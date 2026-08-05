using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Logging.Attributes;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rendering_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : JOPFPPBONLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7229BD0", Offset = "0x72285D0", VA = "0x187229BD0", Slot = "4")]
		public override void HEDMFNKAECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
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
		public enum OHGEDJKMFMG
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface LLELFJHAACA
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void AAPMEMGCMFN(ScriptableRenderContext GJGBLLHIOAC, List<Camera> OIKCLCPOIKD);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface OBILAJIICKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void AAPMEMGCMFN(ScriptableRenderContext GJGBLLHIOAC, RenderingData GADGPDKEOAL);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class NOIEKFNAPOI : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x722B420", Offset = "0x7229E20", VA = "0x18722B420")]
			public NOIEKFNAPOI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x722B3C0", Offset = "0x7229DC0", VA = "0x18722B3C0", Slot = "9")]
			public override void Execute(ScriptableRenderContext GJGBLLHIOAC, RenderingData GADGPDKEOAL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private NOIEKFNAPOI _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<LLELFJHAACA> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<LLELFJHAACA> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<OBILAJIICKJ> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<OBILAJIICKJ> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x722C860", Offset = "0x722B260", VA = "0x18722C860")]
		public static void LOMNPOPACNJ(OHGEDJKMFMG NNOPAJMMHMO, LLELFJHAACA FNDOKHBMCHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x722C230", Offset = "0x722AC30", VA = "0x18722C230")]
		public static void GBBPPPLKACC(OHGEDJKMFMG NNOPAJMMHMO, LLELFJHAACA FNDOKHBMCHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x722C7A0", Offset = "0x722B1A0", VA = "0x18722C7A0")]
		public static void LOMNPOPACNJ(OHGEDJKMFMG NNOPAJMMHMO, OBILAJIICKJ DGGGACGFOJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x722C170", Offset = "0x722AB70", VA = "0x18722C170")]
		public static void GBBPPPLKACC(OHGEDJKMFMG NNOPAJMMHMO, OBILAJIICKJ DGGGACGFOJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x722B9A0", Offset = "0x722A3A0", VA = "0x18722B9A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x722B890", Offset = "0x722A290", VA = "0x18722B890", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AAPNFNNCHNO, RenderingData GADGPDKEOAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x722BB80", Offset = "0x722A580", VA = "0x18722BB80", Slot = "9")]
		protected override void Dispose(bool AFGFOHKHPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x722BC90", Offset = "0x722A690", VA = "0x18722BC90")]
		private static void EOCPENFDLHB(ScriptableRenderContext GJGBLLHIOAC, List<Camera> OIKCLCPOIKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x722B930", Offset = "0x722A330", VA = "0x18722B930")]
		private static void BDBGOCHBAJO(ScriptableRenderContext GJGBLLHIOAC, List<Camera> OIKCLCPOIKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x722C2F0", Offset = "0x722ACF0", VA = "0x18722C2F0")]
		private static void GIDGMANFAKD(ScriptableRenderContext GJGBLLHIOAC, RenderingData GADGPDKEOAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xF4FCD0", Offset = "0xF4E6D0", VA = "0x180F4FCD0")]
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
		private class FCDFFPGPPEH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool PHIFHMDPAKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<KKJPJKLBHJK> AOGDPBPJHPO;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7228FA0", Offset = "0x72279A0", VA = "0x187228FA0")]
			public FCDFFPGPPEH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class KHDKDKIOMEK : PreRenderManager.OBILAJIICKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string FCFAJHGJMJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler LPBFCHIBMKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly FCDFFPGPPEH PJGJJGDPGPJ;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7229B10", Offset = "0x7228510", VA = "0x187229B10")]
			public KHDKDKIOMEK(FCDFFPGPPEH PKOHFJGIIDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7229720", Offset = "0x7228120", VA = "0x187229720", Slot = "4")]
			public void AAPMEMGCMFN(ScriptableRenderContext GJGBLLHIOAC, RenderingData GADGPDKEOAL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class AHCLIFJEHJO : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string FOAMPAOKJGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly FCDFFPGPPEH PKOHFJGIIDB;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x72287F0", Offset = "0x72271F0", VA = "0x1872287F0")]
			public AHCLIFJEHJO(RenderPassEvent CCMBJBOILED, FCDFFPGPPEH PKOHFJGIIDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x72284E0", Offset = "0x7226EE0", VA = "0x1872284E0", Slot = "9")]
			public override void Execute(ScriptableRenderContext GJGBLLHIOAC, RenderingData GADGPDKEOAL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<KKJPJKLBHJK> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private KHDKDKIOMEK fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private AHCLIFJEHJO fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private FCDFFPGPPEH sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x72290C0", Offset = "0x7227AC0", VA = "0x1872290C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7229440", Offset = "0x7227E40", VA = "0x187229440", Slot = "9")]
		protected override void Dispose(bool AFGFOHKHPAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7229030", Offset = "0x7227A30", VA = "0x187229030", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AAPNFNNCHNO, RenderingData GADGPDKEOAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xF4FCD0", Offset = "0xF4E6D0", VA = "0x180F4FCD0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KKJPJKLBHJK
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OEDLNGMNBAK(CommandBuffer EMGJEDGAEIE, Camera DDOBMGBAJJA, [NotNull] UniversalAdditionalCameraData FDEOBEJBAGJ, bool FFGCIMFOPGA);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HNEEDGOKFEF(Camera DDOBMGBAJJA, CommandBuffer JJIFFAIIHCG);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Fade")]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct OJJCGCKJJPM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float CBEGCNMPDFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public float OMJKBBICLCJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private class MNJELJCMLOG : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string DCDKBFBGODC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler LEBHKGJKECL;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int PAKODGPGDCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private Material NEKLOGELBPI;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x722A3B0", Offset = "0x7228DB0", VA = "0x18722A3B0")]
			public MNJELJCMLOG(RenderPassEvent CCMBJBOILED, Material MLMFHAHBCEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7229FE0", Offset = "0x72289E0", VA = "0x187229FE0", Slot = "9")]
			public override void Execute(ScriptableRenderContext GJGBLLHIOAC, RenderingData GADGPDKEOAL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static OJJCGCKJJPM CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private MNJELJCMLOG m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x722A760", Offset = "0x7229160", VA = "0x18722A760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x722A710", Offset = "0x7229110", VA = "0x18722A710")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x722A560", Offset = "0x7228F60", VA = "0x18722A560", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x722A490", Offset = "0x7228E90", VA = "0x18722A490", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AAPNFNNCHNO, RenderingData GADGPDKEOAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xF4FCD0", Offset = "0xF4E6D0", VA = "0x180F4FCD0")]
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
		public struct NDEHLEDJKFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float KIOFFPEONIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Color AOAILJKFKAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Mesh POKEIEDLNGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AnimationCurve FCGIHMGAMAI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public sealed class MDPAEBAOLBP : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static readonly string DCDKBFBGODC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private ProfilingSampler LEBHKGJKECL;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static readonly int KEHPJFDPMKF;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static readonly int BJLFEHKFCGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Material NEKLOGELBPI;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7229F00", Offset = "0x7228900", VA = "0x187229F00")]
			public MDPAEBAOLBP(RenderPassEvent CCMBJBOILED, Material MLMFHAHBCEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7229C60", Offset = "0x7228660", VA = "0x187229C60", Slot = "9")]
			public override void Execute(ScriptableRenderContext GJGBLLHIOAC, RenderingData GADGPDKEOAL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static NDEHLEDJKFA CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private MDPAEBAOLBP m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x722AA70", Offset = "0x7229470", VA = "0x18722AA70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x722A8C0", Offset = "0x72292C0", VA = "0x18722A8C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x722A7B0", Offset = "0x72291B0", VA = "0x18722A7B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AAPNFNNCHNO, RenderingData GADGPDKEOAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xF4FCD0", Offset = "0xF4E6D0", VA = "0x180F4FCD0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string AFMANDJAODF
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool ADMCHDCPKGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer JJIFFAIIHCG, ScriptableRenderContext GJGBLLHIOAC, RenderingData GADGPDKEOAL);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x884960", Offset = "0x883360", VA = "0x180884960")]
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
		private class AOANGIOPFPF : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private bool LJHOGFMNHNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private readonly List<PerCameraRenderEffect> JAPIGEJHLGB;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private static readonly List<PerCameraRenderEffect> BOGPAKAJLNH;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7228EF0", Offset = "0x72278F0", VA = "0x187228EF0")]
			public AOANGIOPFPF(RenderPassEvent CCMBJBOILED, bool LJHOGFMNHNA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7228AA0", Offset = "0x72274A0", VA = "0x187228AA0")]
			public bool FKNMENBLGLN(CameraData FDEOBEJBAGJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x72288D0", Offset = "0x72272D0", VA = "0x1872288D0", Slot = "9")]
			public override void Execute(ScriptableRenderContext GJGBLLHIOAC, RenderingData GADGPDKEOAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7228D80", Offset = "0x7227780", VA = "0x187228D80")]
			private void IJOABAPLIMJ(PerCameraRenderEffect DPFMGDJILPF, ScriptableRenderContext GJGBLLHIOAC, RenderingData GADGPDKEOAL)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private AOANGIOPFPF m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private AOANGIOPFPF m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x722B4D0", Offset = "0x7229ED0", VA = "0x18722B4D0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x722B440", Offset = "0x7229E40", VA = "0x18722B440", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AAPNFNNCHNO, RenderingData GADGPDKEOAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xF4FCD0", Offset = "0xF4E6D0", VA = "0x180F4FCD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x722B720", Offset = "0x722A120", VA = "0x18722B720")]
		public static void JLEPLPPEODK(ScriptableRenderPass CNLPCDADECI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x722B580", Offset = "0x7229F80", VA = "0x18722B580", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AAPNFNNCHNO, RenderingData GADGPDKEOAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xF4FCD0", Offset = "0xF4E6D0", VA = "0x180F4FCD0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class IJLLNHMKPLI
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly ANDGIEDMMDP KNMFMFHEOCI;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly ANDGIEDMMDP PLOEIKEADKO;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly ANDGIEDMMDP IHAMGAFKIJE;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly ANDGIEDMMDP OBAKBECOGFB;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class NKJDMMAKOAH
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static Mesh POFNDLAAGLM;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x722B320", Offset = "0x7229D20", VA = "0x18722B320")]
	public static Mesh OCMOKPLPOHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x722AE80", Offset = "0x7229880", VA = "0x18722AE80")]
	public static Matrix4x4 OBFJBMNONDL(Camera DDOBMGBAJJA, bool FEIBDNPBNHA = false, bool COFLGHCPMMB = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x722AAC0", Offset = "0x72294C0", VA = "0x18722AAC0")]
	private static Mesh NCFGHHAGCPN()
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
