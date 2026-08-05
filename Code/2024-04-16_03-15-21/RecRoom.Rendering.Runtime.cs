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
		private class PBHKGMCILIK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public bool HLFGHFCGKLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly List<CBDPGKNIGED> BMDKCHHMFOD;

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6710D30", Offset = "0x670FF30", VA = "0x186710D30")]
			public PBHKGMCILIK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class DKFMODDDLHH : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly string FPPILLKJGPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly PBHKGMCILIK PKPAGIJGBBF;

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x670F270", Offset = "0x670E470", VA = "0x18670F270")]
			public DKFMODDDLHH(RenderPassEvent HLKLIGEDCED, PBHKGMCILIK PKPAGIJGBBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x670EE60", Offset = "0x670E060", VA = "0x18670EE60", Slot = "9")]
			public override void Execute(ScriptableRenderContext DPGBKIGAHAN, RenderingData BCHFIEABLNB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class EEDMGGJDICP : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private readonly string FPPILLKJGPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private readonly PBHKGMCILIK PKPAGIJGBBF;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x670F660", Offset = "0x670E860", VA = "0x18670F660")]
			public EEDMGGJDICP(RenderPassEvent HLKLIGEDCED, PBHKGMCILIK PKPAGIJGBBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x670F350", Offset = "0x670E550", VA = "0x18670F350", Slot = "9")]
			public override void Execute(ScriptableRenderContext DPGBKIGAHAN, RenderingData BCHFIEABLNB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static List<CBDPGKNIGED> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private DKFMODDDLHH fastLinesUpdatePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private EEDMGGJDICP fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private PBHKGMCILIK sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x670F7E0", Offset = "0x670E9E0", VA = "0x18670F7E0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x670F740", Offset = "0x670E940", VA = "0x18670F740", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FBFNLOOEGJA, RenderingData BCHFIEABLNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xC435F0", Offset = "0xC427F0", VA = "0x180C435F0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CBDPGKNIGED
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ICHKJPCEMDE(CommandBuffer FJPCIEFBFAB, Camera KHMEBCFGGEJ, [NotNull] UniversalAdditionalCameraData BFBLIFALJEF, bool NLGNDLMLCFP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PHJCNGFNLDK(Camera KHMEBCFGGEJ, CommandBuffer PLCLLNHOEDB);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Tooltip("RR Mobile Fade")]
	[DisallowMultipleRendererFeature(null)]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct AINAKJHCGBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public float IIELJJEONEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public float NHNANINHCCC;
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class NGFELPLOIPL : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private static readonly string HHHFBGKHNLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ProfilingSampler IGGEGAEMNMN;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private static readonly int FGNNFJNPMGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private Material LLPAEIGIAHA;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6710C50", Offset = "0x670FE50", VA = "0x186710C50")]
			public NGFELPLOIPL(RenderPassEvent HLKLIGEDCED, Material ODNKEDBIBDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6710880", Offset = "0x670FA80", VA = "0x186710880", Slot = "9")]
			public override void Execute(ScriptableRenderContext DPGBKIGAHAN, RenderingData BCHFIEABLNB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static AINAKJHCGBG CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private NGFELPLOIPL m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x6710520", Offset = "0x670F720", VA = "0x186710520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x67104D0", Offset = "0x670F6D0", VA = "0x1867104D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6710320", Offset = "0x670F520", VA = "0x186710320", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6710250", Offset = "0x670F450", VA = "0x186710250", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FBFNLOOEGJA, RenderingData BCHFIEABLNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xC435F0", Offset = "0xC427F0", VA = "0x180C435F0")]
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
		public struct NDJEMKPHMEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public float JPIBGGNFJOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Color PGAGKIKLMPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Mesh PHNCJMBAJGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AnimationCurve ECGBADMIGBG;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public sealed class BAFEFCNMPFD : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string HHHFBGKHNLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler IGGEGAEMNMN;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int ECFLKCLENMD;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly int IDIOHLOMCDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private Material LLPAEIGIAHA;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x670E480", Offset = "0x670D680", VA = "0x18670E480")]
			public BAFEFCNMPFD(RenderPassEvent HLKLIGEDCED, Material ODNKEDBIBDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x670E1E0", Offset = "0x670D3E0", VA = "0x18670E1E0", Slot = "9")]
			public override void Execute(ScriptableRenderContext DPGBKIGAHAN, RenderingData BCHFIEABLNB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static NDJEMKPHMEN CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private BAFEFCNMPFD m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x6710830", Offset = "0x670FA30", VA = "0x186710830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6710680", Offset = "0x670F880", VA = "0x186710680", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6710570", Offset = "0x670F770", VA = "0x186710570", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FBFNLOOEGJA, RenderingData BCHFIEABLNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC435F0", Offset = "0xC427F0", VA = "0x180C435F0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string OKJFDMGJNIO
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool AKAJELMHFHK
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7FCE90", Offset = "0x7FC090", VA = "0x1807FCE90", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer PLCLLNHOEDB, ScriptableRenderContext DPGBKIGAHAN, RenderingData BCHFIEABLNB);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BE0", Offset = "0x7B4DE0", VA = "0x1807B5BE0")]
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
		private class LMDAPCACKPP : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private bool OCEPKAGJBLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly List<PerCameraRenderEffect> ECDOLMDLGEE;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly List<PerCameraRenderEffect> HCBPNDCMAPM;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x67101A0", Offset = "0x670F3A0", VA = "0x1867101A0")]
			public LMDAPCACKPP(RenderPassEvent HLKLIGEDCED, bool OCEPKAGJBLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x670FB80", Offset = "0x670ED80", VA = "0x18670FB80")]
			public bool EJBGCOAIBKC(CameraData BFBLIFALJEF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x670FE60", Offset = "0x670F060", VA = "0x18670FE60", Slot = "9")]
			public override void Execute(ScriptableRenderContext DPGBKIGAHAN, RenderingData BCHFIEABLNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6710030", Offset = "0x670F230", VA = "0x186710030")]
			private void FFLEEKIGAJL(PerCameraRenderEffect OCFPLELHFIP, ScriptableRenderContext DPGBKIGAHAN, RenderingData BCHFIEABLNB)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private LMDAPCACKPP m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private LMDAPCACKPP m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6710E50", Offset = "0x6710050", VA = "0x186710E50", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6710DC0", Offset = "0x670FFC0", VA = "0x186710DC0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FBFNLOOEGJA, RenderingData BCHFIEABLNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xC435F0", Offset = "0xC427F0", VA = "0x180C435F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67110A0", Offset = "0x67102A0", VA = "0x1867110A0")]
		public static void HPNHCHDICIK(ScriptableRenderPass JBGPHFALNDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6710F00", Offset = "0x6710100", VA = "0x186710F00", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer FBFNLOOEGJA, RenderingData BCHFIEABLNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xC435F0", Offset = "0xC427F0", VA = "0x180C435F0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DAABPPDNPLN
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Mesh EJNBOMJLKNB;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x670E920", Offset = "0x670DB20", VA = "0x18670E920")]
	public static Mesh MFPABPCCDKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x670E9C0", Offset = "0x670DBC0", VA = "0x18670E9C0")]
	public static Matrix4x4 PCHMNMHOOCF(Camera KHMEBCFGGEJ, bool JNBBJBFBIDM = false, bool BJIGFLIMKJK = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x670E560", Offset = "0x670D760", VA = "0x18670E560")]
	private static Mesh HBLNECLGDHC()
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
