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
	public class LogRegistrationIndex : ONLGCKOFHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E880B0", Offset = "0x7E868B0", VA = "0x187E880B0", Slot = "4")]
		public override void JNEAPGDNFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		private enum MGJBGFJBOAN
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
		private static readonly LLPKKNNAIAE NOMHFHBJHNN;

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
		private MGJBGFJBOAN KJEMKFAOGEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup HACNGFAKFLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline FPLODGINKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry PLGGKDIPJGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken FLFPJDDKBGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private HMKENKMGCKF NJBCGCANDHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private JBMBPMKFACE AJGJBJEFCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material DDOGMFCGDFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int EBBNFHFHLAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect FHPILHINDPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int DBIBNPAONKK;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int BCCDFMIDOAE = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private IFAOCLGAAAL ANCAMGAAMAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool APJDOFDCNOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> PAFMCFEHPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<OOJCEGPONLG> NMAFPNLJKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private AADPDICIOOH HGGICIPBOND;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<AADPDICIOOH> BEGDNHGGAGF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer ALGPJOMCAHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E89DC0", Offset = "0x7E885C0", VA = "0x187E89DC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7E89FD0", Offset = "0x7E887D0", VA = "0x187E89FD0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7E89F70", Offset = "0x7E88770", VA = "0x187E89F70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7E88570", Offset = "0x7E86D70", VA = "0x187E88570")]
		private void EELOPNKAMLI(bool KAEKCBFKBNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7E898D0", Offset = "0x7E880D0", VA = "0x187E898D0")]
		private void MKBBMKBAJCP(bool KAEKCBFKBNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7E8A490", Offset = "0x7E88C90", VA = "0x187E8A490")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7E88E50", Offset = "0x7E87650", VA = "0x187E88E50")]
		public void InitMetricsDependencies(MetricIdLookup HACNGFAKFLK, IRawMetricsPipeline FPLODGINKCP, IMetricCollectionRegistry PLGGKDIPJGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7E8A410", Offset = "0x7E88C10", VA = "0x187E8A410")]
		public void SetActiveOverlay(IFAOCLGAAAL BMMBCGBLLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7E88660", Offset = "0x7E86E60", VA = "0x187E88660")]
		private void HAHIGNCEAFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7E89C40", Offset = "0x7E88440", VA = "0x187E89C40")]
		private void NBEDIEPKOEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7E8A000", Offset = "0x7E88800", VA = "0x187E8A000")]
		private void PADGBJDFFHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7E88FD0", Offset = "0x7E877D0", VA = "0x187E88FD0")]
		private void LEMKBGEMPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7E89620", Offset = "0x7E87E20", VA = "0x187E89620")]
		private bool MANGBMJGBJI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7E88140", Offset = "0x7E86940", VA = "0x187E88140")]
		private bool AIACMFCCCKM(bool IOHDICMKADP = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7E88390", Offset = "0x7E86B90", VA = "0x187E88390")]
		private bool EDGOADPBHJA(ODMKKNDLMMG MDFGJCKGNHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7E88D10", Offset = "0x7E87510", VA = "0x187E88D10")]
		private bool IMKCKCDBMGC(ODMKKNDLMMG MDFGJCKGNHP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7E88AE0", Offset = "0x7E872E0", VA = "0x187E88AE0")]
		public void HandleMetric([In] RawMetric FCEEMFMLCKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x24AFD90", Offset = "0x24AE590", VA = "0x1824AFD90")]
		private bool EEEGEDAFBGD(MGJBGFJBOAN JOOBHAOOMOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7E89DA0", Offset = "0x7E885A0", VA = "0x187E89DA0")]
		private bool OLCAIEOOLLM(MGJBGFJBOAN DFKEEJBLEOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7E8A750", Offset = "0x7E88F50", VA = "0x187E8A750")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7E88380", Offset = "0x7E86B80", VA = "0x187E88380", Slot = "4")]
		private void CHAGCPNCJMJ([In] RawMetric FCEEMFMLCKK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class AADPDICIOOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool AHPFEHJBPCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect KNFNBCJDNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout FBFFGBBELBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout HFAPGKKLNJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout CKNBMJBLPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private GKDDNIBEPDL PIAHMMMKEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic PMOOPNOBBPL;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7E87950", Offset = "0x7E86150", VA = "0x187E87950")]
	public void ILJHHMHPGDK(HMKENKMGCKF AFGPFFELHHL, JBMBPMKFACE FLGHPEDPHFL, LayoutRect DKOMNOCLJKD, int OIHCLPNNMEE, [Optional] MetricGraphGraphic PMOOPNOBBPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7E87240", Offset = "0x7E85A40", VA = "0x187E87240")]
	public void EOCNNHOHDCP(float ELHENHPDCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7E873B0", Offset = "0x7E85BB0", VA = "0x187E873B0")]
	public void GHBFKCECCCM(ReadOnlySpan<char> JNEBALLCEFA, ReadOnlySpan<char> APNIEPDKIHO, ReadOnlySpan<char> GFCBOFBMEEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E87020", Offset = "0x7E85820", VA = "0x187E87020")]
	public void BADLDLKFADC(RRColor32 AGNHOOELDII, bool KHIKBGOLGAN = true, bool PCHACIABBHL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7E87550", Offset = "0x7E85D50", VA = "0x187E87550")]
	public float ICJAGABEGIK(float BBJPCBPMGPE, float LNBKGMCFLCJ, float NGKAIKGJAKN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7E88060", Offset = "0x7E86860", VA = "0x187E88060")]
	public void MDOGPDIBLOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7E87520", Offset = "0x7E85D20", VA = "0x187E87520")]
	public void GNLLHNBNNAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7E87170", Offset = "0x7E85970", VA = "0x187E87170")]
	public void CIMPIMGLHGM(LKACEDLCNPG ADHNPFKGNNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7E87190", Offset = "0x7E85990", VA = "0x187E87190")]
	public void EKAJLMLJFJN(LKACEDLCNPG ADHNPFKGNNC, double EGLHBCAIJLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7E87FD0", Offset = "0x7E867D0", VA = "0x187E87FD0")]
	public void LEAAAEHEKEG(double OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7E87E10", Offset = "0x7E86610", VA = "0x187E87E10")]
	public void IMAIJACFOFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public AADPDICIOOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class NOFOPCKABNB
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static IFAOCLGAAAL FPKKCJBPAAC;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static IFAOCLGAAAL ODPCHCAFIEA;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static IFAOCLGAAAL GKOKLMJMMJD;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static IFAOCLGAAAL KNCHNPCIGCD;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static IFAOCLGAAAL FIKCJIGALBI;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static IFAOCLGAAAL BAHDPJKIENK;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static IFAOCLGAAAL CONOIFPANGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7E8AA10", Offset = "0x7E89210", VA = "0x187E8AA10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static IFAOCLGAAAL DJLMGEOFDML
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7E8AAB0", Offset = "0x7E892B0", VA = "0x187E8AAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static IFAOCLGAAAL KCDJFFCMFEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7E8A920", Offset = "0x7E89120", VA = "0x187E8A920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static IFAOCLGAAAL FILNDGHGFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7E8A970", Offset = "0x7E89170", VA = "0x187E8A970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static IFAOCLGAAAL GCCAMPCLOFB
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7E8AA60", Offset = "0x7E89260", VA = "0x187E8AA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static IFAOCLGAAAL NKAMJGPOFGA
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7E8A9C0", Offset = "0x7E891C0", VA = "0x187E8A9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static IFAOCLGAAAL LPJFBAMFBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct GHDACLHPGEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string JIIOGKBLCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string LKKIMDJEMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string BDAJKIPLIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public LKACEDLCNPG LNDKBIIOLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool NDCOLJDNELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool IMDKNMICMJE;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class IFAOCLGAAAL
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string CNEFPHCHBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GHDACLHPGEF[] CNBMCBCELFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9DF700", Offset = "0x9DDF00", VA = "0x1809DF700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public virtual void GJLFMJLLBJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
	public virtual void LJAAKHFDCEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9E57C0", Offset = "0x9E3FC0", VA = "0x1809E57C0")]
	public IFAOCLGAAAL(string OJJDJJMGEHH, GHDACLHPGEF[] LLNEIOJPCKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum FAMLEMMFBGB
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
internal class OOJCEGPONLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private FAMLEMMFBGB BGGCPHHMBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription NGJILJLJLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload JDGDKOENECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter PPPJKDNDGMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double PMPGIBFGJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int PPKAPEFELKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private LKACEDLCNPG ADHNPFKGNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private CBKMBKHOFBF HHKJILBEGKH;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int MNGGDGACNEC = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] JNEBALLCEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] APNIEPDKIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int MFFEKONNCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] GFCBOFBMEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int GJCEJKMJJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string HNCMGBJKIPH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription JKKJPOLJIKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xCF73C0", Offset = "0xCF5BC0", VA = "0x180CF73C0")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7E8CF20", Offset = "0x7E8B720", VA = "0x187E8CF20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public FAMLEMMFBGB KOICLJCKKGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9E9470", Offset = "0x9E7C70", VA = "0x1809E9470")]
		get
		{
			return default(FAMLEMMFBGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> OJBPDCPAAOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7E8CFD0", Offset = "0x7E8B7D0", VA = "0x187E8CFD0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> KEKGKAGIJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7E8D170", Offset = "0x7E8B970", VA = "0x187E8D170")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> BMMMDONNCEN
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7E8D030", Offset = "0x7E8B830", VA = "0x187E8D030")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public CBKMBKHOFBF JCICEPGANMD
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB9D4B0", Offset = "0xB9BCB0", VA = "0x180B9D4B0")]
		get
		{
			return default(CBKMBKHOFBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double AOGBEDOCNBN
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7E8CFA0", Offset = "0x7E8B7A0", VA = "0x187E8CFA0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float GLOMHFMIOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7E8D110", Offset = "0x7E8B910", VA = "0x187E8D110")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float CMIIJIPBHME
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xBEBA20", Offset = "0xBEA220", VA = "0x180BEBA20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xC2EAC0", Offset = "0xC2D2C0", VA = "0x180C2EAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool OANGAACOOMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x110C0D0", Offset = "0x110A8D0", VA = "0x18110C0D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1326130", Offset = "0x1324930", VA = "0x181326130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public LKACEDLCNPG LNDKBIIOLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9DD230", Offset = "0x9DBA30", VA = "0x1809DD230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7E8D250", Offset = "0x7E8BA50", VA = "0x187E8D250")]
	public OOJCEGPONLG(string JNGEILKPDIM, [Optional] MetricDescription NGJILJLJLHP, [Optional] LKACEDLCNPG ADHNPFKGNNC, bool DHHJJIFFPDG = true, bool CJFCECJOHLA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7E8CE30", Offset = "0x7E8B630", VA = "0x187E8CE30")]
	public void ELHBNLHMGNC(RawMetricPayload JPLMFIAHHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7E8CBB0", Offset = "0x7E8B3B0", VA = "0x187E8CBB0")]
	public bool DKBLPGCEFDC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E8C7D0", Offset = "0x7E8AFD0", VA = "0x187E8C7D0")]
	public bool CGDDDCCFGDB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x699FD60", Offset = "0x699E560", VA = "0x18699FD60")]
	public void KFKFHDOALAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x698E1B0", Offset = "0x698C9B0", VA = "0x18698E1B0")]
	public void GGHJDFKICKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7E8D120", Offset = "0x7E8B920", VA = "0x187E8D120")]
	private static int NONONDIPCHO(MetricDataUnits CFHONBHGGLO)
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
