using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR PreRender Manager")]
	public class PreRenderManager : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public enum FPDIGMDIGBA
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public interface APGMONCCHMK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void DMDKHAOOBDK(ScriptableRenderContext EOIJJPCMNGA, List<Camera> GBNALNEOFGL);
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface LELNDCPHPHI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void DMDKHAOOBDK(ScriptableRenderContext EOIJJPCMNGA, RenderingData ILAACNNKCPP);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class HBLCEHGHNHH : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x69F2110", Offset = "0x69F1310", VA = "0x1869F2110")]
			public HBLCEHGHNHH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x69F20B0", Offset = "0x69F12B0", VA = "0x1869F20B0", Slot = "9")]
			public override void Execute(ScriptableRenderContext EOIJJPCMNGA, RenderingData ILAACNNKCPP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private HBLCEHGHNHH _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<APGMONCCHMK> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<APGMONCCHMK> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<LELNDCPHPHI> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<LELNDCPHPHI> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x69F4A20", Offset = "0x69F3C20", VA = "0x1869F4A20")]
		public static void FNDBHCEGJNA(FPDIGMDIGBA HLEBDJMFEMP, APGMONCCHMK HJFCFDFLPNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x69F40C0", Offset = "0x69F32C0", VA = "0x1869F40C0")]
		public static void AOBPAFOPKGM(FPDIGMDIGBA HLEBDJMFEMP, APGMONCCHMK HJFCFDFLPNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69F4AE0", Offset = "0x69F3CE0", VA = "0x1869F4AE0")]
		public static void FNDBHCEGJNA(FPDIGMDIGBA HLEBDJMFEMP, LELNDCPHPHI DLDECMBMELP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69F4000", Offset = "0x69F3200", VA = "0x1869F4000")]
		public static void AOBPAFOPKGM(FPDIGMDIGBA HLEBDJMFEMP, LELNDCPHPHI DLDECMBMELP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x69F4230", Offset = "0x69F3430", VA = "0x1869F4230", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x69F4180", Offset = "0x69F3380", VA = "0x1869F4180", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MNDOIBEKKNI, RenderingData ILAACNNKCPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x69F4420", Offset = "0x69F3620", VA = "0x1869F4420", Slot = "9")]
		protected override void Dispose(bool IJDACILMIGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69F4530", Offset = "0x69F3730", VA = "0x1869F4530")]
		private static void FAJFIGOJNDK(ScriptableRenderContext EOIJJPCMNGA, List<Camera> GBNALNEOFGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69F4BA0", Offset = "0x69F3DA0", VA = "0x1869F4BA0")]
		private static void JNENFNNABJP(ScriptableRenderContext EOIJJPCMNGA, List<Camera> GBNALNEOFGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x69F4C10", Offset = "0x69F3E10", VA = "0x1869F4C10")]
		private static void LCCNOOICBGC(ScriptableRenderContext EOIJJPCMNGA, RenderingData ILAACNNKCPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCEE250", Offset = "0xCED450", VA = "0x180CEE250")]
		public PreRenderManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Fast Lines")]
	public class FastLinesRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private class PHHOONGNDBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool CGPILEHJHFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<AGCMJNNNCCB> IAIILJAMFLA;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x69F3AC0", Offset = "0x69F2CC0", VA = "0x1869F3AC0")]
			public PHHOONGNDBD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class LIGOPFADOCK : PreRenderManager.LELNDCPHPHI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string HJDOKDIJEEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler DMFHCGLOFOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly PHHOONGNDBD MPFNCILFJMF;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x69F2920", Offset = "0x69F1B20", VA = "0x1869F2920")]
			public LIGOPFADOCK(PHHOONGNDBD JFDBALNDIPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x69F2520", Offset = "0x69F1720", VA = "0x1869F2520", Slot = "4")]
			public void DMDKHAOOBDK(ScriptableRenderContext EOIJJPCMNGA, RenderingData ILAACNNKCPP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class JCONJANCJBO : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string CPGEDNDBINE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly PHHOONGNDBD JFDBALNDIPO;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x69F2440", Offset = "0x69F1640", VA = "0x1869F2440")]
			public JCONJANCJBO(RenderPassEvent KJHKIAEMFEF, PHHOONGNDBD JFDBALNDIPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x69F2130", Offset = "0x69F1330", VA = "0x1869F2130", Slot = "9")]
			public override void Execute(ScriptableRenderContext EOIJJPCMNGA, RenderingData ILAACNNKCPP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<AGCMJNNNCCB> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private LIGOPFADOCK fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private JCONJANCJBO fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private PHHOONGNDBD sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x69F1210", Offset = "0x69F0410", VA = "0x1869F1210", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x69F15A0", Offset = "0x69F07A0", VA = "0x1869F15A0", Slot = "9")]
		protected override void Dispose(bool IJDACILMIGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x69F1170", Offset = "0x69F0370", VA = "0x1869F1170", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MNDOIBEKKNI, RenderingData ILAACNNKCPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xCEE250", Offset = "0xCED450", VA = "0x180CEE250")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AGCMJNNNCCB
{
	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IKHPOGOMFAM(CommandBuffer IEOCJPOBJMD, Camera HGPFGHPKMII, [NotNull] UniversalAdditionalCameraData NOGFDJHOJEF, bool DJGAGPDAEML);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LEHHLFCMBFD(Camera HGPFGHPKMII, CommandBuffer DHAMGOCKPFO);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Tooltip("RR Mobile Fade")]
	[DisallowMultipleRendererFeature(null)]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct PBFPCLAIDPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float LBGHOEOIBMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public float PEACAIIOPFF;
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		private class CNCMOKNGDKO : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string BCHFMCHKGMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler NEIBLOLFAEL;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int CILLMFJADHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private Material PJJMPCCJKCB;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x69F1090", Offset = "0x69F0290", VA = "0x1869F1090")]
			public CNCMOKNGDKO(RenderPassEvent KJHKIAEMFEF, Material OOHAKCENEJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x69F0CB0", Offset = "0x69EFEB0", VA = "0x1869F0CB0", Slot = "9")]
			public override void Execute(ScriptableRenderContext EOIJJPCMNGA, RenderingData ILAACNNKCPP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static PBFPCLAIDPB CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private CNCMOKNGDKO m_MobileFadePass;

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
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x69F2CB0", Offset = "0x69F1EB0", VA = "0x1869F2CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x69F2C60", Offset = "0x69F1E60", VA = "0x1869F2C60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x69F2AB0", Offset = "0x69F1CB0", VA = "0x1869F2AB0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x69F29E0", Offset = "0x69F1BE0", VA = "0x1869F29E0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MNDOIBEKKNI, RenderingData ILAACNNKCPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xCEE250", Offset = "0xCED450", VA = "0x180CEE250")]
		public MobileFadeRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Vignette")]
	public class MobileVignetteRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public struct ODMEENAJNFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float MIBONHNNPGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Color ADNBOBHNILM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Mesh BLFMBPDJACI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AnimationCurve KDJCLPAAJHH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public sealed class NAKBPEMAEEK : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static readonly string BCHFMCHKGMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private ProfilingSampler NEIBLOLFAEL;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static readonly int EPENIAFHGFI;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static readonly int JJEKDMEOAML;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Material PJJMPCCJKCB;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x69F3300", Offset = "0x69F2500", VA = "0x1869F3300")]
			public NAKBPEMAEEK(RenderPassEvent KJHKIAEMFEF, Material OOHAKCENEJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x69F3040", Offset = "0x69F2240", VA = "0x1869F3040", Slot = "9")]
			public override void Execute(ScriptableRenderContext EOIJJPCMNGA, RenderingData ILAACNNKCPP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static ODMEENAJNFB CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NAKBPEMAEEK m_MobileVignettePass;

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
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x69F2FE0", Offset = "0x69F21E0", VA = "0x1869F2FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x69F2E30", Offset = "0x69F2030", VA = "0x1869F2E30", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69F2D10", Offset = "0x69F1F10", VA = "0x1869F2D10", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MNDOIBEKKNI, RenderingData ILAACNNKCPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xCEE250", Offset = "0xCED450", VA = "0x180CEE250")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string BJGHNEJPDIK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool AJPBIANBEDA
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer DHAMGOCKPFO, ScriptableRenderContext EOIJJPCMNGA, RenderingData ILAACNNKCPP);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DE0", Offset = "0x7C8FE0", VA = "0x1807C9DE0")]
		protected PerCameraRenderEffect()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Per-Camera Render Effects")]
	public class PerCameraRenderEffectsRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private class NAPBAABNPGA : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private bool JAHEPFNHLAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private readonly List<PerCameraRenderEffect> KHJKNLNHHEH;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private static readonly List<PerCameraRenderEffect> LEIMGBJPNDP;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x69F3A10", Offset = "0x69F2C10", VA = "0x1869F3A10")]
			public NAPBAABNPGA(RenderPassEvent KJHKIAEMFEF, bool JAHEPFNHLAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x69F35B0", Offset = "0x69F27B0", VA = "0x1869F35B0")]
			public bool LNLOLDGKLJC(CameraData NOGFDJHOJEF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x69F33E0", Offset = "0x69F25E0", VA = "0x1869F33E0", Slot = "9")]
			public override void Execute(ScriptableRenderContext EOIJJPCMNGA, RenderingData ILAACNNKCPP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x69F38A0", Offset = "0x69F2AA0", VA = "0x1869F38A0")]
			private void NBAGOOHHKMM(PerCameraRenderEffect CNLEJOLJLJA, ScriptableRenderContext EOIJJPCMNGA, RenderingData ILAACNNKCPP)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private NAPBAABNPGA m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NAPBAABNPGA m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x69F3BE0", Offset = "0x69F2DE0", VA = "0x1869F3BE0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x69F3B50", Offset = "0x69F2D50", VA = "0x1869F3B50", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MNDOIBEKKNI, RenderingData ILAACNNKCPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xCEE250", Offset = "0xCED450", VA = "0x180CEE250")]
		public PerCameraRenderEffectsRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Persistent Buffer Effects")]
	public class PersistentBufferEffectsRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly List<ScriptableRenderPass> passes;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const RenderPassEvent RENDER_PASS_EVENT = RenderPassEvent.BeforeRenderingShadows;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x69F3E30", Offset = "0x69F3030", VA = "0x1869F3E30")]
		public static void IPFNFOOFHMD(ScriptableRenderPass KJAJPGPIBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x69F3C90", Offset = "0x69F2E90", VA = "0x1869F3C90", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MNDOIBEKKNI, RenderingData ILAACNNKCPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xCEE250", Offset = "0xCED450", VA = "0x180CEE250")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class GJNDKODMGBP
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Mesh NBFHGCJPEAI;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x69F2000", Offset = "0x69F1200", VA = "0x1869F2000")]
	public static Mesh JGIOKIHHOBF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69F17A0", Offset = "0x69F09A0", VA = "0x1869F17A0")]
	public static Matrix4x4 BNDFHKFJPKI(Camera HGPFGHPKMII, bool AIJOJIJIKJA = false, bool LEJKBAFPPLF = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x69F1C40", Offset = "0x69F0E40", VA = "0x1869F1C40")]
	private static Mesh IBOMNGKMFOH()
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
