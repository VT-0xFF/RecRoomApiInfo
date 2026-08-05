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
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8582E90", Offset = "0x8581C90", VA = "0x188582E90", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		public enum NLLLCFHGOHL
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface NFLIFOLEAGB
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void FNJHBOGPDPJ(ScriptableRenderContext JAPGNGDBBIF, List<Camera> DBPOJCJPNJB);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface EFDPOOKOAKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void FNJHBOGPDPJ(ScriptableRenderContext JAPGNGDBBIF, RenderingData KJJLFNEPCMH);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class GMMOIPGMDEE : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x857F9A0", Offset = "0x857E7A0", VA = "0x18857F9A0")]
			public GMMOIPGMDEE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x857F940", Offset = "0x857E740", VA = "0x18857F940", Slot = "9")]
			public override void Execute(ScriptableRenderContext JAPGNGDBBIF, RenderingData KJJLFNEPCMH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private GMMOIPGMDEE _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<NFLIFOLEAGB> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<NFLIFOLEAGB> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<EFDPOOKOAKP> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<EFDPOOKOAKP> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8586300", Offset = "0x8585100", VA = "0x188586300")]
		public static void BLENPNOLALN(NLLLCFHGOHL HKADEHNCHML, NFLIFOLEAGB MAJNFKHJIDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8586C40", Offset = "0x8585A40", VA = "0x188586C40")]
		public static void ENMOFPLCEJA(NLLLCFHGOHL HKADEHNCHML, NFLIFOLEAGB MAJNFKHJIDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8586240", Offset = "0x8585040", VA = "0x188586240")]
		public static void BLENPNOLALN(NLLLCFHGOHL HKADEHNCHML, EFDPOOKOAKP MBLGLHDGPEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8586D00", Offset = "0x8585B00", VA = "0x188586D00")]
		public static void ENMOFPLCEJA(NLLLCFHGOHL HKADEHNCHML, EFDPOOKOAKP MBLGLHDGPEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85868D0", Offset = "0x85856D0", VA = "0x1885868D0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8586190", Offset = "0x8584F90", VA = "0x188586190", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NHLDFAAJMGK, RenderingData KJJLFNEPCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8586AC0", Offset = "0x85858C0", VA = "0x188586AC0", Slot = "9")]
		protected override void Dispose(bool GJGMCGHFKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85863C0", Offset = "0x85851C0", VA = "0x1885863C0")]
		private static void CCJCDMIPAMA(ScriptableRenderContext JAPGNGDBBIF, List<Camera> DBPOJCJPNJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8586BD0", Offset = "0x85859D0", VA = "0x188586BD0")]
		private static void EMCDENEFLDF(ScriptableRenderContext JAPGNGDBBIF, List<Camera> DBPOJCJPNJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8586DC0", Offset = "0x8585BC0", VA = "0x188586DC0")]
		private static void LGFECEPIKFA(ScriptableRenderContext JAPGNGDBBIF, RenderingData KJJLFNEPCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x16BC320", Offset = "0x16BB120", VA = "0x1816BC320")]
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
		private class HPBOCPKKJJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool ILCLKHLMKJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<MOCGPBJMNKE> OACNINKJKOP;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x85818B0", Offset = "0x85806B0", VA = "0x1885818B0")]
			public HPBOCPKKJJN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class OENIEOPMCEP : PreRenderManager.EFDPOOKOAKP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string IDKMFFDNMIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler IIGNPCLNMMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly HPBOCPKKJJN KLAFCCFCAML;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x85857C0", Offset = "0x85845C0", VA = "0x1885857C0")]
			public OENIEOPMCEP(HPBOCPKKJJN LCEDKDIBKCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x85853B0", Offset = "0x85841B0", VA = "0x1885853B0", Slot = "4")]
			public void FNJHBOGPDPJ(ScriptableRenderContext JAPGNGDBBIF, RenderingData KJJLFNEPCMH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class GPCNEPGLDHN : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string EKEIGGLLNNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly HPBOCPKKJJN LCEDKDIBKCK;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x857FCD0", Offset = "0x857EAD0", VA = "0x18857FCD0")]
			public GPCNEPGLDHN(RenderPassEvent OHHADODJICI, HPBOCPKKJJN LCEDKDIBKCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x857F9C0", Offset = "0x857E7C0", VA = "0x18857F9C0", Slot = "9")]
			public override void Execute(ScriptableRenderContext JAPGNGDBBIF, RenderingData KJJLFNEPCMH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<MOCGPBJMNKE> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private OENIEOPMCEP fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private GPCNEPGLDHN fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private HPBOCPKKJJN sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x857F250", Offset = "0x857E050", VA = "0x18857F250", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x857F5E0", Offset = "0x857E3E0", VA = "0x18857F5E0", Slot = "9")]
		protected override void Dispose(bool GJGMCGHFKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x857F1B0", Offset = "0x857DFB0", VA = "0x18857F1B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NHLDFAAJMGK, RenderingData KJJLFNEPCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x16BC320", Offset = "0x16BB120", VA = "0x1816BC320")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MOCGPBJMNKE
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JKBHDFGJODH(CommandBuffer PFINGLBOMJC, Camera DOAGHOOOPIO, [NotNull] UniversalAdditionalCameraData OILBHOIJNPE, bool LBFDFNJDHDL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ELOIDEHKNFB(Camera DOAGHOOOPIO, CommandBuffer HEIPGNLNKGF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IHOADHANNBG
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool MLNBLINLFPB;
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
		private FGAENCGDNDJ _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private MGPLDNHGHHJ _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8582E20", Offset = "0x8581C20", VA = "0x188582E20", Slot = "9")]
		protected override void Dispose(bool BLOGELPKCMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8582810", Offset = "0x8581610", VA = "0x188582810")]
		private void AFKIPOKPEAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8582AD0", Offset = "0x85818D0", VA = "0x188582AD0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NHLDFAAJMGK, RenderingData KJJLFNEPCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x16BC320", Offset = "0x16BB120", VA = "0x1816BC320")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class FJNMIECDOGH
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x857F1A0", Offset = "0x857DFA0", VA = "0x18857F1A0")]
	public static int EEFDJBCHAEO(bool GKKBJDKIFGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1B6CA90", Offset = "0x1B6B890", VA = "0x181B6CA90")]
	public static int DDHNEHCMLCE(bool GKKBJDKIFGO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct FJKAIGNIHIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType JNAFKDGONLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float BMMKHONBJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float MIBGBKPCNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float MHAELLFABNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 CEINIJCKFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 IEOKMJJFPOH;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct IMKPBBNHLDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort MDMGIPGPGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float DFDPKNLIHLL;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct EHCKFPDDDNH : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<FJKAIGNIHIN> IDICPLNBOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 KKNECOPEANN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 PMDCNMMADJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, IMKPBBNHLDL>.ParallelWriter DOHPCDDNADO;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x857D820", Offset = "0x857C620", VA = "0x18857D820", Slot = "4")]
	public void Execute(int MDMGIPGPGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x857D2E0", Offset = "0x857C0E0", VA = "0x18857D2E0")]
	private void ALFBEPIEFHP(uint3 OCADJBIGMFH, uint3 PPCDBJCPEJB, ushort MDMGIPGPGLJ, float3 BCBIEEKOGJB, float OCDCIOKGGGP, float HINKLIPIIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x857DD60", Offset = "0x857CB60", VA = "0x18857DD60")]
	private void LLOLFLMDGCL(uint3 OCADJBIGMFH, uint3 PPCDBJCPEJB, ushort MDMGIPGPGLJ, float3 BCBIEEKOGJB, float3 HJMIEPELOEF, float3 CHLAFMEMLBK, float OCDCIOKGGGP, float FDCJCOGNELF, float HINKLIPIIHP, float EKFPAOIGHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x857D710", Offset = "0x857C510", VA = "0x18857D710")]
	private float3 EAMKNGDCCHN(uint3 OCADJBIGMFH, float3 BCBIEEKOGJB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x857D800", Offset = "0x857C600", VA = "0x18857D800")]
	private float EEBADIHPALP(float BMMKHONBJIM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x857D650", Offset = "0x857C450", VA = "0x18857D650")]
	private float AONADIGAFBJ(float3 OBJMIPPGODN, float3 CHLAFMEMLBK, float FDCJCOGNELF, float HINKLIPIIHP)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct KAJEPPJKNHI : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, IMKPBBNHLDL> DOHPCDDNADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint LBFCOMKIBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int LNLOMOBIJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int DMHHMLGKIAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> DNNFGOACNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> MLGEBLEONJL;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8581E20", Offset = "0x8580C20", VA = "0x188581E20", Slot = "4")]
	public void Execute(int BLGGKPJEGOF, int NMIMDBAIHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8581FC0", Offset = "0x8580DC0", VA = "0x188581FC0")]
	private void INHOAEMDAHM(int MLNNGNMBKPB, ushort FCBGODEABCA, int CDPHMOGDFHB, IMKPBBNHLDL IBLKIIPPDCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct NPDFJLAGNEE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, IMKPBBNHLDL> DOHPCDDNADO;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8585370", Offset = "0x8584170", VA = "0x188585370", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FGAENCGDNDJ : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool OGFFLOKGMFH;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float JELNLJBAKGJ = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int BICPENPLJAK = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int FMBGOMCLDFM = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private EHCKFPDDDNH GLFHNHLHFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private KAJEPPJKNHI DFHDPIDLJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private NPDFJLAGNEE DNNEJKJNMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, IMKPBBNHLDL> NHLAMONOOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private HBAMMFAFKMM FDEDFOCCAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool PBBEENENPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int GJBOKDKNJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<FJKAIGNIHIN> LPNPKEIIBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle FLPEOBEDMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle EOBLMOMGCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool HPBOMDPOFEI;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x857F0F0", Offset = "0x857DEF0", VA = "0x18857F0F0")]
	public FGAENCGDNDJ(RenderPassEvent OHHADODJICI, ComputeShader AJOPHGFFBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x857EBE0", Offset = "0x857D9E0", VA = "0x18857EBE0")]
	private void NJPCIIPCJOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x857EC80", Offset = "0x857DA80", VA = "0x18857EC80")]
	public void PKKKFHHMFII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x38E4EA0", Offset = "0x38E3CA0", VA = "0x1838E4EA0")]
	public static void CHBHOECNJEE<T>(NativeArray<T> KNDCNOIHMGO, int ACINDEOBNPO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x857E230", Offset = "0x857D030", VA = "0x18857E230")]
	public void EOJILNPEFDP(CameraData OILBHOIJNPE, LightData EMMKCMCKNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x857ED60", Offset = "0x857DB60", VA = "0x18857ED60")]
	private void PLNJGPPEMAF(LightData EMMKCMCKNAO, NativeArray<FJKAIGNIHIN> LHBBAFBJDJP, int FADKPDJKNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x857E6E0", Offset = "0x857D4E0", VA = "0x18857E6E0")]
	private void FIFKBLHDLBO(CameraData OILBHOIJNPE, LightData EMMKCMCKNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x857EA50", Offset = "0x857D850", VA = "0x18857EA50")]
	private void MGFBEMNPNEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x857E920", Offset = "0x857D720", VA = "0x18857E920")]
	private void JNBDPOKBGME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x857E210", Offset = "0x857D010", VA = "0x18857E210")]
	private void EIAPFMDJDLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x857EA20", Offset = "0x857D820", VA = "0x18857EA20")]
	private void KCHEKMBJDON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x857E5E0", Offset = "0x857D3E0", VA = "0x18857E5E0", Slot = "9")]
	public override void Execute(ScriptableRenderContext JAPGNGDBBIF, RenderingData KJJLFNEPCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x857EC50", Offset = "0x857DA50", VA = "0x18857EC50", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer HEIPGNLNKGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MGPLDNHGHHJ : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort OJDNEDFKCIP = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float JELNLJBAKGJ = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HBAMMFAFKMM FDEDFOCCAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int KKBADGEAENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private FJKAIGNIHIN[] LPNPKEIIBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 CBNLBFPNOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 COKFLBJHOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint ECLEGFJDADH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int MMBAKHADPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int GNOFLOHHJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> DNNFGOACNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> MLGEBLEONJL;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8584C60", Offset = "0x8583A60", VA = "0x188584C60")]
	public MGPLDNHGHHJ(RenderPassEvent OHHADODJICI, ComputeShader AJOPHGFFBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8583580", Offset = "0x8582380", VA = "0x188583580")]
	public void EOJILNPEFDP(CameraData OILBHOIJNPE, LightData EMMKCMCKNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x85840C0", Offset = "0x8582EC0", VA = "0x1885840C0")]
	private void KBALBDPDHFA(CameraData OILBHOIJNPE, LightData EMMKCMCKNAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x85848F0", Offset = "0x85836F0", VA = "0x1885848F0")]
	public void PKKKFHHMFII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8584910", Offset = "0x8583710", VA = "0x188584910")]
	private void PLNJGPPEMAF(LightData EMMKCMCKNAO, FJKAIGNIHIN[] LHBBAFBJDJP, int FADKPDJKNPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x85834D0", Offset = "0x85822D0", VA = "0x1885834D0")]
	private void ENMIBELDJGE(int BLGGKPJEGOF, int NMIMDBAIHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x85834A0", Offset = "0x85822A0", VA = "0x1885834A0")]
	private void EGEGOONNBLG(int BLGGKPJEGOF, int ALFGNAHPKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x85842C0", Offset = "0x85830C0", VA = "0x1885842C0")]
	private ushort LGOPFBDFPMM(int BLGGKPJEGOF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8583330", Offset = "0x8582130", VA = "0x188583330")]
	private void APKABDAMDJD(int BLGGKPJEGOF, int NMIMDBAIHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8584850", Offset = "0x8583650", VA = "0x188584850")]
	private void MHDKCJFLDME(int ACINDEOBNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8584000", Offset = "0x8582E00", VA = "0x188584000")]
	private void IOPCAKNAMPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x85836F0", Offset = "0x85824F0", VA = "0x1885836F0", Slot = "9")]
	public override void Execute(ScriptableRenderContext JAPGNGDBBIF, RenderingData KJJLFNEPCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x85848C0", Offset = "0x85836C0", VA = "0x1885848C0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer HEIPGNLNKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x85837D0", Offset = "0x85825D0", VA = "0x1885837D0")]
	private void FOMBGJMMPNO(int MDMGIPGPGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8582F20", Offset = "0x8581D20", VA = "0x188582F20")]
	private void ALFBEPIEFHP(uint3 OCADJBIGMFH, uint3 PPCDBJCPEJB, ushort MDMGIPGPGLJ, float3 BCBIEEKOGJB, float OCDCIOKGGGP, float HINKLIPIIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8584300", Offset = "0x8583100", VA = "0x188584300")]
	private void LLOLFLMDGCL(uint3 OCADJBIGMFH, uint3 PPCDBJCPEJB, ushort MDMGIPGPGLJ, float3 BCBIEEKOGJB, float3 HJMIEPELOEF, float3 CHLAFMEMLBK, float OCDCIOKGGGP, float FDCJCOGNELF, float HINKLIPIIHP, float EKFPAOIGHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8583D80", Offset = "0x8582B80", VA = "0x188583D80")]
	private void HFLOCACELGF(ushort MDMGIPGPGLJ, uint MBGFFGAAIGP, float CGJONEFPBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x85833A0", Offset = "0x85821A0", VA = "0x1885833A0")]
	private float3 EAMKNGDCCHN(uint3 OCADJBIGMFH, float3 BCBIEEKOGJB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x857D800", Offset = "0x857C600", VA = "0x18857D800")]
	private float EEBADIHPALP(float BMMKHONBJIM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x857D650", Offset = "0x857C450", VA = "0x18857D650")]
	private float AONADIGAFBJ(float3 OBJMIPPGODN, float3 CHLAFMEMLBK, float FDCJCOGNELF, float HINKLIPIIHP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8583E70", Offset = "0x8582C70", VA = "0x188583E70")]
	private void INHOAEMDAHM(int MLNNGNMBKPB, ushort FCBGODEABCA, int CDPHMOGDFHB, IMKPBBNHLDL IBLKIIPPDCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HBAMMFAFKMM
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class GMHCIFGAJHK
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int KOJOABBOALF;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int BKJAGAOLBMO;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int BPGOOKIMDKB;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int IMHJFBPFCAK;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int CMKMNIIIHAC;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int DLMHEAGMIAD;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int CGEBFOJIKGJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int EOBAPCLNOCC = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int GGCIGOCIKLF = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int HJHBKBIPNMD = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int FBMMIOCBOEB = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int NJLANBNODAM = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int EDKPLMCJJFG = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int HMKGAALBAOG = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool HCJANGNKCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer FGNNFNNOMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture LMNCKILDCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int OHMACLAJHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int NKKMDBNCKLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int PLEAAOEOFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int BFPCICPBNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int DNBJHFKBGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader HNIGOMNCNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int DGMBNPHLEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int BPNJGNGDKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 CJLOHMBPHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 OBMIJGILNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> CFDPEALHLIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> KKBECBDEKFG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> BDLGCGOKLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5065190", Offset = "0x5063F90", VA = "0x185065190")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> HBFCHMNIGJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x11D5440", Offset = "0x11D4240", VA = "0x1811D5440")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int LLOPDJDMLCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xC910C0", Offset = "0xC8FEC0", VA = "0x180C910C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NMACHCDOPNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader NKLNBOPIGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8580EF0", Offset = "0x857FCF0", VA = "0x188580EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8580AB0", Offset = "0x857F8B0", VA = "0x188580AB0")]
	public void LNJEMOCDJGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x85807A0", Offset = "0x857F5A0", VA = "0x1885807A0")]
	public void LBPAFLGOKHG(CameraData OILBHOIJNPE, LightData EMMKCMCKNAO, int FJFOPIJLNOA, bool GKKBJDKIFGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3916650", Offset = "0x3915450", VA = "0x183916650")]
	private void CHBHOECNJEE<T>(NativeArray<T> KNDCNOIHMGO, int ACINDEOBNPO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8580BA0", Offset = "0x857F9A0", VA = "0x188580BA0")]
	public void MKBOPJDKPIA(CommandBuffer HEIPGNLNKGF, ScriptableRenderContext JAPGNGDBBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x857FDB0", Offset = "0x857EBB0", VA = "0x18857FDB0")]
	private static void CCDNDHDAHPO(int AIJANMJCHKJ, CommandBuffer HEIPGNLNKGF, RenderBuffer MMMCOONFJDC, ComputeBuffer GHPMMPADHBO, ComputeShader CKIDEOMKPIK, int IEFKOLLJILO, int KAKHEJDLKAC, int LAKMBECFLKP, int MMALBCCLOJL, int FDJIHHCBMDD, int PBIHGCPAMBK, int NHFNICOHHNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x85801F0", Offset = "0x857EFF0", VA = "0x1885801F0")]
	public void HAFOGFGNDHE(CommandBuffer HEIPGNLNKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x857FF90", Offset = "0x857ED90", VA = "0x18857FF90")]
	private RenderTexture GGPLIBKJCBI(RenderTexture LPNLKFHLFDA, int IEFKOLLJILO, int KAKHEJDLKAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8580170", Offset = "0x857EF70", VA = "0x188580170")]
	public void GONIOIOGAIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8580510", Offset = "0x857F310", VA = "0x188580510")]
	public void KDKPALIPPMG(int GOGGKIOMHAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8580F80", Offset = "0x857FD80", VA = "0x188580F80")]
	public HBAMMFAFKMM()
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
		public struct MFHCPGGGCIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float JGNJDLCOMAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float AEDALOENBNO;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class PGBHFFEPBFM : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string CILAKDMBNCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler KHOBGBCFPDH;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int BOCPLONLAGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material PFGANDAAGKJ;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8585C60", Offset = "0x8584A60", VA = "0x188585C60")]
			public PGBHFFEPBFM(RenderPassEvent OHHADODJICI, Material EFCBJICGDPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8585880", Offset = "0x8584680", VA = "0x188585880", Slot = "9")]
			public override void Execute(ScriptableRenderContext JAPGNGDBBIF, RenderingData KJJLFNEPCMH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static MFHCPGGGCIN CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private PGBHFFEPBFM m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x8584FE0", Offset = "0x8583DE0", VA = "0x188584FE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8584F90", Offset = "0x8583D90", VA = "0x188584F90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8584DE0", Offset = "0x8583BE0", VA = "0x188584DE0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8584D10", Offset = "0x8583B10", VA = "0x188584D10", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NHLDFAAJMGK, RenderingData KJJLFNEPCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x16BC320", Offset = "0x16BB120", VA = "0x1816BC320")]
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
		public struct MPLDLIEIMEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float PCIJMAEHOMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color OIACNEEAHMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh MBHOACNEIOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve EKJDPLINJCJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class JOGMGJBCKGK : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string CILAKDMBNCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler KHOBGBCFPDH;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int BCJNDMOCMBI;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int IBONLFEPLOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material PFGANDAAGKJ;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8581D40", Offset = "0x8580B40", VA = "0x188581D40")]
			public JOGMGJBCKGK(RenderPassEvent OHHADODJICI, Material EFCBJICGDPB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8581A80", Offset = "0x8580880", VA = "0x188581A80", Slot = "9")]
			public override void Execute(ScriptableRenderContext JAPGNGDBBIF, RenderingData KJJLFNEPCMH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static MPLDLIEIMEB CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private JOGMGJBCKGK m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x8585310", Offset = "0x8584110", VA = "0x188585310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8585160", Offset = "0x8583F60", VA = "0x188585160", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8585040", Offset = "0x8583E40", VA = "0x188585040", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NHLDFAAJMGK, RenderingData KJJLFNEPCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x16BC320", Offset = "0x16BB120", VA = "0x1816BC320")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string MBILIKEGKHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool FJKDPPIIHFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer HEIPGNLNKGF, ScriptableRenderContext JAPGNGDBBIF, RenderingData KJJLFNEPCMH);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9B0", Offset = "0xA097B0", VA = "0x180A0A9B0")]
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
		private class LOIJMFJOPAO : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool CGEKCAOPJML;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> AMDLMJGOMEM;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> JKMKHAOJDPD;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8582760", Offset = "0x8581560", VA = "0x188582760")]
			public LOIJMFJOPAO(RenderPassEvent OHHADODJICI, bool CGEKCAOPJML)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x85823E0", Offset = "0x85811E0", VA = "0x1885823E0")]
			public bool IEANGMJCLKD(CameraData OILBHOIJNPE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8582210", Offset = "0x8581010", VA = "0x188582210", Slot = "9")]
			public override void Execute(ScriptableRenderContext JAPGNGDBBIF, RenderingData KJJLFNEPCMH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8582130", Offset = "0x8580F30", VA = "0x188582130")]
			private void BEHEBCFFEMN(PerCameraRenderEffect KDCKKPBGMEP, ScriptableRenderContext JAPGNGDBBIF, RenderingData KJJLFNEPCMH)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private LOIJMFJOPAO m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private LOIJMFJOPAO m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8585DD0", Offset = "0x8584BD0", VA = "0x188585DD0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8585D40", Offset = "0x8584B40", VA = "0x188585D40", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NHLDFAAJMGK, RenderingData KJJLFNEPCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x16BC320", Offset = "0x16BB120", VA = "0x1816BC320")]
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
		[Cpp2IlInjected.Address(RVA = "0x8586020", Offset = "0x8584E20", VA = "0x188586020")]
		public static void EPCGKGBPBAD(ScriptableRenderPass DALBDHJHAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8585E80", Offset = "0x8584C80", VA = "0x188585E80", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer NHLDFAAJMGK, RenderingData KJJLFNEPCMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x16BC320", Offset = "0x16BB120", VA = "0x1816BC320")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class EGLKBBOFIFB
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 HNIEHCIKKJD;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 EAPOIAACGBH;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 BLNCOJMKEMM;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 JHBEBIEIIIM;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 FJOCPNKDKCG;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x857CBB0", Offset = "0x857B9B0", VA = "0x18857CBB0")]
	public static uint FHFBEHEJBOO(uint AJEEBBBAOKG, uint GJPKMHAOJHB, uint ECFKHEFHOMB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x857CBC0", Offset = "0x857B9C0", VA = "0x18857CBC0")]
	public static uint3 KKFLPOIIKBN(float3 NPJPCFKLMHD, float3 KKNECOPEANN, float3 PMDCNMMADJE)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x857CF60", Offset = "0x857BD60", VA = "0x18857CF60")]
	public static void MOMJHGMHKGE(float3 EBBPLIFJCAG, float3 AHLFPBOOOBC, float3 JHODPHBEIKH, float MEHMJKKFJEH, [Out] uint3 MLFINHINELI, [Out] uint3 HIANNMEKLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x857C6E0", Offset = "0x857B4E0", VA = "0x18857C6E0")]
	public static void AMABJMEBHPB(float3 EELOGIMGLGO, float3 JEGEBGAGJPP, float MIBGBKPCNLH, float DJADIEMNGJL, [Out] float3 MOHNDIPBIDM, [Out] float MEHMJKKFJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x857CDC0", Offset = "0x857BBC0", VA = "0x18857CDC0")]
	private static float3 LOIPIOCKPCB(float3 LNPEPAELMOF, float3 CCMCPJJEHBI, float3 JKNFEHGCKCL, float3 ECCICFEKKBN)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class JBGAHNALHKL
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly IEBEPMGFCGH JBBGOGONECB;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly IEBEPMGFCGH ADNAMLECFHI;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly IEBEPMGFCGH ACAKGPAMOPF;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly IEBEPMGFCGH GFKNHHCNENL;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly IEBEPMGFCGH DPCDIKKHLBP;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class HNLKPMMGGFH
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh EOKCAONMAEM;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8581800", Offset = "0x8580600", VA = "0x188581800")]
	public static Mesh OHJNKDLAHEC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8580FA0", Offset = "0x857FDA0", VA = "0x188580FA0")]
	public static Matrix4x4 MCGNKFIJCMI(Camera DOAGHOOOPIO, bool IOJJAEKECCJ = false, bool MADKKNIIPBO = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8581440", Offset = "0x8580240", VA = "0x188581440")]
	private static Mesh NJIIHKHPPNG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3660835736
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x85874D0", Offset = "0x85862D0", VA = "0x1885874D0")]
	public static void BGDPAPHEPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8587560", Offset = "0x8586360", VA = "0x188587560")]
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
