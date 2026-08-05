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
		private class NKCJFHCOPHH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public bool APOICBLJLMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly List<FGGKHBCBFDK> EIJEHOKJMFJ;

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x659D100", Offset = "0x659BB00", VA = "0x18659D100")]
			public NKCJFHCOPHH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class MJIMOAKKMME : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly string DLPKBENCEOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly NKCJFHCOPHH LBHJMDFJDEL;

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x659C9C0", Offset = "0x659B3C0", VA = "0x18659C9C0")]
			public MJIMOAKKMME(RenderPassEvent JPJNABHKFEA, NKCJFHCOPHH LBHJMDFJDEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x659C5B0", Offset = "0x659AFB0", VA = "0x18659C5B0", Slot = "9")]
			public override void Execute(ScriptableRenderContext AGHGCGMHDAO, RenderingData LFCEAOBECBK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class GDOADKMABJH : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private readonly string DLPKBENCEOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private readonly NKCJFHCOPHH LBHJMDFJDEL;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x659B4E0", Offset = "0x6599EE0", VA = "0x18659B4E0")]
			public GDOADKMABJH(RenderPassEvent JPJNABHKFEA, NKCJFHCOPHH LBHJMDFJDEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x659B1D0", Offset = "0x6599BD0", VA = "0x18659B1D0", Slot = "9")]
			public override void Execute(ScriptableRenderContext AGHGCGMHDAO, RenderingData LFCEAOBECBK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static List<FGGKHBCBFDK> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private MJIMOAKKMME fastLinesUpdatePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private GDOADKMABJH fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NKCJFHCOPHH sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x659AA90", Offset = "0x6599490", VA = "0x18659AA90", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x659A9F0", Offset = "0x65993F0", VA = "0x18659A9F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OIBBJKCEHPL, RenderingData LFCEAOBECBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB80780", Offset = "0xB7F180", VA = "0x180B80780")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FGGKHBCBFDK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGGNAKBNIHH(CommandBuffer JKACDONGIED, Camera FMLAMMAEDJM, [NotNull] UniversalAdditionalCameraData FJACKPKEEMK, bool MKCICNLAPOB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OKMMEDEPJPO(Camera FMLAMMAEDJM, CommandBuffer IFLCJGFLADB);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Tooltip("RR Mobile Fade")]
	[DisallowMultipleRendererFeature(null)]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct JIHFPFCIMDA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public float AMFGHLFAFDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public float GJPADIJHGNA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class NPHFJGDMNNK : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private static readonly string BLBDKCEOKBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ProfilingSampler PEELMOKOJCB;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private static readonly int HDHOBJEMPAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private Material LHIEDAKDJEF;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x659D570", Offset = "0x659BF70", VA = "0x18659D570")]
			public NPHFJGDMNNK(RenderPassEvent JPJNABHKFEA, Material HEPAJJIBPIF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x659D190", Offset = "0x659BB90", VA = "0x18659D190", Slot = "9")]
			public override void Execute(ScriptableRenderContext AGHGCGMHDAO, RenderingData LFCEAOBECBK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static JIHFPFCIMDA CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private NPHFJGDMNNK m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x659CD70", Offset = "0x659B770", VA = "0x18659CD70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x659CD20", Offset = "0x659B720", VA = "0x18659CD20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x659CB70", Offset = "0x659B570", VA = "0x18659CB70", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x659CAA0", Offset = "0x659B4A0", VA = "0x18659CAA0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OIBBJKCEHPL, RenderingData LFCEAOBECBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB80780", Offset = "0xB7F180", VA = "0x180B80780")]
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
		public struct LOGDBLDNIKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public float BAAKKKCCFMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Color IAPKHNJJDCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Mesh KOPLEAPEIDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AnimationCurve HALBIHHNAAJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public sealed class GDLFCNICMNI : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string BLBDKCEOKBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler PEELMOKOJCB;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int JFLNNBFPPFM;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly int GDFOCPFMKOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private Material LHIEDAKDJEF;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x659B0F0", Offset = "0x6599AF0", VA = "0x18659B0F0")]
			public GDLFCNICMNI(RenderPassEvent JPJNABHKFEA, Material HEPAJJIBPIF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x659AE30", Offset = "0x6599830", VA = "0x18659AE30", Slot = "9")]
			public override void Execute(ScriptableRenderContext AGHGCGMHDAO, RenderingData LFCEAOBECBK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static LOGDBLDNIKE CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private GDLFCNICMNI m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x659D0A0", Offset = "0x659BAA0", VA = "0x18659D0A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x659CEF0", Offset = "0x659B8F0", VA = "0x18659CEF0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x659CDD0", Offset = "0x659B7D0", VA = "0x18659CDD0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OIBBJKCEHPL, RenderingData LFCEAOBECBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB80780", Offset = "0xB7F180", VA = "0x180B80780")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string OPJCBFKGPKC
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool FDNIHOOKHEN
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7D7550", Offset = "0x7D5F50", VA = "0x1807D7550", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer IFLCJGFLADB, ScriptableRenderContext AGHGCGMHDAO, RenderingData LFCEAOBECBK);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x78F200", Offset = "0x78DC00", VA = "0x18078F200")]
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
		private class GKGOIHCIFDN : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private bool IGCBGLINJMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly List<PerCameraRenderEffect> EKGDDCGLAOD;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly List<PerCameraRenderEffect> BGLDMGBFOPH;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x659BBF0", Offset = "0x659A5F0", VA = "0x18659BBF0")]
			public GKGOIHCIFDN(RenderPassEvent JPJNABHKFEA, bool IGCBGLINJMO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x659B790", Offset = "0x659A190", VA = "0x18659B790")]
			public bool GAKEPCKHAAM(CameraData FJACKPKEEMK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x659B5C0", Offset = "0x6599FC0", VA = "0x18659B5C0", Slot = "9")]
			public override void Execute(ScriptableRenderContext AGHGCGMHDAO, RenderingData LFCEAOBECBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x659BA80", Offset = "0x659A480", VA = "0x18659BA80")]
			private void OOLOGLOEJGH(PerCameraRenderEffect EGNPKIJDLIN, ScriptableRenderContext AGHGCGMHDAO, RenderingData LFCEAOBECBK)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private GKGOIHCIFDN m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private GKGOIHCIFDN m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x659D6E0", Offset = "0x659C0E0", VA = "0x18659D6E0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x659D650", Offset = "0x659C050", VA = "0x18659D650", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OIBBJKCEHPL, RenderingData LFCEAOBECBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB80780", Offset = "0xB7F180", VA = "0x180B80780")]
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
		[Cpp2IlInjected.Address(RVA = "0x659D930", Offset = "0x659C330", VA = "0x18659D930")]
		public static void LBFOKMCCCGO(ScriptableRenderPass INGANLKKCJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x659D790", Offset = "0x659C190", VA = "0x18659D790", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OIBBJKCEHPL, RenderingData LFCEAOBECBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB80780", Offset = "0xB7F180", VA = "0x180B80780")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HCEHBHAOPJJ
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Mesh HNEDOJEPJDD;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x659C140", Offset = "0x659AB40", VA = "0x18659C140")]
	public static Mesh FFBGNCNOJGC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x659BCA0", Offset = "0x659A6A0", VA = "0x18659BCA0")]
	public static Matrix4x4 FCIBDCAJGNE(Camera FMLAMMAEDJM, bool KGBAENBKHCP = false, bool EMLNOODLFAN = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x659C1F0", Offset = "0x659ABF0", VA = "0x18659C1F0")]
	private static Mesh HKCLEHKGBEM()
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
