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
	public class LogRegistrationIndex : IHAELNMODEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x80220C0", Offset = "0x80212C0", VA = "0x1880220C0", Slot = "4")]
		public override void OOCHIMKFMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		private enum HLFOKHEGNKG
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
		private static readonly FODGIOKBGBI FHEIHFBIKLF;

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
		private HLFOKHEGNKG CICFEJKDEMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup FJPJECEBENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline ADPOGFCHJDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry IMAKMNKMJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken DBPEFGDLOHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private HCIMPPNFFOB FBFHDNGOLME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private JMPLBNNKLIE BDAFPDGDJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material LFIHAPHEFOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int KHDIPLMHBAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect AKMINNNJEPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int OJECNOLLPPI;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int GOKAOEOMMHD = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private EIJPBEECLJP BHDIGFIJKPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool IMMFGKNKBOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> NGLOKFIIHJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<BNNCPMKMKGE> JAGJGAMKBHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private ENLFHAOMFCE CGHLPDHNMMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<ENLFHAOMFCE> NHGLKHAJHPO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer HOFHPKDKBLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8023E80", Offset = "0x8023080", VA = "0x188023E80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8024090", Offset = "0x8023290", VA = "0x188024090")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8024030", Offset = "0x8023230", VA = "0x188024030")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x80231D0", Offset = "0x80223D0", VA = "0x1880231D0")]
		private void MIEODNEMFAL(bool BEJFDBKABBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x80240C0", Offset = "0x80232C0", VA = "0x1880240C0")]
		private void PHGFPJOGCEP(bool BEJFDBKABBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80244B0", Offset = "0x80236B0", VA = "0x1880244B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8022C30", Offset = "0x8021E30", VA = "0x188022C30")]
		public void InitMetricsDependencies(MetricIdLookup FJPJECEBENO, IRawMetricsPipeline ADPOGFCHJDC, IMetricCollectionRegistry IMAKMNKMJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8024430", Offset = "0x8023630", VA = "0x188024430")]
		public void SetActiveOverlay(EIJPBEECLJP KOHMJAEMJAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8022400", Offset = "0x8021600", VA = "0x188022400")]
		private void BPHKCHGJPEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8023D20", Offset = "0x8022F20", VA = "0x188023D20")]
		private void NPAADAMLGGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80232C0", Offset = "0x80224C0", VA = "0x1880232C0")]
		private void NBDEBJMNDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x80236D0", Offset = "0x80228D0", VA = "0x1880236D0")]
		private void NMHOJFLDONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8022150", Offset = "0x8021350", VA = "0x188022150")]
		private bool BEGMEECGCHB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8022DB0", Offset = "0x8021FB0", VA = "0x188022DB0")]
		private bool JBFMCCHMCAC(bool LIEHHNOLAGC = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8022FF0", Offset = "0x80221F0", VA = "0x188022FF0")]
		private bool KJGPOECMAIB(BPNALIHLJJG LJMBANNFBIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8022890", Offset = "0x8021A90", VA = "0x188022890")]
		private bool FKMOAPEFDME(BPNALIHLJJG LJMBANNFBIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8022A00", Offset = "0x8021C00", VA = "0x188022A00")]
		public void HandleMetric([In] RawMetric LLKKIJMGNCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8022880", Offset = "0x8021A80", VA = "0x188022880")]
		private bool CLGLNFBLJKG(HLFOKHEGNKG KABGPEPKAEF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x80229E0", Offset = "0x8021BE0", VA = "0x1880229E0")]
		private bool GPMHJAHJNNB(HLFOKHEGNKG DJEKICOCOOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8024770", Offset = "0x8023970", VA = "0x188024770")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x80229D0", Offset = "0x8021BD0", VA = "0x1880229D0", Slot = "4")]
		private void GHONFFDFOIC([In] RawMetric LLKKIJMGNCN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class ENLFHAOMFCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool ENHFOFDEHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect PMINLNEMDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout EELKJOIGGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout CEGIKJEBGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout OGOBBPFPGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private ACGHGEOGIHO GEBDDFMFPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic JLAILCPMFIF;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x801FBE0", Offset = "0x801EDE0", VA = "0x18801FBE0")]
	public void MNFKMEBPDCG(HCIMPPNFFOB OLOOOEGIDPB, JMPLBNNKLIE HAOGANPNLFN, LayoutRect NODJFIFAIFB, int LBKFDENBPBA, [Optional] MetricGraphGraphic JLAILCPMFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x80200A0", Offset = "0x801F2A0", VA = "0x1880200A0")]
	public void OLOKMAACAPF(float PMHMJFJKANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x801F630", Offset = "0x801E830", VA = "0x18801F630")]
	public void EKHHPPJJDAC(ReadOnlySpan<char> CBHOODCHNEO, ReadOnlySpan<char> ILIDGAEBIHG, ReadOnlySpan<char> HOFNBHHHIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x801F990", Offset = "0x801EB90", VA = "0x18801F990")]
	public void JOIMMEHAGHH(RRColor32 EKKMKLFENBL, bool LAFFJMFGDKJ = true, bool AEAGBJIMGCH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x801F180", Offset = "0x801E380", VA = "0x18801F180")]
	public float AJDCIALNGAA(float EPMBMJKGGEK, float EPNGHFNBBPP, float PNHKGFJFJCJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x801FB90", Offset = "0x801ED90", VA = "0x18801FB90")]
	public void MDHCJGMBFDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x801F960", Offset = "0x801EB60", VA = "0x18801F960")]
	public void JMOPHHKGEEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x801F610", Offset = "0x801E810", VA = "0x18801F610")]
	public void DJHEKDNHNDC(OGJJMNNNBBL GJFLNFCKGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x801FAE0", Offset = "0x801ECE0", VA = "0x18801FAE0")]
	public void LCIADBLHECN(OGJJMNNNBBL GJFLNFCKGAL, double MMIJFAFPOOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x801F580", Offset = "0x801E780", VA = "0x18801F580")]
	public void CMLJBBECKLG(double MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x801F7A0", Offset = "0x801E9A0", VA = "0x18801F7A0")]
	public void ELPJDBNOPIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public ENLFHAOMFCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JCCIHAFLAFB
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static EIJPBEECLJP JMBLPJKMEAB;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static EIJPBEECLJP LDCIHEHGNGE;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static EIJPBEECLJP GIDJCMGEGPO;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static EIJPBEECLJP OJMKBGKCBJJ;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static EIJPBEECLJP BOGNOILPNPK;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static EIJPBEECLJP NECCHNFLPLN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static EIJPBEECLJP EMOEMPAFHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8020260", Offset = "0x801F460", VA = "0x188020260")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static EIJPBEECLJP JJOMHCNPJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8020300", Offset = "0x801F500", VA = "0x188020300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static EIJPBEECLJP MFOEDJLLKEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8020350", Offset = "0x801F550", VA = "0x188020350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static EIJPBEECLJP LAMKAOMLFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8020210", Offset = "0x801F410", VA = "0x188020210")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static EIJPBEECLJP DAEKHKLIIOA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x80202B0", Offset = "0x801F4B0", VA = "0x1880202B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static EIJPBEECLJP KGFGJHPDOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x80203A0", Offset = "0x801F5A0", VA = "0x1880203A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static EIJPBEECLJP BGCICDMELOH
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9F07B0", Offset = "0x9EF9B0", VA = "0x1809F07B0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct DGPMHEHGHAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string AGODKDAEPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string LKELKHLONII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string AKDIAMHHLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public OGJJMNNNBBL JOKAFKGNKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool BNNNIMNINLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool JOHIOMBJPLG;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class EIJPBEECLJP
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string CPEKBNDKHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public DGPMHEHGHAI[] CBFBOIDHFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public virtual void JDBIIMMNNIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
	public virtual void NFCNFPPBCEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9FFD40", Offset = "0x9FEF40", VA = "0x1809FFD40")]
	public EIJPBEECLJP(string LBMHFAOKMJO, DGPMHEHGHAI[] AEKHBAFNNKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum OFFHKJNAGGO
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
internal class BNNCPMKMKGE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private OFFHKJNAGGO CGLKAKDMBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription NCMPMINHFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload MGEJNDCFBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter IIJNHNNCMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double EICGNGOPKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int PAEJOECAHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private OGJJMNNNBBL GJFLNFCKGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private MOKEFABDOLK FKAFFJFHMKH;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int HFGEJMHJPNJ = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] CBHOODCHNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] ILIDGAEBIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int KMNOJAKPJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] HOFNBHHHIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int EMBBDGBJLFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string DBKEOEPIPEL;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription INJDFPCKJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xD34F00", Offset = "0xD34100", VA = "0x180D34F00")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x801EC40", Offset = "0x801DE40", VA = "0x18801EC40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public OFFHKJNAGGO PCNPDADJCCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9F94F0", Offset = "0x9F86F0", VA = "0x1809F94F0")]
		get
		{
			return default(OFFHKJNAGGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> LGJPEOEIJKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x801E710", Offset = "0x801D910", VA = "0x18801E710")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> GECPGNKAGDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x801E770", Offset = "0x801D970", VA = "0x18801E770")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> PLKCBIBIDBK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x801E630", Offset = "0x801D830", VA = "0x18801E630")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public MOKEFABDOLK EFJEADINCGI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xBDBA00", Offset = "0xBDAC00", VA = "0x180BDBA00")]
		get
		{
			return default(MOKEFABDOLK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double CMFDOMNPDAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x801EF90", Offset = "0x801E190", VA = "0x18801EF90")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float PKEFFFALJOI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x801E850", Offset = "0x801DA50", VA = "0x18801E850")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float NKPAFLBIENA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xC22800", Offset = "0xC21A00", VA = "0x180C22800")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xC66390", Offset = "0xC65590", VA = "0x180C66390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool DCMLMLMELML
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x113F3B0", Offset = "0x113E5B0", VA = "0x18113F3B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x136ED10", Offset = "0x136DF10", VA = "0x18136ED10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public OGJJMNNNBBL JOKAFKGNKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9F32E0", Offset = "0x9F24E0", VA = "0x1809F32E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x801EFC0", Offset = "0x801E1C0", VA = "0x18801EFC0")]
	public BNNCPMKMKGE(string BFICFCBIIPI, [Optional] MetricDescription NCMPMINHFBH, [Optional] OGJJMNNNBBL GJFLNFCKGAL, bool NAAGMGHADFG = true, bool JAIBDDIBAEM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x801E540", Offset = "0x801D740", VA = "0x18801E540")]
	public void ADJFHIDCBGI(RawMetricPayload OMENHEOOJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x801ED10", Offset = "0x801DF10", VA = "0x18801ED10")]
	public bool LJJDPOEJAEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x801E860", Offset = "0x801DA60", VA = "0x18801E860")]
	public bool IKGDJGDHKDP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6AF7A80", Offset = "0x6AF6C80", VA = "0x186AF7A80")]
	public void HDCJNKNGGNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5ED0", Offset = "0x6AE50D0", VA = "0x186AE5ED0")]
	public void HICCNJNIAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x801ECC0", Offset = "0x801DEC0", VA = "0x18801ECC0")]
	private static int KFMODDJEOKC(MetricDataUnits DFGNPHDABBP)
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
