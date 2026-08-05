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
	[Cpp2IlInjected.Address(RVA = "0x6BD83A0", Offset = "0x6BD77A0", VA = "0x186BD83A0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6BD7EE0", Offset = "0x6BD72E0", VA = "0x186BD7EE0")]
	public string PrintOutObjectValues(object EFJFBDKGGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
	public ApplePushNotificationTester()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NPNNHFCIGAO
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class APHMFNAOPFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Action<MBBHBIIKNPE> NKKPNJNBGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Action<MBBHBIIKNPE> FNFENGPMLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Action<MBBHBIIKNPE> ECOOAGHGBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Action<MBBHBIIKNPE, EFEDEIJMBIO> DIEDPPDBIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public Action<MBBHBIIKNPE, Uri> PEGACAINBFP;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum BIGPFLPHDBM
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
public enum HAJJNIKOJIK
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	IAM_DISPLAY_NOW,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	IAM_DISPLAY_LATER,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	IAM_DISCARD
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void FFKDHEGMPNF(bool FMMLBIOMJHN);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void ENJEOCLHACL(string GAOLOMEJCOK);
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AppboyBinding : SingletonMonoBehaviour<AppboyBinding>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static NPNNHFCIGAO GNDKJLNLLFH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static NPNNHFCIGAO KKENJBDODEH
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6BD7EA0", Offset = "0x6BD72A0", VA = "0x186BD7EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static APHMFNAOPFL HLONKEGAFAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x99CA10", Offset = "0x99BE10", VA = "0x18099CA10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void LogCustomEvent(string GMCADKKMDNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void LogCustomEvent(string GMCADKKMDNJ, Dictionary<string, object> NFDNHCCMBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void LogPurchase(string FGKEKCPCNHK, string DCNMIDKMOKG, decimal CJILBFMACFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void LogPurchase(string FGKEKCPCNHK, string DCNMIDKMOKG, decimal CJILBFMACFH, int FPMMLGBKDCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void LogPurchase(string FGKEKCPCNHK, string DCNMIDKMOKG, decimal CJILBFMACFH, int FPMMLGBKDCE, Dictionary<string, object> NFDNHCCMBMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void ChangeUser(string OFOLDFODADE, [Optional] string BJEAEFHFKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetSdkAuthenticationSignature(string BJEAEFHFKCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetUserFirstName(string MBIFFBOJGIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetUserLastName(string IEODANJGANI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetUserEmail(string ABFHNGNPMOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetUserGender(POIJHCCLECN PJJIDHECFLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetUserDateOfBirth(int IPCGCLINELJ, int IAOOCHLBGLD, int EIDJBJAFBMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetUserCountry(string BFKHCDLJCLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetUserHomeCity(string OJMLNJKKEDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetUserEmailNotificationSubscriptionType(HHHPGAILEPL OMCDJBHGPPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetUserPushNotificationSubscriptionType(HHHPGAILEPL MLHMMAEJOMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetUserPhoneNumber(string NOADEMMHOIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetCustomUserAttribute(string KOFPKIJDAMC, bool KKIAKNLLHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetCustomUserAttribute(string KOFPKIJDAMC, int KKIAKNLLHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetCustomUserAttribute(string KOFPKIJDAMC, float KKIAKNLLHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetCustomUserAttribute(string KOFPKIJDAMC, string KKIAKNLLHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetCustomUserAttributeToNow(string KOFPKIJDAMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetCustomUserAttributeToSecondsFromEpoch(string KOFPKIJDAMC, long AMIJEEONBEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void UnsetCustomUserAttribute(string KOFPKIJDAMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void IncrementCustomUserAttribute(string KOFPKIJDAMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void IncrementCustomUserAttribute(string KOFPKIJDAMC, int BNFMCCGJPKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetCustomUserAttributeArray(string KOFPKIJDAMC, List<string> KGHLGBOMEFA, int JECAINLJFKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void AddToCustomUserAttributeArray(string KOFPKIJDAMC, string KKIAKNLLHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void RemoveFromCustomUserAttributeArray(string KOFPKIJDAMC, string KKIAKNLLHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void setUserFacebookData(string HMCENAIGJAP, string MBIFFBOJGIE, string IEODANJGANI, string ABFHNGNPMOB, string BHPCHBCNALO, string IGIPHJEIDCF, POIJHCCLECN? PJJIDHECFLK, int? LNDJGKGEKFJ, string HHMGMELOPHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void setUserTwitterData(int? OPCFBMHFGHC, string KABINNCNEHL, string DKPHPKDPBCM, string MBHJNEALOOE, int? LMICPLOCDGN, int? ODHGJOJJEHG, int? IKOAGKIPOEI, string MDKBAFGJNCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetUserLastKnownLocation(double PJALPHFFBOC, double AEBCIGOHPPG, [Optional] double? JBBCPCLOKPD, [Optional] double? PKLIKKBDKKI, [Optional] double? KFLLDCHNIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void PromptUserForPushPermissions(bool OHEBPNGNHPP, [Optional] FFKDHEGMPNF FLDANGKPOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetPushTokenReceivedFromSystemDelegate(ENJEOCLHACL MOLFCILHEPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void LogInAppMessageClicked(string BIKHCGIOADN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void LogInAppMessageImpression(string BIKHCGIOADN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void LogInAppMessageButtonClicked(string BIKHCGIOADN, int BJIIPAPBJKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void RequestFeedRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void RequestFeedRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void LogFeedDisplayed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void RequestContentCardsRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void RequestContentCardsRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void LogContentCardClicked(string PAFIECJLPNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void LogContentCardImpression(string PAFIECJLPNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void LogContentCardDismissed(string PAFIECJLPNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void WipeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void EnableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void DisableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x99CA10", Offset = "0x99BE10", VA = "0x18099CA10")]
		public static string GetInstallTrackingId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetAttributionData(string CAABPGDNLIA, string GAHNDHCPFPK, string OEKCAFJCFDN, string HDPMHBHMPAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void RequestLocationInitialization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void RequestGeofences(decimal PJALPHFFBOC, decimal AEBCIGOHPPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void RequestImmediateDataFlush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void AddAlias(string OPGEHMGDPHI, string BJPOABKANKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void ConfigureListener(BIGPFLPHDBM EGONMKIGNNH, string DKEMDGOLFFI, string FIHJFIOBFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void SetInAppMessageDisplayAction(HAJJNIKOJIK AEHPOCNHMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void DisplayNextInAppMessage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void DisplayContentCards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void AddToSubscriptionGroup(string MLGAFKBKMCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120")]
		public static void RemoveFromSubscriptionGroup(string MLGAFKBKMCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7E60", Offset = "0x6BD7260", VA = "0x186BD7E60")]
		public AppboyBinding()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AppboyBindingTester : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7DE0", Offset = "0x6BD71E0", VA = "0x186BD7DE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7380", Offset = "0x6BD6780", VA = "0x186BD7380")]
		private void IHCCGFEHAPP(string HGJHDPGFLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6D00", Offset = "0x6BD6100", VA = "0x186BD6D00")]
		private void DGDHOJIBIAN(string HGJHDPGFLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6D80", Offset = "0x6BD6180", VA = "0x186BD6D80")]
		private void ECJJPDGHGDC(string HGJHDPGFLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7710", Offset = "0x6BD6B10", VA = "0x186BD7710")]
		private void JGLOGDKDOHI(string HGJHDPGFLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7270", Offset = "0x6BD6670", VA = "0x186BD7270")]
		private void GKBDHPHICMO(string HGJHDPGFLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7A20", Offset = "0x6BD6E20", VA = "0x186BD7A20")]
		private void LOKPOIDKEGL(string HGJHDPGFLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7820", Offset = "0x6BD6C20", VA = "0x186BD7820")]
		private void JIFCOLOLLKM(string HGJHDPGFLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7BA0", Offset = "0x6BD6FA0", VA = "0x186BD7BA0")]
		private void MAIADADGIHI(string HGJHDPGFLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6BD6E00", Offset = "0x6BD6200", VA = "0x186BD6E00")]
		private void EMLNEMNFJAC(string HGJHDPGFLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6BD79A0", Offset = "0x6BD6DA0", VA = "0x186BD79A0")]
		private void JIOCMNEONGN(string HGJHDPGFLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7470", Offset = "0x6BD6870", VA = "0x186BD7470")]
		public static void InAppMessageBeforeDisplayed(MBBHBIIKNPE HGJHDPGFLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7600", Offset = "0x6BD6A00", VA = "0x186BD7600")]
		public static void InAppMessageDismissed(MBBHBIIKNPE HGJHDPGFLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7580", Offset = "0x6BD6980", VA = "0x186BD7580")]
		public static void InAppMessageClicked(MBBHBIIKNPE HGJHDPGFLKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6BD74F0", Offset = "0x6BD68F0", VA = "0x186BD74F0")]
		public static void InAppMessageButtonClicked(MBBHBIIKNPE HGJHDPGFLKO, EFEDEIJMBIO GLMOFKCPEDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7680", Offset = "0x6BD6A80", VA = "0x186BD7680")]
		public static void InAppMessageHTMLClicked(MBBHBIIKNPE HGJHDPGFLKO, Uri OADJOGEDOPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
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
		private static GameObject PFLHMFKPPJD;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static GameObject HLFGGJBLCBK
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6BDB2C0", Offset = "0x6BDA6C0", VA = "0x186BDB2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6BDB470", Offset = "0x6BDA870", VA = "0x186BDB470")]
		public static void setPushPromptResponseReceivedDelegate(FFKDHEGMPNF FLDANGKPOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6BDB4D0", Offset = "0x6BDA8D0", VA = "0x186BDB4D0")]
		public static void setPushTokenReceivedFromSystemDelegate(ENJEOCLHACL FLDANGKPOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6BDB410", Offset = "0x6BDA810", VA = "0x186BDB410")]
		public static void setInAppMessageListener(APHMFNAOPFL HLONKEGAFAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
		public BrazeInternalGameObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class BrazeInternalComponent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private FFKDHEGMPNF GPPIMIMLGPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private ENJEOCLHACL ILHHKLOMINN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public APHMFNAOPFL iamListener;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7F3110", Offset = "0x7F2510", VA = "0x1807F3110")]
		public void setPushPromptResponseReceivedDelegate(FFKDHEGMPNF FLDANGKPOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7F2C10", Offset = "0x7F2010", VA = "0x1807F2C10")]
		public void setPushTokenReceivedFromSystemDelegate(ENJEOCLHACL FLDANGKPOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6BDB220", Offset = "0x6BDA620", VA = "0x186BDB220")]
		public void onPushPromptResponseReceived(string BDCLMEKIDFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6BDB2A0", Offset = "0x6BDA6A0", VA = "0x186BDB2A0")]
		public void onPushTokenReceivedFromSystem(string GAOLOMEJCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6BDAA50", Offset = "0x6BD9E50", VA = "0x186BDAA50")]
		public void beforeInAppMessageDisplayed(string NJNNFOKHKII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6BDAEA0", Offset = "0x6BDA2A0", VA = "0x186BDAEA0")]
		public void onInAppMessageDismissed(string NJNNFOKHKII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6BDAE20", Offset = "0x6BDA220", VA = "0x186BDAE20")]
		public void onInAppMessageClicked(string NJNNFOKHKII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6BDAAD0", Offset = "0x6BD9ED0", VA = "0x186BDAAD0")]
		public void onInAppMessageButtonClicked(string OIALBMCKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6BDAF20", Offset = "0x6BDA320", VA = "0x186BDAF20")]
		public void onInAppMessageHTMLClicked(string OIALBMCKGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
		public BrazeInternalComponent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IKFKDGEDPGL
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6BDFA00", Offset = "0x6BDEE00", VA = "0x186BDFA00")]
	public static Color? JNJHJKLPGCN(string BDGJBEFBFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF6B0", Offset = "0x6BDEAB0", VA = "0x186BDF6B0")]
	public static Color JNJHJKLPGCN(int BDGJBEFBFEM)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DefaultMember("Item")]
public class PJBCBEDPBLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public virtual PJBCBEDPBLJ OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x99CA10", Offset = "0x99BE10", VA = "0x18099CA10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual PJBCBEDPBLJ OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x99CA10", Offset = "0x99BE10", VA = "0x18099CA10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public virtual string EEMAOFBHODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6BE6A80", Offset = "0x6BE5E80", VA = "0x186BE6A80", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public virtual int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x99CA10", Offset = "0x99BE10", VA = "0x18099CA10", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual int EHHMAMBGELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6BE6B50", Offset = "0x6BE5F50", VA = "0x186BE6B50", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6BE5EF0", Offset = "0x6BE52F0", VA = "0x186BE5EF0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public virtual bool NLCEDMLLOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6BE6010", Offset = "0x6BE5410", VA = "0x186BE6010", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6BE5F30", Offset = "0x6BE5330", VA = "0x186BE5F30", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public virtual CBCCPNPEINA GHBPHEPMJDO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6BE6B90", Offset = "0x6BE5F90", VA = "0x186BE6B90", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public virtual JAGKHANBODK BANGAMJFLLG
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6BE6CB0", Offset = "0x6BE60B0", VA = "0x186BE6CB0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "4")]
	public virtual void EBOHBLNDMAL(string FNAGIOBCDOF, PJBCBEDPBLJ OEGHPJDLLEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6BE5FB0", Offset = "0x6BE53B0", VA = "0x186BE5FB0", Slot = "10")]
	public virtual void EBOHBLNDMAL(PJBCBEDPBLJ OEGHPJDLLEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6BE6E20", Offset = "0x6BE6220", VA = "0x186BE6E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6BE6DC0", Offset = "0x6BE61C0", VA = "0x186BE6DC0")]
	public static PJBCBEDPBLJ PGDDHPNABOB(string ABFHPKCOHFI)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6BE6D30", Offset = "0x6BE6130", VA = "0x186BE6D30")]
	public static string PGDDHPNABOB(PJBCBEDPBLJ GOFPOLBMIKB)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6BE6C10", Offset = "0x6BE6010", VA = "0x186BE6C10")]
	public static bool MCJHDEKAHDI(PJBCBEDPBLJ EJOFMGLMADH, object CMACFBOCONA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6BE6AB0", Offset = "0x6BE5EB0", VA = "0x186BE6AB0")]
	public static bool JJOPDHABKNF(PJBCBEDPBLJ EJOFMGLMADH, object CMACFBOCONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x19E8E00", Offset = "0x19E8200", VA = "0x1819E8E00", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xDBA290", Offset = "0xDB9690", VA = "0x180DBA290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6BE68F0", Offset = "0x6BE5CF0", VA = "0x186BE68F0")]
	internal static string HCACFLNMABC(string HMPMHPHIDNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6BE60D0", Offset = "0x6BE54D0", VA = "0x186BE60D0")]
	public static PJBCBEDPBLJ GGIPJDMEDNM(string AGKBCPEGFPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public PJBCBEDPBLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DefaultMember("Item")]
public class CBCCPNPEINA : PJBCBEDPBLJ, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class FHFFEEEMFBG : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public CBCCPNPEINA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<PJBCBEDPBLJ>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private PJBCBEDPBLJ <N>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA21140", Offset = "0xA20540", VA = "0x180A21140")]
		[DebuggerHidden]
		public FHFFEEEMFBG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6BDDE10", Offset = "0x6BDD210", VA = "0x186BDDE10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6BDDC30", Offset = "0x6BDD030", VA = "0x186BDDC30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6BDDBE0", Offset = "0x6BDCFE0", VA = "0x186BDDBE0")]
		private void MIMEIPDHABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6BDDDD0", Offset = "0x6BDD1D0", VA = "0x186BDDDD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<PJBCBEDPBLJ> KEBGJELLFGF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override PJBCBEDPBLJ OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6BDB530", Offset = "0x6BDA930", VA = "0x186BDB530", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override PJBCBEDPBLJ OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6BDB5E0", Offset = "0x6BDA9E0", VA = "0x186BDB5E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6BDB710", Offset = "0x6BDAB10", VA = "0x186BDB710", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6BDB640", Offset = "0x6BDAA40", VA = "0x186BDB640", Slot = "4")]
	public override void EBOHBLNDMAL(string FNAGIOBCDOF, PJBCBEDPBLJ OEGHPJDLLEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6BDB6A0", Offset = "0x6BDAAA0", VA = "0x186BDB6A0", Slot = "17")]
	[IteratorStateMachine(typeof(FHFFEEEMFBG))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6BDB750", Offset = "0x6BDAB50", VA = "0x186BDB750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6BDB8F0", Offset = "0x6BDACF0", VA = "0x186BDB8F0")]
	public CBCCPNPEINA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public class JAGKHANBODK : PJBCBEDPBLJ, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class KFGCNAFAIOM : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public JAGKHANBODK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Dictionary<string, PJBCBEDPBLJ>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private KeyValuePair<string, PJBCBEDPBLJ> <N>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA21140", Offset = "0xA20540", VA = "0x180A21140")]
		[DebuggerHidden]
		public KFGCNAFAIOM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6BE2C10", Offset = "0x6BE2010", VA = "0x186BE2C10", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6BE29F0", Offset = "0x6BE1DF0", VA = "0x186BE29F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6BE29A0", Offset = "0x6BE1DA0", VA = "0x186BE29A0")]
		private void MIMEIPDHABP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6BE2BD0", Offset = "0x6BE1FD0", VA = "0x186BE2BD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<string, PJBCBEDPBLJ> MFMNJHNEKJH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override PJBCBEDPBLJ OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6BE0F60", Offset = "0x6BE0360", VA = "0x186BE0F60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override PJBCBEDPBLJ OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6BE0EB0", Offset = "0x6BE02B0", VA = "0x186BE0EB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public override int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6BE11E0", Offset = "0x6BE05E0", VA = "0x186BE11E0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1030", Offset = "0x6BE0430", VA = "0x186BE1030", Slot = "4")]
	public override void EBOHBLNDMAL(string FNAGIOBCDOF, PJBCBEDPBLJ OEGHPJDLLEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1170", Offset = "0x6BE0570", VA = "0x186BE1170", Slot = "17")]
	[IteratorStateMachine(typeof(KFGCNAFAIOM))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1230", Offset = "0x6BE0630", VA = "0x186BE1230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1630", Offset = "0x6BE0A30", VA = "0x186BE1630")]
	public JAGKHANBODK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class KOMBEADKGCK : PJBCBEDPBLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private string JNACHFGDHNF;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public override string EEMAOFBHODN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x10687F0", Offset = "0x1067BF0", VA = "0x1810687F0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F3140", Offset = "0x7F2540", VA = "0x1807F3140", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7FF090", Offset = "0x7FE490", VA = "0x1807FF090")]
	public KOMBEADKGCK(string CIJPKPDNPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2D30", Offset = "0x6BE2130", VA = "0x186BE2D30")]
	public KOMBEADKGCK(bool CIJPKPDNPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2CF0", Offset = "0x6BE20F0", VA = "0x186BE2CF0")]
	public KOMBEADKGCK(int CIJPKPDNPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2CA0", Offset = "0x6BE20A0", VA = "0x186BE2CA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
internal class KDALECAIOMM : PJBCBEDPBLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private PJBCBEDPBLJ AGEKMAPLFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private string IKOLCILIILL;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public override PJBCBEDPBLJ OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6BE20D0", Offset = "0x6BE14D0", VA = "0x186BE20D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override PJBCBEDPBLJ OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6BE2130", Offset = "0x6BE1530", VA = "0x186BE2130", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override int EHHMAMBGELK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6BE2630", Offset = "0x6BE1A30", VA = "0x186BE2630", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6BE21A0", Offset = "0x6BE15A0", VA = "0x186BE21A0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override bool NLCEDMLLOJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6BE2570", Offset = "0x6BE1970", VA = "0x186BE2570", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6BE22E0", Offset = "0x6BE16E0", VA = "0x186BE22E0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override CBCCPNPEINA GHBPHEPMJDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6BE26F0", Offset = "0x6BE1AF0", VA = "0x186BE26F0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public override JAGKHANBODK BANGAMJFLLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6BE27A0", Offset = "0x6BE1BA0", VA = "0x186BE27A0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2880", Offset = "0x6BE1C80", VA = "0x186BE2880")]
	public KDALECAIOMM(PJBCBEDPBLJ MIEMNELHPFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2910", Offset = "0x6BE1D10", VA = "0x186BE2910")]
	public KDALECAIOMM(PJBCBEDPBLJ MIEMNELHPFB, string FNAGIOBCDOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2270", Offset = "0x6BE1670", VA = "0x186BE2270")]
	private void DADPJLGDIHI(PJBCBEDPBLJ NDKKBBGJMOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6BE23B0", Offset = "0x6BE17B0", VA = "0x186BE23B0", Slot = "10")]
	public override void EBOHBLNDMAL(PJBCBEDPBLJ OEGHPJDLLEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2480", Offset = "0x6BE1880", VA = "0x186BE2480", Slot = "4")]
	public override void EBOHBLNDMAL(string FNAGIOBCDOF, PJBCBEDPBLJ OEGHPJDLLEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4EB9120", Offset = "0x4EB8520", VA = "0x184EB9120", Slot = "0")]
	public override bool Equals(object ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xDBA290", Offset = "0xDB9690", VA = "0x180DBA290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2850", Offset = "0x6BE1C50", VA = "0x186BE2850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FLINPIBHMAE
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6BDDEA0", Offset = "0x6BDD2A0", VA = "0x186BDDEA0")]
	public static PJBCBEDPBLJ GGIPJDMEDNM(string AGKBCPEGFPG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EJNIGCGKNPK
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6BDDAD0", Offset = "0x6BDCED0", VA = "0x186BDDAD0")]
	public static object FHINKAMFGNA(Type LJNPFAEMBEB, string KKIAKNLLHIO, bool KEPABEOMLGM, object OLNFJPNAOBM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ABAJEILFICI
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6440", Offset = "0x6BD5840", VA = "0x186BD6440")]
	public static Dictionary<string, string> HMPBPLLDDJN(JAGKHANBODK NGGDDMBBPDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CODCJPGDCFB
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6BDC560", Offset = "0x6BDB960", VA = "0x186BDC560")]
	public static string GMHDAGACOED(Dictionary<string, string> CEDFPOKBHBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1CEDE20", Offset = "0x1CED220", VA = "0x181CEDE20")]
	public static string OKDDHMECHBK<T>(List<T> OCCNFAKIALD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum BDEIBCEDAAO
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
public enum DHOPDIJPPDE
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	TOP,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	BOTTOM
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CMLNFJEFCPI
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public string IFDEANDDGNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F3140", Offset = "0x7F2540", VA = "0x1807F3140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string ECKPKELKCAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F3110", Offset = "0x7F2510", VA = "0x1807F3110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string PIDCEMFCGDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7F2C10", Offset = "0x7F2010", VA = "0x1807F2C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public Dictionary<string, string> EEFLEHLDCOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7F2BB0", Offset = "0x7F1FB0", VA = "0x1807F2BB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7F3120", Offset = "0x7F2520", VA = "0x1807F3120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int AGKIMCMGECE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x976C20", Offset = "0x976020", VA = "0x180976C20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x976BE0", Offset = "0x975FE0", VA = "0x180976BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long MMOADFCDDFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x94BE70", Offset = "0x94B270", VA = "0x18094BE70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x97D5D0", Offset = "0x97C9D0", VA = "0x18097D5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public string OAEIEONCPOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8C2FB0", Offset = "0x8C23B0", VA = "0x1808C2FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x94CDF0", Offset = "0x94C1F0", VA = "0x18094CDF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6BDC180", Offset = "0x6BDB580", VA = "0x186BDC180")]
	public CMLNFJEFCPI(string HGJHDPGFLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6BDBE30", Offset = "0x6BDB230", VA = "0x186BDBE30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6BDB970", Offset = "0x6BDAD70", VA = "0x186BDB970")]
	private string HINFICMDNHC(JAGKHANBODK NGGDDMBBPDC, string KOFPKIJDAMC, string OLNFJPNAOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6BDBC80", Offset = "0x6BDB080", VA = "0x186BDBC80")]
	private int PFDGNJPEBPK(JAGKHANBODK NGGDDMBBPDC, string KOFPKIJDAMC, int OLNFJPNAOBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6BDBAD0", Offset = "0x6BDAED0", VA = "0x186BDBAD0")]
	private long NOMOOMOIMEH(JAGKHANBODK NGGDDMBBPDC, string KOFPKIJDAMC, long OLNFJPNAOBM)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class ONEOBJPKKGA
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<LHHKOBBEOBP> IJCMACBFFAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F3140", Offset = "0x7F2540", VA = "0x1807F3140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool LHHIBLJMKPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x992D00", Offset = "0x992100", VA = "0x180992D00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6BE5990", Offset = "0x6BE4D90", VA = "0x186BE5990")]
	public ONEOBJPKKGA(string HGJHDPGFLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6BE5730", Offset = "0x6BE4B30", VA = "0x186BE5730")]
	private static LHHKOBBEOBP MGIKLCBAELG(JAGKHANBODK NGGDDMBBPDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class KBMMHNLIPCE
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IList<string> GIAAMFGGCAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7F3140", Offset = "0x7F2540", VA = "0x1807F3140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string LCJKCDEJIHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7F3110", Offset = "0x7F2510", VA = "0x1807F3110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string CGEFMAPBOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7F2C10", Offset = "0x7F2010", VA = "0x1807F2C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string BJNFKELOIMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7F2BB0", Offset = "0x7F1FB0", VA = "0x1807F2BB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7F3120", Offset = "0x7F2520", VA = "0x1807F3120")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string OMNNIMDHDGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x940BC0", Offset = "0x93FFC0", VA = "0x180940BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1AD0", Offset = "0x6BE0ED0", VA = "0x186BE1AD0")]
	public KBMMHNLIPCE(JAGKHANBODK NGGDDMBBPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6BE16B0", Offset = "0x6BE0AB0", VA = "0x186BE16B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum EDGMNNPBDPJ
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	AUTO_DISMISS,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	SWIPE
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IPICKKPJDLA
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public KBMMHNLIPCE AOHKJPFDFDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7F3140", Offset = "0x7F2540", VA = "0x1807F3140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int EPFGDDOOHMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9C0750", Offset = "0x9BFB50", VA = "0x1809C0750")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xC0C1E0", Offset = "0xC0B5E0", VA = "0x180C0C1E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public string PDGEOBIDKNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7F2C10", Offset = "0x7F2010", VA = "0x1807F2C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int LCCMMEAPJGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xB7A4F0", Offset = "0xB798F0", VA = "0x180B7A4F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xB945B0", Offset = "0xB939B0", VA = "0x180B945B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IDictionary<string, object> DMELOKGAGCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x940BC0", Offset = "0x93FFC0", VA = "0x180940BC0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6BE08F0", Offset = "0x6BDFCF0", VA = "0x186BE08F0")]
	public IPICKKPJDLA(JAGKHANBODK NGGDDMBBPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6BDFB70", Offset = "0x6BDEF70", VA = "0x186BDFB70")]
	private object HPKLHDIAOFC(PJBCBEDPBLJ GJCCBHONDAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0210", Offset = "0x6BDF610", VA = "0x186BE0210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum HHHPGAILEPL
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	OPTED_IN,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	SUBSCRIBED,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	UNSUBSCRIBED
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public enum POIJHCCLECN
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
public enum FCPNMMFILGA
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	NEWS_FEED,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	URI,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	NONE
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class AKBMJKDCJHL : LHHKOBBEOBP
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string CINNKMCBLCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8C1300", Offset = "0x8C0700", VA = "0x1808C1300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8D19B0", Offset = "0x8D0DB0", VA = "0x1808D19B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string PEHHFMJDBDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x94A3F0", Offset = "0x9497F0", VA = "0x18094A3F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x94A450", Offset = "0x949850", VA = "0x18094A450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string HOFNANCEPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x94A400", Offset = "0x949800", VA = "0x18094A400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x94B840", Offset = "0x94AC40", VA = "0x18094B840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6980", Offset = "0x6BD5D80", VA = "0x186BD6980")]
	public AKBMJKDCJHL(JAGKHANBODK NGGDDMBBPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6790", Offset = "0x6BD5B90", VA = "0x186BD6790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class HLCIFCHFAEP : LHHKOBBEOBP
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string CINNKMCBLCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8C1300", Offset = "0x8C0700", VA = "0x1808C1300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8D19B0", Offset = "0x8D0DB0", VA = "0x1808D19B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string ECKPKELKCAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x94A3F0", Offset = "0x9497F0", VA = "0x18094A3F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x94A450", Offset = "0x949850", VA = "0x18094A450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string CLOBPFLKHFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x94A400", Offset = "0x949800", VA = "0x18094A400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x94B840", Offset = "0x94AC40", VA = "0x18094B840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string PEHHFMJDBDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x94B830", Offset = "0x94AC30", VA = "0x18094B830")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x94CE10", Offset = "0x94C210", VA = "0x18094CE10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string HOFNANCEPCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x94CDE0", Offset = "0x94C1E0", VA = "0x18094CDE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x94B180", Offset = "0x94A580", VA = "0x18094B180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE860", Offset = "0x6BDDC60", VA = "0x186BDE860")]
	public HLCIFCHFAEP(JAGKHANBODK NGGDDMBBPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE5B0", Offset = "0x6BDD9B0", VA = "0x186BDE5B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class DPNPCGDEPFN : LHHKOBBEOBP
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string ECKPKELKCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8C1300", Offset = "0x8C0700", VA = "0x1808C1300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8D19B0", Offset = "0x8D0DB0", VA = "0x1808D19B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string CLOBPFLKHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x94A3F0", Offset = "0x9497F0", VA = "0x18094A3F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x94A450", Offset = "0x949850", VA = "0x18094A450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string PEHHFMJDBDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x94A400", Offset = "0x949800", VA = "0x18094A400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x94B840", Offset = "0x94AC40", VA = "0x18094B840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string HOFNANCEPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x94B830", Offset = "0x94AC30", VA = "0x18094B830")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x94CE10", Offset = "0x94C210", VA = "0x18094CE10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6BDCA20", Offset = "0x6BDBE20", VA = "0x186BDCA20")]
	public DPNPCGDEPFN(JAGKHANBODK NGGDDMBBPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6BDC7D0", Offset = "0x6BDBBD0", VA = "0x186BDC7D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class IJJDENOIMDM : LHHKOBBEOBP
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string CLOBPFLKHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8C1300", Offset = "0x8C0700", VA = "0x1808C1300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x8D19B0", Offset = "0x8D0DB0", VA = "0x1808D19B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string CINNKMCBLCM
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x94A3F0", Offset = "0x9497F0", VA = "0x18094A3F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x94A450", Offset = "0x949850", VA = "0x18094A450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string ECKPKELKCAK
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x94A400", Offset = "0x949800", VA = "0x18094A400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x94B840", Offset = "0x94AC40", VA = "0x18094B840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string PEHHFMJDBDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x94B830", Offset = "0x94AC30", VA = "0x18094B830")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x94CE10", Offset = "0x94C210", VA = "0x18094CE10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string HOFNANCEPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x94CDE0", Offset = "0x94C1E0", VA = "0x18094CDE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x94B180", Offset = "0x94A580", VA = "0x18094B180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF120", Offset = "0x6BDE520", VA = "0x186BDF120")]
	public IJJDENOIMDM(JAGKHANBODK NGGDDMBBPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6BDEE70", Offset = "0x6BDE270", VA = "0x186BDEE70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class LHHKOBBEOBP
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string GIGPDKBONPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7F3140", Offset = "0x7F2540", VA = "0x1807F3140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string JJGFPAEGNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3110", Offset = "0x7F2510", VA = "0x1807F3110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool CIELENPLDDP
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xBAF260", Offset = "0xBAE660", VA = "0x180BAF260")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xBADB00", Offset = "0xBACF00", VA = "0x180BADB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public long BNGHNNNLNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7F2BB0", Offset = "0x7F1FB0", VA = "0x1807F2BB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x17C30F0", Offset = "0x17C24F0", VA = "0x1817C30F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public long ICNKLMMFNOP
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xB9A7F0", Offset = "0xB99BF0", VA = "0x180B9A7F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public HashSet<BDEIBCEDAAO> GMHDPLLGEFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x94BE70", Offset = "0x94B270", VA = "0x18094BE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x94BE50", Offset = "0x94B250", VA = "0x18094BE50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private string CHHFKEJACGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x94CDF0", Offset = "0x94C1F0", VA = "0x18094CDF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Dictionary<string, string> EEFLEHLDCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x94B1A0", Offset = "0x94A5A0", VA = "0x18094B1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x94B820", Offset = "0x94AC20", VA = "0x18094B820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6BE3370", Offset = "0x6BE2770", VA = "0x186BE3370")]
	public LHHKOBBEOBP(JAGKHANBODK NGGDDMBBPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2F80", Offset = "0x6BE2380", VA = "0x186BE2F80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2D70", Offset = "0x6BE2170", VA = "0x186BE2D70")]
	public string ICJKNKDHHOC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class BGNDPCODIPE
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string GIGPDKBONPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7E8110", Offset = "0x7E7510", VA = "0x1807E8110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7F3140", Offset = "0x7F2540", VA = "0x1807F3140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string JJGFPAEGNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3110", Offset = "0x7F2510", VA = "0x1807F3110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool CIELENPLDDP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xBAF260", Offset = "0xBAE660", VA = "0x180BAF260")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xBADB00", Offset = "0xBACF00", VA = "0x180BADB00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public long BNGHNNNLNBI
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7F2BB0", Offset = "0x7F1FB0", VA = "0x1807F2BB0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x17C30F0", Offset = "0x17C24F0", VA = "0x1817C30F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public long GGDOLNDCDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xB9A7F0", Offset = "0xB99BF0", VA = "0x180B9A7F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string CINNKMCBLCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x94BE70", Offset = "0x94B270", VA = "0x18094BE70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x94BE50", Offset = "0x94B250", VA = "0x18094BE50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string ECKPKELKCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8C2FB0", Offset = "0x8C23B0", VA = "0x1808C2FB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x94CDF0", Offset = "0x94C1F0", VA = "0x18094CDF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string CLOBPFLKHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x94B1A0", Offset = "0x94A5A0", VA = "0x18094B1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x94B820", Offset = "0x94AC20", VA = "0x18094B820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string PEHHFMJDBDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8C1300", Offset = "0x8C0700", VA = "0x1808C1300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x8D19B0", Offset = "0x8D0DB0", VA = "0x1808D19B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string HOFNANCEPCH
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x94A3F0", Offset = "0x9497F0", VA = "0x18094A3F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x94A450", Offset = "0x949850", VA = "0x18094A450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool ALIABMAEOEL
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xC7DAE0", Offset = "0xC7CEE0", VA = "0x180C7DAE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1217A50", Offset = "0x1216E50", VA = "0x181217A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool OAECHNDIHOG
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xD35DE0", Offset = "0xD351E0", VA = "0x180D35DE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xD35F30", Offset = "0xD35330", VA = "0x180D35F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool CGJLHOOJMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xFEE860", Offset = "0xFEDC60", VA = "0x180FEE860")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9560", Offset = "0x6BD8960", VA = "0x186BD9560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool FHIPCHOPINH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xFEE920", Offset = "0xFEDD20", VA = "0x180FEE920")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9620", Offset = "0x6BD8A20", VA = "0x186BD9620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool PCDNPHICFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xC5E140", Offset = "0xC5D540", VA = "0x180C5E140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x20E85C0", Offset = "0x20E79C0", VA = "0x1820E85C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public string CHHFKEJACGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x94B830", Offset = "0x94AC30", VA = "0x18094B830")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x94CE10", Offset = "0x94C210", VA = "0x18094CE10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Dictionary<string, string> EEFLEHLDCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x94CDE0", Offset = "0x94C1E0", VA = "0x18094CDE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x94B180", Offset = "0x94A580", VA = "0x18094B180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9DD0", Offset = "0x6BD91D0", VA = "0x186BD9DD0")]
	public BGNDPCODIPE(JAGKHANBODK NGGDDMBBPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9630", Offset = "0x6BD8A30", VA = "0x186BD9630", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6BD94B0", Offset = "0x6BD88B0", VA = "0x186BD94B0")]
	public void GANAKKAIFOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9570", Offset = "0x6BD8970", VA = "0x186BD9570")]
	public void KBNCEIIBMLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class DFEIEGGAPDI : BDKCDKHFKAO
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6BDC7C0", Offset = "0x6BDBBC0", VA = "0x186BDC7C0")]
	public DFEIEGGAPDI(JAGKHANBODK NGGDDMBBPDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class BDKCDKHFKAO : LJLLOIBNJHM, FMPMINMNEKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private bool HPMFJONIBHC;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string PMELNBKJJGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x8C3DA0", Offset = "0x8C31A0", VA = "0x1808C3DA0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8C3980", Offset = "0x8C2D80", VA = "0x1808C3980", Slot = "28")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Color? JINMJDAEOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x20A2ED0", Offset = "0x20A22D0", VA = "0x1820A2ED0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6BD8800", Offset = "0x6BD7C00", VA = "0x186BD8800", Slot = "30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Color? KGHICEPBCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6BD87C0", Offset = "0x6BD7BC0", VA = "0x186BD87C0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6BD87E0", Offset = "0x6BD7BE0", VA = "0x186BD87E0", Slot = "32")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public List<EFEDEIJMBIO> ICELCELMDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9066A0", Offset = "0x905AA0", VA = "0x1809066A0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x906900", Offset = "0x905D00", VA = "0x180906900", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8820", Offset = "0x6BD7C20", VA = "0x186BD8820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8AF0", Offset = "0x6BD7EF0", VA = "0x186BD8AF0")]
	public BDKCDKHFKAO(JAGKHANBODK NGGDDMBBPDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class EFEDEIJMBIO
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int OIDMGIMHPGI
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7E8250", Offset = "0x7E7650", VA = "0x1807E8250")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x902B60", Offset = "0x901F60", VA = "0x180902B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string FGLKANAFPEK
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7F3110", Offset = "0x7F2510", VA = "0x1807F3110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string FICPLADGBBN
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7F2C10", Offset = "0x7F2010", VA = "0x1807F2C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public FCPNMMFILGA APJNPFCJNIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xB7A4F0", Offset = "0xB798F0", VA = "0x180B7A4F0")]
		[CompilerGenerated]
		get
		{
			return default(FCPNMMFILGA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xB945B0", Offset = "0xB939B0", VA = "0x180B945B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public Color? HAEFILACAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6BDCF00", Offset = "0x6BDC300", VA = "0x186BDCF00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6BDCEF0", Offset = "0x6BDC2F0", VA = "0x186BDCEF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public Color? EPAIDFDHDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3830", Offset = "0x2AB2C30", VA = "0x182AB3830")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3820", Offset = "0x2AB2C20", VA = "0x182AB3820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6BDCF20", Offset = "0x6BDC320", VA = "0x186BDCF20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6BDD250", Offset = "0x6BDC650", VA = "0x186BDD250")]
	public EFEDEIJMBIO(JAGKHANBODK NGGDDMBBPDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface MBBHBIIKNPE
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface FMPMINMNEKA
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	List<EFEDEIJMBIO> ICELCELMDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JFJCFNGPMHF : BDKCDKHFKAO
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6BDC7C0", Offset = "0x6BDBBC0", VA = "0x186BDC7C0")]
	public JFJCFNGPMHF(JAGKHANBODK NGGDDMBBPDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class BNGKDDPPAMG
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA7A0", Offset = "0x6BD9BA0", VA = "0x186BDA7A0")]
	public static MBBHBIIKNPE KICGLJCBJJN(string BIKHCGIOADN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public enum GNNBMKOHNCA
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	FULL,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	MODAL,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	SLIDEUP
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class NPPMLPFMDGO
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6BE55D0", Offset = "0x6BE49D0", VA = "0x186BE55D0")]
	public static JAGKHANBODK HNPFNDBPKBD(string LAKJJDGAHAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class GCODCGAHGLB : LJLLOIBNJHM
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public DHOPDIJPPDE LCGKAHIEOIP
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xFB93C0", Offset = "0xFB87C0", VA = "0x180FB93C0")]
		[CompilerGenerated]
		get
		{
			return default(DHOPDIJPPDE);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2E46F10", Offset = "0x2E46310", VA = "0x182E46F10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool NAGEKOPGLGN
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x13003A0", Offset = "0x12FF7A0", VA = "0x1813003A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x13003B0", Offset = "0x12FF7B0", VA = "0x1813003B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Color? GNOFFNEPFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6BDDED0", Offset = "0x6BDD2D0", VA = "0x186BDDED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6BDDEB0", Offset = "0x6BDD2B0", VA = "0x186BDDEB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6BDDEF0", Offset = "0x6BDD2F0", VA = "0x186BDDEF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE160", Offset = "0x6BDD560", VA = "0x186BDE160")]
	public GCODCGAHGLB(JAGKHANBODK NGGDDMBBPDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class LJLLOIBNJHM : MBBHBIIKNPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	protected string DOCCLCGNOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool DEPDDCEIPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool AADGBEOHFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int OPGFPCFJKDD;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Color? EPAIDFDHDMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x97D440", Offset = "0x97C840", VA = "0x18097D440", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x97CE30", Offset = "0x97C230", VA = "0x18097CE30", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Color? HAEFILACAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6BE3D90", Offset = "0x6BE3190", VA = "0x186BE3D90", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6BE3D60", Offset = "0x6BE3160", VA = "0x186BE3D60", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public string LKJLCDHBADB
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x94B1A0", Offset = "0x94A5A0", VA = "0x18094B1A0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x94B820", Offset = "0x94AC20", VA = "0x18094B820", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Color? IFAEEBDEBBK
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3BA0", Offset = "0x2AB2FA0", VA = "0x182AB3BA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2AB3AE0", Offset = "0x2AB2EE0", VA = "0x182AB3AE0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Color? JKOHOFNFGLG
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6BE3D70", Offset = "0x6BE3170", VA = "0x186BE3D70", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6BE3DB0", Offset = "0x6BE31B0", VA = "0x186BE3DB0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public string AFFNONIEEEF
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x91F290", Offset = "0x91E690", VA = "0x18091F290", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x98D750", Offset = "0x98CB50", VA = "0x18098D750", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public string GDOICJCLMCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x94CE00", Offset = "0x94C200", VA = "0x18094CE00", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x94C610", Offset = "0x94BA10", VA = "0x18094C610", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public Dictionary<string, string> EEFLEHLDCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8C3110", Offset = "0x8C2510", VA = "0x1808C3110", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8C26F0", Offset = "0x8C1AF0", VA = "0x1808C26F0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public FCPNMMFILGA JCOCNANGNIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x91F2B0", Offset = "0x91E6B0", VA = "0x18091F2B0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(FCPNMMFILGA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xEBC2C0", Offset = "0xEBB6C0", VA = "0x180EBC2C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public string FICPLADGBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA49860", Offset = "0xA48C60", VA = "0x180A49860", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9EA9B0", Offset = "0x9E9DB0", VA = "0x1809EA9B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public EDGMNNPBDPJ CJAIEPJEAEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x94B860", Offset = "0x94AC60", VA = "0x18094B860", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(EDGMNNPBDPJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x94C0B0", Offset = "0x94B4B0", VA = "0x18094C0B0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int DAAFNKIBGED
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xF71040", Offset = "0xF70440", VA = "0x180F71040", Slot = "24")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6BE3DC0", Offset = "0x6BE31C0", VA = "0x186BE3DC0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6BE3DF0", Offset = "0x6BE31F0", VA = "0x186BE3DF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6BE4460", Offset = "0x6BE3860", VA = "0x186BE4460")]
	public LJLLOIBNJHM(JAGKHANBODK NGGDDMBBPDC)
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
