using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CoordinateBeacons.Concretes;
using CoordinateBeacons.Configs;
using Cpp2IlInjected;
using RRUI;
using RecRoom.Configs;
using RecRoom.DataLayer.Attributes;
using RecRoom.NoEngine.Common;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_CoordinateBeacons_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : JFBHLNBAFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6BB60F0", Offset = "0x6BB52F0", VA = "0x186BB60F0", Slot = "8")]
		public override void KGHJDOOILCG(KCABLKMBKAN registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63262B0", Offset = "0x63254B0", VA = "0x1863262B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace CoordinateBeacons.Configs
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class CoordinationBeaconScriptableConfig : SingletonScriptableObject<CoordinationBeaconScriptableConfig>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private AssetReference _beaconPrefabAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private AssetReference beaconScreensCanvasAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private AssetReference beaconHUDElementAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private AssetReference beaconAudioSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private AssetReference beaconAudioOthers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private AnimationCurve beaconDropAudioCustomRolloff;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private Sprite lookAtThisSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private Sprite watchOutSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private Sprite takeThisSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private Color lookAtThisColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private Color watchOutColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		[SerializeField]
		private Color takeThisColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private Color comeHereColor;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public AssetReference BeaconPrefabAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public AssetReference BeaconScreensCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public AssetReference BeaconHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x894500", Offset = "0x893700", VA = "0x180894500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AssetReference BeaconAudioSelf
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public AssetReference BeaconAudioOthers
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8942D0", Offset = "0x8934D0", VA = "0x1808942D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AnimationCurve BeaconDropAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8942E0", Offset = "0x8934E0", VA = "0x1808942E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Sprite LookAtThisSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x894340", Offset = "0x893540", VA = "0x180894340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Sprite WatchOutSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x894480", Offset = "0x893680", VA = "0x180894480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Sprite TakeThisSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x894310", Offset = "0x893510", VA = "0x180894310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Color LookAtThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9C7490", Offset = "0x9C6690", VA = "0x1809C7490")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Color WatchOutColor
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x4818470", Offset = "0x4817670", VA = "0x184818470")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Color TakeThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x173DD60", Offset = "0x173CF60", VA = "0x18173DD60")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Color ComeHereColor
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x98E3C0", Offset = "0x98D5C0", VA = "0x18098E3C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1BE0", Offset = "0x6BB0DE0", VA = "0x186BB1BE0")]
		public CoordinationBeaconScriptableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class BADIILNGOGF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static CoordinationBeaconScriptableConfig FAKOKDPOOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1360", Offset = "0x6BB0560", VA = "0x186BB1360")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LLMAFIGGHAN
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	List<JANCLLDKAFO.FJHNFAMGJNK> OHMNBDPHHMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<(CoordinationBeacon, CoordinationBeaconHUDElement)> ADEIFEIEACI();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DGKJJPNNOIA(Guid GBBODKPKLHB);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HGPIIINEFCD(int BLDHLOIAKIM, [Out] CoordinationBeacon NFMOJHMNNHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LLIOGMHGFAA
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float AJJBIAOABNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float HGGOCACICBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool PCBJGNFLAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float KAMECNECMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	float HIBFPJEPMAG
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GFAIIBNLHFC
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DropBeacon(Guid GBBODKPKLHB, int BLDHLOIAKIM, Vector3 GFFHHEBCBKP, MAGOBKCOEPN GFIAFOEJCDD, string KBNMEIKBHAG);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RemoveBeacon(Guid GBBODKPKLHB);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PlayerHasActiveBeacon(int BLDHLOIAKIM, [Out] Guid PEBKLEAHBOO);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void UpdateAllBeaconUIElements(Vector3 KJHIGOLEMCB);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HideAllHUDElements();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetVisibilityBeaconUsernameDepthIgnore(bool MJNCHDMKLIA);
}
namespace CoordinateBeacons.Concretes
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class CoordinationBeacon : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private GameObject visualRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private RectTransform rootRect;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private RecNetRawImage recNetImageRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private RecNetRawImage recNetImageDepthIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private Image recNetImageBaseCircleImageRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private Image recNetImageBaseCircleImageDepthIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Material depthIgnoreMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private TextMeshPro accountTMPRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private TextMeshPro accountTMPDepthIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private Image iconRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private Image iconDepthIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private Image directionalArrowRegular;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private Image directionalArrowDepthIgnore;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float CCKGHMJLAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool LIGCCDIGMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private float KFGHPMMIEAO;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Guid CCBOBDNNGDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x173DD60", Offset = "0x173CF60", VA = "0x18173DD60")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA21CB0", Offset = "0xA20EB0", VA = "0x180A21CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int EHHMLLEHBED
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8A2560", Offset = "0x8A1760", VA = "0x1808A2560")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8A23E0", Offset = "0x8A15E0", VA = "0x1808A23E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public MAGOBKCOEPN HNIDMBLCBJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4AD0380", Offset = "0x4ACF580", VA = "0x184AD0380")]
			[CompilerGenerated]
			get
			{
				return default(MAGOBKCOEPN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4AD03D0", Offset = "0x4ACF5D0", VA = "0x184AD03D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public RectTransform CMHIDEANHEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid> POCCCMHBEMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6BB3B20", Offset = "0x6BB2D20", VA = "0x186BB3B20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6BB3BE0", Offset = "0x6BB2DE0", VA = "0x186BB3BE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3AA0", Offset = "0x6BB2CA0", VA = "0x186BB3AA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3340", Offset = "0x6BB2540", VA = "0x186BB3340")]
		public void Initialize(Guid GBBODKPKLHB, int BAILIOHFNPP, MAGOBKCOEPN GFIAFOEJCDD, string KBNMEIKBHAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x18933B0", Offset = "0x18925B0", VA = "0x1818933B0")]
		public void SetVisibility(bool MJNCHDMKLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x179A630", Offset = "0x1799830", VA = "0x18179A630")]
		public void SetVisibilityUsernameDepthIgnore(bool MJNCHDMKLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3A70", Offset = "0x6BB2C70", VA = "0x186BB3A70")]
		public void StartTimer(float KPBLIEPEDDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3A80", Offset = "0x6BB2C80", VA = "0x186BB3A80")]
		public void StopTimer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3A20", Offset = "0x6BB2C20", VA = "0x186BB3A20")]
		private void OGJDEJMFBCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6BB3100", Offset = "0x6BB2300", VA = "0x186BB3100")]
		private void FAKMKKCJAEG(Color KLEKKBBGJDG, bool OECMKJPKGML, bool GEKJMOCONAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8966A0", Offset = "0x8958A0", VA = "0x1808966A0")]
		public CoordinationBeacon()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PCCPPLGKHIA : LLIOGMHGFAA
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static ILGPNHEOFNI BPNGGOHGOND;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float AJJBIAOABNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5EE0", Offset = "0x6BB50E0", VA = "0x186BB5EE0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public float HGGOCACICBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5D70", Offset = "0x6BB4F70", VA = "0x186BB5D70", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool PCBJGNFLAKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5F60", Offset = "0x6BB5160", VA = "0x186BB5F60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float KAMECNECMHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5CF0", Offset = "0x6BB4EF0", VA = "0x186BB5CF0", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public float HIBFPJEPMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5E60", Offset = "0x6BB5060", VA = "0x186BB5E60", Slot = "8")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6BB6080", Offset = "0x6BB5280", VA = "0x186BB6080")]
	[RecRoom.NoEngine.Common.Preserve]
	public PCCPPLGKHIA([GEFLINBOFNF(null)] ILGPNHEOFNI KLIMJCHPKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5DF0", Offset = "0x6BB4FF0", VA = "0x186BB5DF0")]
	[NPIOOMADHDK.ICBCOBDLNNE.HFJMLJLJJPC]
	internal static void GLGGBEPLOGP(KHAIBIPGEJP DDIEINIMBGH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum MAGOBKCOEPN
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	LOOK_AT_THIS,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	COME_HERE,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	WATCH_OUT_RRO_ENEMY,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	WATCH_OUT_PLAYER_ENEMY,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	TAKE_THIS
}
namespace CoordinateBeacons.Concretes
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class CoordinationBeaconHUDElement : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		private GameObject visualRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		private Transform chevronRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private RectTransform rootRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private RecNetRawImage recNetRawImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private Image recNetImageRootMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private TextMeshProUGUI distanceText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		private TextMeshProUGUI usernameText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private Image iconImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private Image directionalIcon;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x18933B0", Offset = "0x18925B0", VA = "0x1818933B0")]
		public void SetVisibility(bool MJNCHDMKLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB14B0", Offset = "0x6BB06B0", VA = "0x186BB14B0")]
		public void Initialize(int BLDHLOIAKIM, MAGOBKCOEPN GFIAFOEJCDD, string KBNMEIKBHAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1A20", Offset = "0x6BB0C20", VA = "0x186BB1A20")]
		public void UpdateVisualElements(Quaternion HFOHKFIHFEO, Vector3 KMEEFLDIFOK, float CGIBKDGBJOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1390", Offset = "0x6BB0590", VA = "0x186BB1390")]
		private void FAKMKKCJAEG(Color KLEKKBBGJDG, bool OECMKJPKGML, bool GEKJMOCONAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8966A0", Offset = "0x8958A0", VA = "0x1808966A0")]
		public CoordinationBeaconHUDElement()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class JANCLLDKAFO : LLMAFIGGHAN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class FJHNFAMGJNK
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public CoordinationBeacon OCIEGLDMHBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public CoordinationBeaconHUDElement GOGLPCEIOII
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8A2310", Offset = "0x8A1510", VA = "0x1808A2310")]
		public FJHNFAMGJNK(CoordinationBeacon EHLBEBCPKOE, CoordinationBeaconHUDElement JNIMFJKBPOM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct HPAEHGHKLGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<(CoordinationBeacon, CoordinationBeaconHUDElement)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public JANCLLDKAFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private CoordinationBeacon <retrievedBeacon>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private AssetReference <beaconHUDElementAssetReference>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6BB41D0", Offset = "0x6BB33D0", VA = "0x186BB41D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6BB4A70", Offset = "0x6BB3C70", VA = "0x186BB4A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class LAINIAJLPOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Guid beaconId;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public LAINIAJLPOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6BB5C30", Offset = "0x6BB4E30", VA = "0x186BB5C30")]
		internal bool ALHDHOCIPHN(FJHNFAMGJNK pooledBeacon)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly LLIOGMHGFAA DBJONHHIEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private List<FJHNFAMGJNK> ONFBFKMMLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private List<FJHNFAMGJNK> HBLBPPBHBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly List<NMANDIAIDGE<GameObject>> BLIEDFAPGEO;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private List<FJHNFAMGJNK> BOPNIMGHANE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8942A0", Offset = "0x8934A0", VA = "0x1808942A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5900", Offset = "0x6BB4B00", VA = "0x186BB5900")]
	[NPIOOMADHDK.EDMEHGENIAN.LGDDIMADCKH]
	internal static void GLGGBEPLOGP(KHAIBIPGEJP DDIEINIMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5B00", Offset = "0x6BB4D00", VA = "0x186BB5B00")]
	[RecRoom.NoEngine.Common.Preserve]
	public JANCLLDKAFO([GEFLINBOFNF(null)] LLIOGMHGFAA NDAEOGONMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5220", Offset = "0x6BB4420", VA = "0x186BB5220", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4E90", Offset = "0x6BB4090", VA = "0x186BB4E90", Slot = "5")]
	[AsyncStateMachine(typeof(HPAEHGHKLGE))]
	public Task<(CoordinationBeacon, CoordinationBeaconHUDElement)> ADEIFEIEACI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6BB4F90", Offset = "0x6BB4190", VA = "0x186BB4F90", Slot = "6")]
	public void DGKJJPNNOIA(Guid GBBODKPKLHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5970", Offset = "0x6BB4B70", VA = "0x186BB5970", Slot = "7")]
	public bool HGPIIINEFCD(int BLDHLOIAKIM, [Out] CoordinationBeacon NFMOJHMNNHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6BB5830", Offset = "0x6BB4A30", VA = "0x186BB5830")]
	private bool EAOMJGJFBCB([Out] FJHNFAMGJNK AKHPCPDJAGN, [Out] int BDDODOGLHBK)
	{
		return default(bool);
	}
}
namespace CoordinateBeacons.Concretes
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CoordinationBeaconVisualManager : MonoBehaviour, GFAIIBNLHFC, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct HJCKNKALCBD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public CoordinationBeaconVisualManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public Guid beaconId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public int ownerRecNetAccountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public MAGOBKCOEPN context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public string username;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public Vector3 worldSpacePosition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private TaskAwaiter<(CoordinationBeacon, CoordinationBeaconHUDElement)> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6BB3CA0", Offset = "0x6BB2EA0", VA = "0x186BB3CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6BB4170", Offset = "0x6BB3370", VA = "0x186BB4170", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct IIMKFJNHEAH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public CoordinationBeaconVisualManager <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6BB4AE0", Offset = "0x6BB3CE0", VA = "0x186BB4AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6BB4E30", Offset = "0x6BB4030", VA = "0x186BB4E30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly LLIOGMHGFAA DBJONHHIEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly LLMAFIGGHAN LNHCPJLCHKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly GGHNOHPFCDJ BLDPKHAIADC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly float MKLEACPOPBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly float BBGGACCNDBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly float GNEAOAMGCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly float FCGCADGKDPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly Vector3 HDHFNKDGNLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private GameObject NKLHCPCGBNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Canvas BIIPAKAOAMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private NMANDIAIDGE<GameObject> FBCLCNKJMLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Vector3[] OJEMCIJMCHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Vector3 OEOKBOOCEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly float MCIHHHHCCLG;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1E30", Offset = "0x6BB1030", VA = "0x186BB1E30")]
		[NPIOOMADHDK.EDMEHGENIAN.LGDDIMADCKH]
		internal static void GLGGBEPLOGP(KHAIBIPGEJP DDIEINIMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2EF0", Offset = "0x6BB20F0", VA = "0x186BB2EF0")]
		[RecRoom.NoEngine.Common.Preserve]
		public CoordinationBeaconVisualManager([GEFLINBOFNF(null)] LLIOGMHGFAA NDAEOGONMPN, [GEFLINBOFNF(null)] LLMAFIGGHAN NECNAPODLFC, [GEFLINBOFNF(null)] GGHNOHPFCDJ LBPMGJFKIOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1C20", Offset = "0x6BB0E20", VA = "0x186BB1C20", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1CD0", Offset = "0x6BB0ED0", VA = "0x186BB1CD0", Slot = "4")]
		[AsyncStateMachine(typeof(HJCKNKALCBD))]
		public Task DropBeacon(Guid GBBODKPKLHB, int BLDHLOIAKIM, Vector3 GFFHHEBCBKP, MAGOBKCOEPN GFIAFOEJCDD, string KBNMEIKBHAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2B30", Offset = "0x6BB1D30", VA = "0x186BB2B30", Slot = "5")]
		public void RemoveBeacon(Guid GBBODKPKLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2A00", Offset = "0x6BB1C00", VA = "0x186BB2A00", Slot = "6")]
		public bool PlayerHasActiveBeacon(int BLDHLOIAKIM, [Out] Guid PEBKLEAHBOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2D70", Offset = "0x6BB1F70", VA = "0x186BB2D70", Slot = "7")]
		public void UpdateAllBeaconUIElements(Vector3 KJHIGOLEMCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1F70", Offset = "0x6BB1170", VA = "0x186BB1F70", Slot = "8")]
		public void HideAllHUDElements()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6BB2C00", Offset = "0x6BB1E00", VA = "0x186BB2C00", Slot = "9")]
		public void SetVisibilityBeaconUsernameDepthIgnore(bool MJNCHDMKLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6BB1EA0", Offset = "0x6BB10A0", VA = "0x186BB1EA0")]
		[AsyncStateMachine(typeof(IIMKFJNHEAH))]
		private Task GNOGFGGDEFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6BB20C0", Offset = "0x6BB12C0", VA = "0x186BB20C0")]
		private void IJEAEAHJJIM(CoordinationBeacon MPKEPBBEOHF, CoordinationBeaconHUDElement GFHEIBLJEGP, Vector3 KJHIGOLEMCB)
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
