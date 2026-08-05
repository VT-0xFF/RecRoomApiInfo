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
	public class LogRegistrationIndex : AGBKNAFJGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FE77F0", Offset = "0x6FE67F0", VA = "0x186FE77F0", Slot = "4")]
		public override void GGLLICMBJNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
		public enum MEGGPOGBNOM
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface ADMELDLCNKO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void ODIGKBLPPJN(ScriptableRenderContext PDLLDMABKGP, List<Camera> KENAJGJMEHI);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface KAJDFOLHECH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void ODIGKBLPPJN(ScriptableRenderContext PDLLDMABKGP, RenderingData LMJMAMMDCBA);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class JMALBEBCCBC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6FE76D0", Offset = "0x6FE66D0", VA = "0x186FE76D0")]
			public JMALBEBCCBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6FE7670", Offset = "0x6FE6670", VA = "0x186FE7670", Slot = "9")]
			public override void Execute(ScriptableRenderContext PDLLDMABKGP, RenderingData LMJMAMMDCBA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private JMALBEBCCBC _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<ADMELDLCNKO> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<ADMELDLCNKO> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<KAJDFOLHECH> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<KAJDFOLHECH> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8EE0", Offset = "0x6FE7EE0", VA = "0x186FE8EE0")]
		public static void IOPCDMLBLHM(MEGGPOGBNOM JNLFBFDBDAD, ADMELDLCNKO GLJHKBKPIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8D60", Offset = "0x6FE7D60", VA = "0x186FE8D60")]
		public static void INGJHIEHPCM(MEGGPOGBNOM JNLFBFDBDAD, ADMELDLCNKO GLJHKBKPIMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8E20", Offset = "0x6FE7E20", VA = "0x186FE8E20")]
		public static void IOPCDMLBLHM(MEGGPOGBNOM JNLFBFDBDAD, KAJDFOLHECH HANOFKDBAIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8CA0", Offset = "0x6FE7CA0", VA = "0x186FE8CA0")]
		public static void INGJHIEHPCM(MEGGPOGBNOM JNLFBFDBDAD, KAJDFOLHECH HANOFKDBAIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8930", Offset = "0x6FE7930", VA = "0x186FE8930", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8880", Offset = "0x6FE7880", VA = "0x186FE8880", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EIOJIOLKBHF, RenderingData LMJMAMMDCBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8B20", Offset = "0x6FE7B20", VA = "0x186FE8B20", Slot = "9")]
		protected override void Dispose(bool MJMBBEEHODB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FE9470", Offset = "0x6FE8470", VA = "0x186FE9470")]
		private static void PFIGMMEABIB(ScriptableRenderContext PDLLDMABKGP, List<Camera> KENAJGJMEHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8C30", Offset = "0x6FE7C30", VA = "0x186FE8C30")]
		private static void IAEJOCILDCB(ScriptableRenderContext PDLLDMABKGP, List<Camera> KENAJGJMEHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8FA0", Offset = "0x6FE7FA0", VA = "0x186FE8FA0")]
		private static void LCCNJEJOJCC(ScriptableRenderContext PDLLDMABKGP, RenderingData LMJMAMMDCBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xEA0340", Offset = "0xE9F340", VA = "0x180EA0340")]
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
		private class PKHINOPJKNG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool MAEANKOPKCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<BNEBLPNAKEK> HKAFGNNOLKL;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6FE83A0", Offset = "0x6FE73A0", VA = "0x186FE83A0")]
			public PKHINOPJKNG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class OFIILPPLAMO : PreRenderManager.KAJDFOLHECH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string KEMIDIAKKIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler OECLCJAFDHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly PKHINOPJKNG GDOKJDEDMJI;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6FE82E0", Offset = "0x6FE72E0", VA = "0x186FE82E0")]
			public OFIILPPLAMO(PKHINOPJKNG MBMKNGHFFIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6FE7EE0", Offset = "0x6FE6EE0", VA = "0x186FE7EE0", Slot = "4")]
			public void ODIGKBLPPJN(ScriptableRenderContext PDLLDMABKGP, RenderingData LMJMAMMDCBA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class DALKHBIMOLA : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string HLPNCLNDBLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly PKHINOPJKNG MBMKNGHFFIK;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6FE62B0", Offset = "0x6FE52B0", VA = "0x186FE62B0")]
			public DALKHBIMOLA(RenderPassEvent AAOINKFEEEH, PKHINOPJKNG MBMKNGHFFIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6FE5FA0", Offset = "0x6FE4FA0", VA = "0x186FE5FA0", Slot = "9")]
			public override void Execute(ScriptableRenderContext PDLLDMABKGP, RenderingData LMJMAMMDCBA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<BNEBLPNAKEK> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private OFIILPPLAMO fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private DALKHBIMOLA fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private PKHINOPJKNG sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6FE67D0", Offset = "0x6FE57D0", VA = "0x186FE67D0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6B60", Offset = "0x6FE5B60", VA = "0x186FE6B60", Slot = "9")]
		protected override void Dispose(bool MJMBBEEHODB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6FE6730", Offset = "0x6FE5730", VA = "0x186FE6730", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EIOJIOLKBHF, RenderingData LMJMAMMDCBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xEA0340", Offset = "0xE9F340", VA = "0x180EA0340")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BNEBLPNAKEK
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MCENAPPGIOK(CommandBuffer OFHOJLJGBAC, Camera JPOHLHNCEHN, [NotNull] UniversalAdditionalCameraData AOGHHDBLABN, bool NCCJNIHBNDM);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KONFEJGIKMB(Camera JPOHLHNCEHN, CommandBuffer AHCDKJKGIAJ);
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Fade")]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct CEGCFEJGBBK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public float MEKNGIBGDOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public float GNDPNCIDBAC;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		private class COGLHAOEKEN : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly string CGMLPODGDGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ProfilingSampler CCPHDOKILIB;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly int AMEJJHIJMCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private Material BMGGELPPICJ;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6FE5EC0", Offset = "0x6FE4EC0", VA = "0x186FE5EC0")]
			public COGLHAOEKEN(RenderPassEvent AAOINKFEEEH, Material JNFDDANGPCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6FE5AE0", Offset = "0x6FE4AE0", VA = "0x186FE5AE0", Slot = "9")]
			public override void Execute(ScriptableRenderContext PDLLDMABKGP, RenderingData LMJMAMMDCBA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static CEGCFEJGBBK CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private COGLHAOEKEN m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x6FE7B50", Offset = "0x6FE6B50", VA = "0x186FE7B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6FE7B00", Offset = "0x6FE6B00", VA = "0x186FE7B00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7950", Offset = "0x6FE6950", VA = "0x186FE7950", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7880", Offset = "0x6FE6880", VA = "0x186FE7880", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EIOJIOLKBHF, RenderingData LMJMAMMDCBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xEA0340", Offset = "0xE9F340", VA = "0x180EA0340")]
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
		public struct IDPCALMLOML
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public float EDFMDLKCHEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Color BMCAEDMLOED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Mesh OGMGNLKIMBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public AnimationCurve AICFBJCNNIE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public sealed class DFOFCHHNNBI : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static readonly string CGMLPODGDGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private ProfilingSampler CCPHDOKILIB;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static readonly int JAADLBFBNDD;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private static readonly int IKAKBJMFEJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private Material BMGGELPPICJ;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6FE6650", Offset = "0x6FE5650", VA = "0x186FE6650")]
			public DFOFCHHNNBI(RenderPassEvent AAOINKFEEEH, Material JNFDDANGPCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6FE6390", Offset = "0x6FE5390", VA = "0x186FE6390", Slot = "9")]
			public override void Execute(ScriptableRenderContext PDLLDMABKGP, RenderingData LMJMAMMDCBA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static IDPCALMLOML CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private DFOFCHHNNBI m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x6FE7E80", Offset = "0x6FE6E80", VA = "0x186FE7E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7CD0", Offset = "0x6FE6CD0", VA = "0x186FE7CD0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6FE7BB0", Offset = "0x6FE6BB0", VA = "0x186FE7BB0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EIOJIOLKBHF, RenderingData LMJMAMMDCBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xEA0340", Offset = "0xE9F340", VA = "0x180EA0340")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract string DFCDGKIPFGC
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public virtual bool MBNFADMJJHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x89A950", Offset = "0x899950", VA = "0x18089A950", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer AHCDKJKGIAJ, ScriptableRenderContext PDLLDMABKGP, RenderingData LMJMAMMDCBA);

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x853940", Offset = "0x852940", VA = "0x180853940")]
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
		private class AADJDLGJNPM : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private bool GAHBAEIDAFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private readonly List<PerCameraRenderEffect> EKLIABCHBMP;

			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private static readonly List<PerCameraRenderEffect> AGMCDHEPPFE;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6FE5A30", Offset = "0x6FE4A30", VA = "0x186FE5A30")]
			public AADJDLGJNPM(RenderPassEvent AAOINKFEEEH, bool GAHBAEIDAFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6FE5400", Offset = "0x6FE4400", VA = "0x186FE5400")]
			public bool CGPPMLPHELM(CameraData AOGHHDBLABN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6FE56F0", Offset = "0x6FE46F0", VA = "0x186FE56F0", Slot = "9")]
			public override void Execute(ScriptableRenderContext PDLLDMABKGP, RenderingData LMJMAMMDCBA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6FE58C0", Offset = "0x6FE48C0", VA = "0x186FE58C0")]
			private void JHINEHBBAHO(PerCameraRenderEffect LONBMHDIOJE, ScriptableRenderContext PDLLDMABKGP, RenderingData LMJMAMMDCBA)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private AADJDLGJNPM m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private AADJDLGJNPM m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6FE84C0", Offset = "0x6FE74C0", VA = "0x186FE84C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8430", Offset = "0x6FE7430", VA = "0x186FE8430", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EIOJIOLKBHF, RenderingData LMJMAMMDCBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xEA0340", Offset = "0xE9F340", VA = "0x180EA0340")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FE8710", Offset = "0x6FE7710", VA = "0x186FE8710")]
		public static void KAHFIMPDDGB(ScriptableRenderPass OLOPAMPBNME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6FE8570", Offset = "0x6FE7570", VA = "0x186FE8570", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EIOJIOLKBHF, RenderingData LMJMAMMDCBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xEA0340", Offset = "0xE9F340", VA = "0x180EA0340")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class LBDLKGHGFIP
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly PHLKHBEJKKB KBACJHLABGE;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly PHLKHBEJKKB NHNJJIDJMPP;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly PHLKHBEJKKB BBMBEMGENIC;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly PHLKHBEJKKB LOIHHMADCDM;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class IOBKICKHEAH
{
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static Mesh GBAHMNIDMPP;

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6FE75C0", Offset = "0x6FE65C0", VA = "0x186FE75C0")]
	public static Mesh OKOBLEFEGCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6FE6D60", Offset = "0x6FE5D60", VA = "0x186FE6D60")]
	public static Matrix4x4 CDDANIPJEAH(Camera JPOHLHNCEHN, bool FMIKMPHLDJI = false, bool GIAKMKHIBIM = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6FE7200", Offset = "0x6FE6200", VA = "0x186FE7200")]
	private static Mesh JBPICOPBDAC()
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
