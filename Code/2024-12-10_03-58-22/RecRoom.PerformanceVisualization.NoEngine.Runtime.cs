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
	public class LogRegistrationIndex : IGKFPLMKJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6EFFF70", Offset = "0x6EFEB70", VA = "0x186EFFF70", Slot = "4")]
		public override void PEGPHNFMEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		private enum AHCAOIBIBIE
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
		private static readonly BNHLDIHMNLF EDHPLLKPKGK;

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
		private int NAACKBDMKOP;

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
		private AHCAOIBIBIE NMFMLCAFPCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private MetricIdLookup CMOCEKAOFLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IRawMetricsPipeline GGEOEPPEDFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMetricCollectionRegistry IAJHCKJGNED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MetricCollectionToken BBIOOMDLGMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private JEBCAJJBJML LAACOAHHCBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private OKHLPEJPAJE BCJGHEFIBGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private EDNIOHJKEAO APJICMONFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private Material NFHBGOCIAPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int NKBEKEDNJMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private LayoutRect GELKCPJPEOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<MetricId> DOEAGJBFIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<HJABGMKOIAH> FKJPDHOGAPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private List<IDFOMKGKHKJ> LPLBPOLGBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private List<TextSegmentLayout> MCLFCCCOGHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private List<OPCADHPNMJH> NOJLKIOFGIH;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static List<(string source, string metric)> PHCEFPCHKBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private int CLAPMHJBPHJ;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F01630", Offset = "0x6F00230", VA = "0x186F01630")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F01730", Offset = "0x6F00330", VA = "0x186F01730")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F016A0", Offset = "0x6F002A0", VA = "0x186F016A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F00000", Offset = "0x6EFEC00", VA = "0x186F00000")]
		private void ALBDBOEEKKL(bool NEFELNIOAKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F00200", Offset = "0x6EFEE00", VA = "0x186F00200")]
		private void CCDPDDJPMCN(bool NEFELNIOAKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F01E80", Offset = "0x6F00A80", VA = "0x186F01E80")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F00B60", Offset = "0x6EFF760", VA = "0x186F00B60")]
		public void InitMetricsDependencies(MetricIdLookup CMOCEKAOFLD, IRawMetricsPipeline GGEOEPPEDFP, IMetricCollectionRegistry IAJHCKJGNED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F01760", Offset = "0x6F00360", VA = "0x186F01760")]
		private void PCOOHOLEKCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F00FD0", Offset = "0x6EFFBD0", VA = "0x186F00FD0")]
		private void NKMENLHAPKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F01390", Offset = "0x6EFFF90", VA = "0x186F01390")]
		private void NMKFAHFBNJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6F00570", Offset = "0x6EFF170", VA = "0x186F00570")]
		private bool EBCPOMEKPEL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F01C70", Offset = "0x6F00870", VA = "0x186F01C70")]
		private bool PHHKOEKLAAL(bool PFFNAMCBLPL = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F00820", Offset = "0x6EFF420", VA = "0x186F00820")]
		private bool FNLJMBNFLIP(DKNOFLOHJEI DOHADELBNEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F00EC0", Offset = "0x6EFFAC0", VA = "0x186F00EC0")]
		private bool NKBDOFDLMCI(DKNOFLOHJEI DOHADELBNEM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F009A0", Offset = "0x6EFF5A0", VA = "0x186F009A0")]
		public void HandleMetric([In] RawMetric CDPBEAPGOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F00DD0", Offset = "0x6EFF9D0", VA = "0x186F00DD0")]
		private bool KAJIDFCHOBN(MetricId CMGACHDFLDI, [Out] int ABKJJBBCDLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F001D0", Offset = "0x6EFEDD0", VA = "0x186F001D0")]
		private bool BGNOFLENCMI(AHCAOIBIBIE IBNDMMNOAJD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F001E0", Offset = "0x6EFEDE0", VA = "0x186F001E0")]
		private bool BPINJAMAOKN(AHCAOIBIBIE AAHEMKNCLNL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F028F0", Offset = "0x6F014F0", VA = "0x186F028F0")]
		public MetricHudDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F009A0", Offset = "0x6EFF5A0", VA = "0x186F009A0", Slot = "4")]
		private void HPNHDKDAKFM([In] RawMetric CDPBEAPGOAB)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IDFOMKGKHKJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly OKHLPEJPAJE EFGCJECGNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly EDNIOHJKEAO NKEPHHPIPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private int AHGBMMDLNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public LayoutRect KNEHCIPBBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public TextSegmentLayout GMPLFGAPDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public TextSegmentLayout KAHLDNHOMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public TextSegmentLayout OGKOBHEMEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public OPCADHPNMJH EIFKDCFFFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool BDMGCMIEKJH;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x887A10", Offset = "0x886610", VA = "0x180887A10")]
	public IDFOMKGKHKJ(OKHLPEJPAJE LBCPHNFGDOE, EDNIOHJKEAO BKOKHHDBJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF480", Offset = "0x6EFE080", VA = "0x186EFF480")]
	public void CIBOHFMOAPI(LayoutRect HPNODMBENLD, int HJNLEMHONGM, float GIDCFPAJCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFE50", Offset = "0x6EFEA50", VA = "0x186EFFE50")]
	public void HAGDBBHEADP(float GIDCFPAJCLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF1A0", Offset = "0x6EFDDA0", VA = "0x186EFF1A0")]
	public void CDJNFCPGLNI(float AMBIJCFOFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6EFFD00", Offset = "0x6EFE900", VA = "0x186EFFD00")]
	public void FCCPBBAAIAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[Flags]
public enum FIIOGBDIJNA
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
public class HJABGMKOIAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public JALNDJKLIPF NOAEFAKDNJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public RawMetricPayload IAEKNKFHCAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public string JHPGFNOPLMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public FIIOGBDIJNA LLKKPCPONAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public char[] OMLGOPKAIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public char[] OOPKMOCFHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public char[] HAOELPLPBKI;

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6EFF0A0", Offset = "0x6EFDCA0", VA = "0x186EFF0A0")]
	public HJABGMKOIAH(JALNDJKLIPF HIDMJHCBMDH, string BGDNHPBDDNG, [Optional] string ADFKKLKOAEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6EFED10", Offset = "0x6EFD910", VA = "0x186EFED10")]
	public bool JJGLGGFHDNE(RawMetricPayload NALLKJAFLKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6EFEC90", Offset = "0x6EFD890", VA = "0x186EFEC90")]
	private static bool HKKHDPFHFGG(char[] CKONCFGMELN, char[] GAAMPOEMOPE)
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
			[Cpp2IlInjected.Address(RVA = "0x6EFEB00", Offset = "0x6EFD700", VA = "0x186EFEB00")]
			public bool EAJCEBIHJBO()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x348DA90", Offset = "0x348C690", VA = "0x18348DA90")]
			private static bool ALODMMEFDMJ<T>(T CGJNNJHBPPG, T CABLCDOIFFL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6EFEC20", Offset = "0x6EFD820", VA = "0x186EFEC20", Slot = "4")]
			void ISerializationCallbackReceiver.OnBeforeSerialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6EFEBA0", Offset = "0x6EFD7A0", VA = "0x186EFEBA0", Slot = "5")]
			public void OnAfterDeserialize()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public DemoValueSource()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public List<DemoValueSource> demoValueSources;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F02AD0", Offset = "0x6F016D0", VA = "0x186F02AD0")]
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
