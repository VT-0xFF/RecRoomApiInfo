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
		private class LBBNBJOBJLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public bool BADHHFBGNCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly List<PLACLOCJDDA> PGNHACMCPAH;

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6575580", Offset = "0x6574380", VA = "0x186575580")]
			public LBBNBJOBJLD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class BKEMHFEHLPH : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly string NACEPLCGJOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly LBBNBJOBJLD ELOPOGNKMFP;

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6574290", Offset = "0x6573090", VA = "0x186574290")]
			public BKEMHFEHLPH(RenderPassEvent PGDDKLDNGAF, LBBNBJOBJLD ELOPOGNKMFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6573E80", Offset = "0x6572C80", VA = "0x186573E80", Slot = "9")]
			public override void Execute(ScriptableRenderContext HOLFPPNPJAH, RenderingData POBOHAKIHHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class LIPPEANDAKB : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private readonly string NACEPLCGJOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private readonly LBBNBJOBJLD ELOPOGNKMFP;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6575920", Offset = "0x6574720", VA = "0x186575920")]
			public LIPPEANDAKB(RenderPassEvent PGDDKLDNGAF, LBBNBJOBJLD ELOPOGNKMFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6575610", Offset = "0x6574410", VA = "0x186575610", Slot = "9")]
			public override void Execute(ScriptableRenderContext HOLFPPNPJAH, RenderingData POBOHAKIHHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static List<PLACLOCJDDA> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private BKEMHFEHLPH fastLinesUpdatePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private LIPPEANDAKB fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private LBBNBJOBJLD sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x65748D0", Offset = "0x65736D0", VA = "0x1865748D0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6574830", Offset = "0x6573630", VA = "0x186574830", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer LAJADMHLOJE, RenderingData POBOHAKIHHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB94F30", Offset = "0xB93D30", VA = "0x180B94F30")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PLACLOCJDDA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MGBBBGNDMAD(CommandBuffer LPMIDNBNPIC, Camera MPBFBPKALIA, [NotNull] UniversalAdditionalCameraData FLNLEMMMKKH, bool HLLOACHIHCE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMFAPHGOIFM(Camera MPBFBPKALIA, CommandBuffer GIFEGHAAFMI);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Tooltip("RR Mobile Fade")]
	[DisallowMultipleRendererFeature(null)]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct KFDDMHHDLPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public float NEDNADPIOAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public float KBFELGPHBCM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class CIMLECJJHAA : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private static readonly string EBDMEAECPFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ProfilingSampler HFBIENOIFEM;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private static readonly int HDDBJANMNEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private Material BNLGPLJLAEF;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6574750", Offset = "0x6573550", VA = "0x186574750")]
			public CIMLECJJHAA(RenderPassEvent PGDDKLDNGAF, Material CMHHFEPJBNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6574370", Offset = "0x6573170", VA = "0x186574370", Slot = "9")]
			public override void Execute(ScriptableRenderContext HOLFPPNPJAH, RenderingData POBOHAKIHHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static KFDDMHHDLPK CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private CIMLECJJHAA m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x65763B0", Offset = "0x65751B0", VA = "0x1865763B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6576360", Offset = "0x6575160", VA = "0x186576360")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x65761B0", Offset = "0x6574FB0", VA = "0x1865761B0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x65760E0", Offset = "0x6574EE0", VA = "0x1865760E0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer LAJADMHLOJE, RenderingData POBOHAKIHHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB94F30", Offset = "0xB93D30", VA = "0x180B94F30")]
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
		public struct JMGODMOLADE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public float HLLPKLKFNCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Color AJBOIJOLAFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Mesh NGCCOFIMEJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AnimationCurve POBAFMHGEBD;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public sealed class BHADMOEAOPD : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string EBDMEAECPFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler HFBIENOIFEM;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int CNDGPAGADHL;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly int MKOONJJILMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private Material BNLGPLJLAEF;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6573DA0", Offset = "0x6572BA0", VA = "0x186573DA0")]
			public BHADMOEAOPD(RenderPassEvent PGDDKLDNGAF, Material CMHHFEPJBNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6573AE0", Offset = "0x65728E0", VA = "0x186573AE0", Slot = "9")]
			public override void Execute(ScriptableRenderContext HOLFPPNPJAH, RenderingData POBOHAKIHHL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static JMGODMOLADE CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private BHADMOEAOPD m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x65766E0", Offset = "0x65754E0", VA = "0x1865766E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6576530", Offset = "0x6575330", VA = "0x186576530", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6576410", Offset = "0x6575210", VA = "0x186576410", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer LAJADMHLOJE, RenderingData POBOHAKIHHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB94F30", Offset = "0xB93D30", VA = "0x180B94F30")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string FFGLNPDPGIO
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool DMJPPMAKBMG
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7F1AA0", Offset = "0x7F08A0", VA = "0x1807F1AA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer GIFEGHAAFMI, ScriptableRenderContext HOLFPPNPJAH, RenderingData POBOHAKIHHL);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5B0", Offset = "0x7A93B0", VA = "0x1807AA5B0")]
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
		private class MCIDOCOKLJJ : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private bool MABJINBKBLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly List<PerCameraRenderEffect> BHGJODOJCFF;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly List<PerCameraRenderEffect> KNHPJIMLBGM;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6576030", Offset = "0x6574E30", VA = "0x186576030")]
			public MCIDOCOKLJJ(RenderPassEvent PGDDKLDNGAF, bool MABJINBKBLF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6575BD0", Offset = "0x65749D0", VA = "0x186575BD0")]
			public bool GHCKFFOJENB(CameraData FLNLEMMMKKH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6575A00", Offset = "0x6574800", VA = "0x186575A00", Slot = "9")]
			public override void Execute(ScriptableRenderContext HOLFPPNPJAH, RenderingData POBOHAKIHHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6575EC0", Offset = "0x6574CC0", VA = "0x186575EC0")]
			private void KNGPAFMKIBE(PerCameraRenderEffect NGBLDKGLIII, ScriptableRenderContext HOLFPPNPJAH, RenderingData POBOHAKIHHL)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private MCIDOCOKLJJ m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private MCIDOCOKLJJ m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x65767D0", Offset = "0x65755D0", VA = "0x1865767D0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6576740", Offset = "0x6575540", VA = "0x186576740", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer LAJADMHLOJE, RenderingData POBOHAKIHHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB94F30", Offset = "0xB93D30", VA = "0x180B94F30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6576A20", Offset = "0x6575820", VA = "0x186576A20")]
		public static void JGPFHKJKCIG(ScriptableRenderPass GKCMFEKLDHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6576880", Offset = "0x6575680", VA = "0x186576880", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer LAJADMHLOJE, RenderingData POBOHAKIHHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB94F30", Offset = "0xB93D30", VA = "0x180B94F30")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HPBKHOAGPLK
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Mesh IOONBOJJNHN;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x65754D0", Offset = "0x65742D0", VA = "0x1865754D0")]
	public static Mesh OEOEIIGMIKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6574C70", Offset = "0x6573A70", VA = "0x186574C70")]
	public static Matrix4x4 CMEOPLEMIDM(Camera MPBFBPKALIA, bool ANCPNLHDFJD = false, bool MKLBOLFJADO = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6575110", Offset = "0x6573F10", VA = "0x186575110")]
	private static Mesh EOIDLKPFKML()
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
