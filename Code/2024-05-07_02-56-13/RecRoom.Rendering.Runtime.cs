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
		private class POBACLBFOAE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public bool OMPLBFBDEHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly List<CDNFHDDPKAL> CIAHDLJBNHJ;

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x67D2670", Offset = "0x67D1870", VA = "0x1867D2670")]
			public POBACLBFOAE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class MNLLFKCDCKN : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly string CJFBMCHDILN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly POBACLBFOAE FOEGBJCPPLN;

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x67D0F90", Offset = "0x67D0190", VA = "0x1867D0F90")]
			public MNLLFKCDCKN(RenderPassEvent NPNJKIAOAJE, POBACLBFOAE FOEGBJCPPLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x67D0B80", Offset = "0x67CFD80", VA = "0x1867D0B80", Slot = "9")]
			public override void Execute(ScriptableRenderContext KAEEGPAIBEC, RenderingData JHNOMFMDOBH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class BJDOKCHLMFB : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private readonly string CJFBMCHDILN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private readonly POBACLBFOAE FOEGBJCPPLN;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x67D02E0", Offset = "0x67CF4E0", VA = "0x1867D02E0")]
			public BJDOKCHLMFB(RenderPassEvent NPNJKIAOAJE, POBACLBFOAE FOEGBJCPPLN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x67CFFD0", Offset = "0x67CF1D0", VA = "0x1867CFFD0", Slot = "9")]
			public override void Execute(ScriptableRenderContext KAEEGPAIBEC, RenderingData JHNOMFMDOBH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static List<CDNFHDDPKAL> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private MNLLFKCDCKN fastLinesUpdatePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private BJDOKCHLMFB fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private POBACLBFOAE sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x67D07E0", Offset = "0x67CF9E0", VA = "0x1867D07E0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x67D0740", Offset = "0x67CF940", VA = "0x1867D0740", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CPHKADKGBCP, RenderingData JHNOMFMDOBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xC574D0", Offset = "0xC566D0", VA = "0x180C574D0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface CDNFHDDPKAL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CLNNCFMPMMK(CommandBuffer IJOJEFEBLLE, Camera MGLCFKEMOED, [NotNull] UniversalAdditionalCameraData HJLGOOJIBCC, bool KBKHGJLBFFF);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMFLGHOFNGA(Camera MGLCFKEMOED, CommandBuffer PJBGKGJIDOO);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Tooltip("RR Mobile Fade")]
	[DisallowMultipleRendererFeature(null)]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct CKLJHDNICEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public float AKLKIMNFDCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public float AIFKMKEDLAA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class BGGFPANMJIC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private static readonly string OKFBHFPILJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ProfilingSampler ABPNJDFIDBD;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private static readonly int DAGEABLJKEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private Material ELNILFEKIBH;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x67CFEF0", Offset = "0x67CF0F0", VA = "0x1867CFEF0")]
			public BGGFPANMJIC(RenderPassEvent NPNJKIAOAJE, Material PEGNOKKFPLO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x67CFB20", Offset = "0x67CED20", VA = "0x1867CFB20", Slot = "9")]
			public override void Execute(ScriptableRenderContext KAEEGPAIBEC, RenderingData JHNOMFMDOBH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static CKLJHDNICEC CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private BGGFPANMJIC m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x67D1340", Offset = "0x67D0540", VA = "0x1867D1340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x67D12F0", Offset = "0x67D04F0", VA = "0x1867D12F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x67D1140", Offset = "0x67D0340", VA = "0x1867D1140", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x67D1070", Offset = "0x67D0270", VA = "0x1867D1070", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CPHKADKGBCP, RenderingData JHNOMFMDOBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xC574D0", Offset = "0xC566D0", VA = "0x180C574D0")]
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
		public struct HHINLDLHNJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public float LLOHKGPCEMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Color OEAIKDKHGEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Mesh ADDMLLLLJJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AnimationCurve LGHEBIPJBDC;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public sealed class EIJAJPHFEMN : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string OKFBHFPILJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler ABPNJDFIDBD;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int NLOGAGFCGBL;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly int IBOEJADFNIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private Material ELNILFEKIBH;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x67D0660", Offset = "0x67CF860", VA = "0x1867D0660")]
			public EIJAJPHFEMN(RenderPassEvent NPNJKIAOAJE, Material PEGNOKKFPLO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x67D03C0", Offset = "0x67CF5C0", VA = "0x1867D03C0", Slot = "9")]
			public override void Execute(ScriptableRenderContext KAEEGPAIBEC, RenderingData JHNOMFMDOBH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static HHINLDLHNJA CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private EIJAJPHFEMN m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x67D1650", Offset = "0x67D0850", VA = "0x1867D1650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x67D14A0", Offset = "0x67D06A0", VA = "0x1867D14A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x67D1390", Offset = "0x67D0590", VA = "0x1867D1390", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CPHKADKGBCP, RenderingData JHNOMFMDOBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC574D0", Offset = "0xC566D0", VA = "0x180C574D0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string CIKIKMLKIMK
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool LMMHBCICFGM
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer PJBGKGJIDOO, ScriptableRenderContext KAEEGPAIBEC, RenderingData JHNOMFMDOBH);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7B45D0", Offset = "0x7B37D0", VA = "0x1807B45D0")]
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
		private class NHIPHGBPBHL : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private bool HHMDKLHIBCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly List<PerCameraRenderEffect> FNLHFGOADKL;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly List<PerCameraRenderEffect> PGOIMFPNPHA;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x67D1CC0", Offset = "0x67D0EC0", VA = "0x1867D1CC0")]
			public NHIPHGBPBHL(RenderPassEvent NPNJKIAOAJE, bool HHMDKLHIBCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x67D1950", Offset = "0x67D0B50", VA = "0x1867D1950")]
			public bool OMAGFCIJMBF(CameraData HJLGOOJIBCC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x67D16A0", Offset = "0x67D08A0", VA = "0x1867D16A0", Slot = "9")]
			public override void Execute(ScriptableRenderContext KAEEGPAIBEC, RenderingData JHNOMFMDOBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x67D1870", Offset = "0x67D0A70", VA = "0x1867D1870")]
			private void JAHLEFAGFFH(PerCameraRenderEffect DBOEAAPJOHM, ScriptableRenderContext KAEEGPAIBEC, RenderingData JHNOMFMDOBH)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NHIPHGBPBHL m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private NHIPHGBPBHL m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x67D2790", Offset = "0x67D1990", VA = "0x1867D2790", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x67D2700", Offset = "0x67D1900", VA = "0x1867D2700", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CPHKADKGBCP, RenderingData JHNOMFMDOBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xC574D0", Offset = "0xC566D0", VA = "0x180C574D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67D29E0", Offset = "0x67D1BE0", VA = "0x1867D29E0")]
		public static void JFFGDJIBGBJ(ScriptableRenderPass IDAANCMNHKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67D2840", Offset = "0x67D1A40", VA = "0x1867D2840", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CPHKADKGBCP, RenderingData JHNOMFMDOBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xC574D0", Offset = "0xC566D0", VA = "0x180C574D0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PEPDOBBIKDC
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Mesh CMLBDPINHOA;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x67D25D0", Offset = "0x67D17D0", VA = "0x1867D25D0")]
	public static Mesh KOJMOHIPEAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x67D2130", Offset = "0x67D1330", VA = "0x1867D2130")]
	public static Matrix4x4 KMFIOHIDCGO(Camera MGLCFKEMOED, bool GPPKJEEAJNC = false, bool OGPFADBJIKB = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x67D1D70", Offset = "0x67D0F70", VA = "0x1867D1D70")]
	private static Mesh JMIBKCNIFHH()
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
