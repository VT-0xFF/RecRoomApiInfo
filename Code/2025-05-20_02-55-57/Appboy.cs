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
public interface DGIODDCDFEA
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ApplePushNotificationTester : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9F0D90", Offset = "0x9EFF90", VA = "0x1809F0D90")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x9F0840", Offset = "0x9EFA40", VA = "0x1809F0840")]
	public string PrintOutObjectValues(object MOGOANMOMMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
	public ApplePushNotificationTester()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum KCEAHCFPBAE
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
public enum IDLIBHFIOML
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	IAM_DISPLAY_NOW,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	IAM_DISPLAY_LATER,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	IAM_DISCARD
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void CGOPMOIBILE(bool GEBCECGOCAM);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void NIOHIHLODOA(string PPOILDCNBFL);
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AppboyBinding : SingletonMonoBehaviour<AppboyBinding>
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static DGIODDCDFEA MCGKOKELAJL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static DGIODDCDFEA PHEJDNBPGHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9F0800", Offset = "0x9EFA00", VA = "0x1809F0800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static EIBLFAMJJIA FKDBOFONAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void LogCustomEvent(string LNEPIHEFEID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void LogCustomEvent(string LNEPIHEFEID, Dictionary<string, object> PPDPHFAEOEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void LogPurchase(string DOCPPNJBIFF, string FFDIAHOOHHO, decimal CDLHEIHGPNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void LogPurchase(string DOCPPNJBIFF, string FFDIAHOOHHO, decimal CDLHEIHGPNH, int BJDKEGOHCNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void LogPurchase(string DOCPPNJBIFF, string FFDIAHOOHHO, decimal CDLHEIHGPNH, int BJDKEGOHCNL, Dictionary<string, object> PPDPHFAEOEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ChangeUser(string LPPHMJBHDIM, [Optional] string HKBEMHABANA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetSdkAuthenticationSignature(string HKBEMHABANA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetUserFirstName(string HFLIIAFLBMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetUserLastName(string MLBOMOEHMGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetUserEmail(string CGMDGMIOGLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetUserGender(AMNKJJBLPGE JNCCCDJJFFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetUserDateOfBirth(int IKPEDABJACA, int BOPFGGPHCDF, int AJMEJNMJKLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetUserCountry(string MNLPBIHICLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetUserHomeCity(string MEOKMCOCCDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetUserEmailNotificationSubscriptionType(IMNENAPDJDH EIINOHLOOAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetUserPushNotificationSubscriptionType(IMNENAPDJDH CKEOGDBPJPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetUserPhoneNumber(string DDJCLIJAKDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetCustomUserAttribute(string AGBHGDFILGO, bool MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetCustomUserAttribute(string AGBHGDFILGO, int MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetCustomUserAttribute(string AGBHGDFILGO, float MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetCustomUserAttribute(string AGBHGDFILGO, string MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetCustomUserAttributeToNow(string AGBHGDFILGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetCustomUserAttributeToSecondsFromEpoch(string AGBHGDFILGO, long BLKBECLPMEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void UnsetCustomUserAttribute(string AGBHGDFILGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void IncrementCustomUserAttribute(string AGBHGDFILGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void IncrementCustomUserAttribute(string AGBHGDFILGO, int NKDEGIGNKFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetCustomUserAttributeArray(string AGBHGDFILGO, List<string> CABEAFGDMFF, int JAFKPMJIGFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void AddToCustomUserAttributeArray(string AGBHGDFILGO, string MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void RemoveFromCustomUserAttributeArray(string AGBHGDFILGO, string MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void setUserFacebookData(string CEFBGMGHKEP, string HFLIIAFLBMB, string MLBOMOEHMGK, string CGMDGMIOGLK, string OGFLNNGNNME, string DKDFCCCNJEL, AMNKJJBLPGE? JNCCCDJJFFE, int? FBADCOLFIDN, string CJNDGAGCDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void setUserTwitterData(int? GHIBFOFBPHF, string LCLIDNMPEFN, string DGIAFBEDPNJ, string CMDDDPOOGFO, int? PGLAGADHOFP, int? MDKEODKNGCG, int? FENGIIEOBEN, string LNDKGKAGKOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetUserLastKnownLocation(double MPHBGFHPHCI, double CNJEDLBGHFA, [Optional] double? LMJGDKBADLJ, [Optional] double? JLNBGBALPBD, [Optional] double? LFLFOLMPDPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void PromptUserForPushPermissions(bool EPFPEFEOMCL, [Optional] CGOPMOIBILE BMOBMAMEPLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetPushTokenReceivedFromSystemDelegate(NIOHIHLODOA LHAHJIJICEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void LogInAppMessageClicked(string MIIODICFDDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void LogInAppMessageImpression(string MIIODICFDDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void LogInAppMessageButtonClicked(string MIIODICFDDM, int LLNECBOGKGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void RequestFeedRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void RequestFeedRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void LogFeedDisplayed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void RequestContentCardsRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void RequestContentCardsRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void LogContentCardClicked(string IHLOBNGOGFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void LogContentCardImpression(string IHLOBNGOGFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void LogContentCardDismissed(string IHLOBNGOGFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void WipeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void EnableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void DisableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0")]
		public static string GetInstallTrackingId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetAttributionData(string BAMILHLHBEA, string AJMIEHFFKHN, string PHDDMGGFGKN, string GBOFKPMBCGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void RequestLocationInitialization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void RequestGeofences(decimal MPHBGFHPHCI, decimal CNJEDLBGHFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void RequestImmediateDataFlush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void AddAlias(string AHNMNHGCLLC, string BFICFCBIIPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void ConfigureListener(KCEAHCFPBAE EKOBCPAOKFI, string KOIHJBJADED, string IPBOIENDBHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void SetInAppMessageDisplayAction(IDLIBHFIOML PCFJEAJPDAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void DisplayNextInAppMessage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void DisplayContentCards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void AddToSubscriptionGroup(string MKHHKDJKLDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0")]
		public static void RemoveFromSubscriptionGroup(string MKHHKDJKLDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9F07C0", Offset = "0x9EF9C0", VA = "0x1809F07C0")]
		public AppboyBinding()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class EIBLFAMJJIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Action<HMGDHGNEJIJ> GLGMHEGGIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Action<HMGDHGNEJIJ> ELDCEEADINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Action<HMGDHGNEJIJ> HLOACMMLCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Action<HMGDHGNEJIJ, NLDBBMEMPKA> BBHFJOICOCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public Action<HMGDHGNEJIJ, Uri> AKKAOADCAOO;
}
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AppboyBindingTester : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9F0710", Offset = "0x9EF910", VA = "0x1809F0710")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9EF730", Offset = "0x9EE930", VA = "0x1809EF730")]
		private void ACILONJLGKG(string BDAAPBJEHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9EF920", Offset = "0x9EEB20", VA = "0x1809EF920")]
		private void DGMGDHNIDPD(string BDAAPBJEHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9F06A0", Offset = "0x9EF8A0", VA = "0x1809F06A0")]
		private void PHNJJBCDDLK(string BDAAPBJEHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9F01F0", Offset = "0x9EF3F0", VA = "0x1809F01F0")]
		private void MOPGMLJBBGE(string BDAAPBJEHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9EF810", Offset = "0x9EEA10", VA = "0x1809EF810")]
		private void CNMLFBHECPI(string BDAAPBJEHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0300", Offset = "0x9EF500", VA = "0x1809F0300")]
		private void NCLCLODBBMM(string BDAAPBJEHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0090", Offset = "0x9EF290", VA = "0x1809F0090")]
		private void LMFFMKNPJLO(string BDAAPBJEHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9F0460", Offset = "0x9EF660", VA = "0x1809F0460")]
		private void NGHMDBKEAPP(string BDAAPBJEHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9EFC50", Offset = "0x9EEE50", VA = "0x1809EFC50")]
		private void LEAOLJBHOKE(string BDAAPBJEHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9EF990", Offset = "0x9EEB90", VA = "0x1809EF990")]
		private void HEIIPMHOOKL(string BDAAPBJEHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA00", Offset = "0x9EEC00", VA = "0x1809EFA00")]
		public static void InAppMessageBeforeDisplayed(HMGDHGNEJIJ BDAAPBJEHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9EFB60", Offset = "0x9EED60", VA = "0x1809EFB60")]
		public static void InAppMessageDismissed(HMGDHGNEJIJ BDAAPBJEHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9EFAF0", Offset = "0x9EECF0", VA = "0x1809EFAF0")]
		public static void InAppMessageClicked(HMGDHGNEJIJ BDAAPBJEHGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9EFA70", Offset = "0x9EEC70", VA = "0x1809EFA70")]
		public static void InAppMessageButtonClicked(HMGDHGNEJIJ BDAAPBJEHGD, NLDBBMEMPKA BBNFNCPPELK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9EFBD0", Offset = "0x9EEDD0", VA = "0x1809EFBD0")]
		public static void InAppMessageHTMLClicked(HMGDHGNEJIJ BDAAPBJEHGD, Uri MHOKJBEEIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public AppboyBindingTester()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class DEOIJLJEDFH
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x9F3AC0", Offset = "0x9F2CC0", VA = "0x1809F3AC0")]
	public static string HFPNJBDENLJ(Dictionary<string, string> IEEHHNMCCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3663430", Offset = "0x3662630", VA = "0x183663430")]
	public static string NHCIFDLHFHH<T>(List<T> MEHAOGGFJIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CCOFMCINKDP
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x9F2020", Offset = "0x9F1220", VA = "0x1809F2020")]
	public static Color? LAIBHENHDEE(string OHOHJHMAELD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x9F1D30", Offset = "0x9F0F30", VA = "0x1809F1D30")]
	public static Color LAIBHENHDEE(int OHOHJHMAELD)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OALIHFPEPKN
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9FD4B0", Offset = "0x9FC6B0", VA = "0x1809FD4B0")]
	public static object ONGMIMEBEHB(Type CIPDLJOCAPI, string MLCDCHNOCFI, bool NOAKMPHBDPD, object FAGKKFIFNNI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JPIKPIHJLJN
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x9F7D70", Offset = "0x9F6F70", VA = "0x1809F7D70")]
	public static Dictionary<string, string> BNHADKJOEHB(JEHFANAFIPH LEGJNCGODJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BEBEKGOCNEL
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class JBOMLJHJPME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private StringBuilder IBLPFKMMCPG;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9F53B0", Offset = "0x9F45B0", VA = "0x1809F53B0")]
		private JBOMLJHJPME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9F11F0", Offset = "0x9F03F0", VA = "0x1809F11F0")]
		public static string CEBCPPBDNIB(object DBCLNEGBNLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9F4650", Offset = "0x9F3850", VA = "0x1809F4650")]
		private void COIBLIFHIJO(object MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9F4B30", Offset = "0x9F3D30", VA = "0x1809F4B30")]
		private void EBKCPJJKDBC(IDictionary DBCLNEGBNLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9F5160", Offset = "0x9F4360", VA = "0x1809F5160")]
		private void NFCIJDPLODP(IList CABEAFGDMFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9F4E20", Offset = "0x9F4020", VA = "0x1809F4E20")]
		private void GHCHNDMPLFB(string AKCEGHPGLOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9F4840", Offset = "0x9F3A40", VA = "0x1809F4840")]
		private void EAHKKAFLJFE(object MLCDCHNOCFI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static NumberFormatInfo MJELAIJKCPB;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x9F11F0", Offset = "0x9F03F0", VA = "0x1809F11F0")]
	public static string CEBCPPBDNIB(object DBCLNEGBNLN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public class JFHLHNINCPF
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public virtual JFHLHNINCPF JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public virtual JFHLHNINCPF JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual string ABLHJAOAOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9F65D0", Offset = "0x9F57D0", VA = "0x1809F65D0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public virtual int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public virtual int JNOLIPECDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9F6950", Offset = "0x9F5B50", VA = "0x1809F6950", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9F6990", Offset = "0x9F5B90", VA = "0x1809F6990", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual bool JDNGKCEDHBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9F5CB0", Offset = "0x9F4EB0", VA = "0x1809F5CB0", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9F6850", Offset = "0x9F5A50", VA = "0x1809F6850", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public virtual NLEKIODJLNM EAMOEODHEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9F5C30", Offset = "0x9F4E30", VA = "0x1809F5C30", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public virtual JEHFANAFIPH KKKENCKFFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9F68D0", Offset = "0x9F5AD0", VA = "0x1809F68D0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public virtual void OOLDDNFEGEK(string LCBFHANEHGM, JFHLHNINCPF GINHGCKBLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x9F6B40", Offset = "0x9F5D40", VA = "0x1809F6B40", Slot = "10")]
	public virtual void OOLDDNFEGEK(JFHLHNINCPF GINHGCKBLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BA0", Offset = "0x9F5DA0", VA = "0x1809F6BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x9F6A50", Offset = "0x9F5C50", VA = "0x1809F6A50")]
	public static JFHLHNINCPF NEKLFDMHCNA(string NFEAHFMGOCB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9F6AC0", Offset = "0x9F5CC0", VA = "0x1809F6AC0")]
	public static string NEKLFDMHCNA(JFHLHNINCPF BEJBCBEBEAC)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x9F69D0", Offset = "0x9F5BD0", VA = "0x1809F69D0")]
	public static bool NDBPPCEOMJH(JFHLHNINCPF FCKEKMKDGOB, object PMDPDEMGJJE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x9F6600", Offset = "0x9F5800", VA = "0x1809F6600")]
	public static bool EFJOOJHLAGB(JFHLHNINCPF FCKEKMKDGOB, object PMDPDEMGJJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x9F6680", Offset = "0x9F5880", VA = "0x1809F6680", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9F6690", Offset = "0x9F5890", VA = "0x1809F6690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x9F66A0", Offset = "0x9F58A0", VA = "0x1809F66A0")]
	internal static string IIMEGCAFDGB(string HHMMOILIJGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x9F5D60", Offset = "0x9F4F60", VA = "0x1809F5D60")]
	public static JFHLHNINCPF DJLDICFOPAG(string EONODLIAHHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public JFHLHNINCPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DefaultMember("Item")]
public class NLEKIODJLNM : JFHLHNINCPF, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class PPAJILPHMKB : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public NLEKIODJLNM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<JFHLHNINCPF>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public PPAJILPHMKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9FFFE0", Offset = "0x9FF1E0", VA = "0x1809FFFE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9FFDE0", Offset = "0x9FEFE0", VA = "0x1809FFDE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9FFD90", Offset = "0x9FEF90", VA = "0x1809FFD90")]
		private void CKKMGPGLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF90", Offset = "0x9FF190", VA = "0x1809FFF90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<JFHLHNINCPF> FEHDPGFDOIC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override JFHLHNINCPF JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9FCFF0", Offset = "0x9FC1F0", VA = "0x1809FCFF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override JFHLHNINCPF JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9FD0C0", Offset = "0x9FC2C0", VA = "0x1809FD0C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9FD1C0", Offset = "0x9FC3C0", VA = "0x1809FD1C0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x9FD200", Offset = "0x9FC400", VA = "0x1809FD200", Slot = "4")]
	public override void OOLDDNFEGEK(string LCBFHANEHGM, JFHLHNINCPF GINHGCKBLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x9FD140", Offset = "0x9FC340", VA = "0x1809FD140", Slot = "17")]
	[IteratorStateMachine(typeof(PPAJILPHMKB))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x9FD260", Offset = "0x9FC460", VA = "0x1809FD260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9FD420", Offset = "0x9FC620", VA = "0x1809FD420")]
	public NLEKIODJLNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class JEHFANAFIPH : JFHLHNINCPF, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class EGAFAGBKDEN : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public JEHFANAFIPH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Dictionary<string, JFHLHNINCPF>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9F4070", Offset = "0x9F3270", VA = "0x1809F4070")]
		[DebuggerHidden]
		public EGAFAGBKDEN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9F3FE0", Offset = "0x9F31E0", VA = "0x1809F3FE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9F3D70", Offset = "0x9F2F70", VA = "0x1809F3D70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9F3D20", Offset = "0x9F2F20", VA = "0x1809F3D20")]
		private void CKKMGPGLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9F3F90", Offset = "0x9F3190", VA = "0x1809F3F90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Dictionary<string, JFHLHNINCPF> LNONDNNHMED;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override JFHLHNINCPF JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9F54D0", Offset = "0x9F46D0", VA = "0x1809F54D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override JFHLHNINCPF JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9F5430", Offset = "0x9F4630", VA = "0x1809F5430", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9F5640", Offset = "0x9F4840", VA = "0x1809F5640", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x9F5690", Offset = "0x9F4890", VA = "0x1809F5690", Slot = "4")]
	public override void OOLDDNFEGEK(string LCBFHANEHGM, JFHLHNINCPF GINHGCKBLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x9F55C0", Offset = "0x9F47C0", VA = "0x1809F55C0", Slot = "17")]
	[IteratorStateMachine(typeof(EGAFAGBKDEN))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x9F57A0", Offset = "0x9F49A0", VA = "0x1809F57A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9F5BA0", Offset = "0x9F4DA0", VA = "0x1809F5BA0")]
	public JEHFANAFIPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NCGALJALADO : JFHLHNINCPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private string JICMMJPGGKM;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public override string ABLHJAOAOGP
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x9FB1E0", Offset = "0x9FA3E0", VA = "0x1809FB1E0")]
	public NCGALJALADO(string EJNPKIDABIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x9FB260", Offset = "0x9FA460", VA = "0x1809FB260")]
	public NCGALJALADO(bool EJNPKIDABIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x9FB220", Offset = "0x9FA420", VA = "0x1809FB220")]
	public NCGALJALADO(int EJNPKIDABIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x9FB190", Offset = "0x9FA390", VA = "0x1809FB190", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
internal class PCKIKLBIACC : JFHLHNINCPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private JFHLHNINCPF DAOFIDHOIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private string OPFNCFDACMA;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public override JFHLHNINCPF JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x9FF4A0", Offset = "0x9FE6A0", VA = "0x1809FF4A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public override JFHLHNINCPF JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x9FF520", Offset = "0x9FE720", VA = "0x1809FF520", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override int JNOLIPECDAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9FF940", Offset = "0x9FEB40", VA = "0x1809FF940", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9FFA10", Offset = "0x9FEC10", VA = "0x1809FFA10", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override bool JDNGKCEDHBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9FF6D0", Offset = "0x9FE8D0", VA = "0x1809FF6D0", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9FF7B0", Offset = "0x9FE9B0", VA = "0x1809FF7B0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override NLEKIODJLNM EAMOEODHEJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9FF5B0", Offset = "0x9FE7B0", VA = "0x1809FF5B0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override JEHFANAFIPH KKKENCKFFLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x9FF890", Offset = "0x9FEA90", VA = "0x1809FF890", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x9FFCF0", Offset = "0x9FEEF0", VA = "0x1809FFCF0")]
	public PCKIKLBIACC(JFHLHNINCPF LMFHOAHGBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x9FFD40", Offset = "0x9FEF40", VA = "0x1809FFD40")]
	public PCKIKLBIACC(JFHLHNINCPF LMFHOAHGBBG, string LCBFHANEHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x9FF660", Offset = "0x9FE860", VA = "0x1809FF660")]
	private void DENBCCCLIHH(JFHLHNINCPF JNJFGPNMDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x9FFBE0", Offset = "0x9FEDE0", VA = "0x1809FFBE0", Slot = "10")]
	public override void OOLDDNFEGEK(JFHLHNINCPF GINHGCKBLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x9FFAF0", Offset = "0x9FECF0", VA = "0x1809FFAF0", Slot = "4")]
	public override void OOLDDNFEGEK(string LCBFHANEHGM, JFHLHNINCPF GINHGCKBLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x9FF7A0", Offset = "0x9FE9A0", VA = "0x1809FF7A0", Slot = "0")]
	public override bool Equals(object DBCLNEGBNLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x9F6690", Offset = "0x9F5890", VA = "0x1809F6690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x9FFCC0", Offset = "0x9FEEC0", VA = "0x1809FFCC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MEMABKHKDON
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x9FA610", Offset = "0x9F9810", VA = "0x1809FA610")]
	public static JFHLHNINCPF DJLDICFOPAG(string EONODLIAHHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum IMNENAPDJDH
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	OPTED_IN,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	SUBSCRIBED,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	UNSUBSCRIBED
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NKDHNDOHPFE
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MPMNCHDFKOO HKCOKBHDGDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int PKNGDLLAGIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3B0", Offset = "0x9FA5B0", VA = "0x1809FB3B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string LICEPMMGONG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int FEKBMICNAIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3C0", Offset = "0x9FA5C0", VA = "0x1809FB3C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IDictionary<string, object> DOLLMGBPIFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x9FC1B0", Offset = "0x9FB3B0", VA = "0x1809FC1B0")]
	public NKDHNDOHPFE(JEHFANAFIPH LEGJNCGODJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x9FB3D0", Offset = "0x9FA5D0", VA = "0x1809FB3D0")]
	private object JHNMGKJDCOI(JFHLHNINCPF GCEDHPINDAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x9FBB00", Offset = "0x9FAD00", VA = "0x1809FBB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class MPMNCHDFKOO
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IList<string> MONLDLBCBDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string OOOHIFKEJMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public string DOANALMEDIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public string JGBMCEJKJIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public string LALPBNDIEDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x9FABC0", Offset = "0x9F9DC0", VA = "0x1809FABC0")]
	public MPMNCHDFKOO(JEHFANAFIPH LEGJNCGODJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x9FA780", Offset = "0x9F9980", VA = "0x1809FA780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum IGFEOENGGAL
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
public enum IIMMHGBLJIJ
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	NEWS_FEED,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	URI,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	NONE
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum GFKMAPFAJNN
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	AUTO_DISMISS,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	SWIPE
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KCBOEENIPEB
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public List<DDMPKDBEKGC> MBODGHLLNPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool NOJGKPDPOIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9F8320", Offset = "0x9F7520", VA = "0x1809F8320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x9F8580", Offset = "0x9F7780", VA = "0x1809F8580")]
	public KCBOEENIPEB(string BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x9F8330", Offset = "0x9F7530", VA = "0x1809F8330")]
	private static DDMPKDBEKGC MMJDABCPMMH(JEHFANAFIPH LEGJNCGODJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum AMNKJJBLPGE
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
public class OFHGNLEPCLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string HPLIDFCOABC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string CPEKBNDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string KFAPGKMNLIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Dictionary<string, string> FEHDAEPINHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9FA750", Offset = "0x9F9950", VA = "0x1809FA750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int FGNNMJCFGOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9FD530", Offset = "0x9FC730", VA = "0x1809FD530")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9FD8D0", Offset = "0x9FCAD0", VA = "0x1809FD8D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public long EOPEDDIHAHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9FD8C0", Offset = "0x9FCAC0", VA = "0x1809FD8C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string JFNOKFLCCGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x9FDDB0", Offset = "0x9FCFB0", VA = "0x1809FDDB0")]
	public OFHGNLEPCLJ(string BDAAPBJEHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x9FDAC0", Offset = "0x9FCCC0", VA = "0x1809FDAC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x9FD540", Offset = "0x9FC740", VA = "0x1809FD540")]
	private string IPJLGPKLKEL(JEHFANAFIPH LEGJNCGODJJ, string AGBHGDFILGO, string FAGKKFIFNNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x9FD6E0", Offset = "0x9FC8E0", VA = "0x1809FD6E0")]
	private int JLCHCCMMNDE(JEHFANAFIPH LEGJNCGODJJ, string AGBHGDFILGO, int FAGKKFIFNNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x9FD8E0", Offset = "0x9FCAE0", VA = "0x1809FD8E0")]
	private long PEFAOOCPGAK(JEHFANAFIPH LEGJNCGODJJ, string AGBHGDFILGO, long FAGKKFIFNNI)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum HNAOAHEGHEK
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	TOP,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	BOTTOM
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface HMGDHGNEJIJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface AOIDCAFBNEN
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	List<NLDBBMEMPKA> PKIMPMKNEEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class LAALNIDIBGI : HMGDHGNEJIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected string JGAGONINEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int BBDDPFJHLBB;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Color? EFMMGJNOOBK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F8740", VA = "0x1809F9540", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9F9580", Offset = "0x9F8780", VA = "0x1809F9580", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Color? MFHFLMLLICD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9F9590", Offset = "0x9F8790", VA = "0x1809F9590", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9F95C0", Offset = "0x9F87C0", VA = "0x1809F95C0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string PGHBLBMIIKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9F24A0", Offset = "0x9F16A0", VA = "0x1809F24A0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Color? JKEFBPPDDCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9F9410", Offset = "0x9F8610", VA = "0x1809F9410", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9F9500", Offset = "0x9F8700", VA = "0x1809F9500", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Color? CMGEAECFIFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9F9520", Offset = "0x9F8720", VA = "0x1809F9520", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9F9480", Offset = "0x9F8680", VA = "0x1809F9480", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string JMJKOJBLDPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8670", VA = "0x1809F9470", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9F93F0", Offset = "0x9F85F0", VA = "0x1809F93F0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string FIKKCGNKHHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9F94E0", Offset = "0x9F86E0", VA = "0x1809F94E0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9F95B0", Offset = "0x9F87B0", VA = "0x1809F95B0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Dictionary<string, string> FEHDAEPINHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9F9460", Offset = "0x9F8660", VA = "0x1809F9460", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9F94A0", Offset = "0x9F86A0", VA = "0x1809F94A0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IIMMHGBLJIJ GAMCMJNFDIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9F9490", Offset = "0x9F8690", VA = "0x1809F9490", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(IIMMHGBLJIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9F9560", Offset = "0x9F8760", VA = "0x1809F9560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string DAMCHJDPPJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9F9400", Offset = "0x9F8600", VA = "0x1809F9400", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9F94C0", Offset = "0x9F86C0", VA = "0x1809F94C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public GFKMAPFAJNN PLIAONJOEIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9F9510", Offset = "0x9F8710", VA = "0x1809F9510", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(GFKMAPFAJNN);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9F9570", Offset = "0x9F8770", VA = "0x1809F9570", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int INDJCIBJDOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0", Slot = "24")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x9F9430", Offset = "0x9F8630", VA = "0x1809F9430", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x9F95D0", Offset = "0x9F87D0", VA = "0x1809F95D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x9F9B80", Offset = "0x9F8D80", VA = "0x1809F9B80")]
	public LAALNIDIBGI(JEHFANAFIPH LEGJNCGODJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NLDBBMEMPKA
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int KNCAGHHFNKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string FHFPDDDDGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string DAMCHJDPPJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public IIMMHGBLJIJ HFACGCMKOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0")]
		[CompilerGenerated]
		get
		{
			return default(IIMMHGBLJIJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3C0", Offset = "0x9FA5C0", VA = "0x1809FB3C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public Color? MFHFLMLLICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x9FC800", Offset = "0x9FBA00", VA = "0x1809FC800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x9FC820", Offset = "0x9FBA20", VA = "0x1809FC820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Color? EFMMGJNOOBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7D0", Offset = "0x9FB9D0", VA = "0x1809FC7D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7F0", Offset = "0x9FB9F0", VA = "0x1809FC7F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x9FC830", Offset = "0x9FBA30", VA = "0x1809FC830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x9FCB10", Offset = "0x9FBD10", VA = "0x1809FCB10")]
	public NLDBBMEMPKA(JEHFANAFIPH LEGJNCGODJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class MOGKEAHBPGP
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x9FA620", Offset = "0x9F9820", VA = "0x1809FA620")]
	public static JEHFANAFIPH MEIBEEGNNHM(string CCINIIIIHDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class JPJIKPEEDFM
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x9F8070", Offset = "0x9F7270", VA = "0x1809F8070")]
	public static HMGDHGNEJIJ FHDPMLMKEBL(string MIIODICFDDM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AKHNKBJPKOD : KEILLIADGAL
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x9EF720", Offset = "0x9EE920", VA = "0x1809EF720")]
	public AKHNKBJPKOD(JEHFANAFIPH LEGJNCGODJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class KEILLIADGAL : LAALNIDIBGI, AOIDCAFBNEN
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string NKDALLIPOPA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x9F8B10", Offset = "0x9F7D10", VA = "0x1809F8B10", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9F8AD0", Offset = "0x9F7CD0", VA = "0x1809F8AD0", Slot = "28")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Color? ADMGFLNPMON
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9EF200", Offset = "0x9EE400", VA = "0x1809EF200", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1D0", Offset = "0x9EE3D0", VA = "0x1809EF1D0", Slot = "30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public Color? DFIEEFAGOPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9F8B40", Offset = "0x9F7D40", VA = "0x1809F8B40", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9F8AF0", Offset = "0x9F7CF0", VA = "0x1809F8AF0", Slot = "32")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public List<NLDBBMEMPKA> PKIMPMKNEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9F8AC0", Offset = "0x9F7CC0", VA = "0x1809F8AC0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9F8B20", Offset = "0x9F7D20", VA = "0x1809F8B20", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x9F8B60", Offset = "0x9F7D60", VA = "0x1809F8B60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x9F8DE0", Offset = "0x9F7FE0", VA = "0x1809F8DE0")]
	public KEILLIADGAL(JEHFANAFIPH LEGJNCGODJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class MMKBBMOFMFK : KEILLIADGAL
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x9EF720", Offset = "0x9EE920", VA = "0x1809EF720")]
	public MMKBBMOFMFK(JEHFANAFIPH LEGJNCGODJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class ABPDJHPFPME : LAALNIDIBGI
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public HNAOAHEGHEK DEONJOPAOEP
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1B0", Offset = "0x9EE3B0", VA = "0x1809EF1B0")]
		[CompilerGenerated]
		get
		{
			return default(HNAOAHEGHEK);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1C0", Offset = "0x9EE3C0", VA = "0x1809EF1C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool OFIDJBJJBOB
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9EF220", Offset = "0x9EE420", VA = "0x1809EF220")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1F0", Offset = "0x9EE3F0", VA = "0x1809EF1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Color? MBLFKKLFPAI
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9EF200", Offset = "0x9EE400", VA = "0x1809EF200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9EF1D0", Offset = "0x9EE3D0", VA = "0x1809EF1D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x9EF230", Offset = "0x9EE430", VA = "0x1809EF230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x9EF470", Offset = "0x9EE670", VA = "0x1809EF470")]
	public ABPDJHPFPME(JEHFANAFIPH LEGJNCGODJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum IILBLNGEKFB
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	FULL,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	MODAL,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	SLIDEUP
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class HIELHOBPCBN : DDMPKDBEKGC
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string IDMLBMPPFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F24B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string LFCFKBENPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9F32E0", Offset = "0x9F24E0", VA = "0x1809F32E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9F3300", Offset = "0x9F2500", VA = "0x1809F3300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string LLHHLANAEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x9F32C0", Offset = "0x9F24C0", VA = "0x1809F32C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9F32D0", Offset = "0x9F24D0", VA = "0x1809F32D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x9F4260", Offset = "0x9F3460", VA = "0x1809F4260")]
	public HIELHOBPCBN(JEHFANAFIPH LEGJNCGODJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x9F40A0", Offset = "0x9F32A0", VA = "0x1809F40A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class DEHMNPMAJHC : DDMPKDBEKGC
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public string IDMLBMPPFGM
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F24B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string CPEKBNDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9F32E0", Offset = "0x9F24E0", VA = "0x1809F32E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9F3300", Offset = "0x9F2500", VA = "0x1809F3300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string BOAMNMPIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9F32C0", Offset = "0x9F24C0", VA = "0x1809F32C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9F32D0", Offset = "0x9F24D0", VA = "0x1809F32D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string LFCFKBENPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9F32F0", Offset = "0x9F24F0", VA = "0x1809F32F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F24A0", VA = "0x1809F32A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string LLHHLANAEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x9F3280", Offset = "0x9F2480", VA = "0x1809F3280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9F3310", Offset = "0x9F2510", VA = "0x1809F3310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x9F3570", Offset = "0x9F2770", VA = "0x1809F3570")]
	public DEHMNPMAJHC(JEHFANAFIPH LEGJNCGODJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x9F3320", Offset = "0x9F2520", VA = "0x1809F3320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class DDMPKDBEKGC
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string EOGCJFGJIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string AFGCMPJBOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool PMOLCNIKLKM
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x9F2490", Offset = "0x9F1690", VA = "0x1809F2490")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x9F24F0", Offset = "0x9F16F0", VA = "0x1809F24F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public long OGOMPKJCOCB
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x9F2520", Offset = "0x9F1720", VA = "0x1809F2520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public long DIOJOKPNIMK
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x9F24C0", Offset = "0x9F16C0", VA = "0x1809F24C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public HashSet<IGFEOENGGAL> IPHJKFJIPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private string GKPKFPHACDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public Dictionary<string, string> FEHDAEPINHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9F24A0", Offset = "0x9F16A0", VA = "0x1809F24A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x9F28B0", Offset = "0x9F1AB0", VA = "0x1809F28B0")]
	public DDMPKDBEKGC(JEHFANAFIPH LEGJNCGODJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x9F2530", Offset = "0x9F1730", VA = "0x1809F2530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x9F2270", Offset = "0x9F1470", VA = "0x1809F2270")]
	public string AMHACLJOEKA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class OLFIKMIJEII : DDMPKDBEKGC
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string BOAMNMPIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F24B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string IDMLBMPPFGM
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x9F32E0", Offset = "0x9F24E0", VA = "0x1809F32E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x9F3300", Offset = "0x9F2500", VA = "0x1809F3300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public string CPEKBNDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x9F32C0", Offset = "0x9F24C0", VA = "0x1809F32C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x9F32D0", Offset = "0x9F24D0", VA = "0x1809F32D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public string LFCFKBENPPP
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x9F32F0", Offset = "0x9F24F0", VA = "0x1809F32F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F24A0", VA = "0x1809F32A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string LLHHLANAEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9F3280", Offset = "0x9F2480", VA = "0x1809F3280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9F3310", Offset = "0x9F2510", VA = "0x1809F3310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x9FEE80", Offset = "0x9FE080", VA = "0x1809FEE80")]
	public OLFIKMIJEII(JEHFANAFIPH LEGJNCGODJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x9FEC30", Offset = "0x9FDE30", VA = "0x1809FEC30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class JNDDCNJOKOH
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public string EOGCJFGJIFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string AFGCMPJBOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool PMOLCNIKLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x9F2490", Offset = "0x9F1690", VA = "0x1809F2490")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x9F24F0", Offset = "0x9F16F0", VA = "0x1809F24F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public long OGOMPKJCOCB
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9F2520", Offset = "0x9F1720", VA = "0x1809F2520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public long HAIOIMBKLPN
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x9F24C0", Offset = "0x9F16C0", VA = "0x1809F24C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public string IDMLBMPPFGM
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x9F2470", Offset = "0x9F1670", VA = "0x1809F2470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string CPEKBNDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9F24B0", Offset = "0x9F16B0", VA = "0x1809F24B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public string BOAMNMPIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x9F2450", Offset = "0x9F1650", VA = "0x1809F2450")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9F24A0", Offset = "0x9F16A0", VA = "0x1809F24A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public string LFCFKBENPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F24B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public string LLHHLANAEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9F32E0", Offset = "0x9F24E0", VA = "0x1809F32E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9F3300", Offset = "0x9F2500", VA = "0x1809F3300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public bool EGEBEPLLIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D80", Offset = "0x9F5F80", VA = "0x1809F6D80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D60", Offset = "0x9F5F60", VA = "0x1809F6D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool JENAHOCNGNL
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D50", Offset = "0x9F5F50", VA = "0x1809F6D50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9F6DC0", Offset = "0x9F5FC0", VA = "0x1809F6DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool NOJLCKHKIGK
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6DA0", Offset = "0x9F5FA0", VA = "0x1809F6DA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BF0", Offset = "0x9F5DF0", VA = "0x1809F6BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool DINPFOOADNO
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x9F6DB0", Offset = "0x9F5FB0", VA = "0x1809F6DB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6D70", Offset = "0x9F5F70", VA = "0x1809F6D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool AJHJPNNHKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BE0", Offset = "0x9F5DE0", VA = "0x1809F6BE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9F6CA0", Offset = "0x9F5EA0", VA = "0x1809F6CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public string GKPKFPHACDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9F32F0", Offset = "0x9F24F0", VA = "0x1809F32F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F24A0", VA = "0x1809F32A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public Dictionary<string, string> FEHDAEPINHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9F3280", Offset = "0x9F2480", VA = "0x1809F3280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x9F3310", Offset = "0x9F2510", VA = "0x1809F3310")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x9F7480", Offset = "0x9F6680", VA = "0x1809F7480")]
	public JNDDCNJOKOH(JEHFANAFIPH LEGJNCGODJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x9F6DD0", Offset = "0x9F5FD0", VA = "0x1809F6DD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x9F6C00", Offset = "0x9F5E00", VA = "0x1809F6C00")]
	public void EBCDPPEPEBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x9F6CB0", Offset = "0x9F5EB0", VA = "0x1809F6CB0")]
	public void EPINFCJFMEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class OHAOEGELMBF : DDMPKDBEKGC
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public string CPEKBNDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F24B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public string BOAMNMPIPFN
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x9F32E0", Offset = "0x9F24E0", VA = "0x1809F32E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9F3300", Offset = "0x9F2500", VA = "0x1809F3300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public string LFCFKBENPPP
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9F32C0", Offset = "0x9F24C0", VA = "0x1809F32C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9F32D0", Offset = "0x9F24D0", VA = "0x1809F32D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string LLHHLANAEAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9F32F0", Offset = "0x9F24F0", VA = "0x1809F32F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9F32A0", Offset = "0x9F24A0", VA = "0x1809F32A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x9FE720", Offset = "0x9FD920", VA = "0x1809FE720")]
	public OHAOEGELMBF(JEHFANAFIPH LEGJNCGODJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x9FE510", Offset = "0x9FD710", VA = "0x1809FE510", Slot = "3")]
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
		private CGOPMOIBILE LAMDDJAFCHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private NIOHIHLODOA GNMOABFFODF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public EIBLFAMJJIA iamListener;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		public void setPushPromptResponseReceivedDelegate(CGOPMOIBILE BMOBMAMEPLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
		public void setPushTokenReceivedFromSystemDelegate(NIOHIHLODOA BMOBMAMEPLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9F1A20", Offset = "0x9F0C20", VA = "0x1809F1A20")]
		public void onPushPromptResponseReceived(string FFKACEKODPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9F1A90", Offset = "0x9F0C90", VA = "0x1809F1A90")]
		public void onPushTokenReceivedFromSystem(string PPOILDCNBFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x9F1380", Offset = "0x9F0580", VA = "0x1809F1380")]
		public void beforeInAppMessageDisplayed(string GGAPOHEBNKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9F1740", Offset = "0x9F0940", VA = "0x1809F1740")]
		public void onInAppMessageDismissed(string GGAPOHEBNKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9F16E0", Offset = "0x9F08E0", VA = "0x1809F16E0")]
		public void onInAppMessageClicked(string GGAPOHEBNKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9F13E0", Offset = "0x9F05E0", VA = "0x1809F13E0")]
		public void onInAppMessageButtonClicked(string HCKIFJOADKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F09A0", VA = "0x1809F17A0")]
		public void onInAppMessageHTMLClicked(string HCKIFJOADKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
		public BrazeInternalComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class BrazeInternalGameObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static GameObject BJFPHBLMMJE;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private static GameObject NDDGJHHDBNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AD0", Offset = "0x9F0CD0", VA = "0x1809F1AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1C70", Offset = "0x9F0E70", VA = "0x1809F1C70")]
		public static void setPushPromptResponseReceivedDelegate(CGOPMOIBILE BMOBMAMEPLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9F1CD0", Offset = "0x9F0ED0", VA = "0x1809F1CD0")]
		public static void setPushTokenReceivedFromSystemDelegate(NIOHIHLODOA BMOBMAMEPLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9F1C10", Offset = "0x9F0E10", VA = "0x1809F1C10")]
		public static void setInAppMessageListener(EIBLFAMJJIA FKDBOFONAPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x9F0790", Offset = "0x9EF990", VA = "0x1809F0790")]
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
