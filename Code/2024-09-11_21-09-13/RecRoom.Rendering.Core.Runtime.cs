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
	public class LogRegistrationIndex : BGIOGCHCHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x71E6710", Offset = "0x71E4D10", VA = "0x1871E6710", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		public enum KNEINJDGIEB
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface BICEBKBJPLP
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void FMNDAIGJPOF(ScriptableRenderContext EIGKPCONJCB, List<Camera> EMDKHKKHEME);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface FLJKHDAAIJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void FMNDAIGJPOF(ScriptableRenderContext EIGKPCONJCB, RenderingData JLJFGIMLKEC);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class ABCCNOEHCJB : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x71E47F0", Offset = "0x71E2DF0", VA = "0x1871E47F0")]
			public ABCCNOEHCJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x71E4790", Offset = "0x71E2D90", VA = "0x1871E4790", Slot = "9")]
			public override void Execute(ScriptableRenderContext EIGKPCONJCB, RenderingData JLJFGIMLKEC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ABCCNOEHCJB _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<BICEBKBJPLP> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<BICEBKBJPLP> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<FLJKHDAAIJP> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<FLJKHDAAIJP> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x71E7CB0", Offset = "0x71E62B0", VA = "0x1871E7CB0")]
		public static void CPPCPHAGMLK(KNEINJDGIEB EOKIPDGDMMK, BICEBKBJPLP ABEDKBLNCKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x71E8060", Offset = "0x71E6660", VA = "0x1871E8060")]
		public static void HCAKCOGPKHO(KNEINJDGIEB EOKIPDGDMMK, BICEBKBJPLP ABEDKBLNCKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x71E7BF0", Offset = "0x71E61F0", VA = "0x1871E7BF0")]
		public static void CPPCPHAGMLK(KNEINJDGIEB EOKIPDGDMMK, FLJKHDAAIJP FCGLHGGJPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x71E8120", Offset = "0x71E6720", VA = "0x1871E8120")]
		public static void HCAKCOGPKHO(KNEINJDGIEB EOKIPDGDMMK, FLJKHDAAIJP FCGLHGGJPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x71E7D70", Offset = "0x71E6370", VA = "0x1871E7D70", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x71E7B50", Offset = "0x71E6150", VA = "0x1871E7B50", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MGJKLBPNDCE, RenderingData JLJFGIMLKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x71E7F50", Offset = "0x71E6550", VA = "0x1871E7F50", Slot = "9")]
		protected override void Dispose(bool CEPHJMGNDCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x71E81E0", Offset = "0x71E67E0", VA = "0x1871E81E0")]
		private static void MKNLLKKFKAB(ScriptableRenderContext EIGKPCONJCB, List<Camera> EMDKHKKHEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x71E86D0", Offset = "0x71E6CD0", VA = "0x1871E86D0")]
		private static void MMEELCJOFCA(ScriptableRenderContext EIGKPCONJCB, List<Camera> EMDKHKKHEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x71E8740", Offset = "0x71E6D40", VA = "0x1871E8740")]
		private static void NLHIPHDPCFA(ScriptableRenderContext EIGKPCONJCB, RenderingData JLJFGIMLKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF54870", Offset = "0xF52E70", VA = "0x180F54870")]
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
		private class PDGIMHEHHEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool HPJBHFJAEDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<CJEOHBBCMOE> JIKFJDBFLGN;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x71E7670", Offset = "0x71E5C70", VA = "0x1871E7670")]
			public PDGIMHEHHEN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class EDPOHOJEEOG : PreRenderManager.FLJKHDAAIJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string BJIFJJEAEFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler PCHIJHKAPCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly PDGIMHEHHEN LMOEAFHCKJP;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x71E5600", Offset = "0x71E3C00", VA = "0x1871E5600")]
			public EDPOHOJEEOG(PDGIMHEHHEN DGBIABOIEBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x71E5200", Offset = "0x71E3800", VA = "0x1871E5200", Slot = "4")]
			public void FMNDAIGJPOF(ScriptableRenderContext EIGKPCONJCB, RenderingData JLJFGIMLKEC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class NNOHCNPGAOO : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string OBGFOFFMEDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly PDGIMHEHHEN DGBIABOIEBN;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x71E70E0", Offset = "0x71E56E0", VA = "0x1871E70E0")]
			public NNOHCNPGAOO(RenderPassEvent KNAJJHHNHND, PDGIMHEHHEN DGBIABOIEBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x71E6DD0", Offset = "0x71E53D0", VA = "0x1871E6DD0", Slot = "9")]
			public override void Execute(ScriptableRenderContext EIGKPCONJCB, RenderingData JLJFGIMLKEC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<CJEOHBBCMOE> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private EDPOHOJEEOG fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private NNOHCNPGAOO fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private PDGIMHEHHEN sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x71E5750", Offset = "0x71E3D50", VA = "0x1871E5750", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x71E5AD0", Offset = "0x71E40D0", VA = "0x1871E5AD0", Slot = "9")]
		protected override void Dispose(bool CEPHJMGNDCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x71E56C0", Offset = "0x71E3CC0", VA = "0x1871E56C0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MGJKLBPNDCE, RenderingData JLJFGIMLKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xF54870", Offset = "0xF52E70", VA = "0x180F54870")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CJEOHBBCMOE
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MAKAMEELMOM(CommandBuffer BNGEJBHJNLC, Camera FIJJFNJDPAF, [NotNull] UniversalAdditionalCameraData JAOBICNLCGO, bool CMEJCBIELID);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBANLEBDIDM(Camera FIJJFNJDPAF, CommandBuffer FMDCOJMFHLF);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Fade")]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct GJCBFFPFCPG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float PHEGICEIHOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public float FGJKMDBJLIJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private class OBHGPDBLGHE : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string EIHPCFDDABN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler HBFJMBKGBEJ;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int LDIFPOBNGIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private Material CKHBMPBPKNA;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x71E7590", Offset = "0x71E5B90", VA = "0x1871E7590")]
			public OBHGPDBLGHE(RenderPassEvent KNAJJHHNHND, Material KFGOIEOLDHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x71E71C0", Offset = "0x71E57C0", VA = "0x1871E71C0", Slot = "9")]
			public override void Execute(ScriptableRenderContext EIGKPCONJCB, RenderingData JLJFGIMLKEC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static GJCBFFPFCPG CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private OBHGPDBLGHE m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x71E6A70", Offset = "0x71E5070", VA = "0x1871E6A70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x71E6A20", Offset = "0x71E5020", VA = "0x1871E6A20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x71E6870", Offset = "0x71E4E70", VA = "0x1871E6870", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x71E67A0", Offset = "0x71E4DA0", VA = "0x1871E67A0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MGJKLBPNDCE, RenderingData JLJFGIMLKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xF54870", Offset = "0xF52E70", VA = "0x180F54870")]
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
		public struct FGIOFGJNAJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float OIIIFIPHNDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Color GMDICIHANPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Mesh EJAFNEGBDAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AnimationCurve KAPDBCLIMFO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public sealed class JCMMEBOBHFI : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static readonly string EIHPCFDDABN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private ProfilingSampler HBFJMBKGBEJ;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static readonly int CKPHAJIHIGA;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static readonly int DCFOLOLFBHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Material CKHBMPBPKNA;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x71E6630", Offset = "0x71E4C30", VA = "0x1871E6630")]
			public JCMMEBOBHFI(RenderPassEvent KNAJJHHNHND, Material KFGOIEOLDHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x71E6390", Offset = "0x71E4990", VA = "0x1871E6390", Slot = "9")]
			public override void Execute(ScriptableRenderContext EIGKPCONJCB, RenderingData JLJFGIMLKEC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static FGIOFGJNAJA CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private JCMMEBOBHFI m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x71E6D80", Offset = "0x71E5380", VA = "0x1871E6D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x71E6BD0", Offset = "0x71E51D0", VA = "0x1871E6BD0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x71E6AC0", Offset = "0x71E50C0", VA = "0x1871E6AC0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MGJKLBPNDCE, RenderingData JLJFGIMLKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xF54870", Offset = "0xF52E70", VA = "0x180F54870")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string MGAJMIHCLBD
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool NHLPNNEPOKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer FMDCOJMFHLF, ScriptableRenderContext EIGKPCONJCB, RenderingData JLJFGIMLKEC);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x885340", Offset = "0x883940", VA = "0x180885340")]
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
		private class HMNONNLJKAK : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private bool JPFPLIFAPKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private readonly List<PerCameraRenderEffect> MKDECBAHBMH;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private static readonly List<PerCameraRenderEffect> OELBBECKKMJ;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x71E62E0", Offset = "0x71E48E0", VA = "0x1871E62E0")]
			public HMNONNLJKAK(RenderPassEvent KNAJJHHNHND, bool JPFPLIFAPKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x71E5CC0", Offset = "0x71E42C0", VA = "0x1871E5CC0")]
			public bool AOBEGDFBGEF(CameraData JAOBICNLCGO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x71E6080", Offset = "0x71E4680", VA = "0x1871E6080", Slot = "9")]
			public override void Execute(ScriptableRenderContext EIGKPCONJCB, RenderingData JLJFGIMLKEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x71E5FA0", Offset = "0x71E45A0", VA = "0x1871E5FA0")]
			private void DNLNFNHHPJG(PerCameraRenderEffect FDIMNBGELJP, ScriptableRenderContext EIGKPCONJCB, RenderingData JLJFGIMLKEC)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private HMNONNLJKAK m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private HMNONNLJKAK m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x71E7790", Offset = "0x71E5D90", VA = "0x1871E7790", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x71E7700", Offset = "0x71E5D00", VA = "0x1871E7700", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MGJKLBPNDCE, RenderingData JLJFGIMLKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xF54870", Offset = "0xF52E70", VA = "0x180F54870")]
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
		[Cpp2IlInjected.Address(RVA = "0x71E79E0", Offset = "0x71E5FE0", VA = "0x1871E79E0")]
		public static void FAKLGEBPOPG(ScriptableRenderPass ABIJLKBODDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x71E7840", Offset = "0x71E5E40", VA = "0x1871E7840", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MGJKLBPNDCE, RenderingData JLJFGIMLKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xF54870", Offset = "0xF52E70", VA = "0x180F54870")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DNILDODGNAO
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly CMICIECANPG ECGBJENFOOP;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly CMICIECANPG PNEDOIDNGDO;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly CMICIECANPG AGHHDJJMBAF;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly CMICIECANPG ECKDHPBGPKA;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class BIGJOIDGCIH
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static Mesh HPJGMAHMBKO;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x71E5070", Offset = "0x71E3670", VA = "0x1871E5070")]
	public static Mesh OFLEHPLALGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x71E4810", Offset = "0x71E2E10", VA = "0x1871E4810")]
	public static Matrix4x4 IGMGPHHPLPL(Camera FIJJFNJDPAF, bool ILAAIHCIEGG = false, bool LAKCCHFLBKE = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x71E4CB0", Offset = "0x71E32B0", VA = "0x1871E4CB0")]
	private static Mesh KEPONAODAHO()
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
