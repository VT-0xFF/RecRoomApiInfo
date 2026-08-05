using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CoordinateBeacons.Concretes;
using CoordinateBeacons.Configs;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RRUI;
using RecRoom.Configs;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_CoordinateBeacons_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7545AC0", Offset = "0x7544CC0", VA = "0x187545AC0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2493E30", Offset = "0x2493030", VA = "0x182493E30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[DEEBEKMCPGD("CoordinationBeacons")]
public enum CNENNAOPCDM
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[IBLBGNJDKPM("You joined a party!", true)]
	JOINED_PARTY_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[IBLBGNJDKPM("You joined a team!", true)]
	JOINED_TEAM_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[IBLBGNJDKPM("Double-tap Screen to place a Beacon.", true)]
	TOUCH_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[IBLBGNJDKPM("Middle-click Mouse to place a Beacon.", true)]
	KBM_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[IBLBGNJDKPM("Double-tap Right Shoulder to place a Beacon.", true)]
	GAMEPAD_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[IBLBGNJDKPM("Point and Tap Main Trigger to place a Beacon.", true)]
	VR_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[IBLBGNJDKPM("What's This?", true)]
	BUTTON_ACCESS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[IBLBGNJDKPM("This is a Beacon", true)]
	THIS_IS_BEACON_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[IBLBGNJDKPM("Beacons can only be placed by players in a Party or on the same Team.", true)]
	BEACON_RULES_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[IBLBGNJDKPM("Try placing a Beacon of your own!", true)]
	TRY_YOURSELF_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[IBLBGNJDKPM("Double-tap the Screen", true)]
	TOUCH_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[IBLBGNJDKPM("Middle-click the Mouse", true)]
	KBM_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[IBLBGNJDKPM("Double-tap Right Shoulder", true)]
	GAMEPAD_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[IBLBGNJDKPM("Point and Tap Main Trigger", true)]
	VR_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[IBLBGNJDKPM("once you close the dialogue window.", true)]
	ONCE_CLOSE_DIALOGUE_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[IBLBGNJDKPM("Don't show me again", true)]
	DONT_SHOW_AGAIN_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[IBLBGNJDKPM("Okay!", true)]
	BUTTON_OKAY_HINT_TUTORIAL
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface IIEGPEMJEJN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AHMDCCBNGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KJMIIEILMJL(MCAJJFEMNKN DEIOHLEKMDJ, string EPHLKMGDNIG);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FDFHENGDDEL(Camera NBEMGKCACGL, Vector3 EMFCPAECFLA);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DLBHJOLDOEK(Camera NBEMGKCACGL, Vector3 EMFCPAECFLA, CoordinationBeacon DAJEMIDGOND);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DIJFKIHPNFC();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JFFEGGDHDOI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float BIHIFEMNOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float NAPALPPKANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JCAAHHINNHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool HCDOIMOIBAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float BOCBDCLFAKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float NCABJEBJAAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float IADJNMNJOOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float NCJFFCNJMAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int GNPGJMNOFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float GMCKDNGFFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float KMAKAIINKBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float IGOGABOKIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool EPNCOIIFBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool PGBGJPHOJPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool MPHEKNIHAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool KJIMCGPPNLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool JDAHNAKNGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float HGIHKDDNIGB
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool MLNMCOFMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool IBGMNCDHJLE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void EOMMKPNKJCJ();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface EMFJFBAKCFI
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	List<JLJFGBBBBIB> HOPLLAGMIPL
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<(CoordinationBeacon, CoordinationBeaconHUDElement)> MAFHKPGBCMP(bool PEKLDAMEAEF);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MBFGFNJNCGB(Guid JFGFGLLEOEC, IFMAPNKIFID.MLEGGDONNGO AFKEKJDHKNE);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BLMKCMHDMBH(int KFNFJDPEENF, [Out] CoordinationBeacon HMPMGNNMNMN);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<CoordinationBeaconRateLimitingFeedbackVisual> LIAGFPPAMEJ();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface FNIIDKGGCNI
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool HOFFNJKFAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LEHOLNFMMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LKHOKJKKBIH();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FOPODEIMCFC();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ECHFPFKPMDP(HKFACLJBOKN JEICPGHJIDH);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface DEMEODINNPM
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool OHLBCPNIEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool HCLFAIHOILB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBOEJHLFMJE(NIMCCIBCNBA GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ECEGLEOPEEF(NIMCCIBCNBA GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CFNBLEKGMMN(NIMCCIBCNBA GIIKHLJPAKH);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FFBNMACKBEC(NIMCCIBCNBA GIIKHLJPAKH);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LCINODLMDFH
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task POIAFCKLBDO(Guid JFGFGLLEOEC, int KFNFJDPEENF, Vector3 JDOODMBINDM, IOCPGOBBEGP IBLIOEFMDMM, string ONEGCFPJIPL, Canvas DJAAOPHLFDC);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CJOONJGNIDF(Guid JFGFGLLEOEC, IFMAPNKIFID.MLEGGDONNGO AFKEKJDHKNE);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DBBEEPONHEE(int KFNFJDPEENF, [Out] Guid COIOODGKIMP);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KHCINOOALHK(Guid JFGFGLLEOEC, [Out] CoordinationBeacon CMFPOIKGDIG);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HKMHGJMBEDC(Vector3 EMFCPAECFLA, Canvas DJAAOPHLFDC);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FMOJKECFAPD();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task PHNLALIHPKO(Vector3 FMGIODJBLMH);
}
namespace CoordinateBeacons.Configs
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class CoordinationBeaconScriptableConfig : SingletonScriptableObject<CoordinationBeaconScriptableConfig>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[Header("Prefabs of Visual Components")]
		[Tooltip("World space beacon")]
		[SerializeField]
		private AssetReference _beaconPrefabAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[Tooltip("HUD beacon shown when world space beacon is not in fov")]
		[SerializeField]
		private AssetReference beaconHUDElementAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[Tooltip("VR HUD beacon shown when world space beacon is not in fov")]
		[SerializeField]
		private AssetReference beaconVRHUDElementAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[Tooltip("Rate limiting visual feedback")]
		[SerializeField]
		private AssetReference beaconRateLimitingFeedbackVisualAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[Header("Canvases for HUD Visual Component")]
		[SerializeField]
		private AssetReference beaconScreensCanvasAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private AssetReference beaconVRCanvasAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		[Header("Audio")]
		[Tooltip("Audio that plays when the local player drops a beacon")]
		private AssetReference beaconAudioSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[Tooltip("Audio that plays when another player drops a beacon")]
		[SerializeField]
		private AssetReference beaconAudioOthers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[Tooltip("Rolloff for audio that plays when the local player drops a beacon")]
		[SerializeField]
		private AnimationCurve beaconDropAudioCustomRolloff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Tooltip("Rolloff for audio that plays another player drops a beacon")]
		[SerializeField]
		private AnimationCurve beaconDropFromOthersAudioCustomRolloff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[Tooltip("The maximum distance the other player can be from the local player for the beaconAudioOthers audio clip to play. This should match the cutoff point for beaconDropFromOthersAudioCustomRolloff")]
		[SerializeField]
		private float beaconDropFromOthersAudioMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[Header("Color Scheme")]
		[Tooltip("Color of visual components when the beacon has the Look At This context (default)")]
		[SerializeField]
		private Color lookAtThisColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Tooltip("Color of visual components when the beacon has the Watch Out context")]
		[SerializeField]
		private Color watchOutColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Tooltip("Color of visual components when the beacon has the Take This context")]
		[SerializeField]
		private Color takeThisColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Tooltip("Color of visual components when the beacon has the Come Here context")]
		[SerializeField]
		private Color comeHereColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Tooltip("Color of visual components when the beacon has the Ally context")]
		[FormerlySerializedAs("fallbackAllyColor")]
		[SerializeField]
		private Color allyColor;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public AssetReference BeaconPrefabAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public AssetReference BeaconHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public AssetReference BeaconVRHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public AssetReference BeaconRateLimitingFeedbackVisualAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AssetReference BeaconScreensCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public AssetReference BeaconVRCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x96A6B0", Offset = "0x9698B0", VA = "0x18096A6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public AssetReference BeaconAudioSelf
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x964F00", Offset = "0x964100", VA = "0x180964F00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public AssetReference BeaconAudioOthers
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x961630", Offset = "0x960830", VA = "0x180961630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public AnimationCurve BeaconDropAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x961620", Offset = "0x960820", VA = "0x180961620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public AnimationCurve BeaconDropFromOthersAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x961600", Offset = "0x960800", VA = "0x180961600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float BeaconDropFromOthersAudioMaxDistance
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x97DAA0", Offset = "0x97CCA0", VA = "0x18097DAA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Color LookAtThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7541960", Offset = "0x7540B60", VA = "0x187541960")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Color WatchOutColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7541970", Offset = "0x7540B70", VA = "0x187541970")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color TakeThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4FB2470", Offset = "0x4FB1670", VA = "0x184FB2470")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color ComeHereColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x7541950", Offset = "0x7540B50", VA = "0x187541950")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Color AllyColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7541940", Offset = "0x7540B40", VA = "0x187541940")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7541900", Offset = "0x7540B00", VA = "0x187541900")]
		public CoordinationBeaconScriptableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class OLLHLPACKKE
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static CoordinationBeaconScriptableConfig JLGHKLNHGNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7545A90", Offset = "0x7544C90", VA = "0x187545A90")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class IFMAPNKIFID
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum MLEGGDONNGO
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		EXPIRED,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		REPLACED
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum AGFIGENMEBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		HINT,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		HEADS_UP
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7542F00", Offset = "0x7542100", VA = "0x187542F00")]
	public static void NELMMLAIBLK(int GMGPDOAAFEJ, string JGBDKHCGBPA, Guid JFGFGLLEOEC, IOCPGOBBEGP BHMHHHLGIDB, MCAJJFEMNKN FAPGJJDFGDG, int AAHJLIIDICA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7542A40", Offset = "0x7541C40", VA = "0x187542A40")]
	public static void GAJMOJJCAKG(int GMGPDOAAFEJ, string JGBDKHCGBPA, Guid JFGFGLLEOEC, IOCPGOBBEGP BHMHHHLGIDB, float LGAGGPCCCLI, MLEGGDONNGO AFKEKJDHKNE, bool KECDFMGIDFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x75432A0", Offset = "0x75424A0", VA = "0x1875432A0")]
	public static void NJIBGJHPJIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7542E20", Offset = "0x7542020", VA = "0x187542E20")]
	public static void GFIDKPBFIIJ(AGFIGENMEBP DEFCAIDOHEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7543320", Offset = "0x7542520", VA = "0x187543320")]
	private static string OMDEIEFGPMH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MBPKMGOKLKO : IIEGPEMJEJN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HNEEDHLAMGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public MBPKMGOKLKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7542510", Offset = "0x7541710", VA = "0x187542510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly JFFEGGDHDOI EMCPHEEDPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly EMFJFBAKCFI HDBJBABKJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly DJMGKIHNICF FCLHMEALPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly GBEHHMEEOPM CEBOBANOIOD;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool AHMDCCBNGCP
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x990150", Offset = "0x98F350", VA = "0x180990150", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x98FED0", Offset = "0x98F0D0", VA = "0x18098FED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7545A20", Offset = "0x7544C20", VA = "0x187545A20")]
	[LDKBBAENJDF.LNCMKHHEGFN.EGEKHIDKBPA]
	internal static void LMOFFJNLCLN(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xE34FF0", Offset = "0xE341F0", VA = "0x180E34FF0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal MBPKMGOKLKO([KMMHIEIDBEA(null)][NotNull] JFFEGGDHDOI NKBKMGACAHH, [KMMHIEIDBEA(null)][NotNull] EMFJFBAKCFI DBMCMFAHLNO, [KMMHIEIDBEA(null)][NotNull] DJMGKIHNICF CLGEHLEDOKA, [KMMHIEIDBEA(null)][NotNull] GBEHHMEEOPM KOFPAKNPLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7545810", Offset = "0x7544A10", VA = "0x187545810", Slot = "5")]
	public void KJMIIEILMJL(MCAJJFEMNKN DEIOHLEKMDJ, string EPHLKMGDNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7545300", Offset = "0x7544500", VA = "0x187545300", Slot = "7")]
	public bool DLBHJOLDOEK(Camera NBEMGKCACGL, Vector3 EMFCPAECFLA, CoordinationBeacon DAJEMIDGOND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7545600", Offset = "0x7544800", VA = "0x187545600", Slot = "6")]
	public bool FDFHENGDDEL(Camera NBEMGKCACGL, Vector3 EMFCPAECFLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7545250", Offset = "0x7544450", VA = "0x187545250", Slot = "8")]
	[AsyncStateMachine(typeof(HNEEDHLAMGG))]
	public void DIJFKIHPNFC()
	{
	}
}
namespace CoordinateBeacons.Concretes
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CoordinationBeacon : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private GameObject visualRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private RectTransform rootRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private RecNetRawImage recNetImageRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private RecNetRawImage recNetImageDepthIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private Image recNetImageBaseCircleImageRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private Image recNetImageBaseCircleImageDepthIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private Material depthIgnoreMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private TextMeshPro accountTMPRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private TextMeshPro accountTMPDepthIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private Image iconRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private Image iconDepthIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private Image directionalArrowRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private Image directionalArrowDepthIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private float JEILFLNBEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private bool NJGMOCIOFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private float DEILNOONMCM;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Guid HOJBPJFAOFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1C1B910", Offset = "0x1C1AB10", VA = "0x181C1B910")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xDF7130", Offset = "0xDF6330", VA = "0x180DF7130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int CPMBLIHEHHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x970720", Offset = "0x96F920", VA = "0x180970720")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9706D0", Offset = "0x96F8D0", VA = "0x1809706D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public IOCPGOBBEGP ADOPBHOJDCI
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x514B090", Offset = "0x514A290", VA = "0x18514B090")]
			[CompilerGenerated]
			get
			{
				return default(IOCPGOBBEGP);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x514B0E0", Offset = "0x514A2E0", VA = "0x18514B0E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public RectTransform HPDFJBPGMIF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid, IFMAPNKIFID.MLEGGDONNGO> FPDMOLDFAOK
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7542390", Offset = "0x7541590", VA = "0x187542390")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7542450", Offset = "0x7541650", VA = "0x187542450")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7542310", Offset = "0x7541510", VA = "0x187542310")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7541BC0", Offset = "0x7540DC0", VA = "0x187541BC0")]
		public void Initialize(Guid JFGFGLLEOEC, int FJPFDHIGPOG, IOCPGOBBEGP IBLIOEFMDMM, string ONEGCFPJIPL, Sprite KALEFOCNMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1DB91F0", Offset = "0x1DB83F0", VA = "0x181DB91F0")]
		public void SetVisibility(bool EPONNDGCKPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1DB91D0", Offset = "0x1DB83D0", VA = "0x181DB91D0")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x75422A0", Offset = "0x75414A0", VA = "0x1875422A0")]
		public void SetVisibilityUsernameDepthIgnore(bool EPONNDGCKPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x75422E0", Offset = "0x75414E0", VA = "0x1875422E0")]
		public void StartTimer(float GGLBPDKGBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x75422F0", Offset = "0x75414F0", VA = "0x1875422F0")]
		public float StopTimer()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7542260", Offset = "0x7541460", VA = "0x187542260")]
		private void OGGHLNEJODE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7541980", Offset = "0x7540B80", VA = "0x187541980")]
		private void FHIMPCCCGHA(Color CGNACLPDGJI, bool OMNCDDODKPN, bool BLLKLGEKGEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
		public CoordinationBeacon()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class IOODENPHIOO : JFFEGGDHDOI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly JDFJKMABMDJ PMLOFGMBKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly ECHOGNCJJEK CKGAPGJLBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly FHHIANONFNH CHAOGIBIALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private float? APBEFEAEPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private float? IHNFLJOABHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool? BLBIFCMCJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool? PILJHEBFCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float? CDFADFLHJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private float? AMLIKGJJPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private float? FNKKDFDIJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private float? JNEDJPDBNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int? AEHGEGHGGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float? BJPFKEBIJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private float? JIAHOBILAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private float? LLIHJKAPGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private bool? ANPPFPJCAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7E")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool? JGFPLNKBCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool? PDAILJBBGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool? NJEADHIBKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private bool? GLBIFOBCCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x86")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private bool? OMDPOPIEENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float? CMGNAEPKMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool? GJAIBDJELEK;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public float BIHIFEMNOAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7543E50", Offset = "0x7543050", VA = "0x187543E50", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float NAPALPPKANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x75445A0", Offset = "0x75437A0", VA = "0x1875445A0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool JCAAHHINNHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7543C20", Offset = "0x7542E20", VA = "0x187543C20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HCDOIMOIBAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7543920", Offset = "0x7542B20", VA = "0x187543920", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public float BOCBDCLFAKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x75443E0", Offset = "0x75435E0", VA = "0x1875443E0", Slot = "8")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public float NCABJEBJAAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7543700", Offset = "0x7542900", VA = "0x187543700", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public float IADJNMNJOOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7544760", Offset = "0x7543960", VA = "0x187544760", Slot = "10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float NCJFFCNJMAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7543D00", Offset = "0x7542F00", VA = "0x187543D00", Slot = "11")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int GNPGJMNOFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x75434A0", Offset = "0x75426A0", VA = "0x1875434A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float GMCKDNGFFMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x75444C0", Offset = "0x75436C0", VA = "0x1875444C0", Slot = "13")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float KMAKAIINKBF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7544070", Offset = "0x7543270", VA = "0x187544070", Slot = "14")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public float IGOGABOKIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7543620", Offset = "0x7542820", VA = "0x187543620", Slot = "15")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool EPNCOIIFBKA
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7543F90", Offset = "0x7543190", VA = "0x187543F90", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool PGBGJPHOJPH
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7544300", Offset = "0x7543500", VA = "0x187544300", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool MPHEKNIHAOD
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7544B50", Offset = "0x7543D50", VA = "0x187544B50", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool IBGMNCDHJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7544910", Offset = "0x7543B10", VA = "0x187544910", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool OPMNIAHIIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x75437E0", Offset = "0x75429E0", VA = "0x1875437E0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool KJIMCGPPNLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x75435D0", Offset = "0x75427D0", VA = "0x1875435D0", Slot = "28")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7543F30", Offset = "0x7543130", VA = "0x187543F30", Slot = "20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool JDAHNAKNGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7544B00", Offset = "0x7543D00", VA = "0x187544B00", Slot = "21")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x75448B0", Offset = "0x7543AB0", VA = "0x1875448B0", Slot = "22")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public float HGIHKDDNIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x75449F0", Offset = "0x7543BF0", VA = "0x1875449F0", Slot = "23")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool MLNMCOFMOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7543580", Offset = "0x7542780", VA = "0x187543580", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7544C30", Offset = "0x7543E30", VA = "0x187544C30")]
	[RecRoom.NoEngine.Common.Preserve]
	public IOODENPHIOO([KMMHIEIDBEA(null)] JDFJKMABMDJ PGKELCELKPP, [KMMHIEIDBEA(null)] ECHOGNCJJEK FIIABEMPCJG, [KMMHIEIDBEA(null)] FHHIANONFNH AFIDJAKMJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7544840", Offset = "0x7543A40", VA = "0x187544840")]
	[LDKBBAENJDF.GEEMEPAJEEA.KFNNKBLDKPF]
	internal static void LMOFFJNLCLN(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7543A00", Offset = "0x7542C00", VA = "0x187543A00", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7543BD0", Offset = "0x7542DD0", VA = "0x187543BD0")]
	private void NOPDCPCNKHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7543830", Offset = "0x7542A30", VA = "0x187543830")]
	private void CIMJPEODHJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7543BD0", Offset = "0x7542DD0", VA = "0x187543BD0")]
	private void NLKCGGEGLFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7543BD0", Offset = "0x7542DD0", VA = "0x187543BD0")]
	private void OBALJCAHOPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7543DE0", Offset = "0x7542FE0", VA = "0x187543DE0", Slot = "19")]
	public void EOMMKPNKJCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7544230", Offset = "0x7543430", VA = "0x187544230")]
	private float GLLDPMCEDNN(string CMEGADGHOME, float? FCENMCHKABK, float OGPHJJMKHNA = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7544150", Offset = "0x7543350", VA = "0x187544150")]
	private bool GLLDPMCEDNN(string CMEGADGHOME, bool? FCENMCHKABK, bool OGPHJJMKHNA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7544680", Offset = "0x7543880", VA = "0x187544680")]
	private bool JAFLJGCMOEG(string CABJNFHEEIM, bool? FCENMCHKABK, bool OGPHJJMKHNA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7543840", Offset = "0x7542A40", VA = "0x187543840")]
	private void DBKDNGKLDGL(string CABJNFHEEIM, bool? FCENMCHKABK, bool JIPFKIHJIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7543BD0", Offset = "0x7542DD0", VA = "0x187543BD0")]
	private void EAMIIOJPJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7543830", Offset = "0x7542A30", VA = "0x187543830")]
	private void HKEJJIEBNBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum IOCPGOBBEGP
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	LOOK_AT_THIS,
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	COME_HERE,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	WATCH_OUT_RRO_ENEMY,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	WATCH_OUT_PLAYER_ENEMY,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	TAKE_THIS,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	ALLY
}
namespace CoordinateBeacons.Concretes
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class CoordinationBeaconHUDElement : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		private GameObject visualRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		private Transform chevronRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		private RectTransform rootRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private RecNetRawImage recNetRawImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private Image recNetImageRootMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		private TextMeshProUGUI distanceText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private TextMeshProUGUI usernameText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		private Image iconImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[SerializeField]
		private Image directionalIcon;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public GameObject BAEEMBKBJMA
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1DB91F0", Offset = "0x1DB83F0", VA = "0x181DB91F0")]
		public void SetVisibility(bool EPONNDGCKPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1DB91D0", Offset = "0x1DB83D0", VA = "0x181DB91D0")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x75410C0", Offset = "0x75402C0", VA = "0x1875410C0")]
		public void Initialize(int KFNFJDPEENF, IOCPGOBBEGP IBLIOEFMDMM, string ONEGCFPJIPL, Sprite KALEFOCNMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7541610", Offset = "0x7540810", VA = "0x187541610")]
		public void UpdateVisualElements(Quaternion MDDDLKLDHPE, Vector3 CHBIEDJMOLB, float CEJLPIDBNHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7540FA0", Offset = "0x75401A0", VA = "0x187540FA0")]
		private void FHIMPCCCGHA(Color CGNACLPDGJI, bool OMNCDDODKPN, bool BLLKLGEKGEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
		public CoordinationBeaconHUDElement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class CoordinationBeaconRateLimitingFeedbackVisual : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class CONANODJDAC : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public CoordinationBeaconRateLimitingFeedbackVisual <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
			[DebuggerHidden]
			public CONANODJDAC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7540830", Offset = "0x753FA30", VA = "0x187540830", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x7540950", Offset = "0x753FB50", VA = "0x187540950", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		private SpriteRenderer spriteRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float fadeDurationS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Color originalColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private float JEILFLNBEIN;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7541850", Offset = "0x7540A50", VA = "0x187541850")]
		public void DisplayRateLimitingFeedbackVisual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x75417D0", Offset = "0x75409D0", VA = "0x1875417D0")]
		[IteratorStateMachine(typeof(CONANODJDAC))]
		private IEnumerator DJGABGJPAKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x75418F0", Offset = "0x7540AF0", VA = "0x1875418F0")]
		public CoordinationBeaconRateLimitingFeedbackVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JKOJJKKMPAK : FNIIDKGGCNI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly LKJLIEKKDMF OPGFFACOELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly IDisposable AFMBONHFKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private bool HENDMFOBNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool OFPKOKPIPMH;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool HOFFNJKFAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x964F10", Offset = "0x964110", VA = "0x180964F10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool LEHOLNFMMAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x11667E0", Offset = "0x11659E0", VA = "0x1811667E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x75450D0", Offset = "0x75442D0", VA = "0x1875450D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public JKOJJKKMPAK([KMMHIEIDBEA(null)] LKJLIEKKDMF NCPDCFOBKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7544EC0", Offset = "0x75440C0", VA = "0x187544EC0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7544F60", Offset = "0x7544160", VA = "0x187544F60")]
	[LDKBBAENJDF.GEEMEPAJEEA.KFNNKBLDKPF]
	internal static void LMOFFJNLCLN(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7544F50", Offset = "0x7544150", VA = "0x187544F50", Slot = "6")]
	public void LKHOKJKKBIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7544F40", Offset = "0x7544140", VA = "0x187544F40", Slot = "7")]
	public bool FOPODEIMCFC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7544F10", Offset = "0x7544110", VA = "0x187544F10", Slot = "8")]
	public void ECHFPFKPMDP(HKFACLJBOKN JEICPGHJIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7544FD0", Offset = "0x75441D0", VA = "0x187544FD0")]
	private GNEMDIILJJK MLHOIABCNKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7544E50", Offset = "0x7544050", VA = "0x187544E50")]
	private void CLCLPBMCEJJ(JCDLFPMDPEJ NMLELHIGJMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class CPAOIABEJKB : DEMEODINNPM, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly LKJLIEKKDMF OPGFFACOELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly DDDECGPJCPM BKPJKMOPDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly DDDECGPJCPM KFIOPFNBEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly IDisposable AFMBONHFKNA;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool OHLBCPNIEKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7540B70", Offset = "0x753FD70", VA = "0x187540B70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool HCLFAIHOILB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7540D60", Offset = "0x753FF60", VA = "0x187540D60", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7540DB0", Offset = "0x753FFB0", VA = "0x187540DB0")]
	[RecRoom.NoEngine.Common.Preserve]
	public CPAOIABEJKB([KMMHIEIDBEA(null)] LKJLIEKKDMF NCPDCFOBKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x75409D0", Offset = "0x753FBD0", VA = "0x1875409D0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7540BC0", Offset = "0x753FDC0", VA = "0x187540BC0")]
	[LDKBBAENJDF.GEEMEPAJEEA.KFNNKBLDKPF]
	internal static void LMOFFJNLCLN(ANOENEDKKHA GFOILLNHEFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7540C30", Offset = "0x753FE30", VA = "0x187540C30", Slot = "5")]
	public void MBOEJHLFMJE(NIMCCIBCNBA GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7540A20", Offset = "0x753FC20", VA = "0x187540A20", Slot = "6")]
	public bool ECEGLEOPEEF(NIMCCIBCNBA GIIKHLJPAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x75409A0", Offset = "0x753FBA0", VA = "0x1875409A0", Slot = "8")]
	public void CFNBLEKGMMN(NIMCCIBCNBA GIIKHLJPAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7540B40", Offset = "0x753FD40", VA = "0x187540B40", Slot = "9")]
	public bool FFBNMACKBEC(NIMCCIBCNBA GIIKHLJPAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7540C60", Offset = "0x753FE60", VA = "0x187540C60")]
	private GNEMDIILJJK MLHOIABCNKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7540A50", Offset = "0x753FC50", VA = "0x187540A50")]
	private void FDBIAFMGPGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum MCAJJFEMNKN
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	UNKNOWN,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	PARTY,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	TEAM
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JLJFGBBBBIB
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public CoordinationBeacon BENGKKEFBFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public CoordinationBeaconHUDElement OLDCDEFAAHF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x96FF10", Offset = "0x96F110", VA = "0x18096FF10")]
	public JLJFGBBBBIB(CoordinationBeacon DAJEMIDGOND, CoordinationBeaconHUDElement JBAAOJBIHBC)
	{
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
