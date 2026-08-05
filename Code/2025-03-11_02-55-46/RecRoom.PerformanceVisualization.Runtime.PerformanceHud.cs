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
	public class LogRegistrationIndex : KENHJELJHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x792DFA0", Offset = "0x792D3A0", VA = "0x18792DFA0", Slot = "4")]
		public override void ICLMLJMBJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		private enum LKLBOJILIAP
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
		private static readonly HLBHMADGLFA GCIBFPDCNDK;

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
		private LKLBOJILIAP ALNOOCNEEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup AHGIDMMAHIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline GBBKGFIENPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry KFJDPOKEDCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken PEFFIDEDEPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private IAAFAKHGOKF ALEGOFFHCDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private ADPKBLDHLGO EOMDPIPGPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material PAGGLCLFJCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int NGKMBLLKPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect JIOFDEDNKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int BAHHHOMLJNJ;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int DGMLEGDAKAD = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private APJIKBCCIOE CFCBIOKABEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool LLCLOLLLOFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> ANGINAMOHKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<PBIJGCOJOHM> CMADPJLLBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private JBHJKMKLIGD JOBAKIPMAOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<JBHJKMKLIGD> JLJGNCLGCIA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer EHLNLFJJINL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7931CD0", Offset = "0x79310D0", VA = "0x187931CD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7931EE0", Offset = "0x79312E0", VA = "0x187931EE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7931E80", Offset = "0x7931280", VA = "0x187931E80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7930E90", Offset = "0x7930290", VA = "0x187930E90")]
		private void IGIMNPBMHBC(bool BNJJNNEIELM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x79308E0", Offset = "0x792FCE0", VA = "0x1879308E0")]
		private void FBHIALFLHKC(bool BNJJNNEIELM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7932240", Offset = "0x7931640", VA = "0x187932240")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7930F80", Offset = "0x7930380", VA = "0x187930F80")]
		public void InitMetricsDependencies(MetricIdLookup AHGIDMMAHIM, IRawMetricsPipeline GBBKGFIENPC, IMetricCollectionRegistry KFJDPOKEDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x79321C0", Offset = "0x79315C0", VA = "0x1879321C0")]
		public void SetActiveOverlay(APJIKBCCIOE JLMFKCGEBLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7930460", Offset = "0x792F860", VA = "0x187930460")]
		private void EPGCHIOHEFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7931B70", Offset = "0x7930F70", VA = "0x187931B70")]
		private void OIIIKAPOJMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7930050", Offset = "0x792F450", VA = "0x187930050")]
		private void EHCHNHLNEIH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7931100", Offset = "0x7930500", VA = "0x187931100")]
		private void KMKHEHBCNHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7931F10", Offset = "0x7931310", VA = "0x187931F10")]
		private bool PPJOLBIPBKF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7931930", Offset = "0x7930D30", VA = "0x187931930")]
		private bool MEHNNPHLHPB(bool JLJMBNIAGMB = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7931750", Offset = "0x7930B50", VA = "0x187931750")]
		private bool LAGKFNHJCOD(JOOHLKLABLN IPKJFPCBFNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x792FF10", Offset = "0x792F310", VA = "0x18792FF10")]
		private bool EFPGJFINJAE(JOOHLKLABLN IPKJFPCBFNH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7930C60", Offset = "0x7930060", VA = "0x187930C60")]
		public void HandleMetric([In] RawMetric JPAPHHGDJCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2340680", Offset = "0x233FA80", VA = "0x182340680")]
		private bool AKMHBGKHBBI(LKLBOJILIAP FEEAHHHNPFA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x792FEE0", Offset = "0x792F2E0", VA = "0x18792FEE0")]
		private bool CLIBPCGLCAO(LKLBOJILIAP JHPBGFLKAEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7932500", Offset = "0x7931900", VA = "0x187932500")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x792FF00", Offset = "0x792F300", VA = "0x18792FF00", Slot = "4")]
		private void DHMLIHCPADH([In] RawMetric JPAPHHGDJCH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class JBHJKMKLIGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool PEOLHJEJONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect OEGMEHPMJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout CFOOJCEEHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout OAMIFDCAKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout IFEHCFMNGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private KKAACPINNNO CKLEBNCGFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic LALEHCJMHLD;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x792D940", Offset = "0x792CD40", VA = "0x18792D940")]
	public void MEKFCHHLHOB(IAAFAKHGOKF MBFJCBDAGLD, ADPKBLDHLGO MJGDNGAOCAD, LayoutRect KAAAGAGPIGG, int JFJHNPMOHDG, [Optional] MetricGraphGraphic LALEHCJMHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x792DE00", Offset = "0x792D200", VA = "0x18792DE00")]
	public void NCMGCHHNMPP(float MCNPKBNEHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x792D320", Offset = "0x792C720", VA = "0x18792D320")]
	public void JCCFDKIHJJF(ReadOnlySpan<char> FFHFALMADCC, ReadOnlySpan<char> NGAKIHFAGCO, ReadOnlySpan<char> GKNIAPHAPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x792D1D0", Offset = "0x792C5D0", VA = "0x18792D1D0")]
	public void ILMHBHHEGOE(RRColor32 MLLLJKFOPGI, bool LFFHPNEONHN = true, bool JFBJBNFPDNJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x792D540", Offset = "0x792C940", VA = "0x18792D540")]
	public float LNALFLGMCCD(float EDLCDOGJBDG, float GOEGPMIKILL, float NGIIDEILHKK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x792CF10", Offset = "0x792C310", VA = "0x18792CF10")]
	public void ANNANFPEPDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x792DF70", Offset = "0x792D370", VA = "0x18792DF70")]
	public void NDHLHFJAKLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x792CFF0", Offset = "0x792C3F0", VA = "0x18792CFF0")]
	public void BMPHCIPBECF(EJBAGGFEAOI MLOHJLEPIGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x792D490", Offset = "0x792C890", VA = "0x18792D490")]
	public void KBNMBOGOFOA(EJBAGGFEAOI MLOHJLEPIGP, double JKHHCOODJNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x792CF60", Offset = "0x792C360", VA = "0x18792CF60")]
	public void BJKKKPPBOIL(double PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x792D010", Offset = "0x792C410", VA = "0x18792D010")]
	public void FIKJJGGPENN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public JBHJKMKLIGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MFBEEMAOIIN
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static APJIKBCCIOE JGBBPKGGMOI;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static APJIKBCCIOE PJBHCCMOJDP;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static APJIKBCCIOE LMEBFIDJNNG;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static APJIKBCCIOE CPFCHBENHAA;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static APJIKBCCIOE JBDLDDJIBMG;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static APJIKBCCIOE EKDHHINBJJB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static APJIKBCCIOE LPOHMOGIBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x792E170", Offset = "0x792D570", VA = "0x18792E170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static APJIKBCCIOE KKONGBNLGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x792E120", Offset = "0x792D520", VA = "0x18792E120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static APJIKBCCIOE PBPMIEBEALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x792E1C0", Offset = "0x792D5C0", VA = "0x18792E1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static APJIKBCCIOE CDAAOGIOGMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x792E030", Offset = "0x792D430", VA = "0x18792E030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static APJIKBCCIOE AINEBMADFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x792E0D0", Offset = "0x792D4D0", VA = "0x18792E0D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static APJIKBCCIOE FDJGOILEKDC
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x792E080", Offset = "0x792D480", VA = "0x18792E080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static APJIKBCCIOE CIPMGOEGIGB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct NAADDHGBNNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string KMJFMEFJIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string JBELCBDEMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string EOJMNODGIFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public EJBAGGFEAOI OOIDNCPAMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool KKHHHAFPGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool DJKGNFEANDE;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class APJIKBCCIOE
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string CPKGFKJBCBG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NAADDHGBNNO[] LJIKBEMCNEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x968060", Offset = "0x967460", VA = "0x180968060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "4")]
	public virtual void ELCHALLNABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
	public virtual void OPFPFLPOHPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x96FAD0", Offset = "0x96EED0", VA = "0x18096FAD0")]
	public APJIKBCCIOE(string KLICPAGEKOI, NAADDHGBNNO[] JKONAEJJMDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum POEGIBDCIHF
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
internal class PBIJGCOJOHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private POEGIBDCIHF FCEJGAEHKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription IIFNLCIEBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload IILBHIALBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter IEMFGLGPIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double NJDAJOPBBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int APIOINAKGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private EJBAGGFEAOI MLOHJLEPIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private AHNADBLKNNF FMFMBAPJPDD;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int CDPEKFKKKGP = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] FFHFALMADCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] NGAKIHFAGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int NCBHPEIHECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] GKNIAPHAPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int MKIDAMFGEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string BNNHPJMBOIK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription KIFILCGCCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xC15800", Offset = "0xC14C00", VA = "0x180C15800")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7932AB0", Offset = "0x7931EB0", VA = "0x187932AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public POEGIBDCIHF DICIHCNJAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9712B0", Offset = "0x9706B0", VA = "0x1809712B0")]
		get
		{
			return default(POEGIBDCIHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> FCJPDIEGFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7932E40", Offset = "0x7932240", VA = "0x187932E40")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> NOIPDPONLDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7933080", Offset = "0x7932480", VA = "0x187933080")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> PMAPGLKKOAA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7932EA0", Offset = "0x79322A0", VA = "0x187932EA0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public AHNADBLKNNF MDBGJKNOBBC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xAC3E40", Offset = "0xAC3240", VA = "0x180AC3E40")]
		get
		{
			return default(AHNADBLKNNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double ECLCKGGJLID
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7932E10", Offset = "0x7932210", VA = "0x187932E10")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float NKKJCCHCAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7932F80", Offset = "0x7932380", VA = "0x187932F80")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float CMAHCEJPEGP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xB0AF90", Offset = "0xB0A390", VA = "0x180B0AF90")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xB701C0", Offset = "0xB6F5C0", VA = "0x180B701C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool LONCPDOICOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xFD32B0", Offset = "0xFD26B0", VA = "0x180FD32B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x11CBC00", Offset = "0x11CB000", VA = "0x1811CBC00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public EJBAGGFEAOI OOIDNCPAMDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9642C0", Offset = "0x9636C0", VA = "0x1809642C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7933160", Offset = "0x7932560", VA = "0x187933160")]
	public PBIJGCOJOHM(string HKOIFLLCMEG, [Optional] MetricDescription IIFNLCIEBAB, [Optional] EJBAGGFEAOI MLOHJLEPIGP, bool ADNLCAAGHPI = true, bool EIIJLNHJKBM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7932F90", Offset = "0x7932390", VA = "0x187932F90")]
	public void JOLHFPMIBAA(RawMetricPayload EHLMGCBMPKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7932B30", Offset = "0x7931F30", VA = "0x187932B30")]
	public bool CBPAMOGBIOE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x79326D0", Offset = "0x7931AD0", VA = "0x1879326D0")]
	public bool AHDPGCAPHGO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x64D4AE0", Offset = "0x64D3EE0", VA = "0x1864D4AE0")]
	public void AGJKKOIPHFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x64D4AD0", Offset = "0x64D3ED0", VA = "0x1864D4AD0")]
	public void DMOPNOKEPDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7932DC0", Offset = "0x79321C0", VA = "0x187932DC0")]
	private static int EAGKDJDPGHP(MetricDataUnits HDBOKGBEIMO)
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
