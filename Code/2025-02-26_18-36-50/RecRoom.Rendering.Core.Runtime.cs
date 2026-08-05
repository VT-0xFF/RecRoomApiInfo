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
	public class LogRegistrationIndex : EIAOKFHFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1830", Offset = "0x7BC0C30", VA = "0x187BC1830", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
		public enum LEMLDPJHAJK
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface DDAPNGPAPEI
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void JIBIDAAECFI(ScriptableRenderContext BPPCEJGCMKA, List<Camera> CFPPKCDILEO);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface ONONCKMCMPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void JIBIDAAECFI(ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class HLDNBFEPICM : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x7BBEEF0", Offset = "0x7BBE2F0", VA = "0x187BBEEF0")]
			public HLDNBFEPICM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7BBEE90", Offset = "0x7BBE290", VA = "0x187BBEE90", Slot = "9")]
			public override void Execute(ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private HLDNBFEPICM _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<DDAPNGPAPEI> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<DDAPNGPAPEI> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<ONONCKMCMPI> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<ONONCKMCMPI> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3090", Offset = "0x7BC2490", VA = "0x187BC3090")]
		public static void OANIKBKGOFI(LEMLDPJHAJK IIFMKMCNGNH, DDAPNGPAPEI BJLADLLOIFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2F10", Offset = "0x7BC2310", VA = "0x187BC2F10")]
		public static void JNBIHPBDKBO(LEMLDPJHAJK IIFMKMCNGNH, DDAPNGPAPEI BJLADLLOIFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3150", Offset = "0x7BC2550", VA = "0x187BC3150")]
		public static void OANIKBKGOFI(LEMLDPJHAJK IIFMKMCNGNH, ONONCKMCMPI PCKDFOEDGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2FD0", Offset = "0x7BC23D0", VA = "0x187BC2FD0")]
		public static void JNBIHPBDKBO(LEMLDPJHAJK IIFMKMCNGNH, ONONCKMCMPI PCKDFOEDGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2740", Offset = "0x7BC1B40", VA = "0x187BC2740", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2690", Offset = "0x7BC1A90", VA = "0x187BC2690", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EHMEICJAGNO, RenderingData BCBGOPGPLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2930", Offset = "0x7BC1D30", VA = "0x187BC2930", Slot = "9")]
		protected override void Dispose(bool MIKBEAGFNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3210", Offset = "0x7BC2610", VA = "0x187BC3210")]
		private static void OENGEMAMDKA(ScriptableRenderContext BPPCEJGCMKA, List<Camera> CFPPKCDILEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3710", Offset = "0x7BC2B10", VA = "0x187BC3710")]
		private static void PDJCCLFKAIE(ScriptableRenderContext BPPCEJGCMKA, List<Camera> CFPPKCDILEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2A40", Offset = "0x7BC1E40", VA = "0x187BC2A40")]
		private static void FPPLBOCMLHJ(ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1434F10", Offset = "0x1434310", VA = "0x181434F10")]
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
		private class HEHKMBLLBBI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool FIPHHAMEMLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<EJNAKAJJBIE> NPOJIKECONN;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7BBEE00", Offset = "0x7BBE200", VA = "0x187BBEE00")]
			public HEHKMBLLBBI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class CIJKAIBBIPD : PreRenderManager.ONONCKMCMPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string EAEFABAMADI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler FPECBBADMIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly HEHKMBLLBBI IOOHACDGMGH;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x7BB9A40", Offset = "0x7BB8E40", VA = "0x187BB9A40")]
			public CIJKAIBBIPD(HEHKMBLLBBI GIJPKNMIFNP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7BB9640", Offset = "0x7BB8A40", VA = "0x187BB9640", Slot = "4")]
			public void JIBIDAAECFI(ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class DOGIKHFKMHJ : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string INCDJFNMOJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly HEHKMBLLBBI GIJPKNMIFNP;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7BBA4F0", Offset = "0x7BB98F0", VA = "0x187BBA4F0")]
			public DOGIKHFKMHJ(RenderPassEvent HAIGDFHBOAO, HEHKMBLLBBI GIJPKNMIFNP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7BBA1E0", Offset = "0x7BB95E0", VA = "0x187BBA1E0", Slot = "9")]
			public override void Execute(ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<EJNAKAJJBIE> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private CIJKAIBBIPD fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private DOGIKHFKMHJ fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private HEHKMBLLBBI sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC5C0", Offset = "0x7BBB9C0", VA = "0x187BBC5C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC950", Offset = "0x7BBBD50", VA = "0x187BBC950", Slot = "9")]
		protected override void Dispose(bool MIKBEAGFNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC520", Offset = "0x7BBB920", VA = "0x187BBC520", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EHMEICJAGNO, RenderingData BCBGOPGPLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1434F10", Offset = "0x1434310", VA = "0x181434F10")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface EJNAKAJJBIE
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ADNMEEHBMKH(CommandBuffer COMHOLINACG, Camera JGNIAEGLGKO, [NotNull] UniversalAdditionalCameraData LNIHFAMJLFI, bool GOJPOJNNEJD);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LPGDAJGEAHL(Camera JGNIAEGLGKO, CommandBuffer PCFAPMNCMCB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class MFAOBICLJGB
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool PCPADAPBMLL;
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
		private LINOMJNAFPD _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private HDANKPALNBB _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1500", Offset = "0x7BC0900", VA = "0x187BC1500", Slot = "9")]
		protected override void Dispose(bool HCKEDLFKINE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1570", Offset = "0x7BC0970", VA = "0x187BC1570")]
		private void GALLHJEDNIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7BC11B0", Offset = "0x7BC05B0", VA = "0x187BC11B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EHMEICJAGNO, RenderingData BCBGOPGPLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1434F10", Offset = "0x1434310", VA = "0x181434F10")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MFKAFGPOCJP
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7BC18C0", Offset = "0x7BC0CC0", VA = "0x187BC18C0")]
	public static int BNJGAKLMPFB(bool FJAMDOAGLGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x18A8EB0", Offset = "0x18A82B0", VA = "0x1818A8EB0")]
	public static int EGNCOANHJAC(bool FJAMDOAGLGD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct EELIDOKAMOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType CBGKLBLCNEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float BGCNNHBPOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float OLCJMBGBODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float MHJBKLHDFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 HKDJEFIMCIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 ADNHOIEEDLM;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct CHOIOJMLJNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort EJCNNMELHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float DDCINBLMNLJ;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct KIJHLOOMFAK : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<EELIDOKAMOA> OKIOMCMJGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 JMIOLIONNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 OLLDAOMBKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, CHOIOJMLJNE>.ParallelWriter IEFGIHNAGMC;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7BBF3D0", Offset = "0x7BBE7D0", VA = "0x187BBF3D0", Slot = "4")]
	public void Execute(int EJCNNMELHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7BBFEB0", Offset = "0x7BBF2B0", VA = "0x187BBFEB0")]
	private void JHKAGKNHGKA(uint3 PFPMNOBHLFD, uint3 HMEOIENHPCB, ushort EJCNNMELHIA, float3 NCJLJGJNMMN, float DPHCALNDANK, float ICBACAMAAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7BBF910", Offset = "0x7BBED10", VA = "0x187BBF910")]
	private void GIBGMOEDHKI(uint3 PFPMNOBHLFD, uint3 HMEOIENHPCB, ushort EJCNNMELHIA, float3 NCJLJGJNMMN, float3 IOEDJKDCAHI, float3 DFAOCDNLJMA, float DPHCALNDANK, float GADNONKMCON, float ICBACAMAAPI, float KBLOEHEPEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7BBFDC0", Offset = "0x7BBF1C0", VA = "0x187BBFDC0")]
	private float3 HBBOPJCFFNI(uint3 PFPMNOBHLFD, float3 NCJLJGJNMMN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE5A0", Offset = "0x7BBD9A0", VA = "0x187BBE5A0")]
	private float NBMIDOKNHNK(float BGCNNHBPOIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7BBEC90", Offset = "0x7BBE090", VA = "0x187BBEC90")]
	private float PIJCMAKGPLJ(float3 OHJCDKMANGN, float3 DFAOCDNLJMA, float GADNONKMCON, float ICBACAMAAPI)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct PPKDNNOFAFO : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, CHOIOJMLJNE> IEFGIHNAGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint BGCBIANMKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int EKLNMDADKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int CMIPMHNBEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> OLCPJHLEOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> HGFMJMMOLOG;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC1F30", Offset = "0x7BC1330", VA = "0x187BC1F30", Slot = "4")]
	public void Execute(int IMJGCMFDCMF, int BOLOPPPAPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC20D0", Offset = "0x7BC14D0", VA = "0x187BC20D0")]
	private void JNJMJBPKKJN(int KPBHKKJFMCN, ushort MCGAPMDLELM, int PIDLPEMJJIN, CHOIOJMLJNE OIFKAOBLGON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct GJIOCDHFILI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, CHOIOJMLJNE> IEFGIHNAGMC;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7BBCB50", Offset = "0x7BBBF50", VA = "0x187BBCB50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LINOMJNAFPD : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool NIBJLAKOJKK;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float PPMKPDNHIKJ = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int CIPBAGCDPBD = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int NJBDMJBALCE = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private KIJHLOOMFAK EFJCBCPPBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private PPKDNNOFAFO DKLGABGEMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private GJIOCDHFILI GPIHNMLDMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, CHOIOJMLJNE> DHHFNJHNBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private EFJCHMCEGML FIGGJLBMABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool LFJDDEHIAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int NFEENIBFAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<EELIDOKAMOA> CGLAFBHAGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle ICJBEIJAEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle FAFBIFAOMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool KMOLGFCAJCD;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7BC1100", Offset = "0x7BC0500", VA = "0x187BC1100")]
	public LINOMJNAFPD(RenderPassEvent HAIGDFHBOAO, ComputeShader PJBDLKBMJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0220", Offset = "0x7BBF620", VA = "0x187BC0220")]
	private void AAKFIMLBKGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0640", Offset = "0x7BBFA40", VA = "0x187BC0640")]
	public void EFLEBMHPPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x34809F0", Offset = "0x347FDF0", VA = "0x1834809F0")]
	public static void ADFAGIPJIEF<T>(NativeArray<T> CJFOOLJEHLK, int IBMHAIHIDJJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0290", Offset = "0x7BBF690", VA = "0x187BC0290")]
	public void CCNDGJADPNB(CameraData LNIHFAMJLFI, LightData ILPDBGOBNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7BC09E0", Offset = "0x7BBFDE0", VA = "0x187BC09E0")]
	private void INNBOKDOLBK(LightData ILPDBGOBNCE, NativeArray<EELIDOKAMOA> BMJGNFHOEGG, int JFFPPJIDDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0D20", Offset = "0x7BC0120", VA = "0x187BC0D20")]
	private void MGBGBPAAJCL(CameraData LNIHFAMJLFI, LightData ILPDBGOBNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0850", Offset = "0x7BBFC50", VA = "0x187BC0850")]
	private void HDDIOBLFFNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0FB0", Offset = "0x7BC03B0", VA = "0x187BC0FB0")]
	private void PPFKMOGHKCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0F60", Offset = "0x7BC0360", VA = "0x187BC0F60")]
	private void NLBKKBDCHMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0820", Offset = "0x7BBFC20", VA = "0x187BC0820")]
	private void GMAFJOABMCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0720", Offset = "0x7BBFB20", VA = "0x187BC0720", Slot = "9")]
	public override void Execute(ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0F80", Offset = "0x7BC0380", VA = "0x187BC0F80", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer PCFAPMNCMCB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HDANKPALNBB : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort NLEOMBOLAFG = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float PPMKPDNHIKJ = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly EFJCHMCEGML FIGGJLBMABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int LKDKBIEALGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private EELIDOKAMOA[] CGLAFBHAGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 BJMBIKGIMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 OLNFMCIKCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint ONOANGFJPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int HKGJDJGPPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int NHJAJOHGMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> OLCPJHLEOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> HGFMJMMOLOG;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7BBED50", Offset = "0x7BBE150", VA = "0x187BBED50")]
	public HDANKPALNBB(RenderPassEvent HAIGDFHBOAO, ComputeShader PJBDLKBMJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7BBCF30", Offset = "0x7BBC330", VA = "0x187BBCF30")]
	public void CCNDGJADPNB(CameraData LNIHFAMJLFI, LightData ILPDBGOBNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD1E0", Offset = "0x7BBC5E0", VA = "0x187BBD1E0")]
	private void EOOIJOEKHAP(CameraData LNIHFAMJLFI, LightData ILPDBGOBNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD110", Offset = "0x7BBC510", VA = "0x187BBD110")]
	public void EFLEBMHPPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7BBDB10", Offset = "0x7BBCF10", VA = "0x187BBDB10")]
	private void INNBOKDOLBK(LightData ILPDBGOBNCE, EELIDOKAMOA[] BMJGNFHOEGG, int JFFPPJIDDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD130", Offset = "0x7BBC530", VA = "0x187BBD130")]
	private void EKFFOLFKAMH(int IMJGCMFDCMF, int BOLOPPPAPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE5C0", Offset = "0x7BBD9C0", VA = "0x187BBE5C0")]
	private void OPLANNKOCMK(int IMJGCMFDCMF, int BBEJNKBNMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE470", Offset = "0x7BBD870", VA = "0x187BBE470")]
	private ushort JPMALMIBPFD(int IMJGCMFDCMF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD0A0", Offset = "0x7BBC4A0", VA = "0x187BBD0A0")]
	private void CMHOFAHMDOF(int IMJGCMFDCMF, int BOLOPPPAPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE270", Offset = "0x7BBD670", VA = "0x187BBE270")]
	private void JNFFHIFKEBM(int IBMHAIHIDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7BBEBD0", Offset = "0x7BBDFD0", VA = "0x187BBEBD0")]
	private void PEPCHLBFGEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD3E0", Offset = "0x7BBC7E0", VA = "0x187BBD3E0", Slot = "9")]
	public override void Execute(ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE5F0", Offset = "0x7BBD9F0", VA = "0x187BBE5F0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer PCFAPMNCMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE620", Offset = "0x7BBDA20", VA = "0x187BBE620")]
	private void PENLBKONLFF(int EJCNNMELHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7BBDE60", Offset = "0x7BBD260", VA = "0x187BBDE60")]
	private void JHKAGKNHGKA(uint3 PFPMNOBHLFD, uint3 HMEOIENHPCB, ushort EJCNNMELHIA, float3 NCJLJGJNMMN, float DPHCALNDANK, float ICBACAMAAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD4C0", Offset = "0x7BBC8C0", VA = "0x187BBD4C0")]
	private void GIBGMOEDHKI(uint3 PFPMNOBHLFD, uint3 HMEOIENHPCB, ushort EJCNNMELHIA, float3 NCJLJGJNMMN, float3 IOEDJKDCAHI, float3 DFAOCDNLJMA, float DPHCALNDANK, float GADNONKMCON, float ICBACAMAAPI, float KBLOEHEPEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE4B0", Offset = "0x7BBD8B0", VA = "0x187BBE4B0")]
	private void MMGIDAEMENJ(ushort EJCNNMELHIA, uint IHAIDHMHDDH, float CPADBKFJEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7BBDA10", Offset = "0x7BBCE10", VA = "0x187BBDA10")]
	private float3 HBBOPJCFFNI(uint3 PFPMNOBHLFD, float3 NCJLJGJNMMN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE5A0", Offset = "0x7BBD9A0", VA = "0x187BBE5A0")]
	private float NBMIDOKNHNK(float BGCNNHBPOIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7BBEC90", Offset = "0x7BBE090", VA = "0x187BBEC90")]
	private float PIJCMAKGPLJ(float3 OHJCDKMANGN, float3 DFAOCDNLJMA, float GADNONKMCON, float ICBACAMAAPI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE2E0", Offset = "0x7BBD6E0", VA = "0x187BBE2E0")]
	private void JNJMJBPKKJN(int KPBHKKJFMCN, ushort MCGAPMDLELM, int PIDLPEMJJIN, CHOIOJMLJNE OIFKAOBLGON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class EFJCHMCEGML
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class FODCAPBOOCM
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int KAKOMPNIDFI;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int BJPKJHLJIPM;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int CEFMCJOODOP;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int NIFEBNOHNCI;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int PFDOBBOMBGH;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int CNMNNGBHOLP;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int POPAMAEJEEB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int JLKHKGLJPMH = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int EIMFGNEAIIO = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int PANEKABGEIO = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int KKAEMLIJOLI = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int MBJGOFEDIDO = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int CPAFGJFGDIN = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int KCICFEPCCID = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool EMPKLIALBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer JEMIJFPKHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture EEDPLLIBBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int KDGNKLCPHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int LLMMIEEFALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int OPDOFJBFKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int POIAIBEECEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int BBGGCHLPILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader LIIIKLEDOAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int PJNEODAFGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int LMHHFDMBGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 OPMHAGCFBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 ININFEPGBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> PDMGNDHLIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> GGIFKHDHPGA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> PDBOBLGGHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4A0BB40", Offset = "0x4A0AF40", VA = "0x184A0BB40")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> LIFFGKCPIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xF617E0", Offset = "0xF60BE0", VA = "0x180F617E0")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int PGMHDDJDODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xB00470", Offset = "0xAFF870", VA = "0x180B00470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NGGFDNFOPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x94D460", Offset = "0x94C860", VA = "0x18094D460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader MDDMCMKPBAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7BBB3C0", Offset = "0x7BBA7C0", VA = "0x187BBB3C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7BBA7B0", Offset = "0x7BB9BB0", VA = "0x187BBA7B0")]
	public void GDCMIOJAIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7BBAA80", Offset = "0x7BB9E80", VA = "0x187BBAA80")]
	public void LHODEDIIHCJ(CameraData LNIHFAMJLFI, LightData ILPDBGOBNCE, int EIMCANODDCG, bool FJAMDOAGLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3226CD0", Offset = "0x32260D0", VA = "0x183226CD0")]
	private void ADFAGIPJIEF<T>(NativeArray<T> CJFOOLJEHLK, int IBMHAIHIDJJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB450", Offset = "0x7BBA850", VA = "0x187BBB450")]
	public void OLIDOBJBHAG(CommandBuffer PCFAPMNCMCB, ScriptableRenderContext BPPCEJGCMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7BBA8A0", Offset = "0x7BB9CA0", VA = "0x187BBA8A0")]
	private static void JDLIMOOJHNG(int FOCFNFNJGMB, CommandBuffer PCFAPMNCMCB, RenderBuffer BCDAHAGDDPH, ComputeBuffer INPAMAIEHMJ, ComputeShader JHJLGHOGIMO, int GNIDCKECMNP, int FHMFACJOFCB, int KBFJNMOIFAM, int KGAPJNMNMMI, int GHIFINDGCGC, int BFKABBCEIKG, int NACPMDHIODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB0A0", Offset = "0x7BBA4A0", VA = "0x187BBB0A0")]
	public void NEADIBJNGPI(CommandBuffer PCFAPMNCMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7BBA5D0", Offset = "0x7BB99D0", VA = "0x187BBA5D0")]
	private RenderTexture DGNLFPOLADF(RenderTexture EGDDJILEHIE, int GNIDCKECMNP, int FHMFACJOFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB020", Offset = "0x7BBA420", VA = "0x187BBB020")]
	public void NCHOFOBALPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7BBAD90", Offset = "0x7BBA190", VA = "0x187BBAD90")]
	public void MEMFIKCFOHK(int CMCCPCKCJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB7A0", Offset = "0x7BBABA0", VA = "0x187BBB7A0")]
	public EFJCHMCEGML()
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
		public struct HMAELCFGJAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float DBKBPOJNHPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float LNOMNEKNMGL;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class KBGHKHNHNHA : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string COKPGNFBBDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler CNABDNGCKKB;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int IIPFNGOKDCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material LBDAPHCEELI;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7BBF2F0", Offset = "0x7BBE6F0", VA = "0x187BBF2F0")]
			public KBGHKHNHNHA(RenderPassEvent HAIGDFHBOAO, Material HJCEHLILOIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7BBEF10", Offset = "0x7BBE310", VA = "0x187BBEF10", Slot = "9")]
			public override void Execute(ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static HMAELCFGJAA CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private KBGHKHNHNHA m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7BC1BA0", Offset = "0x7BC0FA0", VA = "0x187BC1BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1B50", Offset = "0x7BC0F50", VA = "0x187BC1B50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7BC19A0", Offset = "0x7BC0DA0", VA = "0x187BC19A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7BC18D0", Offset = "0x7BC0CD0", VA = "0x187BC18D0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EHMEICJAGNO, RenderingData BCBGOPGPLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1434F10", Offset = "0x1434310", VA = "0x181434F10")]
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
		public struct PPBMPFNFHIM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float DAIJGOGFBMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color CHBEGOBGIOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh DNGHCFODNGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve HMKFGOJAFDD;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class GKHDLMCKCNB : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string COKPGNFBBDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler CNABDNGCKKB;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int CKLKHCMIKBO;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int CLDHKMFHOLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material LBDAPHCEELI;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7BBCE50", Offset = "0x7BBC250", VA = "0x187BBCE50")]
			public GKHDLMCKCNB(RenderPassEvent HAIGDFHBOAO, Material HJCEHLILOIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7BBCB90", Offset = "0x7BBBF90", VA = "0x187BBCB90", Slot = "9")]
			public override void Execute(ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static PPBMPFNFHIM CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private GKHDLMCKCNB m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x7BC1ED0", Offset = "0x7BC12D0", VA = "0x187BC1ED0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1D20", Offset = "0x7BC1120", VA = "0x187BC1D20", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C00", Offset = "0x7BC1000", VA = "0x187BC1C00", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EHMEICJAGNO, RenderingData BCBGOPGPLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1434F10", Offset = "0x1434310", VA = "0x181434F10")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string GCAALBAOLKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool MJDHONNDJNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer PCFAPMNCMCB, ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
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
		private class DENLOHMDFGG : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool JJACKBKJKKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> MHEBLHIIOJM;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> JFDMGLHHLII;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7BBA130", Offset = "0x7BB9530", VA = "0x187BBA130")]
			public DENLOHMDFGG(RenderPassEvent HAIGDFHBOAO, bool JJACKBKJKKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7BB9DB0", Offset = "0x7BB91B0", VA = "0x187BB9DB0")]
			public bool PMBMMACDLKD(CameraData LNIHFAMJLFI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7BB9B00", Offset = "0x7BB8F00", VA = "0x187BB9B00", Slot = "9")]
			public override void Execute(ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7BB9CD0", Offset = "0x7BB90D0", VA = "0x187BB9CD0")]
			private void GJMFJNANDHA(PerCameraRenderEffect MLDJEGNNEHE, ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private DENLOHMDFGG m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private DENLOHMDFGG m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7BC22D0", Offset = "0x7BC16D0", VA = "0x187BC22D0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2240", Offset = "0x7BC1640", VA = "0x187BC2240", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EHMEICJAGNO, RenderingData BCBGOPGPLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1434F10", Offset = "0x1434310", VA = "0x181434F10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BC2520", Offset = "0x7BC1920", VA = "0x187BC2520")]
		public static void NDOLNIMFADJ(ScriptableRenderPass DJBOHBFAOKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2380", Offset = "0x7BC1780", VA = "0x187BC2380", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EHMEICJAGNO, RenderingData BCBGOPGPLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1434F10", Offset = "0x1434310", VA = "0x181434F10")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class FDEGBGJGNOH
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 ELAMLKDFMPC;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 JEMDNNBJOFE;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 NBHFFPCBAAI;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 FPOOALNGAAG;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 MDFPNBBMPDF;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB7C0", Offset = "0x7BBABC0", VA = "0x187BBB7C0")]
	public static uint BMPOMKGDDON(uint IKAEODCKAIP, uint ACCJFOPIMAB, uint FOPBNJBIBAE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB970", Offset = "0x7BBAD70", VA = "0x187BBB970")]
	public static uint3 DPNEODJNDLB(float3 NDADPNJPMFO, float3 JMIOLIONNHN, float3 OLLDAOMBKJI)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7BBBB70", Offset = "0x7BBAF70", VA = "0x187BBBB70")]
	public static void KAHPHEJFNGL(float3 IMCKDNEJGCK, float3 NLOJFHFFEHL, float3 GBPCPJBPMAA, float PMGAIALCDAG, [Out] uint3 GPKKAGCEOLG, [Out] uint3 JHANFONEDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7BBBDB0", Offset = "0x7BBB1B0", VA = "0x187BBBDB0")]
	public static void MGBCIKLOELN(float3 CGGCIMNNOEH, float3 IBCLFINODPD, float OLCJMBGBODB, float GBKEDDGPCFF, [Out] float3 MJPJCMEJEPK, [Out] float PMGAIALCDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB7D0", Offset = "0x7BBABD0", VA = "0x187BBB7D0")]
	private static float3 DBEBNDGAKFB(float3 DMFPFLBAOLA, float3 BKPGOFLPAIJ, float3 KLFJKEIBLMI, float3 HHINEJAPJGO)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class CCBHGKMNFPC
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly IBCMILIKEJG ONJOHGMFMFP;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly IBCMILIKEJG OGILAJKLOOJ;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly IBCMILIKEJG JIKGHDMCNPL;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly IBCMILIKEJG NFHIOAJMNKN;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly IBCMILIKEJG OEAPNAJFEOB;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class BNFFBBNODKA
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh FFGJGEJIMKG;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8BF0", Offset = "0x7BB7FF0", VA = "0x187BB8BF0")]
	public static Mesh KCGDFPCPCFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8CA0", Offset = "0x7BB80A0", VA = "0x187BB8CA0")]
	public static Matrix4x4 KOCFKECHJOB(Camera JGNIAEGLGKO, bool CHCOEBFICGM = false, bool OCJDDOAAHLM = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9140", Offset = "0x7BB8540", VA = "0x187BB9140")]
	private static Mesh PEKALJHFOEC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3211744519
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC39C0", Offset = "0x7BC2DC0", VA = "0x187BC39C0")]
	public static void HHDEEIGDEMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC39B0", Offset = "0x7BC2DB0", VA = "0x187BC39B0")]
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
