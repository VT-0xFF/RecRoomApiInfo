using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet;
using RecNet.Events;
using RecNet.Rooms;
using RecNet.Store;
using RecRoom.Async;
using RecRoom.DataStructures.ResourceHandles;
using RecRoom.MemoryMetrics;
using RecRoom.Networking.DataTypes;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.Protobuf;
using RecRoom.RoomLoad.Protobuf;
using RecRoom.TimeLimitedActivity;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18250", VA = "0x180D19850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HardwareType
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	Desktop_Valve,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Desktop_Oculus,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	PS4,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Desktop_MicrosoftVR,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	Desktop_VRMissing,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	OculusQuest,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	iOS,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	XboxOne,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	AndroidMobile,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	PS5,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	XboxSeries,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	PicoNeo3,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	PicoPhoenix,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	NintendoSwitch
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[Flags]
public enum HardwareTypeMask
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Desktop_Valve = 1,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Desktop_Oculus = 2,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	PS4 = 4,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Desktop_MicrosoftVR = 8,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Desktop_VRMissing = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	OculusQuest = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	iOS = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	XboxOne = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	AndroidMobile = 0x100,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	PS5 = 0x200,
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	XboxSeries = 0x400,
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	PicoNeo3 = 0x800,
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	PicoPhoenix = 0x1000,
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	NintendoSwitch = 0x2000,
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	All = -1
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum LinkButtonTypes
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Uninitialized,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Player,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Room,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		Club,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Invention,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		PlayerEvents
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum LocalPlayerControllerDisplayMode
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		UNINITIALIZED,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		VR,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		SCREEN
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface KDNZYYELQUS
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool KNVLPIKBCDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task Initialize();
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface BTSJKCEBAAZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool UVHNWEJQUMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool BTGNZBDACMB(object a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface TTDNZSUZDGK
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool RGJBEFXOFYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		Vector3 ZTGXRPXVCWA
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		Vector3 YFKSJDRYDDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		Camera IXKTFHEQQDL
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		Camera EFCVGTHLUKM
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		GameObject RVQTLVZXUMU
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		SNQZCVXZZUF DKQSVPGEUOP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		YZDETVQVLVA NWUHCBXEQYF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		bool OHNFMOYELMN
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		float TEORIBYFLKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface XWOLRWFCTJS
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		bool TBHJNGTDZEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		YZDETVQVLVA MDGWWBGXIAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool ANLVGGOIBQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool JKXNKMUMDVM(DDFOJMMWCEL a, DDFOJMMWCEL b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface FLQCOQNBBHQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000010")]
		RegionInfo XJFDDLSZWBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		PlatformType XQLSMEZMHAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		bool CMGQUGJNEKY
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		bool NONKNHRNDDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		string FKPKKMHRHHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		string OKSLBOLVMDW
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface JLSAXKNXFDB : NBNYUVGLZKT, WNKTBFZQCSO, OAMOZHDFIHC, VEXRWKJNVIC, FLQCOQNBBHQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		YZDETVQVLVA LPBZKLBCXGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		HardwareType BUGINDUFHMV
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool JATNBAASVXR
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		bool OBYXDZYIBLC
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		bool UFAXLVVHATG
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool EZUKMCAESBX
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		bool OFXIGXIHLJY
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool QZHTZOCAHAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool SFVSNYYJYLK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "8")]
		IMNXFPWKHPJ<DateTime?> GetPlatformProfileDateOfBirth();

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool IsEULARequired();

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "10")]
		string GetEULA();

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void AcceptEULA();

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "12")]
		GMTKWIVSBCA PlatformLogin();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "13")]
		GMTKWIVSBCA RunVRDisplayModeConfirmation();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "14")]
		bool IsDisplayModeSelectionRequired();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		IMNXFPWKHPJ<LocalPlayerControllerDisplayMode> RunDisplayModeSelection();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		GMTKWIVSBCA RequestMicrophonePermissions();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		GMTKWIVSBCA RequestContactsPermission();

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		bool HasContactsPermission();

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		bool CanAskForContactsPermission();

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		bool SupportsLinkToDownloadUpdate();

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void LinkToDownloadUpdate();

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool IsCrossPlatformWarningRequired();

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void AcceptCrossPlatformWarning();

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "24")]
		bool IsForcedIsolationByPlatformSettings([Out] string helpMessage);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "25")]
		IMNXFPWKHPJ<bool> TryResolveForcedIsolationByPlatformSettings();

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "26")]
		bool IsSiloedMatchmakingEnabled();

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "27")]
		bool RequestCrossPlatformMatchmaking();

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "28")]
		bool RequestSiloedMatchmaking();

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "29")]
		DVNZWAEHOWC<Texture2D> GetPlatformFriendPicture(string imageName);

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "30")]
		IMNXFPWKHPJ<AccountAgeBucket> GetPlatformPlayerAgeBucket();

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "31")]
		Task<AccountAgeBucket> GetPlatformPlayerAgeBucketAsync([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface SNQZCVXZZUF
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		float LWKQRCIAUHN
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
}
namespace RecRoom.Storefronts
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface IUSNJLRJLOC
	{
		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action FBJTMIEVEII;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action<Commerce.RJYSINCPFBJ> LWBOUEMSRSA;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool WSGHZEKTXMF(StorefrontGiftDrop a);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void ZHQNXDHTUXD();

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void YOWIWVTFXDB(Commerce.RJYSINCPFBJ a);
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface ELRGTCSJELU
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool BFIJJNGMSDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}
	}
}
namespace RecRoom.Notifications
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface HZMQRERDGQL
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		YZDETVQVLVA CRVIRXGDDSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable Play(ScreenSpaceNotificationType style, string titleText, float duration, [Optional] Action callback, [Optional] object notificationToken);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IDisposable Play(ScreenSpaceNotificationType style, string titleText, string subtitleText, float duration, [Optional] Action callback, [Optional] object notificationToken);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IDisposable Play(ScreenSpaceNotificationType style, float notificationPriority, ScreenSpaceNotificationBehavior notificationBehavior, string titleText, Color? titleColor, string subtitleText, Color? subtitleColor, float duration, [Optional] Action callback, [Optional] object notificationToken);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PlayProgressionEventWatchNotification(bool isMessageNotification, [Optional] string titleOverride, [Optional] string subtitleOverride, int fromAccountId = -1, [Optional] Action quickAcceptAction, [Optional] string quickAcceptTextOverride, bool hasWatchAction = true, [Optional] float? displayDurationSeconds, float broadcastDelay = 0f);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void PlayTLAWatchNotification([Optional] string titleOverride, [Optional] Action quickAcceptAction, [Optional] string quickAcceptTextOverride, bool hasWatchAction = true, [Optional] float? displayDurationSeconds);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void PlayTLAPointsWatchNotification(string title, float duration, OEREPXWVTSK tlaPointsOptions);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void PlayPlayerProgressionWatchNotification(EVZFMCOVZRF payload);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void AddForceAllowNotifications(object token);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void RemoveForceAllowNotifications(object token);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool TryConsumeWatchNotification();
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum ScreenSpaceNotificationBehavior
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		Opportunistic,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		Queue
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum ScreenSpaceNotificationType
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		Min = -1,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		Minor,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		Medium,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Major,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Vital,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		Max
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class GMXWKDRHMUL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool JMHPFMQVKLQ;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool AZWVIHZLXHU
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xD44270", Offset = "0xD42C70", VA = "0x180D44270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xE0C0A0", Offset = "0xE0AAA0", VA = "0x180E0C0A0")]
		public void AHNUASUSFIY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public GMXWKDRHMUL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface LBUQXPBCETP
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool CHTJXYWBCPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action<GMXWKDRHMUL> VYKAJWORXHM;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RQIRLOHJWEF();

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "2")]
		LoadSceneSourceData VJCRYSUKWXU();

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RTDRNFATWYB(LoadSceneSources a);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void HOJVTOOWBUP(RoomDTO a, SubRoomDTO b, string c, [Optional] Action<JoinRoomResult> d);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void VQCHXPNZBTG(string a, LoadSceneSources b, bool c = false);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void KLGHAYJJWSB(int a, JoinRoomInviteMode b);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void MDGLXJVNCWY(RoomDTO a, SubRoomDTO b, int c, LoadSceneSources d, bool e = false);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		Task<Result<None, EAUBJYCPGNG>> FNAYRJYTZMF(RoomDTO a, SubRoomDTO b, OPLJPQJKNXI c, LoadSceneSources d);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void VGMNAWDLTMK(RoomDTO a, ChatMessage b, long c, [Optional] Action<JoinRoomResult> d);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void TFMGYRJCMWP(SubRoomDTO a, LoadSceneSources b, JoinRoomInviteMode c, bool d, string e = "");

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "13")]
		[Obsolete("Prefer using RunJoinRoom(RoomDTO, SubRoomDTO) or RunJoinRoom(roomId, subRoomId) where possible.")]
		void GGYCOIEDPAC(string a, string b, LoadSceneSourceData c, bool d, [Optional] Action<JoinRoomResult> e);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void GGYCOIEDPAC(long a, LoadSceneSourceData b, bool c, [Optional] Action<JoinRoomResult> d);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void GGYCOIEDPAC(string a, LoadSceneSourceData b, bool c, [Optional] Action<JoinRoomResult> d);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void GGYCOIEDPAC(RoomDTO a, LoadSceneSourceData b, bool c, [Optional] Action<JoinRoomResult> d);

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void GGYCOIEDPAC(GOKDHRHCXHW a, LoadSceneSourceData b, bool c, [Optional] Action<JoinRoomResult> d);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void CNVKXTNEVWN(long a, long b, LoadSceneSourceData c, bool d, List<int> e, [Optional] Action<JoinRoomResult> f);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void GGYCOIEDPAC(RoomDTO a, SubRoomDTO b, LoadSceneSourceData c, bool d, [Optional] string e, [Optional] Action<JoinRoomResult> f, string g = "", [Optional] AATIGHRLMVE h);

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void VILJWTCFFZA(LoadSceneSourceData a, [Optional] Action<JoinRoomResult> b);

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "21")]
		GMTKWIVSBCA RGBRYZRFWGX(Club a, LoadSceneSources b);

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "22")]
		bool ITKPFVOTWVL(PlayerEvent a, LoadSceneSources b, RoomJoinMode c = RoomJoinMode.PublicMatchmaking, bool d = true);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void BVAPEZIANKW(string a, string b, LoadSceneSourceData c, [Optional] Action<JoinRoomResult> d);

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void AGCGXTGCONI(IReadOnlyList<long> a, IReadOnlyList<long> b, LoadSceneSourceData c, [Optional] Action<JoinRoomResult> d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class EAUBJYCPGNG : ARGBUOZFZQD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly string YRNJBNRLCIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly MatchmakingErrorCode? WSVSRAGVULR;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x989ABA0", Offset = "0x98995A0", VA = "0x18989ABA0")]
		public EAUBJYCPGNG(string a, [Optional] MatchmakingErrorCode? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x989A9B0", Offset = "0x98993B0", VA = "0x18989A9B0")]
		public static EAUBJYCPGNG New(string message)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x989AB10", Offset = "0x9899510", VA = "0x18989AB10")]
		public static EAUBJYCPGNG New(ARGBUOZFZQD err)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x989AA20", Offset = "0x9899420", VA = "0x18989AA20")]
		public static EAUBJYCPGNG New(string message, MatchmakingErrorCode errorCode)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface ZORYLYZVEXV
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool SJXJLVVMDOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		YZDETVQVLVA QUHJWQZRZXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		Vector3 GHKKKPHFWJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		long PEGPWVDJAMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		string BGDBXNVOVHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface BYYQFARBLXD
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IMNXFPWKHPJ<Relationship> SendFriendRequest(int playerId, bool ignoreCooldown = false);

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IMNXFPWKHPJ<Relationship> PSNTXBREOWW(int a);

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IMNXFPWKHPJ<Relationship> JZHCSTHFJQV(int a);

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IMNXFPWKHPJ<Relationship> CEMUWSUELGY(int a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface MBBMHZSUIWI
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task SHADPUPBTBE();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface QYSQQYIIHGE
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		YZDETVQVLVA SQVTDPGAKNU
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool SHZVCAVNLNE
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool NURFLPDQNOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool PWWECYVUCJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool NDMRDTFUYON
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		bool DHLRGQUAULH
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "8")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action<bool> PSIVPOXGDCK;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool UDUHHMXRJEV(long a);

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool RXPBNRSIGWN(long a);

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool TPIWOZQUQSK(RoomDTO a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(Slot = "12")]
		bool YTHDIAWATIC(RoomDTO a);

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "13")]
		YNVUIOBZBUF ZKQORVPTXFJ(int a, [Optional] string b, bool c = false, bool d = false, JoinRoomInviteMode e = JoinRoomInviteMode.None);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		Task HTEVCSADNLE(int[] a, bool b = false, JoinRoomInviteMode c = JoinRoomInviteMode.None);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void LGNEEBETFPW(int a, Account b, PlayerPresence c, [Optional] LoadSceneSources? d);

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void SKMXZNCUIIL(MBBMHZSUIWI a);

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void DVXBZMWNIEE(MBBMHZSUIWI a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public struct LoadSceneSourceData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public LoadSceneSources Source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public long SourcePlaylistId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public long SourceRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public string SourceSearchQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public string SourceCarouselDisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public string SourceCarouselEndpoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public string DiscoverySectionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Guid? ServerSearchSessionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public LoadSceneSourceRRUIData? SourceRRUIData;
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct LoadSceneSourceRRUIData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public string BrowserTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public string[] BrowserUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Dictionary<string, string> ModelData;
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public enum LoadSceneSources
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		NOT_SET = 0,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		BOOT = 1,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		GAME_LOADING_NEXT_LEVEL = 2,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		PORTAL = 3,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		AFK = 4,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		VOTE_KICKED = 5,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		CHEAT = 6,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		ROOM_BANNED = 7,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		ACCEPTED_GAME_INVITE = 8,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		PARTY_ACTIVITY_SWITCH = 9,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		NOTIFICATION_NEW_ROOM_FROM_CREATOR = 10,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		NOTIFICATION_PLAYER_EVENT = 11,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		PEOPLE_MENU = 12,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		ACTIVITY_SELECT_MENU = 13,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		PERSISTENCE_ERROR = 14,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		CIRCUIT_REINITIALIZE_ERROR = 15,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		BULLETIN_BOARD_FEATURED_ROOMS = 16,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		__DEPRECATED_CUSTOM_ROOMS_WATCH = 17,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[Obsolete]
		__DEPRECATED_CUSTOM_ROOMS_DOOR_V1_OR_RELOAD_ACTIVITY_OR_FOLLOW_PARTY_AFTER_DOOR = 18,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		QUIT = 19,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		EVENT_DIRECT_GOTO = 20,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		EVENT_NOTIFICATION = 21,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		REC_CENTER_SLIDESHOW = 22,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		COHORT_NUX = 23,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		QUICK_LAUNCH_MENU = 24,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		ANNOUNCEMENT = 25,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		DEPRECATED_1 = 26,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		DELAYED_ROOM_WARNING = 27,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		ROOM_CODE = 28,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		ROOM_COMMENT_NOTIFICATION = 29,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		CLUBHOUSE_DIRECT_GOTO = 30,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		CREATORANNOUNCEMENT_ROOMPUBLISHED = 31,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		FORCE_THROUGH_ADMIN_SITE = 32,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		RECOMMENDED_ROOMS_WATCH = 33,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		INSTANCE_FORCE_CLOSED = 34,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		HOT_ROOMS_WATCH = 35,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		LIVE_ROOMS_WATCH = 36,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		SEARCH_ROOMS_WATCH = 37,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		FAVORITE_ROOMS_WATCH = 38,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		DOOR_SELECT_WATCH = 39,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		FEATURED_ROOMS_WATCH = 40,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		RECNET_ROOMS_WATCH = 41,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		NEW_ROOMS_WATCH = 42,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		ROOM_COMMENT_TELEPORT = 43,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		CURATED_PLAYLISTS_WATCH = 44,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		PLAYER_EVENT_CODE = 45,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		CREATORANNOUNCEMENT_EVENTPUBLISHED = 46,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		ROOM_REJOIN_WATCH = 47,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		PLAYER_EVENT_DETAILS_WATCH = 48,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		RECENT_ROOMS_WATCH = 49,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		FRIEND_PRESENCE_ROOMS_WATCH = 50,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		MY_CLUBHOUSE_ROOMS_WATCH = 51,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		MY_SUBSCRIPTIONS_ROOMS_WATCH = 52,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		TOP_CREATORS_ROOMS_WATCH = 53,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		MORE_FROM_CONTEST_WINNERS_ROOMS_WATCH = 54,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		ROOM_LINK_BUTTON = 55,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		ROOM_SHOWCASE_POSTER = 56,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		THIS_ROOM_WATCH = 57,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		REC_CENTER_WATCH = 58,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		DORM_ROOM_WATCH = 59,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		ROOM_DETAILS_WATCH = 60,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		CLONED_ROOM = 61,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		CREATE_ROOM_RESUME_WATCH = 62,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		BROWSE_ROOMS_WATCH = 63,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		MEETUP_CODE = 64,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		TEST_CASE_WATCH = 65,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		CHAT_MESSAGE = 66,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		MY_CREATED_ROOMS_WATCH = 67,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		PLAYER_CREATED_ROOMS_WATCH = 68,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		PLAYER_SHOWCASE_ROOMS_WATCH = 69,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		CURRENT_CONTEST_ROOMS_WATCH = 70,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		TRENDING_TAGS_WATCH = 71,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		RRO_ROOMS_WATCH = 72,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		MAGIC_DOOR_DOOR = 73,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		MAGIC_DOOR_WATCH = 74,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		ROOM_NOTIFICATION_WATCH = 75,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		FOR_YOU_ROOMS_WATCH = 76,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		CLOUD_DATA_MENU = 77,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		SIMILAR_ROOMS_WATCH = 78,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		DEEP_LINK = 79,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		PLATFORM_NOTIFICATION_ACTION = 80,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[Obsolete]
		ROOM_JACKPOT = 81,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		RRUI_REMOTE_PLAYER_PROFILE = 82,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		ALL_KEEPSAKE_ROOMS = 83,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		STANDARD_KEEPSAKE_ROOMS = 84,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		PREMIUM_KEEPSAKE_ROOMS = 85,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		KEEPSAKE_ROOM_HIGHLIGHT = 86,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		SHOW_ME_ALL_ROOMS = 87,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[Obsolete]
		RISING_ROOMS_WATCH = 88,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		TITLESCREEN_ONLINE_FRIEND = 89,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		BROADCASTING_LISTENER_DISCONNECT = 100,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		CLUBHOUSE_WATCH_HOME = 101,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		ORIENTATION_DORM_DOOR = 102,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		MAKER_PEN_MAIN_MENU = 103,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		ROOM_CATEGORY_SELECT = 104,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		ACCEPTED_PARTY_INVITE = 105,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		XBOX_GAME_INVITE = 106,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		PLAYSTATION_GAME_INVITE = 107,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		PHOTO_DETAILS_WATCH = 108,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		IMAGE_FEED_ITEM = 109,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		CIRCUITS_V2_GO_TO_ROOM = 110,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		CLUBHOUSE_OPTIONS_WATCH = 111,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		SESSION_TAKEOVER = 112,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		DEBUG_CONSOLE = 113,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		PROGRESSSION_EVENT_TUTORIAL = 114,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		MESSAGE_CARD_IMAGE_CLICKED = 115,
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		ROOM_EARNINGS_MESSAGE_CARD_BUTTON_CLICKED = 116,
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		CUSTOM_ROOM_DOOR = 118,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		RELOAD_ACTIVITY = 119,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		FOLLOW_PARTY_AFTER_DOOR = 120,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[Obsolete]
		HOME_LOGIN = 121,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[Obsolete]
		HOME_ROOM = 122,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		PLAY_MENU_BANNER = 123,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		QUICK_ORIENTATION_DOOR = 124,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		CAROUSEL_ENDPOINT_WATCH = 125,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		HEARTBEAT_TIMEOUT = 126,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		MULTIPLAYER_TESTING_COMMAND = 127,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[Obsolete]
		JOIN_NEW_FRIEND = 128,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		SIMILAR_ROOMS_LISTS_WATCH = 129,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		FEATURED_CREATOR_CAROUSEL = 131,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		GENRE_BASED_CAROUSEL = 132,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		CIRCUITS_V2_GO_TO_PLAYER_EVENT = 133,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		PARTY_CARD_GOTO_WATCH = 134,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		REC_ROOM_CREATOR_ACADEMY_WATCH = 200,
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		RRCA_LEARN_TO_CREATE_WATCH = 201,
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		RRCA_CREATION_TUTORIALS_WATCH = 202,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		RRCA_BUILDING_TUTORIALS_WATCH = 203,
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		RRCA_CIRCUITS_TUTORIALS_WATCH = 204,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		MY_CREATED_DORMS_WATCH = 205,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		GENRE_CARDS_SEARCH_WATCH = 206,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		APPNAV_WIDGET = 207,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		CV2_SHOW_ROOM_DETAILS = 208,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		ROOMIE_AI = 209,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		OM_INITIALIZATION_ERROR = 210,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		OFFLINE_TO_ONLINE_DORM = 211,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		TLA_BANNER = 212,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		NOTIFICATION_GIFT_RECEIVED = 213,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		EQUIPPED_CUSTOM_BADGE_PROFILE_LOCAL = 214,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		EQUIPPED_CUSTOM_BADGE_PROFILE_REMOTE = 215,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		PROFILE_BADGES_TAB_BADGES_LIST_ITEM_LOCAL = 216,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		PROFILE_BADGES_TAB_BADGES_LIST_ITEM_REMOTE = 217
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public struct JoinRoomResult
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public bool DidJoinRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public MatchmakingErrorCode ErrorCode;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x989ABF0", Offset = "0x98995F0", VA = "0x18989ABF0")]
		public JoinRoomResult(MatchmakingErrorCode errorCode)
		{
		}
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface TYUTCDXHZWW
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MANHJEAIVWM(PersistedRoomData a, List<KeepsakeInstanceDTO> b);
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
