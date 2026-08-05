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
		private class MNLDPBMJNKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public bool IPPGNKJHKJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly List<MLKFCDNHGHI> PIABANOIKEL;

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x659E080", Offset = "0x659CE80", VA = "0x18659E080")]
			public MNLDPBMJNKL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class NIOJINANCMJ : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly string DKKMCNAFEMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly MNLDPBMJNKL EMEIGPNMMDI;

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x659EB80", Offset = "0x659D980", VA = "0x18659EB80")]
			public NIOJINANCMJ(RenderPassEvent KLJFPJBIHOO, MNLDPBMJNKL EMEIGPNMMDI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x659E770", Offset = "0x659D570", VA = "0x18659E770", Slot = "9")]
			public override void Execute(ScriptableRenderContext BCCEHJNGNAL, RenderingData KIBLGGPMKAO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class AFAHAKNKCBO : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private readonly string DKKMCNAFEMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private readonly MNLDPBMJNKL EMEIGPNMMDI;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x659D300", Offset = "0x659C100", VA = "0x18659D300")]
			public AFAHAKNKCBO(RenderPassEvent KLJFPJBIHOO, MNLDPBMJNKL EMEIGPNMMDI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x659CFF0", Offset = "0x659BDF0", VA = "0x18659CFF0", Slot = "9")]
			public override void Execute(ScriptableRenderContext BCCEHJNGNAL, RenderingData KIBLGGPMKAO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static List<MLKFCDNHGHI> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private NIOJINANCMJ fastLinesUpdatePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private AFAHAKNKCBO fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private MNLDPBMJNKL sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x659DCE0", Offset = "0x659CAE0", VA = "0x18659DCE0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x659DC40", Offset = "0x659CA40", VA = "0x18659DC40", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer BCGNNFCJICK, RenderingData KIBLGGPMKAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB7F120", Offset = "0xB7DF20", VA = "0x180B7F120")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MLKFCDNHGHI
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AKJNBMDNLOF(CommandBuffer NKMCFPCPIIM, Camera MOKJAFMIBBJ, [NotNull] UniversalAdditionalCameraData JJJAMCPDFPG, bool AGCJPLCBIAM);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHEOJPOMKGJ(Camera MOKJAFMIBBJ, CommandBuffer BECIKFDBLCP);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Tooltip("RR Mobile Fade")]
	[DisallowMultipleRendererFeature(null)]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct HDMHFAEIJBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public float FPOKIKFGDGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public float DDLIMHIPOLE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class EFBJIEBPEIM : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private static readonly string JLNCEFIILNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ProfilingSampler CJGGNAJBCPE;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private static readonly int ICKEBHKEEMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private Material MFGMPDDFNLP;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x659DB60", Offset = "0x659C960", VA = "0x18659DB60")]
			public EFBJIEBPEIM(RenderPassEvent KLJFPJBIHOO, Material ELKLKFMLCMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x659D780", Offset = "0x659C580", VA = "0x18659D780", Slot = "9")]
			public override void Execute(ScriptableRenderContext BCCEHJNGNAL, RenderingData KIBLGGPMKAO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static HDMHFAEIJBM CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private EFBJIEBPEIM m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x659E3E0", Offset = "0x659D1E0", VA = "0x18659E3E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x659E390", Offset = "0x659D190", VA = "0x18659E390")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x659E1E0", Offset = "0x659CFE0", VA = "0x18659E1E0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x659E110", Offset = "0x659CF10", VA = "0x18659E110", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer BCGNNFCJICK, RenderingData KIBLGGPMKAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB7F120", Offset = "0xB7DF20", VA = "0x180B7F120")]
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
		public struct EINBFIKPNDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public float LMNFKNHKEOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Color IALGELFPGAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Mesh OOCKBIKCADJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AnimationCurve DOKCKKHHNOO;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public sealed class ALEAHDOHFGC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string JLNCEFIILNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler CJGGNAJBCPE;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int FJMEHHNOIML;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly int OFIMKDKILIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private Material MFGMPDDFNLP;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x659D6A0", Offset = "0x659C4A0", VA = "0x18659D6A0")]
			public ALEAHDOHFGC(RenderPassEvent KLJFPJBIHOO, Material ELKLKFMLCMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x659D3E0", Offset = "0x659C1E0", VA = "0x18659D3E0", Slot = "9")]
			public override void Execute(ScriptableRenderContext BCCEHJNGNAL, RenderingData KIBLGGPMKAO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static EINBFIKPNDJ CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private ALEAHDOHFGC m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x659E710", Offset = "0x659D510", VA = "0x18659E710")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x659E560", Offset = "0x659D360", VA = "0x18659E560", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x659E440", Offset = "0x659D240", VA = "0x18659E440", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer BCGNNFCJICK, RenderingData KIBLGGPMKAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB7F120", Offset = "0xB7DF20", VA = "0x180B7F120")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string DDNGNJILONM
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool LJADHEHPOIN
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7D65C0", Offset = "0x7D53C0", VA = "0x1807D65C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer BECIKFDBLCP, ScriptableRenderContext BCCEHJNGNAL, RenderingData KIBLGGPMKAO);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x790830", Offset = "0x78F630", VA = "0x180790830")]
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
		private class NNBGMDBMDIA : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private bool KJJJHDONFDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly List<PerCameraRenderEffect> EGFDICACJFG;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly List<PerCameraRenderEffect> BFEBCCCJKFG;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x659F290", Offset = "0x659E090", VA = "0x18659F290")]
			public NNBGMDBMDIA(RenderPassEvent KLJFPJBIHOO, bool KJJJHDONFDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x659EE30", Offset = "0x659DC30", VA = "0x18659EE30")]
			public bool KAADAPPHBFL(CameraData JJJAMCPDFPG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x659EC60", Offset = "0x659DA60", VA = "0x18659EC60", Slot = "9")]
			public override void Execute(ScriptableRenderContext BCCEHJNGNAL, RenderingData KIBLGGPMKAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x659F120", Offset = "0x659DF20", VA = "0x18659F120")]
			private void MDOHEJEPKDP(PerCameraRenderEffect CCLMHKPMKOM, ScriptableRenderContext BCCEHJNGNAL, RenderingData KIBLGGPMKAO)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NNBGMDBMDIA m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private NNBGMDBMDIA m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x659F3D0", Offset = "0x659E1D0", VA = "0x18659F3D0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x659F340", Offset = "0x659E140", VA = "0x18659F340", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer BCGNNFCJICK, RenderingData KIBLGGPMKAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB7F120", Offset = "0xB7DF20", VA = "0x180B7F120")]
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
		[Cpp2IlInjected.Address(RVA = "0x659F620", Offset = "0x659E420", VA = "0x18659F620")]
		public static void HJFIGCBAIFO(ScriptableRenderPass BIJBHIKJBDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x659F480", Offset = "0x659E280", VA = "0x18659F480", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer BCGNNFCJICK, RenderingData KIBLGGPMKAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB7F120", Offset = "0xB7DF20", VA = "0x180B7F120")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class AAOEEPIFAHG
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Mesh APEBKADDOOK;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x659CB80", Offset = "0x659B980", VA = "0x18659CB80")]
	public static Mesh DOILCPCFBFL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x659C6E0", Offset = "0x659B4E0", VA = "0x18659C6E0")]
	public static Matrix4x4 COMOBIGNIIN(Camera MOKJAFMIBBJ, bool LGNAHHOPBAK = false, bool GKAJHPDPFAF = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x659CC30", Offset = "0x659BA30", VA = "0x18659CC30")]
	private static Mesh JCNOPOJBPHL()
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
