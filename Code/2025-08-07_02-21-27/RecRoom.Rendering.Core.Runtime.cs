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
		[Cpp2IlInjected.Address(RVA = "0x921A590", Offset = "0x9219190", VA = "0x18921A590", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		public interface FQISITSUYBE
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void YMCZYPRTVWQ(ScriptableRenderContext a, List<Camera> b);
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface UPJKRNQWNRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void YMCZYPRTVWQ(ScriptableRenderContext a, RenderingData b);
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class IZRYFCCFTNF : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9216EE0", Offset = "0x9215AE0", VA = "0x189216EE0")]
			public IZRYFCCFTNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9216E80", Offset = "0x9215A80", VA = "0x189216E80", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool _withinContextRendering;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private IZRYFCCFTNF _preRenderPass;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static List<FQISITSUYBE> _contextTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static List<FQISITSUYBE> _contextTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static List<UPJKRNQWNRU> _cameraTasksCompute;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static List<UPJKRNQWNRU> _cameraTasksGraphics;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string _profilerTag;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static ProfilingSampler _profilingSampler;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x921DCA0", Offset = "0x921C8A0", VA = "0x18921DCA0")]
		public static void AddTask(TaskType taskType, FQISITSUYBE contextTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x921E7A0", Offset = "0x921D3A0", VA = "0x18921E7A0")]
		public static void RemoveTask(TaskType taskType, FQISITSUYBE contextTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x921DDE0", Offset = "0x921C9E0", VA = "0x18921DDE0")]
		public static void AddTask(TaskType taskType, UPJKRNQWNRU cameraTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x921E6E0", Offset = "0x921D2E0", VA = "0x18921E6E0")]
		public static void RemoveTask(TaskType taskType, UPJKRNQWNRU cameraTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x921DF20", Offset = "0x921CB20", VA = "0x18921DF20", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x921DBF0", Offset = "0x921C7F0", VA = "0x18921DBF0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x921E110", Offset = "0x921CD10", VA = "0x18921E110", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x921E8D0", Offset = "0x921D4D0", VA = "0x18921E8D0")]
		private static void VVNKEHDYLNR(ScriptableRenderContext a, List<Camera> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x921E860", Offset = "0x921D460", VA = "0x18921E860")]
		private static void UAJJJDGZYQL(ScriptableRenderContext a, List<Camera> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x921E210", Offset = "0x921CE10", VA = "0x18921E210")]
		private static void JPSSEIZXSHT(ScriptableRenderContext a, RenderingData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1A523C0", Offset = "0x1A50FC0", VA = "0x181A523C0")]
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
		private class ZYPRHGNZVGS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public bool EGQXSQRTYSJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public readonly List<DIVDUMQRWLN> XLGTXHMAOUC;

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x92204E0", Offset = "0x921F0E0", VA = "0x1892204E0")]
			public ZYPRHGNZVGS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class UFJCTZWOLSS : PreRenderManager.UPJKRNQWNRU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private readonly string BOXFWFQVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private readonly ProfilingSampler TNMTSBIYTIY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private readonly ZYPRHGNZVGS YSBEXZOWVFV;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x921FF50", Offset = "0x921EB50", VA = "0x18921FF50")]
			public UFJCTZWOLSS(ZYPRHGNZVGS a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x921FB30", Offset = "0x921E730", VA = "0x18921FB30", Slot = "4")]
			public void YMCZYPRTVWQ(ScriptableRenderContext a, RenderingData b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class GQUHPIKUZKH : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private readonly string IYJKORRYJDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private readonly ZYPRHGNZVGS BIJFBKYDOGA;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9216D90", Offset = "0x9215990", VA = "0x189216D90")]
			public GQUHPIKUZKH(RenderPassEvent a, ZYPRHGNZVGS b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9216A70", Offset = "0x9215670", VA = "0x189216A70", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static List<DIVDUMQRWLN> RenderInstances;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private UFJCTZWOLSS fastLinesUpdateTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private GQUHPIKUZKH fastLinesRenderPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ZYPRHGNZVGS sharedData;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x92164A0", Offset = "0x92150A0", VA = "0x1892164A0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9216870", Offset = "0x9215470", VA = "0x189216870", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9216400", Offset = "0x9215000", VA = "0x189216400", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1A523C0", Offset = "0x1A50FC0", VA = "0x181A523C0")]
		public FastLinesRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface DIVDUMQRWLN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XDKSPKSAKWT(CommandBuffer a, Camera b, [NotNull] UniversalAdditionalCameraData cameraData, bool c);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LOFMWBPTMXC(Camera a, CommandBuffer b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class QRUTNEACXSH
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public static bool GEZCLFBJKRH;
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
		private KRGHPYYYUWE _oldLightBinningPass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private ORJCIKGAZWP _newLightBinningPass;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x921A250", Offset = "0x9218E50", VA = "0x18921A250", Slot = "11")]
		protected override void Dispose(bool isDisposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x921A2C0", Offset = "0x9218EC0", VA = "0x18921A2C0")]
		private void NMMQWQLLGQA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9219DC0", Offset = "0x92189C0", VA = "0x189219DC0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1A523C0", Offset = "0x1A50FC0", VA = "0x181A523C0")]
		public LightBinning()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class AEHLIOLSMNU
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9215170", Offset = "0x9213D70", VA = "0x189215170")]
		public static int MSCYCSLKKPS(bool a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2141380", Offset = "0x213FF80", VA = "0x182141380")]
		public static int HAZBGAQGNJU(bool a)
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
		[Cpp2IlInjected.Address(RVA = "0x9215630", Offset = "0x9214230", VA = "0x189215630", Slot = "4")]
		public void Execute(int lightIdx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9215C60", Offset = "0x9214860", VA = "0x189215C60")]
		private void KATFWQPUFFX(uint3 a, uint3 b, ushort c, float3 d, float e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9215180", Offset = "0x9213D80", VA = "0x189215180")]
		private void DIXHVVEYFYL(uint3 a, uint3 b, ushort c, float3 d, float3 e, float3 f, float g, float h, float i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9215B70", Offset = "0x9214770", VA = "0x189215B70")]
		private float3 GFRZMTSBAVY(uint3 a, float3 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9216090", Offset = "0x9214C90", VA = "0x189216090")]
		private float KZDSOYHRJMU(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9215FD0", Offset = "0x9214BD0", VA = "0x189215FD0")]
		private float KOBLJZCXYZR(float3 a, float3 b, float c, float d)
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
		[Cpp2IlInjected.Address(RVA = "0x92160B0", Offset = "0x9214CB0", VA = "0x1892160B0", Slot = "4")]
		public void Execute(int voxelStartIdx, int voxelBatchSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9216250", Offset = "0x9214E50", VA = "0x189216250")]
		private void YJOIEZHCKQA(int a, ushort b, int c, LightInBin d)
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
		[Cpp2IlInjected.Address(RVA = "0x92163C0", Offset = "0x9214FC0", VA = "0x1892163C0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class KRGHPYYYUWE : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly bool UOZFAVEJWYM;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float UAOTALUBUJA = 179f;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const int DITCVAJCGTM = 32;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const int WRMGZMWLPYG = 221184;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private BinPerLightJob URXGJLCZUJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private BinPerVoxelJob EGQMYWYMKPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CleanupBufferJob OUXYHPRXIWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private NativeParallelMultiHashMap<ushort, LightInBin> VQERBZNPXGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private JESEANVFTTP DOGPIJLYIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool BXETVAXSHLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private int YIINJPUCBEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private NativeArray<BinnableLight> TDUILBNBUSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private JobHandle XZPEMTDSSOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private JobHandle EFQSAQVBXKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool CJUAFDRIVTD;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9219BB0", Offset = "0x92187B0", VA = "0x189219BB0")]
		public KRGHPYYYUWE(RenderPassEvent a, ComputeShader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9219670", Offset = "0x9218270", VA = "0x189219670")]
		private void SMHHYAJRVDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9218E70", Offset = "0x9217A70", VA = "0x189218E70")]
		public void CleanUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3C8D2F0", Offset = "0x3C8BEF0", VA = "0x183C8D2F0")]
		public static void XEKYRPQIWBX<a>(NativeArray<a> a, int b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x92196E0", Offset = "0x92182E0", VA = "0x1892196E0")]
		public void SZMVKLGEIOG(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x92192D0", Offset = "0x9217ED0", VA = "0x1892192D0")]
		private void HKVPGZTEGXX(LightData a, NativeArray<BinnableLight> b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9218F50", Offset = "0x9217B50", VA = "0x189218F50")]
		private void EUYTHBLESFN(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x92199D0", Offset = "0x92185D0", VA = "0x1892199D0")]
		private void UOMAOJXTCLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9218D70", Offset = "0x9217970", VA = "0x189218D70")]
		private void AYJQKXDORLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9219620", Offset = "0x9218220", VA = "0x189219620")]
		private void LFAICSYIVIZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x92192A0", Offset = "0x9217EA0", VA = "0x1892192A0")]
		private void FMXAHMEJXXT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x92191A0", Offset = "0x9217DA0", VA = "0x1892191A0", Slot = "9")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9219640", Offset = "0x9218240", VA = "0x189219640", Slot = "8")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void OnFinishCameraStackRendering(CommandBuffer cmd)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class ORJCIKGAZWP : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private const ushort XOLTSHQVOVV = 159;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private const float UAOTALUBUJA = 179f;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly JESEANVFTTP DOGPIJLYIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private int BICKAHJRRMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private BinnableLight[] TDUILBNBUSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private float3 FCWJBJQIKWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private float3 VWWZVZBCQRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private uint AMSTJYZKSUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private int WIFGJSJNZGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int NFYJWFVCRAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeArray<uint> PIZKXHWKHAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NativeArray<float> RDPVRXJHIRC;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x921C990", Offset = "0x921B590", VA = "0x18921C990")]
		public ORJCIKGAZWP(RenderPassEvent a, ComputeShader b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x921C640", Offset = "0x921B240", VA = "0x18921C640")]
		public void SZMVKLGEIOG(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x921BDA0", Offset = "0x921A9A0", VA = "0x18921BDA0")]
		private void NFQIDLNDQYH(CameraData a, LightData b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x921ADC0", Offset = "0x92199C0", VA = "0x18921ADC0")]
		public void CleanUp()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x921B5D0", Offset = "0x921A1D0", VA = "0x18921B5D0")]
		private void HKVPGZTEGXX(LightData a, BinnableLight[] b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x921ACE0", Offset = "0x92198E0", VA = "0x18921ACE0")]
		private void CAONSTOXQTT(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x921AD90", Offset = "0x9219990", VA = "0x18921AD90")]
		private void CZHEPMPMBWT(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x921BFB0", Offset = "0x921ABB0", VA = "0x18921BFB0")]
		private ushort OYVONQIWUFW(int a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x921C5D0", Offset = "0x921B1D0", VA = "0x18921C5D0")]
		private void RVVFSXUKJPX(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x921B920", Offset = "0x921A520", VA = "0x18921B920")]
		private void HZKTYMVTHVU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x921B330", Offset = "0x9219F30", VA = "0x18921B330")]
		private void EWROQKHEGTJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x921B3F0", Offset = "0x9219FF0", VA = "0x18921B3F0", Slot = "9")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x921BFF0", Offset = "0x921ABF0", VA = "0x18921BFF0", Slot = "8")]
		[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
		public override void OnFinishCameraStackRendering(CommandBuffer cmd)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x921C020", Offset = "0x921AC20", VA = "0x18921C020")]
		private void PAFYNBFTRGM(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x921B990", Offset = "0x921A590", VA = "0x18921B990")]
		private void KATFWQPUFFX(uint3 a, uint3 b, ushort c, float3 d, float e, float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x921ADE0", Offset = "0x92199E0", VA = "0x18921ADE0")]
		private void DIXHVVEYFYL(uint3 a, uint3 b, ushort c, float3 d, float3 e, float3 f, float g, float h, float i, float j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x921C710", Offset = "0x921B310", VA = "0x18921C710")]
		private void WAGCESMLFVQ(ushort a, uint b, float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x921B4D0", Offset = "0x921A0D0", VA = "0x18921B4D0")]
		private float3 GFRZMTSBAVY(uint3 a, float3 b)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9216090", Offset = "0x9214C90", VA = "0x189216090")]
		private float KZDSOYHRJMU(float a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9215FD0", Offset = "0x9214BD0", VA = "0x189215FD0")]
		private float KOBLJZCXYZR(float3 a, float3 b, float c, float d)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x921C800", Offset = "0x921B400", VA = "0x18921C800")]
		private void YJOIEZHCKQA(int a, ushort b, int c, LightInBin d)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class JESEANVFTTP
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private static class PFNWXBAGCAQ
		{
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly int WNPWMNYIGBL;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly int RXCCSNEGGPY;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly int BJAEYNLZUID;

			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public static readonly int VSJKJQUYLAI;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly int MANVBLNPFCO;

			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public static readonly int KTMXMJUVCEF;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly int GPKVURUPOED;
		}

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private const int UPDELUHEJAN = 4;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private const int OGVEJARCFXG = 2;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private const int EUSNROLQYTG = 3;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private const int EUXUOVFOIEP = 3;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private const int EVDBMBZLRPY = 3;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private const int MMXOPZNUTCD = 4;

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private const int NWNIYBBJEZI = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool JXDCOHEENJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private ComputeBuffer JTCTXFRCQNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private RenderTexture WSHCLENLYXY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int DAKUAWVVIKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int QUDMNJZPJEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int FXUVWUNTAFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int IUXPTBQSVIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private int URHBVEJIHMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private ComputeShader ENTNVQPEKBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private int PZTBLFUGGQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private int HWTHFBGMWEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float3 UUQJWENQCLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float3 SVAXFJPXFQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private NativeArray<uint> TPJMIHUUWEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private NativeArray<float> KVDJELWVHJO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NativeArray<uint> AQLSCRTDRYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x10FF6E0", Offset = "0x10FE2E0", VA = "0x1810FF6E0")]
			get
			{
				return default(NativeArray<uint>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public NativeArray<float> WJIBRMMEXRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x142A4C0", Offset = "0x14290C0", VA = "0x18142A4C0")]
			get
			{
				return default(NativeArray<float>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int PYIBRJBYOIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCB0B00", Offset = "0xCAF700", VA = "0x180CB0B00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int TVAXYIAQGHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB30", Offset = "0xB1E730", VA = "0x180B1FB30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ComputeShader WRKOKQNJEWD
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x92183F0", Offset = "0x9216FF0", VA = "0x1892183F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9217B70", Offset = "0x9216770", VA = "0x189217B70")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x92180D0", Offset = "0x9216CD0", VA = "0x1892180D0")]
		public void OBPKSSZXLGA(CameraData a, LightData b, int c, bool d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3C43730", Offset = "0x3C42330", VA = "0x183C43730")]
		private void XEKYRPQIWBX<a>(NativeArray<a> a, int b) where a : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9218A00", Offset = "0x9217600", VA = "0x189218A00")]
		public void ZQNMYZVZESH(CommandBuffer a, ScriptableRenderContext b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9218480", Offset = "0x9217080", VA = "0x189218480")]
		private static void TRRUNPPBFZL(int a, CommandBuffer b, RenderBuffer c, ComputeBuffer d, ComputeShader e, int f, int g, int h, int i, int j, int k, int l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x92186E0", Offset = "0x92172E0", VA = "0x1892186E0")]
		public void VDXJTZQVMBF(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9217C60", Offset = "0x9216860", VA = "0x189217C60")]
		private RenderTexture ERNHXFYTEDU(RenderTexture a, int b, int c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9218660", Offset = "0x9217260", VA = "0x189218660")]
		public void UQCTYHICIHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9217E40", Offset = "0x9216A40", VA = "0x189217E40")]
		public void GNFWOVIUUWW(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9218D50", Offset = "0x9217950", VA = "0x189218D50")]
		public JESEANVFTTP()
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
		private class WFGVRTSDPFG : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly string ADEKYFWQXUS;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private static readonly int FFPNRVFPGPT;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private Material BHUIDZWHIXC;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x92203F0", Offset = "0x921EFF0", VA = "0x1892203F0")]
			public WFGVRTSDPFG(RenderPassEvent a, Material b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x9220010", Offset = "0x921EC10", VA = "0x189220010", Slot = "9")]
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
		private WFGVRTSDPFG m_MobileFadePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Reload("Shaders/MobileFade.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public static bool RAPJGTYDAUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x921A940", Offset = "0x9219540", VA = "0x18921A940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static float NXKXIFLNCRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x921A8F0", Offset = "0x92194F0", VA = "0x18921A8F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x921A740", Offset = "0x9219340", VA = "0x18921A740", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x921A660", Offset = "0x9219260", VA = "0x18921A660", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1A523C0", Offset = "0x1A50FC0", VA = "0x181A523C0")]
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
		public sealed class QXDQJWRYFLS : ScriptableRenderPass
		{
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private static readonly string ADEKYFWQXUS;

			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private static readonly int YSHSCBHJJNY;

			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private static readonly int UBCYCHCRVIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private Material BHUIDZWHIXC;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x921F340", Offset = "0x921DF40", VA = "0x18921F340")]
			public QXDQJWRYFLS(RenderPassEvent a, Material b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x921F1E0", Offset = "0x921DDE0", VA = "0x18921F1E0", Slot = "5")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void OnCameraSetup(CommandBuffer cmd, RenderingData renderingData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x921EFE0", Offset = "0x921DBE0", VA = "0x18921EFE0", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static Settings CurrentSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private QXDQJWRYFLS m_MobileVignettePass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Reload("Shaders/MobileVignette.shader", ReloadAttribute.Package.Root)]
		public Shader m_Shader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private Material m_Material;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static bool RAPJGTYDAUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x921AC80", Offset = "0x9219880", VA = "0x18921AC80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x921AAD0", Offset = "0x92196D0", VA = "0x18921AAD0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x921A9A0", Offset = "0x92195A0", VA = "0x18921A9A0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x1A523C0", Offset = "0x1A50FC0", VA = "0x181A523C0")]
		public MobileVignetteRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class PerCameraRenderEffect : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public abstract string ZLWOMGKJNEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool WUQKBUTFGWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract void RenderPass(CommandBuffer cmd, ScriptableRenderContext context, RenderingData renderingData);

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xB167E0", Offset = "0xB153E0", VA = "0x180B167E0")]
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
		private class SXEAAXCGESC : ScriptableRenderPass
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private bool ULWDZTYBDKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private readonly List<PerCameraRenderEffect> CDVXNPSYDNF;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private static readonly List<PerCameraRenderEffect> UMWMGPJHPCL;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x921FA60", Offset = "0x921E660", VA = "0x18921FA60")]
			public SXEAAXCGESC(RenderPassEvent a, bool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x921F430", Offset = "0x921E030", VA = "0x18921F430")]
			public bool AAGRWYMTYTA(CameraData a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x921F720", Offset = "0x921E320", VA = "0x18921F720", Slot = "9")]
			[Obsolete("This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.", false)]
			public override void Execute(ScriptableRenderContext context, RenderingData renderingData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x921F8F0", Offset = "0x921E4F0", VA = "0x18921F8F0")]
			private void MTFFQUGVUWF(PerCameraRenderEffect a, ScriptableRenderContext b, RenderingData c)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private SXEAAXCGESC m_OpaqueTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private SXEAAXCGESC m_NoOpaqueTexture;

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x921D550", Offset = "0x921C150", VA = "0x18921D550", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x921D4C0", Offset = "0x921C0C0", VA = "0x18921D4C0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x1A523C0", Offset = "0x1A50FC0", VA = "0x181A523C0")]
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
		private static readonly List<MUTFTNMZNNH> passes;

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private const RenderPassEvent RENDER_PASS_EVENT = RenderPassEvent.BeforeRenderingShadows;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x921D810", Offset = "0x921C410", VA = "0x18921D810")]
		public static void EnqueuePassForNextRender(MUTFTNMZNNH pass)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
		public override void Create()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x921D710", Offset = "0x921C310", VA = "0x18921D710", Slot = "11")]
		protected override void Dispose(bool disposing)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x921D950", Offset = "0x921C550", VA = "0x18921D950")]
		private static bool QOVCVYYAJJH([In] RenderingData renderingData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x921D5F0", Offset = "0x921C1F0", VA = "0x18921D5F0", Slot = "7")]
		public override void AddRenderPasses(ScriptableRenderer renderer, RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x921D9D0", Offset = "0x921C5D0", VA = "0x18921D9D0", Slot = "8")]
		public override void SetupRenderPasses(ScriptableRenderer renderer, [In] RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1A523C0", Offset = "0x1A50FC0", VA = "0x181A523C0")]
		public PersistentBufferEffectsRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public abstract class MUTFTNMZNNH : ScriptableRenderPass
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "11")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "12")]
		public virtual void AAGRWYMTYTA(ScriptableRenderer a, [In] RenderingData renderingData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x921A610", Offset = "0x9219210", VA = "0x18921A610")]
		protected MUTFTNMZNNH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class JDAWZIPIWBH
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public static readonly float3 CTHEPKSWFHB;

		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public static readonly uint3 GFJUUBUGDCK;

		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private static readonly uint3 SXFMRQELRNH;

		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public static readonly float3 ZWMFYHDCSCL;

		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public static readonly float3 IZXDUFZVJLF;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x92171B0", Offset = "0x9215DB0", VA = "0x1892171B0")]
		public static uint IFUECDYCURV(uint a, uint b, uint c)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9217690", Offset = "0x9216290", VA = "0x189217690")]
		public static uint3 OPCPFNBWMDJ(float3 a, float3 b, float3 c)
		{
			return default(uint3);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9216F40", Offset = "0x9215B40", VA = "0x189216F40")]
		public static void DYQRSWIXLEH(float3 a, float3 b, float3 c, float d, [Out] uint3 e, [Out] uint3 f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x92171C0", Offset = "0x9215DC0", VA = "0x1892171C0")]
		public static void NRAWLCQSAID(float3 a, float3 b, float c, float d, [Out] float3 e, [Out] float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9217890", Offset = "0x9216490", VA = "0x189217890")]
		private static float3 PWOXMHIZWNK(float3 a, float3 b, float3 c, float3 d)
		{
			return default(float3);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class LIURVHRJRIP
	{
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private static readonly Log YVJCBKQDRVF;

		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public static readonly Log WRTBZSPRERK;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public static readonly Log CUVSDUSOFJQ;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public static readonly Log ZJAGEPCZRMV;

		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public static readonly Log WYNMYWWCYHY;
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class OVMHTNHOTHD
	{
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private static Mesh LFPAWKIHWQG;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x921CEF0", Offset = "0x921BAF0", VA = "0x18921CEF0")]
		public static Mesh IZEHYFYSTWC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x921CA50", Offset = "0x921B650", VA = "0x18921CA50")]
		public static Matrix4x4 ERKWOBPBTPJ(Camera a, bool b = false, bool c = false)
		{
			return default(Matrix4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x921CFA0", Offset = "0x921BBA0", VA = "0x18921CFA0")]
		private static Mesh QWGCBAUBCCZ()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__930366062
{
	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x9220570", Offset = "0x921F170", VA = "0x189220570")]
	public static void TGIQTAWGCFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x9220560", Offset = "0x921F160", VA = "0x189220560")]
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
