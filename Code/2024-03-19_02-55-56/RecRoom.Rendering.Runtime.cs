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
		private class PAALFJEIAPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public bool KFINFIONGEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly List<BJNFOFIKNGL> BAJFCNNEIME;

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6749890", Offset = "0x6748890", VA = "0x186749890")]
			public PAALFJEIAPN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class PJBJAAEFLIN : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly string LFNMJGDIIOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly PAALFJEIAPN PBEFLGPAKMB;

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6749D30", Offset = "0x6748D30", VA = "0x186749D30")]
			public PJBJAAEFLIN(RenderPassEvent HGJIEONDGNI, PAALFJEIAPN PBEFLGPAKMB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x6749920", Offset = "0x6748920", VA = "0x186749920", Slot = "9")]
			public override void Execute(ScriptableRenderContext LNLKAOCIPJI, RenderingData DPGKMKAEHOM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class PJONELOILGO : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private readonly string LFNMJGDIIOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private readonly PAALFJEIAPN PBEFLGPAKMB;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x674A120", Offset = "0x6749120", VA = "0x18674A120")]
			public PJONELOILGO(RenderPassEvent HGJIEONDGNI, PAALFJEIAPN PBEFLGPAKMB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x6749E10", Offset = "0x6748E10", VA = "0x186749E10", Slot = "9")]
			public override void Execute(ScriptableRenderContext LNLKAOCIPJI, RenderingData DPGKMKAEHOM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static List<BJNFOFIKNGL> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private PJBJAAEFLIN fastLinesUpdatePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private PJONELOILGO fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private PAALFJEIAPN sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6747B00", Offset = "0x6746B00", VA = "0x186747B00", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6747A60", Offset = "0x6746A60", VA = "0x186747A60", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JFDOOADJAOI, RenderingData DPGKMKAEHOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xC4F2B0", Offset = "0xC4E2B0", VA = "0x180C4F2B0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface BJNFOFIKNGL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GLMKKOAHPGD(CommandBuffer FKPGABMEIOP, Camera NOKKDLLPIMH, [NotNull] UniversalAdditionalCameraData MPEAFKLGJDL, bool NCKPPCHHOOK);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IGAHPKBDHCG(Camera NOKKDLLPIMH, CommandBuffer LENBLHCIOIF);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Tooltip("RR Mobile Fade")]
	[DisallowMultipleRendererFeature(null)]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct JPADIAJEKEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public float FGMALFECPFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public float AHEHJMIMNKC;
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class BOBNNAOLDJD : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private static readonly string MMGCBBBCHJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ProfilingSampler ICPPGOCMADM;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private static readonly int LBDOKNEFHDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private Material NAMAPKHMPKK;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6747980", Offset = "0x6746980", VA = "0x186747980")]
			public BOBNNAOLDJD(RenderPassEvent HGJIEONDGNI, Material BKIIKPMMAIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x67475A0", Offset = "0x67465A0", VA = "0x1867475A0", Slot = "9")]
			public override void Execute(ScriptableRenderContext LNLKAOCIPJI, RenderingData DPGKMKAEHOM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static JPADIAJEKEK CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private BOBNNAOLDJD m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x6749500", Offset = "0x6748500", VA = "0x186749500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x67494B0", Offset = "0x67484B0", VA = "0x1867494B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6749300", Offset = "0x6748300", VA = "0x186749300", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6749230", Offset = "0x6748230", VA = "0x186749230", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JFDOOADJAOI, RenderingData DPGKMKAEHOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xC4F2B0", Offset = "0xC4E2B0", VA = "0x180C4F2B0")]
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
		public struct JLLHIAJICMJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public float JEFOEPFOBHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Color CMAECKCGGLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Mesh NHKGGOJDFAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AnimationCurve OHAIFOOLPKH;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public sealed class HKDGGDDIOIA : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string MMGCBBBCHJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler ICPPGOCMADM;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int IMNHAGHJFCH;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly int PIONHLFHJKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private Material NAMAPKHMPKK;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6748A70", Offset = "0x6747A70", VA = "0x186748A70")]
			public HKDGGDDIOIA(RenderPassEvent HGJIEONDGNI, Material BKIIKPMMAIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x67487B0", Offset = "0x67477B0", VA = "0x1867487B0", Slot = "9")]
			public override void Execute(ScriptableRenderContext LNLKAOCIPJI, RenderingData DPGKMKAEHOM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static JLLHIAJICMJ CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private HKDGGDDIOIA m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x6749830", Offset = "0x6748830", VA = "0x186749830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6749680", Offset = "0x6748680", VA = "0x186749680", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6749560", Offset = "0x6748560", VA = "0x186749560", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JFDOOADJAOI, RenderingData DPGKMKAEHOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC4F2B0", Offset = "0xC4E2B0", VA = "0x180C4F2B0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string KIJCNCGNJFD
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool MIMOLNBKECF
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x803AA0", Offset = "0x802AA0", VA = "0x180803AA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer LENBLHCIOIF, ScriptableRenderContext LNLKAOCIPJI, RenderingData DPGKMKAEHOM);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7BB270", Offset = "0x7BA270", VA = "0x1807BB270")]
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
		private class JOAOPOMOCKD : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private bool EBNGKDIEBEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly List<PerCameraRenderEffect> MCEPAKLNHMI;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly List<PerCameraRenderEffect> IIDPPKHAEPE;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6749180", Offset = "0x6748180", VA = "0x186749180")]
			public JOAOPOMOCKD(RenderPassEvent HGJIEONDGNI, bool EBNGKDIEBEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6748E00", Offset = "0x6747E00", VA = "0x186748E00")]
			public bool OBALCGANPOD(CameraData MPEAFKLGJDL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6748B50", Offset = "0x6747B50", VA = "0x186748B50", Slot = "9")]
			public override void Execute(ScriptableRenderContext LNLKAOCIPJI, RenderingData DPGKMKAEHOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6748D20", Offset = "0x6747D20", VA = "0x186748D20")]
			private void JJELDFCBFNG(PerCameraRenderEffect ELJAPEKPFNB, ScriptableRenderContext LNLKAOCIPJI, RenderingData DPGKMKAEHOM)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private JOAOPOMOCKD m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private JOAOPOMOCKD m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x674A290", Offset = "0x6749290", VA = "0x18674A290", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x674A200", Offset = "0x6749200", VA = "0x18674A200", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JFDOOADJAOI, RenderingData DPGKMKAEHOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xC4F2B0", Offset = "0xC4E2B0", VA = "0x180C4F2B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x674A340", Offset = "0x6749340", VA = "0x18674A340")]
		public static void AKJHEDBCJPF(ScriptableRenderPass BKLMNIFFKGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x674A420", Offset = "0x6749420", VA = "0x18674A420", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer JFDOOADJAOI, RenderingData DPGKMKAEHOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xC4F2B0", Offset = "0xC4E2B0", VA = "0x180C4F2B0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GGOMEEGLPKN
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Mesh HNCNPNLBKNB;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6748700", Offset = "0x6747700", VA = "0x186748700")]
	public static Mesh IICBAJEIANK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6748260", Offset = "0x6747260", VA = "0x186748260")]
	public static Matrix4x4 BDNDHKDCPCJ(Camera NOKKDLLPIMH, bool MGNPNGGNLPM = false, bool CDGELIECJCD = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6747EA0", Offset = "0x6746EA0", VA = "0x186747EA0")]
	private static Mesh ANOFMPDGJGA()
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
