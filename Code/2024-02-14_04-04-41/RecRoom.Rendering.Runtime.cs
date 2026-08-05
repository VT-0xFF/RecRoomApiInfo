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
			[Cpp2IlInjected.Address(RVA = "0x64C92B0", Offset = "0x64C86B0", VA = "0x1864C92B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x64CB7D0", Offset = "0x64CABD0", VA = "0x1864CB7D0")]
			public MECBDPEMPBH(RenderPassEvent JMAEDHHMGPG, AOFJCLGNKBD ELPKMKBANCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x64CB3C0", Offset = "0x64CA7C0", VA = "0x1864CB3C0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x64C9650", Offset = "0x64C8A50", VA = "0x1864C9650")]
			public CPINPLJOGDP(RenderPassEvent JMAEDHHMGPG, AOFJCLGNKBD ELPKMKBANCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x64C9340", Offset = "0x64C8740", VA = "0x1864C9340", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x64C9B70", Offset = "0x64C8F70", VA = "0x1864C9B70", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x64C9AD0", Offset = "0x64C8ED0", VA = "0x1864C9AD0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AOCIMHKIBEA, RenderingData CKCGAPOBPJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB7D500", Offset = "0xB7C900", VA = "0x180B7D500")]
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
			[Cpp2IlInjected.Address(RVA = "0x64CB2E0", Offset = "0x64CA6E0", VA = "0x1864CB2E0")]
			public LHCBGDKKCLP(RenderPassEvent JMAEDHHMGPG, Material OODGJPECLJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x64CAF00", Offset = "0x64CA300", VA = "0x1864CAF00", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x64CBB80", Offset = "0x64CAF80", VA = "0x1864CBB80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x64CBB30", Offset = "0x64CAF30", VA = "0x1864CBB30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x64CB980", Offset = "0x64CAD80", VA = "0x1864CB980", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x64CB8B0", Offset = "0x64CACB0", VA = "0x1864CB8B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AOCIMHKIBEA, RenderingData CKCGAPOBPJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB7D500", Offset = "0xB7C900", VA = "0x180B7D500")]
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
			[Cpp2IlInjected.Address(RVA = "0x64C99F0", Offset = "0x64C8DF0", VA = "0x1864C99F0")]
			public DEOIIGLOHKH(RenderPassEvent JMAEDHHMGPG, Material OODGJPECLJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x64C9730", Offset = "0x64C8B30", VA = "0x1864C9730", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x64CBEB0", Offset = "0x64CB2B0", VA = "0x1864CBEB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x64CBD00", Offset = "0x64CB100", VA = "0x1864CBD00", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x64CBBE0", Offset = "0x64CAFE0", VA = "0x1864CBBE0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AOCIMHKIBEA, RenderingData CKCGAPOBPJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB7D500", Offset = "0xB7C900", VA = "0x180B7D500")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E58B0", Offset = "0x7E4CB0", VA = "0x1807E58B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer LIAHCIKAODA, ScriptableRenderContext PEHINKLIDNC, RenderingData CKCGAPOBPJL);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x79E360", Offset = "0x79D760", VA = "0x18079E360")]
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
			[Cpp2IlInjected.Address(RVA = "0x64CAE50", Offset = "0x64CA250", VA = "0x1864CAE50")]
			public IAILMNPFHCA(RenderPassEvent JMAEDHHMGPG, bool MCJMKIPLGEJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x64CA820", Offset = "0x64C9C20", VA = "0x1864CA820")]
			public bool AFECADFCBFO(CameraData KKDPKPACBFB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x64CABF0", Offset = "0x64C9FF0", VA = "0x1864CABF0", Slot = "9")]
			public override void Execute(ScriptableRenderContext PEHINKLIDNC, RenderingData CKCGAPOBPJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x64CAB10", Offset = "0x64C9F10", VA = "0x1864CAB10")]
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
		[Cpp2IlInjected.Address(RVA = "0x64CBFA0", Offset = "0x64CB3A0", VA = "0x1864CBFA0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x64CBF10", Offset = "0x64CB310", VA = "0x1864CBF10", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AOCIMHKIBEA, RenderingData CKCGAPOBPJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB7D500", Offset = "0xB7C900", VA = "0x180B7D500")]
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
		[Cpp2IlInjected.Address(RVA = "0x64CC1F0", Offset = "0x64CB5F0", VA = "0x1864CC1F0")]
		public static void DPPNEDHOIKP(ScriptableRenderPass KICIKOIIPEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x79E370", Offset = "0x79D770", VA = "0x18079E370", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x64CC050", Offset = "0x64CB450", VA = "0x1864CC050", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AOCIMHKIBEA, RenderingData CKCGAPOBPJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB7D500", Offset = "0xB7C900", VA = "0x180B7D500")]
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
	[Cpp2IlInjected.Address(RVA = "0x64CA770", Offset = "0x64C9B70", VA = "0x1864CA770")]
	public static Mesh KMHPPKIOJLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x64CA2D0", Offset = "0x64C96D0", VA = "0x1864CA2D0")]
	public static Matrix4x4 KJHAIGCGIKG(Camera KIIMCIJEHGL, bool EKPKKKDPCCD = false, bool FMOADOLIEFA = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x64C9F10", Offset = "0x64C9310", VA = "0x1864C9F10")]
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
