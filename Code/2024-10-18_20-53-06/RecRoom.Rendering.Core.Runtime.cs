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
	public class LogRegistrationIndex : HLBHPGBFEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x746F650", Offset = "0x746EA50", VA = "0x18746F650", Slot = "4")]
		public override void MHJHNBDIMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		public enum KPANJKDLBNA
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface MFPKNKLGOPN
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void DNJGMMIDFGL(ScriptableRenderContext OMHMFLHBNDJ, List<Camera> LAGDECDDDNK);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface OGIOMNKDPFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void DNJGMMIDFGL(ScriptableRenderContext OMHMFLHBNDJ, RenderingData CMGIFFLKING);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class DFGMDNCAAHG : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x746D110", Offset = "0x746C510", VA = "0x18746D110")]
			public DFGMDNCAAHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x746D0B0", Offset = "0x746C4B0", VA = "0x18746D0B0", Slot = "9")]
			public override void Execute(ScriptableRenderContext OMHMFLHBNDJ, RenderingData CMGIFFLKING)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private DFGMDNCAAHG _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<MFPKNKLGOPN> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<MFPKNKLGOPN> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<OGIOMNKDPFN> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<OGIOMNKDPFN> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x74717F0", Offset = "0x7470BF0", VA = "0x1874717F0")]
		public static void ANKKCFMLIBI(KPANJKDLBNA MDCKECLBNBA, MFPKNKLGOPN IBLHBGGLPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7471A10", Offset = "0x7470E10", VA = "0x187471A10")]
		public static void CFEGMPBDCAF(KPANJKDLBNA MDCKECLBNBA, MFPKNKLGOPN IBLHBGGLPCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7471730", Offset = "0x7470B30", VA = "0x187471730")]
		public static void ANKKCFMLIBI(KPANJKDLBNA MDCKECLBNBA, OGIOMNKDPFN AHFPAFACALK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7471950", Offset = "0x7470D50", VA = "0x187471950")]
		public static void CFEGMPBDCAF(KPANJKDLBNA MDCKECLBNBA, OGIOMNKDPFN AHFPAFACALK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7471AD0", Offset = "0x7470ED0", VA = "0x187471AD0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x74718B0", Offset = "0x7470CB0", VA = "0x1874718B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OMALFJOLMMP, RenderingData CMGIFFLKING)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7471CB0", Offset = "0x74710B0", VA = "0x187471CB0", Slot = "9")]
		protected override void Dispose(bool DAHECFKBGJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7471DC0", Offset = "0x74711C0", VA = "0x187471DC0")]
		private static void KJAEGMKNHKL(ScriptableRenderContext OMHMFLHBNDJ, List<Camera> LAGDECDDDNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x74722A0", Offset = "0x74716A0", VA = "0x1874722A0")]
		private static void MNMGBEJBODF(ScriptableRenderContext OMHMFLHBNDJ, List<Camera> LAGDECDDDNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7472310", Offset = "0x7471710", VA = "0x187472310")]
		private static void NFODMKABBIJ(ScriptableRenderContext OMHMFLHBNDJ, RenderingData CMGIFFLKING)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x10A1A90", Offset = "0x10A0E90", VA = "0x1810A1A90")]
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
		private class ACJODAFKCPN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool CLCMFCCEJNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<AAIBAOKHBLI> IMPFJKLGKHO;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7467E10", Offset = "0x7467210", VA = "0x187467E10")]
			public ACJODAFKCPN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class IBGEKHKKKHP : PreRenderManager.OGIOMNKDPFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string FJGEPEFMICN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler LIGEPPANPBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly ACJODAFKCPN CIPECBEHBFI;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x746E330", Offset = "0x746D730", VA = "0x18746E330")]
			public IBGEKHKKKHP(ACJODAFKCPN BLEFGEAKEAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x746DF30", Offset = "0x746D330", VA = "0x18746DF30", Slot = "4")]
			public void DNJGMMIDFGL(ScriptableRenderContext OMHMFLHBNDJ, RenderingData CMGIFFLKING)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class PMCBNLLMINL : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string DDMPDBLICJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly ACJODAFKCPN BLEFGEAKEAK;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7471200", Offset = "0x7470600", VA = "0x187471200")]
			public PMCBNLLMINL(RenderPassEvent OEPCBMIJALI, ACJODAFKCPN BLEFGEAKEAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7470EF0", Offset = "0x74702F0", VA = "0x187470EF0", Slot = "9")]
			public override void Execute(ScriptableRenderContext OMHMFLHBNDJ, RenderingData CMGIFFLKING)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<AAIBAOKHBLI> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private IBGEKHKKKHP fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private PMCBNLLMINL fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ACJODAFKCPN sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x746D980", Offset = "0x746CD80", VA = "0x18746D980", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x746DD00", Offset = "0x746D100", VA = "0x18746DD00", Slot = "9")]
		protected override void Dispose(bool DAHECFKBGJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x746D8F0", Offset = "0x746CCF0", VA = "0x18746D8F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OMALFJOLMMP, RenderingData CMGIFFLKING)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x10A1A90", Offset = "0x10A0E90", VA = "0x1810A1A90")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AAIBAOKHBLI
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CAFNJHDIGBA(CommandBuffer CIJKCKGLFGO, Camera EMNPAABKIAH, [NotNull] UniversalAdditionalCameraData NKIKJAFILFH, bool NBNIODECLIJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLJANHBKONI(Camera EMNPAABKIAH, CommandBuffer CAFEJLEOHDK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IGEIHGODBAP
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool LGEKKGHAAAJ;
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
		private AFBBGHMAMLI _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private BPBMEPIOLPD _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x746F330", Offset = "0x746E730", VA = "0x18746F330", Slot = "9")]
		protected override void Dispose(bool GLPILCHGGDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x746F3A0", Offset = "0x746E7A0", VA = "0x18746F3A0")]
		private void PACIHMGFBJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x746EFE0", Offset = "0x746E3E0", VA = "0x18746EFE0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OMALFJOLMMP, RenderingData CMGIFFLKING)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x10A1A90", Offset = "0x10A0E90", VA = "0x1810A1A90")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IMMKMMPNBPG
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x746E3F0", Offset = "0x746D7F0", VA = "0x18746E3F0")]
	public static int EOLGEGIKCGP(bool CIBNOKKOKFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x14ED9B0", Offset = "0x14ECDB0", VA = "0x1814ED9B0")]
	public static int LFMPLPNOMPB(bool CIBNOKKOKFM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct INPEKADKJKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType ILBDGOMDJLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float FJPCIEGFMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float HAIEMBCHPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float IFBEGAKKFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 ILGNEHGJOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 AIGHLDHDDFH;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FJLFEMIBEHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort PIIKFBPICKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float HJMNMBDADJC;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct CDCBHPLMGBM : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<INPEKADKJKL> ILNEFIMKBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 ALJDDKLGIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 IKCBKAOMFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, FJLFEMIBEHE>.ParallelWriter JGGFDNMACGJ;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x746C250", Offset = "0x746B650", VA = "0x18746C250", Slot = "4")]
	public void Execute(int PIIKFBPICKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x746BEE0", Offset = "0x746B2E0", VA = "0x18746BEE0")]
	private void CKKEBGBMEKM(uint3 MCDCOLDCLMN, uint3 IAOJDHCAFFN, ushort PIIKFBPICKD, float3 PKJCDKHPBAB, float EAEEGAENMMC, float LGLMGHGACJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x746C790", Offset = "0x746BB90", VA = "0x18746C790")]
	private void LPIJCKNLLGO(uint3 MCDCOLDCLMN, uint3 IAOJDHCAFFN, ushort PIIKFBPICKD, float3 PKJCDKHPBAB, float3 LNNAGJKBPNL, float3 IKMDCMIHAMA, float EAEEGAENMMC, float HGGMCPOCGPC, float LGLMGHGACJG, float NLGGPADOBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x746CC40", Offset = "0x746C040", VA = "0x18746CC40")]
	private float3 PKPFEKEDLJK(uint3 MCDCOLDCLMN, float3 PKJCDKHPBAB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x746A850", Offset = "0x7469C50", VA = "0x18746A850")]
	private float IDLMBJKAOLN(float FJPCIEGFMII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x746B1E0", Offset = "0x746A5E0", VA = "0x18746B1E0")]
	private float OANNMJLMBKL(float3 CNBBOCOAOEK, float3 IKMDCMIHAMA, float HGGMCPOCGPC, float LGLMGHGACJG)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct DIDJJHKLJKL : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, FJLFEMIBEHE> JGGFDNMACGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint KILCCPOAHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int CAFGBJCMDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int IMAEJCHKCFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> MFIMNJFHMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> NDPEHAKLJOI;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x746D130", Offset = "0x746C530", VA = "0x18746D130", Slot = "4")]
	public void Execute(int CPDEHMJLLFC, int CCPNINCOBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x746D2D0", Offset = "0x746C6D0", VA = "0x18746D2D0")]
	private void NCCFOBLNINA(int HMIIFGGOIIA, ushort DONCHCDPGGH, int HBEPBLBFIJM, FJLFEMIBEHE OKDKHKALCDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct HFINMKEMMIO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, FJLFEMIBEHE> JGGFDNMACGJ;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x746DEF0", Offset = "0x746D2F0", VA = "0x18746DEF0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class AFBBGHMAMLI : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool EAHNHKCBNAC;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float AGKCKLHHHJA = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int FGKEKMBHFNA = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int ENMPECIJALE = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private CDCBHPLMGBM KHIMNJPKLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private DIDJJHKLJKL KBONMHBPCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private HFINMKEMMIO PNAKIJPJMOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, FJLFEMIBEHE> KMMDIMFNJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private MFLMJHPHCLM PJBCJMHHBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool OLLFKAKGHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int OONKAPEEMMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<INPEKADKJKL> FFENMKFDFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle PEOODKHPDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle PNIEGEGOFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool FPJMHFKKBAA;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7468D60", Offset = "0x7468160", VA = "0x187468D60")]
	public AFBBGHMAMLI(RenderPassEvent OEPCBMIJALI, ComputeShader PBKNFFPHDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x74684F0", Offset = "0x74678F0", VA = "0x1874684F0")]
	private void KKGPKDIHLBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x74682E0", Offset = "0x74676E0", VA = "0x1874682E0")]
	public void GLFGIDNFHGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3587550", Offset = "0x3586950", VA = "0x183587550")]
	public static void FLIJHFFBNFB<T>(NativeArray<T> IGGIDMIPNHL, int IKJKAFPPDBP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7468560", Offset = "0x7467960", VA = "0x187468560")]
	public void MBFEHPHEAGM(CameraData NKIKJAFILFH, LightData KHCMIGBJPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7467EA0", Offset = "0x74672A0", VA = "0x187467EA0")]
	private void CLJGCHJHPCB(LightData KHCMIGBJPKO, NativeArray<INPEKADKJKL> PMFNIKKLIFN, int BCPOOEAGMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7468900", Offset = "0x7467D00", VA = "0x187468900")]
	private void OILOGLNPFHK(CameraData NKIKJAFILFH, LightData KHCMIGBJPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7468B90", Offset = "0x7467F90", VA = "0x187468B90")]
	private void PPKGAFJBJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x74683C0", Offset = "0x74677C0", VA = "0x1874683C0")]
	private void HPOMINLEDOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7468B70", Offset = "0x7467F70", VA = "0x187468B70")]
	private void PEOMICJCOPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x74684C0", Offset = "0x74678C0", VA = "0x1874684C0")]
	private void JFEBBLDCOBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x74681E0", Offset = "0x74675E0", VA = "0x1874681E0", Slot = "9")]
	public override void Execute(ScriptableRenderContext OMHMFLHBNDJ, RenderingData CMGIFFLKING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7468B40", Offset = "0x7467F40", VA = "0x187468B40", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer CAFEJLEOHDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BPBMEPIOLPD : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort KEGFNPDKJOD = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float AGKCKLHHHJA = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly MFLMJHPHCLM PJBCJMHHBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int HHPBODCLKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private INPEKADKJKL[] FFENMKFDFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 JBAGMGDKHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 AAAFHEKHHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint MIIAMANHHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int KMFKKGMCNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int JJDKAKDKJBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> MFIMNJFHMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> NDPEHAKLJOI;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x746B530", Offset = "0x746A930", VA = "0x18746B530")]
	public BPBMEPIOLPD(RenderPassEvent OEPCBMIJALI, ComputeShader PBKNFFPHDLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x746AE70", Offset = "0x746A270", VA = "0x18746AE70")]
	public void MBFEHPHEAGM(CameraData NKIKJAFILFH, LightData KHCMIGBJPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x746A550", Offset = "0x7469950", VA = "0x18746A550")]
	private void DPOIENBNOPL(CameraData NKIKJAFILFH, LightData KHCMIGBJPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x746A830", Offset = "0x7469C30", VA = "0x18746A830")]
	public void GLFGIDNFHGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x746A1C0", Offset = "0x74695C0", VA = "0x18746A1C0")]
	private void CLJGCHJHPCB(LightData KHCMIGBJPKO, INPEKADKJKL[] PMFNIKKLIFN, int BCPOOEAGMBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x746A870", Offset = "0x7469C70", VA = "0x18746A870")]
	private void LJGKPDICIGG(int CPDEHMJLLFC, int CCPNINCOBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x746B2A0", Offset = "0x746A6A0", VA = "0x18746B2A0")]
	private void OBKPKDENCHD(int CPDEHMJLLFC, int HMELIAGANNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x746A510", Offset = "0x7469910", VA = "0x18746A510")]
	private ushort DEACOPHMAJJ(int CPDEHMJLLFC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x746B2D0", Offset = "0x746A6D0", VA = "0x18746B2D0")]
	private void OGODCFAHHPN(int CPDEHMJLLFC, int CCPNINCOBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x746AFE0", Offset = "0x746A3E0", VA = "0x18746AFE0")]
	private void NCBOKHAMDBB(int IKJKAFPPDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x746B340", Offset = "0x746A740", VA = "0x18746B340")]
	private void OPJDLNGFOOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x746A750", Offset = "0x7469B50", VA = "0x18746A750", Slot = "9")]
	public override void Execute(ScriptableRenderContext OMHMFLHBNDJ, RenderingData CMGIFFLKING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x746B400", Offset = "0x746A800", VA = "0x18746B400", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer CAFEJLEOHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7469800", Offset = "0x7468C00", VA = "0x187469800")]
	private void BJNECNFJLEM(int PIIKFBPICKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7469DB0", Offset = "0x74691B0", VA = "0x187469DB0")]
	private void CKKEBGBMEKM(uint3 MCDCOLDCLMN, uint3 IAOJDHCAFFN, ushort PIIKFBPICKD, float3 PKJCDKHPBAB, float EAEEGAENMMC, float LGLMGHGACJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x746A920", Offset = "0x7469D20", VA = "0x18746A920")]
	private void LPIJCKNLLGO(uint3 MCDCOLDCLMN, uint3 IAOJDHCAFFN, ushort PIIKFBPICKD, float3 PKJCDKHPBAB, float3 LNNAGJKBPNL, float3 IKMDCMIHAMA, float EAEEGAENMMC, float HGGMCPOCGPC, float LGLMGHGACJG, float NLGGPADOBED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7469710", Offset = "0x7468B10", VA = "0x187469710")]
	private void BJIKOEDMNEI(ushort PIIKFBPICKD, uint KPEBNPGICGI, float PNEHFDOCOLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x746B430", Offset = "0x746A830", VA = "0x18746B430")]
	private float3 PKPFEKEDLJK(uint3 MCDCOLDCLMN, float3 PKJCDKHPBAB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x746A850", Offset = "0x7469C50", VA = "0x18746A850")]
	private float IDLMBJKAOLN(float FJPCIEGFMII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x746B1E0", Offset = "0x746A5E0", VA = "0x18746B1E0")]
	private float OANNMJLMBKL(float3 CNBBOCOAOEK, float3 IKMDCMIHAMA, float HGGMCPOCGPC, float LGLMGHGACJG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x746B050", Offset = "0x746A450", VA = "0x18746B050")]
	private void NCCFOBLNINA(int HMIIFGGOIIA, ushort DONCHCDPGGH, int HBEPBLBFIJM, FJLFEMIBEHE OKDKHKALCDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class MFLMJHPHCLM
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class ALHJJHJEHGN
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int AAPNBJGDKJE;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int ANFNINODHGI;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int PHCNBDCBFDD;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int OJOKCOCFGOA;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int MAFEGOGBCPJ;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int KGIOPLMDMFL;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int LMMPJEINGML;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int MJOAMJOIGCL = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int CBJANNMIMBB = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int CELBLCOBPKN = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int OKKCMIAJAOD = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int GGICIJDMLCE = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int FGMODCHJEOP = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int BNIJLNLEPGM = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool GHGNMKPDHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer EKHLJGHCOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture BJLBABDEFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int MAEBKEMMMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int LMKKKDFLEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int NOHHMBOHOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int BHGBLNEEHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int KJOCCCJOILF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader CLEDPNBMDKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int NADLAHLALNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int AOPGGBFHBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 ALKOONEFEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 EMDMJLCACAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> EBJMCEDFMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> KCJGAFANLBD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> FDJJAPJOPJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x134B690", Offset = "0x134AA90", VA = "0x18134B690")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> BCKOLOEDLFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1883380", Offset = "0x1882780", VA = "0x181883380")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BPKNEOPCPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xBE3220", Offset = "0xBE2620", VA = "0x180BE3220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int JDAHBCAENKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8A8A30", Offset = "0x8A7E30", VA = "0x1808A8A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader NKMJKPONHEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x746F6E0", Offset = "0x746EAE0", VA = "0x18746F6E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x746F7F0", Offset = "0x746EBF0", VA = "0x18746F7F0")]
	public void BMHCCLKIAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x746F8E0", Offset = "0x746ECE0", VA = "0x18746F8E0")]
	public void EKGKMJMGDEB(CameraData NKIKJAFILFH, LightData KHCMIGBJPKO, int KHOHFALHAKD, bool CIBNOKKOKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2F2C2B0", Offset = "0x2F2B6B0", VA = "0x182F2C2B0")]
	private void FLIJHFFBNFB<T>(NativeArray<T> IGGIDMIPNHL, int IKJKAFPPDBP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7470370", Offset = "0x746F770", VA = "0x187470370")]
	public void IDDKNNGNEPM(CommandBuffer CAFEJLEOHDK, ScriptableRenderContext OMHMFLHBNDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x746FBF0", Offset = "0x746EFF0", VA = "0x18746FBF0")]
	private static void FEBNOOIDKMK(int IHFJEHOKDKD, CommandBuffer CAFEJLEOHDK, RenderBuffer NMIEMHPKJGF, ComputeBuffer EKIOFPFMNJB, ComputeShader FJFIELNIGKO, int NONLEJOJOJJ, int PNAKLHJFEME, int KDBOBCKIPLI, int NKFKJAAICAC, int FNNPBGGIIFL, int APEHOCIMPEH, int MIPAKJELIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x746FDD0", Offset = "0x746F1D0", VA = "0x18746FDD0")]
	public void GAHEJGBBAKK(CommandBuffer CAFEJLEOHDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x74706C0", Offset = "0x746FAC0", VA = "0x1874706C0")]
	private RenderTexture OCKLDNHLEON(RenderTexture GLJJMBNAHJA, int NONLEJOJOJJ, int PNAKLHJFEME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x746F770", Offset = "0x746EB70", VA = "0x18746F770")]
	public void AOGFHNBNKOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x74700E0", Offset = "0x746F4E0", VA = "0x1874700E0")]
	public void HMOCEOAEOHE(int HPAFDJAILCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x74708A0", Offset = "0x746FCA0", VA = "0x1874708A0")]
	public MFLMJHPHCLM()
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
		public struct LHPDHDEPCFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float OMJJIOCEKFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float OGHIAKCHJGE;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class EIEIJNNEKMB : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string POAMAFBEFGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler HNMGMMJCBJM;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int EJMFKEDNKKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material ECNGKDNKCOG;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x746D810", Offset = "0x746CC10", VA = "0x18746D810")]
			public EIEIJNNEKMB(RenderPassEvent OEPCBMIJALI, Material PBHLFFKCLKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x746D440", Offset = "0x746C840", VA = "0x18746D440", Slot = "9")]
			public override void Execute(ScriptableRenderContext OMHMFLHBNDJ, RenderingData CMGIFFLKING)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static LHPDHDEPCFB CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private EIEIJNNEKMB m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7470B90", Offset = "0x746FF90", VA = "0x187470B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7470B40", Offset = "0x746FF40", VA = "0x187470B40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7470990", Offset = "0x746FD90", VA = "0x187470990", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x74708C0", Offset = "0x746FCC0", VA = "0x1874708C0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OMALFJOLMMP, RenderingData CMGIFFLKING)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x10A1A90", Offset = "0x10A0E90", VA = "0x1810A1A90")]
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
		public struct CIGHHFEMKHB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float OEFDOAGABBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color IJHLJDBPPMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh PEFOEPLKLJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve JIGNCAEGJFB;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class CIEICMKDNOD : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string POAMAFBEFGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler HNMGMMJCBJM;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int DBFAJEILFFD;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int BEOAHPMBPFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material ECNGKDNKCOG;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x746CFD0", Offset = "0x746C3D0", VA = "0x18746CFD0")]
			public CIEICMKDNOD(RenderPassEvent OEPCBMIJALI, Material PBHLFFKCLKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x746CD30", Offset = "0x746C130", VA = "0x18746CD30", Slot = "9")]
			public override void Execute(ScriptableRenderContext OMHMFLHBNDJ, RenderingData CMGIFFLKING)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static CIGHHFEMKHB CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private CIEICMKDNOD m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7470EA0", Offset = "0x74702A0", VA = "0x187470EA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7470CF0", Offset = "0x74700F0", VA = "0x187470CF0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7470BE0", Offset = "0x746FFE0", VA = "0x187470BE0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OMALFJOLMMP, RenderingData CMGIFFLKING)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x10A1A90", Offset = "0x10A0E90", VA = "0x1810A1A90")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string MJGDEDHGPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool PFFLINCBNAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer CAFEJLEOHDK, ScriptableRenderContext OMHMFLHBNDJ, RenderingData CMGIFFLKING);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8AA260", Offset = "0x8A9660", VA = "0x1808AA260")]
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
		private class AGLEPBMGHJG : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool EPIBDKJOIMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> CBMMNKIDGDE;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> JEJGDHMGPKL;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7469430", Offset = "0x7468830", VA = "0x187469430")]
			public AGLEPBMGHJG(RenderPassEvent OEPCBMIJALI, bool EPIBDKJOIMC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7468E10", Offset = "0x7468210", VA = "0x187468E10")]
			public bool EBELDMFHNMM(CameraData NKIKJAFILFH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x74690F0", Offset = "0x74684F0", VA = "0x1874690F0", Slot = "9")]
			public override void Execute(ScriptableRenderContext OMHMFLHBNDJ, RenderingData CMGIFFLKING)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x74692C0", Offset = "0x74686C0", VA = "0x1874692C0")]
			private void HCCOOBAJIDN(PerCameraRenderEffect HLOGLMLEIML, ScriptableRenderContext OMHMFLHBNDJ, RenderingData CMGIFFLKING)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private AGLEPBMGHJG m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private AGLEPBMGHJG m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7471370", Offset = "0x7470770", VA = "0x187471370", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x74712E0", Offset = "0x74706E0", VA = "0x1874712E0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OMALFJOLMMP, RenderingData CMGIFFLKING)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x10A1A90", Offset = "0x10A0E90", VA = "0x1810A1A90")]
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
		[Cpp2IlInjected.Address(RVA = "0x74715C0", Offset = "0x74709C0", VA = "0x1874715C0")]
		public static void HOHBOKEHDBD(ScriptableRenderPass AAPHBNIMOBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7471420", Offset = "0x7470820", VA = "0x187471420", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer OMALFJOLMMP, RenderingData CMGIFFLKING)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x10A1A90", Offset = "0x10A0E90", VA = "0x1810A1A90")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class JICGMNFEPDM
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 GPNKLDOJPAM;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 AHAJEKAIHHH;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 DAPEHDOOADO;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 KJICCOAADEO;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 AIIKJMMNJGB;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x746EB10", Offset = "0x746DF10", VA = "0x18746EB10")]
	public static uint HGACKCFJHMA(uint LBEGFJJGJFP, uint GAMIAAAKNPF, uint PPLPGLGEGKB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x746EB20", Offset = "0x746DF20", VA = "0x18746EB20")]
	public static uint3 HOIJAMMIDIB(float3 CLHMEGFDOKF, float3 ALJDDKLGIMP, float3 IKCBKAOMFMA)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x746E8D0", Offset = "0x746DCD0", VA = "0x18746E8D0")]
	public static void GMMFLGMLMKL(float3 AAHBEBEADJJ, float3 DKKNDHMKDNO, float3 DBICIEIFBBK, float CBOFEOAGGML, [Out] uint3 HELKOLCHKDC, [Out] uint3 BHMGMKDMAHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x746E400", Offset = "0x746D800", VA = "0x18746E400")]
	public static void BHCDFELOKPK(float3 IKKAFCDLFIB, float3 HPKOMJOMEMC, float HAIEMBCHPMF, float LLKPKGCDECN, [Out] float3 GEJINEDEPDI, [Out] float CBOFEOAGGML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x746ED10", Offset = "0x746E110", VA = "0x18746ED10")]
	private static float3 LGCCDNNECDN(float3 OJMDJPGPCJC, float3 HNNAFPKNHJD, float3 PEAKOHFFOBH, float3 CLLBEPEJOIH)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BBMLHJGDCJN
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly FLILHMOBPPM FDMPCCEAHCD;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly FLILHMOBPPM DIDDHOLNDCO;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly FLILHMOBPPM MDBABLAEMGG;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly FLILHMOBPPM JMLBHHDHGFJ;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class CDBLFHAPKPN
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static Mesh HNEEEIDBDFB;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x746BE40", Offset = "0x746B240", VA = "0x18746BE40")]
	public static Mesh GDKEJPDGGHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x746B5E0", Offset = "0x746A9E0", VA = "0x18746B5E0")]
	public static Matrix4x4 AKLKCBJEKAG(Camera EMNPAABKIAH, bool AKHLOPAILAK = false, bool DDENLHJPBIK = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x746BA80", Offset = "0x746AE80", VA = "0x18746BA80")]
	private static Mesh FDNAKNPKAIP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__647889524
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x74729E0", Offset = "0x7471DE0", VA = "0x1874729E0")]
	public static void KOANDPIKEHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x74729D0", Offset = "0x7471DD0", VA = "0x1874729D0")]
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
