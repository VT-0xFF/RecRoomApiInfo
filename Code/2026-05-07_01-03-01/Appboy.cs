using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Appboy.Models;
using Appboy.Models.Cards;
using Appboy.Models.InAppMessage;
using Appboy.Utilities;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface AQDLEKZKITD
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ApplePushNotificationTester : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xCD1AB0", Offset = "0xCD04B0", VA = "0x180CD1AB0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xCD1560", Offset = "0xCCFF60", VA = "0x180CD1560")]
	public string PrintOutObjectValues(object o)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xCD14B0", Offset = "0xCCFEB0", VA = "0x180CD14B0")]
	public ApplePushNotificationTester()
	{
	}
}
namespace Appboy
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum BrazeUnityMessageType
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
	public enum BrazeUnityInAppMessageDisplayActionType
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		IAM_DISPLAY_NOW,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		IAM_DISPLAY_LATER,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		IAM_DISCARD
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void PushPromptResponseReceived(bool granted);
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate void PushTokenReceivedFromSystem(string token);
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AppboyBinding : SingletonMonoBehaviour<AppboyBinding>
	{
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static AQDLEKZKITD GNZFEIJMQVL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static AQDLEKZKITD AHCXGZAKNBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCD1520", Offset = "0xCCFF20", VA = "0x180CD1520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static YGAGOCMUCBB HPVPSDIFVWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void LogCustomEvent(string eventName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void LogCustomEvent(string eventName, Dictionary<string, object> properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void LogPurchase(string productId, string currencyCode, decimal price)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void LogPurchase(string productId, string currencyCode, decimal price, int quantity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void LogPurchase(string productId, string currencyCode, decimal price, int quantity, Dictionary<string, object> properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void ChangeUser(string userId, [Optional] string sdkAuthSignature)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetSdkAuthenticationSignature(string sdkAuthSignature)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetUserFirstName(string firstName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetUserLastName(string lastName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetUserEmail(string email)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetUserGender(Gender gender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetUserDateOfBirth(int year, int month, int day)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetUserCountry(string country)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetUserHomeCity(string city)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetUserEmailNotificationSubscriptionType(AppboyNotificationSubscriptionType emailNotificationSubscriptionType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetUserPushNotificationSubscriptionType(AppboyNotificationSubscriptionType pushNotificationSubscriptionType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetUserPhoneNumber(string phoneNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetCustomUserAttribute(string key, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetCustomUserAttribute(string key, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetCustomUserAttribute(string key, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetCustomUserAttribute(string key, string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetCustomUserAttributeToNow(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetCustomUserAttributeToSecondsFromEpoch(string key, long secondsFromEpoch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void UnsetCustomUserAttribute(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void IncrementCustomUserAttribute(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void IncrementCustomUserAttribute(string key, int incrementValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetCustomUserAttributeArray(string key, List<string> array, int size)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void AddToCustomUserAttributeArray(string key, string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void RemoveFromCustomUserAttributeArray(string key, string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void setUserFacebookData(string facebookId, string firstName, string lastName, string email, string bio, string cityName, Gender? gender, int? numberOfFriends, string birthday)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void setUserTwitterData(int? twitterUserId, string twitterHandle, string name, string description, int? followerCount, int? followingCount, int? tweetCount, string profileImageUrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetUserLastKnownLocation(double latitude, double longitude, [Optional] double? altitude, [Optional] double? accuracy, [Optional] double? verticalAccuracy)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void PromptUserForPushPermissions(bool provisional, [Optional] PushPromptResponseReceived responseDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetPushTokenReceivedFromSystemDelegate(PushTokenReceivedFromSystem tokenDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void LogInAppMessageClicked(string inAppMessageJSONString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void LogInAppMessageImpression(string inAppMessageJSONString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void LogInAppMessageButtonClicked(string inAppMessageJSONString, int buttonID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void RequestFeedRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void RequestFeedRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void LogFeedDisplayed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void RequestContentCardsRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void RequestContentCardsRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void LogContentCardClicked(string contentCardString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void LogContentCardImpression(string contentCardString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void LogContentCardDismissed(string contentCardString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void WipeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void EnableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void DisableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0")]
		public static string GetInstallTrackingId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetAttributionData(string network, string campaign, string adgroup, string creative)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void RequestLocationInitialization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void RequestGeofences(decimal latitude, decimal longitude)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void RequestImmediateDataFlush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void AddAlias(string alias, string label)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void ConfigureListener(BrazeUnityMessageType messageType, string gameobject, string method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void SetInAppMessageDisplayAction(BrazeUnityInAppMessageDisplayActionType actionType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void DisplayNextInAppMessage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void DisplayContentCards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void AddToSubscriptionGroup(string id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public static void RemoveFromSubscriptionGroup(string id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xCD14E0", Offset = "0xCCFEE0", VA = "0x180CD14E0")]
		public AppboyBinding()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class YGAGOCMUCBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Action<FOCTOLUQHFA> LXORLUZTJYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public Action<FOCTOLUQHFA> LBAMJOJKREN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Action<FOCTOLUQHFA> EHZUKSILSOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public Action<FOCTOLUQHFA, XMKLSZGZSON> AUMRVGLAYWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public Action<FOCTOLUQHFA, Uri> KJMSYVOSMPM;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AppboyBindingTester : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xCD1180", Offset = "0xCCFB80", VA = "0x180CD1180")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xCD0A00", Offset = "0xCCF400", VA = "0x180CD0A00")]
		private void JMGBUIQSKGJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xCD1200", Offset = "0xCCFC00", VA = "0x180CD1200")]
		private void UMJSLPISQOH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xCD0460", Offset = "0xCCEE60", VA = "0x180CD0460")]
		private void AEIEAHOZGKR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xCD1080", Offset = "0xCCFA80", VA = "0x180CD1080")]
		private void RXKVNDWEGJJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xCD0900", Offset = "0xCCF300", VA = "0x180CD0900")]
		private void JLCRFOABJIZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xCD0AE0", Offset = "0xCCF4E0", VA = "0x180CD0AE0")]
		private void NWOEUPQEYNF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xCD0540", Offset = "0xCCEF40", VA = "0x180CD0540")]
		private void GEQXFMOWPRH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xCD1270", Offset = "0xCCFC70", VA = "0x180CD1270")]
		private void VCHDSYASFIA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xCD0C50", Offset = "0xCCF650", VA = "0x180CD0C50")]
		private void PJPBOLYWSXW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xCD04D0", Offset = "0xCCEED0", VA = "0x180CD04D0")]
		private void DHZXQFPUHHX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xCD06B0", Offset = "0xCCF0B0", VA = "0x180CD06B0")]
		public static void InAppMessageBeforeDisplayed(FOCTOLUQHFA message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xCD0810", Offset = "0xCCF210", VA = "0x180CD0810")]
		public static void InAppMessageDismissed(FOCTOLUQHFA message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xCD07A0", Offset = "0xCCF1A0", VA = "0x180CD07A0")]
		public static void InAppMessageClicked(FOCTOLUQHFA message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xCD0720", Offset = "0xCCF120", VA = "0x180CD0720")]
		public static void InAppMessageButtonClicked(FOCTOLUQHFA message, XMKLSZGZSON button)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xCD0880", Offset = "0xCCF280", VA = "0x180CD0880")]
		public static void InAppMessageHTMLClicked(FOCTOLUQHFA message, Uri uri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xCD14B0", Offset = "0xCCFEB0", VA = "0x180CD14B0")]
		public AppboyBindingTester()
		{
		}
	}
}
namespace Appboy.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class TXNYHFYBTZX
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xCDC3C0", Offset = "0xCDADC0", VA = "0x180CDC3C0")]
		public static string GGVVIDQQVAI(Dictionary<string, string> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3F52BD0", Offset = "0x3F515D0", VA = "0x183F52BD0")]
		public static string BBDQVCGHOWM<a>(List<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class YBOORNGSVJG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xCE06F0", Offset = "0xCDF0F0", VA = "0x180CE06F0")]
		public static Color? BRAKJVJRZFJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xCE0420", Offset = "0xCDEE20", VA = "0x180CE0420")]
		public static Color BRAKJVJRZFJ(int a)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PNVXASEHOVY
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xCD9FB0", Offset = "0xCD89B0", VA = "0x180CD9FB0")]
		public static object CDBQJAFJOGY(Type a, string b, bool c, object d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AFMDZIBDEXV
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xCD0120", Offset = "0xCCEB20", VA = "0x180CD0120")]
		public static Dictionary<string, string> LWQQPOYYAJZ(WMWDWUZLOKS a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class BCGNYNXEFRY
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private sealed class FUBHOUEZVHW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private StringBuilder GNCHSVYJVFF;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xCD5880", Offset = "0xCD4280", VA = "0x180CD5880")]
			private FUBHOUEZVHW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xCD1F20", Offset = "0xCD0920", VA = "0x180CD1F20")]
			public static string XQIXCNAGDPI(object a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xCD5370", Offset = "0xCD3D70", VA = "0x180CD5370")]
			private void OCIELEGXQTN(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xCD5080", Offset = "0xCD3A80", VA = "0x180CD5080")]
			private void KYYEQYITOPL(IDictionary a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xCD4E30", Offset = "0xCD3830", VA = "0x180CD4E30")]
			private void JAHSGUUJEVR(IList a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xCD5540", Offset = "0xCD3F40", VA = "0x180CD5540")]
			private void UAWARBHNLNN(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xCD4BC0", Offset = "0xCD35C0", VA = "0x180CD4BC0")]
			private void ATRLEZKHTKQ(object a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static NumberFormatInfo KBVLKCFEPHA;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xCD1F20", Offset = "0xCD0920", VA = "0x180CD1F20")]
		public static string XQIXCNAGDPI(object a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class JSONNode
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public virtual JSONNode this[int aIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public virtual JSONNode this[string aKey]
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual string YSLRVNQQVPD
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xCD68A0", Offset = "0xCD52A0", VA = "0x180CD68A0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public virtual int KQOHZIVUHAP
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xCD14D0", Offset = "0xCCFED0", VA = "0x180CD14D0", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public virtual int BBJNQILAFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xCD72A0", Offset = "0xCD5CA0", VA = "0x180CD72A0", Slot = "11")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xCD72E0", Offset = "0xCD5CE0", VA = "0x180CD72E0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public virtual bool LPLAMZEWFDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xCD7190", Offset = "0xCD5B90", VA = "0x180CD7190", Slot = "13")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xCD7220", Offset = "0xCD5C20", VA = "0x180CD7220", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public virtual RKSSNPJLYOL PZYOYNURIVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xCD6670", Offset = "0xCD5070", VA = "0x180CD6670", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual WMWDWUZLOKS SHZCNJTRKLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xCD7510", Offset = "0xCD5F10", VA = "0x180CD7510", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "4")]
		public virtual void SPFQXNEUWXR(string a, JSONNode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xCD73A0", Offset = "0xCD5DA0", VA = "0x180CD73A0", Slot = "10")]
		public virtual void SPFQXNEUWXR(JSONNode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xCD7400", Offset = "0xCD5E00", VA = "0x180CD7400", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xCD74B0", Offset = "0xCD5EB0", VA = "0x180CD74B0")]
		public static JSONNode VFJBORFPFZV(string a)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xCD7430", Offset = "0xCD5E30", VA = "0x180CD7430")]
		public static string VFJBORFPFZV(JSONNode a)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xCD7320", Offset = "0xCD5D20", VA = "0x180CD7320")]
		public static bool OTUOIXXRZSY(JSONNode a, object b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xCD68D0", Offset = "0xCD52D0", VA = "0x180CD68D0")]
		public static bool JSGIPYLAFHN(JSONNode a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xCD6890", Offset = "0xCD5290", VA = "0x180CD6890", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xCD43E0", Offset = "0xCD2DE0", VA = "0x180CD43E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xCD66F0", Offset = "0xCD50F0", VA = "0x180CD66F0")]
		internal static string EQQPNBSGHVJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xCD6950", Offset = "0xCD5350", VA = "0x180CD6950")]
		public static JSONNode KCLNZMAQWZB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public JSONNode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class RKSSNPJLYOL : JSONNode, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class NCVOSNWLXSX : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private object AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public RKSSNPJLYOL AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private List<JSONNode>.Enumerator ONPYAFUWWYM;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object ODDPXBAQQIJ
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xCD8B10", Offset = "0xCD7510", VA = "0x180CD8B10")]
			[DebuggerHidden]
			public NCVOSNWLXSX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xCD8B40", Offset = "0xCD7540", VA = "0x180CD8B40", Slot = "5")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xCD8BD0", Offset = "0xCD75D0", VA = "0x180CD8BD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xCD8D80", Offset = "0xCD7780", VA = "0x180CD8D80")]
			private void SMVYKFBVGYB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xCD8DD0", Offset = "0xCD77D0", VA = "0x180CD8DD0", Slot = "8")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<JSONNode> EAXWDNPCPAI;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override JSONNode this[int aIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xCDA660", Offset = "0xCD9060", VA = "0x180CDA660", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override JSONNode this[string aKey]
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xCDA720", Offset = "0xCD9120", VA = "0x180CDA720", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override int KQOHZIVUHAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xCDA3E0", Offset = "0xCD8DE0", VA = "0x180CDA3E0", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xCDA330", Offset = "0xCD8D30", VA = "0x180CDA330", Slot = "4")]
		public override void SPFQXNEUWXR(string a, JSONNode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xCDA2C0", Offset = "0xCD8CC0", VA = "0x180CDA2C0", Slot = "17")]
		[IteratorStateMachine(typeof(NCVOSNWLXSX))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xCDA420", Offset = "0xCD8E20", VA = "0x180CDA420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xCDA5E0", Offset = "0xCD8FE0", VA = "0x180CDA5E0")]
		public RKSSNPJLYOL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class WMWDWUZLOKS : JSONNode, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class NCQHVHCOOHO : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int KPYKIUTJAWU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private object AGGTFEUSTML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public WMWDWUZLOKS AFKVCRAYCVS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private Dictionary<string, JSONNode>.Enumerator ONPYAFUWWYM;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object ODDPXBAQQIJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private object KXFWSOWDLDQ
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xCD8B10", Offset = "0xCD7510", VA = "0x180CD8B10")]
			[DebuggerHidden]
			public NCQHVHCOOHO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xCD87C0", Offset = "0xCD71C0", VA = "0x180CD87C0", Slot = "5")]
			[DebuggerHidden]
			private void EAMCGMHRBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCD8850", Offset = "0xCD7250", VA = "0x180CD8850", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A80", Offset = "0xCD7480", VA = "0x180CD8A80")]
			private void SMVYKFBVGYB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xCD8AD0", Offset = "0xCD74D0", VA = "0x180CD8AD0", Slot = "8")]
			[DebuggerHidden]
			private void VVBIBJOVTIU()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private Dictionary<string, JSONNode> XJBCRZRPHNW;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override JSONNode this[string aKey]
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xCDEB40", Offset = "0xCDD540", VA = "0x180CDEB40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override JSONNode this[int aIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xCDEC20", Offset = "0xCDD620", VA = "0x180CDEC20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override int KQOHZIVUHAP
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xCDE770", Offset = "0xCDD170", VA = "0x180CDE770", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xCDE660", Offset = "0xCDD060", VA = "0x180CDE660", Slot = "4")]
		public override void SPFQXNEUWXR(string a, JSONNode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xCDE5F0", Offset = "0xCDCFF0", VA = "0x180CDE5F0", Slot = "17")]
		[IteratorStateMachine(typeof(NCQHVHCOOHO))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xCDE7C0", Offset = "0xCDD1C0", VA = "0x180CDE7C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAC0", Offset = "0xCDD4C0", VA = "0x180CDEAC0")]
		public WMWDWUZLOKS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class RLTDFHBFSPQ : JSONNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private string QVLSAKIFMGQ;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string YSLRVNQQVPD
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xCDA870", Offset = "0xCD9270", VA = "0x180CDA870")]
		public RLTDFHBFSPQ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xCDA7F0", Offset = "0xCD91F0", VA = "0x180CDA7F0")]
		public RLTDFHBFSPQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xCDA830", Offset = "0xCD9230", VA = "0x180CDA830")]
		public RLTDFHBFSPQ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xCDA7A0", Offset = "0xCD91A0", VA = "0x180CDA7A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal class FFMMFDCOEXO : JSONNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private JSONNode ZIZSWDTITOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private string KOLUUPHANFF;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override JSONNode this[int aIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xCD4AC0", Offset = "0xCD34C0", VA = "0x180CD4AC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override JSONNode this[string aKey]
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xCD4B40", Offset = "0xCD3540", VA = "0x180CD4B40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override int BBJNQILAFIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xCD4580", Offset = "0xCD2F80", VA = "0x180CD4580", Slot = "11")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xCD4640", Offset = "0xCD3040", VA = "0x180CD4640", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override bool LPLAMZEWFDK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xCD43F0", Offset = "0xCD2DF0", VA = "0x180CD43F0", Slot = "13")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xCD44B0", Offset = "0xCD2EB0", VA = "0x180CD44B0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override RKSSNPJLYOL PZYOYNURIVP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xCD4320", Offset = "0xCD2D20", VA = "0x180CD4320", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override WMWDWUZLOKS SHZCNJTRKLV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xCD4970", Offset = "0xCD3370", VA = "0x180CD4970", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xCD4A20", Offset = "0xCD3420", VA = "0x180CD4A20")]
		public FFMMFDCOEXO(JSONNode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xCD4A70", Offset = "0xCD3470", VA = "0x180CD4A70")]
		public FFMMFDCOEXO(JSONNode a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xCD4900", Offset = "0xCD3300", VA = "0x180CD4900")]
		private void UWLHHMTKSSQ(JSONNode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xCD4710", Offset = "0xCD3110", VA = "0x180CD4710", Slot = "10")]
		public override void SPFQXNEUWXR(JSONNode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xCD47E0", Offset = "0xCD31E0", VA = "0x180CD47E0", Slot = "4")]
		public override void SPFQXNEUWXR(string a, JSONNode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xCD43D0", Offset = "0xCD2DD0", VA = "0x180CD43D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xCD43E0", Offset = "0xCD2DE0", VA = "0x180CD43E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xCD48D0", Offset = "0xCD32D0", VA = "0x180CD48D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class UGSWDCQLJSG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xCDC620", Offset = "0xCDB020", VA = "0x180CDC620")]
		public static JSONNode KCLNZMAQWZB(string a)
		{
			return null;
		}
	}
}
namespace Appboy.Models
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public enum AppboyNotificationSubscriptionType
	{
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		OPTED_IN,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		SUBSCRIBED,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		UNSUBSCRIBED
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ETJUMEUZVAL
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public NKDUIUNWVQH LUNLTDMQPYW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int NCSNWCHNTFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCD36A0", Offset = "0xCD20A0", VA = "0x180CD36A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCD36B0", Offset = "0xCD20B0", VA = "0x180CD36B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string PDQUWLTLHSD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xCD27D0", Offset = "0xCD11D0", VA = "0x180CD27D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int ZZDRVWDQXFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xCD36C0", Offset = "0xCD20C0", VA = "0x180CD36C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xCD36E0", Offset = "0xCD20E0", VA = "0x180CD36E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public IDictionary<string, object> ENGDMFKHPDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CD0", Offset = "0xCD26D0", VA = "0x180CD3CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CE0", Offset = "0xCD26E0", VA = "0x180CD3CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xCD3CF0", Offset = "0xCD26F0", VA = "0x180CD3CF0")]
		public ETJUMEUZVAL(WMWDWUZLOKS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xCD2FB0", Offset = "0xCD19B0", VA = "0x180CD2FB0")]
		private object AXFXEUKUWTJ(JSONNode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xCD36F0", Offset = "0xCD20F0", VA = "0x180CD36F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class NKDUIUNWVQH
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IList<string> HEWMISSBNTP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string WGPDOUSJWSM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E10", Offset = "0xCD7810", VA = "0x180CD8E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string FPZGAEWSMMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xCD27D0", Offset = "0xCD11D0", VA = "0x180CD27D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string IBSYJYSAOAS
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xCD27E0", Offset = "0xCD11E0", VA = "0x180CD27E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string ELYJMHHYHVG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CD0", Offset = "0xCD26D0", VA = "0x180CD3CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CE0", Offset = "0xCD26E0", VA = "0x180CD3CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xCD9270", Offset = "0xCD7C70", VA = "0x180CD9270")]
		public NKDUIUNWVQH(WMWDWUZLOKS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xCD8E30", Offset = "0xCD7830", VA = "0x180CD8E30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public enum CardCategory
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
	public enum ClickAction
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		NEWS_FEED,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		URI,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		NONE
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public enum DismissType
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		AUTO_DISMISS,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		SWIPE
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class GGNENLRVBFS
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public List<WTPDVPPPWKW> XQFYMEWASTV
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private bool ZAYODMSIWUQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xCD5F00", Offset = "0xCD4900", VA = "0x180CD5F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xCD6150", Offset = "0xCD4B50", VA = "0x180CD6150")]
		public GGNENLRVBFS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xCD5F10", Offset = "0xCD4910", VA = "0x180CD5F10")]
		private static WTPDVPPPWKW VEHYUJTWRIA(WMWDWUZLOKS a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum Gender
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
	public class VUJXRDBOXVB
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public string VYWMSXFMTON
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string BOKCYCCXZHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E10", Offset = "0xCD7810", VA = "0x180CD8E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string QHAVJXGUJFL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xCD27D0", Offset = "0xCD11D0", VA = "0x180CD27D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Dictionary<string, string> XWSFLBUVKOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xCD27E0", Offset = "0xCD11E0", VA = "0x180CD27E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int FLACZWHCRDP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xCDD9E0", Offset = "0xCDC3E0", VA = "0x180CDD9E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xCDD820", Offset = "0xCDC220", VA = "0x180CDD820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public long STPAKPZZEWU
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xCDB330", Offset = "0xCD9D30", VA = "0x180CDB330")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xCDD9D0", Offset = "0xCDC3D0", VA = "0x180CDD9D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public string SUPLRWKDQOO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xCDB260", Offset = "0xCD9C60", VA = "0x180CDB260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xCDB280", Offset = "0xCD9C80", VA = "0x180CDB280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xCDDEA0", Offset = "0xCDC8A0", VA = "0x180CDDEA0")]
		public VUJXRDBOXVB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xCDD9F0", Offset = "0xCDC3F0", VA = "0x180CDD9F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xCDD830", Offset = "0xCDC230", VA = "0x180CDD830")]
		private string JIEHIWJRARU(WMWDWUZLOKS a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xCDDCC0", Offset = "0xCDC6C0", VA = "0x180CDDCC0")]
		private int ULKNMYAJFMY(WMWDWUZLOKS a, string b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xCDD640", Offset = "0xCDC040", VA = "0x180CDD640")]
		private long ADPFVQLJSJT(WMWDWUZLOKS a, string b, long c)
		{
			return default(long);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public enum SlideFrom
	{
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		TOP,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		BOTTOM
	}
}
namespace Appboy.Models.InAppMessage
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public interface FOCTOLUQHFA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface RVWCNUKMIGN
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		List<XMKLSZGZSON> AOTFWDPKFVT
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public abstract class LXPIMMGJPXW : FOCTOLUQHFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		protected string GGHDRRYGEFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int UKKPBXNJHWB;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color? MBZZCTAGJJZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xCD76C0", Offset = "0xCD60C0", VA = "0x180CD76C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xCD7700", Offset = "0xCD6100", VA = "0x180CD7700", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Color? UYWQUGWMCKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xCD7650", Offset = "0xCD6050", VA = "0x180CD7650", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xCD7D20", Offset = "0xCD6720", VA = "0x180CD7D20", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public string MPEJIWRIDBP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xCD7CF0", Offset = "0xCD66F0", VA = "0x180CD7CF0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xCD76A0", Offset = "0xCD60A0", VA = "0x180CD76A0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Color? LLIGUUMLPTW
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xCD7670", Offset = "0xCD6070", VA = "0x180CD7670", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xCD75D0", Offset = "0xCD5FD0", VA = "0x180CD75D0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Color? ETTFLGIXFSQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xCD75B0", Offset = "0xCD5FB0", VA = "0x180CD75B0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xCD7D00", Offset = "0xCD6700", VA = "0x180CD7D00", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public string EORRCYQQXQN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xCD75F0", Offset = "0xCD5FF0", VA = "0x180CD75F0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xCD75E0", Offset = "0xCD5FE0", VA = "0x180CD75E0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public string EZVZMXGFVQH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xCD7690", Offset = "0xCD6090", VA = "0x180CD7690", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xCD7D10", Offset = "0xCD6710", VA = "0x180CD7D10", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Dictionary<string, string> XWSFLBUVKOH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xCD75A0", Offset = "0xCD5FA0", VA = "0x180CD75A0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xCD7710", Offset = "0xCD6110", VA = "0x180CD7710", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public ClickAction NPZOWPBODAY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xCD76E0", Offset = "0xCD60E0", VA = "0x180CD76E0", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(ClickAction);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xCD7730", Offset = "0xCD6130", VA = "0x180CD7730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string LGEZGNVEPPM
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xCD76F0", Offset = "0xCD60F0", VA = "0x180CD76F0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xCD7630", Offset = "0xCD6030", VA = "0x180CD7630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public DismissType DSKBARGXXUO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xCD76B0", Offset = "0xCD60B0", VA = "0x180CD76B0", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return default(DismissType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xCD7D30", Offset = "0xCD6730", VA = "0x180CD7D30", Slot = "23")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int USSTVRVIIKY
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xCD36A0", Offset = "0xCD20A0", VA = "0x180CD36A0", Slot = "24")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xCD7600", Offset = "0xCD6000", VA = "0x180CD7600", Slot = "25")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xCD7740", Offset = "0xCD6140", VA = "0x180CD7740", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xCD7D40", Offset = "0xCD6740", VA = "0x180CD7D40")]
		public LXPIMMGJPXW(WMWDWUZLOKS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class XMKLSZGZSON
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int GFRJSZRRSCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xCD0110", Offset = "0xCCEB10", VA = "0x180CD0110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xCDFF30", Offset = "0xCDE930", VA = "0x180CDFF30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public string TBADZHMKSFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E10", Offset = "0xCD7810", VA = "0x180CD8E10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public string LGEZGNVEPPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xCD27D0", Offset = "0xCD11D0", VA = "0x180CD27D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public ClickAction SXKOSASYYXM
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xCD36C0", Offset = "0xCD20C0", VA = "0x180CD36C0")]
			[CompilerGenerated]
			get
			{
				return default(ClickAction);
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xCD36E0", Offset = "0xCD20E0", VA = "0x180CD36E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Color? UYWQUGWMCKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xCDFC10", Offset = "0xCDE610", VA = "0x180CDFC10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xCDFF40", Offset = "0xCDE940", VA = "0x180CDFF40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Color? MBZZCTAGJJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xCDFC30", Offset = "0xCDE630", VA = "0x180CDFC30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xCDFC50", Offset = "0xCDE650", VA = "0x180CDFC50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xCDFC60", Offset = "0xCDE660", VA = "0x180CDFC60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xCDFF50", Offset = "0xCDE950", VA = "0x180CDFF50")]
		public XMKLSZGZSON(WMWDWUZLOKS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RCACVQEKONA
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xCDA190", Offset = "0xCD8B90", VA = "0x180CDA190")]
		public static WMWDWUZLOKS CUNJONBHSXS(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class ZIVRPZJDBHT
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xCE0840", Offset = "0xCDF240", VA = "0x180CE0840")]
		public static FOCTOLUQHFA HNIQEUJIAYN(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class GXNCLVBVBMA : SDDKPJYZMND
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xCD6660", Offset = "0xCD5060", VA = "0x180CD6660")]
		public GXNCLVBVBMA(WMWDWUZLOKS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public abstract class SDDKPJYZMND : LXPIMMGJPXW, RVWCNUKMIGN
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public string MJKQEYJZFIF
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xCDA8F0", Offset = "0xCD92F0", VA = "0x180CDA8F0", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xCDA8D0", Offset = "0xCD92D0", VA = "0x180CDA8D0", Slot = "28")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Color? QWGRHWCQADX
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xCD2AB0", Offset = "0xCD14B0", VA = "0x180CD2AB0", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xCD2A80", Offset = "0xCD1480", VA = "0x180CD2A80", Slot = "30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public Color? FSZAOFMXCQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xCDABA0", Offset = "0xCD95A0", VA = "0x180CDABA0", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xCDAB80", Offset = "0xCD9580", VA = "0x180CDAB80", Slot = "32")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public List<XMKLSZGZSON> AOTFWDPKFVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xCDABC0", Offset = "0xCD95C0", VA = "0x180CDABC0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xCDA8B0", Offset = "0xCD92B0", VA = "0x180CDA8B0", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xCDA900", Offset = "0xCD9300", VA = "0x180CDA900", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xCDABD0", Offset = "0xCD95D0", VA = "0x180CDABD0")]
		public SDDKPJYZMND(WMWDWUZLOKS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class WLURIBRQOPI : SDDKPJYZMND
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xCD6660", Offset = "0xCD5060", VA = "0x180CD6660")]
		public WLURIBRQOPI(WMWDWUZLOKS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class DOAVUVRCATV : LXPIMMGJPXW
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public SlideFrom GIMKAZWVWKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xCD2A60", Offset = "0xCD1460", VA = "0x180CD2A60")]
			[CompilerGenerated]
			get
			{
				return default(SlideFrom);
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xCD2AD0", Offset = "0xCD14D0", VA = "0x180CD2AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool EXRQCZFKCPB
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xCD2A70", Offset = "0xCD1470", VA = "0x180CD2A70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xCD2AA0", Offset = "0xCD14A0", VA = "0x180CD2AA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Color? EMPXRNSCTGG
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xCD2AB0", Offset = "0xCD14B0", VA = "0x180CD2AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xCD2A80", Offset = "0xCD1480", VA = "0x180CD2A80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xCD2AE0", Offset = "0xCD14E0", VA = "0x180CD2AE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xCD2D10", Offset = "0xCD1710", VA = "0x180CD2D10")]
		public DOAVUVRCATV(WMWDWUZLOKS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public enum InAppMessageType
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		FULL,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		MODAL,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		SLIDEUP
	}
}
namespace Appboy.Models.Cards
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class GCLMEWCZOYQ : WTPDVPPPWKW
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string NROMTDSEHQG
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xCD5930", Offset = "0xCD4330", VA = "0x180CD5930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xCD5910", Offset = "0xCD4310", VA = "0x180CD5910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string CEYGUKWWDCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xCD58F0", Offset = "0xCD42F0", VA = "0x180CD58F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xCD5B00", Offset = "0xCD4500", VA = "0x180CD5B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string MXJRVMJYGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xCD5900", Offset = "0xCD4300", VA = "0x180CD5900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xCD5920", Offset = "0xCD4320", VA = "0x180CD5920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xCD5B10", Offset = "0xCD4510", VA = "0x180CD5B10")]
		public GCLMEWCZOYQ(WMWDWUZLOKS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xCD5940", Offset = "0xCD4340", VA = "0x180CD5940", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class VRMKSCDANMW : WTPDVPPPWKW
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string NROMTDSEHQG
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xCD5930", Offset = "0xCD4330", VA = "0x180CD5930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xCD5910", Offset = "0xCD4310", VA = "0x180CD5910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string BOKCYCCXZHA
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xCD58F0", Offset = "0xCD42F0", VA = "0x180CD58F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xCD5B00", Offset = "0xCD4500", VA = "0x180CD5B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public string INKXTWOQDBI
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xCD5900", Offset = "0xCD4300", VA = "0x180CD5900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xCD5920", Offset = "0xCD4320", VA = "0x180CD5920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string CEYGUKWWDCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xCD9880", Offset = "0xCD8280", VA = "0x180CD9880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xCD9890", Offset = "0xCD8290", VA = "0x180CD9890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public string MXJRVMJYGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xCDB1B0", Offset = "0xCD9BB0", VA = "0x180CDB1B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xCDB340", Offset = "0xCD9D40", VA = "0x180CDB340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xCDC880", Offset = "0xCDB280", VA = "0x180CDC880")]
		public VRMKSCDANMW(WMWDWUZLOKS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xCDC630", Offset = "0xCDB030", VA = "0x180CDC630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class WTPDVPPPWKW
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string LPMCNUEWAXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string MERZPCICCKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E10", Offset = "0xCD7810", VA = "0x180CD8E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool CUSEHCEHCDW
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xCDB270", Offset = "0xCD9C70", VA = "0x180CDB270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xCDB290", Offset = "0xCD9C90", VA = "0x180CDB290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public long XINXYIVTTYY
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xCDB2F0", Offset = "0xCD9CF0", VA = "0x180CDB2F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public long ISBJWURAWRR
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CD0", Offset = "0xCD26D0", VA = "0x180CD3CD0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xCDB320", Offset = "0xCD9D20", VA = "0x180CDB320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public HashSet<CardCategory> DDCIIPIVRDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xCDB330", Offset = "0xCD9D30", VA = "0x180CDB330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xCDB2C0", Offset = "0xCD9CC0", VA = "0x180CDB2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private string HIDBMCPFFSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xCDB280", Offset = "0xCD9C80", VA = "0x180CDB280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Dictionary<string, string> XWSFLBUVKOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0xCD7CF0", Offset = "0xCD66F0", VA = "0x180CD7CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xCD76A0", Offset = "0xCD60A0", VA = "0x180CD76A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xCDF270", Offset = "0xCDDC70", VA = "0x180CDF270")]
		public WTPDVPPPWKW(WMWDWUZLOKS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xCDEF00", Offset = "0xCDD900", VA = "0x180CDEF00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xCDECC0", Offset = "0xCDD6C0", VA = "0x180CDECC0")]
		public string SOABARUKDUY()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class VUHHSTSBVRU : WTPDVPPPWKW
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string INKXTWOQDBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xCD5930", Offset = "0xCD4330", VA = "0x180CD5930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xCD5910", Offset = "0xCD4310", VA = "0x180CD5910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string NROMTDSEHQG
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xCD58F0", Offset = "0xCD42F0", VA = "0x180CD58F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xCD5B00", Offset = "0xCD4500", VA = "0x180CD5B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string BOKCYCCXZHA
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xCD5900", Offset = "0xCD4300", VA = "0x180CD5900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xCD5920", Offset = "0xCD4320", VA = "0x180CD5920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string CEYGUKWWDCN
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xCD9880", Offset = "0xCD8280", VA = "0x180CD9880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xCD9890", Offset = "0xCD8290", VA = "0x180CD9890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string MXJRVMJYGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xCDB1B0", Offset = "0xCD9BB0", VA = "0x180CDB1B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xCDB340", Offset = "0xCD9D40", VA = "0x180CDB340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xCDD020", Offset = "0xCDBA20", VA = "0x180CDD020")]
		public VUHHSTSBVRU(WMWDWUZLOKS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xCDCDD0", Offset = "0xCDB7D0", VA = "0x180CDCDD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class TNHADAWSSNJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string LPMCNUEWAXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string MERZPCICCKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0xCD8A70", Offset = "0xCD7470", VA = "0x180CD8A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E10", Offset = "0xCD7810", VA = "0x180CD8E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool CUSEHCEHCDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xCDB270", Offset = "0xCD9C70", VA = "0x180CDB270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xCDB290", Offset = "0xCD9C90", VA = "0x180CDB290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public long XINXYIVTTYY
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xCD8E20", Offset = "0xCD7820", VA = "0x180CD8E20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0xCDB2F0", Offset = "0xCD9CF0", VA = "0x180CDB2F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public long PSEQAUVNHWA
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CD0", Offset = "0xCD26D0", VA = "0x180CD3CD0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xCDB320", Offset = "0xCD9D20", VA = "0x180CDB320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public string NROMTDSEHQG
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xCDB330", Offset = "0xCD9D30", VA = "0x180CDB330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xCDB2C0", Offset = "0xCD9CC0", VA = "0x180CDB2C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string BOKCYCCXZHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xCDB260", Offset = "0xCD9C60", VA = "0x180CDB260")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xCDB280", Offset = "0xCD9C80", VA = "0x180CDB280")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public string INKXTWOQDBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xCD7CF0", Offset = "0xCD66F0", VA = "0x180CD7CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xCD76A0", Offset = "0xCD60A0", VA = "0x180CD76A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public string CEYGUKWWDCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xCD5930", Offset = "0xCD4330", VA = "0x180CD5930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xCD5910", Offset = "0xCD4310", VA = "0x180CD5910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public string MXJRVMJYGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xCD58F0", Offset = "0xCD42F0", VA = "0x180CD58F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xCD5B00", Offset = "0xCD4500", VA = "0x180CD5B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public bool KQIJZMJVZQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xCDBAB0", Offset = "0xCDA4B0", VA = "0x180CDBAB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xCDB2D0", Offset = "0xCD9CD0", VA = "0x180CDB2D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public bool AEJXYOXNRSA
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xCDB300", Offset = "0xCD9D00", VA = "0x180CDB300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xCDB2B0", Offset = "0xCD9CB0", VA = "0x180CDB2B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool SBHKVYAGOIO
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xCDBA00", Offset = "0xCDA400", VA = "0x180CDBA00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xCDB310", Offset = "0xCD9D10", VA = "0x180CDB310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool RSSKSDHZVAE
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xCDBAC0", Offset = "0xCDA4C0", VA = "0x180CDBAC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xCDB2E0", Offset = "0xCD9CE0", VA = "0x180CDB2E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool AVLDFRNPNPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xCDB2A0", Offset = "0xCD9CA0", VA = "0x180CDB2A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xCDB350", Offset = "0xCD9D50", VA = "0x180CDB350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public string HIDBMCPFFSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xCD9880", Offset = "0xCD8280", VA = "0x180CD9880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xCD9890", Offset = "0xCD8290", VA = "0x180CD9890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Dictionary<string, string> XWSFLBUVKOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xCDB1B0", Offset = "0xCD9BB0", VA = "0x180CDB1B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xCDB340", Offset = "0xCD9D40", VA = "0x180CDB340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xCDBAD0", Offset = "0xCDA4D0", VA = "0x180CDBAD0")]
		public TNHADAWSSNJ(WMWDWUZLOKS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xCDB360", Offset = "0xCD9D60", VA = "0x180CDB360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xCDBA10", Offset = "0xCDA410", VA = "0x180CDBA10")]
		public void XXZJDNIISED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xCDB1C0", Offset = "0xCD9BC0", VA = "0x180CDB1C0")]
		public void IYEMOGOYKIO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class NMUJHAQPRYS : WTPDVPPPWKW
	{
		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public string BOKCYCCXZHA
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xCD5930", Offset = "0xCD4330", VA = "0x180CD5930")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xCD5910", Offset = "0xCD4310", VA = "0x180CD5910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public string INKXTWOQDBI
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xCD58F0", Offset = "0xCD42F0", VA = "0x180CD58F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xCD5B00", Offset = "0xCD4500", VA = "0x180CD5B00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string CEYGUKWWDCN
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xCD5900", Offset = "0xCD4300", VA = "0x180CD5900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xCD5920", Offset = "0xCD4320", VA = "0x180CD5920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string MXJRVMJYGEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xCD9880", Offset = "0xCD8280", VA = "0x180CD9880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xCD9890", Offset = "0xCD8290", VA = "0x180CD9890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xCD9AB0", Offset = "0xCD84B0", VA = "0x180CD9AB0")]
		public NMUJHAQPRYS(WMWDWUZLOKS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xCD98A0", Offset = "0xCD82A0", VA = "0x180CD98A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
namespace Appboy.Internal
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class BrazeInternalComponent : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private PushPromptResponseReceived FWHIFDJYZBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private PushTokenReceivedFromSystem VSMFQQQHTDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public YGAGOCMUCBB iamListener;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xCD27D0", Offset = "0xCD11D0", VA = "0x180CD27D0")]
		public void setPushPromptResponseReceivedDelegate(PushPromptResponseReceived responseDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xCD27E0", Offset = "0xCD11E0", VA = "0x180CD27E0")]
		public void setPushTokenReceivedFromSystemDelegate(PushTokenReceivedFromSystem responseDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xCD2740", Offset = "0xCD1140", VA = "0x180CD2740")]
		public void onPushPromptResponseReceived(string response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xCD27B0", Offset = "0xCD11B0", VA = "0x180CD27B0")]
		public void onPushTokenReceivedFromSystem(string token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xCD20A0", Offset = "0xCD0AA0", VA = "0x180CD20A0")]
		public void beforeInAppMessageDisplayed(string messageJSON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xCD2460", Offset = "0xCD0E60", VA = "0x180CD2460")]
		public void onInAppMessageDismissed(string messageJSON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xCD2400", Offset = "0xCD0E00", VA = "0x180CD2400")]
		public void onInAppMessageClicked(string messageJSON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xCD2100", Offset = "0xCD0B00", VA = "0x180CD2100")]
		public void onInAppMessageButtonClicked(string argvJSON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xCD24C0", Offset = "0xCD0EC0", VA = "0x180CD24C0")]
		public void onInAppMessageHTMLClicked(string argvJSON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xCD14B0", Offset = "0xCCFEB0", VA = "0x180CD14B0")]
		public BrazeInternalComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class BrazeInternalGameObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static GameObject NAWLPYDHEIX;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private static GameObject IWMDTGRRYAH
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xCD27F0", Offset = "0xCD11F0", VA = "0x180CD27F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xCD29A0", Offset = "0xCD13A0", VA = "0x180CD29A0")]
		public static void setPushPromptResponseReceivedDelegate(PushPromptResponseReceived responseDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xCD2A00", Offset = "0xCD1400", VA = "0x180CD2A00")]
		public static void setPushTokenReceivedFromSystemDelegate(PushTokenReceivedFromSystem responseDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xCD2940", Offset = "0xCD1340", VA = "0x180CD2940")]
		public static void setInAppMessageListener(YGAGOCMUCBB inAppMessageListener)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xCD14B0", Offset = "0xCCFEB0", VA = "0x180CD14B0")]
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
