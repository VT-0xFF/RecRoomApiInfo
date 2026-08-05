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
		private class EBFDOLHNNKD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public bool LABMBNFHGNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly List<LCKIAGOLNKH> CDAMBFIDCNN;

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x66E7450", Offset = "0x66E6050", VA = "0x1866E7450")]
			public EBFDOLHNNKD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class CFNAGBNCENK : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly string AMNMPNNOODN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly EBFDOLHNNKD MKLIEKDPHKI;

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x66E7370", Offset = "0x66E5F70", VA = "0x1866E7370")]
			public CFNAGBNCENK(RenderPassEvent FDALHPGOKGK, EBFDOLHNNKD MKLIEKDPHKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x66E6F60", Offset = "0x66E5B60", VA = "0x1866E6F60", Slot = "9")]
			public override void Execute(ScriptableRenderContext LAMCDJBBCDK, RenderingData OBAGCOGAIIC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class PPHDIKMPFME : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private readonly string AMNMPNNOODN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private readonly EBFDOLHNNKD MKLIEKDPHKI;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x66E9400", Offset = "0x66E8000", VA = "0x1866E9400")]
			public PPHDIKMPFME(RenderPassEvent FDALHPGOKGK, EBFDOLHNNKD MKLIEKDPHKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x66E90F0", Offset = "0x66E7CF0", VA = "0x1866E90F0", Slot = "9")]
			public override void Execute(ScriptableRenderContext LAMCDJBBCDK, RenderingData OBAGCOGAIIC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static List<LCKIAGOLNKH> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private CFNAGBNCENK fastLinesUpdatePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private PPHDIKMPFME fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EBFDOLHNNKD sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x66E7A40", Offset = "0x66E6640", VA = "0x1866E7A40", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x66E79A0", Offset = "0x66E65A0", VA = "0x1866E79A0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AFGILNBALBJ, RenderingData OBAGCOGAIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xC4B8D0", Offset = "0xC4A4D0", VA = "0x180C4B8D0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LCKIAGOLNKH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CANDJLEMBJG(CommandBuffer FBKJNKJFPFC, Camera JGPDJKGMCDE, [NotNull] UniversalAdditionalCameraData PHJCENNACJF, bool BLLAEBIHIPO);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KJPECGHHCKO(Camera JGPDJKGMCDE, CommandBuffer NENBHEDFPEL);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Tooltip("RR Mobile Fade")]
	[DisallowMultipleRendererFeature(null)]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct LFOFOMALBEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public float BHMFBGJHNMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public float NOCJBBDAONM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class EONDIAKGBBK : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private static readonly string HKIGHPCHBCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ProfilingSampler LONNNHADKLM;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private static readonly int IGGJHLMLPDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private Material AHJECKEIBHI;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x66E78C0", Offset = "0x66E64C0", VA = "0x1866E78C0")]
			public EONDIAKGBBK(RenderPassEvent FDALHPGOKGK, Material PKJODJFPANA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x66E74E0", Offset = "0x66E60E0", VA = "0x1866E74E0", Slot = "9")]
			public override void Execute(ScriptableRenderContext LAMCDJBBCDK, RenderingData OBAGCOGAIIC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static LFOFOMALBEN CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private EONDIAKGBBK m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x66E8450", Offset = "0x66E7050", VA = "0x1866E8450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x66E8400", Offset = "0x66E7000", VA = "0x1866E8400")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x66E8250", Offset = "0x66E6E50", VA = "0x1866E8250", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x66E8180", Offset = "0x66E6D80", VA = "0x1866E8180", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AFGILNBALBJ, RenderingData OBAGCOGAIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xC4B8D0", Offset = "0xC4A4D0", VA = "0x180C4B8D0")]
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
		public struct GHMNBMAMAFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public float FONIHMHLJHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Color KFIEHBOPAAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Mesh KMDFCAGGFBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AnimationCurve JMHGFLABCEN;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public sealed class LAGCPGJPGIG : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string HKIGHPCHBCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler LONNNHADKLM;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int JFKJPDGLALP;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly int PKFFEJDJNHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private Material AHJECKEIBHI;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x66E80A0", Offset = "0x66E6CA0", VA = "0x1866E80A0")]
			public LAGCPGJPGIG(RenderPassEvent FDALHPGOKGK, Material PKJODJFPANA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x66E7DE0", Offset = "0x66E69E0", VA = "0x1866E7DE0", Slot = "9")]
			public override void Execute(ScriptableRenderContext LAMCDJBBCDK, RenderingData OBAGCOGAIIC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static GHMNBMAMAFG CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private LAGCPGJPGIG m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x66E8780", Offset = "0x66E7380", VA = "0x1866E8780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x66E85D0", Offset = "0x66E71D0", VA = "0x1866E85D0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x66E84B0", Offset = "0x66E70B0", VA = "0x1866E84B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AFGILNBALBJ, RenderingData OBAGCOGAIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC4B8D0", Offset = "0xC4A4D0", VA = "0x180C4B8D0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string PILJBNINPML
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool GFJPDDKHOAK
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7F8B30", Offset = "0x7F7730", VA = "0x1807F8B30", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer NENBHEDFPEL, ScriptableRenderContext LAMCDJBBCDK, RenderingData OBAGCOGAIIC);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7B01F0", Offset = "0x7AEDF0", VA = "0x1807B01F0")]
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
		private class BFGKBGFHDBN : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private bool DCMNCDFBNCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly List<PerCameraRenderEffect> GJABOBCPNHB;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly List<PerCameraRenderEffect> BCPAAHIKFJA;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x66E6EB0", Offset = "0x66E5AB0", VA = "0x1866E6EB0")]
			public BFGKBGFHDBN(RenderPassEvent FDALHPGOKGK, bool DCMNCDFBNCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x66E6B30", Offset = "0x66E5730", VA = "0x1866E6B30")]
			public bool LNDJCDOPJCC(CameraData PHJCENNACJF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x66E6880", Offset = "0x66E5480", VA = "0x1866E6880", Slot = "9")]
			public override void Execute(ScriptableRenderContext LAMCDJBBCDK, RenderingData OBAGCOGAIIC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x66E6A50", Offset = "0x66E5650", VA = "0x1866E6A50")]
			private void IOBKMPEAOIO(PerCameraRenderEffect COJHHPFHIGG, ScriptableRenderContext LAMCDJBBCDK, RenderingData OBAGCOGAIIC)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private BFGKBGFHDBN m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private BFGKBGFHDBN m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x66E9570", Offset = "0x66E8170", VA = "0x1866E9570", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x66E94E0", Offset = "0x66E80E0", VA = "0x1866E94E0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AFGILNBALBJ, RenderingData OBAGCOGAIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xC4B8D0", Offset = "0xC4A4D0", VA = "0x180C4B8D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x66E97C0", Offset = "0x66E83C0", VA = "0x1866E97C0")]
		public static void DGPNBOMDIOL(ScriptableRenderPass CONENNFIOJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B0200", Offset = "0x7AEE00", VA = "0x1807B0200", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x66E9620", Offset = "0x66E8220", VA = "0x1866E9620", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AFGILNBALBJ, RenderingData OBAGCOGAIIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xC4B8D0", Offset = "0xC4A4D0", VA = "0x180C4B8D0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PNKGFAJPEBA
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Mesh IBBPCBNEDIB;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x66E87E0", Offset = "0x66E73E0", VA = "0x1866E87E0")]
	public static Mesh AMOABLEENEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x66E8890", Offset = "0x66E7490", VA = "0x1866E8890")]
	public static Matrix4x4 EPGFOECGHAG(Camera JGPDJKGMCDE, bool BMCPHGAEAOA = false, bool GANFBHCAIFJ = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x66E8D30", Offset = "0x66E7930", VA = "0x1866E8D30")]
	private static Mesh KGCHNJMIDMC()
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
