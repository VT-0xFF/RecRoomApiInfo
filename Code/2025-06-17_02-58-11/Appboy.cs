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
public interface JHNJKKBCHOH
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ApplePushNotificationTester : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA0CAB0", Offset = "0xA0B4B0", VA = "0x180A0CAB0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xA0C550", Offset = "0xA0AF50", VA = "0x180A0C550")]
	public string PrintOutObjectValues(object FOILEJGNBKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
	public ApplePushNotificationTester()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MCIKCCHFIDC
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
public enum DKJHACNGGDJ
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	IAM_DISPLAY_NOW,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	IAM_DISPLAY_LATER,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	IAM_DISCARD
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void JHKPHJHBHLK(bool EDJOJLNECFF);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void KEMFNLANAFI(string BECBHDDLOHA);
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AppboyBinding : SingletonMonoBehaviour<AppboyBinding>
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static JHNJKKBCHOH PBIFOBBKKME;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static JHNJKKBCHOH EBIBNOJBDAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA0C510", Offset = "0xA0AF10", VA = "0x180A0C510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CLDKBIEMKLH PFCKOIMEHDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void LogCustomEvent(string NDNNFECKMEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void LogCustomEvent(string NDNNFECKMEJ, Dictionary<string, object> COGBEMJPNIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void LogPurchase(string BELFBKOPEOL, string FMHMFDIAHBA, decimal DPLKFDPKGLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void LogPurchase(string BELFBKOPEOL, string FMHMFDIAHBA, decimal DPLKFDPKGLG, int IHEMAOAJCIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void LogPurchase(string BELFBKOPEOL, string FMHMFDIAHBA, decimal DPLKFDPKGLG, int IHEMAOAJCIP, Dictionary<string, object> COGBEMJPNIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void ChangeUser(string AIJBEMKBLNM, [Optional] string AHOJCCPELCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetSdkAuthenticationSignature(string AHOJCCPELCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetUserFirstName(string PBNKDHFLHEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetUserLastName(string DCIPLBFNIJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetUserEmail(string OJCFJPICEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetUserGender(DJKKKAHCFID PHPDDGMAHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetUserDateOfBirth(int LCFIOGLJFCK, int HPPJPDJPKFE, int EHMFOAKACFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetUserCountry(string KJNFGKIGLKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetUserHomeCity(string MPOODINNNBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetUserEmailNotificationSubscriptionType(LNAHCNFLEDM FHOKMPHECFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetUserPushNotificationSubscriptionType(LNAHCNFLEDM HDFIMPMLLDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetUserPhoneNumber(string HIAGOPKLAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetCustomUserAttribute(string KJNEHANBOBO, bool PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetCustomUserAttribute(string KJNEHANBOBO, int PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetCustomUserAttribute(string KJNEHANBOBO, float PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetCustomUserAttribute(string KJNEHANBOBO, string PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetCustomUserAttributeToNow(string KJNEHANBOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetCustomUserAttributeToSecondsFromEpoch(string KJNEHANBOBO, long BOKKEMELMPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void UnsetCustomUserAttribute(string KJNEHANBOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void IncrementCustomUserAttribute(string KJNEHANBOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void IncrementCustomUserAttribute(string KJNEHANBOBO, int PHCBFJGJEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetCustomUserAttributeArray(string KJNEHANBOBO, List<string> KLDOGKPLNJA, int OPKPFANIILK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void AddToCustomUserAttributeArray(string KJNEHANBOBO, string PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void RemoveFromCustomUserAttributeArray(string KJNEHANBOBO, string PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void setUserFacebookData(string KBNOGJJOIIA, string PBNKDHFLHEM, string DCIPLBFNIJA, string OJCFJPICEPO, string PFGFCLGDJGJ, string CKOPHOIJLJO, DJKKKAHCFID? PHPDDGMAHIG, int? NPKGLHKBALF, string MBDMOOFHJAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void setUserTwitterData(int? CICBJPMJKIF, string CEMICFAIBNH, string GBCFHNGPBLM, string NLIGMLKPGCH, int? MOCKJAKHDCI, int? KJCKJIJLIJB, int? DAOBABMLEBO, string BGJNAKPPIOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetUserLastKnownLocation(double BFEFKFFIJPJ, double OLDDJMPKCKM, [Optional] double? FIIJAEIPNNF, [Optional] double? OOGCADIBHJG, [Optional] double? FMLCJFLJAIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void PromptUserForPushPermissions(bool FAKDJLFNMGH, [Optional] JHKPHJHBHLK HACEDNJLACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetPushTokenReceivedFromSystemDelegate(KEMFNLANAFI LGEPBPBKJNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void LogInAppMessageClicked(string PJJLGHJNKLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void LogInAppMessageImpression(string PJJLGHJNKLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void LogInAppMessageButtonClicked(string PJJLGHJNKLE, int OLOGAEMNDHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void RequestFeedRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void RequestFeedRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void LogFeedDisplayed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void RequestContentCardsRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void RequestContentCardsRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void LogContentCardClicked(string GFKMNKMFBDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void LogContentCardImpression(string GFKMNKMFBDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void LogContentCardDismissed(string GFKMNKMFBDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void WipeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void EnableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void DisableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0")]
		public static string GetInstallTrackingId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetAttributionData(string CENGFMKGLII, string EDFHODAFILG, string GHMNIIBPMAP, string CNAGJKPEDOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void RequestLocationInitialization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void RequestGeofences(decimal BFEFKFFIJPJ, decimal OLDDJMPKCKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void RequestImmediateDataFlush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void AddAlias(string JNCOCIFNBCD, string DCBDCJILPIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void ConfigureListener(MCIKCCHFIDC HHPGEEEEHGL, string DECLAOHPPIC, string PAANMNLCKIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void SetInAppMessageDisplayAction(DKJHACNGGDJ PPDIAPNGNGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void DisplayNextInAppMessage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void DisplayContentCards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void AddToSubscriptionGroup(string KHNIMGKFPOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		public static void RemoveFromSubscriptionGroup(string KHNIMGKFPOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4D0", Offset = "0xA0AED0", VA = "0x180A0C4D0")]
		public AppboyBinding()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class CLDKBIEMKLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Action<FGAJDGFAKBJ> DGHDGIMPCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Action<FGAJDGFAKBJ> EONLNPCLHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Action<FGAJDGFAKBJ> IPEHMJKCFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Action<FGAJDGFAKBJ, LMMLLOIHOEB> HAJBPGPKBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public Action<FGAJDGFAKBJ, Uri> MMJKLOFHDEH;
}
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AppboyBindingTester : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA0C420", Offset = "0xA0AE20", VA = "0x180A0C420")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA0BF30", Offset = "0xA0A930", VA = "0x180A0BF30")]
		private void KPPIPFGEGGN(string IJOJGNJMCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA0C010", Offset = "0xA0AA10", VA = "0x180A0C010")]
		private void LDKKDEPDFHM(string IJOJGNJMCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA0C3B0", Offset = "0xA0ADB0", VA = "0x180A0C3B0")]
		private void PBBGMANAIHN(string IJOJGNJMCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A080", VA = "0x180A0B680")]
		private void GEKNGILABEF(string IJOJGNJMCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA0B790", Offset = "0xA0A190", VA = "0x180A0B790")]
		private void IOGIFJKKGME(string IJOJGNJMCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA0C080", Offset = "0xA0AA80", VA = "0x180A0C080")]
		private void MGICBCPFKEF(string IJOJGNJMCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA0C1E0", Offset = "0xA0ABE0", VA = "0x180A0C1E0")]
		private void NGDAJEMEKJP(string IJOJGNJMCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA0B440", Offset = "0xA09E40", VA = "0x180A0B440")]
		private void FBGHLLHKOID(string IJOJGNJMCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA0BAF0", Offset = "0xA0A4F0", VA = "0x180A0BAF0")]
		private void KBOGCIKMIDE(string IJOJGNJMCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA0C340", Offset = "0xA0AD40", VA = "0x180A0C340")]
		private void OPIBBGLDJEO(string IJOJGNJMCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA0B8A0", Offset = "0xA0A2A0", VA = "0x180A0B8A0")]
		public static void InAppMessageBeforeDisplayed(FGAJDGFAKBJ IJOJGNJMCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA0BA00", Offset = "0xA0A400", VA = "0x180A0BA00")]
		public static void InAppMessageDismissed(FGAJDGFAKBJ IJOJGNJMCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA0B990", Offset = "0xA0A390", VA = "0x180A0B990")]
		public static void InAppMessageClicked(FGAJDGFAKBJ IJOJGNJMCGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA0B910", Offset = "0xA0A310", VA = "0x180A0B910")]
		public static void InAppMessageButtonClicked(FGAJDGFAKBJ IJOJGNJMCGP, LMMLLOIHOEB KKJNCLHHAAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xA0BA70", Offset = "0xA0A470", VA = "0x180A0BA70")]
		public static void InAppMessageHTMLClicked(FGAJDGFAKBJ IJOJGNJMCGP, Uri CPPKKIGLPDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public AppboyBindingTester()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class PFAJIFDNPDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0xA19C70", Offset = "0xA18670", VA = "0x180A19C70")]
	public static string MGDFEBHEDEI(Dictionary<string, string> FHONBPKKLIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3C212C0", Offset = "0x3C1FCC0", VA = "0x183C212C0")]
	public static string EFFDPMGHELM<T>(List<T> IBKFNAMHILN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BKMGOMFCJOI
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF20", Offset = "0xA0B920", VA = "0x180A0CF20")]
	public static Color? PKMDHIGOFBM(string LDIHKGGKBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xA0D070", Offset = "0xA0BA70", VA = "0x180A0D070")]
	public static Color PKMDHIGOFBM(int LDIHKGGKBBO)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ELOHCLJPHBF
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0xA10CB0", Offset = "0xA0F6B0", VA = "0x180A10CB0")]
	public static object DKBEFMGKPNM(Type HDKNAAMEFKN, string PCDAHJCDHHF, bool FNMICNFOFHN, object ALKDPGOIFPD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MABLNMMABNN
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xA15DF0", Offset = "0xA147F0", VA = "0x180A15DF0")]
	public static Dictionary<string, string> EPBMLFDOMDN(IMIGPGEIMBK APBNLPNFAIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class ILPAPGJAPPE
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class CGMAMOMCAFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private StringBuilder DMEMNPOMCMK;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA0F4D0", Offset = "0xA0DED0", VA = "0x180A0F4D0")]
		private CGMAMOMCAFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA0F3F0", Offset = "0xA0DDF0", VA = "0x180A0F3F0")]
		public static string PGPOMLMDCHO(object OJDHMKOBKLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA0E9C0", Offset = "0xA0D3C0", VA = "0x180A0E9C0")]
		private void JBDPDLAEAKJ(object PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA0EE00", Offset = "0xA0D800", VA = "0x180A0EE00")]
		private void LDGBPLMCAGM(IDictionary OJDHMKOBKLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBB0", Offset = "0xA0D5B0", VA = "0x180A0EBB0")]
		private void KKFPGDMMMMO(IList KLDOGKPLNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA0E680", Offset = "0xA0D080", VA = "0x180A0E680")]
		private void GDMONIEMLIJ(string JDGADODOANI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA0F0F0", Offset = "0xA0DAF0", VA = "0x180A0F0F0")]
		private void NINGHPPPONG(object PCDAHJCDHHF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static NumberFormatInfo GOOONGFPADM;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0xA0F3F0", Offset = "0xA0DDF0", VA = "0x180A0F3F0")]
	public static string PGPOMLMDCHO(object OJDHMKOBKLD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public class CIMFBCOAJGA
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public virtual CIMFBCOAJGA OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public virtual CIMFBCOAJGA OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual string AMCECKEAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA103B0", Offset = "0xA0EDB0", VA = "0x180A103B0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public virtual int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4C0", Offset = "0xA0AEC0", VA = "0x180A0C4C0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public virtual int NCKNNNNAJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA0F550", Offset = "0xA0DF50", VA = "0x180A0F550", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA0F6D0", Offset = "0xA0E0D0", VA = "0x180A0F6D0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual bool HEJHDAEGBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA0F590", Offset = "0xA0DF90", VA = "0x180A0F590", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA103E0", Offset = "0xA0EDE0", VA = "0x180A103E0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public virtual LDAEBCGKHEI GPIPCHCEPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA10140", Offset = "0xA0EB40", VA = "0x180A10140", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public virtual IMIGPGEIMBK DOOIFCLFNNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA0F640", Offset = "0xA0E040", VA = "0x180A0F640", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "4")]
	public virtual void PBDMKLNODMP(string ACCLNCEPBCC, CIMFBCOAJGA NIPEHNDELDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0xA10460", Offset = "0xA0EE60", VA = "0x180A10460", Slot = "10")]
	public virtual void PBDMKLNODMP(CIMFBCOAJGA NIPEHNDELDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0xA104C0", Offset = "0xA0EEC0", VA = "0x180A104C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xA10240", Offset = "0xA0EC40", VA = "0x180A10240")]
	public static CIMFBCOAJGA HNONLACFBHP(string NDFNAFDNBHK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0xA101C0", Offset = "0xA0EBC0", VA = "0x180A101C0")]
	public static string HNONLACFBHP(CIMFBCOAJGA AIDBPMAAHBO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xA102B0", Offset = "0xA0ECB0", VA = "0x180A102B0")]
	public static bool IDFALDDOLDN(CIMFBCOAJGA MJGADEGDMOP, object LJDEEJKPAEN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA10330", Offset = "0xA0ED30", VA = "0x180A10330")]
	public static bool JAIBCELPAPH(CIMFBCOAJGA MJGADEGDMOP, object LJDEEJKPAEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6C0", Offset = "0xA0E0C0", VA = "0x180A0F6C0", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xA10130", Offset = "0xA0EB30", VA = "0x180A10130", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA0F710", Offset = "0xA0E110", VA = "0x180A0F710")]
	internal static string FFNMPOLHILH(string ABEODEBGAKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA0F8C0", Offset = "0xA0E2C0", VA = "0x180A0F8C0")]
	public static CIMFBCOAJGA GOPLFKFJMCC(string OLPKMPPODKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public CIMFBCOAJGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DefaultMember("Item")]
public class LDAEBCGKHEI : CIMFBCOAJGA, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class HFKAJNFDGCL : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public LDAEBCGKHEI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<CIMFBCOAJGA>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public HFKAJNFDGCL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA12680", Offset = "0xA11080", VA = "0x180A12680", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA12480", Offset = "0xA10E80", VA = "0x180A12480", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA12430", Offset = "0xA10E30", VA = "0x180A12430")]
		private void KIPLFAABBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA12630", Offset = "0xA11030", VA = "0x180A12630", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<CIMFBCOAJGA> KKKCIDAEMDJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override CIMFBCOAJGA OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA150C0", Offset = "0xA13AC0", VA = "0x180A150C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override CIMFBCOAJGA OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA15190", Offset = "0xA13B90", VA = "0x180A15190", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA15080", Offset = "0xA13A80", VA = "0x180A15080", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0xA15290", Offset = "0xA13C90", VA = "0x180A15290", Slot = "4")]
	public override void PBDMKLNODMP(string ACCLNCEPBCC, CIMFBCOAJGA NIPEHNDELDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xA15210", Offset = "0xA13C10", VA = "0x180A15210", Slot = "17")]
	[IteratorStateMachine(typeof(HFKAJNFDGCL))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xA15340", Offset = "0xA13D40", VA = "0x180A15340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xA15500", Offset = "0xA13F00", VA = "0x180A15500")]
	public LDAEBCGKHEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class IMIGPGEIMBK : CIMFBCOAJGA, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class PPNJNHCDIGC : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public IMIGPGEIMBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Dictionary<string, CIMFBCOAJGA>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
		[DebuggerHidden]
		public PPNJNHCDIGC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA1A190", Offset = "0xA18B90", VA = "0x180A1A190", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA19F20", Offset = "0xA18920", VA = "0x180A19F20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA19ED0", Offset = "0xA188D0", VA = "0x180A19ED0")]
		private void KIPLFAABBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA1A140", Offset = "0xA18B40", VA = "0x180A1A140", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Dictionary<string, CIMFBCOAJGA> JBHHEFGFHDL;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override CIMFBCOAJGA OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA13290", Offset = "0xA11C90", VA = "0x180A13290", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override CIMFBCOAJGA OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA13380", Offset = "0xA11D80", VA = "0x180A13380", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override int IMMMMMEPNJA
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA13240", Offset = "0xA11C40", VA = "0x180A13240", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xA134A0", Offset = "0xA11EA0", VA = "0x180A134A0", Slot = "4")]
	public override void PBDMKLNODMP(string ACCLNCEPBCC, CIMFBCOAJGA NIPEHNDELDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xA13420", Offset = "0xA11E20", VA = "0x180A13420", Slot = "17")]
	[IteratorStateMachine(typeof(PPNJNHCDIGC))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xA135B0", Offset = "0xA11FB0", VA = "0x180A135B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0xA139C0", Offset = "0xA123C0", VA = "0x180A139C0")]
	public IMIGPGEIMBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KDJLIKKPIFB : CIMFBCOAJGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private string FENPFCIBEHL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public override string AMCECKEAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
	public KDJLIKKPIFB(string AIAIOKAIEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA144D0", Offset = "0xA12ED0", VA = "0x180A144D0")]
	public KDJLIKKPIFB(bool AIAIOKAIEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA14490", Offset = "0xA12E90", VA = "0x180A14490")]
	public KDJLIKKPIFB(int AIAIOKAIEDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA14440", Offset = "0xA12E40", VA = "0x180A14440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
internal class JMANGPKCBEI : CIMFBCOAJGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private CIMFBCOAJGA BHIFACOHNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private string ELDIAJKBKND;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public override CIMFBCOAJGA OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA13D80", Offset = "0xA12780", VA = "0x180A13D80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public override CIMFBCOAJGA OIPJADEMDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xA13CF0", Offset = "0xA126F0", VA = "0x180A13CF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override int NCKNNNNAJHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA13B50", Offset = "0xA12550", VA = "0x180A13B50", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA13F30", Offset = "0xA12930", VA = "0x180A13F30", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override bool HEJHDAEGBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA13C20", Offset = "0xA12620", VA = "0x180A13C20", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA140C0", Offset = "0xA12AC0", VA = "0x180A140C0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override LDAEBCGKHEI GPIPCHCEPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA14010", Offset = "0xA12A10", VA = "0x180A14010", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override IMIGPGEIMBK DOOIFCLFNNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA13E70", Offset = "0xA12870", VA = "0x180A13E70", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0xA143F0", Offset = "0xA12DF0", VA = "0x180A143F0")]
	public JMANGPKCBEI(CIMFBCOAJGA OOOBJEFGMHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xA143A0", Offset = "0xA12DA0", VA = "0x180A143A0")]
	public JMANGPKCBEI(CIMFBCOAJGA OOOBJEFGMHA, string ACCLNCEPBCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xA13E00", Offset = "0xA12800", VA = "0x180A13E00")]
	private void DGDFODDEBEH(CIMFBCOAJGA DBHJIFBIGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xA141A0", Offset = "0xA12BA0", VA = "0x180A141A0", Slot = "10")]
	public override void PBDMKLNODMP(CIMFBCOAJGA NIPEHNDELDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0xA14280", Offset = "0xA12C80", VA = "0x180A14280", Slot = "4")]
	public override void PBDMKLNODMP(string ACCLNCEPBCC, CIMFBCOAJGA NIPEHNDELDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0xA13F20", Offset = "0xA12920", VA = "0x180A13F20", Slot = "0")]
	public override bool Equals(object OJDHMKOBKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xA10130", Offset = "0xA0EB30", VA = "0x180A10130", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0xA14370", Offset = "0xA12D70", VA = "0x180A14370", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class MCGKNEAOJFI
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xA160F0", Offset = "0xA14AF0", VA = "0x180A160F0")]
	public static CIMFBCOAJGA GOPLFKFJMCC(string OLPKMPPODKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum LNAHCNFLEDM
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	OPTED_IN,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	SUBSCRIBED,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	UNSUBSCRIBED
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NEICBOHPHIA
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public KFMKAKEOBJI OCPDNNMNNPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int JIKKOPPOFLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA16630", Offset = "0xA15030", VA = "0x180A16630")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string KKFIMMCILPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA0A570", Offset = "0xA08F70", VA = "0x180A0A570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int PHLOOLILBCM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA155B0", Offset = "0xA13FB0", VA = "0x180A155B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA155E0", Offset = "0xA13FE0", VA = "0x180A155E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IDictionary<string, object> HJJLPMCCMCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xA14650", Offset = "0xA13050", VA = "0x180A14650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0xA17440", Offset = "0xA15E40", VA = "0x180A17440")]
	public NEICBOHPHIA(IMIGPGEIMBK APBNLPNFAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0xA16640", Offset = "0xA15040", VA = "0x180A16640")]
	private object JLJBCKIKFNL(CIMFBCOAJGA DGGBJNBEMBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0xA16D70", Offset = "0xA15770", VA = "0x180A16D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class KFMKAKEOBJI
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IList<string> MEPBBJOMCHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string JFJAKHKCDAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public string KOLOOCKHAEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA0A570", Offset = "0xA08F70", VA = "0x180A0A570")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public string DPAECCJHJBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA093C0", VA = "0x180A0A9C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public string OFAGPDEFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA14650", Offset = "0xA13050", VA = "0x180A14650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0xA14AB0", Offset = "0xA134B0", VA = "0x180A14AB0")]
	public KFMKAKEOBJI(IMIGPGEIMBK APBNLPNFAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0xA14660", Offset = "0xA13060", VA = "0x180A14660", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum KMACODDBLOH
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
public enum DDAKOJHGJMD
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	NEWS_FEED,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	URI,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	NONE
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum DPCBPCDIIIB
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	AUTO_DISMISS,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	SWIPE
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HILNCCMMKCM
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public List<FPBJOAFACGN> EFNHJBEHBCB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool PLMKOFPCHGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xA129F0", Offset = "0xA113F0", VA = "0x180A129F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0xA12C50", Offset = "0xA11650", VA = "0x180A12C50")]
	public HILNCCMMKCM(string IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0xA12A00", Offset = "0xA11400", VA = "0x180A12A00")]
	private static FPBJOAFACGN IANOOJIPHJM(IMIGPGEIMBK APBNLPNFAIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum DJKKKAHCFID
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
public class AOOFGFIOGHH
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string OKEIJCNJDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string KKEPOPAPFDG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string CJLJDIDBKGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA0A570", Offset = "0xA08F70", VA = "0x180A0A570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Dictionary<string, string> LKAFJDIINEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA093C0", VA = "0x180A0A9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int LKMGHPAIGEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7C0", Offset = "0xA091C0", VA = "0x180A0A7C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA0A550", Offset = "0xA08F50", VA = "0x180A0A550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public long EGFMMHNFPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA0A580", Offset = "0xA08F80", VA = "0x180A0A580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string CEBCEDNNJEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA0A540", Offset = "0xA08F40", VA = "0x180A0A540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7D0", Offset = "0xA091D0", VA = "0x180A0A7D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0xA0ACE0", Offset = "0xA096E0", VA = "0x180A0ACE0")]
	public AOOFGFIOGHH(string IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9E0", Offset = "0xA093E0", VA = "0x180A0A9E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0xA0A3A0", Offset = "0xA08DA0", VA = "0x180A0A3A0")]
	private string ANGKBECLGJM(IMIGPGEIMBK APBNLPNFAIO, string KJNEHANBOBO, string ALKDPGOIFPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0xA0A5A0", Offset = "0xA08FA0", VA = "0x180A0A5A0")]
	private int FPLAMDGLPMB(IMIGPGEIMBK APBNLPNFAIO, string KJNEHANBOBO, int ALKDPGOIFPD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0xA0A7E0", Offset = "0xA091E0", VA = "0x180A0A7E0")]
	private long PIBDKOBKPAK(IMIGPGEIMBK APBNLPNFAIO, string KJNEHANBOBO, long ALKDPGOIFPD)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum NOIMIEBJOMK
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	TOP,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	BOTTOM
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface FGAJDGFAKBJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface NAGMGJENLNP
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	List<LMMLLOIHOEB> JALAIHPMHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class ABNJCDGKODJ : FGAJDGFAKBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected string PAIEKGCKCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int KBNGJHPPCOO;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Color? IABJFPGOONN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA091B0", Offset = "0xA07BB0", VA = "0x180A091B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA09170", Offset = "0xA07B70", VA = "0x180A09170", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Color? ONJOLOEBCPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA09250", Offset = "0xA07C50", VA = "0x180A09250", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA09140", Offset = "0xA07B40", VA = "0x180A09140", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string HNJHOFAGMLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA091E0", Offset = "0xA07BE0", VA = "0x180A091E0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA09180", Offset = "0xA07B80", VA = "0x180A09180", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Color? KGPPINHOALF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA09120", Offset = "0xA07B20", VA = "0x180A09120", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA091D0", Offset = "0xA07BD0", VA = "0x180A091D0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Color? MFBJMOJKGCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA092E0", Offset = "0xA07CE0", VA = "0x180A092E0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA09230", Offset = "0xA07C30", VA = "0x180A09230", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string HDPEJAHEAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA092C0", Offset = "0xA07CC0", VA = "0x180A092C0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA09160", Offset = "0xA07B60", VA = "0x180A09160", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string PGOOIHNHDKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA09190", Offset = "0xA07B90", VA = "0x180A09190", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA09280", Offset = "0xA07C80", VA = "0x180A09280", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Dictionary<string, string> LKAFJDIINEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xA09220", Offset = "0xA07C20", VA = "0x180A09220", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA09300", Offset = "0xA07D00", VA = "0x180A09300", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public DDAKOJHGJMD HBFJAKKBDEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA09270", Offset = "0xA07C70", VA = "0x180A09270", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(DDAKOJHGJMD);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA09150", Offset = "0xA07B50", VA = "0x180A09150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string GIJPJBDKLPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA091A0", Offset = "0xA07BA0", VA = "0x180A091A0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA092A0", Offset = "0xA07CA0", VA = "0x180A092A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public DPCBPCDIIIB ECEBKHGNAPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA09290", Offset = "0xA07C90", VA = "0x180A09290", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(DPCBPCDIIIB);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA092D0", Offset = "0xA07CD0", VA = "0x180A092D0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int LMLEFBGOJLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA09240", Offset = "0xA07C40", VA = "0x180A09240", Slot = "24")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA091F0", Offset = "0xA07BF0", VA = "0x180A091F0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0xA09320", Offset = "0xA07D20", VA = "0x180A09320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0xA09900", Offset = "0xA08300", VA = "0x180A09900")]
	public ABNJCDGKODJ(IMIGPGEIMBK APBNLPNFAIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class LMMLLOIHOEB
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int BOKJKMFDDBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA09110", Offset = "0xA07B10", VA = "0x180A09110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA155F0", Offset = "0xA13FF0", VA = "0x180A155F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string BHOIENPHJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string GIJPJBDKLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA0A570", Offset = "0xA08F70", VA = "0x180A0A570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DDAKOJHGJMD OFADKEHOHFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA155B0", Offset = "0xA13FB0", VA = "0x180A155B0")]
		[CompilerGenerated]
		get
		{
			return default(DDAKOJHGJMD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA155E0", Offset = "0xA13FE0", VA = "0x180A155E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public Color? ONJOLOEBCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA15600", Offset = "0xA14000", VA = "0x180A15600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA15590", Offset = "0xA13F90", VA = "0x180A15590")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Color? IABJFPGOONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xA155C0", Offset = "0xA13FC0", VA = "0x180A155C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA155A0", Offset = "0xA13FA0", VA = "0x180A155A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0xA15620", Offset = "0xA14020", VA = "0x180A15620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0xA15910", Offset = "0xA14310", VA = "0x180A15910")]
	public LMMLLOIHOEB(IMIGPGEIMBK APBNLPNFAIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GCOOPABEEOA
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0xA11D50", Offset = "0xA10750", VA = "0x180A11D50")]
	public static IMIGPGEIMBK BEJDNKCLKEI(string OOKDICODMHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class HGFDIAMNFCH
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0xA12740", Offset = "0xA11140", VA = "0x180A12740")]
	public static FGAJDGFAKBJ HJCCMGOGKKP(string PJJLGHJNKLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class FKMKOJJJKEE : BNFBBFCBLAN
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xA10D30", Offset = "0xA0F730", VA = "0x180A10D30")]
	public FKMKOJJJKEE(IMIGPGEIMBK APBNLPNFAIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class BNFBBFCBLAN : ABNJCDGKODJ, NAGMGJENLNP
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string GJPNKFFBFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA0D3B0", Offset = "0xA0BDB0", VA = "0x180A0D3B0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA0D3C0", Offset = "0xA0BDC0", VA = "0x180A0D3C0", Slot = "28")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Color? JPAECOFENFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA0D400", Offset = "0xA0BE00", VA = "0x180A0D400", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA0D390", Offset = "0xA0BD90", VA = "0x180A0D390", Slot = "30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public Color? NIPDLPEEBBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA0D3E0", Offset = "0xA0BDE0", VA = "0x180A0D3E0", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA0D420", Offset = "0xA0BE20", VA = "0x180A0D420", Slot = "32")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public List<LMMLLOIHOEB> JALAIHPMHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA0D440", Offset = "0xA0BE40", VA = "0x180A0D440", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA0D370", Offset = "0xA0BD70", VA = "0x180A0D370", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0xA0D450", Offset = "0xA0BE50", VA = "0x180A0D450", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xA0D6E0", Offset = "0xA0C0E0", VA = "0x180A0D6E0")]
	public BNFBBFCBLAN(IMIGPGEIMBK APBNLPNFAIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class NAKACAMEGJN : BNFBBFCBLAN
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xA10D30", Offset = "0xA0F730", VA = "0x180A10D30")]
	public NAKACAMEGJN(IMIGPGEIMBK APBNLPNFAIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class MDGIOPKCDJC : ABNJCDGKODJ
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public NOIMIEBJOMK ELNOMANLPIH
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA16130", Offset = "0xA14B30", VA = "0x180A16130")]
		[CompilerGenerated]
		get
		{
			return default(NOIMIEBJOMK);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA16100", Offset = "0xA14B00", VA = "0x180A16100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool LAGJODOPEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA16120", Offset = "0xA14B20", VA = "0x180A16120")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA16110", Offset = "0xA14B10", VA = "0x180A16110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Color? DONDMAFGOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA0D400", Offset = "0xA0BE00", VA = "0x180A0D400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA0D390", Offset = "0xA0BD90", VA = "0x180A0D390")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0xA16140", Offset = "0xA14B40", VA = "0x180A16140", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0xA16380", Offset = "0xA14D80", VA = "0x180A16380")]
	public MDGIOPKCDJC(IMIGPGEIMBK APBNLPNFAIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum ABMEEGHLKIO
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	FULL,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	MODAL,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	SLIDEUP
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class GNNJABGLFDN : FPBJOAFACGN
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string HDEOGHMJJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA10570", Offset = "0xA0EF70", VA = "0x180A10570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA10560", Offset = "0xA0EF60", VA = "0x180A10560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string EPPHGPODHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0xA10550", Offset = "0xA0EF50", VA = "0x180A10550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA10540", Offset = "0xA0EF40", VA = "0x180A10540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string BPCEHPMEJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA10520", Offset = "0xA0EF20", VA = "0x180A10520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xA10510", Offset = "0xA0EF10", VA = "0x180A10510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0xA12040", Offset = "0xA10A40", VA = "0x180A12040")]
	public GNNJABGLFDN(IMIGPGEIMBK APBNLPNFAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0xA11E80", Offset = "0xA10880", VA = "0x180A11E80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class ONPDLMDHIBH : FPBJOAFACGN
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public string HDEOGHMJJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xA10570", Offset = "0xA0EF70", VA = "0x180A10570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA10560", Offset = "0xA0EF60", VA = "0x180A10560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string KKEPOPAPFDG
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA10550", Offset = "0xA0EF50", VA = "0x180A10550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA10540", Offset = "0xA0EF40", VA = "0x180A10540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string CKFNMAMOGDM
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA10520", Offset = "0xA0EF20", VA = "0x180A10520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA10510", Offset = "0xA0EF10", VA = "0x180A10510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string EPPHGPODHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA10500", Offset = "0xA0EF00", VA = "0x180A10500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string BPCEHPMEJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA17C00", Offset = "0xA16600", VA = "0x180A17C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA17C40", Offset = "0xA16640", VA = "0x180A17C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0xA19720", Offset = "0xA18120", VA = "0x180A19720")]
	public ONPDLMDHIBH(IMIGPGEIMBK APBNLPNFAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0xA194B0", Offset = "0xA17EB0", VA = "0x180A194B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class FPBJOAFACGN
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string PNFBOOCDALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string GLEDFKBBOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool DHEDALDCJBE
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0xA10D70", Offset = "0xA0F770", VA = "0x180A10D70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA10D60", Offset = "0xA0F760", VA = "0x180A10D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public long DEJEKBCPKFO
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA10D50", Offset = "0xA0F750", VA = "0x180A10D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public long OGHGKMBFLJG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA10FD0", Offset = "0xA0F9D0", VA = "0x180A10FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public HashSet<KMACODDBLOH> NCDFLNLGPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA10D40", Offset = "0xA0F740", VA = "0x180A10D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private string PJNAGCILAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7D0", Offset = "0xA091D0", VA = "0x180A0A7D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public Dictionary<string, string> LKAFJDIINEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA091E0", Offset = "0xA07BE0", VA = "0x180A091E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA09180", Offset = "0xA07B80", VA = "0x180A09180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0xA11380", Offset = "0xA0FD80", VA = "0x180A11380")]
	public FPBJOAFACGN(IMIGPGEIMBK APBNLPNFAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xA10FE0", Offset = "0xA0F9E0", VA = "0x180A10FE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0xA10D80", Offset = "0xA0F780", VA = "0x180A10D80")]
	public string KLNPJCBOIJF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class OBPIHOBPILI : FPBJOAFACGN
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string CKFNMAMOGDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xA10570", Offset = "0xA0EF70", VA = "0x180A10570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xA10560", Offset = "0xA0EF60", VA = "0x180A10560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string HDEOGHMJJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xA10550", Offset = "0xA0EF50", VA = "0x180A10550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xA10540", Offset = "0xA0EF40", VA = "0x180A10540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public string KKEPOPAPFDG
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xA10520", Offset = "0xA0EF20", VA = "0x180A10520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xA10510", Offset = "0xA0EF10", VA = "0x180A10510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public string EPPHGPODHLA
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA10500", Offset = "0xA0EF00", VA = "0x180A10500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string BPCEHPMEJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA17C00", Offset = "0xA16600", VA = "0x180A17C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xA17C40", Offset = "0xA16640", VA = "0x180A17C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0xA18E90", Offset = "0xA17890", VA = "0x180A18E90")]
	public OBPIHOBPILI(IMIGPGEIMBK APBNLPNFAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0xA18C20", Offset = "0xA17620", VA = "0x180A18C20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class NOEFGNGMPIM
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public string PNFBOOCDALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string GLEDFKBBOKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool DHEDALDCJBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA10D70", Offset = "0xA0F770", VA = "0x180A10D70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA10D60", Offset = "0xA0F760", VA = "0x180A10D60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public long DEJEKBCPKFO
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA10D50", Offset = "0xA0F750", VA = "0x180A10D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public long DLOKLOLDHFM
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA10FD0", Offset = "0xA0F9D0", VA = "0x180A10FD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public string HDEOGHMJJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA10D40", Offset = "0xA0F740", VA = "0x180A10D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string KKEPOPAPFDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA0A540", Offset = "0xA08F40", VA = "0x180A0A540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7D0", Offset = "0xA091D0", VA = "0x180A0A7D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public string CKFNMAMOGDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA091E0", Offset = "0xA07BE0", VA = "0x180A091E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA09180", Offset = "0xA07B80", VA = "0x180A09180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public string EPPHGPODHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA10570", Offset = "0xA0EF70", VA = "0x180A10570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA10560", Offset = "0xA0EF60", VA = "0x180A10560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public string BPCEHPMEJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA10550", Offset = "0xA0EF50", VA = "0x180A10550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA10540", Offset = "0xA0EF40", VA = "0x180A10540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public bool KBNAAIBOBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA17C20", Offset = "0xA16620", VA = "0x180A17C20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xA17BD0", Offset = "0xA165D0", VA = "0x180A17BD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool JFLHDDGFNHK
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA17A50", Offset = "0xA16450", VA = "0x180A17A50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA17BB0", Offset = "0xA165B0", VA = "0x180A17BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool MHDEPCIEHEK
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xA17C30", Offset = "0xA16630", VA = "0x180A17C30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xA17A60", Offset = "0xA16460", VA = "0x180A17A60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool EPIGBKELFAE
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xA17BF0", Offset = "0xA165F0", VA = "0x180A17BF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA17BC0", Offset = "0xA165C0", VA = "0x180A17BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool KMPLJAAODJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA17C10", Offset = "0xA16610", VA = "0x180A17C10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA17BE0", Offset = "0xA165E0", VA = "0x180A17BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public string PJNAGCILAHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA10500", Offset = "0xA0EF00", VA = "0x180A10500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public Dictionary<string, string> LKAFJDIINEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA17C00", Offset = "0xA16600", VA = "0x180A17C00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA17C40", Offset = "0xA16640", VA = "0x180A17C40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0xA18330", Offset = "0xA16D30", VA = "0x180A18330")]
	public NOEFGNGMPIM(IMIGPGEIMBK APBNLPNFAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0xA17C50", Offset = "0xA16650", VA = "0x180A17C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0xA17A70", Offset = "0xA16470", VA = "0x180A17A70")]
	public void AEJDOIOLOLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0xA17B10", Offset = "0xA16510", VA = "0x180A17B10")]
	public void AODECFEONCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class ELCKJEBHNOO : FPBJOAFACGN
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public string KKEPOPAPFDG
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA10570", Offset = "0xA0EF70", VA = "0x180A10570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA10560", Offset = "0xA0EF60", VA = "0x180A10560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public string CKFNMAMOGDM
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA10550", Offset = "0xA0EF50", VA = "0x180A10550")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA10540", Offset = "0xA0EF40", VA = "0x180A10540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public string EPPHGPODHLA
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA10520", Offset = "0xA0EF20", VA = "0x180A10520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA10510", Offset = "0xA0EF10", VA = "0x180A10510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string BPCEHPMEJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xA10500", Offset = "0xA0EF00", VA = "0x180A10500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0xA107A0", Offset = "0xA0F1A0", VA = "0x180A107A0")]
	public ELCKJEBHNOO(IMIGPGEIMBK APBNLPNFAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0xA10580", Offset = "0xA0EF80", VA = "0x180A10580", Slot = "3")]
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
		private JHKPHJHBHLK FLMGFOPPPDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private KEMFNLANAFI BKKLJIDNPME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CLDKBIEMKLH iamListener;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
		public void setPushPromptResponseReceivedDelegate(JHKPHJHBHLK HACEDNJLACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA0A570", Offset = "0xA08F70", VA = "0x180A0A570")]
		public void setPushTokenReceivedFromSystemDelegate(KEMFNLANAFI HACEDNJLACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xA0E390", Offset = "0xA0CD90", VA = "0x180A0E390")]
		public void onPushPromptResponseReceived(string COBBCGIHJAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA0E400", Offset = "0xA0CE00", VA = "0x180A0E400")]
		public void onPushTokenReceivedFromSystem(string BECBHDDLOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA0DCF0", Offset = "0xA0C6F0", VA = "0x180A0DCF0")]
		public void beforeInAppMessageDisplayed(string JFGBBCPPOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA0E0B0", Offset = "0xA0CAB0", VA = "0x180A0E0B0")]
		public void onInAppMessageDismissed(string JFGBBCPPOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA0E050", Offset = "0xA0CA50", VA = "0x180A0E050")]
		public void onInAppMessageClicked(string JFGBBCPPOGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xA0DD50", Offset = "0xA0C750", VA = "0x180A0DD50")]
		public void onInAppMessageButtonClicked(string IMJLINGEEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xA0E110", Offset = "0xA0CB10", VA = "0x180A0E110")]
		public void onInAppMessageHTMLClicked(string IMJLINGEEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public BrazeInternalComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class BrazeInternalGameObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static GameObject NMGHOHCNINO;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private static GameObject FDCAMNOGINK
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xA0E420", Offset = "0xA0CE20", VA = "0x180A0E420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xA0E5C0", Offset = "0xA0CFC0", VA = "0x180A0E5C0")]
		public static void setPushPromptResponseReceivedDelegate(JHKPHJHBHLK HACEDNJLACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xA0E620", Offset = "0xA0D020", VA = "0x180A0E620")]
		public static void setPushTokenReceivedFromSystemDelegate(KEMFNLANAFI HACEDNJLACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xA0E560", Offset = "0xA0CF60", VA = "0x180A0E560")]
		public static void setInAppMessageListener(CLDKBIEMKLH PFCKOIMEHDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
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
