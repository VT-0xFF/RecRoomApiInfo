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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7FB95B0", Offset = "0x7FB7BB0", VA = "0x187FB95B0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		private enum DCFICPBNKMF
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
		private static readonly JBBHIJHGEPM PAJIGEJCNAP;

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
		private DCFICPBNKMF KLDHMLLFEDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup INBNFFMHJEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline JJFPHLJHIDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry KKOGMOAFABK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken ANFLIMPPGPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private PEFFLCIMHDG MBBELFLHNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private LBCCJIKLLIH LDPBMOMKJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material MGHEDOGIMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int PENHOPFGHKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect KGFKPONMFJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int MKONHPEECIG;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int OKIGOEBMPJE = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private OECFJEGJOBD GCMJFGMCMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool PFKLJDHKOEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> JOBCJGAFPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<CIMKEHICIMA> HGIEIKLELPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private PEBPHJCBIGN FEOALGEIBCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<PEBPHJCBIGN> NMCFECCEJBG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer DIIDLMBLFDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7FBB6C0", Offset = "0x7FB9CC0", VA = "0x187FBB6C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7FBB8D0", Offset = "0x7FB9ED0", VA = "0x187FBB8D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7FBB870", Offset = "0x7FB9E70", VA = "0x187FBB870")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7FBA6D0", Offset = "0x7FB8CD0", VA = "0x187FBA6D0")]
		private void ICNHCGPIPGB(bool LMILHBBDLAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7FBA130", Offset = "0x7FB8730", VA = "0x187FBA130")]
		private void HNLOEIPGKKI(bool LMILHBBDLAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7FBB9A0", Offset = "0x7FB9FA0", VA = "0x187FBB9A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7FBAA00", Offset = "0x7FB9000", VA = "0x187FBAA00")]
		public void InitMetricsDependencies(MetricIdLookup INBNFFMHJEA, IRawMetricsPipeline JJFPHLJHIDL, IMetricCollectionRegistry KKOGMOAFABK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7FBB920", Offset = "0x7FB9F20", VA = "0x187FBB920")]
		public void SetActiveOverlay(OECFJEGJOBD EMMOIOHPMEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9650", Offset = "0x7FB7C50", VA = "0x187FB9650")]
		private void COFHKDGFKNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7FBAB80", Offset = "0x7FB9180", VA = "0x187FBAB80")]
		private void JAIGPAGEBNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7FBB000", Offset = "0x7FB9600", VA = "0x187FBB000")]
		private void KOPNFACLCIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9AE0", Offset = "0x7FB80E0", VA = "0x187FB9AE0")]
		private void FHDJEBCDAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7FBB410", Offset = "0x7FB9A10", VA = "0x187FBB410")]
		private bool MDDPHGHMLCH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7FBA7C0", Offset = "0x7FB8DC0", VA = "0x187FBA7C0")]
		private bool IEHAKJECEPD(bool ECOALLGHBMI = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7FBACE0", Offset = "0x7FB92E0", VA = "0x187FBACE0")]
		private bool JCFDGACIGEB(BMGOKABNDBN NEKLMLONNIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7FBAEC0", Offset = "0x7FB94C0", VA = "0x187FBAEC0")]
		private bool JIPKBMBADPB(BMGOKABNDBN NEKLMLONNIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7FBA4A0", Offset = "0x7FB8AA0", VA = "0x187FBA4A0")]
		public void HandleMetric([In] RawMetric MLELCPMIOKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9640", Offset = "0x7FB7C40", VA = "0x187FB9640")]
		private bool CDDIFNKCICP(DCFICPBNKMF HNJKBNOFGGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7FBB900", Offset = "0x7FB9F00", VA = "0x187FBB900")]
		private bool PIKHHADHFNG(DCFICPBNKMF AHOHIOJOJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7FBBC60", Offset = "0x7FBA260", VA = "0x187FBBC60")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7FB9AD0", Offset = "0x7FB80D0", VA = "0x187FB9AD0", Slot = "4")]
		private void EAIEGMODDOP([In] RawMetric MLELCPMIOKG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class PEBPHJCBIGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool GPFLCKAMNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect BPKPKMBJPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout IDAHEEBOMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout IOOGDNIGECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout NCDKHFENPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private ILPBOLFDEHJ OOPCIGKEPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic HLALLAJBCAP;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC160", Offset = "0x7FBA760", VA = "0x187FBC160")]
	public void EEBICEODLFH(PEFFLCIMHDG KKHHLFGOJKA, LBCCJIKLLIH CJEJLMOKIJP, LayoutRect LPEBOHKPPLK, int FFEEENCEKHD, [Optional] MetricGraphGraphic HLALLAJBCAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7FBBFF0", Offset = "0x7FBA5F0", VA = "0x187FBBFF0")]
	public void CKCJODOBHGA(float KCGHGEMMBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC640", Offset = "0x7FBAC40", VA = "0x187FBC640")]
	public void HKPHEMHFCJA(ReadOnlySpan<char> BDBFLBOFBGM, ReadOnlySpan<char> JOMJFHPECGD, ReadOnlySpan<char> IFOGOAJKPOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC860", Offset = "0x7FBAE60", VA = "0x187FBC860")]
	public void NCHIIEBDCAC(RRColor32 NGGKCKILBNF, bool KGPKLOLMHJP = true, bool ODKBGFHHOEL = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7FBCA40", Offset = "0x7FBB040", VA = "0x187FBCA40")]
	public float OJOENHCGAOD(float EHDMIOIKIEO, float HMIIOIJEMAD, float JGOPNKDMDLP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7FBCE40", Offset = "0x7FBB440", VA = "0x187FBCE40")]
	public void PHAHACDDDPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7FBCE90", Offset = "0x7FBB490", VA = "0x187FBCE90")]
	public void PLPNMLHBNIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC620", Offset = "0x7FBAC20", VA = "0x187FBC620")]
	public void HEKHCLGNNOF(PENBDDEPHJF GNEJMIHLKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC7B0", Offset = "0x7FBADB0", VA = "0x187FBC7B0")]
	public void MDENNHDEEPA(PENBDDEPHJF GNEJMIHLKNH, double HDLKNIPAJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC9B0", Offset = "0x7FBAFB0", VA = "0x187FBC9B0")]
	public void NGIILNODBNM(double OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7FBBE30", Offset = "0x7FBA430", VA = "0x187FBBE30")]
	public void AOJNBLCPAHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public PEBPHJCBIGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class IPBFBPKNBHE
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static OECFJEGJOBD NAKOIJFBHBG;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static OECFJEGJOBD KAFALOFFMKL;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static OECFJEGJOBD AOHFGKADPDG;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static OECFJEGJOBD PCPEONBODGO;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static OECFJEGJOBD NKLOFMKGMOJ;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static OECFJEGJOBD LKGMOKFCDLC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static OECFJEGJOBD OPJKGEJPJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7FB77F0", Offset = "0x7FB5DF0", VA = "0x187FB77F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static OECFJEGJOBD PGKCFGLPMJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7750", Offset = "0x7FB5D50", VA = "0x187FB7750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static OECFJEGJOBD IPIFELKLKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7890", Offset = "0x7FB5E90", VA = "0x187FB7890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static OECFJEGJOBD DLCKGCBEDPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7FB77A0", Offset = "0x7FB5DA0", VA = "0x187FB77A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static OECFJEGJOBD KPIPOGFJIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7840", Offset = "0x7FB5E40", VA = "0x187FB7840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static OECFJEGJOBD NPPIJMMJMFN
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7700", Offset = "0x7FB5D00", VA = "0x187FB7700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static OECFJEGJOBD DDKBOEFIDNL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9EA230", Offset = "0x9E8830", VA = "0x1809EA230")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct DHHDFFACBLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string IBENKHKLJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string AGDDMBFJAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string AFLPCNNBMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public PENBDDEPHJF BBALHJGNFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool HALGBIGEKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool AGACBLHNLJA;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class OECFJEGJOBD
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string GDDJONJKHPG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DHHDFFACBLL[] ONFBCHHKPHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public virtual void LJIJJAJPLLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
	public virtual void GODLCNFDGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9F85E0", Offset = "0x9F6BE0", VA = "0x1809F85E0")]
	public OECFJEGJOBD(string PAGMGOCFAHK, DHHDFFACBLL[] PKCEJFAFCCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum CGHLJEMHEGI
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
internal class CIMKEHICIMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private CGHLJEMHEGI EPMOPIGFAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription FOHPKJNICFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload DGHLABNPIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter GKICDPOEBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double MGFEIANCEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int KKIFCIBKGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private PENBDDEPHJF GNEJMIHLKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private GKEOMODKLJM HMJGPNLJPCO;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int HKPHJPOMOJB = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] BDBFLBOFBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] JOMJFHPECGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int CCDGKEMFPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] IFOGOAJKPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int IOPEJFJGIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string FINOACPAHKN;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription OPGKLNIMCIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xD316E0", Offset = "0xD2FCE0", VA = "0x180D316E0")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7FB6D40", Offset = "0x7FB5340", VA = "0x187FB6D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public CGHLJEMHEGI GBCILPNOMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2A0", Offset = "0x9EB8A0", VA = "0x1809ED2A0")]
		get
		{
			return default(CGHLJEMHEGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> OOOCOBIOIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7FB6BB0", Offset = "0x7FB51B0", VA = "0x187FB6BB0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> MFFFOPKHFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7450", Offset = "0x7FB5A50", VA = "0x187FB7450")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> FBFBMAHEPIA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7FB6C10", Offset = "0x7FB5210", VA = "0x187FB6C10")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public GKEOMODKLJM KADMOFAEKBO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xBD3490", Offset = "0xBD1A90", VA = "0x180BD3490")]
		get
		{
			return default(GKEOMODKLJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double HMEMKKBJLGE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7420", Offset = "0x7FB5A20", VA = "0x187FB7420")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float JMGJBKHMNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7FB7530", Offset = "0x7FB5B30", VA = "0x187FB7530")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float LAICHPNAIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xC19D70", Offset = "0xC18370", VA = "0x180C19D70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xC6F490", Offset = "0xC6DA90", VA = "0x180C6F490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool JEIEDEILPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1132F70", Offset = "0x1131570", VA = "0x181132F70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1372D50", Offset = "0x1371350", VA = "0x181372D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public PENBDDEPHJF BBALHJGNFKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9EE700", Offset = "0x9ECD00", VA = "0x1809EE700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7FB7540", Offset = "0x7FB5B40", VA = "0x187FB7540")]
	public CIMKEHICIMA(string EKPIAKIDDJI, [Optional] MetricDescription FOHPKJNICFA, [Optional] PENBDDEPHJF GNEJMIHLKNH, bool OLKBBBLMKNC = true, bool EDHDIDGKPBN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7FB6AC0", Offset = "0x7FB50C0", VA = "0x187FB6AC0")]
	public void ANKEGOPKPDC(RawMetricPayload KCEIIGBJLLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7FB6DC0", Offset = "0x7FB53C0", VA = "0x187FB6DC0")]
	public bool DMNJADNLCPF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7FB7040", Offset = "0x7FB5640", VA = "0x187FB7040")]
	public bool ICIKHJOHLJF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6A96DE0", Offset = "0x6A953E0", VA = "0x186A96DE0")]
	public void CLPFFDIBILB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6A85230", Offset = "0x6A83830", VA = "0x186A85230")]
	public void MENDAFDOJEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7FB6CF0", Offset = "0x7FB52F0", VA = "0x187FB6CF0")]
	private static int CNLCBMCKJFN(MetricDataUnits NILKHNKDICM)
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
