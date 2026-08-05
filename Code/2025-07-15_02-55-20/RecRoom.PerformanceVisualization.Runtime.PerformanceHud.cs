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
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84C03A0", Offset = "0x84BEFA0", VA = "0x1884C03A0", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		private enum GHGNBBFOOKG
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
		private static readonly PEOHNMCPNIJ GDLIBGFAMED;

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
		private GHGNBBFOOKG DPOOMHDCPJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup HCCIJAEOHJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline PNPMGIEECHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry FCLBBEELHOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken JPEEANIAIDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private OHMKEHFIPMC LMOALOOIHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private BLDDMEAJIMC LOJDOOLACBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material NKFHJGJGOMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int DECMLBMGEIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect KJDKLNDIEIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int GDOFDBIKBBO;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int JMJPDNDBLHK = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private FMPIJGOHDBB GOCEAENJCHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool OBDDEECLBBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> CCMOOMPODMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<JNNKDFNGLBA> EEGGGFFOPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private CICMAMMMECC JGMDLAECCEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<CICMAMMMECC> FDPDLNDEFIB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer HLHKGGKPEKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84C2530", Offset = "0x84C1130", VA = "0x1884C2530")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x84C2740", Offset = "0x84C1340", VA = "0x1884C2740")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84C26E0", Offset = "0x84C12E0", VA = "0x1884C26E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84C2120", Offset = "0x84C0D20", VA = "0x1884C2120")]
		private void MMMNMODCODO(bool LIJLDHJAPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84C18B0", Offset = "0x84C04B0", VA = "0x1884C18B0")]
		private void JKAMHOGDKJK(bool LIJLDHJAPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84C2810", Offset = "0x84C1410", VA = "0x1884C2810")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84C1290", Offset = "0x84BFE90", VA = "0x1884C1290")]
		public void InitMetricsDependencies(MetricIdLookup HCCIJAEOHJH, IRawMetricsPipeline PNPMGIEECHG, IMetricCollectionRegistry FCLBBEELHOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84C2790", Offset = "0x84C1390", VA = "0x1884C2790")]
		public void SetActiveOverlay(FMPIJGOHDBB DNIKBLMKNOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84C1420", Offset = "0x84C0020", VA = "0x1884C1420")]
		private void JFPFPKIJKFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84C0430", Offset = "0x84BF030", VA = "0x1884C0430")]
		private void AKIJMGNDDLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84C0C50", Offset = "0x84BF850", VA = "0x1884C0C50")]
		private void GCNIEOKMCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84C0590", Offset = "0x84BF190", VA = "0x1884C0590")]
		private void DKGIPDHNGAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84C1E70", Offset = "0x84C0A70", VA = "0x1884C1E70")]
		private bool MKCDCGAHOJO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84C1C20", Offset = "0x84C0820", VA = "0x1884C1C20")]
		private bool JLIKDFIBFED(bool GPAPPOJDLEG = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84C2350", Offset = "0x84C0F50", VA = "0x1884C2350")]
		private bool OJBDDJMHKGJ(NEOMIGFJGAA NDMEBHICHPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84C2210", Offset = "0x84C0E10", VA = "0x1884C2210")]
		private bool OAFCDIAIPFP(NEOMIGFJGAA NDMEBHICHPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84C1060", Offset = "0x84BFC60", VA = "0x1884C1060")]
		public void HandleMetric([In] RawMetric HJPHCMEPGEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84C0C40", Offset = "0x84BF840", VA = "0x1884C0C40")]
		private bool DLMNMPIBOKE(GHGNBBFOOKG JNGFEOOLNKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84C2770", Offset = "0x84C1370", VA = "0x1884C2770")]
		private bool PMNLHININCG(GHGNBBFOOKG MDDBFFNBNCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84C2AD0", Offset = "0x84C16D0", VA = "0x1884C2AD0")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x84C1E60", Offset = "0x84C0A60", VA = "0x1884C1E60", Slot = "4")]
		private void MCOFBLLADMH([In] RawMetric HJPHCMEPGEK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class CICMAMMMECC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool DLMILAHHEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect NAEEEAJKFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout OOJPHDKAKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout GNHBKJIFENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout CNEHEPPHCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private BFFGNPBLLEH GJJBKIJCDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic FOHNLBLKMNF;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x84BE920", Offset = "0x84BD520", VA = "0x1884BE920")]
	public void CBACPPGGEHG(OHMKEHFIPMC AFANPLKLCCM, BLDDMEAJIMC BNOGIAIAFOI, LayoutRect KHFILFMFLIO, int KCBPICFEFCP, [Optional] MetricGraphGraphic FOHNLBLKMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x84BEE70", Offset = "0x84BDA70", VA = "0x1884BEE70")]
	public void FABLGGAEEMA(float GKIDLCDIFJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x84BE7B0", Offset = "0x84BD3B0", VA = "0x1884BE7B0")]
	public void BOMCCIGFAOG(ReadOnlySpan<char> HONNDIFCEMH, ReadOnlySpan<char> NMBHMBCHOMO, ReadOnlySpan<char> EOOBMMOLDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84BE5B0", Offset = "0x84BD1B0", VA = "0x1884BE5B0")]
	public void ABHMHACIFFK(RRColor32 MGBNCENPLKH, bool BFLCKINPCEO = true, bool HAENPIBAJGB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84BEFE0", Offset = "0x84BDBE0", VA = "0x1884BEFE0")]
	public float KGBJEOJAJBH(float AFGOOKBIOBP, float FIPHNKIOJIC, float PNJHFPHAFJC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x84BF430", Offset = "0x84BE030", VA = "0x1884BF430")]
	public void NBEBMJAEJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x84BF3E0", Offset = "0x84BDFE0", VA = "0x1884BF3E0")]
	public void KGKIPPHJCCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x84BF410", Offset = "0x84BE010", VA = "0x1884BF410")]
	public void LICMCKAMPBM(AFNAPECJHIF OENAKNNAHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x84BE700", Offset = "0x84BD300", VA = "0x1884BE700")]
	public void BANOCFGBOME(AFNAPECJHIF OENAKNNAHBL, double ECJMFFOLCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x84BEDE0", Offset = "0x84BD9E0", VA = "0x1884BEDE0")]
	public void CJLGJMOKJBB(double BKMPCFIAHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x84BF480", Offset = "0x84BE080", VA = "0x1884BF480")]
	public void OCPEIGBLBFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	public CICMAMMMECC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PJPEGHMJDAK
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static FMPIJGOHDBB EOIFCLICGGP;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static FMPIJGOHDBB AIPNKDPIPOM;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static FMPIJGOHDBB NBANMGIMNMA;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static FMPIJGOHDBB JGEBNIHBOAI;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static FMPIJGOHDBB LAOLANENBPA;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static FMPIJGOHDBB INICMMMAMBI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static FMPIJGOHDBB JOFMPALJJOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84C2CF0", Offset = "0x84C18F0", VA = "0x1884C2CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static FMPIJGOHDBB BNFLPAOFCGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84C2D90", Offset = "0x84C1990", VA = "0x1884C2D90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static FMPIJGOHDBB HJGPOKGAGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84C2E30", Offset = "0x84C1A30", VA = "0x1884C2E30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static FMPIJGOHDBB OGINHKPIEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84C2D40", Offset = "0x84C1940", VA = "0x1884C2D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static FMPIJGOHDBB MAMNJDJEGJM
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84C2CA0", Offset = "0x84C18A0", VA = "0x1884C2CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static FMPIJGOHDBB IHIFFGECOLH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x84C2DE0", Offset = "0x84C19E0", VA = "0x1884C2DE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static FMPIJGOHDBB GDNEKIIBCIC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct HHMFIFDNMKN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string GCHBBDJLFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string ALDGPKKMHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string JEDFFEIDNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public AFNAPECJHIF HFIGNLGGGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool LBJBLAJGJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool FDAANAGJOLG;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FMPIJGOHDBB
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string KAGGCCJCGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public HHMFIFDNMKN[] EHPLKBMGBAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "4")]
	public virtual void FDKJDKIDOAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
	public virtual void BGCIKJKGLKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA67BC0", Offset = "0xA667C0", VA = "0x180A67BC0")]
	public FMPIJGOHDBB(string JNKLGPOIBON, HHMFIFDNMKN[] DHFMGAINMIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum IHCGMDFFGPD
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
internal class JNNKDFNGLBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private IHCGMDFFGPD JNPLLAKLLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription JKGONHGBCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload HGBKIACHBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter POFGAICPFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double BECHMOLJOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int JBHAOAGCFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private AFNAPECJHIF OENAKNNAHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private DEGMIAEPLMM OKFEFPIIPDO;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int JCEGDAEDLFD = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] HONNDIFCEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] NMBHMBCHOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int AGMOKFGEPDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] EOOBMMOLDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int KBPDJPHMHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string OCLGABBHKCC;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription ENHEMOEELFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xE4A620", Offset = "0xE49220", VA = "0x180E4A620")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x84BF730", Offset = "0x84BE330", VA = "0x1884BF730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public IHCGMDFFGPD CEIEKNGOJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA5EBA0", Offset = "0xA5D7A0", VA = "0x180A5EBA0")]
		get
		{
			return default(IHCGMDFFGPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> KCKAKMIMBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84BF6D0", Offset = "0x84BE2D0", VA = "0x1884BF6D0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> FONPAJEKHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84C0100", Offset = "0x84BED00", VA = "0x1884C0100")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> PIBHGCHMMCP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x84BF8A0", Offset = "0x84BE4A0", VA = "0x1884BF8A0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public DEGMIAEPLMM NNCHGOAHDAA
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xCE49B0", Offset = "0xCE35B0", VA = "0x180CE49B0")]
		get
		{
			return default(DEGMIAEPLMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double JGJMBAOMDHK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x84BF6A0", Offset = "0x84BE2A0", VA = "0x1884BF6A0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float APFGOAMONAL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x84BFE70", Offset = "0x84BEA70", VA = "0x1884BFE70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float CKFKKNLMHDC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xD2BA80", Offset = "0xD2A680", VA = "0x180D2BA80")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xD6A3F0", Offset = "0xD68FF0", VA = "0x180D6A3F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool PAJEPHACIHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1282590", Offset = "0x1281190", VA = "0x181282590")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x157BBB0", Offset = "0x157A7B0", VA = "0x18157BBB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public AFNAPECJHIF HFIGNLGGGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA5B530", Offset = "0xA5A130", VA = "0x180A5B530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x84C01E0", Offset = "0x84BEDE0", VA = "0x1884C01E0")]
	public JNNKDFNGLBA(string JOMHOLNGBJJ, [Optional] MetricDescription JKGONHGBCMI, [Optional] AFNAPECJHIF OENAKNNAHBL, bool HKNJFNPNLDM = true, bool PCFLGNAGCEE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x84BF7B0", Offset = "0x84BE3B0", VA = "0x1884BF7B0")]
	public void EBFEDHPMBEI(RawMetricPayload JDINPMLJGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x84BFE80", Offset = "0x84BEA80", VA = "0x1884BFE80")]
	public bool NJLKKELMFFK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x84BF980", Offset = "0x84BE580", VA = "0x1884BF980")]
	public bool IJKNNJPOPGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8F10", Offset = "0x6EC7B10", VA = "0x186EC8F10")]
	public void ICAHLMDMGKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6EC8F00", Offset = "0x6EC7B00", VA = "0x186EC8F00")]
	public void IJFKJOMABMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x84BFE20", Offset = "0x84BEA20", VA = "0x1884BFE20")]
	private static int KANOACHDJJF(MetricDataUnits FGIOPIHFMOK)
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
