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
		[Cpp2IlInjected.Address(RVA = "0x744D3B0", Offset = "0x744B9B0", VA = "0x18744D3B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x245DCB0", Offset = "0x245C2B0", VA = "0x18245DCB0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[EGNCGLMDOJO("CoordinationBeacons")]
public enum NMNGLIABAIA
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[OFLAONKBAGJ("You joined a party!", true)]
	JOINED_PARTY_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[OFLAONKBAGJ("You joined a team!", true)]
	JOINED_TEAM_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[OFLAONKBAGJ("Double-tap Screen to place a Beacon.", true)]
	TOUCH_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[OFLAONKBAGJ("Middle-click Mouse to place a Beacon.", true)]
	KBM_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[OFLAONKBAGJ("Double-tap Right Shoulder to place a Beacon.", true)]
	GAMEPAD_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[OFLAONKBAGJ("Point and Tap Main Trigger to place a Beacon.", true)]
	VR_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[OFLAONKBAGJ("What's This?", true)]
	BUTTON_ACCESS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[OFLAONKBAGJ("This is a Beacon", true)]
	THIS_IS_BEACON_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[OFLAONKBAGJ("Beacons can only be placed by players in a Party or on the same Team.", true)]
	BEACON_RULES_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[OFLAONKBAGJ("Try placing a Beacon of your own!", true)]
	TRY_YOURSELF_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[OFLAONKBAGJ("Double-tap the Screen", true)]
	TOUCH_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[OFLAONKBAGJ("Middle-click the Mouse", true)]
	KBM_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[OFLAONKBAGJ("Double-tap Right Shoulder", true)]
	GAMEPAD_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[OFLAONKBAGJ("Point and Tap Main Trigger", true)]
	VR_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[OFLAONKBAGJ("once you close the dialogue window.", true)]
	ONCE_CLOSE_DIALOGUE_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[OFLAONKBAGJ("Don't show me again", true)]
	DONT_SHOW_AGAIN_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[OFLAONKBAGJ("Okay!", true)]
	BUTTON_OKAY_HINT_TUTORIAL
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FBGEHHNMJEF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DJCLELIJJEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EJNJCKJCMID(BPKICIGPGKK AGFBMEFBEDK, string JJGFHGAJHBC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KALBMIPPCNH(Camera JGNIAEGLGKO, Vector3 OFNKDHJDMMH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KPMKLPGPGOA(Camera JGNIAEGLGKO, Vector3 OFNKDHJDMMH, CoordinationBeacon OAIEOGOHEPL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FAGEHKLCDNO();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DNJBNKDGMKH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float GIMCFAJKBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float OMJDCFFKDKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IEKOHEGNAFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool ABIFOOILKFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float IJKGKIAHDJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float BNCKHNDLIEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float FNLKNADFOCA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float GNLEFENNCOF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int BOGAIFJKNEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float KGOHBGPDFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float NBOEEODCDHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float CFMAJBPNEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool JGONPAENMEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool PHOCIGOAPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool NKBHFACDLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool CDLCFKEBGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool BGCAOMHEONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float ACDMFIOKJAH
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool MDPNPGBPDCB
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool GGDPLBJANLG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LIJCDDEGCIM();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BHLNLCCMGJG
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	List<DPNHPKDDHBM> NPILJPOMDKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<(CoordinationBeacon, CoordinationBeaconHUDElement)> BFPEMDOJJDE(bool AJAIAOMCIKI);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LHGJMFKKLGJ(Guid JPIHIFJGBAG, LDOPJOHODGO.GDMIPMNLCHN FEGEINBDNLB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DNDPEDJFAKO(int LMNKGGEFJEB, [Out] CoordinationBeacon FDAEKMLGHAO);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<CoordinationBeaconRateLimitingFeedbackVisual> OLBEGFEDNPM();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HAHMCMAKCNH
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool ENGMCNGMBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LCMDADCFIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KOAOGIGFBHK();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DLLOCPHMJLL();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ONILCIAJBNE(BDHMMMHCHAA MIMFFPFKBEA);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KMCDAGFGJMN
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool AKJMNJFGEJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool OKHIGAPDNEC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JOEOBOFAPEA(FDINGGDGHDL LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool AAGIMEHMHHC(FDINGGDGHDL LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CDNIMLPFJLO(FDINGGDGHDL LAAJFAFNFCN);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PIBFHHHIMKM(FDINGGDGHDL LAAJFAFNFCN);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NBBMOFNJMAJ
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task KJIHFLPILIP(Guid JPIHIFJGBAG, int LMNKGGEFJEB, Vector3 FNDAJOIIIJO, FKBINADGHEG BPPCEJGCMKA, string CILPIGHIEAE, Canvas AFDDMKDBEJB);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BKCAPNIIHKH(Guid JPIHIFJGBAG, LDOPJOHODGO.GDMIPMNLCHN FEGEINBDNLB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HKDEFGLENPB(int LMNKGGEFJEB, [Out] Guid EPBFCIDBFJM);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NGFPOMJJGNH(Guid JPIHIFJGBAG, [Out] CoordinationBeacon FJOJBDIGBPD);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DCHELHFNKFK(Vector3 OFNKDHJDMMH, Canvas AFDDMKDBEJB);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MAPBCBIAPOG();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task JNHLFDDFJNP(Vector3 COPBEAKNGEL);
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
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public AssetReference BeaconHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public AssetReference BeaconVRHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public AssetReference BeaconRateLimitingFeedbackVisualAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AssetReference BeaconScreensCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public AssetReference BeaconVRCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9529D0", Offset = "0x950FD0", VA = "0x1809529D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public AssetReference BeaconAudioSelf
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x956AF0", Offset = "0x9550F0", VA = "0x180956AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public AssetReference BeaconAudioOthers
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x956D70", Offset = "0x955370", VA = "0x180956D70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public AnimationCurve BeaconDropAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x956CC0", Offset = "0x9552C0", VA = "0x180956CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public AnimationCurve BeaconDropFromOthersAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x958C60", Offset = "0x957260", VA = "0x180958C60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float BeaconDropFromOthersAudioMaxDistance
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x96C900", Offset = "0x96AF00", VA = "0x18096C900")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Color LookAtThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x744AE40", Offset = "0x7449440", VA = "0x18744AE40")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Color WatchOutColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x744AE50", Offset = "0x7449450", VA = "0x18744AE50")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color TakeThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x47C1E00", Offset = "0x47C0400", VA = "0x1847C1E00")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color ComeHereColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x744AE30", Offset = "0x7449430", VA = "0x18744AE30")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Color AllyColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x744AE20", Offset = "0x7449420", VA = "0x18744AE20")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x744ADE0", Offset = "0x74493E0", VA = "0x18744ADE0")]
		public CoordinationBeaconScriptableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class GGJCMAJHECH
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static CoordinationBeaconScriptableConfig IMFIEPMCPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x744B9F0", Offset = "0x7449FF0", VA = "0x18744B9F0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LDOPJOHODGO
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum GDMIPMNLCHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		EXPIRED,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		REPLACED
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum AHNMELEPNAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		HINT,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		HEADS_UP
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x744C080", Offset = "0x744A680", VA = "0x18744C080")]
	public static void MBGGLIKGFKK(int NJNOPMJJKAE, string LCHKFCCHLKE, Guid JPIHIFJGBAG, FKBINADGHEG GDMIHJGIKLO, BPKICIGPGKK EHLEFJNDNCL, int ONLKFOGKEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x744C420", Offset = "0x744AA20", VA = "0x18744C420")]
	public static void PIIDLMFNICM(int NJNOPMJJKAE, string LCHKFCCHLKE, Guid JPIHIFJGBAG, FKBINADGHEG GDMIHJGIKLO, float KCOMPHBACLN, GDMIPMNLCHN FEGEINBDNLB, bool KMOBCBENAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x744C800", Offset = "0x744AE00", VA = "0x18744C800")]
	public static void PMDGJAMDMAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x744BE20", Offset = "0x744A420", VA = "0x18744BE20")]
	public static void DIJMEDAAJBA(AHNMELEPNAO BHHFKJGCODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x744BF00", Offset = "0x744A500", VA = "0x18744BF00")]
	private static string JLPCFAOOAKH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BBOAJIPKCKM : FBGEHHNMJEF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct NGPPOABIAKA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public BBOAJIPKCKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x744CE80", Offset = "0x744B480", VA = "0x18744CE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA50FB0", Offset = "0xA4F5B0", VA = "0x180A50FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly DNJBNKDGMKH LOHDCAPFODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly BHLNLCCMGJG PKMKAGFBDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly GFJFIDGHMOA GCLFELNMPGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly HDBHJOOCNDA DMDIJHIFKLA;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool DJCLELIJJEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x97F1A0", Offset = "0x97D7A0", VA = "0x18097F1A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x97EF20", Offset = "0x97D520", VA = "0x18097EF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7448110", Offset = "0x7446710", VA = "0x187448110")]
	[HLOHOCOKELO.JGEFFJBDHJI.PBGODBDBELG]
	internal static void APJICGAGHJP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xDDF810", Offset = "0xDDDE10", VA = "0x180DDF810")]
	[RecRoom.NoEngine.Common.Preserve]
	internal BBOAJIPKCKM([IBJCGEMJMJL(null)][NotNull] DNJBNKDGMKH JGEEINABEOK, [IBJCGEMJMJL(null)][NotNull] BHLNLCCMGJG BLKPBDNJLNF, [IBJCGEMJMJL(null)][NotNull] GFJFIDGHMOA CKEMIOHGOMD, [IBJCGEMJMJL(null)][NotNull] HDBHJOOCNDA AOJKEFADKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7448180", Offset = "0x7446780", VA = "0x187448180", Slot = "5")]
	public void EJNJCKJCMID(BPKICIGPGKK AGFBMEFBEDK, string JJGFHGAJHBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7448650", Offset = "0x7446C50", VA = "0x187448650", Slot = "7")]
	public bool KPMKLPGPGOA(Camera JGNIAEGLGKO, Vector3 OFNKDHJDMMH, CoordinationBeacon OAIEOGOHEPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7448440", Offset = "0x7446A40", VA = "0x187448440", Slot = "6")]
	public bool KALBMIPPCNH(Camera JGNIAEGLGKO, Vector3 OFNKDHJDMMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7448390", Offset = "0x7446990", VA = "0x187448390", Slot = "8")]
	[AsyncStateMachine(typeof(NGPPOABIAKA))]
	public void FAGEHKLCDNO()
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
		private float NNPDJIGPHOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private bool KPGKAGBLDME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private float OJNNHKKOLCF;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Guid AOALABMLPFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1BAF590", Offset = "0x1BADB90", VA = "0x181BAF590")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD7F320", Offset = "0xD7D920", VA = "0x180D7F320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int CKPEJPJEONB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x95C650", Offset = "0x95AC50", VA = "0x18095C650")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x95C680", Offset = "0x95AC80", VA = "0x18095C680")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public FKBINADGHEG KKKLHABLMLF
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5134190", Offset = "0x5132790", VA = "0x185134190")]
			[CompilerGenerated]
			get
			{
				return default(FKBINADGHEG);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x51341E0", Offset = "0x51327E0", VA = "0x1851341E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public RectTransform LHCKJHLCPKF
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x952800", Offset = "0x950E00", VA = "0x180952800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid, LDOPJOHODGO.GDMIPMNLCHN> LMMJJBNEJEO
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x744B870", Offset = "0x7449E70", VA = "0x18744B870")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x744B930", Offset = "0x7449F30", VA = "0x18744B930")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x744B7F0", Offset = "0x7449DF0", VA = "0x18744B7F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x744AEA0", Offset = "0x74494A0", VA = "0x18744AEA0")]
		public void Initialize(Guid JPIHIFJGBAG, int LCNMJIEMAGO, FKBINADGHEG BPPCEJGCMKA, string CILPIGHIEAE, Sprite ALDEECMDALG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1C2AA20", Offset = "0x1C29020", VA = "0x181C2AA20")]
		public void SetVisibility(bool OMJBCAAIGCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1C2AA00", Offset = "0x1C29000", VA = "0x181C2AA00")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x744B780", Offset = "0x7449D80", VA = "0x18744B780")]
		public void SetVisibilityUsernameDepthIgnore(bool OMJBCAAIGCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x744B7C0", Offset = "0x7449DC0", VA = "0x18744B7C0")]
		public void StartTimer(float JIOICHDNAMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x744B7D0", Offset = "0x7449DD0", VA = "0x18744B7D0")]
		public float StopTimer()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x744AE60", Offset = "0x7449460", VA = "0x18744AE60")]
		private void HKMGIIOKFFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x744B540", Offset = "0x7449B40", VA = "0x18744B540")]
		private void KEBKKELILPK(Color GKGFIKHDIAG, bool LMJNFBNLIHC, bool CEONIAFJANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950050", VA = "0x180951A50")]
		public CoordinationBeacon()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BGGBNFHHFFO : DNJBNKDGMKH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly FIIDOADKEDD FMMOAMFAIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly CDIHIOEBGKL LLBOAMHFEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly CHDNBFGGGBI GOPJGPODDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private float? DDHHFEMGMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private float? JFGBPPCOOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool? HOCKKMLLDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool? BDMAFPNLBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float? DBCEGJAFOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private float? OLALLHBPDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private float? IOAEPJADCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private float? KALBIPKACNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int? IOJNDLLBMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float? LGAOMLHACAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private float? GENFKBGFIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private float? ONPKFKMGOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private bool? LJIFONLDHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7E")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool? DIJANENKJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool? BGAIJGLBBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool? OGFAHFBKFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private bool? IMELHNOHJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x86")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private bool? NONHDJDIPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float? IJPCALNFNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool? NMIOHCEKAHE;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public float GIMCFAJKBGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7449250", Offset = "0x7447850", VA = "0x187449250", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float OMJDCFFKDKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7449330", Offset = "0x7447930", VA = "0x187449330", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool IEKOHEGNAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7449760", Offset = "0x7447D60", VA = "0x187449760", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool ABIFOOILKFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7449540", Offset = "0x7447B40", VA = "0x187449540", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public float IJKGKIAHDJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7448D10", Offset = "0x7447310", VA = "0x187448D10", Slot = "8")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public float BNCKHNDLIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7449170", Offset = "0x7447770", VA = "0x187449170", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public float FNLKNADFOCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7449460", Offset = "0x7447A60", VA = "0x187449460", Slot = "10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float GNLEFENNCOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x744A000", Offset = "0x7448600", VA = "0x18744A000", Slot = "11")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int BOGAIFJKNEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7449D70", Offset = "0x7448370", VA = "0x187449D70", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float KGOHBGPDFLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x74499F0", Offset = "0x7447FF0", VA = "0x1874499F0", Slot = "13")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float NBOEEODCDHB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7449AD0", Offset = "0x74480D0", VA = "0x187449AD0", Slot = "14")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public float CFMAJBPNEAK
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x74489C0", Offset = "0x7446FC0", VA = "0x1874489C0", Slot = "15")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool JGONPAENMEN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7449030", Offset = "0x7447630", VA = "0x187449030", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool PHOCIGOAPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7449C90", Offset = "0x7448290", VA = "0x187449C90", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool NKBHFACDLFE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7449840", Offset = "0x7447E40", VA = "0x187449840", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool GGDPLBJANLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7449BB0", Offset = "0x74481B0", VA = "0x187449BB0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool EAEIMFPFICF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7449120", Offset = "0x7447720", VA = "0x187449120", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool CDLCFKEBGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7449410", Offset = "0x7447A10", VA = "0x187449410", Slot = "28")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7449990", Offset = "0x7447F90", VA = "0x187449990", Slot = "20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool BGCAOMHEONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7448AF0", Offset = "0x74470F0", VA = "0x187448AF0", Slot = "21")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7449620", Offset = "0x7447C20", VA = "0x187449620", Slot = "22")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public float ACDMFIOKJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7448E40", Offset = "0x7447440", VA = "0x187448E40", Slot = "23")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool MDPNPGBPDCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7448AA0", Offset = "0x74470A0", VA = "0x187448AA0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x744A0E0", Offset = "0x74486E0", VA = "0x18744A0E0")]
	[RecRoom.NoEngine.Common.Preserve]
	public BGGBNFHHFFO([IBJCGEMJMJL(null)] FIIDOADKEDD MGBNFJALEFB, [IBJCGEMJMJL(null)] CDIHIOEBGKL IAMFBEJPEKC, [IBJCGEMJMJL(null)] CHDNBFGGGBI EJFIDBEJEPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7448950", Offset = "0x7446F50", VA = "0x187448950")]
	[HLOHOCOKELO.CMBCHPAFDOL.DIAIOJMELDA]
	internal static void APJICGAGHJP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7448B40", Offset = "0x7447140", VA = "0x187448B40", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7448DF0", Offset = "0x74473F0", VA = "0x187448DF0")]
	private void EFKELHNEDOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7449110", Offset = "0x7447710", VA = "0x187449110")]
	private void LHNDGNLJDDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7448DF0", Offset = "0x74473F0", VA = "0x187448DF0")]
	private void FIICEJONPBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7448DF0", Offset = "0x74473F0", VA = "0x187448DF0")]
	private void GONFHGJOPFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7449920", Offset = "0x7447F20", VA = "0x187449920", Slot = "19")]
	public void LIJCDDEGCIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7449E50", Offset = "0x7448450", VA = "0x187449E50")]
	private float PDHDPOHAKKL(string KNMGCJBGDJG, float? FOAKCJPCPOD, float IDJBNLNBJCD = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7449F20", Offset = "0x7448520", VA = "0x187449F20")]
	private bool PDHDPOHAKKL(string KNMGCJBGDJG, bool? FOAKCJPCPOD, bool IDJBNLNBJCD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7448F50", Offset = "0x7447550", VA = "0x187448F50")]
	private bool FBILHPLLKGJ(string MKBJJJDIMLK, bool? FOAKCJPCPOD, bool IDJBNLNBJCD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7449680", Offset = "0x7447C80", VA = "0x187449680")]
	private void KNNEAANHABN(string MKBJJJDIMLK, bool? FOAKCJPCPOD, bool IOCKBOOECEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7448DF0", Offset = "0x74473F0", VA = "0x187448DF0")]
	private void OCKJLGOMCGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7449110", Offset = "0x7447710", VA = "0x187449110")]
	private void FJLEMMMMKME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum FKBINADGHEG
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
		public GameObject OMDDPMJOAAD
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1C2AA20", Offset = "0x1C29020", VA = "0x181C2AA20")]
		public void SetVisibility(bool OMJBCAAIGCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1C2AA00", Offset = "0x1C29000", VA = "0x181C2AA00")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x744A470", Offset = "0x7448A70", VA = "0x18744A470")]
		public void Initialize(int LMNKGGEFJEB, FKBINADGHEG BPPCEJGCMKA, string CILPIGHIEAE, Sprite ALDEECMDALG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x744AAF0", Offset = "0x74490F0", VA = "0x18744AAF0")]
		public void UpdateVisualElements(Quaternion PJPJFILCEED, Vector3 IJNCCGADGJC, float GCIOBCHMLID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x744A9D0", Offset = "0x7448FD0", VA = "0x18744A9D0")]
		private void KEBKKELILPK(Color GKGFIKHDIAG, bool LMJNFBNLIHC, bool CEONIAFJANL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950050", VA = "0x180951A50")]
		public CoordinationBeaconHUDElement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class CoordinationBeaconRateLimitingFeedbackVisual : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class BJEDHNBFAJC : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x9527A0", Offset = "0x950DA0", VA = "0x1809527A0")]
			[DebuggerHidden]
			public BJEDHNBFAJC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x744A300", Offset = "0x7448900", VA = "0x18744A300", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x744A420", Offset = "0x7448A20", VA = "0x18744A420", Slot = "8")]
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
		private float NNPDJIGPHOM;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x744ACB0", Offset = "0x74492B0", VA = "0x18744ACB0")]
		public void DisplayRateLimitingFeedbackVisual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x744AD50", Offset = "0x7449350", VA = "0x18744AD50")]
		[IteratorStateMachine(typeof(BJEDHNBFAJC))]
		private IEnumerator NPLCIDADKAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x744ADD0", Offset = "0x74493D0", VA = "0x18744ADD0")]
		public CoordinationBeaconRateLimitingFeedbackVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JKDNLDKLFPH : HAHMCMAKCNH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly DMBDJAPHJEC PIPMDKDFHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly IDisposable LIFMCLHJNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private bool AMBMFNGGAEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool FEACGFGEKBL;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool ENGMCNGMBGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x956CE0", Offset = "0x9552E0", VA = "0x180956CE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool LCMDADCFIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1112A70", Offset = "0x1111070", VA = "0x181112A70", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x744BCA0", Offset = "0x744A2A0", VA = "0x18744BCA0")]
	[RecRoom.NoEngine.Common.Preserve]
	public JKDNLDKLFPH([IBJCGEMJMJL(null)] DMBDJAPHJEC LINBCANIEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x744BAA0", Offset = "0x744A0A0", VA = "0x18744BAA0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x744BA20", Offset = "0x744A020", VA = "0x18744BA20")]
	[HLOHOCOKELO.CMBCHPAFDOL.DIAIOJMELDA]
	internal static void APJICGAGHJP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x744BC60", Offset = "0x744A260", VA = "0x18744BC60", Slot = "6")]
	public void KOAOGIGFBHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x744BA90", Offset = "0x744A090", VA = "0x18744BA90", Slot = "7")]
	public bool DLLOCPHMJLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x744BC70", Offset = "0x744A270", VA = "0x18744BC70", Slot = "8")]
	public void ONILCIAJBNE(BDHMMMHCHAA MIMFFPFKBEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x744BAF0", Offset = "0x744A0F0", VA = "0x18744BAF0")]
	private JKEGNLFNIEK HLIEPBKOEKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x744BBF0", Offset = "0x744A1F0", VA = "0x18744BBF0")]
	private void KFBMKAJKBFD(BPPINHJEEIJ PELAIPBHEBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class MMMNNGDGDOC : KMCDAGFGJMN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly DMBDJAPHJEC PIPMDKDFHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly BOGJHKLDLEM PLBKEAIPFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly BOGJHKLDLEM DJDLIBMPGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly IDisposable LIFMCLHJNBN;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool AKJMNJFGEJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x744CC10", Offset = "0x744B210", VA = "0x18744CC10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool OKHIGAPDNEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x744CB90", Offset = "0x744B190", VA = "0x18744CB90", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x744CC90", Offset = "0x744B290", VA = "0x18744CC90")]
	[RecRoom.NoEngine.Common.Preserve]
	public MMMNNGDGDOC([IBJCGEMJMJL(null)] DMBDJAPHJEC LINBCANIEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x744CA40", Offset = "0x744B040", VA = "0x18744CA40", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x744C8B0", Offset = "0x744AEB0", VA = "0x18744C8B0")]
	[HLOHOCOKELO.CMBCHPAFDOL.DIAIOJMELDA]
	internal static void APJICGAGHJP(GFKEMDIOCPC MGOKPJKELJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x744CBE0", Offset = "0x744B1E0", VA = "0x18744CBE0", Slot = "5")]
	public void JOEOBOFAPEA(FDINGGDGHDL LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x744C880", Offset = "0x744AE80", VA = "0x18744C880", Slot = "6")]
	public bool AAGIMEHMHHC(FDINGGDGHDL LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x744C920", Offset = "0x744AF20", VA = "0x18744C920", Slot = "8")]
	public void CDNIMLPFJLO(FDINGGDGHDL LAAJFAFNFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x744CC60", Offset = "0x744B260", VA = "0x18744CC60", Slot = "9")]
	public bool PIBFHHHIMKM(FDINGGDGHDL LAAJFAFNFCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x744CA90", Offset = "0x744B090", VA = "0x18744CA90")]
	private JKEGNLFNIEK HLIEPBKOEKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x744C950", Offset = "0x744AF50", VA = "0x18744C950")]
	private void DDONGCKGGEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum BPKICIGPGKK
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	UNKNOWN,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	PARTY,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	TEAM
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DPNHPKDDHBM
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public CoordinationBeacon KMPPAJECJBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x950410", Offset = "0x94EA10", VA = "0x180950410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public CoordinationBeaconHUDElement POHMCPBCOOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x9526B0", Offset = "0x950CB0", VA = "0x1809526B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x95ED80", Offset = "0x95D380", VA = "0x18095ED80")]
	public DPNHPKDDHBM(CoordinationBeacon OAIEOGOHEPL, CoordinationBeaconHUDElement GOBENMMMMHM)
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
