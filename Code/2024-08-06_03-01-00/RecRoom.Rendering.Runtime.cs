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
	public class LogRegistrationIndex : MHGCIIOBNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7008010", Offset = "0x7006610", VA = "0x187008010", Slot = "4")]
		public override void OOMCOBOGONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
		public enum OBCMLMMJMKD
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface MGOIAPCONKP
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void GKIHIBGHNMF(ScriptableRenderContext MGIHCPMKPNG, List<Camera> AHODDCFLICM);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface LLIABKBLANF
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void GKIHIBGHNMF(ScriptableRenderContext MGIHCPMKPNG, RenderingData AGIMGNDHLBG);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class HMJFPPKBNGH : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7007750", Offset = "0x7005D50", VA = "0x187007750")]
			public HMJFPPKBNGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x70076F0", Offset = "0x7005CF0", VA = "0x1870076F0", Slot = "9")]
			public override void Execute(ScriptableRenderContext MGIHCPMKPNG, RenderingData AGIMGNDHLBG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private HMJFPPKBNGH _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<MGOIAPCONKP> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<MGOIAPCONKP> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<LLIABKBLANF> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<LLIABKBLANF> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x700A140", Offset = "0x7008740", VA = "0x18700A140")]
		public static void PIMFHBFGHNO(OBCMLMMJMKD OLAAEOGAMFA, MGOIAPCONKP CALNHMJHCBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7009FC0", Offset = "0x70085C0", VA = "0x187009FC0")]
		public static void LMGBHMMKKBO(OBCMLMMJMKD OLAAEOGAMFA, MGOIAPCONKP CALNHMJHCBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x700A200", Offset = "0x7008800", VA = "0x18700A200")]
		public static void PIMFHBFGHNO(OBCMLMMJMKD OLAAEOGAMFA, LLIABKBLANF HEDOJFMBINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x700A080", Offset = "0x7008680", VA = "0x18700A080")]
		public static void LMGBHMMKKBO(OBCMLMMJMKD OLAAEOGAMFA, LLIABKBLANF HEDOJFMBINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x70092D0", Offset = "0x70078D0", VA = "0x1870092D0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7009230", Offset = "0x7007830", VA = "0x187009230", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AEAIBJINKNK, RenderingData AGIMGNDHLBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x70094B0", Offset = "0x7007AB0", VA = "0x1870094B0", Slot = "9")]
		protected override void Dispose(bool PLNPBNNLMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7009AE0", Offset = "0x70080E0", VA = "0x187009AE0")]
		private static void LJILOBGOOGD(ScriptableRenderContext MGIHCPMKPNG, List<Camera> AHODDCFLICM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x70095C0", Offset = "0x7007BC0", VA = "0x1870095C0")]
		private static void HDIOOAPLLHP(ScriptableRenderContext MGIHCPMKPNG, List<Camera> AHODDCFLICM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7009630", Offset = "0x7007C30", VA = "0x187009630")]
		private static void KGFFIEDAAJF(ScriptableRenderContext MGIHCPMKPNG, RenderingData AGIMGNDHLBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xE9DA30", Offset = "0xE9C030", VA = "0x180E9DA30")]
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
		private class CCJPMPMDGCA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool IMFAKNOEHOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<AJAJKPINIMC> GLMCPGLLBKK;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x70061B0", Offset = "0x70047B0", VA = "0x1870061B0")]
			public CCJPMPMDGCA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class DFONCPOIGPG : PreRenderManager.LLIABKBLANF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string GLFHLDBAKME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler CIFEFDPFBOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly CCJPMPMDGCA PDEMAHLBCLH;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7006640", Offset = "0x7004C40", VA = "0x187006640")]
			public DFONCPOIGPG(CCJPMPMDGCA FKGIIFDNCHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7006240", Offset = "0x7004840", VA = "0x187006240", Slot = "4")]
			public void GKIHIBGHNMF(ScriptableRenderContext MGIHCPMKPNG, RenderingData AGIMGNDHLBG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class IMKJOJHFDJC : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string CFCHBLMDPFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly CCJPMPMDGCA FKGIIFDNCHF;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7007F30", Offset = "0x7006530", VA = "0x187007F30")]
			public IMKJOJHFDJC(RenderPassEvent MHJNANNAHCF, CCJPMPMDGCA FKGIIFDNCHF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7007C20", Offset = "0x7006220", VA = "0x187007C20", Slot = "9")]
			public override void Execute(ScriptableRenderContext MGIHCPMKPNG, RenderingData AGIMGNDHLBG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<AJAJKPINIMC> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private DFONCPOIGPG fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private IMKJOJHFDJC fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private CCJPMPMDGCA sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7006790", Offset = "0x7004D90", VA = "0x187006790", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7006B10", Offset = "0x7005110", VA = "0x187006B10", Slot = "9")]
		protected override void Dispose(bool PLNPBNNLMBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7006700", Offset = "0x7004D00", VA = "0x187006700", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AEAIBJINKNK, RenderingData AGIMGNDHLBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xE9DA30", Offset = "0xE9C030", VA = "0x180E9DA30")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AJAJKPINIMC
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool DIPHJCAELLI(CommandBuffer BKLEGIBMKFB, Camera GNOGFNJOJME, [NotNull] UniversalAdditionalCameraData HALKHKEPOBE, bool DKBLFMKIJEN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMGNJDKHADJ(Camera GNOGFNJOJME, CommandBuffer AGJPBCCDBDK);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Fade")]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct MFGOIDNANHF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float FMEJAJCDGHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public float PIHBCPHEAMO;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private class IBDGFEIMKIE : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string EEGMJGBCOMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler NIHGPOBPNPI;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int AGOCLCEAIDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private Material FENGJGJOGOL;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7007B40", Offset = "0x7006140", VA = "0x187007B40")]
			public IBDGFEIMKIE(RenderPassEvent MHJNANNAHCF, Material JFOAGNGANHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7007770", Offset = "0x7005D70", VA = "0x187007770", Slot = "9")]
			public override void Execute(ScriptableRenderContext MGIHCPMKPNG, RenderingData AGIMGNDHLBG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static MFGOIDNANHF CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private IBDGFEIMKIE m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x70083B0", Offset = "0x70069B0", VA = "0x1870083B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7008360", Offset = "0x7006960", VA = "0x187008360")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x70081B0", Offset = "0x70067B0", VA = "0x1870081B0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x70080E0", Offset = "0x70066E0", VA = "0x1870080E0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AEAIBJINKNK, RenderingData AGIMGNDHLBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xE9DA30", Offset = "0xE9C030", VA = "0x180E9DA30")]
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
		public struct ECMCBCDOKCK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float FAMGBKMDDKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Color KNDPMBJPICF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Mesh GAMLNCIONAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AnimationCurve CJMGCIEIJLP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public sealed class BDGFECPOEFI : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static readonly string EEGMJGBCOMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private ProfilingSampler NIHGPOBPNPI;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static readonly int NICENGOKIPO;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static readonly int JOKGMGCMFMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Material FENGJGJOGOL;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x70060D0", Offset = "0x70046D0", VA = "0x1870060D0")]
			public BDGFECPOEFI(RenderPassEvent MHJNANNAHCF, Material JFOAGNGANHG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7005E30", Offset = "0x7004430", VA = "0x187005E30", Slot = "9")]
			public override void Execute(ScriptableRenderContext MGIHCPMKPNG, RenderingData AGIMGNDHLBG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static ECMCBCDOKCK CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private BDGFECPOEFI m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x70086C0", Offset = "0x7006CC0", VA = "0x1870086C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7008510", Offset = "0x7006B10", VA = "0x187008510", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7008400", Offset = "0x7006A00", VA = "0x187008400", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AEAIBJINKNK, RenderingData AGIMGNDHLBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xE9DA30", Offset = "0xE9C030", VA = "0x180E9DA30")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string PHJPJEAAHLH
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool PBDNKIMJFDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer AGJPBCCDBDK, ScriptableRenderContext MGIHCPMKPNG, RenderingData AGIMGNDHLBG);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85E9D0", Offset = "0x85CFD0", VA = "0x18085E9D0")]
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
		private class NAKOOJEJKEP : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private bool MMNGPDMOKBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private readonly List<PerCameraRenderEffect> AAOHBHMKGJB;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private static readonly List<PerCameraRenderEffect> JHAGHFNNIIF;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7008D30", Offset = "0x7007330", VA = "0x187008D30")]
			public NAKOOJEJKEP(RenderPassEvent MHJNANNAHCF, bool MMNGPDMOKBI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x70088E0", Offset = "0x7006EE0", VA = "0x1870088E0")]
			public bool FDJHNDOCOED(CameraData HALKHKEPOBE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7008710", Offset = "0x7006D10", VA = "0x187008710", Slot = "9")]
			public override void Execute(ScriptableRenderContext MGIHCPMKPNG, RenderingData AGIMGNDHLBG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7008BC0", Offset = "0x70071C0", VA = "0x187008BC0")]
			private void LNIMOKICGON(PerCameraRenderEffect IKOODNCMFJP, ScriptableRenderContext MGIHCPMKPNG, RenderingData AGIMGNDHLBG)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private NAKOOJEJKEP m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private NAKOOJEJKEP m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7008E70", Offset = "0x7007470", VA = "0x187008E70", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7008DE0", Offset = "0x70073E0", VA = "0x187008DE0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AEAIBJINKNK, RenderingData AGIMGNDHLBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xE9DA30", Offset = "0xE9C030", VA = "0x180E9DA30")]
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
		[Cpp2IlInjected.Address(RVA = "0x70090C0", Offset = "0x70076C0", VA = "0x1870090C0")]
		public static void MJMABABOEPG(ScriptableRenderPass DAHOGNDEIIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7008F20", Offset = "0x7007520", VA = "0x187008F20", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer AEAIBJINKNK, RenderingData AGIMGNDHLBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xE9DA30", Offset = "0xE9C030", VA = "0x180E9DA30")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HDMNOFEHAEF
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly CHNLCLDOCNE OBGBFOHADCN;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly CHNLCLDOCNE MABAJGFDFJK;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly CHNLCLDOCNE EGGMEFHAHMI;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly CHNLCLDOCNE HCAMIPFJJFI;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface MJNFFPOGNCN
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int? IFFEHKOKNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ACPALMMMOIH();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class APAOABBKEFJ : MJNFFPOGNCN
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly CHNLCLDOCNE CNCAEGCNGHI;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly string PGEEEMHLPIF;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly string PKMNNANLHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private BBFOFLHBLBK DHFDGFOKHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private int? BHAHALBADHM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int? IFFEHKOKNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8682B0", Offset = "0x8668B0", VA = "0x1808682B0")]
	[UnityEngine.Scripting.Preserve]
	public APAOABBKEFJ([JLPFJOFFNLM(null)][NotNull] BBFOFLHBLBK JHLHJKLAENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7005C40", Offset = "0x7004240", VA = "0x187005C40")]
	[UsedImplicitly]
	[CCEDJDOPMOE(GIKFHLNFMKF.Session, CFIDNIINJOK.GameOnly)]
	public static void PPDHKFAPNCN(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x70056D0", Offset = "0x7003CD0", VA = "0x1870056D0", Slot = "5")]
	public void ACPALMMMOIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x70057D0", Offset = "0x7003DD0", VA = "0x1870057D0")]
	private void AEEPEBONDBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7005B60", Offset = "0x7004160", VA = "0x187005B60")]
	private bool KBJJIEGBNDC(string PJPDOLBDKFI, [Out] FOOECFICNGH DCHJNBHMHJP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class GNOFHEAGNDP
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static Mesh DINCEADMMPI;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x70071A0", Offset = "0x70057A0", VA = "0x1870071A0")]
	public static Mesh KDHGEHIJLHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7006D00", Offset = "0x7005300", VA = "0x187006D00")]
	public static Matrix4x4 JPNBLGECJHD(Camera GNOGFNJOJME, bool MPOACOLLCFH = false, bool ODEOEMAOONK = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7007240", Offset = "0x7005840", VA = "0x187007240")]
	private static Mesh OKPLCDJHBHE()
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
