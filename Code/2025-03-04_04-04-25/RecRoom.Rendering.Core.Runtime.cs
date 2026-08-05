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
		[Cpp2IlInjected.Address(RVA = "0x7C65F10", Offset = "0x7C64510", VA = "0x187C65F10", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x97B910", Offset = "0x979F10", VA = "0x18097B910")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C635D0", Offset = "0x7C61BD0", VA = "0x187C635D0")]
			public HLDNBFEPICM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x7C63570", Offset = "0x7C61B70", VA = "0x187C63570", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C67770", Offset = "0x7C65D70", VA = "0x187C67770")]
		public static void OANIKBKGOFI(LEMLDPJHAJK IIFMKMCNGNH, DDAPNGPAPEI BJLADLLOIFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C675F0", Offset = "0x7C65BF0", VA = "0x187C675F0")]
		public static void JNBIHPBDKBO(LEMLDPJHAJK IIFMKMCNGNH, DDAPNGPAPEI BJLADLLOIFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C67830", Offset = "0x7C65E30", VA = "0x187C67830")]
		public static void OANIKBKGOFI(LEMLDPJHAJK IIFMKMCNGNH, ONONCKMCMPI PCKDFOEDGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C676B0", Offset = "0x7C65CB0", VA = "0x187C676B0")]
		public static void JNBIHPBDKBO(LEMLDPJHAJK IIFMKMCNGNH, ONONCKMCMPI PCKDFOEDGDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C66E20", Offset = "0x7C65420", VA = "0x187C66E20", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C66D70", Offset = "0x7C65370", VA = "0x187C66D70", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EHMEICJAGNO, RenderingData BCBGOPGPLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C67010", Offset = "0x7C65610", VA = "0x187C67010", Slot = "9")]
		protected override void Dispose(bool MIKBEAGFNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C678F0", Offset = "0x7C65EF0", VA = "0x187C678F0")]
		private static void OENGEMAMDKA(ScriptableRenderContext BPPCEJGCMKA, List<Camera> CFPPKCDILEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7C67DF0", Offset = "0x7C663F0", VA = "0x187C67DF0")]
		private static void PDJCCLFKAIE(ScriptableRenderContext BPPCEJGCMKA, List<Camera> CFPPKCDILEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C67120", Offset = "0x7C65720", VA = "0x187C67120")]
		private static void FPPLBOCMLHJ(ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x14562B0", Offset = "0x14548B0", VA = "0x1814562B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C634E0", Offset = "0x7C61AE0", VA = "0x187C634E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C5E120", Offset = "0x7C5C720", VA = "0x187C5E120")]
			public CIJKAIBBIPD(HEHKMBLLBBI GIJPKNMIFNP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7C5DD20", Offset = "0x7C5C320", VA = "0x187C5DD20", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C5EBD0", Offset = "0x7C5D1D0", VA = "0x187C5EBD0")]
			public DOGIKHFKMHJ(RenderPassEvent HAIGDFHBOAO, HEHKMBLLBBI GIJPKNMIFNP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7C5E8C0", Offset = "0x7C5CEC0", VA = "0x187C5E8C0", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C60CA0", Offset = "0x7C5F2A0", VA = "0x187C60CA0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7C61030", Offset = "0x7C5F630", VA = "0x187C61030", Slot = "9")]
		protected override void Dispose(bool MIKBEAGFNEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C60C00", Offset = "0x7C5F200", VA = "0x187C60C00", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EHMEICJAGNO, RenderingData BCBGOPGPLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x14562B0", Offset = "0x14548B0", VA = "0x1814562B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7C65BE0", Offset = "0x7C641E0", VA = "0x187C65BE0", Slot = "9")]
		protected override void Dispose(bool HCKEDLFKINE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7C65C50", Offset = "0x7C64250", VA = "0x187C65C50")]
		private void GALLHJEDNIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7C65890", Offset = "0x7C63E90", VA = "0x187C65890", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EHMEICJAGNO, RenderingData BCBGOPGPLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x14562B0", Offset = "0x14548B0", VA = "0x1814562B0")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MFKAFGPOCJP
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C65FA0", Offset = "0x7C645A0", VA = "0x187C65FA0")]
	public static int BNJGAKLMPFB(bool FJAMDOAGLGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x18C1E50", Offset = "0x18C0450", VA = "0x1818C1E50")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C63AB0", Offset = "0x7C620B0", VA = "0x187C63AB0", Slot = "4")]
	public void Execute(int EJCNNMELHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7C64590", Offset = "0x7C62B90", VA = "0x187C64590")]
	private void JHKAGKNHGKA(uint3 PFPMNOBHLFD, uint3 HMEOIENHPCB, ushort EJCNNMELHIA, float3 NCJLJGJNMMN, float DPHCALNDANK, float ICBACAMAAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7C63FF0", Offset = "0x7C625F0", VA = "0x187C63FF0")]
	private void GIBGMOEDHKI(uint3 PFPMNOBHLFD, uint3 HMEOIENHPCB, ushort EJCNNMELHIA, float3 NCJLJGJNMMN, float3 IOEDJKDCAHI, float3 DFAOCDNLJMA, float DPHCALNDANK, float GADNONKMCON, float ICBACAMAAPI, float KBLOEHEPEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C644A0", Offset = "0x7C62AA0", VA = "0x187C644A0")]
	private float3 HBBOPJCFFNI(uint3 PFPMNOBHLFD, float3 NCJLJGJNMMN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C62C80", Offset = "0x7C61280", VA = "0x187C62C80")]
	private float NBMIDOKNHNK(float BGCNNHBPOIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C63370", Offset = "0x7C61970", VA = "0x187C63370")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C66610", Offset = "0x7C64C10", VA = "0x187C66610", Slot = "4")]
	public void Execute(int IMJGCMFDCMF, int BOLOPPPAPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7C667B0", Offset = "0x7C64DB0", VA = "0x187C667B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C61230", Offset = "0x7C5F830", VA = "0x187C61230", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C657E0", Offset = "0x7C63DE0", VA = "0x187C657E0")]
	public LINOMJNAFPD(RenderPassEvent HAIGDFHBOAO, ComputeShader PJBDLKBMJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C64900", Offset = "0x7C62F00", VA = "0x187C64900")]
	private void AAKFIMLBKGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C64D20", Offset = "0x7C63320", VA = "0x187C64D20")]
	public void EFLEBMHPPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x34CB550", Offset = "0x34C9B50", VA = "0x1834CB550")]
	public static void ADFAGIPJIEF<T>(NativeArray<T> CJFOOLJEHLK, int IBMHAIHIDJJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7C64970", Offset = "0x7C62F70", VA = "0x187C64970")]
	public void CCNDGJADPNB(CameraData LNIHFAMJLFI, LightData ILPDBGOBNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7C650C0", Offset = "0x7C636C0", VA = "0x187C650C0")]
	private void INNBOKDOLBK(LightData ILPDBGOBNCE, NativeArray<EELIDOKAMOA> BMJGNFHOEGG, int JFFPPJIDDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7C65400", Offset = "0x7C63A00", VA = "0x187C65400")]
	private void MGBGBPAAJCL(CameraData LNIHFAMJLFI, LightData ILPDBGOBNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7C64F30", Offset = "0x7C63530", VA = "0x187C64F30")]
	private void HDDIOBLFFNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7C65690", Offset = "0x7C63C90", VA = "0x187C65690")]
	private void PPFKMOGHKCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7C65640", Offset = "0x7C63C40", VA = "0x187C65640")]
	private void NLBKKBDCHMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7C64F00", Offset = "0x7C63500", VA = "0x187C64F00")]
	private void GMAFJOABMCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7C64E00", Offset = "0x7C63400", VA = "0x187C64E00", Slot = "9")]
	public override void Execute(ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7C65660", Offset = "0x7C63C60", VA = "0x187C65660", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C63430", Offset = "0x7C61A30", VA = "0x187C63430")]
	public HDANKPALNBB(RenderPassEvent HAIGDFHBOAO, ComputeShader PJBDLKBMJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C61610", Offset = "0x7C5FC10", VA = "0x187C61610")]
	public void CCNDGJADPNB(CameraData LNIHFAMJLFI, LightData ILPDBGOBNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7C618C0", Offset = "0x7C5FEC0", VA = "0x187C618C0")]
	private void EOOIJOEKHAP(CameraData LNIHFAMJLFI, LightData ILPDBGOBNCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7C617F0", Offset = "0x7C5FDF0", VA = "0x187C617F0")]
	public void EFLEBMHPPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7C621F0", Offset = "0x7C607F0", VA = "0x187C621F0")]
	private void INNBOKDOLBK(LightData ILPDBGOBNCE, EELIDOKAMOA[] BMJGNFHOEGG, int JFFPPJIDDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7C61810", Offset = "0x7C5FE10", VA = "0x187C61810")]
	private void EKFFOLFKAMH(int IMJGCMFDCMF, int BOLOPPPAPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7C62CA0", Offset = "0x7C612A0", VA = "0x187C62CA0")]
	private void OPLANNKOCMK(int IMJGCMFDCMF, int BBEJNKBNMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7C62B50", Offset = "0x7C61150", VA = "0x187C62B50")]
	private ushort JPMALMIBPFD(int IMJGCMFDCMF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7C61780", Offset = "0x7C5FD80", VA = "0x187C61780")]
	private void CMHOFAHMDOF(int IMJGCMFDCMF, int BOLOPPPAPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C62950", Offset = "0x7C60F50", VA = "0x187C62950")]
	private void JNFFHIFKEBM(int IBMHAIHIDJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7C632B0", Offset = "0x7C618B0", VA = "0x187C632B0")]
	private void PEPCHLBFGEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7C61AC0", Offset = "0x7C600C0", VA = "0x187C61AC0", Slot = "9")]
	public override void Execute(ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C62CD0", Offset = "0x7C612D0", VA = "0x187C62CD0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer PCFAPMNCMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C62D00", Offset = "0x7C61300", VA = "0x187C62D00")]
	private void PENLBKONLFF(int EJCNNMELHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C62540", Offset = "0x7C60B40", VA = "0x187C62540")]
	private void JHKAGKNHGKA(uint3 PFPMNOBHLFD, uint3 HMEOIENHPCB, ushort EJCNNMELHIA, float3 NCJLJGJNMMN, float DPHCALNDANK, float ICBACAMAAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C61BA0", Offset = "0x7C601A0", VA = "0x187C61BA0")]
	private void GIBGMOEDHKI(uint3 PFPMNOBHLFD, uint3 HMEOIENHPCB, ushort EJCNNMELHIA, float3 NCJLJGJNMMN, float3 IOEDJKDCAHI, float3 DFAOCDNLJMA, float DPHCALNDANK, float GADNONKMCON, float ICBACAMAAPI, float KBLOEHEPEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C62B90", Offset = "0x7C61190", VA = "0x187C62B90")]
	private void MMGIDAEMENJ(ushort EJCNNMELHIA, uint IHAIDHMHDDH, float CPADBKFJEPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C620F0", Offset = "0x7C606F0", VA = "0x187C620F0")]
	private float3 HBBOPJCFFNI(uint3 PFPMNOBHLFD, float3 NCJLJGJNMMN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7C62C80", Offset = "0x7C61280", VA = "0x187C62C80")]
	private float NBMIDOKNHNK(float BGCNNHBPOIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C63370", Offset = "0x7C61970", VA = "0x187C63370")]
	private float PIJCMAKGPLJ(float3 OHJCDKMANGN, float3 DFAOCDNLJMA, float GADNONKMCON, float ICBACAMAAPI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C629C0", Offset = "0x7C60FC0", VA = "0x187C629C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4A67720", Offset = "0x4A65D20", VA = "0x184A67720")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> LIFFGKCPIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xF73E80", Offset = "0xF72480", VA = "0x180F73E80")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int PGMHDDJDODM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xB08740", Offset = "0xB06D40", VA = "0x180B08740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NGGFDNFOPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x954460", Offset = "0x952A60", VA = "0x180954460")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader MDDMCMKPBAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7C5FAA0", Offset = "0x7C5E0A0", VA = "0x187C5FAA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7C5EE90", Offset = "0x7C5D490", VA = "0x187C5EE90")]
	public void GDCMIOJAIMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F160", Offset = "0x7C5D760", VA = "0x187C5F160")]
	public void LHODEDIIHCJ(CameraData LNIHFAMJLFI, LightData ILPDBGOBNCE, int EIMCANODDCG, bool FJAMDOAGLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x326FE30", Offset = "0x326E430", VA = "0x18326FE30")]
	private void ADFAGIPJIEF<T>(NativeArray<T> CJFOOLJEHLK, int IBMHAIHIDJJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FB30", Offset = "0x7C5E130", VA = "0x187C5FB30")]
	public void OLIDOBJBHAG(CommandBuffer PCFAPMNCMCB, ScriptableRenderContext BPPCEJGCMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7C5EF80", Offset = "0x7C5D580", VA = "0x187C5EF80")]
	private static void JDLIMOOJHNG(int FOCFNFNJGMB, CommandBuffer PCFAPMNCMCB, RenderBuffer BCDAHAGDDPH, ComputeBuffer INPAMAIEHMJ, ComputeShader JHJLGHOGIMO, int GNIDCKECMNP, int FHMFACJOFCB, int KBFJNMOIFAM, int KGAPJNMNMMI, int GHIFINDGCGC, int BFKABBCEIKG, int NACPMDHIODI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F780", Offset = "0x7C5DD80", VA = "0x187C5F780")]
	public void NEADIBJNGPI(CommandBuffer PCFAPMNCMCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5ECB0", Offset = "0x7C5D2B0", VA = "0x187C5ECB0")]
	private RenderTexture DGNLFPOLADF(RenderTexture EGDDJILEHIE, int GNIDCKECMNP, int FHMFACJOFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F700", Offset = "0x7C5DD00", VA = "0x187C5F700")]
	public void NCHOFOBALPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F470", Offset = "0x7C5DA70", VA = "0x187C5F470")]
	public void MEMFIKCFOHK(int CMCCPCKCJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FE80", Offset = "0x7C5E480", VA = "0x187C5FE80")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C639D0", Offset = "0x7C61FD0", VA = "0x187C639D0")]
			public KBGHKHNHNHA(RenderPassEvent HAIGDFHBOAO, Material HJCEHLILOIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7C635F0", Offset = "0x7C61BF0", VA = "0x187C635F0", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C66280", Offset = "0x7C64880", VA = "0x187C66280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7C66230", Offset = "0x7C64830", VA = "0x187C66230")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7C66080", Offset = "0x7C64680", VA = "0x187C66080", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7C65FB0", Offset = "0x7C645B0", VA = "0x187C65FB0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EHMEICJAGNO, RenderingData BCBGOPGPLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x14562B0", Offset = "0x14548B0", VA = "0x1814562B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C61530", Offset = "0x7C5FB30", VA = "0x187C61530")]
			public GKHDLMCKCNB(RenderPassEvent HAIGDFHBOAO, Material HJCEHLILOIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7C61270", Offset = "0x7C5F870", VA = "0x187C61270", Slot = "9")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C665B0", Offset = "0x7C64BB0", VA = "0x187C665B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7C66400", Offset = "0x7C64A00", VA = "0x187C66400", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7C662E0", Offset = "0x7C648E0", VA = "0x187C662E0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EHMEICJAGNO, RenderingData BCBGOPGPLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x14562B0", Offset = "0x14548B0", VA = "0x1814562B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x99B9F0", Offset = "0x999FF0", VA = "0x18099B9F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer PCFAPMNCMCB, ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x951A50", Offset = "0x950050", VA = "0x180951A50")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C5E810", Offset = "0x7C5CE10", VA = "0x187C5E810")]
			public DENLOHMDFGG(RenderPassEvent HAIGDFHBOAO, bool JJACKBKJKKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7C5E490", Offset = "0x7C5CA90", VA = "0x187C5E490")]
			public bool PMBMMACDLKD(CameraData LNIHFAMJLFI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x7C5E1E0", Offset = "0x7C5C7E0", VA = "0x187C5E1E0", Slot = "9")]
			public override void Execute(ScriptableRenderContext BPPCEJGCMKA, RenderingData BCBGOPGPLBC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7C5E3B0", Offset = "0x7C5C9B0", VA = "0x187C5E3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C669B0", Offset = "0x7C64FB0", VA = "0x187C669B0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7C66920", Offset = "0x7C64F20", VA = "0x187C66920", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EHMEICJAGNO, RenderingData BCBGOPGPLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x14562B0", Offset = "0x14548B0", VA = "0x1814562B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C66C00", Offset = "0x7C65200", VA = "0x187C66C00")]
		public static void NDOLNIMFADJ(ScriptableRenderPass DJBOHBFAOKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7C66A60", Offset = "0x7C65060", VA = "0x187C66A60", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer EHMEICJAGNO, RenderingData BCBGOPGPLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x14562B0", Offset = "0x14548B0", VA = "0x1814562B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C5FEA0", Offset = "0x7C5E4A0", VA = "0x187C5FEA0")]
	public static uint BMPOMKGDDON(uint IKAEODCKAIP, uint ACCJFOPIMAB, uint FOPBNJBIBAE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7C60050", Offset = "0x7C5E650", VA = "0x187C60050")]
	public static uint3 DPNEODJNDLB(float3 NDADPNJPMFO, float3 JMIOLIONNHN, float3 OLLDAOMBKJI)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7C60250", Offset = "0x7C5E850", VA = "0x187C60250")]
	public static void KAHPHEJFNGL(float3 IMCKDNEJGCK, float3 NLOJFHFFEHL, float3 GBPCPJBPMAA, float PMGAIALCDAG, [Out] uint3 GPKKAGCEOLG, [Out] uint3 JHANFONEDCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7C60490", Offset = "0x7C5EA90", VA = "0x187C60490")]
	public static void MGBCIKLOELN(float3 CGGCIMNNOEH, float3 IBCLFINODPD, float OLCJMBGBODB, float GBKEDDGPCFF, [Out] float3 MJPJCMEJEPK, [Out] float PMGAIALCDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FEB0", Offset = "0x7C5E4B0", VA = "0x187C5FEB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C5D2D0", Offset = "0x7C5B8D0", VA = "0x187C5D2D0")]
	public static Mesh KCGDFPCPCFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D380", Offset = "0x7C5B980", VA = "0x187C5D380")]
	public static Matrix4x4 KOCFKECHJOB(Camera JGNIAEGLGKO, bool CHCOEBFICGM = false, bool OCJDDOAAHLM = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D820", Offset = "0x7C5BE20", VA = "0x187C5D820")]
	private static Mesh PEKALJHFOEC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__852584176
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7C680A0", Offset = "0x7C666A0", VA = "0x187C680A0")]
	public static void HHDEEIGDEMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7C68090", Offset = "0x7C66690", VA = "0x187C68090")]
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
