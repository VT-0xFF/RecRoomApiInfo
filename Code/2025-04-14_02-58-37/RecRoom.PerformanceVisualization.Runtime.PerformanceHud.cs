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
	public class LogRegistrationIndex : CCAGPMFGEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7C611D0", Offset = "0x7C5FBD0", VA = "0x187C611D0", Slot = "4")]
		public override void BLLBFFICICF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9D7E50", Offset = "0x9D6850", VA = "0x1809D7E50")]
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
		private enum BABGBMKLKHJ
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
		private static readonly LMPJBEBLCLM BLAHIKOFFGK;

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
		private BABGBMKLKHJ CCJDJNCCDNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup LMJCKJDJGHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline IGKNEDFIPLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry CNBBBOMHEFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken CDAMDKIMPGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private HAKLIJNNGPJ CNLAMIEDILO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private JPHDOEAHHBG OELBIEGGCEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private Material CHCLBPKGPMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int FINABJKHCMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private LayoutRect EDIINHGDING;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int GLFHMNFFNAM;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private const int IJPDBELOOBH = 10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private OGOPNGCIOPC PJNHDNCNPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool AKAILECENNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Dictionary<MetricId, int> NALHNHKDGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<BDFAJOJFOMH> MEKGJJMMMKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private DIHOEJOCDBH HNINGDNPDHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private List<DIHOEJOCDBH> LLNBGLNBEFF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public MeshBufferRenderer LPMADEDMCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C631A0", Offset = "0x7C61BA0", VA = "0x187C631A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C633B0", Offset = "0x7C61DB0", VA = "0x187C633B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C63350", Offset = "0x7C61D50", VA = "0x187C63350")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C62D30", Offset = "0x7C61730", VA = "0x187C62D30")]
		private void LMONEEBBKNH(bool FJEAIEKNHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C62E20", Offset = "0x7C61820", VA = "0x187C62E20")]
		private void MCICBGLONBF(bool FJEAIEKNHDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C635C0", Offset = "0x7C61FC0", VA = "0x187C635C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C62550", Offset = "0x7C60F50", VA = "0x187C62550")]
		public void InitMetricsDependencies(MetricIdLookup LMJCKJDJGHD, IRawMetricsPipeline IGKNEDFIPLJ, IMetricCollectionRegistry CNBBBOMHEFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C63540", Offset = "0x7C61F40", VA = "0x187C63540")]
		public void SetActiveOverlay(OGOPNGCIOPC KGEICDNJCAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C613A0", Offset = "0x7C5FDA0", VA = "0x187C613A0")]
		private void DCKPJEEOGNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7C633E0", Offset = "0x7C61DE0", VA = "0x187C633E0")]
		private void PLMFOILMOAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C626D0", Offset = "0x7C610D0", VA = "0x187C626D0")]
		private void JAHEEAEPPMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C61820", Offset = "0x7C60220", VA = "0x187C61820")]
		private void EBNMBHNPGDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C62070", Offset = "0x7C60A70", VA = "0x187C62070")]
		private bool HJFAPJFLECM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C62AF0", Offset = "0x7C614F0", VA = "0x187C62AF0")]
		private bool JLCOCAGPMNN(bool JDEIJIAFEMH = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C61E90", Offset = "0x7C60890", VA = "0x187C61E90")]
		private bool GNMLNDCFKAK(KIIIKHPFKCF HBNNPNFAEOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C61260", Offset = "0x7C5FC60", VA = "0x187C61260")]
		private bool BJOLPHLHJFF(KIIIKHPFKCF HBNNPNFAEOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C62320", Offset = "0x7C60D20", VA = "0x187C62320")]
		public void HandleMetric([In] RawMetric MAJLDFGHJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2425790", Offset = "0x2424190", VA = "0x182425790")]
		private bool NODIMMMJJLD(BABGBMKLKHJ GIKIOAPBHAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C61E70", Offset = "0x7C60870", VA = "0x187C61E70")]
		private bool EOMJAAIGJFG(BABGBMKLKHJ ECKGPFLFAKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C63880", Offset = "0x7C62280", VA = "0x187C63880")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C62AE0", Offset = "0x7C614E0", VA = "0x187C62AE0", Slot = "4")]
		private void JFADGONODMB([In] RawMetric MAJLDFGHJEC)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal class DIHOEJOCDBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private bool GMMKIHECLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LayoutRect GJPLLACHCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private TextSegmentLayout CADNDKLBNBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private TextSegmentLayout MMNJDGENNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private TextSegmentLayout HMLFLNGBCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private DJHLEPAIACN AJOPAFGKJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private MetricGraphGraphic ODPIBANKJOB;

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5EC00", Offset = "0x7C5D600", VA = "0x187C5EC00")]
	public void JCFABLNPBJM(HAKLIJNNGPJ JAGPGIJOHCE, JPHDOEAHHBG DDPMEKBDBIP, LayoutRect OEFMPHNAGCO, int DGICCNFDFAJ, [Optional] MetricGraphGraphic ODPIBANKJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E500", Offset = "0x7C5CF00", VA = "0x187C5E500")]
	public void EBGNIGFKLNK(float ILGNOPNHION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C5EA70", Offset = "0x7C5D470", VA = "0x187C5EA70")]
	public void EGLEMGKFFKB(ReadOnlySpan<char> FHFKGJKBGOF, ReadOnlySpan<char> OCOOBBELPOI, ReadOnlySpan<char> MCINAHJNEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F1A0", Offset = "0x7C5DBA0", VA = "0x187C5F1A0")]
	public void NOAIJIGKHLC(RRColor32 IFFOAMBAJEI, bool APDJFIAENEG = true, bool ADFGOKBEEAO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E670", Offset = "0x7C5D070", VA = "0x187C5E670")]
	public float EFIFOIJDGOD(float IKGAMFPDIKG, float JDBJHHJFAEA, float KHHCJIIGCJN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F150", Offset = "0x7C5DB50", VA = "0x187C5F150")]
	public void MNGKBGPFFHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F2F0", Offset = "0x7C5DCF0", VA = "0x187C5F2F0")]
	public void OOPBJPMGLGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C5EBE0", Offset = "0x7C5D5E0", VA = "0x187C5EBE0")]
	public void GLOIIPACEJO(GGAMDINGGHK DDKPOLMPJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E290", Offset = "0x7C5CC90", VA = "0x187C5E290")]
	public void CAAHIJEEBFK(GGAMDINGGHK DDKPOLMPJLJ, double GFDDEGDNEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F0C0", Offset = "0x7C5DAC0", VA = "0x187C5F0C0")]
	public void JFKGFNGLDBP(double PPJFMHBDGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E340", Offset = "0x7C5CD40", VA = "0x187C5E340")]
	public void CMKPBKOPCPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public DIHOEJOCDBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class FJFIFDGLKML
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static OGOPNGCIOPC MNLKLIKBDMM;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static OGOPNGCIOPC HNNOCBBIDNN;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private static OGOPNGCIOPC NCJDAHEJINB;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private static OGOPNGCIOPC KBIGPHPLOID;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static OGOPNGCIOPC NBHGNDKNOFJ;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static OGOPNGCIOPC HJKHGPIADOD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static OGOPNGCIOPC JKECEEFIAPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F370", Offset = "0x7C5DD70", VA = "0x187C5F370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static OGOPNGCIOPC OOJEDNKPION
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F4B0", Offset = "0x7C5DEB0", VA = "0x187C5F4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static OGOPNGCIOPC PJJBDLFEDJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F3C0", Offset = "0x7C5DDC0", VA = "0x187C5F3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static OGOPNGCIOPC CNLGJCHGBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F460", Offset = "0x7C5DE60", VA = "0x187C5F460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static OGOPNGCIOPC FMOFEMKHJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F320", Offset = "0x7C5DD20", VA = "0x187C5F320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static OGOPNGCIOPC BJELHFDNDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F410", Offset = "0x7C5DE10", VA = "0x187C5F410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static OGOPNGCIOPC NGPFDFPCBED
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9AE070", Offset = "0x9ACA70", VA = "0x1809AE070")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct MFEHILAKBPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public string OMEMJJKEIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public string IIFBMLJLIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public string APNEFFLGPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public GGAMDINGGHK DKJHHGMLFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public bool HFMNHEFOOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public bool IJICFCPMEEN;
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class OGOPNGCIOPC
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string ODGDIMGNJEF
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9AEDA0", Offset = "0x9AD7A0", VA = "0x1809AEDA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public MFEHILAKBPB[] IOFCJILJBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFB0", Offset = "0x9AD9B0", VA = "0x1809AEFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "4")]
	public virtual void FOPCHJAHAHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "5")]
	public virtual void IMAHKJGJAAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x9BB930", Offset = "0x9BA330", VA = "0x1809BB930")]
	public OGOPNGCIOPC(string NEADOILGEFJ, MFEHILAKBPB[] DIOEOAEACHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[Flags]
internal enum LMFLLDJPGKG
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
internal class BDFAJOJFOMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private LMFLLDJPGKG FFGELHBBILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private MetricDescription BDGBKGBECGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private RawMetricPayload ECGNDACMANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private EwmaFilter FLNKOANKMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private double OGPNLECEDOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private int OMKABEGJEBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private GGAMDINGGHK DDKPOLMPJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private ALDKJCKAMLA IMHBECALIPI;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int EPCFAECDNGN = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private char[] FHFKGJKBGOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private char[] OCOOBBELPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private int JMIGHMFEFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private char[] MCINAHJNEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private int CJINFCGPHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private string HAHBDNDJJEH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MetricDescription NAECAAIGFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xCA3D80", Offset = "0xCA2780", VA = "0x180CA3D80")]
		get
		{
			return default(MetricDescription);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7C5DA40", Offset = "0x7C5C440", VA = "0x187C5DA40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LMFLLDJPGKG MFLIMIPKEGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9B5570", Offset = "0x9B3F70", VA = "0x1809B5570")]
		get
		{
			return default(LMFLLDJPGKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ReadOnlySpan<char> GDLDLOCPFPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7C5DAC0", Offset = "0x7C5C4C0", VA = "0x187C5DAC0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ReadOnlySpan<char> JIFCNONECBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C5DFF0", Offset = "0x7C5C9F0", VA = "0x187C5DFF0")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ReadOnlySpan<char> IKJFFKELFEA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5D900", Offset = "0x7C5C300", VA = "0x187C5D900")]
		get
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public ALDKJCKAMLA GEJKJFMNFBG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB4D0B0", Offset = "0xB4BAB0", VA = "0x180B4D0B0")]
		get
		{
			return default(ALDKJCKAMLA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public double PEMBFHNJAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7C5D640", Offset = "0x7C5C040", VA = "0x187C5D640")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public float HCKIOEDKGCI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7C5D9E0", Offset = "0x7C5C3E0", VA = "0x187C5D9E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public float OFOIBCLLMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xB9A7A0", Offset = "0xB991A0", VA = "0x180B9A7A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xBFD880", Offset = "0xBFC280", VA = "0x180BFD880")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool OMFEHHNJJIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1064160", Offset = "0x1062B60", VA = "0x181064160")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x12749C0", Offset = "0x12733C0", VA = "0x1812749C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public GGAMDINGGHK DKJHHGMLFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9AC530", Offset = "0x9AAF30", VA = "0x1809AC530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E0D0", Offset = "0x7C5CAD0", VA = "0x187C5E0D0")]
	public BDFAJOJFOMH(string ICBJABOHKGL, [Optional] MetricDescription BDGBKGBECGN, [Optional] GGAMDINGGHK DDKPOLMPJLJ, bool FGBPLCJNEMF = true, bool BNDAKABFAAB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DB20", Offset = "0x7C5C520", VA = "0x187C5DB20")]
	public void MDOOIGBAAKK(RawMetricPayload OPEIKLLCLEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D670", Offset = "0x7C5C070", VA = "0x187C5D670")]
	public bool GBJEKFPNLJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DC10", Offset = "0x7C5C610", VA = "0x187C5DC10")]
	public bool NKNIDJLCMIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x67B45B0", Offset = "0x67B2FB0", VA = "0x1867B45B0")]
	public void EEMOFOBFPME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x67A2A00", Offset = "0x67A1400", VA = "0x1867A2A00")]
	public void DKHNMGCNBBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D9F0", Offset = "0x7C5C3F0", VA = "0x187C5D9F0")]
	private static int KAODLFCBKOK(MetricDataUnits KGBLPBGCPHP)
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
