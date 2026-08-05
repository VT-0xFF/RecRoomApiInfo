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
public interface FJLKBDCGJNH
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ApplePushNotificationTester : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x771910", Offset = "0x770510", VA = "0x180771910")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7713B0", Offset = "0x76FFB0", VA = "0x1807713B0")]
	public string PrintOutObjectValues(object HHPJDGEICAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x771300", Offset = "0x76FF00", VA = "0x180771300")]
	public ApplePushNotificationTester()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum MANJCFLGOEF
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
public enum KAGAJHMNMKJ
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	IAM_DISPLAY_NOW,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	IAM_DISPLAY_LATER,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	IAM_DISCARD
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void AKENKJKDMPK(bool OLLPKPMIPCF);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void BPBALJIHIIA(string KJCAGLABEME);
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AppboyBinding : SingletonMonoBehaviour<AppboyBinding>
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static FJLKBDCGJNH HIGMACJEBNP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static FJLKBDCGJNH BJPEIIFMILD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x771370", Offset = "0x76FF70", VA = "0x180771370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static OOBBMILCMFF EDDMMBAOGHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x771320", Offset = "0x76FF20", VA = "0x180771320")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void LogCustomEvent(string EGBBEOKJLOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void LogCustomEvent(string EGBBEOKJLOC, Dictionary<string, object> ACGMLGMLLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void LogPurchase(string HBBCMCBGNIG, string PGEELNDHOPO, decimal GGEOOMNPPCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void LogPurchase(string HBBCMCBGNIG, string PGEELNDHOPO, decimal GGEOOMNPPCH, int HECECHIOFNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void LogPurchase(string HBBCMCBGNIG, string PGEELNDHOPO, decimal GGEOOMNPPCH, int HECECHIOFNI, Dictionary<string, object> ACGMLGMLLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void ChangeUser(string NLBKPHJJHIA, [Optional] string GBALFOMIFKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetSdkAuthenticationSignature(string GBALFOMIFKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetUserFirstName(string IEHGLCJBCEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetUserLastName(string OPABEDFDGBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetUserEmail(string GOMIPBFIEFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetUserGender(JGLPHGLOJLK CMHDEJBDGHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetUserDateOfBirth(int EPGGBDLBJCB, int ILOOBAJFAJG, int OAEKKMKBOAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetUserCountry(string BMPGIHALLMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetUserHomeCity(string KMDHIGNMAIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetUserEmailNotificationSubscriptionType(DKGCPDFHHOO BINNOHPGGCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetUserPushNotificationSubscriptionType(DKGCPDFHHOO KDPICINFFJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetUserPhoneNumber(string KEBPEIKGJIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetCustomUserAttribute(string PPNDANAOAMK, bool GCPEEAODAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetCustomUserAttribute(string PPNDANAOAMK, int GCPEEAODAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetCustomUserAttribute(string PPNDANAOAMK, float GCPEEAODAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetCustomUserAttribute(string PPNDANAOAMK, string GCPEEAODAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetCustomUserAttributeToNow(string PPNDANAOAMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetCustomUserAttributeToSecondsFromEpoch(string PPNDANAOAMK, long DFBMFENFBLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void UnsetCustomUserAttribute(string PPNDANAOAMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void IncrementCustomUserAttribute(string PPNDANAOAMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void IncrementCustomUserAttribute(string PPNDANAOAMK, int OGIMMMEIEOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetCustomUserAttributeArray(string PPNDANAOAMK, List<string> DAJPKFPFPMI, int JIGGJNDJAAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void AddToCustomUserAttributeArray(string PPNDANAOAMK, string GCPEEAODAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void RemoveFromCustomUserAttributeArray(string PPNDANAOAMK, string GCPEEAODAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void setUserFacebookData(string OCIGLMJDFLE, string IEHGLCJBCEM, string OPABEDFDGBI, string GOMIPBFIEFA, string IJCPBJLIGAB, string CDPEGMPEEPM, JGLPHGLOJLK? CMHDEJBDGHD, int? BINIFJCNBMO, string HEKGFPEAHNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void setUserTwitterData(int? LCGLIJCAEIN, string JDHDAJKOFHB, string JEICAPDKHKI, string BKAHLJMONND, int? NHJACGAJHGI, int? LENBBJPMCPH, int? BMJFOJGEBDL, string GGEICILMBNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetUserLastKnownLocation(double AIOKIJIHJBN, double FODDCHONFCM, [Optional] double? INMHNGLLGNJ, [Optional] double? MKJOEIJIEGN, [Optional] double? OJLONJBFLDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void PromptUserForPushPermissions(bool DABFEEJGDOA, [Optional] AKENKJKDMPK PPLLHJLJMIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetPushTokenReceivedFromSystemDelegate(BPBALJIHIIA JGNLHEGOPNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void LogInAppMessageClicked(string NOBKEIBGLKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void LogInAppMessageImpression(string NOBKEIBGLKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void LogInAppMessageButtonClicked(string NOBKEIBGLKI, int LLHLMEBEKEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void RequestFeedRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void RequestFeedRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void LogFeedDisplayed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void RequestContentCardsRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void RequestContentCardsRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void LogContentCardClicked(string MMGDDDOIOBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void LogContentCardImpression(string MMGDDDOIOBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void LogContentCardDismissed(string MMGDDDOIOBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void WipeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void EnableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void DisableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x771320", Offset = "0x76FF20", VA = "0x180771320")]
		public static string GetInstallTrackingId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetAttributionData(string PBMNPBHMJKG, string MLODDMENPCK, string MNPHNOJGPNE, string FHFLCEFOPAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void RequestLocationInitialization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void RequestGeofences(decimal AIOKIJIHJBN, decimal FODDCHONFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void RequestImmediateDataFlush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void AddAlias(string KJHFMPJGCGL, string BBODCMJFAEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void ConfigureListener(MANJCFLGOEF DJFEPCFLBLG, string OLPGHELLLJC, string OLBMKOEFGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void SetInAppMessageDisplayAction(KAGAJHMNMKJ MBOIEMIEAEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void DisplayNextInAppMessage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void DisplayContentCards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void AddToSubscriptionGroup(string HLINMGJJNHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310")]
		public static void RemoveFromSubscriptionGroup(string HLINMGJJNHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x771330", Offset = "0x76FF30", VA = "0x180771330")]
		public AppboyBinding()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class OOBBMILCMFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Action<JINBHNNNCMG> HENNBNPDELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Action<JINBHNNNCMG> PPBOBBHLFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Action<JINBHNNNCMG> HIEAFGJGJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Action<JINBHNNNCMG, NIIIBBAOHID> GKBAHEKIBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public Action<JINBHNNNCMG, Uri> CEMBPNLCIHM;
}
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AppboyBindingTester : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x771280", Offset = "0x76FE80", VA = "0x180771280")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x770D40", Offset = "0x76F940", VA = "0x180770D40")]
		private void JJHEGOPDHFH(string EOOPGFAEMIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x771100", Offset = "0x76FD00", VA = "0x180771100")]
		private void PDOJCBLPNDB(string EOOPGFAEMIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7706E0", Offset = "0x76F2E0", VA = "0x1807706E0")]
		private void CPLJKIBLFCB(string EOOPGFAEMIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x771170", Offset = "0x76FD70", VA = "0x180771170")]
		private void PMFHHDFMBDM(string EOOPGFAEMIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x770E90", Offset = "0x76FA90", VA = "0x180770E90")]
		private void NDGNMAIKKCP(string EOOPGFAEMIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x770FA0", Offset = "0x76FBA0", VA = "0x180770FA0")]
		private void OILOMKMDGFG(string EOOPGFAEMIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x770750", Offset = "0x76F350", VA = "0x180770750")]
		private void IAHKOLHEJGK(string EOOPGFAEMIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7708B0", Offset = "0x76F4B0", VA = "0x1807708B0")]
		private void IJDCKDDCEJB(string EOOPGFAEMIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7702A0", Offset = "0x76EEA0", VA = "0x1807702A0")]
		private void CDMCHNFMDPA(string EOOPGFAEMIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x770E20", Offset = "0x76FA20", VA = "0x180770E20")]
		private void LGBFOMPFMNJ(string EOOPGFAEMIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x770AF0", Offset = "0x76F6F0", VA = "0x180770AF0")]
		public static void InAppMessageBeforeDisplayed(JINBHNNNCMG EOOPGFAEMIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x770C50", Offset = "0x76F850", VA = "0x180770C50")]
		public static void InAppMessageDismissed(JINBHNNNCMG EOOPGFAEMIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x770BE0", Offset = "0x76F7E0", VA = "0x180770BE0")]
		public static void InAppMessageClicked(JINBHNNNCMG EOOPGFAEMIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x770B60", Offset = "0x76F760", VA = "0x180770B60")]
		public static void InAppMessageButtonClicked(JINBHNNNCMG EOOPGFAEMIH, NIIIBBAOHID BALPLFBBBPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x770CC0", Offset = "0x76F8C0", VA = "0x180770CC0")]
		public static void InAppMessageHTMLClicked(JINBHNNNCMG EOOPGFAEMIH, Uri IDJJNANLPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x771300", Offset = "0x76FF00", VA = "0x180771300")]
		public AppboyBindingTester()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class PJMAIKPFEEF
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x780260", Offset = "0x77EE60", VA = "0x180780260")]
	public static string PEGHEEPHCHC(Dictionary<string, string> AHCKPBMADJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2664E20", Offset = "0x2663A20", VA = "0x182664E20")]
	public static string FBKMOIACGPB<T>(List<T> ALFGCABNDNK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JJLDGKOLLEN
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x77B220", Offset = "0x779E20", VA = "0x18077B220")]
	public static Color? LPEJCMEFPOK(string CNFLEMDDGDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x77B370", Offset = "0x779F70", VA = "0x18077B370")]
	public static Color LPEJCMEFPOK(int CNFLEMDDGDH)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GONDGBOCLOG
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x77A370", Offset = "0x778F70", VA = "0x18077A370")]
	public static object OKKJCKINLCN(Type OMDPEHNEHJH, string GCPEEAODAIB, bool NMFHABCDJKE, object MLNCHKABKBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KALIMKPHPGN
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x77B660", Offset = "0x77A260", VA = "0x18077B660")]
	public static Dictionary<string, string> GCPCEHLIHED(FHAJHPHNCHA MFADGLMMHMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[DefaultMember("Item")]
public class BHDGELBFLHM
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public virtual BHDGELBFLHM NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x771320", Offset = "0x76FF20", VA = "0x180771320", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public virtual BHDGELBFLHM NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x771320", Offset = "0x76FF20", VA = "0x180771320", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual string GMFAJOGMKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x772D30", Offset = "0x771930", VA = "0x180772D30", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public virtual int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x771320", Offset = "0x76FF20", VA = "0x180771320", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public virtual int FELLNLDEJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x772240", Offset = "0x770E40", VA = "0x180772240", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x773170", Offset = "0x771D70", VA = "0x180773170", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual bool LBGEABCIMEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x772BF0", Offset = "0x7717F0", VA = "0x180772BF0", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x772280", Offset = "0x770E80", VA = "0x180772280", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public virtual BCHCMJLNENJ FOBIKNMBFFD
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x772CB0", Offset = "0x7718B0", VA = "0x180772CB0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public virtual FHAJHPHNCHA ENMAOBKGJCA
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x772300", Offset = "0x770F00", VA = "0x180772300", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x771310", Offset = "0x76FF10", VA = "0x180771310", Slot = "4")]
	public virtual void HFMDKEOMMOI(string IILINHFKIII, BHDGELBFLHM CLAHEHIMHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x772D70", Offset = "0x771970", VA = "0x180772D70", Slot = "10")]
	public virtual void HFMDKEOMMOI(BHDGELBFLHM CLAHEHIMHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7731B0", Offset = "0x771DB0", VA = "0x1807731B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x773000", Offset = "0x771C00", VA = "0x180773000")]
	public static BHDGELBFLHM JLFJLFEACJM(string HJMPOPKEFMK)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x773070", Offset = "0x771C70", VA = "0x180773070")]
	public static string JLFJLFEACJM(BHDGELBFLHM DKFOONILOPO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7730F0", Offset = "0x771CF0", VA = "0x1807730F0")]
	public static bool JONBIHPGCCI(BHDGELBFLHM FLGIINLNNEM, object KNDAEONALIC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x772F80", Offset = "0x771B80", VA = "0x180772F80")]
	public static bool JBDELPGDOBO(BHDGELBFLHM FLGIINLNNEM, object KNDAEONALIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x772CA0", Offset = "0x7718A0", VA = "0x180772CA0", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x772D60", Offset = "0x771960", VA = "0x180772D60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x772DD0", Offset = "0x7719D0", VA = "0x180772DD0")]
	internal static string HNNJKDJGEMA(string ENJPEDOOFDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x772380", Offset = "0x770F80", VA = "0x180772380")]
	public static BHDGELBFLHM EJCEEDCGPOP(string JGANDDAHPOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
	public BHDGELBFLHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[DefaultMember("Item")]
public class BCHCMJLNENJ : BHDGELBFLHM, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private sealed class GEPHJLBJOEP : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public BCHCMJLNENJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<BHDGELBFLHM>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public GEPHJLBJOEP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x779AF0", Offset = "0x7786F0", VA = "0x180779AF0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7798F0", Offset = "0x7784F0", VA = "0x1807798F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7798A0", Offset = "0x7784A0", VA = "0x1807798A0")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x779AA0", Offset = "0x7786A0", VA = "0x180779AA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<BHDGELBFLHM> IBNCAAELMDB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override BHDGELBFLHM NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x771D80", Offset = "0x770980", VA = "0x180771D80", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override BHDGELBFLHM NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x771E50", Offset = "0x770A50", VA = "0x180771E50", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x771ED0", Offset = "0x770AD0", VA = "0x180771ED0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x771F90", Offset = "0x770B90", VA = "0x180771F90", Slot = "4")]
	public override void HFMDKEOMMOI(string IILINHFKIII, BHDGELBFLHM CLAHEHIMHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x771F10", Offset = "0x770B10", VA = "0x180771F10", Slot = "17")]
	[IteratorStateMachine(typeof(GEPHJLBJOEP))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x771FF0", Offset = "0x770BF0", VA = "0x180771FF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7721B0", Offset = "0x770DB0", VA = "0x1807721B0")]
	public BCHCMJLNENJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DefaultMember("Item")]
public class FHAJHPHNCHA : BHDGELBFLHM, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class IOAKLCEEAOI : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public FHAJHPHNCHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private Dictionary<string, BHDGELBFLHM>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x779B80", Offset = "0x778780", VA = "0x180779B80")]
		[DebuggerHidden]
		public IOAKLCEEAOI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x77B190", Offset = "0x779D90", VA = "0x18077B190", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x77AF20", Offset = "0x779B20", VA = "0x18077AF20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x77AED0", Offset = "0x779AD0", VA = "0x18077AED0")]
		private void LLJFIEILMND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x77B140", Offset = "0x779D40", VA = "0x18077B140", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private Dictionary<string, BHDGELBFLHM> GAFAKKJOKGN;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override BHDGELBFLHM NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x777780", Offset = "0x776380", VA = "0x180777780", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override BHDGELBFLHM NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7776E0", Offset = "0x7762E0", VA = "0x1807776E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override int CMJPMBPLDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x777870", Offset = "0x776470", VA = "0x180777870", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x777940", Offset = "0x776540", VA = "0x180777940", Slot = "4")]
	public override void HFMDKEOMMOI(string IILINHFKIII, BHDGELBFLHM CLAHEHIMHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7778C0", Offset = "0x7764C0", VA = "0x1807778C0", Slot = "17")]
	[IteratorStateMachine(typeof(IOAKLCEEAOI))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x777A50", Offset = "0x776650", VA = "0x180777A50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x777E50", Offset = "0x776A50", VA = "0x180777E50")]
	public FHAJHPHNCHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KPJCONFALDK : BHDGELBFLHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private string KAMLFGKDFME;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public override string GMFAJOGMKIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x773430", Offset = "0x772030", VA = "0x180773430", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x77D010", Offset = "0x77BC10", VA = "0x18077D010")]
	public KPJCONFALDK(string LPHMOKBNBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x77D050", Offset = "0x77BC50", VA = "0x18077D050")]
	public KPJCONFALDK(bool LPHMOKBNBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x77D090", Offset = "0x77BC90", VA = "0x18077D090")]
	public KPJCONFALDK(int LPHMOKBNBNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x77CFC0", Offset = "0x77BBC0", VA = "0x18077CFC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
internal class DJAPBCBIOMK : BHDGELBFLHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private BHDGELBFLHM KOPGHJKOKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private string ENKMFIEKILP;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public override BHDGELBFLHM NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x775370", Offset = "0x773F70", VA = "0x180775370", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public override BHDGELBFLHM NDLPAODIKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7752E0", Offset = "0x773EE0", VA = "0x1807752E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override int FELLNLDEJGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x775210", Offset = "0x773E10", VA = "0x180775210", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x775950", Offset = "0x774550", VA = "0x180775950", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override bool LBGEABCIMEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x775580", Offset = "0x774180", VA = "0x180775580", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7753F0", Offset = "0x773FF0", VA = "0x1807753F0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override BCHCMJLNENJ FOBIKNMBFFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x775660", Offset = "0x774260", VA = "0x180775660", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override FHAJHPHNCHA ENMAOBKGJCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x7754D0", Offset = "0x7740D0", VA = "0x1807754D0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x775AB0", Offset = "0x7746B0", VA = "0x180775AB0")]
	public DJAPBCBIOMK(BHDGELBFLHM EIKMJGLGNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x775A60", Offset = "0x774660", VA = "0x180775A60")]
	public DJAPBCBIOMK(BHDGELBFLHM EIKMJGLGNLK, string IILINHFKIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7758E0", Offset = "0x7744E0", VA = "0x1807758E0")]
	private void INLCAGHFLDH(BHDGELBFLHM FALBHAHIMMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x775710", Offset = "0x774310", VA = "0x180775710", Slot = "10")]
	public override void HFMDKEOMMOI(BHDGELBFLHM CLAHEHIMHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7757F0", Offset = "0x7743F0", VA = "0x1807757F0", Slot = "4")]
	public override void HFMDKEOMMOI(string IILINHFKIII, BHDGELBFLHM CLAHEHIMHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x775650", Offset = "0x774250", VA = "0x180775650", Slot = "0")]
	public override bool Equals(object IIFJCGIHMIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x772D60", Offset = "0x771960", VA = "0x180772D60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x775A30", Offset = "0x774630", VA = "0x180775A30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CCIEANJOCPG
{
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7750D0", Offset = "0x773CD0", VA = "0x1807750D0")]
	public static BHDGELBFLHM EJCEEDCGPOP(string JGANDDAHPOI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum DKGCPDFHHOO
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	OPTED_IN,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	SUBSCRIBED,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	UNSUBSCRIBED
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MHEHJEKJKFH
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public MDAGBFCMEKF GLJNDINFKLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x773430", Offset = "0x772030", VA = "0x180773430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int GHBKJBEIGOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7786A0", Offset = "0x7772A0", VA = "0x1807786A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x77E240", Offset = "0x77CE40", VA = "0x18077E240")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string EAFFELNPBNM
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x773620", Offset = "0x772220", VA = "0x180773620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int DPOLPOPCJIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x77DAF0", Offset = "0x77C6F0", VA = "0x18077DAF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x77E230", Offset = "0x77CE30", VA = "0x18077E230")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IDictionary<string, object> CGMOFGFDBAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7766D0", Offset = "0x7752D0", VA = "0x1807766D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x77D0D0", Offset = "0x77BCD0", VA = "0x18077D0D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x77E900", Offset = "0x77D500", VA = "0x18077E900")]
	public MHEHJEKJKFH(FHAJHPHNCHA MFADGLMMHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x77DB00", Offset = "0x77C700", VA = "0x18077DB00")]
	private object IJKEEOPCNKH(BHDGELBFLHM NIICEONAONO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x77E250", Offset = "0x77CE50", VA = "0x18077E250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MDAGBFCMEKF
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IList<string> BBEIHBPPCLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x773430", Offset = "0x772030", VA = "0x180773430")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string KIPMGIKKKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7733F0", Offset = "0x771FF0", VA = "0x1807733F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public string EPPKICFEAEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x773620", Offset = "0x772220", VA = "0x180773620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public string IDDFOIGAODO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x773600", Offset = "0x772200", VA = "0x180773600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x773820", Offset = "0x772420", VA = "0x180773820")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public string BPEMFPBCADM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7766D0", Offset = "0x7752D0", VA = "0x1807766D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x77D0D0", Offset = "0x77BCD0", VA = "0x18077D0D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x77D520", Offset = "0x77C120", VA = "0x18077D520")]
	public MDAGBFCMEKF(FHAJHPHNCHA MFADGLMMHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x77D0E0", Offset = "0x77BCE0", VA = "0x18077D0E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum COACDGFLAIF
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
public enum COBMLOBCCLN
{
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	NEWS_FEED,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	URI,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	NONE
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum APBGOFOBNIN
{
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	AUTO_DISMISS,
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	SWIPE
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FLEOOJFHFCB
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public List<KIKFNLHFABP> CICJOBOCKON
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x773430", Offset = "0x772030", VA = "0x180773430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool PBIKAAHHNBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x778130", Offset = "0x776D30", VA = "0x180778130")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x778140", Offset = "0x776D40", VA = "0x180778140")]
	public FLEOOJFHFCB(string EOOPGFAEMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x777EE0", Offset = "0x776AE0", VA = "0x180777EE0")]
	private static KIKFNLHFABP ACJBAGALPFC(FHAJHPHNCHA MFADGLMMHMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum JGLPHGLOJLK
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
public class BJPIIDDMHGL
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string IJGAADLAJFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x773430", Offset = "0x772030", VA = "0x180773430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string HOACIKFNJOM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7733F0", Offset = "0x771FF0", VA = "0x1807733F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string IGFCMPAHEPH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x773620", Offset = "0x772220", VA = "0x180773620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Dictionary<string, string> JEIBJOILPFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x773600", Offset = "0x772200", VA = "0x180773600")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x773820", Offset = "0x772420", VA = "0x180773820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int DJLLEBPNPGF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x773400", Offset = "0x772000", VA = "0x180773400")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7733E0", Offset = "0x771FE0", VA = "0x1807733E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public long ANJDOAKJBNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x773610", Offset = "0x772210", VA = "0x180773610")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x773450", Offset = "0x772050", VA = "0x180773450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string BBDEOAIJJPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x773440", Offset = "0x772040", VA = "0x180773440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7733D0", Offset = "0x771FD0", VA = "0x1807733D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x773B20", Offset = "0x772720", VA = "0x180773B20")]
	public BJPIIDDMHGL(string EOOPGFAEMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x773830", Offset = "0x772430", VA = "0x180773830", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x773460", Offset = "0x772060", VA = "0x180773460")]
	private string GHHINOONNFJ(FHAJHPHNCHA MFADGLMMHMB, string PPNDANAOAMK, string MLNCHKABKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x773640", Offset = "0x772240", VA = "0x180773640")]
	private int OBKOAOLHIEJ(FHAJHPHNCHA MFADGLMMHMB, string PPNDANAOAMK, int MLNCHKABKBO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7731F0", Offset = "0x771DF0", VA = "0x1807731F0")]
	private long ABCKIBCGEKD(FHAJHPHNCHA MFADGLMMHMB, string PPNDANAOAMK, long MLNCHKABKBO)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum LGKGOAGAMOG
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	TOP,
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	BOTTOM
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JINBHNNNCMG
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public interface GOIIECACFCK
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	List<NIIIBBAOHID> IMNAPGHPOPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public abstract class FLLHPGFLLPK : JINBHNNNCMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	protected string OPFIPNFNHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int GLELJEIPJPG;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Color? OHPLDICNKIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7787E0", Offset = "0x7773E0", VA = "0x1807787E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x778830", Offset = "0x777430", VA = "0x180778830", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Color? FDEIDAEECAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x778740", Offset = "0x777340", VA = "0x180778740", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x778810", Offset = "0x777410", VA = "0x180778810", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string CDGKGMPFGAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x776710", Offset = "0x775310", VA = "0x180776710", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x776640", Offset = "0x775240", VA = "0x180776640", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Color? HDIOPPLGEHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x778720", Offset = "0x777320", VA = "0x180778720", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x778800", Offset = "0x777400", VA = "0x180778800", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Color? AELPADBJDMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7786F0", Offset = "0x7772F0", VA = "0x1807786F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x778790", Offset = "0x777390", VA = "0x180778790", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string OPGPANMPDCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x778760", Offset = "0x777360", VA = "0x180778760", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7787D0", Offset = "0x7773D0", VA = "0x1807787D0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string JODIMDLOCOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x778710", Offset = "0x777310", VA = "0x180778710", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x778820", Offset = "0x777420", VA = "0x180778820", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Dictionary<string, string> JEIBJOILPFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x778780", Offset = "0x777380", VA = "0x180778780", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x778840", Offset = "0x777440", VA = "0x180778840", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public COBMLOBCCLN IDFOFGGIIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x778770", Offset = "0x777370", VA = "0x180778770", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(COBMLOBCCLN);
		}
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x778680", Offset = "0x777280", VA = "0x180778680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string FKIBELLIFIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x778690", Offset = "0x777290", VA = "0x180778690", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7786D0", Offset = "0x7772D0", VA = "0x1807786D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public APBGOFOBNIN MHKHGCCBJBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7786B0", Offset = "0x7772B0", VA = "0x1807786B0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(APBGOFOBNIN);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7786C0", Offset = "0x7772C0", VA = "0x1807786C0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int HKPDNLFGKPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7786A0", Offset = "0x7772A0", VA = "0x1807786A0", Slot = "24")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7787A0", Offset = "0x7773A0", VA = "0x1807787A0", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x778860", Offset = "0x777460", VA = "0x180778860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x778E10", Offset = "0x777A10", VA = "0x180778E10")]
	public FLLHPGFLLPK(FHAJHPHNCHA MFADGLMMHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class NIIIBBAOHID
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int DLOBFEFDIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x770180", Offset = "0x76ED80", VA = "0x180770180")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x77F1E0", Offset = "0x77DDE0", VA = "0x18077F1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string CGBJCFCEBHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7733F0", Offset = "0x771FF0", VA = "0x1807733F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string FKIBELLIFIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x773620", Offset = "0x772220", VA = "0x180773620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public COBMLOBCCLN DADCLPIHCGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x77DAF0", Offset = "0x77C6F0", VA = "0x18077DAF0")]
		[CompilerGenerated]
		get
		{
			return default(COBMLOBCCLN);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x77E230", Offset = "0x77CE30", VA = "0x18077E230")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public Color? FDEIDAEECAF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x77F1C0", Offset = "0x77DDC0", VA = "0x18077F1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x77F210", Offset = "0x77DE10", VA = "0x18077F210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Color? OHPLDICNKIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x77F1F0", Offset = "0x77DDF0", VA = "0x18077F1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x77F220", Offset = "0x77DE20", VA = "0x18077F220")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x77F230", Offset = "0x77DE30", VA = "0x18077F230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x77F510", Offset = "0x77E110", VA = "0x18077F510")]
	public NIIIBBAOHID(FHAJHPHNCHA MFADGLMMHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class CIBHDOCMKEK
{
	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7750E0", Offset = "0x773CE0", VA = "0x1807750E0")]
	public static FHAJHPHNCHA NPHMBDDKOLK(string FMLCJLCDABD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class NEMFGLPLGPK
{
	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x77EF10", Offset = "0x77DB10", VA = "0x18077EF10")]
	public static JINBHNNNCMG GPHLLJEGLAG(string NOBKEIBGLKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class AHJFDAOAKOJ : ECFEDCNAKDM
{
	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x770190", Offset = "0x76ED90", VA = "0x180770190")]
	public AHJFDAOAKOJ(FHAJHPHNCHA MFADGLMMHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public abstract class ECFEDCNAKDM : FLLHPGFLLPK, GOIIECACFCK
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string FPPIFLAJFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x775B00", Offset = "0x774700", VA = "0x180775B00", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x775BA0", Offset = "0x7747A0", VA = "0x180775BA0", Slot = "28")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Color? HGNMKAFKLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x775BC0", Offset = "0x7747C0", VA = "0x180775BC0", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x775B20", Offset = "0x774720", VA = "0x180775B20", Slot = "30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public Color? AFHNCFBABNC
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x775B80", Offset = "0x774780", VA = "0x180775B80", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x775B60", Offset = "0x774760", VA = "0x180775B60", Slot = "32")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public List<NIIIBBAOHID> IMNAPGHPOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x775B10", Offset = "0x774710", VA = "0x180775B10", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x775B40", Offset = "0x774740", VA = "0x180775B40", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x775BE0", Offset = "0x7747E0", VA = "0x180775BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x775E60", Offset = "0x774A60", VA = "0x180775E60")]
	public ECFEDCNAKDM(FHAJHPHNCHA MFADGLMMHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class AJJCBHKFBBN : ECFEDCNAKDM
{
	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x770190", Offset = "0x76ED90", VA = "0x180770190")]
	public AJJCBHKFBBN(FHAJHPHNCHA MFADGLMMHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class HCLGIOGNICG : FLLHPGFLLPK
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public LGKGOAGAMOG LDBEDPFCOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x77A400", Offset = "0x779000", VA = "0x18077A400")]
		[CompilerGenerated]
		get
		{
			return default(LGKGOAGAMOG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x77A420", Offset = "0x779020", VA = "0x18077A420")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool HEMOPDFJKOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x77A3F0", Offset = "0x778FF0", VA = "0x18077A3F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x77A410", Offset = "0x779010", VA = "0x18077A410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Color? NFCPCMNIGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x775BC0", Offset = "0x7747C0", VA = "0x180775BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x775B20", Offset = "0x774720", VA = "0x180775B20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x77A430", Offset = "0x779030", VA = "0x18077A430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x77A670", Offset = "0x779270", VA = "0x18077A670")]
	public HCLGIOGNICG(FHAJHPHNCHA MFADGLMMHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum MGIJGPHDEGN
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	FULL,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	MODAL,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	SLIDEUP
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class HHGEIMFFEGN : KIKFNLHFABP
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string ECJONJJDLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7766F0", Offset = "0x7752F0", VA = "0x1807766F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x776620", Offset = "0x775220", VA = "0x180776620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string PADCDJHOAME
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7766E0", Offset = "0x7752E0", VA = "0x1807766E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7766B0", Offset = "0x7752B0", VA = "0x1807766B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string MJOEDPMPFBO
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x779BC0", Offset = "0x7787C0", VA = "0x180779BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x779BB0", Offset = "0x7787B0", VA = "0x180779BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x77AAE0", Offset = "0x7796E0", VA = "0x18077AAE0")]
	public HHGEIMFFEGN(FHAJHPHNCHA MFADGLMMHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x77A920", Offset = "0x779520", VA = "0x18077A920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class GNDPHJMEAHH : KIKFNLHFABP
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public string ECJONJJDLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7766F0", Offset = "0x7752F0", VA = "0x1807766F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x776620", Offset = "0x775220", VA = "0x180776620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string HOACIKFNJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7766E0", Offset = "0x7752E0", VA = "0x1807766E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7766B0", Offset = "0x7752B0", VA = "0x1807766B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string LOLJPFLIOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x779BC0", Offset = "0x7787C0", VA = "0x180779BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x779BB0", Offset = "0x7787B0", VA = "0x180779BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string PADCDJHOAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x776540", Offset = "0x775140", VA = "0x180776540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x776550", Offset = "0x775150", VA = "0x180776550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string MJOEDPMPFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x776650", Offset = "0x775250", VA = "0x180776650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x776730", Offset = "0x775330", VA = "0x180776730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x779E20", Offset = "0x778A20", VA = "0x180779E20")]
	public GNDPHJMEAHH(FHAJHPHNCHA MFADGLMMHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x779BD0", Offset = "0x7787D0", VA = "0x180779BD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class KIKFNLHFABP
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string FHLPJAKBEGB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x773430", Offset = "0x772030", VA = "0x180773430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string IBCFEMEEMGE
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7733F0", Offset = "0x771FF0", VA = "0x1807733F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool OBODGGMFLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x776670", Offset = "0x775270", VA = "0x180776670")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x776720", Offset = "0x775320", VA = "0x180776720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public long FBMNBCKOJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x773600", Offset = "0x772200", VA = "0x180773600")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x776610", Offset = "0x775210", VA = "0x180776610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public long CBCABDBEFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7766D0", Offset = "0x7752D0", VA = "0x1807766D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x776510", Offset = "0x775110", VA = "0x180776510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public HashSet<COACDGFLAIF> BIPEGFIJGJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x773610", Offset = "0x772210", VA = "0x180773610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x776700", Offset = "0x775300", VA = "0x180776700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private string EACCNHOHEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7733D0", Offset = "0x771FD0", VA = "0x1807733D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public Dictionary<string, string> JEIBJOILPFO
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x776710", Offset = "0x775310", VA = "0x180776710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x776640", Offset = "0x775240", VA = "0x180776640")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x77C5F0", Offset = "0x77B1F0", VA = "0x18077C5F0")]
	public KIKFNLHFABP(FHAJHPHNCHA MFADGLMMHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x77C270", Offset = "0x77AE70", VA = "0x18077C270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x77C090", Offset = "0x77AC90", VA = "0x18077C090")]
	public string LLHNHEBPBKF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class NPHNCEGELOP : KIKFNLHFABP
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string LOLJPFLIOEN
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7766F0", Offset = "0x7752F0", VA = "0x1807766F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x776620", Offset = "0x775220", VA = "0x180776620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string ECJONJJDLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7766E0", Offset = "0x7752E0", VA = "0x1807766E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7766B0", Offset = "0x7752B0", VA = "0x1807766B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public string HOACIKFNJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x779BC0", Offset = "0x7787C0", VA = "0x180779BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x779BB0", Offset = "0x7787B0", VA = "0x180779BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public string PADCDJHOAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x776540", Offset = "0x775140", VA = "0x180776540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x776550", Offset = "0x775150", VA = "0x180776550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string MJOEDPMPFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x776650", Offset = "0x775250", VA = "0x180776650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x776730", Offset = "0x775330", VA = "0x180776730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x77FC40", Offset = "0x77E840", VA = "0x18077FC40")]
	public NPHNCEGELOP(FHAJHPHNCHA MFADGLMMHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x77F9F0", Offset = "0x77E5F0", VA = "0x18077F9F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class FELPCAFFEEE
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public string FHLPJAKBEGB
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x773410", Offset = "0x772010", VA = "0x180773410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x773430", Offset = "0x772030", VA = "0x180773430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string IBCFEMEEMGE
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7733F0", Offset = "0x771FF0", VA = "0x1807733F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool OBODGGMFLDB
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x776670", Offset = "0x775270", VA = "0x180776670")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x776720", Offset = "0x775320", VA = "0x180776720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public long FBMNBCKOJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x773600", Offset = "0x772200", VA = "0x180773600")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x776610", Offset = "0x775210", VA = "0x180776610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public long NOKOBAHPGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7766D0", Offset = "0x7752D0", VA = "0x1807766D0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x776510", Offset = "0x775110", VA = "0x180776510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public string ECJONJJDLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x773610", Offset = "0x772210", VA = "0x180773610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x776700", Offset = "0x775300", VA = "0x180776700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string HOACIKFNJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x773440", Offset = "0x772040", VA = "0x180773440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7733D0", Offset = "0x771FD0", VA = "0x1807733D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public string LOLJPFLIOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x776710", Offset = "0x775310", VA = "0x180776710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x776640", Offset = "0x775240", VA = "0x180776640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public string PADCDJHOAME
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x7766F0", Offset = "0x7752F0", VA = "0x1807766F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x776620", Offset = "0x775220", VA = "0x180776620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public string MJOEDPMPFBO
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x7766E0", Offset = "0x7752E0", VA = "0x1807766E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x7766B0", Offset = "0x7752B0", VA = "0x1807766B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public bool BJDAIBPHPBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x776560", Offset = "0x775160", VA = "0x180776560")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x776460", Offset = "0x775060", VA = "0x180776460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool NADPLMPCGCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x776680", Offset = "0x775280", VA = "0x180776680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7766A0", Offset = "0x7752A0", VA = "0x1807766A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool LCMLJHGKHNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7766C0", Offset = "0x7752C0", VA = "0x1807766C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x776690", Offset = "0x775290", VA = "0x180776690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool JCFFNBMFCKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x776520", Offset = "0x775120", VA = "0x180776520")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x776530", Offset = "0x775130", VA = "0x180776530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool FCIGMPFIGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x776630", Offset = "0x775230", VA = "0x180776630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x776660", Offset = "0x775260", VA = "0x180776660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public string EACCNHOHEGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x776540", Offset = "0x775140", VA = "0x180776540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x776550", Offset = "0x775150", VA = "0x180776550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public Dictionary<string, string> JEIBJOILPFO
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x776650", Offset = "0x775250", VA = "0x180776650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x776730", Offset = "0x775330", VA = "0x180776730")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x776DF0", Offset = "0x7759F0", VA = "0x180776DF0")]
	public FELPCAFFEEE(FHAJHPHNCHA MFADGLMMHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x776740", Offset = "0x775340", VA = "0x180776740", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x776470", Offset = "0x775070", VA = "0x180776470")]
	public void BKGMEMIODML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x776570", Offset = "0x775170", VA = "0x180776570")]
	public void GEHGCCFOIBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class KGKHCMBCGLF : KIKFNLHFABP
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public string HOACIKFNJOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x7766F0", Offset = "0x7752F0", VA = "0x1807766F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x776620", Offset = "0x775220", VA = "0x180776620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public string LOLJPFLIOEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7766E0", Offset = "0x7752E0", VA = "0x1807766E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7766B0", Offset = "0x7752B0", VA = "0x1807766B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public string PADCDJHOAME
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x779BC0", Offset = "0x7787C0", VA = "0x180779BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x779BB0", Offset = "0x7787B0", VA = "0x180779BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string MJOEDPMPFBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x776540", Offset = "0x775140", VA = "0x180776540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x776550", Offset = "0x775150", VA = "0x180776550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x77BB80", Offset = "0x77A780", VA = "0x18077BB80")]
	public KGKHCMBCGLF(FHAJHPHNCHA MFADGLMMHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x77B970", Offset = "0x77A570", VA = "0x18077B970", Slot = "3")]
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
		private AKENKJKDMPK MHHKLHEPHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private BPBALJIHIIA HLHFONJAFIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public OOBBMILCMFF iamListener;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7733F0", Offset = "0x771FF0", VA = "0x1807733F0")]
		public void setPushPromptResponseReceivedDelegate(AKENKJKDMPK PPLLHJLJMIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x773620", Offset = "0x772220", VA = "0x180773620")]
		public void setPushTokenReceivedFromSystemDelegate(BPBALJIHIIA PPLLHJLJMIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x774DD0", Offset = "0x7739D0", VA = "0x180774DD0")]
		public void onPushPromptResponseReceived(string JFMGGEALMEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x774E40", Offset = "0x773A40", VA = "0x180774E40")]
		public void onPushTokenReceivedFromSystem(string KJCAGLABEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x774720", Offset = "0x773320", VA = "0x180774720")]
		public void beforeInAppMessageDisplayed(string FNLACOMBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x774AF0", Offset = "0x7736F0", VA = "0x180774AF0")]
		public void onInAppMessageDismissed(string FNLACOMBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x774A90", Offset = "0x773690", VA = "0x180774A90")]
		public void onInAppMessageClicked(string FNLACOMBOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x774780", Offset = "0x773380", VA = "0x180774780")]
		public void onInAppMessageButtonClicked(string IBLHICBKHHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x774B50", Offset = "0x773750", VA = "0x180774B50")]
		public void onInAppMessageHTMLClicked(string IBLHICBKHHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x771300", Offset = "0x76FF00", VA = "0x180771300")]
		public BrazeInternalComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class BrazeInternalGameObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private static GameObject BJMIJNLECJK;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private static GameObject IDAIJJLMAFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x774E60", Offset = "0x773A60", VA = "0x180774E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x775010", Offset = "0x773C10", VA = "0x180775010")]
		public static void setPushPromptResponseReceivedDelegate(AKENKJKDMPK PPLLHJLJMIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x775070", Offset = "0x773C70", VA = "0x180775070")]
		public static void setPushTokenReceivedFromSystemDelegate(BPBALJIHIIA PPLLHJLJMIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x774FB0", Offset = "0x773BB0", VA = "0x180774FB0")]
		public static void setInAppMessageListener(OOBBMILCMFF EDDMMBAOGHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x771300", Offset = "0x76FF00", VA = "0x180771300")]
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
