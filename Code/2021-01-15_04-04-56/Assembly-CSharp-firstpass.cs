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
	[Cpp2IlInjected.Address(RVA = "0x13FC7F0", Offset = "0x13FB5F0", VA = "0x1813FC7F0")]
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
	[Cpp2IlInjected.Address(RVA = "0xB21FA0", Offset = "0xB20DA0", VA = "0x180B21FA0")]
	public void GetAdvertisingIdentifier()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xB22020", Offset = "0xB20E20", VA = "0x180B22020")]
	public void GetAdvertisingTrackingEnabled()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3CF600", Offset = "0x3CE400", VA = "0x1803CF600")]
	public ASIdentifierManagerExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ISN_AppdelegateUseExample : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xB25150", Offset = "0xB23F50", VA = "0x180B25150")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3CF600", Offset = "0x3CE400", VA = "0x1803CF600")]
	public ISN_AppdelegateUseExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ISN_CoreLocationDelegateExample : ISN_iCLLocationManagerDelegate
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xB26060", Offset = "0xB24E60", VA = "0x180B26060", Slot = "4")]
	public void DidChangeAuthorizationStatus(ISN_CLAuthorizationStatus authorizationStatus)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xB26240", Offset = "0xB25040", VA = "0x180B26240", Slot = "5")]
	public void DidUpdateLocations(ISN_CLLocationArray locations)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xB260E0", Offset = "0xB24EE0", VA = "0x180B260E0", Slot = "6")]
	public void DidFailWithError(SA_Error error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xB26140", Offset = "0xB24F40", VA = "0x180B26140", Slot = "7")]
	public void DidFinishDeferredUpdatesWithError(SA_Error error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xB261A0", Offset = "0xB24FA0", VA = "0x180B261A0", Slot = "8")]
	public void DidPauseLocationUpdates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xB261F0", Offset = "0xB24FF0", VA = "0x180B261F0", Slot = "9")]
	public void DidResumeLocationUpdates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xB26640", Offset = "0xB25440", VA = "0x180B26640")]
	private void ShowMessage(string title, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3AD870", Offset = "0x3AC670", VA = "0x1803AD870")]
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
	[Cpp2IlInjected.Address(RVA = "0xB26900", Offset = "0xB25700", VA = "0x180B26900")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0xB267A0", Offset = "0xB255A0", VA = "0x180B267A0")]
	private void ShowMessage(string title, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3CF600", Offset = "0x3CE400", VA = "0x1803CF600")]
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
	[Cpp2IlInjected.Address(RVA = "0xB27560", Offset = "0xB26360", VA = "0x180B27560")]
	public void RequestAccessToEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0xB275F0", Offset = "0xB263F0", VA = "0x180B275F0")]
	public void RequestAccessToReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0xB27120", Offset = "0xB25F20", VA = "0x180B27120")]
	public void AddEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xB273C0", Offset = "0xB261C0", VA = "0x180B273C0")]
	public void RemoveEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xB27260", Offset = "0xB26060", VA = "0x180B27260")]
	public void AddReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0xB27490", Offset = "0xB26290", VA = "0x180B27490")]
	public void RemoveReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3CF600", Offset = "0x3CE400", VA = "0x1803CF600")]
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
	[Cpp2IlInjected.Address(RVA = "0xB28F50", Offset = "0xB27D50", VA = "0x180B28F50")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3CF600", Offset = "0x3CE400", VA = "0x1803CF600")]
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
	[Cpp2IlInjected.Address(RVA = "0xB29D80", Offset = "0xB28B80", VA = "0x180B29D80")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xB2A100", Offset = "0xB28F00", VA = "0x180B2A100")]
	private void UpdatePlayerStateUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3CF600", Offset = "0x3CE400", VA = "0x1803CF600")]
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
	[Cpp2IlInjected.Address(RVA = "0xB25BE0", Offset = "0xB249E0", VA = "0x180B25BE0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3CF600", Offset = "0x3CE400", VA = "0x1803CF600")]
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
	[Cpp2IlInjected.Address(RVA = "0xB2B3C0", Offset = "0xB2A1C0", VA = "0x180B2B3C0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3CF600", Offset = "0x3CE400", VA = "0x1803CF600")]
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
	[Cpp2IlInjected.Address(RVA = "0xB2C3A0", Offset = "0xB2B1A0", VA = "0x180B2C3A0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xB2C220", Offset = "0xB2B020", VA = "0x180B2C220")]
	private void AddFitter(GameObject go)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xB2CD70", Offset = "0xB2BB70", VA = "0x180B2CD70")]
	private void UpdateUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0xB2C9C0", Offset = "0xB2B7C0", VA = "0x180B2C9C0")]
	private void StartPicker(ISN_UIImagePickerControllerSourceType sourceType, string mediaType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xB2C820", Offset = "0xB2B620", VA = "0x180B2C820")]
	private void DisplayResult(ISN_UIPickerControllerResult result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0xB2C290", Offset = "0xB2B090", VA = "0x180B2C290")]
	private void ApplyImageToGui(Texture2D image)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0xB2C700", Offset = "0xB2B500", VA = "0x180B2C700")]
	private void DisplayMessage(string message, [Optional] Action onClose)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3CF600", Offset = "0x3CE400", VA = "0x1803CF600")]
	public ISN_UIImagePickerControllerExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DocumentationExample : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xB223C0", Offset = "0xB211C0", VA = "0x180B223C0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3CF600", Offset = "0x3CE400", VA = "0x1803CF600")]
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
		[Cpp2IlInjected.Address(RVA = "0x13FB790", Offset = "0x13FA590", VA = "0x1813FB790", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_RemoteNotifications_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class ISN_UNAuthorization_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x13FC170", Offset = "0x13FAF70", VA = "0x1813FC170", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
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
		[Cpp2IlInjected.Address(RVA = "0x13FC250", Offset = "0x13FB050", VA = "0x1813FC250", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x13FC5C0", Offset = "0x13FB3C0", VA = "0x1813FC5C0")]
		private void ValidateRequest(ISN_UNNotificationRequest presentdeRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
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
		[Cpp2IlInjected.Address(RVA = "0x13FBCF0", Offset = "0x13FAAF0", VA = "0x1813FBCF0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x13FBBC0", Offset = "0x13FA9C0", VA = "0x1813FBBC0")]
		private void TestVideo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_UIImagePickerController_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SaveToCameraRollTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x13FCD00", Offset = "0x13FBB00", VA = "0x1813FCD00", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
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
		[Cpp2IlInjected.Address(RVA = "0xB26E90", Offset = "0xB25C90", VA = "0x180B26E90", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_DefaultSharingDialog_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class ISN_FacebookShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x13FB440", Offset = "0x13FA240", VA = "0x1813FB440", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_FacebookShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class ISN_InstagramShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x13FB550", Offset = "0x13FA350", VA = "0x1813FB550", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_InstagramShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ISN_MailShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x13FB660", Offset = "0x13FA460", VA = "0x1813FB660", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_MailShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ISN_TextMessage_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x13FB990", Offset = "0x13FA790", VA = "0x1813FB990", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_TextMessage_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ISN_TwitterShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x13FBAB0", Offset = "0x13FA8B0", VA = "0x1813FBAB0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_TwitterShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ISN_WhatsAppShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x13FC750", Offset = "0x13FB550", VA = "0x1813FC750", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
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
		[Cpp2IlInjected.Address(RVA = "0xB27CE0", Offset = "0xB26AE0", VA = "0x180B27CE0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_GKAchievementsLoad_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ISN_GKAchievmentReport_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xB280F0", Offset = "0xB26EF0", VA = "0x180B280F0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB28020", Offset = "0xB26E20", VA = "0x180B28020")]
		private void ReportCompletedAchievment(string achievementId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xB27FB0", Offset = "0xB26DB0", VA = "0x180B27FB0")]
		private void CheckIfCompleted(string achievementId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_GKAchievmentReport_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class ISN_GKAchievmentReset_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xB28360", Offset = "0xB27160", VA = "0x180B28360", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xB282F0", Offset = "0xB270F0", VA = "0x180B282F0")]
		private void CheckIfResetCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_GKAchievmentReset_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ISN_GKGameCenterUI_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xB28510", Offset = "0xB27310", VA = "0x180B28510", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_GKGameCenterUI_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ISN_GKGenerateIdentityVerificationSignature_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xB28540", Offset = "0xB27340", VA = "0x180B28540", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_GKGenerateIdentityVerificationSignature_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class ISN_GKLoadLeaderboards_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xB28740", Offset = "0xB27540", VA = "0x180B28740", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_GKLoadLeaderboards_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class ISN_GKLocalPlayer_Authenticate_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xB28990", Offset = "0xB27790", VA = "0x180B28990", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_GKLocalPlayer_Authenticate_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class ISN_GKReportingScores_Test : ISN_GKSingleLeaderboard_Test
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xB28B80", Offset = "0xB27980", VA = "0x180B28B80", Slot = "7")]
		public override void OnLeaderboardReady(ISN_GKLeaderboard leaderboard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_GKReportingScores_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class ISN_GKRetrievingScores_Test : ISN_GKSingleLeaderboard_Test
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xB28CF0", Offset = "0xB27AF0", VA = "0x180B28CF0", Slot = "7")]
		public override void OnLeaderboardReady(ISN_GKLeaderboard leaderboard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_GKRetrievingScores_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class ISN_GKSingleLeaderboard_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xB28E30", Offset = "0xB27C30", VA = "0x180B28E30", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void OnLeaderboardReady(ISN_GKLeaderboard leaderboard);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
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
		[Cpp2IlInjected.Address(RVA = "0xB25320", Offset = "0xB24120", VA = "0x180B25320", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_AudioSessionTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class ISN_BuildInfoTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xB254F0", Offset = "0xB242F0", VA = "0x180B254F0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_BuildInfoTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ISN_NSFileManagerTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xB2A270", Offset = "0xB29070", VA = "0x180B2A270", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_NSFileManagerTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class ISN_TimeZoneTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xB2B640", Offset = "0xB2A440", VA = "0x180B2B640", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_TimeZoneTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class ISN_iCloudKeyValueStorageTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xB30240", Offset = "0xB2F040", VA = "0x180B30240", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
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
		[Cpp2IlInjected.Address(RVA = "0xB25590", Offset = "0xB24390", VA = "0x180B25590", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
		public ISN_CNContactsPicker_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class ISN_CNFetchPhoneContacts_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xB25AD0", Offset = "0xB248D0", VA = "0x180B25AD0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xB25650", Offset = "0xB24450", VA = "0x180B25650")]
		public static void PrintContacts(List<ISN_CNContact> contacts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0xB25380", Offset = "0xB24180", VA = "0x180B25380")]
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
		[Cpp2IlInjected.Address(RVA = "0xB220C0", Offset = "0xB20EC0", VA = "0x180B220C0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3CF600", Offset = "0x3CE400", VA = "0x1803CF600")]
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
		[Cpp2IlInjected.Address(RVA = "0xB25390", Offset = "0xB24190", VA = "0x180B25390", Slot = "4")]
		protected virtual void InitStyles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3CE220", Offset = "0x3CD020", VA = "0x1803CE220", Slot = "5")]
		public virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xB25490", Offset = "0xB24290", VA = "0x180B25490")]
		public void UpdateToStartPos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xB25480", Offset = "0xB24280", VA = "0x180B25480")]
		public void LoadLevel(string levelName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xB254A0", Offset = "0xB242A0", VA = "0x180B254A0")]
		public ISN_BaseIOSFeaturePreview()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class ISN_FoundationExamples
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xB27BE0", Offset = "0xB269E0", VA = "0x180B27BE0")]
		public void LocaleInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3AD870", Offset = "0x3AC670", VA = "0x1803AD870")]
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
		[Cpp2IlInjected.Address(RVA = "0xB22DE0", Offset = "0xB21BE0", VA = "0x180B22DE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xB23690", Offset = "0xB22490", VA = "0x180B23690")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xB22EC0", Offset = "0xB21CC0", VA = "0x180B22EC0")]
		private void DidModifySavedGame(ISN_GKSavedGameSaveResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xB231A0", Offset = "0xB21FA0", VA = "0x180B231A0")]
		private void HasConflictingSavedGames(ISN_GKSavedGameFetchResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xB23770", Offset = "0xB22570", VA = "0x180B23770")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xB250D0", Offset = "0xB23ED0", VA = "0x180B250D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB2B8D0", Offset = "0xB2A6D0", VA = "0x180B2B8D0", Slot = "7")]
		public override GameObject AddSideMenuElement(List<SA_ExampleSubsectionConfig> subsections, bool isActive)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xB2BEC0", Offset = "0xB2ACC0", VA = "0x180B2BEC0")]
		private void SetToggle(string sceneName, string text, SA_SideToggleStyle style, Toggle toggle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xB2BB40", Offset = "0xB2A940", VA = "0x180B2BB40", Slot = "5")]
		public override Toggle AddTopMenuElement(string name, Sprite icon, bool isActive, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xB2BEA0", Offset = "0xB2ACA0", VA = "0x180B2BEA0", Slot = "4")]
		public override void SetLogo(Sprite sprite)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xB2C140", Offset = "0xB2AF40", VA = "0x180B2C140", Slot = "8")]
		public override void UnloadContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xB2BDE0", Offset = "0xB2ABE0", VA = "0x180B2BDE0", Slot = "9")]
		public override void LoadContent(GameObject canvas)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xB2C090", Offset = "0xB2AE90", VA = "0x180B2C090", Slot = "6")]
		public override void ShowTopMenuItem(GameObject menuItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xB2B820", Offset = "0xB2A620", VA = "0x180B2B820", Slot = "10")]
		public override void AddLog(string log)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3CF600", Offset = "0x3CE400", VA = "0x1803CF600")]
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
		[Cpp2IlInjected.Address(RVA = "0xB30380", Offset = "0xB2F180", VA = "0x180B30380")]
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
		[Cpp2IlInjected.Address(RVA = "0xB30A90", Offset = "0xB2F890", VA = "0x180B30A90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xB30C30", Offset = "0xB2FA30", VA = "0x180B30C30")]
		private void Subscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xB30A50", Offset = "0xB2F850", VA = "0x180B30A50")]
		private void SetLogo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xB30410", Offset = "0xB2F210", VA = "0x180B30410")]
		private void GenerateMenuUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xB30750", Offset = "0xB2F550", VA = "0x180B30750")]
		private void HandlerTopMenuClick(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xB30610", Offset = "0xB2F410", VA = "0x180B30610")]
		private void HandlerSideMenuClick(string sceneName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xB30800", Offset = "0xB2F600", VA = "0x180B30800")]
		private void LoadScene(string sceneName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xB30DA0", Offset = "0xB2FBA0", VA = "0x180B30DA0")]
		private void UnloadScene()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xB30900", Offset = "0xB2F700", VA = "0x180B30900")]
		private void SceneLoaded(Scene scene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xB303E0", Offset = "0xB2F1E0", VA = "0x180B303E0")]
		private void Application_LogMessageReceived(string condition, string stackTrace, LogType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xB30E10", Offset = "0xB2FC10", VA = "0x180B30E10")]
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
		[Cpp2IlInjected.Address(RVA = "0xB30E70", Offset = "0xB2FC70", VA = "0x180B30E70")]
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
		[Cpp2IlInjected.Address(RVA = "0x3AD870", Offset = "0x3AC670", VA = "0x1803AD870")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AF1F0", Offset = "0x3ADFF0", VA = "0x1803AF1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xB311E0", Offset = "0xB2FFE0", VA = "0x180B311E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB31330", Offset = "0xB30130", VA = "0x180B31330")]
		public void SetParam(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xB31220", Offset = "0xB30020", VA = "0x180B31220", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xB31250", Offset = "0xB30050", VA = "0x180B31250", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xB31440", Offset = "0xB30240", VA = "0x180B31440")]
		public void SetWhite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xB312B0", Offset = "0xB300B0", VA = "0x180B312B0")]
		public void SetBlue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3CF600", Offset = "0x3CE400", VA = "0x1803CF600")]
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
		[Cpp2IlInjected.Address(RVA = "0xB315D0", Offset = "0xB303D0", VA = "0x180B315D0")]
		public Toggle SetToggle(bool isActive, string text, Sprite sprite)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xB31490", Offset = "0xB30290", VA = "0x180B31490", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xB314C0", Offset = "0xB302C0", VA = "0x180B314C0", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xB31730", Offset = "0xB30530", VA = "0x180B31730")]
		public void SetWhite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xB314F0", Offset = "0xB302F0", VA = "0x180B314F0")]
		public void SetBlue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3CF600", Offset = "0x3CE400", VA = "0x1803CF600")]
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
		[Cpp2IlInjected.Address(RVA = "0x3CF600", Offset = "0x3CE400", VA = "0x1803CF600")]
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
		[Cpp2IlInjected.Address(RVA = "0xB2AE10", Offset = "0xB29C10", VA = "0x180B2AE10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xB2B020", Offset = "0xB29E20", VA = "0x180B2B020")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xB2B280", Offset = "0xB2A080", VA = "0x180B2B280")]
		private void OnRecordStopped(ISN_RPStopResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xB254A0", Offset = "0xB242A0", VA = "0x180B254A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB291D0", Offset = "0xB27FD0", VA = "0x180B291D0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xB254A0", Offset = "0xB242A0", VA = "0x180B254A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB2AC60", Offset = "0xB29A60", VA = "0x180B2AC60")]
		public void init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xB2ABB0", Offset = "0xB299B0", VA = "0x180B2ABB0")]
		private static void UnlockProducts(ISN_iSKPaymentTransaction transaction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xB2A560", Offset = "0xB29360", VA = "0x180B2A560", Slot = "4")]
		public void OnTransactionUpdated(ISN_iSKPaymentTransaction transaction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3B8FE0", Offset = "0x3B7DE0", VA = "0x1803B8FE0", Slot = "5")]
		public void OnTransactionRemoved(ISN_iSKPaymentTransaction result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3B0420", Offset = "0x3AF220", VA = "0x1803B0420", Slot = "6")]
		public bool OnShouldAddStorePayment(ISN_SKProduct result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xB2A2F0", Offset = "0xB290F0", VA = "0x180B2A2F0", Slot = "7")]
		public void OnRestoreTransactionsComplete(SA_Result result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3AD870", Offset = "0x3AC670", VA = "0x1803AD870")]
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
		[Cpp2IlInjected.Address(RVA = "0xB2CE00", Offset = "0xB2BC00", VA = "0x180B2CE00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xB2CF80", Offset = "0xB2BD80", VA = "0x180B2CF80")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xB254A0", Offset = "0xB242A0", VA = "0x180B254A0")]
		public ISN_UIKitExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class ISN_UserNotificationExample : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xB2E620", Offset = "0xB2D420", VA = "0x180B2E620")]
		public void RequestUserNotificationPermission()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xB2DEE0", Offset = "0xB2CCE0", VA = "0x180B2DEE0")]
		public void GetSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xB2E2B0", Offset = "0xB2D0B0", VA = "0x180B2E2B0")]
		public void NotificationInterval()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xB2E100", Offset = "0xB2CF00", VA = "0x180B2E100")]
		public void NotificationCalendar()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xB2E430", Offset = "0xB2D230", VA = "0x180B2E430")]
		public void NotificationLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xB2DFB0", Offset = "0xB2CDB0", VA = "0x180B2DFB0")]
		public void NoSoundToTrigger()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3CF600", Offset = "0x3CE400", VA = "0x1803CF600")]
		public ISN_UserNotificationExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class ISN_UserNotificationsExamples : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xB2E800", Offset = "0xB2D600", VA = "0x180B2E800")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xB2FF90", Offset = "0xB2ED90", VA = "0x180B2FF90")]
		private void PrintNotification(ISN_UNNotification notification)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xB2F300", Offset = "0xB2E100", VA = "0x180B2F300")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xB2F4D0", Offset = "0xB2E2D0", VA = "0x180B2F4D0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xB2EF70", Offset = "0xB2DD70", VA = "0x180B2EF70")]
		private void DocsExample()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xB2EAC0", Offset = "0xB2D8C0", VA = "0x180B2EAC0")]
		private void ContactsUse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xB254A0", Offset = "0xB242A0", VA = "0x180B254A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB372F0", Offset = "0xB360F0", VA = "0x180B372F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xB373E0", Offset = "0xB361E0", VA = "0x180B373E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xB37D60", Offset = "0xB36B60", VA = "0x180B37D60")]
		private void StoreDidChangeExternally(ISN_NSStoreDidChangeExternallyNotification result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xB37470", Offset = "0xB36270", VA = "0x180B37470")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xB37FA0", Offset = "0xB36DA0", VA = "0x180B37FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB302F0", Offset = "0xB2F0F0", VA = "0x180B302F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AF1F0", Offset = "0x3ADFF0", VA = "0x1803AF1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool HideInInspector
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4E7580", Offset = "0x4E6380", VA = "0x1804E7580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xB30ED0", Offset = "0xB2FCD0", VA = "0x180B30ED0")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xB30F30", Offset = "0xB2FD30", VA = "0x180B30F30")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D1720", Offset = "0x3D0520", VA = "0x1803D1720")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xB30FD0", Offset = "0xB2FDD0", VA = "0x180B30FD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D1720", Offset = "0x3D0520", VA = "0x1803D1720")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xB30FD0", Offset = "0xB2FDD0", VA = "0x180B30FD0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AF1F0", Offset = "0x3ADFF0", VA = "0x1803AF1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string InternalIconPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x3AEF90", Offset = "0x3ADD90", VA = "0x1803AEF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xB31040", Offset = "0xB2FE40", VA = "0x180B31040")]
		public SA_PD_LabelWithIconAttribute(string iconPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xB310B0", Offset = "0xB2FEB0", VA = "0x180B310B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x40CDF0", Offset = "0x40BBF0", VA = "0x18040CDF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x466410", Offset = "0x465210", VA = "0x180466410")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x3D0DE0", Offset = "0x3CFBE0", VA = "0x1803D0DE0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xB31150", Offset = "0xB2FF50", VA = "0x180B31150")]
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
			[Cpp2IlInjected.Address(RVA = "0x40CDF0", Offset = "0x40BBF0", VA = "0x18040CDF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x466410", Offset = "0x465210", VA = "0x180466410")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x3D0DE0", Offset = "0x3CFBE0", VA = "0x1803D0DE0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xB31150", Offset = "0xB2FF50", VA = "0x180B31150")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AF1F0", Offset = "0x3ADFF0", VA = "0x1803AF1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xB30FA0", Offset = "0xB2FDA0", VA = "0x180B30FA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3AF1F0", Offset = "0x3ADFF0", VA = "0x1803AF1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x4AB750", Offset = "0x4AA550", VA = "0x1804AB750")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xB31000", Offset = "0xB2FE00", VA = "0x180B31000")]
		public SA_PD_HelpboxDecoratorAttribute(SA_PD_MessageType type, string message = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_PRInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x492620", Offset = "0x491420", VA = "0x180492620")]
		public SA_PD_PRInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_StandartInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x492620", Offset = "0x491420", VA = "0x180492620")]
		public SA_PD_StandartInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_ThingInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x492620", Offset = "0x491420", VA = "0x180492620")]
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
		[Cpp2IlInjected.Address(RVA = "0x465280", Offset = "0x464080", VA = "0x180465280")]
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
		[Cpp2IlInjected.Address(RVA = "0x465280", Offset = "0x464080", VA = "0x180465280")]
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
		[Cpp2IlInjected.Address(RVA = "0x465280", Offset = "0x464080", VA = "0x180465280")]
		private RenameAttribute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D80", Offset = "0x5E4B80", VA = "0x1805E5D80")]
		public RenameAttribute(string target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x402640", Offset = "0x401440", VA = "0x180402640")]
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
		[Cpp2IlInjected.Address(RVA = "0x465280", Offset = "0x464080", VA = "0x180465280")]
		public ReplaceLiteralsWithNameAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x465280", Offset = "0x464080", VA = "0x180465280")]
		public SkipAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipRenameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x465280", Offset = "0x464080", VA = "0x180465280")]
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
		[Cpp2IlInjected.Address(RVA = "0x465280", Offset = "0x464080", VA = "0x180465280")]
		private SuppressLogAttribute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x860690", Offset = "0x85F490", VA = "0x180860690")]
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
