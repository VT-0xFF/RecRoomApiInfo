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
		[Cpp2IlInjected.Address(RVA = "0x8ACFB00", Offset = "0x8ACE300", VA = "0x188ACFB00", Slot = "4")]
		public override void JPLRKQDWIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		public interface LOVELNXLBYE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void AUZOHRYEXGW(ScriptableRenderContext a, List<Camera> b);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface MHOQIJMPWOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void AUZOHRYEXGW(ScriptableRenderContext a, RenderingData b);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class FHQPTKAYWYV : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8ACD0D0", Offset = "0x8ACB8D0", VA = "0x188ACD0D0")]
			public FHQPTKAYWYV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8ACD070", Offset = "0x8ACB870", VA = "0x188ACD070", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private FHQPTKAYWYV _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<LOVELNXLBYE> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<LOVELNXLBYE> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<MHOQIJMPWOQ> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<MHOQIJMPWOQ> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AD1100", Offset = "0x8ACF900", VA = "0x188AD1100")]
		public static void AddTask(TaskType taskType, LOVELNXLBYE contextTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8AD1EC0", Offset = "0x8AD06C0", VA = "0x188AD1EC0")]
		public static void RemoveTask(TaskType taskType, LOVELNXLBYE contextTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8AD0FC0", Offset = "0x8ACF7C0", VA = "0x188AD0FC0")]
		public static void AddTask(TaskType taskType, MHOQIJMPWOQ cameraTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8AD1F80", Offset = "0x8AD0780", VA = "0x188AD1F80")]
		public static void RemoveTask(TaskType taskType, MHOQIJMPWOQ cameraTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8AD1240", Offset = "0x8ACFA40", VA = "0x188AD1240", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8AD0F20", Offset = "0x8ACF720", VA = "0x188AD0F20", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8AD1430", Offset = "0x8ACFC30", VA = "0x188AD1430", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8AD19E0", Offset = "0x8AD01E0", VA = "0x188AD19E0")]
		private static void OARPVOKDIHX(ScriptableRenderContext a, List<Camera> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD2040", Offset = "0x8AD0840", VA = "0x188AD2040")]
		private static void UMKOCYOVVDP(ScriptableRenderContext a, List<Camera> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD1530", Offset = "0x8ACFD30", VA = "0x188AD1530")]
		private static void LRGIXUTIEDV(ScriptableRenderContext a, RenderingData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x16FA700", Offset = "0x16F8F00", VA = "0x1816FA700")]
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
		private class QWSZPQYETUA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool NKHDWQZANRR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<UQVDUUZDAFD> RPNPLOXSPAE;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8AD51E0", Offset = "0x8AD39E0", VA = "0x188AD51E0")]
			public QWSZPQYETUA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class PZFHCXAZAGA : PreRenderManager.MHOQIJMPWOQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string IRCDLUHMQKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler AKXIMNACCJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly QWSZPQYETUA BDWWUFHIPKJ;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8AD0770", Offset = "0x8ACEF70", VA = "0x188AD0770")]
			public PZFHCXAZAGA(QWSZPQYETUA a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8AD0360", Offset = "0x8ACEB60", VA = "0x188AD0360", Slot = "4")]
			public void AUZOHRYEXGW(ScriptableRenderContext a, RenderingData b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class GPDKAANMGMV : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string JHNKIOCFINQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly QWSZPQYETUA NSYJFFPYOJQ;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8ACE170", Offset = "0x8ACC970", VA = "0x188ACE170")]
			public GPDKAANMGMV(RenderPassEvent a, QWSZPQYETUA b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8ACDE50", Offset = "0x8ACC650", VA = "0x188ACDE50", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<UQVDUUZDAFD> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private PZFHCXAZAGA fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private GPDKAANMGMV fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private QWSZPQYETUA sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8ACD1C0", Offset = "0x8ACB9C0", VA = "0x188ACD1C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8ACD590", Offset = "0x8ACBD90", VA = "0x188ACD590", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8ACD130", Offset = "0x8ACB930", VA = "0x188ACD130", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x16FA700", Offset = "0x16F8F00", VA = "0x1816FA700")]
		public FastLinesRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface UQVDUUZDAFD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool HAKNEYNDLTD(CommandBuffer a, Camera b, [NotNull] UniversalAdditionalCameraData cameraData, bool c);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FOYFXCLYUFA(Camera a, CommandBuffer b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class CFXUAVWYFHL
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static bool SISJMWXGOHF;
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
		private EMGOZGAHMQG _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private QPWKWCYRWGV _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8ACFA90", Offset = "0x8ACE290", VA = "0x188ACFA90", Slot = "11")]
		protected override void Dispose(bool isDisposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF7C0", Offset = "0x8ACDFC0", VA = "0x188ACF7C0")]
		private void DXOTHGVWASK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF330", Offset = "0x8ACDB30", VA = "0x188ACF330", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x16FA700", Offset = "0x16F8F00", VA = "0x1816FA700")]
		public LightBinning()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class TLRIZZZUZIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8AD57B0", Offset = "0x8AD3FB0", VA = "0x188AD57B0")]
		public static int PSDHJIXAYWW(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1BCF5B0", Offset = "0x1BCDDB0", VA = "0x181BCF5B0")]
		public static int TNMFMEOFMMI(bool a)
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
		[Cpp2IlInjected.Address(RVA = "0x8ACAB10", Offset = "0x8AC9310", VA = "0x188ACAB10", Slot = "4")]
		public void Execute(int lightIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA5F0", Offset = "0x8AC8DF0", VA = "0x188ACA5F0")]
		private void AYERFDWDUMD(uint3 a, uint3 b, ushort c, float3 d, float e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB070", Offset = "0x8AC9870", VA = "0x188ACB070")]
		private void STEQFUVUFZD(uint3 a, uint3 b, ushort c, float3 d, float3 e, float3 f, float g, float h, float i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8ACAA20", Offset = "0x8AC9220", VA = "0x188ACAA20")]
		private float3 EXPCCSBDUAM(uint3 a, float3 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB050", Offset = "0x8AC9850", VA = "0x188ACB050")]
		private float JISVUMNXKKO(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA960", Offset = "0x8AC9160", VA = "0x188ACA960")]
		private float EMWDPPTQMZP(float3 a, float3 b, float c, float d)
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
		[Cpp2IlInjected.Address(RVA = "0x8ACB690", Offset = "0x8AC9E90", VA = "0x188ACB690", Slot = "4")]
		public void Execute(int voxelStartIdx, int voxelBatchSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB520", Offset = "0x8AC9D20", VA = "0x188ACB520")]
		private void ALIBMQFJNLY(int a, ushort b, int c, LightInBin d)
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
		[Cpp2IlInjected.Address(RVA = "0x8ACB830", Offset = "0x8ACA030", VA = "0x188ACB830", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class EMGOZGAHMQG : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly bool EJIUDUYFEMO;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float AIULYDFHLCY = 179f;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int QMWSHMCFEVK = 32;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const int LWLWKKZSEAY = 221184;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private BinPerLightJob IRTAZCAKGLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private BinPerVoxelJob FIBZYMLJMCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CleanupBufferJob PDLBHHTVOJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private NativeParallelMultiHashMap<ushort, LightInBin> KKNDTIWQXQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private QAIOLWPXXFV YKDDKVTAXOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool ZWIURLHFUAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int KRDXGHXLMII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private NativeArray<BinnableLight> HXATPSZPLOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private JobHandle JIZWDWZGFEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private JobHandle XMMDYYWPXNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool XCQFYEXWGLZ;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8ACC6A0", Offset = "0x8ACAEA0", VA = "0x188ACC6A0")]
		public EMGOZGAHMQG(RenderPassEvent a, ComputeShader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8ACC410", Offset = "0x8ACAC10", VA = "0x188ACC410")]
		private void LRPGWFAPOLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8ACBC60", Offset = "0x8ACA460", VA = "0x188ACBC60")]
		public void FGFWDAHBZWV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x35CF150", Offset = "0x35CD950", VA = "0x1835CF150")]
		public static void VAEMPZVXECL<a>(NativeArray<a> a, int b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB870", Offset = "0x8ACA070", VA = "0x188ACB870")]
		public void ERZZMYAWPSQ(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8ACC0C0", Offset = "0x8ACA8C0", VA = "0x188ACC0C0")]
		private void LHAGPEORTMT(LightData a, NativeArray<BinnableLight> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8ACBE70", Offset = "0x8ACA670", VA = "0x188ACBE70")]
		private void IVKOTUSVAWV(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8ACC4D0", Offset = "0x8ACACD0", VA = "0x188ACC4D0")]
		private void YNIMSIGERTJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8ACBD70", Offset = "0x8ACA570", VA = "0x188ACBD70")]
		private void GYXOHBFXHGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8ACC4B0", Offset = "0x8ACACB0", VA = "0x188ACC4B0")]
		private void UDHXCQKUGFR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8ACBD40", Offset = "0x8ACA540", VA = "0x188ACBD40")]
		private void FPAVDEEUJGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8ACBB60", Offset = "0x8ACA360", VA = "0x188ACBB60", Slot = "9")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8ACC480", Offset = "0x8ACAC80", VA = "0x188ACC480", Slot = "8")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void OnFinishCameraStackRendering(CommandBuffer cmd)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class QPWKWCYRWGV : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const ushort SPRUVLVGVND = 159;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const float AIULYDFHLCY = 179f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly QAIOLWPXXFV YKDDKVTAXOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private int XPYKCAOIJSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private BinnableLight[] HXATPSZPLOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private float3 NBMXQRXXGNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private float3 ZIMHSHPMPAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private uint BISXLOFKCST;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private int IWTJQLLMVWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int MOXORYDXTEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeArray<uint> VRHACYCMNBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NativeArray<float> XZMBPYXZRSC;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5120", Offset = "0x8AD3920", VA = "0x188AD5120")]
		public QPWKWCYRWGV(RenderPassEvent a, ComputeShader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3A10", Offset = "0x8AD2210", VA = "0x188AD3A10")]
		public void ERZZMYAWPSQ(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3EC0", Offset = "0x8AD26C0", VA = "0x188AD3EC0")]
		private void LACLIOYEPZT(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3CC0", Offset = "0x8AD24C0", VA = "0x188AD3CC0")]
		public void FGFWDAHBZWV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8AD40D0", Offset = "0x8AD28D0", VA = "0x188AD40D0")]
		private void LHAGPEORTMT(LightData a, BinnableLight[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3CE0", Offset = "0x8AD24E0", VA = "0x188AD3CE0")]
		private void FNPCYFEQJPN(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4F50", Offset = "0x8AD3750", VA = "0x188AD4F50")]
		private void VBNQLBNRUMV(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8AD50E0", Offset = "0x8AD38E0", VA = "0x188AD50E0")]
		private ushort YSWUVPYJLLU(int a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4F80", Offset = "0x8AD3780", VA = "0x188AD4F80")]
		private void VGSSQNMMXCT(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3E50", Offset = "0x8AD2650", VA = "0x188AD3E50")]
		private void HRERYRVJFDO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3D90", Offset = "0x8AD2590", VA = "0x188AD3D90")]
		private void HMBHCYPAWMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3BE0", Offset = "0x8AD23E0", VA = "0x188AD3BE0", Slot = "9")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4420", Offset = "0x8AD2C20", VA = "0x188AD4420", Slot = "8")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void OnFinishCameraStackRendering(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4450", Offset = "0x8AD2C50", VA = "0x188AD4450")]
		private void PQFOYOUNQGS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3600", Offset = "0x8AD1E00", VA = "0x188AD3600")]
		private void AYERFDWDUMD(uint3 a, uint3 b, ushort c, float3 d, float e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4A00", Offset = "0x8AD3200", VA = "0x188AD4A00")]
		private void STEQFUVUFZD(uint3 a, uint3 b, ushort c, float3 d, float3 e, float3 f, float g, float h, float i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4FF0", Offset = "0x8AD37F0", VA = "0x188AD4FF0")]
		private void VOUNODDIJIU(ushort a, uint b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3AE0", Offset = "0x8AD22E0", VA = "0x188AD3AE0")]
		private float3 EXPCCSBDUAM(uint3 a, float3 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8ACB050", Offset = "0x8AC9850", VA = "0x188ACB050")]
		private float JISVUMNXKKO(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8ACA960", Offset = "0x8AC9160", VA = "0x188ACA960")]
		private float EMWDPPTQMZP(float3 a, float3 b, float c, float d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3470", Offset = "0x8AD1C70", VA = "0x188AD3470")]
		private void ALIBMQFJNLY(int a, ushort b, int c, LightInBin d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class QAIOLWPXXFV
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private static class MZSGTXYUJRE
		{
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly int XTEORKICUMH;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly int PGTABDADFMU;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly int EUJQLXOTZTD;

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly int OQKIOGHQYAK;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly int LPSGPLKUBYU;

			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public static readonly int SNFVZNMKAKD;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly int CGKCQHFRQOF;
		}

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private const int LUJLZNOQPET = 4;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const int JXTULTDNJRI = 2;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private const int TACZABOSXJE = 3;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private const int TAIFXIIQGUN = 3;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private const int SZSLFOAYEMM = 3;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private const int RZHDLFYHYGN = 4;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private const int NNEIPNMZVEA = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool IVENAGNJSYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private ComputeBuffer WMHFFYLUPOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private RenderTexture ULWMWOYKZJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int VQFSRFZEDLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int UMVGHGRGLRG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int XRRUDVETVSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int BSRHVSAHJSN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int UDKXOFWYRYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private ComputeShader GNDWEJXULGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int QOVHJYFXDLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private int YHXIAUBLSPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float3 KNHVMDTIJUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float3 ZHZDNZFWYGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private NativeArray<uint> YMRHWGHLPIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private NativeArray<float> WAOLKWVWZXE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NativeArray<uint> JXYNFCQYAET
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xD7F2B0", Offset = "0xD7DAB0", VA = "0x180D7F2B0")]
			get
			{
				return default(NativeArray<uint>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public NativeArray<float> CKXPHMWRJGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCA0600", Offset = "0xC9EE00", VA = "0x180CA0600")]
			get
			{
				return default(NativeArray<float>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int FVWWUDOEVDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xB6E470", Offset = "0xB6CC70", VA = "0x180B6E470")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int PDYERPIABZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAB1F10", Offset = "0xAB0710", VA = "0x180AB1F10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ComputeShader DMTUAFJWWRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8AD33C0", Offset = "0x8AD1BC0", VA = "0x188AD33C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8AD2290", Offset = "0x8AD0A90", VA = "0x188AD2290")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8AD2B10", Offset = "0x8AD1310", VA = "0x188AD2B10")]
		public void LKXDSVCWJMG(CameraData a, LightData b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x396C8B0", Offset = "0x396B0B0", VA = "0x18396C8B0")]
		private void VAEMPZVXECL<a>(NativeArray<a> a, int b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8AD2400", Offset = "0x8AD0C00", VA = "0x188AD2400")]
		public void GOCSWNGTOZT(CommandBuffer a, ScriptableRenderContext b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD2930", Offset = "0x8AD1130", VA = "0x188AD2930")]
		private static void LAGOTNTXSCP(int a, CommandBuffer b, RenderBuffer c, ComputeBuffer d, ComputeShader e, int f, int g, int h, int i, int j, int k, int l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD30B0", Offset = "0x8AD18B0", VA = "0x188AD30B0")]
		public void PWGGPPQXKYJ(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD2750", Offset = "0x8AD0F50", VA = "0x188AD2750")]
		private RenderTexture GSPCCUWUGRW(RenderTexture a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8AD2380", Offset = "0x8AD0B80", VA = "0x188AD2380")]
		public void GMDMSDAJANY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD2E20", Offset = "0x8AD1620", VA = "0x188AD2E20")]
		public void NRNPXVDKHTG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8AD3450", Offset = "0x8AD1C50", VA = "0x188AD3450")]
		public QAIOLWPXXFV()
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
		private class HMJVFMVRVRI : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string EFKSQCOWVHK;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private static readonly int MTTWQTDXQVZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private Material IAMHSZXNTKG;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8ACE630", Offset = "0x8ACCE30", VA = "0x188ACE630")]
			public HMJVFMVRVRI(RenderPassEvent a, Material b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x8ACE260", Offset = "0x8ACCA60", VA = "0x188ACE260", Slot = "9")]
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
		private HMJVFMVRVRI m_MobileFadePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Reload("Shaders/MobileFade.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool AZACHEIVZZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x8ACFFA0", Offset = "0x8ACE7A0", VA = "0x188ACFFA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float VFJYDNETTIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x8ACFF50", Offset = "0x8ACE750", VA = "0x188ACFF50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8ACFDA0", Offset = "0x8ACE5A0", VA = "0x188ACFDA0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8ACFCC0", Offset = "0x8ACE4C0", VA = "0x188ACFCC0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x16FA700", Offset = "0x16F8F00", VA = "0x1816FA700")]
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
		public sealed class SWPGJRPYOMO : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private static readonly string EFKSQCOWVHK;

			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly int KVNHTSWZFGE;

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private static readonly int JDSQKZBQBTA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private Material IAMHSZXNTKG;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8AD56C0", Offset = "0x8AD3EC0", VA = "0x188AD56C0")]
			public SWPGJRPYOMO(RenderPassEvent a, Material b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8AD5570", Offset = "0x8AD3D70", VA = "0x188AD5570", Slot = "5")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void OnCameraSetup(CommandBuffer cmd, RenderingData renderingData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8AD5380", Offset = "0x8AD3B80", VA = "0x188AD5380", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static Settings CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private SWPGJRPYOMO m_MobileVignettePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Reload("Shaders/MobileVignette.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static bool AZACHEIVZZF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8AD02C0", Offset = "0x8ACEAC0", VA = "0x188AD02C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD0110", Offset = "0x8ACE910", VA = "0x188AD0110", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8ACFFF0", Offset = "0x8ACE7F0", VA = "0x188ACFFF0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x16FA700", Offset = "0x16F8F00", VA = "0x1816FA700")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string TACKHCBJIMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool MJXDVTPOYLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer cmd, ScriptableRenderContext context, RenderingData renderingData);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAC0", Offset = "0xAAD2C0", VA = "0x180AAEAC0")]
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
		private class GHCKWTOTZQY : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private bool IFHPQUVEATB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private readonly List<PerCameraRenderEffect> QQKOUGDPGGF;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private static readonly List<PerCameraRenderEffect> GUVQJSALEXL;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x8ACDD80", Offset = "0x8ACC580", VA = "0x188ACDD80")]
			public GHCKWTOTZQY(RenderPassEvent a, bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x8ACDA20", Offset = "0x8ACC220", VA = "0x188ACDA20")]
			public bool ILPRDDMFTSU(CameraData a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x8ACD770", Offset = "0x8ACBF70", VA = "0x188ACD770", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x8ACD940", Offset = "0x8ACC140", VA = "0x188ACD940")]
			private void FPTUZSYMJNN(PerCameraRenderEffect a, ScriptableRenderContext b, RenderingData c)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private GHCKWTOTZQY m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private GHCKWTOTZQY m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8AD08C0", Offset = "0x8ACF0C0", VA = "0x188AD08C0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8AD0830", Offset = "0x8ACF030", VA = "0x188AD0830", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x16FA700", Offset = "0x16F8F00", VA = "0x1816FA700")]
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
		private static readonly List<OUPYXDLMMVZ> passes;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private const RenderPassEvent RENDER_PASS_EVENT = RenderPassEvent.BeforeRenderingShadows;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8AD0BE0", Offset = "0x8ACF3E0", VA = "0x188AD0BE0")]
		public static void EnqueuePassForNextRender(OUPYXDLMMVZ pass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8AD0A70", Offset = "0x8ACF270", VA = "0x188AD0A70", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8AD0B60", Offset = "0x8ACF360", VA = "0x188AD0B60")]
		private static bool EONYHTNHEFV([In] RenderingData renderingData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8AD0960", Offset = "0x8ACF160", VA = "0x188AD0960", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8AD0D10", Offset = "0x8ACF510", VA = "0x188AD0D10", Slot = "8")]
		public override void SetupRenderPasses(ScriptableRenderer renderer, [In] RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x16FA700", Offset = "0x16F8F00", VA = "0x1816FA700")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public abstract class OUPYXDLMMVZ : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "11")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "12")]
		public virtual void ILPRDDMFTSU(ScriptableRenderer a, [In] RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8AD0310", Offset = "0x8ACEB10", VA = "0x188AD0310")]
		protected OUPYXDLMMVZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class LIGFAIMMZZV
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly float3 GRUEMHDKKKN;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly uint3 FEBQXWBEKDS;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private static readonly uint3 IZWZBZKHICP;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly float3 JPSNCGXWKTL;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static readonly float3 ZKDSTMCSGMV;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF050", Offset = "0x8ACD850", VA = "0x188ACF050")]
		public static uint SGQPXTCIFPP(uint a, uint b, uint c)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8ACE720", Offset = "0x8ACCF20", VA = "0x188ACE720")]
		public static uint3 ENXSFKZURTD(float3 a, float3 b, float3 c)
		{
			return default(uint3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8ACE910", Offset = "0x8ACD110", VA = "0x188ACE910")]
		public static void LJXFPCBBOPD(float3 a, float3 b, float3 c, float d, [Out] uint3 e, [Out] uint3 f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8ACEB80", Offset = "0x8ACD380", VA = "0x188ACEB80")]
		public static void MMQMANOFBFT(float3 a, float3 b, float c, float d, [Out] float3 e, [Out] float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8ACF060", Offset = "0x8ACD860", VA = "0x188ACF060")]
		private static float3 VTUOFPYOKRA(float3 a, float3 b, float3 c, float3 d)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class SMCNBVEJYRX
	{
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private static readonly Log XAHRLIGRNWB;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly Log HTCGJZGZOSS;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly Log XLGAEDRTLYQ;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public static readonly Log OIHVPXUDAPV;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public static readonly Log YURLXZBQSDS;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class EPLWEWGBJUP
	{
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private static Mesh HLMYQGLYCOQ;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8ACC770", Offset = "0x8ACAF70", VA = "0x188ACC770")]
		public static Mesh CIKPBVIYCFS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8ACC810", Offset = "0x8ACB010", VA = "0x188ACC810")]
		public static Matrix4x4 FINJGQAAMFX(Camera a, bool b = false, bool c = false)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8ACCCB0", Offset = "0x8ACB4B0", VA = "0x188ACCCB0")]
		private static Mesh JYLZNASWQLF()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3295504709
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8AD57C0", Offset = "0x8AD3FC0", VA = "0x188AD57C0")]
	public static void AXVIOBQOKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x8AD5860", Offset = "0x8AD4060", VA = "0x188AD5860")]
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
