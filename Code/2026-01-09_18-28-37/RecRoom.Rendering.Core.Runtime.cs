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
		[Cpp2IlInjected.Address(RVA = "0x89DF460", Offset = "0x89DE860", VA = "0x1889DF460", Slot = "4")]
		public override void MKOAUOREKWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		public interface SMKVGJKMXOF
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void CDXZOOQETHP(ScriptableRenderContext a, List<Camera> b);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface DBCYNHIYKOT
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void CDXZOOQETHP(ScriptableRenderContext a, RenderingData b);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class LADYFPJEUPM : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x89DEBB0", Offset = "0x89DDFB0", VA = "0x1889DEBB0")]
			public LADYFPJEUPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x89DEB50", Offset = "0x89DDF50", VA = "0x1889DEB50", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private LADYFPJEUPM _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<SMKVGJKMXOF> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<SMKVGJKMXOF> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<DBCYNHIYKOT> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<DBCYNHIYKOT> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x89E1B10", Offset = "0x89E0F10", VA = "0x1889E1B10")]
		public static void AddTask(TaskType taskType, SMKVGJKMXOF contextTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x89E2AD0", Offset = "0x89E1ED0", VA = "0x1889E2AD0")]
		public static void RemoveTask(TaskType taskType, SMKVGJKMXOF contextTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x89E1C50", Offset = "0x89E1050", VA = "0x1889E1C50")]
		public static void AddTask(TaskType taskType, DBCYNHIYKOT cameraTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x89E2A10", Offset = "0x89E1E10", VA = "0x1889E2A10")]
		public static void RemoveTask(TaskType taskType, DBCYNHIYKOT cameraTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89E1D90", Offset = "0x89E1190", VA = "0x1889E1D90", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89E1A70", Offset = "0x89E0E70", VA = "0x1889E1A70", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x89E1F80", Offset = "0x89E1380", VA = "0x1889E1F80", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x89E2530", Offset = "0x89E1930", VA = "0x1889E2530")]
		private static void QCQITGDOSKC(ScriptableRenderContext a, List<Camera> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x89E1A00", Offset = "0x89E0E00", VA = "0x1889E1A00")]
		private static void AGNWHGBMMLY(ScriptableRenderContext a, List<Camera> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x89E2080", Offset = "0x89E1480", VA = "0x1889E2080")]
		private static void IKTSHGTSBUW(ScriptableRenderContext a, RenderingData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x16C14F0", Offset = "0x16C08F0", VA = "0x1816C14F0")]
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
		private class LSHBMDUTUBJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool KSIKRXKWDOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<LDEOIZTSWZU> FLPXTJIRUTN;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x89DEC10", Offset = "0x89DE010", VA = "0x1889DEC10")]
			public LSHBMDUTUBJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class SLDUCJDXSZV : PreRenderManager.DBCYNHIYKOT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string NMJIXOGWFZA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler CILUHCSXCMZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly LSHBMDUTUBJ WMLXHLNZYFE;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x89E3CF0", Offset = "0x89E30F0", VA = "0x1889E3CF0")]
			public SLDUCJDXSZV(LSHBMDUTUBJ a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x89E38D0", Offset = "0x89E2CD0", VA = "0x1889E38D0", Slot = "4")]
			public void CDXZOOQETHP(ScriptableRenderContext a, RenderingData b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class GFEOEYMQBBM : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string OJAJQEPVQYF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly LSHBMDUTUBJ OJFMJSUREFF;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x89DC0E0", Offset = "0x89DB4E0", VA = "0x1889DC0E0")]
			public GFEOEYMQBBM(RenderPassEvent a, LSHBMDUTUBJ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x89DBDC0", Offset = "0x89DB1C0", VA = "0x1889DBDC0", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<LDEOIZTSWZU> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private SLDUCJDXSZV fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private GFEOEYMQBBM fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private LSHBMDUTUBJ sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x89DB810", Offset = "0x89DAC10", VA = "0x1889DB810", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x89DBBE0", Offset = "0x89DAFE0", VA = "0x1889DBBE0", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x89DB780", Offset = "0x89DAB80", VA = "0x1889DB780", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x16C14F0", Offset = "0x16C08F0", VA = "0x1816C14F0")]
		public FastLinesRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface LDEOIZTSWZU
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool VGTBBNXEPNY(CommandBuffer a, Camera b, [NotNull] UniversalAdditionalCameraData cameraData, bool c);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void YWEVMIFIRLV(Camera a, CommandBuffer b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class BHJRZFCAWZA
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static bool HQBMOECBZFA;
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
		private YLHDXIJBJLD _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private JOAJQIYJTPE _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x89DF120", Offset = "0x89DE520", VA = "0x1889DF120", Slot = "11")]
		protected override void Dispose(bool isDisposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x89DF190", Offset = "0x89DE590", VA = "0x1889DF190")]
		private void GFQEMXBUQMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x89DEC90", Offset = "0x89DE090", VA = "0x1889DEC90", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x16C14F0", Offset = "0x16C08F0", VA = "0x1816C14F0")]
		public LightBinning()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class CJRASXWDVWB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x89DB610", Offset = "0x89DAA10", VA = "0x1889DB610")]
		public static int STGIYKREVSV(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1B8DD10", Offset = "0x1B8D110", VA = "0x181B8DD10")]
		public static int BTKIYBNYBXN(bool a)
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
		[Cpp2IlInjected.Address(RVA = "0x89DA4B0", Offset = "0x89D98B0", VA = "0x1889DA4B0", Slot = "4")]
		public void Execute(int lightIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x89DA9F0", Offset = "0x89D9DF0", VA = "0x1889DA9F0")]
		private void LIAWHOJOTTM(uint3 a, uint3 b, ushort c, float3 d, float e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x89DAD60", Offset = "0x89DA160", VA = "0x1889DAD60")]
		private void LRGKXBPHOIC(uint3 a, uint3 b, ushort c, float3 d, float3 e, float3 f, float g, float h, float i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x89DB210", Offset = "0x89DA610", VA = "0x1889DB210")]
		private float3 SMJMRNRTTNP(uint3 a, float3 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x89DA3D0", Offset = "0x89D97D0", VA = "0x1889DA3D0")]
		private float BTHBEHSVGSV(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x89DA3F0", Offset = "0x89D97F0", VA = "0x1889DA3F0")]
		private float DZJFQGEBKRG(float3 a, float3 b, float c, float d)
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
		[Cpp2IlInjected.Address(RVA = "0x89DB300", Offset = "0x89DA700", VA = "0x1889DB300", Slot = "4")]
		public void Execute(int voxelStartIdx, int voxelBatchSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x89DB4A0", Offset = "0x89DA8A0", VA = "0x1889DB4A0")]
		private void VASBOEBXVQX(int a, ushort b, int c, LightInBin d)
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
		[Cpp2IlInjected.Address(RVA = "0x89DB620", Offset = "0x89DAA20", VA = "0x1889DB620", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class YLHDXIJBJLD : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly bool IPPZIPNRQWF;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float HLAYZXJBVNH = 179f;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int QPACGIXUAWP = 32;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const int CNEZXPWRRKB = 221184;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private BinPerLightJob DIAHEBQHPHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private BinPerVoxelJob EFSZHEKBMII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CleanupBufferJob VYXPSOIGSTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private NativeParallelMultiHashMap<ushort, LightInBin> OTWSAFYEIKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private PXRGVRKPSGW UGNTAKZQMJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool VOMBZTPLSED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int MUSLODZRQGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private NativeArray<BinnableLight> CQXPNFISOAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private JobHandle NSOGXEYYRNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private JobHandle YUYMDZCMGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool WMSJMFVGQUA;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x89E4BE0", Offset = "0x89E3FE0", VA = "0x1889E4BE0")]
		public YLHDXIJBJLD(RenderPassEvent a, ComputeShader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x89E4720", Offset = "0x89E3B20", VA = "0x1889E4720")]
		private void PWNTDNVDUCR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x89E4120", Offset = "0x89E3520", VA = "0x1889E4120")]
		public void EIUMQRAZJPY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3C04B00", Offset = "0x3C03F00", VA = "0x183C04B00")]
		public static void LARLTJYEVVC<a>(NativeArray<a> a, int b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x89E4400", Offset = "0x89E3800", VA = "0x1889E4400")]
		public void LQHMBUWAMRR(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x89E3DB0", Offset = "0x89E31B0", VA = "0x1889E3DB0")]
		private void BVDGNMRQLMS(LightData a, NativeArray<BinnableLight> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x89E4920", Offset = "0x89E3D20", VA = "0x1889E4920")]
		private void RRRWJSDLMWI(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x89E4790", Offset = "0x89E3B90", VA = "0x1889E4790")]
		private void RAACFDUGAIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x89E4300", Offset = "0x89E3700", VA = "0x1889E4300")]
		private void FURXWQKNDKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x89E4100", Offset = "0x89E3500", VA = "0x1889E4100")]
		private void CPTKDKIIWVS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x89E4B70", Offset = "0x89E3F70", VA = "0x1889E4B70")]
		private void ZAOJZOMTRVY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x89E4200", Offset = "0x89E3600", VA = "0x1889E4200", Slot = "9")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x89E46F0", Offset = "0x89E3AF0", VA = "0x1889E46F0", Slot = "8")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void OnFinishCameraStackRendering(CommandBuffer cmd)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class JOAJQIYJTPE : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const ushort JFSWNUFOZEK = 159;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const float HLAYZXJBVNH = 179f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly PXRGVRKPSGW UGNTAKZQMJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private int WIQGLZGEWXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private BinnableLight[] CQXPNFISOAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private float3 NJKKHHJZKXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private float3 UZTYCKTGQNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private uint INQDDKGAIMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private int VQQPTVBBBTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int HPFWHVLVTHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeArray<uint> NRJJWQAPITV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NativeArray<float> ADNLJICFXZT;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x89DEA90", Offset = "0x89DDE90", VA = "0x1889DEA90")]
		public JOAJQIYJTPE(RenderPassEvent a, ComputeShader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x89DE170", Offset = "0x89DD570", VA = "0x1889DE170")]
		public void LQHMBUWAMRR(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x89DD970", Offset = "0x89DCD70", VA = "0x1889DD970")]
		private void FJWJIYGLCJI(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x89DD870", Offset = "0x89DCC70", VA = "0x1889DD870")]
		public void EIUMQRAZJPY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x89DCE80", Offset = "0x89DC280", VA = "0x1889DCE80")]
		private void BVDGNMRQLMS(LightData a, BinnableLight[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x89DDBF0", Offset = "0x89DCFF0", VA = "0x1889DDBF0")]
		private void HRLMINSKQUI(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x89DCE50", Offset = "0x89DC250", VA = "0x1889DCE50")]
		private void BAUYPHXPAAY(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x89DEA50", Offset = "0x89DDE50", VA = "0x1889DEA50")]
		private ushort ZUYWJOVKYNN(int a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x89DDB80", Offset = "0x89DCF80", VA = "0x1889DDB80")]
		private void FSPOGLTKVQQ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x89DCDE0", Offset = "0x89DC1E0", VA = "0x1889DCDE0")]
		private void BARBIOFMYXV(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x89DDCA0", Offset = "0x89DD0A0", VA = "0x1889DDCA0")]
		private void IBLWWZQTEQO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x89DD890", Offset = "0x89DCC90", VA = "0x1889DD890", Slot = "9")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x89DE790", Offset = "0x89DDB90", VA = "0x1889DE790", Slot = "8")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void OnFinishCameraStackRendering(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x89DD2C0", Offset = "0x89DC6C0", VA = "0x1889DD2C0")]
		private void DDRADCRFQDZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x89DDD60", Offset = "0x89DD160", VA = "0x1889DDD60")]
		private void LIAWHOJOTTM(uint3 a, uint3 b, ushort c, float3 d, float e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x89DE240", Offset = "0x89DD640", VA = "0x1889DE240")]
		private void LRGKXBPHOIC(uint3 a, uint3 b, ushort c, float3 d, float3 e, float3 f, float g, float h, float i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x89DD1D0", Offset = "0x89DC5D0", VA = "0x1889DD1D0")]
		private void BZPGNDAGHRX(ushort a, uint b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x89DE7C0", Offset = "0x89DDBC0", VA = "0x1889DE7C0")]
		private float3 SMJMRNRTTNP(uint3 a, float3 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x89DA3D0", Offset = "0x89D97D0", VA = "0x1889DA3D0")]
		private float BTHBEHSVGSV(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x89DA3F0", Offset = "0x89D97F0", VA = "0x1889DA3F0")]
		private float DZJFQGEBKRG(float3 a, float3 b, float c, float d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x89DE8C0", Offset = "0x89DDCC0", VA = "0x1889DE8C0")]
		private void VASBOEBXVQX(int a, ushort b, int c, LightInBin d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PXRGVRKPSGW
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private static class MGMLJPORKHZ
		{
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly int GLQFXAWPBVW;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly int KSFMVZBNMOJ;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly int VIAXGFNCHPY;

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly int FDDCAEPAAVT;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly int LLBNEDPCAIV;

			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public static readonly int JMOSXPIOZSS;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly int ARHOWRCCSEK;
		}

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private const int DKTFJLTFSNM = 4;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const int QGFIOETCCCF = 2;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private const int UWHEIIFOQAP = 3;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private const int UWBXLBLRGPG = 3;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private const int UWRSCVTJIXH = 3;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private const int VBQGYIRUFCG = 4;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private const int RJGOLIOBCZD = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool ZYECHPBYVJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private ComputeBuffer JJUNJBAPRPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private RenderTexture GGRCZWRTTLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int OKWLALTJHPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int QAJTYUFCGGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int SYVBBUONQOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int YSDLMNHMQJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int EDQPMWUJQCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private ComputeShader HFCERYVUXOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int HKHSAEVMCZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private int ZCJUUCFVLXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float3 RYWACMVWPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float3 FLBEKXBPVLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private NativeArray<uint> VFXCUTCIUZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private NativeArray<float> GFXFKITTDFX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NativeArray<uint> IYACUVCKIVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xD57120", Offset = "0xD56520", VA = "0x180D57120")]
			get
			{
				return default(NativeArray<uint>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public NativeArray<float> FOOSUZLCOFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xC6E790", Offset = "0xC6DB90", VA = "0x180C6E790")]
			get
			{
				return default(NativeArray<float>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int KTRNGWOTSVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xB334F0", Offset = "0xB328F0", VA = "0x180B334F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int WSOWOHPRTJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAA5980", Offset = "0xAA4D80", VA = "0x180AA5980")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ComputeShader DVMZODSCQCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x89E0F50", Offset = "0x89E0350", VA = "0x1889E0F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x89E0130", Offset = "0x89DF530", VA = "0x1889E0130")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x89E0FE0", Offset = "0x89E03E0", VA = "0x1889E0FE0")]
		public void TUPFYZJTCHT(CameraData a, LightData b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x38C1280", Offset = "0x38C0680", VA = "0x1838C1280")]
		private void LARLTJYEVVC<a>(NativeArray<a> a, int b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x89E0C00", Offset = "0x89E0000", VA = "0x1889E0C00")]
		public void RNVWQDSZKGY(CommandBuffer a, ScriptableRenderContext b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x89E0530", Offset = "0x89DF930", VA = "0x1889E0530")]
		private static void HSIHWQXKESS(int a, CommandBuffer b, RenderBuffer c, ComputeBuffer d, ComputeShader e, int f, int g, int h, int i, int j, int k, int l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x89E0220", Offset = "0x89DF620", VA = "0x1889E0220")]
		public void EXZTJCSHSWU(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x89E0A20", Offset = "0x89DFE20", VA = "0x1889E0A20")]
		private RenderTexture MMAZLKLMSFR(RenderTexture a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x89E0710", Offset = "0x89DFB10", VA = "0x1889E0710")]
		public void JGCHOLHCONJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x89E0790", Offset = "0x89DFB90", VA = "0x1889E0790")]
		public void KEIUPAOXVHZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x89E12F0", Offset = "0x89E06F0", VA = "0x1889E12F0")]
		public PXRGVRKPSGW()
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
		private class MRJDHTJIHFF : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string QFKCTLWONFB;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private static readonly int AYPFHLAJZII;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private Material XQGHWROXTAH;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x89DF9F0", Offset = "0x89DEDF0", VA = "0x1889DF9F0")]
			public MRJDHTJIHFF(RenderPassEvent a, Material b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x89DF620", Offset = "0x89DEA20", VA = "0x1889DF620", Slot = "9")]
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
		private MRJDHTJIHFF m_MobileFadePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Reload("Shaders/MobileFade.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool CZNJXPHTYXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x89DFDC0", Offset = "0x89DF1C0", VA = "0x1889DFDC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float DQQTEVQZIDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x89DFD70", Offset = "0x89DF170", VA = "0x1889DFD70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x89DFBC0", Offset = "0x89DEFC0", VA = "0x1889DFBC0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x89DFAE0", Offset = "0x89DEEE0", VA = "0x1889DFAE0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x16C14F0", Offset = "0x16C08F0", VA = "0x1816C14F0")]
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
		public sealed class SAKPOEQMONF : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private static readonly string QFKCTLWONFB;

			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly int MLSVIFTNRMF;

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private static readonly int GYNGGEWWYLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private Material XQGHWROXTAH;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x89E37E0", Offset = "0x89E2BE0", VA = "0x1889E37E0")]
			public SAKPOEQMONF(RenderPassEvent a, Material b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x89E3690", Offset = "0x89E2A90", VA = "0x1889E3690", Slot = "5")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void OnCameraSetup(CommandBuffer cmd, RenderingData renderingData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x89E34A0", Offset = "0x89E28A0", VA = "0x1889E34A0", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static Settings CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private SAKPOEQMONF m_MobileVignettePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Reload("Shaders/MobileVignette.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static bool CZNJXPHTYXO
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x89E00E0", Offset = "0x89DF4E0", VA = "0x1889E00E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x89DFF30", Offset = "0x89DF330", VA = "0x1889DFF30", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x89DFE10", Offset = "0x89DF210", VA = "0x1889DFE10", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x16C14F0", Offset = "0x16C08F0", VA = "0x1816C14F0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string NDKCTELLXZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool LNXOLWBXYYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer cmd, ScriptableRenderContext context, RenderingData renderingData);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAA3140", Offset = "0xAA2540", VA = "0x180AA3140")]
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
		private class RXNNITDGDOR : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private bool OLWAXASJDBS;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private readonly List<PerCameraRenderEffect> HKIHXAULJXQ;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private static readonly List<PerCameraRenderEffect> KXMOMMCAJXI;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x89E33D0", Offset = "0x89E27D0", VA = "0x1889E33D0")]
			public RXNNITDGDOR(RenderPassEvent a, bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x89E2F90", Offset = "0x89E2390", VA = "0x1889E2F90")]
			public bool NYLCRQPKDLV(CameraData a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x89E2DC0", Offset = "0x89E21C0", VA = "0x1889E2DC0", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x89E3270", Offset = "0x89E2670", VA = "0x1889E3270")]
			private void OREHSEODYQQ(PerCameraRenderEffect a, ScriptableRenderContext b, RenderingData c)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private RXNNITDGDOR m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private RXNNITDGDOR m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x89E13A0", Offset = "0x89E07A0", VA = "0x1889E13A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x89E1310", Offset = "0x89E0710", VA = "0x1889E1310", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x16C14F0", Offset = "0x16C08F0", VA = "0x1816C14F0")]
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
		private static readonly List<RUBXQLAIOMY> passes;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private const RenderPassEvent RENDER_PASS_EVENT = RenderPassEvent.BeforeRenderingShadows;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x89E1640", Offset = "0x89E0A40", VA = "0x1889E1640")]
		public static void EnqueuePassForNextRender(RUBXQLAIOMY pass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x89E1550", Offset = "0x89E0950", VA = "0x1889E1550", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x89E1770", Offset = "0x89E0B70", VA = "0x1889E1770")]
		private static bool MBQCEOBCXDO([In] RenderingData renderingData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x89E1440", Offset = "0x89E0840", VA = "0x1889E1440", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x89E17F0", Offset = "0x89E0BF0", VA = "0x1889E17F0", Slot = "8")]
		public override void SetupRenderPasses(ScriptableRenderer renderer, [In] RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x16C14F0", Offset = "0x16C08F0", VA = "0x1816C14F0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public abstract class RUBXQLAIOMY : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "11")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "12")]
		public virtual void NYLCRQPKDLV(ScriptableRenderer a, [In] RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x89E2D70", Offset = "0x89E2170", VA = "0x1889E2D70")]
		protected RUBXQLAIOMY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class HGWZXXRFHFK
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly float3 MQXENBBNJFC;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly uint3 TDWDQUUPMJL;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private static readonly uint3 QXPGQDGNBLA;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly float3 UIPRUEMQRLM;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static readonly float3 HYTJJEUGAKA;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x89DC910", Offset = "0x89DBD10", VA = "0x1889DC910")]
		public static uint UFKVDPOKFSS(uint a, uint b, uint c)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x89DC920", Offset = "0x89DBD20", VA = "0x1889DC920")]
		public static uint3 VVPLHWFDCXS(float3 a, float3 b, float3 c)
		{
			return default(uint3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x89DC1D0", Offset = "0x89DB5D0", VA = "0x1889DC1D0")]
		public static void AQSFLJQQPEG(float3 a, float3 b, float3 c, float d, [Out] uint3 e, [Out] uint3 f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x89DC440", Offset = "0x89DB840", VA = "0x1889DC440")]
		public static void CBMPWKZLRYA(float3 a, float3 b, float c, float d, [Out] float3 e, [Out] float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x89DCB10", Offset = "0x89DBF10", VA = "0x1889DCB10")]
		private static float3 WZKJEBPAJRL(float3 a, float3 b, float3 c, float3 d)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class EIEZXIACQZY
	{
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private static readonly Log IOHOPMTWTFM;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly Log ULBBSVKTUNZ;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly Log AYMBNHECUUX;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public static readonly Log UQHGIEIFTNY;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public static readonly Log LOXHCDSEYTV;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class ZGEBWIWPFDY
	{
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private static Mesh CXYJXOVLAKL;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x89E4CB0", Offset = "0x89E40B0", VA = "0x1889E4CB0")]
		public static Mesh POHZOLDDHDV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x89E4D50", Offset = "0x89E4150", VA = "0x1889E4D50")]
		public static Matrix4x4 RNBCFQRLPUQ(Camera a, bool b = false, bool c = false)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x89E51F0", Offset = "0x89E45F0", VA = "0x1889E51F0")]
		private static Mesh ZBFRHXYZZFQ()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1132216663
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x89E55C0", Offset = "0x89E49C0", VA = "0x1889E55C0")]
	public static void JRNZJIULILS()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x89E55B0", Offset = "0x89E49B0", VA = "0x1889E55B0")]
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
