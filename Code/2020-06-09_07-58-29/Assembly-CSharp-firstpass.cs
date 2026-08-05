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
	[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
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
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		EmailCryptTypeNone,
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		EmailCryptTypeSHA1,
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		EmailCryptTypeMD5,
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		EmailCryptTypeSHA256
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setCurrencyCode(string currencyCode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setCustomerUserID(string customerUserID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setAppsFlyerKey(string key)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void trackAppLaunch()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setAppID(string appleAppId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void trackRichEvent(string eventName, Dictionary<string, string> eventValues)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setIsDebug(bool isDebug)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setIsSandbox(bool isSandbox)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void getConversionData()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3A5E80", Offset = "0x3A5080", VA = "0x1803A5E80")]
	public static string getAppsFlyerId()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void handleOpenUrl(string url, string sourceApplication, string annotation)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setDeviceTrackingDisabled(bool state)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void stopTracking(bool isStopTracking)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setAdditionalData(Dictionary<string, string> extraData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setAppInviteOneLinkID(string oneLinkID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void generateUserInviteLink(Dictionary<string, string> parameters, string callbackObject, string callbackMethod, string callbackFailedMethod)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void trackCrossPromoteImpression(string appId, string campaign)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void trackAndOpenStore(string promotedAppId, string campaign, Dictionary<string, string> customParams)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setMinTimeBetweenSessions(int seconds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setHost(string hostPrefixName, string hostName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3A5E80", Offset = "0x3A5080", VA = "0x1803A5E80")]
	public static string getHost()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setUserEmails(EmailCryptType cryptType, params string[] userEmails)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setResolveDeepLinkURLs(params string[] userEmails)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setOneLinkCustomDomain(params string[] domains)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void validateReceipt(string publicKey, string purchaseData, string signature, string price, string currency, Dictionary<string, string> extraParams)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setCollectIMEI(bool shouldCollect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setCollectAndroidID(bool shouldCollect)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void createValidateInAppListener(string aObject, string callbackMethod, string callbackFailedMethod)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void init(string devKey)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void init(string devKey, string callbackObject)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setImeiData(string imeiData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void loadConversionData(string callbackObject)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void enableUninstallTracking(string senderId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void updateServerUninstallToken(string token)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setAndroidIdData(string androidIdData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setPreinstallAttribution(string mediaSource, string campaign, string siteId)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void validateReceipt(string productIdentifier, string price, string currency, string transactionId, Dictionary<string, string> additionalParametes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void handlePushNotification(Dictionary<string, string> payload)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void registerUninstall(byte[] token)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setValue(string value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	[Obsolete]
	public static void loadConversionData(string callbackObject, string callbackMethod, string callbackFailedMethod)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	[Obsolete]
	public static void setGCMProjectNumber(string googleGCMNumber)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	public static void setShouldCollectDeviceName(bool shouldCollectDeviceName)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x390240", Offset = "0x38F440", VA = "0x180390240")]
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
	[Cpp2IlInjected.Address(RVA = "0x1B626C0", Offset = "0x1B618C0", VA = "0x181B626C0")]
	public void didReceiveConversionData(string conversionData)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1B62630", Offset = "0x1B61830", VA = "0x181B62630")]
	public void didReceiveConversionDataWithError(string error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x1B625A0", Offset = "0x1B617A0", VA = "0x181B625A0")]
	public void didFinishValidateReceipt(string validateResult)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1B62510", Offset = "0x1B61710", VA = "0x181B62510")]
	public void didFinishValidateReceiptWithError(string error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x1B62830", Offset = "0x1B61A30", VA = "0x181B62830")]
	public void onAppOpenAttribution(string validateResult)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1B627A0", Offset = "0x1B619A0", VA = "0x181B627A0")]
	public void onAppOpenAttributionFailure(string error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1B629A0", Offset = "0x1B61BA0", VA = "0x181B629A0")]
	public void onInAppBillingSuccess()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1B62910", Offset = "0x1B61B10", VA = "0x181B62910")]
	public void onInAppBillingFailure(string error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1B62A10", Offset = "0x1B61C10", VA = "0x181B62A10")]
	public void onInviteLinkGenerated(string link)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1B62AA0", Offset = "0x1B61CA0", VA = "0x181B62AA0")]
	public void onOpenStoreLinkGenerated(string link)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1B62B40", Offset = "0x1B61D40", VA = "0x181B62B40")]
	private void printCallback(string str)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x390240", Offset = "0x38F440", VA = "0x180390240")]
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
		[Cpp2IlInjected.Address(RVA = "0x2ADD2A0", Offset = "0x2ADC4A0", VA = "0x182ADD2A0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADD2B0", Offset = "0x2ADC4B0", VA = "0x182ADD2B0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2ADD050", Offset = "0x2ADC250", VA = "0x182ADD050")]
	public StreamingAudioIn(IAudioOutputDevice sourceDevice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2ADCFB0", Offset = "0x2ADC1B0", VA = "0x182ADCFB0", Slot = "4")]
	public void SetCallback(Action<float[]> callback, LocalVoice localVoice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2ADCE30", Offset = "0x2ADC030", VA = "0x182ADCE30")]
	private void Push(ArraySegment<float> samples)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x2ADCD70", Offset = "0x2ADBF70", VA = "0x182ADCD70", Slot = "7")]
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
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private Action<short[]> callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private IntPtr javaBuf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private int cntFrame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private int cntShort;

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x1B65860", Offset = "0x1B64A60", VA = "0x181B65860")]
		public DataCallback(Action<short[]> callback, IntPtr javaBuf)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B2")]
		[Cpp2IlInjected.Address(RVA = "0x1B657E0", Offset = "0x1B649E0", VA = "0x181B657E0")]
		public void OnData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x1B65850", Offset = "0x1B64A50", VA = "0x181B65850")]
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
		[Cpp2IlInjected.Address(RVA = "0x493CE0", Offset = "0x492EE0", VA = "0x180493CE0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1B62020", Offset = "0x1B61220", VA = "0x181B62020", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
	public AndroidAudioInAEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1B61550", Offset = "0x1B60750", VA = "0x181B61550", Slot = "4")]
	public void SetCallback(Action<short[]> callback, LocalVoice localVoice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1B614F0", Offset = "0x1B606F0", VA = "0x181B614F0", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x493CE0", Offset = "0x492EE0", VA = "0x180493CE0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1B62460", Offset = "0x1B61660", VA = "0x181B62460", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1B620D0", Offset = "0x1B612D0", VA = "0x181B620D0")]
	private static extern IntPtr Photon_Audio_In_CreateReader(int deviceID);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1B62170", Offset = "0x1B61370", VA = "0x181B62170")]
	private static extern void Photon_Audio_In_Destroy(IntPtr handler);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x1B62210", Offset = "0x1B61410", VA = "0x181B62210")]
	private static extern bool Photon_Audio_In_Read(IntPtr handle, float[] buf, int len);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1B623B0", Offset = "0x1B615B0", VA = "0x181B623B0")]
	public AppleAudioInReader(int deviceID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x1B62030", Offset = "0x1B61230", VA = "0x181B62030", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1B622E0", Offset = "0x1B614E0", VA = "0x181B622E0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x4062D0", Offset = "0x4054D0", VA = "0x1804062D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4062E0", Offset = "0x4054E0", VA = "0x1804062E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x18193E0", Offset = "0x18185E0", VA = "0x1818193E0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x18193C0", Offset = "0x18185C0", VA = "0x1818193C0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1B62CD0", Offset = "0x1B61ED0", VA = "0x181B62CD0")]
	public AudioClipWrapper(AudioClip audioClip)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x1B62BA0", Offset = "0x1B61DA0", VA = "0x181B62BA0", Slot = "4")]
	public bool Read(float[] buffer)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1B636A0", Offset = "0x1B628A0", VA = "0x181B636A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1B63740", Offset = "0x1B62940", VA = "0x181B63740")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1B63640", Offset = "0x1B62840", VA = "0x181B63640")]
	private void OnAudioFilterRead(float[] frame, int channels)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x390240", Offset = "0x38F440", VA = "0x180390240")]
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

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private bool paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int _priority;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private int streamSamplePosAvg;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private AudioSource source;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private string logPrefix;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private bool debugInfo;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private int sourceTimeSamplesPrev;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private int playLoopCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private Queue<float[]> frameQueue;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public const int FRAME_POOL_CAPACITY = 50;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private PrimitiveArrayPool<float> framePool;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int Priority
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3B4C00", Offset = "0x3B3E00", VA = "0x1803B4C00", Slot = "10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1B649F0", Offset = "0x1B63BF0", VA = "0x181B649F0", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int CurrentBufferLag
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3D0CE0", Offset = "0x3CFEE0", VA = "0x1803D0CE0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x88B900", Offset = "0x88AB00", VA = "0x18088B900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public AudioSource AudioSource
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x397B40", Offset = "0x396D40", VA = "0x180397B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private int playSamplePos
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1B64930", Offset = "0x1B63B30", VA = "0x181B64930")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1B64A30", Offset = "0x1B63C30", VA = "0x181B64A30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool IsPlaying
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1B64910", Offset = "0x1B63B10", VA = "0x181B64910", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x1B64840", Offset = "0x1B63A40", VA = "0x181B64840")]
	public AudioStreamPlayer(AudioSource audioSource, string logPrefix, bool debugInfo)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x1B64510", Offset = "0x1B63710", VA = "0x181B64510", Slot = "5")]
	public void Start(int frequency, int channels, int frameSamples, int playDelayMs)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1B63BA0", Offset = "0x1B62DA0", VA = "0x181B63BA0", Slot = "8")]
	public void Service()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1B637E0", Offset = "0x1B629E0", VA = "0x181B637E0", Slot = "7")]
	public void OnAudioFrame(float[] frame)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x1B646B0", Offset = "0x1B638B0", VA = "0x181B646B0", Slot = "6")]
	public void Stop()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1B63AD0", Offset = "0x1B62CD0", VA = "0x181B63AD0", Slot = "12")]
	public void Pause()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1B647A0", Offset = "0x1B639A0", VA = "0x181B647A0")]
	private void UnPause()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1B63B70", Offset = "0x1B62D70", VA = "0x181B63B70")]
	private void RefreshSourcePriority()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class IOSAudioForceToSpeaker : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	private void PhotonVoiceCreated()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x390240", Offset = "0x38F440", VA = "0x180390240")]
	public IOSAudioForceToSpeaker()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MicWrapper : IAudioReader<float>, IDataReader<float>, IDisposable, IAudioSource
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private AudioClip mic;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private string device;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int micPrevPos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int micLoopCnt;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private int readAbsPos;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x18193E0", Offset = "0x18185E0", VA = "0x1818193E0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x18193C0", Offset = "0x18185C0", VA = "0x1818193C0", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x1819310", Offset = "0x1818510", VA = "0x181819310")]
	public MicWrapper(string device, int suggestedFrequency)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x18191F0", Offset = "0x18183F0", VA = "0x1818191F0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x1819200", Offset = "0x1818400", VA = "0x181819200", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA820", Offset = "0x2AD9A20", VA = "0x182ADA820", Slot = "4")]
		public void LogError(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA900", Offset = "0x2AD9B00", VA = "0x182ADA900", Slot = "5")]
		public void LogWarning(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B6")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA890", Offset = "0x2AD9A90", VA = "0x182ADA890", Slot = "6")]
		public void LogInfo(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA7B0", Offset = "0x2AD99B0", VA = "0x182ADA7B0", Slot = "7")]
		public void LogDebug(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
		public Logger()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[Header("Platforms")]
	public bool Windows;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public bool Mac;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[Header("Effects")]
	[Tooltip("Acoustic Echo Cancellation")]
	public bool AEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int AECPlaybackDelayMs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int AECFilterLengthMs;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public bool Denoise;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[Tooltip("Automatic Gain Control")]
	public bool AGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[Range(1f, 32768f)]
	public float AGCLevel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public int AECPlayDelayCurrentFrames;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool AECLatencyDetect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private SpeexProcessor proc;

	[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private bool prevAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private int aecLDState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private float aecLDStart;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private AudioSource aecLDPing;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public SpeexProcessor Processor
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x386B00", Offset = "0x385D00", VA = "0x180386B00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool Active
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4CC280", Offset = "0x4CB480", VA = "0x1804CC280")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x54DC70", Offset = "0x54CE70", VA = "0x18054DC70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC8A0", Offset = "0x2ADBAA0", VA = "0x182ADC8A0")]
	public void ResetAEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC0C0", Offset = "0x2ADB2C0", VA = "0x182ADC0C0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC8C0", Offset = "0x2ADBAC0", VA = "0x182ADC8C0")]
	private void UpdateProcProps()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2ADCB90", Offset = "0x2ADBD90", VA = "0x182ADCB90")]
	private void setOutputListener(bool set)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x2ADCA50", Offset = "0x2ADBC50", VA = "0x182ADCA50")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC100", Offset = "0x2ADB300", VA = "0x182ADC100")]
	private void InitAECLatencyDetect()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC370", Offset = "0x2ADB570", VA = "0x182ADC370")]
	[SkipRename]
	private void PhotonVoiceCreated(LocalVoice localVoice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC330", Offset = "0x2ADB530", VA = "0x182ADC330")]
	[SkipRename]
	private void PhotonVoiceRemoved()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC330", Offset = "0x2ADB530", VA = "0x182ADC330")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC330", Offset = "0x2ADB530", VA = "0x182ADC330")]
	private void reset()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x2ADCB60", Offset = "0x2ADBD60", VA = "0x182ADCB60")]
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
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		SINGLE_CHANNEL_AEC = 0,
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		OPTIBEAM_ARRAY_ONLY = 2,
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		OPTIBEAM_ARRAY_AND_AEC = 4,
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		SINGLE_CHANNEL_NSAGC = 5
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private IntPtr handle;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private Action<short[]> pushCallback;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private LocalVoiceFramed<short> localVoice;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int deviceID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Action<IntPtr, int> pushRef;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int Channels
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x493CE0", Offset = "0x492EE0", VA = "0x180493CE0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2ADEE70", Offset = "0x2ADE070", VA = "0x182ADEE70", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x2ADEA40", Offset = "0x2ADDC40", VA = "0x182ADEA40")]
	private static extern IntPtr Photon_Audio_In_Create(SystemMode systemMode, int micDevIdx, int spkDevIdx, Action<IntPtr, int> callback, bool featrModeOn, bool noiseSup, bool agc, bool cntrClip);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x2ADEB50", Offset = "0x2ADDD50", VA = "0x182ADEB50")]
	private static extern void Photon_Audio_In_Destroy(IntPtr handler);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x2ADEE40", Offset = "0x2ADE040", VA = "0x182ADEE40")]
	public WindowsAudioInPusher(int deviceID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x2ADEBF0", Offset = "0x2ADDDF0", VA = "0x182ADEBF0", Slot = "4")]
	public void SetCallback(Action<short[]> callback, LocalVoice localVoice)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2ADEE80", Offset = "0x2ADE080", VA = "0x182ADEE80")]
	private void push(IntPtr buf, int lenBytes)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2ADE9A0", Offset = "0x2ADDBA0", VA = "0x182ADE9A0", Slot = "7")]
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
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		GameObject,
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		Favorite,
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		Prefab,
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		GameManager,
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		Dragdot,
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		DragdotActive,
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		DragdotDimmed,
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		Dropdown,
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		d_winbtn_mac_close,
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		d_winbtn_mac_close_a,
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		d_winbtn_mac_close_h,
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		d_winbtn_mac_inact,
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		d_winbtn_mac_max,
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		d_winbtn_mac_max_h,
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		d_winbtn_mac_min,
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		d_winbtn_mac_min_h,
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		d_winbtn_win_close,
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		DefaultAsset,
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		DllScript,
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		DistanceJoint2D,
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		FilterByLabel,
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		FilterByType,
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		Fixedjoint,
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		FlareLayer,
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		FrictionJoint2D,
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		GUIText,
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		HingeJoint2D,
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		Image,
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		LightProbeProxyVolume,
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		LightProbeGroup,
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		LineRenderer,
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		LayoutElement,
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		LensFlare
	}

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Dictionary<IconType, string> m_internalIcons;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x2ADB490", Offset = "0x2ADA690", VA = "0x182ADB490")]
	public static string GetInternalStringPathOfEnumValue(IconType type)
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public enum SA_PD_MessageType
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	Info,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	Error
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ASIdentifierManagerExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[SerializeField]
	private Text advertisingTrackingEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[SerializeField]
	private Text advertisingIdentifier;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x1B613C0", Offset = "0x1B605C0", VA = "0x181B613C0")]
	public void GetAdvertisingIdentifier()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x1B61450", Offset = "0x1B60650", VA = "0x181B61450")]
	public void GetAdvertisingTrackingEnabled()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x390240", Offset = "0x38F440", VA = "0x180390240")]
	public ASIdentifierManagerExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class ISN_AppdelegateUseExample : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x1812110", Offset = "0x1811310", VA = "0x181812110")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x390240", Offset = "0x38F440", VA = "0x180390240")]
	public ISN_AppdelegateUseExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ISN_CoreLocationDelegateExample : ISN_iCLLocationManagerDelegate
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x1812900", Offset = "0x1811B00", VA = "0x181812900", Slot = "4")]
	public void DidChangeAuthorizationStatus(ISN_CLAuthorizationStatus authorizationStatus)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x1812B00", Offset = "0x1811D00", VA = "0x181812B00", Slot = "5")]
	public void DidUpdateLocations(ISN_CLLocationArray locations)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x1812980", Offset = "0x1811B80", VA = "0x181812980", Slot = "6")]
	public void DidFailWithError(SA_Error error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x18129F0", Offset = "0x1811BF0", VA = "0x1818129F0", Slot = "7")]
	public void DidFinishDeferredUpdatesWithError(SA_Error error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x1812A60", Offset = "0x1811C60", VA = "0x181812A60", Slot = "8")]
	public void DidPauseLocationUpdates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1812AB0", Offset = "0x1811CB0", VA = "0x181812AB0", Slot = "9")]
	public void DidResumeLocationUpdates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x1812F60", Offset = "0x1812160", VA = "0x181812F60")]
	private void ShowMessage(string title, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
	public ISN_CoreLocationDelegateExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ISN_CoreLocationUseExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[SerializeField]
	private Button m_AuthButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[SerializeField]
	private Button m_StartUpdatingButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[SerializeField]
	private Button m_StopUpdatingButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[SerializeField]
	private Button m_RequestLocationButton;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1813220", Offset = "0x1812420", VA = "0x181813220")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x18130C0", Offset = "0x18122C0", VA = "0x1818130C0")]
	private void ShowMessage(string title, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x390240", Offset = "0x38F440", VA = "0x180390240")]
	public ISN_CoreLocationUseExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ISN_EventKitExamples : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[SerializeField]
	private Text m_Error;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private string m_EventID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private string m_ReminderID;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1813C20", Offset = "0x1812E20", VA = "0x181813C20")]
	public void RequestAccessToEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1813CB0", Offset = "0x1812EB0", VA = "0x181813CB0")]
	public void RequestAccessToReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x18137D0", Offset = "0x18129D0", VA = "0x1818137D0")]
	public void AddEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x1813A80", Offset = "0x1812C80", VA = "0x181813A80")]
	public void RemoveEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x1813920", Offset = "0x1812B20", VA = "0x181813920")]
	public void AddReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x1813B50", Offset = "0x1812D50", VA = "0x181813B50")]
	public void RemoveReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x390240", Offset = "0x38F440", VA = "0x180390240")]
	public ISN_EventKitExamples()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ISN_GameKitUseExample_TvOS : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[SerializeField]
	private Button m_SingInButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[SerializeField]
	private Button m_LeaderboardsUI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	[SerializeField]
	private Button m_AchievementsUI;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x1814470", Offset = "0x1813670", VA = "0x181814470")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x390240", Offset = "0x38F440", VA = "0x180390240")]
	public ISN_GameKitUseExample_TvOS()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DocumentationExample : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x1B65A00", Offset = "0x1B64C00", VA = "0x181B65A00")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x390240", Offset = "0x38F440", VA = "0x180390240")]
	public DocumentationExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class ISN_MediaPlayerExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	[SerializeField]
	[Header("Info Panel")]
	private Text m_title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	[SerializeField]
	private Text m_artist;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	[SerializeField]
	private Text m_playbackState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	[SerializeField]
	[Header("Buttons")]
	private Button m_play;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	[SerializeField]
	private Button m_stop;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	[SerializeField]
	private Button m_pause;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[SerializeField]
	private Button m_next;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[SerializeField]
	private Button m_previos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private ISN_MPMusicPlayerController m_player;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x18152F0", Offset = "0x18144F0", VA = "0x1818152F0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x1815680", Offset = "0x1814880", VA = "0x181815680")]
	private void UpdatePlayerStateUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x390240", Offset = "0x38F440", VA = "0x180390240")]
	public ISN_MediaPlayerExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ISN_CameraGalleryExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[SerializeField]
	private Button m_loadFromGallery;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[SerializeField]
	private Button m_loadFromCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[SerializeField]
	private Button m_saveToGallery;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[SerializeField]
	private Image m_image;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[SerializeField]
	private GameObject m_go;

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1812450", Offset = "0x1811650", VA = "0x181812450")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x390240", Offset = "0x38F440", VA = "0x180390240")]
	public ISN_CameraGalleryExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ISN_SocialExamples : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[SerializeField]
	private Button m_twitterText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[SerializeField]
	private Button m_twitterTextImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[SerializeField]
	private Button m_fbImage;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x18169A0", Offset = "0x1815BA0", VA = "0x1818169A0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x390240", Offset = "0x38F440", VA = "0x180390240")]
	public ISN_SocialExamples()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class ISN_UIImagePickerControllerExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[SerializeField]
	private RawImage m_Image;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[SerializeField]
	private Image m_Sprite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[SerializeField]
	[Header("Image")]
	private Button m_ImageCapture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[SerializeField]
	private Button m_ImageLibrary;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[SerializeField]
	private Button m_ImageAlbum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[SerializeField]
	[Header("Video")]
	private Button m_VideoCapture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[SerializeField]
	private Button m_VideoLibrary;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[SerializeField]
	private Button m_VideoAlbum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[SerializeField]
	private Button m_VideoPlay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private ISN_UIPickerControllerResult m_LastPickerResult;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x1817620", Offset = "0x1816820", VA = "0x181817620")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1817490", Offset = "0x1816690", VA = "0x181817490")]
	private void AddFitter(GameObject go)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1818040", Offset = "0x1817240", VA = "0x181818040")]
	private void UpdateUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x1817C70", Offset = "0x1816E70", VA = "0x181817C70")]
	private void StartPicker(ISN_UIImagePickerControllerSourceType sourceType, string mediaType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x1817AC0", Offset = "0x1816CC0", VA = "0x181817AC0")]
	private void DisplayResult(ISN_UIPickerControllerResult result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x1817500", Offset = "0x1816700", VA = "0x181817500")]
	private void ApplyImageToGui(Texture2D image)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x18179A0", Offset = "0x1816BA0", VA = "0x1818179A0")]
	private void DisplayMessage(string message, [Optional] Action onClose)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x390240", Offset = "0x38F440", VA = "0x180390240")]
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
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private ISN_UNNotificationRequest m_request;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x2AD7000", Offset = "0x2AD6200", VA = "0x182AD7000", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_RemoteNotifications_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class ISN_UNAuthorization_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2AD7BC0", Offset = "0x2AD6DC0", VA = "0x182AD7BC0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_UNAuthorization_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ISN_UNSchedule_Test : SA_BaseTest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private ISN_UNNotificationRequest m_request;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x2AD7CA0", Offset = "0x2AD6EA0", VA = "0x182AD7CA0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2AD7F90", Offset = "0x2AD7190", VA = "0x182AD7F90")]
		private void ValidateRequest(ISN_UNNotificationRequest presentdeRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
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
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x2AD7730", Offset = "0x2AD6930", VA = "0x182AD7730", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x2AD7600", Offset = "0x2AD6800", VA = "0x182AD7600")]
		private void TestVideo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_UIImagePickerController_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class SaveToCameraRollTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBFD0", Offset = "0x2ADB1D0", VA = "0x182ADBFD0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
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
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x2AD5520", Offset = "0x2AD4720", VA = "0x182AD5520", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_DefaultSharingDialog_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class ISN_FacebookShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x2AD57F0", Offset = "0x2AD49F0", VA = "0x182AD57F0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_FacebookShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class ISN_InstagramShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x2AD6D40", Offset = "0x2AD5F40", VA = "0x182AD6D40", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_InstagramShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class ISN_MailShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x2AD6E50", Offset = "0x2AD6050", VA = "0x182AD6E50", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_MailShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class ISN_TextMessage_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x2AD71B0", Offset = "0x2AD63B0", VA = "0x182AD71B0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_TextMessage_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class ISN_TwitterShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x2AD74F0", Offset = "0x2AD66F0", VA = "0x182AD74F0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_TwitterShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ISN_WhatsAppShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA650", Offset = "0x2AD9850", VA = "0x182ADA650", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
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
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x2AD5910", Offset = "0x2AD4B10", VA = "0x182AD5910", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_GKAchievementsLoad_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class ISN_GKAchievmentReport_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x2AD5D60", Offset = "0x2AD4F60", VA = "0x182AD5D60", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x2AD5C80", Offset = "0x2AD4E80", VA = "0x182AD5C80")]
		private void ReportCompletedAchievment(string achievementId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2AD5C10", Offset = "0x2AD4E10", VA = "0x182AD5C10")]
		private void CheckIfCompleted(string achievementId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_GKAchievmentReport_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class ISN_GKAchievmentReset_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x2AD6020", Offset = "0x2AD5220", VA = "0x182AD6020", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x2AD5FB0", Offset = "0x2AD51B0", VA = "0x182AD5FB0")]
		private void CheckIfResetCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_GKAchievmentReset_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class ISN_GKGameCenterUI_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x2AD61E0", Offset = "0x2AD53E0", VA = "0x182AD61E0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_GKGameCenterUI_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class ISN_GKGenerateIdentityVerificationSignature_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x2AD6210", Offset = "0x2AD5410", VA = "0x182AD6210", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_GKGenerateIdentityVerificationSignature_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class ISN_GKLoadLeaderboards_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x2AD6420", Offset = "0x2AD5620", VA = "0x182AD6420", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_GKLoadLeaderboards_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class ISN_GKLocalPlayer_Authenticate_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x2AD66C0", Offset = "0x2AD58C0", VA = "0x182AD66C0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_GKLocalPlayer_Authenticate_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class ISN_GKReportingScores_Test : ISN_GKSingleLeaderboard_Test
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2AD68E0", Offset = "0x2AD5AE0", VA = "0x182AD68E0", Slot = "7")]
		public override void OnLeaderboardReady(ISN_GKLeaderboard leaderboard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_GKReportingScores_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class ISN_GKRetrievingScores_Test : ISN_GKSingleLeaderboard_Test
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x2AD6A90", Offset = "0x2AD5C90", VA = "0x182AD6A90", Slot = "7")]
		public override void OnLeaderboardReady(ISN_GKLeaderboard leaderboard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_GKRetrievingScores_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public abstract class ISN_GKSingleLeaderboard_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x2AD6BF0", Offset = "0x2AD5DF0", VA = "0x182AD6BF0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void OnLeaderboardReady(ISN_GKLeaderboard leaderboard);

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
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
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4CE0", Offset = "0x2AD3EE0", VA = "0x182AD4CE0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_AudioSessionTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class ISN_BuildInfoTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D50", Offset = "0x2AD3F50", VA = "0x182AD4D50", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_BuildInfoTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class ISN_iCloudKeyValueStorageTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA6F0", Offset = "0x2AD98F0", VA = "0x182ADA6F0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_iCloudKeyValueStorageTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class ISN_NSFileManagerTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x2AD6F80", Offset = "0x2AD6180", VA = "0x182AD6F80", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_NSFileManagerTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class ISN_TimeZoneTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x2AD72D0", Offset = "0x2AD64D0", VA = "0x182AD72D0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
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
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4E00", Offset = "0x2AD4000", VA = "0x182AD4E00", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
		public ISN_CNContactsPicker_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public class ISN_CNFetchPhoneContacts_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x2AD53F0", Offset = "0x2AD45F0", VA = "0x182AD53F0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4ED0", Offset = "0x2AD40D0", VA = "0x182AD4ED0")]
		public static void PrintContacts(List<ISN_CNContact> contacts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2AD4D40", Offset = "0x2AD3F40", VA = "0x182AD4D40")]
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
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x180F880", Offset = "0x180EA80", VA = "0x18180F880")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x390240", Offset = "0x38F440", VA = "0x180390240")]
		public AVKitUseExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class ISN_BaseIOSFeaturePreview : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		protected GUIStyle style;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		protected int buttonWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		protected int buttonHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		protected float StartY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		protected float StartX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		protected float XStartPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		protected float YStartPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		protected float XButtonStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		protected float YButtonStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		protected float YLableStep;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x18122F0", Offset = "0x18114F0", VA = "0x1818122F0", Slot = "4")]
		protected virtual void InitStyles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x706830", Offset = "0x705A30", VA = "0x180706830", Slot = "5")]
		public virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x18123F0", Offset = "0x18115F0", VA = "0x1818123F0")]
		public void UpdateToStartPos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x18123E0", Offset = "0x18115E0", VA = "0x1818123E0")]
		public void LoadLevel(string levelName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1812400", Offset = "0x1811600", VA = "0x181812400")]
		public ISN_BaseIOSFeaturePreview()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class ISN_FoundationExamples
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1814340", Offset = "0x1813540", VA = "0x181814340")]
		public void LocaleInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
		public ISN_FoundationExamples()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class GameKitUseExample : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private List<ISN_GKSavedGame> m_fetchedSavedGames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private List<string> m_conflictedSavedGames;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x180FBE0", Offset = "0x180EDE0", VA = "0x18180FBE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x1810560", Offset = "0x180F760", VA = "0x181810560")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x180FCC0", Offset = "0x180EEC0", VA = "0x18180FCC0")]
		private void DidModifySavedGame(ISN_GKSavedGameSaveResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x180FFF0", Offset = "0x180F1F0", VA = "0x18180FFF0")]
		private void HasConflictingSavedGames(ISN_GKSavedGameFetchResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x1810640", Offset = "0x180F840", VA = "0x181810640")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x1812090", Offset = "0x1811290", VA = "0x181812090")]
		public GameKitUseExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class iCloudUseExample : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private float valueF;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2ADEFD0", Offset = "0x2ADE1D0", VA = "0x182ADEFD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF0C0", Offset = "0x2ADE2C0", VA = "0x182ADF0C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFAB0", Offset = "0x2ADECB0", VA = "0x182ADFAB0")]
		private void StoreDidChangeExternally(ISN_NSStoreDidChangeExternallyNotification result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x2ADF150", Offset = "0x2ADE350", VA = "0x182ADF150")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x2ADFD40", Offset = "0x2ADEF40", VA = "0x182ADFD40")]
		public iCloudUseExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class ISN_UIController : SA_UIController
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public ScrollRect scroll;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x1816CF0", Offset = "0x1815EF0", VA = "0x181816CF0", Slot = "7")]
		public override GameObject AddSideMenuElement(List<SA_ExampleSubsectionConfig> subsections, bool isActive)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x1817200", Offset = "0x1816400", VA = "0x181817200")]
		private void SetToggle(string sceneName, string text, SA_SideToggleStyle style, Toggle toggle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x1816F90", Offset = "0x1816190", VA = "0x181816F90", Slot = "5")]
		public override Toggle AddTopMenuElement(string name, Sprite icon, bool isActive, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x18171E0", Offset = "0x18163E0", VA = "0x1818171E0", Slot = "4")]
		public override void SetLogo(Sprite sprite)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x18173B0", Offset = "0x18165B0", VA = "0x1818173B0", Slot = "8")]
		public override void UnloadContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x1817120", Offset = "0x1816320", VA = "0x181817120", Slot = "9")]
		public override void LoadContent(GameObject canvas)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x1817300", Offset = "0x1816500", VA = "0x181817300", Slot = "6")]
		public override void ShowTopMenuItem(GameObject menuItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x1816C40", Offset = "0x1815E40", VA = "0x181816C40", Slot = "10")]
		public override void AddLog(string log)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x429360", Offset = "0x428560", VA = "0x180429360")]
		public ISN_UIController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class SA_ExampleSceneConfig : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public List<SA_ExampleServicesConfig> Services;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Sprite Logo;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA970", Offset = "0x2AD9B70", VA = "0x182ADA970")]
		public SA_ExampleSceneConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class SA_ExampleSceneController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[SerializeField]
		private SA_ExampleSceneConfig m_config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[SerializeField]
		private SA_UIController m_UIController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private List<GameObject> m_links;

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB050", Offset = "0x2ADA250", VA = "0x182ADB050")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB1F0", Offset = "0x2ADA3F0", VA = "0x182ADB1F0")]
		private void Subscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB010", Offset = "0x2ADA210", VA = "0x182ADB010")]
		private void SetLogo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAA00", Offset = "0x2AD9C00", VA = "0x182ADAA00")]
		private void GenerateMenuUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAD10", Offset = "0x2AD9F10", VA = "0x182ADAD10")]
		private void HandlerTopMenuClick(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x2ADABD0", Offset = "0x2AD9DD0", VA = "0x182ADABD0")]
		private void HandlerSideMenuClick(string sceneName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x2ADADC0", Offset = "0x2AD9FC0", VA = "0x182ADADC0")]
		private void LoadScene(string sceneName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB360", Offset = "0x2ADA560", VA = "0x182ADB360")]
		private void UnloadScene()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2ADAEC0", Offset = "0x2ADA0C0", VA = "0x182ADAEC0")]
		private void SceneLoaded(Scene scene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA9D0", Offset = "0x2AD9BD0", VA = "0x182ADA9D0")]
		private void Application_LogMessageReceived(string condition, string stackTrace, LogType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB3D0", Offset = "0x2ADA5D0", VA = "0x182ADB3D0")]
		public SA_ExampleSceneController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class SA_ExampleServicesConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Sprite Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public List<SA_ExampleSubsectionConfig> Subsections;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB430", Offset = "0x2ADA630", VA = "0x182ADB430")]
		public SA_ExampleServicesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class SA_ExampleSubsectionConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public SA_SceneField Scene;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
		public SA_ExampleSubsectionConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class SA_SceneField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[SerializeField]
		private UnityEngine.Object sceneAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[SerializeField]
		private string sceneName;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public string SceneName
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x3821C0", Offset = "0x3813C0", VA = "0x1803821C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB9A0", Offset = "0x2ADABA0", VA = "0x182ADB9A0")]
		public SA_SceneField()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class SA_SideToggleStyle : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[HideInInspector]
		public Text Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private GameObject m_mainContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private string m_sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private Toggle m_toggle;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBB10", Offset = "0x2ADAD10", VA = "0x182ADBB10")]
		public void SetParam(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x2ADB9E0", Offset = "0x2ADABE0", VA = "0x182ADB9E0", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBA20", Offset = "0x2ADAC20", VA = "0x182ADBA20", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBC20", Offset = "0x2ADAE20", VA = "0x182ADBC20")]
		public void SetWhite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBA90", Offset = "0x2ADAC90", VA = "0x182ADBA90")]
		public void SetBlue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x390240", Offset = "0x38F440", VA = "0x180390240")]
		public SA_SideToggleStyle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class SA_TopToggleStyle : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private Text m_label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private Image m_icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private Toggle m_toggle;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBDE0", Offset = "0x2ADAFE0", VA = "0x182ADBDE0")]
		public Toggle SetToggle(bool isActive, string text, Sprite sprite)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBC70", Offset = "0x2ADAE70", VA = "0x182ADBC70", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBCB0", Offset = "0x2ADAEB0", VA = "0x182ADBCB0", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBF40", Offset = "0x2ADB140", VA = "0x182ADBF40")]
		public void SetWhite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x2ADBCF0", Offset = "0x2ADAEF0", VA = "0x182ADBCF0")]
		public void SetBlue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x390240", Offset = "0x38F440", VA = "0x180390240")]
		public SA_TopToggleStyle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public abstract class SA_UIController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Action<int> OnTopMenuClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public Action<string> OnSideMenuClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		protected Image m_logo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		protected GameObject m_topMenuItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		protected GameObject m_sideMenuItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		protected GameObject m_sideScroll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		protected GameObject m_mainContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		protected Text m_logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		protected GameObject m_prevSideItem;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void SetLogo(Sprite sprite);

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract Toggle AddTopMenuElement(string name, Sprite icon, bool isActive, int index);

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void ShowTopMenuItem(GameObject menuItem);

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract GameObject AddSideMenuElement(List<SA_ExampleSubsectionConfig> subsections, bool isActive);

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void UnloadContent();

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void LoadContent(GameObject canvas);

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void AddLog(string log);

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x390240", Offset = "0x38F440", VA = "0x180390240")]
		protected SA_UIController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class ISN_ReplayKitUseExample : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private bool IsRecording;

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x18163C0", Offset = "0x18155C0", VA = "0x1818163C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x18165E0", Offset = "0x18157E0", VA = "0x1818165E0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x1816840", Offset = "0x1815A40", VA = "0x181816840")]
		private void OnRecordStopped(ISN_RPStopResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x1812400", Offset = "0x1811600", VA = "0x181812400")]
		public ISN_ReplayKitUseExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class ISN_MarketExample : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private static ISN_PaymentManagerExample s_paymentManager;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x1814710", Offset = "0x1813910", VA = "0x181814710")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x1812400", Offset = "0x1811600", VA = "0x181812400")]
		public ISN_MarketExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public class ISN_PaymentManagerExample : ISN_iSKPaymentTransactionObserver
	{
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public const string SMALL_PACK = "your.product.id1.here";

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public const string NC_PACK = "your.product.id2.here";

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private static bool IsInitialized;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1816210", Offset = "0x1815410", VA = "0x181816210")]
		public void init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x1816160", Offset = "0x1815360", VA = "0x181816160")]
		private static void UnlockProducts(ISN_iSKPaymentTransaction transaction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x1815AB0", Offset = "0x1814CB0", VA = "0x181815AB0", Slot = "4")]
		public void OnTransactionUpdated(ISN_iSKPaymentTransaction transaction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220", Slot = "5")]
		public void OnTransactionRemoved(ISN_iSKPaymentTransaction result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x38F7E0", Offset = "0x38E9E0", VA = "0x18038F7E0", Slot = "6")]
		public bool OnShouldAddStorePayment(ISN_SKProduct result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x1815800", Offset = "0x1814A00", VA = "0x181815800", Slot = "7")]
		public void OnRestoreTransactionsComplete(SA_Result result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
		public ISN_PaymentManagerExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class ISN_UIKitExample : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[SerializeField]
		private Texture2D m_icon;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x18180D0", Offset = "0x18172D0", VA = "0x1818180D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x1818250", Offset = "0x1817450", VA = "0x181818250")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x1812400", Offset = "0x1811600", VA = "0x181812400")]
		public ISN_UIKitExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public class ISN_UserNotificationExample : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8930", Offset = "0x2AD7B30", VA = "0x182AD8930")]
		public void RequestUserNotificationPermission()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2AD81A0", Offset = "0x2AD73A0", VA = "0x182AD81A0")]
		public void GetSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8590", Offset = "0x2AD7790", VA = "0x182AD8590")]
		public void NotificationInterval()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x2AD83D0", Offset = "0x2AD75D0", VA = "0x182AD83D0")]
		public void NotificationCalendar()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8720", Offset = "0x2AD7920", VA = "0x182AD8720")]
		public void NotificationLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8270", Offset = "0x2AD7470", VA = "0x182AD8270")]
		public void NoSoundToTrigger()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x390240", Offset = "0x38F440", VA = "0x180390240")]
		public ISN_UserNotificationExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class ISN_UserNotificationsExamples : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8AF0", Offset = "0x2AD7CF0", VA = "0x182AD8AF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA310", Offset = "0x2AD9510", VA = "0x182ADA310")]
		private void PrintNotification(ISN_UNNotification notification)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9620", Offset = "0x2AD8820", VA = "0x182AD9620")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2AD9800", Offset = "0x2AD8A00", VA = "0x182AD9800")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x2AD92A0", Offset = "0x2AD84A0", VA = "0x182AD92A0")]
		private void DocsExample()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2AD8D70", Offset = "0x2AD7F70", VA = "0x182AD8D70")]
		private void ContactsUse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x2ADA640", Offset = "0x2AD9840", VA = "0x182ADA640")]
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
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[Space]
		[Multiline]
		[SerializeField]
		[Header("Unity Default Property Drawers")]
		[Space(10f)]
		private string m_multilineString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[TextArea]
		public string m_textAreaString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[SerializeField]
		[Range(0f, 100f)]
		private int m_intRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_floatRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[SerializeField]
		[Tooltip("Health value between 0 and 100.")]
		private float m_hoverMouseToSeeTooltip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[Space]
		[Header("Sliders")]
		[Space(10f)]
		public float m_simpleSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[SA_PD_MinMaxSlider(0f, 3f, 255f, 0f, 0f)]
		public Vector2 m_MinMaxSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[Header("Help Boxes with text message")]
		[SA_PD_HelpBox(SA_PD_MessageType.Info)]
		public string myHelpBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[SA_PD_HelpBox(SA_PD_MessageType.Warning)]
		public string myString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
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
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[SA_PD_IndentLevel(2)]
		public string indentLevel1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[SA_PD_IndentLevel(0)]
		public string indentLevel2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[Space]
		[Header("Conditional Hide / Show fields")]
		[Space(10f)]
		public bool showBelowSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public float range;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public bool isExists;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public AnimationCurve curve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[Space]
		[Header("Conditional Disable / Enable fields")]
		[Space(10f)]
		public bool enableBelowSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[SA_PD_Conditional("enableBelowSettings")]
		public bool firstSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[SA_PD_Conditional("enableBelowSettings")]
		public float secondSettigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[Space]
		[Header("Label with Icon")]
		[Space(10f)]
		[SA_PD_LabelWithIcon("Plugins/StansAssets/Support2018/Modules/Editor/EditorStylesCollection/Resources/Icons/gameObjectIcon.png")]
		public string myLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[SA_PD_LabelWithIcon(SA_PD_EditorIcons.IconType.Light)]
		public string favoriteLabel;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x181B010", Offset = "0x181A210", VA = "0x18181B010")]
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
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private string m_conditionalSourceField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private bool m_hideInInspector;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public string ConditionalSourceField
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x3823A0", Offset = "0x3815A0", VA = "0x1803823A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool HideInInspector
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x494CC0", Offset = "0x493EC0", VA = "0x180494CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x181B0A0", Offset = "0x181A2A0", VA = "0x18181B0A0")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x181B100", Offset = "0x181A300", VA = "0x18181B100")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField, bool hideInInspector)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_HelpBoxAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private SA_PD_MessageType m_type;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x3AFFF0", Offset = "0x3AF1F0", VA = "0x1803AFFF0")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x181B170", Offset = "0x181A370", VA = "0x18181B170")]
		public SA_PD_HelpBoxAttribute(SA_PD_MessageType type)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_IndentLevelAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private int m_indentLevel;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public int IndentLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x3AFFF0", Offset = "0x3AF1F0", VA = "0x1803AFFF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x181B170", Offset = "0x181A370", VA = "0x18181B170")]
		public SA_PD_IndentLevelAttribute(int indentLevel)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_LabelWithIconAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private string m_iconPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private string m_internalIconPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private SA_PD_EditorIcons.IconType m_iconType;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string IconPath
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x3823A0", Offset = "0x3815A0", VA = "0x1803823A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public string InternalIconPath
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x3821C0", Offset = "0x3813C0", VA = "0x1803821C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x181B1E0", Offset = "0x181A3E0", VA = "0x18181B1E0")]
		public SA_PD_LabelWithIconAttribute(string iconPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x181B250", Offset = "0x181A450", VA = "0x18181B250")]
		public SA_PD_LabelWithIconAttribute(SA_PD_EditorIcons.IconType icon)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_MinMaxSliderAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private float m_minLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private float m_maxLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private Color m_color;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public float MinLimit
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x46A360", Offset = "0x469560", VA = "0x18046A360")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x46A370", Offset = "0x469570", VA = "0x18046A370")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x4E3C00", Offset = "0x4E2E00", VA = "0x1804E3C00")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x181B2F0", Offset = "0x181A4F0", VA = "0x18181B2F0")]
		public SA_PD_MinMaxSliderAttribute(float minLimit, float maxLimit, float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_SimpleSliderAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private float m_minLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private float m_maxLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private Color m_color;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float MinLimit
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x46A360", Offset = "0x469560", VA = "0x18046A360")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x46A370", Offset = "0x469570", VA = "0x18046A370")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x4E3C00", Offset = "0x4E2E00", VA = "0x1804E3C00")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x181B2F0", Offset = "0x181A4F0", VA = "0x18181B2F0")]
		public SA_PD_SimpleSliderAttribute(float minLimit, float maxLimit, float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public class SA_PD_HeaderDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private string m_text;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0x3823A0", Offset = "0x3815A0", VA = "0x1803823A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x51C3F0", Offset = "0x51B5F0", VA = "0x18051C3F0")]
		public SA_PD_HeaderDecoratorAttribute(string text)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SA_PD_HelpboxDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private string m_message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private SA_PD_MessageType m_type;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public string Message
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x3823A0", Offset = "0x3815A0", VA = "0x1803823A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x3B1470", Offset = "0x3B0670", VA = "0x1803B1470")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x181B1A0", Offset = "0x181A3A0", VA = "0x18181B1A0")]
		public SA_PD_HelpboxDecoratorAttribute(SA_PD_MessageType type, string message = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SA_PD_PRInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x543860", Offset = "0x542A60", VA = "0x180543860")]
		public SA_PD_PRInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SA_PD_StandartInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x543860", Offset = "0x542A60", VA = "0x180543860")]
		public SA_PD_StandartInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class SA_PD_ThingInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x543860", Offset = "0x542A60", VA = "0x180543860")]
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
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private IntPtr _handle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private string _version;

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private const int MaxFrameSize = 5760;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private bool _previousPacketInvalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int _channelCount;

		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private static readonly float[] EmptyBufferFloat;

		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private static readonly short[] EmptyBufferShort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private Bandwidth? _previousPacketBandwidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private float[] bufferFloat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private short[] bufferShort;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public string Version
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x3821C0", Offset = "0x3813C0", VA = "0x1803821C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Bandwidth? PreviousPacketBandwidth
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x38FF90", Offset = "0x38F190", VA = "0x18038FF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public SamplingRate SamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x3B4C00", Offset = "0x3B3E00", VA = "0x1803B4C00")]
			[CompilerGenerated]
			get
			{
				return default(SamplingRate);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x3B4220", Offset = "0x3B3420", VA = "0x1803B4220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Channels Channels
		{
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x3B48A0", Offset = "0x3B3AA0", VA = "0x1803B48A0")]
			get
			{
				return default(Channels);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x1819970", Offset = "0x1818B70", VA = "0x181819970")]
		public OpusDecoder(SamplingRate outputSamplingRateHz, Channels numChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x1819400", Offset = "0x1818600", VA = "0x181819400")]
		public float[] DecodePacketFloat(byte[] packetData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1819630", Offset = "0x1818830", VA = "0x181819630")]
		public short[] DecodePacketShort(byte[] packetData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x1819860", Offset = "0x1818A60", VA = "0x181819860", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class OpusEncoder : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public const int BitrateMax = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private IntPtr _handle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private string _version;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private const int RecommendedMaxPacketSize = 4000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private int _frameSizePerChannel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private SamplingRate _inputSamplingRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private Channels _inputChannels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly byte[] writePacket;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private static readonly ArraySegment<byte> EmptyBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private Delay _encoderDelay;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public SamplingRate InputSamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x3B48A0", Offset = "0x3B3AA0", VA = "0x1803B48A0")]
			get
			{
				return default(SamplingRate);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Channels InputChannels
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x3B4940", Offset = "0x3B3B40", VA = "0x1803B4940")]
			get
			{
				return default(Channels);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public string Version
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x3821C0", Offset = "0x3813C0", VA = "0x1803821C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Delay EncoderDelay
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x444AD0", Offset = "0x443CD0", VA = "0x180444AD0")]
			get
			{
				return default(Delay);
			}
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x181A640", Offset = "0x1819840", VA = "0x18181A640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public int FrameSizePerChannel
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x3B15B0", Offset = "0x3B07B0", VA = "0x1803B15B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int Bitrate
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x181A4C0", Offset = "0x18196C0", VA = "0x18181A4C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x181A5E0", Offset = "0x18197E0", VA = "0x18181A5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public Bandwidth MaxBandwidth
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x181A560", Offset = "0x1819760", VA = "0x18181A560")]
			get
			{
				return default(Bandwidth);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x181A7A0", Offset = "0x18199A0", VA = "0x18181A7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public Complexity Complexity
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x181A4E0", Offset = "0x18196E0", VA = "0x18181A4E0")]
			get
			{
				return default(Complexity);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x181A600", Offset = "0x1819800", VA = "0x18181A600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int ExpectedPacketLossPercentage
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x181A520", Offset = "0x1819720", VA = "0x18181A520")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x181A760", Offset = "0x1819960", VA = "0x18181A760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public SignalHint SignalHint
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x181A580", Offset = "0x1819780", VA = "0x18181A580")]
			get
			{
				return default(SignalHint);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x181A7C0", Offset = "0x18199C0", VA = "0x18181A7C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public ForceChannels ForceChannels
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x181A540", Offset = "0x1819740", VA = "0x18181A540")]
			get
			{
				return default(ForceChannels);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x181A780", Offset = "0x1819980", VA = "0x18181A780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool UseInbandFEC
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x181A5A0", Offset = "0x18197A0", VA = "0x18181A5A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x181A7E0", Offset = "0x18199E0", VA = "0x18181A7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool UseUnconstrainedVBR
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x181A5C0", Offset = "0x18197C0", VA = "0x18181A5C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x181A800", Offset = "0x1819A00", VA = "0x18181A800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool DtxEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x181A500", Offset = "0x1819700", VA = "0x18181A500")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x181A620", Offset = "0x1819820", VA = "0x18181A620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x181A080", Offset = "0x1819280", VA = "0x18181A080")]
		public OpusEncoder(SamplingRate inputSamplingRateHz, Channels numChannels, int bitrate, OpusApplicationType applicationType, Delay encoderDelay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x1819BF0", Offset = "0x1818DF0", VA = "0x181819BF0")]
		public ArraySegment<byte> Encode(float[] pcmSamples)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x1819E00", Offset = "0x1819000", VA = "0x181819E00")]
		public ArraySegment<byte> Encode(short[] pcmSamples)
		{
			return default(ArraySegment<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x1819B50", Offset = "0x1818D50", VA = "0x181819B50", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class OpusException : Exception
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private OpusStatusCode _statusCode;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public OpusStatusCode StatusCode
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x856680", Offset = "0x855880", VA = "0x180856680")]
			get
			{
				return default(OpusStatusCode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x181A820", Offset = "0x1819A20", VA = "0x18181A820")]
		public OpusException(OpusStatusCode statusCode, string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	internal class Wrapper
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private const string lib_name = "opus_egpv";

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x182ACB0", Offset = "0x1829EB0", VA = "0x18182ACB0")]
		private static extern int opus_encoder_get_size(Channels channels);

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x182AD40", Offset = "0x1829F40", VA = "0x18182AD40")]
		private static extern OpusStatusCode opus_encoder_init(IntPtr st, SamplingRate Fs, Channels channels, OpusApplicationType application);

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x182AE00", Offset = "0x182A000", VA = "0x18182AE00")]
		public static extern IntPtr opus_get_version_string();

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x182A6A0", Offset = "0x18298A0", VA = "0x18182A6A0")]
		private static extern int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x182A440", Offset = "0x1829640", VA = "0x18182A440")]
		private static extern int opus_encode_float(IntPtr st, float[] pcm, int frame_size, byte[] data, int max_data_bytes);

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x182ABA0", Offset = "0x1829DA0", VA = "0x18182ABA0")]
		private static extern int opus_encoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x182AAF0", Offset = "0x1829CF0", VA = "0x18182AAF0")]
		private static extern int opus_encoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x182A1F0", Offset = "0x18293F0", VA = "0x18182A1F0")]
		private static extern int opus_decoder_ctl_set(IntPtr st, OpusCtlSetRequest request, int value);

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x182A140", Offset = "0x1829340", VA = "0x18182A140")]
		private static extern int opus_decoder_ctl_get(IntPtr st, OpusCtlGetRequest request, ref int value);

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x182A300", Offset = "0x1829500", VA = "0x18182A300")]
		private static extern int opus_decoder_get_size(Channels channels);

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x182A390", Offset = "0x1829590", VA = "0x18182A390")]
		private static extern OpusStatusCode opus_decoder_init(IntPtr st, SamplingRate Fs, Channels channels);

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x1829D80", Offset = "0x1828F80", VA = "0x181829D80")]
		private static extern int opus_decode(IntPtr st, byte[] data, int len, short[] pcm, int frame_size, int decode_fec);

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x1829B90", Offset = "0x1828D90", VA = "0x181829B90")]
		private static extern int opus_decode_float(IntPtr st, byte[] data, int len, float[] pcm, int frame_size, int decode_fec);

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x182AE90", Offset = "0x182A090", VA = "0x18182AE90")]
		public static extern int opus_packet_get_bandwidth(byte[] data);

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x182AF30", Offset = "0x182A130", VA = "0x18182AF30")]
		public static extern int opus_packet_get_nb_channels(byte[] data);

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x182AFD0", Offset = "0x182A1D0", VA = "0x18182AFD0")]
		private static extern IntPtr opus_strerror(OpusStatusCode error);

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x182A900", Offset = "0x1829B00", VA = "0x18182A900")]
		public static IntPtr opus_encoder_create(SamplingRate Fs, Channels channels, OpusApplicationType application)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x182A790", Offset = "0x1829990", VA = "0x18182A790")]
		public static int opus_encode(IntPtr st, short[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x182A530", Offset = "0x1829730", VA = "0x18182A530")]
		public static int opus_encode(IntPtr st, float[] pcm, int frame_size, byte[] data)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x182AC50", Offset = "0x1829E50", VA = "0x18182AC50")]
		public static void opus_encoder_destroy(IntPtr st)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x1829A70", Offset = "0x1828C70", VA = "0x181829A70")]
		public static int get_opus_encoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x182B180", Offset = "0x182A380", VA = "0x18182B180")]
		public static void set_opus_encoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x1829950", Offset = "0x1828B50", VA = "0x181829950")]
		public static int get_opus_decoder_ctl(IntPtr st, OpusCtlGetRequest request)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x182B060", Offset = "0x182A260", VA = "0x18182B060")]
		public static void set_opus_decoder_ctl(IntPtr st, OpusCtlSetRequest request, int value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x1829F70", Offset = "0x1829170", VA = "0x181829F70")]
		public static IntPtr opus_decoder_create(SamplingRate Fs, Channels channels)
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x182A2A0", Offset = "0x18294A0", VA = "0x18182A2A0")]
		public static void opus_decoder_destroy(IntPtr st)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x1829E70", Offset = "0x1829070", VA = "0x181829E70")]
		public static int opus_decode(IntPtr st, byte[] data, short[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x1829C80", Offset = "0x1828E80", VA = "0x181829C80")]
		public static int opus_decode(IntPtr st, byte[] data, float[] pcm, int decode_fec, int channels)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x1829820", Offset = "0x1828A20", VA = "0x181829820")]
		private static void HandleStatusCode(OpusStatusCode statusCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
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
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		Narrowband = 1101,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		Mediumband,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		Wideband,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		SuperWideband,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		Fullband
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum Channels
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Mono = 1,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Stereo
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public enum Complexity
	{
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		Complexity0,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		Complexity1,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		Complexity2,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		Complexity3,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		Complexity4,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		Complexity5,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		Complexity6,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		Complexity7,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		Complexity8,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		Complexity9,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Complexity10
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public enum Delay
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Delay2dot5ms = 5,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Delay5ms = 10,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Delay10ms = 20,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Delay20ms = 40,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Delay40ms = 80,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Delay60ms = 120
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum ForceChannels
	{
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		NoForce = -1000,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		Mono = 1,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		Stereo = 2
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public enum OpusApplicationType
	{
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		Voip = 2048,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		Audio = 2049,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		RestrictedLowDelay = 2051
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal enum OpusCtlGetRequest
	{
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		Application = 4001,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		Bitrate = 4003,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		MaxBandwidth = 4005,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		VBR = 4007,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		Bandwidth = 4009,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Complexity = 4011,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		InbandFec = 4013,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		PacketLossPercentage = 4015,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Dtx = 4017,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		VBRConstraint = 4021,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		ForceChannels = 4023,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		Signal = 4025,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		LookAhead = 4027,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		SampleRate = 4029,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		FinalRange = 4031,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		Pitch = 4033,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		Gain = 4035,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		LsbDepth = 4037,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		LastPacketDurationRequest = 4039
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal enum OpusCtlSetRequest
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Application = 4000,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Bitrate = 4002,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		MaxBandwidth = 4004,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		VBR = 4006,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		Bandwidth = 4008,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		Complexity = 4010,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		InbandFec = 4012,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		PacketLossPercentage = 4014,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		Dtx = 4016,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		VBRConstraint = 4020,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		ForceChannels = 4022,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		Signal = 4024,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		Gain = 4034,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		LsbDepth = 4036
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public enum OpusStatusCode
	{
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		OK = 0,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		BadArguments = -1,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		BufferTooSmall = -2,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		InternalError = -3,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		InvalidPacket = -4,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		Unimplemented = -5,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		InvalidState = -6,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		AllocFail = -7
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public enum SamplingRate
	{
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		Sampling08000 = 8000,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		Sampling12000 = 12000,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		Sampling16000 = 16000,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		Sampling24000 = 24000,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		Sampling48000 = 48000
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public enum SignalHint
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Auto = -1000,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		Voice = 3001,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
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
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			protected T[] frameResampled;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			private int channels;

			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(RVA = "0x1A1B380", Offset = "0x1A1A580", VA = "0x181A1B380")]
			public Resampler(int dstSize, int channels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0x1A1B330", Offset = "0x1A1A530", VA = "0x181A1B330", Slot = "4")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F0")]
		public interface ILevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x170000EB")]
			float CurrentAvgAmp
			{
				[Cpp2IlInjected.Token(Token = "0x600053D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000EC")]
			float CurrentPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x600053E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000ED")]
			float PeakAmpForFrame
			{
				[Cpp2IlInjected.Token(Token = "0x600053F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000EE")]
			float AccumAvgPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x6000540")]
				[Cpp2IlInjected.Address(Slot = "3")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000541")]
			[Cpp2IlInjected.Address(Slot = "4")]
			void ResetAccumAvgPeakAmp();
		}

		[Cpp2IlInjected.Token(Token = "0x20000F1")]
		public class LevelMetterDummy : ILevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x170000EF")]
			public float CurrentAvgAmp
			{
				[Cpp2IlInjected.Token(Token = "0x6000542")]
				[Cpp2IlInjected.Address(RVA = "0x672970", Offset = "0x671B70", VA = "0x180672970", Slot = "4")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F0")]
			public float CurrentPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x6000543")]
				[Cpp2IlInjected.Address(RVA = "0x672970", Offset = "0x671B70", VA = "0x180672970", Slot = "5")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F1")]
			public float PeakAmpForFrame
			{
				[Cpp2IlInjected.Token(Token = "0x6000544")]
				[Cpp2IlInjected.Address(RVA = "0x672970", Offset = "0x671B70", VA = "0x180672970", Slot = "6")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F2")]
			public float AccumAvgPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x6000545")]
				[Cpp2IlInjected.Address(RVA = "0x672970", Offset = "0x671B70", VA = "0x180672970", Slot = "7")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000546")]
			[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220", Slot = "8")]
			public void ResetAccumAvgPeakAmp()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
			public LevelMetterDummy()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		public abstract class LevelMeter<T> : LocalVoiceFramed<T>.IProcessor, IDisposable, ILevelMeter
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			protected float ampSum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			protected float ampPeak;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			protected int bufferSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			protected float[] buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047F")]
			protected int prevValuesPtr;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			protected float accumAvgPeakAmpSum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			protected int accumAvgPeakAmpCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			protected float peakAmpForFrame;

			[Cpp2IlInjected.Token(Token = "0x170000F3")]
			public float CurrentAvgAmp
			{
				[Cpp2IlInjected.Token(Token = "0x6000549")]
				[Cpp2IlInjected.Address(RVA = "0x1A19970", Offset = "0x1A18B70", VA = "0x181A19970", Slot = "6")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F4")]
			public float CurrentPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x600054A")]
				[Cpp2IlInjected.Address(RVA = "0x3DEE50", Offset = "0x3DE050", VA = "0x1803DEE50", Slot = "7")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600054B")]
				[Cpp2IlInjected.Address(RVA = "0x7019A0", Offset = "0x700BA0", VA = "0x1807019A0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F5")]
			public float PeakAmpForFrame
			{
				[Cpp2IlInjected.Token(Token = "0x600054C")]
				[Cpp2IlInjected.Address(RVA = "0x3C75F0", Offset = "0x3C67F0", VA = "0x1803C75F0", Slot = "8")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000F6")]
			public float AccumAvgPeakAmp
			{
				[Cpp2IlInjected.Token(Token = "0x600054D")]
				[Cpp2IlInjected.Address(RVA = "0x1A19950", Offset = "0x1A18B50", VA = "0x181A19950", Slot = "9")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0x1A19850", Offset = "0x1A18A50", VA = "0x181A19850")]
			internal LevelMeter(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054E")]
			[Cpp2IlInjected.Address(RVA = "0x1A197C0", Offset = "0x1A189C0", VA = "0x181A197C0", Slot = "10")]
			public void ResetAccumAvgPeakAmp()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600054F")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract T[] Process(T[] buf);

			[Cpp2IlInjected.Token(Token = "0x6000550")]
			[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		public class LevelMeterFloat : LevelMeter<float>
		{
			[Cpp2IlInjected.Token(Token = "0x6000551")]
			[Cpp2IlInjected.Address(RVA = "0x1B67E20", Offset = "0x1B67020", VA = "0x181B67E20")]
			public LevelMeterFloat(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0x1B67C70", Offset = "0x1B66E70", VA = "0x181B67C70", Slot = "11")]
			public override float[] Process(float[] buf)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		public class LevelMeterShort : LevelMeter<short>
		{
			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0x1B68050", Offset = "0x1B67250", VA = "0x181B68050")]
			public LevelMeterShort(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000554")]
			[Cpp2IlInjected.Address(RVA = "0x1B67E80", Offset = "0x1B67080", VA = "0x181B67E80", Slot = "11")]
			public override short[] Process(short[] buf)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		public interface IVoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x170000F7")]
			bool On
			{
				[Cpp2IlInjected.Token(Token = "0x6000555")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000556")]
				[Cpp2IlInjected.Address(Slot = "1")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000F8")]
			float Threshold
			{
				[Cpp2IlInjected.Token(Token = "0x6000557")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
				[Cpp2IlInjected.Token(Token = "0x6000558")]
				[Cpp2IlInjected.Address(Slot = "3")]
				set;
			}

			[Cpp2IlInjected.Token(Token = "0x170000F9")]
			bool Detected
			{
				[Cpp2IlInjected.Token(Token = "0x6000559")]
				[Cpp2IlInjected.Address(Slot = "4")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000FA")]
			DateTime DetectedTime
			{
				[Cpp2IlInjected.Token(Token = "0x600055A")]
				[Cpp2IlInjected.Address(Slot = "5")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x170000FB")]
			int ActivityDelayMs
			{
				[Cpp2IlInjected.Token(Token = "0x600055D")]
				[Cpp2IlInjected.Address(Slot = "8")]
				get;
				[Cpp2IlInjected.Token(Token = "0x600055E")]
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
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			private IVoiceDetector voiceDetector;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			private ILevelMeter levelMeter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			private int valuesPerSec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			protected int voiceDetectorCalibrateCount;

			[Cpp2IlInjected.Token(Token = "0x170000FC")]
			public bool VoiceDetectorCalibrating
			{
				[Cpp2IlInjected.Token(Token = "0x600055F")]
				[Cpp2IlInjected.Address(RVA = "0x81AA70", Offset = "0x819C70", VA = "0x18081AA70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0x1A1CA60", Offset = "0x1A1BC60", VA = "0x181A1CA60")]
			public VoiceDetectorCalibration(IVoiceDetector voiceDetector, ILevelMeter levelMeter, int samplingRate, int channels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0x1A1C8E0", Offset = "0x1A1BAE0", VA = "0x181A1C8E0")]
			public void VoiceDetectorCalibrate(int durationMs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x1A1C780", Offset = "0x1A1B980", VA = "0x181A1C780", Slot = "4")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F7")]
		public class VoiceDetectorDummy : IVoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x170000FD")]
			public bool On
			{
				[Cpp2IlInjected.Token(Token = "0x6000564")]
				[Cpp2IlInjected.Address(RVA = "0x38FEF0", Offset = "0x38F0F0", VA = "0x18038FEF0", Slot = "4")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000565")]
				[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220", Slot = "5")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FE")]
			public float Threshold
			{
				[Cpp2IlInjected.Token(Token = "0x6000566")]
				[Cpp2IlInjected.Address(RVA = "0x672970", Offset = "0x671B70", VA = "0x180672970", Slot = "6")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000567")]
				[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220", Slot = "7")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FF")]
			public bool Detected
			{
				[Cpp2IlInjected.Token(Token = "0x6000568")]
				[Cpp2IlInjected.Address(RVA = "0x38FEF0", Offset = "0x38F0F0", VA = "0x18038FEF0", Slot = "8")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000100")]
			public int ActivityDelayMs
			{
				[Cpp2IlInjected.Token(Token = "0x6000569")]
				[Cpp2IlInjected.Address(RVA = "0x3A5E80", Offset = "0x3A5080", VA = "0x1803A5E80", Slot = "12")]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600056A")]
				[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220", Slot = "13")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000101")]
			public DateTime DetectedTime
			{
				[Cpp2IlInjected.Token(Token = "0x600056B")]
				[Cpp2IlInjected.Address(RVA = "0x3823A0", Offset = "0x3815A0", VA = "0x1803823A0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(DateTime);
				}
				[Cpp2IlInjected.Token(Token = "0x600056C")]
				[Cpp2IlInjected.Address(RVA = "0x3AFCB0", Offset = "0x3AEEB0", VA = "0x1803AFCB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000006")]
			public event Action OnDetected
			{
				[Cpp2IlInjected.Token(Token = "0x600056D")]
				[Cpp2IlInjected.Address(RVA = "0x1B79B70", Offset = "0x1B78D70", VA = "0x181B79B70", Slot = "10")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600056E")]
				[Cpp2IlInjected.Address(RVA = "0x1B79C10", Offset = "0x1B78E10", VA = "0x181B79C10", Slot = "11")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
			public VoiceDetectorDummy()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public abstract class VoiceDetector<T> : LocalVoiceFramed<T>.IProcessor, IDisposable, IVoiceDetector
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private bool detected;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			protected int activityDelay;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			protected int autoSilenceCounter;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			protected int valuesCountPerSec;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000492")]
			protected int activityDelayValuesCount;

			[Cpp2IlInjected.Token(Token = "0x17000102")]
			public bool On
			{
				[Cpp2IlInjected.Token(Token = "0x6000570")]
				[Cpp2IlInjected.Address(RVA = "0x397FF0", Offset = "0x3971F0", VA = "0x180397FF0", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000571")]
				[Cpp2IlInjected.Address(RVA = "0x3ACEA0", Offset = "0x3AC0A0", VA = "0x1803ACEA0", Slot = "7")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000103")]
			public float Threshold
			{
				[Cpp2IlInjected.Token(Token = "0x6000572")]
				[Cpp2IlInjected.Address(RVA = "0x46A370", Offset = "0x469570", VA = "0x18046A370", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000573")]
				[Cpp2IlInjected.Address(RVA = "0x49A350", Offset = "0x499550", VA = "0x18049A350", Slot = "9")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000104")]
			public bool Detected
			{
				[Cpp2IlInjected.Token(Token = "0x6000574")]
				[Cpp2IlInjected.Address(RVA = "0x494CC0", Offset = "0x493EC0", VA = "0x180494CC0", Slot = "10")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000575")]
				[Cpp2IlInjected.Address(RVA = "0x1A1D100", Offset = "0x1A1C300", VA = "0x181A1D100")]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000105")]
			public DateTime DetectedTime
			{
				[Cpp2IlInjected.Token(Token = "0x6000576")]
				[Cpp2IlInjected.Address(RVA = "0x3827E0", Offset = "0x3819E0", VA = "0x1803827E0", Slot = "11")]
				[CompilerGenerated]
				get
				{
					return default(DateTime);
				}
				[Cpp2IlInjected.Token(Token = "0x6000577")]
				[Cpp2IlInjected.Address(RVA = "0x3B1450", Offset = "0x3B0650", VA = "0x1803B1450")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000106")]
			public int ActivityDelayMs
			{
				[Cpp2IlInjected.Token(Token = "0x6000578")]
				[Cpp2IlInjected.Address(RVA = "0x3B4C00", Offset = "0x3B3E00", VA = "0x1803B4C00", Slot = "14")]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000579")]
				[Cpp2IlInjected.Address(RVA = "0x1A1CF70", Offset = "0x1A1C170", VA = "0x181A1CF70", Slot = "15")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x14000007")]
			public event Action OnDetected
			{
				[Cpp2IlInjected.Token(Token = "0x600057A")]
				[Cpp2IlInjected.Address(RVA = "0x1A1CCB0", Offset = "0x1A1BEB0", VA = "0x181A1CCB0", Slot = "12")]
				[CompilerGenerated]
				add
				{
				}
				[Cpp2IlInjected.Token(Token = "0x600057B")]
				[Cpp2IlInjected.Address(RVA = "0x1A1CD60", Offset = "0x1A1BF60", VA = "0x181A1CD60", Slot = "13")]
				[CompilerGenerated]
				remove
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600057C")]
			[Cpp2IlInjected.Address(RVA = "0x1A1CAC0", Offset = "0x1A1BCC0", VA = "0x181A1CAC0")]
			internal VoiceDetector(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(Slot = "16")]
			public abstract T[] Process(T[] buf);

			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F9")]
		public class VoiceDetectorFloat : VoiceDetector<float>
		{
			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0x1B79DE0", Offset = "0x1B78FE0", VA = "0x181B79DE0")]
			public VoiceDetectorFloat(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0x1B79CB0", Offset = "0x1B78EB0", VA = "0x181B79CB0", Slot = "16")]
			public override float[] Process(float[] buffer)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FA")]
		public class VoiceDetectorShort : VoiceDetector<short>
		{
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x1B79F90", Offset = "0x1B79190", VA = "0x181B79F90")]
			internal VoiceDetectorShort(int samplingRate, int numChannels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0x1B79E50", Offset = "0x1B79050", VA = "0x181B79E50", Slot = "16")]
			public override short[] Process(short[] buffer)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FB")]
		public class VoiceLevelDetectCalibrate<T> : LocalVoiceFramed<T>.IProcessor, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			private VoiceDetectorCalibration<T> c;

			[Cpp2IlInjected.Token(Token = "0x17000107")]
			public ILevelMeter Level
			{
				[Cpp2IlInjected.Token(Token = "0x6000583")]
				[Cpp2IlInjected.Address(RVA = "0x3823A0", Offset = "0x3815A0", VA = "0x1803823A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000584")]
				[Cpp2IlInjected.Address(RVA = "0x3AFCB0", Offset = "0x3AEEB0", VA = "0x1803AFCB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000108")]
			public IVoiceDetector Detector
			{
				[Cpp2IlInjected.Token(Token = "0x6000585")]
				[Cpp2IlInjected.Address(RVA = "0x3821C0", Offset = "0x3813C0", VA = "0x1803821C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000586")]
				[Cpp2IlInjected.Address(RVA = "0x3B1460", Offset = "0x3B0660", VA = "0x1803B1460")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x1A1D880", Offset = "0x1A1CA80", VA = "0x181A1D880")]
			public VoiceLevelDetectCalibrate(int samplingRate, int channels)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x1A1D1B0", Offset = "0x1A1C3B0", VA = "0x181A1D1B0")]
			public void Calibrate(int durationMs)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0x1A1D690", Offset = "0x1A1C890", VA = "0x181A1D690", Slot = "4")]
			public T[] Process(T[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0x1A1D1E0", Offset = "0x1A1C3E0", VA = "0x181A1D1E0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public const float SHORT_TO_NORMALIZED_FLOAT_RATIO = 3.051851E-05f;

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x18CD1A0", Offset = "0x18CC3A0", VA = "0x1818CD1A0")]
		public static void Resample<T>(T[] src, T[] dst, int dstCount, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x1B64EE0", Offset = "0x1B640E0", VA = "0x181B64EE0")]
		public static void ResampleAndConvert(short[] src, float[] dst, int dstCount, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x1B64C20", Offset = "0x1B63E20", VA = "0x181B64C20")]
		public static void ResampleAndConvert(float[] src, short[] dst, int dstCount, int channels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x1B64BA0", Offset = "0x1B63DA0", VA = "0x181B64BA0")]
		public static void Convert(float[] src, short[] dst, int dstCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x1B64B10", Offset = "0x1B63D10", VA = "0x181B64B10")]
		public static void Convert(short[] src, float[] dst, int dstCount)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x18CD090", Offset = "0x18CC290", VA = "0x1818CD090")]
		public static void ForceToStereo<T>(T[] src, T[] dst, int srcChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x132DFA0", Offset = "0x132D1A0", VA = "0x18132DFA0")]
		internal static string tostr<T>(T[] x, int lim = 10)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public interface IAudioOut
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool IsPlaying
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		int CurrentBufferLag
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		int Priority
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Start(int frequency, int channels, int frameSamplesPerChannel, int playDelayMs);

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Stop();

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OnAudioFrame(float[] frame);

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Service();

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void Pause();
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public abstract class ObjectPool<TType, TInfo> : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		protected int capacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		protected TInfo info;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private TType[] freeObj;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		protected int pos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		protected string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private bool inited;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		internal string LogPrefix
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x142BB20", Offset = "0x142AD20", VA = "0x18142BB20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public TInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x3B1490", Offset = "0x3B0690", VA = "0x1803B1490")]
			get
			{
				return (TInfo)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract TType createObject(TInfo info);

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void destroyObject(TType obj);

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract bool infosMatch(TInfo i0, TInfo i1);

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x142B9A0", Offset = "0x142ABA0", VA = "0x18142B9A0")]
		public ObjectPool(int capacity, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x142BA10", Offset = "0x142AC10", VA = "0x18142BA10")]
		public ObjectPool(int capacity, string name, TInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x142B190", Offset = "0x142A390", VA = "0x18142B190")]
		public void Init(TInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x142AAE0", Offset = "0x1429CE0", VA = "0x18142AAE0")]
		public TType AcquireOrCreate()
		{
			return (TType)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x142ACC0", Offset = "0x1429EC0", VA = "0x18142ACC0")]
		public TType AcquireOrCreate(TInfo info)
		{
			return (TType)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x142B770", Offset = "0x142A970", VA = "0x18142B770", Slot = "8")]
		public virtual bool Release(TType obj, TInfo objInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x142B5F0", Offset = "0x142A7F0", VA = "0x18142B5F0", Slot = "9")]
		public virtual bool Release(TType obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x142AF00", Offset = "0x142A100", VA = "0x18142AF00", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public class PrimitiveArrayPool<T> : ObjectPool<T[], int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x142BBC0", Offset = "0x142ADC0", VA = "0x18142BBC0")]
		public PrimitiveArrayPool(int capacity, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x142BBF0", Offset = "0x142ADF0", VA = "0x18142BBF0")]
		public PrimitiveArrayPool(int capacity, string name, int info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x142BC20", Offset = "0x142AE20", VA = "0x18142BC20", Slot = "5")]
		protected override T[] createObject(int info)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220", Slot = "6")]
		protected override void destroyObject(T[] obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x88E4A0", Offset = "0x88D6A0", VA = "0x18088E4A0", Slot = "7")]
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
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private Factory factory;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1A17390", Offset = "0x1A16590", VA = "0x181A17390")]
		public ImageBufferNativePool(int capacity, Factory factory, string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1A173E0", Offset = "0x1A165E0", VA = "0x181A173E0")]
		public ImageBufferNativePool(int capacity, Factory factory, string name, ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x1A17440", Offset = "0x1A16640", VA = "0x181A17440", Slot = "5")]
		protected override T createObject(ImageBufferInfo info)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x1A17480", Offset = "0x1A16680", VA = "0x181A17480", Slot = "6")]
		protected override void destroyObject(T obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x1A174B0", Offset = "0x1A166B0", VA = "0x181A174B0", Slot = "7")]
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
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			Frame2dot5ms = 2500,
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			Frame5ms = 5000,
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			Frame10ms = 10000,
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			Frame20ms = 20000,
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			Frame40ms = 40000,
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			Frame60ms = 60000
		}

		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		public static class EncoderFactory
		{
			[Cpp2IlInjected.Token(Token = "0x600058F")]
			[Cpp2IlInjected.Address(RVA = "0x1B664E0", Offset = "0x1B656E0", VA = "0x181B664E0")]
			public static IEncoder Create(VoiceInfo i, LocalVoice localVoice)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000FF")]
		public abstract class Encoder<T> : IEncoderDataFlowDirect<T>, IEncoderDataFlow<T>, IEncoder, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049D")]
			protected OpusEncoder encoder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			protected bool disposed;

			[Cpp2IlInjected.Token(Token = "0x6000590")]
			[Cpp2IlInjected.Address(RVA = "0x141BCB0", Offset = "0x141AEB0", VA = "0x18141BCB0")]
			protected Encoder(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0x141B970", Offset = "0x141AB70", VA = "0x18141B970", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(Slot = "6")]
			public abstract ArraySegment<byte> EncodeAndGetOutput(T[] buf);
		}

		[Cpp2IlInjected.Token(Token = "0x2000100")]
		public class EncoderFloat : Encoder<float>
		{
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			private static readonly ArraySegment<byte> EmptyBuffer;

			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0x1B66940", Offset = "0x1B65B40", VA = "0x181B66940")]
			internal EncoderFloat(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0x1B66740", Offset = "0x1B65940", VA = "0x181B66740", Slot = "6")]
			public override ArraySegment<byte> EncodeAndGetOutput(float[] buf)
			{
				return default(ArraySegment<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000101")]
		public class EncoderShort : Encoder<short>
		{
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			private static readonly ArraySegment<byte> EmptyBuffer;

			[Cpp2IlInjected.Token(Token = "0x6000596")]
			[Cpp2IlInjected.Address(RVA = "0x1B66BB0", Offset = "0x1B65DB0", VA = "0x181B66BB0")]
			internal EncoderShort(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000597")]
			[Cpp2IlInjected.Address(RVA = "0x1B669B0", Offset = "0x1B65BB0", VA = "0x181B669B0", Slot = "6")]
			public override ArraySegment<byte> EncodeAndGetOutput(short[] buf)
			{
				return default(ArraySegment<byte>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000102")]
		public class Decoder : IDecoderDirect, IDecoder, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			private OpusDecoder decoder;

			[Cpp2IlInjected.Token(Token = "0x6000599")]
			[Cpp2IlInjected.Address(RVA = "0x1B65970", Offset = "0x1B64B70", VA = "0x181B65970", Slot = "7")]
			public void Open(VoiceInfo i)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0x1B658C0", Offset = "0x1B64AC0", VA = "0x181B658C0", Slot = "4")]
			public byte[] DecodeToByte(byte[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x1B65910", Offset = "0x1B64B10", VA = "0x181B65910", Slot = "5")]
			public float[] DecodeToFloat(byte[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0x1B65930", Offset = "0x1B64B30", VA = "0x181B65930", Slot = "6")]
			public short[] DecodeToShort(byte[] buf)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x1B65950", Offset = "0x1B64B50", VA = "0x181B65950", Slot = "8")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
			public Decoder()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000103")]
		public class Util
		{
			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0x1B79910", Offset = "0x1B78B10", VA = "0x181B79910")]
			internal static int bestEncoderSampleRate(int f)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
			public Util()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
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
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			public int LatencyMs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			public int LatencyDelayedMs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			public bool PlayDetected;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40004A5")]
			public bool PlayDelayedDetected;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x40004A6")]
			public bool RecDetected;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private bool _AEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private int _AECPlaybackDelayMs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private bool _AECLatencyDetect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private int frameSamples;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private int samplingRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private int channels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private int playDelayFrames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private int playDelayMaxFrames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private IntPtr stEcho;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private IntPtr st;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private short[] resultBuf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private PrimitiveArrayPool<short> playbackBufPool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private Queue<short[]> playBufQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private Framer<float> playFramer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private int playSamplingRate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private int playChannels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private ILogger logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private Func<long> clockMs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private AudioUtil.VoiceLevelDetectCalibrate<float> detectPlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private AudioUtil.VoiceLevelDetectCalibrate<short> detectPlayCorr;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private AudioUtil.VoiceLevelDetectCalibrate<short> detectRec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private long detectTimePlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private long detectTimePlayDelayed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private long detectTimeRec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private int frameCntRec;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private int frameCntPlay;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool AEC
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x397FF0", Offset = "0x3971F0", VA = "0x180397FF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x181E2E0", Offset = "0x181D4E0", VA = "0x18181E2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int AECFilterLengthMs
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x3B1490", Offset = "0x3B0690", VA = "0x1803B1490")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x3B14B0", Offset = "0x3B06B0", VA = "0x1803B14B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int AECPlaybackDelayMs
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x3B1470", Offset = "0x3B0670", VA = "0x1803B1470")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x181E2C0", Offset = "0x181D4C0", VA = "0x18181E2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int AECurrentPlayDelayFrames
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x181E1C0", Offset = "0x181D3C0", VA = "0x18181E1C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool AECLatencyDetect
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x42F180", Offset = "0x42E380", VA = "0x18042F180")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x181E2A0", Offset = "0x181D4A0", VA = "0x18181E2A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public AECLatencyResultType AECLatencyResult
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x181E090", Offset = "0x181D290", VA = "0x18181E090")]
			get
			{
				return default(AECLatencyResultType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool Denoise
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x181E270", Offset = "0x181D470", VA = "0x18181E270")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x181E3A0", Offset = "0x181D5A0", VA = "0x18181E3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool AGC
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x181E240", Offset = "0x181D440", VA = "0x18181E240")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x181E370", Offset = "0x181D570", VA = "0x18181E370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public float AGCLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x181E210", Offset = "0x181D410", VA = "0x18181E210")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x181E340", Offset = "0x181D540", VA = "0x18181E340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x181DB70", Offset = "0x181CD70", VA = "0x18181DB70")]
		public void ResetAEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x181C090", Offset = "0x181B290", VA = "0x18181C090")]
		public void AECLatecnyDetectCaliberate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x181E3D0", Offset = "0x181D5D0", VA = "0x18181E3D0")]
		private void set(int param, bool val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x181E400", Offset = "0x181D600", VA = "0x18181E400")]
		private void set(int param, float val)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x181E030", Offset = "0x181D230", VA = "0x18181E030")]
		private bool getBool(int param)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x181E060", Offset = "0x181D260", VA = "0x18181E060")]
		private float getFloat(int param)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x181DD10", Offset = "0x181CF10", VA = "0x18181DD10")]
		public SpeexProcessor(ILogger logger, Func<long> clockMs, int frameSize, int samplingRate, int channels, int playSamplingRate, int playChannels, int playBufSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x181CCC0", Offset = "0x181BEC0", VA = "0x18181CCC0")]
		private void InitLatencyDetect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x181C390", Offset = "0x181B590", VA = "0x18181C390")]
		public void InitAEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x181CEC0", Offset = "0x181C0C0", VA = "0x18181CEC0")]
		private void InitPlayDelay(int ms)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x181D6F0", Offset = "0x181C8F0", VA = "0x18181D6F0", Slot = "4")]
		public short[] Process(short[] buf)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x181CF80", Offset = "0x181C180", VA = "0x18181CF80")]
		public void OnAudioOutFrame(float[] data, int outChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220")]
		public void PrintInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x181C120", Offset = "0x181B320", VA = "0x18181C120")]
		private void DestroyEchoState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x181C210", Offset = "0x181B410", VA = "0x18181C210", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class SpeexLib
	{
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private const string lib_name = "libspeexdsp";

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public const int SPEEX_PREPROCESS_SET_DENOISE = 0;

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public const int SPEEX_PREPROCESS_GET_DENOISE = 1;

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public const int SPEEX_PREPROCESS_SET_AGC = 2;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public const int SPEEX_PREPROCESS_GET_AGC = 3;

		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public const int SPEEX_PREPROCESS_SET_VAD = 4;

		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public const int SPEEX_PREPROCESS_GET_VAD = 5;

		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public const int SPEEX_PREPROCESS_SET_AGC_LEVEL = 6;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		public const int SPEEX_PREPROCESS_GET_AGC_LEVEL = 7;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB = 8;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB = 9;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB_LEVEL = 10;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB_LEVEL = 11;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public const int SPEEX_PREPROCESS_SET_DEREVERB_DECAY = 12;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public const int SPEEX_PREPROCESS_GET_DEREVERB_DECAY = 13;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public const int SPEEX_PREPROCESS_SET_PROB_START = 14;

		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public const int SPEEX_PREPROCESS_GET_PROB_START = 15;

		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public const int SPEEX_PREPROCESS_SET_PROB_CONTINUE = 16;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public const int SPEEX_PREPROCESS_GET_PROB_CONTINUE = 17;

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public const int SPEEX_PREPROCESS_SET_NOISE_SUPPRESS = 18;

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public const int SPEEX_PREPROCESS_GET_NOISE_SUPPRESS = 19;

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public const int SPEEX_PREPROCESS_SET_ECHO_SUPPRESS = 20;

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public const int SPEEX_PREPROCESS_GET_ECHO_SUPPRESS = 21;

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public const int SPEEX_PREPROCESS_SET_ECHO_SUPPRESS_ACTIVE = 22;

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public const int SPEEX_PREPROCESS_GET_ECHO_SUPPRESS_ACTIVE = 23;

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public const int SPEEX_PREPROCESS_SET_ECHO_STATE = 24;

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public const int SPEEX_PREPROCESS_GET_ECHO_STATE = 25;

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public const int SPEEX_PREPROCESS_SET_AGC_INCREMENT = 26;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public const int SPEEX_PREPROCESS_GET_AGC_INCREMENT = 27;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		public const int SPEEX_PREPROCESS_SET_AGC_DECREMENT = 28;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		public const int SPEEX_PREPROCESS_GET_AGC_DECREMENT = 29;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		public const int SPEEX_PREPROCESS_SET_AGC_MAX_GAIN = 30;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		public const int SPEEX_PREPROCESS_GET_AGC_MAX_GAIN = 31;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public const int SPEEX_PREPROCESS_GET_AGC_LOUDNESS = 33;

		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		public const int SPEEX_PREPROCESS_GET_AGC_GAIN = 35;

		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		public const int SPEEX_PREPROCESS_GET_PSD_SIZE = 37;

		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		public const int SPEEX_PREPROCESS_GET_PSD = 39;

		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public const int SPEEX_PREPROCESS_GET_NOISE_PSD_SIZE = 41;

		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public const int SPEEX_PREPROCESS_GET_NOISE_PSD = 43;

		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public const int SPEEX_PREPROCESS_GET_PROB = 45;

		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		public const int SPEEX_PREPROCESS_SET_AGC_TARGET = 46;

		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		public const int SPEEX_PREPROCESS_GET_AGC_TARGET = 47;

		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public const int SPEEX_ECHO_GET_FRAME_SIZE = 3;

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public const int SPEEX_ECHO_SET_SAMPLING_RATE = 24;

		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public const int SPEEX_ECHO_GET_SAMPLING_RATE = 25;

		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public const int SPEEX_ECHO_GET_IMPULSE_RESPONSE_SIZE = 27;

		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public const int SPEEX_ECHO_GET_IMPULSE_RESPONSE = 29;

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x181BFF0", Offset = "0x181B1F0", VA = "0x18181BFF0")]
		public static extern IntPtr speex_preprocess_state_init(int frame_size, int sampling_rate);

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x181BF60", Offset = "0x181B160", VA = "0x18181BF60")]
		public static extern void speex_preprocess_state_destroy(IntPtr st);

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x181BEB0", Offset = "0x181B0B0", VA = "0x18181BEB0")]
		public static extern int speex_preprocess_run(IntPtr st, short[] x);

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x181BBA0", Offset = "0x181ADA0", VA = "0x18181BBA0")]
		public static extern int speex_preprocess_ctl(IntPtr st, int request, IntPtr ptr);

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x181BD70", Offset = "0x181AF70", VA = "0x18181BD70")]
		public static int speex_preprocess_ctl(IntPtr st, int request, ref int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x181BC50", Offset = "0x181AE50", VA = "0x18181BC50")]
		public static int speex_preprocess_ctl(IntPtr st, int request, ref float value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x181B9B0", Offset = "0x181ABB0", VA = "0x18181B9B0")]
		public static extern IntPtr speex_echo_state_init(int frame_size, int filter_length);

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x181BA50", Offset = "0x181AC50", VA = "0x18181BA50")]
		public static extern IntPtr speex_echo_state_init_mc(int frame_size, int filter_length, int nb_mic, int nb_speakers);

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x181B920", Offset = "0x181AB20", VA = "0x18181B920")]
		public static extern void speex_echo_state_destroy(IntPtr st);

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x181B380", Offset = "0x181A580", VA = "0x18181B380")]
		public static extern void speex_echo_cancellation(IntPtr st, short[] rec, short[] play, short[] outBuf);

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x181B460", Offset = "0x181A660", VA = "0x18181B460")]
		public static extern void speex_echo_capture(IntPtr st, short[] rec, short[] outBuf);

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x181B870", Offset = "0x181AA70", VA = "0x18181B870")]
		public static extern void speex_echo_playback(IntPtr st, short[] play);

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x181BB10", Offset = "0x181AD10", VA = "0x18181BB10")]
		public static extern void speex_echo_state_reset(IntPtr st);

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x181B530", Offset = "0x181A730", VA = "0x18181B530")]
		public static extern int speex_echo_ctl(IntPtr st, int request, IntPtr ptr);

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x181B730", Offset = "0x181A930", VA = "0x18181B730")]
		public static int speex_echo_ctl(IntPtr st, int request, ref int value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x181B5E0", Offset = "0x181A7E0", VA = "0x18181B5E0")]
		public static int speex_echo_ctl(IntPtr st, int request, ref float value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
		public SpeexLib()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public interface IDataReader<T> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool Read(T[] buffer);
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public interface IServiceable
	{
		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Service(LocalVoice localVoice);
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public class LocalVoice : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		public const int DATA_POOL_CAPACITY = 50;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private bool debugEchoMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		internal VoiceInfo info;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		protected IEncoder encoder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		internal byte id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		internal int channelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		internal byte evNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		protected VoiceClient voiceClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		protected bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		protected object disposeLock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private int noTransmitCnt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		internal Dictionary<byte, int> eventTimestamps;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public byte Group
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x397FF0", Offset = "0x3971F0", VA = "0x180397FF0")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x3ACEA0", Offset = "0x3AC0A0", VA = "0x1803ACEA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public VoiceInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x1B73200", Offset = "0x1B72400", VA = "0x181B73200")]
			get
			{
				return default(VoiceInfo);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool Transmit
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x49AA40", Offset = "0x499C40", VA = "0x18049AA40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x49AA20", Offset = "0x499C20", VA = "0x18049AA20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public bool IsTransmitting
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x49AA50", Offset = "0x499C50", VA = "0x18049AA50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x49AA70", Offset = "0x499C70", VA = "0x18049AA70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public int FramesSent
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x3B1490", Offset = "0x3B0690", VA = "0x1803B1490")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x3B14B0", Offset = "0x3B06B0", VA = "0x1803B14B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public int FramesSentBytes
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x3B1470", Offset = "0x3B0670", VA = "0x1803B1470")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x3B1590", Offset = "0x3B0790", VA = "0x1803B1590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool Reliable
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x42F180", Offset = "0x42E380", VA = "0x18042F180")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x49AA80", Offset = "0x499C80", VA = "0x18049AA80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool Encrypt
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0xA8D980", Offset = "0xA8CB80", VA = "0x180A8D980")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0xA8D990", Offset = "0xA8CB90", VA = "0x180A8D990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public object LocalUserObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x3827E0", Offset = "0x3819E0", VA = "0x1803827E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x3B1450", Offset = "0x3B0650", VA = "0x1803B1450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public IServiceable LocalUserServiceable
		{
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x38FF90", Offset = "0x38F190", VA = "0x18038FF90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x3B12D0", Offset = "0x3B04D0", VA = "0x1803B12D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public bool DebugEchoMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x387660", Offset = "0x386860", VA = "0x180387660")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x1B738E0", Offset = "0x1B72AE0", VA = "0x181B738E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		internal string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0x1B73270", Offset = "0x1B72470", VA = "0x181B73270")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		internal string LogPrefix
		{
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x1B73220", Offset = "0x1B72420", VA = "0x181B73220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x1B73170", Offset = "0x1B72370", VA = "0x181B73170")]
		internal LocalVoice()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x1B73080", Offset = "0x1B72280", VA = "0x181B73080")]
		internal LocalVoice(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x1B73470", Offset = "0x1B72670", VA = "0x181B73470")]
		protected void resetNoTransmitCnt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x1B73610", Offset = "0x1B72810", VA = "0x181B73610", Slot = "5")]
		internal virtual void service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x1B73480", Offset = "0x1B72680", VA = "0x181B73480")]
		internal void sendFrame(ArraySegment<byte> compressed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x1B73050", Offset = "0x1B72250", VA = "0x181B73050")]
		public void RemoveSelf()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x1B72FE0", Offset = "0x1B721E0", VA = "0x181B72FE0", Slot = "6")]
		public virtual void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public struct RemoteVoiceOptions
	{
		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Action<byte[]> OnDecodedFrameByteAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x134FA0", Offset = "0x1343A0", VA = "0x180134FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x134F90", Offset = "0x134390", VA = "0x180134F90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public Action<float[]> OnDecodedFrameFloatAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x134F70", Offset = "0x134370", VA = "0x180134F70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x134F80", Offset = "0x134380", VA = "0x180134F80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Action<short[]> OnDecodedFrameShortAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x13C350", Offset = "0x13B750", VA = "0x18013C350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x13C340", Offset = "0x13B740", VA = "0x18013C340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Action OnRemoteVoiceRemoveAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x1590E0", Offset = "0x1584E0", VA = "0x1801590E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x159100", Offset = "0x158500", VA = "0x180159100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public object LocalUserObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x17CD80", Offset = "0x17C180", VA = "0x18017CD80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x22D590", Offset = "0x22C990", VA = "0x18022D590")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public IDecoder Decoder
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x1756F0", Offset = "0x174AF0", VA = "0x1801756F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x22D580", Offset = "0x22C980", VA = "0x18022D580")]
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
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		internal RemoteVoiceOptions options;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private int channelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private int playerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private byte voiceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private bool disposed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private object disposeLock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		internal byte lastEvNumber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private VoiceClient voiceClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private Queue<byte[]> frameQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private AutoResetEvent frameQueueReady;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		internal VoiceInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0xBB22D0", Offset = "0xBB14D0", VA = "0x180BB22D0")]
			[CompilerGenerated]
			get
			{
				return default(VoiceInfo);
			}
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x181AFE0", Offset = "0x181A1E0", VA = "0x18181AFE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		protected string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x1B76380", Offset = "0x1B75580", VA = "0x181B76380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected string LogPrefix
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x1B76330", Offset = "0x1B75530", VA = "0x181B76330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x1B751B0", Offset = "0x1B743B0", VA = "0x181B751B0")]
		internal RemoteVoice(VoiceClient client, RemoteVoiceOptions options, int channelId, int playerId, byte voiceId, VoiceInfo info, byte lastEventNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x1B75440", Offset = "0x1B74640", VA = "0x181B75440")]
		private static byte byteDiff(byte latest, byte last)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x1B76660", Offset = "0x1B75860", VA = "0x181B76660")]
		internal void receiveBytes(byte[] receivedBytes, byte evNumber)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x1B76B80", Offset = "0x1B75D80", VA = "0x181B76B80")]
		private void receiveFrame(byte[] frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x1B76D60", Offset = "0x1B75F60", VA = "0x181B76D60")]
		private void receiveNullFrames(int count)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x1B75C80", Offset = "0x1B74E80", VA = "0x181B75C80")]
		private void decodeThread(IDecoder decoder)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x1B75A70", Offset = "0x1B74C70", VA = "0x181B75A70")]
		private void decodeFrame(IDecoder decoder, byte[] frame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x1B75450", Offset = "0x1B74650", VA = "0x181B75450")]
		internal byte[] decodeFrameToByte(byte[] buffer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x1B75860", Offset = "0x1B74A60", VA = "0x181B75860")]
		internal short[] decodeFrameToShort(byte[] buffer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x1B75650", Offset = "0x1B74850", VA = "0x181B75650")]
		internal float[] decodeFrameToFloat(byte[] buffer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x1B76F50", Offset = "0x1B76150", VA = "0x181B76F50")]
		internal void removeAndDispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x1B75090", Offset = "0x1B74290", VA = "0x181B75090", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public interface IAudioSource : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		int SamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		int Channels
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
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
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SetCallback(Action<T[]> callback, LocalVoice localVoice);
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public interface ILocalVoiceAudio
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		AudioUtil.IVoiceDetector VoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		AudioUtil.ILevelMeter LevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		bool VoiceDetectorCalibrating
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VoiceDetectorCalibrate(int durationMs);
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public static class LocalVoiceAudio
	{
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		public static LocalVoiceAudioDummy Dummy;

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1236800", Offset = "0x1235A00", VA = "0x181236800")]
		public static LocalVoiceAudio<T> Create<T>(VoiceClient voiceClient, byte voiceId, IEncoder encoder, VoiceInfo voiceInfo, int channelId)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public abstract class LocalVoiceAudio<T> : LocalVoiceFramed<T>, ILocalVoiceAudio
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		protected AudioUtil.VoiceDetector<T> voiceDetector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		protected AudioUtil.VoiceDetectorCalibration<T> voiceDetectorCalibration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		protected AudioUtil.LevelMeter<T> levelMeter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		protected int channels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		protected int sourceSamplingRateHz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		protected bool resampleSource;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual AudioUtil.IVoiceDetector VoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x3FFC70", Offset = "0x3FEE70", VA = "0x1803FFC70", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public virtual AudioUtil.ILevelMeter LevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0x3A4C00", Offset = "0x3A3E00", VA = "0x1803A4C00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool VoiceDetectorCalibrating
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x1A1AEC0", Offset = "0x1A1A0C0", VA = "0x181A1AEC0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x1A19EA0", Offset = "0x1A190A0", VA = "0x181A19EA0", Slot = "10")]
		public void VoiceDetectorCalibrate(int durationMs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x1A1A970", Offset = "0x1A19B70", VA = "0x181A1A970")]
		internal LocalVoiceAudio(VoiceClient voiceClient, IEncoderDataFlow<T> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x1A1AEF0", Offset = "0x1A1A0F0", VA = "0x181A1AEF0")]
		protected void initBuiltinProcessors()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class LocalVoiceAudioDummy : LocalVoice, ILocalVoiceAudio
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private AudioUtil.VoiceDetectorDummy voiceDetector;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private AudioUtil.LevelMetterDummy levelMeter;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public AudioUtil.IVoiceDetector VoiceDetector
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x43BB50", Offset = "0x43AD50", VA = "0x18043BB50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public AudioUtil.ILevelMeter LevelMeter
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x45A9E0", Offset = "0x459BE0", VA = "0x18045A9E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public bool VoiceDetectorCalibrating
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x38FEF0", Offset = "0x38F0F0", VA = "0x18038FEF0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220", Slot = "10")]
		public void VoiceDetectorCalibrate(int durationMs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x1B71A50", Offset = "0x1B70C50", VA = "0x181B71A50")]
		public LocalVoiceAudioDummy()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public class LocalVoiceAudioFloat : LocalVoiceAudio<float>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x1B71B30", Offset = "0x1B70D30", VA = "0x181B71B30")]
		internal LocalVoiceAudioFloat(VoiceClient voiceClient, IEncoderDataFlow<float> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	public class LocalVoiceAudioShort : LocalVoiceAudio<short>
	{
		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x1B71CD0", Offset = "0x1B70ED0", VA = "0x181B71CD0")]
		internal LocalVoiceAudioShort(VoiceClient voiceClient, IEncoderDataFlow<short> encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	internal enum EventSubcode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		VoiceInfo = 1,
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		VoiceRemove,
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		Frame
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	internal enum EventParam : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		VoiceId = 1,
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		SamplingRate = 2,
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		Channels = 3,
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		FrameDurationUs = 4,
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		Bitrate = 5,
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		UserData = 10,
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		EventNumber = 11,
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		Codec = 12
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public interface ILogger
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LogError(string fmt, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LogWarning(string fmt, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LogInfo(string fmt, params object[] args);

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void LogDebug(string fmt, params object[] args);
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	internal interface IVoiceFrontend : ILogger
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int AssignChannel(VoiceInfo v);

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool IsChannelJoined(int channelId);

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId);

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId);

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice);

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		string ChannelIdStr(int channelId);

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		string PlayerIdStr(int playerId);

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
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
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004AA")]
			private RemoteVoiceInfo <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004AB")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004AC")]
			public VoiceClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004AD")]
			private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004AE")]
			private KeyValuePair<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> <channelVoices>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40004AF")]
			private Dictionary<int, Dictionary<byte, RemoteVoice>>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40004B0")]
			private KeyValuePair<int, Dictionary<byte, RemoteVoice>> <playerVoices>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40004B1")]
			private Dictionary<byte, RemoteVoice>.Enumerator <>7__wrap5;

			[Cpp2IlInjected.Token(Token = "0x17000109")]
			RemoteVoiceInfo IEnumerator<RemoteVoiceInfo>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005AE")]
				[Cpp2IlInjected.Address(RVA = "0x3821C0", Offset = "0x3813C0", VA = "0x1803821C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700010A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005B0")]
				[Cpp2IlInjected.Address(RVA = "0x3821C0", Offset = "0x3813C0", VA = "0x1803821C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0x8EC530", Offset = "0x8EB730", VA = "0x1808EC530")]
			[DebuggerHidden]
			public <get_RemoteVoiceInfos>d__39(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x1822D40", Offset = "0x1821F40", VA = "0x181822D40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AA")]
			[Cpp2IlInjected.Address(RVA = "0x1822810", Offset = "0x1821A10", VA = "0x181822810", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005AB")]
			[Cpp2IlInjected.Address(RVA = "0x1822EB0", Offset = "0x18220B0", VA = "0x181822EB0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AC")]
			[Cpp2IlInjected.Address(RVA = "0x1822EF0", Offset = "0x18220F0", VA = "0x181822EF0")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AD")]
			[Cpp2IlInjected.Address(RVA = "0x1822F30", Offset = "0x1822130", VA = "0x181822F30")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0x1822CF0", Offset = "0x1821EF0", VA = "0x181822CF0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0x1822C50", Offset = "0x1821E50", VA = "0x181822C50", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<RemoteVoiceInfo> IEnumerable<RemoteVoiceInfo>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0x1822C50", Offset = "0x1821E50", VA = "0x181822C50", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40004B2")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004B3")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004B4")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004B5")]
			public VoiceClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004B6")]
			private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40004B7")]
			private Dictionary<int, Dictionary<byte, RemoteVoice>>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40004B8")]
			private Dictionary<byte, RemoteVoice>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.Token(Token = "0x1700010B")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005B9")]
				[Cpp2IlInjected.Address(RVA = "0x3821C0", Offset = "0x3813C0", VA = "0x1803821C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700010C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005BB")]
				[Cpp2IlInjected.Address(RVA = "0x3821C0", Offset = "0x3813C0", VA = "0x1803821C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0x8EC530", Offset = "0x8EB730", VA = "0x1808EC530")]
			[DebuggerHidden]
			public <get_RemoteVoiceLocalUserObjects>d__41(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0x18233D0", Offset = "0x18225D0", VA = "0x1818233D0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0x1822F80", Offset = "0x1822180", VA = "0x181822F80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005B6")]
			[Cpp2IlInjected.Address(RVA = "0x1823540", Offset = "0x1822740", VA = "0x181823540")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B7")]
			[Cpp2IlInjected.Address(RVA = "0x1823580", Offset = "0x1822780", VA = "0x181823580")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005B8")]
			[Cpp2IlInjected.Address(RVA = "0x18235C0", Offset = "0x18227C0", VA = "0x1818235C0")]
			private void <>m__Finally3()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BA")]
			[Cpp2IlInjected.Address(RVA = "0x1823380", Offset = "0x1822580", VA = "0x181823380", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005BC")]
			[Cpp2IlInjected.Address(RVA = "0x18232E0", Offset = "0x18224E0", VA = "0x1818232E0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<object> IEnumerable<object>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005BD")]
			[Cpp2IlInjected.Address(RVA = "0x18232E0", Offset = "0x18224E0", VA = "0x1818232E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		internal IVoiceFrontend frontend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private int prevRtt;

		[Cpp2IlInjected.Token(Token = "0x400020C")]
		public const int ChannelAuto = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private byte globalGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private byte voiceIdCnt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private Dictionary<byte, LocalVoice> localVoices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private Dictionary<int, List<LocalVoice>> localVoicesPerChannel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private Dictionary<int, Dictionary<int, Dictionary<byte, RemoteVoice>>> remoteVoices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private System.Random rnd;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public int FramesLost
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x3B1470", Offset = "0x3B0670", VA = "0x1803B1470")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x3B1590", Offset = "0x3B0790", VA = "0x1803B1590")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public int FramesReceived
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x3B15A0", Offset = "0x3B07A0", VA = "0x1803B15A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x3B1480", Offset = "0x3B0680", VA = "0x1803B1480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int FramesSent
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x1826040", Offset = "0x1825240", VA = "0x181826040")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public int FramesSentBytes
		{
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x1825EA0", Offset = "0x18250A0", VA = "0x181825EA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public int RoundTripTime
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x3B15B0", Offset = "0x3B07B0", VA = "0x1803B15B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x3B14A0", Offset = "0x3B06A0", VA = "0x1803B14A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public int RoundTripTimeVariance
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x3B48A0", Offset = "0x3B3AA0", VA = "0x1803B48A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x3B4950", Offset = "0x3B3B50", VA = "0x1803B4950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool SuppressInfoDuplicateWarning
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x426EB0", Offset = "0x4260B0", VA = "0x180426EB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x426CC0", Offset = "0x425EC0", VA = "0x180426CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public RemoteVoiceInfoDelegate OnRemoteVoiceInfoAction
		{
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x3B6C30", Offset = "0x3B5E30", VA = "0x1803B6C30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x444780", Offset = "0x443980", VA = "0x180444780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public int DebugLostPercent
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x444AD0", Offset = "0x443CD0", VA = "0x180444AD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public IEnumerable<LocalVoice> LocalVoices
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x18261E0", Offset = "0x18253E0", VA = "0x1818261E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public IEnumerable<RemoteVoiceInfo> RemoteVoiceInfos
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x1826280", Offset = "0x1825480", VA = "0x181826280")]
			[IteratorStateMachine(typeof(<get_RemoteVoiceInfos>d__39))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public IEnumerable<object> RemoteVoiceLocalUserObjects
		{
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x18262F0", Offset = "0x18254F0", VA = "0x1818262F0")]
			[IteratorStateMachine(typeof(<get_RemoteVoiceLocalUserObjects>d__41))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		internal byte GlobalGroup
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x4CC280", Offset = "0x4CB480", VA = "0x1804CC280")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x1828AC0", Offset = "0x1827CC0", VA = "0x181828AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x1823F50", Offset = "0x1823150", VA = "0x181823F50")]
		public IEnumerable<LocalVoice> LocalVoicesInChannel(int channelId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x1824390", Offset = "0x1823590", VA = "0x181824390")]
		internal VoiceClient(IVoiceFrontend frontend)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x1824200", Offset = "0x1823400", VA = "0x181824200")]
		public void Service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x1825940", Offset = "0x1824B40", VA = "0x181825940")]
		private LocalVoice createLocalVoice(VoiceInfo voiceInfo, int channelId, Func<byte, int, LocalVoice> voiceFactory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x18238D0", Offset = "0x1822AD0", VA = "0x1818238D0")]
		public LocalVoice CreateLocalVoice(VoiceInfo voiceInfo, int channelId = -1, [Optional] IEncoder encoder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x1244370", Offset = "0x1243570", VA = "0x181244370")]
		public LocalVoiceFramed<T> CreateLocalVoiceFramed<T>(VoiceInfo voiceInfo, int frameSize, int channelId = -1, [Optional] IEncoderDataFlow<T> encoder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x1243EF0", Offset = "0x12430F0", VA = "0x181243EF0")]
		public LocalVoiceAudio<T> CreateLocalVoiceAudio<T>(VoiceInfo voiceInfo, int channelId = -1, [Optional] IEncoderDataFlow<T> encoder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x1825C60", Offset = "0x1824E60", VA = "0x181825C60")]
		private byte getNewVoiceId()
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x1824470", Offset = "0x1823670", VA = "0x181824470")]
		private void addVoice(byte newId, int channelId, LocalVoice v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1824020", Offset = "0x1823220", VA = "0x181824020")]
		public void RemoveLocalVoice(LocalVoice voice)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x18288A0", Offset = "0x1827AA0", VA = "0x1818288A0")]
		internal void sendVoicesInfo(int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x18287E0", Offset = "0x18279E0", VA = "0x1818287E0")]
		internal void sendChannelVoicesInfo(int channelId, int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x1826C00", Offset = "0x1825E00", VA = "0x181826C00")]
		internal void onVoiceEvent(object content0, int channelId, int playerId, int localPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x1824840", Offset = "0x1823A40", VA = "0x181824840")]
		internal object[] buildVoicesInfo(IEnumerable<LocalVoice> voicesToSend, bool logInfo)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x1824610", Offset = "0x1823810", VA = "0x181824610")]
		internal object[] buildVoiceRemoveMessage(LocalVoice v)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x18254D0", Offset = "0x18246D0", VA = "0x1818254D0")]
		internal void clearRemoteVoices()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x1825150", Offset = "0x1824350", VA = "0x181825150")]
		internal void clearRemoteVoicesInChannel(int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x1827040", Offset = "0x1826240", VA = "0x181827040")]
		private void onVoiceInfo(int channelId, int playerId, object payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x18279C0", Offset = "0x1826BC0", VA = "0x1818279C0")]
		private void onVoiceRemove(int channelId, int playerId, object payload)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x1826360", Offset = "0x1825560", VA = "0x181826360")]
		private void onFrame(int channelId, int playerId, byte voiceId, byte evNumber, byte[] receivedBytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x1828670", Offset = "0x1827870", VA = "0x181828670")]
		internal bool removePlayerVoices(int playerId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x1828450", Offset = "0x1827650", VA = "0x181828450")]
		internal bool removePlayerVoices(int channelId, int playerId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x1824F10", Offset = "0x1824110", VA = "0x181824F10")]
		internal string channelStr(int channelId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x1828210", Offset = "0x1827410", VA = "0x181828210")]
		internal string playerStr(int playerId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x18239E0", Offset = "0x1822BE0", VA = "0x1818239E0", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ArraySegment<byte> EncodeAndGetOutput(T[] buf);
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public interface IEncoderNativeImageDirect : IEncoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ArraySegment<byte>> EncodeAndGetOutput(IntPtr[] buf, int width, int height, int[] stride, ImageFormat imageFormat, Rotation rotation, Flip flip);
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public interface IEncoderQueued : IEncoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<ArraySegment<byte>> GetOutput();
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public interface IDecoder : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Open(VoiceInfo info);
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public interface IDecoderDirect : IDecoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		byte[] DecodeToByte(byte[] buf);

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		float[] DecodeToFloat(byte[] buf);

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		short[] DecodeToShort(byte[] buf);
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public interface IDecoderQueued : IDecoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Decode(byte[] buf);
	}
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	public delegate void OnImageOutputNative(IntPtr buf, int width, int height, int stride);
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	public interface IDecoderQueuedOutputImageNative : IDecoderQueued, IDecoder, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000074")]
		ImageFormat OutputImageFormat
		{
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		Flip OutputImageFlip
		{
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		Func<int, int, IntPtr> OutputImageBufferGetter
		{
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(Slot = "5")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		OnImageOutputNative OnOutputImage
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(Slot = "7")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal class UnsupportedSampleTypeException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x1823850", Offset = "0x1822A50", VA = "0x181823850")]
		public UnsupportedSampleTypeException(Type t)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	internal class UnsupportedCodecException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x1823610", Offset = "0x1822810", VA = "0x181823610")]
		public UnsupportedCodecException(Codec codec, LocalVoice voice)
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public enum Codec
	{
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		AudioOpus = 11
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	public enum ImageFormat
	{
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		I420,
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		YV12,
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		Android420,
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		RGBA,
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		ABGR,
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		BGRA,
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		ARGB
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public enum Rotation
	{
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		Rotate0 = 0,
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		Rotate90 = 90,
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		Rotate180 = 180,
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		Rotate270 = 270
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public enum Flip
	{
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		Vertical,
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		Horizontal
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class ImageBufferInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public int Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x3AFFF0", Offset = "0x3AF1F0", VA = "0x1803AFFF0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x3AFF80", Offset = "0x3AF180", VA = "0x1803AFF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public int Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x3B1490", Offset = "0x3B0690", VA = "0x1803B1490")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x3B14B0", Offset = "0x3B06B0", VA = "0x1803B14B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public int[] Stride
		{
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x3821C0", Offset = "0x3813C0", VA = "0x1803821C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x3B1460", Offset = "0x3B0660", VA = "0x1803B1460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public ImageFormat Format
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x3B15B0", Offset = "0x3B07B0", VA = "0x1803B15B0")]
			[CompilerGenerated]
			get
			{
				return default(ImageFormat);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x3B14A0", Offset = "0x3B06A0", VA = "0x1803B14A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Rotation Rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x3B48A0", Offset = "0x3B3AA0", VA = "0x1803B48A0")]
			[CompilerGenerated]
			get
			{
				return default(Rotation);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x3B4950", Offset = "0x3B3B50", VA = "0x1803B4950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public Flip Flip
		{
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x3B4940", Offset = "0x3B3B40", VA = "0x1803B4940")]
			[CompilerGenerated]
			get
			{
				return default(Flip);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x3B4890", Offset = "0x3B3A90", VA = "0x1803B4890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x1B67830", Offset = "0x1B66A30", VA = "0x181B67830")]
		public ImageBufferInfo(int width, int height, int[] stride, ImageFormat format)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public class ImageBufferNative
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public ImageBufferInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x3823A0", Offset = "0x3815A0", VA = "0x1803823A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x3AFCB0", Offset = "0x3AEEB0", VA = "0x1803AFCB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public IntPtr[] Planes
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x3821C0", Offset = "0x3813C0", VA = "0x1803821C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x3B1460", Offset = "0x3B0660", VA = "0x1803B1460")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x3AFCC0", Offset = "0x3AEEC0", VA = "0x1803AFCC0")]
		public ImageBufferNative(ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220", Slot = "4")]
		public virtual void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220", Slot = "5")]
		public virtual void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public class ImageBufferNativeAlloc : ImageBufferNative, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private ImageBufferNativePool<ImageBufferNativeAlloc> pool;

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x1B67970", Offset = "0x1B66B70", VA = "0x181B67970")]
		public ImageBufferNativeAlloc(ImageBufferNativePool<ImageBufferNativeAlloc> pool, ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x1B67950", Offset = "0x1B66B50", VA = "0x181B67950", Slot = "4")]
		public override void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x1B67880", Offset = "0x1B66A80", VA = "0x181B67880", Slot = "5")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public class ImageBufferNativeGCHandleSinglePlane : ImageBufferNative, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private GCHandle planeHandle;

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x1B67B60", Offset = "0x1B66D60", VA = "0x181B67B60")]
		public ImageBufferNativeGCHandleSinglePlane(ImageBufferNativePool<ImageBufferNativeGCHandleSinglePlane> pool, ImageBufferInfo info)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x1B67AB0", Offset = "0x1B66CB0", VA = "0x181B67AB0")]
		public void PinPlane(byte[] plane)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x1B67B20", Offset = "0x1B66D20", VA = "0x181B67B20", Slot = "4")]
		public override void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220", Slot = "5")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	internal static class VoiceCodec
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x1828CB0", Offset = "0x1827EB0", VA = "0x181828CB0")]
		internal static IEncoder CreateDefaultEncoder(VoiceInfo info, LocalVoice localVoice)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x1828C50", Offset = "0x1827E50", VA = "0x181828C50")]
		internal static IDecoder CreateDefaultDecoder(int channelId, int playerId, byte voiceId, VoiceInfo info)
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public enum ProcessorQueue
	{
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		RawSignalReading = 0,
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		GainAdjustment = 100,
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		GainAdjustedSignalReading = 200,
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		Resampling = 300,
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		SignalProcessing = 400,
		[Cpp2IlInjected.Token(Token = "0x4000237")]
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
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			private T[] <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C5")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C6")]
			public Framer<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C7")]
			private T[] buf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C8")]
			public T[] <>3__buf;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C9")]
			private int <s>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CA")]
			private int <bufPos>5__3;

			[Cpp2IlInjected.Token(Token = "0x1700010D")]
			private T[] System.Collections.Generic.IEnumerator<T[]>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005C7")]
				[Cpp2IlInjected.Address(RVA = "0x3821C0", Offset = "0x3813C0", VA = "0x1803821C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700010E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60005C9")]
				[Cpp2IlInjected.Address(RVA = "0x3821C0", Offset = "0x3813C0", VA = "0x1803821C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60005C4")]
			[Cpp2IlInjected.Address(RVA = "0xFEB7E0", Offset = "0xFEA9E0", VA = "0x180FEB7E0")]
			[DebuggerHidden]
			public <Frame>d__5(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0x382220", Offset = "0x381420", VA = "0x180382220", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x1A1BF40", Offset = "0x1A1B140", VA = "0x181A1BF40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0x1A1C200", Offset = "0x1A1B400", VA = "0x181A1C200", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x1A1C0B0", Offset = "0x1A1B2B0", VA = "0x181A1C0B0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<T[]> System.Collections.Generic.IEnumerable<T[]>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x103E9E0", Offset = "0x103DBE0", VA = "0x18103E9E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private T[] frame;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private int sizeofT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private int framePos;

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x1A16AF0", Offset = "0x1A15CF0", VA = "0x181A16AF0")]
		public Framer(int frameSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x1A16A20", Offset = "0x1A15C20", VA = "0x181A16A20")]
		public int Count(int bufLen)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x1A16A50", Offset = "0x1A15C50", VA = "0x181A16A50")]
		[IteratorStateMachine(typeof(Framer<>.<Frame>d__5))]
		public IEnumerable<T[]> Frame(T[] buf)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class LocalVoiceFramed : LocalVoice
	{
		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public int FrameSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0xD752F0", Offset = "0xD744F0", VA = "0x180D752F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x11AD730", Offset = "0x11AC930", VA = "0x1811AD730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x1B71F90", Offset = "0x1B71190", VA = "0x181B71F90")]
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
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			T[] Process(T[] buf);
		}

		[Cpp2IlInjected.Token(Token = "0x200010E")]
		private struct ProcessorEntry : IComparable<ProcessorEntry>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CB")]
			public IProcessor processor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CC")]
			public int priority;

			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x178970", Offset = "0x177D70", VA = "0x180178970", Slot = "4")]
			public int CompareTo(ProcessorEntry other)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private Framer<T> framer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private List<ProcessorEntry> processors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private bool dataEncodeThreadStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private Queue<T[]> pushDataQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private AutoResetEvent pushDataQueueReady;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private PrimitiveArrayPool<T> pushDataBufferPool;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private int framesSkipped;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private bool exitThread;

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public PrimitiveArrayPool<T> PushDataBufferPool
		{
			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x3FFEA0", Offset = "0x3FF0A0", VA = "0x1803FFEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool PushDataAsyncReady
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x14251A0", Offset = "0x14243A0", VA = "0x1814251A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x14254A0", Offset = "0x14246A0", VA = "0x1814254A0")]
		internal T[] processFrame(T[] buf)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x1420E00", Offset = "0x1420000", VA = "0x181420E00")]
		public void AddProcessor(ProcessorQueue queue, params IProcessor[] newProcessors)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x14212E0", Offset = "0x14204E0", VA = "0x1814212E0")]
		public void ClearProcessors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x14249C0", Offset = "0x1423BC0", VA = "0x1814249C0")]
		internal LocalVoiceFramed(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId, int frameSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x1423270", Offset = "0x1422470", VA = "0x181423270")]
		public void PushDataAsync(T[] buf)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x1422510", Offset = "0x1421710", VA = "0x181422510")]
		private void PushDataAsyncThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x1423EE0", Offset = "0x14230E0", VA = "0x181423EE0")]
		public void PushData(T[] buf)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x14217E0", Offset = "0x14209E0", VA = "0x1814217E0", Slot = "6")]
		public override void Dispose()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 40)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public struct VoiceInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Codec Codec
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x137B00", Offset = "0x136F00", VA = "0x180137B00")]
			[CompilerGenerated]
			get
			{
				return default(Codec);
			}
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x14A850", Offset = "0x149C50", VA = "0x18014A850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public int SamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x137AF0", Offset = "0x136EF0", VA = "0x180137AF0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x14A930", Offset = "0x149D30", VA = "0x18014A930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public int SourceSamplingRate
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x13BED0", Offset = "0x13B2D0", VA = "0x18013BED0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x19C3B0", Offset = "0x19B7B0", VA = "0x18019C3B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public int Channels
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x15AF70", Offset = "0x15A370", VA = "0x18015AF70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x22D640", Offset = "0x22CA40", VA = "0x18022D640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public int FrameDurationUs
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x135A00", Offset = "0x134E00", VA = "0x180135A00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x22D650", Offset = "0x22CA50", VA = "0x18022D650")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public int Bitrate
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x150360", Offset = "0x14F760", VA = "0x180150360")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x22D630", Offset = "0x22CA30", VA = "0x18022D630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public object UserData
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x1590E0", Offset = "0x1584E0", VA = "0x1801590E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x159100", Offset = "0x158500", VA = "0x180159100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public int FrameDurationSamples
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x22D5D0", Offset = "0x22C9D0", VA = "0x18022D5D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public int FrameSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x22D600", Offset = "0x22CA00", VA = "0x18022D600")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public int Width
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x17CD50", Offset = "0x17C150", VA = "0x18017CD50")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x22D670", Offset = "0x22CA70", VA = "0x18022D670")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public int Height
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x15AFA0", Offset = "0x15A3A0", VA = "0x18015AFA0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x22D660", Offset = "0x22CA60", VA = "0x18022D660")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x1828DA0", Offset = "0x1827FA0", VA = "0x181828DA0")]
		public static VoiceInfo CreateAudioOpus(SamplingRate samplingRate, int sourceSamplingRate, int channels, OpusCodec.FrameDuration frameDurationUs, int bitrate, [Optional] object userdata)
		{
			return default(VoiceInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x22D5C0", Offset = "0x22C9C0", VA = "0x18022D5C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x1828E00", Offset = "0x1828000", VA = "0x181828E00")]
		internal static VoiceInfo CreateFromEventPayload(Dictionary<byte, object> h)
		{
			return default(VoiceInfo);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	public class RemoteVoiceInfo
	{
		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public VoiceInfo Info
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0xBB22D0", Offset = "0xBB14D0", VA = "0x180BB22D0")]
			[CompilerGenerated]
			get
			{
				return default(VoiceInfo);
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x181AFE0", Offset = "0x181A1E0", VA = "0x18181AFE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public int ChannelId
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x444AD0", Offset = "0x443CD0", VA = "0x180444AD0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int PlayerId
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x38FF10", Offset = "0x38F110", VA = "0x18038FF10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x6BF690", Offset = "0x6BE890", VA = "0x1806BF690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public byte VoiceId
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x4CC280", Offset = "0x4CB480", VA = "0x1804CC280")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x54DC70", Offset = "0x54CE70", VA = "0x18054DC70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public object LocalUserObject
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x38EBF0", Offset = "0x38DDF0", VA = "0x18038EBF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x398CA0", Offset = "0x397EA0", VA = "0x180398CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x181AF70", Offset = "0x181A170", VA = "0x18181AF70")]
		internal RemoteVoiceInfo(int channelId, int playerId, byte voiceId, VoiceInfo info, object localUserObject)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public abstract class BufferReaderPushAdapterBase<T> : IServiceable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		protected IDataReader<T> reader;

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void Service(LocalVoice localVoice);

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0xFF4F90", Offset = "0xFF4190", VA = "0x180FF4F90")]
		public BufferReaderPushAdapterBase(IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x1A10C70", Offset = "0x1A0FE70", VA = "0x181A10C70")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public class BufferReaderPushAdapter<T> : BufferReaderPushAdapterBase<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		protected T[] buffer;

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x1A10E70", Offset = "0x1A10070", VA = "0x181A10E70")]
		public BufferReaderPushAdapter(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x1A10CC0", Offset = "0x1A0FEC0", VA = "0x181A10CC0", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public class BufferReaderPushAdapterAsyncPool<T> : BufferReaderPushAdapterBase<T>
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x1A10BA0", Offset = "0x1A0FDA0", VA = "0x181A10BA0")]
		public BufferReaderPushAdapterAsyncPool(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x1A10990", Offset = "0x1A0FB90", VA = "0x181A10990", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class BufferReaderPushAdapterAsyncPoolCopy<T> : BufferReaderPushAdapterBase<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		protected T[] buffer;

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x1A10890", Offset = "0x1A0FA90", VA = "0x181A10890")]
		public BufferReaderPushAdapterAsyncPoolCopy(LocalVoice localVoice, IDataReader<T> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x1A106C0", Offset = "0x1A0F8C0", VA = "0x181A106C0", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public class BufferReaderPushAdapterAsyncPoolFloatToShort : BufferReaderPushAdapterBase<float>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private float[] buffer;

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x1B656E0", Offset = "0x1B648E0", VA = "0x181B656E0")]
		public BufferReaderPushAdapterAsyncPoolFloatToShort(LocalVoice localVoice, IDataReader<float> reader)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x1B65460", Offset = "0x1B64660", VA = "0x181B65460", Slot = "5")]
		public override void Service(LocalVoice localVoice)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public class LocalVoiceVideo : LocalVoice
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private bool imageEncodeThreadStarted;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private Queue<ImageBufferNative> pushImageQueue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private AutoResetEvent pushImageQueueReady;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private bool exitThread;

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public int PushImageQueueCount
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x1B72F90", Offset = "0x1B72190", VA = "0x181B72F90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x1B72E60", Offset = "0x1B72060", VA = "0x181B72E60")]
		internal LocalVoiceVideo(VoiceClient voiceClient, IEncoder encoder, byte id, VoiceInfo voiceInfo, int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x1B72760", Offset = "0x1B71960", VA = "0x181B72760")]
		public void PushImageAsync(ImageBufferNative buf)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x1B721A0", Offset = "0x1B713A0", VA = "0x181B721A0")]
		private void PushImageAsyncThread()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x1B72A10", Offset = "0x1B71C10", VA = "0x181B72A10")]
		public void PushImage(IntPtr[] buf, int width, int height, int[] stride, ImageFormat imageFormat, Rotation rotation = Rotation.Rotate0, Flip flip = Flip.None)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x1B72000", Offset = "0x1B71200", VA = "0x181B72000", Slot = "6")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	internal class VoiceEventCode
	{
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public const byte Code0 = 201;

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x1828D60", Offset = "0x1827F60", VA = "0x181828D60")]
		public static byte GetCode(int channelID)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x1828D70", Offset = "0x1827F70", VA = "0x181828D70")]
		public static bool TryGetChannelID(byte evCode, int maxChannels, out byte channelID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
		public VoiceEventCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class LoadBalancingFrontend : LoadBalancingClient, IVoiceFrontend, ILogger, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		protected VoiceClient voiceClient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private object sendLock;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public VoiceClient VoiceClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x3FFD50", Offset = "0x3FEF50", VA = "0x1803FFD50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public new Action<EventData> OnEventAction
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x3FF370", Offset = "0x3FE570", VA = "0x1803FF370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x53D460", Offset = "0x53C660", VA = "0x18053D460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public new Action<ClientState> OnStateChangeAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x3FF720", Offset = "0x3FE920", VA = "0x1803FF720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x600B20", Offset = "0x5FFD20", VA = "0x180600B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public byte GlobalAudioGroup
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x1B6EDF0", Offset = "0x1B6DFF0", VA = "0x181B6EDF0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x1B6F360", Offset = "0x1B6E560", VA = "0x181B6F360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x1B6DEA0", Offset = "0x1B6D0A0", VA = "0x181B6DEA0", Slot = "27")]
		public void LogError(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x1B6DF20", Offset = "0x1B6D120", VA = "0x181B6DF20", Slot = "28")]
		public void LogWarning(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x1B6DEE0", Offset = "0x1B6D0E0", VA = "0x181B6DEE0", Slot = "29")]
		public void LogInfo(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x1B6DE60", Offset = "0x1B6D060", VA = "0x181B6DE60", Slot = "30")]
		public void LogDebug(string fmt, params object[] args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x1B6DD30", Offset = "0x1B6CF30", VA = "0x181B6DD30", Slot = "19")]
		public int AssignChannel(VoiceInfo v)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x1B6DE50", Offset = "0x1B6D050", VA = "0x181B6DE50", Slot = "20")]
		public bool IsChannelJoined(int channelId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x1B6EA60", Offset = "0x1B6DC60", VA = "0x181B6EA60", Slot = "26")]
		public void SetDebugEchoMode(LocalVoice v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x1B6EB60", Offset = "0x1B6DD60", VA = "0x181B6EB60")]
		public LoadBalancingFrontend(ConnectionProtocol connectionProtocol = ConnectionProtocol.Udp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x1B6EA20", Offset = "0x1B6DC20", VA = "0x181B6EA20")]
		public new void Service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x1B6DDF0", Offset = "0x1B6CFF0", VA = "0x181B6DDF0", Slot = "32")]
		public virtual bool ChangeAudioGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x1B6E690", Offset = "0x1B6D890", VA = "0x181B6E690", Slot = "21")]
		public void SendVoicesInfo(IEnumerable<LocalVoice> voices, int channelId, int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x1B6DF60", Offset = "0x1B6D160", VA = "0x181B6DF60")]
		public void SendDebugEchoVoicesInfo(int channelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x1B6E450", Offset = "0x1B6D650", VA = "0x181B6E450", Slot = "22")]
		public void SendVoiceRemove(LocalVoice voice, int channelId, int targetPlayerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x1B6E0C0", Offset = "0x1B6D2C0", VA = "0x181B6E0C0", Slot = "23")]
		public void SendFrame(ArraySegment<byte> data, byte evNumber, byte voiceId, int channelId, LocalVoice localVoice)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E80", Offset = "0x3A5080", VA = "0x1803A5E80", Slot = "24")]
		public string ChannelIdStr(int channelId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x3A5E80", Offset = "0x3A5080", VA = "0x1803A5E80", Slot = "25")]
		public string PlayerIdStr(int playerId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x1B6EE20", Offset = "0x1B6E020", VA = "0x181B6EE20")]
		private void onEventActionVoiceClient(EventData ev)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x1B6F1F0", Offset = "0x1B6E3F0", VA = "0x181B6F1F0")]
		private void onStateChangeVoiceClient(ClientState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x1B6F120", Offset = "0x1B6E320", VA = "0x181B6F120")]
		private void onPlayerLeave(int playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x1B6DE20", Offset = "0x1B6D020", VA = "0x181B6DE20", Slot = "31")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public class AudioInEnumerator : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private const string lib_name = "AudioIn";

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private IntPtr handle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public readonly bool IsSupported;

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x1B635A0", Offset = "0x1B627A0", VA = "0x181B635A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x1B62FA0", Offset = "0x1B621A0", VA = "0x181B62FA0")]
		private static extern IntPtr Photon_Audio_In_CreateMicEnumerator();

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x1B63030", Offset = "0x1B62230", VA = "0x181B63030")]
		private static extern void Photon_Audio_In_DestroyMicEnumerator(IntPtr handle);

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x1B630D0", Offset = "0x1B622D0", VA = "0x181B630D0")]
		private static extern int Photon_Audio_In_MicEnumerator_Count(IntPtr handle);

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x1B63220", Offset = "0x1B62420", VA = "0x181B63220")]
		private static extern IntPtr Photon_Audio_In_MicEnumerator_NameAtIndex(IntPtr handle, int idx);

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x1B63170", Offset = "0x1B62370", VA = "0x181B63170")]
		private static extern int Photon_Audio_In_MicEnumerator_IDAtIndex(IntPtr handle, int idx);

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x1B63430", Offset = "0x1B62630", VA = "0x181B63430")]
		public AudioInEnumerator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x1B632D0", Offset = "0x1B624D0", VA = "0x181B632D0")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x1B62EB0", Offset = "0x1B620B0", VA = "0x181B62EB0")]
		public string NameAtIndex(int idx)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x1B62DF0", Offset = "0x1B61FF0", VA = "0x181B62DF0")]
		public int IDAtIndex(int idx)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x1B62EA0", Offset = "0x1B620A0", VA = "0x181B62EA0")]
		public bool IDIsValid(int id)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x1B62D10", Offset = "0x1B61F10", VA = "0x181B62D10", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x1B66E90", Offset = "0x1B66090", VA = "0x181B66E90")]
		public static void Merge(this IDictionary target, IDictionary addHash)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x1B66C20", Offset = "0x1B65E20", VA = "0x181B66C20")]
		public static void MergeStringKeys(this IDictionary target, IDictionary addHash)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x1B67630", Offset = "0x1B66830", VA = "0x181B67630")]
		public static string ToStringFull(this IDictionary origin)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x1B67690", Offset = "0x1B66890", VA = "0x181B67690")]
		public static string ToStringFull(this object[] data)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x1B673E0", Offset = "0x1B665E0", VA = "0x181B673E0")]
		public static Hashtable StripToStringKeys(this IDictionary original)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x1B67180", Offset = "0x1B66380", VA = "0x181B67180")]
		public static void StripKeysWithNullValues(this IDictionary original)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0xAA3C50", Offset = "0xAA2E50", VA = "0x180AA3C50")]
		public static bool Contains(this int[] target, int nr)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	public class FriendInfo
	{
		[Cpp2IlInjected.Token(Token = "0x17000099")]
		[Obsolete]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x3823A0", Offset = "0x3815A0", VA = "0x1803823A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x3823A0", Offset = "0x3815A0", VA = "0x1803823A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x3AFCB0", Offset = "0x3AEEB0", VA = "0x1803AFCB0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public bool IsOnline
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x494CC0", Offset = "0x493EC0", VA = "0x180494CC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x494D30", Offset = "0x493F30", VA = "0x180494D30")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public string Room
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x3827E0", Offset = "0x3819E0", VA = "0x1803827E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x3B1450", Offset = "0x3B0650", VA = "0x1803B1450")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public bool IsInRoom
		{
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0xBE9CB0", Offset = "0xBE8EB0", VA = "0x180BE9CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x1B677B0", Offset = "0x1B669B0", VA = "0x181B677B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
		public FriendInfo()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	public enum ClientState
	{
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		PeerCreated = 0,
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		Authenticating = 1,
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		Authenticated = 2,
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		JoinedLobby = 3,
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		DisconnectingFromMasterserver = 4,
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		ConnectingToGameserver = 5,
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		ConnectedToGameserver = 6,
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		Joining = 7,
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		Joined = 8,
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		Leaving = 9,
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		DisconnectingFromGameserver = 10,
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		ConnectingToMasterserver = 11,
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		Disconnecting = 12,
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		Disconnected = 13,
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		ConnectedToMasterserver = 14,
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		[Obsolete]
		ConnectedToMaster = 14,
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		ConnectingToNameServer = 15,
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		ConnectedToNameServer = 16,
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		DisconnectingFromNameServer = 17
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	internal enum JoinType
	{
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		CreateRoom,
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		JoinRoom,
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		JoinRandomRoom,
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		JoinOrCreateRoom
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public enum DisconnectCause
	{
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		DisconnectByServerUserLimit,
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		ExceptionOnConnect,
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		DisconnectByServer,
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		TimeoutDisconnect,
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		Exception,
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		InvalidAuthentication,
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		MaxCcuReached,
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		InvalidRegion,
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		OperationNotAllowedInCurrentState,
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		CustomAuthenticationFailed,
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		DisconnectByServerLogic,
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		AuthenticationTicketExpired
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	public enum ServerConnection
	{
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		MasterServer,
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		GameServer,
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		NameServer
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public enum EncryptionMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		PayloadEncryption = 0,
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		DatagramEncryption = 10,
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		DatagramEncryptionRandomSequence = 11
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	public static class EncryptionDataParameters
	{
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public const byte Mode = 0;

		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public const byte Secret1 = 1;

		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public const byte Secret2 = 2;
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	public class LoadBalancingClient : IPhotonPeerListener
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public LoadBalancingPeer loadBalancingPeer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public AuthModeOption AuthMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public EncryptionMode EncryptionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private ConnectionProtocol ExpectedProtocol;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public string NameServerHost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public string NameServerHttp;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private static readonly Dictionary<ConnectionProtocol, int> ProtocolToNameServerPort;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private ClientState state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private bool inLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private bool autoJoinLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x91")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public bool EnableLobbyStatistics;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private List<TypedLobbyInfo> lobbyStatistics;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public Dictionary<string, RoomInfo> RoomInfoList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public Room CurrentRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private JoinType lastJoinType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		protected internal EnterRoomParams enterRoomParamsCache;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private bool didAuthenticate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private string[] friendListRequested;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private int friendListTimestamp;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private bool isFetchingFriendList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private byte[] encryptionSecret;

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public string AppVersion
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x3821C0", Offset = "0x3813C0", VA = "0x1803821C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x3B1460", Offset = "0x3B0660", VA = "0x1803B1460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public string AppId
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x3827E0", Offset = "0x3819E0", VA = "0x1803827E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x3B1450", Offset = "0x3B0650", VA = "0x1803B1450")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public AuthenticationValues AuthValues
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x38FF90", Offset = "0x38F190", VA = "0x18038FF90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x3B12D0", Offset = "0x3B04D0", VA = "0x1803B12D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public ConnectionProtocol TransportProtocol
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x1B6D950", Offset = "0x1B6CB50", VA = "0x181B6D950")]
			get
			{
				return default(ConnectionProtocol);
			}
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x1B6DBD0", Offset = "0x1B6CDD0", VA = "0x181B6DBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Dictionary<ConnectionProtocol, Type> SocketImplementationConfig
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x1B0DF70", Offset = "0x1B0D170", VA = "0x181B0DF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		private string TokenForInit
		{
			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x1B6D930", Offset = "0x1B6CB30", VA = "0x181B6D930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public bool IsUsingNameServer
		{
			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x42BB00", Offset = "0x42AD00", VA = "0x18042BB00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x49AA10", Offset = "0x499C10", VA = "0x18049AA10")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public string NameServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x1B6D760", Offset = "0x1B6C960", VA = "0x181B6D760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public string CurrentServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x1B6D640", Offset = "0x1B6C840", VA = "0x181B6D640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public string MasterServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x3D0CC0", Offset = "0x3CFEC0", VA = "0x1803D0CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x467AA0", Offset = "0x466CA0", VA = "0x180467AA0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public string GameServerAddress
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x3BAEF0", Offset = "0x3BA0F0", VA = "0x1803BAEF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x3BA1E0", Offset = "0x3B93E0", VA = "0x1803BA1E0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public ServerConnection Server
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x467810", Offset = "0x466A10", VA = "0x180467810")]
			[CompilerGenerated]
			get
			{
				return default(ServerConnection);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x467AB0", Offset = "0x466CB0", VA = "0x180467AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public ClientState State
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x6A09B0", Offset = "0x69FBB0", VA = "0x1806A09B0")]
			get
			{
				return default(ClientState);
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x1B6DB80", Offset = "0x1B6CD80", VA = "0x181B6DB80")]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public bool IsConnected
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x1B6D740", Offset = "0x1B6C940", VA = "0x181B6D740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool IsConnectedAndReady
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x1B6D6D0", Offset = "0x1B6C8D0", VA = "0x181B6D6D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public DisconnectCause DisconnectedCause
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x481D40", Offset = "0x480F40", VA = "0x180481D40")]
			[CompilerGenerated]
			get
			{
				return default(DisconnectCause);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x7D9C90", Offset = "0x7D8E90", VA = "0x1807D9C90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public TypedLobby CurrentLobby
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x3FF950", Offset = "0x3FEB50", VA = "0x1803FF950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x456CB0", Offset = "0x455EB0", VA = "0x180456CB0")]
			[CompilerGenerated]
			protected internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool AutoJoinLobby
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x43FA40", Offset = "0x43EC40", VA = "0x18043FA40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x757B20", Offset = "0x756D20", VA = "0x180757B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public List<TypedLobbyInfo> LobbyStatistics
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x44FFE0", Offset = "0x44F1E0", VA = "0x18044FFE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x5FA840", Offset = "0x5F9A40", VA = "0x1805FA840")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public Player LocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x43BB50", Offset = "0x43AD50", VA = "0x18043BB50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x5FC300", Offset = "0x5FB500", VA = "0x1805FC300")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public string NickName
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x1B6D900", Offset = "0x1B6CB00", VA = "0x181B6D900")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x1B6DB60", Offset = "0x1B6CD60", VA = "0x181B6DB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x1B6D970", Offset = "0x1B6CB70", VA = "0x181B6D970")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x1B6DCB0", Offset = "0x1B6CEB0", VA = "0x181B6DCB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public int PlayersOnMasterCount
		{
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x8B8EC0", Offset = "0x8B80C0", VA = "0x1808B8EC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x8BA1C0", Offset = "0x8B93C0", VA = "0x1808BA1C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public int PlayersInRoomsCount
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x8B9450", Offset = "0x8B8650", VA = "0x1808B9450")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x8BA010", Offset = "0x8B9210", VA = "0x1808BA010")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public int RoomsCount
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE20", Offset = "0x5FA020", VA = "0x1805FAE20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x5FC2F0", Offset = "0x5FB4F0", VA = "0x1805FC2F0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public List<FriendInfo> FriendList
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x3FFEB0", Offset = "0x3FF0B0", VA = "0x1803FFEB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x4728A0", Offset = "0x471AA0", VA = "0x1804728A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public int FriendListAge
		{
			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x1B6D660", Offset = "0x1B6C860", VA = "0x181B6D660")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		protected bool IsAuthorizeSecretAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x1B6D6A0", Offset = "0x1B6C8A0", VA = "0x181B6D6A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public string[] AvailableRegions
		{
			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x3A4C00", Offset = "0x3A3E00", VA = "0x1803A4C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x3A11A0", Offset = "0x3A03A0", VA = "0x1803A11A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public string[] AvailableRegionsServers
		{
			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x5E1800", Offset = "0x5E0A00", VA = "0x1805E1800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x391C90", Offset = "0x390E90", VA = "0x180391C90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public string CloudRegion
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x4042D0", Offset = "0x4034D0", VA = "0x1804042D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x403700", Offset = "0x402900", VA = "0x180403700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ClientState> OnStateChangeAction
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x1B6D5A0", Offset = "0x1B6C7A0", VA = "0x181B6D5A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x1B6DAC0", Offset = "0x1B6CCC0", VA = "0x181B6DAC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action<EventData> OnEventAction
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x1B6D460", Offset = "0x1B6C660", VA = "0x181B6D460")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x1B6D980", Offset = "0x1B6CB80", VA = "0x181B6D980")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<OperationResponse> OnOpResponseAction
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x1B6D500", Offset = "0x1B6C700", VA = "0x181B6D500")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x1B6DA20", Offset = "0x1B6CC20", VA = "0x181B6DA20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x1B6D210", Offset = "0x1B6C410", VA = "0x181B6D210")]
		public LoadBalancingClient(ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x1B6D410", Offset = "0x1B6C610", VA = "0x181B6D410")]
		public LoadBalancingClient(string masterAddress, string appId, string gameVersion, ConnectionProtocol protocol = ConnectionProtocol.Udp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x1B68EB0", Offset = "0x1B680B0", VA = "0x181B68EB0")]
		private string GetNameServerAddress()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x1B68750", Offset = "0x1B67950", VA = "0x181B68750")]
		public bool Connect(string masterServerAddress, string appId, string appVersion, string nickName, AuthenticationValues authValues)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x1B686A0", Offset = "0x1B678A0", VA = "0x181B686A0", Slot = "8")]
		public virtual bool Connect()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x1B68420", Offset = "0x1B67620", VA = "0x181B68420")]
		public bool ConnectToNameServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x1B68550", Offset = "0x1B67750", VA = "0x181B68550")]
		public bool ConnectToRegionMaster(string region)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x1B68BA0", Offset = "0x1B67DA0", VA = "0x181B68BA0")]
		public void Disconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x1B680B0", Offset = "0x1B672B0", VA = "0x181B680B0")]
		private bool CallAuthenticate()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x1B6CDF0", Offset = "0x1B6BFF0", VA = "0x181B6CDF0")]
		public void Service()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x1B68AB0", Offset = "0x1B67CB0", VA = "0x181B68AB0")]
		private void DisconnectToReconnect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x1B68380", Offset = "0x1B67580", VA = "0x181B68380")]
		private bool ConnectToGameServer()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x1B6B6A0", Offset = "0x1B6A8A0", VA = "0x181B6B6A0")]
		public bool OpGetRegions()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x1B6B390", Offset = "0x1B6A590", VA = "0x181B6B390")]
		public bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x1B6B6F0", Offset = "0x1B6A8F0", VA = "0x181B6B6F0")]
		public bool OpJoinLobby(TypedLobby lobby)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x12DA880", Offset = "0x12D9A80", VA = "0x1812DA880")]
		public bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x1B6B8B0", Offset = "0x1B6AAB0", VA = "0x181B6B8B0")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x1B6BAF0", Offset = "0x1B6ACF0", VA = "0x181B6BAF0")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x1B6B960", Offset = "0x1B6AB60", VA = "0x181B6B960")]
		public bool OpJoinRandomRoom(Hashtable expectedCustomRoomProperties, byte expectedMaxPlayers, MatchmakingMode matchmakingMode, TypedLobby lobby, string sqlLobbyFilter, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x1B6BBA0", Offset = "0x1B6ADA0", VA = "0x181B6BBA0")]
		public bool OpJoinRoom(string roomName, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x1B6BED0", Offset = "0x1B6B0D0", VA = "0x181B6BED0")]
		public bool OpReJoinRoom(string roomName)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x1B6B7A0", Offset = "0x1B6A9A0", VA = "0x181B6B7A0")]
		public bool OpJoinOrCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x1B6B280", Offset = "0x1B6A480", VA = "0x181B6B280")]
		public bool OpCreateRoom(string roomName, RoomOptions roomOptions, TypedLobby lobby, [Optional] string[] expectedUsers)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x1B6BCA0", Offset = "0x1B6AEA0", VA = "0x181B6BCA0")]
		public bool OpLeaveRoom()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x1B6BD30", Offset = "0x1B6AF30", VA = "0x181B6BD30")]
		public bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x1B6B670", Offset = "0x1B6A870", VA = "0x181B6B670")]
		public bool OpGetGameList(TypedLobby typedLobby, string sqlLobbyFilter)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x1B6BFC0", Offset = "0x1B6B1C0", VA = "0x181B6BFC0")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x1B6C290", Offset = "0x1B6B490", VA = "0x181B6C290")]
		[Obsolete]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x1B6C4D0", Offset = "0x1B6B6D0", VA = "0x181B6C4D0")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x1B6C340", Offset = "0x1B6B540", VA = "0x181B6C340")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x1B6C3E0", Offset = "0x1B6B5E0", VA = "0x181B6C3E0")]
		[Obsolete]
		public bool OpSetCustomPropertiesOfRoom(Hashtable propertiesToSet, Hashtable expectedProperties, bool webForward)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x1B6C610", Offset = "0x1B6B810", VA = "0x181B6C610")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x1B6BEA0", Offset = "0x1B6B0A0", VA = "0x181B6BEA0", Slot = "9")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x1B6BDF0", Offset = "0x1B6AFF0", VA = "0x181B6BDF0", Slot = "10")]
		[Obsolete]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, bool sendReliable, RaiseEventOptions raiseEventOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x1B6B260", Offset = "0x1B6A460", VA = "0x181B6B260", Slot = "11")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x1B6C950", Offset = "0x1B6BB50", VA = "0x181B6C950")]
		private void ReadoutProperties(Hashtable gameProperties, Hashtable actorProperties, int targetActorNr)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x1B6C850", Offset = "0x1B6BA50", VA = "0x181B6C850")]
		private Hashtable ReadoutPropertiesForActorNr(Hashtable actorProperties, int actorNr)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x1B68170", Offset = "0x1B67370", VA = "0x181B68170")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x1B682E0", Offset = "0x1B674E0", VA = "0x181B682E0")]
		private void CleanCachedValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x1B68C20", Offset = "0x1B67E20", VA = "0x181B68C20")]
		private void GameEnteredOnGameServer(OperationResponse operationResponse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x1B6D020", Offset = "0x1B6C220", VA = "0x181B6D020")]
		private void UpdatedActorList(int[] actorsInGame)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x1B68810", Offset = "0x1B67A10", VA = "0x181B68810", Slot = "12")]
		protected internal virtual Player CreatePlayer(string actorName, int actorNumber, bool isLocal, Hashtable actorProperties)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x1B688A0", Offset = "0x1B67AA0", VA = "0x181B688A0", Slot = "13")]
		protected internal virtual Room CreateRoom(string roomName, RoomOptions opt)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x1B68990", Offset = "0x1B67B90", VA = "0x181B68990", Slot = "14")]
		public virtual void DebugReturn(DebugLevel level, string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x1B69C70", Offset = "0x1B68E70", VA = "0x181B69C70", Slot = "15")]
		public virtual void OnOperationResponse(OperationResponse operationResponse)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x1B6AB50", Offset = "0x1B69D50", VA = "0x181B6AB50", Slot = "16")]
		public virtual void OnStatusChanged(StatusCode statusCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x1B69080", Offset = "0x1B68280", VA = "0x181B69080", Slot = "17")]
		public virtual void OnEvent(EventData photonEvent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x1B69C10", Offset = "0x1B68E10", VA = "0x181B69C10", Slot = "18")]
		public virtual void OnMessage(object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x1B6CE10", Offset = "0x1B6C010", VA = "0x181B6CE10")]
		private void SetupEncryption(Dictionary<byte, object> encryptionData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x1B6C730", Offset = "0x1B6B930", VA = "0x181B6C730")]
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
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			CheckUserOnJoin = 1,
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			DeleteCacheOnLeave = 2,
			[Cpp2IlInjected.Token(Token = "0x40004D2")]
			SuppressRoomEvents = 4,
			[Cpp2IlInjected.Token(Token = "0x40004D3")]
			PublishUserId = 8,
			[Cpp2IlInjected.Token(Token = "0x40004D4")]
			DeleteNullProps = 0x10,
			[Cpp2IlInjected.Token(Token = "0x40004D5")]
			BroadcastPropsChangeToAll = 0x20
		}

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected internal static Type PingImplementation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private readonly Dictionary<byte, object> opParameters;

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x1B718C0", Offset = "0x1B70AC0", VA = "0x181B718C0")]
		public LoadBalancingPeer(ConnectionProtocol protocolType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x1B71960", Offset = "0x1B70B60", VA = "0x181B71960")]
		public LoadBalancingPeer(IPhotonPeerListener listener, ConnectionProtocol protocolType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x1B6F4A0", Offset = "0x1B6E6A0", VA = "0x181B6F4A0")]
		[Conditional("UNITY")]
		private void ConfigUnitySockets()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x1B70270", Offset = "0x1B6F470", VA = "0x181B70270", Slot = "15")]
		public virtual bool OpGetRegions(string appId)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x1B70340", Offset = "0x1B6F540", VA = "0x181B70340", Slot = "16")]
		public virtual bool OpJoinLobby([Optional] TypedLobby lobby)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x1B70A00", Offset = "0x1B6FC00", VA = "0x181B70A00", Slot = "17")]
		public virtual bool OpLeaveLobby()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x1B714E0", Offset = "0x1B706E0", VA = "0x181B714E0")]
		private void RoomOptionsToOpParameters(Dictionary<byte, object> op, RoomOptions roomOptions)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x1B6FD90", Offset = "0x1B6EF90", VA = "0x181B6FD90", Slot = "18")]
		public virtual bool OpCreateRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x1B70750", Offset = "0x1B6F950", VA = "0x181B70750", Slot = "19")]
		public virtual bool OpJoinRoom(EnterRoomParams opParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x1B70490", Offset = "0x1B6F690", VA = "0x181B70490", Slot = "20")]
		public virtual bool OpJoinRandomRoom(OpJoinRandomRoomParams opJoinRandomRoomParams)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x1B70AB0", Offset = "0x1B6FCB0", VA = "0x181B70AB0", Slot = "21")]
		public virtual bool OpLeaveRoom(bool becomeInactive, bool sendAuthCookie = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x1B700A0", Offset = "0x1B6F2A0", VA = "0x181B700A0", Slot = "22")]
		public virtual bool OpGetGameList(TypedLobby lobby, string queryData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x1B6FFD0", Offset = "0x1B6F1D0", VA = "0x181B6FFD0", Slot = "23")]
		public virtual bool OpFindFriends(string[] friendsToFind)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x1B70E70", Offset = "0x1B70070", VA = "0x181B70E70")]
		public bool OpSetCustomPropertiesOfActor(int actorNr, Hashtable actorProperties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x1B70EF0", Offset = "0x1B700F0", VA = "0x181B70EF0")]
		protected internal bool OpSetPropertiesOfActor(int actorNr, Hashtable actorProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x1B712C0", Offset = "0x1B704C0", VA = "0x181B712C0")]
		protected void OpSetPropertyOfRoom(byte propCode, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x1B70EB0", Offset = "0x1B700B0", VA = "0x181B70EB0")]
		public bool OpSetCustomPropertiesOfRoom(Hashtable gameProperties)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x1B71120", Offset = "0x1B70320", VA = "0x181B71120")]
		protected internal bool OpSetPropertiesOfRoom(Hashtable gameProperties, [Optional] Hashtable expectedProperties, [Optional] WebFlags webflags)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x1B6F9D0", Offset = "0x1B6EBD0", VA = "0x181B6F9D0", Slot = "24")]
		public virtual bool OpAuthenticate(string appId, string appVersion, AuthenticationValues authValues, string regionCode, bool getLobbyStatistics)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x1B6F710", Offset = "0x1B6E910", VA = "0x181B6F710", Slot = "25")]
		public virtual bool OpAuthenticateOnce(string appId, string appVersion, AuthenticationValues authValues, string regionCode, EncryptionMode encryptionMode, ConnectionProtocol expectedProtocol)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x1B6FC60", Offset = "0x1B6EE60", VA = "0x181B6FC60", Slot = "26")]
		public virtual bool OpChangeGroups(byte[] groupsToRemove, byte[] groupsToAdd)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x1B70BE0", Offset = "0x1B6FDE0", VA = "0x181B70BE0", Slot = "27")]
		public virtual bool OpRaiseEvent(byte eventCode, object customEventContent, RaiseEventOptions raiseEventOptions, SendOptions sendOptions)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x1B71380", Offset = "0x1B70580", VA = "0x181B71380", Slot = "28")]
		public virtual bool OpSettings(bool receiveLobbyStats)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public class OpJoinRandomRoomParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public Hashtable ExpectedCustomRoomProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public byte ExpectedMaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public MatchmakingMode MatchingType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public TypedLobby TypedLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public string SqlLobbyFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public string[] ExpectedUsers;

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
		public OpJoinRandomRoomParams()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	public class EnterRoomParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		public string RoomName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		public RoomOptions RoomOptions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public TypedLobby Lobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public Hashtable PlayerProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public bool OnGameServer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public bool CreateIfNotExists;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public bool RejoinOnly;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public string[] ExpectedUsers;

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x740790", Offset = "0x73F990", VA = "0x180740790")]
		public EnterRoomParams()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public class ErrorCode
	{
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public const int Ok = 0;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public const int OperationNotAllowedInCurrentState = -3;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		[Obsolete]
		public const int InvalidOperationCode = -2;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public const int InvalidOperation = -2;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public const int InternalServerError = -1;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public const int InvalidAuthentication = 32767;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public const int GameIdAlreadyExists = 32766;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public const int GameFull = 32765;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		public const int GameClosed = 32764;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		[Obsolete]
		public const int AlreadyMatched = 32763;

		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		public const int ServerFull = 32762;

		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		public const int UserBlocked = 32761;

		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public const int NoRandomMatchFound = 32760;

		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public const int GameDoesNotExist = 32758;

		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public const int MaxCcuReached = 32757;

		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public const int InvalidRegion = 32756;

		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public const int CustomAuthenticationFailed = 32755;

		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public const int AuthenticationTicketExpired = 32753;

		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public const int PluginReportedError = 32752;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		public const int PluginMismatch = 32751;

		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		public const int JoinFailedPeerAlreadyJoined = 32750;

		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		public const int JoinFailedFoundInactiveJoiner = 32749;

		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		public const int JoinFailedWithRejoinerNotFound = 32748;

		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public const int JoinFailedFoundExcludedUserId = 32747;

		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public const int JoinFailedFoundActiveJoiner = 32746;

		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public const int HttpLimitReached = 32745;

		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public const int ExternalHttpCallFailed = 32744;

		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		public const int SlotError = 32742;

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		public const int InvalidEncryptionParameters = 32741;

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
		public ErrorCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public class ActorProperties
	{
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public const byte PlayerName = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public const byte IsInactive = 254;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public const byte UserId = 253;

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
		public ActorProperties()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public class GamePropertyKey
	{
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public const byte MaxPlayers = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public const byte IsVisible = 254;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public const byte IsOpen = 253;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public const byte PlayerCount = 252;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public const byte Removed = 251;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public const byte PropsListedInLobby = 250;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public const byte CleanupCacheOnLeave = 249;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public const byte MasterClientId = 248;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public const byte ExpectedUsers = 247;

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
		public GamePropertyKey()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public class EventCode
	{
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public const byte GameList = 230;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public const byte GameListUpdate = 229;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public const byte QueueState = 228;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		public const byte Match = 227;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public const byte AppStats = 226;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		public const byte LobbyStats = 224;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[Obsolete]
		public const byte AzureNodeInfo = 210;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		public const byte Join = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public const byte Leave = 254;

		[Cpp2IlInjected.Token(Token = "0x4000302")]
		public const byte PropertiesChanged = 253;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		[Obsolete]
		public const byte SetProperties = 253;

		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public const byte ErrorInfo = 251;

		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public const byte CacheSliceChanged = 250;

		[Cpp2IlInjected.Token(Token = "0x4000306")]
		public const byte AuthEvent = 223;

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
		public EventCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public class ParameterCode
	{
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		public const byte SuppressRoomEvents = 237;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public const byte EmptyRoomTTL = 236;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		public const byte PlayerTTL = 235;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		public const byte EventForward = 234;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[Obsolete]
		public const byte IsComingBack = 233;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public const byte IsInactive = 233;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public const byte CheckUserOnJoin = 232;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public const byte ExpectedValues = 231;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public const byte Address = 230;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public const byte PeerCount = 229;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public const byte GameCount = 228;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public const byte MasterPeerCount = 227;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public const byte UserId = 225;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public const byte ApplicationId = 224;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public const byte Position = 223;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public const byte MatchMakingType = 223;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public const byte GameList = 222;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public const byte Secret = 221;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public const byte AppVersion = 220;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[Obsolete]
		public const byte AzureNodeInfo = 210;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		[Obsolete]
		public const byte AzureLocalNodeId = 209;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		[Obsolete]
		public const byte AzureMasterNodeId = 208;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public const byte RoomName = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		public const byte Broadcast = 250;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public const byte ActorList = 252;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		public const byte ActorNr = 254;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public const byte PlayerProperties = 249;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		public const byte CustomEventContent = 245;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		public const byte Data = 245;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		public const byte Code = 244;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		public const byte GameProperties = 248;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public const byte Properties = 251;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public const byte TargetActorNr = 253;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public const byte ReceiverGroup = 246;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public const byte Cache = 247;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public const byte CleanupCacheOnLeave = 241;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public const byte Group = 240;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public const byte Remove = 239;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public const byte PublishUserId = 239;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public const byte Add = 238;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public const byte Info = 218;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public const byte ClientAuthenticationType = 217;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public const byte ClientAuthenticationParams = 216;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public const byte JoinMode = 215;

		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public const byte ClientAuthenticationData = 214;

		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public const byte MasterClientId = 203;

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		public const byte FindFriendsRequestList = 1;

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		public const byte FindFriendsResponseOnlineList = 1;

		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public const byte FindFriendsResponseRoomIdList = 2;

		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public const byte LobbyName = 213;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		public const byte LobbyType = 212;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		public const byte LobbyStats = 211;

		[Cpp2IlInjected.Token(Token = "0x400033B")]
		public const byte Region = 210;

		[Cpp2IlInjected.Token(Token = "0x400033C")]
		public const byte UriPath = 209;

		[Cpp2IlInjected.Token(Token = "0x400033D")]
		public const byte WebRpcParameters = 208;

		[Cpp2IlInjected.Token(Token = "0x400033E")]
		public const byte WebRpcReturnCode = 207;

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		public const byte WebRpcReturnMessage = 206;

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		public const byte CacheSliceIndex = 205;

		[Cpp2IlInjected.Token(Token = "0x4000341")]
		public const byte Plugins = 204;

		[Cpp2IlInjected.Token(Token = "0x4000342")]
		public const byte NickName = 202;

		[Cpp2IlInjected.Token(Token = "0x4000343")]
		public const byte PluginName = 201;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		public const byte PluginVersion = 200;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		public const byte ExpectedProtocol = 195;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		public const byte CustomInitData = 194;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public const byte EncryptionMode = 193;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public const byte EncryptionData = 192;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		public const byte RoomOptionFlags = 191;

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
		public ParameterCode()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public class OperationCode
	{
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		[Obsolete]
		public const byte ExchangeKeysForEncryption = 250;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		[Obsolete]
		public const byte Join = byte.MaxValue;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		public const byte AuthenticateOnce = 231;

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		public const byte Authenticate = 230;

		[Cpp2IlInjected.Token(Token = "0x400034E")]
		public const byte JoinLobby = 229;

		[Cpp2IlInjected.Token(Token = "0x400034F")]
		public const byte LeaveLobby = 228;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		public const byte CreateGame = 227;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public const byte JoinGame = 226;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public const byte JoinRandomGame = 225;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public const byte Leave = 254;

		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public const byte RaiseEvent = 253;

		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public const byte SetProperties = 252;

		[Cpp2IlInjected.Token(Token = "0x4000356")]
		public const byte GetProperties = 251;

		[Cpp2IlInjected.Token(Token = "0x4000357")]
		public const byte ChangeGroups = 248;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		public const byte FindFriends = 222;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		public const byte GetLobbyStats = 221;

		[Cpp2IlInjected.Token(Token = "0x400035A")]
		public const byte GetRegions = 220;

		[Cpp2IlInjected.Token(Token = "0x400035B")]
		public const byte WebRpc = 219;

		[Cpp2IlInjected.Token(Token = "0x400035C")]
		public const byte ServerSettings = 218;

		[Cpp2IlInjected.Token(Token = "0x400035D")]
		public const byte GetGameList = 217;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x381140", Offset = "0x380340", VA = "0x180381140")]
		public OperationCode()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public enum JoinMode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		CreateIfNotExists,
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		JoinOrRejoin,
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		RejoinOnly
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public enum MatchmakingMode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		FillRoom,
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		SerialMatching,
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		RandomMatching
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public enum ReceiverGroup : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		Others,
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		All,
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		MasterClient
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public enum EventCaching : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		DoNotCache = 0,
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		[Obsolete]
		MergeCache = 1,
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		[Obsolete]
		ReplaceCache = 2,
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		[Obsolete]
		RemoveCache = 3,
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		AddToRoomCache = 4,
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		AddToRoomCacheGlobal = 5,
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		RemoveFromRoomCache = 6,
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		RemoveFromRoomCacheForActorsLeft = 7,
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		SliceIncreaseIndex = 10,
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		SliceSetIndex = 11,
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		SlicePurgeIndex = 12,
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		SlicePurgeUpToIndex = 13
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[Flags]
	public enum PropertyTypeFlag : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		Game = 1,
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		Actor = 2,
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		GameAndActor = 3
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public class RoomOptions
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		private bool isVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private bool isOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public byte MaxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		public int PlayerTtl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		public int EmptyRoomTtl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private bool cleanupCacheOnLeave;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		public Hashtable CustomRoomProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		public string[] CustomRoomPropertiesForLobby;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		public string[] Plugins;

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0x397FF0", Offset = "0x3971F0", VA = "0x180397FF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0x3ACEA0", Offset = "0x3AC0A0", VA = "0x1803ACEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x49AA40", Offset = "0x499C40", VA = "0x18049AA40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x49AA20", Offset = "0x499C20", VA = "0x18049AA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		public bool CleanupCacheOnLeave
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0x42F180", Offset = "0x42E380", VA = "0x18042F180")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000423")]
			[Cpp2IlInjected.Address(RVA = "0x49AA80", Offset = "0x499C80", VA = "0x18049AA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		public bool SuppressRoomEvents
		{
			[Cpp2IlInjected.Token(Token = "0x6000424")]
			[Cpp2IlInjected.Address(RVA = "0x42BAF0", Offset = "0x42ACF0", VA = "0x18042BAF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000425")]
			[Cpp2IlInjected.Address(RVA = "0x656150", Offset = "0x655350", VA = "0x180656150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		public bool PublishUserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000426")]
			[Cpp2IlInjected.Address(RVA = "0x42BB00", Offset = "0x42AD00", VA = "0x18042BB00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000427")]
			[Cpp2IlInjected.Address(RVA = "0x49AA10", Offset = "0x499C10", VA = "0x18049AA10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public bool DeleteNullProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x49AA30", Offset = "0x499C30", VA = "0x18049AA30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x49AA60", Offset = "0x499C60", VA = "0x18049AA60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042A")]
		[Cpp2IlInjected.Address(RVA = "0x1B77BF0", Offset = "0x1B76DF0", VA = "0x181B77BF0")]
		public RoomOptions()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public class RaiseEventOptions
	{
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		public static readonly RaiseEventOptions Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		public EventCaching CachingOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		public byte InterestGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		public int[] TargetActors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		public ReceiverGroup Receivers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		[Obsolete]
		public byte SequenceChannel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		public WebFlags Flags;

		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(RVA = "0x1B75020", Offset = "0x1B74220", VA = "0x181B75020")]
		public RaiseEventOptions()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	public enum LobbyType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000391")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x4000392")]
		SqlLobby = 2,
		[Cpp2IlInjected.Token(Token = "0x4000393")]
		AsyncRandomLobby = 3
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public class TypedLobby
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public LobbyType Type;

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public static readonly TypedLobby Default;

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x53BE00", Offset = "0x53B000", VA = "0x18053BE00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x1B79070", Offset = "0x1B78270", VA = "0x181B79070")]
		public TypedLobby()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x53BF20", Offset = "0x53B120", VA = "0x18053BF20")]
		public TypedLobby(string name, LobbyType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x1B78F70", Offset = "0x1B78170", VA = "0x181B78F70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public class TypedLobbyInfo : TypedLobby
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public int PlayerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public int RoomCount;

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x1B78CE0", Offset = "0x1B77EE0", VA = "0x181B78CE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x1B78EE0", Offset = "0x1B780E0", VA = "0x181B78EE0")]
		public TypedLobbyInfo()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public enum AuthModeOption
	{
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		Auth,
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		AuthOnce,
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		AuthOnceWss
	}
	[StructLayout((LayoutKind)3, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public enum CustomAuthenticationType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		Steam = 1,
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		Facebook = 2,
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		Oculus = 3,
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		PlayStation = 4,
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		Xbox = 5,
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		None = byte.MaxValue
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public class AuthenticationValues
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private CustomAuthenticationType authType;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public CustomAuthenticationType AuthType
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x397FF0", Offset = "0x3971F0", VA = "0x180397FF0")]
			get
			{
				return default(CustomAuthenticationType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x3ACEA0", Offset = "0x3AC0A0", VA = "0x1803ACEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public string AuthGetParameters
		{
			[Cpp2IlInjected.Token(Token = "0x6000436")]
			[Cpp2IlInjected.Address(RVA = "0x3821C0", Offset = "0x3813C0", VA = "0x1803821C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000437")]
			[Cpp2IlInjected.Address(RVA = "0x3B1460", Offset = "0x3B0660", VA = "0x1803B1460")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		public object AuthPostData
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x3827E0", Offset = "0x3819E0", VA = "0x1803827E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0x3B1450", Offset = "0x3B0650", VA = "0x1803B1450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		public string Token
		{
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0x38FF90", Offset = "0x38F190", VA = "0x18038FF90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0x3B12D0", Offset = "0x3B04D0", VA = "0x1803B12D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0x3B6C30", Offset = "0x3B5E30", VA = "0x1803B6C30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0x444780", Offset = "0x443980", VA = "0x180444780")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0xCFC7C0", Offset = "0xCFB9C0", VA = "0x180CFC7C0")]
		public AuthenticationValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0xCFC7D0", Offset = "0xCFB9D0", VA = "0x180CFC7D0")]
		public AuthenticationValues(string userId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0xCFC4D0", Offset = "0xCFB6D0", VA = "0x180CFC4D0", Slot = "4")]
		public virtual void SetAuthPostData(string stringData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x3B1450", Offset = "0x3B0650", VA = "0x1803B1450", Slot = "5")]
		public virtual void SetAuthPostData(byte[] byteData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x1B651B0", Offset = "0x1B643B0", VA = "0x181B651B0", Slot = "6")]
		public virtual void AddAuthParameter(string key, string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x1B653E0", Offset = "0x1B645E0", VA = "0x181B653E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public abstract class PhotonPing : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public string DebugString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public bool Successful;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		protected internal bool GotResult;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		protected internal int PingLength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		protected internal byte[] PingBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		protected internal byte PingId;

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x1B73E10", Offset = "0x1B73010", VA = "0x181B73E10", Slot = "5")]
		public virtual bool StartPing(string ip)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x1B73DC0", Offset = "0x1B72FC0", VA = "0x181B73DC0", Slot = "6")]
		public virtual bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x1B73D70", Offset = "0x1B72F70", VA = "0x181B73D70", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x750650", Offset = "0x74F850", VA = "0x180750650")]
		protected internal void Init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x1B73E60", Offset = "0x1B73060", VA = "0x181B73E60")]
		protected PhotonPing()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public class PingMono : PhotonPing
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private Socket sock;

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x1B74090", Offset = "0x1B73290", VA = "0x181B74090", Slot = "5")]
		public override bool StartPing(string ip)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x1B73F60", Offset = "0x1B73160", VA = "0x181B73F60", Slot = "6")]
		public override bool Done()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x1B73EE0", Offset = "0x1B730E0", VA = "0x181B73EE0", Slot = "7")]
		public override void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x1B73E60", Offset = "0x1B73060", VA = "0x181B73E60")]
		public PingMono()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public class Player
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private int actorID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public readonly bool IsLocal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		private string nickName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public object TagObject;

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		protected internal Room RoomReference
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0x3823A0", Offset = "0x3815A0", VA = "0x1803823A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600044E")]
			[Cpp2IlInjected.Address(RVA = "0x3AFCB0", Offset = "0x3AEEB0", VA = "0x1803AFCB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		public int ID
		{
			[Cpp2IlInjected.Token(Token = "0x600044F")]
			[Cpp2IlInjected.Address(RVA = "0x3B1470", Offset = "0x3B0670", VA = "0x1803B1470")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		public string NickName
		{
			[Cpp2IlInjected.Token(Token = "0x6000450")]
			[Cpp2IlInjected.Address(RVA = "0x3827E0", Offset = "0x3819E0", VA = "0x1803827E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000451")]
			[Cpp2IlInjected.Address(RVA = "0x1B74F00", Offset = "0x1B74100", VA = "0x181B74F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		public string UserId
		{
			[Cpp2IlInjected.Token(Token = "0x6000452")]
			[Cpp2IlInjected.Address(RVA = "0x38FF90", Offset = "0x38F190", VA = "0x18038FF90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x3B12D0", Offset = "0x3B04D0", VA = "0x1803B12D0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public bool IsMasterClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x1B74EE0", Offset = "0x1B740E0", VA = "0x181B74EE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public bool IsInactive
		{
			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x387660", Offset = "0x386860", VA = "0x180387660")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x387470", Offset = "0x386670", VA = "0x180387470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public Hashtable CustomProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x386B00", Offset = "0x385D00", VA = "0x180386B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0x397B50", Offset = "0x396D50", VA = "0x180397B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public Hashtable AllProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x1B74E40", Offset = "0x1B74040", VA = "0x181B74E40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x1B74D30", Offset = "0x1B73F30", VA = "0x181B74D30")]
		protected internal Player(string nickName, int actorID, bool isLocal)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x1B74D50", Offset = "0x1B73F50", VA = "0x181B74D50")]
		protected internal Player(string nickName, int actorID, bool isLocal, Hashtable playerProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x1B74610", Offset = "0x1B73810", VA = "0x181B74610")]
		public Player Get(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x1B74600", Offset = "0x1B73800", VA = "0x181B74600")]
		public Player GetNext()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x1B745E0", Offset = "0x1B737E0", VA = "0x181B745E0")]
		public Player GetNextFor(Player currentPlayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x1B74390", Offset = "0x1B73590", VA = "0x181B74390")]
		public Player GetNextFor(int currentPlayerId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x1B74630", Offset = "0x1B73830", VA = "0x181B74630", Slot = "4")]
		public virtual void InternalCacheProperties(Hashtable properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x1B74CB0", Offset = "0x1B73EB0", VA = "0x181B74CB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x1B74A60", Offset = "0x1B73C60", VA = "0x181B74A60")]
		public string ToStringFull()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x1B742C0", Offset = "0x1B734C0", VA = "0x181B742C0", Slot = "0")]
		public override bool Equals(object p)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x3B1470", Offset = "0x3B0670", VA = "0x1803B1470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x1B742B0", Offset = "0x1B734B0", VA = "0x181B742B0")]
		protected internal void ChangeLocalID(int newID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x1B74890", Offset = "0x1B73A90", VA = "0x181B74890")]
		public void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedValues, [Optional] WebFlags webFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x1B74990", Offset = "0x1B73B90", VA = "0x181B74990")]
		private void SetPlayerNameProperty()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public class Room : RoomInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		protected internal int PlayerTTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		protected internal int RoomTTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private Dictionary<int, Player> players;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		protected internal LoadBalancingClient LoadBalancingClient
		{
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x397A60", Offset = "0x396C60", VA = "0x180397A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0x396C20", Offset = "0x395E20", VA = "0x180396C20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public new string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0x386B00", Offset = "0x385D00", VA = "0x180386B00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x397B50", Offset = "0x396D50", VA = "0x180397B50")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public new bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x387660", Offset = "0x386860", VA = "0x180387660")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0x1B78980", Offset = "0x1B77B80", VA = "0x181B78980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public new bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x775480", Offset = "0x774680", VA = "0x180775480")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600046F")]
			[Cpp2IlInjected.Address(RVA = "0x1B78AA0", Offset = "0x1B77CA0", VA = "0x181B78AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public new byte MaxPlayers
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0x4062D0", Offset = "0x4054D0", VA = "0x1804062D0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x1B78BC0", Offset = "0x1B77DC0", VA = "0x181B78BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public new byte PlayerCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000472")]
			[Cpp2IlInjected.Address(RVA = "0x1B78930", Offset = "0x1B77B30", VA = "0x181B78930")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public Dictionary<int, Player> Players
		{
			[Cpp2IlInjected.Token(Token = "0x6000473")]
			[Cpp2IlInjected.Address(RVA = "0x3D0CB0", Offset = "0x3CFEB0", VA = "0x1803D0CB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0x43CFF0", Offset = "0x43C1F0", VA = "0x18043CFF0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public string[] ExpectedUsers
		{
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x38FF90", Offset = "0x38F190", VA = "0x18038FF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public int MasterClientId
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x38FF80", Offset = "0x38F180", VA = "0x18038FF80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public string[] PropertiesListedInLobby
		{
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x38EBF0", Offset = "0x38DDF0", VA = "0x18038EBF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x398CA0", Offset = "0x397EA0", VA = "0x180398CA0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public bool AutoCleanUp
		{
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0x786470", Offset = "0x785670", VA = "0x180786470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x1B78870", Offset = "0x1B77A70", VA = "0x181B78870")]
		protected internal Room(string roomName, RoomOptions options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x1B77F00", Offset = "0x1B77100", VA = "0x181B77F00", Slot = "5")]
		public virtual void SetCustomProperties(Hashtable propertiesToSet, [Optional] Hashtable expectedProperties, [Optional] WebFlags webFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x1B78150", Offset = "0x1B77350", VA = "0x181B78150")]
		public void SetPropertiesListedInLobby(string[] propertiesListedInLobby)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x1B77E90", Offset = "0x1B77090", VA = "0x181B77E90", Slot = "6")]
		protected internal virtual void RemovePlayer(Player player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x1B77E50", Offset = "0x1B77050", VA = "0x181B77E50", Slot = "7")]
		protected internal virtual void RemovePlayer(int id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x1B77FD0", Offset = "0x1B771D0", VA = "0x181B77FD0")]
		public bool SetMasterClient(Player masterClientPlayer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x1B77C40", Offset = "0x1B76E40", VA = "0x181B77C40", Slot = "8")]
		public virtual bool AddPlayer(Player player)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x1B78210", Offset = "0x1B77410", VA = "0x181B78210", Slot = "9")]
		public virtual Player StorePlayer(Player player)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x1B77DE0", Offset = "0x1B76FE0", VA = "0x181B77DE0", Slot = "10")]
		public virtual Player GetPlayer(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x1B77CD0", Offset = "0x1B76ED0", VA = "0x181B77CD0")]
		public void ClearExpectedUsers()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0x1B785D0", Offset = "0x1B777D0", VA = "0x181B785D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x1B78290", Offset = "0x1B77490", VA = "0x181B78290")]
		public new string ToStringFull()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public class RoomInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		protected internal bool removedFromList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private Hashtable customProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		protected byte maxPlayers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		protected string[] expectedUsers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		protected bool isOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		protected bool isVisible;

		[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		protected bool autoCleanUp;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		protected string name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		protected internal int masterClientId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		protected string[] propertiesListedInLobby;

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		public Hashtable CustomProperties
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0x3821C0", Offset = "0x3813C0", VA = "0x1803821C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000487")]
			[Cpp2IlInjected.Address(RVA = "0x386B00", Offset = "0x385D00", VA = "0x180386B00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		public int PlayerCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000488")]
			[Cpp2IlInjected.Address(RVA = "0x575990", Offset = "0x574B90", VA = "0x180575990")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000489")]
			[Cpp2IlInjected.Address(RVA = "0x575FF0", Offset = "0x5751F0", VA = "0x180575FF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		public bool IsLocalClientInside
		{
			[Cpp2IlInjected.Token(Token = "0x600048A")]
			[Cpp2IlInjected.Address(RVA = "0x730720", Offset = "0x72F920", VA = "0x180730720")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600048B")]
			[Cpp2IlInjected.Address(RVA = "0x72FC60", Offset = "0x72EE60", VA = "0x18072FC60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		public byte MaxPlayers
		{
			[Cpp2IlInjected.Token(Token = "0x600048C")]
			[Cpp2IlInjected.Address(RVA = "0x4062D0", Offset = "0x4054D0", VA = "0x1804062D0")]
			get
			{
				return default(byte);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0x387660", Offset = "0x386860", VA = "0x180387660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		public bool IsVisible
		{
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x775480", Offset = "0x774680", VA = "0x180775480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x1B77B50", Offset = "0x1B76D50", VA = "0x181B77B50")]
		protected internal RoomInfo(string roomName, Hashtable roomProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x1B76FB0", Offset = "0x1B761B0", VA = "0x181B76FB0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x1B77050", Offset = "0x1B76250", VA = "0x181B77050", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x1B778E0", Offset = "0x1B76AE0", VA = "0x181B778E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000493")]
		[Cpp2IlInjected.Address(RVA = "0x1B775D0", Offset = "0x1B767D0", VA = "0x181B775D0")]
		public string ToStringFull()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000494")]
		[Cpp2IlInjected.Address(RVA = "0x1B77080", Offset = "0x1B76280", VA = "0x181B77080", Slot = "4")]
		protected internal virtual void InternalCacheProperties(Hashtable propertiesToCache)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public class WebRpcResponse
	{
		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0x3823A0", Offset = "0x3815A0", VA = "0x1803823A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0x3AFCB0", Offset = "0x3AEEB0", VA = "0x1803AFCB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		public int ReturnCode
		{
			[Cpp2IlInjected.Token(Token = "0x6000497")]
			[Cpp2IlInjected.Address(RVA = "0x3B1470", Offset = "0x3B0670", VA = "0x1803B1470")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0x3B1590", Offset = "0x3B0790", VA = "0x1803B1590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		public string DebugMessage
		{
			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0x3827E0", Offset = "0x3819E0", VA = "0x1803827E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0x3B1450", Offset = "0x3B0650", VA = "0x1803B1450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		public Dictionary<string, object> Parameters
		{
			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x38FF90", Offset = "0x38F190", VA = "0x18038FF90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0x3B12D0", Offset = "0x3B04D0", VA = "0x1803B12D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x1B7A370", Offset = "0x1B79570", VA = "0x181B7A370")]
		public WebRpcResponse(OperationResponse response)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049E")]
		[Cpp2IlInjected.Address(RVA = "0x1B7A160", Offset = "0x1B79360", VA = "0x181B7A160")]
		public string ToStringFull()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public class WebFlags
	{
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly WebFlags Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public byte WebhookFlags;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public const byte HttpForwardConst = 1;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public const byte SendAuthCookieConst = 2;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public const byte SendSyncConst = 4;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public const byte SendStateConst = 8;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		public bool HttpForward
		{
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0x1B7A060", Offset = "0x1B79260", VA = "0x181B7A060")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0x1B7A0A0", Offset = "0x1B792A0", VA = "0x181B7A0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		public bool SendAuthCookie
		{
			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x1B7A070", Offset = "0x1B79270", VA = "0x181B7A070")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x1B7A0D0", Offset = "0x1B792D0", VA = "0x181B7A0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		public bool SendSync
		{
			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x1B7A090", Offset = "0x1B79290", VA = "0x181B7A090")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0x1B7A130", Offset = "0x1B79330", VA = "0x181B7A130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public bool SendState
		{
			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x1B7A080", Offset = "0x1B79280", VA = "0x181B7A080")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x1B7A100", Offset = "0x1B79300", VA = "0x181B7A100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x1061170", Offset = "0x1060370", VA = "0x181061170")]
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
		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x3AC6F0", Offset = "0x3AB8F0", VA = "0x1803AC6F0")]
		public DoNotFakeAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[AttributeUsage(AttributeTargets.Method)]
	public class ObfuscateLiteralsAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x3AC6F0", Offset = "0x3AB8F0", VA = "0x1803AC6F0")]
		public ObfuscateLiteralsAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class RenameAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private readonly string target;

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x3AC6F0", Offset = "0x3AB8F0", VA = "0x1803AC6F0")]
		private RenameAttribute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x5FE8D0", Offset = "0x5FDAD0", VA = "0x1805FE8D0")]
		public RenameAttribute(string target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x3823A0", Offset = "0x3815A0", VA = "0x1803823A0")]
		public string GetTarget()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class ReplaceLiteralsWithNameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x3AC6F0", Offset = "0x3AB8F0", VA = "0x1803AC6F0")]
		public ReplaceLiteralsWithNameAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x3AC6F0", Offset = "0x3AB8F0", VA = "0x1803AC6F0")]
		public SkipAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipRenameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x3AC6F0", Offset = "0x3AB8F0", VA = "0x1803AC6F0")]
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
