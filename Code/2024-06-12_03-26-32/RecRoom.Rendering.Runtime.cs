using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Logging.Attributes;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : BOJNKDJNMOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F2D510", Offset = "0x6F2C110", VA = "0x186F2D510", Slot = "4")]
		public override void FHCDBNBHAOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR PreRender Manager")]
	public class PreRenderManager : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public enum HDHAALPCIDO
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface FJLEKJILOPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void FLADJOFCMKI(ScriptableRenderContext FBMKGECLCCA, List<Camera> LGEBLCKFPPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface MCCPFJEKNPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void FLADJOFCMKI(ScriptableRenderContext FBMKGECLCCA, RenderingData FMJPLEFDOHG);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class AFAOIDDOAAL : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6F2AD60", Offset = "0x6F29960", VA = "0x186F2AD60")]
			public AFAOIDDOAAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6F2AD00", Offset = "0x6F29900", VA = "0x186F2AD00", Slot = "9")]
			public override void Execute(ScriptableRenderContext FBMKGECLCCA, RenderingData FMJPLEFDOHG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private AFAOIDDOAAL _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<FJLEKJILOPJ> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<FJLEKJILOPJ> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<MCCPFJEKNPC> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<MCCPFJEKNPC> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F2F7A0", Offset = "0x6F2E3A0", VA = "0x186F2F7A0")]
		public static void PJBFHEPCIGA(HDHAALPCIDO GICMGFFOCPI, FJLEKJILOPJ KNBDMAJJLKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F2F560", Offset = "0x6F2E160", VA = "0x186F2F560")]
		public static void NEOALJOJIGK(HDHAALPCIDO GICMGFFOCPI, FJLEKJILOPJ KNBDMAJJLKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F2F6E0", Offset = "0x6F2E2E0", VA = "0x186F2F6E0")]
		public static void PJBFHEPCIGA(HDHAALPCIDO GICMGFFOCPI, MCCPFJEKNPC CGEECJHJGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F2F620", Offset = "0x6F2E220", VA = "0x186F2F620")]
		public static void NEOALJOJIGK(HDHAALPCIDO GICMGFFOCPI, MCCPFJEKNPC CGEECJHJGOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E820", Offset = "0x6F2D420", VA = "0x186F2E820", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E770", Offset = "0x6F2D370", VA = "0x186F2E770", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer KKNFDPNGCFK, RenderingData FMJPLEFDOHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F2EA10", Offset = "0x6F2D610", VA = "0x186F2EA10", Slot = "9")]
		protected override void Dispose(bool HPJLBEMAOKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F2EB20", Offset = "0x6F2D720", VA = "0x186F2EB20")]
		private static void EJKDMLHELGG(ScriptableRenderContext FBMKGECLCCA, List<Camera> LGEBLCKFPPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F2F4F0", Offset = "0x6F2E0F0", VA = "0x186F2F4F0")]
		private static void LKEBOOOMKFN(ScriptableRenderContext FBMKGECLCCA, List<Camera> LGEBLCKFPPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F2F020", Offset = "0x6F2DC20", VA = "0x186F2F020")]
		private static void GJHHHDLFEDE(ScriptableRenderContext FBMKGECLCCA, RenderingData FMJPLEFDOHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD935D0", Offset = "0xD921D0", VA = "0x180D935D0")]
		public PreRenderManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[Tooltip("RR Fast Lines")]
	[DisallowMultipleRendererFeature(null)]
	public class FastLinesRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class INJFPBFBGLE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool NDHALKFIGFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<HPIMBLJGEBD> PCCJEKEDPGF;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F2D480", Offset = "0x6F2C080", VA = "0x186F2D480")]
			public INJFPBFBGLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class BJKKHGIIPGN : PreRenderManager.MCCPFJEKNPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string HGJDGPKJFCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler IIKKLEAIKFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly INJFPBFBGLE APGOGCMPGBI;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B730", Offset = "0x6F2A330", VA = "0x186F2B730")]
			public BJKKHGIIPGN(INJFPBFBGLE GOOMDNKPLEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B330", Offset = "0x6F29F30", VA = "0x186F2B330", Slot = "4")]
			public void FLADJOFCMKI(ScriptableRenderContext FBMKGECLCCA, RenderingData FMJPLEFDOHG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class CDFEPDEDJAF : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string MBIHKGKCNGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly INJFPBFBGLE GOOMDNKPLEB;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F2BB00", Offset = "0x6F2A700", VA = "0x186F2BB00")]
			public CDFEPDEDJAF(RenderPassEvent LOMPNKHHHLG, INJFPBFBGLE GOOMDNKPLEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6F2B7F0", Offset = "0x6F2A3F0", VA = "0x186F2B7F0", Slot = "9")]
			public override void Execute(ScriptableRenderContext FBMKGECLCCA, RenderingData FMJPLEFDOHG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<HPIMBLJGEBD> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private BJKKHGIIPGN fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private CDFEPDEDJAF fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private INJFPBFBGLE sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C690", Offset = "0x6F2B290", VA = "0x186F2C690", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F2CA20", Offset = "0x6F2B620", VA = "0x186F2CA20", Slot = "9")]
		protected override void Dispose(bool HPJLBEMAOKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C5F0", Offset = "0x6F2B1F0", VA = "0x186F2C5F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer KKNFDPNGCFK, RenderingData FMJPLEFDOHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD935D0", Offset = "0xD921D0", VA = "0x180D935D0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HPIMBLJGEBD
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJECHMEGNAF(CommandBuffer GCFDPGGPFPA, Camera MEAPGGPGMOO, [NotNull] UniversalAdditionalCameraData HLFFHPKLIMG, bool CKPPOMDFLFN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JCADGLKNFPK(Camera MEAPGGPGMOO, CommandBuffer DMCELDOJCFP);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Fade")]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct HMDHLIDJOOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float DJHGNIDOGBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public float GIODJKKPDCC;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private class HBGPONHOBMG : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string MJOKNHLKEKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler FHCCBIMDNAO;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int MAFNMDOKJLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private Material BKIMBMLKAFK;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6F2D3A0", Offset = "0x6F2BFA0", VA = "0x186F2D3A0")]
			public HBGPONHOBMG(RenderPassEvent LOMPNKHHHLG, Material MBCOMNNFJFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6F2CFC0", Offset = "0x6F2BBC0", VA = "0x186F2CFC0", Slot = "9")]
			public override void Execute(ScriptableRenderContext FBMKGECLCCA, RenderingData FMJPLEFDOHG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static HMDHLIDJOOF CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private HBGPONHOBMG m_MobileFadePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[Reload("Shaders/MobileFade.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6F2DF90", Offset = "0x6F2CB90", VA = "0x186F2DF90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6F2DF40", Offset = "0x6F2CB40", VA = "0x186F2DF40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DD90", Offset = "0x6F2C990", VA = "0x186F2DD90", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DCC0", Offset = "0x6F2C8C0", VA = "0x186F2DCC0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer KKNFDPNGCFK, RenderingData FMJPLEFDOHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xD935D0", Offset = "0xD921D0", VA = "0x180D935D0")]
		public MobileFadeRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Vignette")]
	public class MobileVignetteRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public struct MDODBCGMNID
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float IKEBAPOIGDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Color APJMHGBHPNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Mesh GBDEPEMGILA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AnimationCurve HFPELGAKGNI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public sealed class GNOEHIJIGHP : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static readonly string MJOKNHLKEKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private ProfilingSampler FHCCBIMDNAO;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static readonly int LKIACHMCBIE;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static readonly int DHFCHJBHDMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Material BKIMBMLKAFK;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F2CEE0", Offset = "0x6F2BAE0", VA = "0x186F2CEE0")]
			public GNOEHIJIGHP(RenderPassEvent LOMPNKHHHLG, Material MBCOMNNFJFG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F2CC20", Offset = "0x6F2B820", VA = "0x186F2CC20", Slot = "9")]
			public override void Execute(ScriptableRenderContext FBMKGECLCCA, RenderingData FMJPLEFDOHG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static MDODBCGMNID CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private GNOEHIJIGHP m_MobileVignettePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[Reload("Shaders/MobileVignette.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public static bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F2E2C0", Offset = "0x6F2CEC0", VA = "0x186F2E2C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E110", Offset = "0x6F2CD10", VA = "0x186F2E110", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DFF0", Offset = "0x6F2CBF0", VA = "0x186F2DFF0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer KKNFDPNGCFK, RenderingData FMJPLEFDOHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xD935D0", Offset = "0xD921D0", VA = "0x180D935D0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string MGGBBAGKDAK
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool POLOKKLPPHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer DMCELDOJCFP, ScriptableRenderContext FBMKGECLCCA, RenderingData FMJPLEFDOHG);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x846CB0", Offset = "0x8458B0", VA = "0x180846CB0")]
		protected PerCameraRenderEffect()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[Tooltip("RR Per-Camera Render Effects")]
	[DisallowMultipleRendererFeature(null)]
	public class PerCameraRenderEffectsRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private class MJNLEGLPKGI : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private bool EFCLKEKCLOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private readonly List<PerCameraRenderEffect> LMOPGDFPEKN;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private static readonly List<PerCameraRenderEffect> CEPIDHDPFLF;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F2DC10", Offset = "0x6F2C810", VA = "0x186F2DC10")]
			public MJNLEGLPKGI(RenderPassEvent LOMPNKHHHLG, bool EFCLKEKCLOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F2D7B0", Offset = "0x6F2C3B0", VA = "0x186F2D7B0")]
			public bool PCMIJKJGMKN(CameraData HLFFHPKLIMG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F2D5E0", Offset = "0x6F2C1E0", VA = "0x186F2D5E0", Slot = "9")]
			public override void Execute(ScriptableRenderContext FBMKGECLCCA, RenderingData FMJPLEFDOHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F2DAA0", Offset = "0x6F2C6A0", VA = "0x186F2DAA0")]
			private void PMMINGFDIGN(PerCameraRenderEffect LINHPCEMBMK, ScriptableRenderContext FBMKGECLCCA, RenderingData FMJPLEFDOHG)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private MJNLEGLPKGI m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private MJNLEGLPKGI m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E3B0", Offset = "0x6F2CFB0", VA = "0x186F2E3B0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E320", Offset = "0x6F2CF20", VA = "0x186F2E320", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer KKNFDPNGCFK, RenderingData FMJPLEFDOHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xD935D0", Offset = "0xD921D0", VA = "0x180D935D0")]
		public PerCameraRenderEffectsRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[Tooltip("RR Persistent Buffer Effects")]
	[DisallowMultipleRendererFeature(null)]
	public class PersistentBufferEffectsRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private static readonly List<ScriptableRenderPass> passes;

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const RenderPassEvent RENDER_PASS_EVENT = RenderPassEvent.BeforeRenderingShadows;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E600", Offset = "0x6F2D200", VA = "0x186F2E600")]
		public static void LMNNGHIBKFK(ScriptableRenderPass BCMOLLFNJDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E460", Offset = "0x6F2D060", VA = "0x186F2E460", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer KKNFDPNGCFK, RenderingData FMJPLEFDOHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xD935D0", Offset = "0xD921D0", VA = "0x180D935D0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DIMMOCIPCPD
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly KEDKJKIEEGM AANKKHIOECM;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly KEDKJKIEEGM LDHJFNLNHGE;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly KEDKJKIEEGM GMBBEFHJONL;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly KEDKJKIEEGM AEPBNAJBHCD;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OEDMMLAGJLC
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AFBJHCKOIAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AMOAJCJENLJ : OEDMMLAGJLC
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly string IIDAECBDFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private GKDHMMKGFLI HBOEHMOCMAD;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x852C90", Offset = "0x851890", VA = "0x180852C90")]
	[UnityEngine.Scripting.Preserve]
	public AMOAJCJENLJ([GOICEJLKLIB(null)][NotNull] GKDHMMKGFLI MPAGJNLPKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F2AF60", Offset = "0x6F29B60", VA = "0x186F2AF60")]
	[UsedImplicitly]
	[FJJFAIMPJIC(AMDAGODFNAF.Session, JBEKPLNNIEC.GameOnly)]
	public static void KOBBPCBLLFC(LLIMAHMFNLB INBELNINGBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F2AD80", Offset = "0x6F29980", VA = "0x186F2AD80", Slot = "4")]
	public void AFBJHCKOIAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B050", Offset = "0x6F29C50", VA = "0x186F2B050")]
	private void OIEAEFKFHJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F2AE80", Offset = "0x6F29A80", VA = "0x186F2AE80")]
	private bool FEOCGHCJEGJ(string DLNDBHCFMDA, [Out] APPGGIIHCCP GPOBDBFMCIA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class EOAICFLGOGJ
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static Mesh HGAMBKGPLLH;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C540", Offset = "0x6F2B140", VA = "0x186F2C540")]
	public static Mesh NAKLKBMLANI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F2BCE0", Offset = "0x6F2A8E0", VA = "0x186F2BCE0")]
	public static Matrix4x4 EIEOAPGIBJM(Camera MEAPGGPGMOO, bool ACDKOMFELFD = false, bool JKEKFGPDMGD = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C180", Offset = "0x6F2AD80", VA = "0x186F2C180")]
	private static Mesh HHEHLIPDLKO()
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
