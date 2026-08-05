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
		[Cpp2IlInjected.Address(RVA = "0x83F26D0", Offset = "0x83F16D0", VA = "0x1883F26D0", Slot = "4")]
		public override void AMBIAOGNIIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
			[Cpp2IlInjected.Address(RVA = "0x83ECC10", Offset = "0x83EBC10", VA = "0x1883ECC10")]
			public GLCCIANLPHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x83ECBB0", Offset = "0x83EBBB0", VA = "0x1883ECBB0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x83F4590", Offset = "0x83F3590", VA = "0x1883F4590")]
		public static void PNBHFNPGBOP(OOLALIJLJEO EHPFMEDAEBN, DAAIAGNMIOE KDEDEIPJIIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x83F4840", Offset = "0x83F3840", VA = "0x1883F4840")]
		public static void POEPPLEPCBG(OOLALIJLJEO EHPFMEDAEBN, DAAIAGNMIOE KDEDEIPJIIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83F4650", Offset = "0x83F3650", VA = "0x1883F4650")]
		public static void PNBHFNPGBOP(OOLALIJLJEO EHPFMEDAEBN, EJGIEFLPLOO JIJLNHGEOBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83F4780", Offset = "0x83F3780", VA = "0x1883F4780")]
		public static void POEPPLEPCBG(OOLALIJLJEO EHPFMEDAEBN, EJGIEFLPLOO JIJLNHGEOBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83F38C0", Offset = "0x83F28C0", VA = "0x1883F38C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83F3810", Offset = "0x83F2810", VA = "0x1883F3810", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CCKFDFMBDLN, RenderingData KEFIEFNNIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83F3AB0", Offset = "0x83F2AB0", VA = "0x1883F3AB0", Slot = "9")]
		protected override void Dispose(bool OIDNBIJAMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83F3BC0", Offset = "0x83F2BC0", VA = "0x1883F3BC0")]
		private static void GNGHEGFBFNA(ScriptableRenderContext INLEBAAACKH, List<Camera> ECCKNGENJPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83F4710", Offset = "0x83F3710", VA = "0x1883F4710")]
		private static void POBBOFEEOAL(ScriptableRenderContext INLEBAAACKH, List<Camera> ECCKNGENJPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83F40C0", Offset = "0x83F30C0", VA = "0x1883F40C0")]
		private static void LNGFLIIMNIP(ScriptableRenderContext INLEBAAACKH, RenderingData KEFIEFNNIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1642C20", Offset = "0x1641C20", VA = "0x181642C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x83EA280", Offset = "0x83E9280", VA = "0x1883EA280")]
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
			[Cpp2IlInjected.Address(RVA = "0x83F3300", Offset = "0x83F2300", VA = "0x1883F3300")]
			public ONECNIPLJHJ(EPIPNEIAEPD JJLJMHNJFBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x83F2F00", Offset = "0x83F1F00", VA = "0x1883F2F00", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x83F1120", Offset = "0x83F0120", VA = "0x1883F1120")]
			public LAKGFKOAIPN(RenderPassEvent DOHIDBPJPGC, EPIPNEIAEPD JJLJMHNJFBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x83F0E10", Offset = "0x83EFE10", VA = "0x1883F0E10", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x83EA3B0", Offset = "0x83E93B0", VA = "0x1883EA3B0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83EA740", Offset = "0x83E9740", VA = "0x1883EA740", Slot = "9")]
		protected override void Dispose(bool OIDNBIJAMJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83EA310", Offset = "0x83E9310", VA = "0x1883EA310", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CCKFDFMBDLN, RenderingData KEFIEFNNIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1642C20", Offset = "0x1641C20", VA = "0x181642C20")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83F2660", Offset = "0x83F1660", VA = "0x1883F2660", Slot = "9")]
		protected override void Dispose(bool BIGFPAPNDDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83F23A0", Offset = "0x83F13A0", VA = "0x1883F23A0")]
		private void DGKCEBHNNNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83F2050", Offset = "0x83F1050", VA = "0x1883F2050", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CCKFDFMBDLN, RenderingData KEFIEFNNIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1642C20", Offset = "0x1641C20", VA = "0x181642C20")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EFMIENOBHCD
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x83EA230", Offset = "0x83E9230", VA = "0x1883EA230")]
	public static int BDCBCAEOLEI(bool EPDHNABKFDB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1ACBAE0", Offset = "0x1ACAAE0", VA = "0x181ACBAE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x83F1B10", Offset = "0x83F0B10", VA = "0x1883F1B10", Slot = "4")]
	public void Execute(int KOKPCLOFCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x83F1200", Offset = "0x83F0200", VA = "0x1883F1200")]
	private void ACGLAGOFFHA(uint3 ALGADLBANDP, uint3 HNAKIHEPFPD, ushort KOKPCLOFCEE, float3 OGGDLKICPCM, float JFAIFBOKAKO, float MBINPPJBLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x83F1660", Offset = "0x83F0660", VA = "0x1883F1660")]
	private void EFACHNDLGLJ(uint3 ALGADLBANDP, uint3 HNAKIHEPFPD, ushort KOKPCLOFCEE, float3 OGGDLKICPCM, float3 APLAMCEFEME, float3 FJDIDCOIHOI, float JFAIFBOKAKO, float HPMCMCBDLLA, float MBINPPJBLNF, float ODIPJGLKFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x83F1570", Offset = "0x83F0570", VA = "0x1883F1570")]
	private float3 DIHAINFKGHK(uint3 ALGADLBANDP, float3 OGGDLKICPCM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x83EBED0", Offset = "0x83EAED0", VA = "0x1883EBED0")]
	private float IOFDNDOFJMO(float MHAPJAHMOKH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x83EBC10", Offset = "0x83EAC10", VA = "0x1883EBC10")]
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
	[Cpp2IlInjected.Address(RVA = "0x83ED470", Offset = "0x83EC470", VA = "0x1883ED470", Slot = "4")]
	public void Execute(int KNNCDEMOGDJ, int NCCIDHJDPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x83ED610", Offset = "0x83EC610", VA = "0x1883ED610")]
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
	[Cpp2IlInjected.Address(RVA = "0x83EA240", Offset = "0x83E9240", VA = "0x1883EA240", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x83F0D60", Offset = "0x83EFD60", VA = "0x1883F0D60")]
	public KOGMGOLBOMM(RenderPassEvent DOHIDBPJPGC, ComputeShader HNFMOGONJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x83F0220", Offset = "0x83EF220", VA = "0x1883F0220")]
	private void JDFHLOKOGCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x83F0010", Offset = "0x83EF010", VA = "0x1883F0010")]
	public void CABACAKLCAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x38F4B10", Offset = "0x38F3B10", VA = "0x1838F4B10")]
	public static void KCEKCNDACNP<T>(NativeArray<T> NBBLCIBNPBK, int CFNMLMNHCMF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x83F0930", Offset = "0x83EF930", VA = "0x1883F0930")]
	public void NGHCJLMLLGP(CameraData FHFBKODOAPJ, LightData KEBFACLIDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x83F05F0", Offset = "0x83EF5F0", VA = "0x1883F05F0")]
	private void MOCFFEGNDEJ(LightData KEBFACLIDBE, NativeArray<OPPFOFGHHKA> ECFDBIMCDBK, int KONJFEGEPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x83F03B0", Offset = "0x83EF3B0", VA = "0x1883F03B0")]
	private void MCICEDIIGLA(CameraData FHFBKODOAPJ, LightData KEBFACLIDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x83EFE80", Offset = "0x83EEE80", VA = "0x1883EFE80")]
	private void BBNNOLKDBAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x83F0290", Offset = "0x83EF290", VA = "0x1883F0290")]
	private void KBGHDJEBIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x83F0390", Offset = "0x83EF390", VA = "0x1883F0390")]
	private void LKFEJFGGIKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x83F00F0", Offset = "0x83EF0F0", VA = "0x1883F00F0")]
	private void EDDEPIBDNEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x83F0120", Offset = "0x83EF120", VA = "0x1883F0120", Slot = "9")]
	public override void Execute(ScriptableRenderContext INLEBAAACKH, RenderingData KEFIEFNNIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x83F0CE0", Offset = "0x83EFCE0", VA = "0x1883F0CE0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x83EC760", Offset = "0x83EB760", VA = "0x1883EC760")]
	public GCAAIJHKFKG(RenderPassEvent DOHIDBPJPGC, ComputeShader HNFMOGONJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x83EC340", Offset = "0x83EB340", VA = "0x1883EC340")]
	public void NGHCJLMLLGP(CameraData FHFBKODOAPJ, LightData KEBFACLIDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x83EBCD0", Offset = "0x83EACD0", VA = "0x1883EBCD0")]
	private void INDIANDBBOK(CameraData FHFBKODOAPJ, LightData KEBFACLIDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x83EAE70", Offset = "0x83E9E70", VA = "0x1883EAE70")]
	public void CABACAKLCAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x83EBFF0", Offset = "0x83EAFF0", VA = "0x1883EBFF0")]
	private void MOCFFEGNDEJ(LightData KEBFACLIDBE, OPPFOFGHHKA[] ECFDBIMCDBK, int KONJFEGEPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x83EAD50", Offset = "0x83E9D50", VA = "0x1883EAD50")]
	private void ANIAOMMODPK(int KNNCDEMOGDJ, int NCCIDHJDPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x83EAE90", Offset = "0x83E9E90", VA = "0x1883EAE90")]
	private void CKLPLIJCHLO(int KNNCDEMOGDJ, int JAALIADHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x83EBFB0", Offset = "0x83EAFB0", VA = "0x1883EBFB0")]
	private ushort LKMFCJLAIDO(int KNNCDEMOGDJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x83EB5F0", Offset = "0x83EA5F0", VA = "0x1883EB5F0")]
	private void GCPOAIOKLFN(int KNNCDEMOGDJ, int NCCIDHJDPJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x83EAE00", Offset = "0x83E9E00", VA = "0x1883EAE00")]
	private void BDNECJAICGK(int CFNMLMNHCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x83EBEF0", Offset = "0x83EAEF0", VA = "0x1883EBEF0")]
	private void JOFEPGFCBPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x83EB510", Offset = "0x83EA510", VA = "0x1883EB510", Slot = "9")]
	public override void Execute(ScriptableRenderContext INLEBAAACKH, RenderingData KEFIEFNNIGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x83EC5A0", Offset = "0x83EB5A0", VA = "0x1883EC5A0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer HKEOEPNOEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x83EB660", Offset = "0x83EA660", VA = "0x1883EB660")]
	private void HAANDMMJFMM(int KOKPCLOFCEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x83EA940", Offset = "0x83E9940", VA = "0x1883EA940")]
	private void ACGLAGOFFHA(uint3 ALGADLBANDP, uint3 HNAKIHEPFPD, ushort KOKPCLOFCEE, float3 OGGDLKICPCM, float JFAIFBOKAKO, float MBINPPJBLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x83EAFC0", Offset = "0x83E9FC0", VA = "0x1883EAFC0")]
	private void EFACHNDLGLJ(uint3 ALGADLBANDP, uint3 HNAKIHEPFPD, ushort KOKPCLOFCEE, float3 OGGDLKICPCM, float3 APLAMCEFEME, float3 FJDIDCOIHOI, float JFAIFBOKAKO, float HPMCMCBDLLA, float MBINPPJBLNF, float ODIPJGLKFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x83EC4B0", Offset = "0x83EB4B0", VA = "0x1883EC4B0")]
	private void NPFMDJAPOIH(ushort KOKPCLOFCEE, uint ENLMLHJBBGE, float AKMOIJMHOBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x83EAEC0", Offset = "0x83E9EC0", VA = "0x1883EAEC0")]
	private float3 DIHAINFKGHK(uint3 ALGADLBANDP, float3 OGGDLKICPCM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x83EBED0", Offset = "0x83EAED0", VA = "0x1883EBED0")]
	private float IOFDNDOFJMO(float MHAPJAHMOKH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x83EBC10", Offset = "0x83EAC10", VA = "0x1883EBC10")]
	private float IFCFOOFDAHP(float3 EDHLFMIBCDO, float3 FJDIDCOIHOI, float HPMCMCBDLLA, float MBINPPJBLNF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x83EC5D0", Offset = "0x83EB5D0", VA = "0x1883EC5D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4F21380", Offset = "0x4F20380", VA = "0x184F21380")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> FDJOPFBKBCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x114CEC0", Offset = "0x114BEC0", VA = "0x18114CEC0")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GLPKIJNONKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xC63430", Offset = "0xC62430", VA = "0x180C63430")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int DKJJMPJMFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9F0C90", Offset = "0x9EFC90", VA = "0x1809F0C90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader JMGCFCLEGMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x83EE4B0", Offset = "0x83ED4B0", VA = "0x1883EE4B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x83EE860", Offset = "0x83ED860", VA = "0x1883EE860")]
	public void NNOHEEPCFHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x83ED780", Offset = "0x83EC780", VA = "0x1883ED780")]
	public void DNHPHPOCODM(CameraData FHFBKODOAPJ, LightData KEBFACLIDBE, int MLAPCNPFCNL, bool EPDHNABKFDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3899F20", Offset = "0x3898F20", VA = "0x183899F20")]
	private void KCEKCNDACNP<T>(NativeArray<T> NBBLCIBNPBK, int CFNMLMNHCMF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x83EDF00", Offset = "0x83ECF00", VA = "0x1883EDF00")]
	public void FDBHAGNMLPF(CommandBuffer HKEOEPNOEKP, ScriptableRenderContext INLEBAAACKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x83EE2D0", Offset = "0x83ED2D0", VA = "0x1883EE2D0")]
	private static void IINBFNFLNBD(int EHHEPGKEPDH, CommandBuffer HKEOEPNOEKP, RenderBuffer CHFNGKAGDEO, ComputeBuffer GOMFPLNMBCC, ComputeShader DABKGDBJPLI, int IKKJNLALILF, int LEEMNFLAJOF, int JFAJMEPDMEL, int NCDPGCLGCGG, int CBFKOKHEDFI, int BGOHLDFPGEK, int KKGDABFNBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x83EE540", Offset = "0x83ED540", VA = "0x1883EE540")]
	public void MBIOLKEKKAD(CommandBuffer HKEOEPNOEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x83EDA90", Offset = "0x83ECA90", VA = "0x1883EDA90")]
	private RenderTexture ECPCELDDKIN(RenderTexture NKGNEAACNJB, int IKKJNLALILF, int LEEMNFLAJOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x83EE250", Offset = "0x83ED250", VA = "0x1883EE250")]
	public void HILGDINLOAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x83EDC70", Offset = "0x83ECC70", VA = "0x1883EDC70")]
	public void EPGHEMDOAMC(int JFFBPIKKIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x83EE950", Offset = "0x83ED950", VA = "0x1883EE950")]
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
			[Cpp2IlInjected.Address(RVA = "0x83EA150", Offset = "0x83E9150", VA = "0x1883EA150")]
			public AGEFGOPMBMI(RenderPassEvent DOHIDBPJPGC, Material CANJBFKPEMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x83E9D70", Offset = "0x83E8D70", VA = "0x1883E9D70", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x83F2A30", Offset = "0x83F1A30", VA = "0x1883F2A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x83F29E0", Offset = "0x83F19E0", VA = "0x1883F29E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x83F2830", Offset = "0x83F1830", VA = "0x1883F2830", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x83F2760", Offset = "0x83F1760", VA = "0x1883F2760", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CCKFDFMBDLN, RenderingData KEFIEFNNIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1642C20", Offset = "0x1641C20", VA = "0x181642C20")]
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
			[Cpp2IlInjected.Address(RVA = "0x83ECAD0", Offset = "0x83EBAD0", VA = "0x1883ECAD0")]
			public GIEEAOLKBBD(RenderPassEvent DOHIDBPJPGC, Material CANJBFKPEMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x83EC810", Offset = "0x83EB810", VA = "0x1883EC810", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x83F2D60", Offset = "0x83F1D60", VA = "0x1883F2D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x83F2BB0", Offset = "0x83F1BB0", VA = "0x1883F2BB0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x83F2A90", Offset = "0x83F1A90", VA = "0x1883F2A90", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CCKFDFMBDLN, RenderingData KEFIEFNNIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1642C20", Offset = "0x1641C20", VA = "0x181642C20")]
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
			[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer HKEOEPNOEKP, ScriptableRenderContext INLEBAAACKH, RenderingData KEFIEFNNIGG);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9F0210", Offset = "0x9EF210", VA = "0x1809F0210")]
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
			[Cpp2IlInjected.Address(RVA = "0x83ED260", Offset = "0x83EC260", VA = "0x1883ED260")]
			public GPNEOCMHBLC(RenderPassEvent DOHIDBPJPGC, bool NKABFFGLMCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x83ECEE0", Offset = "0x83EBEE0", VA = "0x1883ECEE0")]
			public bool LMDIFILKIOE(CameraData FHFBKODOAPJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x83ECC30", Offset = "0x83EBC30", VA = "0x1883ECC30", Slot = "9")]
			public override void Execute(ScriptableRenderContext INLEBAAACKH, RenderingData KEFIEFNNIGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x83ECE00", Offset = "0x83EBE00", VA = "0x1883ECE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x83F3450", Offset = "0x83F2450", VA = "0x1883F3450", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x83F33C0", Offset = "0x83F23C0", VA = "0x1883F33C0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CCKFDFMBDLN, RenderingData KEFIEFNNIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1642C20", Offset = "0x1641C20", VA = "0x181642C20")]
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
		[Cpp2IlInjected.Address(RVA = "0x83F36A0", Offset = "0x83F26A0", VA = "0x1883F36A0")]
		public static void MKKGJHANENM(ScriptableRenderPass LLIJIJKGFCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x83F3500", Offset = "0x83F2500", VA = "0x1883F3500", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer CCKFDFMBDLN, RenderingData KEFIEFNNIGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1642C20", Offset = "0x1641C20", VA = "0x181642C20")]
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
	[Cpp2IlInjected.Address(RVA = "0x83EEDB0", Offset = "0x83EDDB0", VA = "0x1883EEDB0")]
	public static uint GEIFJJLIEIJ(uint CEJAAIDLEPA, uint IMNDAJIDDFG, uint NPJIMIIOHPI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x83EEBB0", Offset = "0x83EDBB0", VA = "0x1883EEBB0")]
	public static uint3 DJGJJABCDEI(float3 EPCLGOKLIPO, float3 IGJLIIFDLPF, float3 GJJBADAPBBA)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x83EE970", Offset = "0x83ED970", VA = "0x1883EE970")]
	public static void ALGPDAKEEMI(float3 FKBEIMOMIGD, float3 FOIBFJOMKNF, float3 EEHPCPLLMFG, float PIBKBDEFJIN, [Out] uint3 NNLEKFELNLB, [Out] uint3 DHBGHLNMCFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x83EEF60", Offset = "0x83EDF60", VA = "0x1883EEF60")]
	public static void POJJBILHOOJ(float3 HMEBMNHBKNP, float3 HPENJPBIEKG, float OOGHBEFHNIB, float FGHMOEJAMHE, [Out] float3 LCNBCNDGADE, [Out] float PIBKBDEFJIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x83EEDC0", Offset = "0x83EDDC0", VA = "0x1883EEDC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x83EFDD0", Offset = "0x83EEDD0", VA = "0x1883EFDD0")]
	public static Mesh ICFLADPALAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x83EF570", Offset = "0x83EE570", VA = "0x1883EF570")]
	public static Matrix4x4 EHHKGFBLOCH(Camera HJJMGNJIHHH, bool NBGKJDGGLJL = false, bool DKNNIHMPFPI = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x83EFA10", Offset = "0x83EEA10", VA = "0x1883EFA10")]
	private static Mesh FCIFIPGMLBK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3894646916
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x83F4B40", Offset = "0x83F3B40", VA = "0x1883F4B40")]
	public static void PCDGKKDKHOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x83F4B30", Offset = "0x83F3B30", VA = "0x1883F4B30")]
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
