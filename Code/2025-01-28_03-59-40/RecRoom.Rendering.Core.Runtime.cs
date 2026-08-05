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
	public class LogRegistrationIndex : FOFAFNFGNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x791AF30", Offset = "0x791A130", VA = "0x18791AF30", Slot = "4")]
		public override void JMFBCAGPLCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x91D620", Offset = "0x91C820", VA = "0x18091D620")]
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
		public enum GAINNIJEKFA
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface DHFDKEOFCNO
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void OPAIAFJGAEK(ScriptableRenderContext GCGNIOHLIKK, List<Camera> CDHCOFKLGHM);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface COIHGLCIEOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void OPAIAFJGAEK(ScriptableRenderContext GCGNIOHLIKK, RenderingData FENNMANFJMO);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class POOLAIGILGD : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x791EDA0", Offset = "0x791DFA0", VA = "0x18791EDA0")]
			public POOLAIGILGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x791ED40", Offset = "0x791DF40", VA = "0x18791ED40", Slot = "9")]
			public override void Execute(ScriptableRenderContext GCGNIOHLIKK, RenderingData FENNMANFJMO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private POOLAIGILGD _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<DHFDKEOFCNO> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<DHFDKEOFCNO> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<COIHGLCIEOD> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<COIHGLCIEOD> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x791F570", Offset = "0x791E770", VA = "0x18791F570")]
		public static void DDNGNKDNJAL(GAINNIJEKFA MKPOFGKDEHH, DHFDKEOFCNO EFCMCDEKCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x791FCF0", Offset = "0x791EEF0", VA = "0x18791FCF0")]
		public static void MKAFOKLOHPP(GAINNIJEKFA MKPOFGKDEHH, DHFDKEOFCNO EFCMCDEKCIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x791F4B0", Offset = "0x791E6B0", VA = "0x18791F4B0")]
		public static void DDNGNKDNJAL(GAINNIJEKFA MKPOFGKDEHH, COIHGLCIEOD HBLDOGHCLLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x791FC30", Offset = "0x791EE30", VA = "0x18791FC30")]
		public static void MKAFOKLOHPP(GAINNIJEKFA MKPOFGKDEHH, COIHGLCIEOD HBLDOGHCLLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x791F2C0", Offset = "0x791E4C0", VA = "0x18791F2C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x791F210", Offset = "0x791E410", VA = "0x18791F210", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer DELKJLDIJIB, RenderingData FENNMANFJMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x791F630", Offset = "0x791E830", VA = "0x18791F630", Slot = "9")]
		protected override void Dispose(bool FDMJPIFEGDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x791F740", Offset = "0x791E940", VA = "0x18791F740")]
		private static void LCAAALDOAEB(ScriptableRenderContext GCGNIOHLIKK, List<Camera> CDHCOFKLGHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x791FDB0", Offset = "0x791EFB0", VA = "0x18791FDB0")]
		private static void ONLHKCFPFIE(ScriptableRenderContext GCGNIOHLIKK, List<Camera> CDHCOFKLGHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x791FE20", Offset = "0x791F020", VA = "0x18791FE20")]
		private static void PAHDKEOHIPL(ScriptableRenderContext GCGNIOHLIKK, RenderingData FENNMANFJMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1420D00", Offset = "0x141FF00", VA = "0x181420D00")]
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
		private class BHKPGCNOHGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool FDOABOBHJJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<BKNBKNIBBLB> IFHGDJLIIKO;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7917950", Offset = "0x7916B50", VA = "0x187917950")]
			public BHKPGCNOHGI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class NMENMNLGAFJ : PreRenderManager.COIHGLCIEOD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string NDILKPNCDIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler BGKBFHOCIIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly BHKPGCNOHGI JMPIADPEJBO;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x791E3B0", Offset = "0x791D5B0", VA = "0x18791E3B0")]
			public NMENMNLGAFJ(BHKPGCNOHGI FFBMACBPABB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x791DFB0", Offset = "0x791D1B0", VA = "0x18791DFB0", Slot = "4")]
			public void OPAIAFJGAEK(ScriptableRenderContext GCGNIOHLIKK, RenderingData FENNMANFJMO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class PEPCAAEPDNP : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string NGNIPEFDAIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly BHKPGCNOHGI FFBMACBPABB;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x791EB20", Offset = "0x791DD20", VA = "0x18791EB20")]
			public PEPCAAEPDNP(RenderPassEvent PPAAELGINFG, BHKPGCNOHGI FFBMACBPABB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x791E810", Offset = "0x791DA10", VA = "0x18791E810", Slot = "9")]
			public override void Execute(ScriptableRenderContext GCGNIOHLIKK, RenderingData FENNMANFJMO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<BKNBKNIBBLB> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private NMENMNLGAFJ fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private PEPCAAEPDNP fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private BHKPGCNOHGI sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7918B70", Offset = "0x7917D70", VA = "0x187918B70", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7918F00", Offset = "0x7918100", VA = "0x187918F00", Slot = "9")]
		protected override void Dispose(bool FDMJPIFEGDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7918AD0", Offset = "0x7917CD0", VA = "0x187918AD0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer DELKJLDIJIB, RenderingData FENNMANFJMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1420D00", Offset = "0x141FF00", VA = "0x181420D00")]
		public FastLinesRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BKNBKNIBBLB
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MGJBAHKGNGA(CommandBuffer NMFLOALINMH, Camera GMDPMJCMKON, [NotNull] UniversalAdditionalCameraData OMNAAFKHJGB, bool BLFGOKIJLOL);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDNDJHEPLGN(Camera GMDPMJCMKON, CommandBuffer GGLELMAOCGA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KKHJFHPFBLM
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static bool GKABAHBKBOJ;
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
		private FAGMLMNCALK _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private BHBBJBADJMJ _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x791AEC0", Offset = "0x791A0C0", VA = "0x18791AEC0", Slot = "9")]
		protected override void Dispose(bool BELPOKMDOAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x791AC00", Offset = "0x7919E00", VA = "0x18791AC00")]
		private void DKDEJPGABFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x791A8B0", Offset = "0x7919AB0", VA = "0x18791A8B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer DELKJLDIJIB, RenderingData FENNMANFJMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1420D00", Offset = "0x141FF00", VA = "0x181420D00")]
		public LightBinning()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HLLLCGNMCHC
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7919CA0", Offset = "0x7918EA0", VA = "0x187919CA0")]
	public static int NNCPCFPOMOM(bool OEHBLJMMGON)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1887830", Offset = "0x1886A30", VA = "0x181887830")]
	public static int GFMONHMGOPL(bool OEHBLJMMGON)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct MEHLBDNLBMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public LightType FDGCDCJDMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float CNOOJLAGPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float CILLHHMAAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float MCNIBNMJAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float4 FOLNEAEBILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float4 NPMHABMIOLO;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct CCHLMDGIHHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public ushort CGGJPLGFJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float FHAKMGMBOBE;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
public struct NBKGNEMINMK : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[ReadOnly]
	public NativeArray<MEHLBDNLBMP> CIFNJFBFOOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[ReadOnly]
	public float3 FOIFNDBFANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[ReadOnly]
	public float3 KCOHGEONDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, CCHLMDGIHHG>.ParallelWriter DBLHFFDAEGA;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x791C420", Offset = "0x791B620", VA = "0x18791C420", Slot = "4")]
	public void Execute(int CGGJPLGFJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x791CA50", Offset = "0x791BC50", VA = "0x18791CA50")]
	private void POBMLMLIALG(uint3 GMCJIDIPFFD, uint3 ABEOMJKOBAP, ushort CGGJPLGFJPN, float3 MOGOGAOFHLG, float PGNBPINEJNL, float CCKBLLKOOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x791BF70", Offset = "0x791B170", VA = "0x18791BF70")]
	private void DPOABIGLNNH(uint3 GMCJIDIPFFD, uint3 ABEOMJKOBAP, ushort CGGJPLGFJPN, float3 MOGOGAOFHLG, float3 JMEKNFOPLNJ, float3 JAPAMPADBCI, float PGNBPINEJNL, float OBMCCIDIOJE, float CCKBLLKOOCA, float IDBOOHEDHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x791C960", Offset = "0x791BB60", VA = "0x18791C960")]
	private float3 OGFDNOABNFG(uint3 GMCJIDIPFFD, float3 MOGOGAOFHLG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7916820", Offset = "0x7915A20", VA = "0x187916820")]
	private float KCMNIGOCFIP(float CNOOJLAGPNO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7915A80", Offset = "0x7914C80", VA = "0x187915A80")]
	private float BOGOKDGMOBB(float3 LMGLLIGNNDE, float3 JAPAMPADBCI, float OBMCCIDIOJE, float CCKBLLKOOCA)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
public struct AHPMCLHGDLG : IJobParallelForBatch
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	[ReadOnly]
	public NativeParallelMultiHashMap<ushort, CCHLMDGIHHG> DBLHFFDAEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	[ReadOnly]
	public uint CCOEHLNEKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[ReadOnly]
	public int BAECKACNAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[ReadOnly]
	public int FLKKPKKBBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[WriteOnly]
	public NativeArray<uint> GNDHGNAHKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<float> GIGLFHHDDME;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7915770", Offset = "0x7914970", VA = "0x187915770", Slot = "4")]
	public void Execute(int KIECCGCNJHL, int PJGEBKIBCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7915910", Offset = "0x7914B10", VA = "0x187915910")]
	private void NCDEBKAIJNI(int JCLHCGLCCNG, ushort FFFKENPGFEO, int MBHHOKHJKOJ, CCHLMDGIHHG HACLLAHIMBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct MBNGDKKJLNC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[WriteOnly]
	public NativeParallelMultiHashMap<ushort, CCHLMDGIHHG> DBLHFFDAEGA;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x791AFC0", Offset = "0x791A1C0", VA = "0x18791AFC0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FAGMLMNCALK : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private static readonly bool IJEAEOCHPCE;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const float KADHACFOEAM = 179f;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int MBOJPMAMDDB = 32;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const int LFNMGOIEKOG = 221184;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private NBKGNEMINMK KAPAIKOCJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private AHPMCLHGDLG GDAMNBCFMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private MBNGDKKJLNC LHHONPHDHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeParallelMultiHashMap<ushort, CCHLMDGIHHG> AEJFDMIJNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private NHNPAIHAFEH AGCHMJCBOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private bool PPOIBKNAGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int KLOEAGCENFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private NativeArray<MEHLBDNLBMP> HGAEACPLOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private JobHandle OPEIFACJGDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private JobHandle JPCBOCLEEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private bool ADMMAKFLKON;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7918A20", Offset = "0x7917C20", VA = "0x187918A20")]
	public FAGMLMNCALK(RenderPassEvent PPAAELGINFG, ComputeShader GJJBFBPAJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x79181B0", Offset = "0x79173B0", VA = "0x1879181B0")]
	private void MMLHCAFHFIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7917B40", Offset = "0x7916D40", VA = "0x187917B40")]
	public void EJDGCGLDELB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x3245D50", Offset = "0x3244F50", VA = "0x183245D50")]
	public static void BBEGPMONGKD<T>(NativeArray<T> HCOCCGHLKNN, int AFLMMFDMNOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x7918220", Offset = "0x7917420", VA = "0x187918220")]
	public void MOMAEBOEEIG(CameraData OMNAAFKHJGB, LightData EAPIIIJHLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7917D50", Offset = "0x7916F50", VA = "0x187917D50")]
	private void LNLLGEKIKMJ(LightData EAPIIIJHLIG, NativeArray<MEHLBDNLBMP> COAOGCDFJFH, int CJBFCGDDJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7918760", Offset = "0x7917960", VA = "0x187918760")]
	private void NGHJLJINGIB(CameraData OMNAAFKHJGB, LightData EAPIIIJHLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x79185D0", Offset = "0x79177D0", VA = "0x1879185D0")]
	private void NCLDDGDNOAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x7918090", Offset = "0x7917290", VA = "0x187918090")]
	private void MAADFNHBEKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x7918190", Offset = "0x7917390", VA = "0x187918190")]
	private void MIEOCHHIBBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x7917D20", Offset = "0x7916F20", VA = "0x187917D20")]
	private void KGFEEDPBMCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x7917C20", Offset = "0x7916E20", VA = "0x187917C20", Slot = "9")]
	public override void Execute(ScriptableRenderContext GCGNIOHLIKK, RenderingData FENNMANFJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x79189A0", Offset = "0x7917BA0", VA = "0x1879189A0", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer GGLELMAOCGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BHBBJBADJMJ : ScriptableRenderPass
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private const ushort PKLLJKNKLMH = 159;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private const float KADHACFOEAM = 179f;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly NHNPAIHAFEH AGCHMJCBOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private int LFDPFBOPNEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private MEHLBDNLBMP[] HGAEACPLOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private float3 LAFAAFEDPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private float3 KNFPGOPIOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private uint ANDBBMIBCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int LBLHEEIPNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private int NOMKFHJHELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<uint> GNDHGNAHKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<float> GIGLFHHDDME;

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x79178A0", Offset = "0x7916AA0", VA = "0x1879178A0")]
	public BHBBJBADJMJ(RenderPassEvent PPAAELGINFG, ComputeShader GJJBFBPAJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7916CC0", Offset = "0x7915EC0", VA = "0x187916CC0")]
	public void MOMAEBOEEIG(CameraData OMNAAFKHJGB, LightData EAPIIIJHLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7916FC0", Offset = "0x79161C0", VA = "0x187916FC0")]
	private void NDMODBAIBDE(CameraData OMNAAFKHJGB, LightData EAPIIIJHLIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x79160C0", Offset = "0x79152C0", VA = "0x1879160C0")]
	public void EJDGCGLDELB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7916900", Offset = "0x7915B00", VA = "0x187916900")]
	private void LNLLGEKIKMJ(LightData EAPIIIJHLIG, MEHLBDNLBMP[] COAOGCDFJFH, int CJBFCGDDJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7916770", Offset = "0x7915970", VA = "0x187916770")]
	private void IOFFDOJFALF(int KIECCGCNJHL, int PJGEBKIBCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7915B40", Offset = "0x7914D40", VA = "0x187915B40")]
	private void CLAKOGNGJAN(int KIECCGCNJHL, int EOKNBJLIKEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7917860", Offset = "0x7916A60", VA = "0x187917860")]
	private ushort PPLPPIGPIDA(int KIECCGCNJHL)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x79172C0", Offset = "0x79164C0", VA = "0x1879172C0")]
	private void OJCMIMOAMIF(int KIECCGCNJHL, int PJGEBKIBCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7916C50", Offset = "0x7915E50", VA = "0x187916C50")]
	private void MBHCCEEKHGP(int AFLMMFDMNOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7916840", Offset = "0x7915A40", VA = "0x187916840")]
	private void KFINMDLOEPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x79160E0", Offset = "0x79152E0", VA = "0x1879160E0", Slot = "9")]
	public override void Execute(ScriptableRenderContext GCGNIOHLIKK, RenderingData FENNMANFJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7917420", Offset = "0x7916620", VA = "0x187917420", Slot = "8")]
	public override void OnFinishCameraStackRendering(CommandBuffer GGLELMAOCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x79161C0", Offset = "0x79153C0", VA = "0x1879161C0")]
	private void IGMPJJBGCCP(int CGGJPLGFJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7917450", Offset = "0x7916650", VA = "0x187917450")]
	private void POBMLMLIALG(uint3 GMCJIDIPFFD, uint3 ABEOMJKOBAP, ushort CGGJPLGFJPN, float3 MOGOGAOFHLG, float PGNBPINEJNL, float CCKBLLKOOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7915B70", Offset = "0x7914D70", VA = "0x187915B70")]
	private void DPOABIGLNNH(uint3 GMCJIDIPFFD, uint3 ABEOMJKOBAP, ushort CGGJPLGFJPN, float3 MOGOGAOFHLG, float3 JMEKNFOPLNJ, float3 JAPAMPADBCI, float PGNBPINEJNL, float OBMCCIDIOJE, float CCKBLLKOOCA, float IDBOOHEDHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7917330", Offset = "0x7916530", VA = "0x187917330")]
	private void OOJOJCJCICO(ushort CGGJPLGFJPN, uint MMNFNBFLFMJ, float ANJHGMEEABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x79171C0", Offset = "0x79163C0", VA = "0x1879171C0")]
	private float3 OGFDNOABNFG(uint3 GMCJIDIPFFD, float3 MOGOGAOFHLG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7916820", Offset = "0x7915A20", VA = "0x187916820")]
	private float KCMNIGOCFIP(float CNOOJLAGPNO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7915A80", Offset = "0x7914C80", VA = "0x187915A80")]
	private float BOGOKDGMOBB(float3 LMGLLIGNNDE, float3 JAPAMPADBCI, float OBMCCIDIOJE, float CCKBLLKOOCA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7916E30", Offset = "0x7916030", VA = "0x187916E30")]
	private void NCDEBKAIJNI(int JCLHCGLCCNG, ushort FFFKENPGFEO, int MBHHOKHJKOJ, CCHLMDGIHHG HACLLAHIMBK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class NHNPAIHAFEH
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private static class DPGLCGGNNAO
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public static readonly int AMNMCCIBACC;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly int KLNFGOADDLM;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly int DABOIMLBMLG;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public static readonly int CODLKEKELMO;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public static readonly int GIADACADEJH;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static readonly int KCIFBLDBDGD;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public static readonly int ACHMCIPKDCA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private const int CPKAOEENBDA = 4;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private const int AHDABFDJFNC = 2;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private const int AAHGBPOEFJN = 3;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private const int KBCKFAEEICH = 3;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private const int CFKFMBCMLBF = 3;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private const int AKOPMGGBEKN = 4;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private const int LCAJGHJHKFD = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private bool BOIBHAPBKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private ComputeBuffer EEFOOCELFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private RenderTexture NPBDBODFONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private int OOMHKPKNLMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private int DONAKDCDIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private int FCINLICIAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private int IPGJEMLALDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private int JGHMEOKJHJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private ComputeShader NFFNAGEAJGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private int KMLJGGNCPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private int MGLCODKJFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public float3 MFGJACGCAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public float3 EAIFGIDFCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private NativeArray<uint> AEMIGAABIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private NativeArray<float> GNIHGLINCIL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public NativeArray<uint> BPKJJHCDLEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x16BEF20", Offset = "0x16BE120", VA = "0x1816BEF20")]
		get
		{
			return default(NativeArray<uint>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NativeArray<float> LPGHPHFGOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xF77B40", Offset = "0xF76D40", VA = "0x180F77B40")]
		get
		{
			return default(NativeArray<float>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GONBPBMKPCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xB29E30", Offset = "0xB29030", VA = "0x180B29E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int MKEPPNGHIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8F5470", Offset = "0x8F4670", VA = "0x1808F5470")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ComputeShader FEAKDOHBLJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x791D550", Offset = "0x791C750", VA = "0x18791D550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x791D5E0", Offset = "0x791C7E0", VA = "0x18791D5E0")]
	public void MFBFDNDBONL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x791DC80", Offset = "0x791CE80", VA = "0x18791DC80")]
	public void POCHFMFANEE(CameraData OMNAAFKHJGB, LightData EAPIIIJHLIG, int NKEANKMGOCH, bool OEHBLJMMGON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x33F3ED0", Offset = "0x33F30D0", VA = "0x1833F3ED0")]
	private void BBEGPMONGKD<T>(NativeArray<T> HCOCCGHLKNN, int AFLMMFDMNOE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x791CFA0", Offset = "0x791C1A0", VA = "0x18791CFA0")]
	public void ELPBNGKIHCI(CommandBuffer GGLELMAOCGA, ScriptableRenderContext GCGNIOHLIKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x791D370", Offset = "0x791C570", VA = "0x18791D370")]
	private static void HKJCAEHOHGI(int ONELMLJIDAF, CommandBuffer GGLELMAOCGA, RenderBuffer MIBFOHLIGDN, ComputeBuffer CILCNHPFGOA, ComputeShader GFIGGFDKMMH, int LKFLBDBBFBN, int JPNFDFIPOPO, int KNGBBPOADMD, int CMHFPLLAEGK, int IOKPEFHFLEF, int NKJNNAJACKM, int NMGMMBABDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x791D960", Offset = "0x791CB60", VA = "0x18791D960")]
	public void PLKHJGCLHIG(CommandBuffer GGLELMAOCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x791CDC0", Offset = "0x791BFC0", VA = "0x18791CDC0")]
	private RenderTexture BGNDAGDJCHI(RenderTexture EALPNDDMABI, int LKFLBDBBFBN, int JPNFDFIPOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x791D2F0", Offset = "0x791C4F0", VA = "0x18791D2F0")]
	public void FKGOHLMPNJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x791D6D0", Offset = "0x791C8D0", VA = "0x18791D6D0")]
	public void MMIDLLBHCGB(int EHEEELDOPNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x791DF90", Offset = "0x791D190", VA = "0x18791DF90")]
	public NHNPAIHAFEH()
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
		public struct GGFECGKIKEN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float BGICIBLGJLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float MCDNPMGJBMH;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class GMPJLBMOJKI : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string JFFKFGLPAOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private ProfilingSampler BEFNBPKCGPD;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private static readonly int PDJLGOFEPJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private Material PCOMADGJCPH;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7919BC0", Offset = "0x7918DC0", VA = "0x187919BC0")]
			public GMPJLBMOJKI(RenderPassEvent PPAAELGINFG, Material HGJFBFIMOOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x79197E0", Offset = "0x79189E0", VA = "0x1879197E0", Slot = "9")]
			public override void Execute(ScriptableRenderContext GCGNIOHLIKK, RenderingData FENNMANFJMO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static GGFECGKIKEN CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private GMPJLBMOJKI m_MobileFadePass;

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
			[Cpp2IlInjected.Address(RVA = "0x791BBE0", Offset = "0x791ADE0", VA = "0x18791BBE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float CurrentFadeValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x791BB90", Offset = "0x791AD90", VA = "0x18791BB90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x791B9E0", Offset = "0x791ABE0", VA = "0x18791B9E0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x791B910", Offset = "0x791AB10", VA = "0x18791B910", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer DELKJLDIJIB, RenderingData FENNMANFJMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1420D00", Offset = "0x141FF00", VA = "0x181420D00")]
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
		public struct PGFAMLJHFBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float GJMDABHJIII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Color BHPHNBGMJAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Mesh JNEBEMBBGCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AnimationCurve GHCOIMAMENL;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class OBJBMPPJPHF : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly string JFFKFGLPAOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private ProfilingSampler BEFNBPKCGPD;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private static readonly int MAELJEPJCKE;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly int KHOFMNONOGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private Material PCOMADGJCPH;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x791E730", Offset = "0x791D930", VA = "0x18791E730")]
			public OBJBMPPJPHF(RenderPassEvent PPAAELGINFG, Material HGJFBFIMOOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x791E470", Offset = "0x791D670", VA = "0x18791E470", Slot = "9")]
			public override void Execute(ScriptableRenderContext GCGNIOHLIKK, RenderingData FENNMANFJMO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static PGFAMLJHFBA CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private OBJBMPPJPHF m_MobileVignettePass;

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
			[Cpp2IlInjected.Address(RVA = "0x791BF10", Offset = "0x791B110", VA = "0x18791BF10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x791BD60", Offset = "0x791AF60", VA = "0x18791BD60", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x791BC40", Offset = "0x791AE40", VA = "0x18791BC40", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer DELKJLDIJIB, RenderingData FENNMANFJMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1420D00", Offset = "0x141FF00", VA = "0x181420D00")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string EGJADJMLDHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool ENHNGGHOCCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x93C9F0", Offset = "0x93BBF0", VA = "0x18093C9F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer GGLELMAOCGA, ScriptableRenderContext GCGNIOHLIKK, RenderingData FENNMANFJMO);

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D70", Offset = "0x8F2F70", VA = "0x1808F3D70")]
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
		private class GFCEIPFPLOD : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private bool NFIHBDAGKJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private readonly List<PerCameraRenderEffect> JPCDCIBPNIP;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private static readonly List<PerCameraRenderEffect> KKHHPHGLALI;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x7919730", Offset = "0x7918930", VA = "0x187919730")]
			public GFCEIPFPLOD(RenderPassEvent PPAAELGINFG, bool NFIHBDAGKJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x79191E0", Offset = "0x79183E0", VA = "0x1879191E0")]
			public bool EOJIPHAFGMB(CameraData OMNAAFKHJGB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x79194D0", Offset = "0x79186D0", VA = "0x1879194D0", Slot = "9")]
			public override void Execute(ScriptableRenderContext GCGNIOHLIKK, RenderingData FENNMANFJMO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x7919100", Offset = "0x7918300", VA = "0x187919100")]
			private void BLEKKCBONBI(PerCameraRenderEffect BLEFKGPPECC, ScriptableRenderContext GCGNIOHLIKK, RenderingData FENNMANFJMO)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private GFCEIPFPLOD m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private GFCEIPFPLOD m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x791EE50", Offset = "0x791E050", VA = "0x18791EE50", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x791EDC0", Offset = "0x791DFC0", VA = "0x18791EDC0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer DELKJLDIJIB, RenderingData FENNMANFJMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x1420D00", Offset = "0x141FF00", VA = "0x181420D00")]
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
		[Cpp2IlInjected.Address(RVA = "0x791F0A0", Offset = "0x791E2A0", VA = "0x18791F0A0")]
		public static void NEJEFGKNDAP(ScriptableRenderPass OCMMEHPLNLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8F3D80", Offset = "0x8F2F80", VA = "0x1808F3D80", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x791EF00", Offset = "0x791E100", VA = "0x18791EF00", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer DELKJLDIJIB, RenderingData FENNMANFJMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1420D00", Offset = "0x141FF00", VA = "0x181420D00")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class KANHMBFDDPK
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly float3 MLHEDHPHDFK;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly uint3 ECJBONEJABG;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static readonly uint3 GJKCIDOFCLB;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly float3 BIFOGLOANLL;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly float3 BLECMONLKFP;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x791A760", Offset = "0x7919960", VA = "0x18791A760")]
	public static uint PKMIFONLDJB(uint KIEMJAMMNPB, uint IIOFLMMOEPL, uint NIEPPNHEGLF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x791A090", Offset = "0x7919290", VA = "0x18791A090")]
	public static uint3 LKBFMANEKDL(float3 FCKJMOMOHAE, float3 FOIFNDBFANF, float3 KCOHGEONDLP)
	{
		return default(uint3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7919E50", Offset = "0x7919050", VA = "0x187919E50")]
	public static void HIINDKNFAOO(float3 AAKMEDJKFMK, float3 HCLICLGCAPG, float3 FCBLNELGNKG, float COBBNHPDFBH, [Out] uint3 IEMHEOCLKLN, [Out] uint3 CCPLCEDEIJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x791A290", Offset = "0x7919490", VA = "0x18791A290")]
	public static void NIFGAJPAJLH(float3 IBLLMCOKNCH, float3 GLGEAHLKJNI, float CILLHHMAAOC, float FGMEFAPFMAE, [Out] float3 KPOPDEAOOEB, [Out] float COBBNHPDFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7919CB0", Offset = "0x7918EB0", VA = "0x187919CB0")]
	private static float3 ELMHIKFCGDN(float3 IPAHIPBMOBH, float3 HJJFHCOEMOB, float3 EIOCIHNKMOJ, float3 BFEIMEKPJPF)
	{
		return default(float3);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class PLONNJBEGOF
{
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static readonly KJMCEDJMPPA JHFFFJJNEGC;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly KJMCEDJMPPA EPOHIMJJDBO;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly KJMCEDJMPPA KLCIOBPLLLD;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly KJMCEDJMPPA GCICNKCIDCO;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly KJMCEDJMPPA KCONFNCONLJ;
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class MMOJBGGJGKF
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private static Mesh ODDKNGJAMLL;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x791B4A0", Offset = "0x791A6A0", VA = "0x18791B4A0")]
	public static Mesh FPAAJBLEJDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x791B000", Offset = "0x791A200", VA = "0x18791B000")]
	public static Matrix4x4 EKKKNIKLOOD(Camera GMDPMJCMKON, bool JCABGNFEAHG = false, bool NKBKLDLEGMM = false)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x791B550", Offset = "0x791A750", VA = "0x18791B550")]
	private static Mesh GAEBLPDIDAD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3477820297
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7920520", Offset = "0x791F720", VA = "0x187920520")]
	public static void NDFJCLOCNNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7920510", Offset = "0x791F710", VA = "0x187920510")]
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
