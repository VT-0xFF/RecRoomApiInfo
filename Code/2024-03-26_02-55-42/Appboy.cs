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
public interface FCODIENAKHM
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ApplePushNotificationTester : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7BD900", Offset = "0x7BCD00", VA = "0x1807BD900")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7BD3A0", Offset = "0x7BC7A0", VA = "0x1807BD3A0")]
	public string PrintOutObjectValues(object NMBHHBODAEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7BD2F0", Offset = "0x7BC6F0", VA = "0x1807BD2F0")]
	public ApplePushNotificationTester()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum DPOHLCFFLAG
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
public enum AGANANIGNLH
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	IAM_DISPLAY_NOW,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	IAM_DISPLAY_LATER,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	IAM_DISCARD
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void AGJOFFDEFAM(bool BNCEBLDPLFK);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void JHEGLOPLAKB(string ICNJFMMNIKL);
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AppboyBinding : SingletonMonoBehaviour<AppboyBinding>
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static FCODIENAKHM KLCABPNNDGO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static FCODIENAKHM JNBCIGFLNAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7BD360", Offset = "0x7BC760", VA = "0x1807BD360")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static KJAILFAPEJL IIHPELOIOIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void LogCustomEvent(string CDEAFAOMLPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void LogCustomEvent(string CDEAFAOMLPK, Dictionary<string, object> NLBEHFCHMJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void LogPurchase(string EPHGFFGFDFC, string CPGIHBAKFCA, decimal KHFGILNBHEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void LogPurchase(string EPHGFFGFDFC, string CPGIHBAKFCA, decimal KHFGILNBHEA, int GEHEIIBAMPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void LogPurchase(string EPHGFFGFDFC, string CPGIHBAKFCA, decimal KHFGILNBHEA, int GEHEIIBAMPL, Dictionary<string, object> NLBEHFCHMJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void ChangeUser(string CIKIAALPDMP, [Optional] string FJPLJOOELHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetSdkAuthenticationSignature(string FJPLJOOELHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetUserFirstName(string BLENDKKJHAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetUserLastName(string EPIBNOGALEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetUserEmail(string BEBJPIBPLPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetUserGender(GHBHOJKFGLA JBNLPIINEEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetUserDateOfBirth(int KGNFCHHGNMI, int PGIGPKPONCF, int KIDLKDMLDPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetUserCountry(string PLMGCKPGIIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetUserHomeCity(string MBHEGEGDGJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetUserEmailNotificationSubscriptionType(MJEGEOIEKDC KIAGLMDAELN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetUserPushNotificationSubscriptionType(MJEGEOIEKDC DPFKPEDNIJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetUserPhoneNumber(string EFFNKOJKHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetCustomUserAttribute(string NIOPCMHKLMB, bool PCGOHCLJAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetCustomUserAttribute(string NIOPCMHKLMB, int PCGOHCLJAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetCustomUserAttribute(string NIOPCMHKLMB, float PCGOHCLJAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetCustomUserAttribute(string NIOPCMHKLMB, string PCGOHCLJAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetCustomUserAttributeToNow(string NIOPCMHKLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetCustomUserAttributeToSecondsFromEpoch(string NIOPCMHKLMB, long NLJAEFNPOHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void UnsetCustomUserAttribute(string NIOPCMHKLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void IncrementCustomUserAttribute(string NIOPCMHKLMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void IncrementCustomUserAttribute(string NIOPCMHKLMB, int IAHPMAPGBHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetCustomUserAttributeArray(string NIOPCMHKLMB, List<string> KGECIFKDBHF, int HIAJHKACHMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void AddToCustomUserAttributeArray(string NIOPCMHKLMB, string PCGOHCLJAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void RemoveFromCustomUserAttributeArray(string NIOPCMHKLMB, string PCGOHCLJAPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void setUserFacebookData(string CEAMIHAPAOA, string BLENDKKJHAG, string EPIBNOGALEL, string BEBJPIBPLPC, string BNDFCIEEHAD, string CFEANBKNJJE, GHBHOJKFGLA? JBNLPIINEEE, int? AOFEIGOAIAL, string OEEJLIIFMCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void setUserTwitterData(int? OHNKKIJJCKB, string BFBIGLKLDJC, string CCNKHEJHFKM, string INBGNCKHOAH, int? PHEIHHKCFNM, int? ODAPAAGAPFG, int? EMMHINHNJEE, string LBIPKDNJJKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetUserLastKnownLocation(double LDOOONFKDKM, double EPHGDAFBFGG, [Optional] double? HEDGPMFJPKN, [Optional] double? PDHENPBOOAD, [Optional] double? FKAJGEGMFJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void PromptUserForPushPermissions(bool KJILHBCBLPG, [Optional] AGJOFFDEFAM KLPCDLOOPDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetPushTokenReceivedFromSystemDelegate(JHEGLOPLAKB AMELDCKLHME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void LogInAppMessageClicked(string MGENNNILBEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void LogInAppMessageImpression(string MGENNNILBEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void LogInAppMessageButtonClicked(string MGENNNILBEE, int HOJGPFNFHBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void RequestFeedRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void RequestFeedRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void LogFeedDisplayed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void RequestContentCardsRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void RequestContentCardsRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void LogContentCardClicked(string EKONJOFNALG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void LogContentCardImpression(string EKONJOFNALG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void LogContentCardDismissed(string EKONJOFNALG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void WipeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void EnableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void DisableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310")]
		public static string GetInstallTrackingId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetAttributionData(string EAPAAHLIFAF, string FPPBCFNKECD, string MLDLCLEFPFE, string AJABLBHGGDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void RequestLocationInitialization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void RequestGeofences(decimal LDOOONFKDKM, decimal EPHGDAFBFGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void RequestImmediateDataFlush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void AddAlias(string FBAMDBICAHK, string BPMLHPFKFKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void ConfigureListener(DPOHLCFFLAG PKAMJGOJLIN, string AAEOIDGKFPD, string PEHEMBLLCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void SetInAppMessageDisplayAction(AGANANIGNLH FFJPBNFJGDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void DisplayNextInAppMessage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void DisplayContentCards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void AddToSubscriptionGroup(string BFMGPLIBCKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300")]
		public static void RemoveFromSubscriptionGroup(string BFMGPLIBCKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7BD320", Offset = "0x7BC720", VA = "0x1807BD320")]
		public AppboyBinding()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class KJAILFAPEJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Action<IABEALNEMCA> HDNONGPHPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Action<IABEALNEMCA> HCHMMAOLFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Action<IABEALNEMCA> CEFIBNNMIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Action<IABEALNEMCA, KGGBCEBKCEH> IMFLDNGNMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public Action<IABEALNEMCA, Uri> ADKLBEBHENJ;
}
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AppboyBindingTester : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7BD270", Offset = "0x7BC670", VA = "0x1807BD270")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7BC6F0", Offset = "0x7BBAF0", VA = "0x1807BC6F0")]
		private void FFIIKFOPGIO(string JEBCFBFPEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7BCF40", Offset = "0x7BC340", VA = "0x1807BCF40")]
		private void JNGLACNHAHI(string JEBCFBFPEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC10", Offset = "0x7BC010", VA = "0x1807BCC10")]
		private void HLKIENGOFHO(string JEBCFBFPEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC5E0", Offset = "0x7BB9E0", VA = "0x1807BC5E0")]
		private void CLJBGOPFKHD(string JEBCFBFPEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC290", Offset = "0x7BB690", VA = "0x1807BC290")]
		private void AOKDHKHEJMD(string JEBCFBFPEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD110", Offset = "0x7BC510", VA = "0x1807BD110")]
		private void NPKNOCCMOGB(string JEBCFBFPEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7BCFB0", Offset = "0x7BC3B0", VA = "0x1807BCFB0")]
		private void LEBKMGMOCNE(string JEBCFBFPEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3A0", Offset = "0x7BB7A0", VA = "0x1807BC3A0")]
		private void BLBNMPGGICC(string JEBCFBFPEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7D0", Offset = "0x7BBBD0", VA = "0x1807BC7D0")]
		private void GAAFPMLMBIN(string JEBCFBFPEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7BCC80", Offset = "0x7BC080", VA = "0x1807BCC80")]
		private void ILHMJPJDHOI(string JEBCFBFPEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7BCCF0", Offset = "0x7BC0F0", VA = "0x1807BCCF0")]
		public static void InAppMessageBeforeDisplayed(IABEALNEMCA JEBCFBFPEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7BCE50", Offset = "0x7BC250", VA = "0x1807BCE50")]
		public static void InAppMessageDismissed(IABEALNEMCA JEBCFBFPEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7BCDE0", Offset = "0x7BC1E0", VA = "0x1807BCDE0")]
		public static void InAppMessageClicked(IABEALNEMCA JEBCFBFPEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7BCD60", Offset = "0x7BC160", VA = "0x1807BCD60")]
		public static void InAppMessageButtonClicked(IABEALNEMCA JEBCFBFPEMG, KGGBCEBKCEH DGEONPPEPFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7BCEC0", Offset = "0x7BC2C0", VA = "0x1807BCEC0")]
		public static void InAppMessageHTMLClicked(IABEALNEMCA JEBCFBFPEMG, Uri BFMACLELGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2F0", Offset = "0x7BC6F0", VA = "0x1807BD2F0")]
		public AppboyBindingTester()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GBLJIFCFDLP
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7C3150", Offset = "0x7C2550", VA = "0x1807C3150")]
	public static string KIGGFEJIOOM(Dictionary<string, string> HIPPGGLCLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x27E3360", Offset = "0x27E2760", VA = "0x1827E3360")]
	public static string BBOAONNJNPM<T>(List<T> OCAIIBKPIPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class KKIBMKGGHKK
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F80", Offset = "0x7C6380", VA = "0x1807C6F80")]
	public static Color? IHJIGLJMGMD(string KKELNOCBAAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C70D0", Offset = "0x7C64D0", VA = "0x1807C70D0")]
	public static Color IHJIGLJMGMD(int KKELNOCBAAH)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PEIIKNDENKD
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7CB1C0", Offset = "0x7CA5C0", VA = "0x1807CB1C0")]
	public static object GPKOKEDNLBI(Type KNAMCLAGDFP, string PCGOHCLJAPN, bool PIHPPPKONPL, object DADBDDPBLHB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MEICILOLBKO
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7C9CC0", Offset = "0x7C90C0", VA = "0x1807C9CC0")]
	public static Dictionary<string, string> CCEGAMFDCKL(PEMINGJECBI CFJODMPHEKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DefaultMember("Item")]
public class DNNKHEDALCG
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public virtual DNNKHEDALCG BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public virtual DNNKHEDALCG BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual string EIHNEEOMIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7BFFE0", Offset = "0x7BF3E0", VA = "0x1807BFFE0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public virtual int ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7BD310", Offset = "0x7BC710", VA = "0x1807BD310", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public virtual int CMNJJMKJMGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7C0050", Offset = "0x7BF450", VA = "0x1807C0050", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7C0010", Offset = "0x7BF410", VA = "0x1807C0010", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual bool NBKCOGCBBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7BFD40", Offset = "0x7BF140", VA = "0x1807BFD40", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7C0090", Offset = "0x7BF490", VA = "0x1807C0090", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public virtual CJAPNEFODPG NPNELINHCKL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7BFC40", Offset = "0x7BF040", VA = "0x1807BFC40", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public virtual PEMINGJECBI GCKGKKMMNPI
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7BFF60", Offset = "0x7BF360", VA = "0x1807BFF60", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "4")]
	public virtual void FFIECPFJEFG(string GODDFGCOKFN, DNNKHEDALCG HNLHEJKNGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7BFCD0", Offset = "0x7BF0D0", VA = "0x1807BFCD0", Slot = "10")]
	public virtual void FFIECPFJEFG(DNNKHEDALCG HNLHEJKNGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A00", Offset = "0x7BFE00", VA = "0x1807C0A00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEF0", Offset = "0x7BF2F0", VA = "0x1807BFEF0")]
	public static DNNKHEDALCG KAHNABMFJPM(string KFCAJGFCMPH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE70", Offset = "0x7BF270", VA = "0x1807BFE70")]
	public static string KAHNABMFJPM(DNNKHEDALCG MFNJPKAPFJG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7BFDF0", Offset = "0x7BF1F0", VA = "0x1807BFDF0")]
	public static bool IDILALBKFJC(DNNKHEDALCG HKHMJOHPMKP, object GJKNLEMINPO)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7C0980", Offset = "0x7BFD80", VA = "0x1807C0980")]
	public static bool PINPHFMGPOK(DNNKHEDALCG HKHMJOHPMKP, object GJKNLEMINPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7BFCC0", Offset = "0x7BF0C0", VA = "0x1807BFCC0", Slot = "0")]
	public override bool Equals(object LIKEKIACGIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7BFD30", Offset = "0x7BF130", VA = "0x1807BFD30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7BFA90", Offset = "0x7BEE90", VA = "0x1807BFA90")]
	internal static string BADCCMJLFDK(string EMCGBDMAHIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7C0110", Offset = "0x7BF510", VA = "0x1807C0110")]
	public static DNNKHEDALCG PIJLNDFCNFJ(string EENIEJJHEFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
	public DNNKHEDALCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DefaultMember("Item")]
public class CJAPNEFODPG : DNNKHEDALCG, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class PNEHGIDKDDP : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public CJAPNEFODPG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<DNNKHEDALCG>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
		[DebuggerHidden]
		public PNEHGIDKDDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7CBC90", Offset = "0x7CB090", VA = "0x1807CBC90", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7CBA90", Offset = "0x7CAE90", VA = "0x1807CBA90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7CBA40", Offset = "0x7CAE40", VA = "0x1807CBA40")]
		private void CLBCIEJIKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7CBC40", Offset = "0x7CB040", VA = "0x1807CBC40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<DNNKHEDALCG> NPFPHGDOGJG;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override DNNKHEDALCG BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7BF650", Offset = "0x7BEA50", VA = "0x1807BF650", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override DNNKHEDALCG BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5D0", Offset = "0x7BE9D0", VA = "0x1807BF5D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override int ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7BF800", Offset = "0x7BEC00", VA = "0x1807BF800", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7BF720", Offset = "0x7BEB20", VA = "0x1807BF720", Slot = "4")]
	public override void FFIECPFJEFG(string GODDFGCOKFN, DNNKHEDALCG HNLHEJKNGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF780", Offset = "0x7BEB80", VA = "0x1807BF780", Slot = "17")]
	[IteratorStateMachine(typeof(PNEHGIDKDDP))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7BF840", Offset = "0x7BEC40", VA = "0x1807BF840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7BFA00", Offset = "0x7BEE00", VA = "0x1807BFA00")]
	public CJAPNEFODPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DefaultMember("Item")]
public class PEMINGJECBI : DNNKHEDALCG, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class KLFDJOIEFLD : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public PEMINGJECBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private Dictionary<string, DNNKHEDALCG>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7C7710", Offset = "0x7C6B10", VA = "0x1807C7710")]
		[DebuggerHidden]
		public KLFDJOIEFLD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7C7680", Offset = "0x7C6A80", VA = "0x1807C7680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7C7410", Offset = "0x7C6810", VA = "0x1807C7410", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7C73C0", Offset = "0x7C67C0", VA = "0x1807C73C0")]
		private void CLBCIEJIKHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7C7630", Offset = "0x7C6A30", VA = "0x1807C7630", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Dictionary<string, DNNKHEDALCG> CDCNNJAIJLB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override DNNKHEDALCG BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7CB2E0", Offset = "0x7CA6E0", VA = "0x1807CB2E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override DNNKHEDALCG BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7CB240", Offset = "0x7CA640", VA = "0x1807CB240", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override int ALDOGAGGHGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7CB560", Offset = "0x7CA960", VA = "0x1807CB560", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7CB3D0", Offset = "0x7CA7D0", VA = "0x1807CB3D0", Slot = "4")]
	public override void FFIECPFJEFG(string GODDFGCOKFN, DNNKHEDALCG HNLHEJKNGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA8E0", VA = "0x1807CB4E0", Slot = "17")]
	[IteratorStateMachine(typeof(KLFDJOIEFLD))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7CB5B0", Offset = "0x7CA9B0", VA = "0x1807CB5B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7CB9B0", Offset = "0x7CADB0", VA = "0x1807CB9B0")]
	public PEMINGJECBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class OAEFJBMOOFO : DNNKHEDALCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private string NELKFFEHBJL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public override string EIHNEEOMIED
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
	public OAEFJBMOOFO(string JALGKEJIGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7CA610", Offset = "0x7C9A10", VA = "0x1807CA610")]
	public OAEFJBMOOFO(bool JALGKEJIGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7CA650", Offset = "0x7C9A50", VA = "0x1807CA650")]
	public OAEFJBMOOFO(int JALGKEJIGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7CA580", Offset = "0x7C9980", VA = "0x1807CA580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
internal class HKPANAJGIDA : DNNKHEDALCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private DNNKHEDALCG KKMJDPFKLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private string EIPAKBDBBJA;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public override DNNKHEDALCG BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7C3450", Offset = "0x7C2850", VA = "0x1807C3450", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public override DNNKHEDALCG BEENPNFBNIB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7C33C0", Offset = "0x7C27C0", VA = "0x1807C33C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override int CMNJJMKJMGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7C3A30", Offset = "0x7C2E30", VA = "0x1807C3A30", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7C3950", Offset = "0x7C2D50", VA = "0x1807C3950", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override bool NBKCOGCBBIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7C3760", Offset = "0x7C2B60", VA = "0x1807C3760", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C3B00", Offset = "0x7C2F00", VA = "0x1807C3B00", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override CJAPNEFODPG NPNELINHCKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C34D0", Offset = "0x7C28D0", VA = "0x1807C34D0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override PEMINGJECBI GCKGKKMMNPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7C3830", Offset = "0x7C2C30", VA = "0x1807C3830", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C60", Offset = "0x7C3060", VA = "0x1807C3C60")]
	public HKPANAJGIDA(DNNKHEDALCG PBLCMGBACOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7C3C10", Offset = "0x7C3010", VA = "0x1807C3C10")]
	public HKPANAJGIDA(DNNKHEDALCG PBLCMGBACOJ, string GODDFGCOKFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7C38E0", Offset = "0x7C2CE0", VA = "0x1807C38E0")]
	private void NINGCLMMDDO(DNNKHEDALCG INIALHDGFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7C3680", Offset = "0x7C2A80", VA = "0x1807C3680", Slot = "10")]
	public override void FFIECPFJEFG(DNNKHEDALCG HNLHEJKNGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7C3590", Offset = "0x7C2990", VA = "0x1807C3590", Slot = "4")]
	public override void FFIECPFJEFG(string GODDFGCOKFN, DNNKHEDALCG HNLHEJKNGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7C3580", Offset = "0x7C2980", VA = "0x1807C3580", Slot = "0")]
	public override bool Equals(object LIKEKIACGIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7BFD30", Offset = "0x7BF130", VA = "0x1807BFD30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C3BE0", Offset = "0x7C2FE0", VA = "0x1807C3BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OKJNGFOGGMC
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7CA690", Offset = "0x7C9A90", VA = "0x1807CA690")]
	public static DNNKHEDALCG PIJLNDFCNFJ(string EENIEJJHEFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum MJEGEOIEKDC
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	OPTED_IN,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	SUBSCRIBED,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	UNSUBSCRIBED
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LCENMHOJDFI
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public FFOCIHPDHLK NFLLEAMFEJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int MJFIDMCLGBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C55E0", Offset = "0x7C49E0", VA = "0x1807C55E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C7740", Offset = "0x7C6B40", VA = "0x1807C7740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string BLAEHHIHJFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4C0", Offset = "0x7BD8C0", VA = "0x1807BE4C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int KKFLNLOCGPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7C6760", Offset = "0x7C5B60", VA = "0x1807C6760")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C6770", Offset = "0x7C5B70", VA = "0x1807C6770")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IDictionary<string, object> OGPDHIGINPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F80", Offset = "0x7C1380", VA = "0x1807C1F80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7C8530", Offset = "0x7C7930", VA = "0x1807C8530")]
	public LCENMHOJDFI(PEMINGJECBI CFJODMPHEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7C7750", Offset = "0x7C6B50", VA = "0x1807C7750")]
	private object IJFFKEOKBDF(DNNKHEDALCG HBIAHPFPLFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7C7E80", Offset = "0x7C7280", VA = "0x1807C7E80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class FFOCIHPDHLK
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IList<string> BMCIIDFONDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string GLOGPGPODHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4B0", Offset = "0x7BD8B0", VA = "0x1807BE4B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public string JPKBHFGIDDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4C0", Offset = "0x7BD8C0", VA = "0x1807BE4C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public string EDJIGIAEGBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7C1020", Offset = "0x7C0420", VA = "0x1807C1020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A80", Offset = "0x7BFE80", VA = "0x1807C0A80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public string BOJMFFLKOAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F80", Offset = "0x7C1380", VA = "0x1807C1F80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7C23E0", Offset = "0x7C17E0", VA = "0x1807C23E0")]
	public FFOCIHPDHLK(PEMINGJECBI CFJODMPHEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7C1FA0", Offset = "0x7C13A0", VA = "0x1807C1FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum NFPIKOBGHFC
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
public enum PBKPDLENBIN
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	NEWS_FEED,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	URI,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	NONE
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum FFJCFKDAAEN
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	AUTO_DISMISS,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	SWIPE
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class PNIPOEBCDNF
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public List<JGEAFHPPPFM> LMEKOMJDEML
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool NKDGNINPIOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7CBD20", Offset = "0x7CB120", VA = "0x1807CBD20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7CBF80", Offset = "0x7CB380", VA = "0x1807CBF80")]
	public PNIPOEBCDNF(string JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7CBD30", Offset = "0x7CB130", VA = "0x1807CBD30")]
	private static JGEAFHPPPFM JKDHLOHPHFM(PEMINGJECBI CFJODMPHEKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum GHBHOJKFGLA
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
public class EODNAONAMAE
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string PICEOCKAMKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string JBPKKIJGIMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4B0", Offset = "0x7BD8B0", VA = "0x1807BE4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string NMDGBDJLLPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4C0", Offset = "0x7BD8C0", VA = "0x1807BE4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Dictionary<string, string> GHFHLBHHFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7C1020", Offset = "0x7C0420", VA = "0x1807C1020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A80", Offset = "0x7BFE80", VA = "0x1807C0A80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int DAOINPKHJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C80", Offset = "0x7C0080", VA = "0x1807C0C80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A90", Offset = "0x7BFE90", VA = "0x1807C0A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public long LBDBMKDHJDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C1010", Offset = "0x7C0410", VA = "0x1807C1010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string EAFCFMFOKEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C1050", Offset = "0x7C0450", VA = "0x1807C1050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A70", Offset = "0x7BFE70", VA = "0x1807C0A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7C1350", Offset = "0x7C0750", VA = "0x1807C1350")]
	public EODNAONAMAE(string JEBCFBFPEMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7C1060", Offset = "0x7C0460", VA = "0x1807C1060", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C0E70", Offset = "0x7C0270", VA = "0x1807C0E70")]
	private string MIFLCJHHPKE(PEMINGJECBI CFJODMPHEKD, string NIOPCMHKLMB, string DADBDDPBLHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7C0AA0", Offset = "0x7BFEA0", VA = "0x1807C0AA0")]
	private int EJJJCCKJNPP(PEMINGJECBI CFJODMPHEKD, string NIOPCMHKLMB, int DADBDDPBLHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7C0C90", Offset = "0x7C0090", VA = "0x1807C0C90")]
	private long JIHOLJBPKDA(PEMINGJECBI CFJODMPHEKD, string NIOPCMHKLMB, long DADBDDPBLHB)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum FLEDCDFEAAH
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	TOP,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	BOTTOM
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface IABEALNEMCA
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface MAEJDHCNLAI
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	List<KGGBCEBKCEH> JFJBKDFNEIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class KCEDNHCDMOC : IABEALNEMCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected string BLEFBOJPIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int PCIEIHCDMNG;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Color? AMNDMBEBDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C5550", Offset = "0x7C4950", VA = "0x1807C5550", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C5520", Offset = "0x7C4920", VA = "0x1807C5520", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Color? BONPIDNPEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C5670", Offset = "0x7C4A70", VA = "0x1807C5670", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C5610", Offset = "0x7C4A10", VA = "0x1807C5610", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string FFMHALPPBND
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C4690", Offset = "0x7C3A90", VA = "0x1807C4690", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C4470", Offset = "0x7C3870", VA = "0x1807C4470", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Color? FFIPIEBOKLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7C5690", Offset = "0x7C4A90", VA = "0x1807C5690", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C5620", Offset = "0x7C4A20", VA = "0x1807C5620", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Color? LNBJCPAEAAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7C55C0", Offset = "0x7C49C0", VA = "0x1807C55C0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7C55F0", Offset = "0x7C49F0", VA = "0x1807C55F0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string IEBNCFDBJCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7C5640", Offset = "0x7C4A40", VA = "0x1807C5640", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7C5540", Offset = "0x7C4940", VA = "0x1807C5540", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string LNMJBEBMHLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7C5650", Offset = "0x7C4A50", VA = "0x1807C5650", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C5600", Offset = "0x7C4A00", VA = "0x1807C5600", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Dictionary<string, string> GHFHLBHHFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7C5660", Offset = "0x7C4A60", VA = "0x1807C5660", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7C5580", Offset = "0x7C4980", VA = "0x1807C5580", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public PBKPDLENBIN LMFGFMIMMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7C5630", Offset = "0x7C4A30", VA = "0x1807C5630", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(PBKPDLENBIN);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7C56B0", Offset = "0x7C4AB0", VA = "0x1807C56B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string FKCHAPIMHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7C5510", Offset = "0x7C4910", VA = "0x1807C5510", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7C55A0", Offset = "0x7C49A0", VA = "0x1807C55A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public FFJCFKDAAEN AGDGBIONPBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C5530", Offset = "0x7C4930", VA = "0x1807C5530", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(FFJCFKDAAEN);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C5570", Offset = "0x7C4970", VA = "0x1807C5570", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int NGNOLMHMNEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C55E0", Offset = "0x7C49E0", VA = "0x1807C55E0", Slot = "24")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C56C0", Offset = "0x7C4AC0", VA = "0x1807C56C0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7C56F0", Offset = "0x7C4AF0", VA = "0x1807C56F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CA0", Offset = "0x7C50A0", VA = "0x1807C5CA0")]
	public KCEDNHCDMOC(PEMINGJECBI CFJODMPHEKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KGGBCEBKCEH
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int DKOBCFEMHMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7BC180", Offset = "0x7BB580", VA = "0x1807BC180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C6790", Offset = "0x7C5B90", VA = "0x1807C6790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string KPNOGFBJEPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4B0", Offset = "0x7BD8B0", VA = "0x1807BE4B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string FKCHAPIMHLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0440", VA = "0x1807C1040")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4C0", Offset = "0x7BD8C0", VA = "0x1807BE4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public PBKPDLENBIN JEBCIDEIFOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C6760", Offset = "0x7C5B60", VA = "0x1807C6760")]
		[CompilerGenerated]
		get
		{
			return default(PBKPDLENBIN);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C6770", Offset = "0x7C5B70", VA = "0x1807C6770")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public Color? BONPIDNPEFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C67A0", Offset = "0x7C5BA0", VA = "0x1807C67A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7C6780", Offset = "0x7C5B80", VA = "0x1807C6780")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Color? AMNDMBEBDGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7C6740", Offset = "0x7C5B40", VA = "0x1807C6740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7C6730", Offset = "0x7C5B30", VA = "0x1807C6730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7C67C0", Offset = "0x7C5BC0", VA = "0x1807C67C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7C6AA0", Offset = "0x7C5EA0", VA = "0x1807C6AA0")]
	public KGGBCEBKCEH(PEMINGJECBI CFJODMPHEKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class EOJNEHPGNFC
{
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7C1E50", Offset = "0x7C1250", VA = "0x1807C1E50")]
	public static PEMINGJECBI MFJEFPLIFPH(string MKKEAHFOGMO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class OOCMNHBPCMK
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7CAF10", Offset = "0x7CA310", VA = "0x1807CAF10")]
	public static IABEALNEMCA HPOHGKNGIAH(string MGENNNILBEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class LGKFECNHHGF : CFCJKPHEIJG
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7C33B0", Offset = "0x7C27B0", VA = "0x1807C33B0")]
	public LGKFECNHHGF(PEMINGJECBI CFJODMPHEKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class CFCJKPHEIJG : KCEDNHCDMOC, MAEJDHCNLAI
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string PDNGOFJFNHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7BECF0", Offset = "0x7BE0F0", VA = "0x1807BECF0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7BED00", Offset = "0x7BE100", VA = "0x1807BED00", Slot = "28")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Color? OBPPKPIPBMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7BE760", Offset = "0x7BDB60", VA = "0x1807BE760", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7BE790", Offset = "0x7BDB90", VA = "0x1807BE790", Slot = "30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public Color? JJKCBKBEJMA
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7BECB0", Offset = "0x7BE0B0", VA = "0x1807BECB0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7BED20", Offset = "0x7BE120", VA = "0x1807BED20", Slot = "32")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public List<KGGBCEBKCEH> JFJBKDFNEIN
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7BED40", Offset = "0x7BE140", VA = "0x1807BED40", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7BECD0", Offset = "0x7BE0D0", VA = "0x1807BECD0", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7BED50", Offset = "0x7BE150", VA = "0x1807BED50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7BEFD0", Offset = "0x7BE3D0", VA = "0x1807BEFD0")]
	public CFCJKPHEIJG(PEMINGJECBI CFJODMPHEKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class HINOEEIMJEB : CFCJKPHEIJG
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7C33B0", Offset = "0x7C27B0", VA = "0x1807C33B0")]
	public HINOEEIMJEB(PEMINGJECBI CFJODMPHEKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class CCIDBGBGPGH : KCEDNHCDMOC
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public FLEDCDFEAAH LMILFJOCMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7BE740", Offset = "0x7BDB40", VA = "0x1807BE740")]
		[CompilerGenerated]
		get
		{
			return default(FLEDCDFEAAH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7BE750", Offset = "0x7BDB50", VA = "0x1807BE750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool AKJMEPJJPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7BE780", Offset = "0x7BDB80", VA = "0x1807BE780")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7BE7B0", Offset = "0x7BDBB0", VA = "0x1807BE7B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Color? CENPEDHDHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7BE760", Offset = "0x7BDB60", VA = "0x1807BE760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7BE790", Offset = "0x7BDB90", VA = "0x1807BE790")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7C0", Offset = "0x7BDBC0", VA = "0x1807BE7C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7BEA00", Offset = "0x7BDE00", VA = "0x1807BEA00")]
	public CCIDBGBGPGH(PEMINGJECBI CFJODMPHEKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum HELCDOJEAFJ
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	FULL,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	MODAL,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SLIDEUP
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class NPCCBGFOFPM : JGEAFHPPPFM
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string EHIIPBHPHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7C29B0", Offset = "0x7C1DB0", VA = "0x1807C29B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7C29F0", Offset = "0x7C1DF0", VA = "0x1807C29F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string PKDBBKKFKDO
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A20", Offset = "0x7C1E20", VA = "0x1807C2A20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7C29E0", Offset = "0x7C1DE0", VA = "0x1807C29E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string KEOEKLILLCL
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A00", Offset = "0x7C1E00", VA = "0x1807C2A00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7C29C0", Offset = "0x7C1DC0", VA = "0x1807C29C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7CA190", Offset = "0x7C9590", VA = "0x1807CA190")]
	public NPCCBGFOFPM(PEMINGJECBI CFJODMPHEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7C9FD0", Offset = "0x7C93D0", VA = "0x1807C9FD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class IGOMMEDFNEK : JGEAFHPPPFM
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public string EHIIPBHPHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7C29B0", Offset = "0x7C1DB0", VA = "0x1807C29B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7C29F0", Offset = "0x7C1DF0", VA = "0x1807C29F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string JBPKKIJGIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A20", Offset = "0x7C1E20", VA = "0x1807C2A20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7C29E0", Offset = "0x7C1DE0", VA = "0x1807C29E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string CPMGHEGFDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A00", Offset = "0x7C1E00", VA = "0x1807C2A00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7C29C0", Offset = "0x7C1DC0", VA = "0x1807C29C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string PKDBBKKFKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A10", Offset = "0x7C1E10", VA = "0x1807C2A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C1DD0", VA = "0x1807C29D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string KEOEKLILLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CC0", Offset = "0x7C30C0", VA = "0x1807C3CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CB0", Offset = "0x7C30B0", VA = "0x1807C3CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F20", Offset = "0x7C3320", VA = "0x1807C3F20")]
	public IGOMMEDFNEK(PEMINGJECBI CFJODMPHEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CD0", Offset = "0x7C30D0", VA = "0x1807C3CD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JGEAFHPPPFM
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string MELEDNKIAAP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string HCHJICPCOMN
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4B0", Offset = "0x7BD8B0", VA = "0x1807BE4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool KGKFCGHHHHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7C4670", Offset = "0x7C3A70", VA = "0x1807C4670")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7C4680", Offset = "0x7C3A80", VA = "0x1807C4680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public long NMINEMCJOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7C1020", Offset = "0x7C0420", VA = "0x1807C1020")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7C4660", Offset = "0x7C3A60", VA = "0x1807C4660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public long CIOCGNKFHBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7C46B0", Offset = "0x7C3AB0", VA = "0x1807C46B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public HashSet<NFPIKOBGHFC> CLBAKCBMLDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7C46A0", Offset = "0x7C3AA0", VA = "0x1807C46A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private string NPBMFDLMLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A70", Offset = "0x7BFE70", VA = "0x1807C0A70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public Dictionary<string, string> GHFHLBHHFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7C4690", Offset = "0x7C3A90", VA = "0x1807C4690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7C4470", Offset = "0x7C3870", VA = "0x1807C4470")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7C4A40", Offset = "0x7C3E40", VA = "0x1807C4A40")]
	public JGEAFHPPPFM(PEMINGJECBI CFJODMPHEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7C46C0", Offset = "0x7C3AC0", VA = "0x1807C46C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7C4480", Offset = "0x7C3880", VA = "0x1807C4480")]
	public string EDIFCCIDPMC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class ONILMDEABIJ : JGEAFHPPPFM
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string CPMGHEGFDPA
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7C29B0", Offset = "0x7C1DB0", VA = "0x1807C29B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7C29F0", Offset = "0x7C1DF0", VA = "0x1807C29F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string EHIIPBHPHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A20", Offset = "0x7C1E20", VA = "0x1807C2A20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7C29E0", Offset = "0x7C1DE0", VA = "0x1807C29E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public string JBPKKIJGIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A00", Offset = "0x7C1E00", VA = "0x1807C2A00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7C29C0", Offset = "0x7C1DC0", VA = "0x1807C29C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public string PKDBBKKFKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A10", Offset = "0x7C1E10", VA = "0x1807C2A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C1DD0", VA = "0x1807C29D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string KEOEKLILLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CC0", Offset = "0x7C30C0", VA = "0x1807C3CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CB0", Offset = "0x7C30B0", VA = "0x1807C3CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7CA8F0", Offset = "0x7C9CF0", VA = "0x1807CA8F0")]
	public ONILMDEABIJ(PEMINGJECBI CFJODMPHEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7CA6A0", Offset = "0x7C9AA0", VA = "0x1807CA6A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class LJBLIAOLAII
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public string MELEDNKIAAP
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7C1030", Offset = "0x7C0430", VA = "0x1807C1030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A50", Offset = "0x7BFE50", VA = "0x1807C0A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string HCHJICPCOMN
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4B0", Offset = "0x7BD8B0", VA = "0x1807BE4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool KGKFCGHHHHB
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7C4670", Offset = "0x7C3A70", VA = "0x1807C4670")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7C4680", Offset = "0x7C3A80", VA = "0x1807C4680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public long NMINEMCJOGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7C1020", Offset = "0x7C0420", VA = "0x1807C1020")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7C4660", Offset = "0x7C3A60", VA = "0x1807C4660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public long IFEBNENICME
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7C1F90", Offset = "0x7C1390", VA = "0x1807C1F90")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7C46B0", Offset = "0x7C3AB0", VA = "0x1807C46B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public string EHIIPBHPHAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A60", Offset = "0x7BFE60", VA = "0x1807C0A60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7C46A0", Offset = "0x7C3AA0", VA = "0x1807C46A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string JBPKKIJGIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7C1050", Offset = "0x7C0450", VA = "0x1807C1050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A70", Offset = "0x7BFE70", VA = "0x1807C0A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public string CPMGHEGFDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7C4690", Offset = "0x7C3A90", VA = "0x1807C4690")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7C4470", Offset = "0x7C3870", VA = "0x1807C4470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public string PKDBBKKFKDO
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7C29B0", Offset = "0x7C1DB0", VA = "0x1807C29B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7C29F0", Offset = "0x7C1DF0", VA = "0x1807C29F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public string KEOEKLILLCL
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A20", Offset = "0x7C1E20", VA = "0x1807C2A20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7C29E0", Offset = "0x7C1DE0", VA = "0x1807C29E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public bool MJCCKKCOGLH
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7C8B50", Offset = "0x7C7F50", VA = "0x1807C8B50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7C8CE0", Offset = "0x7C80E0", VA = "0x1807C8CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool PCNDNBJIBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D00", Offset = "0x7C8100", VA = "0x1807C8D00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7C8C30", Offset = "0x7C8030", VA = "0x1807C8C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool DCIIOIEHKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7C8B60", Offset = "0x7C7F60", VA = "0x1807C8B60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7C8B40", Offset = "0x7C7F40", VA = "0x1807C8B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool CABJBOBDOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7C8CF0", Offset = "0x7C80F0", VA = "0x1807C8CF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7C8C20", Offset = "0x7C8020", VA = "0x1807C8C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool HBKNKPCAILD
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D10", Offset = "0x7C8110", VA = "0x1807C8D10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7C8C10", Offset = "0x7C8010", VA = "0x1807C8C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public string NPBMFDLMLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A10", Offset = "0x7C1E10", VA = "0x1807C2A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C1DD0", VA = "0x1807C29D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public Dictionary<string, string> GHFHLBHHFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CC0", Offset = "0x7C30C0", VA = "0x1807C3CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CB0", Offset = "0x7C30B0", VA = "0x1807C3CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7C93D0", Offset = "0x7C87D0", VA = "0x1807C93D0")]
	public LJBLIAOLAII(PEMINGJECBI CFJODMPHEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7C8D20", Offset = "0x7C8120", VA = "0x1807C8D20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7C8C40", Offset = "0x7C8040", VA = "0x1807C8C40")]
	public void MBGOABMCIIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7C8B70", Offset = "0x7C7F70", VA = "0x1807C8B70")]
	public void JBDJGHPAKJP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class FLLKIJNMAPH : JGEAFHPPPFM
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public string JBPKKIJGIMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7C29B0", Offset = "0x7C1DB0", VA = "0x1807C29B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7C29F0", Offset = "0x7C1DF0", VA = "0x1807C29F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public string CPMGHEGFDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A20", Offset = "0x7C1E20", VA = "0x1807C2A20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7C29E0", Offset = "0x7C1DE0", VA = "0x1807C29E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public string PKDBBKKFKDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A00", Offset = "0x7C1E00", VA = "0x1807C2A00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7C29C0", Offset = "0x7C1DC0", VA = "0x1807C29C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string KEOEKLILLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A10", Offset = "0x7C1E10", VA = "0x1807C2A10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C1DD0", VA = "0x1807C29D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7C2C40", Offset = "0x7C2040", VA = "0x1807C2C40")]
	public FLLKIJNMAPH(PEMINGJECBI CFJODMPHEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A30", Offset = "0x7C1E30", VA = "0x1807C2A30", Slot = "3")]
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
		private AGJOFFDEFAM PMLJPCHDPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private JHEGLOPLAKB KONHDEAPEGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public KJAILFAPEJL iamListener;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4B0", Offset = "0x7BD8B0", VA = "0x1807BE4B0")]
		public void setPushPromptResponseReceivedDelegate(AGJOFFDEFAM KLPCDLOOPDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4C0", Offset = "0x7BD8C0", VA = "0x1807BE4C0")]
		public void setPushTokenReceivedFromSystemDelegate(JHEGLOPLAKB KLPCDLOOPDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7BE420", Offset = "0x7BD820", VA = "0x1807BE420")]
		public void onPushPromptResponseReceived(string EDFCHOJNMJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7BE490", Offset = "0x7BD890", VA = "0x1807BE490")]
		public void onPushTokenReceivedFromSystem(string ICNJFMMNIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7BDD70", Offset = "0x7BD170", VA = "0x1807BDD70")]
		public void beforeInAppMessageDisplayed(string DBACOHONHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7BE140", Offset = "0x7BD540", VA = "0x1807BE140")]
		public void onInAppMessageDismissed(string DBACOHONHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7BE0E0", Offset = "0x7BD4E0", VA = "0x1807BE0E0")]
		public void onInAppMessageClicked(string DBACOHONHFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7BDDD0", Offset = "0x7BD1D0", VA = "0x1807BDDD0")]
		public void onInAppMessageButtonClicked(string OKDKIKJNAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1A0", Offset = "0x7BD5A0", VA = "0x1807BE1A0")]
		public void onInAppMessageHTMLClicked(string OKDKIKJNAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2F0", Offset = "0x7BC6F0", VA = "0x1807BD2F0")]
		public BrazeInternalComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class BrazeInternalGameObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static GameObject DLKEBALDMPC;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private static GameObject GDCHCCJBKDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7BE4D0", Offset = "0x7BD8D0", VA = "0x1807BE4D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7BE680", Offset = "0x7BDA80", VA = "0x1807BE680")]
		public static void setPushPromptResponseReceivedDelegate(AGJOFFDEFAM KLPCDLOOPDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7BE6E0", Offset = "0x7BDAE0", VA = "0x1807BE6E0")]
		public static void setPushTokenReceivedFromSystemDelegate(JHEGLOPLAKB KLPCDLOOPDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7BE620", Offset = "0x7BDA20", VA = "0x1807BE620")]
		public static void setInAppMessageListener(KJAILFAPEJL IIHPELOIOIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2F0", Offset = "0x7BC6F0", VA = "0x1807BD2F0")]
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
