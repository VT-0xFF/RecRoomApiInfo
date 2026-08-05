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
	[Tooltip("RR Fast Lines")]
	public class FastLinesRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class LBCENGIHNBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public bool MHNBNFJPKPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly List<ACLLPOJOIFK> LFHJMAGLEGP;

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x66605A0", Offset = "0x665F3A0", VA = "0x1866605A0")]
			public LBCENGIHNBA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class PNMGBGGMBHE : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly string POKMHBJCHHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly LBCENGIHNBA OIJBJHLJPDE;

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x66610A0", Offset = "0x665FEA0", VA = "0x1866610A0")]
			public PNMGBGGMBHE(RenderPassEvent HNKPANGOBIC, LBCENGIHNBA OIJBJHLJPDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6660C90", Offset = "0x665FA90", VA = "0x186660C90", Slot = "9")]
			public override void Execute(ScriptableRenderContext KMABAKEMFMI, RenderingData KNAJILBBHIN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class ENDMGGDFGNB : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private readonly string POKMHBJCHHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private readonly LBCENGIHNBA OIJBJHLJPDE;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x665EBD0", Offset = "0x665D9D0", VA = "0x18665EBD0")]
			public ENDMGGDFGNB(RenderPassEvent HNKPANGOBIC, LBCENGIHNBA OIJBJHLJPDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x665E8C0", Offset = "0x665D6C0", VA = "0x18665E8C0", Slot = "9")]
			public override void Execute(ScriptableRenderContext KMABAKEMFMI, RenderingData KNAJILBBHIN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static List<ACLLPOJOIFK> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private PNMGBGGMBHE fastLinesUpdatePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ENDMGGDFGNB fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private LBCENGIHNBA sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x665F210", Offset = "0x665E010", VA = "0x18665F210", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x665F170", Offset = "0x665DF70", VA = "0x18665F170", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FNMHNENOEME, RenderingData KNAJILBBHIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xBE9040", Offset = "0xBE7E40", VA = "0x180BE9040")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ACLLPOJOIFK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JMONEOJHFNC(CommandBuffer AOCMEHLEFMH, Camera JMAPMJOABDH, [NotNull] UniversalAdditionalCameraData CPDPHLKGIHD, bool BFEFKFHGLEM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFGIHDDCHHG(Camera JMAPMJOABDH, CommandBuffer BHOCKOPMBEI);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Tooltip("RR Mobile Fade")]
	[DisallowMultipleRendererFeature(null)]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct JLAAMNNMOFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public float BMLGLCAMCOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public float MJHOIEFBHME;
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class ENMJIGPPBJF : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private static readonly string BHJGLHPEAEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ProfilingSampler GKLKHCJHKFO;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private static readonly int AFADLGALAKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private Material MHHJOKAPNJC;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x665F090", Offset = "0x665DE90", VA = "0x18665F090")]
			public ENMJIGPPBJF(RenderPassEvent HNKPANGOBIC, Material NLKDDMHEDOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x665ECB0", Offset = "0x665DAB0", VA = "0x18665ECB0", Slot = "9")]
			public override void Execute(ScriptableRenderContext KMABAKEMFMI, RenderingData KNAJILBBHIN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static JLAAMNNMOFH CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private ENMJIGPPBJF m_MobileFadePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[Reload("Shaders/MobileFade.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6660900", Offset = "0x665F700", VA = "0x186660900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x66608B0", Offset = "0x665F6B0", VA = "0x1866608B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6660700", Offset = "0x665F500", VA = "0x186660700", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6660630", Offset = "0x665F430", VA = "0x186660630", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FNMHNENOEME, RenderingData KNAJILBBHIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xBE9040", Offset = "0xBE7E40", VA = "0x180BE9040")]
		public MobileFadeRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Vignette")]
	public class MobileVignetteRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public struct DODCFKACBHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public float NKFPFJLJFGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Color HDCGMENJMBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Mesh GOKAPJPMAID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AnimationCurve CLMKLGNBNAG;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public sealed class DFMCOIPOECH : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string BHJGLHPEAEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler GKLKHCJHKFO;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int BKABOLNOEID;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly int HOBPBDFDLPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private Material MHHJOKAPNJC;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x665E7E0", Offset = "0x665D5E0", VA = "0x18665E7E0")]
			public DFMCOIPOECH(RenderPassEvent HNKPANGOBIC, Material NLKDDMHEDOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x665E520", Offset = "0x665D320", VA = "0x18665E520", Slot = "9")]
			public override void Execute(ScriptableRenderContext KMABAKEMFMI, RenderingData KNAJILBBHIN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static DODCFKACBHJ CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private DFMCOIPOECH m_MobileVignettePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[Reload("Shaders/MobileVignette.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6660C30", Offset = "0x665FA30", VA = "0x186660C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6660A80", Offset = "0x665F880", VA = "0x186660A80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6660960", Offset = "0x665F760", VA = "0x186660960", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FNMHNENOEME, RenderingData KNAJILBBHIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xBE9040", Offset = "0xBE7E40", VA = "0x180BE9040")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string JNFHHIBNFHF
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool HJKJOHCPDCG
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x801AA0", Offset = "0x8008A0", VA = "0x180801AA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer BHOCKOPMBEI, ScriptableRenderContext KMABAKEMFMI, RenderingData KNAJILBBHIN);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
		protected PerCameraRenderEffect()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Per-Camera Render Effects")]
	public class PerCameraRenderEffectsRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private class JMOGKONDMJB : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private bool NINAANLCCFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly List<PerCameraRenderEffect> LKCNPIAECGL;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly List<PerCameraRenderEffect> IOHFJNADGMK;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x66604F0", Offset = "0x665F2F0", VA = "0x1866604F0")]
			public JMOGKONDMJB(RenderPassEvent HNKPANGOBIC, bool NINAANLCCFE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6660170", Offset = "0x665EF70", VA = "0x186660170")]
			public bool PBMDDEKLOGF(CameraData CPDPHLKGIHD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x665FFA0", Offset = "0x665EDA0", VA = "0x18665FFA0", Slot = "9")]
			public override void Execute(ScriptableRenderContext KMABAKEMFMI, RenderingData KNAJILBBHIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x665FEC0", Offset = "0x665ECC0", VA = "0x18665FEC0")]
			private void BOEODHHDKLD(PerCameraRenderEffect CEMKPBPMGFA, ScriptableRenderContext KMABAKEMFMI, RenderingData KNAJILBBHIN)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private JMOGKONDMJB m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private JMOGKONDMJB m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6661210", Offset = "0x6660010", VA = "0x186661210", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6661180", Offset = "0x665FF80", VA = "0x186661180", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FNMHNENOEME, RenderingData KNAJILBBHIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xBE9040", Offset = "0xBE7E40", VA = "0x180BE9040")]
		public PerCameraRenderEffectsRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Persistent Buffer Effects")]
	public class PersistentBufferEffectsRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static readonly List<ScriptableRenderPass> passes;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const RenderPassEvent RENDER_PASS_EVENT = RenderPassEvent.BeforeRenderingShadows;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6661460", Offset = "0x6660260", VA = "0x186661460")]
		public static void NCMLDDEOAOI(ScriptableRenderPass ACPGBIAGHHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x66612C0", Offset = "0x66600C0", VA = "0x1866612C0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FNMHNENOEME, RenderingData KNAJILBBHIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xBE9040", Offset = "0xBE7E40", VA = "0x180BE9040")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class IFNLLDHBBGG
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Mesh MHAHOOGIHJN;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x665F5B0", Offset = "0x665E3B0", VA = "0x18665F5B0")]
	public static Mesh DNJIFKCIEOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x665FA20", Offset = "0x665E820", VA = "0x18665FA20")]
	public static Matrix4x4 KPFFPMGJJGF(Camera JMAPMJOABDH, bool CIHLGOECCKM = false, bool AAOFCFPFGHO = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x665F660", Offset = "0x665E460", VA = "0x18665F660")]
	private static Mesh EGIGKMEKNGM()
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
