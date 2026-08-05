using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Logging.Attributes;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rendering_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : NDHLMBGDHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72163F0", Offset = "0x7214DF0", VA = "0x1872163F0", Slot = "4")]
		public override void FBIMIMMHNIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR PreRender Manager")]
	public class PreRenderManager : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public enum DIOJEJHEJIN
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface KNCMPIAHBME
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void DBFKLINPIFI(ScriptableRenderContext MPOBGCPIOEI, List<Camera> LCFCGENIKIC);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface CFOHHHNJOBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void DBFKLINPIFI(ScriptableRenderContext MPOBGCPIOEI, RenderingData NPNFJHBDFOF);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class FDJNEIGEJOA : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7214F30", Offset = "0x7213930", VA = "0x187214F30")]
			public FDJNEIGEJOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7214ED0", Offset = "0x72138D0", VA = "0x187214ED0", Slot = "9")]
			public override void Execute(ScriptableRenderContext MPOBGCPIOEI, RenderingData NPNFJHBDFOF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private FDJNEIGEJOA _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<KNCMPIAHBME> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<KNCMPIAHBME> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<CFOHHHNJOBC> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<CFOHHHNJOBC> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72180C0", Offset = "0x7216AC0", VA = "0x1872180C0")]
		public static void JOPBEKGDFKD(DIOJEJHEJIN LCLHMHFADCH, KNCMPIAHBME FIJGABJLBBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7217ED0", Offset = "0x72168D0", VA = "0x187217ED0")]
		public static void EIIHKPKPKMD(DIOJEJHEJIN LCLHMHFADCH, KNCMPIAHBME FIJGABJLBBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7218180", Offset = "0x7216B80", VA = "0x187218180")]
		public static void JOPBEKGDFKD(DIOJEJHEJIN LCLHMHFADCH, CFOHHHNJOBC ICFDAJCBAKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7217F90", Offset = "0x7216990", VA = "0x187217F90")]
		public static void EIIHKPKPKMD(DIOJEJHEJIN LCLHMHFADCH, CFOHHHNJOBC ICFDAJCBAKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7217BE0", Offset = "0x72165E0", VA = "0x187217BE0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7217660", Offset = "0x7216060", VA = "0x187217660", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer DGLLFNJJPBO, RenderingData NPNFJHBDFOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7217DC0", Offset = "0x72167C0", VA = "0x187217DC0", Slot = "9")]
		protected override void Dispose(bool ODGHBPLNEHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7217700", Offset = "0x7216100", VA = "0x187217700")]
		private static void CFGOLONNBHB(ScriptableRenderContext MPOBGCPIOEI, List<Camera> LCFCGENIKIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7218050", Offset = "0x7216A50", VA = "0x187218050")]
		private static void GHFCMAFMPGD(ScriptableRenderContext MPOBGCPIOEI, List<Camera> LCFCGENIKIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7218240", Offset = "0x7216C40", VA = "0x187218240")]
		private static void KPBDCPKHCMP(ScriptableRenderContext MPOBGCPIOEI, RenderingData NPNFJHBDFOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x100ED00", Offset = "0x100D700", VA = "0x18100ED00")]
		public PreRenderManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[Tooltip("RR Fast Lines")]
	[DisallowMultipleRendererFeature(null)]
	public class FastLinesRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class OBBMIKJGLGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool CAJGIEAJLBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<MKHDGKDKHGN> CCHMOOMHKBK;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7217180", Offset = "0x7215B80", VA = "0x187217180")]
			public OBBMIKJGLGE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class LJBADGACKBN : PreRenderManager.CFOHHHNJOBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string EPIGLKJFOFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler FCBOMCCMHJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly OBBMIKJGLGE CNIBCAHMDLN;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7216330", Offset = "0x7214D30", VA = "0x187216330")]
			public LJBADGACKBN(OBBMIKJGLGE LDGCONOKKJN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7215F40", Offset = "0x7214940", VA = "0x187215F40", Slot = "4")]
			public void DBFKLINPIFI(ScriptableRenderContext MPOBGCPIOEI, RenderingData NPNFJHBDFOF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class APKIDGIFBFA : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string EFGNPLAKICI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly OBBMIKJGLGE LDGCONOKKJN;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x72145C0", Offset = "0x7212FC0", VA = "0x1872145C0")]
			public APKIDGIFBFA(RenderPassEvent GBJFKAGIBCB, OBBMIKJGLGE LDGCONOKKJN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x72142B0", Offset = "0x7212CB0", VA = "0x1872142B0", Slot = "9")]
			public override void Execute(ScriptableRenderContext MPOBGCPIOEI, RenderingData NPNFJHBDFOF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<MKHDGKDKHGN> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private LJBADGACKBN fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private APKIDGIFBFA fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private OBBMIKJGLGE sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7214FE0", Offset = "0x72139E0", VA = "0x187214FE0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7215360", Offset = "0x7213D60", VA = "0x187215360", Slot = "9")]
		protected override void Dispose(bool ODGHBPLNEHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7214F50", Offset = "0x7213950", VA = "0x187214F50", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer DGLLFNJJPBO, RenderingData NPNFJHBDFOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x100ED00", Offset = "0x100D700", VA = "0x18100ED00")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MKHDGKDKHGN
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LOCHNIIEKLE(CommandBuffer LBOGFPKFLHC, Camera LPMABFPOKDA, [NotNull] UniversalAdditionalCameraData ADNHEBHJICE, bool NINOPHHAJEC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NCJLACNDGIK(Camera LPMABFPOKDA, CommandBuffer KIDNBOFHEDH);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Fade")]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct OKCALMEFPBO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float EJPOMKJJBBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public float JDAJENCMKJM;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private class DJAJGLPIOHL : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string OHHFOLAAFJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler LKPECGJEAOC;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int CGFFBMOOHCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private Material DKHAMIMAFIN;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7214DF0", Offset = "0x72137F0", VA = "0x187214DF0")]
			public DJAJGLPIOHL(RenderPassEvent GBJFKAGIBCB, Material PPFNGNPGEKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7214A20", Offset = "0x7213420", VA = "0x187214A20", Slot = "9")]
			public override void Execute(ScriptableRenderContext MPOBGCPIOEI, RenderingData NPNFJHBDFOF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static OKCALMEFPBO CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private DJAJGLPIOHL m_MobileFadePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[Reload("Shaders/MobileFade.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7216E20", Offset = "0x7215820", VA = "0x187216E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7216DD0", Offset = "0x72157D0", VA = "0x187216DD0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7216C20", Offset = "0x7215620", VA = "0x187216C20", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7216B50", Offset = "0x7215550", VA = "0x187216B50", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer DGLLFNJJPBO, RenderingData NPNFJHBDFOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x100ED00", Offset = "0x100D700", VA = "0x18100ED00")]
		public MobileFadeRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Vignette")]
	public class MobileVignetteRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public struct BFDKDMJGIHB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float LLLPJALDGED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Color EIHLEMKGEMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Mesh PIOLIJPIJEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AnimationCurve AODCNIFMCDM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public sealed class CHNDBIANOOA : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static readonly string OHHFOLAAFJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private ProfilingSampler LKPECGJEAOC;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static readonly int MFLLDHONLFC;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static readonly int CDPNCPDKGOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Material DKHAMIMAFIN;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7214940", Offset = "0x7213340", VA = "0x187214940")]
			public CHNDBIANOOA(RenderPassEvent GBJFKAGIBCB, Material PPFNGNPGEKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x72146A0", Offset = "0x72130A0", VA = "0x1872146A0", Slot = "9")]
			public override void Execute(ScriptableRenderContext MPOBGCPIOEI, RenderingData NPNFJHBDFOF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static BFDKDMJGIHB CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private CHNDBIANOOA m_MobileVignettePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[Reload("Shaders/MobileVignette.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7217130", Offset = "0x7215B30", VA = "0x187217130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7216F80", Offset = "0x7215980", VA = "0x187216F80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7216E70", Offset = "0x7215870", VA = "0x187216E70", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer DGLLFNJJPBO, RenderingData NPNFJHBDFOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x100ED00", Offset = "0x100D700", VA = "0x18100ED00")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string LJBGOBNHIIH
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool MEEHANMJIFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer KIDNBOFHEDH, ScriptableRenderContext MPOBGCPIOEI, RenderingData NPNFJHBDFOF);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220")]
		protected PerCameraRenderEffect()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[Tooltip("RR Per-Camera Render Effects")]
	[DisallowMultipleRendererFeature(null)]
	public class PerCameraRenderEffectsRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private class MOKCNLHNDBH : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private bool JDAEEKPNFPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private readonly List<PerCameraRenderEffect> ONHNIBONIEO;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private static readonly List<PerCameraRenderEffect> LOJAOADMOPE;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7216AA0", Offset = "0x72154A0", VA = "0x187216AA0")]
			public MOKCNLHNDBH(RenderPassEvent GBJFKAGIBCB, bool JDAEEKPNFPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7216730", Offset = "0x7215130", VA = "0x187216730")]
			public bool MLJEJKJPEFG(CameraData ADNHEBHJICE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7216480", Offset = "0x7214E80", VA = "0x187216480", Slot = "9")]
			public override void Execute(ScriptableRenderContext MPOBGCPIOEI, RenderingData NPNFJHBDFOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7216650", Offset = "0x7215050", VA = "0x187216650")]
			private void HAOGPBBGANH(PerCameraRenderEffect LIIPIFLDAIO, ScriptableRenderContext MPOBGCPIOEI, RenderingData NPNFJHBDFOF)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private MOKCNLHNDBH m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private MOKCNLHNDBH m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x72172A0", Offset = "0x7215CA0", VA = "0x1872172A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7217210", Offset = "0x7215C10", VA = "0x187217210", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer DGLLFNJJPBO, RenderingData NPNFJHBDFOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x100ED00", Offset = "0x100D700", VA = "0x18100ED00")]
		public PerCameraRenderEffectsRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[Tooltip("RR Persistent Buffer Effects")]
	[DisallowMultipleRendererFeature(null)]
	public class PersistentBufferEffectsRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly List<ScriptableRenderPass> passes;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const RenderPassEvent RENDER_PASS_EVENT = RenderPassEvent.BeforeRenderingShadows;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x72174F0", Offset = "0x7215EF0", VA = "0x1872174F0")]
		public static void PLNAPLBMHGI(ScriptableRenderPass MILFCOOGLNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7217350", Offset = "0x7215D50", VA = "0x187217350", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer DGLLFNJJPBO, RenderingData NPNFJHBDFOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x100ED00", Offset = "0x100D700", VA = "0x18100ED00")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class GNINGLMJHKK
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly CAFGMNLACIN AOJOINAGKIG;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly CAFGMNLACIN HHJLOJFEDBB;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly CAFGMNLACIN BKECGEOBMIM;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly CAFGMNLACIN JMDCCBNGMAO;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class IKDCOAHKBCK
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static Mesh HEAKEFHHAPE;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7215640", Offset = "0x7214040", VA = "0x187215640")]
	public static Mesh FPFMIAAMPJH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7215AA0", Offset = "0x72144A0", VA = "0x187215AA0")]
	public static Matrix4x4 MMAOKENDENG(Camera LPMABFPOKDA, bool ENBFOALNMHE = false, bool PPCFKCHFKGP = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x72156E0", Offset = "0x72140E0", VA = "0x1872156E0")]
	private static Mesh LIFGCJFNNNC()
	{
		return null;
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
