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
		private class NDIPGNFHNJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public bool PHMABBMCFMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly List<OGAOMBBGLHG> JLCFGALPNAK;

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x66D16D0", Offset = "0x66D08D0", VA = "0x1866D16D0")]
			public NDIPGNFHNJM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class BAADGGFKEGK : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly string MOLHKKGANEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly NDIPGNFHNJM BOKMNAFMJDA;

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x66CF5F0", Offset = "0x66CE7F0", VA = "0x1866CF5F0")]
			public BAADGGFKEGK(RenderPassEvent FIMMNPPPACF, NDIPGNFHNJM BOKMNAFMJDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x66CF1E0", Offset = "0x66CE3E0", VA = "0x1866CF1E0", Slot = "9")]
			public override void Execute(ScriptableRenderContext HFFDKMJEBIA, RenderingData JPLGBEHPJFI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class JCIOOLBBDDA : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private readonly string MOLHKKGANEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private readonly NDIPGNFHNJM BOKMNAFMJDA;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x66D0F90", Offset = "0x66D0190", VA = "0x1866D0F90")]
			public JCIOOLBBDDA(RenderPassEvent FIMMNPPPACF, NDIPGNFHNJM BOKMNAFMJDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x66D0C80", Offset = "0x66CFE80", VA = "0x1866D0C80", Slot = "9")]
			public override void Execute(ScriptableRenderContext HFFDKMJEBIA, RenderingData JPLGBEHPJFI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static List<OGAOMBBGLHG> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private BAADGGFKEGK fastLinesUpdatePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private JCIOOLBBDDA fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private NDIPGNFHNJM sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x66CFFD0", Offset = "0x66CF1D0", VA = "0x1866CFFD0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x66CFF30", Offset = "0x66CF130", VA = "0x1866CFF30", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HGMIPNBELIH, RenderingData JPLGBEHPJFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xC4D510", Offset = "0xC4C710", VA = "0x180C4D510")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface OGAOMBBGLHG
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NOFLPDPOLGK(CommandBuffer FJEHOOFEIOO, Camera BLHPIONNJCM, [NotNull] UniversalAdditionalCameraData BIOGPLGLMOC, bool PJPNFBPEAPL);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EAONCFBFOMM(Camera BLHPIONNJCM, CommandBuffer NAPIBEKLCGE);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Tooltip("RR Mobile Fade")]
	[DisallowMultipleRendererFeature(null)]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct NJBPIPMNNIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public float JGEHFGPEPFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public float ODOHLKCHCDC;
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class DFJBLFBNFNM : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private static readonly string BCKCEFFFPHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ProfilingSampler BHLLIPADNFE;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private static readonly int EHMNLIEFINP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private Material DFAPKPOJNDB;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x66CFAB0", Offset = "0x66CECB0", VA = "0x1866CFAB0")]
			public DFJBLFBNFNM(RenderPassEvent FIMMNPPPACF, Material FCJNMBKENDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x66CF6D0", Offset = "0x66CE8D0", VA = "0x1866CF6D0", Slot = "9")]
			public override void Execute(ScriptableRenderContext HFFDKMJEBIA, RenderingData JPLGBEHPJFI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static NJBPIPMNNIC CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private DFJBLFBNFNM m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x66D1340", Offset = "0x66D0540", VA = "0x1866D1340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x66D12F0", Offset = "0x66D04F0", VA = "0x1866D12F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x66D1140", Offset = "0x66D0340", VA = "0x1866D1140", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x66D1070", Offset = "0x66D0270", VA = "0x1866D1070", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HGMIPNBELIH, RenderingData JPLGBEHPJFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xC4D510", Offset = "0xC4C710", VA = "0x180C4D510")]
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
		public struct CJHBHLEBJIL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public float KDDGNKHHAGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Color MIKOAKCKJGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Mesh EOLIMBKIAIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AnimationCurve LHDHMOJOOFA;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public sealed class DKEPLEACAAN : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string BCKCEFFFPHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler BHLLIPADNFE;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int DFGBNAFHCLO;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly int BHHALANPBOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private Material DFAPKPOJNDB;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x66CFE50", Offset = "0x66CF050", VA = "0x1866CFE50")]
			public DKEPLEACAAN(RenderPassEvent FIMMNPPPACF, Material FCJNMBKENDK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x66CFB90", Offset = "0x66CED90", VA = "0x1866CFB90", Slot = "9")]
			public override void Execute(ScriptableRenderContext HFFDKMJEBIA, RenderingData JPLGBEHPJFI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static CJHBHLEBJIL CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private DKEPLEACAAN m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x66D1670", Offset = "0x66D0870", VA = "0x1866D1670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x66D14C0", Offset = "0x66D06C0", VA = "0x1866D14C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x66D13A0", Offset = "0x66D05A0", VA = "0x1866D13A0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HGMIPNBELIH, RenderingData JPLGBEHPJFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC4D510", Offset = "0xC4C710", VA = "0x180C4D510")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string DIIHFDAGEMO
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool ALBKEPOEHOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802CA0", VA = "0x180803AA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer NAPIBEKLCGE, ScriptableRenderContext HFFDKMJEBIA, RenderingData JPLGBEHPJFI);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7A0", Offset = "0x7BB9A0", VA = "0x1807BC7A0")]
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
		private class OLFBNCMCBFG : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private bool GHPJECDGBEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly List<PerCameraRenderEffect> AFLFHFOBBHK;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly List<PerCameraRenderEffect> EEDDBLKIOJM;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x66D1D90", Offset = "0x66D0F90", VA = "0x1866D1D90")]
			public OLFBNCMCBFG(RenderPassEvent FIMMNPPPACF, bool GHPJECDGBEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x66D1760", Offset = "0x66D0960", VA = "0x1866D1760")]
			public bool BCMMBBGMEHK(CameraData BIOGPLGLMOC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x66D1A50", Offset = "0x66D0C50", VA = "0x1866D1A50", Slot = "9")]
			public override void Execute(ScriptableRenderContext HFFDKMJEBIA, RenderingData JPLGBEHPJFI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x66D1C20", Offset = "0x66D0E20", VA = "0x1866D1C20")]
			private void JBHGOAINHGJ(PerCameraRenderEffect HCHLCGIFKDM, ScriptableRenderContext HFFDKMJEBIA, RenderingData JPLGBEHPJFI)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private OLFBNCMCBFG m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private OLFBNCMCBFG m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x66D1ED0", Offset = "0x66D10D0", VA = "0x1866D1ED0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x66D1E40", Offset = "0x66D1040", VA = "0x1866D1E40", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HGMIPNBELIH, RenderingData JPLGBEHPJFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xC4D510", Offset = "0xC4C710", VA = "0x180C4D510")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D2120", Offset = "0x66D1320", VA = "0x1866D2120")]
		public static void MKMBIFAJJGI(ScriptableRenderPass KPDGPHHHKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7BC7B0", Offset = "0x7BB9B0", VA = "0x1807BC7B0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x66D1F80", Offset = "0x66D1180", VA = "0x1866D1F80", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer HGMIPNBELIH, RenderingData JPLGBEHPJFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xC4D510", Offset = "0xC4C710", VA = "0x180C4D510")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class IOGDKEILEIC
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Mesh ECEEENFJAKJ;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x66D0BD0", Offset = "0x66CFDD0", VA = "0x1866D0BD0")]
	public static Mesh PBKEDHOJIMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x66D0730", Offset = "0x66CF930", VA = "0x1866D0730")]
	public static Matrix4x4 NMJMDAGBDCD(Camera BLHPIONNJCM, bool OHMEKKHEJAF = false, bool IHCHOMIGEDK = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x66D0370", Offset = "0x66CF570", VA = "0x1866D0370")]
	private static Mesh MAJBPOIFBPI()
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
