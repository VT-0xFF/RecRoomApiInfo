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
	public class LogRegistrationIndex : EJFLMJDOOOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8CAE850", Offset = "0x8CACE50", VA = "0x188CAE850", Slot = "4")]
		public override void CBPAAEAGBMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		public enum JKLMONJBBPE
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface EFDDPFEEIEO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void MGDMFNNFPNM(ScriptableRenderContext HHPFOCCGJIF, List<Camera> JLPCDCKMOPE);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface KHBEBGNDGEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void MGDMFNNFPNM(ScriptableRenderContext HHPFOCCGJIF, RenderingData FMGGMKFBAKI);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class NAMNLOHIBOO : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8CB0610", Offset = "0x8CAEC10", VA = "0x188CB0610")]
			public NAMNLOHIBOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8CB05B0", Offset = "0x8CAEBB0", VA = "0x188CB05B0", Slot = "9")]
			public override void Execute(ScriptableRenderContext HHPFOCCGJIF, RenderingData FMGGMKFBAKI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private NAMNLOHIBOO _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<EFDDPFEEIEO> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<EFDDPFEEIEO> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<KHBEBGNDGEP> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<KHBEBGNDGEP> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8CB3B70", Offset = "0x8CB2170", VA = "0x188CB3B70")]
		public static void OGGAJAEPJIC(JKLMONJBBPE IEDLPFLGNOI, EFDDPFEEIEO JMLGNKIBFHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8CB31B0", Offset = "0x8CB17B0", VA = "0x188CB31B0")]
		public static void BBHAPDCBNLK(JKLMONJBBPE IEDLPFLGNOI, EFDDPFEEIEO JMLGNKIBFHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8CB3AB0", Offset = "0x8CB20B0", VA = "0x188CB3AB0")]
		public static void OGGAJAEPJIC(JKLMONJBBPE IEDLPFLGNOI, KHBEBGNDGEP DAEEHBDEAJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8CB30F0", Offset = "0x8CB16F0", VA = "0x188CB30F0")]
		public static void BBHAPDCBNLK(JKLMONJBBPE IEDLPFLGNOI, KHBEBGNDGEP DAEEHBDEAJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8CB3270", Offset = "0x8CB1870", VA = "0x188CB3270", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8CB3040", Offset = "0x8CB1640", VA = "0x188CB3040", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PHHDHBAFNEH, RenderingData FMGGMKFBAKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8CB3930", Offset = "0x8CB1F30", VA = "0x188CB3930", Slot = "9")]
		protected override void Dispose(bool PBLLNBJKALP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8CB3C30", Offset = "0x8CB2230", VA = "0x188CB3C30")]
		private static void OHDHCAEDIHP(ScriptableRenderContext HHPFOCCGJIF, List<Camera> JLPCDCKMOPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8CB3A40", Offset = "0x8CB2040", VA = "0x188CB3A40")]
		private static void IMDLHAMNBFN(ScriptableRenderContext HHPFOCCGJIF, List<Camera> JLPCDCKMOPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8CB3460", Offset = "0x8CB1A60", VA = "0x188CB3460")]
		private static void DIMOEHDJHKI(ScriptableRenderContext HHPFOCCGJIF, RenderingData FMGGMKFBAKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x195CEB0", Offset = "0x195B4B0", VA = "0x18195CEB0")]
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
		private class HPPCAGDCFFK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool EMEHLNEHJFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<NBPAACCOGJG> KFLJJFAFKPP;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8CABEE0", Offset = "0x8CAA4E0", VA = "0x188CABEE0")]
			public HPPCAGDCFFK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class GIJDJMKNMAN : PreRenderManager.KHBEBGNDGEP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string BHOLGOLEPIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler JOAMHHEFDMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly HPPCAGDCFFK PLMIJKGHCKN;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8CAA3C0", Offset = "0x8CA89C0", VA = "0x188CAA3C0")]
			public GIJDJMKNMAN(HPPCAGDCFFK IHBEIKCOLKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8CA9FB0", Offset = "0x8CA85B0", VA = "0x188CA9FB0", Slot = "4")]
			public void MGDMFNNFPNM(ScriptableRenderContext HHPFOCCGJIF, RenderingData FMGGMKFBAKI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class HLMIHFGBOIB : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string FNCHHJGLEKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly HPPCAGDCFFK IHBEIKCOLKN;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8CABE00", Offset = "0x8CAA400", VA = "0x188CABE00")]
			public HLMIHFGBOIB(RenderPassEvent OKPCNKDLIPI, HPPCAGDCFFK IHBEIKCOLKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8CABAF0", Offset = "0x8CAA0F0", VA = "0x188CABAF0", Slot = "9")]
			public override void Execute(ScriptableRenderContext HHPFOCCGJIF, RenderingData FMGGMKFBAKI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<NBPAACCOGJG> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private GIJDJMKNMAN fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private HLMIHFGBOIB fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private HPPCAGDCFFK sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8CA9A20", Offset = "0x8CA8020", VA = "0x188CA9A20", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8CA9DB0", Offset = "0x8CA83B0", VA = "0x188CA9DB0", Slot = "9")]
		protected override void Dispose(bool PBLLNBJKALP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8CA9980", Offset = "0x8CA7F80", VA = "0x188CA9980", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PHHDHBAFNEH, RenderingData FMGGMKFBAKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x195CEB0", Offset = "0x195B4B0", VA = "0x18195CEB0")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NBPAACCOGJG
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OMICCOBOPFH(CommandBuffer CJEJPHCKMKJ, Camera GBGEPBILLFN, [NotNull] UniversalAdditionalCameraData EBJGBLCMHBJ, bool GFMLINJDBIK);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LPOLCIMLIGI(Camera GBGEPBILLFN, CommandBuffer PCKGIGGFIHN);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HLOBMFHJGAA
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool DDFAPHBDNNJ;
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
		private HHLGOPJJJMA _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private OLJMEFNNGGP _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8CAE7E0", Offset = "0x8CACDE0", VA = "0x188CAE7E0", Slot = "9")]
		protected override void Dispose(bool EBGHKBNLNDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8CAE520", Offset = "0x8CACB20", VA = "0x188CAE520")]
		private void DNOLLLFGLIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8CAE1D0", Offset = "0x8CAC7D0", VA = "0x188CAE1D0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PHHDHBAFNEH, RenderingData FMGGMKFBAKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x195CEB0", Offset = "0x195B4B0", VA = "0x18195CEB0")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class EAHKIGOHBIK
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8CA9590", Offset = "0x8CA7B90", VA = "0x188CA9590")]
	public static int BGILPNALNLL(bool GLFJILOGCNA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1E07C30", Offset = "0x1E06230", VA = "0x181E07C30")]
	public static int EHHMMJDIBIJ(bool GLFJILOGCNA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct KMMKFNNCIEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType KBHBDGEKPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float MHAKDHMKPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float KNPJHKKMLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float GBPPPHNABPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 EIGACGACDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 NHPIHOMFDFL;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct DHLIPGECOBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort LFGJJOFJCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float GFLOOIOKPAM;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct LOMINBBNDAF : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<KMMKFNNCIEO> GHAJPJPOMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 NHCJDFEIJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 EEGLKEDPOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, DHLIPGECOBJ>.ParallelWriter LDJPDIOLFBK;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8CAD610", Offset = "0x8CABC10", VA = "0x188CAD610", Slot = "4")]
	public void Execute(int LFGJJOFJCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8CAD2A0", Offset = "0x8CAB8A0", VA = "0x188CAD2A0")]
	private void DKANMODAKCH(uint3 PGJDFKNAHDJ, uint3 JJNLMCCBMAO, ushort LFGJJOFJCDN, float3 MNAPPNKJIIL, float PNAIDDAALAO, float EIEFMLAAGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8CADD20", Offset = "0x8CAC320", VA = "0x188CADD20")]
	private void NDNFLBMGHNL(uint3 PGJDFKNAHDJ, uint3 JJNLMCCBMAO, ushort LFGJJOFJCDN, float3 MNAPPNKJIIL, float3 PABDOPMBOCJ, float3 MNEEDGMBJKC, float PNAIDDAALAO, float FLMGIFOOCKN, float EIEFMLAAGHC, float LMIFMOLCGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8CADB50", Offset = "0x8CAC150", VA = "0x188CADB50")]
	private float3 GIIDEGKHNKK(uint3 PGJDFKNAHDJ, float3 MNAPPNKJIIL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8CADD00", Offset = "0x8CAC300", VA = "0x188CADD00")]
	private float LNDPOHPHJJL(float MHAKDHMKPMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8CADC40", Offset = "0x8CAC240", VA = "0x188CADC40")]
	private float JKIPJBMPAFE(float3 DJFCJMBEGGI, float3 MNEEDGMBJKC, float FLMGIFOOCKN, float EIEFMLAAGHC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct NFPHBCOFDEB : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, DHLIPGECOBJ> LDJPDIOLFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint JFOMBJDACIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int EBKIKKEDHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int CFFLOLEAALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> AMMDNFMACMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> MNINLHFAONF;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8CB0630", Offset = "0x8CAEC30", VA = "0x188CB0630", Slot = "4")]
	public void Execute(int IBDFLJLLNCP, int FCHMEAKDDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8CB07D0", Offset = "0x8CAEDD0", VA = "0x188CB07D0")]
	private void FEGAOINPNBB(int HNBLGJDEAIK, ushort LMANJBNBDKP, int DOGEHJHKFGD, DHLIPGECOBJ IHJBBCGOGCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct FNGBJPPJGCI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, DHLIPGECOBJ> LDJPDIOLFBK;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8CA9940", Offset = "0x8CA7F40", VA = "0x188CA9940", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class HHLGOPJJJMA : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool MGKDIBGGGLP;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float FMEGEADIMIK = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int AMHHMHMMLLI = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int IECPCOIKENI = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private LOMINBBNDAF OLOHHBHKIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private NFPHBCOFDEB HKFIIEAMGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private FNGBJPPJGCI DACPFPEAKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, DHLIPGECOBJ> LPLOFFKKBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private KPGLLLPKBPN GONONDEMNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool KMONLOMGHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int PKCEALLKCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<KMMKFNNCIEO> CGCGFNLJHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle BHNHPIBMOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle ODDJIFHNGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool EOPDNFNAKGA;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8CAB360", Offset = "0x8CA9960", VA = "0x188CAB360")]
	public HHLGOPJJJMA(RenderPassEvent OKPCNKDLIPI, ComputeShader MDGMCCNLCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8CAA9A0", Offset = "0x8CA8FA0", VA = "0x188CAA9A0")]
	private void CFFOIENNDAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8CAA480", Offset = "0x8CA8A80", VA = "0x188CAA480")]
	public void AMNKHGILMNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3DDA860", Offset = "0x3DD8E60", VA = "0x183DDA860")]
	public static void AIMBINOPHGL<T>(NativeArray<T> OHHBFAGELLA, int MLMBLBFOLPC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8CAAF30", Offset = "0x8CA9530", VA = "0x188CAAF30")]
	public void NOEEBFGBBDN(CameraData EBJGBLCMHBJ, LightData NACFHBJBMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8CAA560", Offset = "0x8CA8B60", VA = "0x188CAA560")]
	private void BGOHLIHCLNI(LightData NACFHBJBMHB, NativeArray<KMMKFNNCIEO> NCIPBCAINFP, int BCBHAJJFIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8CAACF0", Offset = "0x8CA92F0", VA = "0x188CAACF0")]
	private void MKMMBEPOLDH(CameraData EBJGBLCMHBJ, LightData NACFHBJBMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8CAAB40", Offset = "0x8CA9140", VA = "0x188CAAB40")]
	private void GLPADEAIIIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8CAA8A0", Offset = "0x8CA8EA0", VA = "0x188CAA8A0")]
	private void BLPCIECMNCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8CAACD0", Offset = "0x8CA92D0", VA = "0x188CAACD0")]
	private void IKFNEGCBIML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8CAAB10", Offset = "0x8CA9110", VA = "0x188CAAB10")]
	private void FMIBFMFJMFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8CAAA10", Offset = "0x8CA9010", VA = "0x188CAAA10", Slot = "9")]
	public override void Execute(ScriptableRenderContext HHPFOCCGJIF, RenderingData FMGGMKFBAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8CAB2E0", Offset = "0x8CA98E0", VA = "0x188CAB2E0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer PCKGIGGFIHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OLJMEFNNGGP : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort KDFLHDEJAMH = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float FMEGEADIMIK = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly KPGLLLPKBPN GONONDEMNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int FIJPIALEDEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private KMMKFNNCIEO[] CGCGFNLJHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 IGJCOCEODEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 IGJILEFLEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint DNPFIPMDDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int LPKMDDNCJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int LJFCEDNLPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> AMMDNFMACMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> MNINLHFAONF;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2B40", Offset = "0x8CB1140", VA = "0x188CB2B40")]
	public OLJMEFNNGGP(RenderPassEvent OKPCNKDLIPI, ComputeShader MDGMCCNLCJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2300", Offset = "0x8CB0900", VA = "0x188CB2300")]
	public void NOEEBFGBBDN(CameraData EBJGBLCMHBJ, LightData NACFHBJBMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8CB1B40", Offset = "0x8CB0140", VA = "0x188CB1B40")]
	private void KPCPPDKILNE(CameraData EBJGBLCMHBJ, LightData NACFHBJBMHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x8CB0F70", Offset = "0x8CAF570", VA = "0x188CB0F70")]
	public void AMNKHGILMNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8CB0F90", Offset = "0x8CAF590", VA = "0x188CB0F90")]
	private void BGOHLIHCLNI(LightData NACFHBJBMHB, KMMKFNNCIEO[] NCIPBCAINFP, int BCBHAJJFIPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8CB0EC0", Offset = "0x8CAF4C0", VA = "0x188CB0EC0")]
	private void AGAMHGJHDMP(int IBDFLJLLNCP, int FCHMEAKDDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8CB1A60", Offset = "0x8CB0060", VA = "0x188CB1A60")]
	private void IOCIGCMFBNG(int IBDFLJLLNCP, int FEEKNNBMJMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x8CB1B00", Offset = "0x8CB0100", VA = "0x188CB1B00")]
	private ushort KGLBHLELMKA(int IBDFLJLLNCP)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8CB1D40", Offset = "0x8CB0340", VA = "0x188CB1D40")]
	private void LECDMGKHKIE(int IBDFLJLLNCP, int FCHMEAKDDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x8CB1A90", Offset = "0x8CB0090", VA = "0x188CB1A90")]
	private void JHILDLNMDGG(int MLMBLBFOLPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8CB0E00", Offset = "0x8CAF400", VA = "0x188CB0E00")]
	private void ABFNAIMDFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x8CB16F0", Offset = "0x8CAFCF0", VA = "0x188CB16F0", Slot = "9")]
	public override void Execute(ScriptableRenderContext HHPFOCCGJIF, RenderingData FMGGMKFBAKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2470", Offset = "0x8CB0A70", VA = "0x188CB2470", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer PCKGIGGFIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x8CB24A0", Offset = "0x8CB0AA0", VA = "0x188CB24A0")]
	private void PEFOCDOGBBO(int LFGJJOFJCDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8CB12E0", Offset = "0x8CAF8E0", VA = "0x188CB12E0")]
	private void DKANMODAKCH(uint3 PGJDFKNAHDJ, uint3 JJNLMCCBMAO, ushort LFGJJOFJCDN, float3 MNAPPNKJIIL, float PNAIDDAALAO, float EIEFMLAAGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8CB1DB0", Offset = "0x8CB03B0", VA = "0x188CB1DB0")]
	private void NDNFLBMGHNL(uint3 PGJDFKNAHDJ, uint3 JJNLMCCBMAO, ushort LFGJJOFJCDN, float3 MNAPPNKJIIL, float3 PABDOPMBOCJ, float3 MNEEDGMBJKC, float PNAIDDAALAO, float FLMGIFOOCKN, float EIEFMLAAGHC, float LMIFMOLCGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8CB2A50", Offset = "0x8CB1050", VA = "0x188CB2A50")]
	private void PMLEKDIBFHH(ushort LFGJJOFJCDN, uint MENFCANHJHO, float MKODFAILIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x8CB1960", Offset = "0x8CAFF60", VA = "0x188CB1960")]
	private float3 GIIDEGKHNKK(uint3 PGJDFKNAHDJ, float3 MNAPPNKJIIL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x8CADD00", Offset = "0x8CAC300", VA = "0x188CADD00")]
	private float LNDPOHPHJJL(float MHAKDHMKPMB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x8CADC40", Offset = "0x8CAC240", VA = "0x188CADC40")]
	private float JKIPJBMPAFE(float3 DJFCJMBEGGI, float3 MNEEDGMBJKC, float FLMGIFOOCKN, float EIEFMLAAGHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x8CB17D0", Offset = "0x8CAFDD0", VA = "0x188CB17D0")]
	private void FEGAOINPNBB(int HNBLGJDEAIK, ushort LMANJBNBDKP, int DOGEHJHKFGD, DHLIPGECOBJ IHJBBCGOGCP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class KPGLLLPKBPN
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class MIHADGJBANG
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int NNMLLNGAOEH;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int GMNNDFOODKP;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int KIHMCHJGLNN;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int GKMBJAOOJAG;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int MAMPMLCNJNN;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int JAHENFJOMHO;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int GBBODGCLBHD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int IIFHBBABEJC = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int LNLAPIOEBHF = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int CAPKBEJEJCP = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int ILLKJBMODAA = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int HDNAFMPGDBO = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int KHFKGKOKDBC = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int EOGPGIMIOPP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool BNLJJGHMNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer OALNJAEKHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture COCMIHMPLHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int AJIEKHNPAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int EKFNLEGFJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int APPFJBJBOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int DLLDKNLLAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int KJDLOMBAFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader DEPLMMJIJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int HMOGIGNHOFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int HEBCLINFJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 JACBBFHCLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 EMKEJABGGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> BGHJJEHGGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> GMEDFDFBOBE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> AHGKGAANFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1442610", Offset = "0x1440C10", VA = "0x181442610")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> JIDPBLIGDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x133C820", Offset = "0x133AE20", VA = "0x18133C820")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int NHNGBKGAOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xAE5560", Offset = "0xAE3B60", VA = "0x180AE5560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MAGCCCBAAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA9FA90", Offset = "0xA9E090", VA = "0x180A9FA90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader DFAADNLIECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8CACD00", Offset = "0x8CAB300", VA = "0x188CACD00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8CAC400", Offset = "0x8CAAA00", VA = "0x188CAC400")]
	public void CKBKAMMKCLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x8CACD90", Offset = "0x8CAB390", VA = "0x188CACD90")]
	public void LBEJNBMBNKM(CameraData EBJGBLCMHBJ, LightData NACFHBJBMHB, int HEDCMEJLMMI, bool GLFJILOGCNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3E70FA0", Offset = "0x3E6F5A0", VA = "0x183E70FA0")]
	private void AIMBINOPHGL<T>(NativeArray<T> OHHBFAGELLA, int MLMBLBFOLPC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8CAC0B0", Offset = "0x8CAA6B0", VA = "0x188CAC0B0")]
	public void CAJPMPDAFCJ(CommandBuffer PCKGIGGFIHN, ScriptableRenderContext HHPFOCCGJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8CAC4F0", Offset = "0x8CAAAF0", VA = "0x188CAC4F0")]
	private static void CMNBDMMPIHF(int JGOLOCNMOID, CommandBuffer PCKGIGGFIHN, RenderBuffer MLMKCBEIFDN, ComputeBuffer KBNFGKPOMAN, ComputeShader LHNIEBGOMHJ, int MMGIEADAIML, int PKHJNILJCOG, int LLFMHJKIFBM, int OLFJMGCMIGL, int BMEFINALFLC, int IPCKENEODKD, int CGPKCCPHBLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8CAC9E0", Offset = "0x8CAAFE0", VA = "0x188CAC9E0")]
	public void EBFHEHAAKJF(CommandBuffer PCKGIGGFIHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8CAD0A0", Offset = "0x8CAB6A0", VA = "0x188CAD0A0")]
	private RenderTexture PLFCIHLNEKC(RenderTexture GONALAFAPKJ, int MMGIEADAIML, int PKHJNILJCOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8CAC6D0", Offset = "0x8CAACD0", VA = "0x188CAC6D0")]
	public void CNIBMCPBAOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8CAC750", Offset = "0x8CAAD50", VA = "0x188CAC750")]
	public void DIHLILLMOLK(int IILNGCIACHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8CAD280", Offset = "0x8CAB880", VA = "0x188CAD280")]
	public KPGLLLPKBPN()
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
		public struct APCMPLMKGCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float OPGFPAOHNMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float BHAMHKBPOOK;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class NOGEPGKGFHC : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string LOBNLPDLEHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler GJNNDNDMAEC;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int CBHMMJKBDLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material HPINKLHDCFE;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8CB0D20", Offset = "0x8CAF320", VA = "0x188CB0D20")]
			public NOGEPGKGFHC(RenderPassEvent OKPCNKDLIPI, Material JKDFAJLFBEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8CB0940", Offset = "0x8CAEF40", VA = "0x188CB0940", Slot = "9")]
			public override void Execute(ScriptableRenderContext HHPFOCCGJIF, RenderingData FMGGMKFBAKI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static APCMPLMKGCH CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private NOGEPGKGFHC m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x8CB0220", Offset = "0x8CAE820", VA = "0x188CB0220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8CB01D0", Offset = "0x8CAE7D0", VA = "0x188CB01D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8CB0020", Offset = "0x8CAE620", VA = "0x188CB0020", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8CAFF50", Offset = "0x8CAE550", VA = "0x188CAFF50", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PHHDHBAFNEH, RenderingData FMGGMKFBAKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x195CEB0", Offset = "0x195B4B0", VA = "0x18195CEB0")]
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
		public struct GDIHFAAHIAA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float LLBKCDCHMJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color JFHPJJJOPJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh APANFHBPAHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve GCDCEALLCBA;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class EOHFJNGHKEM : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string LOBNLPDLEHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler GJNNDNDMAEC;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int EDKIECEMAGA;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int GGILNIADBHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material HPINKLHDCFE;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8CA9860", Offset = "0x8CA7E60", VA = "0x188CA9860")]
			public EOHFJNGHKEM(RenderPassEvent OKPCNKDLIPI, Material JKDFAJLFBEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8CA95A0", Offset = "0x8CA7BA0", VA = "0x188CA95A0", Slot = "9")]
			public override void Execute(ScriptableRenderContext HHPFOCCGJIF, RenderingData FMGGMKFBAKI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static GDIHFAAHIAA CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private EOHFJNGHKEM m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x8CB0550", Offset = "0x8CAEB50", VA = "0x188CB0550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8CB03A0", Offset = "0x8CAE9A0", VA = "0x188CB03A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8CB0280", Offset = "0x8CAE880", VA = "0x188CB0280", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PHHDHBAFNEH, RenderingData FMGGMKFBAKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x195CEB0", Offset = "0x195B4B0", VA = "0x18195CEB0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string NOFPPMKJGLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool JJBHGOJAEJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer PCKGIGGFIHN, ScriptableRenderContext HHPFOCCGJIF, RenderingData FMGGMKFBAKI);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
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
		private class HJFGIENHKNF : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool PKIDLJDNJAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> KHCMDFALNIJ;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> EEHJBPBBPGP;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8CABA40", Offset = "0x8CAA040", VA = "0x188CABA40")]
			public HJFGIENHKNF(RenderPassEvent OKPCNKDLIPI, bool PKIDLJDNJAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8CAB6C0", Offset = "0x8CA9CC0", VA = "0x188CAB6C0")]
			public bool OJBDAEJKGJC(CameraData EBJGBLCMHBJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8CAB4F0", Offset = "0x8CA9AF0", VA = "0x188CAB4F0", Slot = "9")]
			public override void Execute(ScriptableRenderContext HHPFOCCGJIF, RenderingData FMGGMKFBAKI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8CAB410", Offset = "0x8CA9A10", VA = "0x188CAB410")]
			private void AJMBGDPPBCJ(PerCameraRenderEffect NLNFNALJJIF, ScriptableRenderContext HHPFOCCGJIF, RenderingData FMGGMKFBAKI)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private HJFGIENHKNF m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private HJFGIENHKNF m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8CB2C80", Offset = "0x8CB1280", VA = "0x188CB2C80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8CB2BF0", Offset = "0x8CB11F0", VA = "0x188CB2BF0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PHHDHBAFNEH, RenderingData FMGGMKFBAKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x195CEB0", Offset = "0x195B4B0", VA = "0x18195CEB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8CB2ED0", Offset = "0x8CB14D0", VA = "0x188CB2ED0")]
		public static void CODCBEMKHDG(ScriptableRenderPass DGEALDDHEKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8CB2D30", Offset = "0x8CB1330", VA = "0x188CB2D30", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer PHHDHBAFNEH, RenderingData FMGGMKFBAKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x195CEB0", Offset = "0x195B4B0", VA = "0x18195CEB0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class MKNKBBAFCPF
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 FGAFFFIEJOM;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 AJBMNAGIMKI;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 EFKCBAOOONG;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 ILJIMELMMGF;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 MJPOFMMAECB;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8CAF4F0", Offset = "0x8CADAF0", VA = "0x188CAF4F0")]
	public static uint PMKNHHPJFND(uint POMPNNDHCKO, uint JLAHKMCOIFF, uint GFIJDJGEMLL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x8CAF150", Offset = "0x8CAD750", VA = "0x188CAF150")]
	public static uint3 ENCNKJICGFL(float3 AANGPKCDGHO, float3 NHCJDFEIJMD, float3 EEGLKEDPOBB)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8CAEA40", Offset = "0x8CAD040", VA = "0x188CAEA40")]
	public static void AGGOBAFGLDA(float3 LEKEOFBPKDH, float3 PDCLCMAPPFE, float3 PEGFKANKANG, float OFHHJJPMNHK, [Out] uint3 NECPIEJKIAI, [Out] uint3 FIEHNBOKDEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8CAEC80", Offset = "0x8CAD280", VA = "0x188CAEC80")]
	public static void BLMHKBMKAJA(float3 MEMOCGIMKHP, float3 BCAFCDPPLGC, float KNPJHKKMLOF, float JNMEBPPPBCN, [Out] float3 KOPJEFOFJJO, [Out] float OFHHJJPMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8CAF350", Offset = "0x8CAD950", VA = "0x188CAF350")]
	private static float3 FJGOHPLLOEC(float3 ACIDFFGNDMD, float3 DLJAODJPFGE, float3 EFIJHIEPODN, float3 IJADIGNGFFK)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class ILCOIGMJEGJ
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly IDGHEFJHGEI KLBMCELPJJD;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly IDGHEFJHGEI EAJMFHEOGJA;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly IDGHEFJHGEI AFKLEGEGAAE;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly IDGHEFJHGEI DKAFHCIAGEP;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly IDGHEFJHGEI ABPFPKLABAI;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class MPIHPDFICGO
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh PBAFJAFDFKE;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8CAF640", Offset = "0x8CADC40", VA = "0x188CAF640")]
	public static Mesh GFBFAKGBHLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8CAFAB0", Offset = "0x8CAE0B0", VA = "0x188CAFAB0")]
	public static Matrix4x4 MDCAJANIBDH(Camera GBGEPBILLFN, bool BDDFFMPMADI = false, bool DJCPOGPKLML = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8CAF6F0", Offset = "0x8CADCF0", VA = "0x188CAF6F0")]
	private static Mesh ILNNNKODBBP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1967982710
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x8CB4370", Offset = "0x8CB2970", VA = "0x188CB4370")]
	public static void NCAGDGCNHIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x8CB4360", Offset = "0x8CB2960", VA = "0x188CB4360")]
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
