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
	public class LogRegistrationIndex : NNAGAKKCAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7032820", Offset = "0x7031420", VA = "0x187032820", Slot = "4")]
		public override void NGMFPPEDCJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
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
		public enum DBFCIJAAOJL
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface CCBEGGOIOPC
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void INOEKLCMBOB(ScriptableRenderContext NGDLPEOFMHL, List<Camera> HNDIMAPPDGC);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface NCGOCAPFIDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void INOEKLCMBOB(ScriptableRenderContext NGDLPEOFMHL, RenderingData JBPLNNCNKCA);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class GEMMFLKMLCE : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7031A20", Offset = "0x7030620", VA = "0x187031A20")]
			public GEMMFLKMLCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x70319C0", Offset = "0x70305C0", VA = "0x1870319C0", Slot = "9")]
			public override void Execute(ScriptableRenderContext NGDLPEOFMHL, RenderingData JBPLNNCNKCA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private GEMMFLKMLCE _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<CCBEGGOIOPC> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<CCBEGGOIOPC> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<NCGOCAPFIDM> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<NCGOCAPFIDM> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7034660", Offset = "0x7033260", VA = "0x187034660")]
		public static void CCCOMPDPCCB(DBFCIJAAOJL EMDPMPHNJGH, CCBEGGOIOPC JIAOILJEKAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7035440", Offset = "0x7034040", VA = "0x187035440")]
		public static void ICFONOJHFGP(DBFCIJAAOJL EMDPMPHNJGH, CCBEGGOIOPC JIAOILJEKAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x70345A0", Offset = "0x70331A0", VA = "0x1870345A0")]
		public static void CCCOMPDPCCB(DBFCIJAAOJL EMDPMPHNJGH, NCGOCAPFIDM HELDALBDBEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7035500", Offset = "0x7034100", VA = "0x187035500")]
		public static void ICFONOJHFGP(DBFCIJAAOJL EMDPMPHNJGH, NCGOCAPFIDM HELDALBDBEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7034C80", Offset = "0x7033880", VA = "0x187034C80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x70344F0", Offset = "0x70330F0", VA = "0x1870344F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PFFACGHHFOH, RenderingData JBPLNNCNKCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7034E70", Offset = "0x7033A70", VA = "0x187034E70", Slot = "9")]
		protected override void Dispose(bool CDHHFLFIMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7034790", Offset = "0x7033390", VA = "0x187034790")]
		private static void COOGEIAOFKM(ScriptableRenderContext NGDLPEOFMHL, List<Camera> HNDIMAPPDGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7034720", Offset = "0x7033320", VA = "0x187034720")]
		private static void CFGENOJOHIM(ScriptableRenderContext NGDLPEOFMHL, List<Camera> HNDIMAPPDGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7034F80", Offset = "0x7033B80", VA = "0x187034F80")]
		private static void EHDLPPBAOBK(ScriptableRenderContext NGDLPEOFMHL, RenderingData JBPLNNCNKCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xDA8650", Offset = "0xDA7250", VA = "0x180DA8650")]
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
		private class KGBLIGHEDNJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool BHBKNBJNAEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<BKEKGLDAKNC> HKCPNDNJBCF;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7032000", Offset = "0x7030C00", VA = "0x187032000")]
			public KGBLIGHEDNJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class POIKIBMMJDH : PreRenderManager.NCGOCAPFIDM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string EODNLNIGHOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler HKHOJELABJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly KGBLIGHEDNJ NAPIJNANHCI;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7033FE0", Offset = "0x7032BE0", VA = "0x187033FE0")]
			public POIKIBMMJDH(KGBLIGHEDNJ JHGIEFNHKOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7033BE0", Offset = "0x70327E0", VA = "0x187033BE0", Slot = "4")]
			public void INOEKLCMBOB(ScriptableRenderContext NGDLPEOFMHL, RenderingData JBPLNNCNKCA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class LLOOFNDJGEG : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string DNEFPJPBBIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly KGBLIGHEDNJ JHGIEFNHKOP;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x70323A0", Offset = "0x7030FA0", VA = "0x1870323A0")]
			public LLOOFNDJGEG(RenderPassEvent PDAGNJOLBNA, KGBLIGHEDNJ JHGIEFNHKOP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7032090", Offset = "0x7030C90", VA = "0x187032090", Slot = "9")]
			public override void Execute(ScriptableRenderContext NGDLPEOFMHL, RenderingData JBPLNNCNKCA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<BKEKGLDAKNC> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private POIKIBMMJDH fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private LLOOFNDJGEG fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private KGBLIGHEDNJ sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7031430", Offset = "0x7030030", VA = "0x187031430", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x70317C0", Offset = "0x70303C0", VA = "0x1870317C0", Slot = "9")]
		protected override void Dispose(bool CDHHFLFIMKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7031390", Offset = "0x702FF90", VA = "0x187031390", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PFFACGHHFOH, RenderingData JBPLNNCNKCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xDA8650", Offset = "0xDA7250", VA = "0x180DA8650")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BKEKGLDAKNC
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LDLICOCOGIG(CommandBuffer CAEIICOJGHE, Camera BCNHCNDKBNI, [NotNull] UniversalAdditionalCameraData INDANCGHONH, bool BBPDEFLLLIL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGMHLGLGDDD(Camera BCNHCNDKBNI, CommandBuffer KMPADPFEHLB);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Fade")]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct IKPFHHLDFKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float AALKJGHENNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public float DCJCCMKIDOA;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private class GNHHGBJBIKH : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string CNAMOJKDGKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler INFPHFABCEI;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int EFEEPAEJNAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private Material IBCMCMPADII;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7031E20", Offset = "0x7030A20", VA = "0x187031E20")]
			public GNHHGBJBIKH(RenderPassEvent PDAGNJOLBNA, Material DMGEDCGOKIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7031A40", Offset = "0x7030640", VA = "0x187031A40", Slot = "9")]
			public override void Execute(ScriptableRenderContext NGDLPEOFMHL, RenderingData JBPLNNCNKCA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static IKPFHHLDFKA CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private GNHHGBJBIKH m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7032BC0", Offset = "0x70317C0", VA = "0x187032BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7032B70", Offset = "0x7031770", VA = "0x187032B70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x70329C0", Offset = "0x70315C0", VA = "0x1870329C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x70328F0", Offset = "0x70314F0", VA = "0x1870328F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PFFACGHHFOH, RenderingData JBPLNNCNKCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xDA8650", Offset = "0xDA7250", VA = "0x180DA8650")]
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
		public struct PCOCIELMIEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float GKNDMCDODHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Color OAPMNDMGDPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Mesh OADAABJJELK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AnimationCurve FMPOGPAIEBI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public sealed class LMJGFPDLOLI : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static readonly string CNAMOJKDGKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private ProfilingSampler INFPHFABCEI;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static readonly int AAPDKPMFJGA;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static readonly int EPDPOMPGPOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Material IBCMCMPADII;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7032740", Offset = "0x7031340", VA = "0x187032740")]
			public LMJGFPDLOLI(RenderPassEvent PDAGNJOLBNA, Material DMGEDCGOKIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7032480", Offset = "0x7031080", VA = "0x187032480", Slot = "9")]
			public override void Execute(ScriptableRenderContext NGDLPEOFMHL, RenderingData JBPLNNCNKCA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static PCOCIELMIEI CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private LMJGFPDLOLI m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7032EF0", Offset = "0x7031AF0", VA = "0x187032EF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7032D40", Offset = "0x7031940", VA = "0x187032D40", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7032C20", Offset = "0x7031820", VA = "0x187032C20", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PFFACGHHFOH, RenderingData JBPLNNCNKCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xDA8650", Offset = "0xDA7250", VA = "0x180DA8650")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string DKMPODEHMCC
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool LMCCPBCCPDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer KMPADPFEHLB, ScriptableRenderContext NGDLPEOFMHL, RenderingData JBPLNNCNKCA);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x866B10", Offset = "0x865710", VA = "0x180866B10")]
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
		private class OKMGMLOELKG : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private bool HBDAACEJIPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private readonly List<PerCameraRenderEffect> BDIHFKGGDPH;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private static readonly List<PerCameraRenderEffect> EJJEBBLBPEE;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7033580", Offset = "0x7032180", VA = "0x187033580")]
			public OKMGMLOELKG(RenderPassEvent PDAGNJOLBNA, bool HBDAACEJIPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7032F50", Offset = "0x7031B50", VA = "0x187032F50")]
			public bool BIAKPBOEPKJ(CameraData INDANCGHONH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7033320", Offset = "0x7031F20", VA = "0x187033320", Slot = "9")]
			public override void Execute(ScriptableRenderContext NGDLPEOFMHL, RenderingData JBPLNNCNKCA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7033240", Offset = "0x7031E40", VA = "0x187033240")]
			private void EPIKJBHPEAC(PerCameraRenderEffect DJAHDNHANFK, ScriptableRenderContext NGDLPEOFMHL, RenderingData JBPLNNCNKCA)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private OKMGMLOELKG m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private OKMGMLOELKG m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7034130", Offset = "0x7032D30", VA = "0x187034130", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x70340A0", Offset = "0x7032CA0", VA = "0x1870340A0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PFFACGHHFOH, RenderingData JBPLNNCNKCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xDA8650", Offset = "0xDA7250", VA = "0x180DA8650")]
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
		[Cpp2IlInjected.Address(RVA = "0x7034380", Offset = "0x7032F80", VA = "0x187034380")]
		public static void GCPPPGIPLAN(ScriptableRenderPass FAIDKKLKABH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x70341E0", Offset = "0x7032DE0", VA = "0x1870341E0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PFFACGHHFOH, RenderingData JBPLNNCNKCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xDA8650", Offset = "0xDA7250", VA = "0x180DA8650")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JMJJELOGPGA
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly EEGEMFOKJOP HNHKHNNAOOD;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly EEGEMFOKJOP DKEECGFKNCM;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly EEGEMFOKJOP DNEDCGADJMC;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly EEGEMFOKJOP ONCHBLAGECL;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface KAAGOOPGGLO
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGGJNKKHKPJ();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PNPHKFBKOMC : KAAGOOPGGLO
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly EEGEMFOKJOP IGMINGONOGN;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly string LHKPENIFLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private HFDCGAIKGJC KEMDPLCMBBG;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
	[UnityEngine.Scripting.Preserve]
	public PNPHKFBKOMC([POJODGKFIMO(null)][NotNull] HFDCGAIKGJC FMEPHEIENDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7033810", Offset = "0x7032410", VA = "0x187033810")]
	[UsedImplicitly]
	[DHOHFCLMOGD(OBGPNJNCONH.Session, IDHBAGABJJA.GameOnly)]
	public static void NIHDPIJHFGJ(IMEOEBHKJNP MLGAMJFBMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7033630", Offset = "0x7032230", VA = "0x187033630", Slot = "4")]
	public void BGGJNKKHKPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7033900", Offset = "0x7032500", VA = "0x187033900")]
	private void POMFAHGAMBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7033730", Offset = "0x7032330", VA = "0x187033730")]
	private bool EPNCCHFKMEM(string BDEPMPHNKOC, [Out] JNMLILBKHMB DEKGOIMOOIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class CLINPCPGLPC
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static Mesh IDDFIHPAKHF;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x70312E0", Offset = "0x702FEE0", VA = "0x1870312E0")]
	public static Mesh MFBOMNFCNFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7030A80", Offset = "0x702F680", VA = "0x187030A80")]
	public static Matrix4x4 AFBIPLDODJG(Camera BCNHCNDKBNI, bool JBNLPPFJICF = false, bool OPNOEKLMCGI = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7030F20", Offset = "0x702FB20", VA = "0x187030F20")]
	private static Mesh JIOPLGDHLKE()
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
