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
public interface AFKPNAAFDMM
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ApplePushNotificationTester : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7AABC0", Offset = "0x7A99C0", VA = "0x1807AABC0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7AA660", Offset = "0x7A9460", VA = "0x1807AA660")]
	public string PrintOutObjectValues(object AHDEOJJOOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
	public ApplePushNotificationTester()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum LAKOIIHEMNJ
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
public enum DFNNPGLLBKO
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	IAM_DISPLAY_NOW,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	IAM_DISPLAY_LATER,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	IAM_DISCARD
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void NMKLCGDNIDG(bool LECCLJKPEED);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void HJFDIFCNCIG(string NBGOKNOECBH);
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AppboyBinding : SingletonMonoBehaviour<AppboyBinding>
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static AFKPNAAFDMM DBOJLJJIGIG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static AFKPNAAFDMM BKGOGEGJJAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7AA620", Offset = "0x7A9420", VA = "0x1807AA620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CIPODDDMHAL JEGFNEBKNHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void LogCustomEvent(string CNMALFPMMDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void LogCustomEvent(string CNMALFPMMDJ, Dictionary<string, object> GGBBBBDBDBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void LogPurchase(string LJKAGAKGODB, string MNHJFKGCOMM, decimal LAPJPEBECIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void LogPurchase(string LJKAGAKGODB, string MNHJFKGCOMM, decimal LAPJPEBECIF, int LBCEMAMCEGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void LogPurchase(string LJKAGAKGODB, string MNHJFKGCOMM, decimal LAPJPEBECIF, int LBCEMAMCEGO, Dictionary<string, object> GGBBBBDBDBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void ChangeUser(string HNCMMELDDJD, [Optional] string BNAOJIFJIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetSdkAuthenticationSignature(string BNAOJIFJIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetUserFirstName(string GLIBOJNGMNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetUserLastName(string BNNPEAFFDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetUserEmail(string IDEIHOKOABH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetUserGender(PCGFMFLOKIJ IDBBGNAJCEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetUserDateOfBirth(int HPHJFAPEDFO, int BHDBIHDEOGJ, int OOPAOHDMEJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetUserCountry(string GIKHHKIMHDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetUserHomeCity(string PCPJOHLLIHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetUserEmailNotificationSubscriptionType(KKLHFHGAOEM EGEPBGJEDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetUserPushNotificationSubscriptionType(KKLHFHGAOEM GPEMKGPOAGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetUserPhoneNumber(string KEELOMNCJAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetCustomUserAttribute(string JCMGBFKGKLO, bool NKKIECLCEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetCustomUserAttribute(string JCMGBFKGKLO, int NKKIECLCEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetCustomUserAttribute(string JCMGBFKGKLO, float NKKIECLCEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetCustomUserAttribute(string JCMGBFKGKLO, string NKKIECLCEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetCustomUserAttributeToNow(string JCMGBFKGKLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetCustomUserAttributeToSecondsFromEpoch(string JCMGBFKGKLO, long BPPBECKKEDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void UnsetCustomUserAttribute(string JCMGBFKGKLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void IncrementCustomUserAttribute(string JCMGBFKGKLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void IncrementCustomUserAttribute(string JCMGBFKGKLO, int ACCMDADOFBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetCustomUserAttributeArray(string JCMGBFKGKLO, List<string> AAKJIOEDOGA, int DDGPJFNNFJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void AddToCustomUserAttributeArray(string JCMGBFKGKLO, string NKKIECLCEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void RemoveFromCustomUserAttributeArray(string JCMGBFKGKLO, string NKKIECLCEML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void setUserFacebookData(string EAMOIPHINBK, string GLIBOJNGMNM, string BNNPEAFFDOK, string IDEIHOKOABH, string EGHDGECAGCD, string ANFGANJACFB, PCGFMFLOKIJ? IDBBGNAJCEG, int? HCKMKJELCGO, string FHBOLCNLAHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void setUserTwitterData(int? MAKMDKKLOLF, string CCDDGJLCIOD, string OHHBGJPCFJD, string JFBABPIJMOE, int? IBNAFJDNNDC, int? MFNHFIBDHKN, int? OBMGCDMEAFN, string IEBNALFCJGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetUserLastKnownLocation(double OBDEAIEGPHM, double JDMNBKKBHNF, [Optional] double? EHAKPIIOFJC, [Optional] double? NHPMIMPHCLF, [Optional] double? NNAIHGBGFDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void PromptUserForPushPermissions(bool EFFMGIDPCFN, [Optional] NMKLCGDNIDG CEFFCMBABHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetPushTokenReceivedFromSystemDelegate(HJFDIFCNCIG PINFBHMIBLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void LogInAppMessageClicked(string FMNEFOFCEOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void LogInAppMessageImpression(string FMNEFOFCEOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void LogInAppMessageButtonClicked(string FMNEFOFCEOH, int FHONCOGINPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void RequestFeedRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void RequestFeedRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void LogFeedDisplayed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void RequestContentCardsRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void RequestContentCardsRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void LogContentCardClicked(string HPFFPCHPKII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void LogContentCardImpression(string HPFFPCHPKII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void LogContentCardDismissed(string HPFFPCHPKII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void WipeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void EnableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void DisableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0")]
		public static string GetInstallTrackingId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetAttributionData(string CIFEPGEHBCC, string BCKGEMEIKGE, string DIBOOJMNIJB, string GKNJMOEOELJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void RequestLocationInitialization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void RequestGeofences(decimal OBDEAIEGPHM, decimal JDMNBKKBHNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void RequestImmediateDataFlush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void AddAlias(string JBIPNNHLBOM, string IDNKFILIEMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void ConfigureListener(LAKOIIHEMNJ GHJLJIDKADO, string CDDCOLLBMKA, string NLCJLEOLBHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void SetInAppMessageDisplayAction(DFNNPGLLBKO GCIILGIENOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void DisplayNextInAppMessage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void DisplayContentCards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void AddToSubscriptionGroup(string DGIBOINMLED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0")]
		public static void RemoveFromSubscriptionGroup(string DGIBOINMLED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5E0", Offset = "0x7A93E0", VA = "0x1807AA5E0")]
		public AppboyBinding()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CIPODDDMHAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Action<OGBMFKHCBCF> HNFBOCOMFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Action<OGBMFKHCBCF> PNGGJKAFMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Action<OGBMFKHCBCF> MKAHBNFMGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Action<OGBMFKHCBCF, NDFFBCJFGDL> CMHHJIHOAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public Action<OGBMFKHCBCF, Uri> CBFDDGMJNIP;
}
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AppboyBindingTester : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7AA530", Offset = "0x7A9330", VA = "0x1807AA530")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7A9D30", Offset = "0x7A8B30", VA = "0x1807A9D30")]
		private void JMCOHDMAAMJ(string EMKENBOOEOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7A9550", Offset = "0x7A8350", VA = "0x1807A9550")]
		private void AIFFNBMHBAF(string EMKENBOOEOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7A96D0", Offset = "0x7A84D0", VA = "0x1807A96D0")]
		private void GAKJGKHHNML(string EMKENBOOEOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7A9E10", Offset = "0x7A8C10", VA = "0x1807A9E10")]
		private void KJAIKOJLPDJ(string EMKENBOOEOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7A95C0", Offset = "0x7A83C0", VA = "0x1807A95C0")]
		private void DGPJIBOBLFI(string EMKENBOOEOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7A9740", Offset = "0x7A8540", VA = "0x1807A9740")]
		private void GMEENDFMPJD(string EMKENBOOEOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7A9F20", Offset = "0x7A8D20", VA = "0x1807A9F20")]
		private void NOILOLJABBH(string EMKENBOOEOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7A98A0", Offset = "0x7A86A0", VA = "0x1807A98A0")]
		private void HIMFNIGFCKO(string EMKENBOOEOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7AA0F0", Offset = "0x7A8EF0", VA = "0x1807AA0F0")]
		private void PNENNNJAHNB(string EMKENBOOEOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7AA080", Offset = "0x7A8E80", VA = "0x1807AA080")]
		private void OJBFIILKHIF(string EMKENBOOEOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7A9AE0", Offset = "0x7A88E0", VA = "0x1807A9AE0")]
		public static void InAppMessageBeforeDisplayed(OGBMFKHCBCF EMKENBOOEOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7A9C40", Offset = "0x7A8A40", VA = "0x1807A9C40")]
		public static void InAppMessageDismissed(OGBMFKHCBCF EMKENBOOEOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7A9BD0", Offset = "0x7A89D0", VA = "0x1807A9BD0")]
		public static void InAppMessageClicked(OGBMFKHCBCF EMKENBOOEOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7A9B50", Offset = "0x7A8950", VA = "0x1807A9B50")]
		public static void InAppMessageButtonClicked(OGBMFKHCBCF EMKENBOOEOH, NDFFBCJFGDL IPJLMCEJDNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7A9CB0", Offset = "0x7A8AB0", VA = "0x1807A9CB0")]
		public static void InAppMessageHTMLClicked(OGBMFKHCBCF EMKENBOOEOH, Uri NBLPLKPBEBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
		public AppboyBindingTester()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GHGPEBNEBKD
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7B1490", Offset = "0x7B0290", VA = "0x1807B1490")]
	public static string EFEODANIFEJ(Dictionary<string, string> BNNBPKMEFEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x26F3F80", Offset = "0x26F2D80", VA = "0x1826F3F80")]
	public static string FMFFMFEIIDA<T>(List<T> FOKGGJDBEOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CNIFFJNMGFE
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7AC5A0", Offset = "0x7AB3A0", VA = "0x1807AC5A0")]
	public static Color? PMMEHGILEAG(string AGAFECKOJAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7AC2B0", Offset = "0x7AB0B0", VA = "0x1807AC2B0")]
	public static Color PMMEHGILEAG(int AGAFECKOJAJ)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CDLOCGOIFEM
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7AC100", Offset = "0x7AAF00", VA = "0x1807AC100")]
	public static object IBBEFPCNIJB(Type MIOGAEAHLIK, string NKKIECLCEML, bool MGBJIDBBEDM, object IDLIOJCDHNC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DFMNNEHGENF
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7ACC70", Offset = "0x7ABA70", VA = "0x1807ACC70")]
	public static Dictionary<string, string> FMBMJONGIJD(ECHCKEIIPJI DLLLAJJCCDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DefaultMember("Item")]
public class GDIFIMGHLAP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public virtual GDIFIMGHLAP LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public virtual GDIFIMGHLAP LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual string DFPHMDCMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7B01D0", Offset = "0x7AEFD0", VA = "0x1807B01D0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public virtual int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5D0", Offset = "0x7A93D0", VA = "0x1807AA5D0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public virtual int AOKMLABIJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7B0290", Offset = "0x7AF090", VA = "0x1807B0290", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF30", Offset = "0x7AED30", VA = "0x1807AFF30", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual bool CDDNJPHJOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7B0D70", Offset = "0x7AFB70", VA = "0x1807B0D70", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7B0150", Offset = "0x7AEF50", VA = "0x1807B0150", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public virtual EAKKKGOJJCO HADDBDNBGGO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7B00C0", Offset = "0x7AEEC0", VA = "0x1807B00C0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public virtual ECHCKEIIPJI DIFJNEMPMOO
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7B0B40", Offset = "0x7AF940", VA = "0x1807B0B40", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "4")]
	public virtual void ANMBPKAMKOK(string NFMNLGBOFBK, GDIFIMGHLAP LGOPFPKOGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7AFF70", Offset = "0x7AED70", VA = "0x1807AFF70", Slot = "10")]
	public virtual void ANMBPKAMKOK(GDIFIMGHLAP LGOPFPKOGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7B0EA0", Offset = "0x7AFCA0", VA = "0x1807B0EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7AFFD0", Offset = "0x7AEDD0", VA = "0x1807AFFD0")]
	public static GDIFIMGHLAP EADAJIFKEOK(string GONJIKGEFGO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7B0040", Offset = "0x7AEE40", VA = "0x1807B0040")]
	public static string EADAJIFKEOK(GDIFIMGHLAP DDIKBLEEKFK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7B0210", Offset = "0x7AF010", VA = "0x1807B0210")]
	public static bool JACCNGOPODK(GDIFIMGHLAP GCMDJKOKHCO, object LGCDJBDIEJC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7B0E20", Offset = "0x7AFC20", VA = "0x1807B0E20")]
	public static bool PONNJIKFNKJ(GDIFIMGHLAP GCMDJKOKHCO, object LGCDJBDIEJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7B0140", Offset = "0x7AEF40", VA = "0x1807B0140", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AF000", VA = "0x1807B0200", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B0BC0", Offset = "0x7AF9C0", VA = "0x1807B0BC0")]
	internal static string OACEMKCKOBG(string POEIFELMLNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7B02D0", Offset = "0x7AF0D0", VA = "0x1807B02D0")]
	public static GDIFIMGHLAP KNILPAIBOFM(string HDAANLACAGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public GDIFIMGHLAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DefaultMember("Item")]
public class EAKKKGOJJCO : GDIFIMGHLAP, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class KBMDECNLICP : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public EAKKKGOJJCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<GDIFIMGHLAP>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
		[DebuggerHidden]
		public KBMDECNLICP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7B3270", Offset = "0x7B2070", VA = "0x1807B3270", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7B3020", Offset = "0x7B1E20", VA = "0x1807B3020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7B31D0", Offset = "0x7B1FD0", VA = "0x1807B31D0")]
		private void ONJBEDHNBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7B3220", Offset = "0x7B2020", VA = "0x1807B3220", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<GDIFIMGHLAP> LFNPDHABDHB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override GDIFIMGHLAP LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7AEAB0", Offset = "0x7AD8B0", VA = "0x1807AEAB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override GDIFIMGHLAP LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7AEA30", Offset = "0x7AD830", VA = "0x1807AEA30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7AEB80", Offset = "0x7AD980", VA = "0x1807AEB80", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7AE950", Offset = "0x7AD750", VA = "0x1807AE950", Slot = "4")]
	public override void ANMBPKAMKOK(string NFMNLGBOFBK, GDIFIMGHLAP LGOPFPKOGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7AE9B0", Offset = "0x7AD7B0", VA = "0x1807AE9B0", Slot = "17")]
	[IteratorStateMachine(typeof(KBMDECNLICP))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7AEBC0", Offset = "0x7AD9C0", VA = "0x1807AEBC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7AED80", Offset = "0x7ADB80", VA = "0x1807AED80")]
	public EAKKKGOJJCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DefaultMember("Item")]
public class ECHCKEIIPJI : GDIFIMGHLAP, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class NKCGGIHFNHI : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public ECHCKEIIPJI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private Dictionary<string, GDIFIMGHLAP>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7B3300", Offset = "0x7B2100", VA = "0x1807B3300")]
		[DebuggerHidden]
		public NKCGGIHFNHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7B5C10", Offset = "0x7B4A10", VA = "0x1807B5C10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7B5950", Offset = "0x7B4750", VA = "0x1807B5950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7B5B70", Offset = "0x7B4970", VA = "0x1807B5B70")]
		private void ONJBEDHNBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BC0", Offset = "0x7B49C0", VA = "0x1807B5BC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Dictionary<string, GDIFIMGHLAP> PIOGNBBFDPG;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override GDIFIMGHLAP LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7AF040", Offset = "0x7ADE40", VA = "0x1807AF040", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override GDIFIMGHLAP LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7AEFA0", Offset = "0x7ADDA0", VA = "0x1807AEFA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override int DDMEKBICEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7AF130", Offset = "0x7ADF30", VA = "0x1807AF130", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7AEE10", Offset = "0x7ADC10", VA = "0x1807AEE10", Slot = "4")]
	public override void ANMBPKAMKOK(string NFMNLGBOFBK, GDIFIMGHLAP LGOPFPKOGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7AEF20", Offset = "0x7ADD20", VA = "0x1807AEF20", Slot = "17")]
	[IteratorStateMachine(typeof(NKCGGIHFNHI))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7AF180", Offset = "0x7ADF80", VA = "0x1807AF180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7AF580", Offset = "0x7AE380", VA = "0x1807AF580")]
	public ECHCKEIIPJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PAIMDMLANKF : GDIFIMGHLAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private string IIDLGMIPBPG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public override string DFPHMDCMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
	public PAIMDMLANKF(string PIMMEPJJOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7B7000", Offset = "0x7B5E00", VA = "0x1807B7000")]
	public PAIMDMLANKF(bool PIMMEPJJOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7B7080", Offset = "0x7B5E80", VA = "0x1807B7080")]
	public PAIMDMLANKF(int PIMMEPJJOJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7B6FB0", Offset = "0x7B5DB0", VA = "0x1807B6FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
internal class HFLBOMKIEGE : GDIFIMGHLAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private GDIFIMGHLAP GHLGHBEFEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private string FLLIFAALKHD;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public override GDIFIMGHLAP LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BB0", Offset = "0x7B09B0", VA = "0x1807B1BB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public override GDIFIMGHLAP LKDOJBHIIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C30", Offset = "0x7B0A30", VA = "0x1807B1C30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override int AOKMLABIJKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7B1CC0", Offset = "0x7B0AC0", VA = "0x1807B1CC0", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7B16F0", Offset = "0x7B04F0", VA = "0x1807B16F0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override bool CDDNJPHJOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B1E40", Offset = "0x7B0C40", VA = "0x1807B1E40", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B1A60", Offset = "0x7B0860", VA = "0x1807B1A60", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override EAKKKGOJJCO HADDBDNBGGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B19A0", Offset = "0x7B07A0", VA = "0x1807B19A0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override ECHCKEIIPJI DIFJNEMPMOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B1D90", Offset = "0x7B0B90", VA = "0x1807B1D90", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7B1F40", Offset = "0x7B0D40", VA = "0x1807B1F40")]
	public HFLBOMKIEGE(GDIFIMGHLAP LJOBGGDLBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7B1F90", Offset = "0x7B0D90", VA = "0x1807B1F90")]
	public HFLBOMKIEGE(GDIFIMGHLAP LJOBGGDLBKD, string NFMNLGBOFBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7B1B40", Offset = "0x7B0940", VA = "0x1807B1B40")]
	private void FOBLAMHLHCD(GDIFIMGHLAP NOCOGCFEING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7B17D0", Offset = "0x7B05D0", VA = "0x1807B17D0", Slot = "10")]
	public override void ANMBPKAMKOK(GDIFIMGHLAP LGOPFPKOGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7B18B0", Offset = "0x7B06B0", VA = "0x1807B18B0", Slot = "4")]
	public override void ANMBPKAMKOK(string NFMNLGBOFBK, GDIFIMGHLAP LGOPFPKOGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7B1A50", Offset = "0x7B0850", VA = "0x1807B1A50", Slot = "0")]
	public override bool Equals(object NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AF000", VA = "0x1807B0200", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7B1F10", Offset = "0x7B0D10", VA = "0x1807B1F10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class DCELCJHGIEP
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7ACC60", Offset = "0x7ABA60", VA = "0x1807ACC60")]
	public static GDIFIMGHLAP KNILPAIBOFM(string HDAANLACAGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum KKLHFHGAOEM
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	OPTED_IN,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	SUBSCRIBED,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	UNSUBSCRIBED
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PIBCOLGCFMC
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ANPJOMAMLIF FKJADJNJCKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int AMENNNOJNAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E90", Offset = "0x7B4C90", VA = "0x1807B5E90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B77F0", Offset = "0x7B65F0", VA = "0x1807B77F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string IKAIGIADEAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7A81D0", Offset = "0x7A6FD0", VA = "0x1807A81D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int NNLABOJMMLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7B3E00", Offset = "0x7B2C00", VA = "0x1807B3E00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B3D80", Offset = "0x7B2B80", VA = "0x1807B3D80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IDictionary<string, object> CKEMGCDGEMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7A8190", Offset = "0x7A6F90", VA = "0x1807A8190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7B7EB0", Offset = "0x7B6CB0", VA = "0x1807B7EB0")]
	public PIBCOLGCFMC(ECHCKEIIPJI DLLLAJJCCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7B70C0", Offset = "0x7B5EC0", VA = "0x1807B70C0")]
	private object FCADPKIGIAI(GDIFIMGHLAP ACNLHBNEANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7B7800", Offset = "0x7B6600", VA = "0x1807B7800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ANPJOMAMLIF
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IList<string> PKNJHLABKJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string HLFIKGOEGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7A81C0", Offset = "0x7A6FC0", VA = "0x1807A81C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public string LPPPMOLENCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7A81D0", Offset = "0x7A6FD0", VA = "0x1807A81D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public string CCDFDMNIJKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7A8200", Offset = "0x7A7000", VA = "0x1807A8200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7A81E0", Offset = "0x7A6FE0", VA = "0x1807A81E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public string EGFDODNIAAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7A8190", Offset = "0x7A6F90", VA = "0x1807A8190")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7A8670", Offset = "0x7A7470", VA = "0x1807A8670")]
	public ANPJOMAMLIF(ECHCKEIIPJI DLLLAJJCCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7A8230", Offset = "0x7A7030", VA = "0x1807A8230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum MOHFJAPENLD
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
public enum KLLBMOBBJGH
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	NEWS_FEED,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	URI,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	NONE
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum LOONJMANPNC
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	AUTO_DISMISS,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	SWIPE
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MDGMDBPNIDA
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public List<JFIKOGBKHBH> KKIOPIPDGGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool BIAMJCFLJKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7B3330", Offset = "0x7B2130", VA = "0x1807B3330")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7B3590", Offset = "0x7B2390", VA = "0x1807B3590")]
	public MDGMDBPNIDA(string EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7B3340", Offset = "0x7B2140", VA = "0x1807B3340")]
	private static JFIKOGBKHBH MKALJPNFLNN(ECHCKEIIPJI DLLLAJJCCDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum PCGFMFLOKIJ
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
public class NJGMIBFLGMA
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string BKLPOHBHAHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string PFEINDMBCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7A81C0", Offset = "0x7A6FC0", VA = "0x1807A81C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string IAJPPFJEKHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7A81D0", Offset = "0x7A6FD0", VA = "0x1807A81D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Dictionary<string, string> AJDOAJOCLND
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7A8200", Offset = "0x7A7000", VA = "0x1807A8200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7A81E0", Offset = "0x7A6FE0", VA = "0x1807A81E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int HHLNFGHKAHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7B49A0", Offset = "0x7B37A0", VA = "0x1807B49A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7B45D0", Offset = "0x7B33D0", VA = "0x1807B45D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public long ONFBHIFDAMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7B4B50", Offset = "0x7B3950", VA = "0x1807B4B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string LMOEFGIPGAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7AD190", Offset = "0x7ABF90", VA = "0x1807AD190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7AD130", Offset = "0x7ABF30", VA = "0x1807AD130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7B4E50", Offset = "0x7B3C50", VA = "0x1807B4E50")]
	public NJGMIBFLGMA(string EMKENBOOEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7B4B60", Offset = "0x7B3960", VA = "0x1807B4B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7B49B0", Offset = "0x7B37B0", VA = "0x1807B49B0")]
	private string MMMIKNOOEMI(ECHCKEIIPJI DLLLAJJCCDH, string JCMGBFKGKLO, string IDLIOJCDHNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7B47C0", Offset = "0x7B35C0", VA = "0x1807B47C0")]
	private int JLGCLKMOGLA(ECHCKEIIPJI DLLLAJJCCDH, string JCMGBFKGKLO, int IDLIOJCDHNC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B33E0", VA = "0x1807B45E0")]
	private long EHMEIMJHDBP(ECHCKEIIPJI DLLLAJJCCDH, string JCMGBFKGKLO, long IDLIOJCDHNC)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum NLEGBBGNFKN
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	TOP,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	BOTTOM
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface OGBMFKHCBCF
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface HHACDAAEDHP
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	List<NDFFBCJFGDL> HGAMGOGCFIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class OECCPLJEDMM : OGBMFKHCBCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected string INOMDANEBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int KDOLJKKDKAA;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Color? PEAOBMPIPJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E30", Offset = "0x7B4C30", VA = "0x1807B5E30", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F40", Offset = "0x7B4D40", VA = "0x1807B5F40", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Color? ABDIFFHJNKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F20", Offset = "0x7B4D20", VA = "0x1807B5F20", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F10", Offset = "0x7B4D10", VA = "0x1807B5F10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string DALIMHPCAIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1F0", Offset = "0x7ABFF0", VA = "0x1807AD1F0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7AD170", Offset = "0x7ABF70", VA = "0x1807AD170", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Color? DKJIFALPDLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E60", Offset = "0x7B4C60", VA = "0x1807B5E60", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7B5DB0", Offset = "0x7B4BB0", VA = "0x1807B5DB0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Color? MNNLFOCGPFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7B5DE0", Offset = "0x7B4BE0", VA = "0x1807B5DE0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7B5DA0", Offset = "0x7B4BA0", VA = "0x1807B5DA0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string HJMBHHKJOCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E20", Offset = "0x7B4C20", VA = "0x1807B5E20", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E80", Offset = "0x7B4C80", VA = "0x1807B5E80", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string EPAABOBMNNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E50", Offset = "0x7B4C50", VA = "0x1807B5E50", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7B5EE0", Offset = "0x7B4CE0", VA = "0x1807B5EE0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Dictionary<string, string> AJDOAJOCLND
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F50", Offset = "0x7B4D50", VA = "0x1807B5F50", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7B5DC0", Offset = "0x7B4BC0", VA = "0x1807B5DC0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public KLLBMOBBJGH CHDJEILHMDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F60", Offset = "0x7B4D60", VA = "0x1807B5F60", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(KLLBMOBBJGH);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D90", Offset = "0x7B4B90", VA = "0x1807B5D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string NGKHKDACMAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7B5F00", Offset = "0x7B4D00", VA = "0x1807B5F00", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E00", Offset = "0x7B4C00", VA = "0x1807B5E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public LOONJMANPNC EPLKIDGFKKA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B5EA0", Offset = "0x7B4CA0", VA = "0x1807B5EA0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(LOONJMANPNC);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7B5EF0", Offset = "0x7B4CF0", VA = "0x1807B5EF0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int ANAHCKJLPHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B5E90", Offset = "0x7B4C90", VA = "0x1807B5E90", Slot = "24")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7B5EB0", Offset = "0x7B4CB0", VA = "0x1807B5EB0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7B5F70", Offset = "0x7B4D70", VA = "0x1807B5F70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7B6520", Offset = "0x7B5320", VA = "0x1807B6520")]
	public OECCPLJEDMM(ECHCKEIIPJI DLLLAJJCCDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NDFFBCJFGDL
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int APGPMCFCLAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7A8180", Offset = "0x7A6F80", VA = "0x1807A8180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B3DB0", Offset = "0x7B2BB0", VA = "0x1807B3DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string CDLOIINFHNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7A81C0", Offset = "0x7A6FC0", VA = "0x1807A81C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string NGKHKDACMAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7A81F0", Offset = "0x7A6FF0", VA = "0x1807A81F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7A81D0", Offset = "0x7A6FD0", VA = "0x1807A81D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public KLLBMOBBJGH EPINGJAIFCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7B3E00", Offset = "0x7B2C00", VA = "0x1807B3E00")]
		[CompilerGenerated]
		get
		{
			return default(KLLBMOBBJGH);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7B3D80", Offset = "0x7B2B80", VA = "0x1807B3D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public Color? ABDIFFHJNKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7B3DD0", Offset = "0x7B2BD0", VA = "0x1807B3DD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7B3DC0", Offset = "0x7B2BC0", VA = "0x1807B3DC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Color? PEAOBMPIPJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7B3D90", Offset = "0x7B2B90", VA = "0x1807B3D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7B3DF0", Offset = "0x7B2BF0", VA = "0x1807B3DF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7B3E10", Offset = "0x7B2C10", VA = "0x1807B3E10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7B40F0", Offset = "0x7B2EF0", VA = "0x1807B40F0")]
	public NDFFBCJFGDL(ECHCKEIIPJI DLLLAJJCCDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class CFHPHNHPGLB
{
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7AC180", Offset = "0x7AAF80", VA = "0x1807AC180")]
	public static ECHCKEIIPJI KKBNFDAMKIF(string DFFAPNPJJJO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MOPHGMNEAIO
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7B3AD0", Offset = "0x7B28D0", VA = "0x1807B3AD0")]
	public static OGBMFKHCBCF EBLHHALPGME(string FMNEFOFCEOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PEHFCGCILCH : FLGPHJLGCMB
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7ACF80", Offset = "0x7ABD80", VA = "0x1807ACF80")]
	public PEHFCGCILCH(ECHCKEIIPJI DLLLAJJCCDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class FLGPHJLGCMB : OECCPLJEDMM, HHACDAAEDHP
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string GJPCLDEDAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7AF610", Offset = "0x7AE410", VA = "0x1807AF610", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7AF680", Offset = "0x7AE480", VA = "0x1807AF680", Slot = "28")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Color? ICHJPJLLHEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7AC740", Offset = "0x7AB540", VA = "0x1807AC740", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7AC710", Offset = "0x7AB510", VA = "0x1807AC710", Slot = "30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public Color? BBIBKEAKLCC
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7AF640", Offset = "0x7AE440", VA = "0x1807AF640", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7AF620", Offset = "0x7AE420", VA = "0x1807AF620", Slot = "32")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public List<NDFFBCJFGDL> HGAMGOGCFIK
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6A0", Offset = "0x7AE4A0", VA = "0x1807AF6A0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7AF660", Offset = "0x7AE460", VA = "0x1807AF660", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7AF6B0", Offset = "0x7AE4B0", VA = "0x1807AF6B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7AF930", Offset = "0x7AE730", VA = "0x1807AF930")]
	public FLGPHJLGCMB(ECHCKEIIPJI DLLLAJJCCDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class DIBMIBDODMO : FLGPHJLGCMB
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7ACF80", Offset = "0x7ABD80", VA = "0x1807ACF80")]
	public DIBMIBDODMO(ECHCKEIIPJI DLLLAJJCCDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class DAKENKIFEPC : OECCPLJEDMM
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public NLEGBBGNFKN HGFBCEGGGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7AC6F0", Offset = "0x7AB4F0", VA = "0x1807AC6F0")]
		[CompilerGenerated]
		get
		{
			return default(NLEGBBGNFKN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7AC700", Offset = "0x7AB500", VA = "0x1807AC700")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool AGJILNCKGCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7AC730", Offset = "0x7AB530", VA = "0x1807AC730")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7AC760", Offset = "0x7AB560", VA = "0x1807AC760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Color? GCICFHOEEIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7AC740", Offset = "0x7AB540", VA = "0x1807AC740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7AC710", Offset = "0x7AB510", VA = "0x1807AC710")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7AC770", Offset = "0x7AB570", VA = "0x1807AC770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7AC9B0", Offset = "0x7AB7B0", VA = "0x1807AC9B0")]
	public DAKENKIFEPC(ECHCKEIIPJI DLLLAJJCCDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum DFKKAIBAMMC
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	FULL,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	MODAL,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SLIDEUP
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class GHDAEECFKDM : JFIKOGBKHBH
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string PHNDDILHBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CC0", Offset = "0x7A7AC0", VA = "0x1807A8CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C50", Offset = "0x7A7A50", VA = "0x1807A8C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string KPMBKJHAJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CB0", Offset = "0x7A7AB0", VA = "0x1807A8CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C60", Offset = "0x7A7A60", VA = "0x1807A8C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string DMKOPGHPGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C70", Offset = "0x7A7A70", VA = "0x1807A8C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C40", Offset = "0x7A7A40", VA = "0x1807A8C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7B10A0", Offset = "0x7AFEA0", VA = "0x1807B10A0")]
	public GHDAEECFKDM(ECHCKEIIPJI DLLLAJJCCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7B0EE0", Offset = "0x7AFCE0", VA = "0x1807B0EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class DLIBPADLFAL : JFIKOGBKHBH
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public string PHNDDILHBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CC0", Offset = "0x7A7AC0", VA = "0x1807A8CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C50", Offset = "0x7A7A50", VA = "0x1807A8C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string PFEINDMBCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CB0", Offset = "0x7A7AB0", VA = "0x1807A8CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C60", Offset = "0x7A7A60", VA = "0x1807A8C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string ILHPKCMLCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C70", Offset = "0x7A7A70", VA = "0x1807A8C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C40", Offset = "0x7A7A40", VA = "0x1807A8C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string KPMBKJHAJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C90", Offset = "0x7A7A90", VA = "0x1807A8C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CA0", Offset = "0x7A7AA0", VA = "0x1807A8CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string DMKOPGHPGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CD0", Offset = "0x7A7AD0", VA = "0x1807A8CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C80", Offset = "0x7A7A80", VA = "0x1807A8C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7AE400", Offset = "0x7AD200", VA = "0x1807AE400")]
	public DLIBPADLFAL(ECHCKEIIPJI DLLLAJJCCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7AE1B0", Offset = "0x7ACFB0", VA = "0x1807AE1B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JFIKOGBKHBH
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string PDICOPOJCGP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string KKPIOFNDDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7A81C0", Offset = "0x7A6FC0", VA = "0x1807A81C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool LLFJFHJJAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1C0", Offset = "0x7ABFC0", VA = "0x1807AD1C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7ACFA0", Offset = "0x7ABDA0", VA = "0x1807ACFA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public long CLAGNOKOCFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7A8200", Offset = "0x7A7000", VA = "0x1807A8200")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7AD150", Offset = "0x7ABF50", VA = "0x1807AD150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public long BABCILOONNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7ACF90", Offset = "0x7ABD90", VA = "0x1807ACF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public HashSet<MOHFJAPENLD> KNPEEAOGMPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7AD180", Offset = "0x7ABF80", VA = "0x1807AD180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private string GALOLNBCOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7AD130", Offset = "0x7ABF30", VA = "0x1807AD130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public Dictionary<string, string> AJDOAJOCLND
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1F0", Offset = "0x7ABFF0", VA = "0x1807AD1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7AD170", Offset = "0x7ABF70", VA = "0x1807AD170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7B2650", Offset = "0x7B1450", VA = "0x1807B2650")]
	public JFIKOGBKHBH(ECHCKEIIPJI DLLLAJJCCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7B20F0", Offset = "0x7B0EF0", VA = "0x1807B20F0")]
	public string LIENAHDHEGJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class APLEBPBHMHC : JFIKOGBKHBH
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string ILHPKCMLCJK
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CC0", Offset = "0x7A7AC0", VA = "0x1807A8CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C50", Offset = "0x7A7A50", VA = "0x1807A8C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string PHNDDILHBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CB0", Offset = "0x7A7AB0", VA = "0x1807A8CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C60", Offset = "0x7A7A60", VA = "0x1807A8C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public string PFEINDMBCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C70", Offset = "0x7A7A70", VA = "0x1807A8C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C40", Offset = "0x7A7A40", VA = "0x1807A8C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public string KPMBKJHAJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C90", Offset = "0x7A7A90", VA = "0x1807A8C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CA0", Offset = "0x7A7AA0", VA = "0x1807A8CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string DMKOPGHPGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CD0", Offset = "0x7A7AD0", VA = "0x1807A8CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C80", Offset = "0x7A7A80", VA = "0x1807A8C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7A8F30", Offset = "0x7A7D30", VA = "0x1807A8F30")]
	public APLEBPBHMHC(ECHCKEIIPJI DLLLAJJCCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7A8CE0", Offset = "0x7A7AE0", VA = "0x1807A8CE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class DJBFJGHEFFJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public string PDICOPOJCGP
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7A81B0", Offset = "0x7A6FB0", VA = "0x1807A81B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string KKPIOFNDDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7A81A0", Offset = "0x7A6FA0", VA = "0x1807A81A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7A81C0", Offset = "0x7A6FC0", VA = "0x1807A81C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool LLFJFHJJAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1C0", Offset = "0x7ABFC0", VA = "0x1807AD1C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7ACFA0", Offset = "0x7ABDA0", VA = "0x1807ACFA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public long CLAGNOKOCFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7A8200", Offset = "0x7A7000", VA = "0x1807A8200")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7AD150", Offset = "0x7ABF50", VA = "0x1807AD150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public long FPIAHJCOAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7ACF90", Offset = "0x7ABD90", VA = "0x1807ACF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public string PHNDDILHBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7AD180", Offset = "0x7ABF80", VA = "0x1807AD180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string PFEINDMBCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7AD190", Offset = "0x7ABF90", VA = "0x1807AD190")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7AD130", Offset = "0x7ABF30", VA = "0x1807AD130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public string ILHPKCMLCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1F0", Offset = "0x7ABFF0", VA = "0x1807AD1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD170", Offset = "0x7ABF70", VA = "0x1807AD170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public string KPMBKJHAJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CC0", Offset = "0x7A7AC0", VA = "0x1807A8CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C50", Offset = "0x7A7A50", VA = "0x1807A8C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public string DMKOPGHPGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CB0", Offset = "0x7A7AB0", VA = "0x1807A8CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C60", Offset = "0x7A7A60", VA = "0x1807A8C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public bool GNDHGJNHNHB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1B0", Offset = "0x7ABFB0", VA = "0x1807AD1B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7AD140", Offset = "0x7ABF40", VA = "0x1807AD140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool IMIBOKGBFBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7AD070", Offset = "0x7ABE70", VA = "0x1807AD070")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1A0", Offset = "0x7ABFA0", VA = "0x1807AD1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool BOLGBIANLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7AD060", Offset = "0x7ABE60", VA = "0x1807AD060")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7AD050", Offset = "0x7ABE50", VA = "0x1807AD050")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool PMJCDCJGLMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7AD1E0", Offset = "0x7ABFE0", VA = "0x1807AD1E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7AD160", Offset = "0x7ABF60", VA = "0x1807AD160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool LDCPJAGJMFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7AD200", Offset = "0x7AC000", VA = "0x1807AD200")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7AD080", Offset = "0x7ABE80", VA = "0x1807AD080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public string GALOLNBCOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C90", Offset = "0x7A7A90", VA = "0x1807A8C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CA0", Offset = "0x7A7AA0", VA = "0x1807A8CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public Dictionary<string, string> AJDOAJOCLND
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CD0", Offset = "0x7A7AD0", VA = "0x1807A8CD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C80", Offset = "0x7A7A80", VA = "0x1807A8C80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7AD8C0", Offset = "0x7AC6C0", VA = "0x1807AD8C0")]
	public DJBFJGHEFFJ(ECHCKEIIPJI DLLLAJJCCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7AD210", Offset = "0x7AC010", VA = "0x1807AD210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7ACFB0", Offset = "0x7ABDB0", VA = "0x1807ACFB0")]
	public void BDDHDPOPLPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7AD090", Offset = "0x7ABE90", VA = "0x1807AD090")]
	public void DJAECIFACEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class BJPOIDGCLEG : JFIKOGBKHBH
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public string PFEINDMBCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CC0", Offset = "0x7A7AC0", VA = "0x1807A8CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C50", Offset = "0x7A7A50", VA = "0x1807A8C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public string ILHPKCMLCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CB0", Offset = "0x7A7AB0", VA = "0x1807A8CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C60", Offset = "0x7A7A60", VA = "0x1807A8C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public string KPMBKJHAJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C70", Offset = "0x7A7A70", VA = "0x1807A8C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C40", Offset = "0x7A7A40", VA = "0x1807A8C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string DMKOPGHPGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7A8C90", Offset = "0x7A7A90", VA = "0x1807A8C90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7A8CA0", Offset = "0x7A7AA0", VA = "0x1807A8CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7AB240", Offset = "0x7AA040", VA = "0x1807AB240")]
	public BJPOIDGCLEG(ECHCKEIIPJI DLLLAJJCCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7AB030", Offset = "0x7A9E30", VA = "0x1807AB030", Slot = "3")]
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
		private NMKLCGDNIDG KPEICGBBLKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private HJFDIFCNCIG EILILGBFPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CIPODDDMHAL iamListener;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7A81C0", Offset = "0x7A6FC0", VA = "0x1807A81C0")]
		public void setPushPromptResponseReceivedDelegate(NMKLCGDNIDG CEFFCMBABHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7A81D0", Offset = "0x7A6FD0", VA = "0x1807A81D0")]
		public void setPushTokenReceivedFromSystemDelegate(HJFDIFCNCIG CEFFCMBABHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7ABE00", Offset = "0x7AAC00", VA = "0x1807ABE00")]
		public void onPushPromptResponseReceived(string JIHOCNLKKAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7ABE70", Offset = "0x7AAC70", VA = "0x1807ABE70")]
		public void onPushTokenReceivedFromSystem(string NBGOKNOECBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7AB750", Offset = "0x7AA550", VA = "0x1807AB750")]
		public void beforeInAppMessageDisplayed(string HJDNIGGLOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7ABB20", Offset = "0x7AA920", VA = "0x1807ABB20")]
		public void onInAppMessageDismissed(string HJDNIGGLOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7ABAC0", Offset = "0x7AA8C0", VA = "0x1807ABAC0")]
		public void onInAppMessageClicked(string HJDNIGGLOBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7AB7B0", Offset = "0x7AA5B0", VA = "0x1807AB7B0")]
		public void onInAppMessageButtonClicked(string MDBNAOGFMFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7ABB80", Offset = "0x7AA980", VA = "0x1807ABB80")]
		public void onInAppMessageHTMLClicked(string MDBNAOGFMFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
		public BrazeInternalComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class BrazeInternalGameObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static GameObject NNOMIIGCPPJ;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private static GameObject AHFNEPHAKHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE90", Offset = "0x7AAC90", VA = "0x1807ABE90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7AC040", Offset = "0x7AAE40", VA = "0x1807AC040")]
		public static void setPushPromptResponseReceivedDelegate(NMKLCGDNIDG CEFFCMBABHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7AC0A0", Offset = "0x7AAEA0", VA = "0x1807AC0A0")]
		public static void setPushTokenReceivedFromSystemDelegate(HJFDIFCNCIG CEFFCMBABHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7ABFE0", Offset = "0x7AADE0", VA = "0x1807ABFE0")]
		public static void setInAppMessageListener(CIPODDDMHAL JEGFNEBKNHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
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
