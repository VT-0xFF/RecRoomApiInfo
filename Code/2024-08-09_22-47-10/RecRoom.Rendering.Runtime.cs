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
	public class LogRegistrationIndex : DLJCNHBICIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F588E0", Offset = "0x6F57CE0", VA = "0x186F588E0", Slot = "4")]
		public override void NLGJOIAOEAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
		public enum HEPBEJGHNLH
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface HMFPGJPCNNB
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void NODAGBIOAMB(ScriptableRenderContext NMIKEFKOPMC, List<Camera> GILIMAFHNHL);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface DKBDOLKHHHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void NODAGBIOAMB(ScriptableRenderContext NMIKEFKOPMC, RenderingData DKEEFMEBNDL);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class OKCKECCJPBI : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6F5A1E0", Offset = "0x6F595E0", VA = "0x186F5A1E0")]
			public OKCKECCJPBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6F5A180", Offset = "0x6F59580", VA = "0x186F5A180", Slot = "9")]
			public override void Execute(ScriptableRenderContext NMIKEFKOPMC, RenderingData DKEEFMEBNDL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private OKCKECCJPBI _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<HMFPGJPCNNB> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<HMFPGJPCNNB> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<DKBDOLKHHHN> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<DKBDOLKHHHN> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B100", Offset = "0x6F5A500", VA = "0x186F5B100")]
		public static void IFJFDCKOOGG(HEPBEJGHNLH AEIGDMMFKON, HMFPGJPCNNB ACGNDFPFONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B040", Offset = "0x6F5A440", VA = "0x186F5B040")]
		public static void HNFNOAANNCG(HEPBEJGHNLH AEIGDMMFKON, HMFPGJPCNNB ACGNDFPFONA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B1C0", Offset = "0x6F5A5C0", VA = "0x186F5B1C0")]
		public static void IFJFDCKOOGG(HEPBEJGHNLH AEIGDMMFKON, DKBDOLKHHHN HFOFDHLOENP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F5AF80", Offset = "0x6F5A380", VA = "0x186F5AF80")]
		public static void HNFNOAANNCG(HEPBEJGHNLH AEIGDMMFKON, DKBDOLKHHHN HFOFDHLOENP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A770", Offset = "0x6F59B70", VA = "0x186F5A770", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A6C0", Offset = "0x6F59AC0", VA = "0x186F5A6C0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CODANAEIMCO, RenderingData DKEEFMEBNDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F5AE70", Offset = "0x6F5A270", VA = "0x186F5AE70", Slot = "9")]
		protected override void Dispose(bool FMELNOHAIIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A960", Offset = "0x6F59D60", VA = "0x186F5A960")]
		private static void DPBPLCFFBLJ(ScriptableRenderContext NMIKEFKOPMC, List<Camera> GILIMAFHNHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A650", Offset = "0x6F59A50", VA = "0x186F5A650")]
		private static void AIEKHDDDBKO(ScriptableRenderContext NMIKEFKOPMC, List<Camera> GILIMAFHNHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B280", Offset = "0x6F5A680", VA = "0x186F5B280")]
		private static void JLDFDHKCMKC(ScriptableRenderContext NMIKEFKOPMC, RenderingData DKEEFMEBNDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xE95430", Offset = "0xE94830", VA = "0x180E95430")]
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
		private class EHLNDLIDPNK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool HJNNEBKJLBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<LIMBNEJGLBK> FGELCHOJNKI;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F572B0", Offset = "0x6F566B0", VA = "0x186F572B0")]
			public EHLNDLIDPNK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class DCFCKBBDKEG : PreRenderManager.DKBDOLKHHHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string PBAPKEKKPMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler BCPAJBBBMDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly EHLNDLIDPNK IBCCOFAGBEL;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F56E00", Offset = "0x6F56200", VA = "0x186F56E00")]
			public DCFCKBBDKEG(EHLNDLIDPNK OKGKHEELBLB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6F569F0", Offset = "0x6F55DF0", VA = "0x186F569F0", Slot = "4")]
			public void NODAGBIOAMB(ScriptableRenderContext NMIKEFKOPMC, RenderingData DKEEFMEBNDL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class DLEDNIIFNGP : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string BKAHJEMNHAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly EHLNDLIDPNK OKGKHEELBLB;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F571D0", Offset = "0x6F565D0", VA = "0x186F571D0")]
			public DLEDNIIFNGP(RenderPassEvent DBNKKPNHHLP, EHLNDLIDPNK OKGKHEELBLB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6F56EC0", Offset = "0x6F562C0", VA = "0x186F56EC0", Slot = "9")]
			public override void Execute(ScriptableRenderContext NMIKEFKOPMC, RenderingData DKEEFMEBNDL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<LIMBNEJGLBK> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private DCFCKBBDKEG fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private DLEDNIIFNGP fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private EHLNDLIDPNK sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F57B70", Offset = "0x6F56F70", VA = "0x186F57B70", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F57F00", Offset = "0x6F57300", VA = "0x186F57F00", Slot = "9")]
		protected override void Dispose(bool FMELNOHAIIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F57AD0", Offset = "0x6F56ED0", VA = "0x186F57AD0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CODANAEIMCO, RenderingData DKEEFMEBNDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xE95430", Offset = "0xE94830", VA = "0x180E95430")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LIMBNEJGLBK
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LLFMKFPDFIP(CommandBuffer EOLELAMEJHO, Camera CDBAEHIFHOD, [NotNull] UniversalAdditionalCameraData PGAMGHKJOCH, bool KCNBIJHHIME);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LAPHBJJJLML(Camera CDBAEHIFHOD, CommandBuffer IBAOLAHLJEB);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Fade")]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct MLDDPFCLFBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float KDOLGJOHAFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public float HGEIIICLGMC;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private class MODDDCCNBCM : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string PDJJGPBDCLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler MMJOCBAKNMM;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int EJDMDMPGDPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private Material OPMONCDAOIC;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6F58D90", Offset = "0x6F58190", VA = "0x186F58D90")]
			public MODDDCCNBCM(RenderPassEvent DBNKKPNHHLP, Material JOFMGPCHADM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6F589B0", Offset = "0x6F57DB0", VA = "0x186F589B0", Slot = "9")]
			public override void Execute(ScriptableRenderContext NMIKEFKOPMC, RenderingData DKEEFMEBNDL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static MLDDPFCLFBP CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private MODDDCCNBCM m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x6F59140", Offset = "0x6F58540", VA = "0x186F59140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6F590F0", Offset = "0x6F584F0", VA = "0x186F590F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F58F40", Offset = "0x6F58340", VA = "0x186F58F40", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F58E70", Offset = "0x6F58270", VA = "0x186F58E70", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CODANAEIMCO, RenderingData DKEEFMEBNDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xE95430", Offset = "0xE94830", VA = "0x180E95430")]
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
		public struct GHBMAKJNPEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float NOIHJHONFND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Color MLNDGEGCFEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Mesh JDKKEOGLPKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AnimationCurve OFJPKPOJGCJ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public sealed class NLOMBAKPOCK : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static readonly string PDJJGPBDCLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private ProfilingSampler MMJOCBAKNMM;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static readonly int ENAPOCBHNHF;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static readonly int HPJDKMNBNKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Material OPMONCDAOIC;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F59790", Offset = "0x6F58B90", VA = "0x186F59790")]
			public NLOMBAKPOCK(RenderPassEvent DBNKKPNHHLP, Material JOFMGPCHADM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F594D0", Offset = "0x6F588D0", VA = "0x186F594D0", Slot = "9")]
			public override void Execute(ScriptableRenderContext NMIKEFKOPMC, RenderingData DKEEFMEBNDL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static GHBMAKJNPEC CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private NLOMBAKPOCK m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x6F59470", Offset = "0x6F58870", VA = "0x186F59470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F592C0", Offset = "0x6F586C0", VA = "0x186F592C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F591A0", Offset = "0x6F585A0", VA = "0x186F591A0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CODANAEIMCO, RenderingData DKEEFMEBNDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xE95430", Offset = "0xE94830", VA = "0x180E95430")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string BJHLLFNGPNL
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool OIBGBJLOJMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer IBAOLAHLJEB, ScriptableRenderContext NMIKEFKOPMC, RenderingData DKEEFMEBNDL);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x84C210", Offset = "0x84B610", VA = "0x18084C210")]
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
		private class JAOOPIBAGJI : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private bool HIPMJCCHJIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private readonly List<PerCameraRenderEffect> CDFBFJCJOEC;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private static readonly List<PerCameraRenderEffect> ALNKJPOALMD;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F58830", Offset = "0x6F57C30", VA = "0x186F58830")]
			public JAOOPIBAGJI(RenderPassEvent DBNKKPNHHLP, bool HIPMJCCHJIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F584B0", Offset = "0x6F578B0", VA = "0x186F584B0")]
			public bool PMFOGEPMGPC(CameraData PGAMGHKJOCH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F58200", Offset = "0x6F57600", VA = "0x186F58200", Slot = "9")]
			public override void Execute(ScriptableRenderContext NMIKEFKOPMC, RenderingData DKEEFMEBNDL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F583D0", Offset = "0x6F577D0", VA = "0x186F583D0")]
			private void FPPHNCANCAP(PerCameraRenderEffect DKJLOJIHPLC, ScriptableRenderContext NMIKEFKOPMC, RenderingData DKEEFMEBNDL)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private JAOOPIBAGJI m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private JAOOPIBAGJI m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A290", Offset = "0x6F59690", VA = "0x186F5A290", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A200", Offset = "0x6F59600", VA = "0x186F5A200", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CODANAEIMCO, RenderingData DKEEFMEBNDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xE95430", Offset = "0xE94830", VA = "0x180E95430")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F5A4E0", Offset = "0x6F598E0", VA = "0x186F5A4E0")]
		public static void KPELLOHMDKO(ScriptableRenderPass CIIKAPHOJJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5A340", Offset = "0x6F59740", VA = "0x186F5A340", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CODANAEIMCO, RenderingData DKEEFMEBNDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xE95430", Offset = "0xE94830", VA = "0x180E95430")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JAKFKNNBOFI
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly BADOKLEEAHE CNCKEEMBMMA;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly BADOKLEEAHE IJEFPCEPDHB;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly BADOKLEEAHE KBEPMJGFKKL;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly BADOKLEEAHE MFLCEIPKEHA;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DGJJLKFNMLA
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int? BFLAIKOIIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOIAFPGFPOJ();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EJKJLNONIDE : DGJJLKFNMLA
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly BADOKLEEAHE MMCLBKHCHDA;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly string GPEHBGIIPPJ;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly string FHOALCFOPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private GKCKIEBCDOA LPKFLGMOOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int? HCOIGABIBDI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int? BFLAIKOIIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x858860", Offset = "0x857C60", VA = "0x180858860")]
	[UnityEngine.Scripting.Preserve]
	public EJKJLNONIDE([NCPIDBJOPHL(null)][NotNull] GKCKIEBCDOA EDGLICBLNJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F576E0", Offset = "0x6F56AE0", VA = "0x186F576E0")]
	[UsedImplicitly]
	[EAMANMFIEOM(LALOBMMKLJJ.Session, NBICBCAKHEI.GameOnly)]
	public static void BEIACLNIGMD(NFLAEHJHNPL IFELLLJKHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F577E0", Offset = "0x6F56BE0", VA = "0x186F577E0", Slot = "5")]
	public void BOIAFPGFPOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F57340", Offset = "0x6F56740", VA = "0x186F57340")]
	private void AMDGPEANAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F578E0", Offset = "0x6F56CE0", VA = "0x186F578E0")]
	private bool PBKELNLCFOB(string GENIHEJOBBL, [Out] IIJBBNKDOPL HNKGKLGPEKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class ODDDADMKEOC
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static Mesh KDIGICPMMPL;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F5A0D0", Offset = "0x6F594D0", VA = "0x186F5A0D0")]
	public static Mesh NLKLODAJNLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F59870", Offset = "0x6F58C70", VA = "0x186F59870")]
	public static Matrix4x4 FIONNAHICGO(Camera CDBAEHIFHOD, bool LLFKMHHIGJC = false, bool KOCCEHDLKEJ = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F59D10", Offset = "0x6F59110", VA = "0x186F59D10")]
	private static Mesh LJFHJADNPPI()
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
