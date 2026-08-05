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
		private class EFIFLJAMGMC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public bool HEGOMFDLPMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly List<DOOOLGNPBNL> DDFEJPBKMIG;

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x65DA090", Offset = "0x65D9490", VA = "0x1865DA090")]
			public EFIFLJAMGMC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class KDCKPOEIMON : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly string ILHIJCBCBIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly EFIFLJAMGMC AHOAAFMMAOL;

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x65DBD00", Offset = "0x65DB100", VA = "0x1865DBD00")]
			public KDCKPOEIMON(RenderPassEvent NDBBAACHBCD, EFIFLJAMGMC AHOAAFMMAOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x65DB8F0", Offset = "0x65DACF0", VA = "0x1865DB8F0", Slot = "9")]
			public override void Execute(ScriptableRenderContext AOGDICEMNLI, RenderingData IIOFEEBNMNK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class OFBHBAKMOAP : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private readonly string ILHIJCBCBIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private readonly EFIFLJAMGMC AHOAAFMMAOL;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x65DCC10", Offset = "0x65DC010", VA = "0x1865DCC10")]
			public OFBHBAKMOAP(RenderPassEvent NDBBAACHBCD, EFIFLJAMGMC AHOAAFMMAOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x65DC900", Offset = "0x65DBD00", VA = "0x1865DC900", Slot = "9")]
			public override void Execute(ScriptableRenderContext AOGDICEMNLI, RenderingData IIOFEEBNMNK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static List<DOOOLGNPBNL> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private KDCKPOEIMON fastLinesUpdatePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private OFBHBAKMOAP fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EFIFLJAMGMC sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x65DA8A0", Offset = "0x65D9CA0", VA = "0x1865DA8A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x65DA800", Offset = "0x65D9C00", VA = "0x1865DA800", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MADIDHJDPOK, RenderingData IIOFEEBNMNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB81500", Offset = "0xB80900", VA = "0x180B81500")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface DOOOLGNPBNL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BNOPOMDBGLM(CommandBuffer GCKIHMFLIHP, Camera KABJBFEEANH, [NotNull] UniversalAdditionalCameraData ACBNJLPCHFC, bool BICELCPJLOH);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MOLIFIGHDFP(Camera KABJBFEEANH, CommandBuffer NEJDMALKOPM);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Tooltip("RR Mobile Fade")]
	[DisallowMultipleRendererFeature(null)]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct JCKDFJOPNFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public float APBFHFHGBKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public float FICFNNPLNNO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class MHLCIOJMPCF : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private static readonly string FNJCMMAAJHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ProfilingSampler IPKJMLIFDMG;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private static readonly int MHNMCNKLKHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private Material DFJHPEAJAMF;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x65DC1C0", Offset = "0x65DB5C0", VA = "0x1865DC1C0")]
			public MHLCIOJMPCF(RenderPassEvent NDBBAACHBCD, Material DELNJNDMHJJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x65DBDE0", Offset = "0x65DB1E0", VA = "0x1865DBDE0", Slot = "9")]
			public override void Execute(ScriptableRenderContext AOGDICEMNLI, RenderingData IIOFEEBNMNK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static JCKDFJOPNFF CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private MHLCIOJMPCF m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x65DC570", Offset = "0x65DB970", VA = "0x1865DC570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x65DC520", Offset = "0x65DB920", VA = "0x1865DC520")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x65DC370", Offset = "0x65DB770", VA = "0x1865DC370", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x65DC2A0", Offset = "0x65DB6A0", VA = "0x1865DC2A0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MADIDHJDPOK, RenderingData IIOFEEBNMNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB81500", Offset = "0xB80900", VA = "0x180B81500")]
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
		public struct KCOPBEDLGFH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public float BANICBAGBHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Color LODMMDMDHHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Mesh DPLFOHFHLOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AnimationCurve PHMIFEBOOAB;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public sealed class IFJFDCLBLLI : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string FNJCMMAAJHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler IPKJMLIFDMG;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int GHFBPBBMKIC;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly int JCDBACAJHFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private Material DFJHPEAJAMF;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x65DAF00", Offset = "0x65DA300", VA = "0x1865DAF00")]
			public IFJFDCLBLLI(RenderPassEvent NDBBAACHBCD, Material DELNJNDMHJJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x65DAC40", Offset = "0x65DA040", VA = "0x1865DAC40", Slot = "9")]
			public override void Execute(ScriptableRenderContext AOGDICEMNLI, RenderingData IIOFEEBNMNK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static KCOPBEDLGFH CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private IFJFDCLBLLI m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x65DC8A0", Offset = "0x65DBCA0", VA = "0x1865DC8A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x65DC6F0", Offset = "0x65DBAF0", VA = "0x1865DC6F0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x65DC5D0", Offset = "0x65DB9D0", VA = "0x1865DC5D0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MADIDHJDPOK, RenderingData IIOFEEBNMNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB81500", Offset = "0xB80900", VA = "0x180B81500")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string ODAHBBKNLJA
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool DLFBNFOCIPI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7D85C0", Offset = "0x7D79C0", VA = "0x1807D85C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer NEJDMALKOPM, ScriptableRenderContext AOGDICEMNLI, RenderingData IIOFEEBNMNK);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x791430", Offset = "0x790830", VA = "0x180791430")]
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
		private class FIFHFMEMCCA : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private bool EDJPIHHBIEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly List<PerCameraRenderEffect> FLGLALKFOEK;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly List<PerCameraRenderEffect> LAMHNGCBNEL;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x65DA750", Offset = "0x65D9B50", VA = "0x1865DA750")]
			public FIFHFMEMCCA(RenderPassEvent NDBBAACHBCD, bool EDJPIHHBIEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x65DA3D0", Offset = "0x65D97D0", VA = "0x1865DA3D0")]
			public bool PCDJBGDBGMD(CameraData ACBNJLPCHFC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x65DA200", Offset = "0x65D9600", VA = "0x1865DA200", Slot = "9")]
			public override void Execute(ScriptableRenderContext AOGDICEMNLI, RenderingData IIOFEEBNMNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x65DA120", Offset = "0x65D9520", VA = "0x1865DA120")]
			private void DGHNPIONBCN(PerCameraRenderEffect JOBNDICGFGK, ScriptableRenderContext AOGDICEMNLI, RenderingData IIOFEEBNMNK)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private FIFHFMEMCCA m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private FIFHFMEMCCA m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x65DCD80", Offset = "0x65DC180", VA = "0x1865DCD80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x65DCCF0", Offset = "0x65DC0F0", VA = "0x1865DCCF0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MADIDHJDPOK, RenderingData IIOFEEBNMNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB81500", Offset = "0xB80900", VA = "0x180B81500")]
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
		[Cpp2IlInjected.Address(RVA = "0x65DCFD0", Offset = "0x65DC3D0", VA = "0x1865DCFD0")]
		public static void FGPAEHBIKJB(ScriptableRenderPass DGPMKCGDONJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x791440", Offset = "0x790840", VA = "0x180791440", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x65DCE30", Offset = "0x65DC230", VA = "0x1865DCE30", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MADIDHJDPOK, RenderingData IIOFEEBNMNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB81500", Offset = "0xB80900", VA = "0x180B81500")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class INEJGNFHHNB
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Mesh KLKFBJMIBEM;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x65DAFE0", Offset = "0x65DA3E0", VA = "0x1865DAFE0")]
	public static Mesh JNDHMKHLJDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x65DB450", Offset = "0x65DA850", VA = "0x1865DB450")]
	public static Matrix4x4 OPLCBFIKING(Camera KABJBFEEANH, bool CJAKNPFMALG = false, bool CAIJLAAODOE = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x65DB090", Offset = "0x65DA490", VA = "0x1865DB090")]
	private static Mesh KLCMHEIMPEE()
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
