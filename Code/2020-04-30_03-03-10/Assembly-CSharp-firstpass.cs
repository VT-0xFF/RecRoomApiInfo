using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Beebyte.Obfuscator;
using Cpp2IlInjected;
using ExitGames.Client.Photon.LoadBalancing;
using ExitGames.Client.Photon.Voice;
using POpusCodec;
using POpusCodec.Enums;
using RecRoom;
using RecRoom.StreamingAudio;
using SA.Foundation.PropertyDrawers.Attributes;
using SA.Foundation.Templates;
using SA.Foundation.Tests;
using SA.iOS.Contacts;
using SA.iOS.CoreLocation;
using SA.iOS.Foundation;
using SA.iOS.GameKit;
using SA.iOS.MediaPlayer;
using SA.iOS.ReplayKit;
using SA.iOS.StoreKit;
using SA.iOS.UIKit;
using SA.iOS.UserNotifications;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class AFInAppEvents
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public const string LEVEL_ACHIEVED = "af_level_achieved";

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public const string ADD_PAYMENT_INFO = "af_add_payment_info";

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public const string ADD_TO_CART = "af_add_to_cart";

	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public const string ADD_TO_WISH_LIST = "af_add_to_wishlist";

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public const string COMPLETE_REGISTRATION = "af_complete_registration";

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public const string TUTORIAL_COMPLETION = "af_tutorial_completion";

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public const string INITIATED_CHECKOUT = "af_initiated_checkout";

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public const string PURCHASE = "af_purchase";

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public const string RATE = "af_rate";

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public const string SEARCH = "af_search";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const string SPENT_CREDIT = "af_spent_credits";

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public const string ACHIEVEMENT_UNLOCKED = "af_achievement_unlocked";

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public const string CONTENT_VIEW = "af_content_view";

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public const string TRAVEL_BOOKING = "af_travel_booking";

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public const string SHARE = "af_share";

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public const string INVITE = "af_invite";

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public const string LOGIN = "af_login";

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public const string RE_ENGAGE = "af_re_engage";

	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const string UPDATE = "af_update";

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public const string OPENED_FROM_PUSH_NOTIFICATION = "af_opened_from_push_notification";

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const string LOCATION_CHANGED = "af_location_changed";

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public const string LOCATION_COORDINATES = "af_location_coordinates";

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public const string ORDER_ID = "af_order_id";

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public const string LEVEL = "af_level";

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public const string SCORE = "af_score";

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public const string SUCCESS = "af_success";

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public const string PRICE = "af_price";

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const string CONTENT_TYPE = "af_content_type";

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public const string CONTENT_ID = "af_content_id";

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public const string CONTENT_LIST = "af_content_list";

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public const string CURRENCY = "af_currency";

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public const string QUANTITY = "af_quantity";

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public const string REGSITRATION_METHOD = "af_registration_method";

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public const string PAYMENT_INFO_AVAILIBLE = "af_payment_info_available";

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public const string MAX_RATING_VALUE = "af_max_rating_value";

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public const string RATING_VALUE = "af_rating_value";

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public const string SEARCH_STRING = "af_search_string";

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public const string DATE_A = "af_date_a";

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public const string DATE_B = "af_date_b";

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public const string DESTINATION_A = "af_destination_a";

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public const string DESTINATION_B = "af_destination_b";

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public const string DESCRIPTION = "af_description";

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const string CLASS = "af_class";

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const string EVENT_START = "af_event_start";

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public const string EVENT_END = "af_event_end";

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public const string LATITUDE = "af_lat";

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public const string LONGTITUDE = "af_long";

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public const string CUSTOMER_USER_ID = "af_customer_user_id";

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public const string VALIDATED = "af_validated";

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public const string REVENUE = "af_revenue";

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public const string RECEIPT_ID = "af_receipt_id";

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public const string PARAM_1 = "af_param_1";

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public const string PARAM_2 = "af_param_2";

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public const string PARAM_3 = "af_param_3";

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public const string PARAM_4 = "af_param_4";

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public const string PARAM_5 = "af_param_5";

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public const string PARAM_6 = "af_param_6";

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public const string PARAM_7 = "af_param_7";

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public const string PARAM_8 = "af_param_8";

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string PARAM_9 = "af_param_9";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string PARAM_10 = "af_param_10";

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
	public AFInAppEvents()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class AppsFlyer : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public enum EmailCryptType
	{
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		EmailCryptTypeNone,
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		EmailCryptTypeSHA1,
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		EmailCryptTypeMD5,
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		EmailCryptTypeSHA256
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setCurrencyCode(string currencyCode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setCustomerUserID(string customerUserID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setAppsFlyerKey(string key)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void trackAppLaunch()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setAppID(string appleAppId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void trackRichEvent(string eventName, Dictionary<string, string> eventValues)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setIsDebug(bool isDebug)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setIsSandbox(bool isSandbox)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void getConversionData()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3DDDE0", Offset = "0x3DCDE0", VA = "0x1803DDDE0")]
	public static string getAppsFlyerId()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void handleOpenUrl(string url, string sourceApplication, string annotation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setDeviceTrackingDisabled(bool state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void stopTracking(bool isStopTracking)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setAdditionalData(Dictionary<string, string> extraData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setAppInviteOneLinkID(string oneLinkID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void generateUserInviteLink(Dictionary<string, string> parameters, string callbackObject, string callbackMethod, string callbackFailedMethod)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void trackCrossPromoteImpression(string appId, string campaign)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void trackAndOpenStore(string promotedAppId, string campaign, Dictionary<string, string> customParams)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setMinTimeBetweenSessions(int seconds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setHost(string hostPrefixName, string hostName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3DDDE0", Offset = "0x3DCDE0", VA = "0x1803DDDE0")]
	public static string getHost()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setUserEmails(EmailCryptType cryptType, params string[] userEmails)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setResolveDeepLinkURLs(params string[] userEmails)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setOneLinkCustomDomain(params string[] domains)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void validateReceipt(string publicKey, string purchaseData, string signature, string price, string currency, Dictionary<string, string> extraParams)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setCollectIMEI(bool shouldCollect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setCollectAndroidID(bool shouldCollect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void createValidateInAppListener(string aObject, string callbackMethod, string callbackFailedMethod)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void init(string devKey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void init(string devKey, string callbackObject)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setImeiData(string imeiData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void loadConversionData(string callbackObject)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void enableUninstallTracking(string senderId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void updateServerUninstallToken(string token)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setAndroidIdData(string androidIdData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setPreinstallAttribution(string mediaSource, string campaign, string siteId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void validateReceipt(string productIdentifier, string price, string currency, string transactionId, Dictionary<string, string> additionalParametes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void handlePushNotification(Dictionary<string, string> payload)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void registerUninstall(byte[] token)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setValue(string value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	[Obsolete]
	public static void loadConversionData(string callbackObject, string callbackMethod, string callbackFailedMethod)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	[Obsolete]
	public static void setGCMProjectNumber(string googleGCMNumber)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	public static void setShouldCollectDeviceName(bool shouldCollectDeviceName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x363240", Offset = "0x362240", VA = "0x180363240")]
	public AppsFlyer()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class AppsFlyerTrackerCallbacks : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly ActionEvent<string> AppOpenAttributionEvent;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly ActionEvent<string> ReceiveConversionDataEvent;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1971C40", Offset = "0x1970C40", VA = "0x181971C40")]
	public void didReceiveConversionData(string conversionData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1971BB0", Offset = "0x1970BB0", VA = "0x181971BB0")]
	public void didReceiveConversionDataWithError(string error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1971B20", Offset = "0x1970B20", VA = "0x181971B20")]
	public void didFinishValidateReceipt(string validateResult)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1971A90", Offset = "0x1970A90", VA = "0x181971A90")]
	public void didFinishValidateReceiptWithError(string error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1971DB0", Offset = "0x1970DB0", VA = "0x181971DB0")]
	public void onAppOpenAttribution(string validateResult)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1971D20", Offset = "0x1970D20", VA = "0x181971D20")]
	public void onAppOpenAttributionFailure(string error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1971F20", Offset = "0x1970F20", VA = "0x181971F20")]
	public void onInAppBillingSuccess()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1971E90", Offset = "0x1970E90", VA = "0x181971E90")]
	public void onInAppBillingFailure(string error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1971F90", Offset = "0x1970F90", VA = "0x181971F90")]
	public void onInviteLinkGenerated(string link)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1972020", Offset = "0x1971020", VA = "0x181972020")]
	public void onOpenStoreLinkGenerated(string link)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x19720C0", Offset = "0x19710C0", VA = "0x1819720C0")]
	private void printCallback(string str)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x363240", Offset = "0x362240", VA = "0x180363240")]
	public AppsFlyerTrackerCallbacks()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class StreamingAudioIn : IAudioPusher<float>, IAudioSource, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private IAudioOutputDevice sourceDevice;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private StreamInfo streamInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Action<float[]> callback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private LocalVoiceFramed<float> localVoice;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2744700", Offset = "0x2743700", VA = "0x182744700", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2744710", Offset = "0x2743710", VA = "0x182744710", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x27444B0", Offset = "0x27434B0", VA = "0x1827444B0")]
	public StreamingAudioIn(IAudioOutputDevice sourceDevice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2744410", Offset = "0x2743410", VA = "0x182744410", Slot = "4")]
	public void SetCallback(Action<float[]> callback, LocalVoice localVoice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2744290", Offset = "0x2743290", VA = "0x182744290")]
	private void Push(ArraySegment<float> samples)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x27441D0", Offset = "0x27431D0", VA = "0x1827441D0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AndroidAudioInAEC : IAudioPusher<short>, IAudioSource, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	private class DataCallback : AndroidJavaProxy
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private Action<short[]> callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		private IntPtr javaBuf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private int cntFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private int cntShort;

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x1974B30", Offset = "0x1973B30", VA = "0x181974B30")]
		public DataCallback(Action<short[]> callback, IntPtr javaBuf)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x1974AB0", Offset = "0x1973AB0", VA = "0x181974AB0")]
		public void OnData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x1974B20", Offset = "0x1973B20", VA = "0x181974B20")]
		public void OnStop()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private AndroidJavaObject audioIn;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private IntPtr javaBuf;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private DataCallback callback;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public const int SAMPLING_RATE = 44100;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3DCB70", Offset = "0x3DBB70", VA = "0x1803DCB70", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x19715A0", Offset = "0x19705A0", VA = "0x1819715A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
	public AndroidAudioInAEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1970AD0", Offset = "0x196FAD0", VA = "0x181970AD0", Slot = "4")]
	public void SetCallback(Action<short[]> callback, LocalVoice localVoice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1970A70", Offset = "0x196FA70", VA = "0x181970A70", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class AppleAudioInReader : IAudioReader<float>, IDataReader<float>, IDisposable, IAudioSource
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private const string lib_name = "AudioIn";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private IntPtr audioIn;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public const int SAMPLING_RATE = 48000;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3DCB70", Offset = "0x3DBB70", VA = "0x1803DCB70", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x19719E0", Offset = "0x19709E0", VA = "0x1819719E0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1971650", Offset = "0x1970650", VA = "0x181971650")]
	private static extern IntPtr Photon_Audio_In_CreateReader(int deviceID);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x19716F0", Offset = "0x19706F0", VA = "0x1819716F0")]
	private static extern void Photon_Audio_In_Destroy(IntPtr handler);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1971790", Offset = "0x1970790", VA = "0x181971790")]
	private static extern bool Photon_Audio_In_Read(IntPtr handle, float[] buf, int len);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1971930", Offset = "0x1970930", VA = "0x181971930")]
	public AppleAudioInReader(int deviceID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x19715B0", Offset = "0x19705B0", VA = "0x1819715B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1971860", Offset = "0x1970860", VA = "0x181971860", Slot = "4")]
	public bool Read(float[] buf)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AudioClipWrapper : IAudioReader<float>, IDataReader<float>, IDisposable, IAudioSource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private AudioClip audioClip;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private int readPos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float startTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private bool playing;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool Loop
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x49AAD0", Offset = "0x499AD0", VA = "0x18049AAD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x49AAE0", Offset = "0x499AE0", VA = "0x18049AAE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x14DC2F0", Offset = "0x14DB2F0", VA = "0x1814DC2F0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x14DC2D0", Offset = "0x14DB2D0", VA = "0x1814DC2D0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1972250", Offset = "0x1971250", VA = "0x181972250")]
	public AudioClipWrapper(AudioClip audioClip)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1972120", Offset = "0x1971120", VA = "0x181972120", Slot = "4")]
	public bool Read(float[] buffer)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class AudioOutCapture : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<float[], int> OnAudioFrame
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1972C20", Offset = "0x1971C20", VA = "0x181972C20")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1972CC0", Offset = "0x1971CC0", VA = "0x181972CC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1972BC0", Offset = "0x1971BC0", VA = "0x181972BC0")]
	private void OnAudioFilterRead(float[] frame, int channels)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x363240", Offset = "0x362240", VA = "0x180363240")]
	public AudioOutCapture()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class AudioStreamPlayer : IAudioOut
{
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private const int maxPlayLagMs = 100;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private int maxPlayLagSamples;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int playDelaySamples;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int bufferSamples;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int channels;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int frameSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int frameSamples;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private int streamSamplePos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int streamSamplePosAvg;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private AudioSource source;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private string logPrefix;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private bool debugInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private int sourceTimeSamplesPrev;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private int playLoopCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private Queue<float[]> frameQueue;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public const int FRAME_POOL_CAPACITY = 50;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private PrimitiveArrayPool<float> framePool;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int CurrentBufferLag
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5E3630", Offset = "0x5E2630", VA = "0x1805E3630", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5E3640", Offset = "0x5E2640", VA = "0x1805E3640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AudioSource AudioSource
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3B0E60", Offset = "0x3AFE60", VA = "0x1803B0E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private int playSamplePos
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1973C40", Offset = "0x1972C40", VA = "0x181973C40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1973D00", Offset = "0x1972D00", VA = "0x181973D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool IsPlaying
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1973C20", Offset = "0x1972C20", VA = "0x181973C20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x1973B50", Offset = "0x1972B50", VA = "0x181973B50")]
	public AudioStreamPlayer(AudioSource audioSource, string logPrefix, bool debugInfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x19739E0", Offset = "0x19729E0", VA = "0x1819739E0", Slot = "5")]
	public void Start(int frequency, int channels, int frameSamples, int playDelayMs)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x19730D0", Offset = "0x19720D0", VA = "0x1819730D0", Slot = "8")]
	public void Service()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1972D60", Offset = "0x1971D60", VA = "0x181972D60", Slot = "7")]
	public void OnAudioFrame(float[] frame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3B0D50", Offset = "0x3AFD50", VA = "0x1803B0D50", Slot = "6")]
	public void Stop()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1973050", Offset = "0x1972050", VA = "0x181973050", Slot = "10")]
	public void Pause()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class IOSAudioForceToSpeaker : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	private void PhotonVoiceCreated()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x363240", Offset = "0x362240", VA = "0x180363240")]
	public IOSAudioForceToSpeaker()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MicWrapper : IAudioReader<float>, IDataReader<float>, IDisposable, IAudioSource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private AudioClip mic;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private string device;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int micPrevPos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private int micLoopCnt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int readAbsPos;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x14DC2F0", Offset = "0x14DB2F0", VA = "0x1814DC2F0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x14DC2D0", Offset = "0x14DB2D0", VA = "0x1814DC2D0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x14DC220", Offset = "0x14DB220", VA = "0x1814DC220")]
	public MicWrapper(string device, int suggestedFrequency)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x14DC100", Offset = "0x14DB100", VA = "0x1814DC100", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x14DC110", Offset = "0x14DB110", VA = "0x1814DC110", Slot = "4")]
	public bool Read(float[] buffer)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class SpeexDSP : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	private class Logger : ExitGames.Client.Photon.Voice.ILogger
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x2741C80", Offset = "0x2740C80", VA = "0x182741C80", Slot = "4")]
		public void LogError(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x2741D60", Offset = "0x2740D60", VA = "0x182741D60", Slot = "5")]
		public void LogWarning(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x2741CF0", Offset = "0x2740CF0", VA = "0x182741CF0", Slot = "6")]
		public void LogInfo(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x2741C10", Offset = "0x2740C10", VA = "0x182741C10", Slot = "7")]
		public void LogDebug(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
		public Logger()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[Header("Platforms")]
	public bool Windows;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public bool Mac;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[Header("Effects")]
	[Tooltip("Acoustic Echo Cancellation")]
	public bool AEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public int AECPlaybackDelayMs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int AECFilterLengthMs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public bool Denoise;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[Tooltip("Automatic Gain Control")]
	public bool AGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[Range(1f, 32768f)]
	public float AGCLevel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public int AECPlayDelayCurrentFrames;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public bool AECLatencyDetect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private SpeexProcessor proc;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool prevAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private int aecLDState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private float aecLDStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private AudioSource aecLDPing;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public SpeexProcessor Processor
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3B0E60", Offset = "0x3AFE60", VA = "0x1803B0E60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool Active
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x369780", Offset = "0x368780", VA = "0x180369780")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8A0", Offset = "0x7DE8A0", VA = "0x1807DF8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x2743D00", Offset = "0x2742D00", VA = "0x182743D00")]
	public void ResetAEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2743520", Offset = "0x2742520", VA = "0x182743520")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x2743D20", Offset = "0x2742D20", VA = "0x182743D20")]
	private void UpdateProcProps()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2743FF0", Offset = "0x2742FF0", VA = "0x182743FF0")]
	private void setOutputListener(bool set)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2743EB0", Offset = "0x2742EB0", VA = "0x182743EB0")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x2743560", Offset = "0x2742560", VA = "0x182743560")]
	private void InitAECLatencyDetect()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x27437D0", Offset = "0x27427D0", VA = "0x1827437D0")]
	[SkipRename]
	private void PhotonVoiceCreated(LocalVoice localVoice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2743790", Offset = "0x2742790", VA = "0x182743790")]
	[SkipRename]
	private void PhotonVoiceRemoved()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2743790", Offset = "0x2742790", VA = "0x182743790")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2743790", Offset = "0x2742790", VA = "0x182743790")]
	private void reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2743FC0", Offset = "0x2742FC0", VA = "0x182743FC0")]
	public SpeexDSP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class WindowsAudioInPusher : IAudioPusher<short>, IAudioSource, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	private enum SystemMode
	{
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		SINGLE_CHANNEL_AEC = 0,
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		OPTIBEAM_ARRAY_ONLY = 2,
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		OPTIBEAM_ARRAY_AND_AEC = 4,
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		SINGLE_CHANNEL_NSAGC = 5
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IntPtr handle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private Action<short[]> pushCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private LocalVoiceFramed<short> localVoice;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private int deviceID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private Action<IntPtr, int> pushRef;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x3DCB70", Offset = "0x3DBB70", VA = "0x1803DCB70", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x27465C0", Offset = "0x27455C0", VA = "0x1827465C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2746190", Offset = "0x2745190", VA = "0x182746190")]
	private static extern IntPtr Photon_Audio_In_Create(SystemMode systemMode, int micDevIdx, int spkDevIdx, Action<IntPtr, int> callback, bool featrModeOn, bool noiseSup, bool agc, bool cntrClip);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x27462A0", Offset = "0x27452A0", VA = "0x1827462A0")]
	private static extern void Photon_Audio_In_Destroy(IntPtr handler);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2746590", Offset = "0x2745590", VA = "0x182746590")]
	public WindowsAudioInPusher(int deviceID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2746340", Offset = "0x2745340", VA = "0x182746340", Slot = "4")]
	public void SetCallback(Action<short[]> callback, LocalVoice localVoice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x27465D0", Offset = "0x27455D0", VA = "0x1827465D0")]
	private void push(IntPtr buf, int lenBytes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x27460F0", Offset = "0x27450F0", VA = "0x1827460F0", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class SA_PD_EditorIcons
{
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public enum IconType
	{
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		GameObject,
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		Favorite,
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		Prefab,
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		GameManager,
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		Dragdot,
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		DragdotActive,
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		DragdotDimmed,
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		Dropdown,
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		d_winbtn_mac_close,
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		d_winbtn_mac_close_a,
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		d_winbtn_mac_close_h,
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		d_winbtn_mac_inact,
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		d_winbtn_mac_max,
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		d_winbtn_mac_max_h,
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		d_winbtn_mac_min,
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		d_winbtn_mac_min_h,
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		d_winbtn_win_close,
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		DefaultAsset,
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		DllScript,
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		DistanceJoint2D,
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		FilterByLabel,
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		FilterByType,
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		Fixedjoint,
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		FlareLayer,
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		FrictionJoint2D,
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		GUIText,
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		HingeJoint2D,
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		Image,
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		LightProbeProxyVolume,
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		LightProbeGroup,
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		LineRenderer,
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		LayoutElement,
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		LensFlare
	}

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static Dictionary<IconType, string> m_internalIcons;

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x27428F0", Offset = "0x27418F0", VA = "0x1827428F0")]
	public static string GetInternalStringPathOfEnumValue(IconType type)
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum SA_PD_MessageType
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Info,
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Error
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ASIdentifierManagerExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	[SerializeField]
	private Text advertisingTrackingEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[SerializeField]
	private Text advertisingIdentifier;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1970940", Offset = "0x196F940", VA = "0x181970940")]
	public void GetAdvertisingIdentifier()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x19709D0", Offset = "0x196F9D0", VA = "0x1819709D0")]
	public void GetAdvertisingTrackingEnabled()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x363240", Offset = "0x362240", VA = "0x180363240")]
	public ASIdentifierManagerExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ISN_AppdelegateUseExample : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x14D5020", Offset = "0x14D4020", VA = "0x1814D5020")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x363240", Offset = "0x362240", VA = "0x180363240")]
	public ISN_AppdelegateUseExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ISN_CoreLocationDelegateExample : ISN_iCLLocationManagerDelegate
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x14D5810", Offset = "0x14D4810", VA = "0x1814D5810", Slot = "4")]
	public void DidChangeAuthorizationStatus(ISN_CLAuthorizationStatus authorizationStatus)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x14D5A10", Offset = "0x14D4A10", VA = "0x1814D5A10", Slot = "5")]
	public void DidUpdateLocations(ISN_CLLocationArray locations)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x14D5890", Offset = "0x14D4890", VA = "0x1814D5890", Slot = "6")]
	public void DidFailWithError(SA_Error error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x14D5900", Offset = "0x14D4900", VA = "0x1814D5900", Slot = "7")]
	public void DidFinishDeferredUpdatesWithError(SA_Error error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x14D5970", Offset = "0x14D4970", VA = "0x1814D5970", Slot = "8")]
	public void DidPauseLocationUpdates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x14D59C0", Offset = "0x14D49C0", VA = "0x1814D59C0", Slot = "9")]
	public void DidResumeLocationUpdates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x14D5E70", Offset = "0x14D4E70", VA = "0x1814D5E70")]
	private void ShowMessage(string title, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
	public ISN_CoreLocationDelegateExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ISN_CoreLocationUseExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[SerializeField]
	private Button m_AuthButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[SerializeField]
	private Button m_StartUpdatingButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[SerializeField]
	private Button m_StopUpdatingButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[SerializeField]
	private Button m_RequestLocationButton;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x14D6130", Offset = "0x14D5130", VA = "0x1814D6130")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x14D5FD0", Offset = "0x14D4FD0", VA = "0x1814D5FD0")]
	private void ShowMessage(string title, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x363240", Offset = "0x362240", VA = "0x180363240")]
	public ISN_CoreLocationUseExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ISN_EventKitExamples : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[SerializeField]
	private Text m_Error;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private string m_EventID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private string m_ReminderID;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x14D6B30", Offset = "0x14D5B30", VA = "0x1814D6B30")]
	public void RequestAccessToEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x14D6BC0", Offset = "0x14D5BC0", VA = "0x1814D6BC0")]
	public void RequestAccessToReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x14D66E0", Offset = "0x14D56E0", VA = "0x1814D66E0")]
	public void AddEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x14D6990", Offset = "0x14D5990", VA = "0x1814D6990")]
	public void RemoveEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x14D6830", Offset = "0x14D5830", VA = "0x1814D6830")]
	public void AddReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x14D6A60", Offset = "0x14D5A60", VA = "0x1814D6A60")]
	public void RemoveReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x363240", Offset = "0x362240", VA = "0x180363240")]
	public ISN_EventKitExamples()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ISN_GameKitUseExample_TvOS : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[SerializeField]
	private Button m_SingInButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[SerializeField]
	private Button m_LeaderboardsUI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[SerializeField]
	private Button m_AchievementsUI;

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x14D7380", Offset = "0x14D6380", VA = "0x1814D7380")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x363240", Offset = "0x362240", VA = "0x180363240")]
	public ISN_GameKitUseExample_TvOS()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DocumentationExample : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x1974CD0", Offset = "0x1973CD0", VA = "0x181974CD0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x363240", Offset = "0x362240", VA = "0x180363240")]
	public DocumentationExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class ISN_MediaPlayerExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[SerializeField]
	[Header("Info Panel")]
	private Text m_title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[SerializeField]
	private Text m_artist;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[SerializeField]
	private Text m_playbackState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[SerializeField]
	[Header("Buttons")]
	private Button m_play;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[SerializeField]
	private Button m_stop;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[SerializeField]
	private Button m_pause;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[SerializeField]
	private Button m_next;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[SerializeField]
	private Button m_previos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private ISN_MPMusicPlayerController m_player;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x14D8200", Offset = "0x14D7200", VA = "0x1814D8200")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x14D8590", Offset = "0x14D7590", VA = "0x1814D8590")]
	private void UpdatePlayerStateUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x363240", Offset = "0x362240", VA = "0x180363240")]
	public ISN_MediaPlayerExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ISN_CameraGalleryExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[SerializeField]
	private Button m_loadFromGallery;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[SerializeField]
	private Button m_loadFromCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[SerializeField]
	private Button m_saveToGallery;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[SerializeField]
	private Image m_image;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[SerializeField]
	private GameObject m_go;

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x14D5360", Offset = "0x14D4360", VA = "0x1814D5360")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x363240", Offset = "0x362240", VA = "0x180363240")]
	public ISN_CameraGalleryExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ISN_SocialExamples : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[SerializeField]
	private Button m_twitterText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[SerializeField]
	private Button m_twitterTextImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[SerializeField]
	private Button m_fbImage;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x14D98B0", Offset = "0x14D88B0", VA = "0x1814D98B0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x363240", Offset = "0x362240", VA = "0x180363240")]
	public ISN_SocialExamples()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class ISN_UIImagePickerControllerExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[SerializeField]
	private RawImage m_Image;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[SerializeField]
	private Image m_Sprite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[SerializeField]
	[Header("Image")]
	private Button m_ImageCapture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[SerializeField]
	private Button m_ImageLibrary;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[SerializeField]
	private Button m_ImageAlbum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[SerializeField]
	[Header("Video")]
	private Button m_VideoCapture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[SerializeField]
	private Button m_VideoLibrary;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[SerializeField]
	private Button m_VideoAlbum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[SerializeField]
	private Button m_VideoPlay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private ISN_UIPickerControllerResult m_LastPickerResult;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x14DA530", Offset = "0x14D9530", VA = "0x1814DA530")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x14DA3A0", Offset = "0x14D93A0", VA = "0x1814DA3A0")]
	private void AddFitter(GameObject go)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x14DAF50", Offset = "0x14D9F50", VA = "0x1814DAF50")]
	private void UpdateUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x14DAB80", Offset = "0x14D9B80", VA = "0x1814DAB80")]
	private void StartPicker(ISN_UIImagePickerControllerSourceType sourceType, string mediaType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x14DA9D0", Offset = "0x14D99D0", VA = "0x1814DA9D0")]
	private void DisplayResult(ISN_UIPickerControllerResult result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x14DA410", Offset = "0x14D9410", VA = "0x1814DA410")]
	private void ApplyImageToGui(Texture2D image)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x14DA8B0", Offset = "0x14D98B0", VA = "0x1814DA8B0")]
	private void DisplayMessage(string message, [Optional] Action onClose)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x363240", Offset = "0x362240", VA = "0x180363240")]
	public ISN_UIImagePickerControllerExample()
	{
	}
}
namespace SA.iOS.Tests.UserNotifications
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ISN_RemoteNotifications_Test : SA_BaseTest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private ISN_UNNotificationRequest m_request;

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x273E460", Offset = "0x273D460", VA = "0x18273E460", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_RemoteNotifications_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class ISN_UNAuthorization_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x273F020", Offset = "0x273E020", VA = "0x18273F020", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_UNAuthorization_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ISN_UNSchedule_Test : SA_BaseTest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private ISN_UNNotificationRequest m_request;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x273F100", Offset = "0x273E100", VA = "0x18273F100", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x273F3F0", Offset = "0x273E3F0", VA = "0x18273F3F0")]
		private void ValidateRequest(ISN_UNNotificationRequest presentdeRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_UNSchedule_Test()
		{
		}
	}
}
namespace SA.iOS.Tests.UIKit
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ISN_UIImagePickerController_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x273EB90", Offset = "0x273DB90", VA = "0x18273EB90", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x273EA60", Offset = "0x273DA60", VA = "0x18273EA60")]
		private void TestVideo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_UIImagePickerController_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class SaveToCameraRollTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2743430", Offset = "0x2742430", VA = "0x182743430", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public SaveToCameraRollTest()
		{
		}
	}
}
namespace SA.iOS.Tests.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class ISN_DefaultSharingDialog_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x273C980", Offset = "0x273B980", VA = "0x18273C980", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_DefaultSharingDialog_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class ISN_FacebookShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x273CC50", Offset = "0x273BC50", VA = "0x18273CC50", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_FacebookShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class ISN_InstagramShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x273E1A0", Offset = "0x273D1A0", VA = "0x18273E1A0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_InstagramShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class ISN_MailShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x273E2B0", Offset = "0x273D2B0", VA = "0x18273E2B0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_MailShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class ISN_TextMessage_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x273E610", Offset = "0x273D610", VA = "0x18273E610", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_TextMessage_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class ISN_TwitterShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x273E950", Offset = "0x273D950", VA = "0x18273E950", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_TwitterShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ISN_WhatsAppShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2741AB0", Offset = "0x2740AB0", VA = "0x182741AB0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_WhatsAppShare_Test()
		{
		}
	}
}
namespace SA.iOS.Tests.GameKit
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class ISN_GKAchievementsLoad_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x273CD70", Offset = "0x273BD70", VA = "0x18273CD70", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_GKAchievementsLoad_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class ISN_GKAchievmentReport_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x273D1C0", Offset = "0x273C1C0", VA = "0x18273D1C0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x273D0E0", Offset = "0x273C0E0", VA = "0x18273D0E0")]
		private void ReportCompletedAchievment(string achievementId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x273D070", Offset = "0x273C070", VA = "0x18273D070")]
		private void CheckIfCompleted(string achievementId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_GKAchievmentReport_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class ISN_GKAchievmentReset_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x273D480", Offset = "0x273C480", VA = "0x18273D480", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x273D410", Offset = "0x273C410", VA = "0x18273D410")]
		private void CheckIfResetCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_GKAchievmentReset_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class ISN_GKGameCenterUI_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x273D640", Offset = "0x273C640", VA = "0x18273D640", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_GKGameCenterUI_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class ISN_GKGenerateIdentityVerificationSignature_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x273D670", Offset = "0x273C670", VA = "0x18273D670", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_GKGenerateIdentityVerificationSignature_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class ISN_GKLoadLeaderboards_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x273D880", Offset = "0x273C880", VA = "0x18273D880", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_GKLoadLeaderboards_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class ISN_GKLocalPlayer_Authenticate_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x273DB20", Offset = "0x273CB20", VA = "0x18273DB20", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_GKLocalPlayer_Authenticate_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class ISN_GKReportingScores_Test : ISN_GKSingleLeaderboard_Test
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x273DD40", Offset = "0x273CD40", VA = "0x18273DD40", Slot = "7")]
		public override void OnLeaderboardReady(ISN_GKLeaderboard leaderboard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_GKReportingScores_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class ISN_GKRetrievingScores_Test : ISN_GKSingleLeaderboard_Test
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x273DEF0", Offset = "0x273CEF0", VA = "0x18273DEF0", Slot = "7")]
		public override void OnLeaderboardReady(ISN_GKLeaderboard leaderboard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_GKRetrievingScores_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public abstract class ISN_GKSingleLeaderboard_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x273E050", Offset = "0x273D050", VA = "0x18273E050", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void OnLeaderboardReady(ISN_GKLeaderboard leaderboard);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		protected ISN_GKSingleLeaderboard_Test()
		{
		}
	}
}
namespace SA.iOS.Tests.Foundation
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class ISN_AudioSessionTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x273C140", Offset = "0x273B140", VA = "0x18273C140", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_AudioSessionTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class ISN_BuildInfoTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x273C1B0", Offset = "0x273B1B0", VA = "0x18273C1B0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_BuildInfoTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class ISN_iCloudKeyValueStorageTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2741B50", Offset = "0x2740B50", VA = "0x182741B50", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_iCloudKeyValueStorageTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class ISN_NSFileManagerTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x273E3E0", Offset = "0x273D3E0", VA = "0x18273E3E0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_NSFileManagerTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class ISN_TimeZoneTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x273E730", Offset = "0x273D730", VA = "0x18273E730", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_TimeZoneTest()
		{
		}
	}
}
namespace SA.iOS.Tests.Contacts
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class ISN_CNContactsPicker_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x273C260", Offset = "0x273B260", VA = "0x18273C260", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_CNContactsPicker_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class ISN_CNFetchPhoneContacts_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x273C850", Offset = "0x273B850", VA = "0x18273C850", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x273C330", Offset = "0x273B330", VA = "0x18273C330")]
		public static void PrintContacts(List<ISN_CNContact> contacts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x273C1A0", Offset = "0x273B1A0", VA = "0x18273C1A0")]
		public ISN_CNFetchPhoneContacts_Test()
		{
		}
	}
}
namespace SA.iOS.Examples
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class AVKitUseExample : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x14D2790", Offset = "0x14D1790", VA = "0x1814D2790")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x363240", Offset = "0x362240", VA = "0x180363240")]
		public AVKitUseExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class ISN_BaseIOSFeaturePreview : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		protected GUIStyle style;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		protected int buttonWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		protected int buttonHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		protected float StartY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		protected float StartX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		protected float XStartPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		protected float YStartPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		protected float XButtonStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		protected float YButtonStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		protected float YLableStep;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x14D5200", Offset = "0x14D4200", VA = "0x1814D5200", Slot = "4")]
		protected virtual void InitStyles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4E8000", Offset = "0x4E7000", VA = "0x1804E8000", Slot = "5")]
		public virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x14D5300", Offset = "0x14D4300", VA = "0x1814D5300")]
		public void UpdateToStartPos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x14D52F0", Offset = "0x14D42F0", VA = "0x1814D52F0")]
		public void LoadLevel(string levelName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x14D5310", Offset = "0x14D4310", VA = "0x1814D5310")]
		public ISN_BaseIOSFeaturePreview()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class ISN_FoundationExamples
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x14D7250", Offset = "0x14D6250", VA = "0x1814D7250")]
		public void LocaleInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
		public ISN_FoundationExamples()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class GameKitUseExample : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private List<ISN_GKSavedGame> m_fetchedSavedGames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private List<string> m_conflictedSavedGames;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x14D2AF0", Offset = "0x14D1AF0", VA = "0x1814D2AF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x14D3470", Offset = "0x14D2470", VA = "0x1814D3470")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x14D2BD0", Offset = "0x14D1BD0", VA = "0x1814D2BD0")]
		private void DidModifySavedGame(ISN_GKSavedGameSaveResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x14D2F00", Offset = "0x14D1F00", VA = "0x1814D2F00")]
		private void HasConflictingSavedGames(ISN_GKSavedGameFetchResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x14D3550", Offset = "0x14D2550", VA = "0x1814D3550")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x14D4FA0", Offset = "0x14D3FA0", VA = "0x1814D4FA0")]
		public GameKitUseExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class iCloudUseExample : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private float valueF;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x2746720", Offset = "0x2745720", VA = "0x182746720")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x2746810", Offset = "0x2745810", VA = "0x182746810")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x2747200", Offset = "0x2746200", VA = "0x182747200")]
		private void StoreDidChangeExternally(ISN_NSStoreDidChangeExternallyNotification result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x27468A0", Offset = "0x27458A0", VA = "0x1827468A0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2747490", Offset = "0x2746490", VA = "0x182747490")]
		public iCloudUseExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class ISN_UIController : SA_UIController
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public ScrollRect scroll;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x14D9C00", Offset = "0x14D8C00", VA = "0x1814D9C00", Slot = "7")]
		public override GameObject AddSideMenuElement(List<SA_ExampleSubsectionConfig> subsections, bool isActive)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x14DA110", Offset = "0x14D9110", VA = "0x1814DA110")]
		private void SetToggle(string sceneName, string text, SA_SideToggleStyle style, Toggle toggle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x14D9EA0", Offset = "0x14D8EA0", VA = "0x1814D9EA0", Slot = "5")]
		public override Toggle AddTopMenuElement(string name, Sprite icon, bool isActive, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x14DA0F0", Offset = "0x14D90F0", VA = "0x1814DA0F0", Slot = "4")]
		public override void SetLogo(Sprite sprite)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x14DA2C0", Offset = "0x14D92C0", VA = "0x1814DA2C0", Slot = "8")]
		public override void UnloadContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x14DA030", Offset = "0x14D9030", VA = "0x1814DA030", Slot = "9")]
		public override void LoadContent(GameObject canvas)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x14DA210", Offset = "0x14D9210", VA = "0x1814DA210", Slot = "6")]
		public override void ShowTopMenuItem(GameObject menuItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x14D9B50", Offset = "0x14D8B50", VA = "0x1814D9B50", Slot = "10")]
		public override void AddLog(string log)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3DC400", Offset = "0x3DB400", VA = "0x1803DC400")]
		public ISN_UIController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class SA_ExampleSceneConfig : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public List<SA_ExampleServicesConfig> Services;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Sprite Logo;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x2741DD0", Offset = "0x2740DD0", VA = "0x182741DD0")]
		public SA_ExampleSceneConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class SA_ExampleSceneController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[SerializeField]
		private SA_ExampleSceneConfig m_config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[SerializeField]
		private SA_UIController m_UIController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private List<GameObject> m_links;

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x27424B0", Offset = "0x27414B0", VA = "0x1827424B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x2742650", Offset = "0x2741650", VA = "0x182742650")]
		private void Subscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x2742470", Offset = "0x2741470", VA = "0x182742470")]
		private void SetLogo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2741E60", Offset = "0x2740E60", VA = "0x182741E60")]
		private void GenerateMenuUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2742170", Offset = "0x2741170", VA = "0x182742170")]
		private void HandlerTopMenuClick(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x2742030", Offset = "0x2741030", VA = "0x182742030")]
		private void HandlerSideMenuClick(string sceneName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2742220", Offset = "0x2741220", VA = "0x182742220")]
		private void LoadScene(string sceneName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x27427C0", Offset = "0x27417C0", VA = "0x1827427C0")]
		private void UnloadScene()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2742320", Offset = "0x2741320", VA = "0x182742320")]
		private void SceneLoaded(Scene scene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2741E30", Offset = "0x2740E30", VA = "0x182741E30")]
		private void Application_LogMessageReceived(string condition, string stackTrace, LogType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2742830", Offset = "0x2741830", VA = "0x182742830")]
		public SA_ExampleSceneController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class SA_ExampleServicesConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Sprite Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public List<SA_ExampleSubsectionConfig> Subsections;

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2742890", Offset = "0x2741890", VA = "0x182742890")]
		public SA_ExampleServicesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class SA_ExampleSubsectionConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public SA_SceneField Scene;

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
		public SA_ExampleSubsectionConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class SA_SceneField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[SerializeField]
		private UnityEngine.Object sceneAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[SerializeField]
		private string sceneName;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public string SceneName
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x361AC0", Offset = "0x360AC0", VA = "0x180361AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2742E00", Offset = "0x2741E00", VA = "0x182742E00")]
		public SA_SceneField()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class SA_SideToggleStyle : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[HideInInspector]
		public Text Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private GameObject m_mainContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private string m_sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private Toggle m_toggle;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2742F70", Offset = "0x2741F70", VA = "0x182742F70")]
		public void SetParam(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2742E40", Offset = "0x2741E40", VA = "0x182742E40", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x2742E80", Offset = "0x2741E80", VA = "0x182742E80", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2743080", Offset = "0x2742080", VA = "0x182743080")]
		public void SetWhite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2742EF0", Offset = "0x2741EF0", VA = "0x182742EF0")]
		public void SetBlue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x363240", Offset = "0x362240", VA = "0x180363240")]
		public SA_SideToggleStyle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class SA_TopToggleStyle : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private Text m_label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private Image m_icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private Toggle m_toggle;

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2743240", Offset = "0x2742240", VA = "0x182743240")]
		public Toggle SetToggle(bool isActive, string text, Sprite sprite)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x27430D0", Offset = "0x27420D0", VA = "0x1827430D0", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2743110", Offset = "0x2742110", VA = "0x182743110", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x27433A0", Offset = "0x27423A0", VA = "0x1827433A0")]
		public void SetWhite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2743150", Offset = "0x2742150", VA = "0x182743150")]
		public void SetBlue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x363240", Offset = "0x362240", VA = "0x180363240")]
		public SA_TopToggleStyle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public abstract class SA_UIController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public Action<int> OnTopMenuClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Action<string> OnSideMenuClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[SerializeField]
		protected Image m_logo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[SerializeField]
		protected GameObject m_topMenuItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		protected GameObject m_sideMenuItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		protected GameObject m_sideScroll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		protected GameObject m_mainContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		protected Text m_logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		protected GameObject m_prevSideItem;

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void SetLogo(Sprite sprite);

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract Toggle AddTopMenuElement(string name, Sprite icon, bool isActive, int index);

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void ShowTopMenuItem(GameObject menuItem);

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract GameObject AddSideMenuElement(List<SA_ExampleSubsectionConfig> subsections, bool isActive);

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void UnloadContent();

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void LoadContent(GameObject canvas);

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void AddLog(string log);

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x363240", Offset = "0x362240", VA = "0x180363240")]
		protected SA_UIController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class ISN_ReplayKitUseExample : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private bool IsRecording;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x14D92D0", Offset = "0x14D82D0", VA = "0x1814D92D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x14D94F0", Offset = "0x14D84F0", VA = "0x1814D94F0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x14D9750", Offset = "0x14D8750", VA = "0x1814D9750")]
		private void OnRecordStopped(ISN_RPStopResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x14D5310", Offset = "0x14D4310", VA = "0x1814D5310")]
		public ISN_ReplayKitUseExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class ISN_MarketExample : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private static ISN_PaymentManagerExample s_paymentManager;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x14D7620", Offset = "0x14D6620", VA = "0x1814D7620")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x14D5310", Offset = "0x14D4310", VA = "0x1814D5310")]
		public ISN_MarketExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class ISN_PaymentManagerExample : ISN_iSKPaymentTransactionObserver
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public const string SMALL_PACK = "your.product.id1.here";

		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public const string NC_PACK = "your.product.id2.here";

		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private static bool IsInitialized;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x14D9120", Offset = "0x14D8120", VA = "0x1814D9120")]
		public void init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x14D9070", Offset = "0x14D8070", VA = "0x1814D9070")]
		private static void UnlockProducts(ISN_iSKPaymentTransaction transaction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x14D89C0", Offset = "0x14D79C0", VA = "0x1814D89C0", Slot = "4")]
		public void OnTransactionUpdated(ISN_iSKPaymentTransaction transaction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20", Slot = "5")]
		public void OnTransactionRemoved(ISN_iSKPaymentTransaction result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x367E30", Offset = "0x366E30", VA = "0x180367E30", Slot = "6")]
		public bool OnShouldAddStorePayment(ISN_SKProduct result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x14D8710", Offset = "0x14D7710", VA = "0x1814D8710", Slot = "7")]
		public void OnRestoreTransactionsComplete(SA_Result result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
		public ISN_PaymentManagerExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class ISN_UIKitExample : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[SerializeField]
		private Texture2D m_icon;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x14DAFE0", Offset = "0x14D9FE0", VA = "0x1814DAFE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x14DB160", Offset = "0x14DA160", VA = "0x1814DB160")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x14D5310", Offset = "0x14D4310", VA = "0x1814D5310")]
		public ISN_UIKitExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class ISN_UserNotificationExample : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x273FD90", Offset = "0x273ED90", VA = "0x18273FD90")]
		public void RequestUserNotificationPermission()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x273F600", Offset = "0x273E600", VA = "0x18273F600")]
		public void GetSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x273F9F0", Offset = "0x273E9F0", VA = "0x18273F9F0")]
		public void NotificationInterval()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x273F830", Offset = "0x273E830", VA = "0x18273F830")]
		public void NotificationCalendar()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x273FB80", Offset = "0x273EB80", VA = "0x18273FB80")]
		public void NotificationLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x273F6D0", Offset = "0x273E6D0", VA = "0x18273F6D0")]
		public void NoSoundToTrigger()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x363240", Offset = "0x362240", VA = "0x180363240")]
		public ISN_UserNotificationExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class ISN_UserNotificationsExamples : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x273FF50", Offset = "0x273EF50", VA = "0x18273FF50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2741770", Offset = "0x2740770", VA = "0x182741770")]
		private void PrintNotification(ISN_UNNotification notification)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2740A80", Offset = "0x273FA80", VA = "0x182740A80")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2740C60", Offset = "0x273FC60", VA = "0x182740C60")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2740700", Offset = "0x273F700", VA = "0x182740700")]
		private void DocsExample()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x27401D0", Offset = "0x273F1D0", VA = "0x1827401D0")]
		private void ContactsUse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2741AA0", Offset = "0x2740AA0", VA = "0x182741AA0")]
		public ISN_UserNotificationsExamples()
		{
		}
	}
}
namespace SA.Foundation.EditorStylesCollection
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class SA_ESC_PropertyDrawerExample : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[Space]
		[Multiline]
		[SerializeField]
		[Header("Unity Default Property Drawers")]
		[Space(10f)]
		private string m_multilineString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[TextArea]
		public string m_textAreaString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		[Range(0f, 100f)]
		private int m_intRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_floatRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[SerializeField]
		[Tooltip("Health value between 0 and 100.")]
		private float m_hoverMouseToSeeTooltip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[Space]
		[Header("Sliders")]
		[Space(10f)]
		public float m_simpleSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[SA_PD_MinMaxSlider(0f, 3f, 255f, 0f, 0f)]
		public Vector2 m_MinMaxSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[Header("Help Boxes with text message")]
		[SA_PD_HelpBox(SA_PD_MessageType.Info)]
		public string myHelpBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[SA_PD_HelpBox(SA_PD_MessageType.Warning)]
		public string myString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[Space]
		[Space]
		[SA_PD_ThingInsertionDecorator]
		[SA_PD_PRInsertionDecorator]
		[SA_PD_StandartInsertionDecorator]
		[Space]
		[Space]
		[Header("Help Boxes Decorators")]
		[Space(10f)]
		[SA_PD_HelpboxDecorator(SA_PD_MessageType.Info, "Pre-defined text")]
		[SA_PD_HelpboxDecorator(SA_PD_MessageType.None, "")]
		[Header("Insertions")]
		[Space(10f)]
		[Header("Headers")]
		[Space(10f)]
		[SA_PD_HeaderDecorator("Indent Header")]
		[Header("Indent level")]
		[Space(10f)]
		[SA_PD_IndentLevel(1)]
		public string indentLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[SA_PD_IndentLevel(2)]
		public string indentLevel1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SA_PD_IndentLevel(0)]
		public string indentLevel2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[Space]
		[Header("Conditional Hide / Show fields")]
		[Space(10f)]
		public bool showBelowSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public float range;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public bool isExists;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public AnimationCurve curve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[Space]
		[Header("Conditional Disable / Enable fields")]
		[Space(10f)]
		public bool enableBelowSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[SA_PD_Conditional("enableBelowSettings")]
		public bool firstSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[SA_PD_Conditional("enableBelowSettings")]
		public float secondSettigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[Space]
		[Header("Label with Icon")]
		[Space(10f)]
		[SA_PD_LabelWithIcon("Plugins/StansAssets/Support2018/Modules/Editor/EditorStylesCollection/Resources/Icons/gameObjectIcon.png")]
		public string myLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[SA_PD_LabelWithIcon(SA_PD_EditorIcons.IconType.Light)]
		public string favoriteLabel;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x14DE460", Offset = "0x14DD460", VA = "0x1814DE460")]
		public SA_ESC_PropertyDrawerExample()
		{
		}
	}
}
namespace SA.Foundation.PropertyDrawers.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_ConditionalAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private string m_conditionalSourceField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private bool m_hideInInspector;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public string ConditionalSourceField
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x38FC50", Offset = "0x38EC50", VA = "0x18038FC50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool HideInInspector
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x4AD2F0", Offset = "0x4AC2F0", VA = "0x1804AD2F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x14DE4F0", Offset = "0x14DD4F0", VA = "0x1814DE4F0")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x14DE550", Offset = "0x14DD550", VA = "0x1814DE550")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField, bool hideInInspector)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_HelpBoxAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private SA_PD_MessageType m_type;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x392A60", Offset = "0x391A60", VA = "0x180392A60")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x14DE5C0", Offset = "0x14DD5C0", VA = "0x1814DE5C0")]
		public SA_PD_HelpBoxAttribute(SA_PD_MessageType type)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_IndentLevelAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private int m_indentLevel;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public int IndentLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x392A60", Offset = "0x391A60", VA = "0x180392A60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x14DE5C0", Offset = "0x14DD5C0", VA = "0x1814DE5C0")]
		public SA_PD_IndentLevelAttribute(int indentLevel)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_LabelWithIconAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private string m_iconPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private string m_internalIconPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private SA_PD_EditorIcons.IconType m_iconType;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public string IconPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x38FC50", Offset = "0x38EC50", VA = "0x18038FC50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string InternalIconPath
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x361AC0", Offset = "0x360AC0", VA = "0x180361AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x14DE630", Offset = "0x14DD630", VA = "0x1814DE630")]
		public SA_PD_LabelWithIconAttribute(string iconPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x14DE6A0", Offset = "0x14DD6A0", VA = "0x1814DE6A0")]
		public SA_PD_LabelWithIconAttribute(SA_PD_EditorIcons.IconType icon)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_MinMaxSliderAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private float m_minLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private float m_maxLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private Color m_color;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public float MinLimit
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x503980", Offset = "0x502980", VA = "0x180503980")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x47C2F0", Offset = "0x47B2F0", VA = "0x18047C2F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x54CFB0", Offset = "0x54BFB0", VA = "0x18054CFB0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x14DE740", Offset = "0x14DD740", VA = "0x1814DE740")]
		public SA_PD_MinMaxSliderAttribute(float minLimit, float maxLimit, float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_SimpleSliderAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private float m_minLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private float m_maxLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private Color m_color;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float MinLimit
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x503980", Offset = "0x502980", VA = "0x180503980")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x47C2F0", Offset = "0x47B2F0", VA = "0x18047C2F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x54CFB0", Offset = "0x54BFB0", VA = "0x18054CFB0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x14DE740", Offset = "0x14DD740", VA = "0x1814DE740")]
		public SA_PD_SimpleSliderAttribute(float minLimit, float maxLimit, float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class SA_PD_HeaderDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private string m_text;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x38FC50", Offset = "0x38EC50", VA = "0x18038FC50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x42C4E0", Offset = "0x42B4E0", VA = "0x18042C4E0")]
		public SA_PD_HeaderDecoratorAttribute(string text)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SA_PD_HelpboxDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private string m_message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private SA_PD_MessageType m_type;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string Message
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x38FC50", Offset = "0x38EC50", VA = "0x18038FC50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x427840", Offset = "0x426840", VA = "0x180427840")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x14DE5F0", Offset = "0x14DD5F0", VA = "0x1814DE5F0")]
		public SA_PD_HelpboxDecoratorAttribute(SA_PD_MessageType type, string message = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SA_PD_PRInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4AF1F0", Offset = "0x4AE1F0", VA = "0x1804AF1F0")]
		public SA_PD_PRInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SA_PD_StandartInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4AF1F0", Offset = "0x4AE1F0", VA = "0x1804AF1F0")]
		public SA_PD_StandartInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SA_PD_ThingInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4AF1F0", Offset = "0x4AE1F0", VA = "0x1804AF1F0")]
		public SA_PD_ThingInsertionDecoratorAttribute()
		{
		}
	}
}
namespace POpusCodec
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class OpusDecoder : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private IntPtr _handle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private string _version;

		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private const int MaxFrameSize = 5760;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private bool _previousPacketInvalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private int _channelCount;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly float[] EmptyBufferFloat;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly short[] EmptyBufferShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private Bandwidth? _previousPacketBandwidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private float[] bufferFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private short[] bufferShort;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public string Version
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x361AC0", Offset = "0x360AC0", VA = "0x180361AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Bandwidth? PreviousPacketBandwidth
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x365D30", Offset = "0x364D30", VA = "0x180365D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public SamplingRate SamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x455A20", Offset = "0x454A20", VA = "0x180455A20")]
			[CompilerGenerated]
			get
			{
				return default(SamplingRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x53A2D0", Offset = "0x5392D0", VA = "0x18053A2D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Channels Channels
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x5E3460", Offset = "0x5E2460", VA = "0x1805E3460")]
			get
			{
				return default(Channels);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x14DC880", Offset = "0x14DB880", VA = "0x1814DC880")]
		public OpusDecoder(SamplingRate outputSamplingRateHz, Channels numChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x14DC310", Offset = "0x14DB310", VA = "0x1814DC310")]
		public float[] DecodePacketFloat(byte[] packetData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x14DC540", Offset = "0x14DB540", VA = "0x1814DC540")]
		public short[] DecodePacketShort(byte[] packetData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x14DC770", Offset = "0x14DB770", VA = "0x1814DC770", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class OpusEncoder : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public const int BitrateMax = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private IntPtr _handle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private string _version;

		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private const int RecommendedMaxPacketSize = 4000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private int _frameSizePerChannel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private SamplingRate _inputSamplingRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private Channels _inputChannels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private readonly byte[] writePacket;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private static readonly ArraySegment<byte> EmptyBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private Delay _encoderDelay;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public SamplingRate InputSamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x5E3460", Offset = "0x5E2460", VA = "0x1805E3460")]
			get
			{
				return default(SamplingRate);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Channels InputChannels
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x42B660", Offset = "0x42A660", VA = "0x18042B660")]
			get
			{
				return default(Channels);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string Version
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x361AC0", Offset = "0x360AC0", VA = "0x180361AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Delay EncoderDelay
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x3903A0", Offset = "0x38F3A0", VA = "0x1803903A0")]
			get
			{
				return default(Delay);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x14DD550", Offset = "0x14DC550", VA = "0x1814DD550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int FrameSizePerChannel
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x540EC0", Offset = "0x53FEC0", VA = "0x180540EC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public int Bitrate
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x14DD3D0", Offset = "0x14DC3D0", VA = "0x1814DD3D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x14DD4F0", Offset = "0x14DC4F0", VA = "0x1814DD4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Bandwidth MaxBandwidth
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x14DD470", Offset = "0x14DC470", VA = "0x1814DD470")]
			get
			{
				return default(Bandwidth);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x14DD6B0", Offset = "0x14DC6B0", VA = "0x1814DD6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Complexity Complexity
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x14DD3F0", Offset = "0x14DC3F0", VA = "0x1814DD3F0")]
			get
			{
				return default(Complexity);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x14DD510", Offset = "0x14DC510", VA = "0x1814DD510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int ExpectedPacketLossPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x14DD430", Offset = "0x14DC430", VA = "0x1814DD430")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x14DD670", Offset = "0x14DC670", VA = "0x1814DD670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public SignalHint SignalHint
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x14DD490", Offset = "0x14DC490", VA = "0x1814DD490")]
			get
			{
				return default(SignalHint);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x14DD6D0", Offset = "0x14DC6D0", VA = "0x1814DD6D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public ForceChannels ForceChannels
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x14DD450", Offset = "0x14DC450", VA = "0x1814DD450")]
			get
			{
				return default(ForceChannels);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x14DD690", Offset = "0x14DC690", VA = "0x1814DD690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool UseInbandFEC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x14DD4B0", Offset = "0x14DC4B0", VA = "0x1814DD4B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x14DD6F0", Offset = "0x14DC6F0", VA = "0x1814DD6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool UseUnconstrainedVBR
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x14DD4D0", Offset = "0x14DC4D0", VA = "0x1814DD4D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x14DD710", Offset = "0x14DC710", VA = "0x1814DD710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool DtxEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x14DD410", Offset = "0x14DC410", VA = "0x1814DD410")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x14DD530", Offset = "0x14DC530", VA = "0x1814DD530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x14DCF90", Offset = "0x14DBF90", VA = "0x1814DCF90")]
		public OpusEncoder(SamplingRate inputSamplingRateHz, Channels numChannels, int bitrate, OpusApplicationType applicationType, Delay encoderDelay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x14DCB00", Offset = "0x14DBB00", VA = "0x1814DCB00")]
		public ArraySegment<byte> Encode(float[] pcmSamples)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x14DCD10", Offset = "0x14DBD10", VA = "0x1814DCD10")]
		public ArraySegment<byte> Encode(short[] pcmSamples)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x14DCA60", Offset = "0x14DBA60", VA = "0x1814DCA60", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class OpusException : Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private OpusStatusCode _statusCode;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public OpusStatusCode StatusCode
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x54FA30", Offset = "0x54EA30", VA = "0x18054FA30")]
			get
			{
				return default(OpusStatusCode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x14DD730", Offset = "0x14DC730", VA = "0x1814DD730")]
		public OpusException(OpusStatusCode statusCode, string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class Wrapper
	{
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private const string lib_name = "opus_egpv";

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x14EDE10", Offset = "0x14ECE10", VA = "0x1814EDE10")]
		private static extern int opus_encoder_get_size(Channels channels);

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x14EDEA0", Offset = "0x14ECEA0", VA = "0x1814EDEA0")]
		private static extern OpusStatusCode opus_encoder_init(IntPtr st, SamplingRate Fs, Channels channels, OpusApplicationType application);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x14EDF60", Offset = "0x14ECF60", VA = "0x1814EDF60")]
		public static extern IntPtr opus_get_version_string();

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x14ED800", Offset = "0x14EC800", VA = "0x1814ED800")]
		private static extern int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x14ED5A0", Offset = "0x14EC5A0", VA = "0x1814ED5A0")]
		private static extern int opus_encode_float(IntPtr st, float[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x14EDD00", Offset = "0x14ECD00", VA = "0x1814EDD00")]
		private static extern int opus_encoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x14EDC50", Offset = "0x14ECC50", VA = "0x1814EDC50")]
		private static extern int opus_encoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x14ED350", Offset = "0x14EC350", VA = "0x1814ED350")]
		private static extern int opus_decoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x14ED2A0", Offset = "0x14EC2A0", VA = "0x1814ED2A0")]
		private static extern int opus_decoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x14ED460", Offset = "0x14EC460", VA = "0x1814ED460")]
		private static extern int opus_decoder_get_size(Channels channels);

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x14ED4F0", Offset = "0x14EC4F0", VA = "0x1814ED4F0")]
		private static extern OpusStatusCode opus_decoder_init(IntPtr st, SamplingRate Fs, Channels channels);

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x14ECEE0", Offset = "0x14EBEE0", VA = "0x1814ECEE0")]
		private static extern int opus_decode(IntPtr st, byte[] data, int len, short[] pcm, int frame_size, int decode_fec);

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x14ECCF0", Offset = "0x14EBCF0", VA = "0x1814ECCF0")]
		private static extern int opus_decode_float(IntPtr st, byte[] data, int len, float[] pcm, int frame_size, int decode_fec);

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x14EDFF0", Offset = "0x14ECFF0", VA = "0x1814EDFF0")]
		public static extern int opus_packet_get_bandwidth(byte[] data);

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x14EE090", Offset = "0x14ED090", VA = "0x1814EE090")]
		public static extern int opus_packet_get_nb_channels(byte[] data);

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x14EE130", Offset = "0x14ED130", VA = "0x1814EE130")]
		private static extern IntPtr opus_strerror(OpusStatusCode error);

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x14EDA60", Offset = "0x14ECA60", VA = "0x1814EDA60")]
		public static IntPtr opus_encoder_create(SamplingRate Fs, Channels channels, OpusApplicationType application)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x14ED8F0", Offset = "0x14EC8F0", VA = "0x1814ED8F0")]
		public static int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x14ED690", Offset = "0x14EC690", VA = "0x1814ED690")]
		public static int opus_encode(IntPtr st, float[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x14EDDB0", Offset = "0x14ECDB0", VA = "0x1814EDDB0")]
		public static void opus_encoder_destroy(IntPtr st)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x14ECBD0", Offset = "0x14EBBD0", VA = "0x1814ECBD0")]
		public static int get_opus_encoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x14EE2E0", Offset = "0x14ED2E0", VA = "0x1814EE2E0")]
		public static void set_opus_encoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x14ECAB0", Offset = "0x14EBAB0", VA = "0x1814ECAB0")]
		public static int get_opus_decoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x14EE1C0", Offset = "0x14ED1C0", VA = "0x1814EE1C0")]
		public static void set_opus_decoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x14ED0D0", Offset = "0x14EC0D0", VA = "0x1814ED0D0")]
		public static IntPtr opus_decoder_create(SamplingRate Fs, Channels channels)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x14ED400", Offset = "0x14EC400", VA = "0x1814ED400")]
		public static void opus_decoder_destroy(IntPtr st)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x14ECFD0", Offset = "0x14EBFD0", VA = "0x1814ECFD0")]
		public static int opus_decode(IntPtr st, byte[] data, short[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x14ECDE0", Offset = "0x14EBDE0", VA = "0x1814ECDE0")]
		public static int opus_decode(IntPtr st, byte[] data, float[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x14EC980", Offset = "0x14EB980", VA = "0x1814EC980")]
		private static void HandleStatusCode(OpusStatusCode statusCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
		public Wrapper()
		{
		}
	}
}
namespace POpusCodec.Enums
{
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public enum Bandwidth
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		Narrowband = 1101,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		Mediumband,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		Wideband,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		SuperWideband,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		Fullband
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum Channels
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		Mono = 1,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		Stereo
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public enum Complexity
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Complexity0,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		Complexity1,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		Complexity2,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		Complexity3,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		Complexity4,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		Complexity5,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		Complexity6,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		Complexity7,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		Complexity8,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		Complexity9,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		Complexity10
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum Delay
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Delay2dot5ms = 5,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Delay5ms = 10,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Delay10ms = 20,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Delay20ms = 40,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Delay40ms = 80,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Delay60ms = 120
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum ForceChannels
	{
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		NoForce = -1000,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Mono = 1,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		Stereo = 2
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public enum OpusApplicationType
	{
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		Voip = 2048,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		Audio = 2049,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		RestrictedLowDelay = 2051
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal enum OpusCtlGetRequest
	{
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		Application = 4001,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		Bitrate = 4003,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		MaxBandwidth = 4005,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		VBR = 4007,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		Bandwidth = 4009,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		Complexity = 4011,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		InbandFec = 4013,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		PacketLossPercentage = 4015,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Dtx = 4017,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		VBRConstraint = 4021,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		ForceChannels = 4023,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		Signal = 4025,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		LookAhead = 4027,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		SampleRate = 4029,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		FinalRange = 4031,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		Pitch = 4033,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		Gain = 4035,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		LsbDepth = 4037,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		LastPacketDurationRequest = 4039
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal enum OpusCtlSetRequest
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		Application = 4000,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		Bitrate = 4002,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		MaxBandwidth = 4004,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		VBR = 4006,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		Bandwidth = 4008,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Complexity = 4010,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		InbandFec = 4012,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		PacketLossPercentage = 4014,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Dtx = 4016,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		VBRConstraint = 4020,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		ForceChannels = 4022,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		Signal = 4024,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Gain = 4034,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		LsbDepth = 4036
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public enum OpusStatusCode
	{
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		OK = 0,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		BadArguments = -1,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		BufferTooSmall = -2,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		InternalError = -3,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		InvalidPacket = -4,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		Unimplemented = -5,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		InvalidState = -6,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		AllocFail = -7
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public enum SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		Sampling08000 = 8000,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		Sampling12000 = 12000,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		Sampling16000 = 16000,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		Sampling24000 = 24000,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		Sampling48000 = 48000
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public enum SignalHint
	{
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		Auto = -1000,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		Voice = 3001,
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Music = 3002
	}
}
namespace Photon.Realtime
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public abstract class PhotonPing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public string DebugString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public bool Successful;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		protected internal bool GotResult;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		protected internal int PingLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		protected internal byte[] PingBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		protected internal byte PingId;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x14DD850", Offset = "0x14DC850", VA = "0x1814DD850", Slot = "5")]
		public virtual bool StartPing(string ip)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x14DD800", Offset = "0x14DC800", VA = "0x1814DD800", Slot = "6")]
		public virtual bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x14DD7B0", Offset = "0x14DC7B0", VA = "0x1814DD7B0", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6BAA10", Offset = "0x6B9A10", VA = "0x1806BAA10")]
		protected internal void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x14DD8A0", Offset = "0x14DC8A0", VA = "0x1814DD8A0")]
		protected PhotonPing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class PingMono : PhotonPing
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private Socket sock;

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x14DDAD0", Offset = "0x14DCAD0", VA = "0x1814DDAD0", Slot = "5")]
		public override bool StartPing(string ip)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x14DD9A0", Offset = "0x14DC9A0", VA = "0x1814DD9A0", Slot = "6")]
		public override bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x14DD920", Offset = "0x14DC920", VA = "0x1814DD920", Slot = "7")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x14DD8A0", Offset = "0x14DC8A0", VA = "0x1814DD8A0")]
		public PingMono()
		{
		}
	}
}
namespace ExitGames.Client.Photon.Voice
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public static class AudioUtil
	{
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		public class Resampler<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			protected T[] frameResampled;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			private int channels;

			[Cpp2IlInjected.Token(Token = "0x6000534")]
			[Cpp2IlInjected.Address(RVA = "0x15D6E60", Offset = "0x15D5E60", VA = "0x1815D6E60")]
			public Resampler(int dstSize, int channels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000535")]
			[Cpp2IlInjected.Address(RVA = "0x15D6E10", Offset = "0x15D5E10", VA = "0x1815D6E10", Slot = "4")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F0")]
		public interface ILevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x170000E9")]
			float CurrentAvgAmp
			{
				[Cpp2IlInjected.Token(Token = "0x6000537")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000EA")]
			float CurrentPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x6000538")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000EB")]
			float PeakAmpForFrame
			{
				[Cpp2IlInjected.Token(Token = "0x6000539")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000EC")]
			float AccumAvgPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x600053A")]
				[Cpp2IlInjected.Address(Slot = "3")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void ResetAccumAvgPeakAmp();
		}

		[Cpp2IlInjected.Token(Token = "0x20000F1")]
		public class LevelMetterDummy : ILevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x170000ED")]
			public float CurrentAvgAmp
			{
				[Cpp2IlInjected.Token(Token = "0x600053C")]
				[Cpp2IlInjected.Address(RVA = "0x4B6210", Offset = "0x4B5210", VA = "0x1804B6210", Slot = "4")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000EE")]
			public float CurrentPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x600053D")]
				[Cpp2IlInjected.Address(RVA = "0x4B6210", Offset = "0x4B5210", VA = "0x1804B6210", Slot = "5")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000EF")]
			public float PeakAmpForFrame
			{
				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0x4B6210", Offset = "0x4B5210", VA = "0x1804B6210", Slot = "6")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F0")]
			public float AccumAvgPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x600053F")]
				[Cpp2IlInjected.Address(RVA = "0x4B6210", Offset = "0x4B5210", VA = "0x1804B6210", Slot = "7")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20", Slot = "8")]
			public void ResetAccumAvgPeakAmp()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000541")]
			[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
			public LevelMetterDummy()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public abstract class LevelMeter<T> : LocalVoiceFramed<T>.IProcessor, IDisposable, ILevelMeter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			protected float ampSum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			protected float ampPeak;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			protected int bufferSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			protected float[] buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			protected int prevValuesPtr;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			protected float accumAvgPeakAmpSum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047F")]
			protected int accumAvgPeakAmpCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			protected float peakAmpForFrame;

			[Cpp2IlInjected.Token(Token = "0x170000F1")]
			public float CurrentAvgAmp
			{
				[Cpp2IlInjected.Token(Token = "0x6000543")]
				[Cpp2IlInjected.Address(RVA = "0x15D59B0", Offset = "0x15D49B0", VA = "0x1815D59B0", Slot = "6")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F2")]
			public float CurrentPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x6000544")]
				[Cpp2IlInjected.Address(RVA = "0x436930", Offset = "0x435930", VA = "0x180436930", Slot = "7")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000545")]
				[Cpp2IlInjected.Address(RVA = "0x436940", Offset = "0x435940", VA = "0x180436940")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F3")]
			public float PeakAmpForFrame
			{
				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0x4377D0", Offset = "0x4367D0", VA = "0x1804377D0", Slot = "8")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F4")]
			public float AccumAvgPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x6000547")]
				[Cpp2IlInjected.Address(RVA = "0x15D5990", Offset = "0x15D4990", VA = "0x1815D5990", Slot = "9")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000542")]
			[Cpp2IlInjected.Address(RVA = "0x15D5890", Offset = "0x15D4890", VA = "0x1815D5890")]
			internal LevelMeter(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0x15D5800", Offset = "0x15D4800", VA = "0x1815D5800", Slot = "10")]
			public void ResetAccumAvgPeakAmp()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract T[] Process(T[] buf);

			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		public class LevelMeterFloat : LevelMeter<float>
		{
			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x19770F0", Offset = "0x19760F0", VA = "0x1819770F0")]
			public LevelMeterFloat(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054C")]
			[Cpp2IlInjected.Address(RVA = "0x1976F40", Offset = "0x1975F40", VA = "0x181976F40", Slot = "11")]
			public override float[] Process(float[] buf)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		public class LevelMeterShort : LevelMeter<short>
		{
			[Cpp2IlInjected.Token(Token = "0x600054D")]
			[Cpp2IlInjected.Address(RVA = "0x1977320", Offset = "0x1976320", VA = "0x181977320")]
			public LevelMeterShort(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054E")]
			[Cpp2IlInjected.Address(RVA = "0x1977150", Offset = "0x1976150", VA = "0x181977150", Slot = "11")]
			public override short[] Process(short[] buf)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		public interface IVoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x170000F5")]
			bool On
			{
				[Cpp2IlInjected.Token(Token = "0x600054F")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000550")]
				[Cpp2IlInjected.Address(Slot = "1")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000F6")]
			float Threshold
			{
				[Cpp2IlInjected.Token(Token = "0x6000551")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000552")]
				[Cpp2IlInjected.Address(Slot = "3")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000F7")]
			bool Detected
			{
				[Cpp2IlInjected.Token(Token = "0x6000553")]
				[Cpp2IlInjected.Address(Slot = "4")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000F8")]
			DateTime DetectedTime
			{
				[Cpp2IlInjected.Token(Token = "0x6000554")]
				[Cpp2IlInjected.Address(Slot = "5")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000F9")]
			int ActivityDelayMs
			{
				[Cpp2IlInjected.Token(Token = "0x6000557")]
				[Cpp2IlInjected.Address(Slot = "8")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000558")]
				[Cpp2IlInjected.Address(Slot = "9")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x14000005")]
			event Action OnDetected;
		}

		[Cpp2IlInjected.Token(Token = "0x20000F6")]
		public class VoiceDetectorCalibration<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			private IVoiceDetector voiceDetector;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			private ILevelMeter levelMeter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			private int valuesPerSec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			protected int voiceDetectorCalibrateCount;

			[Cpp2IlInjected.Token(Token = "0x170000FA")]
			public bool VoiceDetectorCalibrating
			{
				[Cpp2IlInjected.Token(Token = "0x6000559")]
				[Cpp2IlInjected.Address(RVA = "0x638E50", Offset = "0x637E50", VA = "0x180638E50")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0x109ED40", Offset = "0x109DD40", VA = "0x18109ED40")]
			public VoiceDetectorCalibration(IVoiceDetector voiceDetector, ILevelMeter levelMeter, int samplingRate, int channels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x15D8290", Offset = "0x15D7290", VA = "0x1815D8290")]
			public void VoiceDetectorCalibrate(int durationMs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x15D8130", Offset = "0x15D7130", VA = "0x1815D8130", Slot = "4")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		public class VoiceDetectorDummy : IVoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x170000FB")]
			public bool On
			{
				[Cpp2IlInjected.Token(Token = "0x600055E")]
				[Cpp2IlInjected.Address(RVA = "0x367E20", Offset = "0x366E20", VA = "0x180367E20", Slot = "4")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FC")]
			public float Threshold
			{
				[Cpp2IlInjected.Token(Token = "0x6000560")]
				[Cpp2IlInjected.Address(RVA = "0x4B6210", Offset = "0x4B5210", VA = "0x1804B6210", Slot = "6")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000561")]
				[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20", Slot = "7")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FD")]
			public bool Detected
			{
				[Cpp2IlInjected.Token(Token = "0x6000562")]
				[Cpp2IlInjected.Address(RVA = "0x367E20", Offset = "0x366E20", VA = "0x180367E20", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FE")]
			public int ActivityDelayMs
			{
				[Cpp2IlInjected.Token(Token = "0x6000563")]
				[Cpp2IlInjected.Address(RVA = "0x3DDDE0", Offset = "0x3DCDE0", VA = "0x1803DDDE0", Slot = "12")]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000564")]
				[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20", Slot = "13")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FF")]
			public DateTime DetectedTime
			{
				[Cpp2IlInjected.Token(Token = "0x6000565")]
				[Cpp2IlInjected.Address(RVA = "0x38FC50", Offset = "0x38EC50", VA = "0x18038FC50", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(DateTime);
				}
				[Cpp2IlInjected.Token(Token = "0x6000566")]
				[Cpp2IlInjected.Address(RVA = "0x38BFA0", Offset = "0x38AFA0", VA = "0x18038BFA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action OnDetected
			{
				[Cpp2IlInjected.Token(Token = "0x6000567")]
				[Cpp2IlInjected.Address(RVA = "0x1988900", Offset = "0x1987900", VA = "0x181988900", Slot = "10")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000568")]
				[Cpp2IlInjected.Address(RVA = "0x19889A0", Offset = "0x19879A0", VA = "0x1819889A0", Slot = "11")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
			public VoiceDetectorDummy()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public abstract class VoiceDetector<T> : LocalVoiceFramed<T>.IProcessor, IDisposable, IVoiceDetector
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private bool detected;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			protected int activityDelay;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			protected int autoSilenceCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			protected int valuesCountPerSec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			protected int activityDelayValuesCount;

			[Cpp2IlInjected.Token(Token = "0x17000100")]
			public bool On
			{
				[Cpp2IlInjected.Token(Token = "0x600056A")]
				[Cpp2IlInjected.Address(RVA = "0x38BAB0", Offset = "0x38AAB0", VA = "0x18038BAB0", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600056B")]
				[Cpp2IlInjected.Address(RVA = "0x38BAC0", Offset = "0x38AAC0", VA = "0x18038BAC0", Slot = "7")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000101")]
			public float Threshold
			{
				[Cpp2IlInjected.Token(Token = "0x600056C")]
				[Cpp2IlInjected.Address(RVA = "0x47C2F0", Offset = "0x47B2F0", VA = "0x18047C2F0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600056D")]
				[Cpp2IlInjected.Address(RVA = "0x47C2E0", Offset = "0x47B2E0", VA = "0x18047C2E0", Slot = "9")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000102")]
			public bool Detected
			{
				[Cpp2IlInjected.Token(Token = "0x600056E")]
				[Cpp2IlInjected.Address(RVA = "0x4AD2F0", Offset = "0x4AC2F0", VA = "0x1804AD2F0", Slot = "10")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600056F")]
				[Cpp2IlInjected.Address(RVA = "0x109F3E0", Offset = "0x109E3E0", VA = "0x18109F3E0")]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000103")]
			public DateTime DetectedTime
			{
				[Cpp2IlInjected.Token(Token = "0x6000570")]
				[Cpp2IlInjected.Address(RVA = "0x390560", Offset = "0x38F560", VA = "0x180390560", Slot = "11")]
				[CompilerGenerated]
				get
				{
					return default(DateTime);
				}
				[Cpp2IlInjected.Token(Token = "0x6000571")]
				[Cpp2IlInjected.Address(RVA = "0x3903B0", Offset = "0x38F3B0", VA = "0x1803903B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000104")]
			public int ActivityDelayMs
			{
				[Cpp2IlInjected.Token(Token = "0x6000572")]
				[Cpp2IlInjected.Address(RVA = "0x455A20", Offset = "0x454A20", VA = "0x180455A20", Slot = "14")]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000573")]
				[Cpp2IlInjected.Address(RVA = "0x109F250", Offset = "0x109E250", VA = "0x18109F250", Slot = "15")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action OnDetected
			{
				[Cpp2IlInjected.Token(Token = "0x6000574")]
				[Cpp2IlInjected.Address(RVA = "0x109EF90", Offset = "0x109DF90", VA = "0x18109EF90", Slot = "12")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000575")]
				[Cpp2IlInjected.Address(RVA = "0x109F040", Offset = "0x109E040", VA = "0x18109F040", Slot = "13")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x109EDA0", Offset = "0x109DDA0", VA = "0x18109EDA0")]
			internal VoiceDetector(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(Slot = "16")]
			public abstract T[] Process(T[] buf);

			[Cpp2IlInjected.Token(Token = "0x6000578")]
			[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		public class VoiceDetectorFloat : VoiceDetector<float>
		{
			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x1988B70", Offset = "0x1987B70", VA = "0x181988B70")]
			public VoiceDetectorFloat(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057A")]
			[Cpp2IlInjected.Address(RVA = "0x1988A40", Offset = "0x1987A40", VA = "0x181988A40", Slot = "16")]
			public override float[] Process(float[] buffer)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		public class VoiceDetectorShort : VoiceDetector<short>
		{
			[Cpp2IlInjected.Token(Token = "0x600057B")]
			[Cpp2IlInjected.Address(RVA = "0x1988D20", Offset = "0x1987D20", VA = "0x181988D20")]
			internal VoiceDetectorShort(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057C")]
			[Cpp2IlInjected.Address(RVA = "0x1988BE0", Offset = "0x1987BE0", VA = "0x181988BE0", Slot = "16")]
			public override short[] Process(short[] buffer)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		public class VoiceLevelDetectCalibrate<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			private VoiceDetectorCalibration<T> c;

			[Cpp2IlInjected.Token(Token = "0x17000105")]
			public ILevelMeter Level
			{
				[Cpp2IlInjected.Token(Token = "0x600057D")]
				[Cpp2IlInjected.Address(RVA = "0x38FC50", Offset = "0x38EC50", VA = "0x18038FC50")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600057E")]
				[Cpp2IlInjected.Address(RVA = "0x38BFA0", Offset = "0x38AFA0", VA = "0x18038BFA0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000106")]
			public IVoiceDetector Detector
			{
				[Cpp2IlInjected.Token(Token = "0x600057F")]
				[Cpp2IlInjected.Address(RVA = "0x361AC0", Offset = "0x360AC0", VA = "0x180361AC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000580")]
				[Cpp2IlInjected.Address(RVA = "0x390550", Offset = "0x38F550", VA = "0x180390550")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x109FB60", Offset = "0x109EB60", VA = "0x18109FB60")]
			public VoiceLevelDetectCalibrate(int samplingRate, int channels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0x109F490", Offset = "0x109E490", VA = "0x18109F490")]
			public void Calibrate(int durationMs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0x109F970", Offset = "0x109E970", VA = "0x18109F970", Slot = "4")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0x109F4C0", Offset = "0x109E4C0", VA = "0x18109F4C0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public const float SHORT_TO_NORMALIZED_FLOAT_RATIO = 3.051851E-05f;

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x13E5B40", Offset = "0x13E4B40", VA = "0x1813E5B40")]
		public static void Resample<T>(T[] src, T[] dst, int dstCount, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x19741B0", Offset = "0x19731B0", VA = "0x1819741B0")]
		public static void ResampleAndConvert(short[] src, float[] dst, int dstCount, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x1973EF0", Offset = "0x1972EF0", VA = "0x181973EF0")]
		public static void ResampleAndConvert(float[] src, short[] dst, int dstCount, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x1973E70", Offset = "0x1972E70", VA = "0x181973E70")]
		public static void Convert(float[] src, short[] dst, int dstCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x1973DE0", Offset = "0x1972DE0", VA = "0x181973DE0")]
		public static void Convert(short[] src, float[] dst, int dstCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x13E5A30", Offset = "0x13E4A30", VA = "0x1813E5A30")]
		public static void ForceToStereo<T>(T[] src, T[] dst, int srcChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x13A7E80", Offset = "0x13A6E80", VA = "0x1813A7E80")]
		internal static string tostr<T>(T[] x, int lim = 10)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public interface IAudioOut
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool IsPlaying
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		int CurrentBufferLag
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Start(int frequency, int channels, int frameSamplesPerChannel, int playDelayMs);

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Stop();

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnAudioFrame(float[] frame);

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Service();

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Pause();
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public abstract class ObjectPool<TType, TInfo> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		protected int capacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		protected TInfo info;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private TType[] freeObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		protected int pos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		protected string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private bool inited;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		internal string LogPrefix
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x109D6E0", Offset = "0x109C6E0", VA = "0x18109D6E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public TInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x3922C0", Offset = "0x3912C0", VA = "0x1803922C0")]
			get
			{
				return (TInfo)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract TType createObject(TInfo info);

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void destroyObject(TType obj);

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract bool infosMatch(TInfo i0, TInfo i1);

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x109D560", Offset = "0x109C560", VA = "0x18109D560")]
		public ObjectPool(int capacity, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x109D5D0", Offset = "0x109C5D0", VA = "0x18109D5D0")]
		public ObjectPool(int capacity, string name, TInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x109CD50", Offset = "0x109BD50", VA = "0x18109CD50")]
		public void Init(TInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x109C6A0", Offset = "0x109B6A0", VA = "0x18109C6A0")]
		public TType AcquireOrCreate()
		{
			return (TType)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x109C880", Offset = "0x109B880", VA = "0x18109C880")]
		public TType AcquireOrCreate(TInfo info)
		{
			return (TType)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x109D330", Offset = "0x109C330", VA = "0x18109D330", Slot = "8")]
		public virtual bool Release(TType obj, TInfo objInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x109D1B0", Offset = "0x109C1B0", VA = "0x18109D1B0", Slot = "9")]
		public virtual bool Release(TType obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x109CAC0", Offset = "0x109BAC0", VA = "0x18109CAC0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class PrimitiveArrayPool<T> : ObjectPool<T[], int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x109D780", Offset = "0x109C780", VA = "0x18109D780")]
		public PrimitiveArrayPool(int capacity, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x109D7B0", Offset = "0x109C7B0", VA = "0x18109D7B0")]
		public PrimitiveArrayPool(int capacity, string name, int info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x109D7E0", Offset = "0x109C7E0", VA = "0x18109D7E0", Slot = "5")]
		protected override T[] createObject(int info)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20", Slot = "6")]
		protected override void destroyObject(T[] obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7FE4E0", Offset = "0x7FD4E0", VA = "0x1807FE4E0", Slot = "7")]
		protected override bool infosMatch(int i0, int i1)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class ImageBufferNativePool<T> : ObjectPool<T, ImageBufferInfo> where T : ImageBufferNative
	{
		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		public delegate T Factory(ImageBufferNativePool<T> pool, ImageBufferInfo info);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private Factory factory;

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x1091170", Offset = "0x1090170", VA = "0x181091170")]
		public ImageBufferNativePool(int capacity, Factory factory, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x10911C0", Offset = "0x10901C0", VA = "0x1810911C0")]
		public ImageBufferNativePool(int capacity, Factory factory, string name, ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x1091220", Offset = "0x1090220", VA = "0x181091220", Slot = "5")]
		protected override T createObject(ImageBufferInfo info)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x1091260", Offset = "0x1090260", VA = "0x181091260", Slot = "6")]
		protected override void destroyObject(T obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1091290", Offset = "0x1090290", VA = "0x181091290", Slot = "7")]
		protected override bool infosMatch(ImageBufferInfo i0, ImageBufferInfo i1)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class OpusCodec
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		public enum FrameDuration
		{
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			Frame2dot5ms = 2500,
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			Frame5ms = 5000,
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			Frame10ms = 10000,
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			Frame20ms = 20000,
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			Frame40ms = 40000,
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			Frame60ms = 60000
		}

		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		public static class EncoderFactory
		{
			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0x19757B0", Offset = "0x19747B0", VA = "0x1819757B0")]
			public static IEncoder Create(VoiceInfo i, LocalVoice localVoice)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		public abstract class Encoder<T> : IEncoderDataFlowDirect<T>, IEncoderDataFlow<T>, IEncoder, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			protected OpusEncoder encoder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			protected bool disposed;

			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0x108BC60", Offset = "0x108AC60", VA = "0x18108BC60")]
			protected Encoder(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0x108B920", Offset = "0x108A920", VA = "0x18108B920", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract ArraySegment<byte> EncodeAndGetOutput(T[] buf);
		}

		[Cpp2IlInjected.Token(Token = "0x2000100")]
		public class EncoderFloat : Encoder<float>
		{
			[Cpp2IlInjected.Token(Token = "0x400049D")]
			private static readonly ArraySegment<byte> EmptyBuffer;

			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0x1975C10", Offset = "0x1974C10", VA = "0x181975C10")]
			internal EncoderFloat(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058E")]
			[Cpp2IlInjected.Address(RVA = "0x1975A10", Offset = "0x1974A10", VA = "0x181975A10", Slot = "6")]
			public override ArraySegment<byte> EncodeAndGetOutput(float[] buf)
			{
				return default(ArraySegment<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000101")]
		public class EncoderShort : Encoder<short>
		{
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			private static readonly ArraySegment<byte> EmptyBuffer;

			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x1975E80", Offset = "0x1974E80", VA = "0x181975E80")]
			internal EncoderShort(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0x1975C80", Offset = "0x1974C80", VA = "0x181975C80", Slot = "6")]
			public override ArraySegment<byte> EncodeAndGetOutput(short[] buf)
			{
				return default(ArraySegment<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000102")]
		public class Decoder : IDecoderDirect, IDecoder, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			private OpusDecoder decoder;

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0x1974C40", Offset = "0x1973C40", VA = "0x181974C40", Slot = "7")]
			public void Open(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0x1974B90", Offset = "0x1973B90", VA = "0x181974B90", Slot = "4")]
			public byte[] DecodeToByte(byte[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x1974BE0", Offset = "0x1973BE0", VA = "0x181974BE0", Slot = "5")]
			public float[] DecodeToFloat(byte[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x1974C00", Offset = "0x1973C00", VA = "0x181974C00", Slot = "6")]
			public short[] DecodeToShort(byte[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x1974C20", Offset = "0x1973C20", VA = "0x181974C20", Slot = "8")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
			public Decoder()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000103")]
		public class Util
		{
			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0x19886A0", Offset = "0x19876A0", VA = "0x1819886A0")]
			internal static int bestEncoderSampleRate(int f)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
			public Util()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
		public OpusCodec()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class SpeexProcessor : SpeexLib, LocalVoiceFramed<short>.IProcessor, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000104")]
		public struct AECLatencyResultType
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			public int LatencyMs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			public int LatencyDelayedMs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			public bool PlayDetected;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			public bool PlayDelayedDetected;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			public bool RecDetected;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private bool _AEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int _AECPlaybackDelayMs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private bool _AECLatencyDetect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private int frameSamples;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private int samplingRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private int channels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private int playDelayFrames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private int playDelayMaxFrames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private IntPtr stEcho;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private IntPtr st;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private short[] resultBuf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private PrimitiveArrayPool<short> playbackBufPool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private Queue<short[]> playBufQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private Framer<float> playFramer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private int playSamplingRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private int playChannels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private ILogger logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private Func<long> clockMs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private AudioUtil.VoiceLevelDetectCalibrate<float> detectPlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private AudioUtil.VoiceLevelDetectCalibrate<short> detectPlayCorr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private AudioUtil.VoiceLevelDetectCalibrate<short> detectRec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private long detectTimePlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private long detectTimePlayDelayed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private long detectTimeRec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private int frameCntRec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private int frameCntPlay;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool AEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x38BAB0", Offset = "0x38AAB0", VA = "0x18038BAB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x14E1730", Offset = "0x14E0730", VA = "0x1814E1730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int AECFilterLengthMs
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x3922C0", Offset = "0x3912C0", VA = "0x1803922C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x392470", Offset = "0x391470", VA = "0x180392470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int AECPlaybackDelayMs
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x427840", Offset = "0x426840", VA = "0x180427840")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x14E1710", Offset = "0x14E0710", VA = "0x1814E1710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int AECurrentPlayDelayFrames
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x14E1610", Offset = "0x14E0610", VA = "0x1814E1610")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool AECLatencyDetect
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x427970", Offset = "0x426970", VA = "0x180427970")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x14E16F0", Offset = "0x14E06F0", VA = "0x1814E16F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public AECLatencyResultType AECLatencyResult
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x14E14E0", Offset = "0x14E04E0", VA = "0x1814E14E0")]
			get
			{
				return default(AECLatencyResultType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool Denoise
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x14E16C0", Offset = "0x14E06C0", VA = "0x1814E16C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x14E17F0", Offset = "0x14E07F0", VA = "0x1814E17F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool AGC
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x14E1690", Offset = "0x14E0690", VA = "0x1814E1690")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x14E17C0", Offset = "0x14E07C0", VA = "0x1814E17C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public float AGCLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x14E1660", Offset = "0x14E0660", VA = "0x1814E1660")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x14E1790", Offset = "0x14E0790", VA = "0x1814E1790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x14E0FC0", Offset = "0x14DFFC0", VA = "0x1814E0FC0")]
		public void ResetAEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x14DF4E0", Offset = "0x14DE4E0", VA = "0x1814DF4E0")]
		public void AECLatecnyDetectCaliberate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x14E1820", Offset = "0x14E0820", VA = "0x1814E1820")]
		private void set(int param, bool val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x14E1850", Offset = "0x14E0850", VA = "0x1814E1850")]
		private void set(int param, float val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x14E1480", Offset = "0x14E0480", VA = "0x1814E1480")]
		private bool getBool(int param)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x14E14B0", Offset = "0x14E04B0", VA = "0x1814E14B0")]
		private float getFloat(int param)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x14E1160", Offset = "0x14E0160", VA = "0x1814E1160")]
		public SpeexProcessor(ILogger logger, Func<long> clockMs, int frameSize, int samplingRate, int channels, int playSamplingRate, int playChannels, int playBufSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x14E0110", Offset = "0x14DF110", VA = "0x1814E0110")]
		private void InitLatencyDetect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x14DF7E0", Offset = "0x14DE7E0", VA = "0x1814DF7E0")]
		public void InitAEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x14E0310", Offset = "0x14DF310", VA = "0x1814E0310")]
		private void InitPlayDelay(int ms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x14E0B40", Offset = "0x14DFB40", VA = "0x1814E0B40", Slot = "4")]
		public short[] Process(short[] buf)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x14E03D0", Offset = "0x14DF3D0", VA = "0x1814E03D0")]
		public void OnAudioOutFrame(float[] data, int outChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20")]
		public void PrintInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x14DF570", Offset = "0x14DE570", VA = "0x1814DF570")]
		private void DestroyEchoState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x14DF660", Offset = "0x14DE660", VA = "0x1814DF660", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class SpeexLib
	{
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private const string lib_name = "libspeexdsp";

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const int SPEEX_PREPROCESS_SET_DENOISE = 0;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const int SPEEX_PREPROCESS_GET_DENOISE = 1;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public const int SPEEX_PREPROCESS_SET_AGC = 2;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public const int SPEEX_PREPROCESS_GET_AGC = 3;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public const int SPEEX_PREPROCESS_SET_VAD = 4;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public const int SPEEX_PREPROCESS_GET_VAD = 5;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public const int SPEEX_PREPROCESS_SET_AGC_LEVEL = 6;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public const int SPEEX_PREPROCESS_GET_AGC_LEVEL = 7;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB = 8;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB = 9;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB_LEVEL = 10;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB_LEVEL = 11;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB_DECAY = 12;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB_DECAY = 13;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public const int SPEEX_PREPROCESS_SET_PROB_START = 14;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public const int SPEEX_PREPROCESS_GET_PROB_START = 15;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public const int SPEEX_PREPROCESS_SET_PROB_CONTINUE = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public const int SPEEX_PREPROCESS_GET_PROB_CONTINUE = 17;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public const int SPEEX_PREPROCESS_SET_NOISE_SUPPRESS = 18;

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public const int SPEEX_PREPROCESS_GET_NOISE_SUPPRESS = 19;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public const int SPEEX_PREPROCESS_SET_ECHO_SUPPRESS = 20;

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public const int SPEEX_PREPROCESS_GET_ECHO_SUPPRESS = 21;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public const int SPEEX_PREPROCESS_SET_ECHO_SUPPRESS_ACTIVE = 22;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public const int SPEEX_PREPROCESS_GET_ECHO_SUPPRESS_ACTIVE = 23;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public const int SPEEX_PREPROCESS_SET_ECHO_STATE = 24;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public const int SPEEX_PREPROCESS_GET_ECHO_STATE = 25;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public const int SPEEX_PREPROCESS_SET_AGC_INCREMENT = 26;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public const int SPEEX_PREPROCESS_GET_AGC_INCREMENT = 27;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public const int SPEEX_PREPROCESS_SET_AGC_DECREMENT = 28;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public const int SPEEX_PREPROCESS_GET_AGC_DECREMENT = 29;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public const int SPEEX_PREPROCESS_SET_AGC_MAX_GAIN = 30;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public const int SPEEX_PREPROCESS_GET_AGC_MAX_GAIN = 31;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public const int SPEEX_PREPROCESS_GET_AGC_LOUDNESS = 33;

		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public const int SPEEX_PREPROCESS_GET_AGC_GAIN = 35;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public const int SPEEX_PREPROCESS_GET_PSD_SIZE = 37;

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public const int SPEEX_PREPROCESS_GET_PSD = 39;

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public const int SPEEX_PREPROCESS_GET_NOISE_PSD_SIZE = 41;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public const int SPEEX_PREPROCESS_GET_NOISE_PSD = 43;

		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public const int SPEEX_PREPROCESS_GET_PROB = 45;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public const int SPEEX_PREPROCESS_SET_AGC_TARGET = 46;

		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public const int SPEEX_PREPROCESS_GET_AGC_TARGET = 47;

		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public const int SPEEX_ECHO_GET_FRAME_SIZE = 3;

		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public const int SPEEX_ECHO_SET_SAMPLING_RATE = 24;

		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public const int SPEEX_ECHO_GET_SAMPLING_RATE = 25;

		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public const int SPEEX_ECHO_GET_IMPULSE_RESPONSE_SIZE = 27;

		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public const int SPEEX_ECHO_GET_IMPULSE_RESPONSE = 29;

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x14DF440", Offset = "0x14DE440", VA = "0x1814DF440")]
		public static extern IntPtr speex_preprocess_state_init(int frame_size, int sampling_rate);

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x14DF3B0", Offset = "0x14DE3B0", VA = "0x1814DF3B0")]
		public static extern void speex_preprocess_state_destroy(IntPtr st);

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x14DF300", Offset = "0x14DE300", VA = "0x1814DF300")]
		public static extern int speex_preprocess_run(IntPtr st, short[] x);

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x14DEFF0", Offset = "0x14DDFF0", VA = "0x1814DEFF0")]
		public static extern int speex_preprocess_ctl(IntPtr st, int request, IntPtr ptr);

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x14DF1C0", Offset = "0x14DE1C0", VA = "0x1814DF1C0")]
		public static int speex_preprocess_ctl(IntPtr st, int request, ref int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x14DF0A0", Offset = "0x14DE0A0", VA = "0x1814DF0A0")]
		public static int speex_preprocess_ctl(IntPtr st, int request, ref float value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x14DEE00", Offset = "0x14DDE00", VA = "0x1814DEE00")]
		public static extern IntPtr speex_echo_state_init(int frame_size, int filter_length);

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x14DEEA0", Offset = "0x14DDEA0", VA = "0x1814DEEA0")]
		public static extern IntPtr speex_echo_state_init_mc(int frame_size, int filter_length, int nb_mic, int nb_speakers);

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x14DED70", Offset = "0x14DDD70", VA = "0x1814DED70")]
		public static extern void speex_echo_state_destroy(IntPtr st);

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x14DE7D0", Offset = "0x14DD7D0", VA = "0x1814DE7D0")]
		public static extern void speex_echo_cancellation(IntPtr st, short[] rec, short[] play, short[] outBuf);

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x14DE8B0", Offset = "0x14DD8B0", VA = "0x1814DE8B0")]
		public static extern void speex_echo_capture(IntPtr st, short[] rec, short[] outBuf);

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x14DECC0", Offset = "0x14DDCC0", VA = "0x1814DECC0")]
		public static extern void speex_echo_playback(IntPtr st, short[] play);

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x14DEF60", Offset = "0x14DDF60", VA = "0x1814DEF60")]
		public static extern void speex_echo_state_reset(IntPtr st);

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x14DE980", Offset = "0x14DD980", VA = "0x1814DE980")]
		public static extern int speex_echo_ctl(IntPtr st, int request, IntPtr ptr);

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x14DEB80", Offset = "0x14DDB80", VA = "0x1814DEB80")]
		public static int speex_echo_ctl(IntPtr st, int request, ref int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x14DEA30", Offset = "0x14DDA30", VA = "0x1814DEA30")]
		public static int speex_echo_ctl(IntPtr st, int request, ref float value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
		public SpeexLib()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public interface IDataReader<T> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Read(T[] buffer);
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public interface IServiceable
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Service(LocalVoice localVoice);
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class LocalVoice : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		public const int DATA_POOL_CAPACITY = 50;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private bool debugEchoMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		internal VoiceInfo info;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		protected IEncoder encoder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		internal byte id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		internal int channelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		internal byte evNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		protected VoiceClient voiceClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		protected bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		protected object disposeLock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private int noTransmitCnt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		internal Dictionary<byte, int> eventTimestamps;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public byte Group
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x38BAB0", Offset = "0x38AAB0", VA = "0x18038BAB0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x38BAC0", Offset = "0x38AAC0", VA = "0x18038BAC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public VoiceInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x19824D0", Offset = "0x19814D0", VA = "0x1819824D0")]
			get
			{
				return default(VoiceInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool Transmit
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x38B980", Offset = "0x38A980", VA = "0x18038B980")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x38BC40", Offset = "0x38AC40", VA = "0x18038BC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool IsTransmitting
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x397A60", Offset = "0x396A60", VA = "0x180397A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x397B70", Offset = "0x396B70", VA = "0x180397B70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public int FramesSent
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x3922C0", Offset = "0x3912C0", VA = "0x1803922C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x392470", Offset = "0x391470", VA = "0x180392470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public int FramesSentBytes
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x427840", Offset = "0x426840", VA = "0x180427840")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x427980", Offset = "0x426980", VA = "0x180427980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool Reliable
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x427970", Offset = "0x426970", VA = "0x180427970")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x427990", Offset = "0x426990", VA = "0x180427990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool Encrypt
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x98BE70", Offset = "0x98AE70", VA = "0x18098BE70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x98BE80", Offset = "0x98AE80", VA = "0x18098BE80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public object LocalUserObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x390560", Offset = "0x38F560", VA = "0x180390560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x3903B0", Offset = "0x38F3B0", VA = "0x1803903B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public IServiceable LocalUserServiceable
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x365D30", Offset = "0x364D30", VA = "0x180365D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x3903D0", Offset = "0x38F3D0", VA = "0x1803903D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool DebugEchoMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x36D870", Offset = "0x36C870", VA = "0x18036D870")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x1982BB0", Offset = "0x1981BB0", VA = "0x181982BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		internal string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x1982540", Offset = "0x1981540", VA = "0x181982540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		internal string LogPrefix
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x19824F0", Offset = "0x19814F0", VA = "0x1819824F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x1982440", Offset = "0x1981440", VA = "0x181982440")]
		internal LocalVoice()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x1982350", Offset = "0x1981350", VA = "0x181982350")]
		internal LocalVoice(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x1982740", Offset = "0x1981740", VA = "0x181982740")]
		protected void resetNoTransmitCnt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x19828E0", Offset = "0x19818E0", VA = "0x1819828E0", Slot = "5")]
		internal virtual void service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x1982750", Offset = "0x1981750", VA = "0x181982750")]
		internal void sendFrame(ArraySegment<byte> compressed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x1982320", Offset = "0x1981320", VA = "0x181982320")]
		public void RemoveSelf()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x19822B0", Offset = "0x19812B0", VA = "0x1819822B0", Slot = "6")]
		public virtual void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public struct RemoteVoiceOptions
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Action<byte[]> OnDecodedFrameByteAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x129120", Offset = "0x128520", VA = "0x180129120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x125E50", Offset = "0x125250", VA = "0x180125E50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Action<float[]> OnDecodedFrameFloatAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x129130", Offset = "0x128530", VA = "0x180129130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x142BF0", Offset = "0x141FF0", VA = "0x180142BF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Action<short[]> OnDecodedFrameShortAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x129E90", Offset = "0x129290", VA = "0x180129E90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x129E80", Offset = "0x129280", VA = "0x180129E80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public Action OnRemoteVoiceRemoveAction
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x1473B0", Offset = "0x1467B0", VA = "0x1801473B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x1473C0", Offset = "0x1467C0", VA = "0x1801473C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public object LocalUserObject
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x16EBF0", Offset = "0x16DFF0", VA = "0x18016EBF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x1EC320", Offset = "0x1EB720", VA = "0x1801EC320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public IDecoder Decoder
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x163B30", Offset = "0x162F30", VA = "0x180163B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x1EC310", Offset = "0x1EB710", VA = "0x1801EC310")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	internal class RemoteVoice : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		internal RemoteVoiceOptions options;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private int channelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private byte voiceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private object disposeLock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		internal byte lastEvNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private VoiceClient voiceClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private Queue<byte[]> frameQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private AutoResetEvent frameQueueReady;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		internal VoiceInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x42E890", Offset = "0x42D890", VA = "0x18042E890")]
			[CompilerGenerated]
			get
			{
				return default(VoiceInfo);
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x14DE430", Offset = "0x14DD430", VA = "0x1814DE430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		protected string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x1985110", Offset = "0x1984110", VA = "0x181985110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		protected string LogPrefix
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x19850C0", Offset = "0x19840C0", VA = "0x1819850C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x1983F40", Offset = "0x1982F40", VA = "0x181983F40")]
		internal RemoteVoice(VoiceClient client, RemoteVoiceOptions options, int channelId, int playerId, byte voiceId, VoiceInfo info, byte lastEventNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x19841D0", Offset = "0x19831D0", VA = "0x1819841D0")]
		private static byte byteDiff(byte latest, byte last)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x19853F0", Offset = "0x19843F0", VA = "0x1819853F0")]
		internal void receiveBytes(byte[] receivedBytes, byte evNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1985910", Offset = "0x1984910", VA = "0x181985910")]
		private void receiveFrame(byte[] frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x1985AF0", Offset = "0x1984AF0", VA = "0x181985AF0")]
		private void receiveNullFrames(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1984A10", Offset = "0x1983A10", VA = "0x181984A10")]
		private void decodeThread(IDecoder decoder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1984800", Offset = "0x1983800", VA = "0x181984800")]
		private void decodeFrame(IDecoder decoder, byte[] frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x19841E0", Offset = "0x19831E0", VA = "0x1819841E0")]
		internal byte[] decodeFrameToByte(byte[] buffer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x19845F0", Offset = "0x19835F0", VA = "0x1819845F0")]
		internal short[] decodeFrameToShort(byte[] buffer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x19843E0", Offset = "0x19833E0", VA = "0x1819843E0")]
		internal float[] decodeFrameToFloat(byte[] buffer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x1985CE0", Offset = "0x1984CE0", VA = "0x181985CE0")]
		internal void removeAndDispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x1983E20", Offset = "0x1982E20", VA = "0x181983E20", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public interface IAudioSource : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		int SamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		int Channels
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public interface IAudioReader<T> : IDataReader<T>, IDisposable, IAudioSource
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public interface IAudioPusher<T> : IAudioSource, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetCallback(Action<T[]> callback, LocalVoice localVoice);
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public interface ILocalVoiceAudio
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		AudioUtil.IVoiceDetector VoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		AudioUtil.ILevelMeter LevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		bool VoiceDetectorCalibrating
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VoiceDetectorCalibrate(int durationMs);
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public static class LocalVoiceAudio
	{
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public static LocalVoiceAudioDummy Dummy;

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x10DA050", Offset = "0x10D9050", VA = "0x1810DA050")]
		public static LocalVoiceAudio<T> Create<T>(VoiceClient voiceClient, byte voiceId, IEncoder encoder, VoiceInfo voiceInfo, int channelId)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public abstract class LocalVoiceAudio<T> : LocalVoiceFramed<T>, ILocalVoiceAudio
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		protected AudioUtil.VoiceDetector<T> voiceDetector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		protected AudioUtil.VoiceDetectorCalibration<T> voiceDetectorCalibration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		protected AudioUtil.LevelMeter<T> levelMeter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		protected int channels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		protected int sourceSamplingRateHz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		protected bool resampleSource;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public virtual AudioUtil.IVoiceDetector VoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x4677E0", Offset = "0x4667E0", VA = "0x1804677E0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public virtual AudioUtil.ILevelMeter LevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x41C320", Offset = "0x41B320", VA = "0x18041C320", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool VoiceDetectorCalibrating
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x1092590", Offset = "0x1091590", VA = "0x181092590", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x1091570", Offset = "0x1090570", VA = "0x181091570", Slot = "10")]
		public void VoiceDetectorCalibrate(int durationMs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1092040", Offset = "0x1091040", VA = "0x181092040")]
		internal LocalVoiceAudio(VoiceClient voiceClient, IEncoderDataFlow<T> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x10925C0", Offset = "0x10915C0", VA = "0x1810925C0")]
		protected void initBuiltinProcessors()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class LocalVoiceAudioDummy : LocalVoice, ILocalVoiceAudio
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private AudioUtil.VoiceDetectorDummy voiceDetector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private AudioUtil.LevelMetterDummy levelMeter;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public AudioUtil.IVoiceDetector VoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0x6DF120", Offset = "0x6DE120", VA = "0x1806DF120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public AudioUtil.ILevelMeter LevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x3BAF60", Offset = "0x3B9F60", VA = "0x1803BAF60", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool VoiceDetectorCalibrating
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x367E20", Offset = "0x366E20", VA = "0x180367E20", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20", Slot = "10")]
		public void VoiceDetectorCalibrate(int durationMs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x1980D20", Offset = "0x197FD20", VA = "0x181980D20")]
		public LocalVoiceAudioDummy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public class LocalVoiceAudioFloat : LocalVoiceAudio<float>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x1980E00", Offset = "0x197FE00", VA = "0x181980E00")]
		internal LocalVoiceAudioFloat(VoiceClient voiceClient, IEncoderDataFlow<float> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	public class LocalVoiceAudioShort : LocalVoiceAudio<short>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x1980FA0", Offset = "0x197FFA0", VA = "0x181980FA0")]
		internal LocalVoiceAudioShort(VoiceClient voiceClient, IEncoderDataFlow<short> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	internal enum EventSubcode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		VoiceInfo = 1,
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		VoiceRemove,
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		Frame
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	internal enum EventParam : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		VoiceId = 1,
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		SamplingRate = 2,
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		Channels = 3,
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		FrameDurationUs = 4,
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		Bitrate = 5,
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		UserData = 10,
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		EventNumber = 11,
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		Codec = 12
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public interface ILogger
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LogError(string fmt, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LogWarning(string fmt, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LogInfo(string fmt, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LogDebug(string fmt, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	internal interface IVoiceFrontend : ILogger
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int AssignChannel(VoiceInfo v);

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool IsChannelJoined(int channelId);

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId);

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId);

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice);

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		string ChannelIdStr(int channelId);

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(Slot = "6")]
		string PlayerIdStr(int playerId);

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void SetDebugEchoMode(LocalVoice v);
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class VoiceClient : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000106")]
		public delegate void RemoteVoiceInfoDelegate(int channelId, int playerId, byte voiceId, VoiceInfo voiceInfo, ref RemoteVoiceOptions options);

		[Cpp2IlInjected.Token(Token = "0x2000107")]
		[CompilerGenerated]
		private sealed class <get_RemoteVoiceInfos>d__39 : IEnumerable<RemoteVoiceInfo>, IEnumerable, IEnumerator<RemoteVoiceInfo>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			private RemoteVoiceInfo <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004AA")]
			public VoiceClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004AB")]
			private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004AC")]
			private KeyValuePair<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> <channelVoices>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004AD")]
			private Dictionary<int, Dictionary<byte, RemoteVoice>>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004AE")]
			private KeyValuePair<int, Dictionary<byte, RemoteVoice>> <playerVoices>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40004AF")]
			private Dictionary<byte, RemoteVoice>.Enumerator <>7__wrap5;

			[Cpp2IlInjected.Token(Token = "0x17000107")]
			RemoteVoiceInfo IEnumerator<RemoteVoiceInfo>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005A8")]
				[Cpp2IlInjected.Address(RVA = "0x361AC0", Offset = "0x360AC0", VA = "0x180361AC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000108")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005AA")]
				[Cpp2IlInjected.Address(RVA = "0x361AC0", Offset = "0x360AC0", VA = "0x180361AC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x83A3D0", Offset = "0x8393D0", VA = "0x18083A3D0")]
			[DebuggerHidden]
			public <get_RemoteVoiceInfos>d__39(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0x14E5EA0", Offset = "0x14E4EA0", VA = "0x1814E5EA0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0x14E5970", Offset = "0x14E4970", VA = "0x1814E5970", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x14E6010", Offset = "0x14E5010", VA = "0x1814E6010")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x14E6050", Offset = "0x14E5050", VA = "0x1814E6050")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x14E6090", Offset = "0x14E5090", VA = "0x1814E6090")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x14E5E50", Offset = "0x14E4E50", VA = "0x1814E5E50", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x14E5DB0", Offset = "0x14E4DB0", VA = "0x1814E5DB0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<RemoteVoiceInfo> IEnumerable<RemoteVoiceInfo>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x14E5DB0", Offset = "0x14E4DB0", VA = "0x1814E5DB0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000108")]
		[CompilerGenerated]
		private sealed class <get_RemoteVoiceLocalUserObjects>d__41 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004B0")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			public VoiceClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			private Dictionary<int, Dictionary<byte, RemoteVoice>>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			private Dictionary<byte, RemoteVoice>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.Token(Token = "0x17000109")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005B3")]
				[Cpp2IlInjected.Address(RVA = "0x361AC0", Offset = "0x360AC0", VA = "0x180361AC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700010A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005B5")]
				[Cpp2IlInjected.Address(RVA = "0x361AC0", Offset = "0x360AC0", VA = "0x180361AC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x83A3D0", Offset = "0x8393D0", VA = "0x18083A3D0")]
			[DebuggerHidden]
			public <get_RemoteVoiceLocalUserObjects>d__41(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x14E6530", Offset = "0x14E5530", VA = "0x1814E6530", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x14E60E0", Offset = "0x14E50E0", VA = "0x1814E60E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x14E66A0", Offset = "0x14E56A0", VA = "0x1814E66A0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x14E66E0", Offset = "0x14E56E0", VA = "0x1814E66E0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0x14E6720", Offset = "0x14E5720", VA = "0x1814E6720")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x14E64E0", Offset = "0x14E54E0", VA = "0x1814E64E0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x14E6440", Offset = "0x14E5440", VA = "0x1814E6440", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<object> IEnumerable<object>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x14E6440", Offset = "0x14E5440", VA = "0x1814E6440", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		internal IVoiceFrontend frontend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private int prevRtt;

		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public const int ChannelAuto = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private byte globalGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private byte voiceIdCnt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private Dictionary<byte, LocalVoice> localVoices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private Dictionary<int, List<LocalVoice>> localVoicesPerChannel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> remoteVoices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private System.Random rnd;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int FramesLost
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x427840", Offset = "0x426840", VA = "0x180427840")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x427980", Offset = "0x426980", VA = "0x180427980")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int FramesReceived
		{
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x4C85D0", Offset = "0x4C75D0", VA = "0x1804C85D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x5A9260", Offset = "0x5A8260", VA = "0x1805A9260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public int FramesSent
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x14E91A0", Offset = "0x14E81A0", VA = "0x1814E91A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public int FramesSentBytes
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x14E9000", Offset = "0x14E8000", VA = "0x1814E9000")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int RoundTripTime
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x540EC0", Offset = "0x53FEC0", VA = "0x180540EC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x540EB0", Offset = "0x53FEB0", VA = "0x180540EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public int RoundTripTimeVariance
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x5E3460", Offset = "0x5E2460", VA = "0x1805E3460")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x5E3450", Offset = "0x5E2450", VA = "0x1805E3450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool SuppressInfoDuplicateWarning
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x392730", Offset = "0x391730", VA = "0x180392730")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x392720", Offset = "0x391720", VA = "0x180392720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public RemoteVoiceInfoDelegate OnRemoteVoiceInfoAction
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x364F90", Offset = "0x363F90", VA = "0x180364F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x390570", Offset = "0x38F570", VA = "0x180390570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public int DebugLostPercent
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x3903A0", Offset = "0x38F3A0", VA = "0x1803903A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x3903C0", Offset = "0x38F3C0", VA = "0x1803903C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public IEnumerable<LocalVoice> LocalVoices
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x14E9340", Offset = "0x14E8340", VA = "0x1814E9340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public IEnumerable<RemoteVoiceInfo> RemoteVoiceInfos
		{
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x14E93E0", Offset = "0x14E83E0", VA = "0x1814E93E0")]
			[IteratorStateMachine(typeof(<get_RemoteVoiceInfos>d__39))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public IEnumerable<object> RemoteVoiceLocalUserObjects
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x14E9450", Offset = "0x14E8450", VA = "0x1814E9450")]
			[IteratorStateMachine(typeof(<get_RemoteVoiceLocalUserObjects>d__41))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		internal byte GlobalGroup
		{
			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x369780", Offset = "0x368780", VA = "0x180369780")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x14EBC20", Offset = "0x14EAC20", VA = "0x1814EBC20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x14E70B0", Offset = "0x14E60B0", VA = "0x1814E70B0")]
		public IEnumerable<LocalVoice> LocalVoicesInChannel(int channelId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x14E74F0", Offset = "0x14E64F0", VA = "0x1814E74F0")]
		internal VoiceClient(IVoiceFrontend frontend)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x14E7360", Offset = "0x14E6360", VA = "0x1814E7360")]
		public void Service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x14E8AA0", Offset = "0x14E7AA0", VA = "0x1814E8AA0")]
		private LocalVoice createLocalVoice(VoiceInfo voiceInfo, int channelId, Func<byte, int, LocalVoice> voiceFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x14E6A30", Offset = "0x14E5A30", VA = "0x1814E6A30")]
		public LocalVoice CreateLocalVoice(VoiceInfo voiceInfo, int channelId = -1, [Optional] IEncoder encoder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x10E8650", Offset = "0x10E7650", VA = "0x1810E8650")]
		public LocalVoiceFramed<T> CreateLocalVoiceFramed<T>(VoiceInfo voiceInfo, int frameSize, int channelId = -1, [Optional] IEncoderDataFlow<T> encoder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x10E81D0", Offset = "0x10E71D0", VA = "0x1810E81D0")]
		public LocalVoiceAudio<T> CreateLocalVoiceAudio<T>(VoiceInfo voiceInfo, int channelId = -1, [Optional] IEncoderDataFlow<T> encoder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x14E8DC0", Offset = "0x14E7DC0", VA = "0x1814E8DC0")]
		private byte getNewVoiceId()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x14E75D0", Offset = "0x14E65D0", VA = "0x1814E75D0")]
		private void addVoice(byte newId, int channelId, LocalVoice v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x14E7180", Offset = "0x14E6180", VA = "0x1814E7180")]
		public void RemoveLocalVoice(LocalVoice voice)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x14EBA00", Offset = "0x14EAA00", VA = "0x1814EBA00")]
		internal void sendVoicesInfo(int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x14EB940", Offset = "0x14EA940", VA = "0x1814EB940")]
		internal void sendChannelVoicesInfo(int channelId, int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x14E9D60", Offset = "0x14E8D60", VA = "0x1814E9D60")]
		internal void onVoiceEvent(object content0, int channelId, int playerId, int localPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x14E79A0", Offset = "0x14E69A0", VA = "0x1814E79A0")]
		internal object[] buildVoicesInfo(IEnumerable<LocalVoice> voicesToSend, bool logInfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x14E7770", Offset = "0x14E6770", VA = "0x1814E7770")]
		internal object[] buildVoiceRemoveMessage(LocalVoice v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x14E8630", Offset = "0x14E7630", VA = "0x1814E8630")]
		internal void clearRemoteVoices()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x14E82B0", Offset = "0x14E72B0", VA = "0x1814E82B0")]
		internal void clearRemoteVoicesInChannel(int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x14EA1A0", Offset = "0x14E91A0", VA = "0x1814EA1A0")]
		private void onVoiceInfo(int channelId, int playerId, object payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x14EAB20", Offset = "0x14E9B20", VA = "0x1814EAB20")]
		private void onVoiceRemove(int channelId, int playerId, object payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x14E94C0", Offset = "0x14E84C0", VA = "0x1814E94C0")]
		private void onFrame(int channelId, int playerId, byte voiceId, byte evNumber, byte[] receivedBytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x14EB7D0", Offset = "0x14EA7D0", VA = "0x1814EB7D0")]
		internal bool removePlayerVoices(int playerId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x14EB5B0", Offset = "0x14EA5B0", VA = "0x1814EB5B0")]
		internal bool removePlayerVoices(int channelId, int playerId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x14E8070", Offset = "0x14E7070", VA = "0x1814E8070")]
		internal string channelStr(int channelId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x14EB370", Offset = "0x14EA370", VA = "0x1814EB370")]
		internal string playerStr(int playerId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x14E6B40", Offset = "0x14E5B40", VA = "0x1814E6B40", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public interface IEncoder : IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public interface IEncoderDataFlow<T> : IEncoder, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public interface IEncoderDataFlowDirect<T> : IEncoderDataFlow<T>, IEncoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ArraySegment<byte> EncodeAndGetOutput(T[] buf);
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public interface IEncoderNativeImageDirect : IEncoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ArraySegment<byte>> EncodeAndGetOutput(IntPtr[] buf, int width, int height, int[] stride, ImageFormat imageFormat, Rotation rotation, Flip flip);
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public interface IEncoderQueued : IEncoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ArraySegment<byte>> GetOutput();
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public interface IDecoder : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Open(VoiceInfo info);
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public interface IDecoderDirect : IDecoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		byte[] DecodeToByte(byte[] buf);

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float[] DecodeToFloat(byte[] buf);

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(Slot = "2")]
		short[] DecodeToShort(byte[] buf);
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public interface IDecoderQueued : IDecoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Decode(byte[] buf);
	}
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	public delegate void OnImageOutputNative(IntPtr buf, int width, int height, int stride);
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	public interface IDecoderQueuedOutputImageNative : IDecoderQueued, IDecoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000072")]
		ImageFormat OutputImageFormat
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		Flip OutputImageFlip
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		Func<int, int, IntPtr> OutputImageBufferGetter
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		OnImageOutputNative OnOutputImage
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	internal class UnsupportedSampleTypeException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x14E69B0", Offset = "0x14E59B0", VA = "0x1814E69B0")]
		public UnsupportedSampleTypeException(Type t)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	internal class UnsupportedCodecException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x14E6770", Offset = "0x14E5770", VA = "0x1814E6770")]
		public UnsupportedCodecException(Codec codec, LocalVoice voice)
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public enum Codec
	{
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		AudioOpus = 11
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public enum ImageFormat
	{
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		I420,
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		YV12,
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		Android420,
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		RGBA,
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		ABGR,
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		BGRA,
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		ARGB
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public enum Rotation
	{
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		Rotate0 = 0,
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		Rotate90 = 90,
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		Rotate180 = 180,
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		Rotate270 = 270
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public enum Flip
	{
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		Vertical,
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		Horizontal
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class ImageBufferInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public int Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x392A60", Offset = "0x391A60", VA = "0x180392A60")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x392750", Offset = "0x391750", VA = "0x180392750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public int Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x3922C0", Offset = "0x3912C0", VA = "0x1803922C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x392470", Offset = "0x391470", VA = "0x180392470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int[] Stride
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x361AC0", Offset = "0x360AC0", VA = "0x180361AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x390550", Offset = "0x38F550", VA = "0x180390550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public ImageFormat Format
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x540EC0", Offset = "0x53FEC0", VA = "0x180540EC0")]
			[CompilerGenerated]
			get
			{
				return default(ImageFormat);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x540EB0", Offset = "0x53FEB0", VA = "0x180540EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Rotation Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x5E3460", Offset = "0x5E2460", VA = "0x1805E3460")]
			[CompilerGenerated]
			get
			{
				return default(Rotation);
			}
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x5E3450", Offset = "0x5E2450", VA = "0x1805E3450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public Flip Flip
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x42B660", Offset = "0x42A660", VA = "0x18042B660")]
			[CompilerGenerated]
			get
			{
				return default(Flip);
			}
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x42B680", Offset = "0x42A680", VA = "0x18042B680")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x1976B00", Offset = "0x1975B00", VA = "0x181976B00")]
		public ImageBufferInfo(int width, int height, int[] stride, ImageFormat format)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class ImageBufferNative
	{
		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public ImageBufferInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x38FC50", Offset = "0x38EC50", VA = "0x18038FC50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x38BFA0", Offset = "0x38AFA0", VA = "0x18038BFA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public IntPtr[] Planes
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x361AC0", Offset = "0x360AC0", VA = "0x180361AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x390550", Offset = "0x38F550", VA = "0x180390550")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x4990E0", Offset = "0x4980E0", VA = "0x1804990E0")]
		public ImageBufferNative(ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20", Slot = "4")]
		public virtual void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20", Slot = "5")]
		public virtual void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class ImageBufferNativeAlloc : ImageBufferNative, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private ImageBufferNativePool<ImageBufferNativeAlloc> pool;

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x1976C40", Offset = "0x1975C40", VA = "0x181976C40")]
		public ImageBufferNativeAlloc(ImageBufferNativePool<ImageBufferNativeAlloc> pool, ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x1976C20", Offset = "0x1975C20", VA = "0x181976C20", Slot = "4")]
		public override void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x1976B50", Offset = "0x1975B50", VA = "0x181976B50", Slot = "5")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public class ImageBufferNativeGCHandleSinglePlane : ImageBufferNative, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private GCHandle planeHandle;

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x1976E30", Offset = "0x1975E30", VA = "0x181976E30")]
		public ImageBufferNativeGCHandleSinglePlane(ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool, ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x1976D80", Offset = "0x1975D80", VA = "0x181976D80")]
		public void PinPlane(byte[] plane)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x1976DF0", Offset = "0x1975DF0", VA = "0x181976DF0", Slot = "4")]
		public override void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20", Slot = "5")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	internal static class VoiceCodec
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x14EBE10", Offset = "0x14EAE10", VA = "0x1814EBE10")]
		internal static IEncoder CreateDefaultEncoder(VoiceInfo info, LocalVoice localVoice)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x14EBDB0", Offset = "0x14EADB0", VA = "0x1814EBDB0")]
		internal static IDecoder CreateDefaultDecoder(int channelId, int playerId, byte voiceId, VoiceInfo info)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public enum ProcessorQueue
	{
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		RawSignalReading = 0,
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		GainAdjustment = 100,
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		GainAdjustedSignalReading = 200,
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		Resampling = 300,
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		SignalProcessing = 400,
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		ProcessedSignalReading = 500
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class Framer<T>
	{
		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[CompilerGenerated]
		private sealed class <Frame>d__5 : IEnumerable<T[]>, IEnumerable, IEnumerator<T[]>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C2")]
			private T[] <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			public Framer<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			private T[] buf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			public T[] <>3__buf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C7")]
			private int <s>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C8")]
			private int <bufPos>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700010B")]
			private T[] System.Collections.Generic.IEnumerator<T[]>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005C1")]
				[Cpp2IlInjected.Address(RVA = "0x361AC0", Offset = "0x360AC0", VA = "0x180361AC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700010C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005C3")]
				[Cpp2IlInjected.Address(RVA = "0x361AC0", Offset = "0x360AC0", VA = "0x180361AC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0x107F250", Offset = "0x107E250", VA = "0x18107F250")]
			[DebuggerHidden]
			public <Frame>d__5(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x361B20", Offset = "0x360B20", VA = "0x180361B20", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x109E0D0", Offset = "0x109D0D0", VA = "0x18109E0D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x109E3C0", Offset = "0x109D3C0", VA = "0x18109E3C0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x109E240", Offset = "0x109D240", VA = "0x18109E240", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<T[]> System.Collections.Generic.IEnumerable<T[]>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x109E2F0", Offset = "0x109D2F0", VA = "0x18109E2F0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private T[] frame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private int sizeofT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private int framePos;

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x108D0E0", Offset = "0x108C0E0", VA = "0x18108D0E0")]
		public Framer(int frameSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x108D010", Offset = "0x108C010", VA = "0x18108D010")]
		public int Count(int bufLen)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x108D040", Offset = "0x108C040", VA = "0x18108D040")]
		[IteratorStateMachine(typeof(Framer<>.<Frame>d__5))]
		public IEnumerable<T[]> Frame(T[] buf)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class LocalVoiceFramed : LocalVoice
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public int FrameSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x1302100", Offset = "0x1301100", VA = "0x181302100")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x13025C0", Offset = "0x13015C0", VA = "0x1813025C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x1981260", Offset = "0x1980260", VA = "0x181981260")]
		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public class LocalVoiceFramed<T> : LocalVoiceFramed
	{
		[Cpp2IlInjected.Token(Token = "0x200010D")]
		public interface IProcessor : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			T[] Process(T[] buf);
		}

		[Cpp2IlInjected.Token(Token = "0x200010E")]
		private struct ProcessorEntry : IComparable<ProcessorEntry>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C9")]
			public IProcessor processor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CA")]
			public int priority;

			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0x15E7D0", Offset = "0x15DBD0", VA = "0x18015E7D0", Slot = "4")]
			public int CompareTo(ProcessorEntry other)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private Framer<T> framer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private List<ProcessorEntry> processors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private bool dataEncodeThreadStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private Queue<T[]> pushDataQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private AutoResetEvent pushDataQueueReady;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private PrimitiveArrayPool<T> pushDataBufferPool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private int framesSkipped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private bool exitThread;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public PrimitiveArrayPool<T> PushDataBufferPool
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x39A6E0", Offset = "0x3996E0", VA = "0x18039A6E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool PushDataAsyncReady
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x1096E30", Offset = "0x1095E30", VA = "0x181096E30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x1097130", Offset = "0x1096130", VA = "0x181097130")]
		internal T[] processFrame(T[] buf)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x1092A90", Offset = "0x1091A90", VA = "0x181092A90")]
		public void AddProcessor(ProcessorQueue queue, params IProcessor[] newProcessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x1092F70", Offset = "0x1091F70", VA = "0x181092F70")]
		public void ClearProcessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x1096650", Offset = "0x1095650", VA = "0x181096650")]
		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x1094F00", Offset = "0x1093F00", VA = "0x181094F00")]
		public void PushDataAsync(T[] buf)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x10941A0", Offset = "0x10931A0", VA = "0x1810941A0")]
		private void PushDataAsyncThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x1095B70", Offset = "0x1094B70", VA = "0x181095B70")]
		public void PushData(T[] buf)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x1093470", Offset = "0x1092470", VA = "0x181093470", Slot = "6")]
		public override void Dispose()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 40)]
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public struct VoiceInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public Codec Codec
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x125460", Offset = "0x124860", VA = "0x180125460")]
			[CompilerGenerated]
			get
			{
				return default(Codec);
			}
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x125450", Offset = "0x124850", VA = "0x180125450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public int SamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x125440", Offset = "0x124840", VA = "0x180125440")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x125470", Offset = "0x124870", VA = "0x180125470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public int SourceSamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x134730", Offset = "0x133B30", VA = "0x180134730")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x18D670", Offset = "0x18CA70", VA = "0x18018D670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int Channels
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x1EC360", Offset = "0x1EB760", VA = "0x1801EC360")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x1EC3F0", Offset = "0x1EB7F0", VA = "0x1801EC3F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public int FrameDurationUs
		{
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x128EC0", Offset = "0x1282C0", VA = "0x180128EC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x1EC400", Offset = "0x1EB800", VA = "0x1801EC400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public int Bitrate
		{
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x143240", Offset = "0x142640", VA = "0x180143240")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x1EC3E0", Offset = "0x1EB7E0", VA = "0x1801EC3E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public object UserData
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x1473B0", Offset = "0x1467B0", VA = "0x1801473B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x1473C0", Offset = "0x1467C0", VA = "0x1801473C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public int FrameDurationSamples
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x1EC370", Offset = "0x1EB770", VA = "0x1801EC370")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public int FrameSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x1EC3A0", Offset = "0x1EB7A0", VA = "0x1801EC3A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public int Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x16EBB0", Offset = "0x16DFB0", VA = "0x18016EBB0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x1EC420", Offset = "0x1EB820", VA = "0x1801EC420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public int Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x1EC3D0", Offset = "0x1EB7D0", VA = "0x1801EC3D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x1EC410", Offset = "0x1EB810", VA = "0x1801EC410")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x14EBF00", Offset = "0x14EAF00", VA = "0x1814EBF00")]
		public static VoiceInfo CreateAudioOpus(SamplingRate samplingRate, int sourceSamplingRate, int channels, OpusCodec.FrameDuration frameDurationUs, int bitrate, [Optional] object userdata)
		{
			return default(VoiceInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x1EC350", Offset = "0x1EB750", VA = "0x1801EC350", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x14EBF60", Offset = "0x14EAF60", VA = "0x1814EBF60")]
		internal static VoiceInfo CreateFromEventPayload(Dictionary<byte, object> h)
		{
			return default(VoiceInfo);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public class RemoteVoiceInfo
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public VoiceInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x42E890", Offset = "0x42D890", VA = "0x18042E890")]
			[CompilerGenerated]
			get
			{
				return default(VoiceInfo);
			}
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x14DE430", Offset = "0x14DD430", VA = "0x1814DE430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public int ChannelId
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x3903A0", Offset = "0x38F3A0", VA = "0x1803903A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x3903C0", Offset = "0x38F3C0", VA = "0x1803903C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int PlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x408AE0", Offset = "0x407AE0", VA = "0x180408AE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x6147C0", Offset = "0x6137C0", VA = "0x1806147C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public byte VoiceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x369780", Offset = "0x368780", VA = "0x180369780")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x7DF8A0", Offset = "0x7DE8A0", VA = "0x1807DF8A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public object LocalUserObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x3C7B50", Offset = "0x3C6B50", VA = "0x1803C7B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x3C7E10", Offset = "0x3C6E10", VA = "0x1803C7E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x14DE3C0", Offset = "0x14DD3C0", VA = "0x1814DE3C0")]
		internal RemoteVoiceInfo(int channelId, int playerId, byte voiceId, VoiceInfo info, object localUserObject)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public abstract class BufferReaderPushAdapterBase<T> : IServiceable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		protected IDataReader<T> reader;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void Service(LocalVoice localVoice);

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x1088C10", Offset = "0x1087C10", VA = "0x181088C10")]
		public BufferReaderPushAdapterBase(IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x108AC40", Offset = "0x1089C40", VA = "0x18108AC40")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class BufferReaderPushAdapter<T> : BufferReaderPushAdapterBase<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		protected T[] buffer;

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x108AE40", Offset = "0x1089E40", VA = "0x18108AE40")]
		public BufferReaderPushAdapter(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x108AC90", Offset = "0x1089C90", VA = "0x18108AC90", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class BufferReaderPushAdapterAsyncPool<T> : BufferReaderPushAdapterBase<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x108AB70", Offset = "0x1089B70", VA = "0x18108AB70")]
		public BufferReaderPushAdapterAsyncPool(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x108A960", Offset = "0x1089960", VA = "0x18108A960", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public class BufferReaderPushAdapterAsyncPoolCopy<T> : BufferReaderPushAdapterBase<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		protected T[] buffer;

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x108A860", Offset = "0x1089860", VA = "0x18108A860")]
		public BufferReaderPushAdapterAsyncPoolCopy(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x108A690", Offset = "0x1089690", VA = "0x18108A690", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public class BufferReaderPushAdapterAsyncPoolFloatToShort : BufferReaderPushAdapterBase<float>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private float[] buffer;

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x19749B0", Offset = "0x19739B0", VA = "0x1819749B0")]
		public BufferReaderPushAdapterAsyncPoolFloatToShort(LocalVoice localVoice, IDataReader<float> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x1974730", Offset = "0x1973730", VA = "0x181974730", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class LocalVoiceVideo : LocalVoice
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private bool imageEncodeThreadStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private Queue<ImageBufferNative> pushImageQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private AutoResetEvent pushImageQueueReady;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private bool exitThread;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public int PushImageQueueCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x1982260", Offset = "0x1981260", VA = "0x181982260")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x1982130", Offset = "0x1981130", VA = "0x181982130")]
		internal LocalVoiceVideo(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x1981A30", Offset = "0x1980A30", VA = "0x181981A30")]
		public void PushImageAsync(ImageBufferNative buf)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x1981470", Offset = "0x1980470", VA = "0x181981470")]
		private void PushImageAsyncThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x1981CE0", Offset = "0x1980CE0", VA = "0x181981CE0")]
		public void PushImage(IntPtr[] buf, int width, int height, int[] stride, ImageFormat imageFormat, Rotation rotation = Rotation.Rotate0, Flip flip = Flip.None)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x19812D0", Offset = "0x19802D0", VA = "0x1819812D0", Slot = "6")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	internal class VoiceEventCode
	{
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public const byte Code0 = 201;

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x14EBEC0", Offset = "0x14EAEC0", VA = "0x1814EBEC0")]
		public static byte GetCode(int channelID)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x14EBED0", Offset = "0x14EAED0", VA = "0x1814EBED0")]
		public static bool TryGetChannelID(byte evCode, int maxChannels, out byte channelID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
		public VoiceEventCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public class LoadBalancingFrontend : LoadBalancingClient, IVoiceFrontend, ILogger, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		protected VoiceClient voiceClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private object sendLock;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public VoiceClient VoiceClient
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x4678C0", Offset = "0x4668C0", VA = "0x1804678C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public new Action<EventData> OnEventAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x466EF0", Offset = "0x465EF0", VA = "0x180466EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x7CFE00", Offset = "0x7CEE00", VA = "0x1807CFE00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public new Action<ClientState> OnStateChangeAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x4672A0", Offset = "0x4662A0", VA = "0x1804672A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x5667B0", Offset = "0x5657B0", VA = "0x1805667B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public byte GlobalAudioGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x197E0C0", Offset = "0x197D0C0", VA = "0x18197E0C0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x197E630", Offset = "0x197D630", VA = "0x18197E630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x197D170", Offset = "0x197C170", VA = "0x18197D170", Slot = "27")]
		public void LogError(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x197D1F0", Offset = "0x197C1F0", VA = "0x18197D1F0", Slot = "28")]
		public void LogWarning(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x197D1B0", Offset = "0x197C1B0", VA = "0x18197D1B0", Slot = "29")]
		public void LogInfo(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x197D130", Offset = "0x197C130", VA = "0x18197D130", Slot = "30")]
		public void LogDebug(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x197D000", Offset = "0x197C000", VA = "0x18197D000", Slot = "19")]
		public int AssignChannel(VoiceInfo v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x197D120", Offset = "0x197C120", VA = "0x18197D120", Slot = "20")]
		public bool IsChannelJoined(int channelId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x197DD30", Offset = "0x197CD30", VA = "0x18197DD30", Slot = "26")]
		public void SetDebugEchoMode(LocalVoice v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x197DE30", Offset = "0x197CE30", VA = "0x18197DE30")]
		public LoadBalancingFrontend(ConnectionProtocol connectionProtocol = ConnectionProtocol.Udp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x197DCF0", Offset = "0x197CCF0", VA = "0x18197DCF0")]
		public new void Service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x197D0C0", Offset = "0x197C0C0", VA = "0x18197D0C0", Slot = "32")]
		public virtual bool ChangeAudioGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x197D960", Offset = "0x197C960", VA = "0x18197D960", Slot = "21")]
		public void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x197D230", Offset = "0x197C230", VA = "0x18197D230")]
		public void SendDebugEchoVoicesInfo(int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x197D720", Offset = "0x197C720", VA = "0x18197D720", Slot = "22")]
		public void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x197D390", Offset = "0x197C390", VA = "0x18197D390", Slot = "23")]
		public void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x3DDDE0", Offset = "0x3DCDE0", VA = "0x1803DDDE0", Slot = "24")]
		public string ChannelIdStr(int channelId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x3DDDE0", Offset = "0x3DCDE0", VA = "0x1803DDDE0", Slot = "25")]
		public string PlayerIdStr(int playerId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x197E0F0", Offset = "0x197D0F0", VA = "0x18197E0F0")]
		private void onEventActionVoiceClient(EventData ev)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x197E4C0", Offset = "0x197D4C0", VA = "0x18197E4C0")]
		private void onStateChangeVoiceClient(ClientState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x197E3F0", Offset = "0x197D3F0", VA = "0x18197E3F0")]
		private void onPlayerLeave(int playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x197D0F0", Offset = "0x197C0F0", VA = "0x18197D0F0", Slot = "31")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class AudioInEnumerator : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private const string lib_name = "AudioIn";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private IntPtr handle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public readonly bool IsSupported;

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x1972B20", Offset = "0x1971B20", VA = "0x181972B20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x1972520", Offset = "0x1971520", VA = "0x181972520")]
		private static extern IntPtr Photon_Audio_In_CreateMicEnumerator();

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x19725B0", Offset = "0x19715B0", VA = "0x1819725B0")]
		private static extern void Photon_Audio_In_DestroyMicEnumerator(IntPtr handle);

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x1972650", Offset = "0x1971650", VA = "0x181972650")]
		private static extern int Photon_Audio_In_MicEnumerator_Count(IntPtr handle);

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x19727A0", Offset = "0x19717A0", VA = "0x1819727A0")]
		private static extern IntPtr Photon_Audio_In_MicEnumerator_NameAtIndex(IntPtr handle, int idx);

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x19726F0", Offset = "0x19716F0", VA = "0x1819726F0")]
		private static extern int Photon_Audio_In_MicEnumerator_IDAtIndex(IntPtr handle, int idx);

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x19729B0", Offset = "0x19719B0", VA = "0x1819729B0")]
		public AudioInEnumerator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x1972850", Offset = "0x1971850", VA = "0x181972850")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x1972430", Offset = "0x1971430", VA = "0x181972430")]
		public string NameAtIndex(int idx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x1972370", Offset = "0x1971370", VA = "0x181972370")]
		public int IDAtIndex(int idx)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x1972420", Offset = "0x1971420", VA = "0x181972420")]
		public bool IDIsValid(int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x1972290", Offset = "0x1971290", VA = "0x181972290", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace ExitGames.Client.Photon.LoadBalancing
{
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public static class Extensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x1976160", Offset = "0x1975160", VA = "0x181976160")]
		public static void Merge(this IDictionary target, IDictionary addHash)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x1975EF0", Offset = "0x1974EF0", VA = "0x181975EF0")]
		public static void MergeStringKeys(this IDictionary target, IDictionary addHash)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x1976900", Offset = "0x1975900", VA = "0x181976900")]
		public static string ToStringFull(this IDictionary origin)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x1976960", Offset = "0x1975960", VA = "0x181976960")]
		public static string ToStringFull(this object[] data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x19766B0", Offset = "0x19756B0", VA = "0x1819766B0")]
		public static Hashtable StripToStringKeys(this IDictionary original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x1976450", Offset = "0x1975450", VA = "0x181976450")]
		public static void StripKeysWithNullValues(this IDictionary original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x99CD50", Offset = "0x99BD50", VA = "0x18099CD50")]
		public static bool Contains(this int[] target, int nr)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public class FriendInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000097")]
		[Obsolete]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x38FC50", Offset = "0x38EC50", VA = "0x18038FC50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x38FC50", Offset = "0x38EC50", VA = "0x18038FC50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x38BFA0", Offset = "0x38AFA0", VA = "0x18038BFA0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public bool IsOnline
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x4AD2F0", Offset = "0x4AC2F0", VA = "0x1804AD2F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x4AD2E0", Offset = "0x4AC2E0", VA = "0x1804AD2E0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public string Room
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x390560", Offset = "0x38F560", VA = "0x180390560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x3903B0", Offset = "0x38F3B0", VA = "0x1803903B0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public bool IsInRoom
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xD974C0", Offset = "0xD964C0", VA = "0x180D974C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x1976A80", Offset = "0x1975A80", VA = "0x181976A80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
		public FriendInfo()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public enum ClientState
	{
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		PeerCreated = 0,
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		Authenticating = 1,
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		Authenticated = 2,
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		JoinedLobby = 3,
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		DisconnectingFromMasterserver = 4,
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		ConnectingToGameserver = 5,
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		ConnectedToGameserver = 6,
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		Joining = 7,
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		Joined = 8,
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		Leaving = 9,
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		DisconnectingFromGameserver = 10,
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		ConnectingToMasterserver = 11,
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		Disconnecting = 12,
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		Disconnected = 13,
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		ConnectedToMasterserver = 14,
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		[Obsolete]
		ConnectedToMaster = 14,
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		ConnectingToNameServer = 15,
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		ConnectedToNameServer = 16,
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		DisconnectingFromNameServer = 17
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	internal enum JoinType
	{
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		CreateRoom,
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		JoinRoom,
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		JoinRandomRoom,
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		JoinOrCreateRoom
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public enum DisconnectCause
	{
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		DisconnectByServerUserLimit,
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		ExceptionOnConnect,
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		DisconnectByServer,
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		TimeoutDisconnect,
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		Exception,
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		InvalidAuthentication,
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		MaxCcuReached,
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		InvalidRegion,
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		OperationNotAllowedInCurrentState,
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		CustomAuthenticationFailed,
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		DisconnectByServerLogic,
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		AuthenticationTicketExpired
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public enum ServerConnection
	{
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		MasterServer,
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		GameServer,
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		NameServer
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public enum EncryptionMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		PayloadEncryption = 0,
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		DatagramEncryption = 10,
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		DatagramEncryptionRandomSequence = 11
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public static class EncryptionDataParameters
	{
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public const byte Mode = 0;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public const byte Secret1 = 1;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public const byte Secret2 = 2;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public class LoadBalancingClient : IPhotonPeerListener
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public LoadBalancingPeer loadBalancingPeer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public AuthModeOption AuthMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public EncryptionMode EncryptionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private ConnectionProtocol ExpectedProtocol;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public string NameServerHost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public string NameServerHttp;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private ClientState state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private bool inLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private bool autoJoinLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x91")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public bool EnableLobbyStatistics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private List<TypedLobbyInfo> lobbyStatistics;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		public Dictionary<string, RoomInfo> RoomInfoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		public Room CurrentRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private JoinType lastJoinType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		protected internal EnterRoomParams enterRoomParamsCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private bool didAuthenticate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private string[] friendListRequested;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private int friendListTimestamp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private bool isFetchingFriendList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private byte[] encryptionSecret;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public string AppVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x361AC0", Offset = "0x360AC0", VA = "0x180361AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x390550", Offset = "0x38F550", VA = "0x180390550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public string AppId
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x390560", Offset = "0x38F560", VA = "0x180390560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x3903B0", Offset = "0x38F3B0", VA = "0x1803903B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public AuthenticationValues AuthValues
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x365D30", Offset = "0x364D30", VA = "0x180365D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x3903D0", Offset = "0x38F3D0", VA = "0x1803903D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public ConnectionProtocol TransportProtocol
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x197CC20", Offset = "0x197BC20", VA = "0x18197CC20")]
			get
			{
				return default(ConnectionProtocol);
			}
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x197CEA0", Offset = "0x197BEA0", VA = "0x18197CEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig
		{
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x1759210", Offset = "0x1758210", VA = "0x181759210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		private string TokenForInit
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x197CC00", Offset = "0x197BC00", VA = "0x18197CC00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool IsUsingNameServer
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x5C4620", Offset = "0x5C3620", VA = "0x1805C4620")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xA90F00", Offset = "0xA8FF00", VA = "0x180A90F00")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public string NameServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x197CA30", Offset = "0x197BA30", VA = "0x18197CA30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public string CurrentServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x197C910", Offset = "0x197B910", VA = "0x18197C910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public string MasterServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x38FC60", Offset = "0x38EC60", VA = "0x18038FC60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x38E4A0", Offset = "0x38D4A0", VA = "0x18038E4A0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public string GameServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x386170", Offset = "0x385170", VA = "0x180386170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x3C7DF0", Offset = "0x3C6DF0", VA = "0x1803C7DF0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public ServerConnection Server
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x3C7B40", Offset = "0x3C6B40", VA = "0x1803C7B40")]
			[CompilerGenerated]
			get
			{
				return default(ServerConnection);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x3C7E00", Offset = "0x3C6E00", VA = "0x1803C7E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public ClientState State
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xB99640", Offset = "0xB98640", VA = "0x180B99640")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x197CE50", Offset = "0x197BE50", VA = "0x18197CE50")]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public bool IsConnected
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x197CA10", Offset = "0x197BA10", VA = "0x18197CA10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool IsConnectedAndReady
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x197C9A0", Offset = "0x197B9A0", VA = "0x18197C9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public DisconnectCause DisconnectedCause
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x518710", Offset = "0x517710", VA = "0x180518710")]
			[CompilerGenerated]
			get
			{
				return default(DisconnectCause);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x54FAC0", Offset = "0x54EAC0", VA = "0x18054FAC0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public TypedLobby CurrentLobby
		{
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x3B7280", Offset = "0x3B6280", VA = "0x1803B7280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x3B7290", Offset = "0x3B6290", VA = "0x1803B7290")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool AutoJoinLobby
		{
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x3F1990", Offset = "0x3F0990", VA = "0x1803F1990")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0xD9A8B0", Offset = "0xD998B0", VA = "0x180D9A8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public List<TypedLobbyInfo> LobbyStatistics
		{
			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x68ECF0", Offset = "0x68DCF0", VA = "0x18068ECF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x7E5910", Offset = "0x7E4910", VA = "0x1807E5910")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public Player LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x6DF120", Offset = "0x6DE120", VA = "0x1806DF120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x8C67B0", Offset = "0x8C57B0", VA = "0x1808C67B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public string NickName
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x197CBD0", Offset = "0x197BBD0", VA = "0x18197CBD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x197CE30", Offset = "0x197BE30", VA = "0x18197CE30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x197CC40", Offset = "0x197BC40", VA = "0x18197CC40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x197CF80", Offset = "0x197BF80", VA = "0x18197CF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public int PlayersOnMasterCount
		{
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x7309E0", Offset = "0x72F9E0", VA = "0x1807309E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0xA07410", Offset = "0xA06410", VA = "0x180A07410")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public int PlayersInRoomsCount
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0xC900C0", Offset = "0xC8F0C0", VA = "0x180C900C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0xC90C60", Offset = "0xC8FC60", VA = "0x180C90C60")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public int RoomsCount
		{
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x839230", Offset = "0x838230", VA = "0x180839230")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0xC90A40", Offset = "0xC8FA40", VA = "0x180C90A40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public List<FriendInfo> FriendList
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x39A6B0", Offset = "0x3996B0", VA = "0x18039A6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x398890", Offset = "0x397890", VA = "0x180398890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public int FriendListAge
		{
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x197C930", Offset = "0x197B930", VA = "0x18197C930")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		protected bool IsAuthorizeSecretAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x197C970", Offset = "0x197B970", VA = "0x18197C970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public string[] AvailableRegions
		{
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x41C320", Offset = "0x41B320", VA = "0x18041C320")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x418960", Offset = "0x417960", VA = "0x180418960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public string[] AvailableRegionsServers
		{
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x67BFF0", Offset = "0x67AFF0", VA = "0x18067BFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x67C2D0", Offset = "0x67B2D0", VA = "0x18067C2D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public string CloudRegion
		{
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x64EFF0", Offset = "0x64DFF0", VA = "0x18064EFF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x64E420", Offset = "0x64D420", VA = "0x18064E420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState> OnStateChangeAction
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x197C870", Offset = "0x197B870", VA = "0x18197C870")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x197CD90", Offset = "0x197BD90", VA = "0x18197CD90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<EventData> OnEventAction
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x197C730", Offset = "0x197B730", VA = "0x18197C730")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x197CC50", Offset = "0x197BC50", VA = "0x18197CC50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<OperationResponse> OnOpResponseAction
		{
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x197C7D0", Offset = "0x197B7D0", VA = "0x18197C7D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x197CCF0", Offset = "0x197BCF0", VA = "0x18197CCF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x197C4E0", Offset = "0x197B4E0", VA = "0x18197C4E0")]
		public LoadBalancingClient(ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x197C6E0", Offset = "0x197B6E0", VA = "0x18197C6E0")]
		public LoadBalancingClient(string masterAddress, string appId, string gameVersion, ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x1978180", Offset = "0x1977180", VA = "0x181978180")]
		private string GetNameServerAddress()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x1977A20", Offset = "0x1976A20", VA = "0x181977A20")]
		public bool Connect(string masterServerAddress, string appId, string appVersion, string nickName, AuthenticationValues authValues)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x1977970", Offset = "0x1976970", VA = "0x181977970", Slot = "8")]
		public virtual bool Connect()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x19776F0", Offset = "0x19766F0", VA = "0x1819776F0")]
		public bool ConnectToNameServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x1977820", Offset = "0x1976820", VA = "0x181977820")]
		public bool ConnectToRegionMaster(string region)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x1977E70", Offset = "0x1976E70", VA = "0x181977E70")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1977380", Offset = "0x1976380", VA = "0x181977380")]
		private bool CallAuthenticate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x197C0C0", Offset = "0x197B0C0", VA = "0x18197C0C0")]
		public void Service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1977D80", Offset = "0x1976D80", VA = "0x181977D80")]
		private void DisconnectToReconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1977650", Offset = "0x1976650", VA = "0x181977650")]
		private bool ConnectToGameServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x197A970", Offset = "0x1979970", VA = "0x18197A970")]
		public bool OpGetRegions()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x197A660", Offset = "0x1979660", VA = "0x18197A660")]
		public bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x197A9C0", Offset = "0x19799C0", VA = "0x18197A9C0")]
		public bool OpJoinLobby(TypedLobby lobby)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x11F8610", Offset = "0x11F7610", VA = "0x1811F8610")]
		public bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x197AB80", Offset = "0x1979B80", VA = "0x18197AB80")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x197ADC0", Offset = "0x1979DC0", VA = "0x18197ADC0")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x197AC30", Offset = "0x1979C30", VA = "0x18197AC30")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode, TypedLobby lobby, string sqlLobbyFilter, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x197AE70", Offset = "0x1979E70", VA = "0x18197AE70")]
		public bool OpJoinRoom(string roomName, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x197B1A0", Offset = "0x197A1A0", VA = "0x18197B1A0")]
		public bool OpReJoinRoom(string roomName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x197AA70", Offset = "0x1979A70", VA = "0x18197AA70")]
		public bool OpJoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x197A550", Offset = "0x1979550", VA = "0x18197A550")]
		public bool OpCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x197AF70", Offset = "0x1979F70", VA = "0x18197AF70")]
		public bool OpLeaveRoom()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x197B000", Offset = "0x197A000", VA = "0x18197B000")]
		public bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x197A940", Offset = "0x1979940", VA = "0x18197A940")]
		public bool OpGetGameList(TypedLobby typedLobby, string sqlLobbyFilter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x197B290", Offset = "0x197A290", VA = "0x18197B290")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x197B560", Offset = "0x197A560", VA = "0x18197B560")]
		[Obsolete]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x197B7A0", Offset = "0x197A7A0", VA = "0x18197B7A0")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x197B610", Offset = "0x197A610", VA = "0x18197B610")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x197B6B0", Offset = "0x197A6B0", VA = "0x18197B6B0")]
		[Obsolete]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x197B8E0", Offset = "0x197A8E0", VA = "0x18197B8E0")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x197B170", Offset = "0x197A170", VA = "0x18197B170", Slot = "9")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x197B0C0", Offset = "0x197A0C0", VA = "0x18197B0C0", Slot = "10")]
		[Obsolete]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x197A530", Offset = "0x1979530", VA = "0x18197A530", Slot = "11")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x197BC20", Offset = "0x197AC20", VA = "0x18197BC20")]
		private void ReadoutProperties(Hashtable gameProperties, Hashtable actorProperties, int targetActorNr)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x197BB20", Offset = "0x197AB20", VA = "0x18197BB20")]
		private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x1977440", Offset = "0x1976440", VA = "0x181977440")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x19775B0", Offset = "0x19765B0", VA = "0x1819775B0")]
		private void CleanCachedValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1977EF0", Offset = "0x1976EF0", VA = "0x181977EF0")]
		private void GameEnteredOnGameServer(OperationResponse operationResponse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x197C2F0", Offset = "0x197B2F0", VA = "0x18197C2F0")]
		private void UpdatedActorList(int[] actorsInGame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1977AE0", Offset = "0x1976AE0", VA = "0x181977AE0", Slot = "12")]
		protected internal virtual Player CreatePlayer(string actorName, int actorNumber, bool isLocal, Hashtable actorProperties)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x1977B70", Offset = "0x1976B70", VA = "0x181977B70", Slot = "13")]
		protected internal virtual Room CreateRoom(string roomName, RoomOptions opt)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x1977C60", Offset = "0x1976C60", VA = "0x181977C60", Slot = "14")]
		public virtual void DebugReturn(DebugLevel level, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1978F40", Offset = "0x1977F40", VA = "0x181978F40", Slot = "15")]
		public virtual void OnOperationResponse(OperationResponse operationResponse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x1979E20", Offset = "0x1978E20", VA = "0x181979E20", Slot = "16")]
		public virtual void OnStatusChanged(StatusCode statusCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x1978350", Offset = "0x1977350", VA = "0x181978350", Slot = "17")]
		public virtual void OnEvent(EventData photonEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x1978EE0", Offset = "0x1977EE0", VA = "0x181978EE0", Slot = "18")]
		public virtual void OnMessage(object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x197C0E0", Offset = "0x197B0E0", VA = "0x18197C0E0")]
		private void SetupEncryption(Dictionary<byte, object> encryptionData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x197BA00", Offset = "0x197AA00", VA = "0x18197BA00")]
		public bool OpWebRpc(string uriPath, object parameters, bool sendAuthCookie = false)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public class LoadBalancingPeer : PhotonPeer
	{
		[Cpp2IlInjected.Token(Token = "0x2000110")]
		private enum RoomOptionBit
		{
			[Cpp2IlInjected.Token(Token = "0x40004CE")]
			CheckUserOnJoin = 1,
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			DeleteCacheOnLeave = 2,
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			SuppressRoomEvents = 4,
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			PublishUserId = 8,
			[Cpp2IlInjected.Token(Token = "0x40004D2")]
			DeleteNullProps = 0x10,
			[Cpp2IlInjected.Token(Token = "0x40004D3")]
			BroadcastPropsChangeToAll = 0x20
		}

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		protected internal static Type PingImplementation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private readonly Dictionary<byte, object> opParameters;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x1980B90", Offset = "0x197FB90", VA = "0x181980B90")]
		public LoadBalancingPeer(ConnectionProtocol protocolType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x1980C30", Offset = "0x197FC30", VA = "0x181980C30")]
		public LoadBalancingPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x197E770", Offset = "0x197D770", VA = "0x18197E770")]
		[Conditional("UNITY")]
		private void ConfigUnitySockets()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x197F540", Offset = "0x197E540", VA = "0x18197F540", Slot = "15")]
		public virtual bool OpGetRegions(string appId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x197F610", Offset = "0x197E610", VA = "0x18197F610", Slot = "16")]
		public virtual bool OpJoinLobby([Optional] TypedLobby lobby)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x197FCD0", Offset = "0x197ECD0", VA = "0x18197FCD0", Slot = "17")]
		public virtual bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x19807B0", Offset = "0x197F7B0", VA = "0x1819807B0")]
		private void RoomOptionsToOpParameters(Dictionary<byte, object> op, RoomOptions roomOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x197F060", Offset = "0x197E060", VA = "0x18197F060", Slot = "18")]
		public virtual bool OpCreateRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x197FA20", Offset = "0x197EA20", VA = "0x18197FA20", Slot = "19")]
		public virtual bool OpJoinRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x197F760", Offset = "0x197E760", VA = "0x18197F760", Slot = "20")]
		public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x197FD80", Offset = "0x197ED80", VA = "0x18197FD80", Slot = "21")]
		public virtual bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x197F370", Offset = "0x197E370", VA = "0x18197F370", Slot = "22")]
		public virtual bool OpGetGameList(TypedLobby lobby, string queryData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x197F2A0", Offset = "0x197E2A0", VA = "0x18197F2A0", Slot = "23")]
		public virtual bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x1980140", Offset = "0x197F140", VA = "0x181980140")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable actorProperties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x19801C0", Offset = "0x197F1C0", VA = "0x1819801C0")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x1980590", Offset = "0x197F590", VA = "0x181980590")]
		protected void OpSetPropertyOfRoom(byte propCode, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x1980180", Offset = "0x197F180", VA = "0x181980180")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable gameProperties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x19803F0", Offset = "0x197F3F0", VA = "0x1819803F0")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x197ECA0", Offset = "0x197DCA0", VA = "0x18197ECA0", Slot = "24")]
		public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x197E9E0", Offset = "0x197D9E0", VA = "0x18197E9E0", Slot = "25")]
		public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x197EF30", Offset = "0x197DF30", VA = "0x18197EF30", Slot = "26")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x197FEB0", Offset = "0x197EEB0", VA = "0x18197FEB0", Slot = "27")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x1980650", Offset = "0x197F650", VA = "0x181980650", Slot = "28")]
		public virtual bool OpSettings(bool receiveLobbyStats)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public class OpJoinRandomRoomParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public Hashtable ExpectedCustomRoomProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public byte ExpectedMaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public MatchmakingMode MatchingType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public TypedLobby TypedLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public string SqlLobbyFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public string[] ExpectedUsers;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
		public OpJoinRandomRoomParams()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public class EnterRoomParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public string RoomName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public RoomOptions RoomOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public TypedLobby Lobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public Hashtable PlayerProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public bool OnGameServer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public bool CreateIfNotExists;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public bool RejoinOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public string[] ExpectedUsers;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x6AAEE0", Offset = "0x6A9EE0", VA = "0x1806AAEE0")]
		public EnterRoomParams()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public class ErrorCode
	{
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public const int Ok = 0;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public const int OperationNotAllowedInCurrentState = -3;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		[Obsolete]
		public const int InvalidOperationCode = -2;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public const int InvalidOperation = -2;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public const int InternalServerError = -1;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public const int InvalidAuthentication = 32767;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public const int GameIdAlreadyExists = 32766;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public const int GameFull = 32765;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public const int GameClosed = 32764;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		[Obsolete]
		public const int AlreadyMatched = 32763;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public const int ServerFull = 32762;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public const int UserBlocked = 32761;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public const int NoRandomMatchFound = 32760;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public const int GameDoesNotExist = 32758;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public const int MaxCcuReached = 32757;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public const int InvalidRegion = 32756;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public const int CustomAuthenticationFailed = 32755;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public const int AuthenticationTicketExpired = 32753;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public const int PluginReportedError = 32752;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public const int PluginMismatch = 32751;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public const int JoinFailedPeerAlreadyJoined = 32750;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public const int JoinFailedFoundInactiveJoiner = 32749;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public const int JoinFailedWithRejoinerNotFound = 32748;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public const int JoinFailedFoundExcludedUserId = 32747;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public const int JoinFailedFoundActiveJoiner = 32746;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public const int HttpLimitReached = 32745;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public const int ExternalHttpCallFailed = 32744;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public const int SlotError = 32742;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public const int InvalidEncryptionParameters = 32741;

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
		public ErrorCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public class ActorProperties
	{
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public const byte PlayerName = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public const byte IsInactive = 254;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public const byte UserId = 253;

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
		public ActorProperties()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public class GamePropertyKey
	{
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public const byte MaxPlayers = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public const byte IsVisible = 254;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public const byte IsOpen = 253;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public const byte PlayerCount = 252;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public const byte Removed = 251;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public const byte PropsListedInLobby = 250;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public const byte CleanupCacheOnLeave = 249;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public const byte MasterClientId = 248;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public const byte ExpectedUsers = 247;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
		public GamePropertyKey()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public class EventCode
	{
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public const byte GameList = 230;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public const byte GameListUpdate = 229;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public const byte QueueState = 228;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public const byte Match = 227;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public const byte AppStats = 226;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public const byte LobbyStats = 224;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[Obsolete]
		public const byte AzureNodeInfo = 210;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public const byte Join = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public const byte Leave = 254;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public const byte PropertiesChanged = 253;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[Obsolete]
		public const byte SetProperties = 253;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public const byte ErrorInfo = 251;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public const byte CacheSliceChanged = 250;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public const byte AuthEvent = 223;

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
		public EventCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public class ParameterCode
	{
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public const byte SuppressRoomEvents = 237;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public const byte EmptyRoomTTL = 236;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public const byte PlayerTTL = 235;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public const byte EventForward = 234;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[Obsolete]
		public const byte IsComingBack = 233;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public const byte IsInactive = 233;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public const byte CheckUserOnJoin = 232;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public const byte ExpectedValues = 231;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public const byte Address = 230;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public const byte PeerCount = 229;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public const byte GameCount = 228;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public const byte MasterPeerCount = 227;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public const byte UserId = 225;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public const byte ApplicationId = 224;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		public const byte Position = 223;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public const byte MatchMakingType = 223;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public const byte GameList = 222;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public const byte Secret = 221;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public const byte AppVersion = 220;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		[Obsolete]
		public const byte AzureNodeInfo = 210;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		[Obsolete]
		public const byte AzureLocalNodeId = 209;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		[Obsolete]
		public const byte AzureMasterNodeId = 208;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public const byte RoomName = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public const byte Broadcast = 250;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public const byte ActorList = 252;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public const byte ActorNr = 254;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public const byte PlayerProperties = 249;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public const byte CustomEventContent = 245;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public const byte Data = 245;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public const byte Code = 244;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public const byte GameProperties = 248;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public const byte Properties = 251;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public const byte TargetActorNr = 253;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public const byte ReceiverGroup = 246;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public const byte Cache = 247;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public const byte CleanupCacheOnLeave = 241;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public const byte Group = 240;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public const byte Remove = 239;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public const byte PublishUserId = 239;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public const byte Add = 238;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public const byte Info = 218;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public const byte ClientAuthenticationType = 217;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public const byte ClientAuthenticationParams = 216;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public const byte JoinMode = 215;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public const byte ClientAuthenticationData = 214;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public const byte MasterClientId = 203;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public const byte FindFriendsRequestList = 1;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public const byte FindFriendsResponseOnlineList = 1;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public const byte FindFriendsResponseRoomIdList = 2;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public const byte LobbyName = 213;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public const byte LobbyType = 212;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public const byte LobbyStats = 211;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public const byte Region = 210;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public const byte UriPath = 209;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public const byte WebRpcParameters = 208;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public const byte WebRpcReturnCode = 207;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public const byte WebRpcReturnMessage = 206;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public const byte CacheSliceIndex = 205;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public const byte Plugins = 204;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public const byte NickName = 202;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public const byte PluginName = 201;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public const byte PluginVersion = 200;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public const byte ExpectedProtocol = 195;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public const byte CustomInitData = 194;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public const byte EncryptionMode = 193;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public const byte EncryptionData = 192;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public const byte RoomOptionFlags = 191;

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
		public ParameterCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public class OperationCode
	{
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		[Obsolete]
		public const byte ExchangeKeysForEncryption = 250;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		[Obsolete]
		public const byte Join = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public const byte AuthenticateOnce = 231;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public const byte Authenticate = 230;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public const byte JoinLobby = 229;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public const byte LeaveLobby = 228;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public const byte CreateGame = 227;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public const byte JoinGame = 226;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public const byte JoinRandomGame = 225;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public const byte Leave = 254;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public const byte RaiseEvent = 253;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public const byte SetProperties = 252;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public const byte GetProperties = 251;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public const byte ChangeGroups = 248;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public const byte FindFriends = 222;

		[Cpp2IlInjected.Token(Token = "0x400035E")]
		public const byte GetLobbyStats = 221;

		[Cpp2IlInjected.Token(Token = "0x400035F")]
		public const byte GetRegions = 220;

		[Cpp2IlInjected.Token(Token = "0x4000360")]
		public const byte WebRpc = 219;

		[Cpp2IlInjected.Token(Token = "0x4000361")]
		public const byte ServerSettings = 218;

		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public const byte GetGameList = 217;

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x361000", Offset = "0x360000", VA = "0x180361000")]
		public OperationCode()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public enum JoinMode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		CreateIfNotExists,
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		JoinOrRejoin,
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		RejoinOnly
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public enum MatchmakingMode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		FillRoom,
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		SerialMatching,
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		RandomMatching
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public enum ReceiverGroup : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		Others,
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		All,
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		MasterClient
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public enum EventCaching : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		DoNotCache = 0,
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		[Obsolete]
		MergeCache = 1,
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		[Obsolete]
		ReplaceCache = 2,
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		[Obsolete]
		RemoveCache = 3,
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		AddToRoomCache = 4,
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		AddToRoomCacheGlobal = 5,
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		RemoveFromRoomCache = 6,
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		RemoveFromRoomCacheForActorsLeft = 7,
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		SliceIncreaseIndex = 10,
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		SliceSetIndex = 11,
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		SlicePurgeIndex = 12,
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		SlicePurgeUpToIndex = 13
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[Flags]
	public enum PropertyTypeFlag : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		Game = 1,
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		Actor = 2,
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		GameAndActor = 3
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public class RoomOptions
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private bool isVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private bool isOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public byte MaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public int PlayerTtl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		public int EmptyRoomTtl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private bool cleanupCacheOnLeave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public Hashtable CustomRoomProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public string[] CustomRoomPropertiesForLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public string[] Plugins;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x38BAB0", Offset = "0x38AAB0", VA = "0x18038BAB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x38BAC0", Offset = "0x38AAC0", VA = "0x18038BAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x38B980", Offset = "0x38A980", VA = "0x18038B980")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x38BC40", Offset = "0x38AC40", VA = "0x18038BC40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public bool CleanupCacheOnLeave
		{
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x427970", Offset = "0x426970", VA = "0x180427970")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x427990", Offset = "0x426990", VA = "0x180427990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public bool SuppressRoomEvents
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x495B00", Offset = "0x494B00", VA = "0x180495B00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x495B10", Offset = "0x494B10", VA = "0x180495B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public bool PublishUserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x5C4620", Offset = "0x5C3620", VA = "0x1805C4620")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0xA90F00", Offset = "0xA8FF00", VA = "0x180A90F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public bool DeleteNullProperties
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x7EF760", Offset = "0x7EE760", VA = "0x1807EF760")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0xA90F10", Offset = "0xA8FF10", VA = "0x180A90F10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1986980", Offset = "0x1985980", VA = "0x181986980")]
		public RoomOptions()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public class RaiseEventOptions
	{
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		public static readonly RaiseEventOptions Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public EventCaching CachingOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		public byte InterestGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public int[] TargetActors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public ReceiverGroup Receivers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		[Obsolete]
		public byte SequenceChannel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public WebFlags Flags;

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x1983DB0", Offset = "0x1982DB0", VA = "0x181983DB0")]
		public RaiseEventOptions()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public enum LobbyType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		SqlLobby = 2,
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		AsyncRandomLobby = 3
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public class TypedLobby
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		public LobbyType Type;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		public static readonly TypedLobby Default;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x7CE7D0", Offset = "0x7CD7D0", VA = "0x1807CE7D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x1987E00", Offset = "0x1986E00", VA = "0x181987E00")]
		public TypedLobby()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x7CE8F0", Offset = "0x7CD8F0", VA = "0x1807CE8F0")]
		public TypedLobby(string name, LobbyType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x1987D00", Offset = "0x1986D00", VA = "0x181987D00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public class TypedLobbyInfo : TypedLobby
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		public int PlayerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		public int RoomCount;

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x1987A70", Offset = "0x1986A70", VA = "0x181987A70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x1987C70", Offset = "0x1986C70", VA = "0x181987C70")]
		public TypedLobbyInfo()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public enum AuthModeOption
	{
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		Auth,
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		AuthOnce,
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		AuthOnceWss
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public enum CustomAuthenticationType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		Steam = 1,
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		Facebook = 2,
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		Oculus = 3,
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		PlayStation = 4,
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		Xbox = 5,
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		None = byte.MaxValue
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public class AuthenticationValues
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private CustomAuthenticationType authType;

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public CustomAuthenticationType AuthType
		{
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0x38BAB0", Offset = "0x38AAB0", VA = "0x18038BAB0")]
			get
			{
				return default(CustomAuthenticationType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x38BAC0", Offset = "0x38AAC0", VA = "0x18038BAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public string AuthGetParameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x361AC0", Offset = "0x360AC0", VA = "0x180361AC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0x390550", Offset = "0x38F550", VA = "0x180390550")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public object AuthPostData
		{
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0x390560", Offset = "0x38F560", VA = "0x180390560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0x3903B0", Offset = "0x38F3B0", VA = "0x1803903B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public string Token
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0x365D30", Offset = "0x364D30", VA = "0x180365D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x3903D0", Offset = "0x38F3D0", VA = "0x1803903D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x364F90", Offset = "0x363F90", VA = "0x180364F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0x390570", Offset = "0x38F570", VA = "0x180390570")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0xD06AD0", Offset = "0xD05AD0", VA = "0x180D06AD0")]
		public AuthenticationValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0xD06AE0", Offset = "0xD05AE0", VA = "0x180D06AE0")]
		public AuthenticationValues(string userId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0xD067E0", Offset = "0xD057E0", VA = "0x180D067E0", Slot = "4")]
		public virtual void SetAuthPostData(string stringData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x3903B0", Offset = "0x38F3B0", VA = "0x1803903B0", Slot = "5")]
		public virtual void SetAuthPostData(byte[] byteData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x1974480", Offset = "0x1973480", VA = "0x181974480", Slot = "6")]
		public virtual void AddAuthParameter(string key, string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x19746B0", Offset = "0x19736B0", VA = "0x1819746B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public class Player
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private int actorID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		public readonly bool IsLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private string nickName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public object TagObject;

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		protected internal Room RoomReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000447")]
			[Cpp2IlInjected.Address(RVA = "0x38FC50", Offset = "0x38EC50", VA = "0x18038FC50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0x38BFA0", Offset = "0x38AFA0", VA = "0x18038BFA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0x427840", Offset = "0x426840", VA = "0x180427840")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public string NickName
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x390560", Offset = "0x38F560", VA = "0x180390560")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0x1983C90", Offset = "0x1982C90", VA = "0x181983C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0x365D30", Offset = "0x364D30", VA = "0x180365D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x3903D0", Offset = "0x38F3D0", VA = "0x1803903D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x1983C70", Offset = "0x1982C70", VA = "0x181983C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public bool IsInactive
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x36D870", Offset = "0x36C870", VA = "0x18036D870")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x5415E0", Offset = "0x5405E0", VA = "0x1805415E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Hashtable CustomProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x3B0E60", Offset = "0x3AFE60", VA = "0x1803B0E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x3B5030", Offset = "0x3B4030", VA = "0x1803B5030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public Hashtable AllProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x1983BD0", Offset = "0x1982BD0", VA = "0x181983BD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x1983AC0", Offset = "0x1982AC0", VA = "0x181983AC0")]
		protected internal Player(string nickName, int actorID, bool isLocal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x1983AE0", Offset = "0x1982AE0", VA = "0x181983AE0")]
		protected internal Player(string nickName, int actorID, bool isLocal, Hashtable playerProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x19833A0", Offset = "0x19823A0", VA = "0x1819833A0")]
		public Player Get(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x1983390", Offset = "0x1982390", VA = "0x181983390")]
		public Player GetNext()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x1983370", Offset = "0x1982370", VA = "0x181983370")]
		public Player GetNextFor(Player currentPlayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x1983120", Offset = "0x1982120", VA = "0x181983120")]
		public Player GetNextFor(int currentPlayerId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x19833C0", Offset = "0x19823C0", VA = "0x1819833C0", Slot = "4")]
		public virtual void InternalCacheProperties(Hashtable properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x1983A40", Offset = "0x1982A40", VA = "0x181983A40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x19837F0", Offset = "0x19827F0", VA = "0x1819837F0")]
		public string ToStringFull()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x1983050", Offset = "0x1982050", VA = "0x181983050", Slot = "0")]
		public override bool Equals(object p)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x427840", Offset = "0x426840", VA = "0x180427840", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x1983040", Offset = "0x1982040", VA = "0x181983040")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x1983620", Offset = "0x1982620", VA = "0x181983620")]
		public void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedValues, [Optional] WebFlags webFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x1983720", Offset = "0x1982720", VA = "0x181983720")]
		private void SetPlayerNameProperty()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public class Room : RoomInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		protected internal int PlayerTTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		protected internal int RoomTTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private Dictionary<int, Player> players;

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		protected internal LoadBalancingClient LoadBalancingClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0x386190", Offset = "0x385190", VA = "0x180386190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x40EA40", Offset = "0x40DA40", VA = "0x18040EA40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public new string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x3B0E60", Offset = "0x3AFE60", VA = "0x1803B0E60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x3B5030", Offset = "0x3B4030", VA = "0x1803B5030")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public new bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x36D870", Offset = "0x36C870", VA = "0x18036D870")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x1987710", Offset = "0x1986710", VA = "0x181987710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public new bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x541170", Offset = "0x540170", VA = "0x180541170")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0x1987830", Offset = "0x1986830", VA = "0x181987830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public new byte MaxPlayers
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x49AAD0", Offset = "0x499AD0", VA = "0x18049AAD0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x1987950", Offset = "0x1986950", VA = "0x181987950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public new byte PlayerCount
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x19876C0", Offset = "0x19866C0", VA = "0x1819876C0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public Dictionary<int, Player> Players
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x386180", Offset = "0x385180", VA = "0x180386180")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x4B5060", Offset = "0x4B4060", VA = "0x1804B5060")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public string[] ExpectedUsers
		{
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0x365D30", Offset = "0x364D30", VA = "0x180365D30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public int MasterClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0x3F3700", Offset = "0x3F2700", VA = "0x1803F3700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public string[] PropertiesListedInLobby
		{
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x3C7B50", Offset = "0x3C6B50", VA = "0x1803C7B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x3C7E10", Offset = "0x3C6E10", VA = "0x1803C7E10")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public bool AutoCleanUp
		{
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0xA0A160", Offset = "0xA09160", VA = "0x180A0A160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x1987600", Offset = "0x1986600", VA = "0x181987600")]
		protected internal Room(string roomName, RoomOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x1986C90", Offset = "0x1985C90", VA = "0x181986C90", Slot = "5")]
		public virtual void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x1986EE0", Offset = "0x1985EE0", VA = "0x181986EE0")]
		public void SetPropertiesListedInLobby(string[] propertiesListedInLobby)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x1986C20", Offset = "0x1985C20", VA = "0x181986C20", Slot = "6")]
		protected internal virtual void RemovePlayer(Player player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x1986BE0", Offset = "0x1985BE0", VA = "0x181986BE0", Slot = "7")]
		protected internal virtual void RemovePlayer(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x1986D60", Offset = "0x1985D60", VA = "0x181986D60")]
		public bool SetMasterClient(Player masterClientPlayer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x19869D0", Offset = "0x19859D0", VA = "0x1819869D0", Slot = "8")]
		public virtual bool AddPlayer(Player player)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x1986FA0", Offset = "0x1985FA0", VA = "0x181986FA0", Slot = "9")]
		public virtual Player StorePlayer(Player player)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x1986B70", Offset = "0x1985B70", VA = "0x181986B70", Slot = "10")]
		public virtual Player GetPlayer(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x1986A60", Offset = "0x1985A60", VA = "0x181986A60")]
		public void ClearExpectedUsers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x1987360", Offset = "0x1986360", VA = "0x181987360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x1987020", Offset = "0x1986020", VA = "0x181987020")]
		public new string ToStringFull()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public class RoomInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		protected internal bool removedFromList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private Hashtable customProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		protected byte maxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		protected string[] expectedUsers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		protected bool isOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		protected bool isVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		protected bool autoCleanUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		protected string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		protected internal int masterClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		protected string[] propertiesListedInLobby;

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public Hashtable CustomProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0x361AC0", Offset = "0x360AC0", VA = "0x180361AC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0x3B0E60", Offset = "0x3AFE60", VA = "0x1803B0E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public int PlayerCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0x5B1770", Offset = "0x5B0770", VA = "0x1805B1770")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(RVA = "0x5B2220", Offset = "0x5B1220", VA = "0x1805B2220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public bool IsLocalClientInside
		{
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x5C4560", Offset = "0x5C3560", VA = "0x1805C4560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x5C4660", Offset = "0x5C3660", VA = "0x1805C4660")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public byte MaxPlayers
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0x49AAD0", Offset = "0x499AD0", VA = "0x18049AAD0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0x36D870", Offset = "0x36C870", VA = "0x18036D870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0x541170", Offset = "0x540170", VA = "0x180541170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x19868E0", Offset = "0x19858E0", VA = "0x1819868E0")]
		protected internal RoomInfo(string roomName, Hashtable roomProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1985D40", Offset = "0x1984D40", VA = "0x181985D40", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x1985DE0", Offset = "0x1984DE0", VA = "0x181985DE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x1986670", Offset = "0x1985670", VA = "0x181986670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x1986360", Offset = "0x1985360", VA = "0x181986360")]
		public string ToStringFull()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x1985E10", Offset = "0x1984E10", VA = "0x181985E10", Slot = "4")]
		protected internal virtual void InternalCacheProperties(Hashtable propertiesToCache)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public class WebRpcResponse
	{
		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0x38FC50", Offset = "0x38EC50", VA = "0x18038FC50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0x38BFA0", Offset = "0x38AFA0", VA = "0x18038BFA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public int ReturnCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x427840", Offset = "0x426840", VA = "0x180427840")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x427980", Offset = "0x426980", VA = "0x180427980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public string DebugMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0x390560", Offset = "0x38F560", VA = "0x180390560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0x3903B0", Offset = "0x38F3B0", VA = "0x1803903B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public Dictionary<string, object> Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0x365D30", Offset = "0x364D30", VA = "0x180365D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0x3903D0", Offset = "0x38F3D0", VA = "0x1803903D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x1989100", Offset = "0x1988100", VA = "0x181989100")]
		public WebRpcResponse(OperationResponse response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x1988EF0", Offset = "0x1987EF0", VA = "0x181988EF0")]
		public string ToStringFull()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public class WebFlags
	{
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly WebFlags Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public byte WebhookFlags;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public const byte HttpForwardConst = 1;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public const byte SendAuthCookieConst = 2;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public const byte SendSyncConst = 4;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public const byte SendStateConst = 8;

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public bool HttpForward
		{
			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0x1988DF0", Offset = "0x1987DF0", VA = "0x181988DF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0x1988E30", Offset = "0x1987E30", VA = "0x181988E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool SendAuthCookie
		{
			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x1988E00", Offset = "0x1987E00", VA = "0x181988E00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x1988E60", Offset = "0x1987E60", VA = "0x181988E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public bool SendSync
		{
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x1988E20", Offset = "0x1987E20", VA = "0x181988E20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x1988EC0", Offset = "0x1987EC0", VA = "0x181988EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public bool SendState
		{
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0x1988E10", Offset = "0x1987E10", VA = "0x181988E10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0x1988E90", Offset = "0x1987E90", VA = "0x181988E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x11938F0", Offset = "0x11928F0", VA = "0x1811938F0")]
		public WebFlags(byte webhookFlags)
		{
		}
	}
}
namespace Beebyte.Obfuscator
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public class DoNotFakeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60004A3")]
		[Cpp2IlInjected.Address(RVA = "0x394820", Offset = "0x393820", VA = "0x180394820")]
		public DoNotFakeAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[AttributeUsage(AttributeTargets.Method)]
	public class ObfuscateLiteralsAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x394820", Offset = "0x393820", VA = "0x180394820")]
		public ObfuscateLiteralsAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class RenameAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private readonly string target;

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x394820", Offset = "0x393820", VA = "0x180394820")]
		private RenameAttribute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x4AA360", Offset = "0x4A9360", VA = "0x1804AA360")]
		public RenameAttribute(string target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x38FC50", Offset = "0x38EC50", VA = "0x18038FC50")]
		public string GetTarget()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class ReplaceLiteralsWithNameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x394820", Offset = "0x393820", VA = "0x180394820")]
		public ReplaceLiteralsWithNameAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x394820", Offset = "0x393820", VA = "0x180394820")]
		public SkipAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipRenameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x394820", Offset = "0x393820", VA = "0x180394820")]
		public SkipRenameAttribute()
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
