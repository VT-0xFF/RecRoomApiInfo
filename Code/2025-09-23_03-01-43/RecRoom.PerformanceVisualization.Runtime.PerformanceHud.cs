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
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x88C6110", Offset = "0x88C4710", VA = "0x1888C6110", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		private enum OMEIJHCNMBA
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
		private static readonly IPHNFELODMJ AMCHCCAPJNG;

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
		private OMEIJHCNMBA BCLPFDPBICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup OHBICEIAIAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline EKIJCJAINAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry GLHLOEFHCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken GHPGOFFMOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private BDNCNPMFIDD GPCOHNBPKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private OCGBLDAPBIE KMPHLOAPBAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material AKNPMJGBNMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int HNGDKNFIIKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect PJHDEIJNKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int BAIKECGAOPH;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int FCBHAMJEHAH = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private EKLCKLJFKJM EBDJOHMADDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool PMILPDHEAPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> CDBFLPJMNDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<ICKMIAHIKKE> AEMCFKKAAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private JKHJAJDKHJF EGAABLNGFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<JKHJAJDKHJF> OIKHKACHAEF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer GPACIDOCMKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x88CA120", Offset = "0x88C8720", VA = "0x1888CA120")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x88CA330", Offset = "0x88C8930", VA = "0x1888CA330")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x88CA2D0", Offset = "0x88C88D0", VA = "0x1888CA2D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x88C80B0", Offset = "0x88C66B0", VA = "0x1888C80B0")]
		private void BOHMKGNHPMN(bool EHGAKGFIEHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x88C8450", Offset = "0x88C6A50", VA = "0x1888C8450")]
		private void EKOKIMMHPLD(bool EHGAKGFIEHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x88CA3E0", Offset = "0x88C89E0", VA = "0x1888CA3E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x88C9BA0", Offset = "0x88C81A0", VA = "0x1888C9BA0")]
		public void InitMetricsDependencies(MetricIdLookup OHBICEIAIAE, IRawMetricsPipeline EKIJCJAINAJ, IMetricCollectionRegistry GLHLOEFHCPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x88CA360", Offset = "0x88C8960", VA = "0x1888CA360")]
		public void SetActiveOverlay(EKLCKLJFKJM MKHIFLNAILG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x88C9710", Offset = "0x88C7D10", VA = "0x1888C9710")]
		private void IMDAFJMKCGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88C95B0", Offset = "0x88C7BB0", VA = "0x1888C95B0")]
		private void IHBCBELNCED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88C9D10", Offset = "0x88C8310", VA = "0x1888C9D10")]
		private void NDBNBHEMIFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x88C8D30", Offset = "0x88C7330", VA = "0x1888C8D30")]
		private void HKHPLOLNMBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x88C81A0", Offset = "0x88C67A0", VA = "0x1888C81A0")]
		private bool DDJBGLOJBKL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x88C8AF0", Offset = "0x88C70F0", VA = "0x1888C8AF0")]
		private bool HEGGDGHHAAH(bool AKKFOJDOENB = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x88C87D0", Offset = "0x88C6DD0", VA = "0x1888C87D0")]
		private bool FFMDNAPADBC(AEIPIMBAAED NGOJMGCIOHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x88C89B0", Offset = "0x88C6FB0", VA = "0x1888C89B0")]
		private bool GMGEJHIPNAA(AEIPIMBAAED NGOJMGCIOHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x88C9380", Offset = "0x88C7980", VA = "0x1888C9380")]
		public void HandleMetric([In] RawMetric HEFOMGKHEFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x88C9D00", Offset = "0x88C8300", VA = "0x1888C9D00")]
		private bool MHCNIPIJEAK(OMEIJHCNMBA GNKDOMPCKMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x88C8090", Offset = "0x88C6690", VA = "0x1888C8090")]
		private bool AEFNGAOLAMG(OMEIJHCNMBA HEPMLCCFECG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x88CA6A0", Offset = "0x88C8CA0", VA = "0x1888CA6A0")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x88C9CF0", Offset = "0x88C82F0", VA = "0x1888C9CF0", Slot = "4")]
		private void LCPJJANKDJH([In] RawMetric HEFOMGKHEFC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class JKHJAJDKHJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool NOPBNJICMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect EICMGDKNFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout DPJPGFIOJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout LHNFIJFNMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout HPKACIMNDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NBIGALJPCAJ IOCLKKCNONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic DPBJPAGPJPC;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x88C5630", Offset = "0x88C3C30", VA = "0x1888C5630")]
	public void HAKAIDJFGEI(BDNCNPMFIDD CGHEMIGGOCM, OCGBLDAPBIE NGOBJGGOPID, LayoutRect EPCMALFNIHP, int EPCBIBMKDMM, [Optional] MetricGraphGraphic DPBJPAGPJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x88C5FA0", Offset = "0x88C45A0", VA = "0x1888C5FA0")]
	public void PCPDHDALNOM(float COBEKFBOOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x88C5080", Offset = "0x88C3680", VA = "0x1888C5080")]
	public void AAJENHCKKHM(ReadOnlySpan<char> MAOIMLENPKK, ReadOnlySpan<char> KLEAKBLHCIL, ReadOnlySpan<char> AMPKLEOBOJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x88C54E0", Offset = "0x88C3AE0", VA = "0x1888C54E0")]
	public void DHIDHIKAJFM(RRColor32 FPHNLEHIJEM, bool PKNEKJDFAMC = true, bool JHHJJKNOLOE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x88C5AF0", Offset = "0x88C40F0", VA = "0x1888C5AF0")]
	public float JHLLFIAMFHF(float MMNDBJPNMEP, float PHJHPDFMOHG, float MLKCOMCGKLB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x88C51F0", Offset = "0x88C37F0", VA = "0x1888C51F0")]
	public void AMOEFCMECKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x88C5240", Offset = "0x88C3840", VA = "0x1888C5240")]
	public void BKCCNAJCLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x88C5EF0", Offset = "0x88C44F0", VA = "0x1888C5EF0")]
	public void MGDCMPGAMPK(BPIEGFEHHOP MEGNCMNIANH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x88C5270", Offset = "0x88C3870", VA = "0x1888C5270")]
	public void CJOPLEOKEOO(BPIEGFEHHOP MEGNCMNIANH, double EAHAEIJNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x88C5F10", Offset = "0x88C4510", VA = "0x1888C5F10")]
	public void NHDIBODDLAP(double KOPHBHGIACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x88C5320", Offset = "0x88C3920", VA = "0x1888C5320")]
	public void CNCNJGCEOGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
	public JKHJAJDKHJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MALDLCMLEIK
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static EKLCKLJFKJM BKKDMFEHPJB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static EKLCKLJFKJM DPJEEAKDDEI;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static EKLCKLJFKJM IBJLGBGKKCC;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static EKLCKLJFKJM OPOPAEACLHB;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static EKLCKLJFKJM IABOAGJMHBJ;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static EKLCKLJFKJM FNDILCOBMJC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static EKLCKLJFKJM DKABDBMACEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x88C6290", Offset = "0x88C4890", VA = "0x1888C6290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static EKLCKLJFKJM NFLDLAJLKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x88C6240", Offset = "0x88C4840", VA = "0x1888C6240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static EKLCKLJFKJM EALFJGFBHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x88C61F0", Offset = "0x88C47F0", VA = "0x1888C61F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static EKLCKLJFKJM KGLINMNANGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x88C62E0", Offset = "0x88C48E0", VA = "0x1888C62E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static EKLCKLJFKJM DIHLMAOLFLO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x88C61A0", Offset = "0x88C47A0", VA = "0x1888C61A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static EKLCKLJFKJM NKNECEOKIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x88C6330", Offset = "0x88C4930", VA = "0x1888C6330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static EKLCKLJFKJM AFLFCLLDLIE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct GCHCJCLFBIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string LBDIFEEJEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string FELNGADGAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string KHFKFMJBIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public BPIEGFEHHOP JGMCDBJKJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool EGONANHCLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool IENMHCCNMNF;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class EKLCKLJFKJM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string DFOKIJMJKCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GCHCJCLFBIO[] PCBEIFPEFEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "4")]
	public virtual void EMLOAMECMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
	public virtual void NNNBODEKBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xAA7000", Offset = "0xAA5600", VA = "0x180AA7000")]
	public EKLCKLJFKJM(string PPIKFHNMOAN, GCHCJCLFBIO[] PGHKNMJAGFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum AOOFOEDMBIE
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
internal class ICKMIAHIKKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private AOOFOEDMBIE IGMEGHFNBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription AFHJECLFKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload JFAOAIPNPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter MJOOCADPCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double KAFMBNBKNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int LHHHPNCJCCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private BPIEGFEHHOP MEGNCMNIANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private EINGPCHMPDP FMOLKMCDAPP;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int ELGLONEANCG = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] MAOIMLENPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] KLEAKBLHCIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int KKMJPJNENEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] AMPKLEOBOJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int DOMGOPFNKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string FEECMFJIKGD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription OACEECJLMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xEC0AD0", Offset = "0xEBF0D0", VA = "0x180EC0AD0")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x88C4B30", Offset = "0x88C3130", VA = "0x1888C4B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public AOOFOEDMBIE NIHMHNAJOIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
		get
		{
			return default(AOOFOEDMBIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> LNJCPIKHFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88C4BB0", Offset = "0x88C31B0", VA = "0x1888C4BB0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> FFKACJOMFFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x88C4DE0", Offset = "0x88C33E0", VA = "0x1888C4DE0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> MNFOPJAHMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x88C4C10", Offset = "0x88C3210", VA = "0x1888C4C10")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public EINGPCHMPDP CNHGFHFHIFP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xD6B700", Offset = "0xD69D00", VA = "0x180D6B700")]
		get
		{
			return default(EINGPCHMPDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double OIMOJDKANKI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x88C4AB0", Offset = "0x88C30B0", VA = "0x1888C4AB0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float IOJLEGOJJMC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x88C4600", Offset = "0x88C2C00", VA = "0x1888C4600")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float MPOOELGMDCG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xDA16A0", Offset = "0xD9FCA0", VA = "0x180DA16A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xE1BC20", Offset = "0xE1A220", VA = "0x180E1BC20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool CEFEHNFDOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1342CD0", Offset = "0x13412D0", VA = "0x181342CD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1683CA0", Offset = "0x16822A0", VA = "0x181683CA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public BPIEGFEHHOP JGMCDBJKJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xAA54C0", Offset = "0xAA3AC0", VA = "0x180AA54C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x88C4EC0", Offset = "0x88C34C0", VA = "0x1888C4EC0")]
	public ICKMIAHIKKE(string ICGKKCLOGHP, [Optional] MetricDescription AFHJECLFKNO, [Optional] BPIEGFEHHOP MEGNCMNIANH, bool GMEPFGLIEOM = true, bool OGCDDIPIMCE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x88C4CF0", Offset = "0x88C32F0", VA = "0x1888C4CF0")]
	public void KINJGANGIIL(RawMetricPayload JGIKFNCGDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x88C4370", Offset = "0x88C2970", VA = "0x1888C4370")]
	public bool BPEJLHLALKI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x88C4610", Offset = "0x88C2C10", VA = "0x1888C4610")]
	public bool DFHAJIFKHBF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7265A40", Offset = "0x7264040", VA = "0x187265A40")]
	public void NJOHBONKEIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7265A30", Offset = "0x7264030", VA = "0x187265A30")]
	public void DKCDCINHFCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x88C4AE0", Offset = "0x88C30E0", VA = "0x1888C4AE0")]
	private static int FGDNFOIOLKJ(MetricDataUnits AFLEHPICLLK)
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
