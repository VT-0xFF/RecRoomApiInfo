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
	[Cpp2IlInjected.Address(RVA = "0x6E11790", Offset = "0x6E10B90", VA = "0x186E11790")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6E112D0", Offset = "0x6E106D0", VA = "0x186E112D0")]
	public string PrintOutObjectValues(object EMNJAKHDMIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
	public ApplePushNotificationTester()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DHIKFFGDODM
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MBIPKFOAPMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Action<MADDMLHHEDE> DBONBMDCOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Action<MADDMLHHEDE> KJPKOOGEJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Action<MADDMLHHEDE> LJMFGMIDIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Action<MADDMLHHEDE, JHIKJLODPJA> BMNABGPAHOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public Action<MADDMLHHEDE, Uri> LDBHKONOHKN;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum PIOMOEFMJBH
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
public enum DPGMFOMMFGB
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	IAM_DISPLAY_NOW,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	IAM_DISPLAY_LATER,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	IAM_DISCARD
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void IAGLKHLGBAN(bool NAKCPFONIJH);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void MFPBEECIGEA(string AEMEEHLIDCM);
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AppboyBinding : SingletonMonoBehaviour<AppboyBinding>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static DHIKFFGDODM OMBMBJCGIIC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static DHIKFFGDODM FFADENLPOHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6E11290", Offset = "0x6E10690", VA = "0x186E11290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static MBIPKFOAPMC OLHKGCKCHHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8C9920", Offset = "0x8C8D20", VA = "0x1808C9920")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void LogCustomEvent(string FNMHFGHGEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void LogCustomEvent(string FNMHFGHGEMD, Dictionary<string, object> OEGNIABGFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void LogPurchase(string ALAIIBGHIEG, string IGNNLIEIJNJ, decimal JPMDEAEKLGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void LogPurchase(string ALAIIBGHIEG, string IGNNLIEIJNJ, decimal JPMDEAEKLGB, int AIMCAKGJJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void LogPurchase(string ALAIIBGHIEG, string IGNNLIEIJNJ, decimal JPMDEAEKLGB, int AIMCAKGJJGG, Dictionary<string, object> OEGNIABGFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void ChangeUser(string JEJLDCJDABJ, [Optional] string ANJKHKECFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetSdkAuthenticationSignature(string ANJKHKECFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetUserFirstName(string IGLJMAMGCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetUserLastName(string PHGFLIHFFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetUserEmail(string OOAODBPNIIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetUserGender(GHAAHCMAPFK BANHCFOIBBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetUserDateOfBirth(int FGOPGKGALKA, int GNMMLHLANMP, int BKFANMJCPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetUserCountry(string PNMGOKENFIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetUserHomeCity(string AJPOALEECND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetUserEmailNotificationSubscriptionType(GJEEPODKDFH ILBBMNOIECN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetUserPushNotificationSubscriptionType(GJEEPODKDFH ALNJLALPDAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetUserPhoneNumber(string OMIJACPJADK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetCustomUserAttribute(string PMMAAICOJOP, bool AGLCIEKHLEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetCustomUserAttribute(string PMMAAICOJOP, int AGLCIEKHLEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetCustomUserAttribute(string PMMAAICOJOP, float AGLCIEKHLEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetCustomUserAttribute(string PMMAAICOJOP, string AGLCIEKHLEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetCustomUserAttributeToNow(string PMMAAICOJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetCustomUserAttributeToSecondsFromEpoch(string PMMAAICOJOP, long BBDJIGJLADP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void UnsetCustomUserAttribute(string PMMAAICOJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void IncrementCustomUserAttribute(string PMMAAICOJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void IncrementCustomUserAttribute(string PMMAAICOJOP, int MKMDJGPJFPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetCustomUserAttributeArray(string PMMAAICOJOP, List<string> EACKPMFPNLH, int AJCINIIEJAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void AddToCustomUserAttributeArray(string PMMAAICOJOP, string AGLCIEKHLEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void RemoveFromCustomUserAttributeArray(string PMMAAICOJOP, string AGLCIEKHLEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void setUserFacebookData(string MMLCEIBDJEL, string IGLJMAMGCMH, string PHGFLIHFFFM, string OOAODBPNIIM, string DEADHMKEKCB, string KIBHBAMAMFG, GHAAHCMAPFK? BANHCFOIBBF, int? MDALMPNMKOM, string EFANMKJMGKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void setUserTwitterData(int? BAAPLDAJFDM, string DIILJBHBELJ, string GDKOBCHHFLB, string NLDGENPEJBJ, int? FOFABJNBPKK, int? ILFEELOBNKH, int? HHEILKIIKJO, string PIFEADMPCMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetUserLastKnownLocation(double CAIGDEHPPDG, double EDKOHNFJKIA, [Optional] double? DPEMEJCHBOF, [Optional] double? MDDJKICNILA, [Optional] double? FKMMLBHADJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void PromptUserForPushPermissions(bool OGLPOHHBGKF, [Optional] IAGLKHLGBAN LBALDBLBDOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetPushTokenReceivedFromSystemDelegate(MFPBEECIGEA CGOFHOCHEID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void LogInAppMessageClicked(string ODBBDNLKCLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void LogInAppMessageImpression(string ODBBDNLKCLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void LogInAppMessageButtonClicked(string ODBBDNLKCLC, int PGJHONIILLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void RequestFeedRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void RequestFeedRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void LogFeedDisplayed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void RequestContentCardsRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void RequestContentCardsRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void LogContentCardClicked(string CFFPKBNNJNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void LogContentCardImpression(string CFFPKBNNJNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void LogContentCardDismissed(string CFFPKBNNJNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void WipeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void EnableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void DisableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8C9920", Offset = "0x8C8D20", VA = "0x1808C9920")]
		public static string GetInstallTrackingId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetAttributionData(string OKOJLHMIJKD, string HLEAHMBFFKJ, string DNMMGDBIDAL, string BHCMLGLEBAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void RequestLocationInitialization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void RequestGeofences(decimal CAIGDEHPPDG, decimal EDKOHNFJKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void RequestImmediateDataFlush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void AddAlias(string KAMDDJGGACO, string PBPMMNLOLHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void ConfigureListener(PIOMOEFMJBH MNAFCHCPDFJ, string AAKPCOOCKEN, string FNDJCENOLLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void SetInAppMessageDisplayAction(DPGMFOMMFGB FBDPHEGBEAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void DisplayNextInAppMessage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void DisplayContentCards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void AddToSubscriptionGroup(string JNHCLKAAKHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490")]
		public static void RemoveFromSubscriptionGroup(string JNHCLKAAKHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6E11250", Offset = "0x6E10650", VA = "0x186E11250")]
		public AppboyBinding()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AppboyBindingTester : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6E111D0", Offset = "0x6E105D0", VA = "0x186E111D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6E110E0", Offset = "0x6E104E0", VA = "0x186E110E0")]
		private void PKGFNODNICN(string FHDJIGKOLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6E10920", Offset = "0x6E0FD20", VA = "0x186E10920")]
		private void GJNLHKDHOBH(string FHDJIGKOLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6E10F50", Offset = "0x6E10350", VA = "0x186E10F50")]
		private void LMPCNAOGKEG(string FHDJIGKOLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6E10FD0", Offset = "0x6E103D0", VA = "0x186E10FD0")]
		private void MGEHFGAOLFG(string FHDJIGKOLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6E10A20", Offset = "0x6E0FE20", VA = "0x186E10A20")]
		private void HMOGHMDCBFC(string FHDJIGKOLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6E10DD0", Offset = "0x6E101D0", VA = "0x186E10DD0")]
		private void JBEEOBDPDAC(string FHDJIGKOLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6E100F0", Offset = "0x6E0F4F0", VA = "0x186E100F0")]
		private void BFJGOFPJELG(string FHDJIGKOLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6E10270", Offset = "0x6E0F670", VA = "0x186E10270")]
		private void BGNDLAFLBGC(string FHDJIGKOLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6E104B0", Offset = "0x6E0F8B0", VA = "0x186E104B0")]
		private void EABLGOMLGEI(string FHDJIGKOLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6E109A0", Offset = "0x6E0FDA0", VA = "0x186E109A0")]
		private void HHONDJEKADI(string FHDJIGKOLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6E10B30", Offset = "0x6E0FF30", VA = "0x186E10B30")]
		public static void InAppMessageBeforeDisplayed(MADDMLHHEDE FHDJIGKOLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6E10CC0", Offset = "0x6E100C0", VA = "0x186E10CC0")]
		public static void InAppMessageDismissed(MADDMLHHEDE FHDJIGKOLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6E10C40", Offset = "0x6E10040", VA = "0x186E10C40")]
		public static void InAppMessageClicked(MADDMLHHEDE FHDJIGKOLJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6E10BB0", Offset = "0x6E0FFB0", VA = "0x186E10BB0")]
		public static void InAppMessageButtonClicked(MADDMLHHEDE FHDJIGKOLJM, JHIKJLODPJA OCIPJKMJCCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6E10D40", Offset = "0x6E10140", VA = "0x186E10D40")]
		public static void InAppMessageHTMLClicked(MADDMLHHEDE FHDJIGKOLJM, Uri JNHPKNDDFMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
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
		private static GameObject IILNPDLGJIK;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static GameObject FNGGPKJOCFE
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6E126E0", Offset = "0x6E11AE0", VA = "0x186E126E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6E12890", Offset = "0x6E11C90", VA = "0x186E12890")]
		public static void setPushPromptResponseReceivedDelegate(IAGLKHLGBAN LBALDBLBDOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6E128F0", Offset = "0x6E11CF0", VA = "0x186E128F0")]
		public static void setPushTokenReceivedFromSystemDelegate(MFPBEECIGEA LBALDBLBDOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6E12830", Offset = "0x6E11C30", VA = "0x186E12830")]
		public static void setInAppMessageListener(MBIPKFOAPMC OLHKGCKCHHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public BrazeInternalGameObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class BrazeInternalComponent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private IAGLKHLGBAN LBFEKFKNMHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private MFPBEECIGEA JIIIJBFLOOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public MBIPKFOAPMC iamListener;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8C5080", Offset = "0x8C4480", VA = "0x1808C5080")]
		public void setPushPromptResponseReceivedDelegate(IAGLKHLGBAN LBALDBLBDOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD60", Offset = "0x8BB160", VA = "0x1808BBD60")]
		public void setPushTokenReceivedFromSystemDelegate(MFPBEECIGEA LBALDBLBDOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6E12640", Offset = "0x6E11A40", VA = "0x186E12640")]
		public void onPushPromptResponseReceived(string EFJKGNCMMPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6E126C0", Offset = "0x6E11AC0", VA = "0x186E126C0")]
		public void onPushTokenReceivedFromSystem(string AEMEEHLIDCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6E11E70", Offset = "0x6E11270", VA = "0x186E11E70")]
		public void beforeInAppMessageDisplayed(string MPGAPMPDELN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6E122C0", Offset = "0x6E116C0", VA = "0x186E122C0")]
		public void onInAppMessageDismissed(string MPGAPMPDELN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E12240", Offset = "0x6E11640", VA = "0x186E12240")]
		public void onInAppMessageClicked(string MPGAPMPDELN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6E11EF0", Offset = "0x6E112F0", VA = "0x186E11EF0")]
		public void onInAppMessageButtonClicked(string BJGGJNDFFEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6E12340", Offset = "0x6E11740", VA = "0x186E12340")]
		public void onInAppMessageHTMLClicked(string BJGGJNDFFEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x976820", Offset = "0x975C20", VA = "0x180976820")]
		public BrazeInternalComponent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class APEKDPBGDHB
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0FF80", Offset = "0x6E0F380", VA = "0x186E0FF80")]
	public static Color? LNDKLMFKFCC(string GEJHMBPINHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6E0FC30", Offset = "0x6E0F030", VA = "0x186E0FC30")]
	public static Color LNDKLMFKFCC(int GEJHMBPINHP)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DefaultMember("Item")]
public class DIGDKLHKIHG
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public virtual DIGDKLHKIHG ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8C9920", Offset = "0x8C8D20", VA = "0x1808C9920", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual DIGDKLHKIHG ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8C9920", Offset = "0x8C8D20", VA = "0x1808C9920", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public virtual string EKGBCCDIAJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6E133E0", Offset = "0x6E127E0", VA = "0x186E133E0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public virtual int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8C9920", Offset = "0x8C8D20", VA = "0x1808C9920", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual int OEBEBOCPJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6E133A0", Offset = "0x6E127A0", VA = "0x186E133A0", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6E13660", Offset = "0x6E12A60", VA = "0x186E13660", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public virtual bool FPKIPLEOFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6E13740", Offset = "0x6E12B40", VA = "0x186E13740", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6E13800", Offset = "0x6E12C00", VA = "0x186E13800", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public virtual OEOJMJLJJDN JOPIGDJALMC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6E13410", Offset = "0x6E12810", VA = "0x186E13410", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public virtual NAEMNNIPJDE ABHNIKOKGEF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6E13580", Offset = "0x6E12980", VA = "0x186E13580", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8BA490", Offset = "0x8B9890", VA = "0x1808BA490", Slot = "4")]
	public virtual void NNFBEGDMHOD(string BADNDNHJPOA, DIGDKLHKIHG IIIDHADCKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6E13600", Offset = "0x6E12A00", VA = "0x186E13600", Slot = "10")]
	public virtual void NNFBEGDMHOD(DIGDKLHKIHG IIIDHADCKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6E13880", Offset = "0x6E12C80", VA = "0x186E13880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6E13490", Offset = "0x6E12890", VA = "0x186E13490")]
	public static DIGDKLHKIHG LFFBPOODCDC(string LECIMCCDIIM)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6E134F0", Offset = "0x6E128F0", VA = "0x186E134F0")]
	public static string LFFBPOODCDC(DIGDKLHKIHG FPFFKAACHPJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6E136A0", Offset = "0x6E12AA0", VA = "0x186E136A0")]
	public static bool PHJEMBLBEDF(DIGDKLHKIHG NPBBJPKPNCJ, object KBAEKPMBMFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6E12950", Offset = "0x6E11D50", VA = "0x186E12950")]
	public static bool AHGPMPLECPJ(DIGDKLHKIHG NPBBJPKPNCJ, object KBAEKPMBMFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x1AA0B20", Offset = "0x1A9FF20", VA = "0x181AA0B20", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xAACC80", Offset = "0xAAC080", VA = "0x180AACC80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6E13210", Offset = "0x6E12610", VA = "0x186E13210")]
	internal static string FAFCAOKOEEH(string LNKFNPJIPJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6E129F0", Offset = "0x6E11DF0", VA = "0x186E129F0")]
	public static DIGDKLHKIHG AMGMHCBCNPH(string JDJCOFAAGOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public DIGDKLHKIHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DefaultMember("Item")]
public class OEOJMJLJJDN : DIGDKLHKIHG, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class BECJFMACHEB : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public OEOJMJLJJDN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<DIGDKLHKIHG>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private DIGDKLHKIHG <N>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
		[DebuggerHidden]
		public BECJFMACHEB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6E11DE0", Offset = "0x6E111E0", VA = "0x186E11DE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6E11BB0", Offset = "0x6E10FB0", VA = "0x186E11BB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6E11D50", Offset = "0x6E11150", VA = "0x186E11D50")]
		private void PPOPDODPNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6E11DA0", Offset = "0x6E111A0", VA = "0x186E11DA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<DIGDKLHKIHG> DMPFOAPDDPP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override DIGDKLHKIHG ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B5A0", Offset = "0x6E1A9A0", VA = "0x186E1B5A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override DIGDKLHKIHG ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B650", Offset = "0x6E1AA50", VA = "0x186E1B650", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6E1B720", Offset = "0x6E1AB20", VA = "0x186E1B720", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B760", Offset = "0x6E1AB60", VA = "0x186E1B760", Slot = "4")]
	public override void NNFBEGDMHOD(string BADNDNHJPOA, DIGDKLHKIHG IIIDHADCKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B6B0", Offset = "0x6E1AAB0", VA = "0x186E1B6B0", Slot = "17")]
	[IteratorStateMachine(typeof(BECJFMACHEB))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B7C0", Offset = "0x6E1ABC0", VA = "0x186E1B7C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B960", Offset = "0x6E1AD60", VA = "0x186E1B960")]
	public OEOJMJLJJDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public class NAEMNNIPJDE : DIGDKLHKIHG, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class PEPEMAFMIJL : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public NAEMNNIPJDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Dictionary<string, DIGDKLHKIHG>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private KeyValuePair<string, DIGDKLHKIHG> <N>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BAD30", VA = "0x1809BB930")]
		[DebuggerHidden]
		public PEPEMAFMIJL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DCA0", Offset = "0x6E1D0A0", VA = "0x186E1DCA0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DA30", Offset = "0x6E1CE30", VA = "0x186E1DA30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DC10", Offset = "0x6E1D010", VA = "0x186E1DC10")]
		private void PPOPDODPNIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6E1DC60", Offset = "0x6E1D060", VA = "0x186E1DC60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<string, DIGDKLHKIHG> FPDGNKAIMMB;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override DIGDKLHKIHG ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A1B0", Offset = "0x6E195B0", VA = "0x186E1A1B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override DIGDKLHKIHG ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A280", Offset = "0x6E19680", VA = "0x186E1A280", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public override int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6E1A3A0", Offset = "0x6E197A0", VA = "0x186E1A3A0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A3F0", Offset = "0x6E197F0", VA = "0x186E1A3F0", Slot = "4")]
	public override void NNFBEGDMHOD(string BADNDNHJPOA, DIGDKLHKIHG IIIDHADCKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A330", Offset = "0x6E19730", VA = "0x186E1A330", Slot = "17")]
	[IteratorStateMachine(typeof(PEPEMAFMIJL))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A530", Offset = "0x6E19930", VA = "0x186E1A530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A930", Offset = "0x6E19D30", VA = "0x186E1A930")]
	public NAEMNNIPJDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class FBIJFHOKKML : DIGDKLHKIHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private string JIMGBPDMFDJ;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public override string EKGBCCDIAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9FC8D0", Offset = "0x9FBCD0", VA = "0x1809FC8D0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD20", Offset = "0x8BB120", VA = "0x1808BBD20", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8C4170", Offset = "0x8C3570", VA = "0x1808C4170")]
	public FBIJFHOKKML(string FCPBHPOGOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6E13B60", Offset = "0x6E12F60", VA = "0x186E13B60")]
	public FBIJFHOKKML(bool FCPBHPOGOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6E13BA0", Offset = "0x6E12FA0", VA = "0x186E13BA0")]
	public FBIJFHOKKML(int FCPBHPOGOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6E13B10", Offset = "0x6E12F10", VA = "0x186E13B10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
internal class MDKOKBELHFN : DIGDKLHKIHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private DIGDKLHKIHG CIMAGCIBFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private string FBDNNIEIJCD;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public override DIGDKLHKIHG ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6E197D0", Offset = "0x6E18BD0", VA = "0x186E197D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override DIGDKLHKIHG ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6E19830", Offset = "0x6E18C30", VA = "0x186E19830", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override int OEBEBOCPJHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6E19710", Offset = "0x6E18B10", VA = "0x186E19710", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6E19BC0", Offset = "0x6E18FC0", VA = "0x186E19BC0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override bool FPKIPLEOFLP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6E19C90", Offset = "0x6E19090", VA = "0x186E19C90", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6E19D50", Offset = "0x6E19150", VA = "0x186E19D50", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override OEOJMJLJJDN JOPIGDJALMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E198A0", Offset = "0x6E18CA0", VA = "0x186E198A0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public override NAEMNNIPJDE ABHNIKOKGEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E19950", Offset = "0x6E18D50", VA = "0x186E19950", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x44FEDF0", Offset = "0x44FE1F0", VA = "0x1844FEDF0")]
	public MDKOKBELHFN(DIGDKLHKIHG PDLELKDJKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x44FEE80", Offset = "0x44FE280", VA = "0x1844FEE80")]
	public MDKOKBELHFN(DIGDKLHKIHG PDLELKDJKBJ, string BADNDNHJPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6E196A0", Offset = "0x6E18AA0", VA = "0x186E196A0")]
	private void AFLFAPDAOKF(DIGDKLHKIHG GLPLGILLJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6E19AF0", Offset = "0x6E18EF0", VA = "0x186E19AF0", Slot = "10")]
	public override void NNFBEGDMHOD(DIGDKLHKIHG IIIDHADCKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6E19A00", Offset = "0x6E18E00", VA = "0x186E19A00", Slot = "4")]
	public override void NNFBEGDMHOD(string BADNDNHJPOA, DIGDKLHKIHG IIIDHADCKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x44FE9E0", Offset = "0x44FDDE0", VA = "0x1844FE9E0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xAACC80", Offset = "0xAAC080", VA = "0x180AACC80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6E19E20", Offset = "0x6E19220", VA = "0x186E19E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MMNDCCDCKPI
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6E19E50", Offset = "0x6E19250", VA = "0x186E19E50")]
	public static DIGDKLHKIHG AMGMHCBCNPH(string JDJCOFAAGOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HCGAOFNKNFM
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6E159C0", Offset = "0x6E14DC0", VA = "0x186E159C0")]
	public static object KADOMFKFNMI(Type AFJFEPCGIJM, string AGLCIEKHLEE, bool IPABMMNIGEE, object CHKFHALGEFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MPPCAAFGHAL
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6E19E60", Offset = "0x6E19260", VA = "0x186E19E60")]
	public static Dictionary<string, string> KOEMPIPABFP(NAEMNNIPJDE KJEBJAPHFDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FBEDFPFIABI
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6E138B0", Offset = "0x6E12CB0", VA = "0x186E138B0")]
	public static string EAGNBKFEONL(Dictionary<string, string> IOKFOMHMAHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x17A5310", Offset = "0x17A4710", VA = "0x1817A5310")]
	public static string MHEBAKDNDCF<T>(List<T> FIONHDMDJNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum LLEGIJABBOM
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
public enum KOCOGNEOHFJ
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	TOP,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	BOTTOM
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OAKFKDLEAJK
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public string HJGGMJNLPDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD20", Offset = "0x8BB120", VA = "0x1808BBD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string AKPLNHMDHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8C5080", Offset = "0x8C4480", VA = "0x1808C5080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string HPLNCLBOJFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD60", Offset = "0x8BB160", VA = "0x1808BBD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public Dictionary<string, string> OAGCLDCMJPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x823B70", Offset = "0x822F70", VA = "0x180823B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD30", Offset = "0x8BB130", VA = "0x1808BBD30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int MMEDPNPCDJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xABE110", Offset = "0xABD510", VA = "0x180ABE110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xD9E490", Offset = "0xD9D890", VA = "0x180D9E490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long BLMIAELPFJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9857F0", Offset = "0x984BF0", VA = "0x1809857F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA7CE00", Offset = "0xA7C200", VA = "0x180A7CE00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public string MMIHJPPNLPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8C3A00", Offset = "0x8C2E00", VA = "0x1808C3A00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xB9A340", Offset = "0xB99740", VA = "0x180B9A340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B1C0", Offset = "0x6E1A5C0", VA = "0x186E1B1C0")]
	public OAKFKDLEAJK(string FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6E1AE70", Offset = "0x6E1A270", VA = "0x186E1AE70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6E1A9B0", Offset = "0x6E19DB0", VA = "0x186E1A9B0")]
	private string BBAFGCJBGOH(NAEMNNIPJDE KJEBJAPHFDB, string PMMAAICOJOP, string CHKFHALGEFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6E1ACC0", Offset = "0x6E1A0C0", VA = "0x186E1ACC0")]
	private int JJBDCLJIPBG(NAEMNNIPJDE KJEBJAPHFDB, string PMMAAICOJOP, int CHKFHALGEFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6E1AB10", Offset = "0x6E19F10", VA = "0x186E1AB10")]
	private long DONPBIOFMEB(NAEMNNIPJDE KJEBJAPHFDB, string PMMAAICOJOP, long CHKFHALGEFG)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LBKLMELCNIH
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<HKDGLCDKKNL> LEEIEJKLGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD20", Offset = "0x8BB120", VA = "0x1808BBD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool PCAEAENEANM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x901900", Offset = "0x900D00", VA = "0x180901900")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6E18FE0", Offset = "0x6E183E0", VA = "0x186E18FE0")]
	public LBKLMELCNIH(string FHDJIGKOLJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6E18D80", Offset = "0x6E18180", VA = "0x186E18D80")]
	private static HKDGLCDKKNL CANJPFMCNFC(NAEMNNIPJDE KJEBJAPHFDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class AFJCLBOEMNL
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IList<string> ANGFOIGKAKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD20", Offset = "0x8BB120", VA = "0x1808BBD20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string IKIDBPOJLKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8C5080", Offset = "0x8C4480", VA = "0x1808C5080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string IOEAHOIEIAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD60", Offset = "0x8BB160", VA = "0x1808BBD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string AJBEKKAGOCN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x823B70", Offset = "0x822F70", VA = "0x180823B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD30", Offset = "0x8BB130", VA = "0x1808BBD30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string HHOFNGKIDIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4C0", Offset = "0x8B98C0", VA = "0x1808BA4C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F380", Offset = "0x6E0E780", VA = "0x186E0F380")]
	public AFJCLBOEMNL(NAEMNNIPJDE KJEBJAPHFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EF60", Offset = "0x6E0E360", VA = "0x186E0EF60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum DPGHOAFKPFI
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	AUTO_DISMISS,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	SWIPE
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class OFDKGACLKDM
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public AFJCLBOEMNL LGMBGDAMIAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD20", Offset = "0x8BB120", VA = "0x1808BBD20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int JLLMMKBEGKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x978170", Offset = "0x977570", VA = "0x180978170")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD50", Offset = "0x8BB150", VA = "0x1808BBD50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public string KEECGLKGBAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD60", Offset = "0x8BB160", VA = "0x1808BBD60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int APHNCHNOJOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xE903A0", Offset = "0xE8F7A0", VA = "0x180E903A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xE902C0", Offset = "0xE8F6C0", VA = "0x180E902C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IDictionary<string, object> NBJNCJPPIIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8BA4C0", Offset = "0x8B98C0", VA = "0x1808BA4C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C760", Offset = "0x6E1BB60", VA = "0x186E1C760")]
	public OFDKGACLKDM(NAEMNNIPJDE KJEBJAPHFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B9E0", Offset = "0x6E1ADE0", VA = "0x186E1B9E0")]
	private object OKHIFNEMCFB(DIGDKLHKIHG HBBENJBLANN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6E1C080", Offset = "0x6E1B480", VA = "0x186E1C080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum GJEEPODKDFH
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	OPTED_IN,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	SUBSCRIBED,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	UNSUBSCRIBED
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public enum GHAAHCMAPFK
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
public enum ADBKFJAEHJC
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	NEWS_FEED,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	URI,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	NONE
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class FHHFACBCLJE : HKDGLCDKKNL
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string OMKFFDEHDFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA48C70", Offset = "0xA48070", VA = "0x180A48C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA490F0", Offset = "0xA484F0", VA = "0x180A490F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string CJDPIAIOMNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x997FD0", Offset = "0x9973D0", VA = "0x180997FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xABA5D0", Offset = "0xAB99D0", VA = "0x180ABA5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string OBIIBIOJGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFE0", Offset = "0x8CB3E0", VA = "0x1808CBFE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFF0", Offset = "0x8CB3F0", VA = "0x1808CBFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6E13DD0", Offset = "0x6E131D0", VA = "0x186E13DD0")]
	public FHHFACBCLJE(NAEMNNIPJDE KJEBJAPHFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6E13BE0", Offset = "0x6E12FE0", VA = "0x186E13BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class IFDNNMKDIOC : HKDGLCDKKNL
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string OMKFFDEHDFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA48C70", Offset = "0xA48070", VA = "0x180A48C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA490F0", Offset = "0xA484F0", VA = "0x180A490F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string AKPLNHMDHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x997FD0", Offset = "0x9973D0", VA = "0x180997FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xABA5D0", Offset = "0xAB99D0", VA = "0x180ABA5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string JCNOHAELOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFE0", Offset = "0x8CB3E0", VA = "0x1808CBFE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFF0", Offset = "0x8CB3F0", VA = "0x1808CBFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string CJDPIAIOMNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x99C4F0", Offset = "0x99B8F0", VA = "0x18099C4F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x999290", Offset = "0x998690", VA = "0x180999290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string OBIIBIOJGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x9B7D80", Offset = "0x9B7180", VA = "0x1809B7D80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA48FA0", Offset = "0xA483A0", VA = "0x180A48FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6E16D70", Offset = "0x6E16170", VA = "0x186E16D70")]
	public IFDNNMKDIOC(NAEMNNIPJDE KJEBJAPHFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6E16AC0", Offset = "0x6E15EC0", VA = "0x186E16AC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class JEEOMJHCLHA : HKDGLCDKKNL
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string AKPLNHMDHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA48C70", Offset = "0xA48070", VA = "0x180A48C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA490F0", Offset = "0xA484F0", VA = "0x180A490F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string JCNOHAELOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x997FD0", Offset = "0x9973D0", VA = "0x180997FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xABA5D0", Offset = "0xAB99D0", VA = "0x180ABA5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string CJDPIAIOMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFE0", Offset = "0x8CB3E0", VA = "0x1808CBFE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFF0", Offset = "0x8CB3F0", VA = "0x1808CBFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string OBIIBIOJGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x99C4F0", Offset = "0x99B8F0", VA = "0x18099C4F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x999290", Offset = "0x998690", VA = "0x180999290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6E175D0", Offset = "0x6E169D0", VA = "0x186E175D0")]
	public JEEOMJHCLHA(NAEMNNIPJDE KJEBJAPHFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6E17380", Offset = "0x6E16780", VA = "0x186E17380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PLCNBEHLHKF : HKDGLCDKKNL
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string JCNOHAELOOD
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xA48C70", Offset = "0xA48070", VA = "0x180A48C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA490F0", Offset = "0xA484F0", VA = "0x180A490F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string OMKFFDEHDFG
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x997FD0", Offset = "0x9973D0", VA = "0x180997FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xABA5D0", Offset = "0xAB99D0", VA = "0x180ABA5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string AKPLNHMDHGE
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFE0", Offset = "0x8CB3E0", VA = "0x1808CBFE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8CBFF0", Offset = "0x8CB3F0", VA = "0x1808CBFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string CJDPIAIOMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x99C4F0", Offset = "0x99B8F0", VA = "0x18099C4F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x999290", Offset = "0x998690", VA = "0x180999290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string OBIIBIOJGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9B7D80", Offset = "0x9B7180", VA = "0x1809B7D80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA48FA0", Offset = "0xA483A0", VA = "0x180A48FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DFE0", Offset = "0x6E1D3E0", VA = "0x186E1DFE0")]
	public PLCNBEHLHKF(NAEMNNIPJDE KJEBJAPHFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6E1DD30", Offset = "0x6E1D130", VA = "0x186E1DD30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class HKDGLCDKKNL
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string PBGCFEJFPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD20", Offset = "0x8BB120", VA = "0x1808BBD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string OILIJCDIDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8C5080", Offset = "0x8C4480", VA = "0x1808C5080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool IMBFKPONPNC
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8C5070", Offset = "0x8C4470", VA = "0x1808C5070")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8C50E0", Offset = "0x8C44E0", VA = "0x1808C50E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public long OCBGKLKBBEI
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x823B70", Offset = "0x822F70", VA = "0x180823B70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x139C090", Offset = "0x139B490", VA = "0x18139C090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public long MDNCKMELLLL
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x1770340", Offset = "0x176F740", VA = "0x181770340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public HashSet<LLEGIJABBOM> BAPGKNDAHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9857F0", Offset = "0x984BF0", VA = "0x1809857F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8D0170", Offset = "0x8CF570", VA = "0x1808D0170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private string IOAEJLIDMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xB9A340", Offset = "0xB99740", VA = "0x180B9A340")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Dictionary<string, string> OAGCLDCMJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9E5720", Offset = "0x9E4B20", VA = "0x1809E5720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9E3C00", Offset = "0x9E3000", VA = "0x1809E3C00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6E16050", Offset = "0x6E15450", VA = "0x186E16050")]
	public HKDGLCDKKNL(NAEMNNIPJDE KJEBJAPHFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6E15C60", Offset = "0x6E15060", VA = "0x186E15C60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6E15A50", Offset = "0x6E14E50", VA = "0x186E15A50")]
	public string MOJEKFCPFIA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class PNAKJHHHNOB
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string PBGCFEJFPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x81F0B0", Offset = "0x81E4B0", VA = "0x18081F0B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD20", Offset = "0x8BB120", VA = "0x1808BBD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string OILIJCDIDLD
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8C5080", Offset = "0x8C4480", VA = "0x1808C5080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool IMBFKPONPNC
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8C5070", Offset = "0x8C4470", VA = "0x1808C5070")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x8C50E0", Offset = "0x8C44E0", VA = "0x1808C50E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public long OCBGKLKBBEI
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x823B70", Offset = "0x822F70", VA = "0x180823B70")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x139C090", Offset = "0x139B490", VA = "0x18139C090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public long DCCFPMOGPCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x823B60", Offset = "0x822F60", VA = "0x180823B60")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1770340", Offset = "0x176F740", VA = "0x181770340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string OMKFFDEHDFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x9857F0", Offset = "0x984BF0", VA = "0x1809857F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8D0170", Offset = "0x8CF570", VA = "0x1808D0170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string AKPLNHMDHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8C3A00", Offset = "0x8C2E00", VA = "0x1808C3A00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xB9A340", Offset = "0xB99740", VA = "0x180B9A340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string JCNOHAELOOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x9E5720", Offset = "0x9E4B20", VA = "0x1809E5720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x9E3C00", Offset = "0x9E3000", VA = "0x1809E3C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string CJDPIAIOMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA48C70", Offset = "0xA48070", VA = "0x180A48C70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA490F0", Offset = "0xA484F0", VA = "0x180A490F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string OBIIBIOJGCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x997FD0", Offset = "0x9973D0", VA = "0x180997FD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xABA5D0", Offset = "0xAB99D0", VA = "0x180ABA5D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool IGKLKOKJCOO
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xDBD7E0", Offset = "0xDBCBE0", VA = "0x180DBD7E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1056100", Offset = "0x1055500", VA = "0x181056100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool DICDKKCLJBK
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xDBD7D0", Offset = "0xDBCBD0", VA = "0x180DBD7D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xE474C0", Offset = "0xE468C0", VA = "0x180E474C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool DMFPBPAKFME
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xDBD7C0", Offset = "0xDBCBC0", VA = "0x180DBD7C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E620", Offset = "0x6E1DA20", VA = "0x186E1E620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool IFKHIFENMOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xDBD8A0", Offset = "0xDBCCA0", VA = "0x180DBD8A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6E1E630", Offset = "0x6E1DA30", VA = "0x186E1E630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool OPMODLIEJIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xBBC5C0", Offset = "0xBBB9C0", VA = "0x180BBC5C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x2256B90", Offset = "0x2255F90", VA = "0x182256B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public string IOAEJLIDMGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x99C4F0", Offset = "0x99B8F0", VA = "0x18099C4F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x999290", Offset = "0x998690", VA = "0x180999290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Dictionary<string, string> OAGCLDCMJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9B7D80", Offset = "0x9B7180", VA = "0x1809B7D80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA48FA0", Offset = "0xA483A0", VA = "0x180A48FA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6E1EE90", Offset = "0x6E1E290", VA = "0x186E1EE90")]
	public PNAKJHHHNOB(NAEMNNIPJDE KJEBJAPHFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E6F0", Offset = "0x6E1DAF0", VA = "0x186E1E6F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E570", Offset = "0x6E1D970", VA = "0x186E1E570")]
	public void BNMKLGKDBLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1E640", Offset = "0x6E1DA40", VA = "0x186E1E640")]
	public void NCGMBBFDOMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class ACCELOBBKGK : PDAJJNJMPOF
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EF50", Offset = "0x6E0E350", VA = "0x186E0EF50")]
	public ACCELOBBKGK(NAEMNNIPJDE KJEBJAPHFDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class PDAJJNJMPOF : FJAHNMBGMGP, DFGACEGMBHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private bool CFKMOJJJBPJ;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string FAKBLLHEFNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA36AC0", Offset = "0xA35EC0", VA = "0x180A36AC0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xC1F1A0", Offset = "0xC1E5A0", VA = "0x180C1F1A0", Slot = "28")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Color? BCKCMKHFMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6E1CD40", Offset = "0x6E1C140", VA = "0x186E1CD40", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6E1CD80", Offset = "0x6E1C180", VA = "0x186E1CD80", Slot = "30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Color? MFELILFEHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6E1CD60", Offset = "0x6E1C160", VA = "0x186E1CD60", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6E1CD20", Offset = "0x6E1C120", VA = "0x186E1CD20", Slot = "32")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public List<JHIKJLODPJA> MKLGFMNMOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9870C0", Offset = "0x9864C0", VA = "0x1809870C0", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xC5AD70", Offset = "0xC5A170", VA = "0x180C5AD70", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6E1CDA0", Offset = "0x6E1C1A0", VA = "0x186E1CDA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6E1D070", Offset = "0x6E1C470", VA = "0x186E1D070")]
	public PDAJJNJMPOF(NAEMNNIPJDE KJEBJAPHFDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class JHIKJLODPJA
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int LLBGECPOFBF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x81F160", Offset = "0x81E560", VA = "0x18081F160")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x9C1170", Offset = "0x9C0570", VA = "0x1809C1170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string GFBJMDBKLNK
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8C5080", Offset = "0x8C4480", VA = "0x1808C5080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string GDIHNHMABJL
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8BBD60", Offset = "0x8BB160", VA = "0x1808BBD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public ADBKFJAEHJC DIEDEAEMDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xE903A0", Offset = "0xE8F7A0", VA = "0x180E903A0")]
		[CompilerGenerated]
		get
		{
			return default(ADBKFJAEHJC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xE902C0", Offset = "0xE8F6C0", VA = "0x180E902C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public Color? LGMEHFBDLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6E17AB0", Offset = "0x6E16EB0", VA = "0x186E17AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6E17AA0", Offset = "0x6E16EA0", VA = "0x186E17AA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public Color? DHKNLOMNBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2A435C0", Offset = "0x2A429C0", VA = "0x182A435C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2A43560", Offset = "0x2A42960", VA = "0x182A43560")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6E17AD0", Offset = "0x6E16ED0", VA = "0x186E17AD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6E17E00", Offset = "0x6E17200", VA = "0x186E17E00")]
	public JHIKJLODPJA(NAEMNNIPJDE KJEBJAPHFDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface MADDMLHHEDE
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface DFGACEGMBHH
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	List<JHIKJLODPJA> MKLGFMNMOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class OLGJEIPNCHO : PDAJJNJMPOF
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6E0EF50", Offset = "0x6E0E350", VA = "0x186E0EF50")]
	public OLGJEIPNCHO(NAEMNNIPJDE KJEBJAPHFDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class ANEMMGOOBNN
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F980", Offset = "0x6E0ED80", VA = "0x186E0F980")]
	public static MADDMLHHEDE MKOEBADJKHD(string ODBBDNLKCLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public enum NOBEAAGPKFI
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	FULL,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	MODAL,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	SLIDEUP
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class LMMOCDAKNFD
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6E19540", Offset = "0x6E18940", VA = "0x186E19540")]
	public static NAEMNNIPJDE BAMFMKIBHMC(string KNAMJHDBDBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class JNOCPLNEAHM : FJAHNMBGMGP
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public KOCOGNEOHFJ MAIPGAHEJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x1CC9990", Offset = "0x1CC8D90", VA = "0x181CC9990")]
		[CompilerGenerated]
		get
		{
			return default(KOCOGNEOHFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x2A42E70", Offset = "0x2A42270", VA = "0x182A42E70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool AJOGCMJLNPP
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x116C9A0", Offset = "0x116BDA0", VA = "0x18116C9A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x116C9B0", Offset = "0x116BDB0", VA = "0x18116C9B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Color? CAPPDDODLKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6E186A0", Offset = "0x6E17AA0", VA = "0x186E186A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6E18680", Offset = "0x6E17A80", VA = "0x186E18680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6E186C0", Offset = "0x6E17AC0", VA = "0x186E186C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6E18930", Offset = "0x6E17D30", VA = "0x186E18930")]
	public JNOCPLNEAHM(NAEMNNIPJDE KJEBJAPHFDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class FJAHNMBGMGP : MADDMLHHEDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	protected string HILCAKENKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool MPLCKDEPKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool OIHNCPFIOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int HAMBOIPGDBL;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Color? DHKNLOMNBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA7CA00", Offset = "0xA7BE00", VA = "0x180A7CA00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA7CDF0", Offset = "0xA7C1F0", VA = "0x180A7CDF0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Color? LGMEHFBDLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6E14190", Offset = "0x6E13590", VA = "0x186E14190", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6E14150", Offset = "0x6E13550", VA = "0x186E14150", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public string EPBDKBKKKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9E5720", Offset = "0x9E4B20", VA = "0x1809E5720", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9E3C00", Offset = "0x9E3000", VA = "0x1809E3C00", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Color? IJPBEAMKCFO
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8790", Offset = "0x2CA7B90", VA = "0x182CA8790", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2CA8710", Offset = "0x2CA7B10", VA = "0x182CA8710", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Color? DFPBHBCCEPI
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6E141C0", Offset = "0x6E135C0", VA = "0x186E141C0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6E141B0", Offset = "0x6E135B0", VA = "0x186E141B0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public string NAMFFONDNBK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x8F8D80", Offset = "0x8F8180", VA = "0x1808F8D80", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8F8760", Offset = "0x8F7B60", VA = "0x1808F8760", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public string GDLOACHAOFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8F8470", Offset = "0x8F7870", VA = "0x1808F8470", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8CB0F0", Offset = "0x8CA4F0", VA = "0x1808CB0F0", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public Dictionary<string, string> OAGCLDCMJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x9B8210", Offset = "0x9B7610", VA = "0x1809B8210", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xB9E0E0", Offset = "0xB9D4E0", VA = "0x180B9E0E0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public ADBKFJAEHJC JJMEONPANDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xAFB900", Offset = "0xAFAD00", VA = "0x180AFB900", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(ADBKFJAEHJC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xD280D0", Offset = "0xD274D0", VA = "0x180D280D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public string GDIHNHMABJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x8BE5D0", Offset = "0x8BD9D0", VA = "0x1808BE5D0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x822D70", Offset = "0x822170", VA = "0x180822D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public DPGHOAFKPFI HFDMNOMBJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xC77E60", Offset = "0xC77260", VA = "0x180C77E60", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(DPGHOAFKPFI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xC77390", Offset = "0xC76790", VA = "0x180C77390", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int NHIJNDLKKAP
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xEC0AE0", Offset = "0xEBFEE0", VA = "0x180EC0AE0", Slot = "24")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6E14160", Offset = "0x6E13560", VA = "0x186E14160", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6E141E0", Offset = "0x6E135E0", VA = "0x186E141E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6E14850", Offset = "0x6E13C50", VA = "0x186E14850")]
	public FJAHNMBGMGP(NAEMNNIPJDE KJEBJAPHFDB)
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
