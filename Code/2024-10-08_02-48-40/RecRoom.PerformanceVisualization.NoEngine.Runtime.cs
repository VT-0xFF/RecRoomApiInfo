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
	public class LogRegistrationIndex : MPFOBEHAELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F09DA0", Offset = "0x6F08FA0", VA = "0x186F09DA0", Slot = "4")]
		public override void ALGAFMBJNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
		private enum HJJBIHHBCIC
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
		private static readonly GAFGFHIJEHD KILNKIHBNIN;

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
		private int EPHNCNMHPNO;

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
		private HJJBIHHBCIC GMPDEAOANEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup CNHDGBPIPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline MNNPOANHGNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry DGFFBKBFLKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken OGDPJECEIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private JLIJGCDDOOO AOFKGPIKLLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private DDAHCBIGLMB HGHGEDKDKIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private OEGBCEPCFPI AKEILAKEALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private Material EJNEEBDPAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int HEJNPPIHMIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private LayoutRect ABDNCAFOMFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<MetricId> BIDPKFAHOHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<IIIBGLCOKOJ> POPBKJJHCIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private List<ICLJBKCKNFE> NKOBDCBJNLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<TextSegmentLayout> CNFLAHEHMAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<JPHGKKABJEC> IINPKNOPJPH;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static List<(string source, string metric)> IOADKACAOIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int OABHGDBBBLJ;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F0BB80", Offset = "0x6F0AD80", VA = "0x186F0BB80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F0BC80", Offset = "0x6F0AE80", VA = "0x186F0BC80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F0BBF0", Offset = "0x6F0ADF0", VA = "0x186F0BBF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F0A890", Offset = "0x6F09A90", VA = "0x186F0A890")]
		private void GIFMJMDLPCE(bool PEFIIAENHDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F0AA60", Offset = "0x6F09C60", VA = "0x186F0AA60")]
		private void HDECFMLPFNL(bool PEFIIAENHDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F0BCB0", Offset = "0x6F0AEB0", VA = "0x186F0BCB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F0AF90", Offset = "0x6F0A190", VA = "0x186F0AF90")]
		public void InitMetricsDependencies(MetricIdLookup CNHDGBPIPLO, IRawMetricsPipeline MNNPOANHGNK, IMetricCollectionRegistry DGFFBKBFLKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F0A0E0", Offset = "0x6F092E0", VA = "0x186F0A0E0")]
		private void EMLJFAKFAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F0B2F0", Offset = "0x6F0A4F0", VA = "0x186F0B2F0")]
		private void MAIHOGLMLAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F0A5F0", Offset = "0x6F097F0", VA = "0x186F0A5F0")]
		private void GHHMHFPIEGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F0B6C0", Offset = "0x6F0A8C0", VA = "0x186F0B6C0")]
		private bool NCBFLFNACLC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F0B970", Offset = "0x6F0AB70", VA = "0x186F0B970")]
		private bool OFNIEOHPIMA(bool OOGPJHPADFG = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F09F40", Offset = "0x6F09140", VA = "0x186F09F40")]
		private bool CCLOGJMHEDN(PGODDAECKEI KLCFDAPKGEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F09E30", Offset = "0x6F09030", VA = "0x186F09E30")]
		private bool CCCJMPEJEMK(PGODDAECKEI KLCFDAPKGEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F0ADD0", Offset = "0x6F09FD0", VA = "0x186F0ADD0")]
		public void HandleMetric([In] RawMetric HJMGBHEEFEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F0B200", Offset = "0x6F0A400", VA = "0x186F0B200")]
		private bool JGJJLPLGKKN(MetricId BDKKBNCPNLE, [Out] int NKJEOOHBLAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F0B6B0", Offset = "0x6F0A8B0", VA = "0x186F0B6B0")]
		private bool MLDCAEBICGD(HJJBIHHBCIC FHNFBCHAPFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F0A0C0", Offset = "0x6F092C0", VA = "0x186F0A0C0")]
		private bool DFEFGLHELGI(HJJBIHHBCIC FNJFLLKOIOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C720", Offset = "0x6F0B920", VA = "0x186F0C720")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F0ADD0", Offset = "0x6F09FD0", VA = "0x186F0ADD0", Slot = "4")]
		private void NBCDKADAOGK([In] RawMetric HJMGBHEEFEP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ICLJBKCKNFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly DDAHCBIGLMB INLIGIMCDHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly OEGBCEPCFPI CHIMEMPEMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private int PGBIFOAGHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public LayoutRect JBMLNFOEOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public TextSegmentLayout PMDMBEMMGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public TextSegmentLayout DBKOOPCJFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TextSegmentLayout LKMGBLCAMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public JPHGKKABJEC BCMHPFMHOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool JKCPPHCKHAI;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8A2310", Offset = "0x8A1510", VA = "0x1808A2310")]
	public ICLJBKCKNFE(DDAHCBIGLMB PCCMFONEBND, OEGBCEPCFPI JHFKJLLELJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F08C10", Offset = "0x6F07E10", VA = "0x186F08C10")]
	public void BPKFIOLMIPE(LayoutRect ILPLPNGHFCH, int MCPMKLGCBIP, float NBOCDIEJPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F09770", Offset = "0x6F08970", VA = "0x186F09770")]
	public void HFIABGPJEKA(float NBOCDIEJPMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F09490", Offset = "0x6F08690", VA = "0x186F09490")]
	public void FJCCOOIJNJN(float IPPPAGDNKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6F08AC0", Offset = "0x6F07CC0", VA = "0x186F08AC0")]
	public void AOJKMPFKLPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum FDGOMLOBBEH
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
public class IIIBGLCOKOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public LKHJNJHLMPB NDHOBJABACC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public RawMetricPayload HLMIACPKMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public string EBLDOMOPGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public FDGOMLOBBEH IEADAALCIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public char[] NOIGCDCAFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public char[] BNNDHMAHCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public char[] CLDIFCMHIMM;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6F09CA0", Offset = "0x6F08EA0", VA = "0x186F09CA0")]
	public IIIBGLCOKOJ(LKHJNJHLMPB GFBEMAICMFO, string HFCOPFIBHIK, [Optional] string DGPMJIANFLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6F09890", Offset = "0x6F08A90", VA = "0x186F09890")]
	public bool FPEBIFKCFAP(RawMetricPayload PJPJIOPBLKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F09C20", Offset = "0x6F08E20", VA = "0x186F09C20")]
	private static bool LCPAFFHNDKI(char[] ICLLFDEBJIO, char[] JPMAPOMKNPF)
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
			[Cpp2IlInjected.Address(RVA = "0x6F08930", Offset = "0x6F07B30", VA = "0x186F08930")]
			public bool KAMEPKENFGK()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x34CD620", Offset = "0x34CC820", VA = "0x1834CD620")]
			private static bool BBKJNLLIPGB<T>(T LCMBJJGJCLO, T JECHHBGMFLN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6F08A50", Offset = "0x6F07C50", VA = "0x186F08A50", Slot = "4")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6F089D0", Offset = "0x6F07BD0", VA = "0x186F089D0", Slot = "5")]
			public void OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
			public DemoValueSource()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public List<DemoValueSource> demoValueSources;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F0C900", Offset = "0x6F0BB00", VA = "0x186F0C900")]
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
