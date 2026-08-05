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
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_PerformanceVisualization_NoEngine_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : OACCHOKJOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x70873C0", Offset = "0x70867C0", VA = "0x1870873C0", Slot = "4")]
		public override void PFLPBBOAAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Utils.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class MetricHudDisplay : MonoBehaviour, IRawMetricsSubscriber, IMetricsSubscriber<RawMetric>
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[Flags]
		private enum AJGKDLFDFBK
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
			LayoutStatesInit = 8,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			MetricStatesInit = 4,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			AllStatesInit = 0xC,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			AllInit = 0xF
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly EGGMDNJPOBA PENMIFMGOLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public MeshBufferRenderer MeshBufferRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public RectTransform RenderAreaRectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Material Mat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public GlyphMapAsset GlyphMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Min(4f)]
		public int FontSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private int PCLEAAOIEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Space]
		public bool debugDraw;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public bool printMeshTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x42")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public bool printMeshState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private AJGKDLFDFBK BCOJLKEJKPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup CABIDHJABOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline OGMFJKKEBMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry OJOHACKGDMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken ELKKAMIKNGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private GEJIGLEOFAM JBGPELDGLNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private PLDMCPGBJEG NLDHGNFLOBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private HINJFOEJADG CGPFIJIBGNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private Material MOJBEILMNDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int AJBPJNNHEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private LayoutRect PGMKOMMBIAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<MetricId> KKLAAEMLHPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<BELLAFMCMIB> KDMMHDAIKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private List<BLFFACIIBBB> LJEDIIDMDGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<TextSegmentLayout> GKPOHGJGDIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<AHCCFOPHHAB> ENNNAGMKBIP;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static List<(string source, string metric)> NNDENKPMDDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int OHALNPGGGOM;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7089190", Offset = "0x7088590", VA = "0x187089190")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7089290", Offset = "0x7088690", VA = "0x187089290")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7089200", Offset = "0x7088600", VA = "0x187089200")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7087450", Offset = "0x7086850", VA = "0x187087450")]
		private void ADGDINJGGHP(bool EEDHLEFEMGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x70887D0", Offset = "0x7087BD0", VA = "0x1870887D0")]
		private void LBPPIACOHJH(bool EEDHLEFEMGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x70892C0", Offset = "0x70886C0", VA = "0x1870892C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7088560", Offset = "0x7087960", VA = "0x187088560")]
		public void InitMetricsDependencies(MetricIdLookup CABIDHJABOB, IRawMetricsPipeline OGMFJKKEBMO, IMetricCollectionRegistry OJOHACKGDMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7087AE0", Offset = "0x7086EE0", VA = "0x187087AE0")]
		private void BCMIFNIIDMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7088DD0", Offset = "0x70881D0", VA = "0x187088DD0")]
		private void OPKDEBHEDDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7087FF0", Offset = "0x70873F0", VA = "0x187087FF0")]
		private void FCLMCOALLJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7087830", Offset = "0x7086C30", VA = "0x187087830")]
		private bool APHNBFIOHIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7087620", Offset = "0x7086A20", VA = "0x187087620")]
		private bool AEDHJHMBMPD(bool MKFHNLMLLFK = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7088C50", Offset = "0x7088050", VA = "0x187088C50")]
		private bool NLLKPJMPCMB(PCCGAENHOOD PPIMIKDHEBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7088B30", Offset = "0x7087F30", VA = "0x187088B30")]
		private bool LFFPICOCOLB(PCCGAENHOOD PPIMIKDHEBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x70883A0", Offset = "0x70877A0", VA = "0x1870883A0")]
		public void HandleMetric([In] RawMetric LGOIICOFOMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x70882B0", Offset = "0x70876B0", VA = "0x1870882B0")]
		private bool GEBGLDPKAHO(MetricId FGCGILGDAIF, [Out] int PHPEMNNMPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7088C40", Offset = "0x7088040", VA = "0x187088C40")]
		private bool MNOCHGHGPAK(AJGKDLFDFBK NCLIEBGGHAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7088290", Offset = "0x7087690", VA = "0x187088290")]
		private bool GDHIOAIKKEM(AJGKDLFDFBK DGMBHJPJFOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7089D50", Offset = "0x7089150", VA = "0x187089D50")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x70883A0", Offset = "0x70877A0", VA = "0x1870883A0", Slot = "4")]
		private void OIFDHMEOBME([In] RawMetric LGOIICOFOMM)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BLFFACIIBBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly PLDMCPGBJEG JOBBHPPFBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly HINJFOEJADG OJHNMOJCJPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private int HBPLAPHLPHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public LayoutRect DADFCHMGJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public TextSegmentLayout DNNMHGFAALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public TextSegmentLayout KPHOCACONNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TextSegmentLayout LABBGIMFHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public AHCCFOPHHAB PKFJELLEKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool BMKCNLGIEDE;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8A9CD0", Offset = "0x8A90D0", VA = "0x1808A9CD0")]
	public BLFFACIIBBB(PLDMCPGBJEG DKEPCFIJJOF, HINJFOEJADG PDHMJFNKJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7086860", Offset = "0x7085C60", VA = "0x187086860")]
	public void LHMGAKDCLGK(LayoutRect DIJNMKAFFAG, int LAPHBBLMDAN, float NJIGEADDHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7086460", Offset = "0x7085860", VA = "0x187086460")]
	public void DCNMIHCAHGF(float NJIGEADDHDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7086580", Offset = "0x7085980", VA = "0x187086580")]
	public void JMFBBGHFINB(float CEFMIMEDKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x70870E0", Offset = "0x70864E0", VA = "0x1870870E0")]
	public void OCMJLPCCMPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum CNAAJEDNPOI
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Clean = 0,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	PrefixDirty = 1,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	ValueDirty = 2,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	SuffixDirty = 4,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	AllDirty = 7
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BELLAFMCMIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public LNDEEOGIBGD IDJDIAFGDHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public RawMetricPayload BNOAJIIDHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public string OMBOCBKOHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public CNAAJEDNPOI FKKFEAMJLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public char[] AAFFJCFKHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public char[] LBJJJAPBGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public char[] OAPBMNDHFDK;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7086360", Offset = "0x7085760", VA = "0x187086360")]
	public BELLAFMCMIB(LNDEEOGIBGD GOFCCCIOLEO, string IIEELGMEBFN, [Optional] string DOFEPKLIFOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7085FD0", Offset = "0x70853D0", VA = "0x187085FD0")]
	public bool GILKACIGLCP(RawMetricPayload GHFHDLNCGDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7085F50", Offset = "0x7085350", VA = "0x187085F50")]
	private static bool AHPGLKFELFI(char[] GIDMNJLJNOH, char[] OONEKAPAHLL)
	{
		return default(bool);
	}
}
namespace RecRoom.Utils.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class TestMetricProvider : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public class DemoValueSource : ISerializationCallbackReceiver
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			[SerializeField]
			[HideInInspector]
			public bool isInit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public string prefix;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public float value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public string suffix;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private string _lastPrefix;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private float _lastValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private string _lastSuffix;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x7087230", Offset = "0x7086630", VA = "0x187087230")]
			public bool BBKCADHPCMM()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x352D830", Offset = "0x352CC30", VA = "0x18352D830")]
			private static bool CKIFNODLCGJ<T>(T ANHPPPBDANF, T LIHHDPOHLDK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7087350", Offset = "0x7086750", VA = "0x187087350", Slot = "4")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x70872D0", Offset = "0x70866D0", VA = "0x1870872D0", Slot = "5")]
			public void OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public DemoValueSource()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public List<DemoValueSource> demoValueSources;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7089F30", Offset = "0x7089330", VA = "0x187089F30")]
		public TestMetricProvider()
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
