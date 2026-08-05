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
	[Cpp2IlInjected.Address(RVA = "0x6B22990", Offset = "0x6B21190", VA = "0x186B22990")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6B224D0", Offset = "0x6B20CD0", VA = "0x186B224D0")]
	public string PrintOutObjectValues(object ANLLMHFNJEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x90A150", Offset = "0x908950", VA = "0x18090A150")]
	public ApplePushNotificationTester()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ILDNNIOONIF
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BLPBKKCOPOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public Action<BPHHBFCDHIE> FFBBPKJHPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public Action<BPHHBFCDHIE> HIKLKBPDIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public Action<BPHHBFCDHIE> FOACIAHGFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public Action<BPHHBFCDHIE, FKACLANNGJM> AAOIDIBICBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public Action<BPHHBFCDHIE, Uri> LJFOHKCOJAL;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum CFDPMDFFDBL
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
public enum FMMAACEPPLD
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	IAM_DISPLAY_NOW,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	IAM_DISPLAY_LATER,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	IAM_DISCARD
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void HBGJFIIOOHM(bool LIMHFNFMBPP);
[Cpp2IlInjected.Token(Token = "0x2000008")]
public delegate void NBCEADBELNA(string AMCDGOPKAOE);
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AppboyBinding : SingletonMonoBehaviour<AppboyBinding>
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ILDNNIOONIF KJPJCNBGJPM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static ILDNNIOONIF CBOIKHIBMME
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6B22490", Offset = "0x6B20C90", VA = "0x186B22490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static BLPBKKCOPOD EDEDFNOKELH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8E4370", Offset = "0x8E2B70", VA = "0x1808E4370")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void LogCustomEvent(string DJHBGOECNIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void LogCustomEvent(string DJHBGOECNIL, Dictionary<string, object> LAEPKFGACAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void LogPurchase(string BIHLABMDNCM, string OHNAHHLACCM, decimal GBFEFOLPAOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void LogPurchase(string BIHLABMDNCM, string OHNAHHLACCM, decimal GBFEFOLPAOP, int MLKDHDAOMNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void LogPurchase(string BIHLABMDNCM, string OHNAHHLACCM, decimal GBFEFOLPAOP, int MLKDHDAOMNB, Dictionary<string, object> LAEPKFGACAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void ChangeUser(string EHKIONDBEDO, [Optional] string FBAIAMLLNDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetSdkAuthenticationSignature(string FBAIAMLLNDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetUserFirstName(string MPBPJLNDPFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetUserLastName(string DJEMDNEBPEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetUserEmail(string CNDIBJCMCPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetUserGender(HHBLAHBPCKK JIGHFDBDNKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetUserDateOfBirth(int CFFJIGFBNNP, int IJNNOFOPKPC, int GHOMJBLDEHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetUserCountry(string KCOIHMANMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetUserHomeCity(string JBIKMJAABFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetUserEmailNotificationSubscriptionType(CEEKMNOONKG POBIKBOAKKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetUserPushNotificationSubscriptionType(CEEKMNOONKG HKLJNPOMLKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetUserPhoneNumber(string KAILKGNMNHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetCustomUserAttribute(string EECINICJCLK, bool MENBIMCLIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetCustomUserAttribute(string EECINICJCLK, int MENBIMCLIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetCustomUserAttribute(string EECINICJCLK, float MENBIMCLIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetCustomUserAttribute(string EECINICJCLK, string MENBIMCLIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetCustomUserAttributeToNow(string EECINICJCLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetCustomUserAttributeToSecondsFromEpoch(string EECINICJCLK, long ECEMOHCHGEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void UnsetCustomUserAttribute(string EECINICJCLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void IncrementCustomUserAttribute(string EECINICJCLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void IncrementCustomUserAttribute(string EECINICJCLK, int OLKKIHHKNLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetCustomUserAttributeArray(string EECINICJCLK, List<string> DLLMPOAIBGN, int JIAHBEIKEJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void AddToCustomUserAttributeArray(string EECINICJCLK, string MENBIMCLIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void RemoveFromCustomUserAttributeArray(string EECINICJCLK, string MENBIMCLIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void setUserFacebookData(string FBBNGNMKFKL, string MPBPJLNDPFH, string DJEMDNEBPEE, string CNDIBJCMCPB, string MDCOLMCCMOP, string JJNOFJOLKFI, HHBLAHBPCKK? JIGHFDBDNKN, int? JLNCHNBFIFC, string FKAGCIJFKCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void setUserTwitterData(int? ANCNHHLDPKD, string NJBACGACMBP, string MDOAADHDBMA, string PNEPJANIHCF, int? BIEGEDFJMLG, int? FPJLIGIGIDF, int? GKMHPLGCFOJ, string NAFHKCPKDBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetUserLastKnownLocation(double CHFGBBBIANJ, double DLILBHKOFOE, [Optional] double? IJPGGDKLIJM, [Optional] double? CAJLIMFEGOE, [Optional] double? MCOFMHAFADH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void PromptUserForPushPermissions(bool NCNEGAOOHBD, [Optional] HBGJFIIOOHM FJGMDNCGEJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetPushTokenReceivedFromSystemDelegate(NBCEADBELNA MBACJOIJHIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void LogInAppMessageClicked(string PPPAGKAGHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void LogInAppMessageImpression(string PPPAGKAGHFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void LogInAppMessageButtonClicked(string PPPAGKAGHFN, int KCAIPBCDIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void RequestFeedRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void RequestFeedRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void LogFeedDisplayed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void RequestContentCardsRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void RequestContentCardsRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void LogContentCardClicked(string EKHCMLMJEHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void LogContentCardImpression(string EKHCMLMJEHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void LogContentCardDismissed(string EKHCMLMJEHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void WipeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void EnableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void DisableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8E4370", Offset = "0x8E2B70", VA = "0x1808E4370")]
		public static string GetInstallTrackingId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetAttributionData(string HGPNEJFDJOL, string CLBKKHOCGPI, string PFCJLKLJKJL, string DBAGGALEPEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void RequestLocationInitialization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void RequestGeofences(decimal CHFGBBBIANJ, decimal DLILBHKOFOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void RequestImmediateDataFlush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void AddAlias(string OCADLPLGGDN, string NBKOLIOINOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void ConfigureListener(CFDPMDFFDBL HOFPHBBFLDN, string CGDPHLOLDMI, string DCIJDKOCBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void SetInAppMessageDisplayAction(FMMAACEPPLD BJFFMOOKJPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void DisplayNextInAppMessage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void DisplayContentCards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void AddToSubscriptionGroup(string BMKPPKKOMAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850")]
		public static void RemoveFromSubscriptionGroup(string BMKPPKKOMAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6B22450", Offset = "0x6B20C50", VA = "0x186B22450")]
		public AppboyBinding()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AppboyBindingTester : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6B223D0", Offset = "0x6B20BD0", VA = "0x186B223D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6B21E50", Offset = "0x6B20650", VA = "0x186B21E50")]
		private void KMMNDIDHKJC(string AKADEFDGONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6B212F0", Offset = "0x6B1FAF0", VA = "0x186B212F0")]
		private void FCCIDOEEJCN(string AKADEFDGONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6B21DD0", Offset = "0x6B205D0", VA = "0x186B21DD0")]
		private void JBBMIJNBFJP(string AKADEFDGONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6B21F40", Offset = "0x6B20740", VA = "0x186B21F40")]
		private void LMNBKHNMOJM(string AKADEFDGONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6B217E0", Offset = "0x6B1FFE0", VA = "0x186B217E0")]
		private void GAONGCOLDDE(string AKADEFDGONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6B22050", Offset = "0x6B20850", VA = "0x186B22050")]
		private void MEGCMFNMJAM(string AKADEFDGONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6B22250", Offset = "0x6B20A50", VA = "0x186B22250")]
		private void OMDMGJNIKGG(string AKADEFDGONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6B218F0", Offset = "0x6B200F0", VA = "0x186B218F0")]
		private void GIAMJAJNMJF(string AKADEFDGONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6B21370", Offset = "0x6B1FB70", VA = "0x186B21370")]
		private void FJOFFJOAHKN(string AKADEFDGONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6B221D0", Offset = "0x6B209D0", VA = "0x186B221D0")]
		private void NBFBEJJGDKF(string AKADEFDGONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6B21B30", Offset = "0x6B20330", VA = "0x186B21B30")]
		public static void InAppMessageBeforeDisplayed(BPHHBFCDHIE AKADEFDGONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6B21CC0", Offset = "0x6B204C0", VA = "0x186B21CC0")]
		public static void InAppMessageDismissed(BPHHBFCDHIE AKADEFDGONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6B21C40", Offset = "0x6B20440", VA = "0x186B21C40")]
		public static void InAppMessageClicked(BPHHBFCDHIE AKADEFDGONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6B21BB0", Offset = "0x6B203B0", VA = "0x186B21BB0")]
		public static void InAppMessageButtonClicked(BPHHBFCDHIE AKADEFDGONP, FKACLANNGJM GHDELLMKMNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6B21D40", Offset = "0x6B20540", VA = "0x186B21D40")]
		public static void InAppMessageHTMLClicked(BPHHBFCDHIE AKADEFDGONP, Uri KNKHPLNKBIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x90A150", Offset = "0x908950", VA = "0x18090A150")]
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
		private static GameObject KLLABPMEFNM;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		private static GameObject OEFAOPMNMGM
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x6B23620", Offset = "0x6B21E20", VA = "0x186B23620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6B237D0", Offset = "0x6B21FD0", VA = "0x186B237D0")]
		public static void setPushPromptResponseReceivedDelegate(HBGJFIIOOHM FJGMDNCGEJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6B23830", Offset = "0x6B22030", VA = "0x186B23830")]
		public static void setPushTokenReceivedFromSystemDelegate(NBCEADBELNA FJGMDNCGEJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6B23770", Offset = "0x6B21F70", VA = "0x186B23770")]
		public static void setInAppMessageListener(BLPBKKCOPOD EDEDFNOKELH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x90A150", Offset = "0x908950", VA = "0x18090A150")]
		public BrazeInternalGameObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class BrazeInternalComponent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private HBGJFIIOOHM AGAJKJDFJGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private NBCEADBELNA MHLPBBAHOEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public BLPBKKCOPOD iamListener;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8E7480", Offset = "0x8E5C80", VA = "0x1808E7480")]
		public void setPushPromptResponseReceivedDelegate(HBGJFIIOOHM FJGMDNCGEJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8E74F0", Offset = "0x8E5CF0", VA = "0x1808E74F0")]
		public void setPushTokenReceivedFromSystemDelegate(NBCEADBELNA FJGMDNCGEJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6B23580", Offset = "0x6B21D80", VA = "0x186B23580")]
		public void onPushPromptResponseReceived(string CBFDMEHPMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6B23600", Offset = "0x6B21E00", VA = "0x186B23600")]
		public void onPushTokenReceivedFromSystem(string AMCDGOPKAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6B22DB0", Offset = "0x6B215B0", VA = "0x186B22DB0")]
		public void beforeInAppMessageDisplayed(string MIBBLHLHGLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6B23200", Offset = "0x6B21A00", VA = "0x186B23200")]
		public void onInAppMessageDismissed(string MIBBLHLHGLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6B23180", Offset = "0x6B21980", VA = "0x186B23180")]
		public void onInAppMessageClicked(string MIBBLHLHGLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6B22E30", Offset = "0x6B21630", VA = "0x186B22E30")]
		public void onInAppMessageButtonClicked(string HFAFLEIMOLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6B23280", Offset = "0x6B21A80", VA = "0x186B23280")]
		public void onInAppMessageHTMLClicked(string HFAFLEIMOLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x90A150", Offset = "0x908950", VA = "0x18090A150")]
		public BrazeInternalComponent()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class FNNLFCECNCG
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6B266E0", Offset = "0x6B24EE0", VA = "0x186B266E0")]
	public static Color? IJBGDJFNIEN(string BENAEDMNNOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6B26390", Offset = "0x6B24B90", VA = "0x186B26390")]
	public static Color IJBGDJFNIEN(int BENAEDMNNOM)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[DefaultMember("Item")]
public class ONCGADMPMIO
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public virtual ONCGADMPMIO ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8E4370", Offset = "0x8E2B70", VA = "0x1808E4370", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual ONCGADMPMIO ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8E4370", Offset = "0x8E2B70", VA = "0x1808E4370", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public virtual string PGHJLABHLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6B2E250", Offset = "0x6B2CA50", VA = "0x186B2E250", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public virtual int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8E4370", Offset = "0x8E2B70", VA = "0x1808E4370", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual int BMMHINAEKJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6B2EE30", Offset = "0x6B2D630", VA = "0x186B2EE30", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6B2EF10", Offset = "0x6B2D710", VA = "0x186B2EF10", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public virtual bool LOBKFAHADOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6B2E450", Offset = "0x6B2CC50", VA = "0x186B2E450", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6B2E510", Offset = "0x6B2CD10", VA = "0x186B2E510", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public virtual JCEGCNDJJKJ BKKOHPCEGEB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6B2E280", Offset = "0x6B2CA80", VA = "0x186B2E280", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public virtual OFJMHKDOHCO NGCCLOJNEBB
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6B2E590", Offset = "0x6B2CD90", VA = "0x186B2E590", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "4")]
	public virtual void GLILACFFLBJ(string HHOHNJPOPOI, ONCGADMPMIO HJEKCMMFNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E300", Offset = "0x6B2CB00", VA = "0x186B2E300", Slot = "10")]
	public virtual void GLILACFFLBJ(ONCGADMPMIO HJEKCMMFNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F0E0", Offset = "0x6B2D8E0", VA = "0x186B2F0E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E360", Offset = "0x6B2CB60", VA = "0x186B2E360")]
	public static ONCGADMPMIO HFMFJLJFEMO(string KFBMNNOPDNH)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E3C0", Offset = "0x6B2CBC0", VA = "0x186B2E3C0")]
	public static string HFMFJLJFEMO(ONCGADMPMIO LDDOOGFOLKL)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6B2EE70", Offset = "0x6B2D670", VA = "0x186B2EE70")]
	public static bool MJNLEMCBPOF(ONCGADMPMIO MBLAPCMEEGI, object NBEGIGNBOIE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E1B0", Offset = "0x6B2C9B0", VA = "0x186B2E1B0")]
	public static bool ACJEIIDJLOL(ONCGADMPMIO MBLAPCMEEGI, object NBEGIGNBOIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x8A8EA0", Offset = "0x8A76A0", VA = "0x1808A8EA0", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xFF8BB0", Offset = "0xFF73B0", VA = "0x180FF8BB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6B2EF50", Offset = "0x6B2D750", VA = "0x186B2EF50")]
	internal static string NFGDNLFOJEG(string IJAPEPBBOCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E610", Offset = "0x6B2CE10", VA = "0x186B2E610")]
	public static ONCGADMPMIO LFKDKCMHJMP(string BDJNIKFBCEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public ONCGADMPMIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DefaultMember("Item")]
public class JCEGCNDJJKJ : ONCGADMPMIO, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class NAIPCGKBCBB : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public JCEGCNDJJKJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private List<ONCGADMPMIO>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private ONCGADMPMIO <N>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
		[DebuggerHidden]
		public NAIPCGKBCBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6B2D610", Offset = "0x6B2BE10", VA = "0x186B2D610", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6B2D3E0", Offset = "0x6B2BBE0", VA = "0x186B2D3E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6B2D580", Offset = "0x6B2BD80", VA = "0x186B2D580")]
		private void PPLJHCFFCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6B2D5D0", Offset = "0x6B2BDD0", VA = "0x186B2D5D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<ONCGADMPMIO> GDJAPPKNMCF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override ONCGADMPMIO ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6B27C70", Offset = "0x6B26470", VA = "0x186B27C70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override ONCGADMPMIO ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6B27C10", Offset = "0x6B26410", VA = "0x186B27C10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public override int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6B27D80", Offset = "0x6B26580", VA = "0x186B27D80", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6B27D20", Offset = "0x6B26520", VA = "0x186B27D20", Slot = "4")]
	public override void GLILACFFLBJ(string HHOHNJPOPOI, ONCGADMPMIO HJEKCMMFNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6B27DC0", Offset = "0x6B265C0", VA = "0x186B27DC0", Slot = "17")]
	[IteratorStateMachine(typeof(NAIPCGKBCBB))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6B27E30", Offset = "0x6B26630", VA = "0x186B27E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6B27FD0", Offset = "0x6B267D0", VA = "0x186B27FD0")]
	public JCEGCNDJJKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public class OFJMHKDOHCO : ONCGADMPMIO, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class NKMMHHDIKAM : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public OFJMHKDOHCO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Dictionary<string, ONCGADMPMIO>.Enumerator <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private KeyValuePair<string, ONCGADMPMIO> <N>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xA2B190", Offset = "0xA29990", VA = "0x180A2B190")]
		[DebuggerHidden]
		public NKMMHHDIKAM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6B2D910", Offset = "0x6B2C110", VA = "0x186B2D910", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6B2D6A0", Offset = "0x6B2BEA0", VA = "0x186B2D6A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6B2D880", Offset = "0x6B2C080", VA = "0x186B2D880")]
		private void PPLJHCFFCFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6B2D8D0", Offset = "0x6B2C0D0", VA = "0x186B2D8D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<string, ONCGADMPMIO> FAHKCDMPLNK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override ONCGADMPMIO ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6B2D9B0", Offset = "0x6B2C1B0", VA = "0x186B2D9B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override ONCGADMPMIO ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6B2DA80", Offset = "0x6B2C280", VA = "0x186B2DA80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public override int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6B2DC70", Offset = "0x6B2C470", VA = "0x186B2DC70", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6B2DB30", Offset = "0x6B2C330", VA = "0x186B2DB30", Slot = "4")]
	public override void GLILACFFLBJ(string HHOHNJPOPOI, ONCGADMPMIO HJEKCMMFNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6B2DCC0", Offset = "0x6B2C4C0", VA = "0x186B2DCC0", Slot = "17")]
	[IteratorStateMachine(typeof(NKMMHHDIKAM))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6B2DD30", Offset = "0x6B2C530", VA = "0x186B2DD30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E130", Offset = "0x6B2C930", VA = "0x186B2E130")]
	public OFJMHKDOHCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ONJFCFOFDEG : ONCGADMPMIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private string NCDPDCCLPCA;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public override string PGHJLABHLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x979150", Offset = "0x977950", VA = "0x180979150", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x892CB0", Offset = "0x8914B0", VA = "0x180892CB0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8BA230", Offset = "0x8B8A30", VA = "0x1808BA230")]
	public ONJFCFOFDEG(string LBJOEONPBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F160", Offset = "0x6B2D960", VA = "0x186B2F160")]
	public ONJFCFOFDEG(bool LBJOEONPBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F1A0", Offset = "0x6B2D9A0", VA = "0x186B2F1A0")]
	public ONJFCFOFDEG(int LBJOEONPBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F110", Offset = "0x6B2D910", VA = "0x186B2F110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
internal class NAELCEHMHAA : ONCGADMPMIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private ONCGADMPMIO HLFPJBKKDGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private string FOGALDFFDFO;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public override ONCGADMPMIO ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6B2CCA0", Offset = "0x6B2B4A0", VA = "0x186B2CCA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override ONCGADMPMIO ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6B2CC30", Offset = "0x6B2B430", VA = "0x186B2CC30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override int BMMHINAEKJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6B2D1B0", Offset = "0x6B2B9B0", VA = "0x186B2D1B0", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6B2D270", Offset = "0x6B2BA70", VA = "0x186B2D270", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override bool LOBKFAHADOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6B2CF70", Offset = "0x6B2B770", VA = "0x186B2CF70", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6B2D030", Offset = "0x6B2B830", VA = "0x186B2D030", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override JCEGCNDJJKJ BKKOHPCEGEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6B2CD00", Offset = "0x6B2B500", VA = "0x186B2CD00", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public override OFJMHKDOHCO NGCCLOJNEBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6B2D100", Offset = "0x6B2B900", VA = "0x186B2D100", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x435FA70", Offset = "0x435E270", VA = "0x18435FA70")]
	public NAELCEHMHAA(ONCGADMPMIO IMPAKGCLMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x435FB00", Offset = "0x435E300", VA = "0x18435FB00")]
	public NAELCEHMHAA(ONCGADMPMIO IMPAKGCLMCJ, string HHOHNJPOPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D340", Offset = "0x6B2BB40", VA = "0x186B2D340")]
	private void OLFLGMGEIBD(ONCGADMPMIO IBCNLMOLIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6B2CEA0", Offset = "0x6B2B6A0", VA = "0x186B2CEA0", Slot = "10")]
	public override void GLILACFFLBJ(ONCGADMPMIO HJEKCMMFNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6B2CDB0", Offset = "0x6B2B5B0", VA = "0x186B2CDB0", Slot = "4")]
	public override void GLILACFFLBJ(string HHOHNJPOPOI, ONCGADMPMIO HJEKCMMFNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x435F840", Offset = "0x435E040", VA = "0x18435F840", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xFF8BB0", Offset = "0xFF73B0", VA = "0x180FF8BB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D3B0", Offset = "0x6B2BBB0", VA = "0x186B2D3B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class NNEEBIMNOII
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x6B2D9A0", Offset = "0x6B2C1A0", VA = "0x186B2D9A0")]
	public static ONCGADMPMIO LFKDKCMHJMP(string BDJNIKFBCEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FNFBOMFOCCO
{
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x6B26300", Offset = "0x6B24B00", VA = "0x186B26300")]
	public static object GKFFIOHEPOP(Type ONNPCDLPJIC, string MENBIMCLIOI, bool GBPNEDBJLHI, object GFJIAKNDNMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FOMMHAOANEE
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x6B26850", Offset = "0x6B25050", VA = "0x186B26850")]
	public static Dictionary<string, string> PHGDCCGNOMA(OFJMHKDOHCO HPHNHGOPBJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PDHDKBFDDFM
{
	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6B30A50", Offset = "0x6B2F250", VA = "0x186B30A50")]
	public static string GEMJKMILLDO(Dictionary<string, string> DFAKGEGFEID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x22F6F00", Offset = "0x22F5700", VA = "0x1822F6F00")]
	public static string AOIOBLDBKIO<T>(List<T> DFMKDLJIHMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum LCIJEGGOPEM
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
public enum KCJJDPDMPFG
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	TOP,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	BOTTOM
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CPDINNCNEMC
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public string NDGPAEIOKDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x892CB0", Offset = "0x8914B0", VA = "0x180892CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string GCADHJIJHOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8E7480", Offset = "0x8E5C80", VA = "0x1808E7480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public string OEPJCDGEAPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8E74F0", Offset = "0x8E5CF0", VA = "0x1808E74F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public Dictionary<string, string> FEIABICBOFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F80", Offset = "0x8A4780", VA = "0x1808A5F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8A97C0", Offset = "0x8A7FC0", VA = "0x1808A97C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public int PNNAKPKMIDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8E8B70", Offset = "0x8E7370", VA = "0x1808E8B70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xBBF230", Offset = "0xBBDA30", VA = "0x180BBF230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public long FMFFLLAKIIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7ED740", Offset = "0x7EBF40", VA = "0x1807ED740")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xD016D0", Offset = "0xCFFED0", VA = "0x180D016D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public string GDMLNAANKEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8A69F0", Offset = "0x8A51F0", VA = "0x1808A69F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA744F0", Offset = "0xA72CF0", VA = "0x180A744F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6B24AC0", Offset = "0x6B232C0", VA = "0x186B24AC0")]
	public CPDINNCNEMC(string AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x6B24770", Offset = "0x6B22F70", VA = "0x186B24770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x6B24610", Offset = "0x6B22E10", VA = "0x186B24610")]
	private string KEFNGOHNELJ(OFJMHKDOHCO HPHNHGOPBJH, string EECINICJCLK, string GFJIAKNDNMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6B242B0", Offset = "0x6B22AB0", VA = "0x186B242B0")]
	private int ADINPCPGKPI(OFJMHKDOHCO HPHNHGOPBJH, string EECINICJCLK, int GFJIAKNDNMH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6B24460", Offset = "0x6B22C60", VA = "0x186B24460")]
	private long EBGGFNEOHBE(OFJMHKDOHCO HPHNHGOPBJH, string EECINICJCLK, long GFJIAKNDNMH)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JNEDHPDKCIK
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public List<GGICNNKMELI> HNOILLMPCBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x892CB0", Offset = "0x8914B0", VA = "0x180892CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool CCHCDAADKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA3F030", Offset = "0xA3D830", VA = "0x180A3F030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6B282B0", Offset = "0x6B26AB0", VA = "0x186B282B0")]
	public JNEDHPDKCIK(string AKADEFDGONP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6B28050", Offset = "0x6B26850", VA = "0x186B28050")]
	private static GGICNNKMELI JAIIOGJJCMN(OFJMHKDOHCO HPHNHGOPBJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class CJMPKJICHCM
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IList<string> AIDHFCIHDJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x892CB0", Offset = "0x8914B0", VA = "0x180892CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public string OFHIFCBJKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8E7480", Offset = "0x8E5C80", VA = "0x1808E7480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string BNHOCFOHIMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8E74F0", Offset = "0x8E5CF0", VA = "0x1808E74F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string IINCDOBLHBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F80", Offset = "0x8A4780", VA = "0x1808A5F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8A97C0", Offset = "0x8A7FC0", VA = "0x1808A97C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string LEGFNANFMDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x95DB30", Offset = "0x95C330", VA = "0x18095DB30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6B23CB0", Offset = "0x6B224B0", VA = "0x186B23CB0")]
	public CJMPKJICHCM(OFJMHKDOHCO HPHNHGOPBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6B23890", Offset = "0x6B22090", VA = "0x186B23890", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum JFONFHOGNOB
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	AUTO_DISMISS,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	SWIPE
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KMDBFPJOGAN
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public CJMPKJICHCM JLMMEPKCLHB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x892CB0", Offset = "0x8914B0", VA = "0x180892CB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int LILOLCKIHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x90BAA0", Offset = "0x90A2A0", VA = "0x18090BAA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x979F40", Offset = "0x978740", VA = "0x180979F40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public string IAJGOPDJFBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8E74F0", Offset = "0x8E5CF0", VA = "0x1808E74F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NLHLEPNDDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xBCC350", Offset = "0xBCAB50", VA = "0x180BCC350")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xBCC380", Offset = "0xBCAB80", VA = "0x180BCC380")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IDictionary<string, object> HNIJFGLJDAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x95DB30", Offset = "0x95C330", VA = "0x18095DB30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6B2A690", Offset = "0x6B28E90", VA = "0x186B2A690")]
	public KMDBFPJOGAN(OFJMHKDOHCO HPHNHGOPBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6B29910", Offset = "0x6B28110", VA = "0x186B29910")]
	private object MABIJMDCBLI(ONCGADMPMIO LJMPFLMBPKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6B29FB0", Offset = "0x6B287B0", VA = "0x186B29FB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum CEEKMNOONKG
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	OPTED_IN,
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	SUBSCRIBED,
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	UNSUBSCRIBED
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public enum HHBLAHBPCKK
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
public enum DEJIPBMKNMN
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	NEWS_FEED,
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	URI,
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	NONE
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class ACEEHELBCCD : GGICNNKMELI
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string DBIGMCIKBFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7ED770", Offset = "0x7EBF70", VA = "0x1807ED770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7ED750", Offset = "0x7EBF50", VA = "0x1807ED750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public string BOMJBNKGJNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8A9ED0", Offset = "0x8A86D0", VA = "0x1808A9ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B28E0", Offset = "0x8B10E0", VA = "0x1808B28E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string BGBLFOOHPLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EE0", Offset = "0x8A86E0", VA = "0x1808A9EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EF0", Offset = "0x8A86F0", VA = "0x1808A9EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6B20F70", Offset = "0x6B1F770", VA = "0x186B20F70")]
	public ACEEHELBCCD(OFJMHKDOHCO HPHNHGOPBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6B20D80", Offset = "0x6B1F580", VA = "0x186B20D80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KBIHIDFDNDD : GGICNNKMELI
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public string DBIGMCIKBFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7ED770", Offset = "0x7EBF70", VA = "0x1807ED770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7ED750", Offset = "0x7EBF50", VA = "0x1807ED750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public string GCADHJIJHOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8A9ED0", Offset = "0x8A86D0", VA = "0x1808A9ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8B28E0", Offset = "0x8B10E0", VA = "0x1808B28E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string LKIEICODGFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EE0", Offset = "0x8A86E0", VA = "0x1808A9EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EF0", Offset = "0x8A86F0", VA = "0x1808A9EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string BOMJBNKGJNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8E9050", Offset = "0x8E7850", VA = "0x1808E9050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFC0", Offset = "0x8E97C0", VA = "0x1808EAFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public string BGBLFOOHPLH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8E8B60", Offset = "0x8E7360", VA = "0x1808E8B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x939750", Offset = "0x937F50", VA = "0x180939750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6B29300", Offset = "0x6B27B00", VA = "0x186B29300")]
	public KBIHIDFDNDD(OFJMHKDOHCO HPHNHGOPBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6B29050", Offset = "0x6B27850", VA = "0x186B29050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class DGKABKEIABM : GGICNNKMELI
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string GCADHJIJHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7ED770", Offset = "0x7EBF70", VA = "0x1807ED770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7ED750", Offset = "0x7EBF50", VA = "0x1807ED750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string LKIEICODGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8A9ED0", Offset = "0x8A86D0", VA = "0x1808A9ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8B28E0", Offset = "0x8B10E0", VA = "0x1808B28E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string BOMJBNKGJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EE0", Offset = "0x8A86E0", VA = "0x1808A9EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EF0", Offset = "0x8A86F0", VA = "0x1808A9EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public string BGBLFOOHPLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8E9050", Offset = "0x8E7850", VA = "0x1808E9050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFC0", Offset = "0x8E97C0", VA = "0x1808EAFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6B250F0", Offset = "0x6B238F0", VA = "0x186B250F0")]
	public DGKABKEIABM(OFJMHKDOHCO HPHNHGOPBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6B24EA0", Offset = "0x6B236A0", VA = "0x186B24EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class KANLBEDCCON : GGICNNKMELI
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public string LKIEICODGFB
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7ED770", Offset = "0x7EBF70", VA = "0x1807ED770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7ED750", Offset = "0x7EBF50", VA = "0x1807ED750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string DBIGMCIKBFK
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9ED0", Offset = "0x8A86D0", VA = "0x1808A9ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x8B28E0", Offset = "0x8B10E0", VA = "0x1808B28E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string GCADHJIJHOM
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EE0", Offset = "0x8A86E0", VA = "0x1808A9EE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EF0", Offset = "0x8A86F0", VA = "0x1808A9EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string BOMJBNKGJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8E9050", Offset = "0x8E7850", VA = "0x1808E9050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFC0", Offset = "0x8E97C0", VA = "0x1808EAFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string BGBLFOOHPLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8E8B60", Offset = "0x8E7360", VA = "0x1808E8B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x939750", Offset = "0x937F50", VA = "0x180939750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6B28AC0", Offset = "0x6B272C0", VA = "0x186B28AC0")]
	public KANLBEDCCON(OFJMHKDOHCO HPHNHGOPBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6B28810", Offset = "0x6B27010", VA = "0x186B28810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class GGICNNKMELI
{
	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string ADNPGIMLOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x892CB0", Offset = "0x8914B0", VA = "0x180892CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string ILFDEIBDFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8E7480", Offset = "0x8E5C80", VA = "0x1808E7480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool CDDBAFHPDAB
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA976F0", VA = "0x180A98EF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA991D0", Offset = "0xA979D0", VA = "0x180A991D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public long PBOAHKPEFJC
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F80", Offset = "0x8A4780", VA = "0x1808A5F80")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xAE54D0", Offset = "0xAE3CD0", VA = "0x180AE54D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public long IEGHALBCBJF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8E7510", Offset = "0x8E5D10", VA = "0x1808E7510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public HashSet<LCIJEGGOPEM> OIHMIPHGOLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7ED740", Offset = "0x7EBF40", VA = "0x1807ED740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7ED730", Offset = "0x7EBF30", VA = "0x1807ED730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private string OPKKBMCBNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA744F0", Offset = "0xA72CF0", VA = "0x180A744F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Dictionary<string, string> FEIABICBOFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCD0", Offset = "0x7DE4D0", VA = "0x1807DFCD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7ED760", Offset = "0x7EBF60", VA = "0x1807ED760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6B271A0", Offset = "0x6B259A0", VA = "0x186B271A0")]
	public GGICNNKMELI(OFJMHKDOHCO HPHNHGOPBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6B26DB0", Offset = "0x6B255B0", VA = "0x186B26DB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6B26BA0", Offset = "0x6B253A0", VA = "0x186B26BA0")]
	public string CFDDJKPNHPP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class LMKNPEOOINF
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string ADNPGIMLOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7DF170", Offset = "0x7DD970", VA = "0x1807DF170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x892CB0", Offset = "0x8914B0", VA = "0x180892CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string ILFDEIBDFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x8E7480", Offset = "0x8E5C80", VA = "0x1808E7480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool CDDBAFHPDAB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA976F0", VA = "0x180A98EF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA991D0", Offset = "0xA979D0", VA = "0x180A991D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public long PBOAHKPEFJC
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F80", Offset = "0x8A4780", VA = "0x1808A5F80")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAE54D0", Offset = "0xAE3CD0", VA = "0x180AE54D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public long POOBMBIBLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8E7510", Offset = "0x8E5D10", VA = "0x1808E7510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string DBIGMCIKBFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7ED740", Offset = "0x7EBF40", VA = "0x1807ED740")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7ED730", Offset = "0x7EBF30", VA = "0x1807ED730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string GCADHJIJHOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8A69F0", Offset = "0x8A51F0", VA = "0x1808A69F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xA744F0", Offset = "0xA72CF0", VA = "0x180A744F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string LKIEICODGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCD0", Offset = "0x7DE4D0", VA = "0x1807DFCD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7ED760", Offset = "0x7EBF60", VA = "0x1807ED760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string BOMJBNKGJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7ED770", Offset = "0x7EBF70", VA = "0x1807ED770")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7ED750", Offset = "0x7EBF50", VA = "0x1807ED750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string BGBLFOOHPLH
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8A9ED0", Offset = "0x8A86D0", VA = "0x1808A9ED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8B28E0", Offset = "0x8B10E0", VA = "0x1808B28E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool NIJHJGPOCNC
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7EBC00", Offset = "0x7EA400", VA = "0x1807EBC00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x937C60", Offset = "0x936460", VA = "0x180937C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool ENMFOMGOCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xECB790", Offset = "0xEC9F90", VA = "0x180ECB790")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xECA850", Offset = "0xEC9050", VA = "0x180ECA850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool GCMECMPOFIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x10FCC10", Offset = "0x10FB410", VA = "0x1810FCC10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x6B2ADC0", Offset = "0x6B295C0", VA = "0x186B2ADC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool IINJJONHFNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x10FCCD0", Offset = "0x10FB4D0", VA = "0x1810FCCD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6B2AC50", Offset = "0x6B29450", VA = "0x186B2AC50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool CJEBEJLHHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xC61D40", Offset = "0xC60540", VA = "0x180C61D40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x281AA50", Offset = "0x2819250", VA = "0x18281AA50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public string OPKKBMCBNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x8E9050", Offset = "0x8E7850", VA = "0x1808E9050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8EAFC0", Offset = "0x8E97C0", VA = "0x1808EAFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Dictionary<string, string> FEIABICBOFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8E8B60", Offset = "0x8E7360", VA = "0x1808E8B60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x939750", Offset = "0x937F50", VA = "0x180939750")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6B2B570", Offset = "0x6B29D70", VA = "0x186B2B570")]
	public LMKNPEOOINF(OFJMHKDOHCO HPHNHGOPBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6B2ADD0", Offset = "0x6B295D0", VA = "0x186B2ADD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6B2AD10", Offset = "0x6B29510", VA = "0x186B2AD10")]
	public void GEFHGGIBHAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6B2AC60", Offset = "0x6B29460", VA = "0x186B2AC60")]
	public void DJCMDGMEHKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AAMDEINGMMF : MFJLEJMHDLN
{
	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6B20D70", Offset = "0x6B1F570", VA = "0x186B20D70")]
	public AAMDEINGMMF(OFJMHKDOHCO HPHNHGOPBJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class MFJLEJMHDLN : PAIKJPPAICK, MMOEIIOMLJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private bool FKLOMLHAJEO;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string NABIEFKAMNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA52590", Offset = "0xA50D90", VA = "0x180A52590", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xBBFF70", Offset = "0xBBE770", VA = "0x180BBFF70", Slot = "28")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Color? EFJKCPLMECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2014FE0", Offset = "0x20137E0", VA = "0x182014FE0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6B2BF40", Offset = "0x6B2A740", VA = "0x186B2BF40", Slot = "30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Color? ABJOIAFHAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6B2BF60", Offset = "0x6B2A760", VA = "0x186B2BF60", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6B2BF80", Offset = "0x6B2A780", VA = "0x186B2BF80", Slot = "32")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public List<FKACLANNGJM> ANDHAFLJLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x91A030", Offset = "0x918830", VA = "0x18091A030", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xAEAE70", Offset = "0xAE9670", VA = "0x180AEAE70", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6B2BFA0", Offset = "0x6B2A7A0", VA = "0x186B2BFA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6B2C270", Offset = "0x6B2AA70", VA = "0x186B2C270")]
	public MFJLEJMHDLN(OFJMHKDOHCO HPHNHGOPBJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class FKACLANNGJM
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int HPEKHHPLFLH
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x7DF240", Offset = "0x7DDA40", VA = "0x1807DF240")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xBE1D20", Offset = "0xBE0520", VA = "0x180BE1D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string ECMDAFNLHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x8E7480", Offset = "0x8E5C80", VA = "0x1808E7480")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public string GMOPIHGLNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x8E74F0", Offset = "0x8E5CF0", VA = "0x1808E74F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public DEJIPBMKNMN HDMMAPKBGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xBCC350", Offset = "0xBCAB50", VA = "0x180BCC350")]
		[CompilerGenerated]
		get
		{
			return default(DEJIPBMKNMN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xBCC380", Offset = "0xBCAB80", VA = "0x180BCC380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public Color? PKACLJDKHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6B25720", Offset = "0x6B23F20", VA = "0x186B25720")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6B25740", Offset = "0x6B23F40", VA = "0x186B25740")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public Color? JFKHKNCKOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2F4B860", Offset = "0x2F4A060", VA = "0x182F4B860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2F4B850", Offset = "0x2F4A050", VA = "0x182F4B850")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6B25750", Offset = "0x6B23F50", VA = "0x186B25750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6B25A80", Offset = "0x6B24280", VA = "0x186B25A80")]
	public FKACLANNGJM(OFJMHKDOHCO HPHNHGOPBJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface BPHHBFCDHIE
{
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface MMOEIIOMLJH
{
	[Cpp2IlInjected.Token(Token = "0x17000064")]
	List<FKACLANNGJM> ANDHAFLJLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class JEIGEALFJML : MFJLEJMHDLN
{
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6B20D70", Offset = "0x6B1F570", VA = "0x186B20D70")]
	public JEIGEALFJML(OFJMHKDOHCO HPHNHGOPBJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class PLIPPKPLNLJ
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6B30CB0", Offset = "0x6B2F4B0", VA = "0x186B30CB0")]
	public static BPHHBFCDHIE NJHMMLKCAAD(string PPPAGKAGHFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public enum CLFGJEIEBLI
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	FULL,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	MODAL,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	SLIDEUP
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class EKGJBMOMIPL
{
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6B255C0", Offset = "0x6B23DC0", VA = "0x186B255C0")]
	public static OFJMHKDOHCO GIFPNKPNOCP(string FFMCADGELNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class POOJBCNOCJC : PAIKJPPAICK
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public KCJJDPDMPFG NOHMDIFJDJE
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF2C0", Offset = "0x8ADAC0", VA = "0x1808AF2C0")]
		[CompilerGenerated]
		get
		{
			return default(KCJJDPDMPFG);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x297BD50", Offset = "0x297A550", VA = "0x18297BD50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool JFIEHMIOHFI
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x1288160", Offset = "0x1286960", VA = "0x181288160")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x1288170", Offset = "0x1286970", VA = "0x181288170")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public Color? KKFOENHJDIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6B30F80", Offset = "0x6B2F780", VA = "0x186B30F80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x6B30F60", Offset = "0x6B2F760", VA = "0x186B30F60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6B30FA0", Offset = "0x6B2F7A0", VA = "0x186B30FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6B31210", Offset = "0x6B2FA10", VA = "0x186B31210")]
	public POOJBCNOCJC(OFJMHKDOHCO HPHNHGOPBJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class PAIKJPPAICK : BPHHBFCDHIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	protected string BHOMGCDPHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool PIPCHKEPJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool PLGLDNGBLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int BELHPKAJNOC;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Color? JFKHKNCKOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xBB02A0", Offset = "0xBAEAA0", VA = "0x180BB02A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xFCA1E0", Offset = "0xFC89E0", VA = "0x180FCA1E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Color? PKACLJDKHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6B2F1F0", Offset = "0x6B2D9F0", VA = "0x186B2F1F0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6B2F260", Offset = "0x6B2DA60", VA = "0x186B2F260", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public string CCGMHIHLELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCD0", Offset = "0x7DE4D0", VA = "0x1807DFCD0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7ED760", Offset = "0x7EBF60", VA = "0x1807ED760", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Color? PJAAKLIFBBF
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x2388CF0", Offset = "0x23874F0", VA = "0x182388CF0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x2388F50", Offset = "0x2387750", VA = "0x182388F50", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public Color? OGMBPFNDCEE
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6B2F240", Offset = "0x6B2DA40", VA = "0x186B2F240", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6B2F1E0", Offset = "0x6B2D9E0", VA = "0x186B2F1E0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public string FCPGLIEKLDK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD00", Offset = "0x7DE500", VA = "0x1807DFD00", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xB3AA20", Offset = "0xB39220", VA = "0x180B3AA20", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public string LLPPEEKFHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7DFCF0", Offset = "0x7DE4F0", VA = "0x1807DFCF0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0xB39D50", Offset = "0xB38550", VA = "0x180B39D50", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public Dictionary<string, string> FEIABICBOFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA51D10", Offset = "0xA50510", VA = "0x180A51D10", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xA582E0", Offset = "0xA56AE0", VA = "0x180A582E0", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public DEJIPBMKNMN GKEPCFEGCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xCE91C0", Offset = "0xCE79C0", VA = "0x180CE91C0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(DEJIPBMKNMN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xE84910", Offset = "0xE83110", VA = "0x180E84910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public string GMOPIHGLNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7F0CD0", Offset = "0x7EF4D0", VA = "0x1807F0CD0", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7F0C70", Offset = "0x7EF470", VA = "0x1807F0C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public JFONFHOGNOB KFBLPDOIJFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xD93FC0", Offset = "0xD927C0", VA = "0x180D93FC0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(JFONFHOGNOB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xD95440", Offset = "0xD93C40", VA = "0x180D95440", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int HKHHCGJBOLH
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xF3A700", Offset = "0xF38F00", VA = "0x180F3A700", Slot = "24")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6B2F210", Offset = "0x6B2DA10", VA = "0x186B2F210", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F270", Offset = "0x6B2DA70", VA = "0x186B2F270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F8E0", Offset = "0x6B2E0E0", VA = "0x186B2F8E0")]
	public PAIKJPPAICK(OFJMHKDOHCO HPHNHGOPBJH)
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
