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
	[Cpp2IlInjected.Address(RVA = "0x3388030", Offset = "0x3386630", VA = "0x183388030")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FE40E0", Offset = "0x1FE26E0", VA = "0x181FE40E0")]
	public void GetAdvertisingIdentifier()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4160", Offset = "0x1FE2760", VA = "0x181FE4160")]
	public void GetAdvertisingTrackingEnabled()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7DA190", Offset = "0x7D8790", VA = "0x1807DA190")]
	public ASIdentifierManagerExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ISN_AppdelegateUseExample : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FE7290", Offset = "0x1FE5890", VA = "0x181FE7290")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7DA190", Offset = "0x7D8790", VA = "0x1807DA190")]
	public ISN_AppdelegateUseExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ISN_CoreLocationDelegateExample : ISN_iCLLocationManagerDelegate
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1FE81A0", Offset = "0x1FE67A0", VA = "0x181FE81A0", Slot = "4")]
	public void DidChangeAuthorizationStatus(ISN_CLAuthorizationStatus authorizationStatus)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8380", Offset = "0x1FE6980", VA = "0x181FE8380", Slot = "5")]
	public void DidUpdateLocations(ISN_CLLocationArray locations)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8220", Offset = "0x1FE6820", VA = "0x181FE8220", Slot = "6")]
	public void DidFailWithError(SA_Error error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8280", Offset = "0x1FE6880", VA = "0x181FE8280", Slot = "7")]
	public void DidFinishDeferredUpdatesWithError(SA_Error error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1FE82E0", Offset = "0x1FE68E0", VA = "0x181FE82E0", Slot = "8")]
	public void DidPauseLocationUpdates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8330", Offset = "0x1FE6930", VA = "0x181FE8330", Slot = "9")]
	public void DidResumeLocationUpdates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1FE8780", Offset = "0x1FE6D80", VA = "0x181FE8780")]
	private void ShowMessage(string title, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FE8A40", Offset = "0x1FE7040", VA = "0x181FE8A40")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1FE88E0", Offset = "0x1FE6EE0", VA = "0x181FE88E0")]
	private void ShowMessage(string title, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7DA190", Offset = "0x7D8790", VA = "0x1807DA190")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FE96A0", Offset = "0x1FE7CA0", VA = "0x181FE96A0")]
	public void RequestAccessToEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9730", Offset = "0x1FE7D30", VA = "0x181FE9730")]
	public void RequestAccessToReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9260", Offset = "0x1FE7860", VA = "0x181FE9260")]
	public void AddEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1FE9500", Offset = "0x1FE7B00", VA = "0x181FE9500")]
	public void RemoveEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1FE93A0", Offset = "0x1FE79A0", VA = "0x181FE93A0")]
	public void AddReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1FE95D0", Offset = "0x1FE7BD0", VA = "0x181FE95D0")]
	public void RemoveReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7DA190", Offset = "0x7D8790", VA = "0x1807DA190")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FEB090", Offset = "0x1FE9690", VA = "0x181FEB090")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7DA190", Offset = "0x7D8790", VA = "0x1807DA190")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FEBEC0", Offset = "0x1FEA4C0", VA = "0x181FEBEC0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1FEC240", Offset = "0x1FEA840", VA = "0x181FEC240")]
	private void UpdatePlayerStateUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7DA190", Offset = "0x7D8790", VA = "0x1807DA190")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FE7D20", Offset = "0x1FE6320", VA = "0x181FE7D20")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7DA190", Offset = "0x7D8790", VA = "0x1807DA190")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FED500", Offset = "0x1FEBB00", VA = "0x181FED500")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7DA190", Offset = "0x7D8790", VA = "0x1807DA190")]
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
	[Cpp2IlInjected.Address(RVA = "0x1FEE4E0", Offset = "0x1FECAE0", VA = "0x181FEE4E0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE360", Offset = "0x1FEC960", VA = "0x181FEE360")]
	private void AddFitter(GameObject go)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEEB0", Offset = "0x1FED4B0", VA = "0x181FEEEB0")]
	private void UpdateUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1FEEB00", Offset = "0x1FED100", VA = "0x181FEEB00")]
	private void StartPicker(ISN_UIImagePickerControllerSourceType sourceType, string mediaType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE960", Offset = "0x1FECF60", VA = "0x181FEE960")]
	private void DisplayResult(ISN_UIPickerControllerResult result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE3D0", Offset = "0x1FEC9D0", VA = "0x181FEE3D0")]
	private void ApplyImageToGui(Texture2D image)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE840", Offset = "0x1FECE40", VA = "0x181FEE840")]
	private void DisplayMessage(string message, [Optional] Action onClose)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7DA190", Offset = "0x7D8790", VA = "0x1807DA190")]
	public ISN_UIImagePickerControllerExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DocumentationExample : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1FE4500", Offset = "0x1FE2B00", VA = "0x181FE4500")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7DA190", Offset = "0x7D8790", VA = "0x1807DA190")]
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
		[Cpp2IlInjected.Address(RVA = "0x3386FD0", Offset = "0x33855D0", VA = "0x183386FD0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_RemoteNotifications_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class ISN_UNAuthorization_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x33879B0", Offset = "0x3385FB0", VA = "0x1833879B0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3387A90", Offset = "0x3386090", VA = "0x183387A90", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3387E00", Offset = "0x3386400", VA = "0x183387E00")]
		private void ValidateRequest(ISN_UNNotificationRequest presentdeRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3387530", Offset = "0x3385B30", VA = "0x183387530", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3387400", Offset = "0x3385A00", VA = "0x183387400")]
		private void TestVideo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_UIImagePickerController_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SaveToCameraRollTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3388540", Offset = "0x3386B40", VA = "0x183388540", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FE8FD0", Offset = "0x1FE75D0", VA = "0x181FE8FD0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_DefaultSharingDialog_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class ISN_FacebookShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x3386C80", Offset = "0x3385280", VA = "0x183386C80", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_FacebookShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class ISN_InstagramShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3386D90", Offset = "0x3385390", VA = "0x183386D90", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_InstagramShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ISN_MailShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3386EA0", Offset = "0x33854A0", VA = "0x183386EA0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_MailShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ISN_TextMessage_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x33871D0", Offset = "0x33857D0", VA = "0x1833871D0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_TextMessage_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ISN_TwitterShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x33872F0", Offset = "0x33858F0", VA = "0x1833872F0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_TwitterShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ISN_WhatsAppShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3387F90", Offset = "0x3386590", VA = "0x183387F90", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FE9E20", Offset = "0x1FE8420", VA = "0x181FE9E20", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_GKAchievementsLoad_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ISN_GKAchievmentReport_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA230", Offset = "0x1FE8830", VA = "0x181FEA230", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA160", Offset = "0x1FE8760", VA = "0x181FEA160")]
		private void ReportCompletedAchievment(string achievementId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA0F0", Offset = "0x1FE86F0", VA = "0x181FEA0F0")]
		private void CheckIfCompleted(string achievementId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_GKAchievmentReport_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class ISN_GKAchievmentReset_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA4A0", Offset = "0x1FE8AA0", VA = "0x181FEA4A0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA430", Offset = "0x1FE8A30", VA = "0x181FEA430")]
		private void CheckIfResetCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_GKAchievmentReset_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ISN_GKGameCenterUI_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA650", Offset = "0x1FE8C50", VA = "0x181FEA650", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_GKGameCenterUI_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ISN_GKGenerateIdentityVerificationSignature_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA680", Offset = "0x1FE8C80", VA = "0x181FEA680", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_GKGenerateIdentityVerificationSignature_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class ISN_GKLoadLeaderboards_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1FEA880", Offset = "0x1FE8E80", VA = "0x181FEA880", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_GKLoadLeaderboards_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class ISN_GKLocalPlayer_Authenticate_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1FEAAD0", Offset = "0x1FE90D0", VA = "0x181FEAAD0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_GKLocalPlayer_Authenticate_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class ISN_GKReportingScores_Test : ISN_GKSingleLeaderboard_Test
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1FEACC0", Offset = "0x1FE92C0", VA = "0x181FEACC0", Slot = "7")]
		public override void OnLeaderboardReady(ISN_GKLeaderboard leaderboard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_GKReportingScores_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class ISN_GKRetrievingScores_Test : ISN_GKSingleLeaderboard_Test
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1FEAE30", Offset = "0x1FE9430", VA = "0x181FEAE30", Slot = "7")]
		public override void OnLeaderboardReady(ISN_GKLeaderboard leaderboard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_GKRetrievingScores_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class ISN_GKSingleLeaderboard_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1FEAF70", Offset = "0x1FE9570", VA = "0x181FEAF70", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void OnLeaderboardReady(ISN_GKLeaderboard leaderboard);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FE7460", Offset = "0x1FE5A60", VA = "0x181FE7460", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_AudioSessionTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class ISN_BuildInfoTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7630", Offset = "0x1FE5C30", VA = "0x181FE7630", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_BuildInfoTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ISN_NSFileManagerTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1FEC3B0", Offset = "0x1FEA9B0", VA = "0x181FEC3B0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_NSFileManagerTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class ISN_TimeZoneTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1FED780", Offset = "0x1FEBD80", VA = "0x181FED780", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_TimeZoneTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class ISN_iCloudKeyValueStorageTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1FF2380", Offset = "0x1FF0980", VA = "0x181FF2380", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FE76D0", Offset = "0x1FE5CD0", VA = "0x181FE76D0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
		public ISN_CNContactsPicker_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class ISN_CNFetchPhoneContacts_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7C10", Offset = "0x1FE6210", VA = "0x181FE7C10", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7790", Offset = "0x1FE5D90", VA = "0x181FE7790")]
		public static void PrintContacts(List<ISN_CNContact> contacts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1FE74C0", Offset = "0x1FE5AC0", VA = "0x181FE74C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FE4200", Offset = "0x1FE2800", VA = "0x181FE4200")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7DA190", Offset = "0x7D8790", VA = "0x1807DA190")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FE74D0", Offset = "0x1FE5AD0", VA = "0x181FE74D0", Slot = "4")]
		protected virtual void InitStyles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xF08140", Offset = "0xF06740", VA = "0x180F08140", Slot = "5")]
		public virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1FE75D0", Offset = "0x1FE5BD0", VA = "0x181FE75D0")]
		public void UpdateToStartPos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1FE75C0", Offset = "0x1FE5BC0", VA = "0x181FE75C0")]
		public void LoadLevel(string levelName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1FE75E0", Offset = "0x1FE5BE0", VA = "0x181FE75E0")]
		public ISN_BaseIOSFeaturePreview()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class ISN_FoundationExamples
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1FE9D20", Offset = "0x1FE8320", VA = "0x181FE9D20")]
		public void LocaleInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FE4F20", Offset = "0x1FE3520", VA = "0x181FE4F20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x1FE57D0", Offset = "0x1FE3DD0", VA = "0x181FE57D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1FE5000", Offset = "0x1FE3600", VA = "0x181FE5000")]
		private void DidModifySavedGame(ISN_GKSavedGameSaveResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1FE52E0", Offset = "0x1FE38E0", VA = "0x181FE52E0")]
		private void HasConflictingSavedGames(ISN_GKSavedGameFetchResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1FE58B0", Offset = "0x1FE3EB0", VA = "0x181FE58B0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x1FE7210", Offset = "0x1FE5810", VA = "0x181FE7210")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FEDA10", Offset = "0x1FEC010", VA = "0x181FEDA10", Slot = "7")]
		public override GameObject AddSideMenuElement(List<SA_ExampleSubsectionConfig> subsections, bool isActive)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE000", Offset = "0x1FEC600", VA = "0x181FEE000")]
		private void SetToggle(string sceneName, string text, SA_SideToggleStyle style, Toggle toggle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDC80", Offset = "0x1FEC280", VA = "0x181FEDC80", Slot = "5")]
		public override Toggle AddTopMenuElement(string name, Sprite icon, bool isActive, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDFE0", Offset = "0x1FEC5E0", VA = "0x181FEDFE0", Slot = "4")]
		public override void SetLogo(Sprite sprite)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE280", Offset = "0x1FEC880", VA = "0x181FEE280", Slot = "8")]
		public override void UnloadContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1FEDF20", Offset = "0x1FEC520", VA = "0x181FEDF20", Slot = "9")]
		public override void LoadContent(GameObject canvas)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE1D0", Offset = "0x1FEC7D0", VA = "0x181FEE1D0", Slot = "6")]
		public override void ShowTopMenuItem(GameObject menuItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1FED960", Offset = "0x1FEBF60", VA = "0x181FED960", Slot = "10")]
		public override void AddLog(string log)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7DA190", Offset = "0x7D8790", VA = "0x1807DA190")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FF24C0", Offset = "0x1FF0AC0", VA = "0x181FF24C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FF2BD0", Offset = "0x1FF11D0", VA = "0x181FF2BD0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1FF2D70", Offset = "0x1FF1370", VA = "0x181FF2D70")]
		private void Subscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1FF2B90", Offset = "0x1FF1190", VA = "0x181FF2B90")]
		private void SetLogo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x1FF2550", Offset = "0x1FF0B50", VA = "0x181FF2550")]
		private void GenerateMenuUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1FF2890", Offset = "0x1FF0E90", VA = "0x181FF2890")]
		private void HandlerTopMenuClick(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1FF2750", Offset = "0x1FF0D50", VA = "0x181FF2750")]
		private void HandlerSideMenuClick(string sceneName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1FF2940", Offset = "0x1FF0F40", VA = "0x181FF2940")]
		private void LoadScene(string sceneName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x1FF2EE0", Offset = "0x1FF14E0", VA = "0x181FF2EE0")]
		private void UnloadScene()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1FF2A40", Offset = "0x1FF1040", VA = "0x181FF2A40")]
		private void SceneLoaded(Scene scene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1FF2520", Offset = "0x1FF0B20", VA = "0x181FF2520")]
		private void Application_LogMessageReceived(string condition, string stackTrace, LogType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1FF2F50", Offset = "0x1FF1550", VA = "0x181FF2F50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FF2FB0", Offset = "0x1FF15B0", VA = "0x181FF2FB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DE5D0", Offset = "0x3DCBD0", VA = "0x1803DE5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1FF32F0", Offset = "0x1FF18F0", VA = "0x181FF32F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FF3440", Offset = "0x1FF1A40", VA = "0x181FF3440")]
		public void SetParam(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3330", Offset = "0x1FF1930", VA = "0x181FF3330", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3360", Offset = "0x1FF1960", VA = "0x181FF3360", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3550", Offset = "0x1FF1B50", VA = "0x181FF3550")]
		public void SetWhite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x1FF33C0", Offset = "0x1FF19C0", VA = "0x181FF33C0")]
		public void SetBlue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7DA190", Offset = "0x7D8790", VA = "0x1807DA190")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FF36E0", Offset = "0x1FF1CE0", VA = "0x181FF36E0")]
		public Toggle SetToggle(bool isActive, string text, Sprite sprite)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x1FF35A0", Offset = "0x1FF1BA0", VA = "0x181FF35A0", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1FF35D0", Offset = "0x1FF1BD0", VA = "0x181FF35D0", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3840", Offset = "0x1FF1E40", VA = "0x181FF3840")]
		public void SetWhite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3600", Offset = "0x1FF1C00", VA = "0x181FF3600")]
		public void SetBlue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7DA190", Offset = "0x7D8790", VA = "0x1807DA190")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DA190", Offset = "0x7D8790", VA = "0x1807DA190")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FECF50", Offset = "0x1FEB550", VA = "0x181FECF50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1FED160", Offset = "0x1FEB760", VA = "0x181FED160")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x1FED3C0", Offset = "0x1FEB9C0", VA = "0x181FED3C0")]
		private void OnRecordStopped(ISN_RPStopResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x1FE75E0", Offset = "0x1FE5BE0", VA = "0x181FE75E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FEB310", Offset = "0x1FE9910", VA = "0x181FEB310")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1FE75E0", Offset = "0x1FE5BE0", VA = "0x181FE75E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FECDA0", Offset = "0x1FEB3A0", VA = "0x181FECDA0")]
		public void init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1FECCF0", Offset = "0x1FEB2F0", VA = "0x181FECCF0")]
		private static void UnlockProducts(ISN_iSKPaymentTransaction transaction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1FEC6A0", Offset = "0x1FEACA0", VA = "0x181FEC6A0", Slot = "4")]
		public void OnTransactionUpdated(ISN_iSKPaymentTransaction transaction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3D6860", Offset = "0x3D4E60", VA = "0x1803D6860", Slot = "5")]
		public void OnTransactionRemoved(ISN_iSKPaymentTransaction result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x436F00", Offset = "0x435500", VA = "0x180436F00", Slot = "6")]
		public bool OnShouldAddStorePayment(ISN_SKProduct result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1FEC430", Offset = "0x1FEAA30", VA = "0x181FEC430", Slot = "7")]
		public void OnRestoreTransactionsComplete(SA_Result result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FEEF40", Offset = "0x1FED540", VA = "0x181FEEF40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1FEF0C0", Offset = "0x1FED6C0", VA = "0x181FEF0C0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1FE75E0", Offset = "0x1FE5BE0", VA = "0x181FE75E0")]
		public ISN_UIKitExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class ISN_UserNotificationExample : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1FF0760", Offset = "0x1FEED60", VA = "0x181FF0760")]
		public void RequestUserNotificationPermission()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1FF0020", Offset = "0x1FEE620", VA = "0x181FF0020")]
		public void GetSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1FF03F0", Offset = "0x1FEE9F0", VA = "0x181FF03F0")]
		public void NotificationInterval()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x1FF0240", Offset = "0x1FEE840", VA = "0x181FF0240")]
		public void NotificationCalendar()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1FF0570", Offset = "0x1FEEB70", VA = "0x181FF0570")]
		public void NotificationLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1FF00F0", Offset = "0x1FEE6F0", VA = "0x181FF00F0")]
		public void NoSoundToTrigger()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7DA190", Offset = "0x7D8790", VA = "0x1807DA190")]
		public ISN_UserNotificationExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class ISN_UserNotificationsExamples : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1FF0940", Offset = "0x1FEEF40", VA = "0x181FF0940")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x1FF20D0", Offset = "0x1FF06D0", VA = "0x181FF20D0")]
		private void PrintNotification(ISN_UNNotification notification)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1FF1440", Offset = "0x1FEFA40", VA = "0x181FF1440")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1FF1610", Offset = "0x1FEFC10", VA = "0x181FF1610")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1FF10B0", Offset = "0x1FEF6B0", VA = "0x181FF10B0")]
		private void DocsExample()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1FF0C00", Offset = "0x1FEF200", VA = "0x181FF0C00")]
		private void ContactsUse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x1FE75E0", Offset = "0x1FE5BE0", VA = "0x181FE75E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FF93D0", Offset = "0x1FF79D0", VA = "0x181FF93D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1FF94C0", Offset = "0x1FF7AC0", VA = "0x181FF94C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1FF9E40", Offset = "0x1FF8440", VA = "0x181FF9E40")]
		private void StoreDidChangeExternally(ISN_NSStoreDidChangeExternallyNotification result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x1FF9550", Offset = "0x1FF7B50", VA = "0x181FF9550")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x1FFA080", Offset = "0x1FF8680", VA = "0x181FFA080")]
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
		[Cpp2IlInjected.Address(RVA = "0x1FF2430", Offset = "0x1FF0A30", VA = "0x181FF2430")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DE5D0", Offset = "0x3DCBD0", VA = "0x1803DE5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool HideInInspector
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3FF0A0", Offset = "0x3FD6A0", VA = "0x1803FF0A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3010", Offset = "0x1FF1610", VA = "0x181FF3010")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3070", Offset = "0x1FF1670", VA = "0x181FF3070")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D39E0", Offset = "0x3D1FE0", VA = "0x1803D39E0")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1FF30E0", Offset = "0x1FF16E0", VA = "0x181FF30E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D39E0", Offset = "0x3D1FE0", VA = "0x1803D39E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1FF30E0", Offset = "0x1FF16E0", VA = "0x181FF30E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DE5D0", Offset = "0x3DCBD0", VA = "0x1803DE5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string InternalIconPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x3DE5E0", Offset = "0x3DCBE0", VA = "0x1803DE5E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3150", Offset = "0x1FF1750", VA = "0x181FF3150")]
		public SA_PD_LabelWithIconAttribute(string iconPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1FF31C0", Offset = "0x1FF17C0", VA = "0x181FF31C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x812130", Offset = "0x810730", VA = "0x180812130")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x811E80", Offset = "0x810480", VA = "0x180811E80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x6B06C0", Offset = "0x6AECC0", VA = "0x1806B06C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3260", Offset = "0x1FF1860", VA = "0x181FF3260")]
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
			[Cpp2IlInjected.Address(RVA = "0x812130", Offset = "0x810730", VA = "0x180812130")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x811E80", Offset = "0x810480", VA = "0x180811E80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x6B06C0", Offset = "0x6AECC0", VA = "0x1806B06C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3260", Offset = "0x1FF1860", VA = "0x181FF3260")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DE5D0", Offset = "0x3DCBD0", VA = "0x1803DE5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x88C9C0", Offset = "0x88AFC0", VA = "0x18088C9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DE5D0", Offset = "0x3DCBD0", VA = "0x1803DE5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x3EAF10", Offset = "0x3E9510", VA = "0x1803EAF10")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1FF3110", Offset = "0x1FF1710", VA = "0x181FF3110")]
		public SA_PD_HelpboxDecoratorAttribute(SA_PD_MessageType type, string message = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_PRInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4DC9E0", Offset = "0x4DAFE0", VA = "0x1804DC9E0")]
		public SA_PD_PRInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_StandartInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4DC9E0", Offset = "0x4DAFE0", VA = "0x1804DC9E0")]
		public SA_PD_StandartInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_ThingInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4DC9E0", Offset = "0x4DAFE0", VA = "0x1804DC9E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DC710", Offset = "0x3DAD10", VA = "0x1803DC710")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DC710", Offset = "0x3DAD10", VA = "0x1803DC710")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DC710", Offset = "0x3DAD10", VA = "0x1803DC710")]
		private RenameAttribute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4EBDA0", Offset = "0x4EA3A0", VA = "0x1804EBDA0")]
		public RenameAttribute(string target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3D0000", Offset = "0x3CE600", VA = "0x1803D0000")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DC710", Offset = "0x3DAD10", VA = "0x1803DC710")]
		public ReplaceLiteralsWithNameAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x3DC710", Offset = "0x3DAD10", VA = "0x1803DC710")]
		public SkipAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipRenameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x3DC710", Offset = "0x3DAD10", VA = "0x1803DC710")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DC710", Offset = "0x3DAD10", VA = "0x1803DC710")]
		private SuppressLogAttribute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x4EBB90", Offset = "0x4EA190", VA = "0x1804EBB90")]
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
