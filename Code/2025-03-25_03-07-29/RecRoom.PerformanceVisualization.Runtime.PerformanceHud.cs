using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.FastMesh.Core;
using RecRoom.FastMesh.Rendering;
using RecRoom.FastText;
using RecRoom.FastText.Layout;
using RecRoom.Logging.Attributes;
using RecRoom.Metrics.Pipeline;
using RecRoom.Metrics.Pipeline.MetricInfo;
using RecRoom.NoEngine.DataStructures;
using RecRoom.Profiling;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_PerformanceVisualization_Runtime_PerformanceHud
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : PNJEOLJBAIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B5AF80", Offset = "0x7B5A380", VA = "0x187B5AF80", Slot = "4")]
		public override void ELBDPICAHPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Profiling.Visualization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class MetricHudDisplay : MonoBehaviour, IRawMetricsSubscriber, IMetricsSubscriber<RawMetric>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[Flags]
		private enum DPBFKMNIPFL
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			RenderDependenciesInit = 1,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			MetricDependenciesInit = 2,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			AllDependenciesInit = 3,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			OverlayInit = 4,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			MetricStatesInit = 8,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			LayoutStatesInit = 0x10,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			AllStatesInit = 0x1C,
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			AllInit = 0x1F
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly ABDDJEPKCOD LEMJHEDOKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private MeshBufferRenderer meshBufferRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private RectTransform renderAreaRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private Material glyphMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private GlyphMapAsset glyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private int fontSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private int maxLines;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private float lineHeightFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private Material graphMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private MetricGraphGraphic[] metricGraphs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private DPBFKMNIPFL DOOLOCHBFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup BPMHJKBOIIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline HENIIHOMNGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry MKAPIEHGAID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken GFMHNBLFCPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private LFLIAJMKKCF FPNNLBAIOLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private ICMJHOBPDJN IBCGJHEAHIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material NCOOKGGIIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int OECCILKHDFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect KCBOMIOECNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int AAOLFBFEGBH;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int KPCPJKOGIFO = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private KPDOIDOJAKN ANPHAMPLODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool KGFLICHOAPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> ENNENPCEMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<IJJMGHBIJDO> OCPLJBBGGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private LDCCAMCBGFE PPHAMMPBGNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<LDCCAMCBGFE> MHNDIODOBOG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer BJAJHBHBHIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D0B0", Offset = "0x7B5C4B0", VA = "0x187B5D0B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D2C0", Offset = "0x7B5C6C0", VA = "0x187B5D2C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D260", Offset = "0x7B5C660", VA = "0x187B5D260")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B5B500", Offset = "0x7B5A900", VA = "0x187B5B500")]
		private void CHEBNPKFHAL(bool AGBCADJFPDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B5C9A0", Offset = "0x7B5BDA0", VA = "0x187B5C9A0")]
		private void IFEBGJOGDAD(bool AGBCADJFPDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D370", Offset = "0x7B5C770", VA = "0x187B5D370")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CD20", Offset = "0x7B5C120", VA = "0x187B5CD20")]
		public void InitMetricsDependencies(MetricIdLookup BPMHJKBOIIN, IRawMetricsPipeline HENIIHOMNGO, IMetricCollectionRegistry MKAPIEHGAID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D2F0", Offset = "0x7B5C6F0", VA = "0x187B5D2F0")]
		public void SetActiveOverlay(KPDOIDOJAKN HPIEABJGNAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7B5C1B0", Offset = "0x7B5B5B0", VA = "0x187B5C1B0")]
		private void EKIOLINAHPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7B5C050", Offset = "0x7B5B450", VA = "0x187B5C050")]
		private void DPCOGMKNLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7B5B5F0", Offset = "0x7B5A9F0", VA = "0x187B5B5F0")]
		private void CLKHNONEGOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BA00", Offset = "0x7B5AE00", VA = "0x187B5BA00")]
		private void DNPNHOOKFFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7B5B010", Offset = "0x7B5A410", VA = "0x187B5B010")]
		private bool BHOEOOLFGDE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7B5B2C0", Offset = "0x7B5A6C0", VA = "0x187B5B2C0")]
		private bool BJLIJIPNACP(bool HEGINIGEJIB = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CED0", Offset = "0x7B5C2D0", VA = "0x187B5CED0")]
		private bool ONIBJBMPMBD(PLCIAIJPKJC PBOFAFGAOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7B5C630", Offset = "0x7B5BA30", VA = "0x187B5C630")]
		private bool FHJDPCKOCPM(PLCIAIJPKJC PBOFAFGAOJF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7B5C770", Offset = "0x7B5BB70", VA = "0x187B5C770")]
		public void HandleMetric([In] RawMetric KMPKMJPIGBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x23CDE90", Offset = "0x23CD290", VA = "0x1823CDE90")]
		private bool BHLOCKACGLE(DPBFKMNIPFL HCIEHPOPKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CEA0", Offset = "0x7B5C2A0", VA = "0x187B5CEA0")]
		private bool KJFDGKCDCMJ(DPBFKMNIPFL OCMNECEHIEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D630", Offset = "0x7B5CA30", VA = "0x187B5D630")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7B5CEC0", Offset = "0x7B5C2C0", VA = "0x187B5CEC0", Slot = "4")]
		private void LKDHCNLLLPL([In] RawMetric KMPKMJPIGBH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class LDCCAMCBGFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool DFEGOENHJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect PKCOAJHCLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout MJIMLAFEOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout AIILBOKIOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout IJLBLAMPMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private JEHIGKEKNKC LJBINEAIHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic PBPALOJAADI;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7B59EF0", Offset = "0x7B592F0", VA = "0x187B59EF0")]
	public void AEJOPFDILPE(LFLIAJMKKCF JHKIEBLOIFD, ICMJHOBPDJN LJGDCAAPNJP, LayoutRect DGCAHJCMLNA, int PKECDNBOEMN, [Optional] MetricGraphGraphic PBPALOJAADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A690", Offset = "0x7B59A90", VA = "0x187B5A690")]
	public void EMOKMHPHNDG(float AHLAJHFBHFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A520", Offset = "0x7B59920", VA = "0x187B5A520")]
	public void EMCDDMEBIFN(ReadOnlySpan<char> POPCADMGGKK, ReadOnlySpan<char> NLOPNGKKCOO, ReadOnlySpan<char> JPEPKBHHHHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A3B0", Offset = "0x7B597B0", VA = "0x187B5A3B0")]
	public void ALHHNPEHDBD(RRColor32 CKANMCILFBE, bool GCFJHIPGNGP = true, bool IFEFDLNFNKE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A970", Offset = "0x7B59D70", VA = "0x187B5A970")]
	public float KAIPMMHMCEO(float AEMFJLEJBNN, float LLPBDMGFBGF, float JLPANPDCEIF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7B5AF30", Offset = "0x7B5A330", VA = "0x187B5AF30")]
	public void MNAEPOKGAIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A800", Offset = "0x7B59C00", VA = "0x187B5A800")]
	public void FBAGBHKMKJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A500", Offset = "0x7B59900", VA = "0x187B5A500")]
	public void BIOOAABLAGK(PLKAKLALAMH HHACNEHGGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A8C0", Offset = "0x7B59CC0", VA = "0x187B5A8C0")]
	public void JKEOBKAGHMH(PLKAKLALAMH HHACNEHGGHP, double PGJAFHMCBJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7B5A830", Offset = "0x7B59C30", VA = "0x187B5A830")]
	public void JCKAGPLJBMH(double FIIKLGCIAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7B5AD70", Offset = "0x7B5A170", VA = "0x187B5AD70")]
	public void LDOICLPCMHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
	public LDCCAMCBGFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NDIINCOPANK
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static KPDOIDOJAKN NKNBJBANNIC;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static KPDOIDOJAKN EAPFOAMBCMO;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static KPDOIDOJAKN LIMENCMOECJ;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static KPDOIDOJAKN IFDLIGJHCGH;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static KPDOIDOJAKN LNKJMNBCNAN;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static KPDOIDOJAKN HEDEINJMGAO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static KPDOIDOJAKN OCEPFJKKOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D940", Offset = "0x7B5CD40", VA = "0x187B5D940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static KPDOIDOJAKN PLNBGFBCBHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D990", Offset = "0x7B5CD90", VA = "0x187B5D990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static KPDOIDOJAKN ALIAKHPLNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D8F0", Offset = "0x7B5CCF0", VA = "0x187B5D8F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static KPDOIDOJAKN AILAJAKHKKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D800", Offset = "0x7B5CC00", VA = "0x187B5D800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static KPDOIDOJAKN MOGEGIIBKHF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D8A0", Offset = "0x7B5CCA0", VA = "0x187B5D8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static KPDOIDOJAKN PMBMDDLNEPN
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D850", Offset = "0x7B5CC50", VA = "0x187B5D850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static KPDOIDOJAKN LPBFDCDGMOB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x991350", Offset = "0x990750", VA = "0x180991350")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct PALGDJKNMFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string EIDOHHHFCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string GLABLHDMJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string EHDELHOJMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public PLKAKLALAMH LOIPKOJPBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool JLNNLDDIJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool JNKEHJMLMLG;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KPDOIDOJAKN
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string BGJLELPBPDG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x991DC0", Offset = "0x9911C0", VA = "0x180991DC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x991E00", Offset = "0x991200", VA = "0x180991E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PALGDJKNMFC[] LLDCBLIMCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9933D0", Offset = "0x9927D0", VA = "0x1809933D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "4")]
	public virtual void GMGCDJJOKFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "5")]
	public virtual void PAEKCDKOHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x995770", Offset = "0x994B70", VA = "0x180995770")]
	public KPDOIDOJAKN(string LBJINJOODBJ, PALGDJKNMFC[] DBCEPAOJFFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum LCPJOPJFCMD
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	Clean = 0,
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	MetricUpdated = 1,
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	MetricDirty = 2,
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	TextDirty = 4,
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	AllDirty = 6
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal class IJJMGHBIJDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private LCPJOPJFCMD BJLJBHDGABB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription ONOCDCOHNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload KGCLHKOHKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter KKCDIDPJHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double PELMAJEGBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int MBAFOCKOCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private PLKAKLALAMH HHACNEHGGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private JKIMKAHPIOO MJEDAJEJPIL;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int BDDLHHOBKKB = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] POPCADMGGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] NLOPNGKKCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int EKPADFOCMEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] JPEPKBHHHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int GGHLONLEDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string IPIKEJEPADF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription KCBEINCLMMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xC6CCA0", Offset = "0xC6C0A0", VA = "0x180C6CCA0")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7B592A0", Offset = "0x7B586A0", VA = "0x187B592A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LCPJOPJFCMD ICDGPIBMCFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x991DB0", Offset = "0x9911B0", VA = "0x180991DB0")]
		get
		{
			return default(LCPJOPJFCMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> CPHLBHKJHJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7B59A40", Offset = "0x7B58E40", VA = "0x187B59A40")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> BMDPDBLLHED
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7B59830", Offset = "0x7B58C30", VA = "0x187B59830")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> ICFELFNNDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7B59370", Offset = "0x7B58770", VA = "0x187B59370")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public JKIMKAHPIOO LOKDLCOAIBG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB10960", Offset = "0xB0FD60", VA = "0x180B10960")]
		get
		{
			return default(JKIMKAHPIOO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double HJJFDKBBGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7B59A10", Offset = "0x7B58E10", VA = "0x187B59A10")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float IFKOAFIMJID
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7B59A00", Offset = "0x7B58E00", VA = "0x187B59A00")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float OLMCEDLOBBD
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xB6E0D0", Offset = "0xB6D4D0", VA = "0x180B6E0D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xBADC60", Offset = "0xBAD060", VA = "0x180BADC60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool HOPLGCBFMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xE35E60", Offset = "0xE35260", VA = "0x180E35E60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xE35E70", Offset = "0xE35270", VA = "0x180E35E70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public PLKAKLALAMH LOIPKOJPBIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x993280", Offset = "0x992680", VA = "0x180993280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7B59D30", Offset = "0x7B59130", VA = "0x187B59D30")]
	public IJJMGHBIJDO(string FAGNIGAMDJK, [Optional] MetricDescription ONOCDCOHNMK, [Optional] PLKAKLALAMH HHACNEHGGHP, bool ELLEINEFNHA = true, bool EMJAAOGOLLC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7B59910", Offset = "0x7B58D10", VA = "0x187B59910")]
	public void OOLDEKKEIEN(RawMetricPayload KDENGLLGPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7B59AA0", Offset = "0x7B58EA0", VA = "0x187B59AA0")]
	public bool PLGBGPHBDPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7B59450", Offset = "0x7B58850", VA = "0x187B59450")]
	public bool HJKIINKLFCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x66DAD10", Offset = "0x66DA110", VA = "0x1866DAD10")]
	public void OMFDDNKGOBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x66C8FD0", Offset = "0x66C83D0", VA = "0x1866C8FD0")]
	public void LCMPFHMDIEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7B59320", Offset = "0x7B58720", VA = "0x187B59320")]
	private static int AMKLHDNNLIO(MetricDataUnits KHHPPFLDALN)
	{
		return default(int);
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
