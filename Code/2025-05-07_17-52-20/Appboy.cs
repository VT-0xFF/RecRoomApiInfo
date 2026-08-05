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
	[Cpp2IlInjected.Address(RVA = "0x9F0810", Offset = "0x9EF810", VA = "0x1809F0810")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9F02C0", Offset = "0x9EF2C0", VA = "0x1809F02C0")]
	public string PrintOutObjectValues(object MCLPDKCMLIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9F0210", Offset = "0x9EF210", VA = "0x1809F0210")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0280", Offset = "0x9EF280", VA = "0x1809F0280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CGPAIDCOKGK BPOLMDPLDFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void LogCustomEvent(string AFDMOCAAEDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void LogCustomEvent(string AFDMOCAAEDI, Dictionary<string, object> FBEFHOGBKOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void LogPurchase(string HPNLBFDCAHP, string FDMIBEHPOAH, decimal NBDBEANPNJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void LogPurchase(string HPNLBFDCAHP, string FDMIBEHPOAH, decimal NBDBEANPNJP, int GFNDILIHOFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void LogPurchase(string HPNLBFDCAHP, string FDMIBEHPOAH, decimal NBDBEANPNJP, int GFNDILIHOFK, Dictionary<string, object> FBEFHOGBKOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ChangeUser(string HGNFJDEKKID, [Optional] string NEHLHNFCLNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetSdkAuthenticationSignature(string NEHLHNFCLNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetUserFirstName(string CEPANDCPNKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetUserLastName(string EPGLLHAKLFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetUserEmail(string FFMJGJOALIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetUserGender(LKMPILFIBKG BOOCABAFCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetUserDateOfBirth(int LNAIHGELHGG, int PJDNKOFOBAO, int MFILCFKMOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetUserCountry(string JAPPAIKEBOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetUserHomeCity(string CMGLAEFNHGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetUserEmailNotificationSubscriptionType(MCHGOOKAJDD MKMEEIIAPPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetUserPushNotificationSubscriptionType(MCHGOOKAJDD MMENGBCBJMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetUserPhoneNumber(string PLOEJAFLLOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetCustomUserAttribute(string OEHHKNIGGMI, bool OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetCustomUserAttribute(string OEHHKNIGGMI, int OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetCustomUserAttribute(string OEHHKNIGGMI, float OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetCustomUserAttribute(string OEHHKNIGGMI, string OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetCustomUserAttributeToNow(string OEHHKNIGGMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetCustomUserAttributeToSecondsFromEpoch(string OEHHKNIGGMI, long LCJPNHGPFAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void UnsetCustomUserAttribute(string OEHHKNIGGMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void IncrementCustomUserAttribute(string OEHHKNIGGMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void IncrementCustomUserAttribute(string OEHHKNIGGMI, int EIPGKNNCDKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetCustomUserAttributeArray(string OEHHKNIGGMI, List<string> NBBLCIBNPBK, int CFNMLMNHCMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void AddToCustomUserAttributeArray(string OEHHKNIGGMI, string OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void RemoveFromCustomUserAttributeArray(string OEHHKNIGGMI, string OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void setUserFacebookData(string EEJLKAHNJIJ, string CEPANDCPNKG, string EPGLLHAKLFA, string FFMJGJOALIP, string LKGNCKGPAAD, string DLONFOANGBJ, LKMPILFIBKG? BOOCABAFCCI, int? DGOIMPHJNAF, string IBFJLLIGGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void setUserTwitterData(int? OMPPCJCHLPA, string FECMKNAGOCF, string NFHOBPDKIPM, string HHPFBMBMELN, int? KIDPGGKJFKC, int? DJKHJOJMKJM, int? FFIEHGMBNFM, string HJJGJGPHHMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetUserLastKnownLocation(double GDKDHMMBBBJ, double BCILKAGLBPB, [Optional] double? GLIDLDPJDIF, [Optional] double? MPFJDDEINGO, [Optional] double? EEGDBNDHEBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void PromptUserForPushPermissions(bool JPAMCPNLEMC, [Optional] GLPEELFHAHL NGLEGFGLPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetPushTokenReceivedFromSystemDelegate(PMFBOKINEKE INMKMOGPNIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void LogInAppMessageClicked(string ALAHBOIBBMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void LogInAppMessageImpression(string ALAHBOIBBMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void LogInAppMessageButtonClicked(string ALAHBOIBBMF, int GPFLAGLFCBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void RequestFeedRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void RequestFeedRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void LogFeedDisplayed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void RequestContentCardsRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void RequestContentCardsRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void LogContentCardClicked(string BLFFAOIBJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void LogContentCardImpression(string BLFFAOIBJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void LogContentCardDismissed(string BLFFAOIBJMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void WipeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void EnableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void DisableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230")]
		public static string GetInstallTrackingId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetAttributionData(string HHJCAMMLCNN, string AGBJLPOHMOH, string GKMCAIHGPLF, string JNGJOCMANAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void RequestLocationInitialization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void RequestGeofences(decimal GDKDHMMBBBJ, decimal BCILKAGLBPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void RequestImmediateDataFlush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void AddAlias(string HEONMJDBPIO, string EKPIAKIDDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void ConfigureListener(AJLNDHIDLGN OAOFDBDEHAG, string PEGAPJFPCDM, string OAKFMPLKGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void SetInAppMessageDisplayAction(ODJANNGIMHD PIHIBFDEMJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void DisplayNextInAppMessage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void DisplayContentCards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void AddToSubscriptionGroup(string HJPLNJNIFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
		public static void RemoveFromSubscriptionGroup(string HJPLNJNIFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9F0240", Offset = "0x9EF240", VA = "0x1809F0240")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0190", Offset = "0x9EF190", VA = "0x1809F0190")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9EF220", Offset = "0x9EE220", VA = "0x1809EF220")]
		private void ALPGAMIHIGN(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA70", Offset = "0x9EEA70", VA = "0x1809EFA70")]
		private void KNHKDIJKDDP(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9EF540", Offset = "0x9EE540", VA = "0x1809EF540")]
		private void DAIKMJGHKNM(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0080", Offset = "0x9EF080", VA = "0x1809F0080")]
		private void OMOEKJOMEOO(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9EF960", Offset = "0x9EE960", VA = "0x1809EF960")]
		private void KMBNLAFKMMF(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9EF5B0", Offset = "0x9EE5B0", VA = "0x1809EF5B0")]
		private void HOECDNACDHD(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9EFF20", Offset = "0x9EEF20", VA = "0x1809EFF20")]
		private void OHMIBKBGHIF(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9EF300", Offset = "0x9EE300", VA = "0x1809EF300")]
		private void CNMIDMMHBDF(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9EFAE0", Offset = "0x9EEAE0", VA = "0x1809EFAE0")]
		private void LDFJGIEBAJA(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1B0", Offset = "0x9EE1B0", VA = "0x1809EF1B0")]
		private void AENONELBPCK(string NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9EF710", Offset = "0x9EE710", VA = "0x1809EF710")]
		public static void InAppMessageBeforeDisplayed(KDOBGKIDALP NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9EF870", Offset = "0x9EE870", VA = "0x1809EF870")]
		public static void InAppMessageDismissed(KDOBGKIDALP NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9EF800", Offset = "0x9EE800", VA = "0x1809EF800")]
		public static void InAppMessageClicked(KDOBGKIDALP NAAMEAFIHJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9EF780", Offset = "0x9EE780", VA = "0x1809EF780")]
		public static void InAppMessageButtonClicked(KDOBGKIDALP NAAMEAFIHJI, BFKOKNEHNOC MIEDMJNOLOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9EF8E0", Offset = "0x9EE8E0", VA = "0x1809EF8E0")]
		public static void InAppMessageHTMLClicked(KDOBGKIDALP NAAMEAFIHJI, Uri IJIGBNAIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9F0210", Offset = "0x9EF210", VA = "0x1809F0210")]
		public AppboyBindingTester()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class NLHJKCNGPLN
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x9FED80", Offset = "0x9FDD80", VA = "0x1809FED80")]
	public static string NJABHHPAJOA(Dictionary<string, string> BCFIBNCLPAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3999250", Offset = "0x3998250", VA = "0x183999250")]
	public static string APCFHDBAKLP<T>(List<T> OLEDHEBBJPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ECAPFMKDGHN
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x9F7880", Offset = "0x9F6880", VA = "0x1809F7880")]
	public static Color? KFKDFEPLALA(string HLAHIOBHIML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x9F7580", Offset = "0x9F6580", VA = "0x1809F7580")]
	public static Color KFKDFEPLALA(int HLAHIOBHIML)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BLMGEIMFFML
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9F24F0", Offset = "0x9F14F0", VA = "0x1809F24F0")]
	public static object HBGMKAEOAKP(Type NNODEEMKOHL, string OHLIHBDBKCE, bool JKNAPFDBLHI, object JMMNJNFGHEP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NAGJGNHFBDA
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x9FE790", Offset = "0x9FD790", VA = "0x1809FE790")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F8F50", Offset = "0x9F7F50", VA = "0x1809F8F50")]
		private ENKKKONFBMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9F73F0", Offset = "0x9F63F0", VA = "0x1809F73F0")]
		public static string DFNAEDFOBIJ(object BOMDCGFKGKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9F81E0", Offset = "0x9F71E0", VA = "0x1809F81E0")]
		private void CCJKGOOKJEE(object OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9F83D0", Offset = "0x9F73D0", VA = "0x1809F83D0")]
		private void ELEEPPJEPCO(IDictionary BOMDCGFKGKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9F8D00", Offset = "0x9F7D00", VA = "0x1809F8D00")]
		private void MAHDOIOIEHM(IList NBBLCIBNPBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9F86C0", Offset = "0x9F76C0", VA = "0x1809F86C0")]
		private void GOBPHKJKLFP(string ANKDPLMACBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9F8A00", Offset = "0x9F7A00", VA = "0x1809F8A00")]
		private void IOEGOPNJFHJ(object OHLIHBDBKCE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static NumberFormatInfo JPPMCOMCOEL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x9F73F0", Offset = "0x9F63F0", VA = "0x1809F73F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public virtual PDKDKMGOLAN OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual string FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9FF0A0", Offset = "0x9FE0A0", VA = "0x1809FF0A0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public virtual int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0230", Offset = "0x9EF230", VA = "0x1809F0230", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public virtual int LCANKEKADFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9FFA20", Offset = "0x9FEA20", VA = "0x1809FFA20", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9FEFE0", Offset = "0x9FDFE0", VA = "0x1809FEFE0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual bool LNCLCBFGCIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9FFA60", Offset = "0x9FEA60", VA = "0x1809FFA60", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9FFB10", Offset = "0x9FEB10", VA = "0x1809FFB10", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public virtual KKANGLAMCFI DHMFHDDCNJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9FF0E0", Offset = "0x9FE0E0", VA = "0x1809FF0E0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public virtual EINLAANMACJ AFDJJEADFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9FFEB0", Offset = "0x9FEEB0", VA = "0x1809FFEB0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public virtual void IIGLPCDPOEE(string PNDBIKNIACL, PDKDKMGOLAN HGECMNKLGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x9FF9C0", Offset = "0x9FE9C0", VA = "0x1809FF9C0", Slot = "10")]
	public virtual void IIGLPCDPOEE(PDKDKMGOLAN HGECMNKLGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF30", Offset = "0x9FEF30", VA = "0x1809FFF30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x9FFE40", Offset = "0x9FEE40", VA = "0x1809FFE40")]
	public static PDKDKMGOLAN OIFHDJNIHDL(string AMDHAEEMHLI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9FFDC0", Offset = "0x9FEDC0", VA = "0x1809FFDC0")]
	public static string OIFHDJNIHDL(PDKDKMGOLAN IAEAOGJCDGG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x9FFD40", Offset = "0x9FED40", VA = "0x1809FFD40")]
	public static bool MMJMCICIDNJ(PDKDKMGOLAN FDJHCIBLFFB, object CNIMJCCKEDM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9FF020", Offset = "0x9FE020", VA = "0x1809FF020")]
	public static bool DIKHMNDIIDO(PDKDKMGOLAN FDJHCIBLFFB, object CNIMJCCKEDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x9FF0D0", Offset = "0x9FE0D0", VA = "0x1809FF0D0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9FE0A0", Offset = "0x9FD0A0", VA = "0x1809FE0A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9FFB90", Offset = "0x9FEB90", VA = "0x1809FFB90")]
	internal static string LFKCMHOJDDG(string MDKMGBNODNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9FF160", Offset = "0x9FE160", VA = "0x1809FF160")]
	public static PDKDKMGOLAN GLNDGKKIMDA(string BHCONKCLCCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public NIOIOELGBAP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9FECF0", Offset = "0x9FDCF0", VA = "0x1809FECF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9FEAF0", Offset = "0x9FDAF0", VA = "0x1809FEAF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9FEAA0", Offset = "0x9FDAA0", VA = "0x1809FEAA0")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9FECA0", Offset = "0x9FDCA0", VA = "0x1809FECA0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FD600", Offset = "0x9FC600", VA = "0x1809FD600", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override PDKDKMGOLAN OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9FD6D0", Offset = "0x9FC6D0", VA = "0x1809FD6D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9FD830", Offset = "0x9FC830", VA = "0x1809FD830", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x9FD7D0", Offset = "0x9FC7D0", VA = "0x1809FD7D0", Slot = "4")]
	public override void IIGLPCDPOEE(string PNDBIKNIACL, PDKDKMGOLAN HGECMNKLGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9FD750", Offset = "0x9FC750", VA = "0x1809FD750", Slot = "17")]
	[IteratorStateMachine(typeof(NIOIOELGBAP))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x9FD870", Offset = "0x9FC870", VA = "0x1809FD870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9FDA30", Offset = "0x9FCA30", VA = "0x1809FDA30")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9F28C0", Offset = "0x9F18C0", VA = "0x1809F28C0")]
		[DebuggerHidden]
		public BNHEFJHGEHP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9F2830", Offset = "0x9F1830", VA = "0x1809F2830", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9F25C0", Offset = "0x9F15C0", VA = "0x1809F25C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9F2570", Offset = "0x9F1570", VA = "0x1809F2570")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9F27E0", Offset = "0x9F17E0", VA = "0x1809F27E0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F7A70", Offset = "0x9F6A70", VA = "0x1809F7A70", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override PDKDKMGOLAN OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9F79D0", Offset = "0x9F69D0", VA = "0x1809F79D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9F7CF0", Offset = "0x9F6CF0", VA = "0x1809F7CF0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x9F7BE0", Offset = "0x9F6BE0", VA = "0x1809F7BE0", Slot = "4")]
	public override void IIGLPCDPOEE(string PNDBIKNIACL, PDKDKMGOLAN HGECMNKLGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x9F7B60", Offset = "0x9F6B60", VA = "0x1809F7B60", Slot = "17")]
	[IteratorStateMachine(typeof(BNHEFJHGEHP))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x9F7D40", Offset = "0x9F6D40", VA = "0x1809F7D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9F8150", Offset = "0x9F7150", VA = "0x1809F8150")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	public MOLCIHKLDDA(string EIEOGBNMMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x9FE710", Offset = "0x9FD710", VA = "0x1809FE710")]
	public MOLCIHKLDDA(bool EIEOGBNMMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x9FE750", Offset = "0x9FD750", VA = "0x1809FE750")]
	public MOLCIHKLDDA(int EIEOGBNMMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x9FE680", Offset = "0x9FD680", VA = "0x1809FE680", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FDE60", Offset = "0x9FCE60", VA = "0x1809FDE60", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public override PDKDKMGOLAN OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9FDEE0", Offset = "0x9FCEE0", VA = "0x1809FDEE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override int LCANKEKADFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9FE280", Offset = "0x9FD280", VA = "0x1809FE280", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9FDD80", Offset = "0x9FCD80", VA = "0x1809FDD80", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override bool LNCLCBFGCIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9FE350", Offset = "0x9FD350", VA = "0x1809FE350", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9FE420", Offset = "0x9FD420", VA = "0x1809FE420", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override KKANGLAMCFI DHMFHDDCNJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9FDFF0", Offset = "0x9FCFF0", VA = "0x1809FDFF0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override EINLAANMACJ AFDJJEADFEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9FE500", Offset = "0x9FD500", VA = "0x1809FE500", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x9FE630", Offset = "0x9FD630", VA = "0x1809FE630")]
	public MLPCKFCJMGD(PDKDKMGOLAN DPHPABFMIBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x9FE5E0", Offset = "0x9FD5E0", VA = "0x1809FE5E0")]
	public MLPCKFCJMGD(PDKDKMGOLAN DPHPABFMIBG, string PNDBIKNIACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x9FDF70", Offset = "0x9FCF70", VA = "0x1809FDF70")]
	private void DGBNDJBCMEF(PDKDKMGOLAN JOGHGHKJFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x9FE1A0", Offset = "0x9FD1A0", VA = "0x1809FE1A0", Slot = "10")]
	public override void IIGLPCDPOEE(PDKDKMGOLAN HGECMNKLGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x9FE0B0", Offset = "0x9FD0B0", VA = "0x1809FE0B0", Slot = "4")]
	public override void IIGLPCDPOEE(string PNDBIKNIACL, PDKDKMGOLAN HGECMNKLGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x9FDFE0", Offset = "0x9FCFE0", VA = "0x1809FDFE0", Slot = "0")]
	public override bool Equals(object BOMDCGFKGKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x9FE0A0", Offset = "0x9FD0A0", VA = "0x1809FE0A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x9FE5B0", Offset = "0x9FD5B0", VA = "0x1809FE5B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MDOFFJBHMLJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x9FDD70", Offset = "0x9FCD70", VA = "0x1809FDD70")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int EPENEFAHLKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2290", VA = "0x1809F3290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string HHELPKNHLOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int NLKHEOKLCBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9F0C90", Offset = "0x9EFC90", VA = "0x1809F0C90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CE0", Offset = "0x9EFCE0", VA = "0x1809F0CE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IDictionary<string, object> PFNPEPGILIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x9F40B0", Offset = "0x9F30B0", VA = "0x1809F40B0")]
	public CCPKINKGMMF(EINLAANMACJ JFCMAFFDJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x9F32C0", Offset = "0x9F22C0", VA = "0x1809F32C0")]
	private object NKPJCNINHJG(PDKDKMGOLAN GOJJJBGJPAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x9F39E0", Offset = "0x9F29E0", VA = "0x1809F39E0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string IOBNGFEIHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public string HEMAHGCPDIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public string JNPKPFNEJMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public string MPJEHNDMFII
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x9F5E80", Offset = "0x9F4E80", VA = "0x1809F5E80")]
	public DDAFAGKMLKE(EINLAANMACJ JFCMAFFDJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x9F5A30", Offset = "0x9F4A30", VA = "0x1809F5A30", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool KFNGOBBPNIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9FA1F0", Offset = "0x9F91F0", VA = "0x1809FA1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x9FA450", Offset = "0x9F9450", VA = "0x1809FA450")]
	public FGOKDOLNNPF(string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x9FA200", Offset = "0x9F9200", VA = "0x1809FA200")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string GDDJONJKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string KDFLLFPAOLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Dictionary<string, string> NNIOADDIIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9F5A20", Offset = "0x9F4A20", VA = "0x1809F5A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int DFJMFGNJADJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9F6440", Offset = "0x9F5440", VA = "0x1809F6440")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9F67F0", Offset = "0x9F57F0", VA = "0x1809F67F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public long AHFKHFCIOOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9F6800", Offset = "0x9F5800", VA = "0x1809F6800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string OIPIFAGMGOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9F1580", Offset = "0x9F0580", VA = "0x1809F1580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x9F6CB0", Offset = "0x9F5CB0", VA = "0x1809F6CB0")]
	public DDAFKCJMBII(string NAAMEAFIHJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x9F69B0", Offset = "0x9F59B0", VA = "0x1809F69B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x9F6820", Offset = "0x9F5820", VA = "0x1809F6820")]
	private string KAKOECAGEAP(EINLAANMACJ JFCMAFFDJOP, string OEHHKNIGGMI, string JMMNJNFGHEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x9F6620", Offset = "0x9F5620", VA = "0x1809F6620")]
	private int GANNCOHAGNC(EINLAANMACJ JFCMAFFDJOP, string OEHHKNIGGMI, int JMMNJNFGHEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x9F6450", Offset = "0x9F5450", VA = "0x1809F6450")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F8FD0", Offset = "0x9F7FD0", VA = "0x1809F8FD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9F9090", Offset = "0x9F8090", VA = "0x1809F9090", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Color? BCODMFIMPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9F90A0", Offset = "0x9F80A0", VA = "0x1809F90A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9F9020", Offset = "0x9F8020", VA = "0x1809F9020", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string AGEMJHNOIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9F1500", Offset = "0x9F0500", VA = "0x1809F1500", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Color? OCFGLAAIOOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F9120", Offset = "0x9F8120", VA = "0x1809F9120", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9F9030", Offset = "0x9F8030", VA = "0x1809F9030", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Color? CFDCOFAINHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9F90C0", Offset = "0x9F80C0", VA = "0x1809F90C0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9F9190", Offset = "0x9F8190", VA = "0x1809F9190", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string NNAMCMBBPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9F9180", Offset = "0x9F8180", VA = "0x1809F9180", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9F9080", Offset = "0x9F8080", VA = "0x1809F9080", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string LNILHMKIEOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9F90F0", Offset = "0x9F80F0", VA = "0x1809F90F0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9F9010", Offset = "0x9F8010", VA = "0x1809F9010", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Dictionary<string, string> NNIOADDIIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9F9100", Offset = "0x9F8100", VA = "0x1809F9100", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9F8FF0", Offset = "0x9F7FF0", VA = "0x1809F8FF0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public OGLBDKDFOIG CIPNAGLPMMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9F9110", Offset = "0x9F8110", VA = "0x1809F9110", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(OGLBDKDFOIG);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9F9070", Offset = "0x9F8070", VA = "0x1809F9070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string NHLAPABIJND
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9F9040", Offset = "0x9F8040", VA = "0x1809F9040", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9F9050", Offset = "0x9F8050", VA = "0x1809F9050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public FLDEMPMNOMM KPJNMFPLLOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9F9170", Offset = "0x9F8170", VA = "0x1809F9170", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(FLDEMPMNOMM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9F90E0", Offset = "0x9F80E0", VA = "0x1809F90E0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int GKIGMCHANCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F22A0", VA = "0x1809F32A0", Slot = "24")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9F9140", Offset = "0x9F8140", VA = "0x1809F9140", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x9F91A0", Offset = "0x9F81A0", VA = "0x1809F91A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x9F9780", Offset = "0x9F8780", VA = "0x1809F9780")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string KNHBLAEFJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string NHLAPABIJND
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public OGLBDKDFOIG HADIJPJJCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9F0C90", Offset = "0x9EFC90", VA = "0x1809F0C90")]
		[CompilerGenerated]
		get
		{
			return default(OGLBDKDFOIG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CE0", Offset = "0x9EFCE0", VA = "0x1809F0CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public Color? BCODMFIMPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D00", Offset = "0x9EFD00", VA = "0x1809F0D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CA0", Offset = "0x9EFCA0", VA = "0x1809F0CA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Color? BHEPJIOFCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x9F0C70", Offset = "0x9EFC70", VA = "0x1809F0C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CF0", Offset = "0x9EFCF0", VA = "0x1809F0CF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x9F0D40", Offset = "0x9EFD40", VA = "0x1809F0D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x9F1030", Offset = "0x9F0030", VA = "0x1809F1030")]
	public BFKOKNEHNOC(EINLAANMACJ JFCMAFFDJOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GKBLLHIAHKF
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x9FA990", Offset = "0x9F9990", VA = "0x1809FA990")]
	public static EINLAANMACJ BCCEHFNDFLG(string GKHBFKOHEBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class LNCLAIJHMNA
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x9FDAC0", Offset = "0x9FCAC0", VA = "0x1809FDAC0")]
	public static KDOBGKIDALP CIAINNNFJDO(string ALAHBOIBBMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NNENGLODINL : JLLHIHLLCCF
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x9FA980", Offset = "0x9F9980", VA = "0x1809FA980")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FC4A0", Offset = "0x9FB4A0", VA = "0x1809FC4A0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9FC4C0", Offset = "0x9FB4C0", VA = "0x1809FC4C0", Slot = "28")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Color? CGFBBFLDNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9F5510", Offset = "0x9F4510", VA = "0x1809F5510", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9F54D0", Offset = "0x9F44D0", VA = "0x1809F54D0", Slot = "30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public Color? OGMIIHMKNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9FC4E0", Offset = "0x9FB4E0", VA = "0x1809FC4E0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9FC460", Offset = "0x9FB460", VA = "0x1809FC460", Slot = "32")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public List<BFKOKNEHNOC> JGDFHHCGLLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9FC4B0", Offset = "0x9FB4B0", VA = "0x1809FC4B0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9FC480", Offset = "0x9FB480", VA = "0x1809FC480", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x9FC500", Offset = "0x9FB500", VA = "0x1809FC500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x9FC790", Offset = "0x9FB790", VA = "0x1809FC790")]
	public JLLHIHLLCCF(EINLAANMACJ JFCMAFFDJOP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class GGBEIHIFAND : JLLHIHLLCCF
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x9FA980", Offset = "0x9F9980", VA = "0x1809FA980")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F54B0", Offset = "0x9F44B0", VA = "0x1809F54B0")]
		[CompilerGenerated]
		get
		{
			return default(AGNLEHMGFDA);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9F54F0", Offset = "0x9F44F0", VA = "0x1809F54F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool BLDKFJDODDP
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9F54C0", Offset = "0x9F44C0", VA = "0x1809F54C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9F5500", Offset = "0x9F4500", VA = "0x1809F5500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Color? BKHMKKEKOMN
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9F5510", Offset = "0x9F4510", VA = "0x1809F5510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9F54D0", Offset = "0x9F44D0", VA = "0x1809F54D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x9F5530", Offset = "0x9F4530", VA = "0x1809F5530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x9F5770", Offset = "0x9F4770", VA = "0x1809F5770")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9F46E0", Offset = "0x9F36E0", VA = "0x1809F46E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string DFIGCONFKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9F4710", Offset = "0x9F3710", VA = "0x1809F4710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9F46D0", Offset = "0x9F36D0", VA = "0x1809F46D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string MDJIDHADEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9F46F0", Offset = "0x9F36F0", VA = "0x1809F46F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9F46C0", Offset = "0x9F36C0", VA = "0x1809F46C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x9F48E0", Offset = "0x9F38E0", VA = "0x1809F48E0")]
	public CHAPGMPDNOM(EINLAANMACJ JFCMAFFDJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x9F4720", Offset = "0x9F3720", VA = "0x1809F4720", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9F46E0", Offset = "0x9F36E0", VA = "0x1809F46E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string GDDJONJKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9F4710", Offset = "0x9F3710", VA = "0x1809F4710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9F46D0", Offset = "0x9F36D0", VA = "0x1809F46D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9F46F0", Offset = "0x9F36F0", VA = "0x1809F46F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9F46C0", Offset = "0x9F36C0", VA = "0x1809F46C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string DFIGCONFKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CF0", Offset = "0x9F3CF0", VA = "0x1809F4CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CD0", Offset = "0x9F3CD0", VA = "0x1809F4CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string MDJIDHADEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CE0", Offset = "0x9F3CE0", VA = "0x1809F4CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CC0", Offset = "0x9F3CC0", VA = "0x1809F4CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x9F4F70", Offset = "0x9F3F70", VA = "0x1809F4F70")]
	public CLNNMGJLKHM(EINLAANMACJ JFCMAFFDJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x9F4D00", Offset = "0x9F3D00", VA = "0x1809F4D00", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool BEFOBICDBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1560", Offset = "0x9F0560", VA = "0x1809F1560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1530", Offset = "0x9F0530", VA = "0x1809F1530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public long CIFDELMEPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1790", Offset = "0x9F0790", VA = "0x1809F1790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public long NBLMHKIFOBM
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1520", Offset = "0x9F0520", VA = "0x1809F1520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public HashSet<AAFPPPCNPBP> KOFCNJLJJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private string PIHJBNJGKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9F1580", Offset = "0x9F0580", VA = "0x1809F1580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public Dictionary<string, string> NNIOADDIIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9F1500", Offset = "0x9F0500", VA = "0x1809F1500")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x9F1B50", Offset = "0x9F0B50", VA = "0x1809F1B50")]
	public BKHLPPEDLLA(EINLAANMACJ JFCMAFFDJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x9F17B0", Offset = "0x9F07B0", VA = "0x1809F17B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x9F1590", Offset = "0x9F0590", VA = "0x1809F1590")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9F46E0", Offset = "0x9F36E0", VA = "0x1809F46E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string FJPJCEECAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9F4710", Offset = "0x9F3710", VA = "0x1809F4710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x9F46D0", Offset = "0x9F36D0", VA = "0x1809F46D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public string GDDJONJKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x9F46F0", Offset = "0x9F36F0", VA = "0x1809F46F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x9F46C0", Offset = "0x9F36C0", VA = "0x1809F46C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public string DFIGCONFKFK
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CF0", Offset = "0x9F3CF0", VA = "0x1809F4CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CD0", Offset = "0x9F3CD0", VA = "0x1809F4CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string MDJIDHADEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CE0", Offset = "0x9F3CE0", VA = "0x1809F4CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CC0", Offset = "0x9F3CC0", VA = "0x1809F4CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x9FD000", Offset = "0x9FC000", VA = "0x1809FD000")]
	public KAOKKFDIOGA(EINLAANMACJ JFCMAFFDJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x9FCD90", Offset = "0x9FBD90", VA = "0x1809FCD90", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string KFIKOGBAHMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool BEFOBICDBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9F1560", Offset = "0x9F0560", VA = "0x1809F1560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9F1530", Offset = "0x9F0530", VA = "0x1809F1530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public long CIFDELMEPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1790", Offset = "0x9F0790", VA = "0x1809F1790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public long JCFJOAHBFBK
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1520", Offset = "0x9F0520", VA = "0x1809F1520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public string FJPJCEECAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1770", Offset = "0x9F0770", VA = "0x1809F1770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string GDDJONJKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9F1580", Offset = "0x9F0580", VA = "0x1809F1580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9F1500", Offset = "0x9F0500", VA = "0x1809F1500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public string DFIGCONFKFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9F46E0", Offset = "0x9F36E0", VA = "0x1809F46E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public string MDJIDHADEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9F4710", Offset = "0x9F3710", VA = "0x1809F4710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9F46D0", Offset = "0x9F36D0", VA = "0x1809F46D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public bool IPLEFOGFCOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9FACA0", Offset = "0x9F9CA0", VA = "0x1809FACA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9FAC90", Offset = "0x9F9C90", VA = "0x1809FAC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool LJHLLLLIIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9FAC60", Offset = "0x9F9C60", VA = "0x1809FAC60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9FACB0", Offset = "0x9F9CB0", VA = "0x1809FACB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool HEKJHLJHDPK
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9FAC80", Offset = "0x9F9C80", VA = "0x1809FAC80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9FACD0", Offset = "0x9F9CD0", VA = "0x1809FACD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool PKDPOKCGOGL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9FAC70", Offset = "0x9F9C70", VA = "0x1809FAC70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9FACF0", Offset = "0x9F9CF0", VA = "0x1809FACF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool HCNHKDOEBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9FACE0", Offset = "0x9F9CE0", VA = "0x1809FACE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9FACC0", Offset = "0x9F9CC0", VA = "0x1809FACC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public string PIHJBNJGKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CF0", Offset = "0x9F3CF0", VA = "0x1809F4CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CD0", Offset = "0x9F3CD0", VA = "0x1809F4CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public Dictionary<string, string> NNIOADDIIKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CE0", Offset = "0x9F3CE0", VA = "0x1809F4CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CC0", Offset = "0x9F3CC0", VA = "0x1809F4CC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x9FB480", Offset = "0x9FA480", VA = "0x1809FB480")]
	public HOPFJBKOJIP(EINLAANMACJ JFCMAFFDJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x9FADA0", Offset = "0x9F9DA0", VA = "0x1809FADA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x9FAD00", Offset = "0x9F9D00", VA = "0x1809FAD00")]
	public void NLHDCGMJFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x9FABC0", Offset = "0x9F9BC0", VA = "0x1809FABC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9F46E0", Offset = "0x9F36E0", VA = "0x1809F46E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public string BPBACGJDGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9F4710", Offset = "0x9F3710", VA = "0x1809F4710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9F46D0", Offset = "0x9F36D0", VA = "0x1809F46D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public string DFIGCONFKFK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9F46F0", Offset = "0x9F36F0", VA = "0x1809F46F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9F46C0", Offset = "0x9F36C0", VA = "0x1809F46C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string MDJIDHADEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CF0", Offset = "0x9F3CF0", VA = "0x1809F4CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9F4CD0", Offset = "0x9F3CD0", VA = "0x1809F4CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x9FBF70", Offset = "0x9FAF70", VA = "0x1809FBF70")]
	public JECGEFBDNPM(EINLAANMACJ JFCMAFFDJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x9FBD50", Offset = "0x9FAD50", VA = "0x1809FBD50", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		public void setPushPromptResponseReceivedDelegate(GLPEELFHAHL NGLEGFGLPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
		public void setPushTokenReceivedFromSystemDelegate(PMFBOKINEKE NGLEGFGLPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9F2F90", Offset = "0x9F1F90", VA = "0x1809F2F90")]
		public void onPushPromptResponseReceived(string CGKDHHEHGIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9F3000", Offset = "0x9F2000", VA = "0x1809F3000")]
		public void onPushTokenReceivedFromSystem(string EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x9F28F0", Offset = "0x9F18F0", VA = "0x1809F28F0")]
		public void beforeInAppMessageDisplayed(string GLLKGIFOBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9F2CB0", Offset = "0x9F1CB0", VA = "0x1809F2CB0")]
		public void onInAppMessageDismissed(string GLLKGIFOBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9F2C50", Offset = "0x9F1C50", VA = "0x1809F2C50")]
		public void onInAppMessageClicked(string GLLKGIFOBCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9F2950", Offset = "0x9F1950", VA = "0x1809F2950")]
		public void onInAppMessageButtonClicked(string IMFOOCIMHCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9F2D10", Offset = "0x9F1D10", VA = "0x1809F2D10")]
		public void onInAppMessageHTMLClicked(string IMFOOCIMHCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0210", Offset = "0x9EF210", VA = "0x1809F0210")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F3020", Offset = "0x9F2020", VA = "0x1809F3020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9F31D0", Offset = "0x9F21D0", VA = "0x1809F31D0")]
		public static void setPushPromptResponseReceivedDelegate(GLPEELFHAHL NGLEGFGLPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9F3230", Offset = "0x9F2230", VA = "0x1809F3230")]
		public static void setPushTokenReceivedFromSystemDelegate(PMFBOKINEKE NGLEGFGLPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9F3170", Offset = "0x9F2170", VA = "0x1809F3170")]
		public static void setInAppMessageListener(CGPAIDCOKGK BPOLMDPLDFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9F0210", Offset = "0x9EF210", VA = "0x1809F0210")]
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
