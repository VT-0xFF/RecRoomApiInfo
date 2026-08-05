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
		private class EANHIKMNMLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public bool BIFDNAECIHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly List<NIADHHIOHLF> CPKANFCBGOB;

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x665E2C0", Offset = "0x665D6C0", VA = "0x18665E2C0")]
			public EANHIKMNMLN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class OFNLJOEKMJI : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly string LJIFMDOJNEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly EANHIKMNMLN CJPAGNAOHED;

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6660140", Offset = "0x665F540", VA = "0x186660140")]
			public OFNLJOEKMJI(RenderPassEvent CMDGFCEDGPL, EANHIKMNMLN CJPAGNAOHED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x665FD30", Offset = "0x665F130", VA = "0x18665FD30", Slot = "9")]
			public override void Execute(ScriptableRenderContext HFPPGLCONIA, RenderingData IMOFDKOFEBD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class ANJPNEBJEEB : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private readonly string LJIFMDOJNEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private readonly EANHIKMNMLN CJPAGNAOHED;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x665D8D0", Offset = "0x665CCD0", VA = "0x18665D8D0")]
			public ANJPNEBJEEB(RenderPassEvent CMDGFCEDGPL, EANHIKMNMLN CJPAGNAOHED)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x665D5C0", Offset = "0x665C9C0", VA = "0x18665D5C0", Slot = "9")]
			public override void Execute(ScriptableRenderContext HFPPGLCONIA, RenderingData IMOFDKOFEBD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static List<NIADHHIOHLF> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private OFNLJOEKMJI fastLinesUpdatePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private ANJPNEBJEEB fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private EANHIKMNMLN sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x665E3F0", Offset = "0x665D7F0", VA = "0x18665E3F0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x665E350", Offset = "0x665D750", VA = "0x18665E350", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PFFFLMMGJDB, RenderingData IMOFDKOFEBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB7E890", Offset = "0xB7DC90", VA = "0x180B7E890")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface NIADHHIOHLF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KMOGCIOPGAN(CommandBuffer BBBCEBHJIOK, Camera MFIFMMPLJNJ, [NotNull] UniversalAdditionalCameraData IMLMEHPAOPK, bool DBPONDKILPF);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DJJKICGDCCF(Camera MFIFMMPLJNJ, CommandBuffer INICGLDLNHE);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Tooltip("RR Mobile Fade")]
	[DisallowMultipleRendererFeature(null)]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct GNODODFNMKB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public float IMMNPLGJNJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public float ADJKBCPNMNC;
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class HKKNHHOCGML : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private static readonly string ANMGKAJNKNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ProfilingSampler NOAFHJJOEJD;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private static readonly int NNJIEBLOPNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private Material NGEGAMIOJNA;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x665EB70", Offset = "0x665DF70", VA = "0x18665EB70")]
			public HKKNHHOCGML(RenderPassEvent CMDGFCEDGPL, Material LNKFECCMIIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x665E790", Offset = "0x665DB90", VA = "0x18665E790", Slot = "9")]
			public override void Execute(ScriptableRenderContext HFPPGLCONIA, RenderingData IMOFDKOFEBD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static GNODODFNMKB CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private HKKNHHOCGML m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x665F9A0", Offset = "0x665EDA0", VA = "0x18665F9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x665F950", Offset = "0x665ED50", VA = "0x18665F950")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x665F7A0", Offset = "0x665EBA0", VA = "0x18665F7A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x665F6D0", Offset = "0x665EAD0", VA = "0x18665F6D0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PFFFLMMGJDB, RenderingData IMOFDKOFEBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB7E890", Offset = "0xB7DC90", VA = "0x180B7E890")]
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
		public struct EHCAEEAAMAM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public float ACELPIOLKNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Color FDLLEIMNOPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Mesh BBCMGECEOMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AnimationCurve KFKCOBIMBIB;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public sealed class KJGLELDOPMC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string ANMGKAJNKNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler NOAFHJJOEJD;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int HHMHOGNDPBK;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly int FDKJGEBLPDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private Material NGEGAMIOJNA;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x665F5F0", Offset = "0x665E9F0", VA = "0x18665F5F0")]
			public KJGLELDOPMC(RenderPassEvent CMDGFCEDGPL, Material LNKFECCMIIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x665F330", Offset = "0x665E730", VA = "0x18665F330", Slot = "9")]
			public override void Execute(ScriptableRenderContext HFPPGLCONIA, RenderingData IMOFDKOFEBD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static EHCAEEAAMAM CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private KJGLELDOPMC m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x665FCD0", Offset = "0x665F0D0", VA = "0x18665FCD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x665FB20", Offset = "0x665EF20", VA = "0x18665FB20", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x665FA00", Offset = "0x665EE00", VA = "0x18665FA00", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PFFFLMMGJDB, RenderingData IMOFDKOFEBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB7E890", Offset = "0xB7DC90", VA = "0x180B7E890")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string ANPPJPLGLHN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool KCPDJNADPLK
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7E7780", Offset = "0x7E6B80", VA = "0x1807E7780", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer INICGLDLNHE, ScriptableRenderContext HFPPGLCONIA, RenderingData IMOFDKOFEBD);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7A08F0", Offset = "0x79FCF0", VA = "0x1807A08F0")]
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
		private class JAGCBNJIJFC : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private bool PBMOJPONJCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly List<PerCameraRenderEffect> BKBDKIAEKID;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly List<PerCameraRenderEffect> NNMLANKAIOD;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x665F280", Offset = "0x665E680", VA = "0x18665F280")]
			public JAGCBNJIJFC(RenderPassEvent CMDGFCEDGPL, bool PBMOJPONJCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x665EF00", Offset = "0x665E300", VA = "0x18665EF00")]
			public bool IDJABODCDNN(CameraData IMLMEHPAOPK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x665ED30", Offset = "0x665E130", VA = "0x18665ED30", Slot = "9")]
			public override void Execute(ScriptableRenderContext HFPPGLCONIA, RenderingData IMOFDKOFEBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x665EC50", Offset = "0x665E050", VA = "0x18665EC50")]
			private void BFGMEBJJAFP(PerCameraRenderEffect KDBHCONCIJI, ScriptableRenderContext HFPPGLCONIA, RenderingData IMOFDKOFEBD)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private JAGCBNJIJFC m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private JAGCBNJIJFC m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x66602B0", Offset = "0x665F6B0", VA = "0x1866602B0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6660220", Offset = "0x665F620", VA = "0x186660220", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PFFFLMMGJDB, RenderingData IMOFDKOFEBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xB7E890", Offset = "0xB7DC90", VA = "0x180B7E890")]
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
		[Cpp2IlInjected.Address(RVA = "0x6660360", Offset = "0x665F760", VA = "0x186660360")]
		public static void AOCDLJNJJNG(ScriptableRenderPass PNOBKHAIKCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7A0900", Offset = "0x79FD00", VA = "0x1807A0900", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6660440", Offset = "0x665F840", VA = "0x186660440", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PFFFLMMGJDB, RenderingData IMOFDKOFEBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xB7E890", Offset = "0xB7DC90", VA = "0x180B7E890")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class DEBMBEPAOBB
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Mesh AAOGKJLCEPI;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x665E210", Offset = "0x665D610", VA = "0x18665E210")]
	public static Mesh KKLBBHLDEBI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x665D9B0", Offset = "0x665CDB0", VA = "0x18665D9B0")]
	public static Matrix4x4 AJOJHIPKHLB(Camera MFIFMMPLJNJ, bool CLGGJOOMMMP = false, bool KMHGGOKNMKN = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x665DE50", Offset = "0x665D250", VA = "0x18665DE50")]
	private static Mesh JNFNFAMENPL()
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
