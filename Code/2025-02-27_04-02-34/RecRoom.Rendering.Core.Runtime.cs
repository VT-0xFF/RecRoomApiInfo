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
		[Cpp2IlInjected.Address(RVA = "0x7BC1880", Offset = "0x7BC0C80", VA = "0x187BC1880", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BBEF40", Offset = "0x7BBE340", VA = "0x187BBEF40")]
			public HLDNBFEPICM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7BBEEE0", Offset = "0x7BBE2E0", VA = "0x187BBEEE0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BC30E0", Offset = "0x7BC24E0", VA = "0x187BC30E0")]
		public static void OANIKBKGOFI(LEMLDPJHAJK IIFMKMCNGNH, DDAPNGPAPEI BJLADLLOIFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2F60", Offset = "0x7BC2360", VA = "0x187BC2F60")]
		public static void JNBIHPBDKBO(LEMLDPJHAJK IIFMKMCNGNH, DDAPNGPAPEI BJLADLLOIFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7BC31A0", Offset = "0x7BC25A0", VA = "0x187BC31A0")]
		public static void OANIKBKGOFI(LEMLDPJHAJK IIFMKMCNGNH, ONONCKMCMPI PCKDFOEDGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3020", Offset = "0x7BC2420", VA = "0x187BC3020")]
		public static void JNBIHPBDKBO(LEMLDPJHAJK IIFMKMCNGNH, ONONCKMCMPI PCKDFOEDGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2790", Offset = "0x7BC1B90", VA = "0x187BC2790", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BC26E0", Offset = "0x7BC1AE0", VA = "0x187BC26E0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EHMEICJAGNO, RenderingData BCBGOPGPLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2980", Offset = "0x7BC1D80", VA = "0x187BC2980", Slot = "9")]
		protected override void Dispose(bool MIKBEAGFNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3260", Offset = "0x7BC2660", VA = "0x187BC3260")]
		private static void OENGEMAMDKA(ScriptableRenderContext BPPCEJGCMKA, List<Camera> CFPPKCDILEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC3760", Offset = "0x7BC2B60", VA = "0x187BC3760")]
		private static void PDJCCLFKAIE(ScriptableRenderContext BPPCEJGCMKA, List<Camera> CFPPKCDILEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2A90", Offset = "0x7BC1E90", VA = "0x187BC2A90")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BBEE50", Offset = "0x7BBE250", VA = "0x187BBEE50")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BB9A90", Offset = "0x7BB8E90", VA = "0x187BB9A90")]
			public CIJKAIBBIPD(HEHKMBLLBBI GIJPKNMIFNP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7BB9690", Offset = "0x7BB8A90", VA = "0x187BB9690", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BBA540", Offset = "0x7BB9940", VA = "0x187BBA540")]
			public DOGIKHFKMHJ(RenderPassEvent HAIGDFHBOAO, HEHKMBLLBBI GIJPKNMIFNP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7BBA230", Offset = "0x7BB9630", VA = "0x187BBA230", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BBC610", Offset = "0x7BBBA10", VA = "0x187BBC610", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC9A0", Offset = "0x7BBBDA0", VA = "0x187BBC9A0", Slot = "9")]
		protected override void Dispose(bool MIKBEAGFNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BBC570", Offset = "0x7BBB970", VA = "0x187BBC570", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BC1550", Offset = "0x7BC0950", VA = "0x187BC1550", Slot = "9")]
		protected override void Dispose(bool HCKEDLFKINE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7BC15C0", Offset = "0x7BC09C0", VA = "0x187BC15C0")]
		private void GALLHJEDNIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1200", Offset = "0x7BC0600", VA = "0x187BC1200", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x7BC1910", Offset = "0x7BC0D10", VA = "0x187BC1910")]
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
	[Cpp2IlInjected.Address(RVA = "0x7BBF420", Offset = "0x7BBE820", VA = "0x187BBF420", Slot = "4")]
	public void Execute(int EJCNNMELHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7BBFF00", Offset = "0x7BBF300", VA = "0x187BBFF00")]
	private void JHKAGKNHGKA(uint3 PFPMNOBHLFD, uint3 HMEOIENHPCB, ushort EJCNNMELHIA, float3 NCJLJGJNMMN, float DPHCALNDANK, float ICBACAMAAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7BBF960", Offset = "0x7BBED60", VA = "0x187BBF960")]
	private void GIBGMOEDHKI(uint3 PFPMNOBHLFD, uint3 HMEOIENHPCB, ushort EJCNNMELHIA, float3 NCJLJGJNMMN, float3 IOEDJKDCAHI, float3 DFAOCDNLJMA, float DPHCALNDANK, float GADNONKMCON, float ICBACAMAAPI, float KBLOEHEPEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7BBFE10", Offset = "0x7BBF210", VA = "0x187BBFE10")]
	private float3 HBBOPJCFFNI(uint3 PFPMNOBHLFD, float3 NCJLJGJNMMN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE5F0", Offset = "0x7BBD9F0", VA = "0x187BBE5F0")]
	private float NBMIDOKNHNK(float BGCNNHBPOIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7BBECE0", Offset = "0x7BBE0E0", VA = "0x187BBECE0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7BC1F80", Offset = "0x7BC1380", VA = "0x187BC1F80", Slot = "4")]
	public void Execute(int IMJGCMFDCMF, int BOLOPPPAPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC2120", Offset = "0x7BC1520", VA = "0x187BC2120")]
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
	[Cpp2IlInjected.Address(RVA = "0x7BBCBA0", Offset = "0x7BBBFA0", VA = "0x187BBCBA0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7BC1150", Offset = "0x7BC0550", VA = "0x187BC1150")]
	public LINOMJNAFPD(RenderPassEvent HAIGDFHBOAO, ComputeShader PJBDLKBMJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0270", Offset = "0x7BBF670", VA = "0x187BC0270")]
	private void AAKFIMLBKGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0690", Offset = "0x7BBFA90", VA = "0x187BC0690")]
	public void EFLEBMHPPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x34809F0", Offset = "0x347FDF0", VA = "0x1834809F0")]
	public static void ADFAGIPJIEF<T>(NativeArray<T> CJFOOLJEHLK, int IBMHAIHIDJJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7BC02E0", Offset = "0x7BBF6E0", VA = "0x187BC02E0")]
	public void CCNDGJADPNB(CameraData LNIHFAMJLFI, LightData ILPDBGOBNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0A30", Offset = "0x7BBFE30", VA = "0x187BC0A30")]
	private void INNBOKDOLBK(LightData ILPDBGOBNCE, NativeArray<EELIDOKAMOA> BMJGNFHOEGG, int JFFPPJIDDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0D70", Offset = "0x7BC0170", VA = "0x187BC0D70")]
	private void MGBGBPAAJCL(CameraData LNIHFAMJLFI, LightData ILPDBGOBNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7BC08A0", Offset = "0x7BBFCA0", VA = "0x187BC08A0")]
	private void HDDIOBLFFNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7BC1000", Offset = "0x7BC0400", VA = "0x187BC1000")]
	private void PPFKMOGHKCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0FB0", Offset = "0x7BC03B0", VA = "0x187BC0FB0")]
	private void NLBKKBDCHMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0870", Offset = "0x7BBFC70", VA = "0x187BC0870")]
	private void GMAFJOABMCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0770", Offset = "0x7BBFB70", VA = "0x187BC0770", Slot = "9")]
	public override void Execute(ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7BC0FD0", Offset = "0x7BC03D0", VA = "0x187BC0FD0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x7BBEDA0", Offset = "0x7BBE1A0", VA = "0x187BBEDA0")]
	public HDANKPALNBB(RenderPassEvent HAIGDFHBOAO, ComputeShader PJBDLKBMJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7BBCF80", Offset = "0x7BBC380", VA = "0x187BBCF80")]
	public void CCNDGJADPNB(CameraData LNIHFAMJLFI, LightData ILPDBGOBNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD230", Offset = "0x7BBC630", VA = "0x187BBD230")]
	private void EOOIJOEKHAP(CameraData LNIHFAMJLFI, LightData ILPDBGOBNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD160", Offset = "0x7BBC560", VA = "0x187BBD160")]
	public void EFLEBMHPPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7BBDB60", Offset = "0x7BBCF60", VA = "0x187BBDB60")]
	private void INNBOKDOLBK(LightData ILPDBGOBNCE, EELIDOKAMOA[] BMJGNFHOEGG, int JFFPPJIDDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD180", Offset = "0x7BBC580", VA = "0x187BBD180")]
	private void EKFFOLFKAMH(int IMJGCMFDCMF, int BOLOPPPAPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE610", Offset = "0x7BBDA10", VA = "0x187BBE610")]
	private void OPLANNKOCMK(int IMJGCMFDCMF, int BBEJNKBNMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE4C0", Offset = "0x7BBD8C0", VA = "0x187BBE4C0")]
	private ushort JPMALMIBPFD(int IMJGCMFDCMF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD0F0", Offset = "0x7BBC4F0", VA = "0x187BBD0F0")]
	private void CMHOFAHMDOF(int IMJGCMFDCMF, int BOLOPPPAPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE2C0", Offset = "0x7BBD6C0", VA = "0x187BBE2C0")]
	private void JNFFHIFKEBM(int IBMHAIHIDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7BBEC20", Offset = "0x7BBE020", VA = "0x187BBEC20")]
	private void PEPCHLBFGEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD430", Offset = "0x7BBC830", VA = "0x187BBD430", Slot = "9")]
	public override void Execute(ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE640", Offset = "0x7BBDA40", VA = "0x187BBE640", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer PCFAPMNCMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE670", Offset = "0x7BBDA70", VA = "0x187BBE670")]
	private void PENLBKONLFF(int EJCNNMELHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7BBDEB0", Offset = "0x7BBD2B0", VA = "0x187BBDEB0")]
	private void JHKAGKNHGKA(uint3 PFPMNOBHLFD, uint3 HMEOIENHPCB, ushort EJCNNMELHIA, float3 NCJLJGJNMMN, float DPHCALNDANK, float ICBACAMAAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7BBD510", Offset = "0x7BBC910", VA = "0x187BBD510")]
	private void GIBGMOEDHKI(uint3 PFPMNOBHLFD, uint3 HMEOIENHPCB, ushort EJCNNMELHIA, float3 NCJLJGJNMMN, float3 IOEDJKDCAHI, float3 DFAOCDNLJMA, float DPHCALNDANK, float GADNONKMCON, float ICBACAMAAPI, float KBLOEHEPEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE500", Offset = "0x7BBD900", VA = "0x187BBE500")]
	private void MMGIDAEMENJ(ushort EJCNNMELHIA, uint IHAIDHMHDDH, float CPADBKFJEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7BBDA60", Offset = "0x7BBCE60", VA = "0x187BBDA60")]
	private float3 HBBOPJCFFNI(uint3 PFPMNOBHLFD, float3 NCJLJGJNMMN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE5F0", Offset = "0x7BBD9F0", VA = "0x187BBE5F0")]
	private float NBMIDOKNHNK(float BGCNNHBPOIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7BBECE0", Offset = "0x7BBE0E0", VA = "0x187BBECE0")]
	private float PIJCMAKGPLJ(float3 OHJCDKMANGN, float3 DFAOCDNLJMA, float GADNONKMCON, float ICBACAMAAPI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7BBE330", Offset = "0x7BBD730", VA = "0x187BBE330")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BBB410", Offset = "0x7BBA810", VA = "0x187BBB410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7BBA800", Offset = "0x7BB9C00", VA = "0x187BBA800")]
	public void GDCMIOJAIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7BBAAD0", Offset = "0x7BB9ED0", VA = "0x187BBAAD0")]
	public void LHODEDIIHCJ(CameraData LNIHFAMJLFI, LightData ILPDBGOBNCE, int EIMCANODDCG, bool FJAMDOAGLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3226CD0", Offset = "0x32260D0", VA = "0x183226CD0")]
	private void ADFAGIPJIEF<T>(NativeArray<T> CJFOOLJEHLK, int IBMHAIHIDJJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB4A0", Offset = "0x7BBA8A0", VA = "0x187BBB4A0")]
	public void OLIDOBJBHAG(CommandBuffer PCFAPMNCMCB, ScriptableRenderContext BPPCEJGCMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7BBA8F0", Offset = "0x7BB9CF0", VA = "0x187BBA8F0")]
	private static void JDLIMOOJHNG(int FOCFNFNJGMB, CommandBuffer PCFAPMNCMCB, RenderBuffer BCDAHAGDDPH, ComputeBuffer INPAMAIEHMJ, ComputeShader JHJLGHOGIMO, int GNIDCKECMNP, int FHMFACJOFCB, int KBFJNMOIFAM, int KGAPJNMNMMI, int GHIFINDGCGC, int BFKABBCEIKG, int NACPMDHIODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB0F0", Offset = "0x7BBA4F0", VA = "0x187BBB0F0")]
	public void NEADIBJNGPI(CommandBuffer PCFAPMNCMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7BBA620", Offset = "0x7BB9A20", VA = "0x187BBA620")]
	private RenderTexture DGNLFPOLADF(RenderTexture EGDDJILEHIE, int GNIDCKECMNP, int FHMFACJOFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB070", Offset = "0x7BBA470", VA = "0x187BBB070")]
	public void NCHOFOBALPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7BBADE0", Offset = "0x7BBA1E0", VA = "0x187BBADE0")]
	public void MEMFIKCFOHK(int CMCCPCKCJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB7F0", Offset = "0x7BBABF0", VA = "0x187BBB7F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BBF340", Offset = "0x7BBE740", VA = "0x187BBF340")]
			public KBGHKHNHNHA(RenderPassEvent HAIGDFHBOAO, Material HJCEHLILOIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7BBEF60", Offset = "0x7BBE360", VA = "0x187BBEF60", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BC1BF0", Offset = "0x7BC0FF0", VA = "0x187BC1BF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1BA0", Offset = "0x7BC0FA0", VA = "0x187BC1BA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7BC19F0", Offset = "0x7BC0DF0", VA = "0x187BC19F0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1920", Offset = "0x7BC0D20", VA = "0x187BC1920", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BBCEA0", Offset = "0x7BBC2A0", VA = "0x187BBCEA0")]
			public GKHDLMCKCNB(RenderPassEvent HAIGDFHBOAO, Material HJCEHLILOIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7BBCBE0", Offset = "0x7BBBFE0", VA = "0x187BBCBE0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BC1F20", Offset = "0x7BC1320", VA = "0x187BC1F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1D70", Offset = "0x7BC1170", VA = "0x187BC1D70", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1C50", Offset = "0x7BC1050", VA = "0x187BC1C50", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x7BBA180", Offset = "0x7BB9580", VA = "0x187BBA180")]
			public DENLOHMDFGG(RenderPassEvent HAIGDFHBOAO, bool JJACKBKJKKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7BB9E00", Offset = "0x7BB9200", VA = "0x187BB9E00")]
			public bool PMBMMACDLKD(CameraData LNIHFAMJLFI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7BB9B50", Offset = "0x7BB8F50", VA = "0x187BB9B50", Slot = "9")]
			public override void Execute(ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7BB9D20", Offset = "0x7BB9120", VA = "0x187BB9D20")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BC2320", Offset = "0x7BC1720", VA = "0x187BC2320", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7BC2290", Offset = "0x7BC1690", VA = "0x187BC2290", Slot = "7")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BC2570", Offset = "0x7BC1970", VA = "0x187BC2570")]
		public static void NDOLNIMFADJ(ScriptableRenderPass DJBOHBFAOKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7BC23D0", Offset = "0x7BC17D0", VA = "0x187BC23D0", Slot = "7")]
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
	[Cpp2IlInjected.Address(RVA = "0x7BBB810", Offset = "0x7BBAC10", VA = "0x187BBB810")]
	public static uint BMPOMKGDDON(uint IKAEODCKAIP, uint ACCJFOPIMAB, uint FOPBNJBIBAE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB9C0", Offset = "0x7BBADC0", VA = "0x187BBB9C0")]
	public static uint3 DPNEODJNDLB(float3 NDADPNJPMFO, float3 JMIOLIONNHN, float3 OLLDAOMBKJI)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7BBBBC0", Offset = "0x7BBAFC0", VA = "0x187BBBBC0")]
	public static void KAHPHEJFNGL(float3 IMCKDNEJGCK, float3 NLOJFHFFEHL, float3 GBPCPJBPMAA, float PMGAIALCDAG, [Out] uint3 GPKKAGCEOLG, [Out] uint3 JHANFONEDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7BBBE00", Offset = "0x7BBB200", VA = "0x187BBBE00")]
	public static void MGBCIKLOELN(float3 CGGCIMNNOEH, float3 IBCLFINODPD, float OLCJMBGBODB, float GBKEDDGPCFF, [Out] float3 MJPJCMEJEPK, [Out] float PMGAIALCDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7BBB820", Offset = "0x7BBAC20", VA = "0x187BBB820")]
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
	[Cpp2IlInjected.Address(RVA = "0x7BB8C40", Offset = "0x7BB8040", VA = "0x187BB8C40")]
	public static Mesh KCGDFPCPCFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7BB8CF0", Offset = "0x7BB80F0", VA = "0x187BB8CF0")]
	public static Matrix4x4 KOCFKECHJOB(Camera JGNIAEGLGKO, bool CHCOEBFICGM = false, bool OCJDDOAAHLM = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7BB9190", Offset = "0x7BB8590", VA = "0x187BB9190")]
	private static Mesh PEKALJHFOEC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1448559054
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3A10", Offset = "0x7BC2E10", VA = "0x187BC3A10")]
	public static void HHDEEIGDEMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7BC3A00", Offset = "0x7BC2E00", VA = "0x187BC3A00")]
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
