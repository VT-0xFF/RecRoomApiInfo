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
		[Cpp2IlInjected.Address(RVA = "0x6F4B930", Offset = "0x6F4AD30", VA = "0x186F4B930", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2200990", Offset = "0x21FFD90", VA = "0x182200990")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[NNDDIKIPBDG("CoordinationBeacons")]
public enum HDHPHNMPCFH
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[CPHAPJPEJPP("You joined a party!", true)]
	JOINED_PARTY_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[CPHAPJPEJPP("You joined a team!", true)]
	JOINED_TEAM_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[CPHAPJPEJPP("Double-tap Screen to place a Beacon.", true)]
	TOUCH_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[CPHAPJPEJPP("Middle-click Mouse to place a Beacon.", true)]
	KBM_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[CPHAPJPEJPP("Double-tap Right Shoulder to place a Beacon.", true)]
	GAMEPAD_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[CPHAPJPEJPP("Point and Tap Main Trigger to place a Beacon.", true)]
	VR_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[CPHAPJPEJPP("What's This?", true)]
	BUTTON_ACCESS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[CPHAPJPEJPP("This is a Beacon", true)]
	THIS_IS_BEACON_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[CPHAPJPEJPP("Beacons can only be placed by players in a Party or on the same Team.", true)]
	BEACON_RULES_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[CPHAPJPEJPP("Try placing a Beacon of your own!", true)]
	TRY_YOURSELF_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[CPHAPJPEJPP("Double-tap the Screen", true)]
	TOUCH_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[CPHAPJPEJPP("Middle-click the Mouse", true)]
	KBM_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[CPHAPJPEJPP("Double-tap Right Shoulder", true)]
	GAMEPAD_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[CPHAPJPEJPP("Point and Tap Main Trigger", true)]
	VR_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[CPHAPJPEJPP("once you close the dialogue window.", true)]
	ONCE_CLOSE_DIALOGUE_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[CPHAPJPEJPP("Don't show me again", true)]
	DONT_SHOW_AGAIN_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[CPHAPJPEJPP("Okay!", true)]
	BUTTON_OKAY_HINT_TUTORIAL
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JGIEOPKOGML
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PMFOMJINNJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNEMJKEINAM(FAKPIOAANKO KEPIDJADJAM, string DPACIIDNKHN);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LACGOHDFFGG(Camera HNKNJAPAGLP, Vector3 OMMPLOAAEHA);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EEHIBHADDNP(Camera HNKNJAPAGLP, Vector3 OMMPLOAAEHA, CoordinationBeacon BGNBPKLHAED);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KLPIEOIJILB();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JMGEGDABJJI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float NIPKELIOPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float CAKJPEOACGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EKKLANEFOHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool BAGCLNAPJJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float NKCKAKBNFLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float ILFBJAFBMGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float OKCOHCMIKJH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float MIHEAJGDLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int NLLINDMBOJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float GAJHPDPCKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float KEKNBDPNGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float ANOKDNOLMDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool GIFPKEDLBKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool AFFDEPFILFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool HFAKOMCJOHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool ALCPMMDKDEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool KBHDEBEAKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float CHOHINLBFDM
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool HJJAEJCHGGD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool OJGPJAGJIOG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MJGDHOFOFMO();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GICJPEPBMOF
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	List<LBHDMJGCJKL> INGDKMAOKED
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<(CoordinationBeacon, CoordinationBeaconHUDElement)> NLAJPABCIDB(bool KMHIOPFKOON);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MHANBGFOBEE(Guid NNGNOHILKKI, DAMJCOGENFK.NNBLKMEHDNJ HDCNEAGPDKP);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BPNEHALHPNN(int IHAILIKJFGO, [Out] CoordinationBeacon FGOBNJNMFDF);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<CoordinationBeaconRateLimitingFeedbackVisual> GNFDDGCLDFP();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface DKPLBLCCLMK
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool JOIAINAFIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool GPKDKNPFBKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFPOCBACHMF(PALGLKMIOIC CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HBPPDBMOEIO(PALGLKMIOIC CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MAOHMCMNFKC(PALGLKMIOIC CMNJCPJBHGE);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GPPEPOIFJKB(PALGLKMIOIC CMNJCPJBHGE);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface KDDJIPDAOFM
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task LCDPAJBKCPA(Guid NNGNOHILKKI, int IHAILIKJFGO, Vector3 DNBJCJJOBKP, OOMBIMNPNEE NOIHGGNEIML, string MMNDGHPNBHC);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CKKFJDMJPBN(Guid NNGNOHILKKI, DAMJCOGENFK.NNBLKMEHDNJ HDCNEAGPDKP);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CODCMNGFKKA(int IHAILIKJFGO, [Out] Guid PIAAPLIJEJM);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AAGHJLDJHDE(Guid NNGNOHILKKI, [Out] CoordinationBeacon KMGCLHFODJH);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IOHGMOAAIPA(Vector3 OMMPLOAAEHA);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PLPJGAMMFIO();

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task DCBFGCENJMM(Vector3 PBCCBCFFMLG);
}
namespace CoordinateBeacons.Configs
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
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
		[Header("Audio")]
		[Tooltip("Audio that plays when the local player drops a beacon")]
		[SerializeField]
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

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public AssetReference BeaconPrefabAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public AssetReference BeaconHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public AssetReference BeaconVRHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8C7960", Offset = "0x8C6D60", VA = "0x1808C7960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public AssetReference BeaconRateLimitingFeedbackVisualAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8C8C70", Offset = "0x8C8070", VA = "0x1808C8C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public AssetReference BeaconScreensCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8C7970", Offset = "0x8C6D70", VA = "0x1808C7970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public AssetReference BeaconVRCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DA0", Offset = "0x8C71A0", VA = "0x1808C7DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AssetReference BeaconAudioSelf
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8CFA80", Offset = "0x8CEE80", VA = "0x1808CFA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public AssetReference BeaconAudioOthers
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8CAEF0", Offset = "0x8CA2F0", VA = "0x1808CAEF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public AnimationCurve BeaconDropAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8CAEC0", Offset = "0x8CA2C0", VA = "0x1808CAEC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public AnimationCurve BeaconDropFromOthersAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8CAEE0", Offset = "0x8CA2E0", VA = "0x1808CAEE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float BeaconDropFromOthersAudioMaxDistance
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8E1EF0", Offset = "0x8E12F0", VA = "0x1808E1EF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Color LookAtThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F47570", Offset = "0x6F46970", VA = "0x186F47570")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Color WatchOutColor
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6F47580", Offset = "0x6F46980", VA = "0x186F47580")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Color TakeThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x47AE330", Offset = "0x47AD730", VA = "0x1847AE330")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Color ComeHereColor
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6F47560", Offset = "0x6F46960", VA = "0x186F47560")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color AllyColor
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xF0C860", Offset = "0xF0BC60", VA = "0x180F0C860")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6F47520", Offset = "0x6F46920", VA = "0x186F47520")]
		public CoordinationBeaconScriptableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class IFOMBNEJOAE
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static CoordinationBeaconScriptableConfig ELEBKANKHDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6F4A4E0", Offset = "0x6F498E0", VA = "0x186F4A4E0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DAMJCOGENFK
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum NNBLKMEHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		EXPIRED,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		REPLACED
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum MJGNCBOKFBL
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		HINT,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		HEADS_UP
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F484C0", Offset = "0x6F478C0", VA = "0x186F484C0")]
	public static void JPAFEFNBNNN(int HKJDGEGEECN, string MMLMEBBLIGH, Guid NNGNOHILKKI, OOMBIMNPNEE DPPKFNOFMMH, FAKPIOAANKO MJNCLALCACF, int OAAPMMECCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F480E0", Offset = "0x6F474E0", VA = "0x186F480E0")]
	public static void DBDOKJIBCBG(int HKJDGEGEECN, string MMLMEBBLIGH, Guid NNGNOHILKKI, OOMBIMNPNEE DPPKFNOFMMH, float LNPPJCHOHDI, NNBLKMEHDNJ HDCNEAGPDKP, bool EPIBJNOPNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F48AB0", Offset = "0x6F47EB0", VA = "0x186F48AB0")]
	public static void OLCGDBIGNGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F489D0", Offset = "0x6F47DD0", VA = "0x186F489D0")]
	public static void OKCFLEINNGJ(MJGNCBOKFBL FEPHMBAFAOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F48860", Offset = "0x6F47C60", VA = "0x186F48860")]
	private static string LAADNILLGCL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JGDLBEGDFEJ : JGIEOPKOGML
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct PEFJEPKLIAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public JGDLBEGDFEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B420", Offset = "0x6F4A820", VA = "0x186F4B420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x926A70", Offset = "0x925E70", VA = "0x180926A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly JMGEGDABJJI FGGMGLDKDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly GICJPEPBMOF GBICLNEAEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly DPBNAKNNKND ALFJLEADCGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly NPPHKAMEHEP KCHMFBPLDCC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool PMFOMJINNJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8F4100", Offset = "0x8F3500", VA = "0x1808F4100", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8F3F20", Offset = "0x8F3320", VA = "0x1808F3F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F4ACE0", Offset = "0x6F4A0E0", VA = "0x186F4ACE0")]
	[AGCFNMIICNN.EOJADANDAPN.IGDNFKFONFM]
	internal static void MHHLPLPPGCP(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0xB5C7A0", Offset = "0xB5BBA0", VA = "0x180B5C7A0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal JGDLBEGDFEJ([CNGCCDLPGOD(null)][NotNull] JMGEGDABJJI LPBIEIMNLJF, [CNGCCDLPGOD(null)][NotNull] GICJPEPBMOF FLCAMEGHKBH, [CNGCCDLPGOD(null)][NotNull] DPBNAKNNKND CNADODAPMKL, [CNGCCDLPGOD(null)][NotNull] NPPHKAMEHEP CKMJLCMLPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A810", Offset = "0x6F49C10", VA = "0x186F4A810", Slot = "5")]
	public void JNEMJKEINAM(FAKPIOAANKO KEPIDJADJAM, string DPACIIDNKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A510", Offset = "0x6F49910", VA = "0x186F4A510", Slot = "7")]
	public bool EEHIBHADDNP(Camera HNKNJAPAGLP, Vector3 OMMPLOAAEHA, CoordinationBeacon BGNBPKLHAED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AAD0", Offset = "0x6F49ED0", VA = "0x186F4AAD0", Slot = "6")]
	public bool LACGOHDFFGG(Camera HNKNJAPAGLP, Vector3 OMMPLOAAEHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AA20", Offset = "0x6F49E20", VA = "0x186F4AA20", Slot = "8")]
	[AsyncStateMachine(typeof(PEFJEPKLIAE))]
	public void KLPIEOIJILB()
	{
	}
}
namespace CoordinateBeacons.Concretes
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
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
		private float IJJBIHIGGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private bool AGNBHKKCNEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private float CCFPFFCDKPC;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Guid ODDAFMAOMHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x17E6B10", Offset = "0x17E5F10", VA = "0x1817E6B10")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF50", Offset = "0xB1C350", VA = "0x180B1CF50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public int BBFAPNFHJEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8CFB00", Offset = "0x8CEF00", VA = "0x1808CFB00")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8CFB30", Offset = "0x8CEF30", VA = "0x1808CFB30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public OOMBIMNPNEE NLOFPLJHNIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4CC3810", Offset = "0x4CC2C10", VA = "0x184CC3810")]
			[CompilerGenerated]
			get
			{
				return default(OOMBIMNPNEE);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4CC3860", Offset = "0x4CC2C60", VA = "0x184CC3860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public RectTransform FKODCMMAENM
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid, DAMJCOGENFK.NNBLKMEHDNJ> IDJANJLPAPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6F47F60", Offset = "0x6F47360", VA = "0x186F47F60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6F48020", Offset = "0x6F47420", VA = "0x186F48020")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6F47EE0", Offset = "0x6F472E0", VA = "0x186F47EE0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6F477D0", Offset = "0x6F46BD0", VA = "0x186F477D0")]
		public void Initialize(Guid NNGNOHILKKI, int GDGLKIOOCIH, OOMBIMNPNEE NOIHGGNEIML, string MMNDGHPNBHC, Sprite IMNAKECOMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x19AE710", Offset = "0x19ADB10", VA = "0x1819AE710")]
		public void SetVisibility(bool NNHBLAAAHHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x19AE6F0", Offset = "0x19ADAF0", VA = "0x1819AE6F0")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1865A70", Offset = "0x1864E70", VA = "0x181865A70")]
		public void SetVisibilityUsernameDepthIgnore(bool NNHBLAAAHHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6F47EB0", Offset = "0x6F472B0", VA = "0x186F47EB0")]
		public void StartTimer(float KCKAAMKNFON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6F47EC0", Offset = "0x6F472C0", VA = "0x186F47EC0")]
		public float StopTimer()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6F47E70", Offset = "0x6F47270", VA = "0x186F47E70")]
		private void LGLGLJGEJBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6F47590", Offset = "0x6F46990", VA = "0x186F47590")]
		private void CANPFNGNKKF(Color KKOLGPJIEJO, bool CFEKINDLCDN, bool DAPKJMHCLLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
		public CoordinationBeacon()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GPPCCKCOIPO : JMGEGDABJJI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly AJCHOFIOKBP AHABIKIGDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly GMAGBLHDHPN MOCKAFDGFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly PBMDMFNAGKG EFGMGAAKBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private float? FDGEALOELEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private float? CCKGDLFGEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool? DDCINBEPNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool? COHBBLANHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float? DPNJLJKEJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private float? LCMOIACIPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private float? NPKIIIPNOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private float? EEEEBODLING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int? AEPCFLPJCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float? DPLEPLCCCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private float? GNHNGLONGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private float? APOPBFJMCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private bool? FECNFJBDFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7E")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool? KCCMNOKOLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool? LOOMMEDHAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool? JLBOJHMMBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private bool? EBNELECJGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x86")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private bool? OHHHLOJGIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float? EIGAGEMFHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool? ANGKMHGLEGD;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public float NIPKELIOPEE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6F49B20", Offset = "0x6F48F20", VA = "0x186F49B20", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public float CAKJPEOACGH
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6F49080", Offset = "0x6F48480", VA = "0x186F49080", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool EKKLANEFOHO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6F49790", Offset = "0x6F48B90", VA = "0x186F49790", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool BAGCLNAPJJC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6F49580", Offset = "0x6F48980", VA = "0x186F49580", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public float NKCKAKBNFLE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6F4A100", Offset = "0x6F49500", VA = "0x186F4A100", Slot = "8")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public float ILFBJAFBMGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6F496B0", Offset = "0x6F48AB0", VA = "0x186F496B0", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public float OKCOHCMIKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6F4A1E0", Offset = "0x6F495E0", VA = "0x186F4A1E0", Slot = "10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public float MIHEAJGDLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6F49950", Offset = "0x6F48D50", VA = "0x186F49950", Slot = "11")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int NLLINDMBOJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6F48D80", Offset = "0x6F48180", VA = "0x186F48D80", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float GAJHPDPCKKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6F49870", Offset = "0x6F48C70", VA = "0x186F49870", Slot = "13")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float KEKNBDPNGDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6F49CE0", Offset = "0x6F490E0", VA = "0x186F49CE0", Slot = "14")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float ANOKDNOLMDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6F49160", Offset = "0x6F48560", VA = "0x186F49160", Slot = "15")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool GIFPKEDLBKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6F49DC0", Offset = "0x6F491C0", VA = "0x186F49DC0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool AFFDEPFILFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6F49440", Offset = "0x6F48840", VA = "0x186F49440", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool HFAKOMCJOHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6F48B30", Offset = "0x6F47F30", VA = "0x186F48B30", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool OJGPJAGJIOG
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6F49EF0", Offset = "0x6F492F0", VA = "0x186F49EF0", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool BOMGJPLFEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6F4A0B0", Offset = "0x6F494B0", VA = "0x186F4A0B0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool ALCPMMDKDEA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6F493F0", Offset = "0x6F487F0", VA = "0x186F493F0", Slot = "28")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6F49520", Offset = "0x6F48920", VA = "0x186F49520", Slot = "20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool KBHDEBEAKCB
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6F49EA0", Offset = "0x6F492A0", VA = "0x186F49EA0", Slot = "21")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6F48C10", Offset = "0x6F48010", VA = "0x186F48C10", Slot = "22")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public float CHOHINLBFDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6F48C70", Offset = "0x6F48070", VA = "0x186F48C70", Slot = "23")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool HJJAEJCHGGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6F49030", Offset = "0x6F48430", VA = "0x186F49030", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A2C0", Offset = "0x6F496C0", VA = "0x186F4A2C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GPPCCKCOIPO([CNGCCDLPGOD(null)] AJCHOFIOKBP OMPDJEGMEOI, [CNGCCDLPGOD(null)] GMAGBLHDHPN DEMMBCNAAKG, [CNGCCDLPGOD(null)] PBMDMFNAGKG HNNOIAANPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F49C00", Offset = "0x6F49000", VA = "0x186F49C00")]
	[AGCFNMIICNN.HNNLCOLGEGD.DNCHPFJACPB]
	internal static void MHHLPLPPGCP(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F48E60", Offset = "0x6F48260", VA = "0x186F48E60", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F49660", Offset = "0x6F48A60", VA = "0x186F49660")]
	private void KCJBBIINCCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6F49B10", Offset = "0x6F48F10", VA = "0x186F49B10")]
	private void LOCEKBPOPAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6F49660", Offset = "0x6F48A60", VA = "0x186F49660")]
	private void PNDJPGMLMIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6F49660", Offset = "0x6F48A60", VA = "0x186F49660")]
	private void PIGFJOGHJDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F49C70", Offset = "0x6F49070", VA = "0x186F49C70", Slot = "19")]
	public void MJGDHOFOFMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6F49320", Offset = "0x6F48720", VA = "0x186F49320")]
	private float GCKFJGFKCNJ(string AALJBEMLBMB, float? NFLJFBPCDLL, float EKFBHIJFHMA = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6F49240", Offset = "0x6F48640", VA = "0x186F49240")]
	private bool GCKFJGFKCNJ(string AALJBEMLBMB, bool? NFLJFBPCDLL, bool EKFBHIJFHMA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6F49A30", Offset = "0x6F48E30", VA = "0x186F49A30")]
	private bool LMDOBGHGLAJ(string CJJLPOAPEFD, bool? NFLJFBPCDLL, bool EKFBHIJFHMA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6F49FD0", Offset = "0x6F493D0", VA = "0x186F49FD0")]
	private void NKBFFPCIFOO(string CJJLPOAPEFD, bool? NFLJFBPCDLL, bool CNBOFDKAIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6F49660", Offset = "0x6F48A60", VA = "0x186F49660")]
	private void LPCGAJDPFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6F49B10", Offset = "0x6F48F10", VA = "0x186F49B10")]
	private void MIOIFIGGKNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum OOMBIMNPNEE
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
	[Cpp2IlInjected.Token(Token = "0x2000013")]
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

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public GameObject CCMBLHBOBMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x19AE710", Offset = "0x19ADB10", VA = "0x1819AE710")]
		public void SetVisibility(bool NNHBLAAAHHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x19AE6F0", Offset = "0x19ADAF0", VA = "0x1819AE6F0")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6F46CE0", Offset = "0x6F460E0", VA = "0x186F46CE0")]
		public void Initialize(int IHAILIKJFGO, OOMBIMNPNEE NOIHGGNEIML, string MMNDGHPNBHC, Sprite IMNAKECOMIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F47230", Offset = "0x6F46630", VA = "0x186F47230")]
		public void UpdateVisualElements(Quaternion FDBGJNNMHBO, Vector3 ENJPHPPLHAI, float OMAHLMEHPLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6F46BC0", Offset = "0x6F45FC0", VA = "0x186F46BC0")]
		private void CANPFNGNKKF(Color KKOLGPJIEJO, bool CFEKINDLCDN, bool DAPKJMHCLLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
		public CoordinationBeaconHUDElement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class CoordinationBeaconRateLimitingFeedbackVisual : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class AHEKCNMOGAC : IEnumerator<object>, IEnumerator, IDisposable
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

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000096")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
			[DebuggerHidden]
			public AHEKCNMOGAC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x6F46A50", Offset = "0x6F45E50", VA = "0x186F46A50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6F46B70", Offset = "0x6F45F70", VA = "0x186F46B70", Slot = "8")]
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
		private float IJJBIHIGGOA;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F473F0", Offset = "0x6F467F0", VA = "0x186F473F0")]
		public void DisplayRateLimitingFeedbackVisual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F47490", Offset = "0x6F46890", VA = "0x186F47490")]
		[IteratorStateMachine(typeof(AHEKCNMOGAC))]
		private IEnumerator MNNJMFFBOIP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F47510", Offset = "0x6F46910", VA = "0x186F47510")]
		public CoordinationBeaconRateLimitingFeedbackVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class NIPFNNJHBAJ : DKPLBLCCLMK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly CBKPLBJIJFB NMAGJHBNMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly IMPNODMCNME EBACLPNDMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly IMPNODMCNME PFKMHNDFBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly IDisposable HCMGBJCFLNC;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool JOIAINAFIEC
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6F4AEF0", Offset = "0x6F4A2F0", VA = "0x186F4AEF0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool GPKDKNPFBKD
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6F4B0A0", Offset = "0x6F4A4A0", VA = "0x186F4B0A0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B1C0", Offset = "0x6F4A5C0", VA = "0x186F4B1C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public NIPFNNJHBAJ([CNGCCDLPGOD(null)] CBKPLBJIJFB JNPEEDEABBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AE40", Offset = "0x6F4A240", VA = "0x186F4AE40", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B120", Offset = "0x6F4A520", VA = "0x186F4B120")]
	[AGCFNMIICNN.HNNLCOLGEGD.DNCHPFJACPB]
	internal static void MHHLPLPPGCP(CGJHFFGEHKC CLDCJHAFFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B190", Offset = "0x6F4A590", VA = "0x186F4B190", Slot = "5")]
	public void NFPOCBACHMF(PALGLKMIOIC CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B070", Offset = "0x6F4A470", VA = "0x186F4B070", Slot = "6")]
	public bool HBPPDBMOEIO(PALGLKMIOIC CMNJCPJBHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B0F0", Offset = "0x6F4A4F0", VA = "0x186F4B0F0", Slot = "8")]
	public void MAOHMCMNFKC(PALGLKMIOIC CMNJCPJBHGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B040", Offset = "0x6F4A440", VA = "0x186F4B040", Slot = "9")]
	public bool GPPEPOIFJKB(PALGLKMIOIC CMNJCPJBHGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AF40", Offset = "0x6F4A340", VA = "0x186F4AF40")]
	private ELGDDGNBNAM GFBLENEEHHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AD50", Offset = "0x6F4A150", VA = "0x186F4AD50")]
	private void BHAFEJPDMHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum FAKPIOAANKO
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	UNKNOWN,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	PARTY,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	TEAM
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LBHDMJGCJKL
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public CoordinationBeacon BFCBDANEGAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public CoordinationBeaconHUDElement MMDAMIMPHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8D5E30", Offset = "0x8D5230", VA = "0x1808D5E30")]
	public LBHDMJGCJKL(CoordinationBeacon BGNBPKLHAED, CoordinationBeaconHUDElement KIKDNBFOOHF)
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
