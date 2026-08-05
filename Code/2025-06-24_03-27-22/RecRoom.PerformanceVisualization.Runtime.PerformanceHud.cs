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
	public class LogRegistrationIndex : KHEEPBINELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x817D450", Offset = "0x817C050", VA = "0x18817D450", Slot = "4")]
		public override void KHPGHNAFBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		private enum LLDKPIGCNFE
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
		private static readonly JPIBGNDAFKP FAOMHPPHFKM;

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
		private LLDKPIGCNFE LBGNBDPOHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup AEIDGCCMMOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline MOFBEJBHEDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry EAKFKNJLEDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken IMEICHJMBHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private MBEHDOBMBBA HHGLPJCDOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private IIPEFHOAJJE GEBMIGMDIOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material CLAJOBFPDGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int LDGLGKEABOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect OMPCBNPJALD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int DOBODADCCAH;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int FMCENENIPGL = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private KIDNIAJGKDG LAMHJMIIDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool ILMGEAPJLKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> EKFKAIAPNNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<CFOBMKLCMOO> AECCDAKOJAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private LNJLENDOGDC AMHGHJINBAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<LNJLENDOGDC> MKCEPIMPKED;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer CNCMCOAKICN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x817F5E0", Offset = "0x817E1E0", VA = "0x18817F5E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x817F7F0", Offset = "0x817E3F0", VA = "0x18817F7F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x817F790", Offset = "0x817E390", VA = "0x18817F790")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x817E2F0", Offset = "0x817CEF0", VA = "0x18817E2F0")]
		private void FPENOAEGOMC(bool BBEABHHBLEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x817F130", Offset = "0x817DD30", VA = "0x18817F130")]
		private void OBFMOILEGEO(bool BBEABHHBLEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x817F8A0", Offset = "0x817E4A0", VA = "0x18817F8A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x817EB00", Offset = "0x817D700", VA = "0x18817EB00")]
		public void InitMetricsDependencies(MetricIdLookup AEIDGCCMMOC, IRawMetricsPipeline MOFBEJBHEDL, IMetricCollectionRegistry EAKFKNJLEDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x817F820", Offset = "0x817E420", VA = "0x18817F820")]
		public void SetActiveOverlay(KIDNIAJGKDG POGNBOBMLNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x817EC80", Offset = "0x817D880", VA = "0x18817EC80")]
		private void LADICBEBJPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x817E190", Offset = "0x817CD90", VA = "0x18817E190")]
		private void FNIONENCFJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x817D4F0", Offset = "0x817C0F0", VA = "0x18817D4F0")]
		private void BNICLPAPGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x817D900", Offset = "0x817C500", VA = "0x18817D900")]
		private void DBHMMAFNLON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x817E620", Offset = "0x817D220", VA = "0x18817E620")]
		private bool HNHEKGMJMEP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x817E3E0", Offset = "0x817CFE0", VA = "0x18817E3E0")]
		private bool HIKDGOJCDLF(bool JMDCPKFBLOI = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x817DFB0", Offset = "0x817CBB0", VA = "0x18817DFB0")]
		private bool EPJPLPBDLOL(MKAFIIICDOL GBEGHJIHKEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x817F4A0", Offset = "0x817E0A0", VA = "0x18817F4A0")]
		private bool OMDMBBNMCOP(MKAFIIICDOL GBEGHJIHKEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x817E8D0", Offset = "0x817D4D0", VA = "0x18817E8D0")]
		public void HandleMetric([In] RawMetric FGHAAPDHJIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x817D4E0", Offset = "0x817C0E0", VA = "0x18817D4E0")]
		private bool ABIKHFCOJML(LLDKPIGCNFE GGMLDDKJDMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x817F100", Offset = "0x817DD00", VA = "0x18817F100")]
		private bool LNNDLKJJLLO(LLDKPIGCNFE JNEOJBBHOLC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x817FB60", Offset = "0x817E760", VA = "0x18817FB60")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x817F120", Offset = "0x817DD20", VA = "0x18817F120", Slot = "4")]
		private void NOJNHMFFEBC([In] RawMetric FGHAAPDHJIG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class LNJLENDOGDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool NJMHJJDFLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect BPOHMPINOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout MKKPAOIFNNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout MNGKKGMGLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout DNIIFCIPMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private EPCLPGODANF KMCHPHCIHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic AABPMKCCGLJ;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x817CD40", Offset = "0x817B940", VA = "0x18817CD40")]
	public void GFFHNKPMBNJ(MBEHDOBMBBA NIFEOKBAKJA, IIPEFHOAJJE GFKGKHJDCJC, LayoutRect CEDHPIPOMIP, int LLLIMENDBLI, [Optional] MetricGraphGraphic AABPMKCCGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x817C5D0", Offset = "0x817B1D0", VA = "0x18817C5D0")]
	public void CBICMBPLNJE(float EHAEEOFAINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x817C740", Offset = "0x817B340", VA = "0x18817C740")]
	public void EBGCFCNDBKC(ReadOnlySpan<char> ODPKOFGMLEA, ReadOnlySpan<char> DLAPJPKLJLM, ReadOnlySpan<char> GPIEJNJCJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x817D300", Offset = "0x817BF00", VA = "0x18817D300")]
	public void KKKGLGNANPI(RRColor32 GCKOLKABAJC, bool KHBGPMHOBHC = true, bool DHNOKHECPKB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x817C940", Offset = "0x817B540", VA = "0x18817C940")]
	public float FILILECAGOA(float GBALKOHHFHM, float JJEEGAHMMIC, float LGDDFCBGJAB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x817C580", Offset = "0x817B180", VA = "0x18817C580")]
	public void BBPBOOPDDAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x817D200", Offset = "0x817BE00", VA = "0x18817D200")]
	public void IMDDMLJJING()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x817D2E0", Offset = "0x817BEE0", VA = "0x18817D2E0")]
	public void JJOOLMKCHLA(BKNAHPEDEJK NHABGNKKLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x817D230", Offset = "0x817BE30", VA = "0x18817D230")]
	public void JDDCNJHKIDD(BKNAHPEDEJK NHABGNKKLBC, double LHHOCCKJGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x817C8B0", Offset = "0x817B4B0", VA = "0x18817C8B0")]
	public void EMLLCAKPCLD(double OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x817C360", Offset = "0x817AF60", VA = "0x18817C360")]
	public void AJLHHIGEIBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public LNJLENDOGDC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GMFNDGALELH
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static KIDNIAJGKDG EAEHPMPJNLP;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static KIDNIAJGKDG OBKBPFIIACN;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static KIDNIAJGKDG BNGBNPAJNDG;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static KIDNIAJGKDG NAHGALKHMIN;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static KIDNIAJGKDG DGCIHAKJJJM;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static KIDNIAJGKDG PPOFNDGBEPL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static KIDNIAJGKDG DIACPKGMELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x817A4B0", Offset = "0x81790B0", VA = "0x18817A4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static KIDNIAJGKDG JFHHPHCKBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x817A550", Offset = "0x8179150", VA = "0x18817A550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static KIDNIAJGKDG EKBLNAALDOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x817A640", Offset = "0x8179240", VA = "0x18817A640")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static KIDNIAJGKDG BDOHCINFKPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x817A5A0", Offset = "0x81791A0", VA = "0x18817A5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static KIDNIAJGKDG JOPICHODJOD
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x817A5F0", Offset = "0x81791F0", VA = "0x18817A5F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static KIDNIAJGKDG EPIPPFHDMIG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x817A500", Offset = "0x8179100", VA = "0x18817A500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static KIDNIAJGKDG OJPJEFDMLFK
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct HFIJJGAMFAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string MCDCEPOBKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string MCICINEHEEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string EDCGFHFCIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public BKNAHPEDEJK BEJMADJMEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool DOEFPNEOGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool JMLFLAEIJNE;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class KIDNIAJGKDG
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string HPEJAOCAAFG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB20", Offset = "0xA1D720", VA = "0x180A1EB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public HFIJJGAMFAE[] KALGHJJEJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
	public virtual void EGAAANLLCIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
	public virtual void EODLOBIPBGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0xA20DD0", Offset = "0xA1F9D0", VA = "0x180A20DD0")]
	public KIDNIAJGKDG(string CBBHDDJIAGB, HFIJJGAMFAE[] KILPGNGNIOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum CGDCAOPNCKD
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
internal class CFOBMKLCMOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private CGDCAOPNCKD MLEOHCHALOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription EKIPKOCBLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload ADKJHPADFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter HLAKGKHDPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double LMJHLMJIAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int FCIDCIIDFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private BKNAHPEDEJK NHABGNKKLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private AAJGBGIBFDI EIJJHMEBICK;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int AGGNJINKFGC = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] ODPKOFGMLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] DLAPJPKLJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int LLENAEACHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] GPIEJNJCJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int DKABBNLCDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string GLJLABAKCEL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription EFDDLCHGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xDD35D0", Offset = "0xDD21D0", VA = "0x180DD35D0")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x81798D0", Offset = "0x81784D0", VA = "0x1881798D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public CGDCAOPNCKD IDNBGCCFFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA217D0", Offset = "0xA203D0", VA = "0x180A217D0")]
		get
		{
			return default(CGDCAOPNCKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> IKNNEOAMJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8179DF0", Offset = "0x81789F0", VA = "0x188179DF0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> HAGBHKLKNAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8179950", Offset = "0x8178550", VA = "0x188179950")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> APPNKDLKNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x81797F0", Offset = "0x81783F0", VA = "0x1881797F0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AAJGBGIBFDI DLPNGOOEJFH
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xC76B00", Offset = "0xC75700", VA = "0x180C76B00")]
		get
		{
			return default(AAJGBGIBFDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double KECALCKHIEG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x81797B0", Offset = "0x81783B0", VA = "0x1881797B0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float EFAOFLMCLBN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x81797E0", Offset = "0x81783E0", VA = "0x1881797E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float JGPAOMEMAGH
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xCBD280", Offset = "0xCBBE80", VA = "0x180CBD280")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xD02870", Offset = "0xD01470", VA = "0x180D02870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool GGELOCNDLJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x11D3510", Offset = "0x11D2110", VA = "0x1811D3510")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x14CCE70", Offset = "0x14CBA70", VA = "0x1814CCE70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public BKNAHPEDEJK BEJMADJMEDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA1C6E0", Offset = "0xA1B2E0", VA = "0x180A1C6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x817A2F0", Offset = "0x8178EF0", VA = "0x18817A2F0")]
	public CFOBMKLCMOO(string LPICFBBADAO, [Optional] MetricDescription EKIPKOCBLEI, [Optional] BKNAHPEDEJK NHABGNKKLBC, bool CLFMAAHOAOI = true, bool HGEKBOBJHDH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8179A30", Offset = "0x8178630", VA = "0x188179A30")]
	public void KHKFACCCLLP(RawMetricPayload INFOGHGKDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8179B20", Offset = "0x8178720", VA = "0x188179B20")]
	public bool OGBFDHKCJOA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8179E50", Offset = "0x8178A50", VA = "0x188179E50")]
	public bool OOGFLNOFIHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8980", Offset = "0x6BD7580", VA = "0x186BD8980")]
	public void HJPGIOGJOOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8970", Offset = "0x6BD7570", VA = "0x186BD8970")]
	public void DABEDBPCJLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8179DA0", Offset = "0x81789A0", VA = "0x188179DA0")]
	private static int ONJKDDPNGJB(MetricDataUnits HBBGKFDIFOF)
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
