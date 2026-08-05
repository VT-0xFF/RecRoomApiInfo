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
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8D53620", Offset = "0x8D51C20", VA = "0x188D53620", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		public enum KJENGCFGAGP
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface AIHFGJNLGCI
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void ALBBNBAFAAF(ScriptableRenderContext JIFPJFGEAIK, List<Camera> LECIJIFIMLJ);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface LAOPENLADBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void ALBBNBAFAAF(ScriptableRenderContext JIFPJFGEAIK, RenderingData OFILMDKJEJK);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class AKHKJBGAPOC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8D4B940", Offset = "0x8D49F40", VA = "0x188D4B940")]
			public AKHKJBGAPOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8D4B8E0", Offset = "0x8D49EE0", VA = "0x188D4B8E0", Slot = "9")]
			public override void Execute(ScriptableRenderContext JIFPJFGEAIK, RenderingData OFILMDKJEJK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private AKHKJBGAPOC _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<AIHFGJNLGCI> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<AIHFGJNLGCI> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<LAOPENLADBM> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<LAOPENLADBM> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D55440", Offset = "0x8D53A40", VA = "0x188D55440")]
		public static void BIIJLIHPKMG(KJENGCFGAGP APBCLAKNDMO, AIHFGJNLGCI GPBLJFCDOOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D557B0", Offset = "0x8D53DB0", VA = "0x188D557B0")]
		public static void DABKHFEJDEB(KJENGCFGAGP APBCLAKNDMO, AIHFGJNLGCI GPBLJFCDOOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8D55500", Offset = "0x8D53B00", VA = "0x188D55500")]
		public static void BIIJLIHPKMG(KJENGCFGAGP APBCLAKNDMO, LAOPENLADBM AMOADFDMOBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8D55870", Offset = "0x8D53E70", VA = "0x188D55870")]
		public static void DABKHFEJDEB(KJENGCFGAGP APBCLAKNDMO, LAOPENLADBM AMOADFDMOBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8D555C0", Offset = "0x8D53BC0", VA = "0x188D555C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8D55390", Offset = "0x8D53990", VA = "0x188D55390", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MAFJPEPPLNH, RenderingData OFILMDKJEJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8D55E10", Offset = "0x8D54410", VA = "0x188D55E10", Slot = "9")]
		protected override void Dispose(bool GBAHAHDFBCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8D55F20", Offset = "0x8D54520", VA = "0x188D55F20")]
		private static void JGMBMMMGPHA(ScriptableRenderContext JIFPJFGEAIK, List<Camera> LECIJIFIMLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8D56430", Offset = "0x8D54A30", VA = "0x188D56430")]
		private static void PJIAEMLFIAM(ScriptableRenderContext JIFPJFGEAIK, List<Camera> LECIJIFIMLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8D55930", Offset = "0x8D53F30", VA = "0x188D55930")]
		private static void DJDABIHBMPJ(ScriptableRenderContext JIFPJFGEAIK, RenderingData OFILMDKJEJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x19B02E0", Offset = "0x19AE8E0", VA = "0x1819B02E0")]
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
		private class HFLBCFKBKCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool FLFKOKGEGLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<LOBKBJFJGBC> BEGHKGFNKLH;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8D4F410", Offset = "0x8D4DA10", VA = "0x188D4F410")]
			public HFLBCFKBKCH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class LECMAIKMAIA : PreRenderManager.LAOPENLADBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string IOLHCJCAAHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler MIDAFNJCEPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly HFLBCFKBKCH EIPFNBHJAAF;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8D501C0", Offset = "0x8D4E7C0", VA = "0x188D501C0")]
			public LECMAIKMAIA(HFLBCFKBKCH AIGINHPLMPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8D4FDB0", Offset = "0x8D4E3B0", VA = "0x188D4FDB0", Slot = "4")]
			public void ALBBNBAFAAF(ScriptableRenderContext JIFPJFGEAIK, RenderingData OFILMDKJEJK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class DOHKBIGICCF : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string JLKLMDCFKKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly HFLBCFKBKCH AIGINHPLMPE;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8D4DE50", Offset = "0x8D4C450", VA = "0x188D4DE50")]
			public DOHKBIGICCF(RenderPassEvent AHMCHECBFBO, HFLBCFKBKCH AIGINHPLMPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8D4DB40", Offset = "0x8D4C140", VA = "0x188D4DB40", Slot = "9")]
			public override void Execute(ScriptableRenderContext JIFPJFGEAIK, RenderingData OFILMDKJEJK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<LOBKBJFJGBC> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private LECMAIKMAIA fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private DOHKBIGICCF fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private HFLBCFKBKCH sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8D4E7A0", Offset = "0x8D4CDA0", VA = "0x188D4E7A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8D4EB30", Offset = "0x8D4D130", VA = "0x188D4EB30", Slot = "9")]
		protected override void Dispose(bool GBAHAHDFBCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8D4E700", Offset = "0x8D4CD00", VA = "0x188D4E700", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MAFJPEPPLNH, RenderingData OFILMDKJEJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x19B02E0", Offset = "0x19AE8E0", VA = "0x1819B02E0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LOBKBJFJGBC
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JGLNBBBMHKL(CommandBuffer HKKLCJKKKNB, Camera ADKEJHHNPHO, [NotNull] UniversalAdditionalCameraData EKBENFMJNFH, bool DCJCDJLOFGK);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NIKNCMGOIJH(Camera ADKEJHHNPHO, CommandBuffer DNEIOFKKGBP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class EDKKDJCLGCL
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool JJACABOFFMJ;
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
		private DBEFKCPDAMN _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private LLKLFBOEOPN _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8D535B0", Offset = "0x8D51BB0", VA = "0x188D535B0", Slot = "9")]
		protected override void Dispose(bool BLBODDOEHLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8D532F0", Offset = "0x8D518F0", VA = "0x188D532F0")]
		private void CPKCLILCJBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8D52FA0", Offset = "0x8D515A0", VA = "0x188D52FA0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MAFJPEPPLNH, RenderingData OFILMDKJEJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x19B02E0", Offset = "0x19AE8E0", VA = "0x1819B02E0")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class DIJBNDJFODJ
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8D4DB30", Offset = "0x8D4C130", VA = "0x188D4DB30")]
	public static int NNIAGKLPNNO(bool JGLOIOJNNAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1E77860", Offset = "0x1E75E60", VA = "0x181E77860")]
	public static int DMCCLIKMHPG(bool JGLOIOJNNAK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct CFILLGAJOPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType BFJPKGMKOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float JJBKEIIPICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float ICKFEKPLGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float CHABKIPJAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 DDNDNCACBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 ECPNPMNFCPH;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct FNKKPFIEPAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort NBEJFPOEBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float KFEFLJJLAGI;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct LLHKBJLHDPH : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<CFILLGAJOPD> OPFGLCFPOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 KFNEBJBGANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 KMHDEMNLPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, FNKKPFIEPAO>.ParallelWriter KGFGIKPMGOH;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8D502A0", Offset = "0x8D4E8A0", VA = "0x188D502A0", Slot = "4")]
	public void Execute(int NBEJFPOEBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8D50E40", Offset = "0x8D4F440", VA = "0x188D50E40")]
	private void POFCFBHDCPH(uint3 AHLJGLOJEGG, uint3 EBHFCACNLKL, ushort NBEJFPOEBKL, float3 HBMIMKDCKKL, float HBGAOBMKMPJ, float PJKOPFIONAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8D507E0", Offset = "0x8D4EDE0", VA = "0x188D507E0")]
	private void GDEHIKDBMPG(uint3 AHLJGLOJEGG, uint3 EBHFCACNLKL, ushort NBEJFPOEBKL, float3 HBMIMKDCKKL, float3 CHDMPGLFPFM, float3 NCNEHBAPKFL, float HBGAOBMKMPJ, float BBPAIOIPIEE, float PJKOPFIONAK, float JLNLBCAMMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8D50D50", Offset = "0x8D4F350", VA = "0x188D50D50")]
	private float3 PDBCGHKOLEL(uint3 AHLJGLOJEGG, float3 HBMIMKDCKKL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8D50280", Offset = "0x8D4E880", VA = "0x188D50280")]
	private float EEAPFCOOLHE(float JJBKEIIPICA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8D50C90", Offset = "0x8D4F290", VA = "0x188D50C90")]
	private float NKCAIDPMOGF(float3 LHKCOKAHLDC, float3 NCNEHBAPKFL, float BBPAIOIPIEE, float PJKOPFIONAK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct EKJMEMMEIKC : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, FNKKPFIEPAO> KGFGIKPMGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint POLKIFJLPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int BDMENFNNBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int COEBBIOLMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> BDPFOCGHDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> AODIKBGIJIC;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8D4E3F0", Offset = "0x8D4C9F0", VA = "0x188D4E3F0", Slot = "4")]
	public void Execute(int NPBGHABALNL, int APGMOEMKLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8D4E590", Offset = "0x8D4CB90", VA = "0x188D4E590")]
	private void IDCDDMHPELP(int ECAGPJBECIH, ushort BJELFJGHGIA, int EPGMCHICHMK, FNKKPFIEPAO AAMBDGIKNOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct NBEJKBKGICF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, FNKKPFIEPAO> KGFGIKPMGOH;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8D53D10", Offset = "0x8D52310", VA = "0x188D53D10", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DBEFKCPDAMN : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool KIBLIMHEDKH;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float JNMAHLIANPF = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int KPFKPIBIAFA = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int DJNNBFBHILB = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private LLHKBJLHDPH FHBGFJEGKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private EKJMEMMEIKC MKPOKLKNIFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private NBEJKBKGICF AKLACMMINOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, FNKKPFIEPAO> KLPEHEIBJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private OFIEAOHCEEN JPFBDPLBKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool NMIMMEBPLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int INGFBOHNHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<CFILLGAJOPD> DOOMBHLPFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle EOMEOHFEFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle GPAMFNKLNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool GGCEJNCLGAH;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8D4DA80", Offset = "0x8D4C080", VA = "0x188D4DA80")]
	public DBEFKCPDAMN(RenderPassEvent AHMCHECBFBO, ComputeShader KOHEIGENKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8D4D250", Offset = "0x8D4B850", VA = "0x188D4D250")]
	private void KPAOEDJBJFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8D4D170", Offset = "0x8D4B770", VA = "0x188D4D170")]
	public void GLFDHPBDCEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3C1D840", Offset = "0x3C1BE40", VA = "0x183C1D840")]
	public static void MGNPGDKCPNA<T>(NativeArray<T> GHKPAFFMJAO, int KCJLCGFEBMJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8D4D620", Offset = "0x8D4BC20", VA = "0x188D4D620")]
	public void MKGLFPNFNPP(CameraData EKBENFMJNFH, LightData PBMGNCDLNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8D4D2C0", Offset = "0x8D4B8C0", VA = "0x188D4D2C0")]
	private void LCFGFELCLHJ(LightData PBMGNCDLNEN, NativeArray<CFILLGAJOPD> LJMPJFKIJCG, int OKDLDDMCOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8D4CBA0", Offset = "0x8D4B1A0", VA = "0x188D4CBA0")]
	private void CJJLBLDEODJ(CameraData EKBENFMJNFH, LightData PBMGNCDLNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8D4CDE0", Offset = "0x8D4B3E0", VA = "0x188D4CDE0")]
	private void DJPBOICPBMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8D4CF70", Offset = "0x8D4B570", VA = "0x188D4CF70")]
	private void EABFIBCCHPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8D4D600", Offset = "0x8D4BC00", VA = "0x188D4D600")]
	private void MCKHCHJLPKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8D4D9D0", Offset = "0x8D4BFD0", VA = "0x188D4D9D0")]
	private void OPHMCGMNKLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8D4D070", Offset = "0x8D4B670", VA = "0x188D4D070", Slot = "9")]
	public override void Execute(ScriptableRenderContext JIFPJFGEAIK, RenderingData OFILMDKJEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8D4DA00", Offset = "0x8D4C000", VA = "0x188D4DA00", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer DNEIOFKKGBP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LLKLFBOEOPN : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort BJEFNGCJBCA = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float JNMAHLIANPF = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly OFIEAOHCEEN JPFBDPLBKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int EMNPJMMJPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private CFILLGAJOPD[] DOOMBHLPFMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 CBOCGGLIFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 JPAFPNMEJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint FELPNKHBIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int HLPFDAINJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int DGCDKGBPIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> BDPFOCGHDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> AODIKBGIJIC;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8D52EF0", Offset = "0x8D514F0", VA = "0x188D52EF0")]
	public LLKLFBOEOPN(RenderPassEvent AHMCHECBFBO, ComputeShader KOHEIGENKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8D52070", Offset = "0x8D50670", VA = "0x188D52070")]
	public void MKGLFPNFNPP(CameraData EKBENFMJNFH, LightData PBMGNCDLNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8D511E0", Offset = "0x8D4F7E0", VA = "0x188D511E0")]
	private void CBKKIIHGIMD(CameraData EKBENFMJNFH, LightData PBMGNCDLNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8D51A80", Offset = "0x8D50080", VA = "0x188D51A80")]
	public void GLFDHPBDCEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8D51D20", Offset = "0x8D50320", VA = "0x188D51D20")]
	private void LCFGFELCLHJ(LightData PBMGNCDLNEN, CFILLGAJOPD[] LJMPJFKIJCG, int OKDLDDMCOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8D51C70", Offset = "0x8D50270", VA = "0x188D51C70")]
	private void KIGJEDBHKLD(int NPBGHABALNL, int APGMOEMKLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8D511B0", Offset = "0x8D4F7B0", VA = "0x188D511B0")]
	private void BFADLHNIFFK(int NPBGHABALNL, int LMJBLNOIBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8D51AA0", Offset = "0x8D500A0", VA = "0x188D51AA0")]
	private ushort HGMMFODGHOP(int NPBGHABALNL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8D52880", Offset = "0x8D50E80", VA = "0x188D52880")]
	private void OEGFOAAKEIC(int NPBGHABALNL, int APGMOEMKLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8D514C0", Offset = "0x8D4FAC0", VA = "0x188D514C0")]
	private void GAONNICNHLG(int KCJLCGFEBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8D52A20", Offset = "0x8D51020", VA = "0x188D52A20")]
	private void PHDDHHAOMNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8D513E0", Offset = "0x8D4F9E0", VA = "0x188D513E0", Slot = "9")]
	public override void Execute(ScriptableRenderContext JIFPJFGEAIK, RenderingData OFILMDKJEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8D528F0", Offset = "0x8D50EF0", VA = "0x188D528F0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer DNEIOFKKGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8D522D0", Offset = "0x8D508D0", VA = "0x188D522D0")]
	private void NNENEBDKCBG(int NBEJFPOEBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8D52AE0", Offset = "0x8D510E0", VA = "0x188D52AE0")]
	private void POFCFBHDCPH(uint3 AHLJGLOJEGG, uint3 EBHFCACNLKL, ushort NBEJFPOEBKL, float3 HBMIMKDCKKL, float HBGAOBMKMPJ, float PJKOPFIONAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8D51530", Offset = "0x8D4FB30", VA = "0x188D51530")]
	private void GDEHIKDBMPG(uint3 AHLJGLOJEGG, uint3 EBHFCACNLKL, ushort NBEJFPOEBKL, float3 HBMIMKDCKKL, float3 CHDMPGLFPFM, float3 NCNEHBAPKFL, float HBGAOBMKMPJ, float BBPAIOIPIEE, float PJKOPFIONAK, float JLNLBCAMMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8D521E0", Offset = "0x8D507E0", VA = "0x188D521E0")]
	private void MODDHBHIJLJ(ushort NBEJFPOEBKL, uint PFGJABECGGP, float BHMHDGKNMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8D52920", Offset = "0x8D50F20", VA = "0x188D52920")]
	private float3 PDBCGHKOLEL(uint3 AHLJGLOJEGG, float3 HBMIMKDCKKL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8D50280", Offset = "0x8D4E880", VA = "0x188D50280")]
	private float EEAPFCOOLHE(float JJBKEIIPICA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8D50C90", Offset = "0x8D4F290", VA = "0x188D50C90")]
	private float NKCAIDPMOGF(float3 LHKCOKAHLDC, float3 NCNEHBAPKFL, float BBPAIOIPIEE, float PJKOPFIONAK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8D51AE0", Offset = "0x8D500E0", VA = "0x188D51AE0")]
	private void IDCDDMHPELP(int ECAGPJBECIH, ushort BJELFJGHGIA, int EPGMCHICHMK, FNKKPFIEPAO AAMBDGIKNOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class OFIEAOHCEEN
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class CCMOCIMACDD
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int EFIEMDAAFMG;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int DOBMLJNFEKH;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int PDHCDOHMCJG;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int DFMFGDCHIAK;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int MIKDJDKDJKG;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int DMHBMCKOLIG;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int CLMEJAJPCCG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int CNPDPAFEHJK = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int HBNJIPIMKKE = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int KMGGELHEFDD = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int JINANAADOBL = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int GHFCIMLOKIM = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int OOHAPEOBLJF = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int FOHBFJCBNND = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool CMNLMOKLFEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer MKIPEGBHADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture AJOCNCBEKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int AMJLOJEKKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int DNHHANIJBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int PJHDHFAHJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int BEDAJFEKOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int NDFMGBKGFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader PPCFDFBKPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int IGNNHEAKJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int MKGMEPMHDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 JHIPKMHFBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 NABAOHKPCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> ACLIHABCKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> FGOIMEECACP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> KPHJPHAOONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x55915B0", Offset = "0x558FBB0", VA = "0x1855915B0")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> GDBELEMECNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x136A850", Offset = "0x1368E50", VA = "0x18136A850")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int FHCFNLFLCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAF64A0", Offset = "0xAF4AA0", VA = "0x180AF64A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EHFAKKPKDAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xAA70A0", Offset = "0xAA56A0", VA = "0x180AA70A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader JMMALCBIINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8D548E0", Offset = "0x8D52EE0", VA = "0x188D548E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8D54560", Offset = "0x8D52B60", VA = "0x188D54560")]
	public void ELCJDKMDHCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8D53D50", Offset = "0x8D52350", VA = "0x188D53D50")]
	public void BIOAPGFMBDD(CameraData EKBENFMJNFH, LightData PBMGNCDLNEN, int HCLNELKFEAH, bool JGLOIOJNNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3F7CD50", Offset = "0x3F7B350", VA = "0x183F7CD50")]
	private void MGNPGDKCPNA<T>(NativeArray<T> GHKPAFFMJAO, int KCJLCGFEBMJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8D54970", Offset = "0x8D52F70", VA = "0x188D54970")]
	public void LAAABMHCPPD(CommandBuffer DNEIOFKKGBP, ScriptableRenderContext JIFPJFGEAIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8D54CC0", Offset = "0x8D532C0", VA = "0x188D54CC0")]
	private static void NPKDOHFJCBE(int MAKJJICIGHM, CommandBuffer DNEIOFKKGBP, RenderBuffer HHPFPKLJJAM, ComputeBuffer CAIKHJMKOJF, ComputeShader KJPAIPIAHDL, int JFOAGANFFFC, int AAKCHPFJFLN, int FIGCJMBIPGJ, int ABBDCBBDOKG, int BHEEEIMEIFE, int EIAFGNHECPL, int NPMHNKCNNKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8D54240", Offset = "0x8D52840", VA = "0x188D54240")]
	public void EJLODPGJLNA(CommandBuffer DNEIOFKKGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8D54060", Offset = "0x8D52660", VA = "0x188D54060")]
	private RenderTexture DKMKODIAHGN(RenderTexture KDKFDBAGHKF, int JFOAGANFFFC, int AAKCHPFJFLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8D54EA0", Offset = "0x8D534A0", VA = "0x188D54EA0")]
	public void PAIMAAAMDLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8D54650", Offset = "0x8D52C50", VA = "0x188D54650")]
	public void IBCEPDJPKJF(int JALBJHCNANO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8D54F20", Offset = "0x8D53520", VA = "0x188D54F20")]
	public OFIEAOHCEEN()
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
		public struct EAFOEGJIPLD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float DJCOKIMBMCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float HOGHFIHAPGM;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class EACIBBLEPAP : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string IIKCDFDHODL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler HGPICJEGOCH;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int IHNKPPBOEEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material EEFCDKPJILI;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8D4E310", Offset = "0x8D4C910", VA = "0x188D4E310")]
			public EACIBBLEPAP(RenderPassEvent AHMCHECBFBO, Material PFHPGDKJCCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8D4DF30", Offset = "0x8D4C530", VA = "0x188D4DF30", Slot = "9")]
			public override void Execute(ScriptableRenderContext JIFPJFGEAIK, RenderingData OFILMDKJEJK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static EAFOEGJIPLD CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private EACIBBLEPAP m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x8D53980", Offset = "0x8D51F80", VA = "0x188D53980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8D53930", Offset = "0x8D51F30", VA = "0x188D53930")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8D53780", Offset = "0x8D51D80", VA = "0x188D53780", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8D536B0", Offset = "0x8D51CB0", VA = "0x188D536B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MAFJPEPPLNH, RenderingData OFILMDKJEJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x19B02E0", Offset = "0x19AE8E0", VA = "0x1819B02E0")]
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
		public struct ENJGIDLHJBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float OHPHEIDPGGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color BCDCPOCOEME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh MMFLLKBEBIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve MHKFJFHAMEM;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class ANHDHDONGJK : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string IIKCDFDHODL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler HGPICJEGOCH;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int NPCNKAELNJK;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int PNGFGGFGHFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material EEFCDKPJILI;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8D4BC20", Offset = "0x8D4A220", VA = "0x188D4BC20")]
			public ANHDHDONGJK(RenderPassEvent AHMCHECBFBO, Material PFHPGDKJCCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8D4B960", Offset = "0x8D49F60", VA = "0x188D4B960", Slot = "9")]
			public override void Execute(ScriptableRenderContext JIFPJFGEAIK, RenderingData OFILMDKJEJK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static ENJGIDLHJBM CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private ANHDHDONGJK m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x8D53CB0", Offset = "0x8D522B0", VA = "0x188D53CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8D53B00", Offset = "0x8D52100", VA = "0x188D53B00", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8D539E0", Offset = "0x8D51FE0", VA = "0x188D539E0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MAFJPEPPLNH, RenderingData OFILMDKJEJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x19B02E0", Offset = "0x19AE8E0", VA = "0x1819B02E0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string GNDOGGIJDEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool FAMLLJNALGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer DNEIOFKKGBP, ScriptableRenderContext JIFPJFGEAIK, RenderingData OFILMDKJEJK);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
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
		private class GEEMHPLNKLL : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool GLODPHOGKEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> ADCJCMGMCCE;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> FNLHGPBGJBC;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8D4F360", Offset = "0x8D4D960", VA = "0x188D4F360")]
			public GEEMHPLNKLL(RenderPassEvent AHMCHECBFBO, bool GLODPHOGKEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8D4EF00", Offset = "0x8D4D500", VA = "0x188D4EF00")]
			public bool HFNJJDCIHFC(CameraData EKBENFMJNFH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8D4ED30", Offset = "0x8D4D330", VA = "0x188D4ED30", Slot = "9")]
			public override void Execute(ScriptableRenderContext JIFPJFGEAIK, RenderingData OFILMDKJEJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8D4F1F0", Offset = "0x8D4D7F0", VA = "0x188D4F1F0")]
			private void OHHCBODKHGM(PerCameraRenderEffect FNBONMMGOJM, ScriptableRenderContext JIFPJFGEAIK, RenderingData OFILMDKJEJK)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private GEEMHPLNKLL m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private GEEMHPLNKLL m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8D54FD0", Offset = "0x8D535D0", VA = "0x188D54FD0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8D54F40", Offset = "0x8D53540", VA = "0x188D54F40", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MAFJPEPPLNH, RenderingData OFILMDKJEJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x19B02E0", Offset = "0x19AE8E0", VA = "0x1819B02E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D55220", Offset = "0x8D53820", VA = "0x188D55220")]
		public static void GBPPNDMBKHG(ScriptableRenderPass KLECFBHIKLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8D55080", Offset = "0x8D53680", VA = "0x188D55080", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer MAFJPEPPLNH, RenderingData OFILMDKJEJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x19B02E0", Offset = "0x19AE8E0", VA = "0x1819B02E0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class CIPOPMLBKAF
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 GBLNMJKMEPP;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 EHHPHAJHHFA;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 FGNOAFEOBNA;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 CMKPNGJICFM;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 PAHICGKAFBG;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8D4BFA0", Offset = "0x8D4A5A0", VA = "0x188D4BFA0")]
	public static uint BADBMJOMPND(uint GBNAKFLHCOE, uint ODEKEFJCIIL, uint CNCKLOHMBJK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8D4C480", Offset = "0x8D4AA80", VA = "0x188D4C480")]
	public static uint3 KBCPBDKIOEM(float3 APHHGJIDDCM, float3 KFNEBJBGANI, float3 KMHDEMNLPJI)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8D4C680", Offset = "0x8D4AC80", VA = "0x188D4C680")]
	public static void LEINALJLKIB(float3 DDHMNNDHPCH, float3 GBEAPNCAILC, float3 MGBDBAFIPJL, float JPNOJNLEGJO, [Out] uint3 CKIHKAANNON, [Out] uint3 CAAPIKALDNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8D4BFB0", Offset = "0x8D4A5B0", VA = "0x188D4BFB0")]
	public static void FPPFMCBONGD(float3 PGCDFJNJABC, float3 IMCMAKNMFCP, float ICKFEKPLGLA, float JLDIENFLJAC, [Out] float3 FFDMBCJMMJF, [Out] float JPNOJNLEGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8D4C8C0", Offset = "0x8D4AEC0", VA = "0x188D4C8C0")]
	private static float3 PJGPNBIEMBE(float3 FMJAJHPJOLN, float3 GFGJFONAAJJ, float3 FDKJPIAFFAH, float3 GGCABFBBJIA)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class CBJANJOEFOL
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly IPHNFELODMJ EAOLGPIMJLI;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly IPHNFELODMJ AONIPPCIKPH;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly IPHNFELODMJ OPDLMNIALEA;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly IPHNFELODMJ CKCFMOPIMBI;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly IPHNFELODMJ DGBOIDNLNON;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class JIDKINBDJGB
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh AHPOJOCCHCF;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8D4F940", Offset = "0x8D4DF40", VA = "0x188D4F940")]
	public static Mesh JJPDBCAFCCE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8D4F4A0", Offset = "0x8D4DAA0", VA = "0x188D4F4A0")]
	public static Matrix4x4 EPLMMGNJFMO(Camera ADKEJHHNPHO, bool GAMNJKOJLGF = false, bool PJDHIKLJBEG = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8D4F9F0", Offset = "0x8D4DFF0", VA = "0x188D4F9F0")]
	private static Mesh MEKGMHGMJIF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2414802248
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8D566E0", Offset = "0x8D54CE0", VA = "0x188D566E0")]
	public static void GIFNOONCKGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8D566D0", Offset = "0x8D54CD0", VA = "0x188D566D0")]
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
