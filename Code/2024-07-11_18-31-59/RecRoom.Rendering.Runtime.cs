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
	public class LogRegistrationIndex : MKCMLEJGADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F3BBE0", Offset = "0x6F3A5E0", VA = "0x186F3BBE0", Slot = "4")]
		public override void JGBCFAKMKJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87B0C0", VA = "0x18087C6C0")]
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
		public enum MDBHKCILLCG
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface EGFEBPLEKFE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void MHMACPKANBJ(ScriptableRenderContext CNBJCJOALNK, List<Camera> PFCKDJBEMEM);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface AGCEJALIACO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void MHMACPKANBJ(ScriptableRenderContext CNBJCJOALNK, RenderingData JOOKFIIMNNK);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class GKHOJFACMKM : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6F39E60", Offset = "0x6F38860", VA = "0x186F39E60")]
			public GKHOJFACMKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6F39E00", Offset = "0x6F38800", VA = "0x186F39E00", Slot = "9")]
			public override void Execute(ScriptableRenderContext CNBJCJOALNK, RenderingData JOOKFIIMNNK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private GKHOJFACMKM _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<EGFEBPLEKFE> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<EGFEBPLEKFE> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<AGCEJALIACO> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<AGCEJALIACO> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F3DCC0", Offset = "0x6F3C6C0", VA = "0x186F3DCC0")]
		public static void OELIMODIAHH(MDBHKCILLCG NLLKDNJEMLD, EGFEBPLEKFE OPAFPLMGHLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F3DB40", Offset = "0x6F3C540", VA = "0x186F3DB40")]
		public static void JIGLHGAMKPD(MDBHKCILLCG NLLKDNJEMLD, EGFEBPLEKFE OPAFPLMGHLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F3DC00", Offset = "0x6F3C600", VA = "0x186F3DC00")]
		public static void OELIMODIAHH(MDBHKCILLCG NLLKDNJEMLD, AGCEJALIACO HJJFKJOMLFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F3DA80", Offset = "0x6F3C480", VA = "0x186F3DA80")]
		public static void JIGLHGAMKPD(MDBHKCILLCG NLLKDNJEMLD, AGCEJALIACO HJJFKJOMLFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F3D710", Offset = "0x6F3C110", VA = "0x186F3D710", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F3CC90", Offset = "0x6F3B690", VA = "0x186F3CC90", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GHBIMLIJLGK, RenderingData JOOKFIIMNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F3D900", Offset = "0x6F3C300", VA = "0x186F3D900", Slot = "9")]
		protected override void Dispose(bool DAIALHNNCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F3CD40", Offset = "0x6F3B740", VA = "0x186F3CD40")]
		private static void BFKGBBHLEBM(ScriptableRenderContext CNBJCJOALNK, List<Camera> PFCKDJBEMEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F3DA10", Offset = "0x6F3C410", VA = "0x186F3DA10")]
		private static void FIMLNLPIJCL(ScriptableRenderContext CNBJCJOALNK, List<Camera> PFCKDJBEMEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F3D240", Offset = "0x6F3BC40", VA = "0x186F3D240")]
		private static void CPMEKJJOFPE(ScriptableRenderContext CNBJCJOALNK, RenderingData JOOKFIIMNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD94CE0", Offset = "0xD936E0", VA = "0x180D94CE0")]
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
		private class PNBIPMMNCAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool LGCOGNIPIBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<KDDGNCBILPB> GIMKFAEJGDM;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F3C7B0", Offset = "0x6F3B1B0", VA = "0x186F3C7B0")]
			public PNBIPMMNCAK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class IOENHNEBINB : PreRenderManager.AGCEJALIACO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string ECKFEBODIEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler HLIPNDCNINK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly PNBIPMMNCAK ENANPOJNMDH;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F3AE20", Offset = "0x6F39820", VA = "0x186F3AE20")]
			public IOENHNEBINB(PNBIPMMNCAK FMPOAHKBDCG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6F3AA20", Offset = "0x6F39420", VA = "0x186F3AA20", Slot = "4")]
			public void MHMACPKANBJ(ScriptableRenderContext CNBJCJOALNK, RenderingData JOOKFIIMNNK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class JGFLAFFFKPO : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string DNKJKONNKKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly PNBIPMMNCAK FMPOAHKBDCG;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F3B1F0", Offset = "0x6F39BF0", VA = "0x186F3B1F0")]
			public JGFLAFFFKPO(RenderPassEvent KOGADNBNHNP, PNBIPMMNCAK FMPOAHKBDCG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6F3AEE0", Offset = "0x6F398E0", VA = "0x186F3AEE0", Slot = "9")]
			public override void Execute(ScriptableRenderContext CNBJCJOALNK, RenderingData JOOKFIIMNNK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<KDDGNCBILPB> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IOENHNEBINB fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private JGFLAFFFKPO fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private PNBIPMMNCAK sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F39870", Offset = "0x6F38270", VA = "0x186F39870", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F39C00", Offset = "0x6F38600", VA = "0x186F39C00", Slot = "9")]
		protected override void Dispose(bool DAIALHNNCDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F397D0", Offset = "0x6F381D0", VA = "0x186F397D0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GHBIMLIJLGK, RenderingData JOOKFIIMNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xD94CE0", Offset = "0xD936E0", VA = "0x180D94CE0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KDDGNCBILPB
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JJMKGDBEIDB(CommandBuffer BFHPBHHGKEK, Camera OKGPIGCMLDO, [NotNull] UniversalAdditionalCameraData HJDNLOCCFPI, bool PIGOINHFNHG);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OGHBGNKBEIA(Camera OKGPIGCMLDO, CommandBuffer GLEICJJMPEC);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Fade")]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct MHEEJPEMLCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float OAPHAGLMHJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public float AKHJKCHFKGG;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private class HNGIJMJIKIO : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string JIMCKEBBHJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler PCBEFCDCFHP;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int DPLLHGLFEPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private Material KKPCICPMGJP;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A940", Offset = "0x6F39340", VA = "0x186F3A940")]
			public HNGIJMJIKIO(RenderPassEvent KOGADNBNHNP, Material GIIKGEKINDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A560", Offset = "0x6F38F60", VA = "0x186F3A560", Slot = "9")]
			public override void Execute(ScriptableRenderContext CNBJCJOALNK, RenderingData JOOKFIIMNNK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static MHEEJPEMLCG CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private HNGIJMJIKIO m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x6F3C080", Offset = "0x6F3AA80", VA = "0x186F3C080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6F3C030", Offset = "0x6F3AA30", VA = "0x186F3C030")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F3BE80", Offset = "0x6F3A880", VA = "0x186F3BE80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F3BDB0", Offset = "0x6F3A7B0", VA = "0x186F3BDB0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GHBIMLIJLGK, RenderingData JOOKFIIMNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xD94CE0", Offset = "0xD936E0", VA = "0x180D94CE0")]
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
		public struct GAKDIAHKKOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float KABMJOGNMKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Color CKPNPNIBCJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Mesh CENDCMLBGNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AnimationCurve HHCKNGKJDDF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public sealed class PCFHJAFGLKI : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static readonly string JIMCKEBBHJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private ProfilingSampler PCBEFCDCFHP;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static readonly int EOBBDICNGFL;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static readonly int BDMMNHFKGML;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Material KKPCICPMGJP;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F3C6D0", Offset = "0x6F3B0D0", VA = "0x186F3C6D0")]
			public PCFHJAFGLKI(RenderPassEvent KOGADNBNHNP, Material GIIKGEKINDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F3C410", Offset = "0x6F3AE10", VA = "0x186F3C410", Slot = "9")]
			public override void Execute(ScriptableRenderContext CNBJCJOALNK, RenderingData JOOKFIIMNNK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static GAKDIAHKKOK CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private PCFHJAFGLKI m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x6F3C3B0", Offset = "0x6F3ADB0", VA = "0x186F3C3B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F3C200", Offset = "0x6F3AC00", VA = "0x186F3C200", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F3C0E0", Offset = "0x6F3AAE0", VA = "0x186F3C0E0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GHBIMLIJLGK, RenderingData JOOKFIIMNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xD94CE0", Offset = "0xD936E0", VA = "0x180D94CE0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string BHOLBLAIMDJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool IFEMDDMMHAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x89B1F0", Offset = "0x899BF0", VA = "0x18089B1F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer GLEICJJMPEC, ScriptableRenderContext CNBJCJOALNK, RenderingData JOOKFIIMNNK);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x854280", Offset = "0x852C80", VA = "0x180854280")]
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
		private class HGLJIJFNNGI : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private bool HGMANPHKEDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private readonly List<PerCameraRenderEffect> HFBBAGMNAEC;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private static readonly List<PerCameraRenderEffect> DHHFFHBJPGM;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A4B0", Offset = "0x6F38EB0", VA = "0x186F3A4B0")]
			public HGLJIJFNNGI(RenderPassEvent KOGADNBNHNP, bool HGMANPHKEDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F3A130", Offset = "0x6F38B30", VA = "0x186F3A130")]
			public bool GBGAKFNOANO(CameraData HJDNLOCCFPI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F39F60", Offset = "0x6F38960", VA = "0x186F39F60", Slot = "9")]
			public override void Execute(ScriptableRenderContext CNBJCJOALNK, RenderingData JOOKFIIMNNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F39E80", Offset = "0x6F38880", VA = "0x186F39E80")]
			private void CECIFMEMAMF(PerCameraRenderEffect ODENBJPPFAG, ScriptableRenderContext CNBJCJOALNK, RenderingData JOOKFIIMNNK)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private HGLJIJFNNGI m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private HGLJIJFNNGI m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F3C8D0", Offset = "0x6F3B2D0", VA = "0x186F3C8D0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F3C840", Offset = "0x6F3B240", VA = "0x186F3C840", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GHBIMLIJLGK, RenderingData JOOKFIIMNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xD94CE0", Offset = "0xD936E0", VA = "0x180D94CE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F3CB20", Offset = "0x6F3B520", VA = "0x186F3CB20")]
		public static void HMMCDILEJEN(ScriptableRenderPass MEKELEDAKOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6F3C980", Offset = "0x6F3B380", VA = "0x186F3C980", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer GHBIMLIJLGK, RenderingData JOOKFIIMNNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xD94CE0", Offset = "0xD936E0", VA = "0x180D94CE0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MDBBHMENBHM
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly CDLNJDLNIPA NFFGGMPLICF;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly CDLNJDLNIPA GOFADMGOMNJ;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly CDLNJDLNIPA MFKBHOGIDGA;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly CDLNJDLNIPA HIOOFPLAKCM;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OEBGOMLOGJC
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDOLCBGNIJF();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class FGLGIECHFAM : OEBGOMLOGJC
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly string DPJOJPPJAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private NICHJPMKMDF BLEKBGCPHAD;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x851BE0", VA = "0x1808531E0")]
	[UnityEngine.Scripting.Preserve]
	public FGLGIECHFAM([OMAPKKAGFIL(null)][NotNull] NICHJPMKMDF DOFIDBNKPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F39520", Offset = "0x6F37F20", VA = "0x186F39520")]
	[UsedImplicitly]
	[GDGALFJPCGE(JAFPILLCEJB.Session, JMIPDAHBNNG.GameOnly)]
	public static void NINFHNAOIMF(INCIOHANCNE PGHIDIKDPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F39210", Offset = "0x6F37C10", VA = "0x186F39210", Slot = "4")]
	public void DDOLCBGNIJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F39310", Offset = "0x6F37D10", VA = "0x186F39310")]
	private void GLMNOCMOCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F39620", Offset = "0x6F38020", VA = "0x186F39620")]
	private bool PJFHMNJIAEH(string ABBPJNAAFNC, [Out] CLEEKKAIGLK COONEANDAMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class KODHHMCKFEH
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static Mesh BGFOMNGJGCI;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BB30", Offset = "0x6F3A530", VA = "0x186F3BB30")]
	public static Mesh ODNCJIKNKIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B690", Offset = "0x6F3A090", VA = "0x186F3B690")]
	public static Matrix4x4 IGBKNPJCLOL(Camera OKGPIGCMLDO, bool OLICBPBBIDP = false, bool LINDDJEPOJG = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F3B2D0", Offset = "0x6F39CD0", VA = "0x186F3B2D0")]
	private static Mesh EFPHFHJLHBE()
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
