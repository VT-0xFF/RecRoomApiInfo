using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DDJFLOCGBNH
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ApplePushNotificationTester : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9EA810", Offset = "0x9E8E10", VA = "0x1809EA810")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9EA2C0", Offset = "0x9E88C0", VA = "0x1809EA2C0")]
	public string PrintOutObjectValues(object MCLPDKCMLIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
	public ApplePushNotificationTester()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum AJLNDHIDLGN
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
public enum ODJANNGIMHD
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	IAM_DISPLAY_NOW,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	IAM_DISPLAY_LATER,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	IAM_DISCARD
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void GLPEELFHAHL(bool GLFPDNBECEB);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void PMFBOKINEKE(string EJJDDFFADPC);
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AppboyBinding : SingletonMonoBehaviour<AppboyBinding>
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static DDJFLOCGBNH KGBGEMINJIB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static DDJFLOCGBNH NAPEDOJADHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9EA280", Offset = "0x9E8880", VA = "0x1809EA280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CGPAIDCOKGK BPOLMDPLDFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void LogCustomEvent(string AFDMOCAAEDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void LogCustomEvent(string AFDMOCAAEDI, Dictionary<string, object> FBEFHOGBKOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void LogPurchase(string HPNLBFDCAHP, string FDMIBEHPOAH, decimal NBDBEANPNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void LogPurchase(string HPNLBFDCAHP, string FDMIBEHPOAH, decimal NBDBEANPNJP, int GFNDILIHOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void LogPurchase(string HPNLBFDCAHP, string FDMIBEHPOAH, decimal NBDBEANPNJP, int GFNDILIHOFK, Dictionary<string, object> FBEFHOGBKOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ChangeUser(string HGNFJDEKKID, [Optional] string NEHLHNFCLNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetSdkAuthenticationSignature(string NEHLHNFCLNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetUserFirstName(string CEPANDCPNKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetUserLastName(string EPGLLHAKLFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetUserEmail(string FFMJGJOALIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetUserGender(LKMPILFIBKG BOOCABAFCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetUserDateOfBirth(int LNAIHGELHGG, int PJDNKOFOBAO, int MFILCFKMOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetUserCountry(string JAPPAIKEBOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetUserHomeCity(string CMGLAEFNHGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetUserEmailNotificationSubscriptionType(MCHGOOKAJDD MKMEEIIAPPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetUserPushNotificationSubscriptionType(MCHGOOKAJDD MMENGBCBJMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetUserPhoneNumber(string PLOEJAFLLOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetCustomUserAttribute(string OEHHKNIGGMI, bool OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetCustomUserAttribute(string OEHHKNIGGMI, int OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetCustomUserAttribute(string OEHHKNIGGMI, float OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetCustomUserAttribute(string OEHHKNIGGMI, string OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetCustomUserAttributeToNow(string OEHHKNIGGMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetCustomUserAttributeToSecondsFromEpoch(string OEHHKNIGGMI, long LCJPNHGPFAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void UnsetCustomUserAttribute(string OEHHKNIGGMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void IncrementCustomUserAttribute(string OEHHKNIGGMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void IncrementCustomUserAttribute(string OEHHKNIGGMI, int EIPGKNNCDKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetCustomUserAttributeArray(string OEHHKNIGGMI, List<string> NBBLCIBNPBK, int CFNMLMNHCMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void AddToCustomUserAttributeArray(string OEHHKNIGGMI, string OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void RemoveFromCustomUserAttributeArray(string OEHHKNIGGMI, string OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void setUserFacebookData(string EEJLKAHNJIJ, string CEPANDCPNKG, string EPGLLHAKLFA, string FFMJGJOALIP, string LKGNCKGPAAD, string DLONFOANGBJ, LKMPILFIBKG? BOOCABAFCCI, int? DGOIMPHJNAF, string IBFJLLIGGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void setUserTwitterData(int? OMPPCJCHLPA, string FECMKNAGOCF, string NFHOBPDKIPM, string HHPFBMBMELN, int? KIDPGGKJFKC, int? DJKHJOJMKJM, int? FFIEHGMBNFM, string HJJGJGPHHMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetUserLastKnownLocation(double GDKDHMMBBBJ, double BCILKAGLBPB, [Optional] double? GLIDLDPJDIF, [Optional] double? MPFJDDEINGO, [Optional] double? EEGDBNDHEBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void PromptUserForPushPermissions(bool JPAMCPNLEMC, [Optional] GLPEELFHAHL NGLEGFGLPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetPushTokenReceivedFromSystemDelegate(PMFBOKINEKE INMKMOGPNIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void LogInAppMessageClicked(string ALAHBOIBBMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void LogInAppMessageImpression(string ALAHBOIBBMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void LogInAppMessageButtonClicked(string ALAHBOIBBMF, int GPFLAGLFCBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void RequestFeedRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void RequestFeedRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void LogFeedDisplayed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void RequestContentCardsRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void RequestContentCardsRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void LogContentCardClicked(string BLFFAOIBJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void LogContentCardImpression(string BLFFAOIBJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void LogContentCardDismissed(string BLFFAOIBJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void WipeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void EnableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void DisableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230")]
		public static string GetInstallTrackingId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetAttributionData(string HHJCAMMLCNN, string AGBJLPOHMOH, string GKMCAIHGPLF, string JNGJOCMANAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void RequestLocationInitialization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void RequestGeofences(decimal GDKDHMMBBBJ, decimal BCILKAGLBPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void RequestImmediateDataFlush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void AddAlias(string HEONMJDBPIO, string EKPIAKIDDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void ConfigureListener(AJLNDHIDLGN OAOFDBDEHAG, string PEGAPJFPCDM, string OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void SetInAppMessageDisplayAction(ODJANNGIMHD PIHIBFDEMJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void DisplayNextInAppMessage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void DisplayContentCards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void AddToSubscriptionGroup(string HJPLNJNIFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220")]
		public static void RemoveFromSubscriptionGroup(string HJPLNJNIFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9EA240", Offset = "0x9E8840", VA = "0x1809EA240")]
		public AppboyBinding()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CGPAIDCOKGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Action<KDOBGKIDALP> GCAENHECOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Action<KDOBGKIDALP> MIPNOLNOOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Action<KDOBGKIDALP> JJCELBODGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Action<KDOBGKIDALP, BFKOKNEHNOC> MCMNGBBBNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public Action<KDOBGKIDALP, Uri> APMPJBPFDDN;
}
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AppboyBindingTester : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9EA190", Offset = "0x9E8790", VA = "0x1809EA190")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9E9220", Offset = "0x9E7820", VA = "0x1809E9220")]
		private void ALPGAMIHIGN(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9E9A70", Offset = "0x9E8070", VA = "0x1809E9A70")]
		private void KNHKDIJKDDP(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9E9540", Offset = "0x9E7B40", VA = "0x1809E9540")]
		private void DAIKMJGHKNM(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9EA080", Offset = "0x9E8680", VA = "0x1809EA080")]
		private void OMOEKJOMEOO(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9E9960", Offset = "0x9E7F60", VA = "0x1809E9960")]
		private void KMBNLAFKMMF(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9E95B0", Offset = "0x9E7BB0", VA = "0x1809E95B0")]
		private void HOECDNACDHD(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9E9F20", Offset = "0x9E8520", VA = "0x1809E9F20")]
		private void OHMIBKBGHIF(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9E9300", Offset = "0x9E7900", VA = "0x1809E9300")]
		private void CNMIDMMHBDF(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9E9AE0", Offset = "0x9E80E0", VA = "0x1809E9AE0")]
		private void LDFJGIEBAJA(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9E91B0", Offset = "0x9E77B0", VA = "0x1809E91B0")]
		private void AENONELBPCK(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9E9710", Offset = "0x9E7D10", VA = "0x1809E9710")]
		public static void InAppMessageBeforeDisplayed(KDOBGKIDALP NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9E9870", Offset = "0x9E7E70", VA = "0x1809E9870")]
		public static void InAppMessageDismissed(KDOBGKIDALP NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9E9800", Offset = "0x9E7E00", VA = "0x1809E9800")]
		public static void InAppMessageClicked(KDOBGKIDALP NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9E9780", Offset = "0x9E7D80", VA = "0x1809E9780")]
		public static void InAppMessageButtonClicked(KDOBGKIDALP NAAMEAFIHJI, BFKOKNEHNOC MIEDMJNOLOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9E98E0", Offset = "0x9E7EE0", VA = "0x1809E98E0")]
		public static void InAppMessageHTMLClicked(KDOBGKIDALP NAAMEAFIHJI, Uri IJIGBNAIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public AppboyBindingTester()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class NLHJKCNGPLN
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x9F8D70", Offset = "0x9F7370", VA = "0x1809F8D70")]
	public static string NJABHHPAJOA(Dictionary<string, string> BCFIBNCLPAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x39B5800", Offset = "0x39B3E00", VA = "0x1839B5800")]
	public static string APCFHDBAKLP<T>(List<T> OLEDHEBBJPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ECAPFMKDGHN
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x9F18A0", Offset = "0x9EFEA0", VA = "0x1809F18A0")]
	public static Color? KFKDFEPLALA(string HLAHIOBHIML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x9F15B0", Offset = "0x9EFBB0", VA = "0x1809F15B0")]
	public static Color KFKDFEPLALA(int HLAHIOBHIML)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BLMGEIMFFML
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9EC500", Offset = "0x9EAB00", VA = "0x1809EC500")]
	public static object HBGMKAEOAKP(Type NNODEEMKOHL, string OHLIHBDBKCE, bool JKNAPFDBLHI, object JMMNJNFGHEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NAGJGNHFBDA
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x9F8790", Offset = "0x9F6D90", VA = "0x1809F8790")]
	public static Dictionary<string, string> LJGNMMHBAII(EINLAANMACJ JFCMAFFDJOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DOGLGCPGHPP
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class ENKKKONFBMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private StringBuilder KBOCLOKOKJF;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9F2F50", Offset = "0x9F1550", VA = "0x1809F2F50")]
		private ENKKKONFBMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9F1420", Offset = "0x9EFA20", VA = "0x1809F1420")]
		public static string DFNAEDFOBIJ(object BOMDCGFKGKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9F21F0", Offset = "0x9F07F0", VA = "0x1809F21F0")]
		private void CCJKGOOKJEE(object OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9F23E0", Offset = "0x9F09E0", VA = "0x1809F23E0")]
		private void ELEEPPJEPCO(IDictionary BOMDCGFKGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9F2D00", Offset = "0x9F1300", VA = "0x1809F2D00")]
		private void MAHDOIOIEHM(IList NBBLCIBNPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9F26D0", Offset = "0x9F0CD0", VA = "0x1809F26D0")]
		private void GOBPHKJKLFP(string ANKDPLMACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9F2A10", Offset = "0x9F1010", VA = "0x1809F2A10")]
		private void IOEGOPNJFHJ(object OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static NumberFormatInfo JPPMCOMCOEL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x9F1420", Offset = "0x9EFA20", VA = "0x1809F1420")]
	public static string DFNAEDFOBIJ(object BOMDCGFKGKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public class PDKDKMGOLAN
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public virtual PDKDKMGOLAN OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public virtual PDKDKMGOLAN OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual string FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9F9090", Offset = "0x9F7690", VA = "0x1809F9090", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public virtual int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public virtual int LCANKEKADFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A20", Offset = "0x9F8020", VA = "0x1809F9A20", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9F8FD0", Offset = "0x9F75D0", VA = "0x1809F8FD0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual bool LNCLCBFGCIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9F9A60", Offset = "0x9F8060", VA = "0x1809F9A60", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9F9B10", Offset = "0x9F8110", VA = "0x1809F9B10", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public virtual KKANGLAMCFI DHMFHDDCNJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9F90D0", Offset = "0x9F76D0", VA = "0x1809F90D0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public virtual EINLAANMACJ AFDJJEADFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9F9EB0", Offset = "0x9F84B0", VA = "0x1809F9EB0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public virtual void IIGLPCDPOEE(string PNDBIKNIACL, PDKDKMGOLAN HGECMNKLGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x9F99C0", Offset = "0x9F7FC0", VA = "0x1809F99C0", Slot = "10")]
	public virtual void IIGLPCDPOEE(PDKDKMGOLAN HGECMNKLGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F30", Offset = "0x9F8530", VA = "0x1809F9F30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x9F9E40", Offset = "0x9F8440", VA = "0x1809F9E40")]
	public static PDKDKMGOLAN OIFHDJNIHDL(string AMDHAEEMHLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9F9DC0", Offset = "0x9F83C0", VA = "0x1809F9DC0")]
	public static string OIFHDJNIHDL(PDKDKMGOLAN IAEAOGJCDGG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x9F9D40", Offset = "0x9F8340", VA = "0x1809F9D40")]
	public static bool MMJMCICIDNJ(PDKDKMGOLAN FDJHCIBLFFB, object CNIMJCCKEDM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9F9010", Offset = "0x9F7610", VA = "0x1809F9010")]
	public static bool DIKHMNDIIDO(PDKDKMGOLAN FDJHCIBLFFB, object CNIMJCCKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x9F90C0", Offset = "0x9F76C0", VA = "0x1809F90C0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9F80A0", Offset = "0x9F66A0", VA = "0x1809F80A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9F9B90", Offset = "0x9F8190", VA = "0x1809F9B90")]
	internal static string LFKCMHOJDDG(string MDKMGBNODNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9F9150", Offset = "0x9F7750", VA = "0x1809F9150")]
	public static PDKDKMGOLAN GLNDGKKIMDA(string BHCONKCLCCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PDKDKMGOLAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DefaultMember("Item")]
public class KKANGLAMCFI : PDKDKMGOLAN, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class NIOIOELGBAP : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public KKANGLAMCFI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<PDKDKMGOLAN>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public NIOIOELGBAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9F8CE0", Offset = "0x9F72E0", VA = "0x1809F8CE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9F8AE0", Offset = "0x9F70E0", VA = "0x1809F8AE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9F8A90", Offset = "0x9F7090", VA = "0x1809F8A90")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9F8C90", Offset = "0x9F7290", VA = "0x1809F8C90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<PDKDKMGOLAN> GOPLPLOIDII;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override PDKDKMGOLAN OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9F7600", Offset = "0x9F5C00", VA = "0x1809F7600", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override PDKDKMGOLAN OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9F76D0", Offset = "0x9F5CD0", VA = "0x1809F76D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9F7830", Offset = "0x9F5E30", VA = "0x1809F7830", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x9F77D0", Offset = "0x9F5DD0", VA = "0x1809F77D0", Slot = "4")]
	public override void IIGLPCDPOEE(string PNDBIKNIACL, PDKDKMGOLAN HGECMNKLGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9F7750", Offset = "0x9F5D50", VA = "0x1809F7750", Slot = "17")]
	[IteratorStateMachine(typeof(NIOIOELGBAP))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x9F7870", Offset = "0x9F5E70", VA = "0x1809F7870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9F7A30", Offset = "0x9F6030", VA = "0x1809F7A30")]
	public KKANGLAMCFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class EINLAANMACJ : PDKDKMGOLAN, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class BNHEFJHGEHP : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public EINLAANMACJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Dictionary<string, PDKDKMGOLAN>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9EC8D0", Offset = "0x9EAED0", VA = "0x1809EC8D0")]
		[DebuggerHidden]
		public BNHEFJHGEHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9EC840", Offset = "0x9EAE40", VA = "0x1809EC840", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9EC5D0", Offset = "0x9EABD0", VA = "0x1809EC5D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9EC580", Offset = "0x9EAB80", VA = "0x1809EC580")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9EC7F0", Offset = "0x9EADF0", VA = "0x1809EC7F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Dictionary<string, PDKDKMGOLAN> FHIFNHMAEIN;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override PDKDKMGOLAN OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1A90", Offset = "0x9F0090", VA = "0x1809F1A90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override PDKDKMGOLAN OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9F19F0", Offset = "0x9EFFF0", VA = "0x1809F19F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1D10", Offset = "0x9F0310", VA = "0x1809F1D10", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x9F1C00", Offset = "0x9F0200", VA = "0x1809F1C00", Slot = "4")]
	public override void IIGLPCDPOEE(string PNDBIKNIACL, PDKDKMGOLAN HGECMNKLGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x9F1B80", Offset = "0x9F0180", VA = "0x1809F1B80", Slot = "17")]
	[IteratorStateMachine(typeof(BNHEFJHGEHP))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x9F1D60", Offset = "0x9F0360", VA = "0x1809F1D60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9F2160", Offset = "0x9F0760", VA = "0x1809F2160")]
	public EINLAANMACJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MOLCIHKLDDA : PDKDKMGOLAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private string CMDHILJIPPC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public override string FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public MOLCIHKLDDA(string EIEOGBNMMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x9F8710", Offset = "0x9F6D10", VA = "0x1809F8710")]
	public MOLCIHKLDDA(bool EIEOGBNMMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x9F8750", Offset = "0x9F6D50", VA = "0x1809F8750")]
	public MOLCIHKLDDA(int EIEOGBNMMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x9F8680", Offset = "0x9F6C80", VA = "0x1809F8680", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
internal class MLPCKFCJMGD : PDKDKMGOLAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private PDKDKMGOLAN BCFMPMFIMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private string OJLALKHBJPH;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public override PDKDKMGOLAN OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9F7E60", Offset = "0x9F6460", VA = "0x1809F7E60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public override PDKDKMGOLAN OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9F7EE0", Offset = "0x9F64E0", VA = "0x1809F7EE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override int LCANKEKADFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9F8280", Offset = "0x9F6880", VA = "0x1809F8280", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9F7D80", Offset = "0x9F6380", VA = "0x1809F7D80", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override bool LNCLCBFGCIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9F8350", Offset = "0x9F6950", VA = "0x1809F8350", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9F8420", Offset = "0x9F6A20", VA = "0x1809F8420", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override KKANGLAMCFI DHMFHDDCNJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9F7FF0", Offset = "0x9F65F0", VA = "0x1809F7FF0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override EINLAANMACJ AFDJJEADFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9F8500", Offset = "0x9F6B00", VA = "0x1809F8500", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x9F8630", Offset = "0x9F6C30", VA = "0x1809F8630")]
	public MLPCKFCJMGD(PDKDKMGOLAN DPHPABFMIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x9F85E0", Offset = "0x9F6BE0", VA = "0x1809F85E0")]
	public MLPCKFCJMGD(PDKDKMGOLAN DPHPABFMIBG, string PNDBIKNIACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x9F7F70", Offset = "0x9F6570", VA = "0x1809F7F70")]
	private void DGBNDJBCMEF(PDKDKMGOLAN JOGHGHKJFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x9F81A0", Offset = "0x9F67A0", VA = "0x1809F81A0", Slot = "10")]
	public override void IIGLPCDPOEE(PDKDKMGOLAN HGECMNKLGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x9F80B0", Offset = "0x9F66B0", VA = "0x1809F80B0", Slot = "4")]
	public override void IIGLPCDPOEE(string PNDBIKNIACL, PDKDKMGOLAN HGECMNKLGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x9F7FE0", Offset = "0x9F65E0", VA = "0x1809F7FE0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x9F80A0", Offset = "0x9F66A0", VA = "0x1809F80A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x9F85B0", Offset = "0x9F6BB0", VA = "0x1809F85B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MDOFFJBHMLJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x9F7D70", Offset = "0x9F6370", VA = "0x1809F7D70")]
	public static PDKDKMGOLAN GLNDGKKIMDA(string BHCONKCLCCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum MCHGOOKAJDD
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	OPTED_IN,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	SUBSCRIBED,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	UNSUBSCRIBED
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CCPKINKGMMF
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public DDAFAGKMLKE NOEFBLGOPAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int EPENEFAHLKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9ED290", Offset = "0x9EB890", VA = "0x1809ED290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string HHELPKNHLOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int NLKHEOKLCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9EACE0", Offset = "0x9E92E0", VA = "0x1809EACE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IDictionary<string, object> PFNPEPGILIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x9EE0A0", Offset = "0x9EC6A0", VA = "0x1809EE0A0")]
	public CCPKINKGMMF(EINLAANMACJ JFCMAFFDJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x9ED2C0", Offset = "0x9EB8C0", VA = "0x1809ED2C0")]
	private object NKPJCNINHJG(PDKDKMGOLAN GOJJJBGJPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x9ED9F0", Offset = "0x9EBFF0", VA = "0x1809ED9F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DDAFAGKMLKE
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IList<string> EBFIJHODJNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string IOBNGFEIHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public string HEMAHGCPDIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public string JNPKPFNEJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public string MPJEHNDMFII
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x9EFE60", Offset = "0x9EE460", VA = "0x1809EFE60")]
	public DDAFAGKMLKE(EINLAANMACJ JFCMAFFDJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x9EFA20", Offset = "0x9EE020", VA = "0x1809EFA20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum AAFPPPCNPBP
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	ADVERTISING,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	ANNOUNCEMENTS,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	NEWS,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	SOCIAL,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	NO_CATEGORY
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum OGLBDKDFOIG
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	NEWS_FEED,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	URI,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	NONE
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum FLDEMPMNOMM
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	AUTO_DISMISS,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	SWIPE
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FGOKDOLNNPF
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public List<BKHLPPEDLLA> APBFPOEPKNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool KFNGOBBPNIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9F41E0", Offset = "0x9F27E0", VA = "0x1809F41E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x9F4440", Offset = "0x9F2A40", VA = "0x1809F4440")]
	public FGOKDOLNNPF(string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x9F41F0", Offset = "0x9F27F0", VA = "0x1809F41F0")]
	private static BKHLPPEDLLA JIGNGOADHJE(EINLAANMACJ JFCMAFFDJOP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum LKMPILFIBKG
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	Male,
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	Female,
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	Other,
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	Unknown,
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	NotApplicable,
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	PreferNotToSay
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DDAFKCJMBII
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string NBOECIKHPNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string GDDJONJKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string KDFLLFPAOLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Dictionary<string, string> NNIOADDIIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA10", Offset = "0x9EE010", VA = "0x1809EFA10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int DFJMFGNJADJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9F0430", Offset = "0x9EEA30", VA = "0x1809F0430")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9F0800", Offset = "0x9EEE00", VA = "0x1809F0800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public long AHFKHFCIOOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9F0810", Offset = "0x9EEE10", VA = "0x1809F0810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string OIPIFAGMGOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9EB580", Offset = "0x9E9B80", VA = "0x1809EB580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EF2C0", VA = "0x1809F0CC0")]
	public DDAFKCJMBII(string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x9F09D0", Offset = "0x9EEFD0", VA = "0x1809F09D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x9F0830", Offset = "0x9EEE30", VA = "0x1809F0830")]
	private string KAKOECAGEAP(EINLAANMACJ JFCMAFFDJOP, string OEHHKNIGGMI, string JMMNJNFGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x9F0620", Offset = "0x9EEC20", VA = "0x1809F0620")]
	private int GANNCOHAGNC(EINLAANMACJ JFCMAFFDJOP, string OEHHKNIGGMI, int JMMNJNFGHEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x9F0440", Offset = "0x9EEA40", VA = "0x1809F0440")]
	private long CAAAIIAJPFG(EINLAANMACJ JFCMAFFDJOP, string OEHHKNIGGMI, long JMMNJNFGHEP)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum AGNLEHMGFDA
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	TOP,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	BOTTOM
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface KDOBGKIDALP
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface GFDNNEEHIGD
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	List<BFKOKNEHNOC> JGDFHHCGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class FBGJMCKGBNK : KDOBGKIDALP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected string HHLLMHDKNFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int OFDEIHIAFPK;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Color? BHEPJIOFCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9F2FD0", Offset = "0x9F15D0", VA = "0x1809F2FD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9F3090", Offset = "0x9F1690", VA = "0x1809F3090", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Color? BCODMFIMPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9F30A0", Offset = "0x9F16A0", VA = "0x1809F30A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9F3020", Offset = "0x9F1620", VA = "0x1809F3020", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string AGEMJHNOIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9EB500", Offset = "0x9E9B00", VA = "0x1809EB500", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Color? OCFGLAAIOOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F3120", Offset = "0x9F1720", VA = "0x1809F3120", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9F3030", Offset = "0x9F1630", VA = "0x1809F3030", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Color? CFDCOFAINHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9F30C0", Offset = "0x9F16C0", VA = "0x1809F30C0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9F3190", Offset = "0x9F1790", VA = "0x1809F3190", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string NNAMCMBBPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9F3180", Offset = "0x9F1780", VA = "0x1809F3180", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9F3080", Offset = "0x9F1680", VA = "0x1809F3080", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string LNILHMKIEOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9F30F0", Offset = "0x9F16F0", VA = "0x1809F30F0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9F3010", Offset = "0x9F1610", VA = "0x1809F3010", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Dictionary<string, string> NNIOADDIIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9F3100", Offset = "0x9F1700", VA = "0x1809F3100", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9F2FF0", Offset = "0x9F15F0", VA = "0x1809F2FF0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public OGLBDKDFOIG CIPNAGLPMMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9F3110", Offset = "0x9F1710", VA = "0x1809F3110", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(OGLBDKDFOIG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9F3070", Offset = "0x9F1670", VA = "0x1809F3070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string NHLAPABIJND
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9F3040", Offset = "0x9F1640", VA = "0x1809F3040", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9F3050", Offset = "0x9F1650", VA = "0x1809F3050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public FLDEMPMNOMM KPJNMFPLLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9F3170", Offset = "0x9F1770", VA = "0x1809F3170", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(FLDEMPMNOMM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9F30E0", Offset = "0x9F16E0", VA = "0x1809F30E0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int GKIGMCHANCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0", Slot = "24")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9F3140", Offset = "0x9F1740", VA = "0x1809F3140", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x9F31A0", Offset = "0x9F17A0", VA = "0x1809F31A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x9F3750", Offset = "0x9F1D50", VA = "0x1809F3750")]
	public FBGJMCKGBNK(EINLAANMACJ JFCMAFFDJOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BFKOKNEHNOC
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int DGPKFJDPPKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string KNHBLAEFJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string NHLAPABIJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public OGLBDKDFOIG HADIJPJJCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
		[CompilerGenerated]
		get
		{
			return default(OGLBDKDFOIG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x9EACE0", Offset = "0x9E92E0", VA = "0x1809EACE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public Color? BCODMFIMPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD00", Offset = "0x9E9300", VA = "0x1809EAD00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9EACA0", Offset = "0x9E92A0", VA = "0x1809EACA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Color? BHEPJIOFCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x9EAC70", Offset = "0x9E9270", VA = "0x1809EAC70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9EACF0", Offset = "0x9E92F0", VA = "0x1809EACF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x9EAD40", Offset = "0x9E9340", VA = "0x1809EAD40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x9EB020", Offset = "0x9E9620", VA = "0x1809EB020")]
	public BFKOKNEHNOC(EINLAANMACJ JFCMAFFDJOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GKBLLHIAHKF
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x9F4990", Offset = "0x9F2F90", VA = "0x1809F4990")]
	public static EINLAANMACJ BCCEHFNDFLG(string GKHBFKOHEBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class LNCLAIJHMNA
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x9F7AC0", Offset = "0x9F60C0", VA = "0x1809F7AC0")]
	public static KDOBGKIDALP CIAINNNFJDO(string ALAHBOIBBMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NNENGLODINL : JLLHIHLLCCF
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x9F4980", Offset = "0x9F2F80", VA = "0x1809F4980")]
	public NNENGLODINL(EINLAANMACJ JFCMAFFDJOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class JLLHIHLLCCF : FBGJMCKGBNK, GFDNNEEHIGD
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string HIHGALECIBC
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x9F64A0", Offset = "0x9F4AA0", VA = "0x1809F64A0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9F64C0", Offset = "0x9F4AC0", VA = "0x1809F64C0", Slot = "28")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Color? CGFBBFLDNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9EF500", Offset = "0x9EDB00", VA = "0x1809EF500", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9EF4C0", Offset = "0x9EDAC0", VA = "0x1809EF4C0", Slot = "30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public Color? OGMIIHMKNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9F64E0", Offset = "0x9F4AE0", VA = "0x1809F64E0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9F6460", Offset = "0x9F4A60", VA = "0x1809F6460", Slot = "32")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public List<BFKOKNEHNOC> JGDFHHCGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9F64B0", Offset = "0x9F4AB0", VA = "0x1809F64B0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9F6480", Offset = "0x9F4A80", VA = "0x1809F6480", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x9F6500", Offset = "0x9F4B00", VA = "0x1809F6500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x9F6780", Offset = "0x9F4D80", VA = "0x1809F6780")]
	public JLLHIHLLCCF(EINLAANMACJ JFCMAFFDJOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class GGBEIHIFAND : JLLHIHLLCCF
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x9F4980", Offset = "0x9F2F80", VA = "0x1809F4980")]
	public GGBEIHIFAND(EINLAANMACJ JFCMAFFDJOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class CPFJLLNGBDJ : FBGJMCKGBNK
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public AGNLEHMGFDA FGJJIFHPAFD
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9EF4A0", Offset = "0x9EDAA0", VA = "0x1809EF4A0")]
		[CompilerGenerated]
		get
		{
			return default(AGNLEHMGFDA);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9EF4E0", Offset = "0x9EDAE0", VA = "0x1809EF4E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool BLDKFJDODDP
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9EF4B0", Offset = "0x9EDAB0", VA = "0x1809EF4B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9EF4F0", Offset = "0x9EDAF0", VA = "0x1809EF4F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Color? BKHMKKEKOMN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9EF500", Offset = "0x9EDB00", VA = "0x1809EF500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9EF4C0", Offset = "0x9EDAC0", VA = "0x1809EF4C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x9EF520", Offset = "0x9EDB20", VA = "0x1809EF520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x9EF760", Offset = "0x9EDD60", VA = "0x1809EF760")]
	public CPFJLLNGBDJ(EINLAANMACJ JFCMAFFDJOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum PLKBONCCDIG
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	FULL,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	MODAL,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	SLIDEUP
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class CHAPGMPDNOM : BKHLPPEDLLA
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string FJPJCEECAMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6D0", Offset = "0x9ECCD0", VA = "0x1809EE6D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string DFIGCONFKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9EE700", Offset = "0x9ECD00", VA = "0x1809EE700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6C0", Offset = "0x9ECCC0", VA = "0x1809EE6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string MDJIDHADEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6E0", Offset = "0x9ECCE0", VA = "0x1809EE6E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6B0", Offset = "0x9ECCB0", VA = "0x1809EE6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x9EE8D0", Offset = "0x9ECED0", VA = "0x1809EE8D0")]
	public CHAPGMPDNOM(EINLAANMACJ JFCMAFFDJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x9EE710", Offset = "0x9ECD10", VA = "0x1809EE710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class CLNNMGJLKHM : BKHLPPEDLLA
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public string FJPJCEECAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6D0", Offset = "0x9ECCD0", VA = "0x1809EE6D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string GDDJONJKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9EE700", Offset = "0x9ECD00", VA = "0x1809EE700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6C0", Offset = "0x9ECCC0", VA = "0x1809EE6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6E0", Offset = "0x9ECCE0", VA = "0x1809EE6E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6B0", Offset = "0x9ECCB0", VA = "0x1809EE6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string DFIGCONFKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9EECF0", Offset = "0x9ED2F0", VA = "0x1809EECF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9EECD0", Offset = "0x9ED2D0", VA = "0x1809EECD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string MDJIDHADEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9EECE0", Offset = "0x9ED2E0", VA = "0x1809EECE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9EECC0", Offset = "0x9ED2C0", VA = "0x1809EECC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x9EEF50", Offset = "0x9ED550", VA = "0x1809EEF50")]
	public CLNNMGJLKHM(EINLAANMACJ JFCMAFFDJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x9EED00", Offset = "0x9ED300", VA = "0x1809EED00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class BKHLPPEDLLA
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string DHAKPBMFDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool BEFOBICDBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB560", Offset = "0x9E9B60", VA = "0x1809EB560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB530", Offset = "0x9E9B30", VA = "0x1809EB530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public long CIFDELMEPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9EB790", Offset = "0x9E9D90", VA = "0x1809EB790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public long NBLMHKIFOBM
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB520", Offset = "0x9E9B20", VA = "0x1809EB520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public HashSet<AAFPPPCNPBP> KOFCNJLJJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private string PIHJBNJGKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9EB580", Offset = "0x9E9B80", VA = "0x1809EB580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public Dictionary<string, string> NNIOADDIIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9EB500", Offset = "0x9E9B00", VA = "0x1809EB500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB30", Offset = "0x9EA130", VA = "0x1809EBB30")]
	public BKHLPPEDLLA(EINLAANMACJ JFCMAFFDJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x9EB7B0", Offset = "0x9E9DB0", VA = "0x1809EB7B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x9EB590", Offset = "0x9E9B90", VA = "0x1809EB590")]
	public string EMGAOCENOJB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class KAOKKFDIOGA : BKHLPPEDLLA
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6D0", Offset = "0x9ECCD0", VA = "0x1809EE6D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string FJPJCEECAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9EE700", Offset = "0x9ECD00", VA = "0x1809EE700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6C0", Offset = "0x9ECCC0", VA = "0x1809EE6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public string GDDJONJKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6E0", Offset = "0x9ECCE0", VA = "0x1809EE6E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6B0", Offset = "0x9ECCB0", VA = "0x1809EE6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public string DFIGCONFKFK
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x9EECF0", Offset = "0x9ED2F0", VA = "0x1809EECF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9EECD0", Offset = "0x9ED2D0", VA = "0x1809EECD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string MDJIDHADEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9EECE0", Offset = "0x9ED2E0", VA = "0x1809EECE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9EECC0", Offset = "0x9ED2C0", VA = "0x1809EECC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x9F6FE0", Offset = "0x9F55E0", VA = "0x1809F6FE0")]
	public KAOKKFDIOGA(EINLAANMACJ JFCMAFFDJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5390", VA = "0x1809F6D90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class HOPFJBKOJIP
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public string DHAKPBMFDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool BEFOBICDBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9EB560", Offset = "0x9E9B60", VA = "0x1809EB560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9EB530", Offset = "0x9E9B30", VA = "0x1809EB530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public long CIFDELMEPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9EB790", Offset = "0x9E9D90", VA = "0x1809EB790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public long JCFJOAHBFBK
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9EB520", Offset = "0x9E9B20", VA = "0x1809EB520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public string FJPJCEECAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB770", Offset = "0x9E9D70", VA = "0x1809EB770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string GDDJONJKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9EB580", Offset = "0x9E9B80", VA = "0x1809EB580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9EB500", Offset = "0x9E9B00", VA = "0x1809EB500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public string DFIGCONFKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6D0", Offset = "0x9ECCD0", VA = "0x1809EE6D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public string MDJIDHADEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9EE700", Offset = "0x9ECD00", VA = "0x1809EE700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6C0", Offset = "0x9ECCC0", VA = "0x1809EE6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public bool IPLEFOGFCOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CA0", Offset = "0x9F32A0", VA = "0x1809F4CA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9F4C90", Offset = "0x9F3290", VA = "0x1809F4C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool LJHLLLLIIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9F4C60", Offset = "0x9F3260", VA = "0x1809F4C60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CB0", Offset = "0x9F32B0", VA = "0x1809F4CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool HEKJHLJHDPK
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9F4C80", Offset = "0x9F3280", VA = "0x1809F4C80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CD0", Offset = "0x9F32D0", VA = "0x1809F4CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool PKDPOKCGOGL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9F4C70", Offset = "0x9F3270", VA = "0x1809F4C70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CF0", Offset = "0x9F32F0", VA = "0x1809F4CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool HCNHKDOEBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CE0", Offset = "0x9F32E0", VA = "0x1809F4CE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CC0", Offset = "0x9F32C0", VA = "0x1809F4CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public string PIHJBNJGKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9EECF0", Offset = "0x9ED2F0", VA = "0x1809EECF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9EECD0", Offset = "0x9ED2D0", VA = "0x1809EECD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public Dictionary<string, string> NNIOADDIIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9EECE0", Offset = "0x9ED2E0", VA = "0x1809EECE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9EECC0", Offset = "0x9ED2C0", VA = "0x1809EECC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x9F5450", Offset = "0x9F3A50", VA = "0x1809F5450")]
	public HOPFJBKOJIP(EINLAANMACJ JFCMAFFDJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x9F4DA0", Offset = "0x9F33A0", VA = "0x1809F4DA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x9F4D00", Offset = "0x9F3300", VA = "0x1809F4D00")]
	public void NLHDCGMJFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x9F4BC0", Offset = "0x9F31C0", VA = "0x1809F4BC0")]
	public void AGAAKJOJKOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class JECGEFBDNPM : BKHLPPEDLLA
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public string GDDJONJKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6D0", Offset = "0x9ECCD0", VA = "0x1809EE6D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9EE700", Offset = "0x9ECD00", VA = "0x1809EE700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6C0", Offset = "0x9ECCC0", VA = "0x1809EE6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public string DFIGCONFKFK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6E0", Offset = "0x9ECCE0", VA = "0x1809EE6E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6B0", Offset = "0x9ECCB0", VA = "0x1809EE6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string MDJIDHADEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9EECF0", Offset = "0x9ED2F0", VA = "0x1809EECF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9EECD0", Offset = "0x9ED2D0", VA = "0x1809EECD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x9F5F50", Offset = "0x9F4550", VA = "0x1809F5F50")]
	public JECGEFBDNPM(EINLAANMACJ JFCMAFFDJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x9F5D40", Offset = "0x9F4340", VA = "0x1809F5D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
namespace Appboy.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class BrazeInternalComponent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private GLPEELFHAHL IEKJCHPFFBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private PMFBOKINEKE JCOEOIKDLFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CGPAIDCOKGK iamListener;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		public void setPushPromptResponseReceivedDelegate(GLPEELFHAHL NGLEGFGLPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
		public void setPushTokenReceivedFromSystemDelegate(PMFBOKINEKE NGLEGFGLPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9ECFA0", Offset = "0x9EB5A0", VA = "0x1809ECFA0")]
		public void onPushPromptResponseReceived(string CGKDHHEHGIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9ED010", Offset = "0x9EB610", VA = "0x1809ED010")]
		public void onPushTokenReceivedFromSystem(string EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x9EC900", Offset = "0x9EAF00", VA = "0x1809EC900")]
		public void beforeInAppMessageDisplayed(string GLLKGIFOBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9ECCC0", Offset = "0x9EB2C0", VA = "0x1809ECCC0")]
		public void onInAppMessageDismissed(string GLLKGIFOBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9ECC60", Offset = "0x9EB260", VA = "0x1809ECC60")]
		public void onInAppMessageClicked(string GLLKGIFOBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9EC960", Offset = "0x9EAF60", VA = "0x1809EC960")]
		public void onInAppMessageButtonClicked(string IMFOOCIMHCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9ECD20", Offset = "0x9EB320", VA = "0x1809ECD20")]
		public void onInAppMessageHTMLClicked(string IMFOOCIMHCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
		public BrazeInternalComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class BrazeInternalGameObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static GameObject ELJDCHFNJGK;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private static GameObject MLIJHBGBMKP
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9ED030", Offset = "0x9EB630", VA = "0x1809ED030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9ED1D0", Offset = "0x9EB7D0", VA = "0x1809ED1D0")]
		public static void setPushPromptResponseReceivedDelegate(GLPEELFHAHL NGLEGFGLPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9ED230", Offset = "0x9EB830", VA = "0x1809ED230")]
		public static void setPushTokenReceivedFromSystemDelegate(PMFBOKINEKE NGLEGFGLPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9ED170", Offset = "0x9EB770", VA = "0x1809ED170")]
		public static void setInAppMessageListener(CGPAIDCOKGK BPOLMDPLDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
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
