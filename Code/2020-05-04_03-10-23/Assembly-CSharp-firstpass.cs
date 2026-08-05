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
	[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setCurrencyCode(string currencyCode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setCustomerUserID(string customerUserID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setAppsFlyerKey(string key)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void trackAppLaunch()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setAppID(string appleAppId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void trackRichEvent(string eventName, Dictionary<string, string> eventValues)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setIsDebug(bool isDebug)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setIsSandbox(bool isSandbox)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void getConversionData()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3BCAD0", Offset = "0x3BB8D0", VA = "0x1803BCAD0")]
	public static string getAppsFlyerId()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void handleOpenUrl(string url, string sourceApplication, string annotation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setDeviceTrackingDisabled(bool state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void stopTracking(bool isStopTracking)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setAdditionalData(Dictionary<string, string> extraData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setAppInviteOneLinkID(string oneLinkID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void generateUserInviteLink(Dictionary<string, string> parameters, string callbackObject, string callbackMethod, string callbackFailedMethod)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void trackCrossPromoteImpression(string appId, string campaign)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void trackAndOpenStore(string promotedAppId, string campaign, Dictionary<string, string> customParams)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setMinTimeBetweenSessions(int seconds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setHost(string hostPrefixName, string hostName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3BCAD0", Offset = "0x3BB8D0", VA = "0x1803BCAD0")]
	public static string getHost()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setUserEmails(EmailCryptType cryptType, params string[] userEmails)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setResolveDeepLinkURLs(params string[] userEmails)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setOneLinkCustomDomain(params string[] domains)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void validateReceipt(string publicKey, string purchaseData, string signature, string price, string currency, Dictionary<string, string> extraParams)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setCollectIMEI(bool shouldCollect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setCollectAndroidID(bool shouldCollect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void createValidateInAppListener(string aObject, string callbackMethod, string callbackFailedMethod)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void init(string devKey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void init(string devKey, string callbackObject)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setImeiData(string imeiData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void loadConversionData(string callbackObject)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void enableUninstallTracking(string senderId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void updateServerUninstallToken(string token)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setAndroidIdData(string androidIdData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setPreinstallAttribution(string mediaSource, string campaign, string siteId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void validateReceipt(string productIdentifier, string price, string currency, string transactionId, Dictionary<string, string> additionalParametes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void handlePushNotification(Dictionary<string, string> payload)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void registerUninstall(byte[] token)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setValue(string value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	[Obsolete]
	public static void loadConversionData(string callbackObject, string callbackMethod, string callbackFailedMethod)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	[Obsolete]
	public static void setGCMProjectNumber(string googleGCMNumber)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	public static void setShouldCollectDeviceName(bool shouldCollectDeviceName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x36A810", Offset = "0x369610", VA = "0x18036A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x19F9020", Offset = "0x19F7E20", VA = "0x1819F9020")]
	public void didReceiveConversionData(string conversionData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x19F8F90", Offset = "0x19F7D90", VA = "0x1819F8F90")]
	public void didReceiveConversionDataWithError(string error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x19F8F00", Offset = "0x19F7D00", VA = "0x1819F8F00")]
	public void didFinishValidateReceipt(string validateResult)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x19F8E70", Offset = "0x19F7C70", VA = "0x1819F8E70")]
	public void didFinishValidateReceiptWithError(string error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x19F9190", Offset = "0x19F7F90", VA = "0x1819F9190")]
	public void onAppOpenAttribution(string validateResult)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x19F9100", Offset = "0x19F7F00", VA = "0x1819F9100")]
	public void onAppOpenAttributionFailure(string error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x19F9300", Offset = "0x19F8100", VA = "0x1819F9300")]
	public void onInAppBillingSuccess()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x19F9270", Offset = "0x19F8070", VA = "0x1819F9270")]
	public void onInAppBillingFailure(string error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x19F9370", Offset = "0x19F8170", VA = "0x1819F9370")]
	public void onInviteLinkGenerated(string link)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x19F9400", Offset = "0x19F8200", VA = "0x1819F9400")]
	public void onOpenStoreLinkGenerated(string link)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x19F94A0", Offset = "0x19F82A0", VA = "0x1819F94A0")]
	private void printCallback(string str)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x36A810", Offset = "0x369610", VA = "0x18036A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x27AB880", Offset = "0x27AA680", VA = "0x1827AB880", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x27AB890", Offset = "0x27AA690", VA = "0x1827AB890", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x27AB630", Offset = "0x27AA430", VA = "0x1827AB630")]
	public StreamingAudioIn(IAudioOutputDevice sourceDevice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x27AB590", Offset = "0x27AA390", VA = "0x1827AB590", Slot = "4")]
	public void SetCallback(Action<float[]> callback, LocalVoice localVoice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x27AB410", Offset = "0x27AA210", VA = "0x1827AB410")]
	private void Push(ArraySegment<float> samples)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x27AB350", Offset = "0x27AA150", VA = "0x1827AB350", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x19FBF10", Offset = "0x19FAD10", VA = "0x1819FBF10")]
		public DataCallback(Action<short[]> callback, IntPtr javaBuf)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x19FBE90", Offset = "0x19FAC90", VA = "0x1819FBE90")]
		public void OnData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x19FBF00", Offset = "0x19FAD00", VA = "0x1819FBF00")]
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
		[Cpp2IlInjected.Address(RVA = "0x46B7E0", Offset = "0x46A5E0", VA = "0x18046B7E0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x19F8980", Offset = "0x19F7780", VA = "0x1819F8980", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
	public AndroidAudioInAEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x19F7EB0", Offset = "0x19F6CB0", VA = "0x1819F7EB0", Slot = "4")]
	public void SetCallback(Action<short[]> callback, LocalVoice localVoice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x19F7E50", Offset = "0x19F6C50", VA = "0x1819F7E50", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x46B7E0", Offset = "0x46A5E0", VA = "0x18046B7E0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x19F8DC0", Offset = "0x19F7BC0", VA = "0x1819F8DC0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x19F8A30", Offset = "0x19F7830", VA = "0x1819F8A30")]
	private static extern IntPtr Photon_Audio_In_CreateReader(int deviceID);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x19F8AD0", Offset = "0x19F78D0", VA = "0x1819F8AD0")]
	private static extern void Photon_Audio_In_Destroy(IntPtr handler);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x19F8B70", Offset = "0x19F7970", VA = "0x1819F8B70")]
	private static extern bool Photon_Audio_In_Read(IntPtr handle, float[] buf, int len);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x19F8D10", Offset = "0x19F7B10", VA = "0x1819F8D10")]
	public AppleAudioInReader(int deviceID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x19F8990", Offset = "0x19F7790", VA = "0x1819F8990", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x19F8C40", Offset = "0x19F7A40", VA = "0x1819F8C40", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x39D0E0", Offset = "0x39BEE0", VA = "0x18039D0E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x39D0F0", Offset = "0x39BEF0", VA = "0x18039D0F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x16BA290", Offset = "0x16B9090", VA = "0x1816BA290", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x16BA270", Offset = "0x16B9070", VA = "0x1816BA270", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x19F9630", Offset = "0x19F8430", VA = "0x1819F9630")]
	public AudioClipWrapper(AudioClip audioClip)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x19F9500", Offset = "0x19F8300", VA = "0x1819F9500", Slot = "4")]
	public bool Read(float[] buffer)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x19FA000", Offset = "0x19F8E00", VA = "0x1819FA000")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x19FA0A0", Offset = "0x19F8EA0", VA = "0x1819FA0A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x19F9FA0", Offset = "0x19F8DA0", VA = "0x1819F9FA0")]
	private void OnAudioFilterRead(float[] frame, int channels)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x36A810", Offset = "0x369610", VA = "0x18036A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x3BBF00", Offset = "0x3BAD00", VA = "0x1803BBF00", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3BBEA0", Offset = "0x3BACA0", VA = "0x1803BBEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public AudioSource AudioSource
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x367190", Offset = "0x365F90", VA = "0x180367190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private int playSamplePos
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x19FB020", Offset = "0x19F9E20", VA = "0x1819FB020")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x19FB0E0", Offset = "0x19F9EE0", VA = "0x1819FB0E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool IsPlaying
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x19FB000", Offset = "0x19F9E00", VA = "0x1819FB000", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x19FAF30", Offset = "0x19F9D30", VA = "0x1819FAF30")]
	public AudioStreamPlayer(AudioSource audioSource, string logPrefix, bool debugInfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x19FADC0", Offset = "0x19F9BC0", VA = "0x1819FADC0", Slot = "5")]
	public void Start(int frequency, int channels, int frameSamples, int playDelayMs)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x19FA4B0", Offset = "0x19F92B0", VA = "0x1819FA4B0", Slot = "8")]
	public void Service()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x19FA140", Offset = "0x19F8F40", VA = "0x1819FA140", Slot = "7")]
	public void OnAudioFrame(float[] frame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3C4DD0", Offset = "0x3C3BD0", VA = "0x1803C4DD0", Slot = "6")]
	public void Stop()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x19FA430", Offset = "0x19F9230", VA = "0x1819FA430", Slot = "10")]
	public void Pause()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class IOSAudioForceToSpeaker : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	private void PhotonVoiceCreated()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x36A810", Offset = "0x369610", VA = "0x18036A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x16BA290", Offset = "0x16B9090", VA = "0x1816BA290", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x16BA270", Offset = "0x16B9070", VA = "0x1816BA270", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x16BA1C0", Offset = "0x16B8FC0", VA = "0x1816BA1C0")]
	public MicWrapper(string device, int suggestedFrequency)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x16BA0A0", Offset = "0x16B8EA0", VA = "0x1816BA0A0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x16BA0B0", Offset = "0x16B8EB0", VA = "0x1816BA0B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x27A8E00", Offset = "0x27A7C00", VA = "0x1827A8E00", Slot = "4")]
		public void LogError(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x27A8EE0", Offset = "0x27A7CE0", VA = "0x1827A8EE0", Slot = "5")]
		public void LogWarning(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x27A8E70", Offset = "0x27A7C70", VA = "0x1827A8E70", Slot = "6")]
		public void LogInfo(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x27A8D90", Offset = "0x27A7B90", VA = "0x1827A8D90", Slot = "7")]
		public void LogDebug(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x367190", Offset = "0x365F90", VA = "0x180367190")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool Active
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4C1DC0", Offset = "0x4C0BC0", VA = "0x1804C1DC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5A6800", Offset = "0x5A5600", VA = "0x1805A6800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x27AAE80", Offset = "0x27A9C80", VA = "0x1827AAE80")]
	public void ResetAEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x27AA6A0", Offset = "0x27A94A0", VA = "0x1827AA6A0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x27AAEA0", Offset = "0x27A9CA0", VA = "0x1827AAEA0")]
	private void UpdateProcProps()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x27AB170", Offset = "0x27A9F70", VA = "0x1827AB170")]
	private void setOutputListener(bool set)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x27AB030", Offset = "0x27A9E30", VA = "0x1827AB030")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x27AA6E0", Offset = "0x27A94E0", VA = "0x1827AA6E0")]
	private void InitAECLatencyDetect()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x27AA950", Offset = "0x27A9750", VA = "0x1827AA950")]
	[SkipRename]
	private void PhotonVoiceCreated(LocalVoice localVoice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x27AA910", Offset = "0x27A9710", VA = "0x1827AA910")]
	[SkipRename]
	private void PhotonVoiceRemoved()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x27AA910", Offset = "0x27A9710", VA = "0x1827AA910")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x27AA910", Offset = "0x27A9710", VA = "0x1827AA910")]
	private void reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x27AB140", Offset = "0x27A9F40", VA = "0x1827AB140")]
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
		[Cpp2IlInjected.Address(RVA = "0x46B7E0", Offset = "0x46A5E0", VA = "0x18046B7E0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x27AD450", Offset = "0x27AC250", VA = "0x1827AD450", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x27AD020", Offset = "0x27ABE20", VA = "0x1827AD020")]
	private static extern IntPtr Photon_Audio_In_Create(SystemMode systemMode, int micDevIdx, int spkDevIdx, Action<IntPtr, int> callback, bool featrModeOn, bool noiseSup, bool agc, bool cntrClip);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x27AD130", Offset = "0x27ABF30", VA = "0x1827AD130")]
	private static extern void Photon_Audio_In_Destroy(IntPtr handler);

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x27AD420", Offset = "0x27AC220", VA = "0x1827AD420")]
	public WindowsAudioInPusher(int deviceID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x27AD1D0", Offset = "0x27ABFD0", VA = "0x1827AD1D0", Slot = "4")]
	public void SetCallback(Action<short[]> callback, LocalVoice localVoice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x27AD460", Offset = "0x27AC260", VA = "0x1827AD460")]
	private void push(IntPtr buf, int lenBytes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x27ACF80", Offset = "0x27ABD80", VA = "0x1827ACF80", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x27A9A70", Offset = "0x27A8870", VA = "0x1827A9A70")]
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
	[Cpp2IlInjected.Address(RVA = "0x19F7D20", Offset = "0x19F6B20", VA = "0x1819F7D20")]
	public void GetAdvertisingIdentifier()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x19F7DB0", Offset = "0x19F6BB0", VA = "0x1819F7DB0")]
	public void GetAdvertisingTrackingEnabled()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x36A810", Offset = "0x369610", VA = "0x18036A810")]
	public ASIdentifierManagerExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ISN_AppdelegateUseExample : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x16B2FC0", Offset = "0x16B1DC0", VA = "0x1816B2FC0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x36A810", Offset = "0x369610", VA = "0x18036A810")]
	public ISN_AppdelegateUseExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ISN_CoreLocationDelegateExample : ISN_iCLLocationManagerDelegate
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x16B37B0", Offset = "0x16B25B0", VA = "0x1816B37B0", Slot = "4")]
	public void DidChangeAuthorizationStatus(ISN_CLAuthorizationStatus authorizationStatus)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x16B39B0", Offset = "0x16B27B0", VA = "0x1816B39B0", Slot = "5")]
	public void DidUpdateLocations(ISN_CLLocationArray locations)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x16B3830", Offset = "0x16B2630", VA = "0x1816B3830", Slot = "6")]
	public void DidFailWithError(SA_Error error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x16B38A0", Offset = "0x16B26A0", VA = "0x1816B38A0", Slot = "7")]
	public void DidFinishDeferredUpdatesWithError(SA_Error error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x16B3910", Offset = "0x16B2710", VA = "0x1816B3910", Slot = "8")]
	public void DidPauseLocationUpdates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x16B3960", Offset = "0x16B2760", VA = "0x1816B3960", Slot = "9")]
	public void DidResumeLocationUpdates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x16B3E10", Offset = "0x16B2C10", VA = "0x1816B3E10")]
	private void ShowMessage(string title, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x16B40D0", Offset = "0x16B2ED0", VA = "0x1816B40D0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x16B3F70", Offset = "0x16B2D70", VA = "0x1816B3F70")]
	private void ShowMessage(string title, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x36A810", Offset = "0x369610", VA = "0x18036A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x16B4AD0", Offset = "0x16B38D0", VA = "0x1816B4AD0")]
	public void RequestAccessToEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x16B4B60", Offset = "0x16B3960", VA = "0x1816B4B60")]
	public void RequestAccessToReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x16B4680", Offset = "0x16B3480", VA = "0x1816B4680")]
	public void AddEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x16B4930", Offset = "0x16B3730", VA = "0x1816B4930")]
	public void RemoveEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x16B47D0", Offset = "0x16B35D0", VA = "0x1816B47D0")]
	public void AddReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x16B4A00", Offset = "0x16B3800", VA = "0x1816B4A00")]
	public void RemoveReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x36A810", Offset = "0x369610", VA = "0x18036A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x16B5320", Offset = "0x16B4120", VA = "0x1816B5320")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x36A810", Offset = "0x369610", VA = "0x18036A810")]
	public ISN_GameKitUseExample_TvOS()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DocumentationExample : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x19FC0B0", Offset = "0x19FAEB0", VA = "0x1819FC0B0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x36A810", Offset = "0x369610", VA = "0x18036A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x16B61A0", Offset = "0x16B4FA0", VA = "0x1816B61A0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x16B6530", Offset = "0x16B5330", VA = "0x1816B6530")]
	private void UpdatePlayerStateUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x36A810", Offset = "0x369610", VA = "0x18036A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x16B3300", Offset = "0x16B2100", VA = "0x1816B3300")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x36A810", Offset = "0x369610", VA = "0x18036A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x16B7850", Offset = "0x16B6650", VA = "0x1816B7850")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x36A810", Offset = "0x369610", VA = "0x18036A810")]
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
	[Cpp2IlInjected.Address(RVA = "0x16B84D0", Offset = "0x16B72D0", VA = "0x1816B84D0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x16B8340", Offset = "0x16B7140", VA = "0x1816B8340")]
	private void AddFitter(GameObject go)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x16B8EF0", Offset = "0x16B7CF0", VA = "0x1816B8EF0")]
	private void UpdateUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x16B8B20", Offset = "0x16B7920", VA = "0x1816B8B20")]
	private void StartPicker(ISN_UIImagePickerControllerSourceType sourceType, string mediaType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x16B8970", Offset = "0x16B7770", VA = "0x1816B8970")]
	private void DisplayResult(ISN_UIPickerControllerResult result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x16B83B0", Offset = "0x16B71B0", VA = "0x1816B83B0")]
	private void ApplyImageToGui(Texture2D image)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x16B8850", Offset = "0x16B7650", VA = "0x1816B8850")]
	private void DisplayMessage(string message, [Optional] Action onClose)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x36A810", Offset = "0x369610", VA = "0x18036A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x27A55E0", Offset = "0x27A43E0", VA = "0x1827A55E0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_RemoteNotifications_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class ISN_UNAuthorization_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x27A61A0", Offset = "0x27A4FA0", VA = "0x1827A61A0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
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
		[Cpp2IlInjected.Address(RVA = "0x27A6280", Offset = "0x27A5080", VA = "0x1827A6280", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x27A6570", Offset = "0x27A5370", VA = "0x1827A6570")]
		private void ValidateRequest(ISN_UNNotificationRequest presentdeRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
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
		[Cpp2IlInjected.Address(RVA = "0x27A5D10", Offset = "0x27A4B10", VA = "0x1827A5D10", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x27A5BE0", Offset = "0x27A49E0", VA = "0x1827A5BE0")]
		private void TestVideo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_UIImagePickerController_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class SaveToCameraRollTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x27AA5B0", Offset = "0x27A93B0", VA = "0x1827AA5B0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
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
		[Cpp2IlInjected.Address(RVA = "0x27A3B00", Offset = "0x27A2900", VA = "0x1827A3B00", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_DefaultSharingDialog_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class ISN_FacebookShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x27A3DD0", Offset = "0x27A2BD0", VA = "0x1827A3DD0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_FacebookShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class ISN_InstagramShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x27A5320", Offset = "0x27A4120", VA = "0x1827A5320", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_InstagramShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class ISN_MailShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x27A5430", Offset = "0x27A4230", VA = "0x1827A5430", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_MailShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class ISN_TextMessage_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x27A5790", Offset = "0x27A4590", VA = "0x1827A5790", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_TextMessage_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class ISN_TwitterShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x27A5AD0", Offset = "0x27A48D0", VA = "0x1827A5AD0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_TwitterShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ISN_WhatsAppShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x27A8C30", Offset = "0x27A7A30", VA = "0x1827A8C30", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
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
		[Cpp2IlInjected.Address(RVA = "0x27A3EF0", Offset = "0x27A2CF0", VA = "0x1827A3EF0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_GKAchievementsLoad_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class ISN_GKAchievmentReport_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x27A4340", Offset = "0x27A3140", VA = "0x1827A4340", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x27A4260", Offset = "0x27A3060", VA = "0x1827A4260")]
		private void ReportCompletedAchievment(string achievementId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x27A41F0", Offset = "0x27A2FF0", VA = "0x1827A41F0")]
		private void CheckIfCompleted(string achievementId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_GKAchievmentReport_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class ISN_GKAchievmentReset_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x27A4600", Offset = "0x27A3400", VA = "0x1827A4600", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x27A4590", Offset = "0x27A3390", VA = "0x1827A4590")]
		private void CheckIfResetCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_GKAchievmentReset_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class ISN_GKGameCenterUI_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x27A47C0", Offset = "0x27A35C0", VA = "0x1827A47C0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_GKGameCenterUI_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class ISN_GKGenerateIdentityVerificationSignature_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x27A47F0", Offset = "0x27A35F0", VA = "0x1827A47F0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_GKGenerateIdentityVerificationSignature_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class ISN_GKLoadLeaderboards_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x27A4A00", Offset = "0x27A3800", VA = "0x1827A4A00", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_GKLoadLeaderboards_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class ISN_GKLocalPlayer_Authenticate_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x27A4CA0", Offset = "0x27A3AA0", VA = "0x1827A4CA0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_GKLocalPlayer_Authenticate_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class ISN_GKReportingScores_Test : ISN_GKSingleLeaderboard_Test
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x27A4EC0", Offset = "0x27A3CC0", VA = "0x1827A4EC0", Slot = "7")]
		public override void OnLeaderboardReady(ISN_GKLeaderboard leaderboard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_GKReportingScores_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class ISN_GKRetrievingScores_Test : ISN_GKSingleLeaderboard_Test
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x27A5070", Offset = "0x27A3E70", VA = "0x1827A5070", Slot = "7")]
		public override void OnLeaderboardReady(ISN_GKLeaderboard leaderboard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_GKRetrievingScores_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public abstract class ISN_GKSingleLeaderboard_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x27A51D0", Offset = "0x27A3FD0", VA = "0x1827A51D0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void OnLeaderboardReady(ISN_GKLeaderboard leaderboard);

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
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
		[Cpp2IlInjected.Address(RVA = "0x27A32C0", Offset = "0x27A20C0", VA = "0x1827A32C0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_AudioSessionTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class ISN_BuildInfoTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x27A3330", Offset = "0x27A2130", VA = "0x1827A3330", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_BuildInfoTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class ISN_iCloudKeyValueStorageTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x27A8CD0", Offset = "0x27A7AD0", VA = "0x1827A8CD0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_iCloudKeyValueStorageTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class ISN_NSFileManagerTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x27A5560", Offset = "0x27A4360", VA = "0x1827A5560", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_NSFileManagerTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class ISN_TimeZoneTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x27A58B0", Offset = "0x27A46B0", VA = "0x1827A58B0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
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
		[Cpp2IlInjected.Address(RVA = "0x27A33E0", Offset = "0x27A21E0", VA = "0x1827A33E0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
		public ISN_CNContactsPicker_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class ISN_CNFetchPhoneContacts_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x27A39D0", Offset = "0x27A27D0", VA = "0x1827A39D0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x27A34B0", Offset = "0x27A22B0", VA = "0x1827A34B0")]
		public static void PrintContacts(List<ISN_CNContact> contacts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x27A3320", Offset = "0x27A2120", VA = "0x1827A3320")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B0730", Offset = "0x16AF530", VA = "0x1816B0730")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x36A810", Offset = "0x369610", VA = "0x18036A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B31A0", Offset = "0x16B1FA0", VA = "0x1816B31A0", Slot = "4")]
		protected virtual void InitStyles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6D1990", Offset = "0x6D0790", VA = "0x1806D1990", Slot = "5")]
		public virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x16B32A0", Offset = "0x16B20A0", VA = "0x1816B32A0")]
		public void UpdateToStartPos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x16B3290", Offset = "0x16B2090", VA = "0x1816B3290")]
		public void LoadLevel(string levelName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x16B32B0", Offset = "0x16B20B0", VA = "0x1816B32B0")]
		public ISN_BaseIOSFeaturePreview()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class ISN_FoundationExamples
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x16B51F0", Offset = "0x16B3FF0", VA = "0x1816B51F0")]
		public void LocaleInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B0A90", Offset = "0x16AF890", VA = "0x1816B0A90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x16B1410", Offset = "0x16B0210", VA = "0x1816B1410")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x16B0B70", Offset = "0x16AF970", VA = "0x1816B0B70")]
		private void DidModifySavedGame(ISN_GKSavedGameSaveResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x16B0EA0", Offset = "0x16AFCA0", VA = "0x1816B0EA0")]
		private void HasConflictingSavedGames(ISN_GKSavedGameFetchResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x16B14F0", Offset = "0x16B02F0", VA = "0x1816B14F0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x16B2F40", Offset = "0x16B1D40", VA = "0x1816B2F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x27AD5B0", Offset = "0x27AC3B0", VA = "0x1827AD5B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x27AD6A0", Offset = "0x27AC4A0", VA = "0x1827AD6A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x27AE090", Offset = "0x27ACE90", VA = "0x1827AE090")]
		private void StoreDidChangeExternally(ISN_NSStoreDidChangeExternallyNotification result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x27AD730", Offset = "0x27AC530", VA = "0x1827AD730")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x27AE320", Offset = "0x27AD120", VA = "0x1827AE320")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B7BA0", Offset = "0x16B69A0", VA = "0x1816B7BA0", Slot = "7")]
		public override GameObject AddSideMenuElement(List<SA_ExampleSubsectionConfig> subsections, bool isActive)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x16B80B0", Offset = "0x16B6EB0", VA = "0x1816B80B0")]
		private void SetToggle(string sceneName, string text, SA_SideToggleStyle style, Toggle toggle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x16B7E40", Offset = "0x16B6C40", VA = "0x1816B7E40", Slot = "5")]
		public override Toggle AddTopMenuElement(string name, Sprite icon, bool isActive, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x16B8090", Offset = "0x16B6E90", VA = "0x1816B8090", Slot = "4")]
		public override void SetLogo(Sprite sprite)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x16B8260", Offset = "0x16B7060", VA = "0x1816B8260", Slot = "8")]
		public override void UnloadContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x16B7FD0", Offset = "0x16B6DD0", VA = "0x1816B7FD0", Slot = "9")]
		public override void LoadContent(GameObject canvas)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x16B81B0", Offset = "0x16B6FB0", VA = "0x1816B81B0", Slot = "6")]
		public override void ShowTopMenuItem(GameObject menuItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x16B7AF0", Offset = "0x16B68F0", VA = "0x1816B7AF0", Slot = "10")]
		public override void AddLog(string log)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x3F94F0", Offset = "0x3F82F0", VA = "0x1803F94F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27A8F50", Offset = "0x27A7D50", VA = "0x1827A8F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x27A9630", Offset = "0x27A8430", VA = "0x1827A9630")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x27A97D0", Offset = "0x27A85D0", VA = "0x1827A97D0")]
		private void Subscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x27A95F0", Offset = "0x27A83F0", VA = "0x1827A95F0")]
		private void SetLogo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x27A8FE0", Offset = "0x27A7DE0", VA = "0x1827A8FE0")]
		private void GenerateMenuUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x27A92F0", Offset = "0x27A80F0", VA = "0x1827A92F0")]
		private void HandlerTopMenuClick(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x27A91B0", Offset = "0x27A7FB0", VA = "0x1827A91B0")]
		private void HandlerSideMenuClick(string sceneName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x27A93A0", Offset = "0x27A81A0", VA = "0x1827A93A0")]
		private void LoadScene(string sceneName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x27A9940", Offset = "0x27A8740", VA = "0x1827A9940")]
		private void UnloadScene()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x27A94A0", Offset = "0x27A82A0", VA = "0x1827A94A0")]
		private void SceneLoaded(Scene scene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x27A8FB0", Offset = "0x27A7DB0", VA = "0x1827A8FB0")]
		private void Application_LogMessageReceived(string condition, string stackTrace, LogType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x27A99B0", Offset = "0x27A87B0", VA = "0x1827A99B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27A9A10", Offset = "0x27A8810", VA = "0x1827A9A10")]
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
		[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x359340", Offset = "0x358140", VA = "0x180359340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x27A9F80", Offset = "0x27A8D80", VA = "0x1827A9F80")]
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
		[Cpp2IlInjected.Address(RVA = "0x27AA0F0", Offset = "0x27A8EF0", VA = "0x1827AA0F0")]
		public void SetParam(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x27A9FC0", Offset = "0x27A8DC0", VA = "0x1827A9FC0", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x27AA000", Offset = "0x27A8E00", VA = "0x1827AA000", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x27AA200", Offset = "0x27A9000", VA = "0x1827AA200")]
		public void SetWhite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x27AA070", Offset = "0x27A8E70", VA = "0x1827AA070")]
		public void SetBlue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x36A810", Offset = "0x369610", VA = "0x18036A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x27AA3C0", Offset = "0x27A91C0", VA = "0x1827AA3C0")]
		public Toggle SetToggle(bool isActive, string text, Sprite sprite)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x27AA250", Offset = "0x27A9050", VA = "0x1827AA250", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x27AA290", Offset = "0x27A9090", VA = "0x1827AA290", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x27AA520", Offset = "0x27A9320", VA = "0x1827AA520")]
		public void SetWhite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x27AA2D0", Offset = "0x27A90D0", VA = "0x1827AA2D0")]
		public void SetBlue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x36A810", Offset = "0x369610", VA = "0x18036A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x36A810", Offset = "0x369610", VA = "0x18036A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B7270", Offset = "0x16B6070", VA = "0x1816B7270")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x16B7490", Offset = "0x16B6290", VA = "0x1816B7490")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x16B76F0", Offset = "0x16B64F0", VA = "0x1816B76F0")]
		private void OnRecordStopped(ISN_RPStopResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x16B32B0", Offset = "0x16B20B0", VA = "0x1816B32B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B55C0", Offset = "0x16B43C0", VA = "0x1816B55C0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x16B32B0", Offset = "0x16B20B0", VA = "0x1816B32B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B70C0", Offset = "0x16B5EC0", VA = "0x1816B70C0")]
		public void init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x16B7010", Offset = "0x16B5E10", VA = "0x1816B7010")]
		private static void UnlockProducts(ISN_iSKPaymentTransaction transaction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x16B6960", Offset = "0x16B5760", VA = "0x1816B6960", Slot = "4")]
		public void OnTransactionUpdated(ISN_iSKPaymentTransaction transaction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0", Slot = "5")]
		public void OnTransactionRemoved(ISN_iSKPaymentTransaction result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x394600", Offset = "0x393400", VA = "0x180394600", Slot = "6")]
		public bool OnShouldAddStorePayment(ISN_SKProduct result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x16B66B0", Offset = "0x16B54B0", VA = "0x1816B66B0", Slot = "7")]
		public void OnRestoreTransactionsComplete(SA_Result result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16B8F80", Offset = "0x16B7D80", VA = "0x1816B8F80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x16B9100", Offset = "0x16B7F00", VA = "0x1816B9100")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x16B32B0", Offset = "0x16B20B0", VA = "0x1816B32B0")]
		public ISN_UIKitExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class ISN_UserNotificationExample : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x27A6F10", Offset = "0x27A5D10", VA = "0x1827A6F10")]
		public void RequestUserNotificationPermission()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x27A6780", Offset = "0x27A5580", VA = "0x1827A6780")]
		public void GetSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x27A6B70", Offset = "0x27A5970", VA = "0x1827A6B70")]
		public void NotificationInterval()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x27A69B0", Offset = "0x27A57B0", VA = "0x1827A69B0")]
		public void NotificationCalendar()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x27A6D00", Offset = "0x27A5B00", VA = "0x1827A6D00")]
		public void NotificationLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x27A6850", Offset = "0x27A5650", VA = "0x1827A6850")]
		public void NoSoundToTrigger()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x36A810", Offset = "0x369610", VA = "0x18036A810")]
		public ISN_UserNotificationExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class ISN_UserNotificationsExamples : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x27A70D0", Offset = "0x27A5ED0", VA = "0x1827A70D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x27A88F0", Offset = "0x27A76F0", VA = "0x1827A88F0")]
		private void PrintNotification(ISN_UNNotification notification)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x27A7C00", Offset = "0x27A6A00", VA = "0x1827A7C00")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x27A7DE0", Offset = "0x27A6BE0", VA = "0x1827A7DE0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x27A7880", Offset = "0x27A6680", VA = "0x1827A7880")]
		private void DocsExample()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x27A7350", Offset = "0x27A6150", VA = "0x1827A7350")]
		private void ContactsUse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x27A8C20", Offset = "0x27A7A20", VA = "0x1827A8C20")]
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
		[Cpp2IlInjected.Address(RVA = "0x16BBEC0", Offset = "0x16BACC0", VA = "0x1816BBEC0")]
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
			[Cpp2IlInjected.Address(RVA = "0x37BEA0", Offset = "0x37ACA0", VA = "0x18037BEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool HideInInspector
		{
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x4DD460", Offset = "0x4DC260", VA = "0x1804DD460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x16BBF50", Offset = "0x16BAD50", VA = "0x1816BBF50")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x16BBFB0", Offset = "0x16BADB0", VA = "0x1816BBFB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x381960", Offset = "0x380760", VA = "0x180381960")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x16BC020", Offset = "0x16BAE20", VA = "0x1816BC020")]
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
			[Cpp2IlInjected.Address(RVA = "0x381960", Offset = "0x380760", VA = "0x180381960")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x16BC020", Offset = "0x16BAE20", VA = "0x1816BC020")]
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
			[Cpp2IlInjected.Address(RVA = "0x37BEA0", Offset = "0x37ACA0", VA = "0x18037BEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string InternalIconPath
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x359340", Offset = "0x358140", VA = "0x180359340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x16BC090", Offset = "0x16BAE90", VA = "0x1816BC090")]
		public SA_PD_LabelWithIconAttribute(string iconPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x16BC100", Offset = "0x16BAF00", VA = "0x1816BC100")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E1D60", Offset = "0x4E0B60", VA = "0x1804E1D60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x4E2030", Offset = "0x4E0E30", VA = "0x1804E2030")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x60F9A0", Offset = "0x60E7A0", VA = "0x18060F9A0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x16BC1A0", Offset = "0x16BAFA0", VA = "0x1816BC1A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E1D60", Offset = "0x4E0B60", VA = "0x1804E1D60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x4E2030", Offset = "0x4E0E30", VA = "0x1804E2030")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x60F9A0", Offset = "0x60E7A0", VA = "0x18060F9A0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x16BC1A0", Offset = "0x16BAFA0", VA = "0x1816BC1A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x37BEA0", Offset = "0x37ACA0", VA = "0x18037BEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4FD570", Offset = "0x4FC370", VA = "0x1804FD570")]
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
			[Cpp2IlInjected.Address(RVA = "0x37BEA0", Offset = "0x37ACA0", VA = "0x18037BEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x382DE0", Offset = "0x381BE0", VA = "0x180382DE0")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x16BC050", Offset = "0x16BAE50", VA = "0x1816BC050")]
		public SA_PD_HelpboxDecoratorAttribute(SA_PD_MessageType type, string message = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SA_PD_PRInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6ADF70", Offset = "0x6ACD70", VA = "0x1806ADF70")]
		public SA_PD_PRInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SA_PD_StandartInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6ADF70", Offset = "0x6ACD70", VA = "0x1806ADF70")]
		public SA_PD_StandartInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SA_PD_ThingInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6ADF70", Offset = "0x6ACD70", VA = "0x1806ADF70")]
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
			[Cpp2IlInjected.Address(RVA = "0x359340", Offset = "0x358140", VA = "0x180359340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Bandwidth? PreviousPacketBandwidth
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x382CF0", Offset = "0x381AF0", VA = "0x180382CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public SamplingRate SamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x367180", Offset = "0x365F80", VA = "0x180367180")]
			[CompilerGenerated]
			get
			{
				return default(SamplingRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x4ABD90", Offset = "0x4AAB90", VA = "0x1804ABD90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Channels Channels
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x4B6110", Offset = "0x4B4F10", VA = "0x1804B6110")]
			get
			{
				return default(Channels);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x16BA820", Offset = "0x16B9620", VA = "0x1816BA820")]
		public OpusDecoder(SamplingRate outputSamplingRateHz, Channels numChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x16BA2B0", Offset = "0x16B90B0", VA = "0x1816BA2B0")]
		public float[] DecodePacketFloat(byte[] packetData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x16BA4E0", Offset = "0x16B92E0", VA = "0x1816BA4E0")]
		public short[] DecodePacketShort(byte[] packetData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x16BA710", Offset = "0x16B9510", VA = "0x1816BA710", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x4B6110", Offset = "0x4B4F10", VA = "0x1804B6110")]
			get
			{
				return default(SamplingRate);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Channels InputChannels
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x446DC0", Offset = "0x445BC0", VA = "0x180446DC0")]
			get
			{
				return default(Channels);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string Version
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x359340", Offset = "0x358140", VA = "0x180359340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Delay EncoderDelay
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x417760", Offset = "0x416560", VA = "0x180417760")]
			get
			{
				return default(Delay);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x16BB4F0", Offset = "0x16BA2F0", VA = "0x1816BB4F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int FrameSizePerChannel
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x382F20", Offset = "0x381D20", VA = "0x180382F20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public int Bitrate
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x16BB370", Offset = "0x16BA170", VA = "0x1816BB370")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x16BB490", Offset = "0x16BA290", VA = "0x1816BB490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public Bandwidth MaxBandwidth
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x16BB410", Offset = "0x16BA210", VA = "0x1816BB410")]
			get
			{
				return default(Bandwidth);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x16BB650", Offset = "0x16BA450", VA = "0x1816BB650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Complexity Complexity
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x16BB390", Offset = "0x16BA190", VA = "0x1816BB390")]
			get
			{
				return default(Complexity);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x16BB4B0", Offset = "0x16BA2B0", VA = "0x1816BB4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int ExpectedPacketLossPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x16BB3D0", Offset = "0x16BA1D0", VA = "0x1816BB3D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x16BB610", Offset = "0x16BA410", VA = "0x1816BB610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public SignalHint SignalHint
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x16BB430", Offset = "0x16BA230", VA = "0x1816BB430")]
			get
			{
				return default(SignalHint);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x16BB670", Offset = "0x16BA470", VA = "0x1816BB670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public ForceChannels ForceChannels
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x16BB3F0", Offset = "0x16BA1F0", VA = "0x1816BB3F0")]
			get
			{
				return default(ForceChannels);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x16BB630", Offset = "0x16BA430", VA = "0x1816BB630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public bool UseInbandFEC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x16BB450", Offset = "0x16BA250", VA = "0x1816BB450")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x16BB690", Offset = "0x16BA490", VA = "0x1816BB690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool UseUnconstrainedVBR
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x16BB470", Offset = "0x16BA270", VA = "0x1816BB470")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x16BB6B0", Offset = "0x16BA4B0", VA = "0x1816BB6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool DtxEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x16BB3B0", Offset = "0x16BA1B0", VA = "0x1816BB3B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x16BB4D0", Offset = "0x16BA2D0", VA = "0x1816BB4D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x16BAF30", Offset = "0x16B9D30", VA = "0x1816BAF30")]
		public OpusEncoder(SamplingRate inputSamplingRateHz, Channels numChannels, int bitrate, OpusApplicationType applicationType, Delay encoderDelay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x16BAAA0", Offset = "0x16B98A0", VA = "0x1816BAAA0")]
		public ArraySegment<byte> Encode(float[] pcmSamples)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x16BACB0", Offset = "0x16B9AB0", VA = "0x1816BACB0")]
		public ArraySegment<byte> Encode(short[] pcmSamples)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x16BAA00", Offset = "0x16B9800", VA = "0x1816BAA00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0xA35610", Offset = "0xA34410", VA = "0x180A35610")]
			get
			{
				return default(OpusStatusCode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x16BB6D0", Offset = "0x16BA4D0", VA = "0x1816BB6D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x16CBB50", Offset = "0x16CA950", VA = "0x1816CBB50")]
		private static extern int opus_encoder_get_size(Channels channels);

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x16CBBE0", Offset = "0x16CA9E0", VA = "0x1816CBBE0")]
		private static extern OpusStatusCode opus_encoder_init(IntPtr st, SamplingRate Fs, Channels channels, OpusApplicationType application);

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x16CBCA0", Offset = "0x16CAAA0", VA = "0x1816CBCA0")]
		public static extern IntPtr opus_get_version_string();

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x16CB540", Offset = "0x16CA340", VA = "0x1816CB540")]
		private static extern int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x16CB2E0", Offset = "0x16CA0E0", VA = "0x1816CB2E0")]
		private static extern int opus_encode_float(IntPtr st, float[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x16CBA40", Offset = "0x16CA840", VA = "0x1816CBA40")]
		private static extern int opus_encoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x16CB990", Offset = "0x16CA790", VA = "0x1816CB990")]
		private static extern int opus_encoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x16CB090", Offset = "0x16C9E90", VA = "0x1816CB090")]
		private static extern int opus_decoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x16CAFE0", Offset = "0x16C9DE0", VA = "0x1816CAFE0")]
		private static extern int opus_decoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x16CB1A0", Offset = "0x16C9FA0", VA = "0x1816CB1A0")]
		private static extern int opus_decoder_get_size(Channels channels);

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x16CB230", Offset = "0x16CA030", VA = "0x1816CB230")]
		private static extern OpusStatusCode opus_decoder_init(IntPtr st, SamplingRate Fs, Channels channels);

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x16CAC20", Offset = "0x16C9A20", VA = "0x1816CAC20")]
		private static extern int opus_decode(IntPtr st, byte[] data, int len, short[] pcm, int frame_size, int decode_fec);

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x16CAA30", Offset = "0x16C9830", VA = "0x1816CAA30")]
		private static extern int opus_decode_float(IntPtr st, byte[] data, int len, float[] pcm, int frame_size, int decode_fec);

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x16CBD30", Offset = "0x16CAB30", VA = "0x1816CBD30")]
		public static extern int opus_packet_get_bandwidth(byte[] data);

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x16CBDD0", Offset = "0x16CABD0", VA = "0x1816CBDD0")]
		public static extern int opus_packet_get_nb_channels(byte[] data);

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x16CBE70", Offset = "0x16CAC70", VA = "0x1816CBE70")]
		private static extern IntPtr opus_strerror(OpusStatusCode error);

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x16CB7A0", Offset = "0x16CA5A0", VA = "0x1816CB7A0")]
		public static IntPtr opus_encoder_create(SamplingRate Fs, Channels channels, OpusApplicationType application)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x16CB630", Offset = "0x16CA430", VA = "0x1816CB630")]
		public static int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x16CB3D0", Offset = "0x16CA1D0", VA = "0x1816CB3D0")]
		public static int opus_encode(IntPtr st, float[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x16CBAF0", Offset = "0x16CA8F0", VA = "0x1816CBAF0")]
		public static void opus_encoder_destroy(IntPtr st)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x16CA910", Offset = "0x16C9710", VA = "0x1816CA910")]
		public static int get_opus_encoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x16CC020", Offset = "0x16CAE20", VA = "0x1816CC020")]
		public static void set_opus_encoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x16CA7F0", Offset = "0x16C95F0", VA = "0x1816CA7F0")]
		public static int get_opus_decoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x16CBF00", Offset = "0x16CAD00", VA = "0x1816CBF00")]
		public static void set_opus_decoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x16CAE10", Offset = "0x16C9C10", VA = "0x1816CAE10")]
		public static IntPtr opus_decoder_create(SamplingRate Fs, Channels channels)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x16CB140", Offset = "0x16C9F40", VA = "0x1816CB140")]
		public static void opus_decoder_destroy(IntPtr st)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x16CAD10", Offset = "0x16C9B10", VA = "0x1816CAD10")]
		public static int opus_decode(IntPtr st, byte[] data, short[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x16CAB20", Offset = "0x16C9920", VA = "0x1816CAB20")]
		public static int opus_decode(IntPtr st, byte[] data, float[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x16CA6C0", Offset = "0x16C94C0", VA = "0x1816CA6C0")]
		private static void HandleStatusCode(OpusStatusCode statusCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
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
namespace ExitGames.Client.Photon.Voice
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
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
			[Cpp2IlInjected.Address(RVA = "0x17E5B40", Offset = "0x17E4940", VA = "0x1817E5B40")]
			public Resampler(int dstSize, int channels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000535")]
			[Cpp2IlInjected.Address(RVA = "0x17E5AF0", Offset = "0x17E48F0", VA = "0x1817E5AF0", Slot = "4")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x6501F0", Offset = "0x64EFF0", VA = "0x1806501F0", Slot = "4")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000EE")]
			public float CurrentPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x600053D")]
				[Cpp2IlInjected.Address(RVA = "0x6501F0", Offset = "0x64EFF0", VA = "0x1806501F0", Slot = "5")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000EF")]
			public float PeakAmpForFrame
			{
				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(RVA = "0x6501F0", Offset = "0x64EFF0", VA = "0x1806501F0", Slot = "6")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F0")]
			public float AccumAvgPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x600053F")]
				[Cpp2IlInjected.Address(RVA = "0x6501F0", Offset = "0x64EFF0", VA = "0x1806501F0", Slot = "7")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0", Slot = "8")]
			public void ResetAccumAvgPeakAmp()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000541")]
			[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x17DF4E0", Offset = "0x17DE2E0", VA = "0x1817DF4E0", Slot = "6")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F2")]
			public float CurrentPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x6000544")]
				[Cpp2IlInjected.Address(RVA = "0x3F4630", Offset = "0x3F3430", VA = "0x1803F4630", Slot = "7")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000545")]
				[Cpp2IlInjected.Address(RVA = "0x540B20", Offset = "0x53F920", VA = "0x180540B20")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F3")]
			public float PeakAmpForFrame
			{
				[Cpp2IlInjected.Token(Token = "0x6000546")]
				[Cpp2IlInjected.Address(RVA = "0x43D800", Offset = "0x43C600", VA = "0x18043D800", Slot = "8")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F4")]
			public float AccumAvgPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x6000547")]
				[Cpp2IlInjected.Address(RVA = "0x17DF4C0", Offset = "0x17DE2C0", VA = "0x1817DF4C0", Slot = "9")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000542")]
			[Cpp2IlInjected.Address(RVA = "0x17DF3C0", Offset = "0x17DE1C0", VA = "0x1817DF3C0")]
			internal LevelMeter(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0x17DF330", Offset = "0x17DE130", VA = "0x1817DF330", Slot = "10")]
			public void ResetAccumAvgPeakAmp()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract T[] Process(T[] buf);

			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		public class LevelMeterFloat : LevelMeter<float>
		{
			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x19FE4D0", Offset = "0x19FD2D0", VA = "0x1819FE4D0")]
			public LevelMeterFloat(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054C")]
			[Cpp2IlInjected.Address(RVA = "0x19FE320", Offset = "0x19FD120", VA = "0x1819FE320", Slot = "11")]
			public override float[] Process(float[] buf)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		public class LevelMeterShort : LevelMeter<short>
		{
			[Cpp2IlInjected.Token(Token = "0x600054D")]
			[Cpp2IlInjected.Address(RVA = "0x19FE700", Offset = "0x19FD500", VA = "0x1819FE700")]
			public LevelMeterShort(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054E")]
			[Cpp2IlInjected.Address(RVA = "0x19FE530", Offset = "0x19FD330", VA = "0x1819FE530", Slot = "11")]
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
				[Cpp2IlInjected.Address(RVA = "0x8045F0", Offset = "0x8033F0", VA = "0x1808045F0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0x17E7230", Offset = "0x17E6030", VA = "0x1817E7230")]
			public VoiceDetectorCalibration(IVoiceDetector voiceDetector, ILevelMeter levelMeter, int samplingRate, int channels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0x17E70B0", Offset = "0x17E5EB0", VA = "0x1817E70B0")]
			public void VoiceDetectorCalibrate(int durationMs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x17E6F50", Offset = "0x17E5D50", VA = "0x1817E6F50", Slot = "4")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600055D")]
			[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x36BA90", Offset = "0x36A890", VA = "0x18036BA90", Slot = "4")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FC")]
			public float Threshold
			{
				[Cpp2IlInjected.Token(Token = "0x6000560")]
				[Cpp2IlInjected.Address(RVA = "0x6501F0", Offset = "0x64EFF0", VA = "0x1806501F0", Slot = "6")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000561")]
				[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0", Slot = "7")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FD")]
			public bool Detected
			{
				[Cpp2IlInjected.Token(Token = "0x6000562")]
				[Cpp2IlInjected.Address(RVA = "0x36BA90", Offset = "0x36A890", VA = "0x18036BA90", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FE")]
			public int ActivityDelayMs
			{
				[Cpp2IlInjected.Token(Token = "0x6000563")]
				[Cpp2IlInjected.Address(RVA = "0x3BCAD0", Offset = "0x3BB8D0", VA = "0x1803BCAD0", Slot = "12")]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000564")]
				[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0", Slot = "13")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FF")]
			public DateTime DetectedTime
			{
				[Cpp2IlInjected.Token(Token = "0x6000565")]
				[Cpp2IlInjected.Address(RVA = "0x37BEA0", Offset = "0x37ACA0", VA = "0x18037BEA0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(DateTime);
				}
				[Cpp2IlInjected.Token(Token = "0x6000566")]
				[Cpp2IlInjected.Address(RVA = "0x359420", Offset = "0x358220", VA = "0x180359420")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action OnDetected
			{
				[Cpp2IlInjected.Token(Token = "0x6000567")]
				[Cpp2IlInjected.Address(RVA = "0x1A10220", Offset = "0x1A0F020", VA = "0x181A10220", Slot = "10")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000568")]
				[Cpp2IlInjected.Address(RVA = "0x1A102C0", Offset = "0x1A0F0C0", VA = "0x181A102C0", Slot = "11")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x37E820", Offset = "0x37D620", VA = "0x18037E820", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600056B")]
				[Cpp2IlInjected.Address(RVA = "0x37E810", Offset = "0x37D610", VA = "0x18037E810", Slot = "7")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000101")]
			public float Threshold
			{
				[Cpp2IlInjected.Token(Token = "0x600056C")]
				[Cpp2IlInjected.Address(RVA = "0x4E2030", Offset = "0x4E0E30", VA = "0x1804E2030", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600056D")]
				[Cpp2IlInjected.Address(RVA = "0x4E2050", Offset = "0x4E0E50", VA = "0x1804E2050", Slot = "9")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000102")]
			public bool Detected
			{
				[Cpp2IlInjected.Token(Token = "0x600056E")]
				[Cpp2IlInjected.Address(RVA = "0x4DD460", Offset = "0x4DC260", VA = "0x1804DD460", Slot = "10")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600056F")]
				[Cpp2IlInjected.Address(RVA = "0x17E78D0", Offset = "0x17E66D0", VA = "0x1817E78D0")]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000103")]
			public DateTime DetectedTime
			{
				[Cpp2IlInjected.Token(Token = "0x6000570")]
				[Cpp2IlInjected.Address(RVA = "0x36D510", Offset = "0x36C310", VA = "0x18036D510", Slot = "11")]
				[CompilerGenerated]
				get
				{
					return default(DateTime);
				}
				[Cpp2IlInjected.Token(Token = "0x6000571")]
				[Cpp2IlInjected.Address(RVA = "0x382DD0", Offset = "0x381BD0", VA = "0x180382DD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000104")]
			public int ActivityDelayMs
			{
				[Cpp2IlInjected.Token(Token = "0x6000572")]
				[Cpp2IlInjected.Address(RVA = "0x367180", Offset = "0x365F80", VA = "0x180367180", Slot = "14")]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000573")]
				[Cpp2IlInjected.Address(RVA = "0x17E7740", Offset = "0x17E6540", VA = "0x1817E7740", Slot = "15")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action OnDetected
			{
				[Cpp2IlInjected.Token(Token = "0x6000574")]
				[Cpp2IlInjected.Address(RVA = "0x17E7480", Offset = "0x17E6280", VA = "0x1817E7480", Slot = "12")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x6000575")]
				[Cpp2IlInjected.Address(RVA = "0x17E7530", Offset = "0x17E6330", VA = "0x1817E7530", Slot = "13")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x17E7290", Offset = "0x17E6090", VA = "0x1817E7290")]
			internal VoiceDetector(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(Slot = "16")]
			public abstract T[] Process(T[] buf);

			[Cpp2IlInjected.Token(Token = "0x6000578")]
			[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		public class VoiceDetectorFloat : VoiceDetector<float>
		{
			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x1A10490", Offset = "0x1A0F290", VA = "0x181A10490")]
			public VoiceDetectorFloat(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057A")]
			[Cpp2IlInjected.Address(RVA = "0x1A10360", Offset = "0x1A0F160", VA = "0x181A10360", Slot = "16")]
			public override float[] Process(float[] buffer)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		public class VoiceDetectorShort : VoiceDetector<short>
		{
			[Cpp2IlInjected.Token(Token = "0x600057B")]
			[Cpp2IlInjected.Address(RVA = "0x1A10640", Offset = "0x1A0F440", VA = "0x181A10640")]
			internal VoiceDetectorShort(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057C")]
			[Cpp2IlInjected.Address(RVA = "0x1A10500", Offset = "0x1A0F300", VA = "0x181A10500", Slot = "16")]
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
				[Cpp2IlInjected.Address(RVA = "0x37BEA0", Offset = "0x37ACA0", VA = "0x18037BEA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600057E")]
				[Cpp2IlInjected.Address(RVA = "0x359420", Offset = "0x358220", VA = "0x180359420")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000106")]
			public IVoiceDetector Detector
			{
				[Cpp2IlInjected.Token(Token = "0x600057F")]
				[Cpp2IlInjected.Address(RVA = "0x359340", Offset = "0x358140", VA = "0x180359340")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000580")]
				[Cpp2IlInjected.Address(RVA = "0x36A8D0", Offset = "0x3696D0", VA = "0x18036A8D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x17E8050", Offset = "0x17E6E50", VA = "0x1817E8050")]
			public VoiceLevelDetectCalibrate(int samplingRate, int channels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0x17E7980", Offset = "0x17E6780", VA = "0x1817E7980")]
			public void Calibrate(int durationMs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0x17E7E60", Offset = "0x17E6C60", VA = "0x1817E7E60", Slot = "4")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0x17E79B0", Offset = "0x17E67B0", VA = "0x1817E79B0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public const float SHORT_TO_NORMALIZED_FLOAT_RATIO = 3.051851E-05f;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0xFF9C20", Offset = "0xFF8A20", VA = "0x180FF9C20")]
		public static void Resample<T>(T[] src, T[] dst, int dstCount, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x19FB590", Offset = "0x19FA390", VA = "0x1819FB590")]
		public static void ResampleAndConvert(short[] src, float[] dst, int dstCount, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x19FB2D0", Offset = "0x19FA0D0", VA = "0x1819FB2D0")]
		public static void ResampleAndConvert(float[] src, short[] dst, int dstCount, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x19FB250", Offset = "0x19FA050", VA = "0x1819FB250")]
		public static void Convert(float[] src, short[] dst, int dstCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x19FB1C0", Offset = "0x19F9FC0", VA = "0x1819FB1C0")]
		public static void Convert(short[] src, float[] dst, int dstCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0xFF9B10", Offset = "0xFF8910", VA = "0x180FF9B10")]
		public static void ForceToStereo<T>(T[] src, T[] dst, int srcChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0xFFA350", Offset = "0xFF9150", VA = "0x180FFA350")]
		internal static string tostr<T>(T[] x, int lim = 10)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public interface IAudioOut
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool IsPlaying
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		int CurrentBufferLag
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Start(int frequency, int channels, int frameSamplesPerChannel, int playDelayMs);

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Stop();

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnAudioFrame(float[] frame);

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Service();

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void Pause();
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public abstract class ObjectPool<TType, TInfo> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		protected int capacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		protected TInfo info;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private TType[] freeObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		protected int pos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		protected string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private bool inited;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		internal string LogPrefix
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x12C8520", Offset = "0x12C7320", VA = "0x1812C8520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public TInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x382E00", Offset = "0x381C00", VA = "0x180382E00")]
			get
			{
				return (TInfo)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract TType createObject(TInfo info);

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void destroyObject(TType obj);

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract bool infosMatch(TInfo i0, TInfo i1);

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x12C83A0", Offset = "0x12C71A0", VA = "0x1812C83A0")]
		public ObjectPool(int capacity, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x12C8410", Offset = "0x12C7210", VA = "0x1812C8410")]
		public ObjectPool(int capacity, string name, TInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x12C7B90", Offset = "0x12C6990", VA = "0x1812C7B90")]
		public void Init(TInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x12C74E0", Offset = "0x12C62E0", VA = "0x1812C74E0")]
		public TType AcquireOrCreate()
		{
			return (TType)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x12C76C0", Offset = "0x12C64C0", VA = "0x1812C76C0")]
		public TType AcquireOrCreate(TInfo info)
		{
			return (TType)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x12C8170", Offset = "0x12C6F70", VA = "0x1812C8170", Slot = "8")]
		public virtual bool Release(TType obj, TInfo objInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x12C7FF0", Offset = "0x12C6DF0", VA = "0x1812C7FF0", Slot = "9")]
		public virtual bool Release(TType obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x12C7900", Offset = "0x12C6700", VA = "0x1812C7900", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class PrimitiveArrayPool<T> : ObjectPool<T[], int>
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x12C85C0", Offset = "0x12C73C0", VA = "0x1812C85C0")]
		public PrimitiveArrayPool(int capacity, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x12C85F0", Offset = "0x12C73F0", VA = "0x1812C85F0")]
		public PrimitiveArrayPool(int capacity, string name, int info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x12C8620", Offset = "0x12C7420", VA = "0x1812C8620", Slot = "5")]
		protected override T[] createObject(int info)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0", Slot = "6")]
		protected override void destroyObject(T[] obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x876940", Offset = "0x875740", VA = "0x180876940", Slot = "7")]
		protected override bool infosMatch(int i0, int i1)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class ImageBufferNativePool<T> : ObjectPool<T, ImageBufferInfo> where T : ImageBufferNative
	{
		[Cpp2IlInjected.Token(Token = "0x20000FC")]
		public delegate T Factory(ImageBufferNativePool<T> pool, ImageBufferInfo info);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private Factory factory;

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x17DCF30", Offset = "0x17DBD30", VA = "0x1817DCF30")]
		public ImageBufferNativePool(int capacity, Factory factory, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x17DCF80", Offset = "0x17DBD80", VA = "0x1817DCF80")]
		public ImageBufferNativePool(int capacity, Factory factory, string name, ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x17DCFE0", Offset = "0x17DBDE0", VA = "0x1817DCFE0", Slot = "5")]
		protected override T createObject(ImageBufferInfo info)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x17DD020", Offset = "0x17DBE20", VA = "0x1817DD020", Slot = "6")]
		protected override void destroyObject(T obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x17DD050", Offset = "0x17DBE50", VA = "0x1817DD050", Slot = "7")]
		protected override bool infosMatch(ImageBufferInfo i0, ImageBufferInfo i1)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
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
			[Cpp2IlInjected.Address(RVA = "0x19FCB90", Offset = "0x19FB990", VA = "0x1819FCB90")]
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
			[Cpp2IlInjected.Address(RVA = "0x12BC740", Offset = "0x12BB540", VA = "0x1812BC740")]
			protected Encoder(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0x12BC400", Offset = "0x12BB200", VA = "0x1812BC400", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x19FCFF0", Offset = "0x19FBDF0", VA = "0x1819FCFF0")]
			internal EncoderFloat(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600058E")]
			[Cpp2IlInjected.Address(RVA = "0x19FCDF0", Offset = "0x19FBBF0", VA = "0x1819FCDF0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x19FD260", Offset = "0x19FC060", VA = "0x1819FD260")]
			internal EncoderShort(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0x19FD060", Offset = "0x19FBE60", VA = "0x1819FD060", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x19FC020", Offset = "0x19FAE20", VA = "0x1819FC020", Slot = "7")]
			public void Open(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0x19FBF70", Offset = "0x19FAD70", VA = "0x1819FBF70", Slot = "4")]
			public byte[] DecodeToByte(byte[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000595")]
			[Cpp2IlInjected.Address(RVA = "0x19FBFC0", Offset = "0x19FADC0", VA = "0x1819FBFC0", Slot = "5")]
			public float[] DecodeToFloat(byte[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x19FBFE0", Offset = "0x19FADE0", VA = "0x1819FBFE0", Slot = "6")]
			public short[] DecodeToShort(byte[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x19FC000", Offset = "0x19FAE00", VA = "0x1819FC000", Slot = "8")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000598")]
			[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
			public Decoder()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000103")]
		public class Util
		{
			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0x1A0FFC0", Offset = "0x1A0EDC0", VA = "0x181A0FFC0")]
			internal static int bestEncoderSampleRate(int f)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
			public Util()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
		public OpusCodec()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
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
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private bool _AEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private int _AECPlaybackDelayMs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private bool _AECLatencyDetect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private int frameSamples;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private int samplingRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private int channels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private int playDelayFrames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private int playDelayMaxFrames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private IntPtr stEcho;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private IntPtr st;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private short[] resultBuf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private PrimitiveArrayPool<short> playbackBufPool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private Queue<short[]> playBufQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private Framer<float> playFramer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private int playSamplingRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private int playChannels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private ILogger logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private Func<long> clockMs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private AudioUtil.VoiceLevelDetectCalibrate<float> detectPlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private AudioUtil.VoiceLevelDetectCalibrate<short> detectPlayCorr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private AudioUtil.VoiceLevelDetectCalibrate<short> detectRec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private long detectTimePlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private long detectTimePlayDelayed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private long detectTimeRec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private int frameCntRec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private int frameCntPlay;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool AEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x37E820", Offset = "0x37D620", VA = "0x18037E820")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x16BF190", Offset = "0x16BDF90", VA = "0x1816BF190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public int AECFilterLengthMs
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x382E00", Offset = "0x381C00", VA = "0x180382E00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x382E20", Offset = "0x381C20", VA = "0x180382E20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public int AECPlaybackDelayMs
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x382DE0", Offset = "0x381BE0", VA = "0x180382DE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x16BF170", Offset = "0x16BDF70", VA = "0x1816BF170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int AECurrentPlayDelayFrames
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x16BF070", Offset = "0x16BDE70", VA = "0x1816BF070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool AECLatencyDetect
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x3FF320", Offset = "0x3FE120", VA = "0x1803FF320")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x16BF150", Offset = "0x16BDF50", VA = "0x1816BF150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public AECLatencyResultType AECLatencyResult
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x16BEF40", Offset = "0x16BDD40", VA = "0x1816BEF40")]
			get
			{
				return default(AECLatencyResultType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool Denoise
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x16BF120", Offset = "0x16BDF20", VA = "0x1816BF120")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x16BF250", Offset = "0x16BE050", VA = "0x1816BF250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool AGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x16BF0F0", Offset = "0x16BDEF0", VA = "0x1816BF0F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x16BF220", Offset = "0x16BE020", VA = "0x1816BF220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public float AGCLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x16BF0C0", Offset = "0x16BDEC0", VA = "0x1816BF0C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x16BF1F0", Offset = "0x16BDFF0", VA = "0x1816BF1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x16BEA20", Offset = "0x16BD820", VA = "0x1816BEA20")]
		public void ResetAEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x16BCF40", Offset = "0x16BBD40", VA = "0x1816BCF40")]
		public void AECLatecnyDetectCaliberate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x16BF280", Offset = "0x16BE080", VA = "0x1816BF280")]
		private void set(int param, bool val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x16BF2B0", Offset = "0x16BE0B0", VA = "0x1816BF2B0")]
		private void set(int param, float val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x16BEEE0", Offset = "0x16BDCE0", VA = "0x1816BEEE0")]
		private bool getBool(int param)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x16BEF10", Offset = "0x16BDD10", VA = "0x1816BEF10")]
		private float getFloat(int param)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x16BEBC0", Offset = "0x16BD9C0", VA = "0x1816BEBC0")]
		public SpeexProcessor(ILogger logger, Func<long> clockMs, int frameSize, int samplingRate, int channels, int playSamplingRate, int playChannels, int playBufSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x16BDB70", Offset = "0x16BC970", VA = "0x1816BDB70")]
		private void InitLatencyDetect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x16BD240", Offset = "0x16BC040", VA = "0x1816BD240")]
		public void InitAEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x16BDD70", Offset = "0x16BCB70", VA = "0x1816BDD70")]
		private void InitPlayDelay(int ms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x16BE5A0", Offset = "0x16BD3A0", VA = "0x1816BE5A0", Slot = "4")]
		public short[] Process(short[] buf)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x16BDE30", Offset = "0x16BCC30", VA = "0x1816BDE30")]
		public void OnAudioOutFrame(float[] data, int outChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0")]
		public void PrintInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x16BCFD0", Offset = "0x16BBDD0", VA = "0x1816BCFD0")]
		private void DestroyEchoState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x16BD0C0", Offset = "0x16BBEC0", VA = "0x1816BD0C0", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class SpeexLib
	{
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private const string lib_name = "libspeexdsp";

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public const int SPEEX_PREPROCESS_SET_DENOISE = 0;

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public const int SPEEX_PREPROCESS_GET_DENOISE = 1;

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public const int SPEEX_PREPROCESS_SET_AGC = 2;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public const int SPEEX_PREPROCESS_GET_AGC = 3;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public const int SPEEX_PREPROCESS_SET_VAD = 4;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public const int SPEEX_PREPROCESS_GET_VAD = 5;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int SPEEX_PREPROCESS_SET_AGC_LEVEL = 6;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const int SPEEX_PREPROCESS_GET_AGC_LEVEL = 7;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB = 8;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB = 9;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB_LEVEL = 10;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB_LEVEL = 11;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB_DECAY = 12;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB_DECAY = 13;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public const int SPEEX_PREPROCESS_SET_PROB_START = 14;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public const int SPEEX_PREPROCESS_GET_PROB_START = 15;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public const int SPEEX_PREPROCESS_SET_PROB_CONTINUE = 16;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public const int SPEEX_PREPROCESS_GET_PROB_CONTINUE = 17;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public const int SPEEX_PREPROCESS_SET_NOISE_SUPPRESS = 18;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public const int SPEEX_PREPROCESS_GET_NOISE_SUPPRESS = 19;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public const int SPEEX_PREPROCESS_SET_ECHO_SUPPRESS = 20;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public const int SPEEX_PREPROCESS_GET_ECHO_SUPPRESS = 21;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public const int SPEEX_PREPROCESS_SET_ECHO_SUPPRESS_ACTIVE = 22;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public const int SPEEX_PREPROCESS_GET_ECHO_SUPPRESS_ACTIVE = 23;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public const int SPEEX_PREPROCESS_SET_ECHO_STATE = 24;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public const int SPEEX_PREPROCESS_GET_ECHO_STATE = 25;

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public const int SPEEX_PREPROCESS_SET_AGC_INCREMENT = 26;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public const int SPEEX_PREPROCESS_GET_AGC_INCREMENT = 27;

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public const int SPEEX_PREPROCESS_SET_AGC_DECREMENT = 28;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public const int SPEEX_PREPROCESS_GET_AGC_DECREMENT = 29;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public const int SPEEX_PREPROCESS_SET_AGC_MAX_GAIN = 30;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public const int SPEEX_PREPROCESS_GET_AGC_MAX_GAIN = 31;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public const int SPEEX_PREPROCESS_GET_AGC_LOUDNESS = 33;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public const int SPEEX_PREPROCESS_GET_AGC_GAIN = 35;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public const int SPEEX_PREPROCESS_GET_PSD_SIZE = 37;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public const int SPEEX_PREPROCESS_GET_PSD = 39;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public const int SPEEX_PREPROCESS_GET_NOISE_PSD_SIZE = 41;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public const int SPEEX_PREPROCESS_GET_NOISE_PSD = 43;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public const int SPEEX_PREPROCESS_GET_PROB = 45;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public const int SPEEX_PREPROCESS_SET_AGC_TARGET = 46;

		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public const int SPEEX_PREPROCESS_GET_AGC_TARGET = 47;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public const int SPEEX_ECHO_GET_FRAME_SIZE = 3;

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public const int SPEEX_ECHO_SET_SAMPLING_RATE = 24;

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public const int SPEEX_ECHO_GET_SAMPLING_RATE = 25;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public const int SPEEX_ECHO_GET_IMPULSE_RESPONSE_SIZE = 27;

		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public const int SPEEX_ECHO_GET_IMPULSE_RESPONSE = 29;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x16BCEA0", Offset = "0x16BBCA0", VA = "0x1816BCEA0")]
		public static extern IntPtr speex_preprocess_state_init(int frame_size, int sampling_rate);

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x16BCE10", Offset = "0x16BBC10", VA = "0x1816BCE10")]
		public static extern void speex_preprocess_state_destroy(IntPtr st);

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x16BCD60", Offset = "0x16BBB60", VA = "0x1816BCD60")]
		public static extern int speex_preprocess_run(IntPtr st, short[] x);

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x16BCA50", Offset = "0x16BB850", VA = "0x1816BCA50")]
		public static extern int speex_preprocess_ctl(IntPtr st, int request, IntPtr ptr);

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x16BCC20", Offset = "0x16BBA20", VA = "0x1816BCC20")]
		public static int speex_preprocess_ctl(IntPtr st, int request, ref int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x16BCB00", Offset = "0x16BB900", VA = "0x1816BCB00")]
		public static int speex_preprocess_ctl(IntPtr st, int request, ref float value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x16BC860", Offset = "0x16BB660", VA = "0x1816BC860")]
		public static extern IntPtr speex_echo_state_init(int frame_size, int filter_length);

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x16BC900", Offset = "0x16BB700", VA = "0x1816BC900")]
		public static extern IntPtr speex_echo_state_init_mc(int frame_size, int filter_length, int nb_mic, int nb_speakers);

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x16BC7D0", Offset = "0x16BB5D0", VA = "0x1816BC7D0")]
		public static extern void speex_echo_state_destroy(IntPtr st);

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x16BC230", Offset = "0x16BB030", VA = "0x1816BC230")]
		public static extern void speex_echo_cancellation(IntPtr st, short[] rec, short[] play, short[] outBuf);

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x16BC310", Offset = "0x16BB110", VA = "0x1816BC310")]
		public static extern void speex_echo_capture(IntPtr st, short[] rec, short[] outBuf);

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x16BC720", Offset = "0x16BB520", VA = "0x1816BC720")]
		public static extern void speex_echo_playback(IntPtr st, short[] play);

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x16BC9C0", Offset = "0x16BB7C0", VA = "0x1816BC9C0")]
		public static extern void speex_echo_state_reset(IntPtr st);

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x16BC3E0", Offset = "0x16BB1E0", VA = "0x1816BC3E0")]
		public static extern int speex_echo_ctl(IntPtr st, int request, IntPtr ptr);

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x16BC5E0", Offset = "0x16BB3E0", VA = "0x1816BC5E0")]
		public static int speex_echo_ctl(IntPtr st, int request, ref int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x16BC490", Offset = "0x16BB290", VA = "0x1816BC490")]
		public static int speex_echo_ctl(IntPtr st, int request, ref float value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
		public SpeexLib()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public interface IDataReader<T> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Read(T[] buffer);
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public interface IServiceable
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Service(LocalVoice localVoice);
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class LocalVoice : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public const int DATA_POOL_CAPACITY = 50;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private bool debugEchoMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		internal VoiceInfo info;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		protected IEncoder encoder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		internal byte id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		internal int channelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		internal byte evNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		protected VoiceClient voiceClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		protected bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		protected object disposeLock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private int noTransmitCnt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		internal Dictionary<byte, int> eventTimestamps;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public byte Group
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x37E820", Offset = "0x37D620", VA = "0x18037E820")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x37E810", Offset = "0x37D610", VA = "0x18037E810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public VoiceInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x1A098B0", Offset = "0x1A086B0", VA = "0x181A098B0")]
			get
			{
				return default(VoiceInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public bool Transmit
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x4E2730", Offset = "0x4E1530", VA = "0x1804E2730")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x4E2720", Offset = "0x4E1520", VA = "0x1804E2720")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool IsTransmitting
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x4E2740", Offset = "0x4E1540", VA = "0x1804E2740")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x4E2760", Offset = "0x4E1560", VA = "0x1804E2760")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public int FramesSent
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x382E00", Offset = "0x381C00", VA = "0x180382E00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x382E20", Offset = "0x381C20", VA = "0x180382E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public int FramesSentBytes
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x382DE0", Offset = "0x381BE0", VA = "0x180382DE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x382F00", Offset = "0x381D00", VA = "0x180382F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool Reliable
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x3FF320", Offset = "0x3FE120", VA = "0x1803FF320")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x4E2770", Offset = "0x4E1570", VA = "0x1804E2770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool Encrypt
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x5A5560", Offset = "0x5A4360", VA = "0x1805A5560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x5A5770", Offset = "0x5A4570", VA = "0x1805A5770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public object LocalUserObject
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x36D510", Offset = "0x36C310", VA = "0x18036D510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x382DD0", Offset = "0x381BD0", VA = "0x180382DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public IServiceable LocalUserServiceable
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x382CF0", Offset = "0x381AF0", VA = "0x180382CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x382C40", Offset = "0x381A40", VA = "0x180382C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool DebugEchoMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x3F9040", Offset = "0x3F7E40", VA = "0x1803F9040")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x1A09F90", Offset = "0x1A08D90", VA = "0x181A09F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		internal string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x1A09920", Offset = "0x1A08720", VA = "0x181A09920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		internal string LogPrefix
		{
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x1A098D0", Offset = "0x1A086D0", VA = "0x181A098D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x1A09820", Offset = "0x1A08620", VA = "0x181A09820")]
		internal LocalVoice()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x1A09730", Offset = "0x1A08530", VA = "0x181A09730")]
		internal LocalVoice(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x1A09B20", Offset = "0x1A08920", VA = "0x181A09B20")]
		protected void resetNoTransmitCnt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x1A09CC0", Offset = "0x1A08AC0", VA = "0x181A09CC0", Slot = "5")]
		internal virtual void service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x1A09B30", Offset = "0x1A08930", VA = "0x181A09B30")]
		internal void sendFrame(ArraySegment<byte> compressed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x1A09700", Offset = "0x1A08500", VA = "0x181A09700")]
		public void RemoveSelf()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x1A09690", Offset = "0x1A08490", VA = "0x181A09690", Slot = "6")]
		public virtual void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct RemoteVoiceOptions
	{
		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Action<byte[]> OnDecodedFrameByteAction
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x136060", Offset = "0x135460", VA = "0x180136060")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0x12AC40", Offset = "0x12A040", VA = "0x18012AC40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Action<float[]> OnDecodedFrameFloatAction
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x1333F0", Offset = "0x1327F0", VA = "0x1801333F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x146400", Offset = "0x145800", VA = "0x180146400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Action<short[]> OnDecodedFrameShortAction
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x1384A0", Offset = "0x1378A0", VA = "0x1801384A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x138490", Offset = "0x137890", VA = "0x180138490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public Action OnRemoteVoiceRemoveAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x14A330", Offset = "0x149730", VA = "0x18014A330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x14A350", Offset = "0x149750", VA = "0x18014A350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public object LocalUserObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x16B600", Offset = "0x16AA00", VA = "0x18016B600")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x208940", Offset = "0x207D40", VA = "0x180208940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public IDecoder Decoder
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x1637F0", Offset = "0x162BF0", VA = "0x1801637F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x208930", Offset = "0x207D30", VA = "0x180208930")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	internal class RemoteVoice : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		internal RemoteVoiceOptions options;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private int channelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private byte voiceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private object disposeLock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		internal byte lastEvNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private VoiceClient voiceClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private Queue<byte[]> frameQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private AutoResetEvent frameQueueReady;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		internal VoiceInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0xE22110", Offset = "0xE20F10", VA = "0x180E22110")]
			[CompilerGenerated]
			get
			{
				return default(VoiceInfo);
			}
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x16BBE90", Offset = "0x16BAC90", VA = "0x1816BBE90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		protected string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x1A0CA30", Offset = "0x1A0B830", VA = "0x181A0CA30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		protected string LogPrefix
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x1A0C9E0", Offset = "0x1A0B7E0", VA = "0x181A0C9E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x1A0B860", Offset = "0x1A0A660", VA = "0x181A0B860")]
		internal RemoteVoice(VoiceClient client, RemoteVoiceOptions options, int channelId, int playerId, byte voiceId, VoiceInfo info, byte lastEventNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x1A0BAF0", Offset = "0x1A0A8F0", VA = "0x181A0BAF0")]
		private static byte byteDiff(byte latest, byte last)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x1A0CD10", Offset = "0x1A0BB10", VA = "0x181A0CD10")]
		internal void receiveBytes(byte[] receivedBytes, byte evNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x1A0D230", Offset = "0x1A0C030", VA = "0x181A0D230")]
		private void receiveFrame(byte[] frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x1A0D410", Offset = "0x1A0C210", VA = "0x181A0D410")]
		private void receiveNullFrames(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x1A0C330", Offset = "0x1A0B130", VA = "0x181A0C330")]
		private void decodeThread(IDecoder decoder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x1A0C120", Offset = "0x1A0AF20", VA = "0x181A0C120")]
		private void decodeFrame(IDecoder decoder, byte[] frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x1A0BB00", Offset = "0x1A0A900", VA = "0x181A0BB00")]
		internal byte[] decodeFrameToByte(byte[] buffer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1A0BF10", Offset = "0x1A0AD10", VA = "0x181A0BF10")]
		internal short[] decodeFrameToShort(byte[] buffer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1A0BD00", Offset = "0x1A0AB00", VA = "0x181A0BD00")]
		internal float[] decodeFrameToFloat(byte[] buffer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1A0D600", Offset = "0x1A0C400", VA = "0x181A0D600")]
		internal void removeAndDispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x1A0B740", Offset = "0x1A0A540", VA = "0x181A0B740", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public interface IAudioSource : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		int SamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		int Channels
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public interface IAudioReader<T> : IDataReader<T>, IDisposable, IAudioSource
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public interface IAudioPusher<T> : IAudioSource, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetCallback(Action<T[]> callback, LocalVoice localVoice);
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public interface ILocalVoiceAudio
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		AudioUtil.IVoiceDetector VoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		AudioUtil.ILevelMeter LevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		bool VoiceDetectorCalibrating
		{
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VoiceDetectorCalibrate(int durationMs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public static class LocalVoiceAudio
	{
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public static LocalVoiceAudioDummy Dummy;

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x12537A0", Offset = "0x12525A0", VA = "0x1812537A0")]
		public static LocalVoiceAudio<T> Create<T>(VoiceClient voiceClient, byte voiceId, IEncoder encoder, VoiceInfo voiceInfo, int channelId)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public abstract class LocalVoiceAudio<T> : LocalVoiceFramed<T>, ILocalVoiceAudio
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		protected AudioUtil.VoiceDetector<T> voiceDetector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		protected AudioUtil.VoiceDetectorCalibration<T> voiceDetectorCalibration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		protected AudioUtil.LevelMeter<T> levelMeter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		protected int channels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		protected int sourceSamplingRateHz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		protected bool resampleSource;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public virtual AudioUtil.IVoiceDetector VoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x376EC0", Offset = "0x375CC0", VA = "0x180376EC0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public virtual AudioUtil.ILevelMeter LevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x4981C0", Offset = "0x496FC0", VA = "0x1804981C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool VoiceDetectorCalibrating
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x17E0520", Offset = "0x17DF320", VA = "0x1817E0520", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x17DF500", Offset = "0x17DE300", VA = "0x1817DF500", Slot = "10")]
		public void VoiceDetectorCalibrate(int durationMs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x17DFFD0", Offset = "0x17DEDD0", VA = "0x1817DFFD0")]
		internal LocalVoiceAudio(VoiceClient voiceClient, IEncoderDataFlow<T> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x17E0550", Offset = "0x17DF350", VA = "0x1817E0550")]
		protected void initBuiltinProcessors()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class LocalVoiceAudioDummy : LocalVoice, ILocalVoiceAudio
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private AudioUtil.VoiceDetectorDummy voiceDetector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private AudioUtil.LevelMetterDummy levelMeter;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public AudioUtil.IVoiceDetector VoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x413C00", Offset = "0x412A00", VA = "0x180413C00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public AudioUtil.ILevelMeter LevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x3C4690", Offset = "0x3C3490", VA = "0x1803C4690", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public bool VoiceDetectorCalibrating
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x36BA90", Offset = "0x36A890", VA = "0x18036BA90", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0", Slot = "10")]
		public void VoiceDetectorCalibrate(int durationMs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x1A08100", Offset = "0x1A06F00", VA = "0x181A08100")]
		public LocalVoiceAudioDummy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class LocalVoiceAudioFloat : LocalVoiceAudio<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x1A081E0", Offset = "0x1A06FE0", VA = "0x181A081E0")]
		internal LocalVoiceAudioFloat(VoiceClient voiceClient, IEncoderDataFlow<float> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class LocalVoiceAudioShort : LocalVoiceAudio<short>
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x1A08380", Offset = "0x1A07180", VA = "0x181A08380")]
		internal LocalVoiceAudioShort(VoiceClient voiceClient, IEncoderDataFlow<short> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	internal enum EventSubcode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		VoiceInfo = 1,
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		VoiceRemove,
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		Frame
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	internal enum EventParam : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		VoiceId = 1,
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		SamplingRate = 2,
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		Channels = 3,
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		FrameDurationUs = 4,
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		Bitrate = 5,
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		UserData = 10,
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		EventNumber = 11,
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		Codec = 12
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public interface ILogger
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LogError(string fmt, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LogWarning(string fmt, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LogInfo(string fmt, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LogDebug(string fmt, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	internal interface IVoiceFrontend : ILogger
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int AssignChannel(VoiceInfo v);

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool IsChannelJoined(int channelId);

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId);

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId);

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice);

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		string ChannelIdStr(int channelId);

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "6")]
		string PlayerIdStr(int playerId);

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void SetDebugEchoMode(LocalVoice v);
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
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
				[Cpp2IlInjected.Address(RVA = "0x359340", Offset = "0x358140", VA = "0x180359340", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x359340", Offset = "0x358140", VA = "0x180359340", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x895540", Offset = "0x894340", VA = "0x180895540")]
			[DebuggerHidden]
			public <get_RemoteVoiceInfos>d__39(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0x16C3BF0", Offset = "0x16C29F0", VA = "0x1816C3BF0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0x16C36C0", Offset = "0x16C24C0", VA = "0x1816C36C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x16C3D60", Offset = "0x16C2B60", VA = "0x1816C3D60")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x16C3DA0", Offset = "0x16C2BA0", VA = "0x1816C3DA0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x16C3DE0", Offset = "0x16C2BE0", VA = "0x1816C3DE0")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x16C3BA0", Offset = "0x16C29A0", VA = "0x1816C3BA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x16C3B00", Offset = "0x16C2900", VA = "0x1816C3B00", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<RemoteVoiceInfo> IEnumerable<RemoteVoiceInfo>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x16C3B00", Offset = "0x16C2900", VA = "0x1816C3B00", Slot = "5")]
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
				[Cpp2IlInjected.Address(RVA = "0x359340", Offset = "0x358140", VA = "0x180359340", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x359340", Offset = "0x358140", VA = "0x180359340", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x895540", Offset = "0x894340", VA = "0x180895540")]
			[DebuggerHidden]
			public <get_RemoteVoiceLocalUserObjects>d__41(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x16C4280", Offset = "0x16C3080", VA = "0x1816C4280", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x16C3E30", Offset = "0x16C2C30", VA = "0x1816C3E30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0x16C43F0", Offset = "0x16C31F0", VA = "0x1816C43F0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x16C4430", Offset = "0x16C3230", VA = "0x1816C4430")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0x16C4470", Offset = "0x16C3270", VA = "0x1816C4470")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x16C4230", Offset = "0x16C3030", VA = "0x1816C4230", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x16C4190", Offset = "0x16C2F90", VA = "0x1816C4190", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<object> IEnumerable<object>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x16C4190", Offset = "0x16C2F90", VA = "0x1816C4190", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		internal IVoiceFrontend frontend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private int prevRtt;

		[Cpp2IlInjected.Token(Token = "0x400020A")]
		public const int ChannelAuto = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private byte globalGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private byte voiceIdCnt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private Dictionary<byte, LocalVoice> localVoices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private Dictionary<int, List<LocalVoice>> localVoicesPerChannel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> remoteVoices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private System.Random rnd;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int FramesLost
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x382DE0", Offset = "0x381BE0", VA = "0x180382DE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x382F00", Offset = "0x381D00", VA = "0x180382F00")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public int FramesReceived
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x382F10", Offset = "0x381D10", VA = "0x180382F10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x382DF0", Offset = "0x381BF0", VA = "0x180382DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public int FramesSent
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x16C6EF0", Offset = "0x16C5CF0", VA = "0x1816C6EF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public int FramesSentBytes
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x16C6D50", Offset = "0x16C5B50", VA = "0x1816C6D50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int RoundTripTime
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x382F20", Offset = "0x381D20", VA = "0x180382F20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x382E10", Offset = "0x381C10", VA = "0x180382E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public int RoundTripTimeVariance
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x4B6110", Offset = "0x4B4F10", VA = "0x1804B6110")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x4DD710", Offset = "0x4DC510", VA = "0x1804DD710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool SuppressInfoDuplicateWarning
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x3BBB70", Offset = "0x3BA970", VA = "0x1803BBB70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x3BB980", Offset = "0x3BA780", VA = "0x1803BB980")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public RemoteVoiceInfoDelegate OnRemoteVoiceInfoAction
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x387730", Offset = "0x386530", VA = "0x180387730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x3C4EE0", Offset = "0x3C3CE0", VA = "0x1803C4EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public int DebugLostPercent
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x417760", Offset = "0x416560", VA = "0x180417760")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x417420", Offset = "0x416220", VA = "0x180417420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public IEnumerable<LocalVoice> LocalVoices
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x16C7090", Offset = "0x16C5E90", VA = "0x1816C7090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public IEnumerable<RemoteVoiceInfo> RemoteVoiceInfos
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x16C7130", Offset = "0x16C5F30", VA = "0x1816C7130")]
			[IteratorStateMachine(typeof(<get_RemoteVoiceInfos>d__39))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public IEnumerable<object> RemoteVoiceLocalUserObjects
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x16C71A0", Offset = "0x16C5FA0", VA = "0x1816C71A0")]
			[IteratorStateMachine(typeof(<get_RemoteVoiceLocalUserObjects>d__41))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		internal byte GlobalGroup
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x4C1DC0", Offset = "0x4C0BC0", VA = "0x1804C1DC0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x16C9970", Offset = "0x16C8770", VA = "0x1816C9970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x16C4E00", Offset = "0x16C3C00", VA = "0x1816C4E00")]
		public IEnumerable<LocalVoice> LocalVoicesInChannel(int channelId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x16C5240", Offset = "0x16C4040", VA = "0x1816C5240")]
		internal VoiceClient(IVoiceFrontend frontend)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x16C50B0", Offset = "0x16C3EB0", VA = "0x1816C50B0")]
		public void Service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x16C67F0", Offset = "0x16C55F0", VA = "0x1816C67F0")]
		private LocalVoice createLocalVoice(VoiceInfo voiceInfo, int channelId, Func<byte, int, LocalVoice> voiceFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x16C4780", Offset = "0x16C3580", VA = "0x1816C4780")]
		public LocalVoice CreateLocalVoice(VoiceInfo voiceInfo, int channelId = -1, [Optional] IEncoder encoder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x1261C60", Offset = "0x1260A60", VA = "0x181261C60")]
		public LocalVoiceFramed<T> CreateLocalVoiceFramed<T>(VoiceInfo voiceInfo, int frameSize, int channelId = -1, [Optional] IEncoderDataFlow<T> encoder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x12617E0", Offset = "0x12605E0", VA = "0x1812617E0")]
		public LocalVoiceAudio<T> CreateLocalVoiceAudio<T>(VoiceInfo voiceInfo, int channelId = -1, [Optional] IEncoderDataFlow<T> encoder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x16C6B10", Offset = "0x16C5910", VA = "0x1816C6B10")]
		private byte getNewVoiceId()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x16C5320", Offset = "0x16C4120", VA = "0x1816C5320")]
		private void addVoice(byte newId, int channelId, LocalVoice v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x16C4ED0", Offset = "0x16C3CD0", VA = "0x1816C4ED0")]
		public void RemoveLocalVoice(LocalVoice voice)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x16C9750", Offset = "0x16C8550", VA = "0x1816C9750")]
		internal void sendVoicesInfo(int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x16C9690", Offset = "0x16C8490", VA = "0x1816C9690")]
		internal void sendChannelVoicesInfo(int channelId, int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x16C7AB0", Offset = "0x16C68B0", VA = "0x1816C7AB0")]
		internal void onVoiceEvent(object content0, int channelId, int playerId, int localPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x16C56F0", Offset = "0x16C44F0", VA = "0x1816C56F0")]
		internal object[] buildVoicesInfo(IEnumerable<LocalVoice> voicesToSend, bool logInfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x16C54C0", Offset = "0x16C42C0", VA = "0x1816C54C0")]
		internal object[] buildVoiceRemoveMessage(LocalVoice v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x16C6380", Offset = "0x16C5180", VA = "0x1816C6380")]
		internal void clearRemoteVoices()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x16C6000", Offset = "0x16C4E00", VA = "0x1816C6000")]
		internal void clearRemoteVoicesInChannel(int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x16C7EF0", Offset = "0x16C6CF0", VA = "0x1816C7EF0")]
		private void onVoiceInfo(int channelId, int playerId, object payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x16C8870", Offset = "0x16C7670", VA = "0x1816C8870")]
		private void onVoiceRemove(int channelId, int playerId, object payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x16C7210", Offset = "0x16C6010", VA = "0x1816C7210")]
		private void onFrame(int channelId, int playerId, byte voiceId, byte evNumber, byte[] receivedBytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x16C9520", Offset = "0x16C8320", VA = "0x1816C9520")]
		internal bool removePlayerVoices(int playerId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x16C9300", Offset = "0x16C8100", VA = "0x1816C9300")]
		internal bool removePlayerVoices(int channelId, int playerId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x16C5DC0", Offset = "0x16C4BC0", VA = "0x1816C5DC0")]
		internal string channelStr(int channelId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x16C90C0", Offset = "0x16C7EC0", VA = "0x1816C90C0")]
		internal string playerStr(int playerId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x16C4890", Offset = "0x16C3690", VA = "0x1816C4890", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public interface IEncoder : IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public interface IEncoderDataFlow<T> : IEncoder, IDisposable
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public interface IEncoderDataFlowDirect<T> : IEncoderDataFlow<T>, IEncoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ArraySegment<byte> EncodeAndGetOutput(T[] buf);
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public interface IEncoderNativeImageDirect : IEncoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ArraySegment<byte>> EncodeAndGetOutput(IntPtr[] buf, int width, int height, int[] stride, ImageFormat imageFormat, Rotation rotation, Flip flip);
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public interface IEncoderQueued : IEncoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ArraySegment<byte>> GetOutput();
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public interface IDecoder : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Open(VoiceInfo info);
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public interface IDecoderDirect : IDecoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		byte[] DecodeToByte(byte[] buf);

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float[] DecodeToFloat(byte[] buf);

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(Slot = "2")]
		short[] DecodeToShort(byte[] buf);
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public interface IDecoderQueued : IDecoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Decode(byte[] buf);
	}
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public delegate void OnImageOutputNative(IntPtr buf, int width, int height, int stride);
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public interface IDecoderQueuedOutputImageNative : IDecoderQueued, IDecoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000072")]
		ImageFormat OutputImageFormat
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		Flip OutputImageFlip
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		Func<int, int, IntPtr> OutputImageBufferGetter
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		OnImageOutputNative OnOutputImage
		{
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class UnsupportedSampleTypeException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x16C4700", Offset = "0x16C3500", VA = "0x1816C4700")]
		public UnsupportedSampleTypeException(Type t)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class UnsupportedCodecException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x16C44C0", Offset = "0x16C32C0", VA = "0x1816C44C0")]
		public UnsupportedCodecException(Codec codec, LocalVoice voice)
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum Codec
	{
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		AudioOpus = 11
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public enum ImageFormat
	{
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		I420,
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		YV12,
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		Android420,
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		RGBA,
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		ABGR,
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		BGRA,
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		ARGB
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public enum Rotation
	{
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		Rotate0 = 0,
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		Rotate90 = 90,
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		Rotate180 = 180,
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		Rotate270 = 270
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public enum Flip
	{
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		Vertical,
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		Horizontal
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class ImageBufferInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public int Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x381960", Offset = "0x380760", VA = "0x180381960")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x3818F0", Offset = "0x3806F0", VA = "0x1803818F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public int Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x382E00", Offset = "0x381C00", VA = "0x180382E00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x382E20", Offset = "0x381C20", VA = "0x180382E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int[] Stride
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x359340", Offset = "0x358140", VA = "0x180359340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x36A8D0", Offset = "0x3696D0", VA = "0x18036A8D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public ImageFormat Format
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x382F20", Offset = "0x381D20", VA = "0x180382F20")]
			[CompilerGenerated]
			get
			{
				return default(ImageFormat);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x382E10", Offset = "0x381C10", VA = "0x180382E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Rotation Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x4B6110", Offset = "0x4B4F10", VA = "0x1804B6110")]
			[CompilerGenerated]
			get
			{
				return default(Rotation);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x4DD710", Offset = "0x4DC510", VA = "0x1804DD710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public Flip Flip
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x446DC0", Offset = "0x445BC0", VA = "0x180446DC0")]
			[CompilerGenerated]
			get
			{
				return default(Flip);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x5B1B20", Offset = "0x5B0920", VA = "0x1805B1B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x19FDEE0", Offset = "0x19FCCE0", VA = "0x1819FDEE0")]
		public ImageBufferInfo(int width, int height, int[] stride, ImageFormat format)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class ImageBufferNative
	{
		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public ImageBufferInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x37BEA0", Offset = "0x37ACA0", VA = "0x18037BEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x359420", Offset = "0x358220", VA = "0x180359420")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public IntPtr[] Planes
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x359340", Offset = "0x358140", VA = "0x180359340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x36A8D0", Offset = "0x3696D0", VA = "0x18036A8D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x381630", Offset = "0x380430", VA = "0x180381630")]
		public ImageBufferNative(ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0", Slot = "4")]
		public virtual void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0", Slot = "5")]
		public virtual void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class ImageBufferNativeAlloc : ImageBufferNative, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private ImageBufferNativePool<ImageBufferNativeAlloc> pool;

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x19FE020", Offset = "0x19FCE20", VA = "0x1819FE020")]
		public ImageBufferNativeAlloc(ImageBufferNativePool<ImageBufferNativeAlloc> pool, ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x19FE000", Offset = "0x19FCE00", VA = "0x1819FE000", Slot = "4")]
		public override void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x19FDF30", Offset = "0x19FCD30", VA = "0x1819FDF30", Slot = "5")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class ImageBufferNativeGCHandleSinglePlane : ImageBufferNative, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private GCHandle planeHandle;

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x19FE210", Offset = "0x19FD010", VA = "0x1819FE210")]
		public ImageBufferNativeGCHandleSinglePlane(ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool, ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x19FE160", Offset = "0x19FCF60", VA = "0x1819FE160")]
		public void PinPlane(byte[] plane)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x19FE1D0", Offset = "0x19FCFD0", VA = "0x1819FE1D0", Slot = "4")]
		public override void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0", Slot = "5")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	internal static class VoiceCodec
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x16C9B60", Offset = "0x16C8960", VA = "0x1816C9B60")]
		internal static IEncoder CreateDefaultEncoder(VoiceInfo info, LocalVoice localVoice)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x16C9B00", Offset = "0x16C8900", VA = "0x1816C9B00")]
		internal static IDecoder CreateDefaultDecoder(int channelId, int playerId, byte voiceId, VoiceInfo info)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public enum ProcessorQueue
	{
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		RawSignalReading = 0,
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		GainAdjustment = 100,
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		GainAdjustedSignalReading = 200,
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		Resampling = 300,
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		SignalProcessing = 400,
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		ProcessedSignalReading = 500
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
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
				[Cpp2IlInjected.Address(RVA = "0x359340", Offset = "0x358140", VA = "0x180359340", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x359340", Offset = "0x358140", VA = "0x180359340", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0xECDF30", Offset = "0xECCD30", VA = "0x180ECDF30")]
			[DebuggerHidden]
			public <Frame>d__5(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x3593A0", Offset = "0x3581A0", VA = "0x1803593A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0x17E66D0", Offset = "0x17E54D0", VA = "0x1817E66D0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x17E6990", Offset = "0x17E5790", VA = "0x1817E6990", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0x17E6840", Offset = "0x17E5640", VA = "0x1817E6840", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<T[]> System.Collections.Generic.IEnumerable<T[]>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x10CD200", Offset = "0x10CC000", VA = "0x1810CD200", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private T[] frame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private int sizeofT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private int framePos;

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x17DC690", Offset = "0x17DB490", VA = "0x1817DC690")]
		public Framer(int frameSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x17DC5C0", Offset = "0x17DB3C0", VA = "0x1817DC5C0")]
		public int Count(int bufLen)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x17DC5F0", Offset = "0x17DB3F0", VA = "0x1817DC5F0")]
		[IteratorStateMachine(typeof(Framer<>.<Frame>d__5))]
		public IEnumerable<T[]> Frame(T[] buf)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class LocalVoiceFramed : LocalVoice
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public int FrameSize
		{
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x10EB0D0", Offset = "0x10E9ED0", VA = "0x1810EB0D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x10EB5A0", Offset = "0x10EA3A0", VA = "0x1810EB5A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x1A08640", Offset = "0x1A07440", VA = "0x181A08640")]
		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
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
			[Cpp2IlInjected.Address(RVA = "0x213230", Offset = "0x212630", VA = "0x180213230", Slot = "4")]
			public int CompareTo(ProcessorEntry other)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private Framer<T> framer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private List<ProcessorEntry> processors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private bool dataEncodeThreadStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private Queue<T[]> pushDataQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private AutoResetEvent pushDataQueueReady;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private PrimitiveArrayPool<T> pushDataBufferPool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private int framesSkipped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private bool exitThread;

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public PrimitiveArrayPool<T> PushDataBufferPool
		{
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x377100", Offset = "0x375F00", VA = "0x180377100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public bool PushDataAsyncReady
		{
			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x17E4DC0", Offset = "0x17E3BC0", VA = "0x1817E4DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x17E50C0", Offset = "0x17E3EC0", VA = "0x1817E50C0")]
		internal T[] processFrame(T[] buf)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x17E0A20", Offset = "0x17DF820", VA = "0x1817E0A20")]
		public void AddProcessor(ProcessorQueue queue, params IProcessor[] newProcessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x17E0F00", Offset = "0x17DFD00", VA = "0x1817E0F00")]
		public void ClearProcessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x17E45E0", Offset = "0x17E33E0", VA = "0x1817E45E0")]
		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x17E2E90", Offset = "0x17E1C90", VA = "0x1817E2E90")]
		public void PushDataAsync(T[] buf)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x17E2130", Offset = "0x17E0F30", VA = "0x1817E2130")]
		private void PushDataAsyncThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x17E3B00", Offset = "0x17E2900", VA = "0x1817E3B00")]
		public void PushData(T[] buf)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x17E1400", Offset = "0x17E0200", VA = "0x1817E1400", Slot = "6")]
		public override void Dispose()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 40)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct VoiceInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public Codec Codec
		{
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x12A910", Offset = "0x129D10", VA = "0x18012A910")]
			[CompilerGenerated]
			get
			{
				return default(Codec);
			}
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x133E20", Offset = "0x133220", VA = "0x180133E20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public int SamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x12A900", Offset = "0x129D00", VA = "0x18012A900")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x133F00", Offset = "0x133300", VA = "0x180133F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public int SourceSamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x130090", Offset = "0x12F490", VA = "0x180130090")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x1987D0", Offset = "0x197BD0", VA = "0x1801987D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int Channels
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x1637B0", Offset = "0x162BB0", VA = "0x1801637B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x2089F0", Offset = "0x207DF0", VA = "0x1802089F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public int FrameDurationUs
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x128C30", Offset = "0x128030", VA = "0x180128C30")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x208A00", Offset = "0x207E00", VA = "0x180208A00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public int Bitrate
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x13C3E0", Offset = "0x13B7E0", VA = "0x18013C3E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x2089E0", Offset = "0x207DE0", VA = "0x1802089E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public object UserData
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x14A330", Offset = "0x149730", VA = "0x18014A330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x14A350", Offset = "0x149750", VA = "0x18014A350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public int FrameDurationSamples
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x208980", Offset = "0x207D80", VA = "0x180208980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public int FrameSize
		{
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x2089B0", Offset = "0x207DB0", VA = "0x1802089B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public int Width
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x16B5D0", Offset = "0x16A9D0", VA = "0x18016B5D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x208A20", Offset = "0x207E20", VA = "0x180208A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public int Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x1659C0", Offset = "0x164DC0", VA = "0x1801659C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x208A10", Offset = "0x207E10", VA = "0x180208A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x16C9C50", Offset = "0x16C8A50", VA = "0x1816C9C50")]
		public static VoiceInfo CreateAudioOpus(SamplingRate samplingRate, int sourceSamplingRate, int channels, OpusCodec.FrameDuration frameDurationUs, int bitrate, [Optional] object userdata)
		{
			return default(VoiceInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x208970", Offset = "0x207D70", VA = "0x180208970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x16C9CB0", Offset = "0x16C8AB0", VA = "0x1816C9CB0")]
		internal static VoiceInfo CreateFromEventPayload(Dictionary<byte, object> h)
		{
			return default(VoiceInfo);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public class RemoteVoiceInfo
	{
		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public VoiceInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0xE22110", Offset = "0xE20F10", VA = "0x180E22110")]
			[CompilerGenerated]
			get
			{
				return default(VoiceInfo);
			}
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x16BBE90", Offset = "0x16BAC90", VA = "0x1816BBE90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public int ChannelId
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x417760", Offset = "0x416560", VA = "0x180417760")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x417420", Offset = "0x416220", VA = "0x180417420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int PlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x3E8080", Offset = "0x3E6E80", VA = "0x1803E8080")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x4F2D20", Offset = "0x4F1B20", VA = "0x1804F2D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public byte VoiceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x4C1DC0", Offset = "0x4C0BC0", VA = "0x1804C1DC0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x5A6800", Offset = "0x5A5600", VA = "0x1805A6800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public object LocalUserObject
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x3765B0", Offset = "0x3753B0", VA = "0x1803765B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x3DBF50", Offset = "0x3DAD50", VA = "0x1803DBF50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x16BBE20", Offset = "0x16BAC20", VA = "0x1816BBE20")]
		internal RemoteVoiceInfo(int channelId, int playerId, byte voiceId, VoiceInfo info, object localUserObject)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public abstract class BufferReaderPushAdapterBase<T> : IServiceable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		protected IDataReader<T> reader;

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void Service(LocalVoice localVoice);

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0xED67E0", Offset = "0xED55E0", VA = "0x180ED67E0")]
		public BufferReaderPushAdapterBase(IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x17D77F0", Offset = "0x17D65F0", VA = "0x1817D77F0")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public class BufferReaderPushAdapter<T> : BufferReaderPushAdapterBase<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		protected T[] buffer;

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x17D79F0", Offset = "0x17D67F0", VA = "0x1817D79F0")]
		public BufferReaderPushAdapter(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x17D7840", Offset = "0x17D6640", VA = "0x1817D7840", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public class BufferReaderPushAdapterAsyncPool<T> : BufferReaderPushAdapterBase<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x17D7720", Offset = "0x17D6520", VA = "0x1817D7720")]
		public BufferReaderPushAdapterAsyncPool(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x17D7510", Offset = "0x17D6310", VA = "0x1817D7510", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class BufferReaderPushAdapterAsyncPoolCopy<T> : BufferReaderPushAdapterBase<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		protected T[] buffer;

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x17D7410", Offset = "0x17D6210", VA = "0x1817D7410")]
		public BufferReaderPushAdapterAsyncPoolCopy(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x17D7240", Offset = "0x17D6040", VA = "0x1817D7240", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class BufferReaderPushAdapterAsyncPoolFloatToShort : BufferReaderPushAdapterBase<float>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private float[] buffer;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x19FBD90", Offset = "0x19FAB90", VA = "0x1819FBD90")]
		public BufferReaderPushAdapterAsyncPoolFloatToShort(LocalVoice localVoice, IDataReader<float> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x19FBB10", Offset = "0x19FA910", VA = "0x1819FBB10", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public class LocalVoiceVideo : LocalVoice
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private bool imageEncodeThreadStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private Queue<ImageBufferNative> pushImageQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private AutoResetEvent pushImageQueueReady;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private bool exitThread;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public int PushImageQueueCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x1A09640", Offset = "0x1A08440", VA = "0x181A09640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x1A09510", Offset = "0x1A08310", VA = "0x181A09510")]
		internal LocalVoiceVideo(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x1A08E10", Offset = "0x1A07C10", VA = "0x181A08E10")]
		public void PushImageAsync(ImageBufferNative buf)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x1A08850", Offset = "0x1A07650", VA = "0x181A08850")]
		private void PushImageAsyncThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x1A090C0", Offset = "0x1A07EC0", VA = "0x181A090C0")]
		public void PushImage(IntPtr[] buf, int width, int height, int[] stride, ImageFormat imageFormat, Rotation rotation = Rotation.Rotate0, Flip flip = Flip.None)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x1A086B0", Offset = "0x1A074B0", VA = "0x181A086B0", Slot = "6")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	internal class VoiceEventCode
	{
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public const byte Code0 = 201;

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x16C9C10", Offset = "0x16C8A10", VA = "0x1816C9C10")]
		public static byte GetCode(int channelID)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x16C9C20", Offset = "0x16C8A20", VA = "0x1816C9C20")]
		public static bool TryGetChannelID(byte evCode, int maxChannels, out byte channelID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
		public VoiceEventCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class LoadBalancingFrontend : LoadBalancingClient, IVoiceFrontend, ILogger, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		protected VoiceClient voiceClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private object sendLock;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public VoiceClient VoiceClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x376FA0", Offset = "0x375DA0", VA = "0x180376FA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public new Action<EventData> OnEventAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x3765C0", Offset = "0x3753C0", VA = "0x1803765C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x61C8F0", Offset = "0x61B6F0", VA = "0x18061C8F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public new Action<ClientState> OnStateChangeAction
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x376970", Offset = "0x375770", VA = "0x180376970")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x430FF0", Offset = "0x42FDF0", VA = "0x180430FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public byte GlobalAudioGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x1A054A0", Offset = "0x1A042A0", VA = "0x181A054A0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x1A05A10", Offset = "0x1A04810", VA = "0x181A05A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x1A04550", Offset = "0x1A03350", VA = "0x181A04550", Slot = "27")]
		public void LogError(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x1A045D0", Offset = "0x1A033D0", VA = "0x181A045D0", Slot = "28")]
		public void LogWarning(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x1A04590", Offset = "0x1A03390", VA = "0x181A04590", Slot = "29")]
		public void LogInfo(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x1A04510", Offset = "0x1A03310", VA = "0x181A04510", Slot = "30")]
		public void LogDebug(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x1A043E0", Offset = "0x1A031E0", VA = "0x181A043E0", Slot = "19")]
		public int AssignChannel(VoiceInfo v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x1A04500", Offset = "0x1A03300", VA = "0x181A04500", Slot = "20")]
		public bool IsChannelJoined(int channelId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x1A05110", Offset = "0x1A03F10", VA = "0x181A05110", Slot = "26")]
		public void SetDebugEchoMode(LocalVoice v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x1A05210", Offset = "0x1A04010", VA = "0x181A05210")]
		public LoadBalancingFrontend(ConnectionProtocol connectionProtocol = ConnectionProtocol.Udp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x1A050D0", Offset = "0x1A03ED0", VA = "0x181A050D0")]
		public new void Service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x1A044A0", Offset = "0x1A032A0", VA = "0x181A044A0", Slot = "32")]
		public virtual bool ChangeAudioGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x1A04D40", Offset = "0x1A03B40", VA = "0x181A04D40", Slot = "21")]
		public void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x1A04610", Offset = "0x1A03410", VA = "0x181A04610")]
		public void SendDebugEchoVoicesInfo(int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x1A04B00", Offset = "0x1A03900", VA = "0x181A04B00", Slot = "22")]
		public void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x1A04770", Offset = "0x1A03570", VA = "0x181A04770", Slot = "23")]
		public void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x3BCAD0", Offset = "0x3BB8D0", VA = "0x1803BCAD0", Slot = "24")]
		public string ChannelIdStr(int channelId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x3BCAD0", Offset = "0x3BB8D0", VA = "0x1803BCAD0", Slot = "25")]
		public string PlayerIdStr(int playerId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x1A054D0", Offset = "0x1A042D0", VA = "0x181A054D0")]
		private void onEventActionVoiceClient(EventData ev)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x1A058A0", Offset = "0x1A046A0", VA = "0x181A058A0")]
		private void onStateChangeVoiceClient(ClientState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x1A057D0", Offset = "0x1A045D0", VA = "0x181A057D0")]
		private void onPlayerLeave(int playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x1A044D0", Offset = "0x1A032D0", VA = "0x181A044D0", Slot = "31")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class AudioInEnumerator : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private const string lib_name = "AudioIn";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private IntPtr handle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public readonly bool IsSupported;

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x19F9F00", Offset = "0x19F8D00", VA = "0x1819F9F00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x19F9900", Offset = "0x19F8700", VA = "0x1819F9900")]
		private static extern IntPtr Photon_Audio_In_CreateMicEnumerator();

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x19F9990", Offset = "0x19F8790", VA = "0x1819F9990")]
		private static extern void Photon_Audio_In_DestroyMicEnumerator(IntPtr handle);

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x19F9A30", Offset = "0x19F8830", VA = "0x1819F9A30")]
		private static extern int Photon_Audio_In_MicEnumerator_Count(IntPtr handle);

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x19F9B80", Offset = "0x19F8980", VA = "0x1819F9B80")]
		private static extern IntPtr Photon_Audio_In_MicEnumerator_NameAtIndex(IntPtr handle, int idx);

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x19F9AD0", Offset = "0x19F88D0", VA = "0x1819F9AD0")]
		private static extern int Photon_Audio_In_MicEnumerator_IDAtIndex(IntPtr handle, int idx);

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x19F9D90", Offset = "0x19F8B90", VA = "0x1819F9D90")]
		public AudioInEnumerator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x19F9C30", Offset = "0x19F8A30", VA = "0x1819F9C30")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x19F9810", Offset = "0x19F8610", VA = "0x1819F9810")]
		public string NameAtIndex(int idx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x19F9750", Offset = "0x19F8550", VA = "0x1819F9750")]
		public int IDAtIndex(int idx)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x19F9800", Offset = "0x19F8600", VA = "0x1819F9800")]
		public bool IDIsValid(int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x19F9670", Offset = "0x19F8470", VA = "0x1819F9670", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
namespace ExitGames.Client.Photon.LoadBalancing
{
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public static class Extensions
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x19FD540", Offset = "0x19FC340", VA = "0x1819FD540")]
		public static void Merge(this IDictionary target, IDictionary addHash)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x19FD2D0", Offset = "0x19FC0D0", VA = "0x1819FD2D0")]
		public static void MergeStringKeys(this IDictionary target, IDictionary addHash)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x19FDCE0", Offset = "0x19FCAE0", VA = "0x1819FDCE0")]
		public static string ToStringFull(this IDictionary origin)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x19FDD40", Offset = "0x19FCB40", VA = "0x1819FDD40")]
		public static string ToStringFull(this object[] data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x19FDA90", Offset = "0x19FC890", VA = "0x1819FDA90")]
		public static Hashtable StripToStringKeys(this IDictionary original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x19FD830", Offset = "0x19FC630", VA = "0x1819FD830")]
		public static void StripKeysWithNullValues(this IDictionary original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0xB5E8D0", Offset = "0xB5D6D0", VA = "0x180B5E8D0")]
		public static bool Contains(this int[] target, int nr)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class FriendInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000097")]
		[Obsolete]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x37BEA0", Offset = "0x37ACA0", VA = "0x18037BEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x37BEA0", Offset = "0x37ACA0", VA = "0x18037BEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x359420", Offset = "0x358220", VA = "0x180359420")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public bool IsOnline
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x4DD460", Offset = "0x4DC260", VA = "0x1804DD460")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x4DD4D0", Offset = "0x4DC2D0", VA = "0x1804DD4D0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public string Room
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x36D510", Offset = "0x36C310", VA = "0x18036D510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x382DD0", Offset = "0x381BD0", VA = "0x180382DD0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public bool IsInRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0xDDB900", Offset = "0xDDA700", VA = "0x180DDB900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x19FDE60", Offset = "0x19FCC60", VA = "0x1819FDE60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
		public FriendInfo()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public enum ClientState
	{
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		PeerCreated = 0,
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		Authenticating = 1,
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		Authenticated = 2,
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		JoinedLobby = 3,
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		DisconnectingFromMasterserver = 4,
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		ConnectingToGameserver = 5,
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		ConnectedToGameserver = 6,
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		Joining = 7,
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		Joined = 8,
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		Leaving = 9,
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		DisconnectingFromGameserver = 10,
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		ConnectingToMasterserver = 11,
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		Disconnecting = 12,
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		Disconnected = 13,
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		ConnectedToMasterserver = 14,
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		[Obsolete]
		ConnectedToMaster = 14,
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		ConnectingToNameServer = 15,
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		ConnectedToNameServer = 16,
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		DisconnectingFromNameServer = 17
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	internal enum JoinType
	{
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		CreateRoom,
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		JoinRoom,
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		JoinRandomRoom,
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		JoinOrCreateRoom
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public enum DisconnectCause
	{
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		DisconnectByServerUserLimit,
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		ExceptionOnConnect,
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		DisconnectByServer,
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		TimeoutDisconnect,
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		Exception,
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		InvalidAuthentication,
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		MaxCcuReached,
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		InvalidRegion,
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		OperationNotAllowedInCurrentState,
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		CustomAuthenticationFailed,
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		DisconnectByServerLogic,
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		AuthenticationTicketExpired
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public enum ServerConnection
	{
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		MasterServer,
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		GameServer,
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		NameServer
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public enum EncryptionMode
	{
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		PayloadEncryption = 0,
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		DatagramEncryption = 10,
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		DatagramEncryptionRandomSequence = 11
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public static class EncryptionDataParameters
	{
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public const byte Mode = 0;

		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public const byte Secret1 = 1;

		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public const byte Secret2 = 2;
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class LoadBalancingClient : IPhotonPeerListener
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public LoadBalancingPeer loadBalancingPeer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public AuthModeOption AuthMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public EncryptionMode EncryptionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private ConnectionProtocol ExpectedProtocol;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public string NameServerHost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public string NameServerHttp;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private ClientState state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private bool inLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private bool autoJoinLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x91")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public bool EnableLobbyStatistics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private List<TypedLobbyInfo> lobbyStatistics;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public Dictionary<string, RoomInfo> RoomInfoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public Room CurrentRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private JoinType lastJoinType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		protected internal EnterRoomParams enterRoomParamsCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private bool didAuthenticate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private string[] friendListRequested;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private int friendListTimestamp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private bool isFetchingFriendList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private byte[] encryptionSecret;

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public string AppVersion
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x359340", Offset = "0x358140", VA = "0x180359340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x36A8D0", Offset = "0x3696D0", VA = "0x18036A8D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public string AppId
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x36D510", Offset = "0x36C310", VA = "0x18036D510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x382DD0", Offset = "0x381BD0", VA = "0x180382DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public AuthenticationValues AuthValues
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x382CF0", Offset = "0x381AF0", VA = "0x180382CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x382C40", Offset = "0x381A40", VA = "0x180382C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public ConnectionProtocol TransportProtocol
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x1A04000", Offset = "0x1A02E00", VA = "0x181A04000")]
			get
			{
				return default(ConnectionProtocol);
			}
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x1A04280", Offset = "0x1A03080", VA = "0x181A04280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x197CB60", Offset = "0x197B960", VA = "0x18197CB60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		private string TokenForInit
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x1A03FE0", Offset = "0x1A02DE0", VA = "0x181A03FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool IsUsingNameServer
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x3FBC80", Offset = "0x3FAA80", VA = "0x1803FBC80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x4E2710", Offset = "0x4E1510", VA = "0x1804E2710")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public string NameServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x1A03E10", Offset = "0x1A02C10", VA = "0x181A03E10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public string CurrentServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x1A03CF0", Offset = "0x1A02AF0", VA = "0x181A03CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public string MasterServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x368AF0", Offset = "0x3678F0", VA = "0x180368AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x3DBF30", Offset = "0x3DAD30", VA = "0x1803DBF30")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public string GameServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x36BAA0", Offset = "0x36A8A0", VA = "0x18036BAA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x38ACC0", Offset = "0x389AC0", VA = "0x18038ACC0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public ServerConnection Server
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x3DBCA0", Offset = "0x3DAAA0", VA = "0x1803DBCA0")]
			[CompilerGenerated]
			get
			{
				return default(ServerConnection);
			}
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x3DBF40", Offset = "0x3DAD40", VA = "0x1803DBF40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public ClientState State
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xAB2D50", Offset = "0xAB1B50", VA = "0x180AB2D50")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x1A04230", Offset = "0x1A03030", VA = "0x181A04230")]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public bool IsConnected
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x1A03DF0", Offset = "0x1A02BF0", VA = "0x181A03DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool IsConnectedAndReady
		{
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x1A03D80", Offset = "0x1A02B80", VA = "0x181A03D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public DisconnectCause DisconnectedCause
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x4222B0", Offset = "0x4210B0", VA = "0x1804222B0")]
			[CompilerGenerated]
			get
			{
				return default(DisconnectCause);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x819B00", Offset = "0x818900", VA = "0x180819B00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public TypedLobby CurrentLobby
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x376BA0", Offset = "0x3759A0", VA = "0x180376BA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x3CB390", Offset = "0x3CA190", VA = "0x1803CB390")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool AutoJoinLobby
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x425FD0", Offset = "0x424DD0", VA = "0x180425FD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x425100", Offset = "0x423F00", VA = "0x180425100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public List<TypedLobbyInfo> LobbyStatistics
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x425FE0", Offset = "0x424DE0", VA = "0x180425FE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x4257D0", Offset = "0x4245D0", VA = "0x1804257D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public Player LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x413C00", Offset = "0x412A00", VA = "0x180413C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x413930", Offset = "0x412730", VA = "0x180413930")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public string NickName
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x1A03FB0", Offset = "0x1A02DB0", VA = "0x181A03FB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x1A04210", Offset = "0x1A03010", VA = "0x181A04210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x1A04020", Offset = "0x1A02E20", VA = "0x181A04020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x1A04360", Offset = "0x1A03160", VA = "0x181A04360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public int PlayersOnMasterCount
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x964440", Offset = "0x963240", VA = "0x180964440")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x963CB0", Offset = "0x962AB0", VA = "0x180963CB0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public int PlayersInRoomsCount
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0xC54030", Offset = "0xC52E30", VA = "0x180C54030")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0xC54BD0", Offset = "0xC539D0", VA = "0x180C54BD0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public int RoomsCount
		{
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x8943A0", Offset = "0x8931A0", VA = "0x1808943A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0xC549B0", Offset = "0xC537B0", VA = "0x180C549B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public List<FriendInfo> FriendList
		{
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x377110", Offset = "0x375F10", VA = "0x180377110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x413C30", Offset = "0x412A30", VA = "0x180413C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public int FriendListAge
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x1A03D10", Offset = "0x1A02B10", VA = "0x181A03D10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		protected bool IsAuthorizeSecretAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x1A03D50", Offset = "0x1A02B50", VA = "0x181A03D50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public string[] AvailableRegions
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x4981C0", Offset = "0x496FC0", VA = "0x1804981C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x59CA40", Offset = "0x59B840", VA = "0x18059CA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public string[] AvailableRegionsServers
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x4981D0", Offset = "0x496FD0", VA = "0x1804981D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x564E90", Offset = "0x563C90", VA = "0x180564E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public string CloudRegion
		{
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x39B0E0", Offset = "0x399EE0", VA = "0x18039B0E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x39A510", Offset = "0x399310", VA = "0x18039A510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState> OnStateChangeAction
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x1A03C50", Offset = "0x1A02A50", VA = "0x181A03C50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x1A04170", Offset = "0x1A02F70", VA = "0x181A04170")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<EventData> OnEventAction
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x1A03B10", Offset = "0x1A02910", VA = "0x181A03B10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x1A04030", Offset = "0x1A02E30", VA = "0x181A04030")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<OperationResponse> OnOpResponseAction
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x1A03BB0", Offset = "0x1A029B0", VA = "0x181A03BB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x1A040D0", Offset = "0x1A02ED0", VA = "0x181A040D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x1A038C0", Offset = "0x1A026C0", VA = "0x181A038C0")]
		public LoadBalancingClient(ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x1A03AC0", Offset = "0x1A028C0", VA = "0x181A03AC0")]
		public LoadBalancingClient(string masterAddress, string appId, string gameVersion, ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x19FF560", Offset = "0x19FE360", VA = "0x1819FF560")]
		private string GetNameServerAddress()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x19FEE00", Offset = "0x19FDC00", VA = "0x1819FEE00")]
		public bool Connect(string masterServerAddress, string appId, string appVersion, string nickName, AuthenticationValues authValues)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x19FED50", Offset = "0x19FDB50", VA = "0x1819FED50", Slot = "8")]
		public virtual bool Connect()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x19FEAD0", Offset = "0x19FD8D0", VA = "0x1819FEAD0")]
		public bool ConnectToNameServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x19FEC00", Offset = "0x19FDA00", VA = "0x1819FEC00")]
		public bool ConnectToRegionMaster(string region)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x19FF250", Offset = "0x19FE050", VA = "0x1819FF250")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x19FE760", Offset = "0x19FD560", VA = "0x1819FE760")]
		private bool CallAuthenticate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x1A034A0", Offset = "0x1A022A0", VA = "0x181A034A0")]
		public void Service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x19FF160", Offset = "0x19FDF60", VA = "0x1819FF160")]
		private void DisconnectToReconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x19FEA30", Offset = "0x19FD830", VA = "0x1819FEA30")]
		private bool ConnectToGameServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x1A01D50", Offset = "0x1A00B50", VA = "0x181A01D50")]
		public bool OpGetRegions()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x1A01A40", Offset = "0x1A00840", VA = "0x181A01A40")]
		public bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x1A01DA0", Offset = "0x1A00BA0", VA = "0x181A01DA0")]
		public bool OpJoinLobby(TypedLobby lobby)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x111E5E0", Offset = "0x111D3E0", VA = "0x18111E5E0")]
		public bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x1A01F60", Offset = "0x1A00D60", VA = "0x181A01F60")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1A021A0", Offset = "0x1A00FA0", VA = "0x181A021A0")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1A02010", Offset = "0x1A00E10", VA = "0x181A02010")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode, TypedLobby lobby, string sqlLobbyFilter, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1A02250", Offset = "0x1A01050", VA = "0x181A02250")]
		public bool OpJoinRoom(string roomName, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1A02580", Offset = "0x1A01380", VA = "0x181A02580")]
		public bool OpReJoinRoom(string roomName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x1A01E50", Offset = "0x1A00C50", VA = "0x181A01E50")]
		public bool OpJoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x1A01930", Offset = "0x1A00730", VA = "0x181A01930")]
		public bool OpCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x1A02350", Offset = "0x1A01150", VA = "0x181A02350")]
		public bool OpLeaveRoom()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x1A023E0", Offset = "0x1A011E0", VA = "0x181A023E0")]
		public bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x1A01D20", Offset = "0x1A00B20", VA = "0x181A01D20")]
		public bool OpGetGameList(TypedLobby typedLobby, string sqlLobbyFilter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x1A02670", Offset = "0x1A01470", VA = "0x181A02670")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x1A02940", Offset = "0x1A01740", VA = "0x181A02940")]
		[Obsolete]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x1A02B80", Offset = "0x1A01980", VA = "0x181A02B80")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x1A029F0", Offset = "0x1A017F0", VA = "0x181A029F0")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x1A02A90", Offset = "0x1A01890", VA = "0x181A02A90")]
		[Obsolete]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x1A02CC0", Offset = "0x1A01AC0", VA = "0x181A02CC0")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x1A02550", Offset = "0x1A01350", VA = "0x181A02550", Slot = "9")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x1A024A0", Offset = "0x1A012A0", VA = "0x181A024A0", Slot = "10")]
		[Obsolete]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x1A01910", Offset = "0x1A00710", VA = "0x181A01910", Slot = "11")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x1A03000", Offset = "0x1A01E00", VA = "0x181A03000")]
		private void ReadoutProperties(Hashtable gameProperties, Hashtable actorProperties, int targetActorNr)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x1A02F00", Offset = "0x1A01D00", VA = "0x181A02F00")]
		private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x19FE820", Offset = "0x19FD620", VA = "0x1819FE820")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x19FE990", Offset = "0x19FD790", VA = "0x1819FE990")]
		private void CleanCachedValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x19FF2D0", Offset = "0x19FE0D0", VA = "0x1819FF2D0")]
		private void GameEnteredOnGameServer(OperationResponse operationResponse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x1A036D0", Offset = "0x1A024D0", VA = "0x181A036D0")]
		private void UpdatedActorList(int[] actorsInGame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x19FEEC0", Offset = "0x19FDCC0", VA = "0x1819FEEC0", Slot = "12")]
		protected internal virtual Player CreatePlayer(string actorName, int actorNumber, bool isLocal, Hashtable actorProperties)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x19FEF50", Offset = "0x19FDD50", VA = "0x1819FEF50", Slot = "13")]
		protected internal virtual Room CreateRoom(string roomName, RoomOptions opt)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x19FF040", Offset = "0x19FDE40", VA = "0x1819FF040", Slot = "14")]
		public virtual void DebugReturn(DebugLevel level, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x1A00320", Offset = "0x19FF120", VA = "0x181A00320", Slot = "15")]
		public virtual void OnOperationResponse(OperationResponse operationResponse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x1A01200", Offset = "0x1A00000", VA = "0x181A01200", Slot = "16")]
		public virtual void OnStatusChanged(StatusCode statusCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x19FF730", Offset = "0x19FE530", VA = "0x1819FF730", Slot = "17")]
		public virtual void OnEvent(EventData photonEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x1A002C0", Offset = "0x19FF0C0", VA = "0x181A002C0", Slot = "18")]
		public virtual void OnMessage(object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1A034C0", Offset = "0x1A022C0", VA = "0x181A034C0")]
		private void SetupEncryption(Dictionary<byte, object> encryptionData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1A02DE0", Offset = "0x1A01BE0", VA = "0x181A02DE0")]
		public bool OpWebRpc(string uriPath, object parameters, bool sendAuthCookie = false)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
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

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		protected internal static Type PingImplementation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private readonly Dictionary<byte, object> opParameters;

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x1A07F70", Offset = "0x1A06D70", VA = "0x181A07F70")]
		public LoadBalancingPeer(ConnectionProtocol protocolType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x1A08010", Offset = "0x1A06E10", VA = "0x181A08010")]
		public LoadBalancingPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1A05B50", Offset = "0x1A04950", VA = "0x181A05B50")]
		[Conditional("UNITY")]
		private void ConfigUnitySockets()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x1A06920", Offset = "0x1A05720", VA = "0x181A06920", Slot = "15")]
		public virtual bool OpGetRegions(string appId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x1A069F0", Offset = "0x1A057F0", VA = "0x181A069F0", Slot = "16")]
		public virtual bool OpJoinLobby([Optional] TypedLobby lobby)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x1A070B0", Offset = "0x1A05EB0", VA = "0x181A070B0", Slot = "17")]
		public virtual bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x1A07B90", Offset = "0x1A06990", VA = "0x181A07B90")]
		private void RoomOptionsToOpParameters(Dictionary<byte, object> op, RoomOptions roomOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x1A06440", Offset = "0x1A05240", VA = "0x181A06440", Slot = "18")]
		public virtual bool OpCreateRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x1A06E00", Offset = "0x1A05C00", VA = "0x181A06E00", Slot = "19")]
		public virtual bool OpJoinRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x1A06B40", Offset = "0x1A05940", VA = "0x181A06B40", Slot = "20")]
		public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x1A07160", Offset = "0x1A05F60", VA = "0x181A07160", Slot = "21")]
		public virtual bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1A06750", Offset = "0x1A05550", VA = "0x181A06750", Slot = "22")]
		public virtual bool OpGetGameList(TypedLobby lobby, string queryData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x1A06680", Offset = "0x1A05480", VA = "0x181A06680", Slot = "23")]
		public virtual bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x1A07520", Offset = "0x1A06320", VA = "0x181A07520")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable actorProperties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x1A075A0", Offset = "0x1A063A0", VA = "0x181A075A0")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x1A07970", Offset = "0x1A06770", VA = "0x181A07970")]
		protected void OpSetPropertyOfRoom(byte propCode, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x1A07560", Offset = "0x1A06360", VA = "0x181A07560")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable gameProperties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x1A077D0", Offset = "0x1A065D0", VA = "0x181A077D0")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x1A06080", Offset = "0x1A04E80", VA = "0x181A06080", Slot = "24")]
		public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x1A05DC0", Offset = "0x1A04BC0", VA = "0x181A05DC0", Slot = "25")]
		public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x1A06310", Offset = "0x1A05110", VA = "0x181A06310", Slot = "26")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x1A07290", Offset = "0x1A06090", VA = "0x181A07290", Slot = "27")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x1A07A30", Offset = "0x1A06830", VA = "0x181A07A30", Slot = "28")]
		public virtual bool OpSettings(bool receiveLobbyStats)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public class OpJoinRandomRoomParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public Hashtable ExpectedCustomRoomProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public byte ExpectedMaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public MatchmakingMode MatchingType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public TypedLobby TypedLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public string SqlLobbyFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public string[] ExpectedUsers;

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
		public OpJoinRandomRoomParams()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public class EnterRoomParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public string RoomName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public RoomOptions RoomOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public TypedLobby Lobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public Hashtable PlayerProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public bool OnGameServer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public bool CreateIfNotExists;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public bool RejoinOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public string[] ExpectedUsers;

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x69F470", Offset = "0x69E270", VA = "0x18069F470")]
		public EnterRoomParams()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public class ErrorCode
	{
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public const int Ok = 0;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public const int OperationNotAllowedInCurrentState = -3;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[Obsolete]
		public const int InvalidOperationCode = -2;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public const int InvalidOperation = -2;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public const int InternalServerError = -1;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public const int InvalidAuthentication = 32767;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public const int GameIdAlreadyExists = 32766;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public const int GameFull = 32765;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public const int GameClosed = 32764;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		[Obsolete]
		public const int AlreadyMatched = 32763;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public const int ServerFull = 32762;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		public const int UserBlocked = 32761;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public const int NoRandomMatchFound = 32760;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public const int GameDoesNotExist = 32758;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public const int MaxCcuReached = 32757;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public const int InvalidRegion = 32756;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public const int CustomAuthenticationFailed = 32755;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public const int AuthenticationTicketExpired = 32753;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public const int PluginReportedError = 32752;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public const int PluginMismatch = 32751;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public const int JoinFailedPeerAlreadyJoined = 32750;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public const int JoinFailedFoundInactiveJoiner = 32749;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public const int JoinFailedWithRejoinerNotFound = 32748;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public const int JoinFailedFoundExcludedUserId = 32747;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public const int JoinFailedFoundActiveJoiner = 32746;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public const int HttpLimitReached = 32745;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public const int ExternalHttpCallFailed = 32744;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public const int SlotError = 32742;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public const int InvalidEncryptionParameters = 32741;

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
		public ErrorCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public class ActorProperties
	{
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public const byte PlayerName = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public const byte IsInactive = 254;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public const byte UserId = 253;

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
		public ActorProperties()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public class GamePropertyKey
	{
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public const byte MaxPlayers = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public const byte IsVisible = 254;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public const byte IsOpen = 253;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public const byte PlayerCount = 252;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public const byte Removed = 251;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public const byte PropsListedInLobby = 250;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public const byte CleanupCacheOnLeave = 249;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public const byte MasterClientId = 248;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public const byte ExpectedUsers = 247;

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
		public GamePropertyKey()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public class EventCode
	{
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public const byte GameList = 230;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public const byte GameListUpdate = 229;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public const byte QueueState = 228;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public const byte Match = 227;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public const byte AppStats = 226;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public const byte LobbyStats = 224;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		[Obsolete]
		public const byte AzureNodeInfo = 210;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public const byte Join = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		public const byte Leave = 254;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public const byte PropertiesChanged = 253;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[Obsolete]
		public const byte SetProperties = 253;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public const byte ErrorInfo = 251;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		public const byte CacheSliceChanged = 250;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public const byte AuthEvent = 223;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
		public EventCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public class ParameterCode
	{
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public const byte SuppressRoomEvents = 237;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public const byte EmptyRoomTTL = 236;

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public const byte PlayerTTL = 235;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public const byte EventForward = 234;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		[Obsolete]
		public const byte IsComingBack = 233;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public const byte IsInactive = 233;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		public const byte CheckUserOnJoin = 232;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public const byte ExpectedValues = 231;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public const byte Address = 230;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public const byte PeerCount = 229;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public const byte GameCount = 228;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public const byte MasterPeerCount = 227;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public const byte UserId = 225;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public const byte ApplicationId = 224;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public const byte Position = 223;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public const byte MatchMakingType = 223;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public const byte GameList = 222;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public const byte Secret = 221;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public const byte AppVersion = 220;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		[Obsolete]
		public const byte AzureNodeInfo = 210;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		[Obsolete]
		public const byte AzureLocalNodeId = 209;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[Obsolete]
		public const byte AzureMasterNodeId = 208;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public const byte RoomName = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public const byte Broadcast = 250;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public const byte ActorList = 252;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public const byte ActorNr = 254;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public const byte PlayerProperties = 249;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public const byte CustomEventContent = 245;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public const byte Data = 245;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public const byte Code = 244;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public const byte GameProperties = 248;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public const byte Properties = 251;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public const byte TargetActorNr = 253;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public const byte ReceiverGroup = 246;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public const byte Cache = 247;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public const byte CleanupCacheOnLeave = 241;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public const byte Group = 240;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public const byte Remove = 239;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public const byte PublishUserId = 239;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public const byte Add = 238;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public const byte Info = 218;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public const byte ClientAuthenticationType = 217;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public const byte ClientAuthenticationParams = 216;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public const byte JoinMode = 215;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public const byte ClientAuthenticationData = 214;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public const byte MasterClientId = 203;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public const byte FindFriendsRequestList = 1;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public const byte FindFriendsResponseOnlineList = 1;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public const byte FindFriendsResponseRoomIdList = 2;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public const byte LobbyName = 213;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public const byte LobbyType = 212;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public const byte LobbyStats = 211;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public const byte Region = 210;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public const byte UriPath = 209;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public const byte WebRpcParameters = 208;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public const byte WebRpcReturnCode = 207;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public const byte WebRpcReturnMessage = 206;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public const byte CacheSliceIndex = 205;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public const byte Plugins = 204;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public const byte NickName = 202;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public const byte PluginName = 201;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public const byte PluginVersion = 200;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public const byte ExpectedProtocol = 195;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public const byte CustomInitData = 194;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public const byte EncryptionMode = 193;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public const byte EncryptionData = 192;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public const byte RoomOptionFlags = 191;

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
		public ParameterCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public class OperationCode
	{
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		[Obsolete]
		public const byte ExchangeKeysForEncryption = 250;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		[Obsolete]
		public const byte Join = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x400034A")]
		public const byte AuthenticateOnce = 231;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		public const byte Authenticate = 230;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public const byte JoinLobby = 229;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public const byte LeaveLobby = 228;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public const byte CreateGame = 227;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public const byte JoinGame = 226;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public const byte JoinRandomGame = 225;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public const byte Leave = 254;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public const byte RaiseEvent = 253;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public const byte SetProperties = 252;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public const byte GetProperties = 251;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public const byte ChangeGroups = 248;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public const byte FindFriends = 222;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public const byte GetLobbyStats = 221;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public const byte GetRegions = 220;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public const byte WebRpc = 219;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public const byte ServerSettings = 218;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public const byte GetGameList = 217;

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x3591A0", Offset = "0x357FA0", VA = "0x1803591A0")]
		public OperationCode()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public enum JoinMode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		CreateIfNotExists,
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		JoinOrRejoin,
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		RejoinOnly
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public enum MatchmakingMode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		FillRoom,
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		SerialMatching,
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		RandomMatching
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public enum ReceiverGroup : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		Others,
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		All,
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		MasterClient
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public enum EventCaching : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		DoNotCache = 0,
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		[Obsolete]
		MergeCache = 1,
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		[Obsolete]
		ReplaceCache = 2,
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		[Obsolete]
		RemoveCache = 3,
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		AddToRoomCache = 4,
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		AddToRoomCacheGlobal = 5,
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		RemoveFromRoomCache = 6,
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		RemoveFromRoomCacheForActorsLeft = 7,
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		SliceIncreaseIndex = 10,
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		SliceSetIndex = 11,
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		SlicePurgeIndex = 12,
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		SlicePurgeUpToIndex = 13
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[Flags]
	public enum PropertyTypeFlag : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		Game = 1,
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		Actor = 2,
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		GameAndActor = 3
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public class RoomOptions
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		private bool isVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		private bool isOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		public byte MaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		public int PlayerTtl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public int EmptyRoomTtl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private bool cleanupCacheOnLeave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public Hashtable CustomRoomProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		public string[] CustomRoomPropertiesForLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public string[] Plugins;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x37E820", Offset = "0x37D620", VA = "0x18037E820")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0x37E810", Offset = "0x37D610", VA = "0x18037E810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x4E2730", Offset = "0x4E1530", VA = "0x1804E2730")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x4E2720", Offset = "0x4E1520", VA = "0x1804E2720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public bool CleanupCacheOnLeave
		{
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0x3FF320", Offset = "0x3FE120", VA = "0x1803FF320")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x4E2770", Offset = "0x4E1570", VA = "0x1804E2770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public bool SuppressRoomEvents
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x3FBC70", Offset = "0x3FAA70", VA = "0x1803FBC70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x664740", Offset = "0x663540", VA = "0x180664740")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public bool PublishUserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x3FBC80", Offset = "0x3FAA80", VA = "0x1803FBC80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x4E2710", Offset = "0x4E1510", VA = "0x1804E2710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public bool DeleteNullProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x4B61B0", Offset = "0x4B4FB0", VA = "0x1804B61B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x4E2750", Offset = "0x4E1550", VA = "0x1804E2750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E2A0", Offset = "0x1A0D0A0", VA = "0x181A0E2A0")]
		public RoomOptions()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public class RaiseEventOptions
	{
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public static readonly RaiseEventOptions Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public EventCaching CachingOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public byte InterestGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public int[] TargetActors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public ReceiverGroup Receivers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		[Obsolete]
		public byte SequenceChannel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public WebFlags Flags;

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x1A0B6D0", Offset = "0x1A0A4D0", VA = "0x181A0B6D0")]
		public RaiseEventOptions()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public enum LobbyType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		SqlLobby = 2,
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		AsyncRandomLobby = 3
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public class TypedLobby
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public LobbyType Type;

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public static readonly TypedLobby Default;

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x93CB20", Offset = "0x93B920", VA = "0x18093CB20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(RVA = "0x1A0F720", Offset = "0x1A0E520", VA = "0x181A0F720")]
		public TypedLobby()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000429")]
		[Cpp2IlInjected.Address(RVA = "0x764FF0", Offset = "0x763DF0", VA = "0x180764FF0")]
		public TypedLobby(string name, LobbyType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x1A0F620", Offset = "0x1A0E420", VA = "0x181A0F620", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public class TypedLobbyInfo : TypedLobby
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public int PlayerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public int RoomCount;

		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(RVA = "0x1A0F390", Offset = "0x1A0E190", VA = "0x181A0F390", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x1A0F590", Offset = "0x1A0E390", VA = "0x181A0F590")]
		public TypedLobbyInfo()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public enum AuthModeOption
	{
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		Auth,
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		AuthOnce,
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		AuthOnceWss
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public enum CustomAuthenticationType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		Steam = 1,
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		Facebook = 2,
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		Oculus = 3,
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		PlayStation = 4,
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		Xbox = 5,
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		None = byte.MaxValue
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public class AuthenticationValues
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private CustomAuthenticationType authType;

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public CustomAuthenticationType AuthType
		{
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x37E820", Offset = "0x37D620", VA = "0x18037E820")]
			get
			{
				return default(CustomAuthenticationType);
			}
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x37E810", Offset = "0x37D610", VA = "0x18037E810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public string AuthGetParameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x359340", Offset = "0x358140", VA = "0x180359340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x36A8D0", Offset = "0x3696D0", VA = "0x18036A8D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public object AuthPostData
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0x36D510", Offset = "0x36C310", VA = "0x18036D510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x382DD0", Offset = "0x381BD0", VA = "0x180382DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public string Token
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x382CF0", Offset = "0x381AF0", VA = "0x180382CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x382C40", Offset = "0x381A40", VA = "0x180382C40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x387730", Offset = "0x386530", VA = "0x180387730")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0x3C4EE0", Offset = "0x3C3CE0", VA = "0x1803C4EE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0xD237C0", Offset = "0xD225C0", VA = "0x180D237C0")]
		public AuthenticationValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0xD237D0", Offset = "0xD225D0", VA = "0x180D237D0")]
		public AuthenticationValues(string userId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0xD234D0", Offset = "0xD222D0", VA = "0x180D234D0", Slot = "4")]
		public virtual void SetAuthPostData(string stringData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x382DD0", Offset = "0x381BD0", VA = "0x180382DD0", Slot = "5")]
		public virtual void SetAuthPostData(byte[] byteData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x19FB860", Offset = "0x19FA660", VA = "0x1819FB860", Slot = "6")]
		public virtual void AddAuthParameter(string key, string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x19FBA90", Offset = "0x19FA890", VA = "0x1819FBA90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public abstract class PhotonPing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		public string DebugString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public bool Successful;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		protected internal bool GotResult;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		protected internal int PingLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		protected internal byte[] PingBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		protected internal byte PingId;

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x1A0A4C0", Offset = "0x1A092C0", VA = "0x181A0A4C0", Slot = "5")]
		public virtual bool StartPing(string ip)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x1A0A470", Offset = "0x1A09270", VA = "0x181A0A470", Slot = "6")]
		public virtual bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x1A0A420", Offset = "0x1A09220", VA = "0x181A0A420", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x6AEE90", Offset = "0x6ADC90", VA = "0x1806AEE90")]
		protected internal void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x1A0A510", Offset = "0x1A09310", VA = "0x181A0A510")]
		protected PhotonPing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public class PingMono : PhotonPing
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private Socket sock;

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x1A0A740", Offset = "0x1A09540", VA = "0x181A0A740", Slot = "5")]
		public override bool StartPing(string ip)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x1A0A610", Offset = "0x1A09410", VA = "0x181A0A610", Slot = "6")]
		public override bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x1A0A590", Offset = "0x1A09390", VA = "0x181A0A590", Slot = "7")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x1A0A510", Offset = "0x1A09310", VA = "0x181A0A510")]
		public PingMono()
		{
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
			[Cpp2IlInjected.Address(RVA = "0x37BEA0", Offset = "0x37ACA0", VA = "0x18037BEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0x359420", Offset = "0x358220", VA = "0x180359420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0x382DE0", Offset = "0x381BE0", VA = "0x180382DE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		public string NickName
		{
			[Cpp2IlInjected.Token(Token = "0x600044A")]
			[Cpp2IlInjected.Address(RVA = "0x36D510", Offset = "0x36C310", VA = "0x18036D510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044B")]
			[Cpp2IlInjected.Address(RVA = "0x1A0B5B0", Offset = "0x1A0A3B0", VA = "0x181A0B5B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0x382CF0", Offset = "0x381AF0", VA = "0x180382CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x382C40", Offset = "0x381A40", VA = "0x180382C40")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x1A0B590", Offset = "0x1A0A390", VA = "0x181A0B590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public bool IsInactive
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x3F9040", Offset = "0x3F7E40", VA = "0x1803F9040")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x4E03C0", Offset = "0x4DF1C0", VA = "0x1804E03C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public Hashtable CustomProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x367190", Offset = "0x365F90", VA = "0x180367190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x3C90C0", Offset = "0x3C7EC0", VA = "0x1803C90C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public Hashtable AllProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x1A0B4F0", Offset = "0x1A0A2F0", VA = "0x181A0B4F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000454")]
		[Cpp2IlInjected.Address(RVA = "0x1A0B3E0", Offset = "0x1A0A1E0", VA = "0x181A0B3E0")]
		protected internal Player(string nickName, int actorID, bool isLocal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(RVA = "0x1A0B400", Offset = "0x1A0A200", VA = "0x181A0B400")]
		protected internal Player(string nickName, int actorID, bool isLocal, Hashtable playerProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(RVA = "0x1A0ACC0", Offset = "0x1A09AC0", VA = "0x181A0ACC0")]
		public Player Get(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(RVA = "0x1A0ACB0", Offset = "0x1A09AB0", VA = "0x181A0ACB0")]
		public Player GetNext()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x1A0AC90", Offset = "0x1A09A90", VA = "0x181A0AC90")]
		public Player GetNextFor(Player currentPlayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x1A0AA40", Offset = "0x1A09840", VA = "0x181A0AA40")]
		public Player GetNextFor(int currentPlayerId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x1A0ACE0", Offset = "0x1A09AE0", VA = "0x181A0ACE0", Slot = "4")]
		public virtual void InternalCacheProperties(Hashtable properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x1A0B360", Offset = "0x1A0A160", VA = "0x181A0B360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x1A0B110", Offset = "0x1A09F10", VA = "0x181A0B110")]
		public string ToStringFull()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x1A0A970", Offset = "0x1A09770", VA = "0x181A0A970", Slot = "0")]
		public override bool Equals(object p)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x382DE0", Offset = "0x381BE0", VA = "0x180382DE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x1A0A960", Offset = "0x1A09760", VA = "0x181A0A960")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x1A0AF40", Offset = "0x1A09D40", VA = "0x181A0AF40")]
		public void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedValues, [Optional] WebFlags webFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x1A0B040", Offset = "0x1A09E40", VA = "0x181A0B040")]
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
			[Cpp2IlInjected.Address(RVA = "0x364E40", Offset = "0x363C40", VA = "0x180364E40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000463")]
			[Cpp2IlInjected.Address(RVA = "0x3EE1F0", Offset = "0x3ECFF0", VA = "0x1803EE1F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public new string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x367190", Offset = "0x365F90", VA = "0x180367190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0x3C90C0", Offset = "0x3C7EC0", VA = "0x1803C90C0")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public new bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x3F9040", Offset = "0x3F7E40", VA = "0x1803F9040")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0x1A0F030", Offset = "0x1A0DE30", VA = "0x181A0F030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public new bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x4F5B90", Offset = "0x4F4990", VA = "0x1804F5B90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0x1A0F150", Offset = "0x1A0DF50", VA = "0x181A0F150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public new byte MaxPlayers
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x39D0E0", Offset = "0x39BEE0", VA = "0x18039D0E0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x1A0F270", Offset = "0x1A0E070", VA = "0x181A0F270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public new byte PlayerCount
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x1A0EFE0", Offset = "0x1A0DDE0", VA = "0x181A0EFE0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public Dictionary<int, Player> Players
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x446DB0", Offset = "0x445BB0", VA = "0x180446DB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x524520", Offset = "0x523320", VA = "0x180524520")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public string[] ExpectedUsers
		{
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0x382CF0", Offset = "0x381AF0", VA = "0x180382CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public int MasterClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0x377050", Offset = "0x375E50", VA = "0x180377050")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public string[] PropertiesListedInLobby
		{
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x3765B0", Offset = "0x3753B0", VA = "0x1803765B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x3DBF50", Offset = "0x3DAD50", VA = "0x1803DBF50")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public bool AutoCleanUp
		{
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0xD1F9C0", Offset = "0xD1E7C0", VA = "0x180D1F9C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x1A0EF20", Offset = "0x1A0DD20", VA = "0x181A0EF20")]
		protected internal Room(string roomName, RoomOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E5B0", Offset = "0x1A0D3B0", VA = "0x181A0E5B0", Slot = "5")]
		public virtual void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E800", Offset = "0x1A0D600", VA = "0x181A0E800")]
		public void SetPropertiesListedInLobby(string[] propertiesListedInLobby)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E540", Offset = "0x1A0D340", VA = "0x181A0E540", Slot = "6")]
		protected internal virtual void RemovePlayer(Player player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E500", Offset = "0x1A0D300", VA = "0x181A0E500", Slot = "7")]
		protected internal virtual void RemovePlayer(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E680", Offset = "0x1A0D480", VA = "0x181A0E680")]
		public bool SetMasterClient(Player masterClientPlayer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E2F0", Offset = "0x1A0D0F0", VA = "0x181A0E2F0", Slot = "8")]
		public virtual bool AddPlayer(Player player)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E8C0", Offset = "0x1A0D6C0", VA = "0x181A0E8C0", Slot = "9")]
		public virtual Player StorePlayer(Player player)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E490", Offset = "0x1A0D290", VA = "0x181A0E490", Slot = "10")]
		public virtual Player GetPlayer(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E380", Offset = "0x1A0D180", VA = "0x181A0E380")]
		public void ClearExpectedUsers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x1A0EC80", Offset = "0x1A0DA80", VA = "0x181A0EC80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E940", Offset = "0x1A0D740", VA = "0x181A0E940")]
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
			[Cpp2IlInjected.Address(RVA = "0x359340", Offset = "0x358140", VA = "0x180359340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0x367190", Offset = "0x365F90", VA = "0x180367190")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public int PlayerCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0x483570", Offset = "0x482370", VA = "0x180483570")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(RVA = "0x6F8850", Offset = "0x6F7650", VA = "0x1806F8850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public bool IsLocalClientInside
		{
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x48C000", Offset = "0x48AE00", VA = "0x18048C000")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x48B530", Offset = "0x48A330", VA = "0x18048B530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public byte MaxPlayers
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0x39D0E0", Offset = "0x39BEE0", VA = "0x18039D0E0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0x3F9040", Offset = "0x3F7E40", VA = "0x1803F9040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0x4F5B90", Offset = "0x4F4990", VA = "0x1804F5B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x1A0E200", Offset = "0x1A0D000", VA = "0x181A0E200")]
		protected internal RoomInfo(string roomName, Hashtable roomProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x1A0D660", Offset = "0x1A0C460", VA = "0x181A0D660", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x1A0D700", Offset = "0x1A0C500", VA = "0x181A0D700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x1A0DF90", Offset = "0x1A0CD90", VA = "0x181A0DF90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x1A0DC80", Offset = "0x1A0CA80", VA = "0x181A0DC80")]
		public string ToStringFull()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048E")]
		[Cpp2IlInjected.Address(RVA = "0x1A0D730", Offset = "0x1A0C530", VA = "0x181A0D730", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x37BEA0", Offset = "0x37ACA0", VA = "0x18037BEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000490")]
			[Cpp2IlInjected.Address(RVA = "0x359420", Offset = "0x358220", VA = "0x180359420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public int ReturnCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x382DE0", Offset = "0x381BE0", VA = "0x180382DE0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0x382F00", Offset = "0x381D00", VA = "0x180382F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public string DebugMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0x36D510", Offset = "0x36C310", VA = "0x18036D510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0x382DD0", Offset = "0x381BD0", VA = "0x180382DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public Dictionary<string, object> Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0x382CF0", Offset = "0x381AF0", VA = "0x180382CF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0x382C40", Offset = "0x381A40", VA = "0x180382C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x1A10A20", Offset = "0x1A0F820", VA = "0x181A10A20")]
		public WebRpcResponse(OperationResponse response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0x1A10810", Offset = "0x1A0F610", VA = "0x181A10810")]
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
			[Cpp2IlInjected.Address(RVA = "0x1A10710", Offset = "0x1A0F510", VA = "0x181A10710")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0x1A10750", Offset = "0x1A0F550", VA = "0x181A10750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public bool SendAuthCookie
		{
			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x1A10720", Offset = "0x1A0F520", VA = "0x181A10720")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x1A10780", Offset = "0x1A0F580", VA = "0x181A10780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public bool SendSync
		{
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x1A10740", Offset = "0x1A0F540", VA = "0x181A10740")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x1A107E0", Offset = "0x1A0F5E0", VA = "0x181A107E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public bool SendState
		{
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0x1A10730", Offset = "0x1A0F530", VA = "0x181A10730")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0x1A107B0", Offset = "0x1A0F5B0", VA = "0x181A107B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0xFB7290", Offset = "0xFB6090", VA = "0x180FB7290")]
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
		[Cpp2IlInjected.Address(RVA = "0x37E060", Offset = "0x37CE60", VA = "0x18037E060")]
		public DoNotFakeAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[AttributeUsage(AttributeTargets.Method)]
	public class ObfuscateLiteralsAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x37E060", Offset = "0x37CE60", VA = "0x18037E060")]
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
		[Cpp2IlInjected.Address(RVA = "0x37E060", Offset = "0x37CE60", VA = "0x18037E060")]
		private RenameAttribute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x768CE0", Offset = "0x767AE0", VA = "0x180768CE0")]
		public RenameAttribute(string target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x37BEA0", Offset = "0x37ACA0", VA = "0x18037BEA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x37E060", Offset = "0x37CE60", VA = "0x18037E060")]
		public ReplaceLiteralsWithNameAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x37E060", Offset = "0x37CE60", VA = "0x18037E060")]
		public SkipAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipRenameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x37E060", Offset = "0x37CE60", VA = "0x18037E060")]
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
