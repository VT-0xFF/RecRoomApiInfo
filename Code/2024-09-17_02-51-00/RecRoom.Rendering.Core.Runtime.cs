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
		[Cpp2IlInjected.Address(RVA = "0x72D1C40", Offset = "0x72D0640", VA = "0x1872D1C40", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
			[Cpp2IlInjected.Address(RVA = "0x72CFD20", Offset = "0x72CE720", VA = "0x1872CFD20")]
			public ABCCNOEHCJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x72CFCC0", Offset = "0x72CE6C0", VA = "0x1872CFCC0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x72D31E0", Offset = "0x72D1BE0", VA = "0x1872D31E0")]
		public static void CPPCPHAGMLK(KNEINJDGIEB EOKIPDGDMMK, BICEBKBJPLP ABEDKBLNCKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72D3590", Offset = "0x72D1F90", VA = "0x1872D3590")]
		public static void HCAKCOGPKHO(KNEINJDGIEB EOKIPDGDMMK, BICEBKBJPLP ABEDKBLNCKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72D3120", Offset = "0x72D1B20", VA = "0x1872D3120")]
		public static void CPPCPHAGMLK(KNEINJDGIEB EOKIPDGDMMK, FLJKHDAAIJP FCGLHGGJPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72D3650", Offset = "0x72D2050", VA = "0x1872D3650")]
		public static void HCAKCOGPKHO(KNEINJDGIEB EOKIPDGDMMK, FLJKHDAAIJP FCGLHGGJPHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x72D32A0", Offset = "0x72D1CA0", VA = "0x1872D32A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72D3080", Offset = "0x72D1A80", VA = "0x1872D3080", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MGJKLBPNDCE, RenderingData JLJFGIMLKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72D3480", Offset = "0x72D1E80", VA = "0x1872D3480", Slot = "9")]
		protected override void Dispose(bool CEPHJMGNDCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72D3710", Offset = "0x72D2110", VA = "0x1872D3710")]
		private static void MKNLLKKFKAB(ScriptableRenderContext EIGKPCONJCB, List<Camera> EMDKHKKHEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72D3C00", Offset = "0x72D2600", VA = "0x1872D3C00")]
		private static void MMEELCJOFCA(ScriptableRenderContext EIGKPCONJCB, List<Camera> EMDKHKKHEME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72D3C70", Offset = "0x72D2670", VA = "0x1872D3C70")]
		private static void NLHIPHDPCFA(ScriptableRenderContext EIGKPCONJCB, RenderingData JLJFGIMLKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x10246E0", Offset = "0x10230E0", VA = "0x1810246E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x72D2BA0", Offset = "0x72D15A0", VA = "0x1872D2BA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x72D0B30", Offset = "0x72CF530", VA = "0x1872D0B30")]
			public EDPOHOJEEOG(PDGIMHEHHEN DGBIABOIEBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x72D0730", Offset = "0x72CF130", VA = "0x1872D0730", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x72D2610", Offset = "0x72D1010", VA = "0x1872D2610")]
			public NNOHCNPGAOO(RenderPassEvent KNAJJHHNHND, PDGIMHEHHEN DGBIABOIEBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x72D2300", Offset = "0x72D0D00", VA = "0x1872D2300", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x72D0C80", Offset = "0x72CF680", VA = "0x1872D0C80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72D1000", Offset = "0x72CFA00", VA = "0x1872D1000", Slot = "9")]
		protected override void Dispose(bool CEPHJMGNDCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x72D0BF0", Offset = "0x72CF5F0", VA = "0x1872D0BF0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MGJKLBPNDCE, RenderingData JLJFGIMLKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x10246E0", Offset = "0x10230E0", VA = "0x1810246E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x72D2AC0", Offset = "0x72D14C0", VA = "0x1872D2AC0")]
			public OBHGPDBLGHE(RenderPassEvent KNAJJHHNHND, Material KFGOIEOLDHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x72D26F0", Offset = "0x72D10F0", VA = "0x1872D26F0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x72D1FA0", Offset = "0x72D09A0", VA = "0x1872D1FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x72D1F50", Offset = "0x72D0950", VA = "0x1872D1F50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72D1DA0", Offset = "0x72D07A0", VA = "0x1872D1DA0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72D1CD0", Offset = "0x72D06D0", VA = "0x1872D1CD0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MGJKLBPNDCE, RenderingData JLJFGIMLKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x10246E0", Offset = "0x10230E0", VA = "0x1810246E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x72D1B60", Offset = "0x72D0560", VA = "0x1872D1B60")]
			public JCMMEBOBHFI(RenderPassEvent KNAJJHHNHND, Material KFGOIEOLDHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x72D18C0", Offset = "0x72D02C0", VA = "0x1872D18C0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x72D22B0", Offset = "0x72D0CB0", VA = "0x1872D22B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x72D2100", Offset = "0x72D0B00", VA = "0x1872D2100", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x72D1FF0", Offset = "0x72D09F0", VA = "0x1872D1FF0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MGJKLBPNDCE, RenderingData JLJFGIMLKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x10246E0", Offset = "0x10230E0", VA = "0x1810246E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer FMDCOJMFHLF, ScriptableRenderContext EIGKPCONJCB, RenderingData JLJFGIMLKEC);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x897340", Offset = "0x895D40", VA = "0x180897340")]
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
			[Cpp2IlInjected.Address(RVA = "0x72D1810", Offset = "0x72D0210", VA = "0x1872D1810")]
			public HMNONNLJKAK(RenderPassEvent KNAJJHHNHND, bool JPFPLIFAPKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x72D11F0", Offset = "0x72CFBF0", VA = "0x1872D11F0")]
			public bool AOBEGDFBGEF(CameraData JAOBICNLCGO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x72D15B0", Offset = "0x72CFFB0", VA = "0x1872D15B0", Slot = "9")]
			public override void Execute(ScriptableRenderContext EIGKPCONJCB, RenderingData JLJFGIMLKEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x72D14D0", Offset = "0x72CFED0", VA = "0x1872D14D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72D2CC0", Offset = "0x72D16C0", VA = "0x1872D2CC0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x72D2C30", Offset = "0x72D1630", VA = "0x1872D2C30", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MGJKLBPNDCE, RenderingData JLJFGIMLKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x10246E0", Offset = "0x10230E0", VA = "0x1810246E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72D2F10", Offset = "0x72D1910", VA = "0x1872D2F10")]
		public static void FAKLGEBPOPG(ScriptableRenderPass ABIJLKBODDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x72D2D70", Offset = "0x72D1770", VA = "0x1872D2D70", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MGJKLBPNDCE, RenderingData JLJFGIMLKEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x10246E0", Offset = "0x10230E0", VA = "0x1810246E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x72D05A0", Offset = "0x72CEFA0", VA = "0x1872D05A0")]
	public static Mesh OFLEHPLALGM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x72CFD40", Offset = "0x72CE740", VA = "0x1872CFD40")]
	public static Matrix4x4 IGMGPHHPLPL(Camera FIJJFNJDPAF, bool ILAAIHCIEGG = false, bool LAKCCHFLBKE = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x72D01E0", Offset = "0x72CEBE0", VA = "0x1872D01E0")]
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
