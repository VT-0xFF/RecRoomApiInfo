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
	public class LogRegistrationIndex : BPLGCOBKJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x83D8B00", Offset = "0x83D7100", VA = "0x1883D8B00", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		public enum OOLALIJLJEO
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface DAAIAGNMIOE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void CENANGHIOME(ScriptableRenderContext INLEBAAACKH, List<Camera> ECCKNGENJPA);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface EJGIEFLPLOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void CENANGHIOME(ScriptableRenderContext INLEBAAACKH, RenderingData KEFIEFNNIGG);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class GLCCIANLPHM : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x83D30E0", Offset = "0x83D16E0", VA = "0x1883D30E0")]
			public GLCCIANLPHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x83D3080", Offset = "0x83D1680", VA = "0x1883D3080", Slot = "9")]
			public override void Execute(ScriptableRenderContext INLEBAAACKH, RenderingData KEFIEFNNIGG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private GLCCIANLPHM _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<DAAIAGNMIOE> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<DAAIAGNMIOE> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<EJGIEFLPLOO> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<EJGIEFLPLOO> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x83DA900", Offset = "0x83D8F00", VA = "0x1883DA900")]
		public static void PNBHFNPGBOP(OOLALIJLJEO EHPFMEDAEBN, DAAIAGNMIOE KDEDEIPJIIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x83DABB0", Offset = "0x83D91B0", VA = "0x1883DABB0")]
		public static void POEPPLEPCBG(OOLALIJLJEO EHPFMEDAEBN, DAAIAGNMIOE KDEDEIPJIIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83DA9C0", Offset = "0x83D8FC0", VA = "0x1883DA9C0")]
		public static void PNBHFNPGBOP(OOLALIJLJEO EHPFMEDAEBN, EJGIEFLPLOO JIJLNHGEOBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83DAAF0", Offset = "0x83D90F0", VA = "0x1883DAAF0")]
		public static void POEPPLEPCBG(OOLALIJLJEO EHPFMEDAEBN, EJGIEFLPLOO JIJLNHGEOBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83D9C80", Offset = "0x83D8280", VA = "0x1883D9C80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83D9BE0", Offset = "0x83D81E0", VA = "0x1883D9BE0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CCKFDFMBDLN, RenderingData KEFIEFNNIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83D9E60", Offset = "0x83D8460", VA = "0x1883D9E60", Slot = "9")]
		protected override void Dispose(bool OIDNBIJAMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83D9F70", Offset = "0x83D8570", VA = "0x1883D9F70")]
		private static void GNGHEGFBFNA(ScriptableRenderContext INLEBAAACKH, List<Camera> ECCKNGENJPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83DAA80", Offset = "0x83D9080", VA = "0x1883DAA80")]
		private static void POBBOFEEOAL(ScriptableRenderContext INLEBAAACKH, List<Camera> ECCKNGENJPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83DA450", Offset = "0x83D8A50", VA = "0x1883DA450")]
		private static void LNGFLIIMNIP(ScriptableRenderContext INLEBAAACKH, RenderingData KEFIEFNNIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x165D620", Offset = "0x165BC20", VA = "0x18165D620")]
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
		private class EPIPNEIAEPD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool AIGJILLJCPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<BLNOABCJJDM> NDHJOEMEKJO;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x83D07A0", Offset = "0x83CEDA0", VA = "0x1883D07A0")]
			public EPIPNEIAEPD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class ONECNIPLJHJ : PreRenderManager.EJGIEFLPLOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string EFDEPLHDOOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler EKBEEGMKGKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly EPIPNEIAEPD OLFDCNBFFJP;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x83D96D0", Offset = "0x83D7CD0", VA = "0x1883D96D0")]
			public ONECNIPLJHJ(EPIPNEIAEPD JJLJMHNJFBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x83D92E0", Offset = "0x83D78E0", VA = "0x1883D92E0", Slot = "4")]
			public void CENANGHIOME(ScriptableRenderContext INLEBAAACKH, RenderingData KEFIEFNNIGG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class LAKGFKOAIPN : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string LPIIOHOEMOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly EPIPNEIAEPD JJLJMHNJFBN;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x83D7560", Offset = "0x83D5B60", VA = "0x1883D7560")]
			public LAKGFKOAIPN(RenderPassEvent DOHIDBPJPGC, EPIPNEIAEPD JJLJMHNJFBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x83D7250", Offset = "0x83D5850", VA = "0x1883D7250", Slot = "9")]
			public override void Execute(ScriptableRenderContext INLEBAAACKH, RenderingData KEFIEFNNIGG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<BLNOABCJJDM> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private ONECNIPLJHJ fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private LAKGFKOAIPN fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private EPIPNEIAEPD sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x83D08C0", Offset = "0x83CEEC0", VA = "0x1883D08C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83D0C40", Offset = "0x83CF240", VA = "0x1883D0C40", Slot = "9")]
		protected override void Dispose(bool OIDNBIJAMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83D0830", Offset = "0x83CEE30", VA = "0x1883D0830", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CCKFDFMBDLN, RenderingData KEFIEFNNIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x165D620", Offset = "0x165BC20", VA = "0x18165D620")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BLNOABCJJDM
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AABNMOCODPA(CommandBuffer FMKKBPDFNBM, Camera HJJMGNJIHHH, [NotNull] UniversalAdditionalCameraData FHFBKODOAPJ, bool GFAMAIKEJBP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MNLMICGJFBP(Camera HJJMGNJIHHH, CommandBuffer HKEOEPNOEKP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IIPBBIIPHCB
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool JFFNPKKDIEJ;
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
		private KOGMGOLBOMM _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private GCAAIJHKFKG _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83D8A90", Offset = "0x83D7090", VA = "0x1883D8A90", Slot = "9")]
		protected override void Dispose(bool BIGFPAPNDDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83D87E0", Offset = "0x83D6DE0", VA = "0x1883D87E0")]
		private void DGKCEBHNNNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83D8490", Offset = "0x83D6A90", VA = "0x1883D8490", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CCKFDFMBDLN, RenderingData KEFIEFNNIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x165D620", Offset = "0x165BC20", VA = "0x18165D620")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EFMIENOBHCD
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x83D0750", Offset = "0x83CED50", VA = "0x1883D0750")]
	public static int BDCBCAEOLEI(bool EPDHNABKFDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1AE41D0", Offset = "0x1AE27D0", VA = "0x181AE41D0")]
	public static int BDMGHLBBDBC(bool EPDHNABKFDB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OPPFOFGHHKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType BFCBGKAOLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float MHAPJAHMOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float OOGHBEFHNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float LLNEBBDFIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 HJKJCPABHNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 GJJFMODADCI;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct AOIKPAEMJDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort KOKPCLOFCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float NJOJKKNFDBB;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct LHHJDEEFIPF : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<OPPFOFGHHKA> IBECMCNGPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 IGJLIIFDLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 GJJBADAPBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, AOIKPAEMJDM>.ParallelWriter AFHLJLMGCKD;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x83D7F50", Offset = "0x83D6550", VA = "0x1883D7F50", Slot = "4")]
	public void Execute(int KOKPCLOFCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x83D7640", Offset = "0x83D5C40", VA = "0x1883D7640")]
	private void ACGLAGOFFHA(uint3 ALGADLBANDP, uint3 HNAKIHEPFPD, ushort KOKPCLOFCEE, float3 OGGDLKICPCM, float JFAIFBOKAKO, float MBINPPJBLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x83D7AA0", Offset = "0x83D60A0", VA = "0x1883D7AA0")]
	private void EFACHNDLGLJ(uint3 ALGADLBANDP, uint3 HNAKIHEPFPD, ushort KOKPCLOFCEE, float3 OGGDLKICPCM, float3 APLAMCEFEME, float3 FJDIDCOIHOI, float JFAIFBOKAKO, float HPMCMCBDLLA, float MBINPPJBLNF, float ODIPJGLKFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x83D79B0", Offset = "0x83D5FB0", VA = "0x1883D79B0")]
	private float3 DIHAINFKGHK(uint3 ALGADLBANDP, float3 OGGDLKICPCM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x83D23C0", Offset = "0x83D09C0", VA = "0x1883D23C0")]
	private float IOFDNDOFJMO(float MHAPJAHMOKH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x83D2100", Offset = "0x83D0700", VA = "0x1883D2100")]
	private float IFCFOOFDAHP(float3 EDHLFMIBCDO, float3 FJDIDCOIHOI, float HPMCMCBDLLA, float MBINPPJBLNF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct IGLPKKGCEPB : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, AOIKPAEMJDM> AFHLJLMGCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint JFHKDPCINEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int NKKLBAMEPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int POALHNOOBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> ADENMJFFICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> FBPPKKLOKJK;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x83D3910", Offset = "0x83D1F10", VA = "0x1883D3910", Slot = "4")]
	public void Execute(int KNNCDEMOGDJ, int NCCIDHJDPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x83D3AB0", Offset = "0x83D20B0", VA = "0x1883D3AB0")]
	private void PKDBFKKIEDB(int GAHNJMECDIK, ushort PGNMDFGPKBL, int HKEDLIEEPEM, AOIKPAEMJDM NCGADAKKBKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct EJGNOAOMIIK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, AOIKPAEMJDM> AFHLJLMGCKD;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x83D0760", Offset = "0x83CED60", VA = "0x1883D0760", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KOGMGOLBOMM : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool AEADJIMDEGM;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float GBEMAGOPOJM = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int OKCGPNOODKA = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int LLNMMJNPDMG = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private LHHJDEEFIPF BDLBAECANFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private IGLPKKGCEPB IBOCCOGDCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private EJGNOAOMIIK ECFOMGAOFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, AOIKPAEMJDM> NGMBCAIIMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private JABMOPCGLBO JKLDELIOPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool IBDKNOOJENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int POLFOEHDFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<OPPFOFGHHKA> MKPGKMBGIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle ECMCIKEAPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle EKMKIGPPMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool IPBBJDJPJFO;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x83D71A0", Offset = "0x83D57A0", VA = "0x1883D71A0")]
	public KOGMGOLBOMM(RenderPassEvent DOHIDBPJPGC, ComputeShader HNFMOGONJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x83D6680", Offset = "0x83D4C80", VA = "0x1883D6680")]
	private void JDFHLOKOGCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x83D6470", Offset = "0x83D4A70", VA = "0x1883D6470")]
	public void CABACAKLCAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3912FB0", Offset = "0x39115B0", VA = "0x183912FB0")]
	public static void KCEKCNDACNP<T>(NativeArray<T> NBBLCIBNPBK, int CFNMLMNHCMF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x83D6D90", Offset = "0x83D5390", VA = "0x1883D6D90")]
	public void NGHCJLMLLGP(CameraData FHFBKODOAPJ, LightData KEBFACLIDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x83D6A50", Offset = "0x83D5050", VA = "0x1883D6A50")]
	private void MOCFFEGNDEJ(LightData KEBFACLIDBE, NativeArray<OPPFOFGHHKA> ECFDBIMCDBK, int KONJFEGEPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x83D6810", Offset = "0x83D4E10", VA = "0x1883D6810")]
	private void MCICEDIIGLA(CameraData FHFBKODOAPJ, LightData KEBFACLIDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x83D62E0", Offset = "0x83D48E0", VA = "0x1883D62E0")]
	private void BBNNOLKDBAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x83D66F0", Offset = "0x83D4CF0", VA = "0x1883D66F0")]
	private void KBGHDJEBIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x83D67F0", Offset = "0x83D4DF0", VA = "0x1883D67F0")]
	private void LKFEJFGGIKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x83D6550", Offset = "0x83D4B50", VA = "0x1883D6550")]
	private void EDDEPIBDNEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x83D6580", Offset = "0x83D4B80", VA = "0x1883D6580", Slot = "9")]
	public override void Execute(ScriptableRenderContext INLEBAAACKH, RenderingData KEFIEFNNIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x83D7130", Offset = "0x83D5730", VA = "0x1883D7130", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer HKEOEPNOEKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GCAAIJHKFKG : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort JFADDJPACDN = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float GBEMAGOPOJM = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly JABMOPCGLBO JKLDELIOPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int EAONIMELGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private OPPFOFGHHKA[] MKPGKMBGIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 JFGOAIEPHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 OCCLANDAEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint JEAACDHPANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int DIKKHFJEAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int EIDCKGBCJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> ADENMJFFICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> FBPPKKLOKJK;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x83D2C50", Offset = "0x83D1250", VA = "0x1883D2C50")]
	public GCAAIJHKFKG(RenderPassEvent DOHIDBPJPGC, ComputeShader HNFMOGONJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x83D2830", Offset = "0x83D0E30", VA = "0x1883D2830")]
	public void NGHCJLMLLGP(CameraData FHFBKODOAPJ, LightData KEBFACLIDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x83D21C0", Offset = "0x83D07C0", VA = "0x1883D21C0")]
	private void INDIANDBBOK(CameraData FHFBKODOAPJ, LightData KEBFACLIDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x83D1360", Offset = "0x83CF960", VA = "0x1883D1360")]
	public void CABACAKLCAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x83D24E0", Offset = "0x83D0AE0", VA = "0x1883D24E0")]
	private void MOCFFEGNDEJ(LightData KEBFACLIDBE, OPPFOFGHHKA[] ECFDBIMCDBK, int KONJFEGEPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x83D1240", Offset = "0x83CF840", VA = "0x1883D1240")]
	private void ANIAOMMODPK(int KNNCDEMOGDJ, int NCCIDHJDPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x83D1380", Offset = "0x83CF980", VA = "0x1883D1380")]
	private void CKLPLIJCHLO(int KNNCDEMOGDJ, int JAALIADHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x83D24A0", Offset = "0x83D0AA0", VA = "0x1883D24A0")]
	private ushort LKMFCJLAIDO(int KNNCDEMOGDJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x83D1AE0", Offset = "0x83D00E0", VA = "0x1883D1AE0")]
	private void GCPOAIOKLFN(int KNNCDEMOGDJ, int NCCIDHJDPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x83D12F0", Offset = "0x83CF8F0", VA = "0x1883D12F0")]
	private void BDNECJAICGK(int CFNMLMNHCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x83D23E0", Offset = "0x83D09E0", VA = "0x1883D23E0")]
	private void JOFEPGFCBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x83D1A00", Offset = "0x83D0000", VA = "0x1883D1A00", Slot = "9")]
	public override void Execute(ScriptableRenderContext INLEBAAACKH, RenderingData KEFIEFNNIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x83D2A90", Offset = "0x83D1090", VA = "0x1883D2A90", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer HKEOEPNOEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x83D1B50", Offset = "0x83D0150", VA = "0x1883D1B50")]
	private void HAANDMMJFMM(int KOKPCLOFCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x83D0E30", Offset = "0x83CF430", VA = "0x1883D0E30")]
	private void ACGLAGOFFHA(uint3 ALGADLBANDP, uint3 HNAKIHEPFPD, ushort KOKPCLOFCEE, float3 OGGDLKICPCM, float JFAIFBOKAKO, float MBINPPJBLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x83D14B0", Offset = "0x83CFAB0", VA = "0x1883D14B0")]
	private void EFACHNDLGLJ(uint3 ALGADLBANDP, uint3 HNAKIHEPFPD, ushort KOKPCLOFCEE, float3 OGGDLKICPCM, float3 APLAMCEFEME, float3 FJDIDCOIHOI, float JFAIFBOKAKO, float HPMCMCBDLLA, float MBINPPJBLNF, float ODIPJGLKFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x83D29A0", Offset = "0x83D0FA0", VA = "0x1883D29A0")]
	private void NPFMDJAPOIH(ushort KOKPCLOFCEE, uint ENLMLHJBBGE, float AKMOIJMHOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x83D13B0", Offset = "0x83CF9B0", VA = "0x1883D13B0")]
	private float3 DIHAINFKGHK(uint3 ALGADLBANDP, float3 OGGDLKICPCM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x83D23C0", Offset = "0x83D09C0", VA = "0x1883D23C0")]
	private float IOFDNDOFJMO(float MHAPJAHMOKH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x83D2100", Offset = "0x83D0700", VA = "0x1883D2100")]
	private float IFCFOOFDAHP(float3 EDHLFMIBCDO, float3 FJDIDCOIHOI, float HPMCMCBDLLA, float MBINPPJBLNF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x83D2AC0", Offset = "0x83D10C0", VA = "0x1883D2AC0")]
	private void PKDBFKKIEDB(int GAHNJMECDIK, ushort PGNMDFGPKBL, int HKEDLIEEPEM, AOIKPAEMJDM NCGADAKKBKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JABMOPCGLBO
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class IEAONBJMFJF
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int MDFNPGHGGBI;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int FGNNLBGGALA;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int KMAHNMFPDNP;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int PGODICDOJLA;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int AIDHGHCOADD;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int LOLNDBHKPHF;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int IPGECANPNDA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int KLHFEMKNKKP = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int FFPIAFJPHIE = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int LIDKMCDKJKL = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int OEINICPHPHB = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int MCJLILCMHFJ = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int CKMBELJAHIH = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int EGKPBONMJFG = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool IINMMAHODNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer LKMBOOBHCMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture EDEFOBFBMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int GMHFBDMBHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int PCKKCMJKAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int HMKMCHKLBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int CGDGJAPBHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int FJEKINLGIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader CEBPHMKCLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int JLMCBIMNEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int FAMFJKCBGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 IKJCJPAAOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 ECAKIPILFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> HAKOCKFKHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> OKKGJEANBMK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> KCPJJADKMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4F67EE0", Offset = "0x4F664E0", VA = "0x184F67EE0")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> FDJOPFBKBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x11612A0", Offset = "0x115F8A0", VA = "0x1811612A0")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GLPKIJNONKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xC642E0", Offset = "0xC628E0", VA = "0x180C642E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DKJJMPJMFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader JMGCFCLEGMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x83D4950", Offset = "0x83D2F50", VA = "0x1883D4950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x83D4CF0", Offset = "0x83D32F0", VA = "0x1883D4CF0")]
	public void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x83D3C20", Offset = "0x83D2220", VA = "0x1883D3C20")]
	public void DNHPHPOCODM(CameraData FHFBKODOAPJ, LightData KEBFACLIDBE, int MLAPCNPFCNL, bool EPDHNABKFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x38B8080", Offset = "0x38B6680", VA = "0x1838B8080")]
	private void KCEKCNDACNP<T>(NativeArray<T> NBBLCIBNPBK, int CFNMLMNHCMF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x83D43A0", Offset = "0x83D29A0", VA = "0x1883D43A0")]
	public void FDBHAGNMLPF(CommandBuffer HKEOEPNOEKP, ScriptableRenderContext INLEBAAACKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x83D4770", Offset = "0x83D2D70", VA = "0x1883D4770")]
	private static void IINBFNFLNBD(int EHHEPGKEPDH, CommandBuffer HKEOEPNOEKP, RenderBuffer CHFNGKAGDEO, ComputeBuffer GOMFPLNMBCC, ComputeShader DABKGDBJPLI, int IKKJNLALILF, int LEEMNFLAJOF, int JFAJMEPDMEL, int NCDPGCLGCGG, int CBFKOKHEDFI, int BGOHLDFPGEK, int KKGDABFNBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x83D49E0", Offset = "0x83D2FE0", VA = "0x1883D49E0")]
	public void MBIOLKEKKAD(CommandBuffer HKEOEPNOEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x83D3F30", Offset = "0x83D2530", VA = "0x1883D3F30")]
	private RenderTexture ECPCELDDKIN(RenderTexture NKGNEAACNJB, int IKKJNLALILF, int LEEMNFLAJOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x83D46F0", Offset = "0x83D2CF0", VA = "0x1883D46F0")]
	public void HILGDINLOAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x83D4110", Offset = "0x83D2710", VA = "0x1883D4110")]
	public void EPGHEMDOAMC(int JFFBPIKKIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x83D4DE0", Offset = "0x83D33E0", VA = "0x1883D4DE0")]
	public JABMOPCGLBO()
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
		public struct NKJMDJFEOKO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float CHMCKGHCOGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float OKCKJHLEHHI;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class AGEFGOPMBMI : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string GEOLLLBOHHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler GJJNBBHAMON;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int HAFOIAPPIIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material NLDOHGGGFGD;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x83D0670", Offset = "0x83CEC70", VA = "0x1883D0670")]
			public AGEFGOPMBMI(RenderPassEvent DOHIDBPJPGC, Material CANJBFKPEMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x83D02A0", Offset = "0x83CE8A0", VA = "0x1883D02A0", Slot = "9")]
			public override void Execute(ScriptableRenderContext INLEBAAACKH, RenderingData KEFIEFNNIGG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static NKJMDJFEOKO CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private AGEFGOPMBMI m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x83D8E60", Offset = "0x83D7460", VA = "0x1883D8E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x83D8E10", Offset = "0x83D7410", VA = "0x1883D8E10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x83D8C60", Offset = "0x83D7260", VA = "0x1883D8C60", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x83D8B90", Offset = "0x83D7190", VA = "0x1883D8B90", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CCKFDFMBDLN, RenderingData KEFIEFNNIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x165D620", Offset = "0x165BC20", VA = "0x18165D620")]
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
		public struct JOHONILAKEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float IGFPMBHDFPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color AENHDLBCELJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh CAIGMLPLLDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve EBGIHPIFIJA;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class GIEEAOLKBBD : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string GEOLLLBOHHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler GJJNBBHAMON;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int FFPBEHLDMAM;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int FBIAJDMLJFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material NLDOHGGGFGD;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x83D2FA0", Offset = "0x83D15A0", VA = "0x1883D2FA0")]
			public GIEEAOLKBBD(RenderPassEvent DOHIDBPJPGC, Material CANJBFKPEMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x83D2D00", Offset = "0x83D1300", VA = "0x1883D2D00", Slot = "9")]
			public override void Execute(ScriptableRenderContext INLEBAAACKH, RenderingData KEFIEFNNIGG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static JOHONILAKEB CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private GIEEAOLKBBD m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x83D9170", Offset = "0x83D7770", VA = "0x1883D9170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x83D8FC0", Offset = "0x83D75C0", VA = "0x1883D8FC0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x83D8EB0", Offset = "0x83D74B0", VA = "0x1883D8EB0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CCKFDFMBDLN, RenderingData KEFIEFNNIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x165D620", Offset = "0x165BC20", VA = "0x18165D620")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string PGKKOGEJECP
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool DCNLOHJFFEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer HKEOEPNOEKP, ScriptableRenderContext INLEBAAACKH, RenderingData KEFIEFNNIGG);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9EA210", Offset = "0x9E8810", VA = "0x1809EA210")]
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
		private class GPNEOCMHBLC : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool NKABFFGLMCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> GHFAGPLMNBK;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> CBPOJLMMMCJ;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x83D3720", Offset = "0x83D1D20", VA = "0x1883D3720")]
			public GPNEOCMHBLC(RenderPassEvent DOHIDBPJPGC, bool NKABFFGLMCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x83D33B0", Offset = "0x83D19B0", VA = "0x1883D33B0")]
			public bool LMDIFILKIOE(CameraData FHFBKODOAPJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x83D3100", Offset = "0x83D1700", VA = "0x1883D3100", Slot = "9")]
			public override void Execute(ScriptableRenderContext INLEBAAACKH, RenderingData KEFIEFNNIGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x83D32D0", Offset = "0x83D18D0", VA = "0x1883D32D0")]
			private void LIAMAFLLCBD(PerCameraRenderEffect FDGIBIJHEMI, ScriptableRenderContext INLEBAAACKH, RenderingData KEFIEFNNIGG)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private GPNEOCMHBLC m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private GPNEOCMHBLC m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x83D9820", Offset = "0x83D7E20", VA = "0x1883D9820", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x83D9790", Offset = "0x83D7D90", VA = "0x1883D9790", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CCKFDFMBDLN, RenderingData KEFIEFNNIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x165D620", Offset = "0x165BC20", VA = "0x18165D620")]
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
		[Cpp2IlInjected.Address(RVA = "0x83D9A70", Offset = "0x83D8070", VA = "0x1883D9A70")]
		public static void MKKGJHANENM(ScriptableRenderPass LLIJIJKGFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x83D98D0", Offset = "0x83D7ED0", VA = "0x1883D98D0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CCKFDFMBDLN, RenderingData KEFIEFNNIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x165D620", Offset = "0x165BC20", VA = "0x18165D620")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class KBIOIFIJNHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 LLHNEBHKNMH;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 JLJGFKDGFBD;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 CNMOPFDCHEA;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 OCOBGGLMJAK;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 JKOCGMHNIKF;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x83D5230", Offset = "0x83D3830", VA = "0x1883D5230")]
	public static uint GEIFJJLIEIJ(uint CEJAAIDLEPA, uint IMNDAJIDDFG, uint NPJIMIIOHPI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x83D5040", Offset = "0x83D3640", VA = "0x1883D5040")]
	public static uint3 DJGJJABCDEI(float3 EPCLGOKLIPO, float3 IGJLIIFDLPF, float3 GJJBADAPBBA)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x83D4E00", Offset = "0x83D3400", VA = "0x1883D4E00")]
	public static void ALGPDAKEEMI(float3 FKBEIMOMIGD, float3 FOIBFJOMKNF, float3 EEHPCPLLMFG, float PIBKBDEFJIN, [Out] uint3 NNLEKFELNLB, [Out] uint3 DHBGHLNMCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x83D53E0", Offset = "0x83D39E0", VA = "0x1883D53E0")]
	public static void POJJBILHOOJ(float3 HMEBMNHBKNP, float3 HPENJPBIEKG, float OOGHBEFHNIB, float FGHMOEJAMHE, [Out] float3 LCNBCNDGADE, [Out] float PIBKBDEFJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x83D5240", Offset = "0x83D3840", VA = "0x1883D5240")]
	private static float3 MGKJMINAKDC(float3 NBEILKHBNHH, float3 FOGIDNHENAC, float3 MDBIABHFACI, float3 ODGNGJCMEPJ)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class OFKMOOBFIDC
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly JBBHIJHGEPM KJCLHBEHNEK;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly JBBHIJHGEPM DPEJAHMDIFK;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly JBBHIJHGEPM NNNDNNHJPJK;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly JBBHIJHGEPM CAAFHPGLPFP;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly JBBHIJHGEPM GCLFMDGFEJG;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class KGFLFHKIBFB
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh LLOMLCEJNAJ;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x83D6240", Offset = "0x83D4840", VA = "0x1883D6240")]
	public static Mesh ICFLADPALAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x83D59E0", Offset = "0x83D3FE0", VA = "0x1883D59E0")]
	public static Matrix4x4 EHHKGFBLOCH(Camera HJJMGNJIHHH, bool NBGKJDGGLJL = false, bool DKNNIHMPFPI = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x83D5E80", Offset = "0x83D4480", VA = "0x1883D5E80")]
	private static Mesh FCIFIPGMLBK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2862687661
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x83DAE90", Offset = "0x83D9490", VA = "0x1883DAE90")]
	public static void PCDGKKDKHOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x83DAE80", Offset = "0x83D9480", VA = "0x1883DAE80")]
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
