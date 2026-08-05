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
	public class _AssemblyIndex : PFMKOBANMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6DF9210", Offset = "0x6DF8210", VA = "0x186DF9210", Slot = "8")]
		public override void NCHGKCJDJHF(GLGFPKOIELC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6565350", Offset = "0x6564350", VA = "0x186565350")]
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
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public AssetReference BeaconScreensCanvasAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public AssetReference BeaconHUDElementAssetReference
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AssetReference BeaconAudioSelf
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public AssetReference BeaconAudioOthers
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E90", Offset = "0x8B8E90", VA = "0x1808B9E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AnimationCurve BeaconDropAudioCustomRolloff
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8B9EA0", Offset = "0x8B8EA0", VA = "0x1808B9EA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Sprite LookAtThisSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8B8340", Offset = "0x8B7340", VA = "0x1808B8340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Sprite WatchOutSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8B42A0", Offset = "0x8B32A0", VA = "0x1808B42A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Sprite TakeThisSprite
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8B4280", Offset = "0x8B3280", VA = "0x1808B4280")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Color LookAtThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9C53C0", Offset = "0x9C43C0", VA = "0x1809C53C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Color WatchOutColor
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x49408C0", Offset = "0x493F8C0", VA = "0x1849408C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Color TakeThisColor
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x188C880", Offset = "0x188B880", VA = "0x18188C880")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Color ComeHereColor
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xABDBA0", Offset = "0xABCBA0", VA = "0x180ABDBA0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6DF5200", Offset = "0x6DF4200", VA = "0x186DF5200")]
		public CoordinationBeaconScriptableConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class KEJAPGDGNIE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static CoordinationBeaconScriptableConfig LONLOOPDCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6DF8D20", Offset = "0x6DF7D20", VA = "0x186DF8D20")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface DJMFMHMHHGC
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	List<IMMKEAKGFDA.GDPKOCMNCDF> FIKIFPFAKAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task<(CoordinationBeacon, CoordinationBeaconHUDElement)> GPCFLEJMGFJ();

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BIFCODALMHL(Guid BMEGHICBFNC);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KMOLJHFJKIO(int GMPCILICOJM, [Out] CoordinationBeacon HEFNALLHHDM);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DFBHBDLHEEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float ELAGJJCGGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float IOKDANGLHJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	bool CAJKMFEHHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float PGJCNOIDDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	float AOFGGBOJDKA
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface KLMNBGECDLA
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task DropBeacon(Guid BMEGHICBFNC, int GMPCILICOJM, Vector3 HFMHDKACMBN, MKLCBJGGAPF NDMMIOJEOEB, string JGDGJHCBEEO);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RemoveBeacon(Guid BMEGHICBFNC);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PlayerHasActiveBeacon(int GMPCILICOJM, [Out] Guid GMIIJOMPPCC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void UpdateAllBeaconUIElements(Vector3 DGDPOIHIKBF);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HideAllHUDElements();

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void SetVisibilityBeaconUsernameDepthIgnore(bool ODMGAJFNJCD);
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
		private float PIJAMPBPGGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool EPOGEBLDDLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private float FFNNHHMBHOO;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Guid CCDGLKPMLLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x188C880", Offset = "0x188B880", VA = "0x18188C880")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xB46410", Offset = "0xB45410", VA = "0x180B46410")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public int BLCBAMNEAGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8B8310", Offset = "0x8B7310", VA = "0x1808B8310")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8B8330", Offset = "0x8B7330", VA = "0x1808B8330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public MKLCBJGGAPF ALFCFJMDLMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4BFEAF0", Offset = "0x4BFDAF0", VA = "0x184BFEAF0")]
			[CompilerGenerated]
			get
			{
				return default(MKLCBJGGAPF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4BFEB40", Offset = "0x4BFDB40", VA = "0x184BFEB40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public RectTransform PLBMMDGNLAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<Guid> MNHHFPCBGLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6DF7140", Offset = "0x6DF6140", VA = "0x186DF7140")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6DF7200", Offset = "0x6DF6200", VA = "0x186DF7200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6DF70C0", Offset = "0x6DF60C0", VA = "0x186DF70C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6DF69B0", Offset = "0x6DF59B0", VA = "0x186DF69B0")]
		public void Initialize(Guid BMEGHICBFNC, int LBALJLIOFAG, MKLCBJGGAPF NDMMIOJEOEB, string JGDGJHCBEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x19A9C60", Offset = "0x19A8C60", VA = "0x1819A9C60")]
		public void SetVisibility(bool ODMGAJFNJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x18CE0D0", Offset = "0x18CD0D0", VA = "0x1818CE0D0")]
		public void SetVisibilityUsernameDepthIgnore(bool ODMGAJFNJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6DF7090", Offset = "0x6DF6090", VA = "0x186DF7090")]
		public void StartTimer(float DIEKCGKGOEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6DF70A0", Offset = "0x6DF60A0", VA = "0x186DF70A0")]
		public void StopTimer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6DF6960", Offset = "0x6DF5960", VA = "0x186DF6960")]
		private void GDODCEKOPFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6DF6720", Offset = "0x6DF5720", VA = "0x186DF6720")]
		private void BLADOCPAFKK(Color ANBOFEKPOBI, bool PGMIBNDCLDF, bool PABPHIOALAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public CoordinationBeacon()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class PJGBFGFLGAC : DFBHBDLHEEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static OJMFEDOPAFE BDFGOMIFCIK;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float ELAGJJCGGNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6DF8E10", Offset = "0x6DF7E10", VA = "0x186DF8E10", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public float IOKDANGLHJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6DF9020", Offset = "0x6DF8020", VA = "0x186DF9020", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool CAJKMFEHHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6DF8F00", Offset = "0x6DF7F00", VA = "0x186DF8F00", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float PGJCNOIDDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6DF90A0", Offset = "0x6DF80A0", VA = "0x186DF90A0", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public float AOFGGBOJDKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6DF9120", Offset = "0x6DF8120", VA = "0x186DF9120", Slot = "8")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6DF91A0", Offset = "0x6DF81A0", VA = "0x186DF91A0")]
	[RecRoom.NoEngine.Common.Preserve]
	public PJGBFGFLGAC([GAHPILLNNBL(null)] OJMFEDOPAFE JFKDGCHPBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8E90", Offset = "0x6DF7E90", VA = "0x186DF8E90")]
	[AEDCCIMPEFD.AFLCBBLFINA.JIBIFIAGKAD]
	internal static void EKNFAAPFPJB(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum MKLCBJGGAPF
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
		[Cpp2IlInjected.Address(RVA = "0x19A9C60", Offset = "0x19A8C60", VA = "0x1819A9C60")]
		public void SetVisibility(bool ODMGAJFNJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6DF4AD0", Offset = "0x6DF3AD0", VA = "0x186DF4AD0")]
		public void Initialize(int GMPCILICOJM, MKLCBJGGAPF NDMMIOJEOEB, string JGDGJHCBEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6DF5040", Offset = "0x6DF4040", VA = "0x186DF5040")]
		public void UpdateVisualElements(Quaternion CLPILCIDKEP, Vector3 OFOBLJHNFGM, float DIIBDIFNMFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6DF49B0", Offset = "0x6DF39B0", VA = "0x186DF49B0")]
		private void BLADOCPAFKK(Color ANBOFEKPOBI, bool PGMIBNDCLDF, bool PABPHIOALAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8B5B90", Offset = "0x8B4B90", VA = "0x1808B5B90")]
		public CoordinationBeaconHUDElement()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IMMKEAKGFDA : DJMFMHMHHGC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class GDPKOCMNCDF
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public CoordinationBeacon CPLMBCIBLCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public CoordinationBeaconHUDElement LBPFJDEPHEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8C0B80", Offset = "0x8BFB80", VA = "0x1808C0B80")]
		public GDPKOCMNCDF(CoordinationBeacon IIAMHCPPINF, CoordinationBeaconHUDElement HJFMCAKNBKL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct DEFCBJHFKJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder<(CoordinationBeacon, CoordinationBeaconHUDElement)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public IMMKEAKGFDA <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6DF72C0", Offset = "0x6DF62C0", VA = "0x186DF72C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6DF7B60", Offset = "0x6DF6B60", VA = "0x186DF7B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class MCMHBPNANJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Guid beaconId;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
		public MCMHBPNANJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6DF8D50", Offset = "0x6DF7D50", VA = "0x186DF8D50")]
		internal bool ECGGNINCDCF(GDPKOCMNCDF pooledBeacon)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly DFBHBDLHEEJ IDLNGOFPBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private List<GDPKOCMNCDF> HAPJPCONOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private List<GDPKOCMNCDF> EFPLAGDDJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly List<DIHMDMOKEDJ<GameObject>> IKAKFMCIGDP;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private List<GDPKOCMNCDF> KNMGPPOGAEF
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F0", Offset = "0x8B55F0", VA = "0x1808B65F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6DF88F0", Offset = "0x6DF78F0", VA = "0x186DF88F0")]
	[AEDCCIMPEFD.OFLDIEMPABC.LPLEDBDDEOP]
	internal static void EKNFAAPFPJB(MAONAIOKEHK GHHOPPHGNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8BF0", Offset = "0x6DF7BF0", VA = "0x186DF8BF0")]
	[RecRoom.NoEngine.Common.Preserve]
	public IMMKEAKGFDA([GAHPILLNNBL(null)] DFBHBDLHEEJ NCNKMGGFBBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6DF82E0", Offset = "0x6DF72E0", VA = "0x186DF82E0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8960", Offset = "0x6DF7960", VA = "0x186DF8960", Slot = "5")]
	[AsyncStateMachine(typeof(DEFCBJHFKJO))]
	public Task<(CoordinationBeacon, CoordinationBeaconHUDElement)> GPCFLEJMGFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8050", Offset = "0x6DF7050", VA = "0x186DF8050", Slot = "6")]
	public void BIFCODALMHL(Guid BMEGHICBFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6DF8A60", Offset = "0x6DF7A60", VA = "0x186DF8A60", Slot = "7")]
	public bool KMOLJHFJKIO(int GMPCILICOJM, [Out] CoordinationBeacon HEFNALLHHDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6DF7F80", Offset = "0x6DF6F80", VA = "0x186DF7F80")]
	private bool AHPBJJIOELM([Out] GDPKOCMNCDF MOAFOFKIDEH, [Out] int HCBGBBHPJJH)
	{
		return default(bool);
	}
}
namespace CoordinateBeacons.Concretes
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CoordinationBeaconVisualManager : MonoBehaviour, KLMNBGECDLA, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct AOLPAOHIAOF : IAsyncStateMachine
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
			public MKLCBJGGAPF context;

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
			[Cpp2IlInjected.Address(RVA = "0x6DF4480", Offset = "0x6DF3480", VA = "0x186DF4480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6DF4950", Offset = "0x6DF3950", VA = "0x186DF4950", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct DLEHKONDADG : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x6DF7BD0", Offset = "0x6DF6BD0", VA = "0x186DF7BD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x6DF7F20", Offset = "0x6DF6F20", VA = "0x186DF7F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly DFBHBDLHEEJ IDLNGOFPBIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly DJMFMHMHHGC BPKFAMBNGBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly DEHGKHGJEPG HHNMCAMBNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly float FHLNFOPKLPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly float FELCDCHCAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly float CCPOKEJJDGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly float GMEALKAEGKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly Vector3 EDDODNOCCGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private GameObject IIFDDAGEPDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Canvas FJALHNHGNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private DIHMDMOKEDJ<GameObject> ANOIGFHGHGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly Vector3[] POADKONHHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private Vector3 ONBKEPABLIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly float PHNECOKDLIE;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6DF5450", Offset = "0x6DF4450", VA = "0x186DF5450")]
		[AEDCCIMPEFD.OFLDIEMPABC.LPLEDBDDEOP]
		internal static void EKNFAAPFPJB(MAONAIOKEHK GHHOPPHGNHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6DF6510", Offset = "0x6DF5510", VA = "0x186DF6510")]
		[RecRoom.NoEngine.Common.Preserve]
		public CoordinationBeaconVisualManager([GAHPILLNNBL(null)] DFBHBDLHEEJ NCNKMGGFBBC, [GAHPILLNNBL(null)] DJMFMHMHHGC ONNBEAJIJPD, [GAHPILLNNBL(null)] DEHGKHGJEPG IPFMILAAJFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6DF5240", Offset = "0x6DF4240", VA = "0x186DF5240", Slot = "10")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6DF52F0", Offset = "0x6DF42F0", VA = "0x186DF52F0", Slot = "4")]
		[AsyncStateMachine(typeof(AOLPAOHIAOF))]
		public Task DropBeacon(Guid BMEGHICBFNC, int GMPCILICOJM, Vector3 HFMHDKACMBN, MKLCBJGGAPF NDMMIOJEOEB, string JGDGJHCBEEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6DF6150", Offset = "0x6DF5150", VA = "0x186DF6150", Slot = "5")]
		public void RemoveBeacon(Guid BMEGHICBFNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6DF6020", Offset = "0x6DF5020", VA = "0x186DF6020", Slot = "6")]
		public bool PlayerHasActiveBeacon(int GMPCILICOJM, [Out] Guid GMIIJOMPPCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6DF6390", Offset = "0x6DF5390", VA = "0x186DF6390", Slot = "7")]
		public void UpdateAllBeaconUIElements(Vector3 DGDPOIHIKBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6DF5E00", Offset = "0x6DF4E00", VA = "0x186DF5E00", Slot = "8")]
		public void HideAllHUDElements()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6DF6220", Offset = "0x6DF5220", VA = "0x186DF6220", Slot = "9")]
		public void SetVisibilityBeaconUsernameDepthIgnore(bool ODMGAJFNJCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6DF5F50", Offset = "0x6DF4F50", VA = "0x186DF5F50")]
		[AsyncStateMachine(typeof(DLEHKONDADG))]
		private Task PMGCOPOHENA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6DF54C0", Offset = "0x6DF44C0", VA = "0x186DF54C0")]
		private void EPDDGPEOPHP(CoordinationBeacon CLFCHKEABBF, CoordinationBeaconHUDElement NMELDBANCBJ, Vector3 DGDPOIHIKBF)
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
