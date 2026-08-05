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
	public class LogRegistrationIndex : CCHAKOMCHCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8B3F9B0", Offset = "0x8B3E3B0", VA = "0x188B3F9B0", Slot = "4")]
		public override void MAJNBNPDEEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		public enum APDENCLINFI
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface KPGFBKJIEIC
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void IOLGKAAFKLA(ScriptableRenderContext HCLPHJDKMCA, List<Camera> CPMILDCOLLP);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface MEDFHDMKJEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void IOLGKAAFKLA(ScriptableRenderContext HCLPHJDKMCA, RenderingData IGMANGGOMIG);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class AHACMJKBFPI : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8B38100", Offset = "0x8B36B00", VA = "0x188B38100")]
			public AHACMJKBFPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8B380A0", Offset = "0x8B36AA0", VA = "0x188B380A0", Slot = "9")]
			public override void Execute(ScriptableRenderContext HCLPHJDKMCA, RenderingData IGMANGGOMIG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private AHACMJKBFPI _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<KPGFBKJIEIC> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<KPGFBKJIEIC> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<MEDFHDMKJEE> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<MEDFHDMKJEE> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B40DC0", Offset = "0x8B3F7C0", VA = "0x188B40DC0")]
		public static void GGOFLEGMKKM(APDENCLINFI CFNNKGABOAB, KPGFBKJIEIC DJLDACJEDFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8B41350", Offset = "0x8B3FD50", VA = "0x188B41350")]
		public static void IELHMLHBLFF(APDENCLINFI CFNNKGABOAB, KPGFBKJIEIC DJLDACJEDFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8B40D00", Offset = "0x8B3F700", VA = "0x188B40D00")]
		public static void GGOFLEGMKKM(APDENCLINFI CFNNKGABOAB, MEDFHDMKJEE EPPCPJFAFCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8B41410", Offset = "0x8B3FE10", VA = "0x188B41410")]
		public static void IELHMLHBLFF(APDENCLINFI CFNNKGABOAB, MEDFHDMKJEE EPPCPJFAFCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8B40A00", Offset = "0x8B3F400", VA = "0x188B40A00", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8B40950", Offset = "0x8B3F350", VA = "0x188B40950", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer BDBIAPPPJPF, RenderingData IGMANGGOMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8B40BF0", Offset = "0x8B3F5F0", VA = "0x188B40BF0", Slot = "9")]
		protected override void Dispose(bool OBPCNFJNFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8B414D0", Offset = "0x8B3FED0", VA = "0x188B414D0")]
		private static void JAANINIEONM(ScriptableRenderContext HCLPHJDKMCA, List<Camera> CPMILDCOLLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8B419D0", Offset = "0x8B403D0", VA = "0x188B419D0")]
		private static void MCPLHBNLCOD(ScriptableRenderContext HCLPHJDKMCA, List<Camera> CPMILDCOLLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8B40E80", Offset = "0x8B3F880", VA = "0x188B40E80")]
		private static void GJPCFFCMKOI(ScriptableRenderContext HCLPHJDKMCA, RenderingData IGMANGGOMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1909670", Offset = "0x1908070", VA = "0x181909670")]
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
		private class BJABIMOKCKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool IKPPOGDAPGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<DMBMGLIGJFP> INDOJHFKCIO;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8B39510", Offset = "0x8B37F10", VA = "0x188B39510")]
			public BJABIMOKCKK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class BHMIDMOJNEF : PreRenderManager.MEDFHDMKJEE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string EHPAHBJLAMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler PMBGMJCLBLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly BJABIMOKCKK FCOPIFGMCJH;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8B39450", Offset = "0x8B37E50", VA = "0x188B39450")]
			public BHMIDMOJNEF(BJABIMOKCKK GAONMMEAPEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8B39050", Offset = "0x8B37A50", VA = "0x188B39050", Slot = "4")]
			public void IOLGKAAFKLA(ScriptableRenderContext HCLPHJDKMCA, RenderingData IGMANGGOMIG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class LNIHINCGJHI : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string ILHOKFLCCJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly BJABIMOKCKK GAONMMEAPEM;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8B3F250", Offset = "0x8B3DC50", VA = "0x188B3F250")]
			public LNIHINCGJHI(RenderPassEvent KLIFLLIBPKI, BJABIMOKCKK GAONMMEAPEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8B3EF40", Offset = "0x8B3D940", VA = "0x188B3EF40", Slot = "9")]
			public override void Execute(ScriptableRenderContext HCLPHJDKMCA, RenderingData IGMANGGOMIG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<DMBMGLIGJFP> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private BHMIDMOJNEF fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private LNIHINCGJHI fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private BJABIMOKCKK sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8B3C120", Offset = "0x8B3AB20", VA = "0x188B3C120", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8B3C4B0", Offset = "0x8B3AEB0", VA = "0x188B3C4B0", Slot = "9")]
		protected override void Dispose(bool OBPCNFJNFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8B3C080", Offset = "0x8B3AA80", VA = "0x188B3C080", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer BDBIAPPPJPF, RenderingData IGMANGGOMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1909670", Offset = "0x1908070", VA = "0x181909670")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DMBMGLIGJFP
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CIOAHLCBAHF(CommandBuffer GFHMNONHMKG, Camera MJKCGJBIPGM, [NotNull] UniversalAdditionalCameraData MNGIBPBLMMO, bool LIFJEOBGMHN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PEPODCEIEPB(Camera MJKCGJBIPGM, CommandBuffer CMGFLLGDENJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class EEEKBNEDHIH
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool DNDMFNKHDFJ;
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
		private KKPIFPIGMHB _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private FADLANHJCDO _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8B3F940", Offset = "0x8B3E340", VA = "0x188B3F940", Slot = "9")]
		protected override void Dispose(bool FILMLHBHGMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8B3F680", Offset = "0x8B3E080", VA = "0x188B3F680")]
		private void BOPHLIEAEBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8B3F330", Offset = "0x8B3DD30", VA = "0x188B3F330", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer BDBIAPPPJPF, RenderingData IGMANGGOMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1909670", Offset = "0x1908070", VA = "0x181909670")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PAOBACPPDBN
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8B404F0", Offset = "0x8B3EEF0", VA = "0x188B404F0")]
	public static int EKONGJLJKCG(bool KPPHFBDDOBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1DAF580", Offset = "0x1DADF80", VA = "0x181DAF580")]
	public static int EPJKBNHLIPB(bool KPPHFBDDOBF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct EJIHEIIHCGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType GDDMLMHEPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float BEFFBGJPMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float OPPACCCPKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float FELOOBACEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 CJMIINKJADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 OBOMOAHCEAB;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct LPMNKOPOKKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort MMGIHKFJHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float NJGBPHHCANF;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct BFEJALAEOJF : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<EJIHEIIHCGB> KBGLPLJBGMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 MDIHFLDONGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 JGMGHENJHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, LPMNKOPOKKI>.ParallelWriter POOKOPCFIHC;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8B385D0", Offset = "0x8B36FD0", VA = "0x188B385D0", Slot = "4")]
	public void Execute(int MMGIHKFJHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8B38BF0", Offset = "0x8B375F0", VA = "0x188B38BF0")]
	private void KBNICNFCAEG(uint3 FBEFCAODOBI, uint3 GBAEEIBPMPC, ushort MMGIHKFJHIO, float3 CNDIHEHLEAG, float JJCKNJNEEFA, float ICKHDIOOJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8B38120", Offset = "0x8B36B20", VA = "0x188B38120")]
	private void BPDCKKKLGEL(uint3 FBEFCAODOBI, uint3 GBAEEIBPMPC, ushort MMGIHKFJHIO, float3 CNDIHEHLEAG, float3 JGPMACJLLGI, float3 KLHLBEEGJIE, float JJCKNJNEEFA, float FNMKDLELCOD, float ICKHDIOOJKM, float CJMKNCMMPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8B38F60", Offset = "0x8B37960", VA = "0x188B38F60")]
	private float3 LADFPGNOIAD(uint3 FBEFCAODOBI, float3 CNDIHEHLEAG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8B38B10", Offset = "0x8B37510", VA = "0x188B38B10")]
	private float FHOMFDNKPND(float BEFFBGJPMBN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8B38B30", Offset = "0x8B37530", VA = "0x188B38B30")]
	private float GBBPEIODELJ(float3 DDCOMMOCLEL, float3 KLHLBEEGJIE, float FNMKDLELCOD, float ICKHDIOOJKM)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct MFFOOGDNDKM : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, LPMNKOPOKKI> POOKOPCFIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint DCBGBNLGNBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int MNLLGHAGCFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int IMBIKEFCKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> PDONGBBADPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> DJOPAKAOCME;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8B3FA40", Offset = "0x8B3E440", VA = "0x188B3FA40", Slot = "4")]
	public void Execute(int EPMNHAKPPJJ, int FAJGDGFFNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8B3FBE0", Offset = "0x8B3E5E0", VA = "0x188B3FBE0")]
	private void JPAKCKINJPE(int PGPOFMBLCNG, ushort NCPCBNEIKMI, int OGJBFIBHBEC, LPMNKOPOKKI BPGCGBGNAGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct DNPMKOGBKFF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, LPMNKOPOKKI> POOKOPCFIHC;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8B395A0", Offset = "0x8B37FA0", VA = "0x188B395A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KKPIFPIGMHB : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool FCMIKOGEKIO;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float GLIPHINIJEK = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int KJMKHGLPPGG = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int AKLEDMDOHKA = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private BFEJALAEOJF OHAGPDBBDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private MFFOOGDNDKM CNOMJGFCFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private DNPMKOGBKFF CIHBPOJHEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, LPMNKOPOKKI> EDOEAHGMFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private ADFHBOJKBBM PLLINHAECGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool HEPONJAALIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int AJBPDDNOPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<EJIHEIIHCGB> APPBAMKPJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle LOCPPELGGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle LGBMPAOFCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool KEHDCAMIJBO;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8B3EE90", Offset = "0x8B3D890", VA = "0x188B3EE90")]
	public KKPIFPIGMHB(RenderPassEvent KLIFLLIBPKI, ComputeShader BHFMONBGHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8B3E0B0", Offset = "0x8B3CAB0", VA = "0x188B3E0B0")]
	private void EAJBCAGLIKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8B3E250", Offset = "0x8B3CC50", VA = "0x188B3E250")]
	public void MBEBEMIJNNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3D31AE0", Offset = "0x3D304E0", VA = "0x183D31AE0")]
	public static void OEJDIBJCHJK<T>(NativeArray<T> JCEJMKLBKKB, int CGAAPEOHPIP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8B3E330", Offset = "0x8B3CD30", VA = "0x188B3E330")]
	public void MBIAPJKABIF(CameraData MNGIBPBLMMO, LightData LKIPOIANPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8B3E950", Offset = "0x8B3D350", VA = "0x188B3E950")]
	private void PHANFOIFFGB(LightData LKIPOIANPDP, NativeArray<EJIHEIIHCGB> ICLHMNCHBFN, int EBBONGFLMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8B3E6E0", Offset = "0x8B3D0E0", VA = "0x188B3E6E0")]
	private void OGHGJDCPNFB(CameraData MNGIBPBLMMO, LightData LKIPOIANPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8B3EC90", Offset = "0x8B3D690", VA = "0x188B3EC90")]
	private void PMAFPGOGNJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8B3DFB0", Offset = "0x8B3C9B0", VA = "0x188B3DFB0")]
	private void DGFCJMGDNIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8B3EE20", Offset = "0x8B3D820", VA = "0x188B3EE20")]
	private void PONJLICALPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8B3E220", Offset = "0x8B3CC20", VA = "0x188B3E220")]
	private void JDFFCPIFBAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8B3E120", Offset = "0x8B3CB20", VA = "0x188B3E120", Slot = "9")]
	public override void Execute(ScriptableRenderContext HCLPHJDKMCA, RenderingData IGMANGGOMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8B3E920", Offset = "0x8B3D320", VA = "0x188B3E920", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer CMGFLLGDENJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FADLANHJCDO : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort OILPLJGBLCK = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float GLIPHINIJEK = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly ADFHBOJKBBM PLLINHAECGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int JJICGEOOBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private EJIHEIIHCGB[] APPBAMKPJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 PFANJBLOPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 GNEDAGHKPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint KEKEHJPLOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int MABKILAHAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int DOBIMEJJPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> PDONGBBADPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> DJOPAKAOCME;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8B3B320", Offset = "0x8B39D20", VA = "0x188B3B320")]
	public FADLANHJCDO(RenderPassEvent KLIFLLIBPKI, ComputeShader BHFMONBGHJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8B3AD10", Offset = "0x8B39710", VA = "0x188B3AD10")]
	public void MBIAPJKABIF(CameraData MNGIBPBLMMO, LightData LKIPOIANPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8B39B30", Offset = "0x8B38530", VA = "0x188B39B30")]
	private void CEGPOOLKFCE(CameraData MNGIBPBLMMO, LightData LKIPOIANPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8B3ACF0", Offset = "0x8B396F0", VA = "0x188B3ACF0")]
	public void MBEBEMIJNNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8B3AFD0", Offset = "0x8B399D0", VA = "0x188B3AFD0")]
	private void PHANFOIFFGB(LightData LKIPOIANPDP, EJIHEIIHCGB[] ICLHMNCHBFN, int EBBONGFLMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8B3AEF0", Offset = "0x8B398F0", VA = "0x188B3AEF0")]
	private void NFMPCNAODLK(int EPMNHAKPPJJ, int FAJGDGFFNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8B39D30", Offset = "0x8B38730", VA = "0x188B39D30")]
	private void DOLGHFIBPCI(int EPMNHAKPPJJ, int CDCPIGCEABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8B3A060", Offset = "0x8B38A60", VA = "0x188B3A060")]
	private ushort JHKIOMPNPBD(int EPMNHAKPPJJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8B3AE80", Offset = "0x8B39880", VA = "0x188B3AE80")]
	private void NEBBJIPLEGF(int EPMNHAKPPJJ, int FAJGDGFFNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8B39FF0", Offset = "0x8B389F0", VA = "0x188B39FF0")]
	private void JBEEDIBGAFB(int CGAAPEOHPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8B39F30", Offset = "0x8B38930", VA = "0x188B39F30")]
	private void HLGLOICPGLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8B39D60", Offset = "0x8B38760", VA = "0x188B39D60", Slot = "9")]
	public override void Execute(ScriptableRenderContext HCLPHJDKMCA, RenderingData IGMANGGOMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8B3AFA0", Offset = "0x8B399A0", VA = "0x188B3AFA0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer CMGFLLGDENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8B3A230", Offset = "0x8B38C30", VA = "0x188B3A230")]
	private void JPJJKCFBJEM(int MMGIHKFJHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8B3A7E0", Offset = "0x8B391E0", VA = "0x188B3A7E0")]
	private void KBNICNFCAEG(uint3 FBEFCAODOBI, uint3 GBAEEIBPMPC, ushort MMGIHKFJHIO, float3 CNDIHEHLEAG, float JJCKNJNEEFA, float ICKHDIOOJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8B395E0", Offset = "0x8B37FE0", VA = "0x188B395E0")]
	private void BPDCKKKLGEL(uint3 FBEFCAODOBI, uint3 GBAEEIBPMPC, ushort MMGIHKFJHIO, float3 CNDIHEHLEAG, float3 JGPMACJLLGI, float3 KLHLBEEGJIE, float JJCKNJNEEFA, float FNMKDLELCOD, float ICKHDIOOJKM, float CJMKNCMMPJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8B39E40", Offset = "0x8B38840", VA = "0x188B39E40")]
	private void FGFCKEMAOBN(ushort MMGIHKFJHIO, uint DCDEENMKHOF, float OPJKBKLNFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8B3ABF0", Offset = "0x8B395F0", VA = "0x188B3ABF0")]
	private float3 LADFPGNOIAD(uint3 FBEFCAODOBI, float3 CNDIHEHLEAG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8B38B10", Offset = "0x8B37510", VA = "0x188B38B10")]
	private float FHOMFDNKPND(float BEFFBGJPMBN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8B38B30", Offset = "0x8B37530", VA = "0x188B38B30")]
	private float GBBPEIODELJ(float3 DDCOMMOCLEL, float3 KLHLBEEGJIE, float FNMKDLELCOD, float ICKHDIOOJKM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8B3A0A0", Offset = "0x8B38AA0", VA = "0x188B3A0A0")]
	private void JPAKCKINJPE(int PGPOFMBLCNG, ushort NCPCBNEIKMI, int OGJBFIBHBEC, LPMNKOPOKKI BPGCGBGNAGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ADFHBOJKBBM
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class HLHDOBGMBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int LGDHEEIHBPF;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int DPCLHCGLCCH;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int KGIINMDNHLK;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int IMGJJGBNBPN;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int DAKJBBDEDBN;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int NIFFPJDNKOO;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int AGFLNDDDOFF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int HCNOABCJDDN = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int EFBDPFBNKOP = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int BJLDIACHOHE = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int NBEIPIJNFFO = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int LHCNEPMKOBF = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int KDFPJKIDHJE = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int FJCELKILFCD = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool IIFCNDEDJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer EBBNPFDKJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture IPDKEJEJJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int EMLPELFPMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int LPINJNBKCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int EDMADCMMGMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int EMDKCJPLAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int FGHHDFJNAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader JLGHHHCCDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int FFIJGMAMHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int FHKJNOAFFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 JNHMCCIKFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 POPKLDIOIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> IDEJEANEIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> IOGFFOBGBFF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> HPPHFELLDEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x140DF40", Offset = "0x140C940", VA = "0x18140DF40")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> KDCCBOPOGGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x12EE850", Offset = "0x12ED250", VA = "0x1812EE850")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int NKCDNIJKEBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAD60D0", Offset = "0xAD4AD0", VA = "0x180AD60D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int OIMKLCJHPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5B0", Offset = "0xA8CFB0", VA = "0x180A8E5B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader PJKEMKONNEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8B37B70", Offset = "0x8B36570", VA = "0x188B37B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8B37C80", Offset = "0x8B36680", VA = "0x188B37C80")]
	public void MEOELJAGFLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8B37D70", Offset = "0x8B36770", VA = "0x188B37D70")]
	public void MJPHLGMCCPC(CameraData MNGIBPBLMMO, LightData LKIPOIANPDP, int PCPMPPGHHNA, bool KPPHFBDDOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x31C0700", Offset = "0x31BF100", VA = "0x1831C0700")]
	private void OEJDIBJCHJK<T>(NativeArray<T> JCEJMKLBKKB, int CGAAPEOHPIP) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8B36EB0", Offset = "0x8B358B0", VA = "0x188B36EB0")]
	public void DFAGIIPMALH(CommandBuffer CMGFLLGDENJ, ScriptableRenderContext HCLPHJDKMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8B37520", Offset = "0x8B35F20", VA = "0x188B37520")]
	private static void FIBCHCHKLCB(int LBGFCIIOBBN, CommandBuffer CMGFLLGDENJ, RenderBuffer MGMGLCIGGDL, ComputeBuffer OKNLJNKINJD, ComputeShader DBGOAJLKGOG, int AFHGEFIBOMM, int IJOCBDIDHMC, int ENOKIGGGOPJ, int HLNBIDFGHDP, int JCOHHGDGAFL, int IMALJLGGGIA, int FEFKDIDPOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8B37200", Offset = "0x8B35C00", VA = "0x188B37200")]
	public void FGPGEBMAKJM(CommandBuffer CMGFLLGDENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8B37990", Offset = "0x8B36390", VA = "0x188B37990")]
	private RenderTexture HOIMNBIBOAF(RenderTexture AIABJBINMCJ, int AFHGEFIBOMM, int IJOCBDIDHMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8B37C00", Offset = "0x8B36600", VA = "0x188B37C00")]
	public void LEOHMEENNAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8B37700", Offset = "0x8B36100", VA = "0x188B37700")]
	public void GIDDOFFHNBP(int DIINLOPPLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8B38080", Offset = "0x8B36A80", VA = "0x188B38080")]
	public ADFHBOJKBBM()
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
		public struct HEBOOCAKKDK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float DONIDJNOALG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float FMJJFJCNMEP;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class IICLDFADFDC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string FFLMGMKIBAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler IKAGBDKFGND;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int OMHFHAFMJML;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material PHIOJGFGABH;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8B3D2D0", Offset = "0x8B3BCD0", VA = "0x188B3D2D0")]
			public IICLDFADFDC(RenderPassEvent KLIFLLIBPKI, Material POCHLMCAOAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8B3CEF0", Offset = "0x8B3B8F0", VA = "0x188B3CEF0", Slot = "9")]
			public override void Execute(ScriptableRenderContext HCLPHJDKMCA, RenderingData IGMANGGOMIG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static HEBOOCAKKDK CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private IICLDFADFDC m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x8B40020", Offset = "0x8B3EA20", VA = "0x188B40020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8B3FFD0", Offset = "0x8B3E9D0", VA = "0x188B3FFD0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8B3FE20", Offset = "0x8B3E820", VA = "0x188B3FE20", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8B3FD50", Offset = "0x8B3E750", VA = "0x188B3FD50", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer BDBIAPPPJPF, RenderingData IGMANGGOMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1909670", Offset = "0x1908070", VA = "0x181909670")]
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
		public struct NALFGHDFFBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float NIMMMOEAKDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color PKDJOGMDLJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh MBMBBJPKCCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve MLCNBGFDDKO;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class FOHGJMPBDDJ : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string FFLMGMKIBAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler IKAGBDKFGND;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int EEKINBPGEAP;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int EGKDCEKNCIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material PHIOJGFGABH;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8B3B690", Offset = "0x8B3A090", VA = "0x188B3B690")]
			public FOHGJMPBDDJ(RenderPassEvent KLIFLLIBPKI, Material POCHLMCAOAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8B3B3D0", Offset = "0x8B39DD0", VA = "0x188B3B3D0", Slot = "9")]
			public override void Execute(ScriptableRenderContext HCLPHJDKMCA, RenderingData IGMANGGOMIG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static NALFGHDFFBM CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private FOHGJMPBDDJ m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x8B40350", Offset = "0x8B3ED50", VA = "0x188B40350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8B401A0", Offset = "0x8B3EBA0", VA = "0x188B401A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8B40080", Offset = "0x8B3EA80", VA = "0x188B40080", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer BDBIAPPPJPF, RenderingData IGMANGGOMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1909670", Offset = "0x1908070", VA = "0x181909670")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string IJBBCEPPNAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool FMJPFJIIMON
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAD0480", Offset = "0xACEE80", VA = "0x180AD0480", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer CMGFLLGDENJ, ScriptableRenderContext HCLPHJDKMCA, RenderingData IGMANGGOMIG);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA85A30", Offset = "0xA84430", VA = "0x180A85A30")]
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
		private class GFOOMCEHCHB : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool ODAKAHNOMGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> GIHBLDBHMBI;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> IAEEIJGLODM;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8B3CCE0", Offset = "0x8B3B6E0", VA = "0x188B3CCE0")]
			public GFOOMCEHCHB(RenderPassEvent KLIFLLIBPKI, bool ODAKAHNOMGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8B3C880", Offset = "0x8B3B280", VA = "0x188B3C880")]
			public bool LMMKDDGBABG(CameraData MNGIBPBLMMO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8B3C6B0", Offset = "0x8B3B0B0", VA = "0x188B3C6B0", Slot = "9")]
			public override void Execute(ScriptableRenderContext HCLPHJDKMCA, RenderingData IGMANGGOMIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8B3CB70", Offset = "0x8B3B570", VA = "0x188B3CB70")]
			private void OPPABGGLELB(PerCameraRenderEffect AKIAIAEAFKL, ScriptableRenderContext HCLPHJDKMCA, RenderingData IGMANGGOMIG)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private GFOOMCEHCHB m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private GFOOMCEHCHB m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8B40590", Offset = "0x8B3EF90", VA = "0x188B40590", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8B40500", Offset = "0x8B3EF00", VA = "0x188B40500", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer BDBIAPPPJPF, RenderingData IGMANGGOMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1909670", Offset = "0x1908070", VA = "0x181909670")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B407E0", Offset = "0x8B3F1E0", VA = "0x188B407E0")]
		public static void FEDICJMHKML(ScriptableRenderPass HPICCJCCPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8B40640", Offset = "0x8B3F040", VA = "0x188B40640", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer BDBIAPPPJPF, RenderingData IGMANGGOMIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1909670", Offset = "0x1908070", VA = "0x181909670")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class JGMPAJKIPAH
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 BPLIKAJOHEP;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 BLNAHLOMJPI;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 NOJJOBLDCGH;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 GIOKODMOOIO;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 JEGFCNDGJHN;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8B3DC60", Offset = "0x8B3C660", VA = "0x188B3DC60")]
	public static uint JLMLJIEPPLK(uint IECENJOJFJH, uint OFOCBNJJIJE, uint KBPKNDAKOHF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8B3DC70", Offset = "0x8B3C670", VA = "0x188B3DC70")]
	public static uint3 KFPGGJJPDLP(float3 DDIHIBMHCDH, float3 MDIHFLDONGJ, float3 JGMGHENJHHP)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8B3D880", Offset = "0x8B3C280", VA = "0x188B3D880")]
	public static void EGKCFGENGAB(float3 FJILBIAMNJD, float3 CEACLJFDMNG, float3 NCEAHOGKLDB, float DLJDKOFPIMN, [Out] uint3 ILKKMKNPFFK, [Out] uint3 HGKIAKPGBML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8B3D3B0", Offset = "0x8B3BDB0", VA = "0x188B3D3B0")]
	public static void DGPDAIDNOBJ(float3 EPEOJDDMDLM, float3 BGNBAGJDLGN, float OPPACCCPKCM, float CFMNLLMIPOD, [Out] float3 EKBNCIHBCML, [Out] float DLJDKOFPIMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8B3DAC0", Offset = "0x8B3C4C0", VA = "0x188B3DAC0")]
	private static float3 ILJDPECJHLB(float3 MICMJDDALFL, float3 KHBMFBBCENA, float3 KCBBFLCCCKH, float3 JGHEDDIHFPN)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class OECFIPLCJJA
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly MEBJEIOEDLD KFCKOMADEHF;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly MEBJEIOEDLD LHFBDKNGAKM;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly MEBJEIOEDLD OFNAMEABCII;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly MEBJEIOEDLD HMGGLLJGADP;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly MEBJEIOEDLD JMGLKEKOEAL;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class FPCHKBADAOO
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh ODBMHDFPILA;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8B3BFD0", Offset = "0x8B3A9D0", VA = "0x188B3BFD0")]
	public static Mesh LPOOJPJLANE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8B3BB30", Offset = "0x8B3A530", VA = "0x188B3BB30")]
	public static Matrix4x4 HHNFDMBOJIN(Camera MJKCGJBIPGM, bool DKJAOBOHEHD = false, bool GJBBLJLAFBE = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8B3B770", Offset = "0x8B3A170", VA = "0x188B3B770")]
	private static Mesh DLAPOFOMCEI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3835770364
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8B41C80", Offset = "0x8B40680", VA = "0x188B41C80")]
	public static void FJNLIIMMIOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8B41C70", Offset = "0x8B40670", VA = "0x188B41C70")]
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
