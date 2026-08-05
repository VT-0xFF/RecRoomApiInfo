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
public interface NHIFIHMIFFA
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ApplePushNotificationTester : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x897950", Offset = "0x896350", VA = "0x180897950")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8973F0", Offset = "0x895DF0", VA = "0x1808973F0")]
	public string PrintOutObjectValues(object OGEMKCBGEAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x897340", Offset = "0x895D40", VA = "0x180897340")]
	public ApplePushNotificationTester()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HJCACPKNGNA
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
public enum BOJJCOLIJIG
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	IAM_DISPLAY_NOW,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	IAM_DISPLAY_LATER,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	IAM_DISCARD
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public delegate void HJCGKJLDALC(bool KIHEOKNJIPI);
[Cpp2IlInjected.Token(Token = "0x2000007")]
public delegate void FJGBJEIDJHO(string FLLNLBHFENG);
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AppboyBinding : SingletonMonoBehaviour<AppboyBinding>
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static NHIFIHMIFFA PGBLAICHEFK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static NHIFIHMIFFA OOOJLJMKMII
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8973B0", Offset = "0x895DB0", VA = "0x1808973B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static EHFJBIMAIGA OBCPDOBKBOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void LogCustomEvent(string PJJMBOHKNAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void LogCustomEvent(string PJJMBOHKNAL, Dictionary<string, object> DAODDBNNDHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void LogPurchase(string MJHKEOPOGAG, string KFBOODLJADB, decimal MOBOCAMNDBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void LogPurchase(string MJHKEOPOGAG, string KFBOODLJADB, decimal MOBOCAMNDBJ, int OGKJJPEBIOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void LogPurchase(string MJHKEOPOGAG, string KFBOODLJADB, decimal MOBOCAMNDBJ, int OGKJJPEBIOK, Dictionary<string, object> DAODDBNNDHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void ChangeUser(string FBCNKAADCGD, [Optional] string OGCJFOGNEND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetSdkAuthenticationSignature(string OGCJFOGNEND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetUserFirstName(string BKODJICIGNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetUserLastName(string ANJKNEDDEEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetUserEmail(string FOOBKNOGBKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetUserGender(MAADPMMJHOO FBBBIHJGCHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetUserDateOfBirth(int EPBBGJNOKCN, int MJNHHEPPFDP, int JLCNEJCKGDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetUserCountry(string NCOJECBCIML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetUserHomeCity(string JOGNKAIFCEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetUserEmailNotificationSubscriptionType(EBKHLGPPENN GLILDDNNKBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetUserPushNotificationSubscriptionType(EBKHLGPPENN AJKGHCLFDBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetUserPhoneNumber(string GPCCOFAAOPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetCustomUserAttribute(string LFOBGDLOPID, bool KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetCustomUserAttribute(string LFOBGDLOPID, int KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetCustomUserAttribute(string LFOBGDLOPID, float KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetCustomUserAttribute(string LFOBGDLOPID, string KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetCustomUserAttributeToNow(string LFOBGDLOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetCustomUserAttributeToSecondsFromEpoch(string LFOBGDLOPID, long BCEMBFFEHIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void UnsetCustomUserAttribute(string LFOBGDLOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void IncrementCustomUserAttribute(string LFOBGDLOPID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void IncrementCustomUserAttribute(string LFOBGDLOPID, int BCACPNJPKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetCustomUserAttributeArray(string LFOBGDLOPID, List<string> DKEEEGEFALD, int BHEAFIOEIAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void AddToCustomUserAttributeArray(string LFOBGDLOPID, string KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void RemoveFromCustomUserAttributeArray(string LFOBGDLOPID, string KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void setUserFacebookData(string CLLNOLFLDMA, string BKODJICIGNP, string ANJKNEDDEEE, string FOOBKNOGBKK, string AMEPKHNDMAA, string JLMLDKABIHK, MAADPMMJHOO? FBBBIHJGCHC, int? KNBBGJKFHBA, string IJNFNHCHNJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void setUserTwitterData(int? AMMOKMMIPCC, string AHGKJLDCNBD, string KJPHMNNIMDP, string PADNFDKMCHE, int? JFONAMEIJND, int? KMHOCAKKPEF, int? PGKDMODABFO, string JNJLNDIIFKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetUserLastKnownLocation(double EKCBDCKJAGK, double LMJEJHNBKEL, [Optional] double? EFNBFIDLPKK, [Optional] double? GBMLEJDMJNI, [Optional] double? MFFDIGAJJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void PromptUserForPushPermissions(bool LMLGPLJOLAK, [Optional] HJCGKJLDALC GCLKPCPPJME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetPushTokenReceivedFromSystemDelegate(FJGBJEIDJHO JHLDANAHFPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void LogInAppMessageClicked(string LIPGCBEGDHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void LogInAppMessageImpression(string LIPGCBEGDHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void LogInAppMessageButtonClicked(string LIPGCBEGDHL, int CMKKDKJMOLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void RequestFeedRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void RequestFeedRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void LogFeedDisplayed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void RequestContentCardsRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void RequestContentCardsRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void LogContentCardClicked(string FKPMCJCADBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void LogContentCardImpression(string FKPMCJCADBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void LogContentCardDismissed(string FKPMCJCADBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void WipeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void EnableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void DisableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360")]
		public static string GetInstallTrackingId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetAttributionData(string DEGIGDMKMBA, string JBOJDGOIENH, string AFGJJBAEKKO, string ACNHCMFIEBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void RequestLocationInitialization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void RequestGeofences(decimal EKCBDCKJAGK, decimal LMJEJHNBKEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void RequestImmediateDataFlush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void AddAlias(string ENGCPAGBLND, string MANKBKONOGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void ConfigureListener(HJCACPKNGNA KEOIKFMHEJA, string OCPMJFEFIFL, string PDJPHJMJIMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void SetInAppMessageDisplayAction(BOJJCOLIJIG GGCGHMBDJAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void DisplayNextInAppMessage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void DisplayContentCards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void AddToSubscriptionGroup(string MCAKFNPAKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void RemoveFromSubscriptionGroup(string MCAKFNPAKIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x897370", Offset = "0x895D70", VA = "0x180897370")]
		public AppboyBinding()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class EHFJBIMAIGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public Action<DDBOOBFKEKF> AHCKIHFOCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public Action<DDBOOBFKEKF> NINGIJIDHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public Action<DDBOOBFKEKF> GNOLFFIOEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Action<DDBOOBFKEKF, BMPEOHPBKFN> DEMJMDJKEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public Action<DDBOOBFKEKF, Uri> JINJLLADDIJ;
}
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AppboyBindingTester : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8972C0", Offset = "0x895CC0", VA = "0x1808972C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x896630", Offset = "0x895030", VA = "0x180896630")]
		private void EHDBKHDKIPG(string KFAOBDLOMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8971E0", Offset = "0x895BE0", VA = "0x1808971E0")]
		private void JOKHOMLFDOK(string KFAOBDLOMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x897250", Offset = "0x895C50", VA = "0x180897250")]
		private void ODFDHOAINBG(string KFAOBDLOMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x896520", Offset = "0x894F20", VA = "0x180896520")]
		private void BPDKPLMBJNK(string KFAOBDLOMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x897060", Offset = "0x895A60", VA = "0x180897060")]
		private void JHJJMKGBHDP(string KFAOBDLOMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x896B50", Offset = "0x895550", VA = "0x180896B50")]
		private void FFGMCLKHLKO(string KFAOBDLOMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x896CB0", Offset = "0x8956B0", VA = "0x180896CB0")]
		private void IEPLGFKNNCE(string KFAOBDLOMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8962E0", Offset = "0x894CE0", VA = "0x1808962E0")]
		private void BMBHIKFKKIC(string KFAOBDLOMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x896710", Offset = "0x895110", VA = "0x180896710")]
		private void FEEKDDEPMGE(string KFAOBDLOMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x897170", Offset = "0x895B70", VA = "0x180897170")]
		private void JMIOBICGPGL(string KFAOBDLOMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x896E10", Offset = "0x895810", VA = "0x180896E10")]
		public static void InAppMessageBeforeDisplayed(DDBOOBFKEKF KFAOBDLOMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x896F70", Offset = "0x895970", VA = "0x180896F70")]
		public static void InAppMessageDismissed(DDBOOBFKEKF KFAOBDLOMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x896F00", Offset = "0x895900", VA = "0x180896F00")]
		public static void InAppMessageClicked(DDBOOBFKEKF KFAOBDLOMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x896E80", Offset = "0x895880", VA = "0x180896E80")]
		public static void InAppMessageButtonClicked(DDBOOBFKEKF KFAOBDLOMDC, BMPEOHPBKFN PMPHDOLEBMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x896FE0", Offset = "0x8959E0", VA = "0x180896FE0")]
		public static void InAppMessageHTMLClicked(DDBOOBFKEKF KFAOBDLOMDC, Uri NCPJCCFMGPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x897340", Offset = "0x895D40", VA = "0x180897340")]
		public AppboyBindingTester()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class GJGOENNINPD
{
	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x89E3D0", Offset = "0x89CDD0", VA = "0x18089E3D0")]
	public static string FNMCBKHKGMJ(Dictionary<string, string> HGEMHLLLPMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2DA8570", Offset = "0x2DA6F70", VA = "0x182DA8570")]
	public static string JKLBFDLOPPO<T>(List<T> OLAPNOFMNPM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class FAFJHCKCDLK
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x89D440", Offset = "0x89BE40", VA = "0x18089D440")]
	public static Color? PDOOPLPHOPH(string OLOFHNGHENC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x89D150", Offset = "0x89BB50", VA = "0x18089D150")]
	public static Color PDOOPLPHOPH(int OLOFHNGHENC)
	{
		return default(Color);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JICCLFLDEPM
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8A0820", Offset = "0x89F220", VA = "0x1808A0820")]
	public static object HOPFCGCIMCA(Type LKNKNGAOOJD, string KLABJGGMBGH, bool HOFAEJLAINB, object MCAGMGIJFIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MMHGEIBIHFH
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8A3A60", Offset = "0x8A2460", VA = "0x1808A3A60")]
	public static Dictionary<string, string> BAMOIBKHKNO(PHFHGKAJGKD OADFIADCCGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EIGDGEDLIHJ
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class CALFFHAJNKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private StringBuilder JHPMFODLHPM;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x89C250", Offset = "0x89AC50", VA = "0x18089C250")]
		private CALFFHAJNKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x89B420", Offset = "0x899E20", VA = "0x18089B420")]
		public static string AMCHBAGBIFH(object GHMNBJIOGAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x89B500", Offset = "0x899F00", VA = "0x18089B500")]
		private void IGKLPNFIOML(object KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x89B940", Offset = "0x89A340", VA = "0x18089B940")]
		private void NGLDDCOHCFA(IDictionary GHMNBJIOGAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x89B6F0", Offset = "0x89A0F0", VA = "0x18089B6F0")]
		private void KCKFEEJIJDO(IList DKEEEGEFALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x89BF20", Offset = "0x89A920", VA = "0x18089BF20")]
		private void PCEJNJPGJIN(string KLNAGGGGPDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x89BC30", Offset = "0x89A630", VA = "0x18089BC30")]
		private void OPEBONFKJNE(object KLABJGGMBGH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private static NumberFormatInfo EHPJCCGIIPH;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x89B420", Offset = "0x899E20", VA = "0x18089B420")]
	public static string AMCHBAGBIFH(object GHMNBJIOGAM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public class LLKGBMHPGFN
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public virtual LLKGBMHPGFN BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public virtual LLKGBMHPGFN BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public virtual string PGPGCBGPPOH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8A2350", Offset = "0x8A0D50", VA = "0x1808A2350", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public virtual int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x897360", Offset = "0x895D60", VA = "0x180897360", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public virtual int NNFGGHKGNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8A2710", Offset = "0x8A1110", VA = "0x1808A2710", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8A31A0", Offset = "0x8A1BA0", VA = "0x1808A31A0", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public virtual bool KHABHBDLJGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8A31E0", Offset = "0x8A1BE0", VA = "0x1808A31E0", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8A2750", Offset = "0x8A1150", VA = "0x1808A2750", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public virtual COEPHJJGOBE DOIKEHEPIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8A24E0", Offset = "0x8A0EE0", VA = "0x1808A24E0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public virtual PHFHGKAJGKD FOMHLPFCGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8A3020", Offset = "0x8A1A20", VA = "0x1808A3020", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "4")]
	public virtual void FABNFHGMHGJ(string BBBOFPAAEBJ, LLKGBMHPGFN NPNMEEHNJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8A2480", Offset = "0x8A0E80", VA = "0x1808A2480", Slot = "10")]
	public virtual void FABNFHGMHGJ(LLKGBMHPGFN NPNMEEHNJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8A3290", Offset = "0x8A1C90", VA = "0x1808A3290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8A2380", Offset = "0x8A0D80", VA = "0x1808A2380")]
	public static LLKGBMHPGFN BIEOCAPMHCM(string NFDBNIDBLCF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8A23F0", Offset = "0x8A0DF0", VA = "0x1808A23F0")]
	public static string BIEOCAPMHCM(LLKGBMHPGFN MIBANGGGBCO)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8A3120", Offset = "0x8A1B20", VA = "0x1808A3120")]
	public static bool MNAFCOICNLK(LLKGBMHPGFN MOKDKAEJAPP, object MKGNFMMEFHC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8A30A0", Offset = "0x8A1AA0", VA = "0x1808A30A0")]
	public static bool KIKJPCCIIDN(LLKGBMHPGFN MOKDKAEJAPP, object MKGNFMMEFHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8A2470", Offset = "0x8A0E70", VA = "0x1808A2470", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x89C6E0", Offset = "0x89B0E0", VA = "0x18089C6E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8A2560", Offset = "0x8A0F60", VA = "0x1808A2560")]
	internal static string HDMGDIINHFN(string IIDIGFKIKDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8A27D0", Offset = "0x8A11D0", VA = "0x1808A27D0")]
	public static LLKGBMHPGFN KBCEKLEOMBI(string MJLNAMLGAFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public LLKGBMHPGFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DefaultMember("Item")]
public class COEPHJJGOBE : LLKGBMHPGFN, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class GEPIMIIKDCN : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public COEPHJJGOBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<LLKGBMHPGFN>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
		[DebuggerHidden]
		public GEPIMIIKDCN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x89E310", Offset = "0x89CD10", VA = "0x18089E310", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x89E110", Offset = "0x89CB10", VA = "0x18089E110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x89E0C0", Offset = "0x89CAC0", VA = "0x18089E0C0")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x89E2C0", Offset = "0x89CCC0", VA = "0x18089E2C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<LLKGBMHPGFN> AIBFIIEAKJA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override LLKGBMHPGFN BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x89CC10", Offset = "0x89B610", VA = "0x18089CC10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override LLKGBMHPGFN BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x89CCE0", Offset = "0x89B6E0", VA = "0x18089CCE0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x89CBD0", Offset = "0x89B5D0", VA = "0x18089CBD0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x89CD60", Offset = "0x89B760", VA = "0x18089CD60", Slot = "4")]
	public override void FABNFHGMHGJ(string BBBOFPAAEBJ, LLKGBMHPGFN NPNMEEHNJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x89CDC0", Offset = "0x89B7C0", VA = "0x18089CDC0", Slot = "17")]
	[IteratorStateMachine(typeof(GEPIMIIKDCN))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x89CE40", Offset = "0x89B840", VA = "0x18089CE40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x89D000", Offset = "0x89BA00", VA = "0x18089D000")]
	public COEPHJJGOBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class PHFHGKAJGKD : LLKGBMHPGFN, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class NIEGMHLNMEH : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public PHFHGKAJGKD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Dictionary<string, LLKGBMHPGFN>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x89E3A0", Offset = "0x89CDA0", VA = "0x18089E3A0")]
		[DebuggerHidden]
		public NIEGMHLNMEH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8A4030", Offset = "0x8A2A30", VA = "0x1808A4030", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8A3DC0", Offset = "0x8A27C0", VA = "0x1808A3DC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8A3D70", Offset = "0x8A2770", VA = "0x1808A3D70")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8A3FE0", Offset = "0x8A29E0", VA = "0x1808A3FE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private Dictionary<string, LLKGBMHPGFN> GFOMIADJKNP;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public override LLKGBMHPGFN BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8A57C0", Offset = "0x8A41C0", VA = "0x1808A57C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public override LLKGBMHPGFN BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8A58B0", Offset = "0x8A42B0", VA = "0x1808A58B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public override int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8A5770", Offset = "0x8A4170", VA = "0x1808A5770", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x8A5950", Offset = "0x8A4350", VA = "0x1808A5950", Slot = "4")]
	public override void FABNFHGMHGJ(string BBBOFPAAEBJ, LLKGBMHPGFN NPNMEEHNJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8A5A60", Offset = "0x8A4460", VA = "0x1808A5A60", Slot = "17")]
	[IteratorStateMachine(typeof(NIEGMHLNMEH))]
	public IEnumerator GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8A5AE0", Offset = "0x8A44E0", VA = "0x1808A5AE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8A5EE0", Offset = "0x8A48E0", VA = "0x1808A5EE0")]
	public PHFHGKAJGKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ADONBEBOHJF : LLKGBMHPGFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private string OLMAAGHPBCF;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public override string PGPGCBGPPOH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0", Slot = "7")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894BC0", VA = "0x1808961C0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x8962A0", Offset = "0x894CA0", VA = "0x1808962A0")]
	public ADONBEBOHJF(string OAKAJIFMACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x896220", Offset = "0x894C20", VA = "0x180896220")]
	public ADONBEBOHJF(bool OAKAJIFMACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x896260", Offset = "0x894C60", VA = "0x180896260")]
	public ADONBEBOHJF(int OAKAJIFMACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8961D0", Offset = "0x894BD0", VA = "0x1808961D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
internal class CHPGCFBAEJJ : LLKGBMHPGFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private LLKGBMHPGFN NMGGJOECGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private string EKBMGAEHILC;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public override LLKGBMHPGFN BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x89C2D0", Offset = "0x89ACD0", VA = "0x18089C2D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public override LLKGBMHPGFN BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x89C350", Offset = "0x89AD50", VA = "0x18089C350", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public override int NNFGGHKGNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x89C6F0", Offset = "0x89B0F0", VA = "0x18089C6F0", Slot = "11")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x89C950", Offset = "0x89B350", VA = "0x18089C950", Slot = "12")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public override bool KHABHBDLJGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x89CA30", Offset = "0x89B430", VA = "0x18089CA30", Slot = "13")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x89C7C0", Offset = "0x89B1C0", VA = "0x18089C7C0", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public override COEPHJJGOBE DOIKEHEPIID
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x89C630", Offset = "0x89B030", VA = "0x18089C630", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public override PHFHGKAJGKD FOMHLPFCGKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x89C8A0", Offset = "0x89B2A0", VA = "0x18089C8A0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x89CB30", Offset = "0x89B530", VA = "0x18089CB30")]
	public CHPGCFBAEJJ(LLKGBMHPGFN IGPLJGPNIBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x89CB80", Offset = "0x89B580", VA = "0x18089CB80")]
	public CHPGCFBAEJJ(LLKGBMHPGFN IGPLJGPNIBF, string BBBOFPAAEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x89C3E0", Offset = "0x89ADE0", VA = "0x18089C3E0")]
	private void ENCKAHEIPGI(LLKGBMHPGFN JKLEFJKGNJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x89C550", Offset = "0x89AF50", VA = "0x18089C550", Slot = "10")]
	public override void FABNFHGMHGJ(LLKGBMHPGFN NPNMEEHNJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x89C460", Offset = "0x89AE60", VA = "0x18089C460", Slot = "4")]
	public override void FABNFHGMHGJ(string BBBOFPAAEBJ, LLKGBMHPGFN NPNMEEHNJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x89C450", Offset = "0x89AE50", VA = "0x18089C450", Slot = "0")]
	public override bool Equals(object GHMNBJIOGAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x89C6E0", Offset = "0x89B0E0", VA = "0x18089C6E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x89CB00", Offset = "0x89B500", VA = "0x18089CB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class EBKCMIHDOHA
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x89D090", Offset = "0x89BA90", VA = "0x18089D090")]
	public static LLKGBMHPGFN KBCEKLEOMBI(string MJLNAMLGAFG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum EBKHLGPPENN
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	OPTED_IN,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	SUBSCRIBED,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	UNSUBSCRIBED
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class OFGEOCJFKCP
{
	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public FOAAMPKMEAP OGJJIMDJLEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894BC0", VA = "0x1808961C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int BCHCBGCOPJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x89F660", Offset = "0x89E060", VA = "0x18089F660")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8A40C0", Offset = "0x8A2AC0", VA = "0x1808A40C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public string FOLAIOIFPII
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x899040", Offset = "0x897A40", VA = "0x180899040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public int FAEHHPLCENN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x898FD0", Offset = "0x8979D0", VA = "0x180898FD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x899000", Offset = "0x897A00", VA = "0x180899000")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public IDictionary<string, object> JABHPDKLIPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x89D6A0", Offset = "0x89C0A0", VA = "0x18089D6A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x8A4EB0", Offset = "0x8A38B0", VA = "0x1808A4EB0")]
	public OFGEOCJFKCP(PHFHGKAJGKD OADFIADCCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x8A40D0", Offset = "0x8A2AD0", VA = "0x1808A40D0")]
	private object IPCLCGCDCFB(LLKGBMHPGFN KOHLOCENPAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8A4800", Offset = "0x8A3200", VA = "0x1808A4800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FOAAMPKMEAP
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public IList<string> MEPHPCEMJKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894BC0", VA = "0x1808961C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string PGCHNALIMIP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x899030", Offset = "0x897A30", VA = "0x180899030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public string GNLDGIGBKOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x899040", Offset = "0x897A40", VA = "0x180899040")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public string ICJAJHGDNAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x899AF0", Offset = "0x8984F0", VA = "0x180899AF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x89D6B0", Offset = "0x89C0B0", VA = "0x18089D6B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public string BKFMEFKJANF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x89D6A0", Offset = "0x89C0A0", VA = "0x18089D6A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x89DB00", Offset = "0x89C500", VA = "0x18089DB00")]
	public FOAAMPKMEAP(PHFHGKAJGKD OADFIADCCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x89D6C0", Offset = "0x89C0C0", VA = "0x18089D6C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum ILFMCNFJKGC
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
public enum MBBINPKMPNC
{
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	NEWS_FEED,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	URI,
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	NONE
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum KGCICGGKKKD
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	AUTO_DISMISS,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	SWIPE
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JPHHKENECCG
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public List<HFGHHMJEEFN> GCOJNCCIDCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894BC0", VA = "0x1808961C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool EAOEHCFINIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8A08A0", Offset = "0x89F2A0", VA = "0x1808A08A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x8A0B00", Offset = "0x89F500", VA = "0x1808A0B00")]
	public JPHHKENECCG(string KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x8A08B0", Offset = "0x89F2B0", VA = "0x1808A08B0")]
	private static HFGHHMJEEFN PMJPMEFIIAE(PHFHGKAJGKD OADFIADCCGA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public enum MAADPMMJHOO
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
public class PPKNEGGNJMJ
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public string KNLNDNBLKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894BC0", VA = "0x1808961C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string GBJGOKBDMIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x899030", Offset = "0x897A30", VA = "0x180899030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string PNIJPIIBEPL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x899040", Offset = "0x897A40", VA = "0x180899040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Dictionary<string, string> HPFFANPFJLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x899AF0", Offset = "0x8984F0", VA = "0x180899AF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x89D6B0", Offset = "0x89C0B0", VA = "0x18089D6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int PNMDJKAHODK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8A64C0", Offset = "0x8A4EC0", VA = "0x1808A64C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F70", Offset = "0x8A4970", VA = "0x1808A5F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public long PDIGNEHNMFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8999F0", Offset = "0x8983F0", VA = "0x1808999F0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8A64B0", Offset = "0x8A4EB0", VA = "0x1808A64B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string MGKIEAHICJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x899AA0", Offset = "0x8984A0", VA = "0x180899AA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x899930", Offset = "0x898330", VA = "0x180899930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x8A67C0", Offset = "0x8A51C0", VA = "0x1808A67C0")]
	public PPKNEGGNJMJ(string KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8A64D0", Offset = "0x8A4ED0", VA = "0x1808A64D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8A6320", Offset = "0x8A4D20", VA = "0x1808A6320")]
	private string HDCPOPMHMBG(PHFHGKAJGKD OADFIADCCGA, string LFOBGDLOPID, string MCAGMGIJFIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8A6150", Offset = "0x8A4B50", VA = "0x1808A6150")]
	private int DDOOEFGKIPM(PHFHGKAJGKD OADFIADCCGA, string LFOBGDLOPID, int MCAGMGIJFIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8A5F80", Offset = "0x8A4980", VA = "0x1808A5F80")]
	private long BCHPIELOICC(PHFHGKAJGKD OADFIADCCGA, string LFOBGDLOPID, long MCAGMGIJFIA)
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum PDFOLGIBEPO
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	TOP,
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	BOTTOM
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface DDBOOBFKEKF
{
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public interface MFCMMGCGDBG
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	List<BMPEOHPBKFN> DKFAKOFFKCI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public abstract class JAIHMKBLLEJ : DDBOOBFKEKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	protected string JIMOELMIGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int DLGKHGDNIDO;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Color? NAHENIDAKEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x89F6A0", Offset = "0x89E0A0", VA = "0x18089F6A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x89F7E0", Offset = "0x89E1E0", VA = "0x18089F7E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Color? DELHCDIDDAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x89F630", Offset = "0x89E030", VA = "0x18089F630", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x89F770", Offset = "0x89E170", VA = "0x18089F770", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public string HMEDIKHNKFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x899850", Offset = "0x898250", VA = "0x180899850", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8999D0", Offset = "0x8983D0", VA = "0x1808999D0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Color? IHMMCJJMMCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x89F7C0", Offset = "0x89E1C0", VA = "0x18089F7C0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x89F730", Offset = "0x89E130", VA = "0x18089F730", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Color? OCAEPKKPDGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x89F750", Offset = "0x89E150", VA = "0x18089F750", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x89F650", Offset = "0x89E050", VA = "0x18089F650", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public string LCKPOECMLCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x89F780", Offset = "0x89E180", VA = "0x18089F780", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x89F7B0", Offset = "0x89E1B0", VA = "0x18089F7B0", Slot = "15")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public string OCGNGJODMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x89F740", Offset = "0x89E140", VA = "0x18089F740", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x89F720", Offset = "0x89E120", VA = "0x18089F720", Slot = "17")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Dictionary<string, string> HPFFANPFJLG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x89F6E0", Offset = "0x89E0E0", VA = "0x18089F6E0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x89F700", Offset = "0x89E100", VA = "0x18089F700", Slot = "19")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public MBBINPKMPNC NMNINIKEFIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x89F790", Offset = "0x89E190", VA = "0x18089F790", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(MBBINPKMPNC);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x89F7A0", Offset = "0x89E1A0", VA = "0x18089F7A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string JCMPHFGEGGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x89F620", Offset = "0x89E020", VA = "0x18089F620", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x89F6C0", Offset = "0x89E0C0", VA = "0x18089F6C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public KGCICGGKKKD BONAHHCMJEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x89F6F0", Offset = "0x89E0F0", VA = "0x18089F6F0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(KGCICGGKKKD);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x89F7F0", Offset = "0x89E1F0", VA = "0x18089F7F0", Slot = "23")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int JEEEJDKHNCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x89F660", Offset = "0x89E060", VA = "0x18089F660", Slot = "24")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x89F670", Offset = "0x89E070", VA = "0x18089F670", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x89F800", Offset = "0x89E200", VA = "0x18089F800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x89FDB0", Offset = "0x89E7B0", VA = "0x18089FDB0")]
	public JAIHMKBLLEJ(PHFHGKAJGKD OADFIADCCGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class BMPEOHPBKFN
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int MINOEBCEKHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8961A0", Offset = "0x894BA0", VA = "0x1808961A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x899070", Offset = "0x897A70", VA = "0x180899070")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public string BDBMGIBPHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x899030", Offset = "0x897A30", VA = "0x180899030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string JCMPHFGEGGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x899040", Offset = "0x897A40", VA = "0x180899040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public MBBINPKMPNC KKFHDMDAGLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x898FD0", Offset = "0x8979D0", VA = "0x180898FD0")]
		[CompilerGenerated]
		get
		{
			return default(MBBINPKMPNC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x899000", Offset = "0x897A00", VA = "0x180899000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public Color? DELHCDIDDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x898FE0", Offset = "0x8979E0", VA = "0x180898FE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x899060", Offset = "0x897A60", VA = "0x180899060")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Color? NAHENIDAKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x899010", Offset = "0x897A10", VA = "0x180899010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x899080", Offset = "0x897A80", VA = "0x180899080")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x899090", Offset = "0x897A90", VA = "0x180899090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x899370", Offset = "0x897D70", VA = "0x180899370")]
	public BMPEOHPBKFN(PHFHGKAJGKD OADFIADCCGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class BBDIEEDDFKI
{
	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x898710", Offset = "0x897110", VA = "0x180898710")]
	public static PHFHGKAJGKD IOMBFOLLCBE(string GNDLAHHODLB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class PGKMHFELEFN
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8A54C0", Offset = "0x8A3EC0", VA = "0x1808A54C0")]
	public static DDBOOBFKEKF FPNDFMFDPNB(string LIPGCBEGDHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class MPDNGJOIEIJ : BBDDBOOJDHJ
{
	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x897DB0", Offset = "0x8967B0", VA = "0x180897DB0")]
	public MPDNGJOIEIJ(PHFHGKAJGKD OADFIADCCGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public abstract class BBDDBOOJDHJ : JAIHMKBLLEJ, MFCMMGCGDBG
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public string ILHIBKNOPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x897DE0", Offset = "0x8967E0", VA = "0x180897DE0", Slot = "27")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x897DC0", Offset = "0x8967C0", VA = "0x180897DC0", Slot = "28")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public Color? FEMELNLCHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x897E80", Offset = "0x896880", VA = "0x180897E80", Slot = "29")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x897DF0", Offset = "0x8967F0", VA = "0x180897DF0", Slot = "30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public Color? EJFHKCANEDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x897E10", Offset = "0x896810", VA = "0x180897E10", Slot = "31")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x897E30", Offset = "0x896830", VA = "0x180897E30", Slot = "32")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public List<BMPEOHPBKFN> DKFAKOFFKCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x897E50", Offset = "0x896850", VA = "0x180897E50", Slot = "26")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x897E60", Offset = "0x896860", VA = "0x180897E60", Slot = "33")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x897EA0", Offset = "0x8968A0", VA = "0x180897EA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x898120", Offset = "0x896B20", VA = "0x180898120")]
	public BBDDBOOJDHJ(PHFHGKAJGKD OADFIADCCGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class BAKPFIHPDMF : BBDDBOOJDHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x897DB0", Offset = "0x8967B0", VA = "0x180897DB0")]
	public BAKPFIHPDMF(PHFHGKAJGKD OADFIADCCGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LEFDOAHJGMN : JAIHMKBLLEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public PDFOLGIBEPO EIPIJFAALCO
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E30", Offset = "0x8A0830", VA = "0x1808A1E30")]
		[CompilerGenerated]
		get
		{
			return default(PDFOLGIBEPO);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E50", Offset = "0x8A0850", VA = "0x1808A1E50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool AOPGJMELLIB
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E40", Offset = "0x8A0840", VA = "0x1808A1E40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8A1E60", Offset = "0x8A0860", VA = "0x1808A1E60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Color? NCLOFJDKDJD
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x897E80", Offset = "0x896880", VA = "0x180897E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x897DF0", Offset = "0x8967F0", VA = "0x180897DF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8A1E70", Offset = "0x8A0870", VA = "0x1808A1E70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x8A20B0", Offset = "0x8A0AB0", VA = "0x1808A20B0")]
	public LEFDOAHJGMN(PHFHGKAJGKD OADFIADCCGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum MELOJEAIGOI
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	FULL,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	MODAL,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	SLIDEUP
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class LBMMGBJGELI : HFGHHMJEEFN
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public string HBIENOHNIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8988B0", Offset = "0x8972B0", VA = "0x1808988B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x898880", Offset = "0x897280", VA = "0x180898880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public string GPAANMJJPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x898850", Offset = "0x897250", VA = "0x180898850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8988A0", Offset = "0x8972A0", VA = "0x1808988A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public string DLEFHLBEBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x898870", Offset = "0x897270", VA = "0x180898870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x898860", Offset = "0x897260", VA = "0x180898860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x8A1200", Offset = "0x89FC00", VA = "0x1808A1200")]
	public LBMMGBJGELI(PHFHGKAJGKD OADFIADCCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x8A1040", Offset = "0x89FA40", VA = "0x1808A1040", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class MGNFNEMHMGH : HFGHHMJEEFN
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public string HBIENOHNIOO
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8988B0", Offset = "0x8972B0", VA = "0x1808988B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x898880", Offset = "0x897280", VA = "0x180898880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string GBJGOKBDMIN
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x898850", Offset = "0x897250", VA = "0x180898850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8988A0", Offset = "0x8972A0", VA = "0x1808988A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public string MONLPMOOGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x898870", Offset = "0x897270", VA = "0x180898870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x898860", Offset = "0x897260", VA = "0x180898860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string GPAANMJJPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x898840", Offset = "0x897240", VA = "0x180898840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x898890", Offset = "0x897290", VA = "0x180898890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public string DLEFHLBEBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x899950", Offset = "0x898350", VA = "0x180899950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x899980", Offset = "0x898380", VA = "0x180899980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x8A3520", Offset = "0x8A1F20", VA = "0x1808A3520")]
	public MGNFNEMHMGH(PHFHGKAJGKD OADFIADCCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x8A32D0", Offset = "0x8A1CD0", VA = "0x1808A32D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class HFGHHMJEEFN
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public string IBDAKIKBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894BC0", VA = "0x1808961C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public string EMAFAACIGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x899030", Offset = "0x897A30", VA = "0x180899030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool HDMPEEBJMBM
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x899870", Offset = "0x898270", VA = "0x180899870")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x899990", Offset = "0x898390", VA = "0x180899990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public long FDLFFEILBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x899AF0", Offset = "0x8984F0", VA = "0x180899AF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8999C0", Offset = "0x8983C0", VA = "0x1808999C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public long AGJKHNPCCDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x899AD0", Offset = "0x8984D0", VA = "0x180899AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public HashSet<ILFMCNFJKGC> GPGBCPGOGLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8999F0", Offset = "0x8983F0", VA = "0x1808999F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x899AB0", Offset = "0x8984B0", VA = "0x180899AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	private string JNNHGOHPMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x899930", Offset = "0x898330", VA = "0x180899930")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public Dictionary<string, string> HPFFANPFJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x899850", Offset = "0x898250", VA = "0x180899850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8999D0", Offset = "0x8983D0", VA = "0x1808999D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x89EB90", Offset = "0x89D590", VA = "0x18089EB90")]
	public HFGHHMJEEFN(PHFHGKAJGKD OADFIADCCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x89E810", Offset = "0x89D210", VA = "0x18089E810", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x89E630", Offset = "0x89D030", VA = "0x18089E630")]
	public string DNPDHLPMJIN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class LCDKMALBHOA : HFGHHMJEEFN
{
	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public string MONLPMOOGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8988B0", Offset = "0x8972B0", VA = "0x1808988B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x898880", Offset = "0x897280", VA = "0x180898880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public string HBIENOHNIOO
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x898850", Offset = "0x897250", VA = "0x180898850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8988A0", Offset = "0x8972A0", VA = "0x1808988A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public string GBJGOKBDMIN
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x898870", Offset = "0x897270", VA = "0x180898870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x898860", Offset = "0x897260", VA = "0x180898860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public string GPAANMJJPDC
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x898840", Offset = "0x897240", VA = "0x180898840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x898890", Offset = "0x897290", VA = "0x180898890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public string DLEFHLBEBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x899950", Offset = "0x898350", VA = "0x180899950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x899980", Offset = "0x898380", VA = "0x180899980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x8A1830", Offset = "0x8A0230", VA = "0x1808A1830")]
	public LCDKMALBHOA(PHFHGKAJGKD OADFIADCCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x8A15E0", Offset = "0x89FFE0", VA = "0x1808A15E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class BOBGOJHHENG
{
	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public string IBDAKIKBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894BC0", VA = "0x1808961C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public string EMAFAACIGEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x899030", Offset = "0x897A30", VA = "0x180899030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool HDMPEEBJMBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x899870", Offset = "0x898270", VA = "0x180899870")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x899990", Offset = "0x898390", VA = "0x180899990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public long FDLFFEILBCM
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x899AF0", Offset = "0x8984F0", VA = "0x180899AF0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8999C0", Offset = "0x8983C0", VA = "0x1808999C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public long GMAIKOEIHAO
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x899AD0", Offset = "0x8984D0", VA = "0x180899AD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public string HBIENOHNIOO
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x8999F0", Offset = "0x8983F0", VA = "0x1808999F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x899AB0", Offset = "0x8984B0", VA = "0x180899AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public string GBJGOKBDMIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x899AA0", Offset = "0x8984A0", VA = "0x180899AA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x899930", Offset = "0x898330", VA = "0x180899930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public string MONLPMOOGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x899850", Offset = "0x898250", VA = "0x180899850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8999D0", Offset = "0x8983D0", VA = "0x1808999D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public string GPAANMJJPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8988B0", Offset = "0x8972B0", VA = "0x1808988B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x898880", Offset = "0x897280", VA = "0x180898880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public string DLEFHLBEBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x898850", Offset = "0x897250", VA = "0x180898850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8988A0", Offset = "0x8972A0", VA = "0x1808988A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public bool IJDEDMFDDHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8999B0", Offset = "0x8983B0", VA = "0x1808999B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x899940", Offset = "0x898340", VA = "0x180899940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public bool MDEILCBOLMO
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x899920", Offset = "0x898320", VA = "0x180899920")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x899860", Offset = "0x898260", VA = "0x180899860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public bool FEJIPKCPIDC
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x899AC0", Offset = "0x8984C0", VA = "0x180899AC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8999E0", Offset = "0x8983E0", VA = "0x1808999E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public bool JBODDFNGFFO
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x899960", Offset = "0x898360", VA = "0x180899960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x899970", Offset = "0x898370", VA = "0x180899970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public bool LFEIELKAAHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x899AE0", Offset = "0x8984E0", VA = "0x180899AE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x899840", Offset = "0x898240", VA = "0x180899840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public string JNNHGOHPMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x898840", Offset = "0x897240", VA = "0x180898840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x898890", Offset = "0x897290", VA = "0x180898890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public Dictionary<string, string> HPFFANPFJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x899950", Offset = "0x898350", VA = "0x180899950")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x899980", Offset = "0x898380", VA = "0x180899980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x89A1B0", Offset = "0x898BB0", VA = "0x18089A1B0")]
	public BOBGOJHHENG(PHFHGKAJGKD OADFIADCCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x899B00", Offset = "0x898500", VA = "0x180899B00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x899A00", Offset = "0x898400", VA = "0x180899A00")]
	public void NBIECKPKJFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x899880", Offset = "0x898280", VA = "0x180899880")]
	public void CILFMDCOGLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class BIEIFDAOGNK : HFGHHMJEEFN
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public string GBJGOKBDMIN
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x8988B0", Offset = "0x8972B0", VA = "0x1808988B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x898880", Offset = "0x897280", VA = "0x180898880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public string MONLPMOOGMP
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x898850", Offset = "0x897250", VA = "0x180898850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x8988A0", Offset = "0x8972A0", VA = "0x1808988A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public string GPAANMJJPDC
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x898870", Offset = "0x897270", VA = "0x180898870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x898860", Offset = "0x897260", VA = "0x180898860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public string DLEFHLBEBNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x898840", Offset = "0x897240", VA = "0x180898840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x898890", Offset = "0x897290", VA = "0x180898890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x898AD0", Offset = "0x8974D0", VA = "0x180898AD0")]
	public BIEIFDAOGNK(PHFHGKAJGKD OADFIADCCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x8988C0", Offset = "0x8972C0", VA = "0x1808988C0", Slot = "3")]
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
		private HJCGKJLDALC BIKOLDCMIEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private FJGBJEIDJHO LFPKELOGGAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public EHFJBIMAIGA iamListener;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x899030", Offset = "0x897A30", VA = "0x180899030")]
		public void setPushPromptResponseReceivedDelegate(HJCGKJLDALC GCLKPCPPJME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x899040", Offset = "0x897A40", VA = "0x180899040")]
		public void setPushTokenReceivedFromSystemDelegate(FJGBJEIDJHO GCLKPCPPJME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x89B130", Offset = "0x899B30", VA = "0x18089B130")]
		public void onPushPromptResponseReceived(string AACHLKELPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x89B1A0", Offset = "0x899BA0", VA = "0x18089B1A0")]
		public void onPushTokenReceivedFromSystem(string FLLNLBHFENG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x89AA80", Offset = "0x899480", VA = "0x18089AA80")]
		public void beforeInAppMessageDisplayed(string NMAEPCIMKGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x89AE50", Offset = "0x899850", VA = "0x18089AE50")]
		public void onInAppMessageDismissed(string NMAEPCIMKGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x89ADF0", Offset = "0x8997F0", VA = "0x18089ADF0")]
		public void onInAppMessageClicked(string NMAEPCIMKGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x89AAE0", Offset = "0x8994E0", VA = "0x18089AAE0")]
		public void onInAppMessageButtonClicked(string BALBHHFOCFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x89AEB0", Offset = "0x8998B0", VA = "0x18089AEB0")]
		public void onInAppMessageHTMLClicked(string BALBHHFOCFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x897340", Offset = "0x895D40", VA = "0x180897340")]
		public BrazeInternalComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class BrazeInternalGameObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static GameObject NFEPGHCPILM;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private static GameObject DFEEMNKDOMA
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x89B1C0", Offset = "0x899BC0", VA = "0x18089B1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x89B360", Offset = "0x899D60", VA = "0x18089B360")]
		public static void setPushPromptResponseReceivedDelegate(HJCGKJLDALC GCLKPCPPJME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x89B3C0", Offset = "0x899DC0", VA = "0x18089B3C0")]
		public static void setPushTokenReceivedFromSystemDelegate(FJGBJEIDJHO GCLKPCPPJME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x89B300", Offset = "0x899D00", VA = "0x18089B300")]
		public static void setInAppMessageListener(EHFJBIMAIGA OBCPDOBKBOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x897340", Offset = "0x895D40", VA = "0x180897340")]
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
