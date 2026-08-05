using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Foundation.ComponentSystems;
using Unity.Burst;
using Unity.Entities;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class PACCGUKZAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x82AEEA0", Offset = "0x82AD6A0", VA = "0x1882AEEA0")]
		public static void CYZYUXXVOCQ(ComponentSystemGroup a, EntityCommandBufferSystem b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	internal struct UpgradeSystemRegistration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private ComponentSystemGroup group;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private EntityCommandBufferSystem ecbs;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x82AEEA0", Offset = "0x82AD6A0", VA = "0x1882AEEA0")]
		public static void HXJOQRILYFK(ComponentSystemGroup a, EntityCommandBufferSystem b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82B2B00", Offset = "0x82B1300", VA = "0x1882B2B00")]
		private void CYZYUXXVOCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3BCDF60", Offset = "0x3BCC760", VA = "0x183BCDF60")]
		private void PGNETZSWEQP<a>(a a) where a : HBTGGCQSYRO
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class AKJKGPBLLOM : HBTGGCQSYRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[NoAlias]
		[BurstCompile]
		private struct PersistentUserTagDataUpgradeSystem_4898F9D2_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public IntermediateVersionInfo<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public FinalVersionInfo<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x82AF790", Offset = "0x82ADF90", VA = "0x1882AF790")]
			private void OMMNLAOUJZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x82AF780", Offset = "0x82ADF80", VA = "0x1882AF780", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82AA730", Offset = "0x82A8F30", VA = "0x1882AA730", Slot = "14")]
		protected override void WZDKYNCKFJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82AA590", Offset = "0x82A8D90", VA = "0x1882AA590")]
		private JobHandle HSTFLGIUIQB(IntermediateVersionInfo<PersistentUserTagData_v1> a, FinalVersionInfo<PersistentUserTagData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D3D0", VA = "0x182B8EBD0")]
		[Preserve]
		public AKJKGPBLLOM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class QCEFYYTHWXK : HBTGGCQSYRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile]
		private struct LocalDeformableScaleDataUpgradeSystem_733BF2E_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IntermediateVersionInfo<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public FinalVersionInfo<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x82AD090", Offset = "0x82AB890", VA = "0x1882AD090")]
			private void OMMNLAOUJZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x82AD080", Offset = "0x82AB880", VA = "0x1882AD080", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x82B0970", Offset = "0x82AF170", VA = "0x1882B0970", Slot = "14")]
		protected override void WZDKYNCKFJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82B07D0", Offset = "0x82AEFD0", VA = "0x1882B07D0")]
		private JobHandle JIEKQGKVENJ(IntermediateVersionInfo<LocalDeformableScaleData_v1> a, FinalVersionInfo<LocalDeformableScaleData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D3D0", VA = "0x182B8EBD0")]
		[Preserve]
		public QCEFYYTHWXK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class PLJUBBBFALJ : HBTGGCQSYRO
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile]
		private struct SerializedDataLayerVersionDataUpgradeSystem_4F086E47_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public IntermediateVersionInfo<SerializedDataLayerVersionData_v1> component_15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public FinalVersionInfo<SerializedDataLayerVersionData> component_16;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x82B14E0", Offset = "0x82AFCE0", VA = "0x1882B14E0")]
			private void OMMNLAOUJZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x82B14D0", Offset = "0x82AFCD0", VA = "0x1882B14D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82AF140", Offset = "0x82AD940", VA = "0x1882AF140", Slot = "14")]
		protected override void WZDKYNCKFJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x82AEFA0", Offset = "0x82AD7A0", VA = "0x1882AEFA0")]
		private JobHandle WNVGAPWMFEA(IntermediateVersionInfo<SerializedDataLayerVersionData_v1> a, FinalVersionInfo<SerializedDataLayerVersionData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D3D0", VA = "0x182B8EBD0")]
		[Preserve]
		public PLJUBBBFALJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class TDQKEFFGYNF : HBTGGCQSYRO
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_381E5791_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public IntermediateVersionInfo<ReplicatorPreallocatedObjectCountData_v1> component_23;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public FinalVersionInfo<ReplicatorPreallocatedObjectCountData> component_24;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x82B1270", Offset = "0x82AFA70", VA = "0x1882B1270")]
			private void OMMNLAOUJZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x82B1260", Offset = "0x82AFA60", VA = "0x1882B1260", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82B18E0", Offset = "0x82B00E0", VA = "0x1882B18E0", Slot = "14")]
		protected override void WZDKYNCKFJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82B1740", Offset = "0x82AFF40", VA = "0x1882B1740")]
		private JobHandle TXVIMUWFKHD(IntermediateVersionInfo<ReplicatorPreallocatedObjectCountData_v1> a, FinalVersionInfo<ReplicatorPreallocatedObjectCountData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D3D0", VA = "0x182B8EBD0")]
		[Preserve]
		public TDQKEFFGYNF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class NMIBXMAUBJI : HBTGGCQSYRO
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile]
		private struct ToolCleanupStatusDataUpgradeSystem_574859E8_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public IntermediateVersionInfo<ToolCleanupStatusData_v1> component_28;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public FinalVersionInfo<ToolCleanupStatusData> component_29;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x82B2460", Offset = "0x82B0C60", VA = "0x1882B2460")]
			private void OMMNLAOUJZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x82B2450", Offset = "0x82B0C50", VA = "0x1882B2450", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82AD5B0", Offset = "0x82ABDB0", VA = "0x1882AD5B0", Slot = "14")]
		protected override void WZDKYNCKFJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82AD7B0", Offset = "0x82ABFB0", VA = "0x1882AD7B0")]
		private JobHandle YITCKTJEJTM(IntermediateVersionInfo<ToolCleanupStatusData_v1> a, FinalVersionInfo<ToolCleanupStatusData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D3D0", VA = "0x182B8EBD0")]
		[Preserve]
		public NMIBXMAUBJI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class KTNUMCMNXFN : HBTGGCQSYRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile]
		private struct TerrainGenerationDataUpgradeSystem_52DFB0E1_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public IntermediateVersionInfo<TerrainGenerationData_v1> component_31;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public FinalVersionInfo<TerrainGenerationData> component_32;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x82B1B40", Offset = "0x82B0340", VA = "0x1882B1B40")]
			private void OMMNLAOUJZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x82B1B30", Offset = "0x82B0330", VA = "0x1882B1B30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x82ACE30", Offset = "0x82AB630", VA = "0x1882ACE30", Slot = "14")]
		protected override void WZDKYNCKFJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x82ACC90", Offset = "0x82AB490", VA = "0x1882ACC90")]
		private JobHandle APMYDLQDNRB(IntermediateVersionInfo<TerrainGenerationData_v1> a, FinalVersionInfo<TerrainGenerationData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D3D0", VA = "0x182B8EBD0")]
		[Preserve]
		public KTNUMCMNXFN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class FRJONOBPKKD : HBTGGCQSYRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[NoAlias]
		[BurstCompile]
		private struct ReplicatorDataUpgradeSystem_5EC69FAD_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public IntermediateVersionInfo<ReplicatorData_v1> component_39;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public FinalVersionInfo<ReplicatorData> component_40;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x82B0FC0", Offset = "0x82AF7C0", VA = "0x1882B0FC0")]
			private void OMMNLAOUJZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x82B0FB0", Offset = "0x82AF7B0", VA = "0x1882B0FB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x82ABCC0", Offset = "0x82AA4C0", VA = "0x1882ABCC0", Slot = "14")]
		protected override void WZDKYNCKFJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x82ABEC0", Offset = "0x82AA6C0", VA = "0x1882ABEC0")]
		private JobHandle XTGJDQEIBQP(IntermediateVersionInfo<ReplicatorData_v1> a, FinalVersionInfo<ReplicatorData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D3D0", VA = "0x182B8EBD0")]
		[Preserve]
		public FRJONOBPKKD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class BBOTFTZXLKG : HBTGGCQSYRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[NoAlias]
		[BurstCompile]
		private struct InventionInstanceIdDataUpgradeSystem_23B59C0C_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public IntermediateVersionInfo<InventionInstanceIdData_v1> component_43;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public FinalVersionInfo<InventionInstanceIdData> component_44;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x82AC520", Offset = "0x82AAD20", VA = "0x1882AC520")]
			private void OMMNLAOUJZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x82AC510", Offset = "0x82AAD10", VA = "0x1882AC510", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x82AB170", Offset = "0x82A9970", VA = "0x1882AB170", Slot = "14")]
		protected override void WZDKYNCKFJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x82AAFD0", Offset = "0x82A97D0", VA = "0x1882AAFD0")]
		private JobHandle WLCEGFTEEKW(IntermediateVersionInfo<InventionInstanceIdData_v1> a, FinalVersionInfo<InventionInstanceIdData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D3D0", VA = "0x182B8EBD0")]
		[Preserve]
		public BBOTFTZXLKG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class GTVJENNZDJS : HBTGGCQSYRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile]
		private struct TerrainWaterDataUpgradeSystem_4A9D03D6_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public IntermediateVersionInfo<TerrainWaterData_v1> component_47;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IntermediateVersionInfo<TerrainWaterData_v2> component_48;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public FinalVersionInfo<TerrainWaterData> component_49;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x82B1EB0", Offset = "0x82B06B0", VA = "0x1882B1EB0")]
			private void OMMNLAOUJZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x82B1EA0", Offset = "0x82B06A0", VA = "0x1882B1EA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82AC0B0", Offset = "0x82AA8B0", VA = "0x1882AC0B0", Slot = "14")]
		protected override void WZDKYNCKFJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x82AC310", Offset = "0x82AAB10", VA = "0x1882AC310")]
		private JobHandle XNSZXLAWPEW(IntermediateVersionInfo<TerrainWaterData_v1> a, IntermediateVersionInfo<TerrainWaterData_v2> b, FinalVersionInfo<TerrainWaterData> c, JobHandle d)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D3D0", VA = "0x182B8EBD0")]
		[Preserve]
		public GTVJENNZDJS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class RBPDWVOZRDG : HBTGGCQSYRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile]
		private struct OMShapeContainerDataUpgradeSystem_3C684DE6_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public IntermediateVersionInfo<OMShapeContainerData_v1> component_51;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public FinalVersionInfo<OMShapeContainerData> component_52;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x82AE080", Offset = "0x82AC880", VA = "0x1882AE080")]
			private void OMMNLAOUJZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x82AE070", Offset = "0x82AC870", VA = "0x1882AE070", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x82B0D60", Offset = "0x82AF560", VA = "0x1882B0D60", Slot = "14")]
		protected override void WZDKYNCKFJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x82B0BC0", Offset = "0x82AF3C0", VA = "0x1882B0BC0")]
		private JobHandle PIWUAZLVLEI(IntermediateVersionInfo<OMShapeContainerData_v1> a, FinalVersionInfo<OMShapeContainerData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D3D0", VA = "0x182B8EBD0")]
		[Preserve]
		public RBPDWVOZRDG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class FIGGFXWZAIR : HBTGGCQSYRO
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[NoAlias]
		[BurstCompile]
		private struct MagneticAnchorDataUpgradeSystem_618D20A7_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public IntermediateVersionInfo<MagneticAnchorData_v1> component_61;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public FinalVersionInfo<MagneticAnchorData> component_62;

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x82AD310", Offset = "0x82ABB10", VA = "0x1882AD310")]
			private void OMMNLAOUJZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x82AD300", Offset = "0x82ABB00", VA = "0x1882AD300", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x82ABA70", Offset = "0x82AA270", VA = "0x1882ABA70", Slot = "14")]
		protected override void WZDKYNCKFJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x82AB8D0", Offset = "0x82AA0D0", VA = "0x1882AB8D0")]
		private JobHandle QYZOGIITMQL(IntermediateVersionInfo<MagneticAnchorData_v1> a, FinalVersionInfo<MagneticAnchorData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D3D0", VA = "0x182B8EBD0")]
		[Preserve]
		public FIGGFXWZAIR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class DDSJVGVOVEH : HBTGGCQSYRO
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile]
		private struct AuthoredAIIdDataUpgradeSystem_157799F9_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public IntermediateVersionInfo<AuthoredAIIdData_v1> component_63;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public IntermediateVersionInfo<AuthoredAIIdData_v2> component_64;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public IntermediateVersionInfo<AuthoredAIIdData_v3> component_65;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public FinalVersionInfo<AuthoredAIIdData> component_66;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x82AA990", Offset = "0x82A9190", VA = "0x1882AA990")]
			private void OMMNLAOUJZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x82AA980", Offset = "0x82A9180", VA = "0x1882AA980", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x82AB5B0", Offset = "0x82A9DB0", VA = "0x1882AB5B0", Slot = "14")]
		protected override void WZDKYNCKFJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x82AB3C0", Offset = "0x82A9BC0", VA = "0x1882AB3C0")]
		private JobHandle ADQJZYOTZPT(IntermediateVersionInfo<AuthoredAIIdData_v1> a, IntermediateVersionInfo<AuthoredAIIdData_v2> b, IntermediateVersionInfo<AuthoredAIIdData_v3> c, FinalVersionInfo<AuthoredAIIdData> d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D3D0", VA = "0x182B8EBD0")]
		[Preserve]
		public DDSJVGVOVEH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class POPFZEDTVWN : HBTGGCQSYRO
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_627E7B99_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public IntermediateVersionInfo<ContainerCollisionLayerData_v1> component_76;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public FinalVersionInfo<PhysicsModelCollisionLayerData> component_77;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x82AFA80", Offset = "0x82AE280", VA = "0x1882AFA80")]
			private void OMMNLAOUJZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x82AFA70", Offset = "0x82AE270", VA = "0x1882AFA70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x82AF530", Offset = "0x82ADD30", VA = "0x1882AF530", Slot = "14")]
		protected override void WZDKYNCKFJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x82AF390", Offset = "0x82ADB90", VA = "0x1882AF390")]
		private JobHandle UVBGJZIIULB(IntermediateVersionInfo<ContainerCollisionLayerData_v1> a, FinalVersionInfo<PhysicsModelCollisionLayerData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D3D0", VA = "0x182B8EBD0")]
		[Preserve]
		public POPFZEDTVWN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class VBADZZLLWEJ : HBTGGCQSYRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_612C8331_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public IntermediateVersionInfo<ContainerGrabbableModeData_v1> component_81;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public FinalVersionInfo<PhysicsModelGrabbableModeData> component_82;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x82B0560", Offset = "0x82AED60", VA = "0x1882B0560")]
			private void OMMNLAOUJZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x82B0550", Offset = "0x82AED50", VA = "0x1882B0550", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x82B3140", Offset = "0x82B1940", VA = "0x1882B3140", Slot = "14")]
		protected override void WZDKYNCKFJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x82B2FA0", Offset = "0x82B17A0", VA = "0x1882B2FA0")]
		private JobHandle JXGSUFFCJYL(IntermediateVersionInfo<ContainerGrabbableModeData_v1> a, FinalVersionInfo<PhysicsModelGrabbableModeData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D3D0", VA = "0x182B8EBD0")]
		[Preserve]
		public VBADZZLLWEJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public class JJTCTGGVQEB : HBTGGCQSYRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[NoAlias]
		[BurstCompile]
		private struct PhysicsModelFlagsDataUpgradeSystem_6ABF3EC7_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public IntermediateVersionInfo<ContainerFlagsData_v1> component_88;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public IntermediateVersionInfo<ContainerFlagsData_v2> component_89;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public IntermediateVersionInfo<PhysicsModelFlagsData_v3> component_90;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public FinalVersionInfo<PhysicsModelFlagsData> component_91;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x82AFF80", Offset = "0x82AE780", VA = "0x1882AFF80")]
			private void OMMNLAOUJZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x82AFF70", Offset = "0x82AE770", VA = "0x1882AFF70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x82AC970", Offset = "0x82AB170", VA = "0x1882AC970", Slot = "14")]
		protected override void WZDKYNCKFJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x82AC780", Offset = "0x82AAF80", VA = "0x1882AC780")]
		private JobHandle RCUFRWAKZCP(IntermediateVersionInfo<ContainerFlagsData_v1> a, IntermediateVersionInfo<ContainerFlagsData_v2> b, IntermediateVersionInfo<PhysicsModelFlagsData_v3> c, FinalVersionInfo<PhysicsModelFlagsData> d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D3D0", VA = "0x182B8EBD0")]
		[Preserve]
		public JJTCTGGVQEB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public class UVJHXHIPEVD : HBTGGCQSYRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[NoAlias]
		[BurstCompile]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_D28D6DD_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public IntermediateVersionInfo<ContainerCollisionModeData_v1> component_92;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public FinalVersionInfo<PhysicsModelCollisionModeData> component_93;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x82AFD00", Offset = "0x82AE500", VA = "0x1882AFD00")]
			private void OMMNLAOUJZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x82AFCF0", Offset = "0x82AE4F0", VA = "0x1882AFCF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x82B28B0", Offset = "0x82B10B0", VA = "0x1882B28B0", Slot = "14")]
		protected override void WZDKYNCKFJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x82B2710", Offset = "0x82B0F10", VA = "0x1882B2710")]
		private JobHandle IVSNIIKJBLK(IntermediateVersionInfo<ContainerCollisionModeData_v1> a, FinalVersionInfo<PhysicsModelCollisionModeData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D3D0", VA = "0x182B8EBD0")]
		[Preserve]
		public UVJHXHIPEVD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	public class OCBQGWPCURB : HBTGGCQSYRO
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[NoAlias]
		[BurstCompile]
		private struct ObjectPolicyDataUpgradeSystem_6DE72499_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public IntermediateVersionInfo<ObjectPolicyData_v1> component_96;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public IntermediateVersionInfo<ObjectPolicyData_v2> component_97;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public IntermediateVersionInfo<ObjectPolicyData_v3> component_98;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public IntermediateVersionInfo<ObjectPolicyData_v4> component_99;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public IntermediateVersionInfo<ObjectPolicyData_v5> component_100;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public FinalVersionInfo<ObjectPolicyData> component_101;

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x82AE310", Offset = "0x82ACB10", VA = "0x1882AE310")]
			private void OMMNLAOUJZV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x82AE300", Offset = "0x82ACB00", VA = "0x1882AE300", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x82ADC40", Offset = "0x82AC440", VA = "0x1882ADC40", Slot = "14")]
		protected override void WZDKYNCKFJQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x82AD9A0", Offset = "0x82AC1A0", VA = "0x1882AD9A0")]
		private JobHandle OSKCXOTAKDG(IntermediateVersionInfo<ObjectPolicyData_v1> a, IntermediateVersionInfo<ObjectPolicyData_v2> b, IntermediateVersionInfo<ObjectPolicyData_v3> c, IntermediateVersionInfo<ObjectPolicyData_v4> d, IntermediateVersionInfo<ObjectPolicyData_v5> e, FinalVersionInfo<ObjectPolicyData> f, JobHandle g)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2B8EBD0", Offset = "0x2B8D3D0", VA = "0x182B8EBD0")]
		[Preserve]
		public OCBQGWPCURB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class VCOCOSACCUY
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3BCAEF0", Offset = "0x3BC96F0", VA = "0x183BCAEF0")]
		public static void DWXBXYGJALK<T, U>(T a, [Out] U b) where T : struct where U : struct
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__18474188
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x82B3390", Offset = "0x82B1B90", VA = "0x1882B3390")]
	public static void AXVIOBQOKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x82B3580", Offset = "0x82B1D80", VA = "0x1882B3580")]
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
