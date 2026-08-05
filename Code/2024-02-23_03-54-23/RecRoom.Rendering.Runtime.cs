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
		private class AOFJCLGNKBD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public bool KBKKDKKCGFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly List<GNGBCLIKCIN> FJEDDBBLMAO;

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x65434D0", Offset = "0x6541ED0", VA = "0x1865434D0")]
			public AOFJCLGNKBD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class MECBDPEMPBH : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly string BAFNIJKNIFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly AOFJCLGNKBD ELPKMKBANCD;

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x65459F0", Offset = "0x65443F0", VA = "0x1865459F0")]
			public MECBDPEMPBH(RenderPassEvent JMAEDHHMGPG, AOFJCLGNKBD ELPKMKBANCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x65455E0", Offset = "0x6543FE0", VA = "0x1865455E0", Slot = "9")]
			public override void Execute(ScriptableRenderContext PEHINKLIDNC, RenderingData CKCGAPOBPJL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class CPINPLJOGDP : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private readonly string BAFNIJKNIFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private readonly AOFJCLGNKBD ELPKMKBANCD;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6543870", Offset = "0x6542270", VA = "0x186543870")]
			public CPINPLJOGDP(RenderPassEvent JMAEDHHMGPG, AOFJCLGNKBD ELPKMKBANCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6543560", Offset = "0x6541F60", VA = "0x186543560", Slot = "9")]
			public override void Execute(ScriptableRenderContext PEHINKLIDNC, RenderingData CKCGAPOBPJL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static List<GNGBCLIKCIN> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private MECBDPEMPBH fastLinesUpdatePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private CPINPLJOGDP fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private AOFJCLGNKBD sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6543D90", Offset = "0x6542790", VA = "0x186543D90", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6543CF0", Offset = "0x65426F0", VA = "0x186543CF0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AOCIMHKIBEA, RenderingData CKCGAPOBPJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB89370", Offset = "0xB87D70", VA = "0x180B89370")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GNGBCLIKCIN
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AFHAHLMAPBI(CommandBuffer KEOLOMLLFKJ, Camera KIIMCIJEHGL, [NotNull] UniversalAdditionalCameraData KKDPKPACBFB, bool IFNOOPOEALP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PJPAILCJPBB(Camera KIIMCIJEHGL, CommandBuffer LIAHCIKAODA);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Tooltip("RR Mobile Fade")]
	[DisallowMultipleRendererFeature(null)]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct KLDKBDDKKCB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public float PLGDNHHKCFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public float NMMBBKFMNBP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class LHCBGDKKCLP : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private static readonly string GCNKAKKLCOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ProfilingSampler MFLDGLCMIBJ;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private static readonly int MCGJILFJJLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private Material FIMGAOOMGLB;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6545500", Offset = "0x6543F00", VA = "0x186545500")]
			public LHCBGDKKCLP(RenderPassEvent JMAEDHHMGPG, Material OODGJPECLJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6545120", Offset = "0x6543B20", VA = "0x186545120", Slot = "9")]
			public override void Execute(ScriptableRenderContext PEHINKLIDNC, RenderingData CKCGAPOBPJL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static KLDKBDDKKCB CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private LHCBGDKKCLP m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x6545DA0", Offset = "0x65447A0", VA = "0x186545DA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x6545D50", Offset = "0x6544750", VA = "0x186545D50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6545BA0", Offset = "0x65445A0", VA = "0x186545BA0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6545AD0", Offset = "0x65444D0", VA = "0x186545AD0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AOCIMHKIBEA, RenderingData CKCGAPOBPJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB89370", Offset = "0xB87D70", VA = "0x180B89370")]
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
		public struct OFPPBDINDCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public float MLOFCPIBEBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Color COLAMLGDOIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Mesh EPHJAOEGBMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AnimationCurve LLHDMDGPBKM;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public sealed class DEOIIGLOHKH : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string GCNKAKKLCOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler MFLDGLCMIBJ;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int MKHNCIPEMJH;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly int LBOJFANECCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private Material FIMGAOOMGLB;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6543C10", Offset = "0x6542610", VA = "0x186543C10")]
			public DEOIIGLOHKH(RenderPassEvent JMAEDHHMGPG, Material OODGJPECLJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6543950", Offset = "0x6542350", VA = "0x186543950", Slot = "9")]
			public override void Execute(ScriptableRenderContext PEHINKLIDNC, RenderingData CKCGAPOBPJL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static OFPPBDINDCA CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private DEOIIGLOHKH m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x65460D0", Offset = "0x6544AD0", VA = "0x1865460D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6545F20", Offset = "0x6544920", VA = "0x186545F20", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6545E00", Offset = "0x6544800", VA = "0x186545E00", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AOCIMHKIBEA, RenderingData CKCGAPOBPJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB89370", Offset = "0xB87D70", VA = "0x180B89370")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string BCDJEPBGKJB
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool PPNCBKJPALC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7EF8B0", Offset = "0x7EE2B0", VA = "0x1807EF8B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer LIAHCIKAODA, ScriptableRenderContext PEHINKLIDNC, RenderingData CKCGAPOBPJL);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7A8360", Offset = "0x7A6D60", VA = "0x1807A8360")]
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
		private class IAILMNPFHCA : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private bool MCJMKIPLGEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly List<PerCameraRenderEffect> NIADCAEFFLB;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly List<PerCameraRenderEffect> KIGMGEBEEKB;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6545070", Offset = "0x6543A70", VA = "0x186545070")]
			public IAILMNPFHCA(RenderPassEvent JMAEDHHMGPG, bool MCJMKIPLGEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6544A40", Offset = "0x6543440", VA = "0x186544A40")]
			public bool AFECADFCBFO(CameraData KKDPKPACBFB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6544E10", Offset = "0x6543810", VA = "0x186544E10", Slot = "9")]
			public override void Execute(ScriptableRenderContext PEHINKLIDNC, RenderingData CKCGAPOBPJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6544D30", Offset = "0x6543730", VA = "0x186544D30")]
			private void CAONOBDMPEM(PerCameraRenderEffect NKNPLBPOHIG, ScriptableRenderContext PEHINKLIDNC, RenderingData CKCGAPOBPJL)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private IAILMNPFHCA m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private IAILMNPFHCA m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x65461C0", Offset = "0x6544BC0", VA = "0x1865461C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6546130", Offset = "0x6544B30", VA = "0x186546130", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AOCIMHKIBEA, RenderingData CKCGAPOBPJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB89370", Offset = "0xB87D70", VA = "0x180B89370")]
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
		[Cpp2IlInjected.Address(RVA = "0x6546410", Offset = "0x6544E10", VA = "0x186546410")]
		public static void DPPNEDHOIKP(ScriptableRenderPass KICIKOIIPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7A8370", Offset = "0x7A6D70", VA = "0x1807A8370", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6546270", Offset = "0x6544C70", VA = "0x186546270", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AOCIMHKIBEA, RenderingData CKCGAPOBPJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB89370", Offset = "0xB87D70", VA = "0x180B89370")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class HPNNJKOFMPF
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Mesh KKCFCAKECJF;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6544990", Offset = "0x6543390", VA = "0x186544990")]
	public static Mesh KMHPPKIOJLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x65444F0", Offset = "0x6542EF0", VA = "0x1865444F0")]
	public static Matrix4x4 KJHAIGCGIKG(Camera KIIMCIJEHGL, bool EKPKKKDPCCD = false, bool FMOADOLIEFA = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6544130", Offset = "0x6542B30", VA = "0x186544130")]
	private static Mesh EECIJBFHACM()
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
