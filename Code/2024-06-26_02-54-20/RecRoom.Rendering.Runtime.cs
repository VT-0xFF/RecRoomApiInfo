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
	public class LogRegistrationIndex : DAMGOKPKJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F97DD0", Offset = "0x6F963D0", VA = "0x186F97DD0", Slot = "4")]
		public override void PIKNDMFIIPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
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
		public enum PMBIBODBLCA
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface DLLOEGFKEIH
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void KBOIAJIAKAK(ScriptableRenderContext FFHIJMOJNAI, List<Camera> FFPPKOEPBAP);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface PDNDOFBMBMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void KBOIAJIAKAK(ScriptableRenderContext FFHIJMOJNAI, RenderingData GLMJBPCLION);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class PAFJPMDPHEN : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6F98C40", Offset = "0x6F97240", VA = "0x186F98C40")]
			public PAFJPMDPHEN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6F98BE0", Offset = "0x6F971E0", VA = "0x186F98BE0", Slot = "9")]
			public override void Execute(ScriptableRenderContext FFHIJMOJNAI, RenderingData GLMJBPCLION)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private PAFJPMDPHEN _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<DLLOEGFKEIH> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<DLLOEGFKEIH> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<PDNDOFBMBMB> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<PDNDOFBMBMB> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F99410", Offset = "0x6F97A10", VA = "0x186F99410")]
		public static void DNJLIIKKAJA(PMBIBODBLCA KEMBEHEMJIM, DLLOEGFKEIH LOGIKMMLOHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F9A040", Offset = "0x6F98640", VA = "0x186F9A040")]
		public static void PAJKBLFBOII(PMBIBODBLCA KEMBEHEMJIM, DLLOEGFKEIH LOGIKMMLOHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F99350", Offset = "0x6F97950", VA = "0x186F99350")]
		public static void DNJLIIKKAJA(PMBIBODBLCA KEMBEHEMJIM, PDNDOFBMBMB OFFPGMIECEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F9A100", Offset = "0x6F98700", VA = "0x186F9A100")]
		public static void PAJKBLFBOII(PMBIBODBLCA KEMBEHEMJIM, PDNDOFBMBMB OFFPGMIECEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F99160", Offset = "0x6F97760", VA = "0x186F99160", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F990B0", Offset = "0x6F976B0", VA = "0x186F990B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer APJGPLFHDMA, RenderingData GLMJBPCLION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F994D0", Offset = "0x6F97AD0", VA = "0x186F994D0", Slot = "9")]
		protected override void Dispose(bool OJLMIOJBNDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F99650", Offset = "0x6F97C50", VA = "0x186F99650")]
		private static void LBEELBCCMPM(ScriptableRenderContext FFHIJMOJNAI, List<Camera> FFPPKOEPBAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F995E0", Offset = "0x6F97BE0", VA = "0x186F995E0")]
		private static void IBBIEJFKODJ(ScriptableRenderContext FFHIJMOJNAI, List<Camera> FFPPKOEPBAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F99B60", Offset = "0x6F98160", VA = "0x186F99B60")]
		private static void NNEKLPKLGLM(ScriptableRenderContext FFHIJMOJNAI, RenderingData GLMJBPCLION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xDB0720", Offset = "0xDAED20", VA = "0x180DB0720")]
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
		private class BHGDPNCKLLC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool CCHJMMDBABJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<MKNJGNFBNFN> PCCCNPOLFNP;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6F95620", Offset = "0x6F93C20", VA = "0x186F95620")]
			public BHGDPNCKLLC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class LFHACMDHGBA : PreRenderManager.PDNDOFBMBMB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string DFIBMJFAJHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler GFJODMBFALK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly BHGDPNCKLLC PKBJNJFKOLG;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6F97D10", Offset = "0x6F96310", VA = "0x186F97D10")]
			public LFHACMDHGBA(BHGDPNCKLLC JLELLPCPDIE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6F97900", Offset = "0x6F95F00", VA = "0x186F97900", Slot = "4")]
			public void KBOIAJIAKAK(ScriptableRenderContext FFHIJMOJNAI, RenderingData GLMJBPCLION)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class FEJKHCPELOH : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string EKKJCOHJLIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly BHGDPNCKLLC JLELLPCPDIE;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F96D50", Offset = "0x6F95350", VA = "0x186F96D50")]
			public FEJKHCPELOH(RenderPassEvent DJLOOOABJHF, BHGDPNCKLLC JLELLPCPDIE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6F96A40", Offset = "0x6F95040", VA = "0x186F96A40", Slot = "9")]
			public override void Execute(ScriptableRenderContext FFHIJMOJNAI, RenderingData GLMJBPCLION)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<MKNJGNFBNFN> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private LFHACMDHGBA fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private FEJKHCPELOH fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private BHGDPNCKLLC sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F96ED0", Offset = "0x6F954D0", VA = "0x186F96ED0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F97260", Offset = "0x6F95860", VA = "0x186F97260", Slot = "9")]
		protected override void Dispose(bool OJLMIOJBNDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F96E30", Offset = "0x6F95430", VA = "0x186F96E30", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer APJGPLFHDMA, RenderingData GLMJBPCLION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xDB0720", Offset = "0xDAED20", VA = "0x180DB0720")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MKNJGNFBNFN
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MCMIJDBKCAA(CommandBuffer CGNFFCMFFMD, Camera CMPADPIDKEM, [NotNull] UniversalAdditionalCameraData DHDJCJBPJIF, bool CKMDLHFNKEJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CHEHEGBOGDC(Camera CMPADPIDKEM, CommandBuffer MCPJPPLMPIG);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Fade")]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct OMLLCBAENMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float NJBBCLEOGMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public float NKJAICBMJGO;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private class EGJMNNLMHEB : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string AMBADPMGOCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler GLNBHJOJDBO;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int LJCILKKHEMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private Material AMKCFCBMNGD;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6F96960", Offset = "0x6F94F60", VA = "0x186F96960")]
			public EGJMNNLMHEB(RenderPassEvent DJLOOOABJHF, Material EGLABJPOFKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6F96580", Offset = "0x6F94B80", VA = "0x186F96580", Slot = "9")]
			public override void Execute(ScriptableRenderContext FFHIJMOJNAI, RenderingData GLMJBPCLION)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static OMLLCBAENMO CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private EGJMNNLMHEB m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x6F98170", Offset = "0x6F96770", VA = "0x186F98170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6F98120", Offset = "0x6F96720", VA = "0x186F98120")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6F97F70", Offset = "0x6F96570", VA = "0x186F97F70", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F97EA0", Offset = "0x6F964A0", VA = "0x186F97EA0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer APJGPLFHDMA, RenderingData GLMJBPCLION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xDB0720", Offset = "0xDAED20", VA = "0x180DB0720")]
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
		public struct NEPDNNNACGO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float APPEFKPKFMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Color EHCJBEAHJLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Mesh AIONBBNEPFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AnimationCurve HMHJDGANICB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public sealed class HPFIEDJDBNO : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static readonly string AMBADPMGOCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private ProfilingSampler GLNBHJOJDBO;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static readonly int KLJMBDEABPI;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static readonly int GLLOHPBHMIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Material AMKCFCBMNGD;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F97820", Offset = "0x6F95E20", VA = "0x186F97820")]
			public HPFIEDJDBNO(RenderPassEvent DJLOOOABJHF, Material EGLABJPOFKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F97560", Offset = "0x6F95B60", VA = "0x186F97560", Slot = "9")]
			public override void Execute(ScriptableRenderContext FFHIJMOJNAI, RenderingData GLMJBPCLION)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static NEPDNNNACGO CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private HPFIEDJDBNO m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x6F984A0", Offset = "0x6F96AA0", VA = "0x186F984A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F982F0", Offset = "0x6F968F0", VA = "0x186F982F0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F981D0", Offset = "0x6F967D0", VA = "0x186F981D0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer APJGPLFHDMA, RenderingData GLMJBPCLION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xDB0720", Offset = "0xDAED20", VA = "0x180DB0720")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string MECGANNIIND
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool BGIMBHFEILO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer MCPJPPLMPIG, ScriptableRenderContext FFHIJMOJNAI, RenderingData GLMJBPCLION);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x863340", Offset = "0x861940", VA = "0x180863340")]
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
		private class NJBIDAEEJBA : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private bool FJPBAECDBHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private readonly List<PerCameraRenderEffect> FMCILLNAMBD;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private static readonly List<PerCameraRenderEffect> GDEOFEFNHDC;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F98B30", Offset = "0x6F97130", VA = "0x186F98B30")]
			public NJBIDAEEJBA(RenderPassEvent DJLOOOABJHF, bool FJPBAECDBHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F986D0", Offset = "0x6F96CD0", VA = "0x186F986D0")]
			public bool POEMMNCIOIO(CameraData DHDJCJBPJIF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F98500", Offset = "0x6F96B00", VA = "0x186F98500", Slot = "9")]
			public override void Execute(ScriptableRenderContext FFHIJMOJNAI, RenderingData GLMJBPCLION)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F989C0", Offset = "0x6F96FC0", VA = "0x186F989C0")]
			private void PPEEJBFCJOG(PerCameraRenderEffect AMILNLINGEA, ScriptableRenderContext FFHIJMOJNAI, RenderingData GLMJBPCLION)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private NJBIDAEEJBA m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NJBIDAEEJBA m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F98CF0", Offset = "0x6F972F0", VA = "0x186F98CF0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F98C60", Offset = "0x6F97260", VA = "0x186F98C60", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer APJGPLFHDMA, RenderingData GLMJBPCLION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xDB0720", Offset = "0xDAED20", VA = "0x180DB0720")]
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
		[Cpp2IlInjected.Address(RVA = "0x6F98F40", Offset = "0x6F97540", VA = "0x186F98F40")]
		public static void JHHGMKIENEN(ScriptableRenderPass MHAGOBGDIAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6F98DA0", Offset = "0x6F973A0", VA = "0x186F98DA0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer APJGPLFHDMA, RenderingData GLMJBPCLION)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xDB0720", Offset = "0xDAED20", VA = "0x180DB0720")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class GIMMMLJPMLO
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly ICJNMGNJFIN KFCPPHCDOEN;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly ICJNMGNJFIN KHJOFCNLMCP;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly ICJNMGNJFIN DFFFHFPJCEJ;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly ICJNMGNJFIN MEGJEBAFLJI;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OONHJPMBICK
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OJJFKLJIKFA();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CLNNELEOGKA : OONHJPMBICK
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly string NACFPIEJHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private KKBDEFJOIBO INBNEPBAMHJ;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x869B90", Offset = "0x868190", VA = "0x180869B90")]
	[UnityEngine.Scripting.Preserve]
	public CLNNELEOGKA([JFHFHOOOEKP(null)][NotNull] KKBDEFJOIBO LJADODFIPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F959A0", Offset = "0x6F93FA0", VA = "0x186F959A0")]
	[UsedImplicitly]
	[PECFDJPHGEK(HCAAGBIMBOB.Session, BOIKMOKIOJG.GameOnly)]
	public static void NGGAKNMHICL(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F95AA0", Offset = "0x6F940A0", VA = "0x186F95AA0", Slot = "4")]
	public void OJJFKLJIKFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F95790", Offset = "0x6F93D90", VA = "0x186F95790")]
	private void MBMADNIOGBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F956B0", Offset = "0x6F93CB0", VA = "0x186F956B0")]
	private bool GPLLMIHHGAI(string IHCPJEMPLLO, [Out] FJDHNPAOKKO KHCIIHCNJMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class DAPIPEDNEIA
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static Mesh EJOIDNJKKFK;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F964D0", Offset = "0x6F94AD0", VA = "0x186F964D0")]
	public static Mesh MGEIMLMMKKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F95C70", Offset = "0x6F94270", VA = "0x186F95C70")]
	public static Matrix4x4 KEKEJLAFJBM(Camera CMPADPIDKEM, bool OFMILHLGEHM = false, bool NIIDAMEIFFM = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F96110", Offset = "0x6F94710", VA = "0x186F96110")]
	private static Mesh MEEABOGIHNA()
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
