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
		[Cpp2IlInjected.Address(RVA = "0x775D660", Offset = "0x775CA60", VA = "0x18775D660", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x251F7B0", Offset = "0x251EBB0", VA = "0x18251F7B0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[GLPLMFKJAIO("CoordinationBeacons")]
public enum ECDHLMJGCAO
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[NBMEEHHFEBK("You joined a party!", true)]
	JOINED_PARTY_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[NBMEEHHFEBK("You joined a team!", true)]
	JOINED_TEAM_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[NBMEEHHFEBK("Double-tap Screen to place a Beacon.", true)]
	TOUCH_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[NBMEEHHFEBK("Middle-click Mouse to place a Beacon.", true)]
	KBM_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[NBMEEHHFEBK("Double-tap Right Shoulder to place a Beacon.", true)]
	GAMEPAD_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[NBMEEHHFEBK("Point and Tap Main Trigger to place a Beacon.", true)]
	VR_CONTROLS_HEADS_UP_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[NBMEEHHFEBK("What's This?", true)]
	BUTTON_ACCESS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[NBMEEHHFEBK("This is a Beacon", true)]
	THIS_IS_BEACON_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	[NBMEEHHFEBK("Beacons can only be placed by players in a Party or on the same Team.", true)]
	BEACON_RULES_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[NBMEEHHFEBK("Try placing a Beacon of your own!", true)]
	TRY_YOURSELF_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[NBMEEHHFEBK("Double-tap the Screen", true)]
	TOUCH_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[NBMEEHHFEBK("Middle-click the Mouse", true)]
	KBM_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[NBMEEHHFEBK("Double-tap Right Shoulder", true)]
	GAMEPAD_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[NBMEEHHFEBK("Point and Tap Main Trigger", true)]
	VR_CONTROLS_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[NBMEEHHFEBK("once you close the dialogue window.", true)]
	ONCE_CLOSE_DIALOGUE_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[NBMEEHHFEBK("Don't show me again", true)]
	DONT_SHOW_AGAIN_HINT_TUTORIAL,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[NBMEEHHFEBK("Okay!", true)]
	BUTTON_OKAY_HINT_TUTORIAL
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NKOBDOIDLOO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KOHFAPPFOPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GADGHNABACN(MFGNDPBPHLH EDLKANFOKCH, string KPIKPCJOAJM);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EGFJIHEOIPL(Camera HJODJFKAMBL, Vector3 JHFDIBKAPIA);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AKIJBPCPAOK(Camera HJODJFKAMBL, Vector3 JHFDIBKAPIA, CoordinationBeacon JOENAJBOCEB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPLONEENEJD();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ABGJHMJGALH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float LFCHMIMJDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float JABEPNCKHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ADMHGKNJOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool CFLGGBKDHGD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float LGOHJPDKMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float KCFNPFOAJNE
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float ILPBIPJNDHL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float HIKNALLCAJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int ADHNHEMFHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float HJAMGJFPIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float APEPBKEDJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float EJOOIFCEBOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool MDGPEIBPFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool KDGLGJBMPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool BNHFCALIKJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	bool EPJBKACKDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "16")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool DIFOBDFHGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "18")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float NECDKJLJPDN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	bool DBMGLCEDOLF
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool NPFOMDJOIKF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MOLHHOAMLPD();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MIELFIEKKEA
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	List<AKILIHAOJGP> OOEJKEGGILA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<(CoordinationBeacon, CoordinationBeaconHUDElement)> LEGBAMFCMPM(bool POOALFEPJKP);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EABFBAHGLPM(Guid EAFKCPBGEAC, AGAOKNDMPNE.BCKIBCDDGAJ NLFMOEPKCKO);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HIKADKCPJIM(int IMMIKDCGMIH, [Out] CoordinationBeacon FPEJKGPGLHL);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<CoordinationBeaconRateLimitingFeedbackVisual> AHCPNDMMCNL();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NOIIEBIOGKN
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool LBLAMLIIIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	bool DLBBPKACHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JKJMEHGENNL();

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ENAMENGLKEF();

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PGBAHCBHHOE(BPGLDJMOGPH BDAPIDPALOK);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface HINDPMNACPF
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool MMAPCCOEMBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool LANOECCMIDB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AFEDKHBBECH(NIOICMFLLAK HEJFDMJNIGB);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FGKAEBNPGCO(NIOICMFLLAK HEJFDMJNIGB);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DBJKPCOGCNB(NIOICMFLLAK HEJFDMJNIGB);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ICLBCDJKMFO(NIOICMFLLAK HEJFDMJNIGB);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CAKEKAOBOGC
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task GGGBMKDLFMF(Guid EAFKCPBGEAC, int IMMIKDCGMIH, Vector3 AEBECBMNFOC, AIEOBIENGMM PFPNPMCGHHC, string ECEBBPEFLAC, Canvas HAAENCLGDHJ);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INJEDEJJFJP(Guid EAFKCPBGEAC, AGAOKNDMPNE.BCKIBCDDGAJ NLFMOEPKCKO);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OAEHFIPIHEC(int IMMIKDCGMIH, [Out] Guid DMAJMJBHLGP);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CPKCBDJGAAI(Guid EAFKCPBGEAC, [Out] CoordinationBeacon FINELLGHJHD);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KELGCKPNIMN(Vector3 JHFDIBKAPIA, Canvas HAAENCLGDHJ);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KJHJDDBDHMC();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Task GPCIGHGFMGA(Vector3 KODJPIHDPKO);
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
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public AssetReference BeaconHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public AssetReference BeaconVRHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public AssetReference BeaconRateLimitingFeedbackVisualAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x992540", Offset = "0x991940", VA = "0x180992540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public AssetReference BeaconScreensCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x993450", Offset = "0x992850", VA = "0x180993450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public AssetReference BeaconVRCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x993430", Offset = "0x992830", VA = "0x180993430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public AssetReference BeaconAudioSelf
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x993290", Offset = "0x992690", VA = "0x180993290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public AssetReference BeaconAudioOthers
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x993390", Offset = "0x992790", VA = "0x180993390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public AnimationCurve BeaconDropAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x993280", Offset = "0x992680", VA = "0x180993280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public AnimationCurve BeaconDropFromOthersAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x997460", Offset = "0x996860", VA = "0x180997460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float BeaconDropFromOthersAudioMaxDistance
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Color LookAtThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x775B9E0", Offset = "0x775ADE0", VA = "0x18775B9E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Color WatchOutColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x775B9F0", Offset = "0x775ADF0", VA = "0x18775B9F0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Color TakeThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x49BE8F0", Offset = "0x49BDCF0", VA = "0x1849BE8F0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Color ComeHereColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x775B9D0", Offset = "0x775ADD0", VA = "0x18775B9D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Color AllyColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x775B9C0", Offset = "0x775ADC0", VA = "0x18775B9C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x775B980", Offset = "0x775AD80", VA = "0x18775B980")]
		public CoordinationBeaconScriptableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class ILEDMNCGGJL
{
	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static CoordinationBeaconScriptableConfig DMADMDPHOOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x775D030", Offset = "0x775C430", VA = "0x18775D030")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class AGAOKNDMPNE
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum BCKIBCDDGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		EXPIRED,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		REPLACED
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum JLGGLEPEPHG
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		HINT,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		HEADS_UP
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7758A10", Offset = "0x7757E10", VA = "0x187758A10")]
	public static void JHGAAIAKCKC(int OJKFBILBJGP, string HJDIBMMJCFJ, Guid EAFKCPBGEAC, AIEOBIENGMM ANJKCDEKFGI, MFGNDPBPHLH KBBJMFJOEBI, int KAGNKLLDDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x77583D0", Offset = "0x77577D0", VA = "0x1877583D0")]
	public static void AFLJKBAMKDD(int OJKFBILBJGP, string HJDIBMMJCFJ, Guid EAFKCPBGEAC, AIEOBIENGMM ANJKCDEKFGI, float DAJPLHKHAJA, BCKIBCDDGAJ NLFMOEPKCKO, bool COFKDCBDFAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7758DB0", Offset = "0x77581B0", VA = "0x187758DB0")]
	public static void NOCBDIFIMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7758930", Offset = "0x7757D30", VA = "0x187758930")]
	public static void HIHHPGLKBEA(JLGGLEPEPHG FGJOBAOFHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x77587B0", Offset = "0x7757BB0", VA = "0x1877587B0")]
	private static string GMHJJHLAHDP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BGKIDCCOLFJ : NKOBDOIDLOO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct DJKMCFEELOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public BGKIDCCOLFJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x775C990", Offset = "0x775BD90", VA = "0x18775C990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9E0290", Offset = "0x9DF690", VA = "0x1809E0290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly ABGJHMJGALH FBJBFDDMBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly MIELFIEKKEA JAMKFFMLMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly NLHFEIEIHEO JICDKLCJMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly GKJGCHAHLLB MNEDAHDGNNC;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool KOHFAPPFOPM
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9BF180", Offset = "0x9BE580", VA = "0x1809BF180", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9BEF00", Offset = "0x9BE300", VA = "0x1809BEF00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x775AF00", Offset = "0x775A300", VA = "0x18775AF00")]
	[BOBPNFIGGBE.IMBCNFJLKJE.KFPAFMHMBOE]
	internal static void HEACPKLJJEL(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xE0BF60", Offset = "0xE0B360", VA = "0x180E0BF60")]
	[RecRoom.NoEngine.Common.Preserve]
	internal BGKIDCCOLFJ([GKAMHFFOHNI(null)][NotNull] ABGJHMJGALH LHJDHCHOAML, [GKAMHFFOHNI(null)][NotNull] MIELFIEKKEA KPCNGMCGBKN, [GKAMHFFOHNI(null)][NotNull] NLHFEIEIHEO HEPNNPCGNGJ, [GKAMHFFOHNI(null)][NotNull] GKJGCHAHLLB DGBFKMFFNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x775ACF0", Offset = "0x775A0F0", VA = "0x18775ACF0", Slot = "5")]
	public void GADGHNABACN(MFGNDPBPHLH EDLKANFOKCH, string KPIKPCJOAJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x775A7E0", Offset = "0x7759BE0", VA = "0x18775A7E0", Slot = "7")]
	public bool AKIJBPCPAOK(Camera HJODJFKAMBL, Vector3 JHFDIBKAPIA, CoordinationBeacon JOENAJBOCEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x775AAE0", Offset = "0x7759EE0", VA = "0x18775AAE0", Slot = "6")]
	public bool EGFJIHEOIPL(Camera HJODJFKAMBL, Vector3 JHFDIBKAPIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x775AF70", Offset = "0x775A370", VA = "0x18775AF70", Slot = "8")]
	[AsyncStateMachine(typeof(DJKMCFEELOB))]
	public void IPLONEENEJD()
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
		private float FAPLNBKOLFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private bool HHPOGBKLBHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private float IECEGLNLNOO;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Guid PEOBHBKAJCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1CA6C80", Offset = "0x1CA6080", VA = "0x181CA6C80")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xE58DB0", Offset = "0xE581B0", VA = "0x180E58DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int LEEHDFHGNAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x99A8B0", Offset = "0x999CB0", VA = "0x18099A8B0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x99A8C0", Offset = "0x999CC0", VA = "0x18099A8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public AIEOBIENGMM OKKFDMCBBIN
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x5317010", Offset = "0x5316410", VA = "0x185317010")]
			[CompilerGenerated]
			get
			{
				return default(AIEOBIENGMM);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x5317060", Offset = "0x5316460", VA = "0x185317060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public RectTransform KHMFCKFIFIC
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x991DE0", Offset = "0x9911E0", VA = "0x180991DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid, AGAOKNDMPNE.BCKIBCDDGAJ> FLAAOBOFDAD
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x775C410", Offset = "0x775B810", VA = "0x18775C410")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x775C4D0", Offset = "0x775B8D0", VA = "0x18775C4D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x775C390", Offset = "0x775B790", VA = "0x18775C390")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x775BC40", Offset = "0x775B040", VA = "0x18775BC40")]
		public void Initialize(Guid EAFKCPBGEAC, int PLBJFMECLIG, AIEOBIENGMM PFPNPMCGHHC, string ECEBBPEFLAC, Sprite BENDAMEEPCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1E47DD0", Offset = "0x1E471D0", VA = "0x181E47DD0")]
		public void SetVisibility(bool KLLNMACCJDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x1E47DB0", Offset = "0x1E471B0", VA = "0x181E47DB0")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x775C320", Offset = "0x775B720", VA = "0x18775C320")]
		public void SetVisibilityUsernameDepthIgnore(bool KLLNMACCJDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x775C360", Offset = "0x775B760", VA = "0x18775C360")]
		public void StartTimer(float CHBDFDKNCBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x775C370", Offset = "0x775B770", VA = "0x18775C370")]
		public float StopTimer()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x775C2E0", Offset = "0x775B6E0", VA = "0x18775C2E0")]
		private void PDDEKPPLBAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x775BA00", Offset = "0x775AE00", VA = "0x18775BA00")]
		private void HJILODOODPL(Color JDCEHGHGHFE, bool KDMBEDIAAKB, bool MHHGEAEMNOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public CoordinationBeacon()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BBHMICJIMEN : ABGJHMJGALH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private readonly KIKFEAEKMGH NPMLBGBONBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly MDABFMCKPEE KPFIHDKKNOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly HNAFBHEKIKK KOGABMGIMCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private float? AOLPCOJGECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private float? EBLGBLEHCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool? EMDGJEMDEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool? NDAKAALDJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private float? HHBNGLBAMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private float? FBOMJFAKNOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private float? ELELFJNFDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private float? HCBKDLNDFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int? OLELNBPNEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private float? OANKNMODPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private float? CGNCGFILHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private float? OFKCPDDHMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private bool? LIKPAKFMPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7E")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private bool? HICGBCCLLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private bool? IDEGJOAGAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private bool? JLKHIKPACBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private bool? NADBLMDIANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x86")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private bool? GGAFHAEGBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private float? AHPADANKFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private bool? BKPINALCFAJ;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public float LFCHMIMJDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7758E90", Offset = "0x7758290", VA = "0x187758E90", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float JABEPNCKHKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7759E60", Offset = "0x7759260", VA = "0x187759E60", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool ADMHGKNJOMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7759600", Offset = "0x7758A00", VA = "0x187759600", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool CFLGGBKDHGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7759730", Offset = "0x7758B30", VA = "0x187759730", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public float LGOHJPDKMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x775A330", Offset = "0x7759730", VA = "0x18775A330", Slot = "8")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public float KCFNPFOAJNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7758FD0", Offset = "0x77583D0", VA = "0x187758FD0", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public float ILPBIPJNDHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7759270", Offset = "0x7758670", VA = "0x187759270", Slot = "10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float HIKNALLCAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7759190", Offset = "0x7758590", VA = "0x187759190", Slot = "11")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int ADHNHEMFHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7759B70", Offset = "0x7758F70", VA = "0x187759B70", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float HJAMGJFPIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x775A100", Offset = "0x7759500", VA = "0x18775A100", Slot = "13")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float APEPBKEDJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7759C50", Offset = "0x7759050", VA = "0x187759C50", Slot = "14")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public float EJOOIFCEBOF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7759810", Offset = "0x7758C10", VA = "0x187759810", Slot = "15")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool MDGPEIBPFPB
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x77590B0", Offset = "0x77584B0", VA = "0x1877590B0", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool KDGLGJBMPNA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7759D30", Offset = "0x7759130", VA = "0x187759D30", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool BNHFCALIKJL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x77599B0", Offset = "0x7758DB0", VA = "0x1877599B0", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool NPFOMDJOIKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x775A250", Offset = "0x7759650", VA = "0x18775A250", Slot = "25")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool NHNMDKICILE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x77598F0", Offset = "0x7758CF0", VA = "0x1877598F0", Slot = "27")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool EPJBKACKDFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7759E10", Offset = "0x7759210", VA = "0x187759E10", Slot = "28")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7758F70", Offset = "0x7758370", VA = "0x187758F70", Slot = "20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool DIFOBDFHGPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x775A0B0", Offset = "0x77594B0", VA = "0x18775A0B0", Slot = "21")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7759F40", Offset = "0x7759340", VA = "0x187759F40", Slot = "22")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public float NECDKJLJPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7759FA0", Offset = "0x77593A0", VA = "0x187759FA0", Slot = "23")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool DBMGLCEDOLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x77596E0", Offset = "0x7758AE0", VA = "0x1877596E0", Slot = "24")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x775A5C0", Offset = "0x77599C0", VA = "0x18775A5C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public BBHMICJIMEN([GKAMHFFOHNI(null)] KIKFEAEKMGH GOOAHAMPCLE, [GKAMHFFOHNI(null)] MDABFMCKPEE PEBOFMPHIGH, [GKAMHFFOHNI(null)] HNAFBHEKIKK DEOKBGAPBJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7759940", Offset = "0x7758D40", VA = "0x187759940")]
	[BOBPNFIGGBE.FIPHDKCKMAJ.LALHFPBIBCF]
	internal static void HEACPKLJJEL(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7759350", Offset = "0x7758750", VA = "0x187759350", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7758E40", Offset = "0x7758240", VA = "0x187758E40")]
	private void MIEDCIEEADG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7758E30", Offset = "0x7758230", VA = "0x187758E30")]
	private void AKMDFDAFPCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7758E40", Offset = "0x7758240", VA = "0x187758E40")]
	private void EIEHMNBNCLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7758E40", Offset = "0x7758240", VA = "0x187758E40")]
	private void ANIMGOOMPLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x775A1E0", Offset = "0x77595E0", VA = "0x18775A1E0", Slot = "19")]
	public void MOLHHOAMLPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x775A4F0", Offset = "0x77598F0", VA = "0x18775A4F0")]
	private float PPOPDFOLNAO(string POGHOOOMHAM, float? PKLNGDOJLDF, float MBADHELIPJM = 0f)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x775A410", Offset = "0x7759810", VA = "0x18775A410")]
	private bool PPOPDFOLNAO(string POGHOOOMHAM, bool? PKLNGDOJLDF, bool MBADHELIPJM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7759A90", Offset = "0x7758E90", VA = "0x187759A90")]
	private bool IIPPOKLABHO(string LGNKBCEPBMG, bool? PKLNGDOJLDF, bool MBADHELIPJM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7759520", Offset = "0x7758920", VA = "0x187759520")]
	private void EFIAAAFGNEC(string LGNKBCEPBMG, bool? PKLNGDOJLDF, bool CENPJDFMJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7758E40", Offset = "0x7758240", VA = "0x187758E40")]
	private void GEELILLJAOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7758E30", Offset = "0x7758230", VA = "0x187758E30")]
	private void FEGMLLOLBPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum AIEOBIENGMM
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
		public GameObject NGALLEBNPGC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x1E47DD0", Offset = "0x1E471D0", VA = "0x181E47DD0")]
		public void SetVisibility(bool KLLNMACCJDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1E47DB0", Offset = "0x1E471B0", VA = "0x181E47DB0")]
		public bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x775B140", Offset = "0x775A540", VA = "0x18775B140")]
		public void Initialize(int IMMIKDCGMIH, AIEOBIENGMM PFPNPMCGHHC, string ECEBBPEFLAC, Sprite BENDAMEEPCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x775B690", Offset = "0x775AA90", VA = "0x18775B690")]
		public void UpdateVisualElements(Quaternion NHHICJDNNML, Vector3 PFOFJFECKOD, float IODOMLLKMDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x775B020", Offset = "0x775A420", VA = "0x18775B020")]
		private void HJILODOODPL(Color JDCEHGHGHFE, bool KDMBEDIAAKB, bool MHHGEAEMNOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x991330", Offset = "0x990730", VA = "0x180991330")]
		public CoordinationBeaconHUDElement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class CoordinationBeaconRateLimitingFeedbackVisual : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		[CompilerGenerated]
		private sealed class EMJPMOHMPDK : IEnumerator<object>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x996A30", Offset = "0x995E30", VA = "0x180996A30")]
			[DebuggerHidden]
			public EMJPMOHMPDK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x775CEC0", Offset = "0x775C2C0", VA = "0x18775CEC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x775CFE0", Offset = "0x775C3E0", VA = "0x18775CFE0", Slot = "8")]
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
		private float FAPLNBKOLFL;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x775B8D0", Offset = "0x775ACD0", VA = "0x18775B8D0")]
		public void DisplayRateLimitingFeedbackVisual()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x775B850", Offset = "0x775AC50", VA = "0x18775B850")]
		[IteratorStateMachine(typeof(EMJPMOHMPDK))]
		private IEnumerator AIBNDHNJOKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x775B970", Offset = "0x775AD70", VA = "0x18775B970")]
		public CoordinationBeaconRateLimitingFeedbackVisual()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DEOODFLJKDG : NOIIEBIOGKN, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly AHFKEHIEJLO PEEKJHPAMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly IDisposable GIPAEMDKHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private bool CFFNLLBJBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool PFFHIMHKKCP;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool LBLAMLIIIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9932A0", Offset = "0x9926A0", VA = "0x1809932A0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool DLBBPKACHMC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x11CD3A0", Offset = "0x11CC7A0", VA = "0x1811CD3A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x775C810", Offset = "0x775BC10", VA = "0x18775C810")]
	[RecRoom.NoEngine.Common.Preserve]
	public DEOODFLJKDG([GKAMHFFOHNI(null)] AHFKEHIEJLO CDJLLPGBCKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x775C590", Offset = "0x775B990", VA = "0x18775C590", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x775C6F0", Offset = "0x775BAF0", VA = "0x18775C6F0")]
	[BOBPNFIGGBE.FIPHDKCKMAJ.LALHFPBIBCF]
	internal static void HEACPKLJJEL(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x775C760", Offset = "0x775BB60", VA = "0x18775C760", Slot = "6")]
	public void JKJMEHGENNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x775C5E0", Offset = "0x775B9E0", VA = "0x18775C5E0", Slot = "7")]
	public bool ENAMENGLKEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x775C7E0", Offset = "0x775BBE0", VA = "0x18775C7E0", Slot = "8")]
	public void PGBAHCBHHOE(BPGLDJMOGPH BDAPIDPALOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x775C5F0", Offset = "0x775B9F0", VA = "0x18775C5F0")]
	private PNCKNIPBJFF FLPIOBHICOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x775C770", Offset = "0x775BB70", VA = "0x18775C770")]
	private void KBGGHGGGBBB(CFLKKNKAIAK ENLDJALBDNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PCHGCIOPCEP : HINDPMNACPF, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly AHFKEHIEJLO PEEKJHPAMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private readonly EPNCCHIJEIL AFEBOLKNFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly EPNCCHIJEIL HLBPOBNGJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly IDisposable GIPAEMDKHDF;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool MMAPCCOEMBD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x775D420", Offset = "0x775C820", VA = "0x18775D420", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool LANOECCMIDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x775D3D0", Offset = "0x775C7D0", VA = "0x18775D3D0", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x775D470", Offset = "0x775C870", VA = "0x18775D470")]
	[RecRoom.NoEngine.Common.Preserve]
	public PCHGCIOPCEP([GKAMHFFOHNI(null)] AHFKEHIEJLO CDJLLPGBCKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x775D1B0", Offset = "0x775C5B0", VA = "0x18775D1B0", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x775D330", Offset = "0x775C730", VA = "0x18775D330")]
	[BOBPNFIGGBE.FIPHDKCKMAJ.LALHFPBIBCF]
	internal static void HEACPKLJJEL(NPIEGGOELNH PHDMEDCBLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x775D060", Offset = "0x775C460", VA = "0x18775D060", Slot = "5")]
	public void AFEDKHBBECH(NIOICMFLLAK HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x775D200", Offset = "0x775C600", VA = "0x18775D200", Slot = "6")]
	public bool FGKAEBNPGCO(NIOICMFLLAK HEJFDMJNIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x775D180", Offset = "0x775C580", VA = "0x18775D180", Slot = "8")]
	public void DBJKPCOGCNB(NIOICMFLLAK HEJFDMJNIGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x775D3A0", Offset = "0x775C7A0", VA = "0x18775D3A0", Slot = "9")]
	public bool ICLBCDJKMFO(NIOICMFLLAK HEJFDMJNIGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x775D230", Offset = "0x775C630", VA = "0x18775D230")]
	private PNCKNIPBJFF FLPIOBHICOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x775D090", Offset = "0x775C490", VA = "0x18775D090")]
	private void BBOKCKEOCFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum MFGNDPBPHLH
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	UNKNOWN,
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	PARTY,
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	TEAM
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class AKILIHAOJGP
{
	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public CoordinationBeacon IDMIOLKHPNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public CoordinationBeaconHUDElement MIDELGKFGBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x995770", Offset = "0x994B70", VA = "0x180995770")]
	public AKILIHAOJGP(CoordinationBeacon JOENAJBOCEB, CoordinationBeaconHUDElement PFEHEFHBIMP)
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
