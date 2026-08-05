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
		private class COEHHAFDCLI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public bool PFFGBAFAEMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public readonly List<KHHHBKBMDKB> ECIOMNBIPOO;

			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x689F1B0", Offset = "0x689E1B0", VA = "0x18689F1B0")]
			public COEHHAFDCLI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class AGLIAMDIMMO : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private readonly string EKDGJHHBLHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private readonly COEHHAFDCLI BNEPKOAJHCH;

			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x689ECE0", Offset = "0x689DCE0", VA = "0x18689ECE0")]
			public AGLIAMDIMMO(RenderPassEvent MHDBIKHNMJP, COEHHAFDCLI BNEPKOAJHCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x689E8D0", Offset = "0x689D8D0", VA = "0x18689E8D0", Slot = "9")]
			public override void Execute(ScriptableRenderContext DFKOHNJAKHM, RenderingData PIMDNBHKEBN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class BKEEADKHIOD : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private readonly string EKDGJHHBLHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private readonly COEHHAFDCLI BNEPKOAJHCH;

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x689F0D0", Offset = "0x689E0D0", VA = "0x18689F0D0")]
			public BKEEADKHIOD(RenderPassEvent MHDBIKHNMJP, COEHHAFDCLI BNEPKOAJHCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x689EDC0", Offset = "0x689DDC0", VA = "0x18689EDC0", Slot = "9")]
			public override void Execute(ScriptableRenderContext DFKOHNJAKHM, RenderingData PIMDNBHKEBN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static List<KHHHBKBMDKB> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private AGLIAMDIMMO fastLinesUpdatePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private BKEEADKHIOD fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private COEHHAFDCLI sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x689FE80", Offset = "0x689EE80", VA = "0x18689FE80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x689FDE0", Offset = "0x689EDE0", VA = "0x18689FDE0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GHMFIGHJGLK, RenderingData PIMDNBHKEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xC528A0", Offset = "0xC518A0", VA = "0x180C528A0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KHHHBKBMDKB
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HKNMDOJMLJI(CommandBuffer HMKKMFOAKGK, Camera IGCKGGJPBHM, [NotNull] UniversalAdditionalCameraData OEDJDKIFMHL, bool LIHJKAMPBJJ);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KEFJOPCAOJJ(Camera IGCKGGJPBHM, CommandBuffer EHOEOAEBPAK);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[Tooltip("RR Mobile Fade")]
	[DisallowMultipleRendererFeature(null)]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct DDBHOHFNEHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public float LADCFOHBHOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public float AMGECPNHBFI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class DJGHJPLIHBC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private static readonly string KJHEJJGDKMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ProfilingSampler OGIKCDGLMDN;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private static readonly int LIBHKBGLBLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private Material MHEHGBKGKIL;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x689FD00", Offset = "0x689ED00", VA = "0x18689FD00")]
			public DJGHJPLIHBC(RenderPassEvent MHDBIKHNMJP, Material JANOPPPMNPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x689F920", Offset = "0x689E920", VA = "0x18689F920", Slot = "9")]
			public override void Execute(ScriptableRenderContext DFKOHNJAKHM, RenderingData PIMDNBHKEBN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static DDBHOHFNEHN CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private DJGHJPLIHBC m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x68A11A0", Offset = "0x68A01A0", VA = "0x1868A11A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x68A1150", Offset = "0x68A0150", VA = "0x1868A1150")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x68A0FA0", Offset = "0x689FFA0", VA = "0x1868A0FA0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68A0ED0", Offset = "0x689FED0", VA = "0x1868A0ED0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GHMFIGHJGLK, RenderingData PIMDNBHKEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xC528A0", Offset = "0xC518A0", VA = "0x180C528A0")]
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
		public struct BFPGLPJPLJB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public float EPMFMDMLODC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Color NKAKDJCNNLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public Mesh IJCBAOCJIID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AnimationCurve IDOHEDJOELC;
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public sealed class MCGMGPACINC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string KJHEJJGDKMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler OGIKCDGLMDN;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int KBNIFMEKJBN;

			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly int IKHPFOLLHCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private Material MHEHGBKGKIL;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x68A0DF0", Offset = "0x689FDF0", VA = "0x1868A0DF0")]
			public MCGMGPACINC(RenderPassEvent MHDBIKHNMJP, Material JANOPPPMNPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x68A0B30", Offset = "0x689FB30", VA = "0x1868A0B30", Slot = "9")]
			public override void Execute(ScriptableRenderContext DFKOHNJAKHM, RenderingData PIMDNBHKEBN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public static BFPGLPJPLJB CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private MCGMGPACINC m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x68A14D0", Offset = "0x68A04D0", VA = "0x1868A14D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x68A1320", Offset = "0x68A0320", VA = "0x1868A1320", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x68A1200", Offset = "0x68A0200", VA = "0x1868A1200", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GHMFIGHJGLK, RenderingData PIMDNBHKEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xC528A0", Offset = "0xC518A0", VA = "0x180C528A0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string OPPHBGICNFH
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool BBJMMJAMBLB
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer EHOEOAEBPAK, ScriptableRenderContext DFKOHNJAKHM, RenderingData PIMDNBHKEBN);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7C06B0", Offset = "0x7BF6B0", VA = "0x1807C06B0")]
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
		private class COOMAIIAGKI : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private bool NNPCGFBKNPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly List<PerCameraRenderEffect> FGJKKPBNGCE;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly List<PerCameraRenderEffect> LHPOJCLPAIE;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x689F870", Offset = "0x689E870", VA = "0x18689F870")]
			public COOMAIIAGKI(RenderPassEvent MHDBIKHNMJP, bool NNPCGFBKNPN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x689F240", Offset = "0x689E240", VA = "0x18689F240")]
			public bool DMPOJHDKGNP(CameraData OEDJDKIFMHL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x689F530", Offset = "0x689E530", VA = "0x18689F530", Slot = "9")]
			public override void Execute(ScriptableRenderContext DFKOHNJAKHM, RenderingData PIMDNBHKEBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x689F700", Offset = "0x689E700", VA = "0x18689F700")]
			private void ICKGJPMHJLM(PerCameraRenderEffect HCNJLOLNEEN, ScriptableRenderContext DFKOHNJAKHM, RenderingData PIMDNBHKEBN)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private COOMAIIAGKI m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private COOMAIIAGKI m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x68A15C0", Offset = "0x68A05C0", VA = "0x1868A15C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68A1530", Offset = "0x68A0530", VA = "0x1868A1530", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GHMFIGHJGLK, RenderingData PIMDNBHKEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xC528A0", Offset = "0xC518A0", VA = "0x180C528A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68A1810", Offset = "0x68A0810", VA = "0x1868A1810")]
		public static void DMKIOCLIEHN(ScriptableRenderPass ILMDJAGGCBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68A1670", Offset = "0x68A0670", VA = "0x1868A1670", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GHMFIGHJGLK, RenderingData PIMDNBHKEBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xC528A0", Offset = "0xC518A0", VA = "0x180C528A0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class LOCJINGJJHP
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static Mesh AKMJFEGOONA;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x68A0A80", Offset = "0x689FA80", VA = "0x1868A0A80")]
	public static Mesh NBBGPBEJMBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x68A05E0", Offset = "0x689F5E0", VA = "0x1868A05E0")]
	public static Matrix4x4 KHIJKDECIDF(Camera IGCKGGJPBHM, bool MCMHFDHLIKB = false, bool BEMIGFAABHN = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x68A0220", Offset = "0x689F220", VA = "0x1868A0220")]
	private static Mesh IEJDGOPGEHI()
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
