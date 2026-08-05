using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Logging.Attributes;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : PBLCGONKBFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x706D900", Offset = "0x706BF00", VA = "0x18706D900", Slot = "4")]
		public override void NECNOABNHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x890970", Offset = "0x88EF70", VA = "0x180890970")]
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
		public enum GFAIDGPKJLH
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface GFJNNDCHILF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void PAIJEEONJHA(ScriptableRenderContext CAMDIODFJJE, List<Camera> KOBIICIIINA);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface BKJAKLAHNGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void PAIJEEONJHA(ScriptableRenderContext CAMDIODFJJE, RenderingData CNMBPDMPBMB);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class HJNLBHEKKNK : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x706CD10", Offset = "0x706B310", VA = "0x18706CD10")]
			public HJNLBHEKKNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x706CCB0", Offset = "0x706B2B0", VA = "0x18706CCB0", Slot = "9")]
			public override void Execute(ScriptableRenderContext CAMDIODFJJE, RenderingData CNMBPDMPBMB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private HJNLBHEKKNK _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<GFJNNDCHILF> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<GFJNNDCHILF> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<BKJAKLAHNGH> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<BKJAKLAHNGH> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x70702E0", Offset = "0x706E8E0", VA = "0x1870702E0")]
		public static void DIFODENFCEG(GFAIDGPKJLH ONLCKNLOAPO, GFJNNDCHILF FABMDOGIHAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7070570", Offset = "0x706EB70", VA = "0x187070570")]
		public static void EIHNLOMCFAB(GFAIDGPKJLH ONLCKNLOAPO, GFJNNDCHILF FABMDOGIHAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7070220", Offset = "0x706E820", VA = "0x187070220")]
		public static void DIFODENFCEG(GFAIDGPKJLH ONLCKNLOAPO, BKJAKLAHNGH IAHMBBMPPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x70704B0", Offset = "0x706EAB0", VA = "0x1870704B0")]
		public static void EIHNLOMCFAB(GFAIDGPKJLH ONLCKNLOAPO, BKJAKLAHNGH IAHMBBMPPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x706FB50", Offset = "0x706E150", VA = "0x18706FB50", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x706FAA0", Offset = "0x706E0A0", VA = "0x18706FAA0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PGOGAFFEFPG, RenderingData CNMBPDMPBMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x70703A0", Offset = "0x706E9A0", VA = "0x1870703A0", Slot = "9")]
		protected override void Dispose(bool OEBOBHPNOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x706F590", Offset = "0x706DB90", VA = "0x18706F590")]
		private static void AICBCPMGCBL(ScriptableRenderContext CAMDIODFJJE, List<Camera> KOBIICIIINA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x706F520", Offset = "0x706DB20", VA = "0x18706F520")]
		private static void ACMLGMHEGJG(ScriptableRenderContext CAMDIODFJJE, List<Camera> KOBIICIIINA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x706FD40", Offset = "0x706E340", VA = "0x18706FD40")]
		private static void DBPIICAABIP(ScriptableRenderContext CAMDIODFJJE, RenderingData CNMBPDMPBMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xDD2370", Offset = "0xDD0970", VA = "0x180DD2370")]
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
		private class AIIHOBAKJKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool OPPCLHEICEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<OGHKEFFDHIH> CDPODGILKJN;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x706B8C0", Offset = "0x7069EC0", VA = "0x18706B8C0")]
			public AIIHOBAKJKJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class GAAFJDFAFAA : PreRenderManager.BKJAKLAHNGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string EHIDGCCNLIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler OJGCDIELIND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly AIIHOBAKJKJ IPFKHGFNIOO;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x706C850", Offset = "0x706AE50", VA = "0x18706C850")]
			public GAAFJDFAFAA(AIIHOBAKJKJ OHKGOIIFOGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x706C440", Offset = "0x706AA40", VA = "0x18706C440", Slot = "4")]
			public void PAIJEEONJHA(ScriptableRenderContext CAMDIODFJJE, RenderingData CNMBPDMPBMB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class JDDAJKAJCNF : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string AEMJGFHAANI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly AIIHOBAKJKJ OHKGOIIFOGH;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x706D720", Offset = "0x706BD20", VA = "0x18706D720")]
			public JDDAJKAJCNF(RenderPassEvent DNLMIBJALAD, AIIHOBAKJKJ OHKGOIIFOGH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x706D410", Offset = "0x706BA10", VA = "0x18706D410", Slot = "9")]
			public override void Execute(ScriptableRenderContext CAMDIODFJJE, RenderingData CNMBPDMPBMB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<OGHKEFFDHIH> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private GAAFJDFAFAA fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private JDDAJKAJCNF fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private AIIHOBAKJKJ sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x706BEB0", Offset = "0x706A4B0", VA = "0x18706BEB0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x706C240", Offset = "0x706A840", VA = "0x18706C240", Slot = "9")]
		protected override void Dispose(bool OEBOBHPNOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x706BE10", Offset = "0x706A410", VA = "0x18706BE10", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PGOGAFFEFPG, RenderingData CNMBPDMPBMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xDD2370", Offset = "0xDD0970", VA = "0x180DD2370")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OGHKEFFDHIH
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CAMLLMHACHP(CommandBuffer HKLEKDEAFKC, Camera PNKNDBCILOE, [NotNull] UniversalAdditionalCameraData BGAACPIEOJJ, bool AELCGPKOCFC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCHAAOJOJMK(Camera PNKNDBCILOE, CommandBuffer MGGOHHEBAAI);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Fade")]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct JMMAKNKAOIH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float HOMNMLCAIBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public float EGDJONHOPCJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private class CCNHLJDHOPN : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string EDNFIFLJIGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler ENKPJKHKMNG;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int JEFHPGAECGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private Material GPNCMEAMLKP;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x706BD30", Offset = "0x706A330", VA = "0x18706BD30")]
			public CCNHLJDHOPN(RenderPassEvent DNLMIBJALAD, Material OLKLLNJBJND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x706B950", Offset = "0x7069F50", VA = "0x18706B950", Slot = "9")]
			public override void Execute(ScriptableRenderContext CAMDIODFJJE, RenderingData CNMBPDMPBMB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static JMMAKNKAOIH CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private CCNHLJDHOPN m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x706DCA0", Offset = "0x706C2A0", VA = "0x18706DCA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x706DC50", Offset = "0x706C250", VA = "0x18706DC50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x706DAA0", Offset = "0x706C0A0", VA = "0x18706DAA0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x706D9D0", Offset = "0x706BFD0", VA = "0x18706D9D0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PGOGAFFEFPG, RenderingData CNMBPDMPBMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xDD2370", Offset = "0xDD0970", VA = "0x180DD2370")]
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
		public struct BBBAJBACOMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float KHGCDFOHGAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Color ILFCNJHJMMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Mesh BKMJACOKIMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AnimationCurve KEDBIHJDNOP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public sealed class HDCKBMHACCK : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static readonly string EDNFIFLJIGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private ProfilingSampler ENKPJKHKMNG;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static readonly int CBMJEJCHFCI;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static readonly int MAJMLMPIKOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Material GPNCMEAMLKP;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x706CBD0", Offset = "0x706B1D0", VA = "0x18706CBD0")]
			public HDCKBMHACCK(RenderPassEvent DNLMIBJALAD, Material OLKLLNJBJND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x706C910", Offset = "0x706AF10", VA = "0x18706C910", Slot = "9")]
			public override void Execute(ScriptableRenderContext CAMDIODFJJE, RenderingData CNMBPDMPBMB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static BBBAJBACOMB CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private HDCKBMHACCK m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x706DFD0", Offset = "0x706C5D0", VA = "0x18706DFD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x706DE20", Offset = "0x706C420", VA = "0x18706DE20", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x706DD00", Offset = "0x706C300", VA = "0x18706DD00", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PGOGAFFEFPG, RenderingData CNMBPDMPBMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xDD2370", Offset = "0xDD0970", VA = "0x180DD2370")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string KNJBFCMNKCP
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool LELIEPPDADH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8AF060", Offset = "0x8AD660", VA = "0x1808AF060", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer MGGOHHEBAAI, ScriptableRenderContext CAMDIODFJJE, RenderingData CNMBPDMPBMB);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x867780", Offset = "0x865D80", VA = "0x180867780")]
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
		private class IMCFIOEFGHD : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private bool CAFALCEOKHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private readonly List<PerCameraRenderEffect> LADGDLCLJHL;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private static readonly List<PerCameraRenderEffect> CFEMKNBKAPC;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x706D360", Offset = "0x706B960", VA = "0x18706D360")]
			public IMCFIOEFGHD(RenderPassEvent DNLMIBJALAD, bool CAFALCEOKHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x706CFE0", Offset = "0x706B5E0", VA = "0x18706CFE0")]
			public bool NAPKFKKJOCC(CameraData BGAACPIEOJJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x706CD30", Offset = "0x706B330", VA = "0x18706CD30", Slot = "9")]
			public override void Execute(ScriptableRenderContext CAMDIODFJJE, RenderingData CNMBPDMPBMB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x706CF00", Offset = "0x706B500", VA = "0x18706CF00")]
			private void HOKGKBHAOEA(PerCameraRenderEffect EPDOOCKJEFN, ScriptableRenderContext CAMDIODFJJE, RenderingData CNMBPDMPBMB)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private IMCFIOEFGHD m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private IMCFIOEFGHD m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x706F160", Offset = "0x706D760", VA = "0x18706F160", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x706F0D0", Offset = "0x706D6D0", VA = "0x18706F0D0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PGOGAFFEFPG, RenderingData CNMBPDMPBMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xDD2370", Offset = "0xDD0970", VA = "0x180DD2370")]
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
		[Cpp2IlInjected.Address(RVA = "0x706F3B0", Offset = "0x706D9B0", VA = "0x18706F3B0")]
		public static void FHMDEADOEFK(ScriptableRenderPass IHAIHGAGKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x706F210", Offset = "0x706D810", VA = "0x18706F210", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PGOGAFFEFPG, RenderingData CNMBPDMPBMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xDD2370", Offset = "0xDD0970", VA = "0x180DD2370")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class KBDOADOENLB
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly PBGLEKOCCEM BPFDLDIOANF;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly PBGLEKOCCEM HEMLLDDPGJI;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly PBGLEKOCCEM CGLILCKDNDF;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly PBGLEKOCCEM FCKJMKKJDGN;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BEKJDHDDOBG
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int? JDCJPHDGDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFABBMEGBAN();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NABEPHMDIGC : BEKJDHDDOBG
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly PBGLEKOCCEM APPJEAMJBHK;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly string FLDBDIKALMJ;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly string KBIABPFBMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private NMMBPCBEFII NBOJFNFHFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int? MADIJHGABMH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int? JDCJPHDGDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x872130", Offset = "0x870730", VA = "0x180872130")]
	[UnityEngine.Scripting.Preserve]
	public NABEPHMDIGC([JAMCDGPOOBO(null)][NotNull] NMMBPCBEFII ICHJIAGMLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x706E030", Offset = "0x706C630", VA = "0x18706E030")]
	[UsedImplicitly]
	[ILMJIPMJHLC(LIEKAGJMIGB.Session, IAFNNCJJPGN.GameOnly)]
	public static void BAACPBMFNBB(GLOPJKBGAFG PCIOPLPELBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x706E5B0", Offset = "0x706CBB0", VA = "0x18706E5B0", Slot = "5")]
	public void MFABBMEGBAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x706E130", Offset = "0x706C730", VA = "0x18706E130")]
	private void CHOMDHAPION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x706E4D0", Offset = "0x706CAD0", VA = "0x18706E4D0")]
	private bool ECCJJALILJO(string HNAAKKDEMBK, [Out] OGADDIHGPOA BOOHFNNMNIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class NNAJFCPHGEH
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static Mesh MFFPKJEKAIA;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x706EB80", Offset = "0x706D180", VA = "0x18706EB80")]
	public static Mesh KBLFKKOJOAP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x706EC30", Offset = "0x706D230", VA = "0x18706EC30")]
	public static Matrix4x4 MLBFLBBACMF(Camera PNKNDBCILOE, bool EPJAMAOPAHG = false, bool GODNFHOJHJA = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x706E7C0", Offset = "0x706CDC0", VA = "0x18706E7C0")]
	private static Mesh HHEAJNPFLPG()
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
