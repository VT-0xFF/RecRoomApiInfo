using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Logging.Attributes;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rendering_Core_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8935A80", Offset = "0x8934680", VA = "0x188935A80", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		public enum PPLBFIIPAPK
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface INKOOPAEBLG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void NDPIAIALAKO(ScriptableRenderContext PBHLPKLGFAP, List<Camera> EHPKGGHMDNI);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface AHABEEICGOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void NDPIAIALAKO(ScriptableRenderContext PBHLPKLGFAP, RenderingData FAPPKDEOPJC);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class OFEKAAPBOCP : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8937970", Offset = "0x8936570", VA = "0x188937970")]
			public OFEKAAPBOCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8937910", Offset = "0x8936510", VA = "0x188937910", Slot = "9")]
			public override void Execute(ScriptableRenderContext PBHLPKLGFAP, RenderingData FAPPKDEOPJC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private OFEKAAPBOCP _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<INKOOPAEBLG> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<INKOOPAEBLG> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<AHABEEICGOI> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<AHABEEICGOI> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8938F70", Offset = "0x8937B70", VA = "0x188938F70")]
		public static void AOCIEHJBDBF(PPLBFIIPAPK DPPMEAICLCP, INKOOPAEBLG OIFIGAKJGAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x89399E0", Offset = "0x89385E0", VA = "0x1889399E0")]
		public static void PDIFPFHODDI(PPLBFIIPAPK DPPMEAICLCP, INKOOPAEBLG OIFIGAKJGAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8939030", Offset = "0x8937C30", VA = "0x188939030")]
		public static void AOCIEHJBDBF(PPLBFIIPAPK DPPMEAICLCP, AHABEEICGOI LGHCOEPHONN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8939AA0", Offset = "0x89386A0", VA = "0x188939AA0")]
		public static void PDIFPFHODDI(PPLBFIIPAPK DPPMEAICLCP, AHABEEICGOI LGHCOEPHONN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89391A0", Offset = "0x8937DA0", VA = "0x1889391A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89390F0", Offset = "0x8937CF0", VA = "0x1889390F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NMGNJGPOFCI, RenderingData FAPPKDEOPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8939390", Offset = "0x8937F90", VA = "0x188939390", Slot = "9")]
		protected override void Dispose(bool GOKCOPIKIHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8939B60", Offset = "0x8938760", VA = "0x188939B60")]
		private static void PKNGMJPMHLG(ScriptableRenderContext PBHLPKLGFAP, List<Camera> EHPKGGHMDNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8939970", Offset = "0x8938570", VA = "0x188939970")]
		private static void OIGBCIKKFHD(ScriptableRenderContext PBHLPKLGFAP, List<Camera> EHPKGGHMDNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x89394A0", Offset = "0x89380A0", VA = "0x1889394A0")]
		private static void GPJKHKGOJIC(ScriptableRenderContext PBHLPKLGFAP, RenderingData FAPPKDEOPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1887CE0", Offset = "0x18868E0", VA = "0x181887CE0")]
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
		private class ALAIHMFKCNB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool LLEEAIHNHCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<CPDGKBNOCKC> DCGNGHGEIJG;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x892F470", Offset = "0x892E070", VA = "0x18892F470")]
			public ALAIHMFKCNB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class NHAKCJDKNHG : PreRenderManager.AHABEEICGOI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string FKHEELCKCDJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler HMLNMNHGHGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly ALAIHMFKCNB HLEFNAHEPCO;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8936C50", Offset = "0x8935850", VA = "0x188936C50")]
			public NHAKCJDKNHG(ALAIHMFKCNB CPPMNHBAGPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8936850", Offset = "0x8935450", VA = "0x188936850", Slot = "4")]
			public void NDPIAIALAKO(ScriptableRenderContext PBHLPKLGFAP, RenderingData FAPPKDEOPJC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class KAJDFOKODEE : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string IGBHANIOHGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly ALAIHMFKCNB CPPMNHBAGPI;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8935320", Offset = "0x8933F20", VA = "0x188935320")]
			public KAJDFOKODEE(RenderPassEvent DAKAAKLHCNP, ALAIHMFKCNB CPPMNHBAGPI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8935010", Offset = "0x8933C10", VA = "0x188935010", Slot = "9")]
			public override void Execute(ScriptableRenderContext PBHLPKLGFAP, RenderingData FAPPKDEOPJC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<CPDGKBNOCKC> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private NHAKCJDKNHG fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private KAJDFOKODEE fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ALAIHMFKCNB sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8931D90", Offset = "0x8930990", VA = "0x188931D90", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8932120", Offset = "0x8930D20", VA = "0x188932120", Slot = "9")]
		protected override void Dispose(bool GOKCOPIKIHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8931CF0", Offset = "0x89308F0", VA = "0x188931CF0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NMGNJGPOFCI, RenderingData FAPPKDEOPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1887CE0", Offset = "0x18868E0", VA = "0x181887CE0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CPDGKBNOCKC
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JLLEAHOFFGL(CommandBuffer PLJMPMGAPOF, Camera LOAIHMJNEEH, [NotNull] UniversalAdditionalCameraData LAJKCJDPDLE, bool AEIILIPOJHI);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JIJFMNOPHIH(Camera LOAIHMJNEEH, CommandBuffer KPMAELAGKAJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class GMKFLLFFLFB
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool APODAEGEEIB;
}
namespace RecRoom.Core.Rendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[DisallowMultipleRendererFeature(null)]
	[ReloadGroup]
	internal class LightBinning : ScriptableRendererFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[Reload("Shaders/Utils/ComputeBufferTransfer.compute", ReloadAttribute.Package.Root)]
		public ComputeShader computeBufferTransferCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private JAPNHFFGJHP _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private BINMCKHHKKB _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8935750", Offset = "0x8934350", VA = "0x188935750", Slot = "9")]
		protected override void Dispose(bool MCHJGDOJHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x89357C0", Offset = "0x89343C0", VA = "0x1889357C0")]
		private void JOCGMGHOHMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8935400", Offset = "0x8934000", VA = "0x188935400", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NMGNJGPOFCI, RenderingData FAPPKDEOPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1887CE0", Offset = "0x18868E0", VA = "0x181887CE0")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EPNBGEINGLM
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8931CE0", Offset = "0x89308E0", VA = "0x188931CE0")]
	public static int CJFNHNHBFGM(bool GPGOHOKDEDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1D5FA10", Offset = "0x1D5E610", VA = "0x181D5FA10")]
	public static int GHPGGGCIGPC(bool GPGOHOKDEDK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct LNNIBBJPIKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType CBGBHIEDLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float DFIKBLCOJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float BNBCBHJAJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float GJAILNFMNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 BEBFBNNDCBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 GCJACJMDMNE;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OFPDCFLANHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort GALIGGABJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float IAKAIMFIJNM;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct POFGMJHFHOP : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<LNNIBBJPIKE> GDNNMIPCLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 CGLMPAHFGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 PGLHOGBECIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, OFPDCFLANHO>.ParallelWriter HPEGBKDPEFG;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x89380E0", Offset = "0x8936CE0", VA = "0x1889380E0", Slot = "4")]
	public void Execute(int GALIGGABJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8938710", Offset = "0x8937310", VA = "0x188938710")]
	private void NKHPIPOEBEB(uint3 FOMDNDLOKLI, uint3 BJNPHMLKNHN, ushort GALIGGABJAG, float3 BBEDIJJLFNB, float CBMGAGNKEIK, float HHAMPCBAKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8937C30", Offset = "0x8936830", VA = "0x188937C30")]
	private void EFBHLGOKEBD(uint3 FOMDNDLOKLI, uint3 BJNPHMLKNHN, ushort GALIGGABJAG, float3 BBEDIJJLFNB, float3 PGGKMNFAHFB, float3 KEKCMFOJGBK, float CBMGAGNKEIK, float GCMFAGEDIKH, float HHAMPCBAKAL, float PMLMLJINNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8938620", Offset = "0x8937220", VA = "0x188938620")]
	private float3 HENMKIKNGPI(uint3 FOMDNDLOKLI, float3 BBEDIJJLFNB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8930300", Offset = "0x892EF00", VA = "0x188930300")]
	private float KKKMAMKAAJN(float DFIKBLCOJHI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8930190", Offset = "0x892ED90", VA = "0x188930190")]
	private float HFHCCELCIMH(float3 MIPIEJDEDPF, float3 KEKCMFOJGBK, float GCMFAGEDIKH, float HHAMPCBAKAL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct JOBGAJFNFKE : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, OFPDCFLANHO> HPEGBKDPEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint AKAPFAPEFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int HEOADPALNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int MJBKIKJDHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> NECAABFPCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> OFIHGEHEHAA;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8934E70", Offset = "0x8933A70", VA = "0x188934E70", Slot = "4")]
	public void Execute(int PNGIHFHMFEE, int GGBAFKEHJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8934D00", Offset = "0x8933900", VA = "0x188934D00")]
	private void EAJIGNEPKHE(int KJOMIBKDNAF, ushort IEMCLLGLOFH, int ALCIAHLEGOE, OFPDCFLANHO PLAIOMINMNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct PPJOEHIDCPI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, OFPDCFLANHO> HPEGBKDPEFG;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8938A80", Offset = "0x8937680", VA = "0x188938A80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JAPNHFFGJHP : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool HGHFEJABLKO;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float BEPNDLKOPMA = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int NJDOPGEEFEM = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int LBOBACCOIAJ = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private POFGMJHFHOP IDBKLDNDDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private JOBGAJFNFKE EBEIEKABCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private PPJOEHIDCPI ILKPBNNLPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, OFPDCFLANHO> HCIAKIPOJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private JFCEKMOIFMC BIGKFICFLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool DKJIHELCKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int EFKIPPOAAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<LNNIBBJPIKE> BJLLEIFBADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle ODFLGCKDMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle CHACDJHPCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool DEJCHNAFDIE;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x89336C0", Offset = "0x89322C0", VA = "0x1889336C0")]
	public JAPNHFFGJHP(RenderPassEvent DAKAAKLHCNP, ComputeShader JAMDIEHDFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x89334F0", Offset = "0x89320F0", VA = "0x1889334F0")]
	private void MLAFIDPGLOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8933560", Offset = "0x8932160", VA = "0x188933560")]
	public void NBKKBLDGFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3CC0290", Offset = "0x3CBEE90", VA = "0x183CC0290")]
	public static void KOOLPPHLIEJ<T>(NativeArray<T> COJHNLDFDFB, int PFHGPMHBODB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8932BC0", Offset = "0x89317C0", VA = "0x188932BC0")]
	public void KNIAKBLIPHG(CameraData LAJKCJDPDLE, LightData MHDMFJFDHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8932F70", Offset = "0x8931B70", VA = "0x188932F70")]
	private void MEGJADLKIKO(LightData MHDMFJFDHID, NativeArray<LNNIBBJPIKE> DJINNHGIJEO, int ECFJCLFKENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x89332B0", Offset = "0x8931EB0", VA = "0x1889332B0")]
	private void MIFDKLOILJA(CameraData LAJKCJDPDLE, LightData MHDMFJFDHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8932A30", Offset = "0x8931630", VA = "0x188932A30")]
	private void INIACOEGJPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x89327E0", Offset = "0x89313E0", VA = "0x1889327E0")]
	private void ALEOOGIPEDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8932910", Offset = "0x8931510", VA = "0x188932910")]
	private void ECMDOPFIDPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x89328E0", Offset = "0x89314E0", VA = "0x1889328E0")]
	private void BLPLPKMKKFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8932930", Offset = "0x8931530", VA = "0x188932930", Slot = "9")]
	public override void Execute(ScriptableRenderContext PBHLPKLGFAP, RenderingData FAPPKDEOPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8933640", Offset = "0x8932240", VA = "0x188933640", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer KPMAELAGKAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BINMCKHHKKB : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort FDDCNJMMAHI = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float BEPNDLKOPMA = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly JFCEKMOIFMC BIGKFICFLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int AHBADIPHPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private LNNIBBJPIKE[] BJLLEIFBADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 DHFPMNJBDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 MKHLAAKLMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint DGLGIDFECFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int BHGPFDIPHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int HAHAHLHAAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> NECAABFPCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> OFIHGEHEHAA;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8931320", Offset = "0x892FF20", VA = "0x188931320")]
	public BINMCKHHKKB(RenderPassEvent DAKAAKLHCNP, ComputeShader JAMDIEHDFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8930320", Offset = "0x892EF20", VA = "0x188930320")]
	public void KNIAKBLIPHG(CameraData LAJKCJDPDLE, LightData MHDMFJFDHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x892F500", Offset = "0x892E100", VA = "0x18892F500")]
	private void BCMDEFBFIML(CameraData LAJKCJDPDLE, LightData MHDMFJFDHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x89308D0", Offset = "0x892F4D0", VA = "0x1889308D0")]
	public void NBKKBLDGFKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8930580", Offset = "0x892F180", VA = "0x188930580")]
	private void MEGJADLKIKO(LightData MHDMFJFDHID, LNNIBBJPIKE[] DJINNHGIJEO, int ECFJCLFKENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8930250", Offset = "0x892EE50", VA = "0x188930250")]
	private void KECNEOKPLPK(int PNGIHFHMFEE, int GGBAFKEHJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x892F770", Offset = "0x892E370", VA = "0x18892F770")]
	private void CDJPIHOBDGC(int PNGIHFHMFEE, int NKGPOLKDIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8930D00", Offset = "0x892F900", VA = "0x188930D00")]
	private ushort NPJCJDCMLGJ(int PNGIHFHMFEE)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x892F700", Offset = "0x892E300", VA = "0x18892F700")]
	private void CADMBFFCFNB(int PNGIHFHMFEE, int GGBAFKEHJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8930020", Offset = "0x892EC20", VA = "0x188930020")]
	private void FHMEDEFNHFC(int PFHGPMHBODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x892F7A0", Offset = "0x892E3A0", VA = "0x18892F7A0")]
	private void CECEDFGAFFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x892FF40", Offset = "0x892EB40", VA = "0x18892FF40", Slot = "9")]
	public override void Execute(ScriptableRenderContext PBHLPKLGFAP, RenderingData FAPPKDEOPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x89312F0", Offset = "0x892FEF0", VA = "0x1889312F0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer KPMAELAGKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8930D40", Offset = "0x892F940", VA = "0x188930D40")]
	private void OJNNLGKLKOF(int GALIGGABJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x89308F0", Offset = "0x892F4F0", VA = "0x1889308F0")]
	private void NKHPIPOEBEB(uint3 FOMDNDLOKLI, uint3 BJNPHMLKNHN, ushort GALIGGABJAG, float3 BBEDIJJLFNB, float CBMGAGNKEIK, float HHAMPCBAKAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x892F9F0", Offset = "0x892E5F0", VA = "0x18892F9F0")]
	private void EFBHLGOKEBD(uint3 FOMDNDLOKLI, uint3 BJNPHMLKNHN, ushort GALIGGABJAG, float3 BBEDIJJLFNB, float3 PGGKMNFAHFB, float3 KEKCMFOJGBK, float CBMGAGNKEIK, float GCMFAGEDIKH, float HHAMPCBAKAL, float PMLMLJINNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8930490", Offset = "0x892F090", VA = "0x188930490")]
	private void KPADLIINCMN(ushort GALIGGABJAG, uint HHEFKEJAEJA, float JBPOCKFPNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8930090", Offset = "0x892EC90", VA = "0x188930090")]
	private float3 HENMKIKNGPI(uint3 FOMDNDLOKLI, float3 BBEDIJJLFNB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8930300", Offset = "0x892EF00", VA = "0x188930300")]
	private float KKKMAMKAAJN(float DFIKBLCOJHI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8930190", Offset = "0x892ED90", VA = "0x188930190")]
	private float HFHCCELCIMH(float3 MIPIEJDEDPF, float3 KEKCMFOJGBK, float GCMFAGEDIKH, float HHAMPCBAKAL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x892F860", Offset = "0x892E460", VA = "0x18892F860")]
	private void EAJIGNEPKHE(int KJOMIBKDNAF, ushort IEMCLLGLOFH, int ALCIAHLEGOE, OFPDCFLANHO PLAIOMINMNK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JFCEKMOIFMC
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class PLCCDFIPNOO
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int LENHHMFHPAB;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int NAOAFGHJMAP;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int CFGKLMKIBDN;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int KONOHCIGOAK;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int IBEGPDGEHFB;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int AMCOJCJDDEL;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int BBBOKDAIDHO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int GODCECENMFA = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int DAPBKJJFNCG = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int BADKIIHCIEB = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int MPEAMJNPLJI = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int KPGHMEJOKPB = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int MCPNFCLLPGA = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int LEHCKOKGEOO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool GLOBGNJHDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer ODCAJJMENKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture NDOEJMJCIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int CIHJGLDPOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int HFKNDKHDJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int IIPEHJBAIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int MPOMLNPFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int FOLFNKHGHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader FBLGJBFHAFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int IBIPEMONDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int HHDLKDIFCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 LEHDDHBPFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 KOIPKLOCBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> MIKJNMJFAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> MJOPIKNBOEO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> GDGPAEODIGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4E85C80", Offset = "0x4E84880", VA = "0x184E85C80")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> JFNAPHGCMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x12B9350", Offset = "0x12B7F50", VA = "0x1812B9350")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int KDKHFHPPKHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAAD070", Offset = "0xAABC70", VA = "0x180AAD070")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int ACGFPNOHHIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA5C760", Offset = "0xA5B360", VA = "0x180A5C760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader PJAPACIJMDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8933770", Offset = "0x8932370", VA = "0x188933770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8933A60", Offset = "0x8932660", VA = "0x188933A60")]
	public void EDJAHJBIEKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8933B50", Offset = "0x8932750", VA = "0x188933B50")]
	public void HKFFNILIDEC(CameraData LAJKCJDPDLE, LightData MHDMFJFDHID, int CKFNODBIOMA, bool GPGOHOKDEDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3CC4340", Offset = "0x3CC2F40", VA = "0x183CC4340")]
	private void KOOLPPHLIEJ<T>(NativeArray<T> COJHNLDFDFB, int PFHGPMHBODB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x89345F0", Offset = "0x89331F0", VA = "0x1889345F0")]
	public void PKBHHGNAIOA(CommandBuffer KPMAELAGKAJ, ScriptableRenderContext PBHLPKLGFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8934180", Offset = "0x8932D80", VA = "0x188934180")]
	private static void IJJDLPDJOFL(int POMGPIKLOEG, CommandBuffer KPMAELAGKAJ, RenderBuffer BCGCJNEAIJL, ComputeBuffer NDMGLPPDOGJ, ComputeShader ONIPLNIPPCH, int BNOOLHILPHF, int LPCDNELEIGI, int BNLDANGMIHJ, int PDNDIJCCGBC, int FOGOODEKFHB, int HMJNLDDJNAJ, int IGAEOMAKBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8933E60", Offset = "0x8932A60", VA = "0x188933E60")]
	public void HLHGPHAHGHC(CommandBuffer KPMAELAGKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8933800", Offset = "0x8932400", VA = "0x188933800")]
	private RenderTexture BLLABBPDMDI(RenderTexture JDMFNIJOEGO, int BNOOLHILPHF, int LPCDNELEIGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x89339E0", Offset = "0x89325E0", VA = "0x1889339E0")]
	public void BPCIAIFLDNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8934360", Offset = "0x8932F60", VA = "0x188934360")]
	public void OIHHJAOIBIB(int HPEGMKLNAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8934940", Offset = "0x8933540", VA = "0x188934940")]
	public JFCEKMOIFMC()
	{
	}
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Fade")]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public struct MGDJHDOOANB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float GKHKLEBNDDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float ANIGICPLBKK;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class GGNPNECHNLN : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string MCACIKBJJCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler CHEKNBFGAOK;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int HLIIKOABFAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material DGBNEBPBCDK;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8932700", Offset = "0x8931300", VA = "0x188932700")]
			public GGNPNECHNLN(RenderPassEvent DAKAAKLHCNP, Material CIBNABIMGCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8932320", Offset = "0x8930F20", VA = "0x188932320", Slot = "9")]
			public override void Execute(ScriptableRenderContext PBHLPKLGFAP, RenderingData FAPPKDEOPJC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static MGDJHDOOANB CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private GGNPNECHNLN m_MobileFadePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Reload("Shaders/MobileFade.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x89364C0", Offset = "0x89350C0", VA = "0x1889364C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8936470", Offset = "0x8935070", VA = "0x188936470")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x89362C0", Offset = "0x8934EC0", VA = "0x1889362C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x89361F0", Offset = "0x8934DF0", VA = "0x1889361F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NMGNJGPOFCI, RenderingData FAPPKDEOPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1887CE0", Offset = "0x18868E0", VA = "0x181887CE0")]
		public MobileFadeRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Vignette")]
	public class MobileVignetteRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public struct FPAEJFLDFBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float OJGMODIDNJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color NNKIBBFIGJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh HFJMHAANCAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve KMBHIHAOBLE;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class JLFHNGHNGEK : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string MCACIKBJJCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler CHEKNBFGAOK;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int HFIBKKGDPPK;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int ADEPBEDKAHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material DGBNEBPBCDK;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8934C20", Offset = "0x8933820", VA = "0x188934C20")]
			public JLFHNGHNGEK(RenderPassEvent DAKAAKLHCNP, Material CIBNABIMGCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8934960", Offset = "0x8933560", VA = "0x188934960", Slot = "9")]
			public override void Execute(ScriptableRenderContext PBHLPKLGFAP, RenderingData FAPPKDEOPJC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static FPAEJFLDFBJ CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private JLFHNGHNGEK m_MobileVignettePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Reload("Shaders/MobileVignette.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static bool IsSupported
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x89367F0", Offset = "0x89353F0", VA = "0x1889367F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8936640", Offset = "0x8935240", VA = "0x188936640", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8936520", Offset = "0x8935120", VA = "0x188936520", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NMGNJGPOFCI, RenderingData FAPPKDEOPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1887CE0", Offset = "0x18868E0", VA = "0x181887CE0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string NMAIIBDDAPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool AICLDPHPOPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer KPMAELAGKAJ, ScriptableRenderContext PBHLPKLGFAP, RenderingData FAPPKDEOPJC);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		protected PerCameraRenderEffect()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Per-Camera Render Effects")]
	public class PerCameraRenderEffectsRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private class MIGNGDBLOOA : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool OIPDNIADCJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> IPCLFBJLDEC;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> KMKIOPICGLE;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8936140", Offset = "0x8934D40", VA = "0x188936140")]
			public MIGNGDBLOOA(RenderPassEvent DAKAAKLHCNP, bool OIPDNIADCJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8935DC0", Offset = "0x89349C0", VA = "0x188935DC0")]
			public bool JBBPFHBHKPK(CameraData LAJKCJDPDLE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8935BF0", Offset = "0x89347F0", VA = "0x188935BF0", Slot = "9")]
			public override void Execute(ScriptableRenderContext PBHLPKLGFAP, RenderingData FAPPKDEOPJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8935B10", Offset = "0x8934710", VA = "0x188935B10")]
			private void DKLHKHLBCNJ(PerCameraRenderEffect AJGOICKKMON, ScriptableRenderContext PBHLPKLGFAP, RenderingData FAPPKDEOPJC)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private MIGNGDBLOOA m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private MIGNGDBLOOA m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8938B50", Offset = "0x8937750", VA = "0x188938B50", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8938AC0", Offset = "0x89376C0", VA = "0x188938AC0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NMGNJGPOFCI, RenderingData FAPPKDEOPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1887CE0", Offset = "0x18868E0", VA = "0x181887CE0")]
		public PerCameraRenderEffectsRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[Tooltip("RR Persistent Buffer Effects")]
	[DisallowMultipleRendererFeature(null)]
	public class PersistentBufferEffectsRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static readonly List<ScriptableRenderPass> passes;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private const RenderPassEvent RENDER_PASS_EVENT = RenderPassEvent.BeforeRenderingShadows;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8938DA0", Offset = "0x89379A0", VA = "0x188938DA0")]
		public static void LMNGPJIFLCJ(ScriptableRenderPass BPINOCHMBBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8938C00", Offset = "0x8937800", VA = "0x188938C00", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NMGNJGPOFCI, RenderingData FAPPKDEOPJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1887CE0", Offset = "0x18868E0", VA = "0x181887CE0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class ODDJLLNPJEP
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 AEOIEGCOGFN;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 BAEHIDNOHPH;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 KMEAPHPGPGO;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 GMKFNHKEPDA;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 EBPEBILMGAO;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8936D10", Offset = "0x8935910", VA = "0x188936D10")]
	public static uint FBJCLKDBONO(uint LGCEHLADNJC, uint LFHMHCKODDK, uint COPINMEDHAK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x89375D0", Offset = "0x89361D0", VA = "0x1889375D0")]
	public static uint3 LMDILFIGOGJ(float3 FEMJLOIOGIK, float3 CGLMPAHFGFE, float3 PGLHOGBECIF)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8936EC0", Offset = "0x8935AC0", VA = "0x188936EC0")]
	public static void IJAOAOGCHOI(float3 JMKJDNHHECD, float3 EGIBBNIKJCP, float3 GILNMDCPHOL, float BNDEJLLMNLK, [Out] uint3 GHIAEFOABDG, [Out] uint3 KHJKKGAHJPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8937100", Offset = "0x8935D00", VA = "0x188937100")]
	public static void LFNIPHEGJFN(float3 LFADMAELPBA, float3 MGFJJNFAOLJ, float BNBCBHJAJGO, float AKEJCNBFICL, [Out] float3 DDFJOOKJOHC, [Out] float BNDEJLLMNLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8936D20", Offset = "0x8935920", VA = "0x188936D20")]
	private static float3 HOKNJLBHFHB(float3 IOGKMFJHKIA, float3 HJPGDDCNOHK, float3 NEAGMOKEBKN, float3 JEIPJBJGHGE)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class POBHKCMDPGD
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly PEOHNMCPNIJ MEFKPFFBLNC;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly PEOHNMCPNIJ FBCGKHBJOCG;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly PEOHNMCPNIJ MKNMAHMLFBK;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly PEOHNMCPNIJ GAMLDOEGANH;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly PEOHNMCPNIJ IEHNOEICMBB;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class DBMIPAMOJKO
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh OICLGKLBGOK;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x89313D0", Offset = "0x892FFD0", VA = "0x1889313D0")]
	public static Mesh COILOGPANDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8931480", Offset = "0x8930080", VA = "0x188931480")]
	public static Matrix4x4 MBKIFINPPPN(Camera LOAIHMJNEEH, bool JAMFELADIDE = false, bool AFFBJHOOCHH = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8931920", Offset = "0x8930520", VA = "0x188931920")]
	private static Mesh PHJCPLDJNIL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__629458319
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x893A290", Offset = "0x8938E90", VA = "0x18893A290")]
	public static void BHBOJBGFAMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x893A320", Offset = "0x8938F20", VA = "0x18893A320")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
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
