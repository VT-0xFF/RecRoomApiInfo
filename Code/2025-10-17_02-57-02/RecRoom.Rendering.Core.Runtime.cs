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
		[Cpp2IlInjected.Address(RVA = "0x8CE1F20", Offset = "0x8CE0520", VA = "0x188CE1F20", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		public interface FKAGRMJLQOD
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void LAIGNUUQHPV(ScriptableRenderContext a, List<Camera> b);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface ZVWXNHGUAAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void LAIGNUUQHPV(ScriptableRenderContext a, RenderingData b);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class QUBXASGUMQM : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8CE4A40", Offset = "0x8CE3040", VA = "0x188CE4A40")]
			public QUBXASGUMQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8CE49E0", Offset = "0x8CE2FE0", VA = "0x188CE49E0", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private QUBXASGUMQM _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<FKAGRMJLQOD> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<FKAGRMJLQOD> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<ZVWXNHGUAAR> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<ZVWXNHGUAAR> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3850", Offset = "0x8CE1E50", VA = "0x188CE3850")]
		public static void AddTask(TaskType taskType, FKAGRMJLQOD contextTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8CE4740", Offset = "0x8CE2D40", VA = "0x188CE4740")]
		public static void RemoveTask(TaskType taskType, FKAGRMJLQOD contextTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3710", Offset = "0x8CE1D10", VA = "0x188CE3710")]
		public static void AddTask(TaskType taskType, ZVWXNHGUAAR cameraTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8CE4680", Offset = "0x8CE2C80", VA = "0x188CE4680")]
		public static void RemoveTask(TaskType taskType, ZVWXNHGUAAR cameraTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3A00", Offset = "0x8CE2000", VA = "0x188CE3A00", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3670", Offset = "0x8CE1C70", VA = "0x188CE3670", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3BF0", Offset = "0x8CE21F0", VA = "0x188CE3BF0", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3CF0", Offset = "0x8CE22F0", VA = "0x188CE3CF0")]
		private static void INXZMLFPRUQ(ScriptableRenderContext a, List<Camera> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3990", Offset = "0x8CE1F90", VA = "0x188CE3990")]
		private static void CKNKQLTTRRO(ScriptableRenderContext a, List<Camera> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8CE41D0", Offset = "0x8CE27D0", VA = "0x188CE41D0")]
		private static void MJXXHWITCKI(ScriptableRenderContext a, RenderingData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x19D7100", Offset = "0x19D5700", VA = "0x1819D7100")]
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
		private class OFEJGTSTGXX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool CDCCZYNFKYY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<LDTLXEZBCMI> LGRDDMSEGIJ;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8CE2EF0", Offset = "0x8CE14F0", VA = "0x188CE2EF0")]
			public OFEJGTSTGXX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class CSRQIXEJBQN : PreRenderManager.ZVWXNHGUAAR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string OJSQCVUSKEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler FGXCUDNUTXB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly OFEJGTSTGXX DBZKYNDHBAA;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8CDF450", Offset = "0x8CDDA50", VA = "0x188CDF450")]
			public CSRQIXEJBQN(OFEJGTSTGXX a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8CDF040", Offset = "0x8CDD640", VA = "0x188CDF040", Slot = "4")]
			public void LAIGNUUQHPV(ScriptableRenderContext a, RenderingData b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class LWRXAQGCQUQ : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string EVBTJVAPTCT;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly OFEJGTSTGXX OQPLKFUTDBX;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8CE1660", Offset = "0x8CDFC60", VA = "0x188CE1660")]
			public LWRXAQGCQUQ(RenderPassEvent a, OFEJGTSTGXX b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8CE1340", Offset = "0x8CDF940", VA = "0x188CE1340", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<LDTLXEZBCMI> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private CSRQIXEJBQN fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private LWRXAQGCQUQ fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private OFEJGTSTGXX sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8CDFCC0", Offset = "0x8CDE2C0", VA = "0x188CDFCC0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8CE0090", Offset = "0x8CDE690", VA = "0x188CE0090", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8CDFC30", Offset = "0x8CDE230", VA = "0x188CDFC30", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x19D7100", Offset = "0x19D5700", VA = "0x1819D7100")]
		public FastLinesRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface LDTLXEZBCMI
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HVOEUVNIAGY(CommandBuffer a, Camera b, [NotNull] UniversalAdditionalCameraData cameraData, bool c);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void QUQBQTTUFKZ(Camera a, CommandBuffer b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class VJGLQZGRIQI
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static bool KDORLUKRXKA;
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
		private SEUPGYKVNFF _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private CAWWIPUQLFC _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8CE1BE0", Offset = "0x8CE01E0", VA = "0x188CE1BE0", Slot = "11")]
		protected override void Dispose(bool isDisposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8CE1C50", Offset = "0x8CE0250", VA = "0x188CE1C50")]
		private void IARJXLNRQRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8CE1750", Offset = "0x8CDFD50", VA = "0x188CE1750", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x19D7100", Offset = "0x19D5700", VA = "0x1819D7100")]
		public LightBinning()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class PXFVXESNFLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8CE2F70", Offset = "0x8CE1570", VA = "0x188CE2F70")]
		public static int WJLKJOSCPBZ(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1E825D0", Offset = "0x1E80BD0", VA = "0x181E825D0")]
		public static int IAIMRINEFBP(bool a)
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
		[Cpp2IlInjected.Address(RVA = "0x8CDC0B0", Offset = "0x8CDA6B0", VA = "0x188CDC0B0", Slot = "4")]
		public void Execute(int lightIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8CDC7A0", Offset = "0x8CDADA0", VA = "0x188CDC7A0")]
		private void PLGMTLMEWCA(uint3 a, uint3 b, ushort c, float3 d, float e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8CDCB10", Offset = "0x8CDB110", VA = "0x188CDCB10")]
		private void RWHEFPLLHMA(uint3 a, uint3 b, ushort c, float3 d, float3 e, float3 f, float g, float h, float i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8CDC6B0", Offset = "0x8CDACB0", VA = "0x188CDC6B0")]
		private float3 PCYSZPNVAQH(uint3 a, float3 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8CDC090", Offset = "0x8CDA690", VA = "0x188CDC090")]
		private float CXTFXKRFNVF(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8CDC5F0", Offset = "0x8CDABF0", VA = "0x188CDC5F0")]
		private float GGMMVADKRLE(float3 a, float3 b, float c, float d)
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
		[Cpp2IlInjected.Address(RVA = "0x8CDCFC0", Offset = "0x8CDB5C0", VA = "0x188CDCFC0", Slot = "4")]
		public void Execute(int voxelStartIdx, int voxelBatchSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8CDD160", Offset = "0x8CDB760", VA = "0x188CDD160")]
		private void LUHXQUYRVVH(int a, ushort b, int c, LightInBin d)
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
		[Cpp2IlInjected.Address(RVA = "0x8CDF510", Offset = "0x8CDDB10", VA = "0x188CDF510", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class SEUPGYKVNFF : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly bool XDUTXOXRUHV;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float HAARVRZKSUL = 179f;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int ZEKSAVCLKLH = 32;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const int HRZWBWFHFRB = 221184;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private BinPerLightJob OXBAOVCPKWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private BinPerVoxelJob SIBEXIAXRJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CleanupBufferJob DTKIVVUZQXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private NativeParallelMultiHashMap<ushort, LightInBin> ROOMCROKNBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private RICROMFJEJC JGYJCPVOBOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool XFBIPGYRUSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int TDFXLWXZDNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private NativeArray<BinnableLight> EMTZKXIWVKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private JobHandle ZTVRBKAYBGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private JobHandle HBNDVWZFVWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool APWZDNGXGYK;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6EE0", Offset = "0x8CE54E0", VA = "0x188CE6EE0")]
		public SEUPGYKVNFF(RenderPassEvent a, ComputeShader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8CE66F0", Offset = "0x8CE4CF0", VA = "0x188CE66F0")]
		private void PFWBHRSPCRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6320", Offset = "0x8CE4920", VA = "0x188CE6320")]
		public void CleanUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3D18BC0", Offset = "0x3D171C0", VA = "0x183D18BC0")]
		public static void VZZEVRVPFFY<a>(NativeArray<a> a, int b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6BB0", Offset = "0x8CE51B0", VA = "0x188CE6BB0")]
		public void YWQZLUYUNGB(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6760", Offset = "0x8CE4D60", VA = "0x188CE6760")]
		private void TCNZGXRXQVG(LightData a, NativeArray<BinnableLight> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8CE60D0", Offset = "0x8CE46D0", VA = "0x188CE60D0")]
		private void BKJLCWGFNAC(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6560", Offset = "0x8CE4B60", VA = "0x188CE6560")]
		private void PBLSELAAPVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6AB0", Offset = "0x8CE50B0", VA = "0x188CE6AB0")]
		private void XUNRJXQWSEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8CE60B0", Offset = "0x8CE46B0", VA = "0x188CE60B0")]
		private void ADLHQHVOPOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6500", Offset = "0x8CE4B00", VA = "0x188CE6500")]
		private void LMUBTSTRNGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6400", Offset = "0x8CE4A00", VA = "0x188CE6400", Slot = "9")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6530", Offset = "0x8CE4B30", VA = "0x188CE6530", Slot = "8")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void OnFinishCameraStackRendering(CommandBuffer cmd)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class CAWWIPUQLFC : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const ushort EPXQZDHXPPO = 159;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const float HAARVRZKSUL = 179f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly RICROMFJEJC JGYJCPVOBOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private int RQUSFRHSXXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private BinnableLight[] EMTZKXIWVKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private float3 VGZUGSQRGDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private float3 GXPIYGEWAWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private uint IVZLEHPZTGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private int IRYNBZXDTGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int DPDLQSCXLTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeArray<uint> ALTBSCVMNWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NativeArray<float> WZKYCHALYCL;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8CDEF80", Offset = "0x8CDD580", VA = "0x188CDEF80")]
		public CAWWIPUQLFC(RenderPassEvent a, ComputeShader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8CDEEB0", Offset = "0x8CDD4B0", VA = "0x188CDEEB0")]
		public void YWQZLUYUNGB(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8CDD530", Offset = "0x8CDBB30", VA = "0x188CDD530")]
		private void JEMEEERSVWE(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8CDD3C0", Offset = "0x8CDB9C0", VA = "0x188CDD3C0")]
		public void CleanUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8CDEA60", Offset = "0x8CDD060", VA = "0x188CDEA60")]
		private void TCNZGXRXQVG(LightData a, BinnableLight[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8CDDEB0", Offset = "0x8CDC4B0", VA = "0x188CDDEB0")]
		private void MYPIGLDOZZI(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8CDD740", Offset = "0x8CDBD40", VA = "0x188CDD740")]
		private void JHXOGTQWDFU(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8CDEE70", Offset = "0x8CDD470", VA = "0x188CDEE70")]
		private ushort YUNXYHMMFIR(int a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8CDE4A0", Offset = "0x8CDCAA0", VA = "0x188CDE4A0")]
		private void QLMOQITXZIC(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8CDD4C0", Offset = "0x8CDBAC0", VA = "0x188CDD4C0")]
		private void IJCEHZCFAIB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8CDEDB0", Offset = "0x8CDD3B0", VA = "0x188CDEDB0")]
		private void UGFMNBYUQOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8CDD3E0", Offset = "0x8CDB9E0", VA = "0x188CDD3E0", Slot = "9")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8CDDF60", Offset = "0x8CDC560", VA = "0x188CDDF60", Slot = "8")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void OnFinishCameraStackRendering(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8CDD770", Offset = "0x8CDBD70", VA = "0x188CDD770")]
		private void LHNUABTNZMV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8CDE090", Offset = "0x8CDC690", VA = "0x188CDE090")]
		private void PLGMTLMEWCA(uint3 a, uint3 b, ushort c, float3 d, float e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8CDE510", Offset = "0x8CDCB10", VA = "0x188CDE510")]
		private void RWHEFPLLHMA(uint3 a, uint3 b, ushort c, float3 d, float3 e, float3 f, float g, float h, float i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8CDD2D0", Offset = "0x8CDB8D0", VA = "0x188CDD2D0")]
		private void BIUZNUTBJRZ(ushort a, uint b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8CDDF90", Offset = "0x8CDC590", VA = "0x188CDDF90")]
		private float3 PCYSZPNVAQH(uint3 a, float3 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8CDC090", Offset = "0x8CDA690", VA = "0x188CDC090")]
		private float CXTFXKRFNVF(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8CDC5F0", Offset = "0x8CDABF0", VA = "0x188CDC5F0")]
		private float GGMMVADKRLE(float3 a, float3 b, float c, float d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8CDDD20", Offset = "0x8CDC320", VA = "0x188CDDD20")]
		private void LUHXQUYRVVH(int a, ushort b, int c, LightInBin d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class RICROMFJEJC
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private static class VZUYWAYXCQJ
		{
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly int PQQXAEUYGXA;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly int IPTMGCMODUL;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly int XSTOWQKDONK;

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly int VFZPLHSSDWD;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly int BMALCGFYQXR;

			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public static readonly int CMQUHEHDMNK;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly int GAJETPCDARW;
		}

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private const int DCEISROJAIE = 4;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const int TLXADAITUSL = 2;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private const int PUOLFYMJOEV = 3;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private const int PUJEIRSMETM = 3;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private const int PUDXLKYOVID = 3;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private const int GWPKTTIWYFS = 4;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private const int UXCDZSKLKHB = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool MOOOLVHVWWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private ComputeBuffer NHELNUJCISJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private RenderTexture RDSOKCVDYRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int TJTXHZOPSPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int TZATHXGSBTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int HBQWOGOZARO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int JJOQDZMUVSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int VRLYVDLQDUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private ComputeShader SECEFVAUPFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int GKVZNOMASVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private int NPXUPRSOCSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float3 TILWYGPLCTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float3 DLKYYDPZNJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private NativeArray<uint> ZWYXHHVUBXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private NativeArray<float> QQOQHUHMGDB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NativeArray<uint> VMXQTGXCOHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x1082D10", Offset = "0x1081310", VA = "0x181082D10")]
			get
			{
				return default(NativeArray<uint>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public NativeArray<float> EHBMOKGKCPU
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xFA0490", Offset = "0xF9EA90", VA = "0x180FA0490")]
			get
			{
				return default(NativeArray<float>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int MICBSFIGDHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xC531C0", Offset = "0xC517C0", VA = "0x180C531C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int PUIVXTJHYLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAA7700", Offset = "0xAA5D00", VA = "0x180AA7700")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ComputeShader CWARTSHKTIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8CE5880", Offset = "0x8CE3E80", VA = "0x188CE5880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8CE5480", Offset = "0x8CE3A80", VA = "0x188CE5480")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8CE5570", Offset = "0x8CE3B70", VA = "0x188CE5570")]
		public void EVEACALYHKL(CameraData a, LightData b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3C5BE10", Offset = "0x3C5A410", VA = "0x183C5BE10")]
		private void VZZEVRVPFFY<a>(NativeArray<a> a, int b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8CE4ED0", Offset = "0x8CE34D0", VA = "0x188CE4ED0")]
		public void AASZYKXZQNE(CommandBuffer a, ScriptableRenderContext b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8CE5220", Offset = "0x8CE3820", VA = "0x188CE5220")]
		private static void ALXLKFHTDSQ(int a, CommandBuffer b, RenderBuffer c, ComputeBuffer d, ComputeShader e, int f, int g, int h, int i, int j, int k, int l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8CE5910", Offset = "0x8CE3F10", VA = "0x188CE5910")]
		public void QNQLNMWHFHQ(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8CE5EB0", Offset = "0x8CE44B0", VA = "0x188CE5EB0")]
		private RenderTexture VLYVONKUYYR(RenderTexture a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8CE5400", Offset = "0x8CE3A00", VA = "0x188CE5400")]
		public void DPAJWYAOZNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8CE5C20", Offset = "0x8CE4220", VA = "0x188CE5C20")]
		public void RWAXLIQMUQZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8CE6090", Offset = "0x8CE4690", VA = "0x188CE6090")]
		public RICROMFJEJC()
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
		private class KVAAWWYYBVX : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string LNNDBESLTMR;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private static readonly int NSSBNGAFKGS;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private Material KOWJSYQMLFL;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8CE1250", Offset = "0x8CDF850", VA = "0x188CE1250")]
			public KVAAWWYYBVX(RenderPassEvent a, Material b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8CE0E80", Offset = "0x8CDF480", VA = "0x188CE0E80", Slot = "9")]
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
		private KVAAWWYYBVX m_MobileFadePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Reload("Shaders/MobileFade.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool OGQHAGSYZOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8CE2280", Offset = "0x8CE0880", VA = "0x188CE2280")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float QRDTHNWZMMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8CE2230", Offset = "0x8CE0830", VA = "0x188CE2230")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8CE2080", Offset = "0x8CE0680", VA = "0x188CE2080", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8CE1FA0", Offset = "0x8CE05A0", VA = "0x188CE1FA0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x19D7100", Offset = "0x19D5700", VA = "0x1819D7100")]
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
		public sealed class RBCENRWMJKB : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private static readonly string LNNDBESLTMR;

			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly int TAQIYKSXCLZ;

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private static readonly int SXXVYQYHHSV;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private Material KOWJSYQMLFL;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8CE4DE0", Offset = "0x8CE33E0", VA = "0x188CE4DE0")]
			public RBCENRWMJKB(RenderPassEvent a, Material b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8CE4C90", Offset = "0x8CE3290", VA = "0x188CE4C90", Slot = "5")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void OnCameraSetup(CommandBuffer cmd, RenderingData renderingData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8CE4AA0", Offset = "0x8CE30A0", VA = "0x188CE4AA0", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static Settings CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private RBCENRWMJKB m_MobileVignettePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Reload("Shaders/MobileVignette.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static bool OGQHAGSYZOW
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8CE25A0", Offset = "0x8CE0BA0", VA = "0x188CE25A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8CE23F0", Offset = "0x8CE09F0", VA = "0x188CE23F0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8CE22D0", Offset = "0x8CE08D0", VA = "0x188CE22D0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x19D7100", Offset = "0x19D5700", VA = "0x1819D7100")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string VNHBBCWTHCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool IAFQNLIGJFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer cmd, ScriptableRenderContext context, RenderingData renderingData);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAA6840", Offset = "0xAA4E40", VA = "0x180AA6840")]
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
		private class DEQFUPYDNZB : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private bool VNCRPTLDVFQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private readonly List<PerCameraRenderEffect> MUDBPIXOZXO;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private static readonly List<PerCameraRenderEffect> QFAHCNWUSYA;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8CDFB60", Offset = "0x8CDE160", VA = "0x188CDFB60")]
			public DEQFUPYDNZB(RenderPassEvent a, bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8CDF550", Offset = "0x8CDDB50", VA = "0x188CDF550")]
			public bool BDDXPDNKKCZ(CameraData a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8CDF830", Offset = "0x8CDDE30", VA = "0x188CDF830", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8CDFA00", Offset = "0x8CDE000", VA = "0x188CDFA00")]
			private void VXNIIPTRWWG(PerCameraRenderEffect a, ScriptableRenderContext b, RenderingData c)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private DEQFUPYDNZB m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private DEQFUPYDNZB m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3010", Offset = "0x8CE1610", VA = "0x188CE3010", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8CE2F80", Offset = "0x8CE1580", VA = "0x188CE2F80", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x19D7100", Offset = "0x19D5700", VA = "0x1819D7100")]
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
		private static readonly List<YTQZLWROKWS> passes;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private const RenderPassEvent RENDER_PASS_EVENT = RenderPassEvent.BeforeRenderingShadows;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8CE32B0", Offset = "0x8CE18B0", VA = "0x188CE32B0")]
		public static void EnqueuePassForNextRender(YTQZLWROKWS pass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8CE31C0", Offset = "0x8CE17C0", VA = "0x188CE31C0", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8CE33E0", Offset = "0x8CE19E0", VA = "0x188CE33E0")]
		private static bool RSKIVOFJCIS([In] RenderingData renderingData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8CE30B0", Offset = "0x8CE16B0", VA = "0x188CE30B0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8CE3460", Offset = "0x8CE1A60", VA = "0x188CE3460", Slot = "8")]
		public override void SetupRenderPasses(ScriptableRenderer renderer, [In] RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x19D7100", Offset = "0x19D5700", VA = "0x1819D7100")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public abstract class YTQZLWROKWS : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "11")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "12")]
		public virtual void BDDXPDNKKCZ(ScriptableRenderer a, [In] RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8CE7210", Offset = "0x8CE5810", VA = "0x188CE7210")]
		protected YTQZLWROKWS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class GUWPTVCWOSW
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly float3 KYOQXSTSMTI;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly uint3 MGLXXHQUTCT;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private static readonly uint3 SJKVICWLPAE;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly float3 ZBXJQMZEIFG;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static readonly float3 KNFFNGNOQSO;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8CE0B50", Offset = "0x8CDF150", VA = "0x188CE0B50")]
		public static uint ZHQCYURUNAY(uint a, uint b, uint c)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8CE0B60", Offset = "0x8CDF160", VA = "0x188CE0B60")]
		public static uint3 ZJKSKMOKYAW(float3 a, float3 b, float3 c)
		{
			return default(uint3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8CE08E0", Offset = "0x8CDEEE0", VA = "0x188CE08E0")]
		public static void RBPOFSJBIUQ(float3 a, float3 b, float3 c, float d, [Out] uint3 e, [Out] uint3 f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8CE0410", Offset = "0x8CDEA10", VA = "0x188CE0410")]
		public static void LVQCCXMWOSO(float3 a, float3 b, float c, float d, [Out] float3 e, [Out] float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8CE0270", Offset = "0x8CDE870", VA = "0x188CE0270")]
		private static float3 HCDVOLTGSJV(float3 a, float3 b, float3 c, float3 d)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class WEZFYQOORTG
	{
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private static readonly Log BIUGNMOSEIQ;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly Log UOSXXEYUWLX;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly Log ZKXORFIFRIZ;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public static readonly Log WWXUFDDXGJG;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public static readonly Log PHOASOTGLVP;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class NNECMMAEFKQ
	{
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private static Mesh SDEUFGJYCOB;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8CE25F0", Offset = "0x8CE0BF0", VA = "0x188CE25F0")]
		public static Mesh KPGWPIJJIEZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8CE2690", Offset = "0x8CE0C90", VA = "0x188CE2690")]
		public static Matrix4x4 LINSGZUYTZM(Camera a, bool b = false, bool c = false)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8CE2B30", Offset = "0x8CE1130", VA = "0x188CE2B30")]
		private static Mesh NCAVJWGEICQ()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__889033964
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8CE7270", Offset = "0x8CE5870", VA = "0x188CE7270")]
	public static void FCUCTWCFTNU()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8CE7260", Offset = "0x8CE5860", VA = "0x188CE7260")]
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
