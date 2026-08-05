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
public interface MHKCLKOPEIE
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ApplePushNotificationTester : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7B4BE0", Offset = "0x7B3DE0", VA = "0x1807B4BE0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7B4680", Offset = "0x7B3880", VA = "0x1807B4680")]
	public string PrintOutObjectValues(object OEBECPDEKHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7B45D0", Offset = "0x7B37D0", VA = "0x1807B45D0")]
	public ApplePushNotificationTester()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum AMHEINDABEB
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
public enum GCHKMACCHHP
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	IAM_DISPLAY_NOW,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	IAM_DISPLAY_LATER,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	IAM_DISCARD
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void JDEOIPHNAIG(bool HJKLBPKJCPI);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void BJNMIHOLGPM(string FCKLPDKGPKE);
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AppboyBinding : SingletonMonoBehaviour<AppboyBinding>
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static MHKCLKOPEIE NIIJLCNECJD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MHKCLKOPEIE DIMIPJMNGCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7B4640", Offset = "0x7B3840", VA = "0x1807B4640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static AMGADGAAAGL IKEMFFEDNPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void LogCustomEvent(string BOLGOMHLDPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void LogCustomEvent(string BOLGOMHLDPI, Dictionary<string, object> OEENDMDOMOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void LogPurchase(string NGHEBBOOPME, string GCOPFNONDJF, decimal PKCPADAEEFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void LogPurchase(string NGHEBBOOPME, string GCOPFNONDJF, decimal PKCPADAEEFG, int FNNPIHCMBNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void LogPurchase(string NGHEBBOOPME, string GCOPFNONDJF, decimal PKCPADAEEFG, int FNNPIHCMBNJ, Dictionary<string, object> OEENDMDOMOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void ChangeUser(string BKKGCFBPGLD, [Optional] string MKHGFLAKGLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetSdkAuthenticationSignature(string MKHGFLAKGLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetUserFirstName(string CNIIKNLMJDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetUserLastName(string DNJOJJNFNEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetUserEmail(string BHHLKAKLCLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetUserGender(JGNDBELGPOL IEMMIFPFCEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetUserDateOfBirth(int HCHIADJOOFH, int INHFAKMNIPM, int MJBGOMFPJPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetUserCountry(string LIJPMNCPFKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetUserHomeCity(string IAOJHFPJMBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetUserEmailNotificationSubscriptionType(HMFHPKLCGME JJKAGNHNDGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetUserPushNotificationSubscriptionType(HMFHPKLCGME JKGCOPCBANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetUserPhoneNumber(string FDMDICLDGHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetCustomUserAttribute(string GOBGGNLGONA, bool NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetCustomUserAttribute(string GOBGGNLGONA, int NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetCustomUserAttribute(string GOBGGNLGONA, float NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetCustomUserAttribute(string GOBGGNLGONA, string NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetCustomUserAttributeToNow(string GOBGGNLGONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetCustomUserAttributeToSecondsFromEpoch(string GOBGGNLGONA, long IAMEBLMLMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void UnsetCustomUserAttribute(string GOBGGNLGONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void IncrementCustomUserAttribute(string GOBGGNLGONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void IncrementCustomUserAttribute(string GOBGGNLGONA, int EJEGCFJAHNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetCustomUserAttributeArray(string GOBGGNLGONA, List<string> GEHAOEPMDJB, int MKJBDDDPMKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void AddToCustomUserAttributeArray(string GOBGGNLGONA, string NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void RemoveFromCustomUserAttributeArray(string GOBGGNLGONA, string NICEPFIEJED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void setUserFacebookData(string IJAFEGOEPPF, string CNIIKNLMJDG, string DNJOJJNFNEA, string BHHLKAKLCLJ, string GMBPIJIPNFM, string JLEHFGAJGDM, JGNDBELGPOL? IEMMIFPFCEB, int? LEDNEDOLBDK, string MLIPDKGNLEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void setUserTwitterData(int? MBMBJCANBNF, string OJKAAPGLDHL, string IKEFBMMMAJB, string ALPNBPOHMCC, int? MAHDDCMFMML, int? FEMLPBLCLNJ, int? EKJLAENGNJI, string MHJOHBHKBPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetUserLastKnownLocation(double NJECPPKCGKK, double ABGAOEKLKMO, [Optional] double? IEIAKBNAPBK, [Optional] double? FLBKAPOBKLF, [Optional] double? EGIBFNFOIAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void PromptUserForPushPermissions(bool LFPLLKEAEBC, [Optional] JDEOIPHNAIG OKAFBHIAKED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetPushTokenReceivedFromSystemDelegate(BJNMIHOLGPM GKOCKNDJEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void LogInAppMessageClicked(string CMAABJGLDAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void LogInAppMessageImpression(string CMAABJGLDAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void LogInAppMessageButtonClicked(string CMAABJGLDAG, int AKDCMPLFGGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void RequestFeedRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void RequestFeedRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void LogFeedDisplayed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void RequestContentCardsRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void RequestContentCardsRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void LogContentCardClicked(string DPKGADPOPCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void LogContentCardImpression(string DPKGADPOPCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void LogContentCardDismissed(string DPKGADPOPCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void WipeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void EnableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void DisableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0")]
		public static string GetInstallTrackingId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetAttributionData(string EICJFKILDAJ, string MEICONPFOBF, string GPDEPJEENFJ, string ELJALHHFFLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void RequestLocationInitialization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void RequestGeofences(decimal NJECPPKCGKK, decimal ABGAOEKLKMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void RequestImmediateDataFlush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void AddAlias(string MLBCGNILPCJ, string PICCOCLNMEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void ConfigureListener(AMHEINDABEB JFHAHJALGMK, string NIAAMDNKLHG, string LJEALFGEAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void SetInAppMessageDisplayAction(GCHKMACCHHP ONOGKJCPHFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void DisplayNextInAppMessage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void DisplayContentCards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void AddToSubscriptionGroup(string JNIKIHKLGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
		public static void RemoveFromSubscriptionGroup(string JNIKIHKLGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7B4600", Offset = "0x7B3800", VA = "0x1807B4600")]
		public AppboyBinding()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class AMGADGAAAGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Action<MFDOEJOFEAD> POHPJAHNGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Action<MFDOEJOFEAD> COMLJECNKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Action<MFDOEJOFEAD> CNAELJEILFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Action<MFDOEJOFEAD, FIGIGHMEMHH> GEIMLDNGEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public Action<MFDOEJOFEAD, Uri> HPIINDLLDJD;
}
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AppboyBindingTester : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7B4550", Offset = "0x7B3750", VA = "0x1807B4550")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7B3570", Offset = "0x7B2770", VA = "0x1807B3570")]
		private void DHMNHOPBHJO(string JGNAJPMGGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7B3E30", Offset = "0x7B3030", VA = "0x1807B3E30")]
		private void KJKDKGPBEEO(string JGNAJPMGGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7B3930", Offset = "0x7B2B30", VA = "0x1807B3930")]
		private void FECLCEGHJOB(string JGNAJPMGGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7B3820", Offset = "0x7B2A20", VA = "0x1807B3820")]
		private void FDGGEJMFDNL(string JGNAJPMGGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7B4440", Offset = "0x7B3640", VA = "0x1807B4440")]
		private void PDNEDLIOFDA(string JGNAJPMGGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7B36C0", Offset = "0x7B28C0", VA = "0x1807B36C0")]
		private void DPMEKCNPDDM(string JGNAJPMGGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7B42E0", Offset = "0x7B34E0", VA = "0x1807B42E0")]
		private void OFGCFECNJOF(string JGNAJPMGGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7B39A0", Offset = "0x7B2BA0", VA = "0x1807B39A0")]
		private void IGKKPGHLGGD(string JGNAJPMGGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7B3EA0", Offset = "0x7B30A0", VA = "0x1807B3EA0")]
		private void ODKJCPPEBGP(string JGNAJPMGGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7B3650", Offset = "0x7B2850", VA = "0x1807B3650")]
		private void DOLIEKFAFEF(string JGNAJPMGGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7B3BE0", Offset = "0x7B2DE0", VA = "0x1807B3BE0")]
		public static void InAppMessageBeforeDisplayed(MFDOEJOFEAD JGNAJPMGGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7B3D40", Offset = "0x7B2F40", VA = "0x1807B3D40")]
		public static void InAppMessageDismissed(MFDOEJOFEAD JGNAJPMGGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7B3CD0", Offset = "0x7B2ED0", VA = "0x1807B3CD0")]
		public static void InAppMessageClicked(MFDOEJOFEAD JGNAJPMGGNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7B3C50", Offset = "0x7B2E50", VA = "0x1807B3C50")]
		public static void InAppMessageButtonClicked(MFDOEJOFEAD JGNAJPMGGNE, FIGIGHMEMHH CNFPDFANPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7B3DB0", Offset = "0x7B2FB0", VA = "0x1807B3DB0")]
		public static void InAppMessageHTMLClicked(MFDOEJOFEAD JGNAJPMGGNE, Uri GNEFEELIDCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7B45D0", Offset = "0x7B37D0", VA = "0x1807B45D0")]
		public AppboyBindingTester()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class IKLIEFGJKFM
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE10", Offset = "0x7BB010", VA = "0x1807BBE10")]
	public static string ABJMAALEGDI(Dictionary<string, string> FOGKLDABGBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x292EAA0", Offset = "0x292DCA0", VA = "0x18292EAA0")]
	public static string OKAJFAAHECD<T>(List<T> JLCIFHJMGPA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class AOIDLIBCOKP
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7B3420", Offset = "0x7B2620", VA = "0x1807B3420")]
	public static Color? GAPAGEKBAJP(string MFLANHKKLJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7B3130", Offset = "0x7B2330", VA = "0x1807B3130")]
	public static Color GAPAGEKBAJP(int MFLANHKKLJE)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class OPNIFFIHAKC
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7BFAD0", Offset = "0x7BECD0", VA = "0x1807BFAD0")]
	public static object LHGFEOGGFEC(Type EDPFIOENFLM, string NICEPFIEJED, bool LMNOMLKJDAI, object FJPKGOAOIBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DJMFBBKAFCP
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7B8850", Offset = "0x7B7A50", VA = "0x1807B8850")]
	public static Dictionary<string, string> FCJNMIOBHGD(GNPIMMOAPEK FOOMKMLAHDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DefaultMember("Item")]
public class BDFKPILLOGI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public virtual BDFKPILLOGI HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public virtual BDFKPILLOGI HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual string FJJHODHBEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7B5200", Offset = "0x7B4400", VA = "0x1807B5200", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public virtual int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7B45F0", Offset = "0x7B37F0", VA = "0x1807B45F0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public virtual int MHLPDDMJINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7B5500", Offset = "0x7B4700", VA = "0x1807B5500", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7B5350", Offset = "0x7B4550", VA = "0x1807B5350", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual bool LDGIFFLNDBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7B5150", Offset = "0x7B4350", VA = "0x1807B5150", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7B50D0", Offset = "0x7B42D0", VA = "0x1807B50D0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public virtual OCMGCMMHMOF LDNINMGPLJA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7B5480", Offset = "0x7B4680", VA = "0x1807B5480", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public virtual GNPIMMOAPEK DPONKLGBLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7B5250", Offset = "0x7B4450", VA = "0x1807B5250", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "4")]
	public virtual void OEOPOJPHCNL(string LOMCAJAFJDF, BDFKPILLOGI AOMFOMKDCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7B56F0", Offset = "0x7B48F0", VA = "0x1807B56F0", Slot = "10")]
	public virtual void OEOPOJPHCNL(BDFKPILLOGI AOMFOMKDCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FC0", Offset = "0x7B51C0", VA = "0x1807B5FC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7B5410", Offset = "0x7B4610", VA = "0x1807B5410")]
	public static BDFKPILLOGI LOOIAEAGNBK(string HHFLAHOCOCO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7B5390", Offset = "0x7B4590", VA = "0x1807B5390")]
	public static string LOOIAEAGNBK(BDFKPILLOGI IDBHAEBCELK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7B5050", Offset = "0x7B4250", VA = "0x1807B5050")]
	public static bool AIPCENMEJFE(BDFKPILLOGI JPEEHDCLFEK, object HGMCBKHHGFH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7B52D0", Offset = "0x7B44D0", VA = "0x1807B52D0")]
	public static bool KEIKIALHENC(BDFKPILLOGI JPEEHDCLFEK, object HGMCBKHHGFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7B5230", Offset = "0x7B4430", VA = "0x1807B5230", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7B5240", Offset = "0x7B4440", VA = "0x1807B5240", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B5540", Offset = "0x7B4740", VA = "0x1807B5540")]
	internal static string ODGGPKAHDNP(string MLOLKGICEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7B5750", Offset = "0x7B4950", VA = "0x1807B5750")]
	public static BDFKPILLOGI POBPJJLNAKC(string ICGOBCLPMGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public BDFKPILLOGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DefaultMember("Item")]
public class OCMGCMMHMOF : BDFKPILLOGI, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class BLOCIPAFFJH : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public OCMGCMMHMOF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<BDFKPILLOGI>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7B7470", Offset = "0x7B6670", VA = "0x1807B7470")]
		[DebuggerHidden]
		public BLOCIPAFFJH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7B73E0", Offset = "0x7B65E0", VA = "0x1807B73E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7B71E0", Offset = "0x7B63E0", VA = "0x1807B71E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7B7190", Offset = "0x7B6390", VA = "0x1807B7190")]
		private void IDEOPKLEDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7B7390", Offset = "0x7B6590", VA = "0x1807B7390", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<BDFKPILLOGI> LDKJGPLFKLP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override BDFKPILLOGI HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7BF640", Offset = "0x7BE840", VA = "0x1807BF640", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override BDFKPILLOGI HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5C0", Offset = "0x7BE7C0", VA = "0x1807BF5C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7BF790", Offset = "0x7BE990", VA = "0x1807BF790", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7D0", Offset = "0x7BE9D0", VA = "0x1807BF7D0", Slot = "4")]
	public override void OEOPOJPHCNL(string LOMCAJAFJDF, BDFKPILLOGI AOMFOMKDCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF710", Offset = "0x7BE910", VA = "0x1807BF710", Slot = "17")]
	[IteratorStateMachine(typeof(BLOCIPAFFJH))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7BF880", Offset = "0x7BEA80", VA = "0x1807BF880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7BFA40", Offset = "0x7BEC40", VA = "0x1807BFA40")]
	public OCMGCMMHMOF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DefaultMember("Item")]
public class GNPIMMOAPEK : BDFKPILLOGI, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class FDLFAMOICLJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public GNPIMMOAPEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private Dictionary<string, BDFKPILLOGI>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7B7470", Offset = "0x7B6670", VA = "0x1807B7470")]
		[DebuggerHidden]
		public FDLFAMOICLJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7B9860", Offset = "0x7B8A60", VA = "0x1807B9860", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7B95F0", Offset = "0x7B87F0", VA = "0x1807B95F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7B95A0", Offset = "0x7B87A0", VA = "0x1807B95A0")]
		private void IDEOPKLEDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7B9810", Offset = "0x7B8A10", VA = "0x1807B9810", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Dictionary<string, BDFKPILLOGI> NEHNKBMHNME;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override BDFKPILLOGI HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7BA150", Offset = "0x7B9350", VA = "0x1807BA150", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override BDFKPILLOGI HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7BA240", Offset = "0x7B9440", VA = "0x1807BA240", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7BA360", Offset = "0x7B9560", VA = "0x1807BA360", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7BA3B0", Offset = "0x7B95B0", VA = "0x1807BA3B0", Slot = "4")]
	public override void OEOPOJPHCNL(string LOMCAJAFJDF, BDFKPILLOGI AOMFOMKDCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7BA2E0", Offset = "0x7B94E0", VA = "0x1807BA2E0", Slot = "17")]
	[IteratorStateMachine(typeof(FDLFAMOICLJ))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7BA4C0", Offset = "0x7B96C0", VA = "0x1807BA4C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7BA8C0", Offset = "0x7B9AC0", VA = "0x1807BA8C0")]
	public GNPIMMOAPEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CLICJEMBLOO : BDFKPILLOGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private string LFJJEACLPMJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public override string FJJHODHBEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7B6300", Offset = "0x7B5500", VA = "0x1807B6300", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	public CLICJEMBLOO(string JANEOFHCIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7B87D0", Offset = "0x7B79D0", VA = "0x1807B87D0")]
	public CLICJEMBLOO(bool JANEOFHCIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7B8810", Offset = "0x7B7A10", VA = "0x1807B8810")]
	public CLICJEMBLOO(int JANEOFHCIMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7B8740", Offset = "0x7B7940", VA = "0x1807B8740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
internal class BPAAFEFCCKP : BDFKPILLOGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private BDFKPILLOGI KNFIKLLLLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private string GOGGJDKJCLK;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public override BDFKPILLOGI HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B7760", Offset = "0x7B6960", VA = "0x1807B7760", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public override BDFKPILLOGI HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7B76D0", Offset = "0x7B68D0", VA = "0x1807B76D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override int MHLPDDMJINA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7B7A20", Offset = "0x7B6C20", VA = "0x1807B7A20", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7B7890", Offset = "0x7B6A90", VA = "0x1807B7890", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override bool LDGIFFLNDBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B75F0", Offset = "0x7B67F0", VA = "0x1807B75F0", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B7510", Offset = "0x7B6710", VA = "0x1807B7510", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override OCMGCMMHMOF LDNINMGPLJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B7970", Offset = "0x7B6B70", VA = "0x1807B7970", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override GNPIMMOAPEK DPONKLGBLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B77E0", Offset = "0x7B69E0", VA = "0x1807B77E0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7B7D40", Offset = "0x7B6F40", VA = "0x1807B7D40")]
	public BPAAFEFCCKP(BDFKPILLOGI LLKIKIMGLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7B7CF0", Offset = "0x7B6EF0", VA = "0x1807B7CF0")]
	public BPAAFEFCCKP(BDFKPILLOGI LLKIKIMGLPD, string LOMCAJAFJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7B74A0", Offset = "0x7B66A0", VA = "0x1807B74A0")]
	private void BHMONLIGLCO(BDFKPILLOGI DOBPOCKIFPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7B7AF0", Offset = "0x7B6CF0", VA = "0x1807B7AF0", Slot = "10")]
	public override void OEOPOJPHCNL(BDFKPILLOGI AOMFOMKDCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7B7BD0", Offset = "0x7B6DD0", VA = "0x1807B7BD0", Slot = "4")]
	public override void OEOPOJPHCNL(string LOMCAJAFJDF, BDFKPILLOGI AOMFOMKDCLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7B76C0", Offset = "0x7B68C0", VA = "0x1807B76C0", Slot = "0")]
	public override bool Equals(object JFJMICPDNDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7B5240", Offset = "0x7B4440", VA = "0x1807B5240", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7B7CC0", Offset = "0x7B6EC0", VA = "0x1807B7CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class AAOOBCPDFOI
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7B3120", Offset = "0x7B2320", VA = "0x1807B3120")]
	public static BDFKPILLOGI POBPJJLNAKC(string ICGOBCLPMGO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum HMFHPKLCGME
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	OPTED_IN,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	SUBSCRIBED,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	UNSUBSCRIBED
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PPGPLDJKJFB
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public JDELBNMLGGJ JMGBBEPPGPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B6300", Offset = "0x7B5500", VA = "0x1807B6300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int JCEGEFGBHIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C1090", Offset = "0x7C0290", VA = "0x1807C1090")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7C2820", Offset = "0x7C1A20", VA = "0x1807C2820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string PEGCHDIDGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7B84D0", Offset = "0x7B76D0", VA = "0x1807B84D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int LJEJJAMDKHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7B9980", Offset = "0x7B8B80", VA = "0x1807B9980")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B9970", Offset = "0x7B8B70", VA = "0x1807B9970")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IDictionary<string, object> JGGIFPLMAKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7BC990", Offset = "0x7BBB90", VA = "0x1807BC990")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7C2EE0", Offset = "0x7C20E0", VA = "0x1807C2EE0")]
	public PPGPLDJKJFB(GNPIMMOAPEK FOOMKMLAHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7C20F0", Offset = "0x7C12F0", VA = "0x1807C20F0")]
	private object IFDCIFNDFFH(BDFKPILLOGI CLKPBALPCKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7C2830", Offset = "0x7C1A30", VA = "0x1807C2830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JDELBNMLGGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IList<string> IILMPOCHGKF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7B6300", Offset = "0x7B5500", VA = "0x1807B6300")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string EIPPEGMKNNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7B6290", Offset = "0x7B5490", VA = "0x1807B6290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public string BDJCBICDNDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7B84D0", Offset = "0x7B76D0", VA = "0x1807B84D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public string INLKHIHIOHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9A0", Offset = "0x7BBBA0", VA = "0x1807BC9A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public string OGFHOKHFMJL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7BC990", Offset = "0x7BBB90", VA = "0x1807BC990")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7BCDF0", Offset = "0x7BBFF0", VA = "0x1807BCDF0")]
	public JDELBNMLGGJ(GNPIMMOAPEK FOOMKMLAHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7BC9B0", Offset = "0x7BBBB0", VA = "0x1807BC9B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum GKBEDNGNKFA
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
public enum BBPHIHOILDP
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	NEWS_FEED,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	URI,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	NONE
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum OGOAIPOLDIL
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	AUTO_DISMISS,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	SWIPE
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class HCBHFHEIDDH
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public List<BHJHOCMIDHM> MBOKFPOOKMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B6300", Offset = "0x7B5500", VA = "0x1807B6300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool KABGKBJPNJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7BA960", Offset = "0x7B9B60", VA = "0x1807BA960")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7BABC0", Offset = "0x7B9DC0", VA = "0x1807BABC0")]
	public HCBHFHEIDDH(string JGNAJPMGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7BA970", Offset = "0x7B9B70", VA = "0x1807BA970")]
	private static BHJHOCMIDHM POAKMLDINJG(GNPIMMOAPEK FOOMKMLAHDI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum JGNDBELGPOL
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
public class PNFGGNFLAFO
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string HAJCIBCANHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B6300", Offset = "0x7B5500", VA = "0x1807B6300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string KBIANLCNBEA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7B6290", Offset = "0x7B5490", VA = "0x1807B6290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string BCANGOIDFEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7B84D0", Offset = "0x7B76D0", VA = "0x1807B84D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Dictionary<string, string> DKNENAFEMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7BC9A0", Offset = "0x7BBBA0", VA = "0x1807BC9A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int OAKDNOCICJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7BFCF0", Offset = "0x7BEEF0", VA = "0x1807BFCF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7BFEF0", Offset = "0x7BF0F0", VA = "0x1807BFEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public long FFJFLFJMGCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7BFEE0", Offset = "0x7BF0E0", VA = "0x1807BFEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string CDJFEMJJPJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1A0", Offset = "0x7BD3A0", VA = "0x1807BE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7B62F0", Offset = "0x7B54F0", VA = "0x1807B62F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7C03D0", Offset = "0x7BF5D0", VA = "0x1807C03D0")]
	public PNFGGNFLAFO(string JGNAJPMGGNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7C00E0", Offset = "0x7BF2E0", VA = "0x1807C00E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB50", Offset = "0x7BED50", VA = "0x1807BFB50")]
	private string FEJOPIHPFKK(GNPIMMOAPEK FOOMKMLAHDI, string GOBGGNLGONA, string FJPKGOAOIBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7BFD00", Offset = "0x7BEF00", VA = "0x1807BFD00")]
	private int IHPDJDKDAJC(GNPIMMOAPEK FOOMKMLAHDI, string GOBGGNLGONA, int FJPKGOAOIBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF00", Offset = "0x7BF100", VA = "0x1807BFF00")]
	private long LOCFAKEOFMG(GNPIMMOAPEK FOOMKMLAHDI, string GOBGGNLGONA, long FJPKGOAOIBJ)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum GEBPKEOHIFP
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	TOP,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	BOTTOM
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MFDOEJOFEAD
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface DEDCMIKJPKP
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	List<FIGIGHMEMHH> AKDKBBALCGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class PODLIIPODCK : MFDOEJOFEAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected string ONPHFDHGPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int HFJAOGAAAAC;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Color? HLFJCKGMCPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7C0FF0", Offset = "0x7C01F0", VA = "0x1807C0FF0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7C0F90", Offset = "0x7C0190", VA = "0x1807C0F90", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Color? KOGKEJNKGPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7C0EF0", Offset = "0x7C00F0", VA = "0x1807C0EF0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7C0F30", Offset = "0x7C0130", VA = "0x1807C0F30", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string EEKHGCADNKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B6020", Offset = "0x7B5220", VA = "0x1807B6020", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7B6270", Offset = "0x7B5470", VA = "0x1807B6270", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Color? LEDFGBOCKHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x7C1070", Offset = "0x7C0270", VA = "0x1807C1070", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7C0F40", Offset = "0x7C0140", VA = "0x1807C0F40", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Color? CCJHBBPPHDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7C0ED0", Offset = "0x7C00D0", VA = "0x1807C0ED0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7C0FA0", Offset = "0x7C01A0", VA = "0x1807C0FA0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string MOHONEFNLPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7C02A0", VA = "0x1807C10A0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7C1050", Offset = "0x7C0250", VA = "0x1807C1050", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string EBIHFAEPEMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x7C0FB0", Offset = "0x7C01B0", VA = "0x1807C0FB0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C0F80", Offset = "0x7C0180", VA = "0x1807C0F80", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Dictionary<string, string> DKNENAFEMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7C0F60", Offset = "0x7C0160", VA = "0x1807C0F60", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x7C0FD0", Offset = "0x7C01D0", VA = "0x1807C0FD0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public BBPHIHOILDP CNFHKEDLFPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7C0FC0", Offset = "0x7C01C0", VA = "0x1807C0FC0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(BBPHIHOILDP);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7C0F50", Offset = "0x7C0150", VA = "0x1807C0F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string JDMAPHJAJFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7C1040", Offset = "0x7C0240", VA = "0x1807C1040", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7C0F10", Offset = "0x7C0110", VA = "0x1807C0F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public OGOAIPOLDIL JAFJIJGIKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C1060", Offset = "0x7C0260", VA = "0x1807C1060", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(OGOAIPOLDIL);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C0F70", Offset = "0x7C0170", VA = "0x1807C0F70", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int MJCGHPCGJDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C1090", Offset = "0x7C0290", VA = "0x1807C1090", Slot = "24")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C1010", Offset = "0x7C0210", VA = "0x1807C1010", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x7C10B0", Offset = "0x7C02B0", VA = "0x1807C10B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x7C1660", Offset = "0x7C0860", VA = "0x1807C1660")]
	public PODLIIPODCK(GNPIMMOAPEK FOOMKMLAHDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class FIGIGHMEMHH
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int IFCILBKHNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7B3110", Offset = "0x7B2310", VA = "0x1807B3110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B9910", Offset = "0x7B8B10", VA = "0x1807B9910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string MAACDHOCNMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7B6290", Offset = "0x7B5490", VA = "0x1807B6290")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string JDMAPHJAJFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B84D0", Offset = "0x7B76D0", VA = "0x1807B84D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public BBPHIHOILDP MCNFLHHKBNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7B9980", Offset = "0x7B8B80", VA = "0x1807B9980")]
		[CompilerGenerated]
		get
		{
			return default(BBPHIHOILDP);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7B9970", Offset = "0x7B8B70", VA = "0x1807B9970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public Color? KOGKEJNKGPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7B98F0", Offset = "0x7B8AF0", VA = "0x1807B98F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7B9920", Offset = "0x7B8B20", VA = "0x1807B9920")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Color? HLFJCKGMCPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7B9940", Offset = "0x7B8B40", VA = "0x1807B9940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7B9930", Offset = "0x7B8B30", VA = "0x1807B9930")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7B9990", Offset = "0x7B8B90", VA = "0x1807B9990", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7B9C70", Offset = "0x7B8E70", VA = "0x1807B9C70")]
	public FIGIGHMEMHH(GNPIMMOAPEK FOOMKMLAHDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class EALFHMJBANK
{
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7D60", VA = "0x1807B8B60")]
	public static GNPIMMOAPEK KLEAAJJODGL(string NGJBKGPCPPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class MJNHMOPJILJ
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7BF310", Offset = "0x7BE510", VA = "0x1807BF310")]
	public static MFDOEJOFEAD NNPMNICBNOJ(string CMAABJGLDAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PPJEJIPJJEO : JBECOPEEMBN
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7BA950", Offset = "0x7B9B50", VA = "0x1807BA950")]
	public PPJEJIPJJEO(GNPIMMOAPEK FOOMKMLAHDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class JBECOPEEMBN : PODLIIPODCK, DEDCMIKJPKP
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string OOGCOMJHAJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0A0", Offset = "0x7BB2A0", VA = "0x1807BC0A0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7BC080", Offset = "0x7BB280", VA = "0x1807BC080", Slot = "28")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Color? IMAGCLENFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7BB130", Offset = "0x7BA330", VA = "0x1807BB130", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7BB150", Offset = "0x7BA350", VA = "0x1807BB150", Slot = "30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public Color? GAGFLEFOHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0D0", Offset = "0x7BB2D0", VA = "0x1807BC0D0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0B0", Offset = "0x7BB2B0", VA = "0x1807BC0B0", Slot = "32")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public List<FIGIGHMEMHH> AKDKBBALCGM
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC070", Offset = "0x7BB270", VA = "0x1807BC070", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7BC0F0", Offset = "0x7BB2F0", VA = "0x1807BC0F0", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7BC110", Offset = "0x7BB310", VA = "0x1807BC110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC390", Offset = "0x7BB590", VA = "0x1807BC390")]
	public JBECOPEEMBN(GNPIMMOAPEK FOOMKMLAHDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class GOHNOOGPBPG : JBECOPEEMBN
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7BA950", Offset = "0x7B9B50", VA = "0x1807BA950")]
	public GOHNOOGPBPG(GNPIMMOAPEK FOOMKMLAHDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class HOLFIAKKKLA : PODLIIPODCK
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public GEBPKEOHIFP HINLMLIAPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7BB120", Offset = "0x7BA320", VA = "0x1807BB120")]
		[CompilerGenerated]
		get
		{
			return default(GEBPKEOHIFP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7BB110", Offset = "0x7BA310", VA = "0x1807BB110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool JDDONJHBBDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7BB100", Offset = "0x7BA300", VA = "0x1807BB100")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7BB170", Offset = "0x7BA370", VA = "0x1807BB170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Color? HEPJCMFCFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7BB130", Offset = "0x7BA330", VA = "0x1807BB130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7BB150", Offset = "0x7BA350", VA = "0x1807BB150")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7BB180", Offset = "0x7BA380", VA = "0x1807BB180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7BB3C0", Offset = "0x7BA5C0", VA = "0x1807BB3C0")]
	public HOLFIAKKKLA(GNPIMMOAPEK FOOMKMLAHDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum ILJOJJLAAMN
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	FULL,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	MODAL,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SLIDEUP
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class JEGPIPJKAKA : BHJHOCMIDHM
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string GHENAMOBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D00", Offset = "0x7B7F00", VA = "0x1807B8D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x7B8C90", Offset = "0x7B7E90", VA = "0x1807B8C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string DIKFFJPPLLF
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D20", Offset = "0x7B7F20", VA = "0x1807B8D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CF0", Offset = "0x7B7EF0", VA = "0x1807B8CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string OLNKBMJMNLD
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CB0", Offset = "0x7B7EB0", VA = "0x1807B8CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CA0", Offset = "0x7B7EA0", VA = "0x1807B8CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7BD670", Offset = "0x7BC870", VA = "0x1807BD670")]
	public JEGPIPJKAKA(GNPIMMOAPEK FOOMKMLAHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7BD4B0", Offset = "0x7BC6B0", VA = "0x1807BD4B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class IFHOBPMGAPP : BHJHOCMIDHM
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public string GHENAMOBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D00", Offset = "0x7B7F00", VA = "0x1807B8D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7B8C90", Offset = "0x7B7E90", VA = "0x1807B8C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string KBIANLCNBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D20", Offset = "0x7B7F20", VA = "0x1807B8D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CF0", Offset = "0x7B7EF0", VA = "0x1807B8CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string AEEKODOKDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CB0", Offset = "0x7B7EB0", VA = "0x1807B8CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CA0", Offset = "0x7B7EA0", VA = "0x1807B8CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string DIKFFJPPLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D10", Offset = "0x7B7F10", VA = "0x1807B8D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CE0", Offset = "0x7B7EE0", VA = "0x1807B8CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string OLNKBMJMNLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CC0", Offset = "0x7B7EC0", VA = "0x1807B8CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CD0", Offset = "0x7B7ED0", VA = "0x1807B8CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8C0", Offset = "0x7BAAC0", VA = "0x1807BB8C0")]
	public IFHOBPMGAPP(GNPIMMOAPEK FOOMKMLAHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x7BB670", Offset = "0x7BA870", VA = "0x1807BB670", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class BHJHOCMIDHM
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string NIFJDBMHLOH
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7B6300", Offset = "0x7B5500", VA = "0x1807B6300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string DIOCHMJOOOE
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7B6290", Offset = "0x7B5490", VA = "0x1807B6290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool NNJNGBFNNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7B62E0", Offset = "0x7B54E0", VA = "0x1807B62E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7B6000", Offset = "0x7B5200", VA = "0x1807B6000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public long EDBNDIOAJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7B62C0", Offset = "0x7B54C0", VA = "0x1807B62C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public long MFNIOMJLAKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7B62B0", Offset = "0x7B54B0", VA = "0x1807B62B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public HashSet<GKBEDNGNKFA> PGNEDBJKHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7B6310", Offset = "0x7B5510", VA = "0x1807B6310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private string JKCJBPJFJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7B62F0", Offset = "0x7B54F0", VA = "0x1807B62F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public Dictionary<string, string> DKNENAFEMNG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7B6020", Offset = "0x7B5220", VA = "0x1807B6020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7B6270", Offset = "0x7B5470", VA = "0x1807B6270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7B66B0", Offset = "0x7B58B0", VA = "0x1807B66B0")]
	public BHJHOCMIDHM(GNPIMMOAPEK FOOMKMLAHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7B6330", Offset = "0x7B5530", VA = "0x1807B6330", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7B6030", Offset = "0x7B5230", VA = "0x1807B6030")]
	public string FINIPENGNDP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class EKBDDHFCOIN : BHJHOCMIDHM
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string AEEKODOKDJA
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D00", Offset = "0x7B7F00", VA = "0x1807B8D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7B8C90", Offset = "0x7B7E90", VA = "0x1807B8C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string GHENAMOBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D20", Offset = "0x7B7F20", VA = "0x1807B8D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CF0", Offset = "0x7B7EF0", VA = "0x1807B8CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public string KBIANLCNBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CB0", Offset = "0x7B7EB0", VA = "0x1807B8CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CA0", Offset = "0x7B7EA0", VA = "0x1807B8CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public string DIKFFJPPLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D10", Offset = "0x7B7F10", VA = "0x1807B8D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CE0", Offset = "0x7B7EE0", VA = "0x1807B8CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string OLNKBMJMNLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CC0", Offset = "0x7B7EC0", VA = "0x1807B8CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CD0", Offset = "0x7B7ED0", VA = "0x1807B8CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7B8F80", Offset = "0x7B8180", VA = "0x1807B8F80")]
	public EKBDDHFCOIN(GNPIMMOAPEK FOOMKMLAHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7B8D30", Offset = "0x7B7F30", VA = "0x1807B8D30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class LGOBLPBDPJD
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public string NIFJDBMHLOH
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7B6300", Offset = "0x7B5500", VA = "0x1807B6300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string DIOCHMJOOOE
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7B6290", Offset = "0x7B5490", VA = "0x1807B6290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool NNJNGBFNNJB
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7B62E0", Offset = "0x7B54E0", VA = "0x1807B62E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7B6000", Offset = "0x7B5200", VA = "0x1807B6000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public long EDBNDIOAJLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7B62C0", Offset = "0x7B54C0", VA = "0x1807B62C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public long KLHINDJNBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7B62B0", Offset = "0x7B54B0", VA = "0x1807B62B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public string GHENAMOBJHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7B6310", Offset = "0x7B5510", VA = "0x1807B6310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string KBIANLCNBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1A0", Offset = "0x7BD3A0", VA = "0x1807BE1A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7B62F0", Offset = "0x7B54F0", VA = "0x1807B62F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public string AEEKODOKDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7B6020", Offset = "0x7B5220", VA = "0x1807B6020")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7B6270", Offset = "0x7B5470", VA = "0x1807B6270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public string DIKFFJPPLLF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D00", Offset = "0x7B7F00", VA = "0x1807B8D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7B8C90", Offset = "0x7B7E90", VA = "0x1807B8C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public string OLNKBMJMNLD
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D20", Offset = "0x7B7F20", VA = "0x1807B8D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CF0", Offset = "0x7B7EF0", VA = "0x1807B8CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public bool EOBKHHEBDGB
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7BE190", Offset = "0x7BD390", VA = "0x1807BE190")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x7BE210", Offset = "0x7BD410", VA = "0x1807BE210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool LEJGMFELCLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2C0", Offset = "0x7BD4C0", VA = "0x1807BE2C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1C0", Offset = "0x7BD3C0", VA = "0x1807BE1C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool MEINBJJLHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1B0", Offset = "0x7BD3B0", VA = "0x1807BE1B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7BE180", Offset = "0x7BD380", VA = "0x1807BE180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool GKJFMCBGEJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7BE200", Offset = "0x7BD400", VA = "0x1807BE200")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1F0", Offset = "0x7BD3F0", VA = "0x1807BE1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool MDMONDBBANO
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1E0", Offset = "0x7BD3E0", VA = "0x1807BE1E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1D0", Offset = "0x7BD3D0", VA = "0x1807BE1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public string JKCJBPJFJHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D10", Offset = "0x7B7F10", VA = "0x1807B8D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CE0", Offset = "0x7B7EE0", VA = "0x1807B8CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public Dictionary<string, string> DKNENAFEMNG
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CC0", Offset = "0x7B7EC0", VA = "0x1807B8CC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CD0", Offset = "0x7B7ED0", VA = "0x1807B8CD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7BEA20", Offset = "0x7BDC20", VA = "0x1807BEA20")]
	public LGOBLPBDPJD(GNPIMMOAPEK FOOMKMLAHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7BE370", Offset = "0x7BD570", VA = "0x1807BE370", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7BE2D0", Offset = "0x7BD4D0", VA = "0x1807BE2D0")]
	public void NNHEEIANBKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7BE220", Offset = "0x7BD420", VA = "0x1807BE220")]
	public void LNOCDPFHLDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class JIELGFOLABH : BHJHOCMIDHM
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public string KBIANLCNBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D00", Offset = "0x7B7F00", VA = "0x1807B8D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7B8C90", Offset = "0x7B7E90", VA = "0x1807B8C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public string AEEKODOKDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D20", Offset = "0x7B7F20", VA = "0x1807B8D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CF0", Offset = "0x7B7EF0", VA = "0x1807B8CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public string DIKFFJPPLLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CB0", Offset = "0x7B7EB0", VA = "0x1807B8CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CA0", Offset = "0x7B7EA0", VA = "0x1807B8CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string OLNKBMJMNLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D10", Offset = "0x7B7F10", VA = "0x1807B8D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7B8CE0", Offset = "0x7B7EE0", VA = "0x1807B8CE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7BDC70", Offset = "0x7BCE70", VA = "0x1807BDC70")]
	public JIELGFOLABH(GNPIMMOAPEK FOOMKMLAHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7BDA60", Offset = "0x7BCC60", VA = "0x1807BDA60", Slot = "3")]
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
		private JDEOIPHNAIG AOJGBEDNNFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private BJNMIHOLGPM IJFGKJHAFBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public AMGADGAAAGL iamListener;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7B6290", Offset = "0x7B5490", VA = "0x1807B6290")]
		public void setPushPromptResponseReceivedDelegate(JDEOIPHNAIG OKAFBHIAKED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7B84D0", Offset = "0x7B76D0", VA = "0x1807B84D0")]
		public void setPushTokenReceivedFromSystemDelegate(BJNMIHOLGPM OKAFBHIAKED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7B8440", Offset = "0x7B7640", VA = "0x1807B8440")]
		public void onPushPromptResponseReceived(string IBADPMPBCFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7B84B0", Offset = "0x7B76B0", VA = "0x1807B84B0")]
		public void onPushTokenReceivedFromSystem(string FCKLPDKGPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7B7D90", Offset = "0x7B6F90", VA = "0x1807B7D90")]
		public void beforeInAppMessageDisplayed(string CKFNCKOLAMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7B8160", Offset = "0x7B7360", VA = "0x1807B8160")]
		public void onInAppMessageDismissed(string CKFNCKOLAMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7B8100", Offset = "0x7B7300", VA = "0x1807B8100")]
		public void onInAppMessageClicked(string CKFNCKOLAMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7B7DF0", Offset = "0x7B6FF0", VA = "0x1807B7DF0")]
		public void onInAppMessageButtonClicked(string NLPDCIHJBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7B81C0", Offset = "0x7B73C0", VA = "0x1807B81C0")]
		public void onInAppMessageHTMLClicked(string NLPDCIHJBGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7B45D0", Offset = "0x7B37D0", VA = "0x1807B45D0")]
		public BrazeInternalComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class BrazeInternalGameObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static GameObject JHPIMPOFIFB;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private static GameObject KMGHIJMKCHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7B84E0", Offset = "0x7B76E0", VA = "0x1807B84E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7B8680", Offset = "0x7B7880", VA = "0x1807B8680")]
		public static void setPushPromptResponseReceivedDelegate(JDEOIPHNAIG OKAFBHIAKED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7B86E0", Offset = "0x7B78E0", VA = "0x1807B86E0")]
		public static void setPushTokenReceivedFromSystemDelegate(BJNMIHOLGPM OKAFBHIAKED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7B8620", Offset = "0x7B7820", VA = "0x1807B8620")]
		public static void setInAppMessageListener(AMGADGAAAGL IKEMFFEDNPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7B45D0", Offset = "0x7B37D0", VA = "0x1807B45D0")]
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
