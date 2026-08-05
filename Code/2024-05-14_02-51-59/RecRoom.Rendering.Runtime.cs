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
		private class JGLDFBJFIGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public bool CLMLPPIJFFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly List<KDCLEIJGKPH> ANKEEBJJLKK;

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x692AA20", Offset = "0x6929420", VA = "0x18692AA20")]
			public JGLDFBJFIGK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class GFCKGOOHANA : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly string HELAFGCKJNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly JGLDFBJFIGK DHOJCAHNAGG;

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x692A940", Offset = "0x6929340", VA = "0x18692A940")]
			public GFCKGOOHANA(RenderPassEvent AAANINJIKBM, JGLDFBJFIGK DHOJCAHNAGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x692A530", Offset = "0x6928F30", VA = "0x18692A530", Slot = "9")]
			public override void Execute(ScriptableRenderContext JGGBEOJAHKH, RenderingData OPBJHNCDMBF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class BIBPNKGKMLJ : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private readonly string HELAFGCKJNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private readonly JGLDFBJFIGK DHOJCAHNAGG;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6929240", Offset = "0x6927C40", VA = "0x186929240")]
			public BIBPNKGKMLJ(RenderPassEvent AAANINJIKBM, JGLDFBJFIGK DHOJCAHNAGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6928F30", Offset = "0x6927930", VA = "0x186928F30", Slot = "9")]
			public override void Execute(ScriptableRenderContext JGGBEOJAHKH, RenderingData OPBJHNCDMBF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static List<KDCLEIJGKPH> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private GFCKGOOHANA fastLinesUpdatePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private BIBPNKGKMLJ fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private JGLDFBJFIGK sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x692A190", Offset = "0x6928B90", VA = "0x18692A190", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x692A0F0", Offset = "0x6928AF0", VA = "0x18692A0F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer LDIKCIPDAKN, RenderingData OPBJHNCDMBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xC6E860", Offset = "0xC6D260", VA = "0x180C6E860")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KDCLEIJGKPH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GIJKBJDEOPD(CommandBuffer KNFNDGGBBAI, Camera GCCGCHAAJFL, [NotNull] UniversalAdditionalCameraData DHPJNMCIBLC, bool JAFEJKIOEEG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJGOADIDJGO(Camera GCCGCHAAJFL, CommandBuffer ANEOADEKJBB);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Tooltip("RR Mobile Fade")]
	[DisallowMultipleRendererFeature(null)]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct KMAJGOLPLFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public float IEDDOMKBKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public float GEICLOJIPGK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class DKGLNFMKNJC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private static readonly string GOEODENFJCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ProfilingSampler NFCFCPMMLGL;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private static readonly int IJOBODNEADI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private Material BEJIOFKCECN;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6929700", Offset = "0x6928100", VA = "0x186929700")]
			public DKGLNFMKNJC(RenderPassEvent AAANINJIKBM, Material FEIOCBKHAFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6929320", Offset = "0x6927D20", VA = "0x186929320", Slot = "9")]
			public override void Execute(ScriptableRenderContext JGGBEOJAHKH, RenderingData OPBJHNCDMBF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static KMAJGOLPLFC CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private DKGLNFMKNJC m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x692AD80", Offset = "0x6929780", VA = "0x18692AD80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x692AD30", Offset = "0x6929730", VA = "0x18692AD30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x692AB80", Offset = "0x6929580", VA = "0x18692AB80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x692AAB0", Offset = "0x69294B0", VA = "0x18692AAB0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer LDIKCIPDAKN, RenderingData OPBJHNCDMBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xC6E860", Offset = "0xC6D260", VA = "0x180C6E860")]
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
		public struct FBDMEDDONNO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public float BOCFLBENDNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Color IOELCLBFOFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Mesh FIMANPPHBCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AnimationCurve ALNBAPCHACB;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public sealed class NHCGKKCIFLN : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string GOEODENFJCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler NFCFCPMMLGL;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int BHNDALPLGGK;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly int JGHNLAGDGAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private Material BEJIOFKCECN;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x692B3D0", Offset = "0x6929DD0", VA = "0x18692B3D0")]
			public NHCGKKCIFLN(RenderPassEvent AAANINJIKBM, Material FEIOCBKHAFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x692B110", Offset = "0x6929B10", VA = "0x18692B110", Slot = "9")]
			public override void Execute(ScriptableRenderContext JGGBEOJAHKH, RenderingData OPBJHNCDMBF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static FBDMEDDONNO CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private NHCGKKCIFLN m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x692B0B0", Offset = "0x6929AB0", VA = "0x18692B0B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x692AF00", Offset = "0x6929900", VA = "0x18692AF00", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x692ADE0", Offset = "0x69297E0", VA = "0x18692ADE0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer LDIKCIPDAKN, RenderingData OPBJHNCDMBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC6E860", Offset = "0xC6D260", VA = "0x180C6E860")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string NHIAGNCANCL
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool AGKKFMELPJI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x80B1E0", Offset = "0x809BE0", VA = "0x18080B1E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer ANEOADEKJBB, ScriptableRenderContext JGGBEOJAHKH, RenderingData OPBJHNCDMBF);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C34A0", Offset = "0x7C1EA0", VA = "0x1807C34A0")]
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
		private class NKKHBAOOMOM : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private bool AOBNJKHBDEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly List<PerCameraRenderEffect> PLBGBLDKBIO;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly List<PerCameraRenderEffect> JNCOBFFKAAG;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x692BAE0", Offset = "0x692A4E0", VA = "0x18692BAE0")]
			public NKKHBAOOMOM(RenderPassEvent AAANINJIKBM, bool AOBNJKHBDEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x692B680", Offset = "0x692A080", VA = "0x18692B680")]
			public bool JKJBCFDBKGC(CameraData DHPJNMCIBLC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x692B4B0", Offset = "0x6929EB0", VA = "0x18692B4B0", Slot = "9")]
			public override void Execute(ScriptableRenderContext JGGBEOJAHKH, RenderingData OPBJHNCDMBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x692B970", Offset = "0x692A370", VA = "0x18692B970")]
			private void LEKOBMHAIOP(PerCameraRenderEffect OJFDPAIOBKA, ScriptableRenderContext JGGBEOJAHKH, RenderingData OPBJHNCDMBF)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NKKHBAOOMOM m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private NKKHBAOOMOM m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x692BC20", Offset = "0x692A620", VA = "0x18692BC20", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x692BB90", Offset = "0x692A590", VA = "0x18692BB90", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer LDIKCIPDAKN, RenderingData OPBJHNCDMBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xC6E860", Offset = "0xC6D260", VA = "0x180C6E860")]
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
		[Cpp2IlInjected.Address(RVA = "0x692BE70", Offset = "0x692A870", VA = "0x18692BE70")]
		public static void PLGAKEJOIKF(ScriptableRenderPass OMOODKHDGAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x692BCD0", Offset = "0x692A6D0", VA = "0x18692BCD0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer LDIKCIPDAKN, RenderingData OPBJHNCDMBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xC6E860", Offset = "0xC6D260", VA = "0x180C6E860")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FEONKPJNJAL
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Mesh CIFICDNHPKP;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x692A040", Offset = "0x6928A40", VA = "0x18692A040")]
	public static Mesh PLEJNFKKLAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x69297E0", Offset = "0x69281E0", VA = "0x1869297E0")]
	public static Matrix4x4 DOHOEHDFPHI(Camera GCCGCHAAJFL, bool BJAKHJLGAPM = false, bool EDICIDIPNCN = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6929C80", Offset = "0x6928680", VA = "0x186929C80")]
	private static Mesh IGOFOCDBPOK()
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
