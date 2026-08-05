using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
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
public static class SA_PD_EditorIcons
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public enum IconType
	{
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		GameObject,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Favorite,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Prefab,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		GameManager,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		Dragdot,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		DragdotActive,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		DragdotDimmed,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		Dropdown,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		d_winbtn_mac_close,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		d_winbtn_mac_close_a,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		d_winbtn_mac_close_h,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		d_winbtn_mac_inact,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		d_winbtn_mac_max,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		d_winbtn_mac_max_h,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		d_winbtn_mac_min,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		d_winbtn_mac_min_h,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		d_winbtn_win_close,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		DefaultAsset,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		DllScript,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		DistanceJoint2D,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		FilterByLabel,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		FilterByType,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		Fixedjoint,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		FlareLayer,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		FrictionJoint2D,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		GUIText,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		HingeJoint2D,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		Image,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		LightProbeProxyVolume,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		LightProbeGroup,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		LineRenderer,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		LayoutElement,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		Light,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		LensFlare
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static Dictionary<IconType, string> m_internalIcons;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x31328A0", Offset = "0x3131AA0", VA = "0x1831328A0")]
	public static string GetInternalStringPathOfEnumValue(IconType type)
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, Size = 4)]
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum SA_PD_MessageType
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Info,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Warning,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Error
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class ASIdentifierManagerExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	private Text advertisingTrackingEnabled;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	private Text advertisingIdentifier;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1AF79C0", Offset = "0x1AF6BC0", VA = "0x181AF79C0")]
	public void GetAdvertisingIdentifier()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1AF7A40", Offset = "0x1AF6C40", VA = "0x181AF7A40")]
	public void GetAdvertisingTrackingEnabled()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C40", Offset = "0x3B0E40", VA = "0x1803B1C40")]
	public ASIdentifierManagerExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ISN_AppdelegateUseExample : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1AFAB70", Offset = "0x1AF9D70", VA = "0x181AFAB70")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C40", Offset = "0x3B0E40", VA = "0x1803B1C40")]
	public ISN_AppdelegateUseExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ISN_CoreLocationDelegateExample : ISN_iCLLocationManagerDelegate
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1AFBA80", Offset = "0x1AFAC80", VA = "0x181AFBA80", Slot = "4")]
	public void DidChangeAuthorizationStatus(ISN_CLAuthorizationStatus authorizationStatus)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1AFBC60", Offset = "0x1AFAE60", VA = "0x181AFBC60", Slot = "5")]
	public void DidUpdateLocations(ISN_CLLocationArray locations)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1AFBB00", Offset = "0x1AFAD00", VA = "0x181AFBB00", Slot = "6")]
	public void DidFailWithError(SA_Error error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1AFBB60", Offset = "0x1AFAD60", VA = "0x181AFBB60", Slot = "7")]
	public void DidFinishDeferredUpdatesWithError(SA_Error error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1AFBBC0", Offset = "0x1AFADC0", VA = "0x181AFBBC0", Slot = "8")]
	public void DidPauseLocationUpdates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1AFBC10", Offset = "0x1AFAE10", VA = "0x181AFBC10", Slot = "9")]
	public void DidResumeLocationUpdates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1AFC060", Offset = "0x1AFB260", VA = "0x181AFC060")]
	private void ShowMessage(string title, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3AE300", Offset = "0x3AD500", VA = "0x1803AE300")]
	public ISN_CoreLocationDelegateExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class ISN_CoreLocationUseExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[SerializeField]
	private Button m_AuthButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[SerializeField]
	private Button m_StartUpdatingButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	private Button m_StopUpdatingButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	private Button m_RequestLocationButton;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1AFC320", Offset = "0x1AFB520", VA = "0x181AFC320")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1AFC1C0", Offset = "0x1AFB3C0", VA = "0x181AFC1C0")]
	private void ShowMessage(string title, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C40", Offset = "0x3B0E40", VA = "0x1803B1C40")]
	public ISN_CoreLocationUseExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class ISN_EventKitExamples : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private Text m_Error;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private string m_EventID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private string m_ReminderID;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1AFCF80", Offset = "0x1AFC180", VA = "0x181AFCF80")]
	public void RequestAccessToEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1AFD010", Offset = "0x1AFC210", VA = "0x181AFD010")]
	public void RequestAccessToReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1AFCB40", Offset = "0x1AFBD40", VA = "0x181AFCB40")]
	public void AddEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1AFCDE0", Offset = "0x1AFBFE0", VA = "0x181AFCDE0")]
	public void RemoveEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1AFCC80", Offset = "0x1AFBE80", VA = "0x181AFCC80")]
	public void AddReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1AFCEB0", Offset = "0x1AFC0B0", VA = "0x181AFCEB0")]
	public void RemoveReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C40", Offset = "0x3B0E40", VA = "0x1803B1C40")]
	public ISN_EventKitExamples()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class ISN_GameKitUseExample_TvOS : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	private Button m_SingInButton;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[SerializeField]
	private Button m_LeaderboardsUI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[SerializeField]
	private Button m_AchievementsUI;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1AFE970", Offset = "0x1AFDB70", VA = "0x181AFE970")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C40", Offset = "0x3B0E40", VA = "0x1803B1C40")]
	public ISN_GameKitUseExample_TvOS()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class ISN_MediaPlayerExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	[Header("Info Panel")]
	private Text m_title;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeField]
	private Text m_artist;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	private Text m_playbackState;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[SerializeField]
	[Header("Buttons")]
	private Button m_play;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[SerializeField]
	private Button m_stop;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[SerializeField]
	private Button m_pause;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[SerializeField]
	private Button m_next;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	[SerializeField]
	private Button m_previos;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private ISN_MPMusicPlayerController m_player;

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1AFF7A0", Offset = "0x1AFE9A0", VA = "0x181AFF7A0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1AFFB20", Offset = "0x1AFED20", VA = "0x181AFFB20")]
	private void UpdatePlayerStateUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C40", Offset = "0x3B0E40", VA = "0x1803B1C40")]
	public ISN_MediaPlayerExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ISN_CameraGalleryExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	[SerializeField]
	private Button m_loadFromGallery;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	[SerializeField]
	private Button m_loadFromCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	[SerializeField]
	private Button m_saveToGallery;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	[SerializeField]
	private Image m_image;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	[SerializeField]
	private GameObject m_go;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1AFB600", Offset = "0x1AFA800", VA = "0x181AFB600")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C40", Offset = "0x3B0E40", VA = "0x1803B1C40")]
	public ISN_CameraGalleryExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ISN_SocialExamples : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	[SerializeField]
	private Button m_twitterText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	[SerializeField]
	private Button m_twitterTextImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[SerializeField]
	private Button m_fbImage;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1B00DE0", Offset = "0x1AFFFE0", VA = "0x181B00DE0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C40", Offset = "0x3B0E40", VA = "0x1803B1C40")]
	public ISN_SocialExamples()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class ISN_UIImagePickerControllerExample : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	private RawImage m_Image;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	private Image m_Sprite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	[Header("Image")]
	private Button m_ImageCapture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[SerializeField]
	private Button m_ImageLibrary;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[SerializeField]
	private Button m_ImageAlbum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[SerializeField]
	[Header("Video")]
	private Button m_VideoCapture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[SerializeField]
	private Button m_VideoLibrary;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[SerializeField]
	private Button m_VideoAlbum;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	private Button m_VideoPlay;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private ISN_UIPickerControllerResult m_LastPickerResult;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1B01DC0", Offset = "0x1B00FC0", VA = "0x181B01DC0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1B01C40", Offset = "0x1B00E40", VA = "0x181B01C40")]
	private void AddFitter(GameObject go)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1B02790", Offset = "0x1B01990", VA = "0x181B02790")]
	private void UpdateUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1B023E0", Offset = "0x1B015E0", VA = "0x181B023E0")]
	private void StartPicker(ISN_UIImagePickerControllerSourceType sourceType, string mediaType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1B02240", Offset = "0x1B01440", VA = "0x181B02240")]
	private void DisplayResult(ISN_UIPickerControllerResult result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1B01CB0", Offset = "0x1B00EB0", VA = "0x181B01CB0")]
	private void ApplyImageToGui(Texture2D image)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1B02120", Offset = "0x1B01320", VA = "0x181B02120")]
	private void DisplayMessage(string message, [Optional] Action onClose)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C40", Offset = "0x3B0E40", VA = "0x1803B1C40")]
	public ISN_UIImagePickerControllerExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DocumentationExample : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1AF7DE0", Offset = "0x1AF6FE0", VA = "0x181AF7DE0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B1C40", Offset = "0x3B0E40", VA = "0x1803B1C40")]
	public DocumentationExample()
	{
	}
}
namespace SA.iOS.Tests.UserNotifications
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ISN_RemoteNotifications_Test : SA_BaseTest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private ISN_UNNotificationRequest m_request;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3131840", Offset = "0x3130A40", VA = "0x183131840", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_RemoteNotifications_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class ISN_UNAuthorization_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3132220", Offset = "0x3131420", VA = "0x183132220", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_UNAuthorization_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class ISN_UNSchedule_Test : SA_BaseTest
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private ISN_UNNotificationRequest m_request;

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3132300", Offset = "0x3131500", VA = "0x183132300", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3132670", Offset = "0x3131870", VA = "0x183132670")]
		private void ValidateRequest(ISN_UNNotificationRequest presentdeRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_UNSchedule_Test()
		{
		}
	}
}
namespace SA.iOS.Tests.UIKit
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ISN_UIImagePickerController_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3131DA0", Offset = "0x3130FA0", VA = "0x183131DA0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3131C70", Offset = "0x3130E70", VA = "0x183131C70")]
		private void TestVideo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_UIImagePickerController_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SaveToCameraRollTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3132DB0", Offset = "0x3131FB0", VA = "0x183132DB0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public SaveToCameraRollTest()
		{
		}
	}
}
namespace SA.iOS.Tests.Social
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ISN_DefaultSharingDialog_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1AFC8B0", Offset = "0x1AFBAB0", VA = "0x181AFC8B0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_DefaultSharingDialog_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class ISN_FacebookShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x31314F0", Offset = "0x31306F0", VA = "0x1831314F0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_FacebookShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class ISN_InstagramShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3131600", Offset = "0x3130800", VA = "0x183131600", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_InstagramShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ISN_MailShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3131710", Offset = "0x3130910", VA = "0x183131710", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_MailShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ISN_TextMessage_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3131A40", Offset = "0x3130C40", VA = "0x183131A40", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_TextMessage_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ISN_TwitterShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3131B60", Offset = "0x3130D60", VA = "0x183131B60", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_TwitterShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ISN_WhatsAppShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3132800", Offset = "0x3131A00", VA = "0x183132800", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_WhatsAppShare_Test()
		{
		}
	}
}
namespace SA.iOS.Tests.GameKit
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ISN_GKAchievementsLoad_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1AFD700", Offset = "0x1AFC900", VA = "0x181AFD700", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_GKAchievementsLoad_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ISN_GKAchievmentReport_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1AFDB10", Offset = "0x1AFCD10", VA = "0x181AFDB10", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1AFDA40", Offset = "0x1AFCC40", VA = "0x181AFDA40")]
		private void ReportCompletedAchievment(string achievementId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1AFD9D0", Offset = "0x1AFCBD0", VA = "0x181AFD9D0")]
		private void CheckIfCompleted(string achievementId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_GKAchievmentReport_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class ISN_GKAchievmentReset_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1AFDD80", Offset = "0x1AFCF80", VA = "0x181AFDD80", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1AFDD10", Offset = "0x1AFCF10", VA = "0x181AFDD10")]
		private void CheckIfResetCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_GKAchievmentReset_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ISN_GKGameCenterUI_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1AFDF30", Offset = "0x1AFD130", VA = "0x181AFDF30", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_GKGameCenterUI_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ISN_GKGenerateIdentityVerificationSignature_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1AFDF60", Offset = "0x1AFD160", VA = "0x181AFDF60", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_GKGenerateIdentityVerificationSignature_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class ISN_GKLoadLeaderboards_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1AFE160", Offset = "0x1AFD360", VA = "0x181AFE160", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_GKLoadLeaderboards_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class ISN_GKLocalPlayer_Authenticate_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1AFE3B0", Offset = "0x1AFD5B0", VA = "0x181AFE3B0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_GKLocalPlayer_Authenticate_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class ISN_GKReportingScores_Test : ISN_GKSingleLeaderboard_Test
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1AFE5A0", Offset = "0x1AFD7A0", VA = "0x181AFE5A0", Slot = "7")]
		public override void OnLeaderboardReady(ISN_GKLeaderboard leaderboard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_GKReportingScores_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class ISN_GKRetrievingScores_Test : ISN_GKSingleLeaderboard_Test
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1AFE710", Offset = "0x1AFD910", VA = "0x181AFE710", Slot = "7")]
		public override void OnLeaderboardReady(ISN_GKLeaderboard leaderboard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_GKRetrievingScores_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class ISN_GKSingleLeaderboard_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1AFE850", Offset = "0x1AFDA50", VA = "0x181AFE850", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void OnLeaderboardReady(ISN_GKLeaderboard leaderboard);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		protected ISN_GKSingleLeaderboard_Test()
		{
		}
	}
}
namespace SA.iOS.Tests.Foundation
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class ISN_AudioSessionTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1AFAD40", Offset = "0x1AF9F40", VA = "0x181AFAD40", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_AudioSessionTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class ISN_BuildInfoTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1AFAF10", Offset = "0x1AFA110", VA = "0x181AFAF10", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_BuildInfoTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ISN_NSFileManagerTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1AFFC90", Offset = "0x1AFEE90", VA = "0x181AFFC90", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_NSFileManagerTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class ISN_TimeZoneTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1B01060", Offset = "0x1B00260", VA = "0x181B01060", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_TimeZoneTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class ISN_iCloudKeyValueStorageTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1B05C60", Offset = "0x1B04E60", VA = "0x181B05C60", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_iCloudKeyValueStorageTest()
		{
		}
	}
}
namespace SA.iOS.Tests.Contacts
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class ISN_CNContactsPicker_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1AFAFB0", Offset = "0x1AFA1B0", VA = "0x181AFAFB0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_CNContactsPicker_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class ISN_CNFetchPhoneContacts_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1AFB4F0", Offset = "0x1AFA6F0", VA = "0x181AFB4F0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1AFB070", Offset = "0x1AFA270", VA = "0x181AFB070")]
		public static void PrintContacts(List<ISN_CNContact> contacts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADA0", Offset = "0x1AF9FA0", VA = "0x181AFADA0")]
		public ISN_CNFetchPhoneContacts_Test()
		{
		}
	}
}
namespace SA.iOS.Examples
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class AVKitUseExample : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1AF7AE0", Offset = "0x1AF6CE0", VA = "0x181AF7AE0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3B1C40", Offset = "0x3B0E40", VA = "0x1803B1C40")]
		public AVKitUseExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class ISN_BaseIOSFeaturePreview : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected GUIStyle style;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected int buttonWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		protected int buttonHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected float StartY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		protected float StartX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		protected float XStartPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		protected float YStartPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		protected float XButtonStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		protected float YButtonStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		protected float YLableStep;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1AFADB0", Offset = "0x1AF9FB0", VA = "0x181AFADB0", Slot = "4")]
		protected virtual void InitStyles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x615F50", Offset = "0x615150", VA = "0x180615F50", Slot = "5")]
		public virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1AFAEB0", Offset = "0x1AFA0B0", VA = "0x181AFAEB0")]
		public void UpdateToStartPos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1AFAEA0", Offset = "0x1AFA0A0", VA = "0x181AFAEA0")]
		public void LoadLevel(string levelName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1AFAEC0", Offset = "0x1AFA0C0", VA = "0x181AFAEC0")]
		public ISN_BaseIOSFeaturePreview()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class ISN_FoundationExamples
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1AFD600", Offset = "0x1AFC800", VA = "0x181AFD600")]
		public void LocaleInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3AE300", Offset = "0x3AD500", VA = "0x1803AE300")]
		public ISN_FoundationExamples()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class GameKitUseExample : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private List<ISN_GKSavedGame> m_fetchedSavedGames;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private List<string> m_conflictedSavedGames;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x1AF8800", Offset = "0x1AF7A00", VA = "0x181AF8800")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x1AF90B0", Offset = "0x1AF82B0", VA = "0x181AF90B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1AF88E0", Offset = "0x1AF7AE0", VA = "0x181AF88E0")]
		private void DidModifySavedGame(ISN_GKSavedGameSaveResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1AF8BC0", Offset = "0x1AF7DC0", VA = "0x181AF8BC0")]
		private void HasConflictingSavedGames(ISN_GKSavedGameFetchResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1AF9190", Offset = "0x1AF8390", VA = "0x181AF9190")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x1AFAAF0", Offset = "0x1AF9CF0", VA = "0x181AFAAF0")]
		public GameKitUseExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class ISN_UIController : SA_UIController
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public ScrollRect scroll;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1B012F0", Offset = "0x1B004F0", VA = "0x181B012F0", Slot = "7")]
		public override GameObject AddSideMenuElement(List<SA_ExampleSubsectionConfig> subsections, bool isActive)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x1B018E0", Offset = "0x1B00AE0", VA = "0x181B018E0")]
		private void SetToggle(string sceneName, string text, SA_SideToggleStyle style, Toggle toggle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1B01560", Offset = "0x1B00760", VA = "0x181B01560", Slot = "5")]
		public override Toggle AddTopMenuElement(string name, Sprite icon, bool isActive, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1B018C0", Offset = "0x1B00AC0", VA = "0x181B018C0", Slot = "4")]
		public override void SetLogo(Sprite sprite)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1B01B60", Offset = "0x1B00D60", VA = "0x181B01B60", Slot = "8")]
		public override void UnloadContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1B01800", Offset = "0x1B00A00", VA = "0x181B01800", Slot = "9")]
		public override void LoadContent(GameObject canvas)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1B01AB0", Offset = "0x1B00CB0", VA = "0x181B01AB0", Slot = "6")]
		public override void ShowTopMenuItem(GameObject menuItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1B01240", Offset = "0x1B00440", VA = "0x181B01240", Slot = "10")]
		public override void AddLog(string log)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3B1C40", Offset = "0x3B0E40", VA = "0x1803B1C40")]
		public ISN_UIController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class SA_ExampleSceneConfig : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public List<SA_ExampleServicesConfig> Services;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Sprite Logo;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x1B05DA0", Offset = "0x1B04FA0", VA = "0x181B05DA0")]
		public SA_ExampleSceneConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class SA_ExampleSceneController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private SA_ExampleSceneConfig m_config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private SA_UIController m_UIController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private List<GameObject> m_links;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1B064B0", Offset = "0x1B056B0", VA = "0x181B064B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1B06650", Offset = "0x1B05850", VA = "0x181B06650")]
		private void Subscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1B06470", Offset = "0x1B05670", VA = "0x181B06470")]
		private void SetLogo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x1B05E30", Offset = "0x1B05030", VA = "0x181B05E30")]
		private void GenerateMenuUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1B06170", Offset = "0x1B05370", VA = "0x181B06170")]
		private void HandlerTopMenuClick(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1B06030", Offset = "0x1B05230", VA = "0x181B06030")]
		private void HandlerSideMenuClick(string sceneName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1B06220", Offset = "0x1B05420", VA = "0x181B06220")]
		private void LoadScene(string sceneName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x1B067C0", Offset = "0x1B059C0", VA = "0x181B067C0")]
		private void UnloadScene()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1B06320", Offset = "0x1B05520", VA = "0x181B06320")]
		private void SceneLoaded(Scene scene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1B05E00", Offset = "0x1B05000", VA = "0x181B05E00")]
		private void Application_LogMessageReceived(string condition, string stackTrace, LogType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1B06830", Offset = "0x1B05A30", VA = "0x181B06830")]
		public SA_ExampleSceneController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class SA_ExampleServicesConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public Sprite Icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public List<SA_ExampleSubsectionConfig> Subsections;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x1B06890", Offset = "0x1B05A90", VA = "0x181B06890")]
		public SA_ExampleServicesConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class SA_ExampleSubsectionConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public SA_SceneField Scene;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3AE300", Offset = "0x3AD500", VA = "0x1803AE300")]
		public SA_ExampleSubsectionConfig()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class SA_SceneField
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private UnityEngine.Object sceneAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private string sceneName;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string SceneName
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x3AE670", Offset = "0x3AD870", VA = "0x1803AE670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1B06BD0", Offset = "0x1B05DD0", VA = "0x181B06BD0")]
		public SA_SceneField()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class SA_SideToggleStyle : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[HideInInspector]
		public Text Label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private GameObject m_mainContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private string m_sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Toggle m_toggle;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x1B06D20", Offset = "0x1B05F20", VA = "0x181B06D20")]
		public void SetParam(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x1B06C10", Offset = "0x1B05E10", VA = "0x181B06C10", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1B06C40", Offset = "0x1B05E40", VA = "0x181B06C40", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1B06E30", Offset = "0x1B06030", VA = "0x181B06E30")]
		public void SetWhite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x1B06CA0", Offset = "0x1B05EA0", VA = "0x181B06CA0")]
		public void SetBlue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3B1C40", Offset = "0x3B0E40", VA = "0x1803B1C40")]
		public SA_SideToggleStyle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class SA_TopToggleStyle : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private Text m_label;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private Image m_icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private Toggle m_toggle;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1B06FC0", Offset = "0x1B061C0", VA = "0x181B06FC0")]
		public Toggle SetToggle(bool isActive, string text, Sprite sprite)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x1B06E80", Offset = "0x1B06080", VA = "0x181B06E80", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1B06EB0", Offset = "0x1B060B0", VA = "0x181B06EB0", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1B07120", Offset = "0x1B06320", VA = "0x181B07120")]
		public void SetWhite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1B06EE0", Offset = "0x1B060E0", VA = "0x181B06EE0")]
		public void SetBlue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3B1C40", Offset = "0x3B0E40", VA = "0x1803B1C40")]
		public SA_TopToggleStyle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public abstract class SA_UIController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Action<int> OnTopMenuClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Action<string> OnSideMenuClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		protected Image m_logo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[SerializeField]
		protected GameObject m_topMenuItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[SerializeField]
		protected GameObject m_sideMenuItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		protected GameObject m_sideScroll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		protected GameObject m_mainContent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		protected Text m_logger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		protected GameObject m_prevSideItem;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void SetLogo(Sprite sprite);

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract Toggle AddTopMenuElement(string name, Sprite icon, bool isActive, int index);

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void ShowTopMenuItem(GameObject menuItem);

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract GameObject AddSideMenuElement(List<SA_ExampleSubsectionConfig> subsections, bool isActive);

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract void UnloadContent();

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void LoadContent(GameObject canvas);

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		public abstract void AddLog(string log);

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x3B1C40", Offset = "0x3B0E40", VA = "0x1803B1C40")]
		protected SA_UIController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class ISN_ReplayKitUseExample : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private bool IsRecording;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1B00830", Offset = "0x1AFFA30", VA = "0x181B00830")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1B00A40", Offset = "0x1AFFC40", VA = "0x181B00A40")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x1B00CA0", Offset = "0x1AFFEA0", VA = "0x181B00CA0")]
		private void OnRecordStopped(ISN_RPStopResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x1AFAEC0", Offset = "0x1AFA0C0", VA = "0x181AFAEC0")]
		public ISN_ReplayKitUseExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class ISN_MarketExample : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static ISN_PaymentManagerExample s_paymentManager;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x1AFEBF0", Offset = "0x1AFDDF0", VA = "0x181AFEBF0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1AFAEC0", Offset = "0x1AFA0C0", VA = "0x181AFAEC0")]
		public ISN_MarketExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class ISN_PaymentManagerExample : ISN_iSKPaymentTransactionObserver
	{
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public const string SMALL_PACK = "your.product.id1.here";

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public const string NC_PACK = "your.product.id2.here";

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static bool IsInitialized;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x1B00680", Offset = "0x1AFF880", VA = "0x181B00680")]
		public void init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1B005D0", Offset = "0x1AFF7D0", VA = "0x181B005D0")]
		private static void UnlockProducts(ISN_iSKPaymentTransaction transaction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1AFFF80", Offset = "0x1AFF180", VA = "0x181AFFF80", Slot = "4")]
		public void OnTransactionUpdated(ISN_iSKPaymentTransaction transaction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3BB130", Offset = "0x3BA330", VA = "0x1803BB130", Slot = "5")]
		public void OnTransactionRemoved(ISN_iSKPaymentTransaction result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3B0FF0", Offset = "0x3B01F0", VA = "0x1803B0FF0", Slot = "6")]
		public bool OnShouldAddStorePayment(ISN_SKProduct result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1AFFD10", Offset = "0x1AFEF10", VA = "0x181AFFD10", Slot = "7")]
		public void OnRestoreTransactionsComplete(SA_Result result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3AE300", Offset = "0x3AD500", VA = "0x1803AE300")]
		public ISN_PaymentManagerExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class ISN_UIKitExample : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		private Texture2D m_icon;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x1B02820", Offset = "0x1B01A20", VA = "0x181B02820")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1B029A0", Offset = "0x1B01BA0", VA = "0x181B029A0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1AFAEC0", Offset = "0x1AFA0C0", VA = "0x181AFAEC0")]
		public ISN_UIKitExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class ISN_UserNotificationExample : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1B04040", Offset = "0x1B03240", VA = "0x181B04040")]
		public void RequestUserNotificationPermission()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1B03900", Offset = "0x1B02B00", VA = "0x181B03900")]
		public void GetSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1B03CD0", Offset = "0x1B02ED0", VA = "0x181B03CD0")]
		public void NotificationInterval()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x1B03B20", Offset = "0x1B02D20", VA = "0x181B03B20")]
		public void NotificationCalendar()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1B03E50", Offset = "0x1B03050", VA = "0x181B03E50")]
		public void NotificationLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1B039D0", Offset = "0x1B02BD0", VA = "0x181B039D0")]
		public void NoSoundToTrigger()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3B1C40", Offset = "0x3B0E40", VA = "0x1803B1C40")]
		public ISN_UserNotificationExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class ISN_UserNotificationsExamples : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1B04220", Offset = "0x1B03420", VA = "0x181B04220")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x1B059B0", Offset = "0x1B04BB0", VA = "0x181B059B0")]
		private void PrintNotification(ISN_UNNotification notification)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1B04D20", Offset = "0x1B03F20", VA = "0x181B04D20")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1B04EF0", Offset = "0x1B040F0", VA = "0x181B04EF0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1B04990", Offset = "0x1B03B90", VA = "0x181B04990")]
		private void DocsExample()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1B044E0", Offset = "0x1B036E0", VA = "0x181B044E0")]
		private void ContactsUse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x1AFAEC0", Offset = "0x1AFA0C0", VA = "0x181AFAEC0")]
		public ISN_UserNotificationsExamples()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class iCloudUseExample : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private float valueF;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x1B0CCB0", Offset = "0x1B0BEB0", VA = "0x181B0CCB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1B0CDA0", Offset = "0x1B0BFA0", VA = "0x181B0CDA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1B0D720", Offset = "0x1B0C920", VA = "0x181B0D720")]
		private void StoreDidChangeExternally(ISN_NSStoreDidChangeExternallyNotification result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x1B0CE30", Offset = "0x1B0C030", VA = "0x181B0CE30")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x1B0D960", Offset = "0x1B0CB60", VA = "0x181B0D960")]
		public iCloudUseExample()
		{
		}
	}
}
namespace SA.Foundation.EditorStylesCollection
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public class SA_ESC_PropertyDrawerExample : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Space]
		[Multiline]
		[SerializeField]
		[Header("Unity Default Property Drawers")]
		[Space(10f)]
		private string m_multilineString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[TextArea]
		public string m_textAreaString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		[Range(0f, 100f)]
		private int m_intRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		[Range(0f, 1f)]
		private float m_floatRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		[Tooltip("Health value between 0 and 100.")]
		private float m_hoverMouseToSeeTooltip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Space]
		[Header("Sliders")]
		[Space(10f)]
		public float m_simpleSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SA_PD_MinMaxSlider(0f, 3f, 255f, 0f, 0f)]
		public Vector2 m_MinMaxSlider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Header("Help Boxes with text message")]
		[SA_PD_HelpBox(SA_PD_MessageType.Info)]
		public string myHelpBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SA_PD_HelpBox(SA_PD_MessageType.Warning)]
		public string myString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
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
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SA_PD_IndentLevel(2)]
		public string indentLevel1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SA_PD_IndentLevel(0)]
		public string indentLevel2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Space]
		[Header("Conditional Hide / Show fields")]
		[Space(10f)]
		public bool showBelowSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public float range;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public bool isExists;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[SA_PD_Conditional("showBelowSettings", true)]
		public AnimationCurve curve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Space]
		[Header("Conditional Disable / Enable fields")]
		[Space(10f)]
		public bool enableBelowSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SA_PD_Conditional("enableBelowSettings")]
		public bool firstSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SA_PD_Conditional("enableBelowSettings")]
		public float secondSettigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Space]
		[Header("Label with Icon")]
		[Space(10f)]
		[SA_PD_LabelWithIcon("Plugins/StansAssets/Support2018/Modules/Editor/EditorStylesCollection/Resources/Icons/gameObjectIcon.png")]
		public string myLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SA_PD_LabelWithIcon(SA_PD_EditorIcons.IconType.Light)]
		public string favoriteLabel;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x1B05D10", Offset = "0x1B04F10", VA = "0x181B05D10")]
		public SA_ESC_PropertyDrawerExample()
		{
		}
	}
}
namespace SA.Foundation.PropertyDrawers.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_ConditionalAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private string m_conditionalSourceField;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private bool m_hideInInspector;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string ConditionalSourceField
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x3AE670", Offset = "0x3AD870", VA = "0x1803AE670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool HideInInspector
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x407E90", Offset = "0x407090", VA = "0x180407E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1B068F0", Offset = "0x1B05AF0", VA = "0x181B068F0")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x1B06950", Offset = "0x1B05B50", VA = "0x181B06950")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField, bool hideInInspector)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_HelpBoxAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private SA_PD_MessageType m_type;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x408E40", Offset = "0x408040", VA = "0x180408E40")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1B069C0", Offset = "0x1B05BC0", VA = "0x181B069C0")]
		public SA_PD_HelpBoxAttribute(SA_PD_MessageType type)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_IndentLevelAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int m_indentLevel;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int IndentLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x408E40", Offset = "0x408040", VA = "0x180408E40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1B069C0", Offset = "0x1B05BC0", VA = "0x181B069C0")]
		public SA_PD_IndentLevelAttribute(int indentLevel)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_LabelWithIconAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private string m_iconPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private string m_internalIconPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private SA_PD_EditorIcons.IconType m_iconType;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string IconPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x3AE670", Offset = "0x3AD870", VA = "0x1803AE670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string InternalIconPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x3B1A00", Offset = "0x3B0C00", VA = "0x1803B1A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1B06A30", Offset = "0x1B05C30", VA = "0x181B06A30")]
		public SA_PD_LabelWithIconAttribute(string iconPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1B06AA0", Offset = "0x1B05CA0", VA = "0x181B06AA0")]
		public SA_PD_LabelWithIconAttribute(SA_PD_EditorIcons.IconType icon)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_MinMaxSliderAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private float m_minLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private float m_maxLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private Color m_color;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float MinLimit
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x435210", Offset = "0x434410", VA = "0x180435210")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x434F40", Offset = "0x434140", VA = "0x180434F40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x583A10", Offset = "0x582C10", VA = "0x180583A10")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1B06B40", Offset = "0x1B05D40", VA = "0x181B06B40")]
		public SA_PD_MinMaxSliderAttribute(float minLimit, float maxLimit, float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[AttributeUsage(AttributeTargets.Field)]
	public class SA_PD_SimpleSliderAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private float m_minLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private float m_maxLimit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private Color m_color;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public float MinLimit
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x435210", Offset = "0x434410", VA = "0x180435210")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x434F40", Offset = "0x434140", VA = "0x180434F40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x583A10", Offset = "0x582C10", VA = "0x180583A10")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1B06B40", Offset = "0x1B05D40", VA = "0x181B06B40")]
		public SA_PD_SimpleSliderAttribute(float minLimit, float maxLimit, float r, float g, float b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class SA_PD_HeaderDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private string m_text;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x3AE670", Offset = "0x3AD870", VA = "0x1803AE670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4257E0", Offset = "0x4249E0", VA = "0x1804257E0")]
		public SA_PD_HeaderDecoratorAttribute(string text)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_HelpboxDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private string m_message;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private SA_PD_MessageType m_type;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public string Message
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x3AE670", Offset = "0x3AD870", VA = "0x1803AE670")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x443960", Offset = "0x442B60", VA = "0x180443960")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1B069F0", Offset = "0x1B05BF0", VA = "0x181B069F0")]
		public SA_PD_HelpboxDecoratorAttribute(SA_PD_MessageType type, string message = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_PRInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x43A5F0", Offset = "0x4397F0", VA = "0x18043A5F0")]
		public SA_PD_PRInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_StandartInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x43A5F0", Offset = "0x4397F0", VA = "0x18043A5F0")]
		public SA_PD_StandartInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_ThingInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x43A5F0", Offset = "0x4397F0", VA = "0x18043A5F0")]
		public SA_PD_ThingInsertionDecoratorAttribute()
		{
		}
	}
}
namespace Beebyte.Obfuscator
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
	public class DoNotFakeAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x409A00", Offset = "0x408C00", VA = "0x180409A00")]
		public DoNotFakeAttribute()
		{
		}
	}
	[StructLayout((LayoutKind)3, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public enum MessageCode
	{
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		UnityReflectionMethodNotFound
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[AttributeUsage(AttributeTargets.Method)]
	public class ObfuscateLiteralsAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x409A00", Offset = "0x408C00", VA = "0x180409A00")]
		public ObfuscateLiteralsAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class RenameAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly string target;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x409A00", Offset = "0x408C00", VA = "0x180409A00")]
		private RenameAttribute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x69CDB0", Offset = "0x69BFB0", VA = "0x18069CDB0")]
		public RenameAttribute(string target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4089A0", Offset = "0x407BA0", VA = "0x1804089A0")]
		public string GetTarget()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
	public class ReplaceLiteralsWithNameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x409A00", Offset = "0x408C00", VA = "0x180409A00")]
		public ReplaceLiteralsWithNameAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x409A00", Offset = "0x408C00", VA = "0x180409A00")]
		public SkipAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipRenameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x409A00", Offset = "0x408C00", VA = "0x180409A00")]
		public SkipRenameAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[AttributeUsage(AttributeTargets.Method)]
	public class SuppressLogAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly MessageCode _messageCode;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x409A00", Offset = "0x408C00", VA = "0x180409A00")]
		private SuppressLogAttribute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xEE7420", Offset = "0xEE6620", VA = "0x180EE7420")]
		public SuppressLogAttribute(MessageCode messageCode)
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
