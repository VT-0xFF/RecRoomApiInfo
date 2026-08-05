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
	public class LogRegistrationIndex : IFEEDCBNDCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6EA15D0", Offset = "0x6E9FDD0", VA = "0x186EA15D0", Slot = "4")]
		public override void MPPLGFJBDHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
		public enum KBAEPELNJLP
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface EBKCJLKFBEP
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void HHNAPLDDAPJ(ScriptableRenderContext BHFMOMNKABO, List<Camera> JBKLGDLFDKO);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface IFPFCJGBCBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void HHNAPLDDAPJ(ScriptableRenderContext BHFMOMNKABO, RenderingData KNNGGMJCLOH);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class OKDFAMAAPHM : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6EA1DC0", Offset = "0x6EA05C0", VA = "0x186EA1DC0")]
			public OKDFAMAAPHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6EA1D60", Offset = "0x6EA0560", VA = "0x186EA1D60", Slot = "9")]
			public override void Execute(ScriptableRenderContext BHFMOMNKABO, RenderingData KNNGGMJCLOH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private OKDFAMAAPHM _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<EBKCJLKFBEP> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<EBKCJLKFBEP> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<IFPFCJGBCBC> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<IFPFCJGBCBC> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6EA2CA0", Offset = "0x6EA14A0", VA = "0x186EA2CA0")]
		public static void HAFOIKENAEP(KBAEPELNJLP GIJBPOIMHGE, EBKCJLKFBEP PHPPGCBCMMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3250", Offset = "0x6EA1A50", VA = "0x186EA3250")]
		public static void OALALFNNBFG(KBAEPELNJLP GIJBPOIMHGE, EBKCJLKFBEP PHPPGCBCMMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6EA2BE0", Offset = "0x6EA13E0", VA = "0x186EA2BE0")]
		public static void HAFOIKENAEP(KBAEPELNJLP GIJBPOIMHGE, IFPFCJGBCBC MACHCHGKCFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6EA3310", Offset = "0x6EA1B10", VA = "0x186EA3310")]
		public static void OALALFNNBFG(KBAEPELNJLP GIJBPOIMHGE, IFPFCJGBCBC MACHCHGKCFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6EA2430", Offset = "0x6EA0C30", VA = "0x186EA2430", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6EA2320", Offset = "0x6EA0B20", VA = "0x186EA2320", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GEPBJGBCLCL, RenderingData KNNGGMJCLOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6EA2610", Offset = "0x6EA0E10", VA = "0x186EA2610", Slot = "9")]
		protected override void Dispose(bool AFJGPADFFNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6EA2D60", Offset = "0x6EA1560", VA = "0x186EA2D60")]
		private static void KLKINJIHILK(ScriptableRenderContext BHFMOMNKABO, List<Camera> JBKLGDLFDKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6EA23C0", Offset = "0x6EA0BC0", VA = "0x186EA23C0")]
		private static void CBIMJBEIEPA(ScriptableRenderContext BHFMOMNKABO, List<Camera> JBKLGDLFDKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6EA2720", Offset = "0x6EA0F20", VA = "0x186EA2720")]
		private static void GNEACJHCDBK(ScriptableRenderContext BHFMOMNKABO, RenderingData KNNGGMJCLOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD63B30", Offset = "0xD62330", VA = "0x180D63B30")]
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
		private class MGBHNHCKPDI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool IKKICCBMDPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<NLKMBLKKPBC> KKBMBKLNFFB;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6EA16A0", Offset = "0x6E9FEA0", VA = "0x186EA16A0")]
			public MGBHNHCKPDI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class KLJNAGDKOLG : PreRenderManager.IFPFCJGBCBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string HLNAMIIMDKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler COADNBOLAOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly MGBHNHCKPDI OFNGOHENHEM;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6EA0C10", Offset = "0x6E9F410", VA = "0x186EA0C10")]
			public KLJNAGDKOLG(MGBHNHCKPDI NGGHJDILIBG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6EA0810", Offset = "0x6E9F010", VA = "0x186EA0810", Slot = "4")]
			public void HHNAPLDDAPJ(ScriptableRenderContext BHFMOMNKABO, RenderingData KNNGGMJCLOH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class ENOOOAGDHED : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string EJCFOCILBBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly MGBHNHCKPDI NGGHJDILIBG;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6E9F230", Offset = "0x6E9DA30", VA = "0x186E9F230")]
			public ENOOOAGDHED(RenderPassEvent KIHHPPMFIBK, MGBHNHCKPDI NGGHJDILIBG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6E9EF20", Offset = "0x6E9D720", VA = "0x186E9EF20", Slot = "9")]
			public override void Execute(ScriptableRenderContext BHFMOMNKABO, RenderingData KNNGGMJCLOH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<NLKMBLKKPBC> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private KLJNAGDKOLG fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private ENOOOAGDHED fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MGBHNHCKPDI sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6E9FA70", Offset = "0x6E9E270", VA = "0x186E9FA70", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6E9FDF0", Offset = "0x6E9E5F0", VA = "0x186E9FDF0", Slot = "9")]
		protected override void Dispose(bool AFJGPADFFNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6E9F9E0", Offset = "0x6E9E1E0", VA = "0x186E9F9E0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GEPBJGBCLCL, RenderingData KNNGGMJCLOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD63B30", Offset = "0xD62330", VA = "0x180D63B30")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NLKMBLKKPBC
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PFGNLIGLAMN(CommandBuffer MIMNKEEIAHA, Camera PPBNJJDFPOP, [NotNull] UniversalAdditionalCameraData BPDHFPBKNCJ, bool IEMELFBPEOJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIPALEJGGEG(Camera PPBNJJDFPOP, CommandBuffer JIBAPNLHFNG);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Fade")]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct COPMMGJFEIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float MNBIDEJICDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public float MCGBDKLBENB;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private class GLLDMIJOMKN : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string MCGDFNPDGOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler HEILFIAPEFL;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int DPCHGNCNDMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private Material HCJPBCCAJNK;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6EA03B0", Offset = "0x6E9EBB0", VA = "0x186EA03B0")]
			public GLLDMIJOMKN(RenderPassEvent KIHHPPMFIBK, Material CLECAFFDEAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6E9FFE0", Offset = "0x6E9E7E0", VA = "0x186E9FFE0", Slot = "9")]
			public override void Execute(ScriptableRenderContext BHFMOMNKABO, RenderingData KNNGGMJCLOH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static COPMMGJFEIM CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private GLLDMIJOMKN m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x6EA1A00", Offset = "0x6EA0200", VA = "0x186EA1A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6EA19B0", Offset = "0x6EA01B0", VA = "0x186EA19B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6EA1800", Offset = "0x6EA0000", VA = "0x186EA1800", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6EA1730", Offset = "0x6E9FF30", VA = "0x186EA1730", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GEPBJGBCLCL, RenderingData KNNGGMJCLOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xD63B30", Offset = "0xD62330", VA = "0x180D63B30")]
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
		public struct OAPGBBDKEGC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float IPAEOHOLNFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Color HGCEGIGMOJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Mesh IMOFKINBGPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AnimationCurve OHGJNPJOKHO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public sealed class HKCKAFOODID : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static readonly string MCGDFNPDGOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private ProfilingSampler HEILFIAPEFL;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static readonly int MOHFAGPIAHO;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static readonly int CKIILNFJMMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Material HCJPBCCAJNK;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6EA0730", Offset = "0x6E9EF30", VA = "0x186EA0730")]
			public HKCKAFOODID(RenderPassEvent KIHHPPMFIBK, Material CLECAFFDEAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6EA0490", Offset = "0x6E9EC90", VA = "0x186EA0490", Slot = "9")]
			public override void Execute(ScriptableRenderContext BHFMOMNKABO, RenderingData KNNGGMJCLOH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static OAPGBBDKEGC CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private HKCKAFOODID m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x6EA1D10", Offset = "0x6EA0510", VA = "0x186EA1D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6EA1B60", Offset = "0x6EA0360", VA = "0x186EA1B60", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6EA1A50", Offset = "0x6EA0250", VA = "0x186EA1A50", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GEPBJGBCLCL, RenderingData KNNGGMJCLOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xD63B30", Offset = "0xD62330", VA = "0x180D63B30")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string IJDAIFPGLKO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool JMPDANOKDBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer JIBAPNLHFNG, ScriptableRenderContext BHFMOMNKABO, RenderingData KNNGGMJCLOH);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x843520", Offset = "0x841D20", VA = "0x180843520")]
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
		private class FBDMDLMMLAC : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private bool NHFMADGKLJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private readonly List<PerCameraRenderEffect> GKAMPFPDEPO;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private static readonly List<PerCameraRenderEffect> ODEFDCGNGFK;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6E9F930", Offset = "0x6E9E130", VA = "0x186E9F930")]
			public FBDMDLMMLAC(RenderPassEvent KIHHPPMFIBK, bool NHFMADGKLJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6E9F310", Offset = "0x6E9DB10", VA = "0x186E9F310")]
			public bool CEOJGNHEJMD(CameraData BPDHFPBKNCJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6E9F5F0", Offset = "0x6E9DDF0", VA = "0x186E9F5F0", Slot = "9")]
			public override void Execute(ScriptableRenderContext BHFMOMNKABO, RenderingData KNNGGMJCLOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6E9F7C0", Offset = "0x6E9DFC0", VA = "0x186E9F7C0")]
			private void IKAPECAFDKD(PerCameraRenderEffect AKFHNFNPJKP, ScriptableRenderContext BHFMOMNKABO, RenderingData KNNGGMJCLOH)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private FBDMDLMMLAC m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private FBDMDLMMLAC m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6EA1F60", Offset = "0x6EA0760", VA = "0x186EA1F60", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6EA1ED0", Offset = "0x6EA06D0", VA = "0x186EA1ED0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GEPBJGBCLCL, RenderingData KNNGGMJCLOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xD63B30", Offset = "0xD62330", VA = "0x180D63B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EA21B0", Offset = "0x6EA09B0", VA = "0x186EA21B0")]
		public static void NBLCGDCHBHO(ScriptableRenderPass NFGGEEFGPJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6EA2010", Offset = "0x6EA0810", VA = "0x186EA2010", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GEPBJGBCLCL, RenderingData KNNGGMJCLOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xD63B30", Offset = "0xD62330", VA = "0x180D63B30")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class PMMIBLBKENC
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly MMJHHDEPGMK LEKABEOFGEG;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly MMJHHDEPGMK EOBEODALJGF;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly MMJHHDEPGMK CFPPIICENEA;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly MMJHHDEPGMK NJICKOGAIIB;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LLPPBGGLCEE
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BEPINKFLCOJ();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AKBMAEEHFCP : LLPPBGGLCEE
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly string IANNPCGNJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private CKECBDNFIAF FAFMCGHLBDI;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8468E0", Offset = "0x8450E0", VA = "0x1808468E0")]
	[UnityEngine.Scripting.Preserve]
	public AKBMAEEHFCP([GNKLNMHODGG(null)][NotNull] CKECBDNFIAF CIMEDMLCKMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E9ED60", Offset = "0x6E9D560", VA = "0x186E9ED60")]
	[UsedImplicitly]
	[ANLGLDAOJJE(KKPEBAHBECP.Session, ELBANFBEGNE.GameOnly)]
	public static void HELFCPMGOFL(AANDDJDEEFL KDCLBHAMNHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6E9EA50", Offset = "0x6E9D250", VA = "0x186E9EA50", Slot = "4")]
	public void BEPINKFLCOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E9EB50", Offset = "0x6E9D350", VA = "0x186E9EB50")]
	private void FILIJKHKNHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6E9E970", Offset = "0x6E9D170", VA = "0x186E9E970")]
	private bool ANJILGCOFKP(string DHPBDNPMBKK, [Out] FJGKCCGDGOG DLMIGLAMCAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class LBJBHPIOGKG
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static Mesh BHOKOCJNFEL;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1090", Offset = "0x6E9F890", VA = "0x186EA1090")]
	public static Mesh MKLDCFJDIBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6EA1130", Offset = "0x6E9F930", VA = "0x186EA1130")]
	public static Matrix4x4 PLENGJFMDHJ(Camera PPBNJJDFPOP, bool IIDGPLNIDAH = false, bool EMMBNGNJMBH = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6EA0CD0", Offset = "0x6E9F4D0", VA = "0x186EA0CD0")]
	private static Mesh GGOKLPBEOOM()
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
