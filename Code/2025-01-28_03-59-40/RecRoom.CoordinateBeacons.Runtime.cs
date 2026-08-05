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
		[Cpp2IlInjected.Address(RVA = "0x7171DA0", Offset = "0x7170FA0", VA = "0x187171DA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x23EA930", Offset = "0x23E9B30", VA = "0x1823EA930")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[ADKHNKKKKHN("CoordinationBeacons")]
public enum BCOOPFKKLDO
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[AEIOODNPHHK("You joined a party!", true)]
	JOINED_PARTY_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[AEIOODNPHHK("You joined a team!", true)]
	JOINED_TEAM_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[AEIOODNPHHK("Double-tap Screen to place a Beacon.", true)]
	TOUCH_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[AEIOODNPHHK("Middle-click Mouse to place a Beacon.", true)]
	KBM_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[AEIOODNPHHK("Double-tap Right Shoulder to place a Beacon.", true)]
	GAMEPAD_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[AEIOODNPHHK("Point and Tap Main Trigger to place a Beacon.", true)]
	VR_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[AEIOODNPHHK("What's This?", true)]
	BUTTON_ACCESS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[AEIOODNPHHK("This is a Beacon", true)]
	THIS_IS_BEACON_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[AEIOODNPHHK("Beacons can only be placed by players in a Party or on the same Team.", true)]
	BEACON_RULES_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[AEIOODNPHHK("Try placing a Beacon of your own!", true)]
	TRY_YOURSELF_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[AEIOODNPHHK("Double-tap the Screen", true)]
	TOUCH_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[AEIOODNPHHK("Middle-click the Mouse", true)]
	KBM_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[AEIOODNPHHK("Double-tap Right Shoulder", true)]
	GAMEPAD_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[AEIOODNPHHK("Point and Tap Main Trigger", true)]
	VR_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[AEIOODNPHHK("once you close the dialogue window.", true)]
	ONCE_CLOSE_DIALOGUE_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[AEIOODNPHHK("Don't show me again", true)]
	DONT_SHOW_AGAIN_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[AEIOODNPHHK("Okay!", true)]
	BUTTON_OKAY_HINT_TUTORIAL
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EDEOAFLMHOJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HDOLAKOBOPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HDLKEFNMEPF(MLAOAEFJIJF MHMJCDFAGEG, string AMGNBELGIHC);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KGHFKIPLPJB(Camera GMDPMJCMKON, Vector3 PDDOBGODIAB);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HAHEPKKIHMJ(Camera GMDPMJCMKON, Vector3 PDDOBGODIAB, CoordinationBeacon CAODPHODEDN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FJOFAJGAFKE();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OFKJCMDDCMG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float FBOIDLBLGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float DNCPEHPDPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LNKNCGBEDNC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool FKPDIHPLDBI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float GFFCBLGPKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float BKFGODHGFLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float CNOOJPJCMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float NEDNEIJFCEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int ICCPEHGFJOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float GHONNDMNIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float JLALFHDFBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float CHGJLCNDHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool ODGIJJHJEON
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool KPAHGDELDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool FBJCBFIFAEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool KJNHFOFJNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool CKJCDOCOIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float AGKKFCHKEKA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool DIDICHJEKDF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool NLKKOKLMLND
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void PFBHAMJMDHO();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FOPFEHMKOLN
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	List<KNGNDAPJOPO> BOHEGFEINFP
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<(CoordinationBeacon, CoordinationBeaconHUDElement)> GDPBMBDCDOE(bool PPNGKHPKPFK);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KMOFKGNJGLE(Guid MCJGLPMPJIH, PDHNIEFPEPI.KOKDBIKKPKA MEINBJDMNFB);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JJAGADBIHGC(int GFACCAAHJHG, [Out] CoordinationBeacon NLENOOKMEKN);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<CoordinationBeaconRateLimitingFeedbackVisual> PKILGBCIDEA();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NKBMNLPAHLE
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool PMIPAJODMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool LCEFBKMJAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JOIOCKBLCEF();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BDJONMPMBJB();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LLGEBMJIGHK(LJJCDEANBLH JPGPNLNCOHG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface GOFLKIDPNCD
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool PPKJBDJBIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool PJPADJAAHMP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGHPGCKHJFK(IGCCAEFBMNB BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PBILJPALHEA(IGCCAEFBMNB BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NCEKIAFHMGI(IGCCAEFBMNB BCOHKLCJCPM);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DEICLGMDDFP(IGCCAEFBMNB BCOHKLCJCPM);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface PJKNLGMCAOL
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ALFFJIMLGCD(Guid MCJGLPMPJIH, int GFACCAAHJHG, Vector3 CICOAFGCJGI, AMLPEGIKABL GCGNIOHLIKK, string JJDGHGFHPLI, Canvas CNEFJGEKKJN);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GGCIFKANGLL(Guid MCJGLPMPJIH, PDHNIEFPEPI.KOKDBIKKPKA MEINBJDMNFB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GNHCPKMHJAB(int GFACCAAHJHG, [Out] Guid LILPJDONKIE);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FNGEFHBLCJH(Guid MCJGLPMPJIH, [Out] CoordinationBeacon NNBJIMBNHFL);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void POBMCNOFEBF(Vector3 PDDOBGODIAB, Canvas CNEFJGEKKJN);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PGPKDHNCKFO();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task ELEHODCLAPM(Vector3 FPFCIHHGLBG);
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
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public AssetReference BeaconHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public AssetReference BeaconVRHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public AssetReference BeaconRateLimitingFeedbackVisualAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D20", Offset = "0x8F3F20", VA = "0x1808F4D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AssetReference BeaconScreensCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0E0", Offset = "0x8FA2E0", VA = "0x1808FB0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public AssetReference BeaconVRCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8FD8F0", Offset = "0x8FCAF0", VA = "0x1808FD8F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public AssetReference BeaconAudioSelf
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8F9330", Offset = "0x8F8530", VA = "0x1808F9330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public AssetReference BeaconAudioOthers
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8F21D0", Offset = "0x8F13D0", VA = "0x1808F21D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public AnimationCurve BeaconDropAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8F2220", Offset = "0x8F1420", VA = "0x1808F2220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public AnimationCurve BeaconDropFromOthersAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8F21E0", Offset = "0x8F13E0", VA = "0x1808F21E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float BeaconDropFromOthersAudioMaxDistance
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x90E6F0", Offset = "0x90D8F0", VA = "0x18090E6F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Color LookAtThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x716D540", Offset = "0x716C740", VA = "0x18716D540")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Color WatchOutColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x716D550", Offset = "0x716C750", VA = "0x18716D550")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color TakeThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x43A1920", Offset = "0x43A0B20", VA = "0x1843A1920")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color ComeHereColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x716D530", Offset = "0x716C730", VA = "0x18716D530")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Color AllyColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x716D520", Offset = "0x716C720", VA = "0x18716D520")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x716D4E0", Offset = "0x716C6E0", VA = "0x18716D4E0")]
		public CoordinationBeaconScriptableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class MDNNINBFGMA
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static CoordinationBeaconScriptableConfig CLACNPDFIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7170E10", Offset = "0x7170010", VA = "0x187170E10")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class PDHNIEFPEPI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum KOKDBIKKPKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		EXPIRED,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		REPLACED
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum EBBOKOBIEOB
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		HINT,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		HEADS_UP
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7171470", Offset = "0x7170670", VA = "0x187171470")]
	public static void FDLGKOLMIHK(int GOLPFJHCONJ, string NLAJPBKOPNC, Guid MCJGLPMPJIH, AMLPEGIKABL MGPOGGLGGLO, MLAOAEFJIJF MNIFBCGAFAE, int GIIAGHABGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7170E40", Offset = "0x7170040", VA = "0x187170E40")]
	public static void CIAOHLONKDH(int GOLPFJHCONJ, string NLAJPBKOPNC, Guid MCJGLPMPJIH, AMLPEGIKABL MGPOGGLGGLO, float KKLIKKDKHFM, KOKDBIKKPKA MEINBJDMNFB, bool NAMIJGPPIHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7171810", Offset = "0x7170A10", VA = "0x187171810")]
	public static void KGFMNPDLHIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7171390", Offset = "0x7170590", VA = "0x187171390")]
	public static void DOGDNPNJLJB(EBBOKOBIEOB KCPLLPHLDFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7171220", Offset = "0x7170420", VA = "0x187171220")]
	private static string CMNGHBHNBOE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class DPOEMFBFDOK : EDEOAFLMHOJ
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct PKFDMKNBEBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public DPOEMFBFDOK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7171890", Offset = "0x7170A90", VA = "0x187171890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x949E40", Offset = "0x949040", VA = "0x180949E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly OFKJCMDDCMG NEFONPLPAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly FOPFEHMKOLN CIJMGOFPHGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly DPDFKPJJMMF LPACABIPBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly OCINLGEILCM PNPDDHAFMNO;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool HDOLAKOBOPC
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x920F50", Offset = "0x920150", VA = "0x180920F50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x920CD0", Offset = "0x91FED0", VA = "0x180920CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x716E0B0", Offset = "0x716D2B0", VA = "0x18716E0B0")]
	[NAOGKPPNIGE.MIHKMKENDLB.GBAIAGAIEPJ]
	internal static void EEMNDALIEKO(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xDCCE00", Offset = "0xDCC000", VA = "0x180DCCE00")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DPOEMFBFDOK([FMJHJHHALCB(null)][NotNull] OFKJCMDDCMG ELDJAFEPIDI, [FMJHJHHALCB(null)][NotNull] FOPFEHMKOLN POFAABPBPCP, [FMJHJHHALCB(null)][NotNull] DPDFKPJJMMF NIMPJCAJLLG, [FMJHJHHALCB(null)][NotNull] OCINLGEILCM HHMOHPJIGBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x716E4D0", Offset = "0x716D6D0", VA = "0x18716E4D0", Slot = "5")]
	public void HDLKEFNMEPF(MLAOAEFJIJF MHMJCDFAGEG, string AMGNBELGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x716E1D0", Offset = "0x716D3D0", VA = "0x18716E1D0", Slot = "7")]
	public bool HAHEPKKIHMJ(Camera GMDPMJCMKON, Vector3 PDDOBGODIAB, CoordinationBeacon CAODPHODEDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x716E6E0", Offset = "0x716D8E0", VA = "0x18716E6E0", Slot = "6")]
	public bool KGHFKIPLPJB(Camera GMDPMJCMKON, Vector3 PDDOBGODIAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x716E120", Offset = "0x716D320", VA = "0x18716E120", Slot = "8")]
	[AsyncStateMachine(typeof(PKFDMKNBEBO))]
	public void FJOFAJGAFKE()
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
		private float OCGNNILOFPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private bool EGNCJCJKOEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private float PPIIEIJILJD;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Guid JFJOAOHHOGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1B75490", Offset = "0x1B74690", VA = "0x181B75490")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD6E310", Offset = "0xD6D510", VA = "0x180D6E310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int GNJBLFPPGHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8F91A0", Offset = "0x8F83A0", VA = "0x1808F91A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8F9300", Offset = "0x8F8500", VA = "0x1808F9300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public AMLPEGIKABL NPHCNIEGAPI
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4F6B0D0", Offset = "0x4F6A2D0", VA = "0x184F6B0D0")]
			[CompilerGenerated]
			get
			{
				return default(AMLPEGIKABL);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x4F6B120", Offset = "0x4F6A320", VA = "0x184F6B120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public RectTransform FDAHMPAJDAN
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8F54C0", Offset = "0x8F46C0", VA = "0x1808F54C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid, PDHNIEFPEPI.KOKDBIKKPKA> GDOELFIFMJG
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x716DF30", Offset = "0x716D130", VA = "0x18716DF30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x716DFF0", Offset = "0x716D1F0", VA = "0x18716DFF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x716DEB0", Offset = "0x716D0B0", VA = "0x18716DEB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x716D560", Offset = "0x716C760", VA = "0x18716D560")]
		public void Initialize(Guid MCJGLPMPJIH, int BLHMCLMEIOM, AMLPEGIKABL GCGNIOHLIKK, string JJDGHGFHPLI, Sprite OKPJFPCMAML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1BE6990", Offset = "0x1BE5B90", VA = "0x181BE6990")]
		public void SetVisibility(bool ONKMPCOJFLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1BE6970", Offset = "0x1BE5B70", VA = "0x181BE6970")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1BE3E70", Offset = "0x1BE3070", VA = "0x181BE3E70")]
		public void SetVisibilityUsernameDepthIgnore(bool ONKMPCOJFLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x716DE80", Offset = "0x716D080", VA = "0x18716DE80")]
		public void StartTimer(float MFEMBCBEIED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x716DE90", Offset = "0x716D090", VA = "0x18716DE90")]
		public float StopTimer()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x716DC00", Offset = "0x716CE00", VA = "0x18716DC00")]
		private void JDDGCNEENJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x716DC40", Offset = "0x716CE40", VA = "0x18716DC40")]
		private void ODKFIKLPJFB(Color IDDEDDGMNLB, bool EBALJOOCNKG, bool KBDOKGEINBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
		public CoordinationBeacon()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FCOCCNCOMMO : OFKJCMDDCMG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly AFJINEAEPKI MNEMLBAAICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly OFILAFCHFIJ AEMHPANEGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly DEGKPLDMDPH DIODFMFNHFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private float? BOEHJDNKLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private float? BAGBLNAKHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool? NBAHNNMEAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool? KCBNHKEFBFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float? MEGLHCNPEKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private float? PHOPCGOIDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private float? PBPKGAAJPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private float? IPDNNFNOOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int? LHMAEMCGCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float? CFKAHGHLFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private float? EFFKOMAFKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private float? CGCPOIGJLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private bool? ANNFHHMDKBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7E")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool? PGPAFOONBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool? CLEIJGGEPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool? NGNGJKEGBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private bool? POIPPJFCKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x86")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private bool? LGJKCPLINLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float? AFDAMHBIFCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool? HDBNFGBFBIF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public float FBOIDLBLGEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x716EDC0", Offset = "0x716DFC0", VA = "0x18716EDC0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float DNCPEHPDPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x716FDF0", Offset = "0x716EFF0", VA = "0x18716FDF0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool LNKNCGBEDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x716F8D0", Offset = "0x716EAD0", VA = "0x18716F8D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool FKPDIHPLDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x716EEA0", Offset = "0x716E0A0", VA = "0x18716EEA0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public float GFFCBLGPKMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x716F1D0", Offset = "0x716E3D0", VA = "0x18716F1D0", Slot = "8")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public float BKFGODHGFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x716FB70", Offset = "0x716ED70", VA = "0x18716FB70", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public float CNOOJPJCMMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x716F550", Offset = "0x716E750", VA = "0x18716F550", Slot = "10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float NEDNEIJFCEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x716ECE0", Offset = "0x716DEE0", VA = "0x18716ECE0", Slot = "11")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int ICCPEHGFJOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x716F7F0", Offset = "0x716E9F0", VA = "0x18716F7F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float GHONNDMNIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x716FC50", Offset = "0x716EE50", VA = "0x18716FC50", Slot = "13")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float JLALFHDFBOM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x716E9D0", Offset = "0x716DBD0", VA = "0x18716E9D0", Slot = "14")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public float CHGJLCNDHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x716F9B0", Offset = "0x716EBB0", VA = "0x18716F9B0", Slot = "15")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool ODGIJJHJEON
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x716EB60", Offset = "0x716DD60", VA = "0x18716EB60", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool KPAHGDELDFE
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x716F470", Offset = "0x716E670", VA = "0x18716F470", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool FBJCBFIFAEE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x716E8F0", Offset = "0x716DAF0", VA = "0x18716E8F0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool NLKKOKLMLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x716FA90", Offset = "0x716EC90", VA = "0x18716FA90", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool GKENOIBEHBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x716F7A0", Offset = "0x716E9A0", VA = "0x18716F7A0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool KJNHFOFJNPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x716EAB0", Offset = "0x716DCB0", VA = "0x18716EAB0", Slot = "28")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x716EB00", Offset = "0x716DD00", VA = "0x18716EB00", Slot = "20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool CKJCDOCOIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x716FD30", Offset = "0x716EF30", VA = "0x18716FD30", Slot = "21")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x716F740", Offset = "0x716E940", VA = "0x18716F740", Slot = "22")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public float AGKKFCHKEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x716F630", Offset = "0x716E830", VA = "0x18716F630", Slot = "23")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool DIDICHJEKDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x716EC90", Offset = "0x716DE90", VA = "0x18716EC90", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7170080", Offset = "0x716F280", VA = "0x187170080")]
	[RecRoom.NoEngine.Common.Preserve]
	public FCOCCNCOMMO([FMJHJHHALCB(null)] AFJINEAEPKI APAGJACOOAN, [FMJHJHHALCB(null)] OFILAFCHFIJ OHHFPEEEENG, [FMJHJHHALCB(null)] DEGKPLDMDPH EJCINCHJBGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x716F150", Offset = "0x716E350", VA = "0x18716F150")]
	[NAOGKPPNIGE.AGGBMPJIOLK.IPOKDFJKKKA]
	internal static void EEMNDALIEKO(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x716EF80", Offset = "0x716E180", VA = "0x18716EF80", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x716EC40", Offset = "0x716DE40", VA = "0x18716EC40")]
	private void OLCDFLPOBAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x716F1C0", Offset = "0x716E3C0", VA = "0x18716F1C0")]
	private void GKHBAEPKBHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x716EC40", Offset = "0x716DE40", VA = "0x18716EC40")]
	private void POAOGKIFODA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x716EC40", Offset = "0x716DE40", VA = "0x18716EC40")]
	private void LMEHAFBJCHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x716FD80", Offset = "0x716EF80", VA = "0x18716FD80", Slot = "19")]
	public void PFBHAMJMDHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x716FED0", Offset = "0x716F0D0", VA = "0x18716FED0")]
	private float PNBMKNKJCON(string EKBBFFMFEOM, float? OMEGHEHDIOM, float JEBHMGJFPIP = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x716FFA0", Offset = "0x716F1A0", VA = "0x18716FFA0")]
	private bool PNBMKNKJCON(string EKBBFFMFEOM, bool? OMEGHEHDIOM, bool JEBHMGJFPIP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x716F2B0", Offset = "0x716E4B0", VA = "0x18716F2B0")]
	private bool HHJKFPLIJHM(string HKNBHIFGDLM, bool? OMEGHEHDIOM, bool JEBHMGJFPIP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x716F390", Offset = "0x716E590", VA = "0x18716F390")]
	private void IBCGIAIKLNC(string HKNBHIFGDLM, bool? OMEGHEHDIOM, bool FAKLBLICCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x716EC40", Offset = "0x716DE40", VA = "0x18716EC40")]
	private void CIOEHKCCDEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x716F1C0", Offset = "0x716E3C0", VA = "0x18716F1C0")]
	private void IEHNHAEFEGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum AMLPEGIKABL
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
		public GameObject BFJEOCDJFKI
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1BE6990", Offset = "0x1BE5B90", VA = "0x181BE6990")]
		public void SetVisibility(bool ONKMPCOJFLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1BE6970", Offset = "0x1BE5B70", VA = "0x181BE6970")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x716CB70", Offset = "0x716BD70", VA = "0x18716CB70")]
		public void Initialize(int GFACCAAHJHG, AMLPEGIKABL GCGNIOHLIKK, string JJDGHGFHPLI, Sprite OKPJFPCMAML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x716D1F0", Offset = "0x716C3F0", VA = "0x18716D1F0")]
		public void UpdateVisualElements(Quaternion JNINOMPFCMA, Vector3 ONLMFNGKLOH, float ONBGAIIMDGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x716D0D0", Offset = "0x716C2D0", VA = "0x18716D0D0")]
		private void ODKFIKLPJFB(Color IDDEDDGMNLB, bool EBALJOOCNKG, bool KBDOKGEINBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
		public CoordinationBeaconHUDElement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class CoordinationBeaconRateLimitingFeedbackVisual : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class GDPBCEHBEKH : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CE0", Offset = "0x8F1EE0", VA = "0x1808F2CE0")]
			[DebuggerHidden]
			public GDPBCEHBEKH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x71702A0", Offset = "0x716F4A0", VA = "0x1871702A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x71703C0", Offset = "0x716F5C0", VA = "0x1871703C0", Slot = "8")]
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
		private float OCGNNILOFPI;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x716D3B0", Offset = "0x716C5B0", VA = "0x18716D3B0")]
		public void DisplayRateLimitingFeedbackVisual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x716D450", Offset = "0x716C650", VA = "0x18716D450")]
		[IteratorStateMachine(typeof(GDPBCEHBEKH))]
		private IEnumerator FFFKMFIDMCP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x716D4D0", Offset = "0x716C6D0", VA = "0x18716D4D0")]
		public CoordinationBeaconRateLimitingFeedbackVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class IJLCGOIPDLO : NKBMNLPAHLE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly MEKMCOEEPLL DHGAELFLCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly IDisposable OCNJMBJPACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private bool CGIEGOGPGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool INAOMPMJCBN;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool PMIPAJODMFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8FB0D0", Offset = "0x8FA2D0", VA = "0x1808FB0D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool LCEFBKMJAIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x10E1370", Offset = "0x10E0570", VA = "0x1810E1370", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7170690", Offset = "0x716F890", VA = "0x187170690")]
	[RecRoom.NoEngine.Common.Preserve]
	public IJLCGOIPDLO([FMJHJHHALCB(null)] MEKMCOEEPLL NGAGNLPFNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7170490", Offset = "0x716F690", VA = "0x187170490", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x71704E0", Offset = "0x716F6E0", VA = "0x1871704E0")]
	[NAOGKPPNIGE.AGGBMPJIOLK.IPOKDFJKKKA]
	internal static void EEMNDALIEKO(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7170550", Offset = "0x716F750", VA = "0x187170550", Slot = "6")]
	public void JOIOCKBLCEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7170410", Offset = "0x716F610", VA = "0x187170410", Slot = "7")]
	public bool BDJONMPMBJB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7170560", Offset = "0x716F760", VA = "0x187170560", Slot = "8")]
	public void LLGEBMJIGHK(LJJCDEANBLH JPGPNLNCOHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7170590", Offset = "0x716F790", VA = "0x187170590")]
	private JIKAOKCOAGM MELEDBDKOIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7170420", Offset = "0x716F620", VA = "0x187170420")]
	private void DHGCKFBMJJP(GHIJJJNKODG NCLGMLLDHLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JIGHNMBHOGN : GOFLKIDPNCD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly MEKMCOEEPLL DHGAELFLCDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly IGBBELMMAJJ ANILKNMPABH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly IGBBELMMAJJ PEKPMCMMOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly IDisposable OCNJMBJPACP;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool PPKJBDJBIDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7170810", Offset = "0x716FA10", VA = "0x187170810", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool PJPADJAAHMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7170950", Offset = "0x716FB50", VA = "0x187170950", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7170C20", Offset = "0x716FE20", VA = "0x187170C20")]
	[RecRoom.NoEngine.Common.Preserve]
	public JIGHNMBHOGN([FMJHJHHALCB(null)] MEKMCOEEPLL NGAGNLPFNFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7170890", Offset = "0x716FA90", VA = "0x187170890", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x71708E0", Offset = "0x716FAE0", VA = "0x1871708E0")]
	[NAOGKPPNIGE.AGGBMPJIOLK.IPOKDFJKKKA]
	internal static void EEMNDALIEKO(JBPONICDCIO CKNPDKKKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x71709A0", Offset = "0x716FBA0", VA = "0x1871709A0", Slot = "5")]
	public void IGHPGCKHJFK(IGCCAEFBMNB BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7170B00", Offset = "0x716FD00", VA = "0x187170B00", Slot = "6")]
	public bool PBILJPALHEA(IGCCAEFBMNB BCOHKLCJCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7170AD0", Offset = "0x716FCD0", VA = "0x187170AD0", Slot = "8")]
	public void NCEKIAFHMGI(IGCCAEFBMNB BCOHKLCJCPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7170860", Offset = "0x716FA60", VA = "0x187170860", Slot = "9")]
	public bool DEICLGMDDFP(IGCCAEFBMNB BCOHKLCJCPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x71709D0", Offset = "0x716FBD0", VA = "0x1871709D0")]
	private JIKAOKCOAGM MELEDBDKOIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7170B30", Offset = "0x716FD30", VA = "0x187170B30")]
	private void PJAHPOMBJOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum MLAOAEFJIJF
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	UNKNOWN,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	PARTY,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	TEAM
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KNGNDAPJOPO
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public CoordinationBeacon DNGEPPJLHHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8F4D10", Offset = "0x8F3F10", VA = "0x1808F4D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public CoordinationBeaconHUDElement HOPFBKNGKKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8F2BF0", Offset = "0x8F1DF0", VA = "0x1808F2BF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8FD3B0", Offset = "0x8FC5B0", VA = "0x1808FD3B0")]
	public KNGNDAPJOPO(CoordinationBeacon CAODPHODEDN, CoordinationBeaconHUDElement FPHIELJALNO)
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
