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
		private class DCEFOKKFJPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public bool GKGLHHOIFME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly List<HMLOEEPDOLJ> IBLEAGDABCH;

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x67FA740", Offset = "0x67F9540", VA = "0x1867FA740")]
			public DCEFOKKFJPL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class EJEPCJHIOII : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly string LJHMABKNALB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly DCEFOKKFJPL FLBEKDLHAGK;

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x67FB2B0", Offset = "0x67FA0B0", VA = "0x1867FB2B0")]
			public EJEPCJHIOII(RenderPassEvent LCGCKDGPHNK, DCEFOKKFJPL FLBEKDLHAGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x67FAEA0", Offset = "0x67F9CA0", VA = "0x1867FAEA0", Slot = "9")]
			public override void Execute(ScriptableRenderContext EJDIFPAIGMC, RenderingData GNJCFNHOOAA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class JOMDHFCBLGL : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private readonly string LJHMABKNALB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private readonly DCEFOKKFJPL FLBEKDLHAGK;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x67FC760", Offset = "0x67FB560", VA = "0x1867FC760")]
			public JOMDHFCBLGL(RenderPassEvent LCGCKDGPHNK, DCEFOKKFJPL FLBEKDLHAGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x67FC450", Offset = "0x67FB250", VA = "0x1867FC450", Slot = "9")]
			public override void Execute(ScriptableRenderContext EJDIFPAIGMC, RenderingData GNJCFNHOOAA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static List<HMLOEEPDOLJ> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private EJEPCJHIOII fastLinesUpdatePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private JOMDHFCBLGL fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private DCEFOKKFJPL sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x67FB430", Offset = "0x67FA230", VA = "0x1867FB430", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x67FB390", Offset = "0x67FA190", VA = "0x1867FB390", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer INJBJDLKFFP, RenderingData GNJCFNHOOAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xC415E0", Offset = "0xC403E0", VA = "0x180C415E0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface HMLOEEPDOLJ
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OEHNAKKOHIK(CommandBuffer OOHEJPNDMEM, Camera KOABNEBFIJD, [NotNull] UniversalAdditionalCameraData BKGLNMHFHDI, bool JHINBFGJDKN);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GGNKDPHFDNP(Camera KOABNEBFIJD, CommandBuffer FBKEAHLHJDD);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Tooltip("RR Mobile Fade")]
	[DisallowMultipleRendererFeature(null)]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct IIDNIBOAIOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public float LKJHOGPGAKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public float MCKLJMLFHLD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class MJEJAPEEFEA : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private static readonly string IJIBOKPHLAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ProfilingSampler ODIFHIDPMDC;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private static readonly int NPMGFDKFDHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private Material HIELHFCNMLL;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x67FCC10", Offset = "0x67FBA10", VA = "0x1867FCC10")]
			public MJEJAPEEFEA(RenderPassEvent LCGCKDGPHNK, Material LKFHNDFBKCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x67FC840", Offset = "0x67FB640", VA = "0x1867FC840", Slot = "9")]
			public override void Execute(ScriptableRenderContext EJDIFPAIGMC, RenderingData GNJCFNHOOAA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static IIDNIBOAIOB CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private MJEJAPEEFEA m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x67FCFC0", Offset = "0x67FBDC0", VA = "0x1867FCFC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x67FCF70", Offset = "0x67FBD70", VA = "0x1867FCF70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x67FCDC0", Offset = "0x67FBBC0", VA = "0x1867FCDC0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x67FCCF0", Offset = "0x67FBAF0", VA = "0x1867FCCF0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer INJBJDLKFFP, RenderingData GNJCFNHOOAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xC415E0", Offset = "0xC403E0", VA = "0x180C415E0")]
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
		public struct DAHMHNALNDJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public float PABBGAOKMCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Color KPCIOMDEDGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Mesh EFDHEIEGICC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AnimationCurve KCIGLGNIAGM;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public sealed class GCLLOHGAONN : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string IJIBOKPHLAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler ODIFHIDPMDC;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int MOEFBLJEBHN;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly int FMJOLEMHJBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private Material HIELHFCNMLL;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x67FC370", Offset = "0x67FB170", VA = "0x1867FC370")]
			public GCLLOHGAONN(RenderPassEvent LCGCKDGPHNK, Material LKFHNDFBKCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x67FC0D0", Offset = "0x67FAED0", VA = "0x1867FC0D0", Slot = "9")]
			public override void Execute(ScriptableRenderContext EJDIFPAIGMC, RenderingData GNJCFNHOOAA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static DAHMHNALNDJ CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private GCLLOHGAONN m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x67FD2D0", Offset = "0x67FC0D0", VA = "0x1867FD2D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x67FD120", Offset = "0x67FBF20", VA = "0x1867FD120", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x67FD010", Offset = "0x67FBE10", VA = "0x1867FD010", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer INJBJDLKFFP, RenderingData GNJCFNHOOAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC415E0", Offset = "0xC403E0", VA = "0x180C415E0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string PPGAPMBDGEA
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool JDAAKLOIHHL
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer FBKEAHLHJDD, ScriptableRenderContext EJDIFPAIGMC, RenderingData GNJCFNHOOAA);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0790", Offset = "0x7AF590", VA = "0x1807B0790")]
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
		private class EDFNILOKIAI : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private bool IAGPMIKJMMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly List<PerCameraRenderEffect> JLDMEKHFEHF;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly List<PerCameraRenderEffect> ANINMBCOOGJ;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x67FADF0", Offset = "0x67F9BF0", VA = "0x1867FADF0")]
			public EDFNILOKIAI(RenderPassEvent LCGCKDGPHNK, bool IAGPMIKJMMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x67FA7D0", Offset = "0x67F95D0", VA = "0x1867FA7D0")]
			public bool EMKMCINDNGE(CameraData BKGLNMHFHDI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x67FAAB0", Offset = "0x67F98B0", VA = "0x1867FAAB0", Slot = "9")]
			public override void Execute(ScriptableRenderContext EJDIFPAIGMC, RenderingData GNJCFNHOOAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x67FAC80", Offset = "0x67F9A80", VA = "0x1867FAC80")]
			private void KMHGEEAHBKE(PerCameraRenderEffect IJFLFIEGMCL, ScriptableRenderContext EJDIFPAIGMC, RenderingData GNJCFNHOOAA)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private EDFNILOKIAI m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private EDFNILOKIAI m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x67FD3B0", Offset = "0x67FC1B0", VA = "0x1867FD3B0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67FD320", Offset = "0x67FC120", VA = "0x1867FD320", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer INJBJDLKFFP, RenderingData GNJCFNHOOAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xC415E0", Offset = "0xC403E0", VA = "0x180C415E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FD600", Offset = "0x67FC400", VA = "0x1867FD600")]
		public static void BLCAMCMHIBJ(ScriptableRenderPass HJIBLEGMOLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67FD460", Offset = "0x67FC260", VA = "0x1867FD460", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer INJBJDLKFFP, RenderingData GNJCFNHOOAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xC415E0", Offset = "0xC403E0", VA = "0x180C415E0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GCCBJFLCLAC
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Mesh GOHJAIMJIBC;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x67FBB90", Offset = "0x67FA990", VA = "0x1867FBB90")]
	public static Mesh KFJMNFCDEGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67FBC30", Offset = "0x67FAA30", VA = "0x1867FBC30")]
	public static Matrix4x4 NKAONKEKHKO(Camera KOABNEBFIJD, bool PFLDEPMPDFK = false, bool DFPLNBLAPDG = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x67FB7D0", Offset = "0x67FA5D0", VA = "0x1867FB7D0")]
	private static Mesh KEIEDJFEJKJ()
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
