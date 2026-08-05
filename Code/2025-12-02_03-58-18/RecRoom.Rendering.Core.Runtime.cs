using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Logging;
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
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x89A1E30", Offset = "0x89A0A30", VA = "0x1889A1E30", Slot = "4")]
		public override void OGBNJYRINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		public enum TaskType
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Compute,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Graphics
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public interface RDFTBMCLCZS
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void UPTKQERGVTY(ScriptableRenderContext a, List<Camera> b);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface XAEZYGTBUEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void UPTKQERGVTY(ScriptableRenderContext a, RenderingData b);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class NQITUTQCDAN : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x89A2AE0", Offset = "0x89A16E0", VA = "0x1889A2AE0")]
			public NQITUTQCDAN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x89A2A80", Offset = "0x89A1680", VA = "0x1889A2A80", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private NQITUTQCDAN _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<RDFTBMCLCZS> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<RDFTBMCLCZS> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<XAEZYGTBUEI> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<XAEZYGTBUEI> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x89A59B0", Offset = "0x89A45B0", VA = "0x1889A59B0")]
		public static void AddTask(TaskType taskType, RDFTBMCLCZS contextTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x89A6520", Offset = "0x89A5120", VA = "0x1889A6520")]
		public static void RemoveTask(TaskType taskType, RDFTBMCLCZS contextTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x89A5AF0", Offset = "0x89A46F0", VA = "0x1889A5AF0")]
		public static void AddTask(TaskType taskType, XAEZYGTBUEI cameraTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x89A6460", Offset = "0x89A5060", VA = "0x1889A6460")]
		public static void RemoveTask(TaskType taskType, XAEZYGTBUEI cameraTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89A5CA0", Offset = "0x89A48A0", VA = "0x1889A5CA0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89A5900", Offset = "0x89A4500", VA = "0x1889A5900", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x89A5E90", Offset = "0x89A4A90", VA = "0x1889A5E90", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x89A65E0", Offset = "0x89A51E0", VA = "0x1889A65E0")]
		private static void VXEGICXTXJL(ScriptableRenderContext a, List<Camera> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x89A5C30", Offset = "0x89A4830", VA = "0x1889A5C30")]
		private static void CPJLXEACZBP(ScriptableRenderContext a, List<Camera> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x89A5F90", Offset = "0x89A4B90", VA = "0x1889A5F90")]
		private static void GMNBMPZFIHR(ScriptableRenderContext a, RenderingData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1694EF0", Offset = "0x1693AF0", VA = "0x181694EF0")]
		public PreRenderManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Fast Lines")]
	public class FastLinesRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class VUJRLSATRJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool XKTTZHJPZFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<HOVNFCAQSAB> BRRSJIYPLTS;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x89A93D0", Offset = "0x89A7FD0", VA = "0x1889A93D0")]
			public VUJRLSATRJK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class STIGEBWIBRK : PreRenderManager.XAEZYGTBUEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string PJZCCIYVVDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler MGOGLVTAJPY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly VUJRLSATRJK NLYYLAWTGIV;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x89A7800", Offset = "0x89A6400", VA = "0x1889A7800")]
			public STIGEBWIBRK(VUJRLSATRJK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x89A73F0", Offset = "0x89A5FF0", VA = "0x1889A73F0", Slot = "4")]
			public void UPTKQERGVTY(ScriptableRenderContext a, RenderingData b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class MTSONRTFUJP : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string GKRXMSHYCFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly VUJRLSATRJK XYSMKJILNFA;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x89A21D0", Offset = "0x89A0DD0", VA = "0x1889A21D0")]
			public MTSONRTFUJP(RenderPassEvent a, VUJRLSATRJK b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x89A1EB0", Offset = "0x89A0AB0", VA = "0x1889A1EB0", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<HOVNFCAQSAB> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private STIGEBWIBRK fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private MTSONRTFUJP fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private VUJRLSATRJK sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x89A1030", Offset = "0x899FC30", VA = "0x1889A1030", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x89A1400", Offset = "0x89A0000", VA = "0x1889A1400", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x89A0F90", Offset = "0x899FB90", VA = "0x1889A0F90", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1694EF0", Offset = "0x1693AF0", VA = "0x181694EF0")]
		public FastLinesRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface HOVNFCAQSAB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool OJWUOMYBRKZ(CommandBuffer a, Camera b, [NotNull] UniversalAdditionalCameraData cameraData, bool c);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RHDQAJIYUDQ(Camera a, CommandBuffer b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class KYEFGCBKRQV
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static bool TJCMTUFFRFB;
	}
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
		private YOWITWXCPNE _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private PANEUKMDVCV _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x89A1AF0", Offset = "0x89A06F0", VA = "0x1889A1AF0", Slot = "11")]
		protected override void Dispose(bool isDisposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x89A1B60", Offset = "0x89A0760", VA = "0x1889A1B60")]
		private void GTLHSGRRYDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x89A1660", Offset = "0x89A0260", VA = "0x1889A1660", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1694EF0", Offset = "0x1693AF0", VA = "0x181694EF0")]
		public LightBinning()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class GVXBQVEXOLW
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x89A1600", Offset = "0x89A0200", VA = "0x1889A1600")]
		public static int FQRCEGHDBQS(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1B6A730", Offset = "0x1B69330", VA = "0x181B6A730")]
		public static int XSJCQASTTZW(bool a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct BinnableLight
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public LightType lightType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float approxIntensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float range;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float spotAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public float4 localToWorldC2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public float4 localToWorldC3;
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct LightInBin
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public ushort lightIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public float clusterImportance;
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[BurstCompile(FloatPrecision.Low, FloatMode.Fast)]
	public struct BinPerLightJob : IJobParallelFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[ReadOnly]
		public NativeArray<BinnableLight> lights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[ReadOnly]
		public float3 worldVolumeMinCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[ReadOnly]
		public float3 worldVolumeMaxCorner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[WriteOnly]
		public NativeParallelMultiHashMap<ushort, LightInBin>.ParallelWriter clusteredLightIndices;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x899FCA0", Offset = "0x899E8A0", VA = "0x18899FCA0", Slot = "4")]
		public void Execute(int lightIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x89A01E0", Offset = "0x899EDE0", VA = "0x1889A01E0")]
		private void HQIUPLFIPUD(uint3 a, uint3 b, ushort c, float3 d, float e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x89A0630", Offset = "0x899F230", VA = "0x1889A0630")]
		private void XRMDTAUBMGB(uint3 a, uint3 b, ushort c, float3 d, float3 e, float3 f, float g, float h, float i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x899FBB0", Offset = "0x899E7B0", VA = "0x18899FBB0")]
		private float3 DCXCITZEILK(uint3 a, float3 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x89A0610", Offset = "0x899F210", VA = "0x1889A0610")]
		private float OILWKMNYMVM(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x89A0550", Offset = "0x899F150", VA = "0x1889A0550")]
		private float HYDGTTXNFGN(float3 a, float3 b, float c, float d)
		{
			return default(float);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[BurstCompile(FloatPrecision.Standard, FloatMode.Fast)]
	public struct BinPerVoxelJob : IJobParallelForBatch
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[ReadOnly]
		public NativeParallelMultiHashMap<ushort, LightInBin> clusteredLightIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[ReadOnly]
		public uint lightCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[ReadOnly]
		public int headerSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[ReadOnly]
		public int voxelCapacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[WriteOnly]
		public NativeArray<uint> voxels;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public NativeArray<float> importances;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x89A0AE0", Offset = "0x899F6E0", VA = "0x1889A0AE0", Slot = "4")]
		public void Execute(int voxelStartIdx, int voxelBatchSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x89A0C80", Offset = "0x899F880", VA = "0x1889A0C80")]
		private void NZRGYXGLSAW(int a, ushort b, int c, LightInBin d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[BurstCompile]
	public struct CleanupBufferJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[WriteOnly]
		public NativeParallelMultiHashMap<ushort, LightInBin> clusteredLightIndices;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x89A0DF0", Offset = "0x899F9F0", VA = "0x1889A0DF0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class YOWITWXCPNE : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly bool HERZTALYSYC;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float ZZIZDBMCYCY = 179f;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int LFQZRQVVSLC = 32;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const int TFMNNZTQYBS = 221184;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private BinPerLightJob KNBAUFDBTOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private BinPerVoxelJob HMVGHFXXTMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CleanupBufferJob WLQGKQGDTWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private NativeParallelMultiHashMap<ushort, LightInBin> IDCZPQUVOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private THGMYIKYKAH IHWAPWNXYSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool RPZPIZMHQWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int NVHNGKNWSIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private NativeArray<BinnableLight> ALCZUCSAUWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private JobHandle HRVGVMAQJMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private JobHandle XNAUVMTBWSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool ZSWPQNYGJEH;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x89AAEC0", Offset = "0x89A9AC0", VA = "0x1889AAEC0")]
		public YOWITWXCPNE(RenderPassEvent a, ComputeShader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x89AAC70", Offset = "0x89A9870", VA = "0x1889AAC70")]
		private void RAHHLBTZFRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x89AA650", Offset = "0x89A9250", VA = "0x1889AA650")]
		public void DTFJEXDLYNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3C022E0", Offset = "0x3C00EE0", VA = "0x183C022E0")]
		public static void KVJBTCUGOCX<a>(NativeArray<a> a, int b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x89AA850", Offset = "0x89A9450", VA = "0x1889AA850")]
		public void LIQLALIIRDC(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x89AA080", Offset = "0x89A8C80", VA = "0x1889AA080")]
		private void AGENDAFRUGH(LightData a, NativeArray<BinnableLight> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x89AA400", Offset = "0x89A9000", VA = "0x1889AA400")]
		private void CUFXDTESTTT(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x89AACE0", Offset = "0x89A98E0", VA = "0x1889AACE0")]
		private void XHMAREPDKNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x89AAB70", Offset = "0x89A9770", VA = "0x1889AAB70")]
		private void PMGVCVCWAGZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x89AA830", Offset = "0x89A9430", VA = "0x1889AA830")]
		private void FYOKXOTBTHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x89AA3D0", Offset = "0x89A8FD0", VA = "0x1889AA3D0")]
		private void AHADSIDRIBZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x89AA730", Offset = "0x89A9330", VA = "0x1889AA730", Slot = "9")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x89AAB40", Offset = "0x89A9740", VA = "0x1889AAB40", Slot = "8")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void OnFinishCameraStackRendering(CommandBuffer cmd)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class PANEUKMDVCV : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const ushort JHNBVWYOLLT = 159;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const float ZZIZDBMCYCY = 179f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly THGMYIKYKAH IHWAPWNXYSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private int XDJKUKGCLMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private BinnableLight[] ALCZUCSAUWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private float3 KCOBPNXUHEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private float3 KVUNULDRYSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private uint MWRRZQCDQNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private int ZTTQPUBGUDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int SQGIDOYHPUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeArray<uint> YXSVMGLSPHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NativeArray<float> PUILMSAGCPQ;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x89A5110", Offset = "0x89A3D10", VA = "0x1889A5110")]
		public PANEUKMDVCV(RenderPassEvent a, ComputeShader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x89A3F60", Offset = "0x89A2B60", VA = "0x1889A3F60")]
		public void LIQLALIIRDC(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x89A41F0", Offset = "0x89A2DF0", VA = "0x1889A41F0")]
		private void QUBTSAOBCWJ(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x89A3920", Offset = "0x89A2520", VA = "0x1889A3920")]
		public void DTFJEXDLYNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x89A3460", Offset = "0x89A2060", VA = "0x1889A3460")]
		private void AGENDAFRUGH(LightData a, BinnableLight[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x89A4A20", Offset = "0x89A3620", VA = "0x1889A4A20")]
		private void TPUGXEQLTHJ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x89A37B0", Offset = "0x89A23B0", VA = "0x1889A37B0")]
		private void BDLLFERAUSN(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x89A38E0", Offset = "0x89A24E0", VA = "0x1889A38E0")]
		private ushort DGUBOMQPOQC(int a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x89A3A20", Offset = "0x89A2620", VA = "0x1889A3A20")]
		private void GCCZYTMNZYT(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x89A4400", Offset = "0x89A3000", VA = "0x1889A4400")]
		private void SIZHAJHFXBW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x89A3EA0", Offset = "0x89A2AA0", VA = "0x1889A3EA0")]
		private void JDOYOAOEALD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x89A3940", Offset = "0x89A2540", VA = "0x1889A3940", Slot = "9")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x89A41C0", Offset = "0x89A2DC0", VA = "0x1889A41C0", Slot = "8")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void OnFinishCameraStackRendering(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x89A4470", Offset = "0x89A3070", VA = "0x1889A4470")]
		private void TOMVEUXRQOG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x89A3A90", Offset = "0x89A2690", VA = "0x1889A3A90")]
		private void HQIUPLFIPUD(uint3 a, uint3 b, ushort c, float3 d, float e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x89A4BC0", Offset = "0x89A37C0", VA = "0x1889A4BC0")]
		private void XRMDTAUBMGB(uint3 a, uint3 b, ushort c, float3 d, float3 e, float3 f, float g, float h, float i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x89A4AD0", Offset = "0x89A36D0", VA = "0x1889A4AD0")]
		private void ULSRHJBXAOA(ushort a, uint b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x89A37E0", Offset = "0x89A23E0", VA = "0x1889A37E0")]
		private float3 DCXCITZEILK(uint3 a, float3 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x89A0610", Offset = "0x899F210", VA = "0x1889A0610")]
		private float OILWKMNYMVM(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x89A0550", Offset = "0x899F150", VA = "0x1889A0550")]
		private float HYDGTTXNFGN(float3 a, float3 b, float c, float d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x89A4030", Offset = "0x89A2C30", VA = "0x1889A4030")]
		private void NZRGYXGLSAW(int a, ushort b, int c, LightInBin d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class THGMYIKYKAH
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private static class FKUCVRJLLDM
		{
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly int YGMFBDZWEXN;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly int VDLCVWIMKSQ;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly int ACFSLTMUSGF;

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly int GQRQYCTKGXA;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly int BQXROOJVPLC;

			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public static readonly int RLCPJHHFVLR;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly int XWWLYROKQGR;
		}

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private const int ZMXQMHEJNOL = 4;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const int WAEFPMHBGIC = 2;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private const int UFPIIVLULRI = 3;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private const int UFUPGCFRVCR = 3;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private const int UFEUOHXZSUQ = 3;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private const int RRUYTNDNXUR = 4;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private const int XXUTDNOBEGM = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool ZVOIOACFHRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private ComputeBuffer OYGKZQTEUPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private RenderTexture RKLCGKZAYYI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int BPDRNKBLISR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int EXNXIRKUHXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int RLLXKCWVESR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int EJEUHYUHXVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int FWSXXMFAVRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private ComputeShader KEGPQBFFCTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int LACODHPXOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private int WMMZUPBUTJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float3 QNRCWDNMVIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float3 DURICAKFQWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private NativeArray<uint> WGFEGMIKXGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private NativeArray<float> MYVAALZBRKS;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NativeArray<uint> PEQXHRKCTKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xD217A0", Offset = "0xD203A0", VA = "0x180D217A0")]
			get
			{
				return default(NativeArray<uint>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public NativeArray<float> ESGKJLEDGCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xC1C890", Offset = "0xC1B490", VA = "0x180C1C890")]
			get
			{
				return default(NativeArray<float>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int FGUDEFQPZDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xB108E0", Offset = "0xB0F4E0", VA = "0x180B108E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int IGFOTJDJEMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA9F8F0", Offset = "0xA9E4F0", VA = "0x180A9F8F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ComputeShader XIGXTWIJMQJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x89A8780", Offset = "0x89A7380", VA = "0x1889A8780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x89A7C80", Offset = "0x89A6880", VA = "0x1889A7C80")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x89A7D70", Offset = "0x89A6970", VA = "0x1889A7D70")]
		public void KHRQPAVNNTM(CameraData a, LightData b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3A7F860", Offset = "0x3A7E460", VA = "0x183A7F860")]
		private void KVJBTCUGOCX<a>(NativeArray<a> a, int b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x89A8430", Offset = "0x89A7030", VA = "0x1889A8430")]
		public void MQKLQAIDYOV(CommandBuffer a, ScriptableRenderContext b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x89A7AA0", Offset = "0x89A66A0", VA = "0x1889A7AA0")]
		private static void BCSVDOFXLED(int a, CommandBuffer b, RenderBuffer c, ComputeBuffer d, ComputeShader e, int f, int g, int h, int i, int j, int k, int l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x89A8090", Offset = "0x89A6C90", VA = "0x1889A8090")]
		public void KQUPHGRFBZH(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x89A78C0", Offset = "0x89A64C0", VA = "0x1889A78C0")]
		private RenderTexture AKNKHPHHZAY(RenderTexture a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x89A83B0", Offset = "0x89A6FB0", VA = "0x1889A83B0")]
		public void LGDDJUMOBGW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x89A8810", Offset = "0x89A7410", VA = "0x1889A8810")]
		public void YJNLBAJSNAA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x89A8AA0", Offset = "0x89A76A0", VA = "0x1889A8AA0")]
		public THGMYIKYKAH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Mobile Fade")]
	public class MobileFadeRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public struct Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public float fadeEffect;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public float monochromeReplacementEffect;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private class ONFPGIUPJFE : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string DAPPCBYOJFK;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private static readonly int MBIMHLGHDJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private Material ZGMPIVFIOJY;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x89A3370", Offset = "0x89A1F70", VA = "0x1889A3370")]
			public ONFPGIUPJFE(RenderPassEvent a, Material b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x89A2F90", Offset = "0x89A1B90", VA = "0x1889A2F90", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static Settings CurrentSettings;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private const float MONOCHROME_EFFECT_POWER = 0.667f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private ONFPGIUPJFE m_MobileFadePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Reload("Shaders/MobileFade.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool IWNDNSVWFPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x89A26E0", Offset = "0x89A12E0", VA = "0x1889A26E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float HCADSUMTUXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x89A2690", Offset = "0x89A1290", VA = "0x1889A2690")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x89A24E0", Offset = "0x89A10E0", VA = "0x1889A24E0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x89A2400", Offset = "0x89A1000", VA = "0x1889A2400", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1694EF0", Offset = "0x1693AF0", VA = "0x181694EF0")]
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
		public struct Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public float vignettePowerNormalized;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public Color vignetteColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public Mesh vignetteMesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AnimationCurve vignetteIntensityCurve;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public sealed class OAPAXYAQNZE : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private static readonly string DAPPCBYOJFK;

			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly int ZXEKEHVAHUM;

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private static readonly int DQFOBBNYAFU;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private Material ZGMPIVFIOJY;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x89A2EA0", Offset = "0x89A1AA0", VA = "0x1889A2EA0")]
			public OAPAXYAQNZE(RenderPassEvent a, Material b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x89A2D40", Offset = "0x89A1940", VA = "0x1889A2D40", Slot = "5")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void OnCameraSetup(CommandBuffer cmd, RenderingData renderingData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x89A2B40", Offset = "0x89A1740", VA = "0x1889A2B40", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static Settings CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private OAPAXYAQNZE m_MobileVignettePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Reload("Shaders/MobileVignette.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static bool IWNDNSVWFPN
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x89A2A20", Offset = "0x89A1620", VA = "0x1889A2A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x89A2870", Offset = "0x89A1470", VA = "0x1889A2870", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x89A2740", Offset = "0x89A1340", VA = "0x1889A2740", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1694EF0", Offset = "0x1693AF0", VA = "0x181694EF0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string UKHIIEJVFVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool WBGIRMKAZDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer cmd, ScriptableRenderContext context, RenderingData renderingData);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA96140", Offset = "0xA94D40", VA = "0x180A96140")]
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
		private class RMGSDGMPQPS : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private bool ODNUYHGEEXV;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private readonly List<PerCameraRenderEffect> JPIOOUDYKGJ;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private static readonly List<PerCameraRenderEffect> QWXHPJMTXOV;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x89A7320", Offset = "0x89A5F20", VA = "0x1889A7320")]
			public RMGSDGMPQPS(RenderPassEvent a, bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x89A6EC0", Offset = "0x89A5AC0", VA = "0x1889A6EC0")]
			public bool IKXFAXRILZS(CameraData a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x89A6CF0", Offset = "0x89A58F0", VA = "0x1889A6CF0", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x89A71B0", Offset = "0x89A5DB0", VA = "0x1889A71B0")]
			private void JYOUOZEQRQD(PerCameraRenderEffect a, ScriptableRenderContext b, RenderingData c)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private RMGSDGMPQPS m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private RMGSDGMPQPS m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x89A5260", Offset = "0x89A3E60", VA = "0x1889A5260", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x89A51D0", Offset = "0x89A3DD0", VA = "0x1889A51D0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1694EF0", Offset = "0x1693AF0", VA = "0x181694EF0")]
		public PerCameraRenderEffectsRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[DisallowMultipleRendererFeature(null)]
	[Tooltip("RR Persistent Buffer Effects")]
	public class PersistentBufferEffectsRenderer : ScriptableRendererFeature
	{
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private static readonly List<LOWLCPJBCPZ> passes;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private const RenderPassEvent RENDER_PASS_EVENT = RenderPassEvent.BeforeRenderingShadows;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x89A55A0", Offset = "0x89A41A0", VA = "0x1889A55A0")]
		public static void EnqueuePassForNextRender(LOWLCPJBCPZ pass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x89A54A0", Offset = "0x89A40A0", VA = "0x1889A54A0", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x89A5300", Offset = "0x89A3F00", VA = "0x1889A5300")]
		private static bool AVFHVGRZTNF([In] RenderingData renderingData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x89A5380", Offset = "0x89A3F80", VA = "0x1889A5380", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x89A56E0", Offset = "0x89A42E0", VA = "0x1889A56E0", Slot = "8")]
		public override void SetupRenderPasses(ScriptableRenderer renderer, [In] RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1694EF0", Offset = "0x1693AF0", VA = "0x181694EF0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public abstract class LOWLCPJBCPZ : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "11")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "12")]
		public virtual void IKXFAXRILZS(ScriptableRenderer a, [In] RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x89A1610", Offset = "0x89A0210", VA = "0x1889A1610")]
		protected LOWLCPJBCPZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class XQQZXUBXRJR
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly float3 TFUQNDXWQWZ;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly uint3 GZBLGMRFGOY;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private static readonly uint3 UIZUWPFXQXJ;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly float3 ZZJZVLXZHTL;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static readonly float3 WERGKZHVJKB;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x89A9F30", Offset = "0x89A8B30", VA = "0x1889A9F30")]
		public static uint WGRWVKPNWJL(uint a, uint b, uint c)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x89A9AC0", Offset = "0x89A86C0", VA = "0x1889A9AC0")]
		public static uint3 QDBBALPWHEF(float3 a, float3 b, float3 c)
		{
			return default(uint3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x89A9CC0", Offset = "0x89A88C0", VA = "0x1889A9CC0")]
		public static void VZVMOYYQNZP(float3 a, float3 b, float3 c, float d, [Out] uint3 e, [Out] uint3 f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x89A95F0", Offset = "0x89A81F0", VA = "0x1889A95F0")]
		public static void MYHPKWUMMVD(float3 a, float3 b, float c, float d, [Out] float3 e, [Out] float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x89A9450", Offset = "0x89A8050", VA = "0x1889A9450")]
		private static float3 DIUXLTBOEZU(float3 a, float3 b, float3 c, float3 d)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class MUQBFNDSBOV
	{
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private static readonly Log KLHXTMLHWMV;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly Log BTGSVXMFKNI;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly Log EDFQFICBYYY;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public static readonly Log IZCIRPQPXNJ;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public static readonly Log KPLVYYPXHKE;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class UOYDEMPBMZV
	{
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private static Mesh BIMOBMYXLOY;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x89A9320", Offset = "0x89A7F20", VA = "0x1889A9320")]
		public static Mesh NWORBONUNRK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x89A8E80", Offset = "0x89A7A80", VA = "0x1889A8E80")]
		public static Matrix4x4 HDMAVYWEQEN(Camera a, bool b = false, bool c = false)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x89A8AC0", Offset = "0x89A76C0", VA = "0x1889A8AC0")]
		private static Mesh DDKERDFKFXF()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3473831815
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x89AAF90", Offset = "0x89A9B90", VA = "0x1889AAF90")]
	public static void ERMADPSHGQX()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x89AB030", Offset = "0x89A9C30", VA = "0x1889AB030")]
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
