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
	public class LogRegistrationIndex : MBMEJMGLEPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F28870", Offset = "0x6F27270", VA = "0x186F28870", Slot = "4")]
		public override void PMAGAGNLFOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x876AF0", Offset = "0x8754F0", VA = "0x180876AF0")]
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
		public enum AFPKHGEMEHO
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface HOHKPGMCLMB
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void GGDEKLHCCBN(ScriptableRenderContext NIDJKNBFFJH, List<Camera> LFDAGLODALD);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface PFBNGLNNEHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void GGDEKLHCCBN(ScriptableRenderContext NIDJKNBFFJH, RenderingData IGPOGEIHIPI);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class PGDDAADHBLL : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6F298B0", Offset = "0x6F282B0", VA = "0x186F298B0")]
			public PGDDAADHBLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6F29850", Offset = "0x6F28250", VA = "0x186F29850", Slot = "9")]
			public override void Execute(ScriptableRenderContext NIDJKNBFFJH, RenderingData IGPOGEIHIPI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private PGDDAADHBLL _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<HOHKPGMCLMB> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<HOHKPGMCLMB> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<PFBNGLNNEHK> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<PFBNGLNNEHK> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A630", Offset = "0x6F29030", VA = "0x186F2A630")]
		public static void HHIJPCFMIFL(AFPKHGEMEHO BMGFFJNHDIA, HOHKPGMCLMB IGBBKNONKIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A870", Offset = "0x6F29270", VA = "0x186F2A870")]
		public static void JLNGGCPIEJH(AFPKHGEMEHO BMGFFJNHDIA, HOHKPGMCLMB IGBBKNONKIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A6F0", Offset = "0x6F290F0", VA = "0x186F2A6F0")]
		public static void HHIJPCFMIFL(AFPKHGEMEHO BMGFFJNHDIA, PFBNGLNNEHK PPEIEMMGCIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A7B0", Offset = "0x6F291B0", VA = "0x186F2A7B0")]
		public static void JLNGGCPIEJH(AFPKHGEMEHO BMGFFJNHDIA, PFBNGLNNEHK PPEIEMMGCIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F29E40", Offset = "0x6F28840", VA = "0x186F29E40", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F29D20", Offset = "0x6F28720", VA = "0x186F29D20", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EBCGCCILOJN, RenderingData IGPOGEIHIPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A030", Offset = "0x6F28A30", VA = "0x186F2A030", Slot = "9")]
		protected override void Dispose(bool NENEMNCPKOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A140", Offset = "0x6F28B40", VA = "0x186F2A140")]
		private static void GDJKNLJMIHH(ScriptableRenderContext NIDJKNBFFJH, List<Camera> LFDAGLODALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F29DD0", Offset = "0x6F287D0", VA = "0x186F29DD0")]
		private static void BMOIAINCOLL(ScriptableRenderContext NIDJKNBFFJH, List<Camera> LFDAGLODALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F2A930", Offset = "0x6F29330", VA = "0x186F2A930")]
		private static void NKHIDADEPOD(ScriptableRenderContext NIDJKNBFFJH, RenderingData IGPOGEIHIPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD98FE0", Offset = "0xD979E0", VA = "0x180D98FE0")]
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
		private class FPNJMPEFPPO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool IEOACAJMPNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<EDFFHHGMMKG> DMOPMHMFAPJ;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F27040", Offset = "0x6F25A40", VA = "0x186F27040")]
			public FPNJMPEFPPO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class MOIHDOCOHNC : PreRenderManager.PFBNGLNNEHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string JKKLOCMKPGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler OAKGFAFGCFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly FPNJMPEFPPO IPMAJJAGLFF;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F29130", Offset = "0x6F27B30", VA = "0x186F29130")]
			public MOIHDOCOHNC(FPNJMPEFPPO IBMCCNCABEG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6F28D30", Offset = "0x6F27730", VA = "0x186F28D30", Slot = "4")]
			public void GGDEKLHCCBN(ScriptableRenderContext NIDJKNBFFJH, RenderingData IGPOGEIHIPI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class MNOEJFKEHPG : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string DACDOKNBFOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly FPNJMPEFPPO IBMCCNCABEG;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F28C50", Offset = "0x6F27650", VA = "0x186F28C50")]
			public MNOEJFKEHPG(RenderPassEvent JHEBABABGON, FPNJMPEFPPO IBMCCNCABEG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6F28940", Offset = "0x6F27340", VA = "0x186F28940", Slot = "9")]
			public override void Execute(ScriptableRenderContext NIDJKNBFFJH, RenderingData IGPOGEIHIPI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<EDFFHHGMMKG> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private MOIHDOCOHNC fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private MNOEJFKEHPG fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private FPNJMPEFPPO sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F27170", Offset = "0x6F25B70", VA = "0x186F27170", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F27500", Offset = "0x6F25F00", VA = "0x186F27500", Slot = "9")]
		protected override void Dispose(bool NENEMNCPKOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F270D0", Offset = "0x6F25AD0", VA = "0x186F270D0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EBCGCCILOJN, RenderingData IGPOGEIHIPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD98FE0", Offset = "0xD979E0", VA = "0x180D98FE0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EDFFHHGMMKG
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KCEFFIHECIK(CommandBuffer BGIPPKPIDCO, Camera HGOCAPKHKNC, [NotNull] UniversalAdditionalCameraData LDPKJBKCEND, bool HDMPFPLEPEF);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DEHIFMJMHPP(Camera HGOCAPKHKNC, CommandBuffer CPFKNKMCNPD);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Fade")]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct LENFHFHKLBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float PHJIOBADOIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public float OCPEGNMBHDG;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private class LDDDECCCGKB : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string OONBDOEAMDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler HENONHJPMLO;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int IALJNNOHINF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private Material MPMGPLKGNLP;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6F28790", Offset = "0x6F27190", VA = "0x186F28790")]
			public LDDDECCCGKB(RenderPassEvent JHEBABABGON, Material OKNIOBAOHHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6F283B0", Offset = "0x6F26DB0", VA = "0x186F283B0", Slot = "9")]
			public override void Execute(ScriptableRenderContext NIDJKNBFFJH, RenderingData IGPOGEIHIPI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static LENFHFHKLBI CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private LDDDECCCGKB m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x6F294C0", Offset = "0x6F27EC0", VA = "0x186F294C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6F29470", Offset = "0x6F27E70", VA = "0x186F29470")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F292C0", Offset = "0x6F27CC0", VA = "0x186F292C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F291F0", Offset = "0x6F27BF0", VA = "0x186F291F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EBCGCCILOJN, RenderingData IGPOGEIHIPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xD98FE0", Offset = "0xD979E0", VA = "0x180D98FE0")]
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
		public struct GKNHNKBJDJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float DCIPEAMPEIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Color HJHGODOEGIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Mesh HPEENBKBCGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AnimationCurve IMCGFJANJDH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public sealed class IJEKDFEMPAH : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static readonly string OONBDOEAMDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private ProfilingSampler HENONHJPMLO;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static readonly int EOLGPHDCBEM;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static readonly int EHBKJKHKDFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Material MPMGPLKGNLP;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F282D0", Offset = "0x6F26CD0", VA = "0x186F282D0")]
			public IJEKDFEMPAH(RenderPassEvent JHEBABABGON, Material OKNIOBAOHHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F28010", Offset = "0x6F26A10", VA = "0x186F28010", Slot = "9")]
			public override void Execute(ScriptableRenderContext NIDJKNBFFJH, RenderingData IGPOGEIHIPI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static GKNHNKBJDJM CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private IJEKDFEMPAH m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x6F297F0", Offset = "0x6F281F0", VA = "0x186F297F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F29640", Offset = "0x6F28040", VA = "0x186F29640", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F29520", Offset = "0x6F27F20", VA = "0x186F29520", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EBCGCCILOJN, RenderingData IGPOGEIHIPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xD98FE0", Offset = "0xD979E0", VA = "0x180D98FE0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string HABJIAKBHIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool BJHMLNEDGJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x894D60", Offset = "0x893760", VA = "0x180894D60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer CPFKNKMCNPD, ScriptableRenderContext NIDJKNBFFJH, RenderingData IGPOGEIHIPI);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x84E1C0", Offset = "0x84CBC0", VA = "0x18084E1C0")]
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
		private class DCNLLPMLCJL : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private bool LBIDGIMPLLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private readonly List<PerCameraRenderEffect> JNEAJEBEABL;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private static readonly List<PerCameraRenderEffect> BCMHJJFFJBA;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F26F90", Offset = "0x6F25990", VA = "0x186F26F90")]
			public DCNLLPMLCJL(RenderPassEvent JHEBABABGON, bool LBIDGIMPLLP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F26B30", Offset = "0x6F25530", VA = "0x186F26B30")]
			public bool GFPMMKHMEDG(CameraData LDPKJBKCEND)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F26960", Offset = "0x6F25360", VA = "0x186F26960", Slot = "9")]
			public override void Execute(ScriptableRenderContext NIDJKNBFFJH, RenderingData IGPOGEIHIPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F26E20", Offset = "0x6F25820", VA = "0x186F26E20")]
			private void IGFLGDLFMOI(PerCameraRenderEffect KPFAKABALCO, ScriptableRenderContext NIDJKNBFFJH, RenderingData IGPOGEIHIPI)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private DCNLLPMLCJL m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private DCNLLPMLCJL m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F29960", Offset = "0x6F28360", VA = "0x186F29960", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F298D0", Offset = "0x6F282D0", VA = "0x186F298D0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EBCGCCILOJN, RenderingData IGPOGEIHIPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xD98FE0", Offset = "0xD979E0", VA = "0x180D98FE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F29BB0", Offset = "0x6F285B0", VA = "0x186F29BB0")]
		public static void BNEHCKLLPAI(ScriptableRenderPass KLOLBHKANPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84CD50", Offset = "0x84B750", VA = "0x18084CD50", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6F29A10", Offset = "0x6F28410", VA = "0x186F29A10", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EBCGCCILOJN, RenderingData IGPOGEIHIPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xD98FE0", Offset = "0xD979E0", VA = "0x180D98FE0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class AAIHFFIMBAN
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly LGKLDLNGEGN BLBACEIMIPB;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly LGKLDLNGEGN HNBIDJDNONJ;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly LGKLDLNGEGN ILDKDBNOGKM;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly LGKLDLNGEGN OHLMHOCPIMA;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GLBDBCPHIOA
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IAEFCGBAGJG();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ACDJLAPHALG : GLBDBCPHIOA
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly LGKLDLNGEGN DHOGKNDCDMM;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly string KLLOIDLIGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private BACKHJNLNPC JBKJEJEMOOC;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x852830", Offset = "0x851230", VA = "0x180852830")]
	[UnityEngine.Scripting.Preserve]
	public ACDJLAPHALG([OHLKLPAILPF(null)][NotNull] BACKHJNLNPC ENPFHCCDEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F267A0", Offset = "0x6F251A0", VA = "0x186F267A0")]
	[UsedImplicitly]
	[MHFEIEAPENL(ABEEEPGJOJM.Session, CMFCLNIIIKO.GameOnly)]
	public static void JHFNJPNNDDE(GPECMKAJNMD FOPICBKBDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F266A0", Offset = "0x6F250A0", VA = "0x186F266A0", Slot = "4")]
	public void IAEFCGBAGJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F26490", Offset = "0x6F24E90", VA = "0x186F26490")]
	private void FIGHLHACLPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F263B0", Offset = "0x6F24DB0", VA = "0x186F263B0")]
	private bool EPCENFLGDIO(string BHMDEDBFGPC, [Out] NLIJFOGGGGC JANEHAACEMB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class HOCMKIPCIII
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static Mesh IDBABCLAAMC;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F27BA0", Offset = "0x6F265A0", VA = "0x186F27BA0")]
	public static Mesh HKIKIIPGILH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F27700", Offset = "0x6F26100", VA = "0x186F27700")]
	public static Matrix4x4 DIGCFMOAJCF(Camera HGOCAPKHKNC, bool HEKDKNKAIIB = false, bool PHOBCHNPIOJ = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F27C50", Offset = "0x6F26650", VA = "0x186F27C50")]
	private static Mesh JLOIPMMMFCF()
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
