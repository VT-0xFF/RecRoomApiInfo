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
	[Cpp2IlInjected.Address(RVA = "0x350E1B0", Offset = "0x350D1B0", VA = "0x18350E1B0")]
	public static string GetInternalStringPathOfEnumValue(IconType type)
	{
		return null;
	}
}
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
	[Cpp2IlInjected.Address(RVA = "0x1DA0D80", Offset = "0x1D9FD80", VA = "0x181DA0D80")]
	public void GetAdvertisingIdentifier()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1DA0E00", Offset = "0x1D9FE00", VA = "0x181DA0E00")]
	public void GetAdvertisingTrackingEnabled()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3D9E00", Offset = "0x3D8E00", VA = "0x1803D9E00")]
	public ASIdentifierManagerExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ISN_AppdelegateUseExample : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1DA3ED0", Offset = "0x1DA2ED0", VA = "0x181DA3ED0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3D9E00", Offset = "0x3D8E00", VA = "0x1803D9E00")]
	public ISN_AppdelegateUseExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ISN_CoreLocationDelegateExample : ISN_iCLLocationManagerDelegate
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1DA4E00", Offset = "0x1DA3E00", VA = "0x181DA4E00", Slot = "4")]
	public void DidChangeAuthorizationStatus(ISN_CLAuthorizationStatus authorizationStatus)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1DA4FE0", Offset = "0x1DA3FE0", VA = "0x181DA4FE0", Slot = "5")]
	public void DidUpdateLocations(ISN_CLLocationArray locations)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1DA4E80", Offset = "0x1DA3E80", VA = "0x181DA4E80", Slot = "6")]
	public void DidFailWithError(SA_Error error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1DA4EE0", Offset = "0x1DA3EE0", VA = "0x181DA4EE0", Slot = "7")]
	public void DidFinishDeferredUpdatesWithError(SA_Error error)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1DA4F40", Offset = "0x1DA3F40", VA = "0x181DA4F40", Slot = "8")]
	public void DidPauseLocationUpdates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1DA4F90", Offset = "0x1DA3F90", VA = "0x181DA4F90", Slot = "9")]
	public void DidResumeLocationUpdates()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1DA53B0", Offset = "0x1DA43B0", VA = "0x181DA53B0")]
	private void ShowMessage(string title, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3D80E0", Offset = "0x3D70E0", VA = "0x1803D80E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1DA5670", Offset = "0x1DA4670", VA = "0x181DA5670")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5510", Offset = "0x1DA4510", VA = "0x181DA5510")]
	private void ShowMessage(string title, string message)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3D9E00", Offset = "0x3D8E00", VA = "0x1803D9E00")]
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
	[Cpp2IlInjected.Address(RVA = "0x1DA62D0", Offset = "0x1DA52D0", VA = "0x181DA62D0")]
	public void RequestAccessToEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1DA6360", Offset = "0x1DA5360", VA = "0x181DA6360")]
	public void RequestAccessToReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5E90", Offset = "0x1DA4E90", VA = "0x181DA5E90")]
	public void AddEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x1DA6130", Offset = "0x1DA5130", VA = "0x181DA6130")]
	public void RemoveEvent()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x1DA5FD0", Offset = "0x1DA4FD0", VA = "0x181DA5FD0")]
	public void AddReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1DA6200", Offset = "0x1DA5200", VA = "0x181DA6200")]
	public void RemoveReminder()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3D9E00", Offset = "0x3D8E00", VA = "0x1803D9E00")]
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
	[Cpp2IlInjected.Address(RVA = "0x1DA7C60", Offset = "0x1DA6C60", VA = "0x181DA7C60")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3D9E00", Offset = "0x3D8E00", VA = "0x1803D9E00")]
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
	[Cpp2IlInjected.Address(RVA = "0x1DA8A90", Offset = "0x1DA7A90", VA = "0x181DA8A90")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1DA8E10", Offset = "0x1DA7E10", VA = "0x181DA8E10")]
	private void UpdatePlayerStateUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3D9E00", Offset = "0x3D8E00", VA = "0x1803D9E00")]
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
	[Cpp2IlInjected.Address(RVA = "0x1DA4980", Offset = "0x1DA3980", VA = "0x181DA4980")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x3D9E00", Offset = "0x3D8E00", VA = "0x1803D9E00")]
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
	[Cpp2IlInjected.Address(RVA = "0x1DAA0D0", Offset = "0x1DA90D0", VA = "0x181DAA0D0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3D9E00", Offset = "0x3D8E00", VA = "0x1803D9E00")]
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
	[Cpp2IlInjected.Address(RVA = "0x1DAB0B0", Offset = "0x1DAA0B0", VA = "0x181DAB0B0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x1DAAF30", Offset = "0x1DA9F30", VA = "0x181DAAF30")]
	private void AddFitter(GameObject go)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1DABA80", Offset = "0x1DAAA80", VA = "0x181DABA80")]
	private void UpdateUI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x1DAB6D0", Offset = "0x1DAA6D0", VA = "0x181DAB6D0")]
	private void StartPicker(ISN_UIImagePickerControllerSourceType sourceType, string mediaType)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x1DAB530", Offset = "0x1DAA530", VA = "0x181DAB530")]
	private void DisplayResult(ISN_UIPickerControllerResult result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x1DAAFA0", Offset = "0x1DA9FA0", VA = "0x181DAAFA0")]
	private void ApplyImageToGui(Texture2D image)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1DAB410", Offset = "0x1DAA410", VA = "0x181DAB410")]
	private void DisplayMessage(string message, [Optional] Action onClose)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3D9E00", Offset = "0x3D8E00", VA = "0x1803D9E00")]
	public ISN_UIImagePickerControllerExample()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DocumentationExample : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1DA11A0", Offset = "0x1DA01A0", VA = "0x181DA11A0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3D9E00", Offset = "0x3D8E00", VA = "0x1803D9E00")]
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
		[Cpp2IlInjected.Address(RVA = "0x350D150", Offset = "0x350C150", VA = "0x18350D150", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_RemoteNotifications_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class ISN_UNAuthorization_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x350DB30", Offset = "0x350CB30", VA = "0x18350DB30", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
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
		[Cpp2IlInjected.Address(RVA = "0x350DC10", Offset = "0x350CC10", VA = "0x18350DC10", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x350DF80", Offset = "0x350CF80", VA = "0x18350DF80")]
		private void ValidateRequest(ISN_UNNotificationRequest presentdeRequest)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
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
		[Cpp2IlInjected.Address(RVA = "0x350D6B0", Offset = "0x350C6B0", VA = "0x18350D6B0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x350D580", Offset = "0x350C580", VA = "0x18350D580")]
		private void TestVideo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_UIImagePickerController_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class SaveToCameraRollTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x350E6C0", Offset = "0x350D6C0", VA = "0x18350E6C0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DA5C00", Offset = "0x1DA4C00", VA = "0x181DA5C00", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_DefaultSharingDialog_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class ISN_FacebookShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x350CE00", Offset = "0x350BE00", VA = "0x18350CE00", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_FacebookShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class ISN_InstagramShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x350CF10", Offset = "0x350BF10", VA = "0x18350CF10", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_InstagramShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class ISN_MailShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x350D020", Offset = "0x350C020", VA = "0x18350D020", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_MailShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class ISN_TextMessage_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x350D350", Offset = "0x350C350", VA = "0x18350D350", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_TextMessage_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ISN_TwitterShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x350D470", Offset = "0x350C470", VA = "0x18350D470", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_TwitterShare_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ISN_WhatsAppShare_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x350E110", Offset = "0x350D110", VA = "0x18350E110", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DA6A50", Offset = "0x1DA5A50", VA = "0x181DA6A50", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_GKAchievementsLoad_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ISN_GKAchievmentReport_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1DA6E30", Offset = "0x1DA5E30", VA = "0x181DA6E30", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x1DA6D60", Offset = "0x1DA5D60", VA = "0x181DA6D60")]
		private void ReportCompletedAchievment(string achievementId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x1DA6CF0", Offset = "0x1DA5CF0", VA = "0x181DA6CF0")]
		private void CheckIfCompleted(string achievementId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_GKAchievmentReport_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class ISN_GKAchievmentReset_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1DA70A0", Offset = "0x1DA60A0", VA = "0x181DA70A0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1DA7030", Offset = "0x1DA6030", VA = "0x181DA7030")]
		private void CheckIfResetCompleted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_GKAchievmentReset_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ISN_GKGameCenterUI_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1DA7250", Offset = "0x1DA6250", VA = "0x181DA7250", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_GKGameCenterUI_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ISN_GKGenerateIdentityVerificationSignature_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1DA7280", Offset = "0x1DA6280", VA = "0x181DA7280", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_GKGenerateIdentityVerificationSignature_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class ISN_GKLoadLeaderboards_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1DA7480", Offset = "0x1DA6480", VA = "0x181DA7480", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_GKLoadLeaderboards_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class ISN_GKLocalPlayer_Authenticate_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x1DA76A0", Offset = "0x1DA66A0", VA = "0x181DA76A0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_GKLocalPlayer_Authenticate_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class ISN_GKReportingScores_Test : ISN_GKSingleLeaderboard_Test
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1DA7890", Offset = "0x1DA6890", VA = "0x181DA7890", Slot = "7")]
		public override void OnLeaderboardReady(ISN_GKLeaderboard leaderboard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_GKReportingScores_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class ISN_GKRetrievingScores_Test : ISN_GKSingleLeaderboard_Test
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1DA7A00", Offset = "0x1DA6A00", VA = "0x181DA7A00", Slot = "7")]
		public override void OnLeaderboardReady(ISN_GKLeaderboard leaderboard)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_GKRetrievingScores_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class ISN_GKSingleLeaderboard_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1DA7B40", Offset = "0x1DA6B40", VA = "0x181DA7B40", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract void OnLeaderboardReady(ISN_GKLeaderboard leaderboard);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DA40A0", Offset = "0x1DA30A0", VA = "0x181DA40A0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_AudioSessionTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class ISN_BuildInfoTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x1DA42C0", Offset = "0x1DA32C0", VA = "0x181DA42C0", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_BuildInfoTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ISN_NSFileManagerTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1DA8F80", Offset = "0x1DA7F80", VA = "0x181DA8F80", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_NSFileManagerTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class ISN_TimeZoneTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA350", Offset = "0x1DA9350", VA = "0x181DAA350", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_TimeZoneTest()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class ISN_iCloudKeyValueStorageTest : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x1DAEF50", Offset = "0x1DADF50", VA = "0x181DAEF50", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DA4360", Offset = "0x1DA3360", VA = "0x181DA4360", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
		public ISN_CNContactsPicker_Test()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class ISN_CNFetchPhoneContacts_Test : SA_BaseTest
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4870", Offset = "0x1DA3870", VA = "0x181DA4870", Slot = "4")]
		public override void Test()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4420", Offset = "0x1DA3420", VA = "0x181DA4420")]
		public static void PrintContacts(List<ISN_CNContact> contacts)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4100", Offset = "0x1DA3100", VA = "0x181DA4100")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DA0EA0", Offset = "0x1D9FEA0", VA = "0x181DA0EA0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E00", Offset = "0x3D8E00", VA = "0x1803D9E00")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DA4110", Offset = "0x1DA3110", VA = "0x181DA4110", Slot = "4")]
		protected virtual void InitStyles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xC55920", Offset = "0xC54920", VA = "0x180C55920", Slot = "5")]
		public virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4260", Offset = "0x1DA3260", VA = "0x181DA4260")]
		public void UpdateToStartPos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4200", Offset = "0x1DA3200", VA = "0x181DA4200")]
		public void LoadLevel(string levelName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4270", Offset = "0x1DA3270", VA = "0x181DA4270")]
		public ISN_BaseIOSFeaturePreview()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class ISN_FoundationExamples
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1DA6950", Offset = "0x1DA5950", VA = "0x181DA6950")]
		public void LocaleInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3D80E0", Offset = "0x3D70E0", VA = "0x1803D80E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DA1BC0", Offset = "0x1DA0BC0", VA = "0x181DA1BC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x1DA2430", Offset = "0x1DA1430", VA = "0x181DA2430")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1DA1CA0", Offset = "0x1DA0CA0", VA = "0x181DA1CA0")]
		private void DidModifySavedGame(ISN_GKSavedGameSaveResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x1DA1F80", Offset = "0x1DA0F80", VA = "0x181DA1F80")]
		private void HasConflictingSavedGames(ISN_GKSavedGameFetchResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1DA2510", Offset = "0x1DA1510", VA = "0x181DA2510")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x1DA3E50", Offset = "0x1DA2E50", VA = "0x181DA3E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DAA5E0", Offset = "0x1DA95E0", VA = "0x181DAA5E0", Slot = "7")]
		public override GameObject AddSideMenuElement(List<SA_ExampleSubsectionConfig> subsections, bool isActive)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x1DAABD0", Offset = "0x1DA9BD0", VA = "0x181DAABD0")]
		private void SetToggle(string sceneName, string text, SA_SideToggleStyle style, Toggle toggle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA850", Offset = "0x1DA9850", VA = "0x181DAA850", Slot = "5")]
		public override Toggle AddTopMenuElement(string name, Sprite icon, bool isActive, int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1DAABB0", Offset = "0x1DA9BB0", VA = "0x181DAABB0", Slot = "4")]
		public override void SetLogo(Sprite sprite)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1DAAE50", Offset = "0x1DA9E50", VA = "0x181DAAE50", Slot = "8")]
		public override void UnloadContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x1DAAAF0", Offset = "0x1DA9AF0", VA = "0x181DAAAF0", Slot = "9")]
		public override void LoadContent(GameObject canvas)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1DAADA0", Offset = "0x1DA9DA0", VA = "0x181DAADA0", Slot = "6")]
		public override void ShowTopMenuItem(GameObject menuItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x1DAA530", Offset = "0x1DA9530", VA = "0x181DAA530", Slot = "10")]
		public override void AddLog(string log)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E00", Offset = "0x3D8E00", VA = "0x1803D9E00")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DAF090", Offset = "0x1DAE090", VA = "0x181DAF090")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DAF7A0", Offset = "0x1DAE7A0", VA = "0x181DAF7A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1DAF940", Offset = "0x1DAE940", VA = "0x181DAF940")]
		private void Subscribe()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1DAF760", Offset = "0x1DAE760", VA = "0x181DAF760")]
		private void SetLogo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x1DAF120", Offset = "0x1DAE120", VA = "0x181DAF120")]
		private void GenerateMenuUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1DAF460", Offset = "0x1DAE460", VA = "0x181DAF460")]
		private void HandlerTopMenuClick(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1DAF320", Offset = "0x1DAE320", VA = "0x181DAF320")]
		private void HandlerSideMenuClick(string sceneName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x1DAF510", Offset = "0x1DAE510", VA = "0x181DAF510")]
		private void LoadScene(string sceneName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFAB0", Offset = "0x1DAEAB0", VA = "0x181DAFAB0")]
		private void UnloadScene()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1DAF610", Offset = "0x1DAE610", VA = "0x181DAF610")]
		private void SceneLoaded(Scene scene)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1DAF0F0", Offset = "0x1DAE0F0", VA = "0x181DAF0F0")]
		private void Application_LogMessageReceived(string condition, string stackTrace, LogType type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFB20", Offset = "0x1DAEB20", VA = "0x181DAFB20")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DAFB80", Offset = "0x1DAEB80", VA = "0x181DAFB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D80E0", Offset = "0x3D70E0", VA = "0x1803D80E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D88E0", Offset = "0x3D78E0", VA = "0x1803D88E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFEC0", Offset = "0x1DAEEC0", VA = "0x181DAFEC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DB0010", Offset = "0x1DAF010", VA = "0x181DB0010")]
		public void SetParam(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFF00", Offset = "0x1DAEF00", VA = "0x181DAFF00", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFF30", Offset = "0x1DAEF30", VA = "0x181DAFF30", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1DB0120", Offset = "0x1DAF120", VA = "0x181DB0120")]
		public void SetWhite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFF90", Offset = "0x1DAEF90", VA = "0x181DAFF90")]
		public void SetBlue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E00", Offset = "0x3D8E00", VA = "0x1803D9E00")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DB02B0", Offset = "0x1DAF2B0", VA = "0x181DB02B0")]
		public Toggle SetToggle(bool isActive, string text, Sprite sprite)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x1DB0170", Offset = "0x1DAF170", VA = "0x181DB0170", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x1DB01A0", Offset = "0x1DAF1A0", VA = "0x181DB01A0", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x1DB0410", Offset = "0x1DAF410", VA = "0x181DB0410")]
		public void SetWhite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x1DB01D0", Offset = "0x1DAF1D0", VA = "0x181DB01D0")]
		public void SetBlue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E00", Offset = "0x3D8E00", VA = "0x1803D9E00")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D9E00", Offset = "0x3D8E00", VA = "0x1803D9E00")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DA9B20", Offset = "0x1DA8B20", VA = "0x181DA9B20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9D30", Offset = "0x1DA8D30", VA = "0x181DA9D30")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9F90", Offset = "0x1DA8F90", VA = "0x181DA9F90")]
		private void OnRecordStopped(ISN_RPStopResult result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4270", Offset = "0x1DA3270", VA = "0x181DA4270")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DA7EE0", Offset = "0x1DA6EE0", VA = "0x181DA7EE0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4270", Offset = "0x1DA3270", VA = "0x181DA4270")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DA9970", Offset = "0x1DA8970", VA = "0x181DA9970")]
		public void init()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x1DA98C0", Offset = "0x1DA88C0", VA = "0x181DA98C0")]
		private static void UnlockProducts(ISN_iSKPaymentTransaction transaction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9270", Offset = "0x1DA8270", VA = "0x181DA9270", Slot = "4")]
		public void OnTransactionUpdated(ISN_iSKPaymentTransaction transaction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x3D8940", Offset = "0x3D7940", VA = "0x1803D8940", Slot = "5")]
		public void OnTransactionRemoved(ISN_iSKPaymentTransaction result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x3DC3F0", Offset = "0x3DB3F0", VA = "0x1803DC3F0", Slot = "6")]
		public bool OnShouldAddStorePayment(ISN_SKProduct result)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1DA9000", Offset = "0x1DA8000", VA = "0x181DA9000", Slot = "7")]
		public void OnRestoreTransactionsComplete(SA_Result result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D80E0", Offset = "0x3D70E0", VA = "0x1803D80E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DABB10", Offset = "0x1DAAB10", VA = "0x181DABB10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x1DABC90", Offset = "0x1DAAC90", VA = "0x181DABC90")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4270", Offset = "0x1DA3270", VA = "0x181DA4270")]
		public ISN_UIKitExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class ISN_UserNotificationExample : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD330", Offset = "0x1DAC330", VA = "0x181DAD330")]
		public void RequestUserNotificationPermission()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x1DACBF0", Offset = "0x1DABBF0", VA = "0x181DACBF0")]
		public void GetSettings()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1DACFC0", Offset = "0x1DABFC0", VA = "0x181DACFC0")]
		public void NotificationInterval()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x1DACE10", Offset = "0x1DABE10", VA = "0x181DACE10")]
		public void NotificationCalendar()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD140", Offset = "0x1DAC140", VA = "0x181DAD140")]
		public void NotificationLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x1DACCC0", Offset = "0x1DABCC0", VA = "0x181DACCC0")]
		public void NoSoundToTrigger()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E00", Offset = "0x3D8E00", VA = "0x1803D9E00")]
		public ISN_UserNotificationExample()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class ISN_UserNotificationsExamples : ISN_BaseIOSFeaturePreview
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD510", Offset = "0x1DAC510", VA = "0x181DAD510")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x1DAECA0", Offset = "0x1DADCA0", VA = "0x181DAECA0")]
		private void PrintNotification(ISN_UNNotification notification)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x1DAE010", Offset = "0x1DAD010", VA = "0x181DAE010")]
		private void OnApplicationPause(bool pause)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x1DAE1E0", Offset = "0x1DAD1E0", VA = "0x181DAE1E0")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1DADC80", Offset = "0x1DACC80", VA = "0x181DADC80")]
		private void DocsExample()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD7D0", Offset = "0x1DAC7D0", VA = "0x181DAD7D0")]
		private void ContactsUse()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x1DA4270", Offset = "0x1DA3270", VA = "0x181DA4270")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DB5F10", Offset = "0x1DB4F10", VA = "0x181DB5F10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x1DB6000", Offset = "0x1DB5000", VA = "0x181DB6000")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1DB6980", Offset = "0x1DB5980", VA = "0x181DB6980")]
		private void StoreDidChangeExternally(ISN_NSStoreDidChangeExternallyNotification result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x1DB6090", Offset = "0x1DB5090", VA = "0x181DB6090")]
		private void OnGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x1DB6B90", Offset = "0x1DB5B90", VA = "0x181DB6B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x1DAF000", Offset = "0x1DAE000", VA = "0x181DAF000")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D88E0", Offset = "0x3D78E0", VA = "0x1803D88E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool HideInInspector
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x4B6060", Offset = "0x4B5060", VA = "0x1804B6060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFBE0", Offset = "0x1DAEBE0", VA = "0x181DAFBE0")]
		public SA_PD_ConditionalAttribute(string conditionalSourceField)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFC40", Offset = "0x1DAEC40", VA = "0x181DAFC40")]
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
			[Cpp2IlInjected.Address(RVA = "0x4B12E0", Offset = "0x4B02E0", VA = "0x1804B12E0")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFCB0", Offset = "0x1DAECB0", VA = "0x181DAFCB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4B12E0", Offset = "0x4B02E0", VA = "0x1804B12E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFCB0", Offset = "0x1DAECB0", VA = "0x181DAFCB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D88E0", Offset = "0x3D78E0", VA = "0x1803D88E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public string InternalIconPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x40E370", Offset = "0x40D370", VA = "0x18040E370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFD20", Offset = "0x1DAED20", VA = "0x181DAFD20")]
		public SA_PD_LabelWithIconAttribute(string iconPath)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFD90", Offset = "0x1DAED90", VA = "0x181DAFD90")]
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
			[Cpp2IlInjected.Address(RVA = "0x4D7D30", Offset = "0x4D6D30", VA = "0x1804D7D30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x599C10", Offset = "0x598C10", VA = "0x180599C10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x4DD320", Offset = "0x4DC320", VA = "0x1804DD320")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFE30", Offset = "0x1DAEE30", VA = "0x181DAFE30")]
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
			[Cpp2IlInjected.Address(RVA = "0x4D7D30", Offset = "0x4D6D30", VA = "0x1804D7D30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public float MaxLimit
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x599C10", Offset = "0x598C10", VA = "0x180599C10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x4DD320", Offset = "0x4DC320", VA = "0x1804DD320")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFE30", Offset = "0x1DAEE30", VA = "0x181DAFE30")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D88E0", Offset = "0x3D78E0", VA = "0x1803D88E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x4A87B0", Offset = "0x4A77B0", VA = "0x1804A87B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D88E0", Offset = "0x3D78E0", VA = "0x1803D88E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public SA_PD_MessageType Type
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x4E0600", Offset = "0x4DF600", VA = "0x1804E0600")]
			get
			{
				return default(SA_PD_MessageType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1DAFCE0", Offset = "0x1DAECE0", VA = "0x181DAFCE0")]
		public SA_PD_HelpboxDecoratorAttribute(SA_PD_MessageType type, string message = "")
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_PRInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5A1310", Offset = "0x5A0310", VA = "0x1805A1310")]
		public SA_PD_PRInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_StandartInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5A1310", Offset = "0x5A0310", VA = "0x1805A1310")]
		public SA_PD_StandartInsertionDecoratorAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[AttributeUsage(AttributeTargets.All)]
	public class SA_PD_ThingInsertionDecoratorAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5A1310", Offset = "0x5A0310", VA = "0x1805A1310")]
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
		[Cpp2IlInjected.Address(RVA = "0x4B18B0", Offset = "0x4B08B0", VA = "0x1804B18B0")]
		public DoNotFakeAttribute()
		{
		}
	}
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
		[Cpp2IlInjected.Address(RVA = "0x4B18B0", Offset = "0x4B08B0", VA = "0x1804B18B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4B18B0", Offset = "0x4B08B0", VA = "0x1804B18B0")]
		private RenameAttribute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5BE5F0", Offset = "0x5BD5F0", VA = "0x1805BE5F0")]
		public RenameAttribute(string target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x426940", Offset = "0x425940", VA = "0x180426940")]
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
		[Cpp2IlInjected.Address(RVA = "0x4B18B0", Offset = "0x4B08B0", VA = "0x1804B18B0")]
		public ReplaceLiteralsWithNameAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x4B18B0", Offset = "0x4B08B0", VA = "0x1804B18B0")]
		public SkipAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Parameter | AttributeTargets.Delegate)]
	public class SkipRenameAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x4B18B0", Offset = "0x4B08B0", VA = "0x1804B18B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4B18B0", Offset = "0x4B08B0", VA = "0x1804B18B0")]
		private SuppressLogAttribute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xFF0E10", Offset = "0xFEFE10", VA = "0x180FF0E10")]
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
