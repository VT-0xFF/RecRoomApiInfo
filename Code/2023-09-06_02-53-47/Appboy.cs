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
	[Cpp2IlInjected.Address(RVA = "0x6C482D0", Offset = "0x6C468D0", VA = "0x186C482D0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C47E10", Offset = "0x6C46410", VA = "0x186C47E10")]
	public string PrintOutObjectValues(object FLKJHPOHONJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
	public ApplePushNotificationTester()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MPJOCDMJEMD
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class APFDBPCIAOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Action<HCAMDGOFEOA> JFAGAAHIDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Action<HCAMDGOFEOA> HDCJGOMJJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Action<HCAMDGOFEOA> GFNAKMAGJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Action<HCAMDGOFEOA, NEODALJBNEJ> FBHKPEDBCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public Action<HCAMDGOFEOA, Uri> GCKHMHPEPDI;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum EJOHNEOKBOO
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
public enum KNMFJNLINBH
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	IAM_DISPLAY_NOW,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	IAM_DISPLAY_LATER,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	IAM_DISCARD
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void LAEOEJMBBBG(bool KKPOIGCJCOM);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void FBLAKKDJBPC(string DCEGGIJLHGI);
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AppboyBinding : SingletonMonoBehaviour<AppboyBinding>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static MPJOCDMJEMD FFAHPCDIIOP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MPJOCDMJEMD ONMGNPJOFDB
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6C47DD0", Offset = "0x6C463D0", VA = "0x186C47DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static APFDBPCIAOP KECPOFKJEMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x95FD90", Offset = "0x95E390", VA = "0x18095FD90")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void LogCustomEvent(string GGAPDPNOLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void LogCustomEvent(string GGAPDPNOLAO, Dictionary<string, object> EGDOOPNCMJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void LogPurchase(string GCFPFFCOPJI, string NDCMDPCLPAK, decimal IHHAAIICBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void LogPurchase(string GCFPFFCOPJI, string NDCMDPCLPAK, decimal IHHAAIICBKH, int EBCIODLGAOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void LogPurchase(string GCFPFFCOPJI, string NDCMDPCLPAK, decimal IHHAAIICBKH, int EBCIODLGAOM, Dictionary<string, object> EGDOOPNCMJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void ChangeUser(string JECLHHEOFCL, [Optional] string NFPMPHGKPNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetSdkAuthenticationSignature(string NFPMPHGKPNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetUserFirstName(string JFOCKNJCPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetUserLastName(string IADIMKEEKBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetUserEmail(string JHDOELFMJKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetUserGender(EBGODPEGNJL BFDDLJDOKHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetUserDateOfBirth(int BFLPHBBAPBI, int PLJKHOMMMBE, int KHPHBHAKFLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetUserCountry(string GALDPAPBDJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetUserHomeCity(string MIPJMOAODEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetUserEmailNotificationSubscriptionType(JBPAMKOGGAL MPAFFHOGKLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetUserPushNotificationSubscriptionType(JBPAMKOGGAL HJNGJODLACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetUserPhoneNumber(string AIDCDNNJIHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetCustomUserAttribute(string BOMEFJIOGGM, bool MOLEJFDINLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetCustomUserAttribute(string BOMEFJIOGGM, int MOLEJFDINLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetCustomUserAttribute(string BOMEFJIOGGM, float MOLEJFDINLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetCustomUserAttribute(string BOMEFJIOGGM, string MOLEJFDINLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetCustomUserAttributeToNow(string BOMEFJIOGGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetCustomUserAttributeToSecondsFromEpoch(string BOMEFJIOGGM, long OCMGCEOIHON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void UnsetCustomUserAttribute(string BOMEFJIOGGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void IncrementCustomUserAttribute(string BOMEFJIOGGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void IncrementCustomUserAttribute(string BOMEFJIOGGM, int EHAPJBNAIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetCustomUserAttributeArray(string BOMEFJIOGGM, List<string> IACDCADJJAN, int OCMPILAHMAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void AddToCustomUserAttributeArray(string BOMEFJIOGGM, string MOLEJFDINLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void RemoveFromCustomUserAttributeArray(string BOMEFJIOGGM, string MOLEJFDINLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void setUserFacebookData(string DEPEGBEMCKD, string JFOCKNJCPCL, string IADIMKEEKBK, string JHDOELFMJKJ, string MGIFKOLEMGP, string MCPDNINJNLM, EBGODPEGNJL? BFDDLJDOKHO, int? OGEHIGHAJHN, string CDHCFCAHGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void setUserTwitterData(int? CDJECPLIIGP, string DFIOHBMDMEG, string ECMAPGHKHFB, string MNBBLNHEBBG, int? BDBPGIIFMGK, int? BMFLAJNKENI, int? BCAFIGGCDFP, string OKGDGGACLHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetUserLastKnownLocation(double ILPGHGEEJCF, double EPBKCOFPEID, [Optional] double? JHONAPLKHDO, [Optional] double? MJJFPDJMCEA, [Optional] double? PKJOMEFBNFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void PromptUserForPushPermissions(bool NJGHINKADFD, [Optional] LAEOEJMBBBG JOJCANHEPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetPushTokenReceivedFromSystemDelegate(FBLAKKDJBPC CELMFNGLBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void LogInAppMessageClicked(string APGJAKAKJBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void LogInAppMessageImpression(string APGJAKAKJBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void LogInAppMessageButtonClicked(string APGJAKAKJBJ, int GBKIIOAAOHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void RequestFeedRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void RequestFeedRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void LogFeedDisplayed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void RequestContentCardsRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void RequestContentCardsRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void LogContentCardClicked(string DFCHCLPNIBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void LogContentCardImpression(string DFCHCLPNIBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void LogContentCardDismissed(string DFCHCLPNIBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void WipeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void EnableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void DisableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x95FD90", Offset = "0x95E390", VA = "0x18095FD90")]
		public static string GetInstallTrackingId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetAttributionData(string KICKDGJFNIJ, string IHNGBBPBGOD, string AGGOBHMDGIC, string NPGJFHKOBJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void RequestLocationInitialization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void RequestGeofences(decimal ILPGHGEEJCF, decimal EPBKCOFPEID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void RequestImmediateDataFlush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void AddAlias(string LABOLPLMHLA, string MCLGIMEHNKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void ConfigureListener(EJOHNEOKBOO JKNFMBJLGAC, string HNIPALHBMAE, string JKAECLOEKBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void SetInAppMessageDisplayAction(KNMFJNLINBH NKICOIJOKKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void DisplayNextInAppMessage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void DisplayContentCards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void AddToSubscriptionGroup(string MJBJADACIFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80")]
		public static void RemoveFromSubscriptionGroup(string MJBJADACIFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6C47D90", Offset = "0x6C46390", VA = "0x186C47D90")]
		public AppboyBinding()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AppboyBindingTester : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6C47D10", Offset = "0x6C46310", VA = "0x186C47D10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6C46C30", Offset = "0x6C45230", VA = "0x186C46C30")]
		private void AHHKIDKCDEH(string DPAJDIEBNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6C47C90", Offset = "0x6C46290", VA = "0x186C47C90")]
		private void PMDEMBKOHOK(string DPAJDIEBNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6C46D20", Offset = "0x6C45320", VA = "0x186C46D20")]
		private void HAOFIOIIOFD(string DPAJDIEBNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6C46DA0", Offset = "0x6C453A0", VA = "0x186C46DA0")]
		private void HOFHOFAIECM(string DPAJDIEBNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6C46EB0", Offset = "0x6C454B0", VA = "0x186C46EB0")]
		private void IGOPDLPNBLI(string DPAJDIEBNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6C47A90", Offset = "0x6C46090", VA = "0x186C47A90")]
		private void OMMJAAGMMBB(string DPAJDIEBNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6C47260", Offset = "0x6C45860", VA = "0x186C47260")]
		private void LGGKMBLMNMA(string DPAJDIEBNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6C47850", Offset = "0x6C45E50", VA = "0x186C47850")]
		private void OGHGFCCEMGG(string DPAJDIEBNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6C473E0", Offset = "0x6C459E0", VA = "0x186C473E0")]
		private void OGANIMPNMNF(string DPAJDIEBNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6C47C10", Offset = "0x6C46210", VA = "0x186C47C10")]
		private void OMPBEEFHCBK(string DPAJDIEBNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6C46FC0", Offset = "0x6C455C0", VA = "0x186C46FC0")]
		public static void InAppMessageBeforeDisplayed(HCAMDGOFEOA DPAJDIEBNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6C47150", Offset = "0x6C45750", VA = "0x186C47150")]
		public static void InAppMessageDismissed(HCAMDGOFEOA DPAJDIEBNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6C470D0", Offset = "0x6C456D0", VA = "0x186C470D0")]
		public static void InAppMessageClicked(HCAMDGOFEOA DPAJDIEBNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6C47040", Offset = "0x6C45640", VA = "0x186C47040")]
		public static void InAppMessageButtonClicked(HCAMDGOFEOA DPAJDIEBNKM, NEODALJBNEJ GNHHGEIFGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6C471D0", Offset = "0x6C457D0", VA = "0x186C471D0")]
		public static void InAppMessageHTMLClicked(HCAMDGOFEOA DPAJDIEBNKM, Uri MACEPHHAICD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
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
		private static GameObject DFKGLOBLDNJ;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static GameObject HAMPJMKDJOL
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6C493A0", Offset = "0x6C479A0", VA = "0x186C493A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6C49550", Offset = "0x6C47B50", VA = "0x186C49550")]
		public static void setPushPromptResponseReceivedDelegate(LAEOEJMBBBG JOJCANHEPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6C495B0", Offset = "0x6C47BB0", VA = "0x186C495B0")]
		public static void setPushTokenReceivedFromSystemDelegate(FBLAKKDJBPC JOJCANHEPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6C494F0", Offset = "0x6C47AF0", VA = "0x186C494F0")]
		public static void setInAppMessageListener(APFDBPCIAOP KECPOFKJEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
		public BrazeInternalGameObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class BrazeInternalComponent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private LAEOEJMBBBG DDMKEADIOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private FBLAKKDJBPC JKCAFLMPECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public APFDBPCIAOP iamListener;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C00", Offset = "0x7F5200", VA = "0x1807F6C00")]
		public void setPushPromptResponseReceivedDelegate(LAEOEJMBBBG JOJCANHEPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x91A1A0", Offset = "0x9187A0", VA = "0x18091A1A0")]
		public void setPushTokenReceivedFromSystemDelegate(FBLAKKDJBPC JOJCANHEPIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6C49300", Offset = "0x6C47900", VA = "0x186C49300")]
		public void onPushPromptResponseReceived(string KBKPPPFJEMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6C49380", Offset = "0x6C47980", VA = "0x186C49380")]
		public void onPushTokenReceivedFromSystem(string DCEGGIJLHGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C48B30", Offset = "0x6C47130", VA = "0x186C48B30")]
		public void beforeInAppMessageDisplayed(string EJAEHHGFIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C48F80", Offset = "0x6C47580", VA = "0x186C48F80")]
		public void onInAppMessageDismissed(string EJAEHHGFIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C48F00", Offset = "0x6C47500", VA = "0x186C48F00")]
		public void onInAppMessageClicked(string EJAEHHGFIKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6C48BB0", Offset = "0x6C471B0", VA = "0x186C48BB0")]
		public void onInAppMessageButtonClicked(string FIDJBHKBKMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6C49000", Offset = "0x6C47600", VA = "0x186C49000")]
		public void onInAppMessageHTMLClicked(string FIDJBHKBKMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7EAA60", Offset = "0x7E9060", VA = "0x1807EAA60")]
		public BrazeInternalComponent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AGJPEOFIOMM
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C46770", Offset = "0x6C44D70", VA = "0x186C46770")]
	public static Color? GAJBPHNPIMC(string MDLAJHEHODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6C468E0", Offset = "0x6C44EE0", VA = "0x186C468E0")]
	public static Color GAJBPHNPIMC(int MDLAJHEHODH)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DefaultMember("Item")]
public class MGMEDENILFD
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public virtual MGMEDENILFD ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x95FD90", Offset = "0x95E390", VA = "0x18095FD90", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual MGMEDENILFD ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x95FD90", Offset = "0x95E390", VA = "0x18095FD90", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public virtual string INKIKMDHKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6C51920", Offset = "0x6C4FF20", VA = "0x186C51920", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public virtual int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x95FD90", Offset = "0x95E390", VA = "0x18095FD90", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual int ADNJFGMOHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6C50AE0", Offset = "0x6C4F0E0", VA = "0x186C50AE0", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6C51710", Offset = "0x6C4FD10", VA = "0x186C51710", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public virtual bool NIPNIELIMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6C51950", Offset = "0x6C4FF50", VA = "0x186C51950", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6C51840", Offset = "0x6C4FE40", VA = "0x186C51840", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public virtual BACPCNODDJO MGLLPPOOBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6C515F0", Offset = "0x6C4FBF0", VA = "0x186C515F0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public virtual OOEPBIJBBDN BOINDONCKBB
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6C51570", Offset = "0x6C4FB70", VA = "0x186C51570", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8C4E80", Offset = "0x8C3480", VA = "0x1808C4E80", Slot = "4")]
	public virtual void PDDBDHJNBOH(string IPFEJFNHAPI, MGMEDENILFD EDHEBEBLJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6C518C0", Offset = "0x6C4FEC0", VA = "0x186C518C0", Slot = "10")]
	public virtual void PDDBDHJNBOH(MGMEDENILFD EDHEBEBLJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C51A10", Offset = "0x6C50010", VA = "0x186C51A10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6C517E0", Offset = "0x6C4FDE0", VA = "0x186C517E0")]
	public static MGMEDENILFD LBBGOAOJJNO(string AODCBLNIDOM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6C51750", Offset = "0x6C4FD50", VA = "0x186C51750")]
	public static string LBBGOAOJJNO(MGMEDENILFD MMDGGJCJIAF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6C514D0", Offset = "0x6C4FAD0", VA = "0x186C514D0")]
	public static bool BDIEMMGDBNG(MGMEDENILFD GNJGFBLEGKK, object HEPECHBEGLE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6C51670", Offset = "0x6C4FC70", VA = "0x186C51670")]
	public static bool HGHCMFFFPIK(MGMEDENILFD GNJGFBLEGKK, object HEPECHBEGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x19D1CA0", Offset = "0x19D02A0", VA = "0x1819D1CA0", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xD03A50", Offset = "0xD02050", VA = "0x180D03A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C50B20", Offset = "0x6C4F120", VA = "0x186C50B20")]
	internal static string AEONHEHEEOE(string JAEAPFBGPGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6C50CB0", Offset = "0x6C4F2B0", VA = "0x186C50CB0")]
	public static MGMEDENILFD BBHEMDBKJME(string LGJAOEODGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public MGMEDENILFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DefaultMember("Item")]
public class BACPCNODDJO : MGMEDENILFD, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class JAKLEPDFFEN : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public BACPCNODDJO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<MGMEDENILFD>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private MGMEDENILFD <N>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
		[DebuggerHidden]
		public JAKLEPDFFEN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F150", Offset = "0x6C4D750", VA = "0x186C4F150", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6C4EF70", Offset = "0x6C4D570", VA = "0x186C4EF70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6C4EF20", Offset = "0x6C4D520", VA = "0x186C4EF20")]
		private void FGFPPIJLKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F110", Offset = "0x6C4D710", VA = "0x186C4F110", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<MGMEDENILFD> APNJOLHENEC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override MGMEDENILFD ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6C48790", Offset = "0x6C46D90", VA = "0x186C48790", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override MGMEDENILFD ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6C48730", Offset = "0x6C46D30", VA = "0x186C48730", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6C486F0", Offset = "0x6C46CF0", VA = "0x186C486F0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6C488B0", Offset = "0x6C46EB0", VA = "0x186C488B0", Slot = "4")]
	public override void PDDBDHJNBOH(string IPFEJFNHAPI, MGMEDENILFD EDHEBEBLJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6C48840", Offset = "0x6C46E40", VA = "0x186C48840", Slot = "17")]
	[IteratorStateMachine(typeof(JAKLEPDFFEN))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6C48910", Offset = "0x6C46F10", VA = "0x186C48910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6C48AB0", Offset = "0x6C470B0", VA = "0x186C48AB0")]
	public BACPCNODDJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public class OOEPBIJBBDN : MGMEDENILFD, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class DMNEAFNAOAN : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public OOEPBIJBBDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Dictionary<string, MGMEDENILFD>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private KeyValuePair<string, MGMEDENILFD> <N>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x975A90", Offset = "0x974090", VA = "0x180975A90")]
		[DebuggerHidden]
		public DMNEAFNAOAN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6C4AB70", Offset = "0x6C49170", VA = "0x186C4AB70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6C4A950", Offset = "0x6C48F50", VA = "0x186C4A950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6C4A900", Offset = "0x6C48F00", VA = "0x186C4A900")]
		private void FGFPPIJLKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6C4AB30", Offset = "0x6C49130", VA = "0x186C4AB30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<string, MGMEDENILFD> CCIDFJFGLCK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override MGMEDENILFD ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6C55020", Offset = "0x6C53620", VA = "0x186C55020", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override MGMEDENILFD ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6C54F70", Offset = "0x6C53570", VA = "0x186C54F70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public override int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6C54F20", Offset = "0x6C53520", VA = "0x186C54F20", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6C55160", Offset = "0x6C53760", VA = "0x186C55160", Slot = "4")]
	public override void PDDBDHJNBOH(string IPFEJFNHAPI, MGMEDENILFD EDHEBEBLJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6C550F0", Offset = "0x6C536F0", VA = "0x186C550F0", Slot = "17")]
	[IteratorStateMachine(typeof(DMNEAFNAOAN))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6C552A0", Offset = "0x6C538A0", VA = "0x186C552A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6C556A0", Offset = "0x6C53CA0", VA = "0x186C556A0")]
	public OOEPBIJBBDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class IHJDECPGCMF : MGMEDENILFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private string MIGPEPADNGK;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public override string INKIKMDHKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xE93CC0", Offset = "0xE922C0", VA = "0x180E93CC0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x97E0F0", Offset = "0x97C6F0", VA = "0x18097E0F0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xA0C770", Offset = "0xA0AD70", VA = "0x180A0C770")]
	public IHJDECPGCMF(string HBKIEHNBANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6C4E440", Offset = "0x6C4CA40", VA = "0x186C4E440")]
	public IHJDECPGCMF(bool HBKIEHNBANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6C4E400", Offset = "0x6C4CA00", VA = "0x186C4E400")]
	public IHJDECPGCMF(int HBKIEHNBANP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6C4E3B0", Offset = "0x6C4C9B0", VA = "0x186C4E3B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
internal class ODCJLDHOLEM : MGMEDENILFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private MGMEDENILFD CBIOKFDFDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private string GFDFOKDPLLH;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public override MGMEDENILFD ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6C53E80", Offset = "0x6C52480", VA = "0x186C53E80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override MGMEDENILFD ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6C53E10", Offset = "0x6C52410", VA = "0x186C53E10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override int ADNJFGMOHEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6C53C30", Offset = "0x6C52230", VA = "0x186C53C30", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6C53F90", Offset = "0x6C52590", VA = "0x186C53F90", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override bool NIPNIELIMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6C542F0", Offset = "0x6C528F0", VA = "0x186C542F0", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6C54060", Offset = "0x6C52660", VA = "0x186C54060", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override BACPCNODDJO MGLLPPOOBBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6C53EE0", Offset = "0x6C524E0", VA = "0x186C53EE0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public override OOEPBIJBBDN BOINDONCKBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6C53CF0", Offset = "0x6C522F0", VA = "0x186C53CF0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6C54470", Offset = "0x6C52A70", VA = "0x186C54470")]
	public ODCJLDHOLEM(MGMEDENILFD MBNEGCNHLFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6C543E0", Offset = "0x6C529E0", VA = "0x186C543E0")]
	public ODCJLDHOLEM(MGMEDENILFD MBNEGCNHLFK, string IPFEJFNHAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6C53DA0", Offset = "0x6C523A0", VA = "0x186C53DA0")]
	private void FGMAFKALEHD(MGMEDENILFD IAFHAKOOEBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C54220", Offset = "0x6C52820", VA = "0x186C54220", Slot = "10")]
	public override void PDDBDHJNBOH(MGMEDENILFD EDHEBEBLJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C54130", Offset = "0x6C52730", VA = "0x186C54130", Slot = "4")]
	public override void PDDBDHJNBOH(string IPFEJFNHAPI, MGMEDENILFD EDHEBEBLJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x25DD680", Offset = "0x25DBC80", VA = "0x1825DD680", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xD03A50", Offset = "0xD02050", VA = "0x180D03A50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6C543B0", Offset = "0x6C529B0", VA = "0x186C543B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class JBGIEKHAONF
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F1E0", Offset = "0x6C4D7E0", VA = "0x186C4F1E0")]
	public static MGMEDENILFD BBHEMDBKJME(string LGJAOEODGND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FCHFPNFDNGP
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6C4AC00", Offset = "0x6C49200", VA = "0x186C4AC00")]
	public static object JPKCPKADLHL(Type JJAFEMBKNDO, string MOLEJFDINLH, bool IEPPPFPPHMI, object INIEFLCMFEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HOMGHHBHIMC
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6C4CC70", Offset = "0x6C4B270", VA = "0x186C4CC70")]
	public static Dictionary<string, string> NAGJENMLAOG(OOEPBIJBBDN IFIGOIHCFPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class IINONEKEBMK
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6C4E480", Offset = "0x6C4CA80", VA = "0x186C4E480")]
	public static string KKBFFJGPOLG(Dictionary<string, string> PPGANGPLNJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x11D63F0", Offset = "0x11D49F0", VA = "0x1811D63F0")]
	public static string MFEDCMPHJJB<T>(List<T> CKIKFMIOAHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum CIHNHDKGLKL
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
public enum CAKMCBFPKNA
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	TOP,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	BOTTOM
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NLJMHLCKPIC
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public string GFFNFPLOMBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x97E0F0", Offset = "0x97C6F0", VA = "0x18097E0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string IKBAGGBCBGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C00", Offset = "0x7F5200", VA = "0x1807F6C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string PGFIEKIKBPA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x91A1A0", Offset = "0x9187A0", VA = "0x18091A1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public Dictionary<string, string> DLNHKNKPBAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x913730", Offset = "0x911D30", VA = "0x180913730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7EA9D0", Offset = "0x7E8FD0", VA = "0x1807EA9D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int LCAIGHJOIOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9A9BE0", Offset = "0x9A81E0", VA = "0x1809A9BE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9A9C70", Offset = "0x9A8270", VA = "0x1809A9C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long EFOIKOCOLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7F65D0", Offset = "0x7F4BD0", VA = "0x1807F65D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xED1D20", Offset = "0xED0320", VA = "0x180ED1D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public string DMGKIFKMJGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9B2080", Offset = "0x9B0680", VA = "0x1809B2080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA2A670", Offset = "0xA28C70", VA = "0x180A2A670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6C52E30", Offset = "0x6C51430", VA = "0x186C52E30")]
	public NLJMHLCKPIC(string DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6C52AE0", Offset = "0x6C510E0", VA = "0x186C52AE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6C52980", Offset = "0x6C50F80", VA = "0x186C52980")]
	private string LODAECJCAJM(OOEPBIJBBDN IFIGOIHCFPF, string BOMEFJIOGGM, string INIEFLCMFEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6C52620", Offset = "0x6C50C20", VA = "0x186C52620")]
	private int BOCONJIBMPB(OOEPBIJBBDN IFIGOIHCFPF, string BOMEFJIOGGM, int INIEFLCMFEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6C527D0", Offset = "0x6C50DD0", VA = "0x186C527D0")]
	private long CNJDNPLNJKO(OOEPBIJBBDN IFIGOIHCFPF, string BOMEFJIOGGM, long INIEFLCMFEE)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GGCEEHHPIDG
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<GBEMDNPFMNN> DOGFKPKLLIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x97E0F0", Offset = "0x97C6F0", VA = "0x18097E0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool ABOEJFNDIHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xC00670", Offset = "0xBFEC70", VA = "0x180C00670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C710", Offset = "0x6C4AD10", VA = "0x186C4C710")]
	public GGCEEHHPIDG(string DPAJDIEBNKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C4B0", Offset = "0x6C4AAB0", VA = "0x186C4C4B0")]
	private static GBEMDNPFMNN CPPGEJOPKIJ(OOEPBIJBBDN IFIGOIHCFPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class NMDNOEPGBMO
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IList<string> HJDCHIPAENL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x97E0F0", Offset = "0x97C6F0", VA = "0x18097E0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string MKMLHFPALFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C00", Offset = "0x7F5200", VA = "0x1807F6C00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string BIKFABHKNGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x91A1A0", Offset = "0x9187A0", VA = "0x18091A1A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string ANIFNHNGFAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x913730", Offset = "0x911D30", VA = "0x180913730")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7EA9D0", Offset = "0x7E8FD0", VA = "0x1807EA9D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string BAMDHPKGLAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x919C70", Offset = "0x918270", VA = "0x180919C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6C53630", Offset = "0x6C51C30", VA = "0x186C53630")]
	public NMDNOEPGBMO(OOEPBIJBBDN IFIGOIHCFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6C53210", Offset = "0x6C51810", VA = "0x186C53210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum BAPBCAHIAON
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	AUTO_DISMISS,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	SWIPE
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class PBGBMACCDMP
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public NMDNOEPGBMO KICCDBDMLEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x97E0F0", Offset = "0x97C6F0", VA = "0x18097E0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int LKADOKAMEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x928590", Offset = "0x926B90", VA = "0x180928590")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xB910F0", Offset = "0xB8F6F0", VA = "0x180B910F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public string BFJGKINJOGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x91A1A0", Offset = "0x9187A0", VA = "0x18091A1A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int PFCKBMGDACL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xBE6A50", Offset = "0xBE5050", VA = "0x180BE6A50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xBE6A70", Offset = "0xBE5070", VA = "0x180BE6A70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IDictionary<string, object> PDBJPODGGAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x919C70", Offset = "0x918270", VA = "0x180919C70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6C564A0", Offset = "0x6C54AA0", VA = "0x186C564A0")]
	public PBGBMACCDMP(OOEPBIJBBDN IFIGOIHCFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6C55720", Offset = "0x6C53D20", VA = "0x186C55720")]
	private object CPHFPELKHCB(MGMEDENILFD ELLNBMOONAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6C55DC0", Offset = "0x6C543C0", VA = "0x186C55DC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum JBPAMKOGGAL
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	OPTED_IN,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	SUBSCRIBED,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	UNSUBSCRIBED
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public enum EBGODPEGNJL
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
public enum MPKHOIEFNEI
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	NEWS_FEED,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	URI,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	NONE
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class FKGCJLPBIIM : GBEMDNPFMNN
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string ONLDBAIAAOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x99CEA0", Offset = "0x99B4A0", VA = "0x18099CEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x99CEB0", Offset = "0x99B4B0", VA = "0x18099CEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string GEDAAAIDFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x95A160", Offset = "0x958760", VA = "0x18095A160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9A6DE0", Offset = "0x9A53E0", VA = "0x1809A6DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string GHIDNCELKMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x938330", Offset = "0x936930", VA = "0x180938330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9383D0", Offset = "0x9369D0", VA = "0x1809383D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6C4AE80", Offset = "0x6C49480", VA = "0x186C4AE80")]
	public FKGCJLPBIIM(OOEPBIJBBDN IFIGOIHCFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6C4AC90", Offset = "0x6C49290", VA = "0x186C4AC90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class OHNOBDHIOGN : GBEMDNPFMNN
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string ONLDBAIAAOA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x99CEA0", Offset = "0x99B4A0", VA = "0x18099CEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x99CEB0", Offset = "0x99B4B0", VA = "0x18099CEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string IKBAGGBCBGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x95A160", Offset = "0x958760", VA = "0x18095A160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9A6DE0", Offset = "0x9A53E0", VA = "0x1809A6DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string FMJCBEDBABM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x938330", Offset = "0x936930", VA = "0x180938330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9383D0", Offset = "0x9369D0", VA = "0x1809383D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string GEDAAAIDFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4A0", Offset = "0x8CBAA0", VA = "0x1808CD4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9585D0", Offset = "0x956BD0", VA = "0x1809585D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string GHIDNCELKMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x974F50", Offset = "0x973550", VA = "0x180974F50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA7E0B0", Offset = "0xA7C6B0", VA = "0x180A7E0B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6C547B0", Offset = "0x6C52DB0", VA = "0x186C547B0")]
	public OHNOBDHIOGN(OOEPBIJBBDN IFIGOIHCFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6C54500", Offset = "0x6C52B00", VA = "0x186C54500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class PGCHHBIMDLF : GBEMDNPFMNN
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string IKBAGGBCBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x99CEA0", Offset = "0x99B4A0", VA = "0x18099CEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x99CEB0", Offset = "0x99B4B0", VA = "0x18099CEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string FMJCBEDBABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x95A160", Offset = "0x958760", VA = "0x18095A160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9A6DE0", Offset = "0x9A53E0", VA = "0x1809A6DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string GEDAAAIDFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x938330", Offset = "0x936930", VA = "0x180938330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x9383D0", Offset = "0x9369D0", VA = "0x1809383D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string GHIDNCELKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4A0", Offset = "0x8CBAA0", VA = "0x1808CD4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x9585D0", Offset = "0x956BD0", VA = "0x1809585D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6C56CB0", Offset = "0x6C552B0", VA = "0x186C56CB0")]
	public PGCHHBIMDLF(OOEPBIJBBDN IFIGOIHCFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6C56A60", Offset = "0x6C55060", VA = "0x186C56A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class IKCNCCKGBKM : GBEMDNPFMNN
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string FMJCBEDBABM
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x99CEA0", Offset = "0x99B4A0", VA = "0x18099CEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x99CEB0", Offset = "0x99B4B0", VA = "0x18099CEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string ONLDBAIAAOA
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x95A160", Offset = "0x958760", VA = "0x18095A160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x9A6DE0", Offset = "0x9A53E0", VA = "0x1809A6DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string IKBAGGBCBGP
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x938330", Offset = "0x936930", VA = "0x180938330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x9383D0", Offset = "0x9369D0", VA = "0x1809383D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string GEDAAAIDFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4A0", Offset = "0x8CBAA0", VA = "0x1808CD4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9585D0", Offset = "0x956BD0", VA = "0x1809585D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string GHIDNCELKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x974F50", Offset = "0x973550", VA = "0x180974F50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA7E0B0", Offset = "0xA7C6B0", VA = "0x180A7E0B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6C4E990", Offset = "0x6C4CF90", VA = "0x186C4E990")]
	public IKCNCCKGBKM(OOEPBIJBBDN IFIGOIHCFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6C4E6E0", Offset = "0x6C4CCE0", VA = "0x186C4E6E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GBEMDNPFMNN
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string JAOJDFGCLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x97E0F0", Offset = "0x97C6F0", VA = "0x18097E0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string BJFLOLKBEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C00", Offset = "0x7F5200", VA = "0x1807F6C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool CMGCKKOMGEB
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x9B4500", Offset = "0x9B2B00", VA = "0x1809B4500")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9B5480", Offset = "0x9B3A80", VA = "0x1809B5480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public long FFIBELNOEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x913730", Offset = "0x911D30", VA = "0x180913730")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x16BE640", Offset = "0x16BCC40", VA = "0x1816BE640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public long FAHBINKGIHF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xC32B90", Offset = "0xC31190", VA = "0x180C32B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public HashSet<CIHNHDKGLKL> HPKDPMIBGPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7F65D0", Offset = "0x7F4BD0", VA = "0x1807F65D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9B3590", Offset = "0x9B1B90", VA = "0x1809B3590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private string HJDJKHJNLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA2A670", Offset = "0xA28C70", VA = "0x180A2A670")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Dictionary<string, string> DLNHKNKPBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7F64D0", Offset = "0x7F4AD0", VA = "0x1807F64D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9B35C0", Offset = "0x9B1BC0", VA = "0x1809B35C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6C4BAB0", Offset = "0x6C4A0B0", VA = "0x186C4BAB0")]
	public GBEMDNPFMNN(OOEPBIJBBDN IFIGOIHCFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B6C0", Offset = "0x6C49CC0", VA = "0x186C4B6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B4B0", Offset = "0x6C49AB0", VA = "0x186C4B4B0")]
	public string LACIMDKOOLK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class CCMEIFMPOKG
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string JAOJDFGCLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7EA010", Offset = "0x7E8610", VA = "0x1807EA010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x97E0F0", Offset = "0x97C6F0", VA = "0x18097E0F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string BJFLOLKBEGK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C00", Offset = "0x7F5200", VA = "0x1807F6C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool CMGCKKOMGEB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9B4500", Offset = "0x9B2B00", VA = "0x1809B4500")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9B5480", Offset = "0x9B3A80", VA = "0x1809B5480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public long FFIBELNOEIC
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x913730", Offset = "0x911D30", VA = "0x180913730")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x16BE640", Offset = "0x16BCC40", VA = "0x1816BE640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public long NFPOOJENENC
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8BD300", Offset = "0x8BB900", VA = "0x1808BD300")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xC32B90", Offset = "0xC31190", VA = "0x180C32B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string ONLDBAIAAOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7F65D0", Offset = "0x7F4BD0", VA = "0x1807F65D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9B3590", Offset = "0x9B1B90", VA = "0x1809B3590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string IKBAGGBCBGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9B2080", Offset = "0x9B0680", VA = "0x1809B2080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA2A670", Offset = "0xA28C70", VA = "0x180A2A670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string FMJCBEDBABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7F64D0", Offset = "0x7F4AD0", VA = "0x1807F64D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9B35C0", Offset = "0x9B1BC0", VA = "0x1809B35C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string GEDAAAIDFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x99CEA0", Offset = "0x99B4A0", VA = "0x18099CEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x99CEB0", Offset = "0x99B4B0", VA = "0x18099CEB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string GHIDNCELKMH
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x95A160", Offset = "0x958760", VA = "0x18095A160")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9A6DE0", Offset = "0x9A53E0", VA = "0x1809A6DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool FJNHHOEFLNG
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7FF090", Offset = "0x7FD690", VA = "0x1807FF090")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x109DB40", Offset = "0x109C140", VA = "0x18109DB40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool EHGEFBPKIMB
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xDFE5A0", Offset = "0xDFCBA0", VA = "0x180DFE5A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xDFDB20", Offset = "0xDFC120", VA = "0x180DFDB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool LCLNAHEEIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x1488440", Offset = "0x1486A40", VA = "0x181488440")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6C49610", Offset = "0x6C47C10", VA = "0x186C49610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool BPCENAADGMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x1488500", Offset = "0x1486B00", VA = "0x181488500")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6C49780", Offset = "0x6C47D80", VA = "0x186C49780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool LOLIPHJEHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xBE5E50", Offset = "0xBE4450", VA = "0x180BE5E50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x20FF930", Offset = "0x20FDF30", VA = "0x1820FF930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public string HJDJKHJNLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8CD4A0", Offset = "0x8CBAA0", VA = "0x1808CD4A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x9585D0", Offset = "0x956BD0", VA = "0x1809585D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Dictionary<string, string> DLNHKNKPBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x974F50", Offset = "0x973550", VA = "0x180974F50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA7E0B0", Offset = "0xA7C6B0", VA = "0x180A7E0B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6C49F30", Offset = "0x6C48530", VA = "0x186C49F30")]
	public CCMEIFMPOKG(OOEPBIJBBDN IFIGOIHCFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6C49790", Offset = "0x6C47D90", VA = "0x186C49790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6C496D0", Offset = "0x6C47CD0", VA = "0x186C496D0")]
	public void KIOINHFFHKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6C49620", Offset = "0x6C47C20", VA = "0x186C49620")]
	public void GNHPJHPCHBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class GDFGPCJDALC : IAGLHPBPFKB
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C4A0", Offset = "0x6C4AAA0", VA = "0x186C4C4A0")]
	public GDFGPCJDALC(OOEPBIJBBDN IFIGOIHCFPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class IAGLHPBPFKB : LKDCFAJKFLB, NFKICDMEDAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private bool EAPCKMDGMMN;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string CEGOGHFDPFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9F3250", Offset = "0x9F1850", VA = "0x1809F3250", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xD5E4B0", Offset = "0xD5CAB0", VA = "0x180D5E4B0", Slot = "28")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Color? MDCAMKJDCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x212A740", Offset = "0x2128D40", VA = "0x18212A740", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6C4CFC0", Offset = "0x6C4B5C0", VA = "0x186C4CFC0", Slot = "30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Color? NCIPMKNKMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D000", Offset = "0x6C4B600", VA = "0x186C4D000", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6C4CFE0", Offset = "0x6C4B5E0", VA = "0x186C4CFE0", Slot = "32")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public List<NEODALJBNEJ> GOLMOHIENDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x937190", Offset = "0x935790", VA = "0x180937190", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xC8E7F0", Offset = "0xC8CDF0", VA = "0x180C8E7F0", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D020", Offset = "0x6C4B620", VA = "0x186C4D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D2F0", Offset = "0x6C4B8F0", VA = "0x186C4D2F0")]
	public IAGLHPBPFKB(OOEPBIJBBDN IFIGOIHCFPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NEODALJBNEJ
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int JBIBPKLMGHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1A0", Offset = "0x7E87A0", VA = "0x1807EA1A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9B6E30", Offset = "0x9B5430", VA = "0x1809B6E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string JACKNKCKNPM
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7F6C00", Offset = "0x7F5200", VA = "0x1807F6C00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string PNDCNFDCAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8BD370", Offset = "0x8BB970", VA = "0x1808BD370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x91A1A0", Offset = "0x9187A0", VA = "0x18091A1A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public MPKHOIEFNEI GGJEGPCEMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xBE6A50", Offset = "0xBE5050", VA = "0x180BE6A50")]
		[CompilerGenerated]
		get
		{
			return default(MPKHOIEFNEI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xBE6A70", Offset = "0xBE5070", VA = "0x180BE6A70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public Color? FJMGHOIGNIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6C51A40", Offset = "0x6C50040", VA = "0x186C51A40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6C51A60", Offset = "0x6C50060", VA = "0x186C51A60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public Color? HLHMPKHNFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2F96CC0", Offset = "0x2F952C0", VA = "0x182F96CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2F96CB0", Offset = "0x2F952B0", VA = "0x182F96CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6C51A70", Offset = "0x6C50070", VA = "0x186C51A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6C51DA0", Offset = "0x6C503A0", VA = "0x186C51DA0")]
	public NEODALJBNEJ(OOEPBIJBBDN IFIGOIHCFPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface HCAMDGOFEOA
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface NFKICDMEDAI
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	List<NEODALJBNEJ> GOLMOHIENDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class IPPEHLKEGFA : IAGLHPBPFKB
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6C4C4A0", Offset = "0x6C4AAA0", VA = "0x186C4C4A0")]
	public IPPEHLKEGFA(OOEPBIJBBDN IFIGOIHCFPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class GAEGMNBFBJF
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B200", Offset = "0x6C49800", VA = "0x186C4B200")]
	public static HCAMDGOFEOA BDOANMPECHI(string APGJAKAKJBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public enum GNGOGMGIKGA
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	FULL,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	MODAL,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	SLIDEUP
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class OKELNFGBEDE
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6C54DC0", Offset = "0x6C533C0", VA = "0x186C54DC0")]
	public static OOEPBIJBBDN ABBKHOIFKJN(string PGBEKFAPGDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class ICMMBGPKCLF : LKDCFAJKFLB
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public CAKMCBFPKNA MMKPOGOPFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA41650", Offset = "0xA3FC50", VA = "0x180A41650")]
		[CompilerGenerated]
		get
		{
			return default(CAKMCBFPKNA);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x31B0AA0", Offset = "0x31AF0A0", VA = "0x1831B0AA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool PCJLGMDNMPN
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x119A3D0", Offset = "0x11989D0", VA = "0x18119A3D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x119A3E0", Offset = "0x11989E0", VA = "0x18119A3E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Color? HENHHNNAEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6C4DCB0", Offset = "0x6C4C2B0", VA = "0x186C4DCB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6C4DCD0", Offset = "0x6C4C2D0", VA = "0x186C4DCD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DCF0", Offset = "0x6C4C2F0", VA = "0x186C4DCF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DF60", Offset = "0x6C4C560", VA = "0x186C4DF60")]
	public ICMMBGPKCLF(OOEPBIJBBDN IFIGOIHCFPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class LKDCFAJKFLB : HCAMDGOFEOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	protected string CHAANMGFLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool CEAILAINHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool AEODPPJIGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int CLINHDFCHBI;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Color? HLHMPKHNFJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x15F4840", Offset = "0x15F2E40", VA = "0x1815F4840", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x1909E00", Offset = "0x1908400", VA = "0x181909E00", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Color? FJMGHOIGNIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F270", Offset = "0x6C4D870", VA = "0x186C4F270", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F2E0", Offset = "0x6C4D8E0", VA = "0x186C4F2E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public string GODHDENMJPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7F64D0", Offset = "0x7F4AD0", VA = "0x1807F64D0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9B35C0", Offset = "0x9B1BC0", VA = "0x1809B35C0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Color? MGJGJNBCHHN
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x22DA070", Offset = "0x22D8670", VA = "0x1822DA070", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x22DA110", Offset = "0x22D8710", VA = "0x1822DA110", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Color? FHPOBDEPBNK
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F290", Offset = "0x6C4D890", VA = "0x186C4F290", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F2F0", Offset = "0x6C4D8F0", VA = "0x186C4F2F0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public string HKODBAPFMFE
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9CC460", Offset = "0x9CAA60", VA = "0x1809CC460", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA0A480", Offset = "0xA08A80", VA = "0x180A0A480", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public string APNBCBOBIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x929320", Offset = "0x927920", VA = "0x180929320", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x9AF3F0", Offset = "0x9AD9F0", VA = "0x1809AF3F0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public Dictionary<string, string> DLNHKNKPBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9F2B30", Offset = "0x9F1130", VA = "0x1809F2B30", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9FA090", Offset = "0x9F8690", VA = "0x1809FA090", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public MPKHOIEFNEI EMKHNDPGDHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xCC7500", Offset = "0xCC5B00", VA = "0x180CC7500", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(MPKHOIEFNEI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xDC3630", Offset = "0xDC1C30", VA = "0x180DC3630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public string PNDCNFDCAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9DA620", Offset = "0x9D8C20", VA = "0x1809DA620", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9D9BA0", Offset = "0x9D81A0", VA = "0x1809D9BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public BAPBCAHIAON AOCGNKLLJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA7E0C0", Offset = "0xA7C6C0", VA = "0x180A7E0C0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(BAPBCAHIAON);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xBA35F0", Offset = "0xBA1BF0", VA = "0x180BA35F0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int BCGBCDBOFLN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xE4E210", Offset = "0xE4C810", VA = "0x180E4E210", Slot = "24")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6C4F2B0", Offset = "0x6C4D8B0", VA = "0x186C4F2B0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F300", Offset = "0x6C4D900", VA = "0x186C4F300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F970", Offset = "0x6C4DF70", VA = "0x186C4F970")]
	public LKDCFAJKFLB(OOEPBIJBBDN IFIGOIHCFPF)
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
