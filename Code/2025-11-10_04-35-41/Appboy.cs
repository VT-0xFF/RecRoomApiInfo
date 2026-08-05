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
public interface WQZKPGRFYSL
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ApplePushNotificationTester : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xAA4F10", Offset = "0xAA4310", VA = "0x180AA4F10")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xAA49B0", Offset = "0xAA3DB0", VA = "0x180AA49B0")]
	public string PrintOutObjectValues(object o)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
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
		private static WQZKPGRFYSL OIDDWAZNAHZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static WQZKPGRFYSL HMYMIYCNQYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAA4970", Offset = "0xAA3D70", VA = "0x180AA4970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static UOIBGFDESGF CLQAEFCWKWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void LogCustomEvent(string eventName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void LogCustomEvent(string eventName, Dictionary<string, object> properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void LogPurchase(string productId, string currencyCode, decimal price)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void LogPurchase(string productId, string currencyCode, decimal price, int quantity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void LogPurchase(string productId, string currencyCode, decimal price, int quantity, Dictionary<string, object> properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void ChangeUser(string userId, [Optional] string sdkAuthSignature)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetSdkAuthenticationSignature(string sdkAuthSignature)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetUserFirstName(string firstName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetUserLastName(string lastName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetUserEmail(string email)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetUserGender(Gender gender)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetUserDateOfBirth(int year, int month, int day)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetUserCountry(string country)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetUserHomeCity(string city)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetUserEmailNotificationSubscriptionType(AppboyNotificationSubscriptionType emailNotificationSubscriptionType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetUserPushNotificationSubscriptionType(AppboyNotificationSubscriptionType pushNotificationSubscriptionType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetUserPhoneNumber(string phoneNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetCustomUserAttribute(string key, bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetCustomUserAttribute(string key, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetCustomUserAttribute(string key, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetCustomUserAttribute(string key, string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetCustomUserAttributeToNow(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetCustomUserAttributeToSecondsFromEpoch(string key, long secondsFromEpoch)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void UnsetCustomUserAttribute(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void IncrementCustomUserAttribute(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void IncrementCustomUserAttribute(string key, int incrementValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetCustomUserAttributeArray(string key, List<string> array, int size)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void AddToCustomUserAttributeArray(string key, string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void RemoveFromCustomUserAttributeArray(string key, string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void setUserFacebookData(string facebookId, string firstName, string lastName, string email, string bio, string cityName, Gender? gender, int? numberOfFriends, string birthday)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void setUserTwitterData(int? twitterUserId, string twitterHandle, string name, string description, int? followerCount, int? followingCount, int? tweetCount, string profileImageUrl)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetUserLastKnownLocation(double latitude, double longitude, [Optional] double? altitude, [Optional] double? accuracy, [Optional] double? verticalAccuracy)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void PromptUserForPushPermissions(bool provisional, [Optional] PushPromptResponseReceived responseDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetPushTokenReceivedFromSystemDelegate(PushTokenReceivedFromSystem tokenDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void LogInAppMessageClicked(string inAppMessageJSONString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void LogInAppMessageImpression(string inAppMessageJSONString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void LogInAppMessageButtonClicked(string inAppMessageJSONString, int buttonID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void RequestFeedRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void RequestFeedRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void LogFeedDisplayed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void RequestContentCardsRefresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void RequestContentCardsRefreshFromCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void LogContentCardClicked(string contentCardString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void LogContentCardImpression(string contentCardString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void LogContentCardDismissed(string contentCardString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void WipeData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void EnableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void DisableSDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920")]
		public static string GetInstallTrackingId()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetAttributionData(string network, string campaign, string adgroup, string creative)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void RequestLocationInitialization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void RequestGeofences(decimal latitude, decimal longitude)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void RequestImmediateDataFlush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void AddAlias(string alias, string label)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void ConfigureListener(BrazeUnityMessageType messageType, string gameobject, string method)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void SetInAppMessageDisplayAction(BrazeUnityInAppMessageDisplayActionType actionType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void DisplayNextInAppMessage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void DisplayContentCards()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void AddToSubscriptionGroup(string id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public static void RemoveFromSubscriptionGroup(string id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xAA4930", Offset = "0xAA3D30", VA = "0x180AA4930")]
		public AppboyBinding()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class UOIBGFDESGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Action<XMGCGMJHJFW> SEAXWXZTAFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public Action<XMGCGMJHJFW> WFCNUPKQAYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Action<XMGCGMJHJFW> XVCUGZDDGLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public Action<XMGCGMJHJFW, GMABWFVTCOL> YEFXISFGKLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public Action<XMGCGMJHJFW, Uri> WIUEPDYVCMU;
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AppboyBindingTester : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xAA4070", Offset = "0xAA3470", VA = "0x180AA4070")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xAA3F90", Offset = "0xAA3390", VA = "0x180AA3F90")]
		private void PFHTLOBJTRF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xAA38B0", Offset = "0xAA2CB0", VA = "0x180AA38B0")]
		private void AKPHQQBHFMB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xAA3920", Offset = "0xAA2D20", VA = "0x180AA3920")]
		private void GORMJMCWRLF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xAA40F0", Offset = "0xAA34F0", VA = "0x180AA40F0")]
		private void TXZZQKNQKFD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xAA41F0", Offset = "0xAA35F0", VA = "0x180AA41F0")]
		private void XHLZHAIXWGX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xAA4720", Offset = "0xAA3B20", VA = "0x180AA4720")]
		private void YBQIBGVKFZH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xAA3BD0", Offset = "0xAA2FD0", VA = "0x180AA3BD0")]
		private void IPLEUWFDKMX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xAA3990", Offset = "0xAA2D90", VA = "0x180AA3990")]
		private void GULVGIRTOVE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xAA42F0", Offset = "0xAA36F0", VA = "0x180AA42F0")]
		private void XJKEMOOFGVM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xAA4890", Offset = "0xAA3C90", VA = "0x180AA4890")]
		private void YVMGTOIVLZV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xAA3D40", Offset = "0xAA3140", VA = "0x180AA3D40")]
		public static void InAppMessageBeforeDisplayed(XMGCGMJHJFW message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAA3EA0", Offset = "0xAA32A0", VA = "0x180AA3EA0")]
		public static void InAppMessageDismissed(XMGCGMJHJFW message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xAA3E30", Offset = "0xAA3230", VA = "0x180AA3E30")]
		public static void InAppMessageClicked(XMGCGMJHJFW message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xAA3DB0", Offset = "0xAA31B0", VA = "0x180AA3DB0")]
		public static void InAppMessageButtonClicked(XMGCGMJHJFW message, GMABWFVTCOL button)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xAA3F10", Offset = "0xAA3310", VA = "0x180AA3F10")]
		public static void InAppMessageHTMLClicked(XMGCGMJHJFW message, Uri uri)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
		public AppboyBindingTester()
		{
		}
	}
}
namespace Appboy.Utilities
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class OTYPMWYEDYH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xAB0AE0", Offset = "0xAAFEE0", VA = "0x180AB0AE0")]
		public static string BDMZOJBVUCW(Dictionary<string, string> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x386F130", Offset = "0x386E530", VA = "0x18386F130")]
		public static string OBCAYHASZXQ<a>(List<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class BPAXYGIVWXU
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xAA5E10", Offset = "0xAA5210", VA = "0x180AA5E10")]
		public static Color? MKNVMUVNBWN(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAA5B40", Offset = "0xAA4F40", VA = "0x180AA5B40")]
		public static Color MKNVMUVNBWN(int a)
		{
			return default(Color);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DMWRTELPNVK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xAA90D0", Offset = "0xAA84D0", VA = "0x180AA90D0")]
		public static object WNIWTQLPHSC(Type a, string b, bool c, object d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class VCSPQZEEWXH
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xAB1000", Offset = "0xAB0400", VA = "0x180AB1000")]
		public static Dictionary<string, string> QSINJNXAUIJ(FRWVYHNKOUA a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class EZKGTBTFCGM
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		private sealed class KLLHTITQIMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private StringBuilder NUQWZLVARPX;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAAF220", Offset = "0xAAE620", VA = "0x180AAF220")]
			private KLLHTITQIMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAA9130", Offset = "0xAA8530", VA = "0x180AA9130")]
			public static string CQVTSUWTJSM(object a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAC0", Offset = "0xAADEC0", VA = "0x180AAEAC0")]
			private void OZDLMUEZKGJ(object a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xAAE7D0", Offset = "0xAADBD0", VA = "0x180AAE7D0")]
			private void KYOAAXWQHXZ(IDictionary a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xAAEC90", Offset = "0xAAE090", VA = "0x180AAEC90")]
			private void PBPUPBFDCXL(IList a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAAEEE0", Offset = "0xAAE2E0", VA = "0x180AAEEE0")]
			private void SYKFGJSPBOV(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xAAE560", Offset = "0xAAD960", VA = "0x180AAE560")]
			private void BNOQFCEGYLA(object a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static NumberFormatInfo EZPLMITEYCQ;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAA9130", Offset = "0xAA8530", VA = "0x180AA9130")]
		public static string CQVTSUWTJSM(object a)
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
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public virtual JSONNode this[string aKey]
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual string QEMSNQIEONV
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xAAC7B0", Offset = "0xAABBB0", VA = "0x180AAC7B0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public virtual int ULFDSOUXGUF
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public virtual int DGQOYZMSSWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xAAC3D0", Offset = "0xAAB7D0", VA = "0x180AAC3D0", Slot = "11")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xAAC6B0", Offset = "0xAABAB0", VA = "0x180AAC6B0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public virtual bool EMTBUBXDYMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xAAC720", Offset = "0xAABB20", VA = "0x180AAC720", Slot = "13")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAAC5B0", Offset = "0xAAB9B0", VA = "0x180AAC5B0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public virtual DLDOMTFFDNP BFCZZPZBIML
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAABA20", Offset = "0xAAAE20", VA = "0x180AABA20", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual FRWVYHNKOUA SAYSTVCJCYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAABA30", VA = "0x180AAC630", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
		public virtual void BLDQHHUMPZX(string a, JSONNode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xAAB9C0", Offset = "0xAAADC0", VA = "0x180AAB9C0", Slot = "10")]
		public virtual void BLDQHHUMPZX(JSONNode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xAAC6F0", Offset = "0xAABAF0", VA = "0x180AAC6F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xAAC370", Offset = "0xAAB770", VA = "0x180AAC370")]
		public static JSONNode JPYCDDHQRIR(string a)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xAAC2F0", Offset = "0xAAB6F0", VA = "0x180AAC2F0")]
		public static string JPYCDDHQRIR(JSONNode a)
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xAAC860", Offset = "0xAABC60", VA = "0x180AAC860")]
		public static bool ZWISVWGZSLY(JSONNode a, object b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xAAC7E0", Offset = "0xAABBE0", VA = "0x180AAC7E0")]
		public static bool ZPGHGHNXRJT(JSONNode a, object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAABAA0", Offset = "0xAAAEA0", VA = "0x180AABAA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xAA7D60", Offset = "0xAA7160", VA = "0x180AA7D60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAAC410", Offset = "0xAAB810", VA = "0x180AAC410")]
		internal static string NSILBFAOXHP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAABAB0", Offset = "0xAAAEB0", VA = "0x180AABAB0")]
		public static JSONNode IWYMAMBRLMF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public JSONNode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class DLDOMTFFDNP : JSONNode, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private sealed class OCVPIUARBQF : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private object JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public DLDOMTFFDNP MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private List<JSONNode>.Enumerator BPMZBLFMONE;

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object PNRLUNGDWHZ
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
			[DebuggerHidden]
			public OCVPIUARBQF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xAB0810", Offset = "0xAAFC10", VA = "0x180AB0810", Slot = "5")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xAB08E0", Offset = "0xAAFCE0", VA = "0x180AB08E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xAB0A90", Offset = "0xAAFE90", VA = "0x180AB0A90")]
			private void RYZDNTQONZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAB08A0", Offset = "0xAAFCA0", VA = "0x180AB08A0", Slot = "8")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<JSONNode> ICZAUVFFQIW;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public override JSONNode this[int aIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xAA9010", Offset = "0xAA8410", VA = "0x180AA9010", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override JSONNode this[string aKey]
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xAA8F90", Offset = "0xAA8390", VA = "0x180AA8F90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override int ULFDSOUXGUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xAA8CA0", Offset = "0xAA80A0", VA = "0x180AA8CA0", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAA8BF0", Offset = "0xAA7FF0", VA = "0x180AA8BF0", Slot = "4")]
		public override void BLDQHHUMPZX(string a, JSONNode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xAA8CE0", Offset = "0xAA80E0", VA = "0x180AA8CE0", Slot = "17")]
		[IteratorStateMachine(typeof(OCVPIUARBQF))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xAA8D50", Offset = "0xAA8150", VA = "0x180AA8D50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xAA8F10", Offset = "0xAA8310", VA = "0x180AA8F10")]
		public DLDOMTFFDNP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class FRWVYHNKOUA : JSONNode, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class OCQILNGTSEW : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private object JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public FRWVYHNKOUA MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private Dictionary<string, JSONNode>.Enumerator BPMZBLFMONE;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private object PNRLUNGDWHZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAB07E0", Offset = "0xAAFBE0", VA = "0x180AB07E0")]
			[DebuggerHidden]
			public OCQILNGTSEW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAB04A0", Offset = "0xAAF8A0", VA = "0x180AB04A0", Slot = "5")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAB0570", Offset = "0xAAF970", VA = "0x180AB0570", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAB0790", Offset = "0xAAFB90", VA = "0x180AB0790")]
			private void RYZDNTQONZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xAB0530", Offset = "0xAAF930", VA = "0x180AB0530", Slot = "8")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private Dictionary<string, JSONNode> ZXUBOPLYTRA;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override JSONNode this[string aKey]
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xAA9DB0", Offset = "0xAA91B0", VA = "0x180AA9DB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override JSONNode this[int aIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xAA9E90", Offset = "0xAA9290", VA = "0x180AA9E90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override int ULFDSOUXGUF
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAA9970", Offset = "0xAA8D70", VA = "0x180AA9970", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xAA9860", Offset = "0xAA8C60", VA = "0x180AA9860", Slot = "4")]
		public override void BLDQHHUMPZX(string a, JSONNode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAA99C0", Offset = "0xAA8DC0", VA = "0x180AA99C0", Slot = "17")]
		[IteratorStateMachine(typeof(OCQILNGTSEW))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAA9A30", Offset = "0xAA8E30", VA = "0x180AA9A30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xAA9D30", Offset = "0xAA9130", VA = "0x180AA9D30")]
		public FRWVYHNKOUA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class BRNNIXDXCUY : JSONNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private string HYISQPPUUIC;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public override string QEMSNQIEONV
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6010", Offset = "0xAA5410", VA = "0x180AA6010")]
		public BRNNIXDXCUY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xAA6050", Offset = "0xAA5450", VA = "0x180AA6050")]
		public BRNNIXDXCUY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAA5FD0", Offset = "0xAA53D0", VA = "0x180AA5FD0")]
		public BRNNIXDXCUY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xAA5F60", Offset = "0xAA5360", VA = "0x180AA5F60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal class DKFEUJYWMSC : JSONNode
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private JSONNode YIGLCZWCDBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private string SJISHTDNYQR;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public override JSONNode this[int aIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xAA8280", Offset = "0xAA7680", VA = "0x180AA8280", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override JSONNode this[string aKey]
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xAA8300", Offset = "0xAA7700", VA = "0x180AA8300", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override int DGQOYZMSSWP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xAA7D70", Offset = "0xAA7170", VA = "0x180AA7D70", Slot = "11")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xAA8020", Offset = "0xAA7420", VA = "0x180AA8020", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override bool EMTBUBXDYMW
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAA8120", Offset = "0xAA7520", VA = "0x180AA8120", Slot = "13")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAA7E30", Offset = "0xAA7230", VA = "0x180AA7E30", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override DLDOMTFFDNP BFCZZPZBIML
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0xAA7CA0", Offset = "0xAA70A0", VA = "0x180AA7CA0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override FRWVYHNKOUA SAYSTVCJCYR
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0xAA7F00", Offset = "0xAA7300", VA = "0x180AA7F00", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xAA81E0", Offset = "0xAA75E0", VA = "0x180AA81E0")]
		public DKFEUJYWMSC(JSONNode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xAA8230", Offset = "0xAA7630", VA = "0x180AA8230")]
		public DKFEUJYWMSC(JSONNode a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xAA7FB0", Offset = "0xAA73B0", VA = "0x180AA7FB0")]
		private void RRYYXUROFWW(JSONNode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0xAA7AE0", Offset = "0xAA6EE0", VA = "0x180AA7AE0", Slot = "10")]
		public override void BLDQHHUMPZX(JSONNode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAA7BB0", Offset = "0xAA6FB0", VA = "0x180AA7BB0", Slot = "4")]
		public override void BLDQHHUMPZX(string a, JSONNode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xAA7D50", Offset = "0xAA7150", VA = "0x180AA7D50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xAA7D60", Offset = "0xAA7160", VA = "0x180AA7D60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xAA80F0", Offset = "0xAA74F0", VA = "0x180AA80F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class YQVOEHLZMEY
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xAB3A90", Offset = "0xAB2E90", VA = "0x180AB3A90")]
		public static JSONNode IWYMAMBRLMF(string a)
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
	public class XMEXXPUHEIB
	{
		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public KHWEMZXUVON JMZSTNMPXVW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int CLCHOXCVEUF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public string HWTCSZGAHGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int XDIHXYSNDBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1B0", Offset = "0xAAA5B0", VA = "0x180AAB1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public IDictionary<string, object> STYLIDTSZAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xAB2F50", Offset = "0xAB2350", VA = "0x180AB2F50")]
		public XMEXXPUHEIB(FRWVYHNKOUA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xAB2290", Offset = "0xAB1690", VA = "0x180AB2290")]
		private object FOXMVUHOLVT(JSONNode a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAB2980", Offset = "0xAB1D80", VA = "0x180AB2980", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class KHWEMZXUVON
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public IList<string> XLEURCWYQOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string OLGWNKTDWEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string DQSBYJWBQAS
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string CPIVSSRNTYI
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string KVTCVPSONPU
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xAADF50", Offset = "0xAAD350", VA = "0x180AADF50")]
		public KHWEMZXUVON(FRWVYHNKOUA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xAADB10", Offset = "0xAACF10", VA = "0x180AADB10", Slot = "3")]
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
	public class DGSNWFXVBPU
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public List<WKKLGIHXOEE> JPTGHIWBROV
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private bool CKWKPLKOCQK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xAA7380", Offset = "0xAA6780", VA = "0x180AA7380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xAA75D0", Offset = "0xAA69D0", VA = "0x180AA75D0")]
		public DGSNWFXVBPU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xAA7390", Offset = "0xAA6790", VA = "0x180AA7390")]
		private static WKKLGIHXOEE DXSTWGEADDY(FRWVYHNKOUA a)
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
	public class LWODDSRVDER
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public string FMZKITTXEDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public string PVNXHJOCPXW
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string CWIMTPRYWAX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Dictionary<string, string> TGIATZSBBAZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int KQEEWKUIMXN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xAAF800", Offset = "0xAAEC00", VA = "0x180AAF800")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAAF7F0", Offset = "0xAAEBF0", VA = "0x180AAF7F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public long OKCCSRSQCMK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xAAF810", Offset = "0xAAEC10", VA = "0x180AAF810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public string HWAMSXIKRXK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xAAFAF0", Offset = "0xAAEEF0", VA = "0x180AAFAF0")]
		public LWODDSRVDER(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xAAF820", Offset = "0xAAEC20", VA = "0x180AAF820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xAAF470", Offset = "0xAAE870", VA = "0x180AAF470")]
		private string CHBDPYNXIDC(FRWVYHNKOUA a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xAAF610", Offset = "0xAAEA10", VA = "0x180AAF610")]
		private int DUTMDLRRCDQ(FRWVYHNKOUA a, string b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xAAF290", Offset = "0xAAE690", VA = "0x180AAF290")]
		private long AAUPSCUJYGP(FRWVYHNKOUA a, string b, long c)
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
	public interface XMGCGMJHJFW
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public interface BSORHHBJPXN
	{
		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		List<GMABWFVTCOL> WWVVWNIVYZF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public abstract class JZVFRWOKACW : XMGCGMJHJFW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		protected string LFBKFKJHLEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int XLSICDCXZFJ;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Color? RXVGDHPAKRH
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0xAACA30", Offset = "0xAABE30", VA = "0x180AACA30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8F0", Offset = "0xAABCF0", VA = "0x180AAC8F0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Color? CYHSJNCTSUI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xAACA10", Offset = "0xAABE10", VA = "0x180AACA10", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAAC900", Offset = "0xAABD00", VA = "0x180AAC900", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public string UWWYIIRHPNF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public Color? TCPJDCVRIHM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xAAC940", Offset = "0xAABD40", VA = "0x180AAC940", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9E0", Offset = "0xAABDE0", VA = "0x180AAC9E0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public Color? LVQHFDKJEXI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xAAD060", Offset = "0xAAC460", VA = "0x180AAD060", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xAAD030", Offset = "0xAAC430", VA = "0x180AAD030", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public string KVEYQORBFGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xAAD010", Offset = "0xAAC410", VA = "0x180AAD010", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xAAD050", Offset = "0xAAC450", VA = "0x180AAD050", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public string EZHNQEWUXQB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xAAD040", Offset = "0xAAC440", VA = "0x180AAD040", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9D0", Offset = "0xAABDD0", VA = "0x180AAC9D0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Dictionary<string, string> TGIATZSBBAZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9A0", Offset = "0xAABDA0", VA = "0x180AAC9A0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9F0", Offset = "0xAABDF0", VA = "0x180AAC9F0", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public ClickAction OGIRFAAZBCC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xAAC990", Offset = "0xAABD90", VA = "0x180AAC990", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(ClickAction);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xAACA50", Offset = "0xAABE50", VA = "0x180AACA50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string WUZFUKDTXFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9C0", Offset = "0xAABDC0", VA = "0x180AAC9C0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xAAC960", Offset = "0xAABD60", VA = "0x180AAC960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public DismissType CTBFAPOSAUE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xAAC9B0", Offset = "0xAABDB0", VA = "0x180AAC9B0", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return default(DismissType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xAAD020", Offset = "0xAAC420", VA = "0x180AAD020", Slot = "23")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public int EDEYOXZHUES
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980", Slot = "24")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xAAC910", Offset = "0xAABD10", VA = "0x180AAC910", Slot = "25")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAACA60", Offset = "0xAABE60", VA = "0x180AACA60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xAAD080", Offset = "0xAAC480", VA = "0x180AAD080")]
		public JZVFRWOKACW(FRWVYHNKOUA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class GMABWFVTCOL
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int AGSHWYMMPCT
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xAA3110", Offset = "0xAA2510", VA = "0x180AA3110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1D0", Offset = "0xAAA5D0", VA = "0x180AAB1D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public string NDLHNVCRWBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public string WUZFUKDTXFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public ClickAction QHAQPZDASFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0")]
			[CompilerGenerated]
			get
			{
				return default(ClickAction);
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1B0", Offset = "0xAAA5B0", VA = "0x180AAB1B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Color? CYHSJNCTSUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1E0", Offset = "0xAAA5E0", VA = "0x180AAB1E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xAAB190", Offset = "0xAAA590", VA = "0x180AAB190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public Color? RXVGDHPAKRH
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xAAB200", Offset = "0xAAA600", VA = "0x180AAB200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xAAB180", Offset = "0xAAA580", VA = "0x180AAB180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xAAB220", Offset = "0xAAA620", VA = "0x180AAB220", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xAAB4F0", Offset = "0xAAA8F0", VA = "0x180AAB4F0")]
		public GMABWFVTCOL(FRWVYHNKOUA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class PWPELBDXQPS
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xAB0D40", Offset = "0xAB0140", VA = "0x180AB0D40")]
		public static FRWVYHNKOUA GRAMOPZZVCW(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class NEADIZVZBVV
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xAB0240", Offset = "0xAAF640", VA = "0x180AB0240")]
		public static XMGCGMJHJFW JNMQLUMIBMT(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class SMHSTTKCVBU : CNTYJGABAZN
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xAB0FF0", Offset = "0xAB03F0", VA = "0x180AB0FF0")]
		public SMHSTTKCVBU(FRWVYHNKOUA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public abstract class CNTYJGABAZN : JZVFRWOKACW, BSORHHBJPXN
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public string EEYSIZHBKMX
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A40", Offset = "0xAA5E40", VA = "0x180AA6A40", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A70", Offset = "0xAA5E70", VA = "0x180AA6A70", Slot = "28")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public Color? ENMTKNRZMNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xAA6D80", Offset = "0xAA6180", VA = "0x180AA6D80", Slot = "29")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A90", Offset = "0xAA5E90", VA = "0x180AA6A90", Slot = "30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public Color? NPHUDLZCVDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xAA6D40", Offset = "0xAA6140", VA = "0x180AA6D40", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A50", Offset = "0xAA5E50", VA = "0x180AA6A50", Slot = "32")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public List<GMABWFVTCOL> WWVVWNIVYZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xAA6AB0", Offset = "0xAA5EB0", VA = "0x180AA6AB0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xAA6D60", Offset = "0xAA6160", VA = "0x180AA6D60", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xAA6AC0", Offset = "0xAA5EC0", VA = "0x180AA6AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xAA6DA0", Offset = "0xAA61A0", VA = "0x180AA6DA0")]
		public CNTYJGABAZN(FRWVYHNKOUA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class YSWNQAZHYXS : CNTYJGABAZN
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xAB0FF0", Offset = "0xAB03F0", VA = "0x180AB0FF0")]
		public YSWNQAZHYXS(FRWVYHNKOUA a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class YCBJLCMJDWF : JZVFRWOKACW
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public SlideFrom YHQBAWLGBZJ
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xAB3590", Offset = "0xAB2990", VA = "0x180AB3590")]
			[CompilerGenerated]
			get
			{
				return default(SlideFrom);
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAB3580", Offset = "0xAB2980", VA = "0x180AB3580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool PLZKKPKYSUR
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xAB35B0", Offset = "0xAB29B0", VA = "0x180AB35B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xAB35A0", Offset = "0xAB29A0", VA = "0x180AB35A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Color? LMKLFLMIQSQ
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xAA6D80", Offset = "0xAA6180", VA = "0x180AA6D80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A90", Offset = "0xAA5E90", VA = "0x180AA6A90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xAB35C0", Offset = "0xAB29C0", VA = "0x180AB35C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xAB37F0", Offset = "0xAB2BF0", VA = "0x180AB37F0")]
		public YCBJLCMJDWF(FRWVYHNKOUA a)
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
	public class FCVRKQNKKLM : WKKLGIHXOEE
	{
		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string ULATNKSBVEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public string GLFOLTSPFZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string YBUOFZNCXLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xAA3380", Offset = "0xAA2780", VA = "0x180AA3380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0xAA3130", Offset = "0xAA2530", VA = "0x180AA3130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xAA9470", Offset = "0xAA8870", VA = "0x180AA9470")]
		public FCVRKQNKKLM(FRWVYHNKOUA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xAA92B0", Offset = "0xAA86B0", VA = "0x180AA92B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class BLXAQDZQGBK : WKKLGIHXOEE
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string ULATNKSBVEA
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public string PVNXHJOCPXW
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3380", Offset = "0xAA2780", VA = "0x180AA3380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xAA3130", Offset = "0xAA2530", VA = "0x180AA3130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string GLFOLTSPFZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xAA3120", Offset = "0xAA2520", VA = "0x180AA3120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public string YBUOFZNCXLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xAA5380", Offset = "0xAA4780", VA = "0x180AA5380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA4790", VA = "0x180AA5390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA49F0", VA = "0x180AA55F0")]
		public BLXAQDZQGBK(FRWVYHNKOUA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAA53A0", Offset = "0xAA47A0", VA = "0x180AA53A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class WKKLGIHXOEE
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public string OWTIKKQZTTB
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string IRYCWFFEKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool GMIAKPSXXQK
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA010", Offset = "0xAA9410", VA = "0x180AAA010")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA830", Offset = "0xAA9C30", VA = "0x180AAA830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public long TRSQYXGWNLY
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA000", Offset = "0xAA9400", VA = "0x180AAA000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public long UJVOWTYBRVL
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA860", Offset = "0xAA9C60", VA = "0x180AAA860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public HashSet<CardCategory> UXTFGTWDCJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private string NJRGCOMBHXX
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Dictionary<string, string> TGIATZSBBAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xAB18F0", Offset = "0xAB0CF0", VA = "0x180AB18F0")]
		public WKKLGIHXOEE(FRWVYHNKOUA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xAB1580", Offset = "0xAB0980", VA = "0x180AB1580", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xAB1340", Offset = "0xAB0740", VA = "0x180AB1340")]
		public string KLGWOJFFTFA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class DKFLGLCHRME : WKKLGIHXOEE
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string ULATNKSBVEA
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string PVNXHJOCPXW
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xAA3380", Offset = "0xAA2780", VA = "0x180AA3380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAA3130", Offset = "0xAA2530", VA = "0x180AA3130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string GLFOLTSPFZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3120", Offset = "0xAA2520", VA = "0x180AA3120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public string YBUOFZNCXLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xAA5380", Offset = "0xAA4780", VA = "0x180AA5380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA4790", VA = "0x180AA5390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xAA85D0", Offset = "0xAA79D0", VA = "0x180AA85D0")]
		public DKFLGLCHRME(FRWVYHNKOUA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xAA8380", Offset = "0xAA7780", VA = "0x180AA8380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class FZVOAKZAUER
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public string OWTIKKQZTTB
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string IRYCWFFEKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0xAAA120", Offset = "0xAA9520", VA = "0x180AAA120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool GMIAKPSXXQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xAAA010", Offset = "0xAA9410", VA = "0x180AAA010")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xAAA830", Offset = "0xAA9C30", VA = "0x180AAA830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public long TRSQYXGWNLY
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA000", Offset = "0xAA9400", VA = "0x180AAA000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public long CVBLUUYUUJM
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA860", Offset = "0xAA9C60", VA = "0x180AAA860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public string ULATNKSBVEA
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA110", Offset = "0xAA9510", VA = "0x180AAA110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public string PVNXHJOCPXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public string GLFOLTSPFZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public string YBUOFZNCXLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public bool MLLAXKVSBLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xAA9F30", Offset = "0xAA9330", VA = "0x180AA9F30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xAAA040", Offset = "0xAA9440", VA = "0x180AAA040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public bool AQERWPQQYZQ
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xAA9FF0", Offset = "0xAA93F0", VA = "0x180AA9FF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA130", Offset = "0xAA9530", VA = "0x180AAA130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public bool HOJCVBECXMU
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xAAA850", Offset = "0xAA9C50", VA = "0x180AAA850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xAAA050", Offset = "0xAA9450", VA = "0x180AAA050")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool OVBPCMCSANU
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xAAA020", Offset = "0xAA9420", VA = "0x180AAA020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xAAA100", Offset = "0xAA9500", VA = "0x180AAA100")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool QNQWICWBFIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xAA9F40", Offset = "0xAA9340", VA = "0x180AA9F40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xAAA150", Offset = "0xAA9550", VA = "0x180AAA150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public string NJRGCOMBHXX
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xAA3120", Offset = "0xAA2520", VA = "0x180AA3120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Dictionary<string, string> TGIATZSBBAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0xAA5380", Offset = "0xAA4780", VA = "0x180AA5380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA4790", VA = "0x180AA5390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xAAA890", Offset = "0xAA9C90", VA = "0x180AAA890")]
		public FZVOAKZAUER(FRWVYHNKOUA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xAAA170", Offset = "0xAA9570", VA = "0x180AAA170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xAAA060", Offset = "0xAA9460", VA = "0x180AAA060")]
		public void OJOIZHUZGUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xAA9F50", Offset = "0xAA9350", VA = "0x180AA9F50")]
		public void HIYSGUXWPKM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class AAZYKGHRDVC : WKKLGIHXOEE
	{
		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public string PVNXHJOCPXW
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public string SKIARNWWPAU
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xAA33A0", Offset = "0xAA27A0", VA = "0x180AA33A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string GLFOLTSPFZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3380", Offset = "0xAA2780", VA = "0x180AA3380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xAA3130", Offset = "0xAA2530", VA = "0x180AA3130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public string YBUOFZNCXLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xAA3120", Offset = "0xAA2520", VA = "0x180AA3120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xAA33B0", Offset = "0xAA27B0", VA = "0x180AA33B0")]
		public AAZYKGHRDVC(FRWVYHNKOUA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0xAA3160", Offset = "0xAA2560", VA = "0x180AA3160", Slot = "3")]
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
		private PushPromptResponseReceived ELKRJTZPYWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private PushTokenReceivedFromSystem EWBJDUOEXCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public UOIBGFDESGF iamListener;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
		public void setPushPromptResponseReceivedDelegate(PushPromptResponseReceived responseDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xAA67D0", Offset = "0xAA5BD0", VA = "0x180AA67D0")]
		public void setPushTokenReceivedFromSystemDelegate(PushTokenReceivedFromSystem responseDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xAA6730", Offset = "0xAA5B30", VA = "0x180AA6730")]
		public void onPushPromptResponseReceived(string response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xAA67A0", Offset = "0xAA5BA0", VA = "0x180AA67A0")]
		public void onPushTokenReceivedFromSystem(string token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xAA6090", Offset = "0xAA5490", VA = "0x180AA6090")]
		public void beforeInAppMessageDisplayed(string messageJSON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xAA6450", Offset = "0xAA5850", VA = "0x180AA6450")]
		public void onInAppMessageDismissed(string messageJSON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xAA63F0", Offset = "0xAA57F0", VA = "0x180AA63F0")]
		public void onInAppMessageClicked(string messageJSON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0xAA60F0", Offset = "0xAA54F0", VA = "0x180AA60F0")]
		public void onInAppMessageButtonClicked(string argvJSON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0xAA64B0", Offset = "0xAA58B0", VA = "0x180AA64B0")]
		public void onInAppMessageHTMLClicked(string argvJSON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
		public BrazeInternalComponent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class BrazeInternalGameObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static GameObject HEWJBQCTFXH;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		private static GameObject LVYKDVFRYUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xAA67E0", Offset = "0xAA5BE0", VA = "0x180AA67E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6980", Offset = "0xAA5D80", VA = "0x180AA6980")]
		public static void setPushPromptResponseReceivedDelegate(PushPromptResponseReceived responseDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xAA69E0", Offset = "0xAA5DE0", VA = "0x180AA69E0")]
		public static void setPushTokenReceivedFromSystemDelegate(PushTokenReceivedFromSystem responseDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xAA6920", Offset = "0xAA5D20", VA = "0x180AA6920")]
		public static void setInAppMessageListener(UOIBGFDESGF inAppMessageListener)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
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
