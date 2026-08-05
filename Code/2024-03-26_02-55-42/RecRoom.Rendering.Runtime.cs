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
		private class EMHPDCFCHEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public bool NIELFCKOIDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly List<BMDAEDEJBFK> BPJAICGHMOF;

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x67777F0", Offset = "0x6776BF0", VA = "0x1867777F0")]
			public EMHPDCFCHEJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class HOEAOLEBPKG : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly string FMPCLIONEMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly EMHPDCFCHEJ MKOGBOPNOEI;

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x67784C0", Offset = "0x67778C0", VA = "0x1867784C0")]
			public HOEAOLEBPKG(RenderPassEvent PLMGHLKAGDB, EMHPDCFCHEJ MKOGBOPNOEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x67780B0", Offset = "0x67774B0", VA = "0x1867780B0", Slot = "9")]
			public override void Execute(ScriptableRenderContext APOKKKDAFKO, RenderingData FGICCEHKCNF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class FFMGNLNELLH : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private readonly string FMPCLIONEMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private readonly EMHPDCFCHEJ MKOGBOPNOEI;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6777B90", Offset = "0x6776F90", VA = "0x186777B90")]
			public FFMGNLNELLH(RenderPassEvent PLMGHLKAGDB, EMHPDCFCHEJ MKOGBOPNOEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6777880", Offset = "0x6776C80", VA = "0x186777880", Slot = "9")]
			public override void Execute(ScriptableRenderContext APOKKKDAFKO, RenderingData FGICCEHKCNF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static List<BMDAEDEJBFK> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private HOEAOLEBPKG fastLinesUpdatePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private FFMGNLNELLH fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EMHPDCFCHEJ sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6777D10", Offset = "0x6777110", VA = "0x186777D10", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6777C70", Offset = "0x6777070", VA = "0x186777C70", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FPOCAHFIAOI, RenderingData FGICCEHKCNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xC4A9A0", Offset = "0xC49DA0", VA = "0x180C4A9A0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BMDAEDEJBFK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NMMEKCOCAPH(CommandBuffer IDGNJPGDHAG, Camera BCFBFBEPKAI, [NotNull] UniversalAdditionalCameraData IDLINJEJHHI, bool JJIMJCOKCIJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OBEKPOKEPIO(Camera BCFBFBEPKAI, CommandBuffer JOMLPNOOLBG);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Tooltip("RR Mobile Fade")]
	[DisallowMultipleRendererFeature(null)]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct HHJPBOCIFLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public float GAIMBIEFONL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public float LCHPLAIKIDM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class IGDJCHBMHID : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private static readonly string IGMACEOEBBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ProfilingSampler LNDONOMFOIE;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private static readonly int BKOOMMAAHDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private Material DPNMEAFBFKG;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6778980", Offset = "0x6777D80", VA = "0x186778980")]
			public IGDJCHBMHID(RenderPassEvent PLMGHLKAGDB, Material GDFHEJJFPNA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x67785A0", Offset = "0x67779A0", VA = "0x1867785A0", Slot = "9")]
			public override void Execute(ScriptableRenderContext APOKKKDAFKO, RenderingData FGICCEHKCNF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static HHJPBOCIFLD CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IGDJCHBMHID m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x67790D0", Offset = "0x67784D0", VA = "0x1867790D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6779080", Offset = "0x6778480", VA = "0x186779080")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6778ED0", Offset = "0x67782D0", VA = "0x186778ED0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6778E00", Offset = "0x6778200", VA = "0x186778E00", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FPOCAHFIAOI, RenderingData FGICCEHKCNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xC4A9A0", Offset = "0xC49DA0", VA = "0x180C4A9A0")]
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
		public struct AKDBKAHCGEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public float PFIPABPNJHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Color PHJLJGLDJNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Mesh LPJFDCKGBIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AnimationCurve ACELNGGEAIM;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public sealed class LBEPADFPHGH : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string IGMACEOEBBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler LNDONOMFOIE;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int GPELAMDOGME;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly int JLPGKPOIHNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private Material DPNMEAFBFKG;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6778D20", Offset = "0x6778120", VA = "0x186778D20")]
			public LBEPADFPHGH(RenderPassEvent PLMGHLKAGDB, Material GDFHEJJFPNA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6778A60", Offset = "0x6777E60", VA = "0x186778A60", Slot = "9")]
			public override void Execute(ScriptableRenderContext APOKKKDAFKO, RenderingData FGICCEHKCNF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static AKDBKAHCGEO CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private LBEPADFPHGH m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x6779400", Offset = "0x6778800", VA = "0x186779400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6779250", Offset = "0x6778650", VA = "0x186779250", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6779130", Offset = "0x6778530", VA = "0x186779130", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FPOCAHFIAOI, RenderingData FGICCEHKCNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC4A9A0", Offset = "0xC49DA0", VA = "0x180C4A9A0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string BMCMGPEINFE
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool DGNLJBEKLLE
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x805B30", Offset = "0x804F30", VA = "0x180805B30", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer JOMLPNOOLBG, ScriptableRenderContext APOKKKDAFKO, RenderingData FGICCEHKCNF);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD2F0", Offset = "0x7BC6F0", VA = "0x1807BD2F0")]
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
		private class CCPDPDJFELI : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private bool GMPGHOGPEJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly List<PerCameraRenderEffect> BKMDOCFMAEG;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly List<PerCameraRenderEffect> CBHHJBJBPDP;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6777740", Offset = "0x6776B40", VA = "0x186777740")]
			public CCPDPDJFELI(RenderPassEvent PLMGHLKAGDB, bool GMPGHOGPEJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x67771F0", Offset = "0x67765F0", VA = "0x1867771F0")]
			public bool DKCJJMAEJNE(CameraData IDLINJEJHHI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x67774E0", Offset = "0x67768E0", VA = "0x1867774E0", Slot = "9")]
			public override void Execute(ScriptableRenderContext APOKKKDAFKO, RenderingData FGICCEHKCNF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6777110", Offset = "0x6776510", VA = "0x186777110")]
			private void APEHEFJJGII(PerCameraRenderEffect GNDGDPOFOLP, ScriptableRenderContext APOKKKDAFKO, RenderingData FGICCEHKCNF)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private CCPDPDJFELI m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private CCPDPDJFELI m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6779E00", Offset = "0x6779200", VA = "0x186779E00", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6779D70", Offset = "0x6779170", VA = "0x186779D70", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FPOCAHFIAOI, RenderingData FGICCEHKCNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xC4A9A0", Offset = "0xC49DA0", VA = "0x180C4A9A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x677A050", Offset = "0x6779450", VA = "0x18677A050")]
		public static void MBJJJKKCPDJ(ScriptableRenderPass BGGGOEAOOEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6779EB0", Offset = "0x67792B0", VA = "0x186779EB0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FPOCAHFIAOI, RenderingData FGICCEHKCNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xC4A9A0", Offset = "0xC49DA0", VA = "0x180C4A9A0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NMEJPDJAIHO
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Mesh MODGIFLEFCD;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6779460", Offset = "0x6778860", VA = "0x186779460")]
	public static Mesh IMPMEDJHBKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67798D0", Offset = "0x6778CD0", VA = "0x1867798D0")]
	public static Matrix4x4 LMKNENPBBKF(Camera BCFBFBEPKAI, bool CMAACGHIGNC = false, bool BJJCIEAGOHJ = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6779510", Offset = "0x6778910", VA = "0x186779510")]
	private static Mesh LCCNMGGNDHN()
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
