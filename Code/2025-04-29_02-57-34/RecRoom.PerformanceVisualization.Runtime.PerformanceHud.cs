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
	public class LogRegistrationIndex : EEFEEDICGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C3C0", Offset = "0x7E5B7C0", VA = "0x187E5C3C0", Slot = "4")]
		public override void KECNLMAOALC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		private enum MNMPKKLCOFP
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
		private static readonly LMKAPNBAFDO KIBGFJNEFGA;

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
		private MNMPKKLCOFP LMLFHIHEBAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup HFFFMNGGDEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline IHCOFECFIBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry KPAJPGIHOGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken KILHLGHKOKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private HDCOEEHMINI BAHNCGEADLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private BFAAJGFECLK LJOCIIOPLDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material LJKOBGCBCGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int LJAOGLKMIDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect OMPEOIKFOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int NODKFKMDDNL;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int DNBPFOAOFHP = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private JGMJOKLNFPO CBLAGANKFNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool JMNPFBPNDCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> DFPPCFCIKJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<LKHPCJBLNOC> NLKFMBNNMOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private LMLFMKCAACC JFOBPCDJPHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<LMLFMKCAACC> MEODIBHPBNC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer FADHMPPEJHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E5E510", Offset = "0x7E5D910", VA = "0x187E5E510")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7E5E720", Offset = "0x7E5DB20", VA = "0x187E5E720")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7E5E6C0", Offset = "0x7E5DAC0", VA = "0x187E5E6C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D8B0", Offset = "0x7E5CCB0", VA = "0x187E5D8B0")]
		private void IACAPFEGLHN(bool PFGFLAGNGML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C690", Offset = "0x7E5BA90", VA = "0x187E5C690")]
		private void AJDDHBCMEAH(bool PFGFLAGNGML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7E5E7D0", Offset = "0x7E5DBD0", VA = "0x187E5E7D0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D9A0", Offset = "0x7E5CDA0", VA = "0x187E5D9A0")]
		public void InitMetricsDependencies(MetricIdLookup HFFFMNGGDEC, IRawMetricsPipeline IHCOFECFIBK, IMetricCollectionRegistry KPAJPGIHOGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7E5E750", Offset = "0x7E5DB50", VA = "0x187E5E750")]
		public void SetActiveOverlay(JGMJOKLNFPO JGKEPHHEJMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7E5DB30", Offset = "0x7E5CF30", VA = "0x187E5DB30")]
		private void KDLFILMDAOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7E5CA10", Offset = "0x7E5BE10", VA = "0x187E5CA10")]
		private void BEAKDBLJFFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7E5DFC0", Offset = "0x7E5D3C0", VA = "0x187E5DFC0")]
		private void MCIMGPABDCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7E5CD50", Offset = "0x7E5C150", VA = "0x187E5CD50")]
		private void EFLDKGDMEFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D3D0", Offset = "0x7E5C7D0", VA = "0x187E5D3D0")]
		private bool HMMDCFALKON()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7E5C450", Offset = "0x7E5B850", VA = "0x187E5C450")]
		private bool AEHOBHGPMEA(bool IMJBLFBLNHJ = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7E5CB70", Offset = "0x7E5BF70", VA = "0x187E5CB70")]
		private bool DIDFOIPCFCO(LODJPNFDKOD ILNONAAFECI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7E5E3D0", Offset = "0x7E5D7D0", VA = "0x187E5E3D0")]
		private bool NBIDKBCBNMF(LODJPNFDKOD ILNONAAFECI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D680", Offset = "0x7E5CA80", VA = "0x187E5D680")]
		public void HandleMetric([In] RawMetric OFJMJGOIAKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x247F410", Offset = "0x247E810", VA = "0x18247F410")]
		private bool EAEKLJMBANC(MNMPKKLCOFP AAIJELKNDNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D3B0", Offset = "0x7E5C7B0", VA = "0x187E5D3B0")]
		private bool GILLOOBCHCF(MNMPKKLCOFP EKEFDIPJJHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7E5EA90", Offset = "0x7E5DE90", VA = "0x187E5EA90")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D3A0", Offset = "0x7E5C7A0", VA = "0x187E5D3A0", Slot = "4")]
		private void FKCDNEIKNGC([In] RawMetric OFJMJGOIAKC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class LMLFMKCAACC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool DPJHFJEEEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect EACKACJBIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout DKCJBMMPMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout IAKOCFFMKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout LDBJEEPBEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private PKIFJNJDPDJ BKHOIALJNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic DJALJBMDOGG;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7E5B780", Offset = "0x7E5AB80", VA = "0x187E5B780")]
	public void HGEPFBBIJLL(HDCOEEHMINI LMOFELIMABN, BFAAJGFECLK MBFHPNNFLOF, LayoutRect BGEGIJMHKOC, int ACOPJLELDFF, [Optional] MetricGraphGraphic DJALJBMDOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7E5BCB0", Offset = "0x7E5B0B0", VA = "0x187E5BCB0")]
	public void LGCIGBPMOBI(float OOAFALIFNHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7E5BE20", Offset = "0x7E5B220", VA = "0x187E5BE20")]
	public void MBFCEDEHDEK(ReadOnlySpan<char> HEKNPHAPGAA, ReadOnlySpan<char> HDAMMDEKKCG, ReadOnlySpan<char> ELDLNNIIBJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E5B330", Offset = "0x7E5A730", VA = "0x187E5B330")]
	public void CGFOGIAKKNJ(RRColor32 JLFKDHGAEDA, bool ADPBEFKCAIN = true, bool IKDGJPFFLOD = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7E5BFC0", Offset = "0x7E5B3C0", VA = "0x187E5BFC0")]
	public float PCBGOEBHGMH(float ALHKFDDNBFP, float DMCEPIEPPEF, float OOJLGENCNOC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7E5BC40", Offset = "0x7E5B040", VA = "0x187E5BC40")]
	public void IPOHGLAFMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7E5BF90", Offset = "0x7E5B390", VA = "0x187E5BF90")]
	public void NNCICIBLKJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7E5BC90", Offset = "0x7E5B090", VA = "0x187E5BC90")]
	public void KFJBOMFKJEL(EMJEOJIPPNL CFPCKNKGLEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7E5B510", Offset = "0x7E5A910", VA = "0x187E5B510")]
	public void FOKCLKJPJDB(EMJEOJIPPNL CFPCKNKGLEN, double KPABPLHPKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7E5B480", Offset = "0x7E5A880", VA = "0x187E5B480")]
	public void DHAOGLPOGOG(double OOEMJLHLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E5B5C0", Offset = "0x7E5A9C0", VA = "0x187E5B5C0")]
	public void HAHHCGEAEBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	public LMLFMKCAACC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KPKEIOFAJCJ
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static JGMJOKLNFPO OKHGNFLBBPB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static JGMJOKLNFPO PNPKNDFBMMF;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static JGMJOKLNFPO DHAFLAKJDLE;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static JGMJOKLNFPO HGJHLLJMGAJ;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static JGMJOKLNFPO POKLJDEPLEI;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static JGMJOKLNFPO HGLKGLOKEDC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static JGMJOKLNFPO GCAAODGDGAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7E58920", Offset = "0x7E57D20", VA = "0x187E58920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static JGMJOKLNFPO NMOIDMJNDGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7E58880", Offset = "0x7E57C80", VA = "0x187E58880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static JGMJOKLNFPO BGLDEPKPDMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7E587E0", Offset = "0x7E57BE0", VA = "0x187E587E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static JGMJOKLNFPO MODGADAHGCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7E58830", Offset = "0x7E57C30", VA = "0x187E58830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static JGMJOKLNFPO PMPJNMPHBDF
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7E58970", Offset = "0x7E57D70", VA = "0x187E58970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static JGMJOKLNFPO FFMICJKALHM
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7E588D0", Offset = "0x7E57CD0", VA = "0x187E588D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static JGMJOKLNFPO GOAPIKLJFMC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9CB240", Offset = "0x9CA640", VA = "0x1809CB240")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct FDLGAFJADKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string OCGLEKAIFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string DMJDOLFACOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string FDCOAKNEIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public EMJEOJIPPNL CIAFKCCKHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool KHOBIPOMNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool PHBBIANAKDM;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class JGMJOKLNFPO
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string IGLANLLFBFP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9C9460", Offset = "0x9C8860", VA = "0x1809C9460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9C91D0", Offset = "0x9C85D0", VA = "0x1809C91D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FDLGAFJADKO[] FEJJEDFCIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9C91E0", Offset = "0x9C85E0", VA = "0x1809C91E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "4")]
	public virtual void KJJHAKNLMBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
	public virtual void GMGIBJGGKMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9CD730", Offset = "0x9CCB30", VA = "0x1809CD730")]
	public JGMJOKLNFPO(string EIFHMNNCFBD, FDLGAFJADKO[] DKHPFMKLBLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum AGECHKLFNLJ
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
internal class LKHPCJBLNOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private AGECHKLFNLJ PANFIJJGAKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription OHFCHBEHKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload CFFKMBGFAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter GFKEMCJOOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double HDLMFAMOMGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int PDENJNEJPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EMJEOJIPPNL CFPCKNKGLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private NMOEJHOODMD JNDMPLLFIOL;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int OIEBDLPENBP = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] HEKNPHAPGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] HDAMMDEKKCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int MLFOLILMFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] ELDLNNIIBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int KFNGCEEOHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string KJLNBJLIPAP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription KCKMALIDOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xCDBA30", Offset = "0xCDAE30", VA = "0x180CDBA30")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7E5B060", Offset = "0x7E5A460", VA = "0x187E5B060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public AGECHKLFNLJ EIDKKOCFDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9D5BF0", Offset = "0x9D4FF0", VA = "0x1809D5BF0")]
		get
		{
			return default(AGECHKLFNLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> MMCNJGLHGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7E5B0E0", Offset = "0x7E5A4E0", VA = "0x187E5B0E0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> JJCHBMGNCDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7E5A980", Offset = "0x7E59D80", VA = "0x187E5A980")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> IHLNKJLBOOL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7E5AF80", Offset = "0x7E5A380", VA = "0x187E5AF80")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public NMOEJHOODMD JGLBNLDJBKB
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB8AA20", Offset = "0xB89E20", VA = "0x180B8AA20")]
		get
		{
			return default(NMOEJHOODMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double CNNHLNPBDKE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7E5B140", Offset = "0x7E5A540", VA = "0x187E5B140")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float ALFABJEHHHC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7E5A6E0", Offset = "0x7E59AE0", VA = "0x187E5A6E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float CIELGBFPLBD
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xBD9050", Offset = "0xBD8450", VA = "0x180BD9050")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xC3CE40", Offset = "0xC3C240", VA = "0x180C3CE40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool BIEBEOEOPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x10AE5A0", Offset = "0x10AD9A0", VA = "0x1810AE5A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x12CA900", Offset = "0x12C9D00", VA = "0x1812CA900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public EMJEOJIPPNL CIAFKCCKHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9CD810", Offset = "0x9CCC10", VA = "0x1809CD810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7E5B170", Offset = "0x7E5A570", VA = "0x187E5B170")]
	public LKHPCJBLNOC(string LPHIFBBKFHF, [Optional] MetricDescription OHFCHBEHKLA, [Optional] EMJEOJIPPNL CFPCKNKGLEN, bool BGBDFGMFHHP = true, bool GFDOMEDJLLP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7E5AA60", Offset = "0x7E59E60", VA = "0x187E5AA60")]
	public void FFJLNHJJIJB(RawMetricPayload DACPKJODAKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7E5A6F0", Offset = "0x7E59AF0", VA = "0x187E5A6F0")]
	public bool CAELGFHJHJC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E5ABA0", Offset = "0x7E59FA0", VA = "0x187E5ABA0")]
	public bool ILAFDAJNFKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6967C50", Offset = "0x6967050", VA = "0x186967C50")]
	public void PBGBIGIHINH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6955BE0", Offset = "0x6954FE0", VA = "0x186955BE0")]
	public void CALJFJEDAGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7E5AB50", Offset = "0x7E59F50", VA = "0x187E5AB50")]
	private static int FNGBJKNCMOC(MetricDataUnits IOJCJGAIFCL)
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
