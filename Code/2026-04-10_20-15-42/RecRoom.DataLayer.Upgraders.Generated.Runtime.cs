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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class SCYYIALAFXX
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x999FD30", Offset = "0x999ED30", VA = "0x18999FD30")]
		public static void VIKXUZWHXEP(ComponentSystemGroup a, EntityCommandBufferSystem b)
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
		[Cpp2IlInjected.Address(RVA = "0x999FD30", Offset = "0x999ED30", VA = "0x18999FD30")]
		public static void GXHTVERRXXH(ComponentSystemGroup a, EntityCommandBufferSystem b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x99A0C80", Offset = "0x999FC80", VA = "0x1899A0C80")]
		private void VIKXUZWHXEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x40D1940", Offset = "0x40D0940", VA = "0x1840D1940")]
		private void NKNBRUJYDLO<a>(a a) where a : MQCICDIZMOL
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class OPXDPYBXMFB : MQCICDIZMOL
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
			[Cpp2IlInjected.Address(RVA = "0x999DAD0", Offset = "0x999CAD0", VA = "0x18999DAD0")]
			private void AZJIBKKIKUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x999DDB0", Offset = "0x999CDB0", VA = "0x18999DDB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x999BF00", Offset = "0x999AF00", VA = "0x18999BF00", Slot = "14")]
		protected override void CYSBHVYHWEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x999C100", Offset = "0x999B100", VA = "0x18999C100")]
		private JobHandle YOMSMHPIOUI(IntermediateVersionInfo<PersistentUserTagData_v1> a, FinalVersionInfo<PersistentUserTagData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0")]
		[Preserve]
		public OPXDPYBXMFB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class ZEEOKJQPXYR : MQCICDIZMOL
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
			[Cpp2IlInjected.Address(RVA = "0x9999F90", Offset = "0x9998F90", VA = "0x189999F90")]
			private void AZJIBKKIKUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x999A200", Offset = "0x9999200", VA = "0x18999A200", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x99A1120", Offset = "0x99A0120", VA = "0x1899A1120", Slot = "14")]
		protected override void CYSBHVYHWEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99A1320", Offset = "0x99A0320", VA = "0x1899A1320")]
		private JobHandle RWAMRKLSQSW(IntermediateVersionInfo<LocalDeformableScaleData_v1> a, FinalVersionInfo<LocalDeformableScaleData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0")]
		[Preserve]
		public ZEEOKJQPXYR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class ICYBXQAWSXI : MQCICDIZMOL
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
			[Cpp2IlInjected.Address(RVA = "0x999FE30", Offset = "0x999EE30", VA = "0x18999FE30")]
			private void AZJIBKKIKUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x99A0090", Offset = "0x999F090", VA = "0x1899A0090", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9999540", Offset = "0x9998540", VA = "0x189999540", Slot = "14")]
		protected override void CYSBHVYHWEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9999740", Offset = "0x9998740", VA = "0x189999740")]
		private JobHandle OWCBMKBPAYH(IntermediateVersionInfo<SerializedDataLayerVersionData_v1> a, FinalVersionInfo<SerializedDataLayerVersionData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0")]
		[Preserve]
		public ICYBXQAWSXI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ZKYSUQYFXOU : MQCICDIZMOL
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
			[Cpp2IlInjected.Address(RVA = "0x999FAC0", Offset = "0x999EAC0", VA = "0x18999FAC0")]
			private void AZJIBKKIKUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x999FD20", Offset = "0x999ED20", VA = "0x18999FD20", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x99A1510", Offset = "0x99A0510", VA = "0x1899A1510", Slot = "14")]
		protected override void CYSBHVYHWEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x99A1710", Offset = "0x99A0710", VA = "0x1899A1710")]
		private JobHandle TRYOPCWLNUI(IntermediateVersionInfo<ReplicatorPreallocatedObjectCountData_v1> a, FinalVersionInfo<ReplicatorPreallocatedObjectCountData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0")]
		[Preserve]
		public ZKYSUQYFXOU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class NOCSWECPQJX : MQCICDIZMOL
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
			[Cpp2IlInjected.Address(RVA = "0x99A09C0", Offset = "0x999F9C0", VA = "0x1899A09C0")]
			private void AZJIBKKIKUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x99A0C70", Offset = "0x999FC70", VA = "0x1899A0C70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x999A4C0", Offset = "0x99994C0", VA = "0x18999A4C0", Slot = "14")]
		protected override void CYSBHVYHWEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x999A6C0", Offset = "0x99996C0", VA = "0x18999A6C0")]
		private JobHandle PZBXOQXLTDV(IntermediateVersionInfo<ToolCleanupStatusData_v1> a, FinalVersionInfo<ToolCleanupStatusData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0")]
		[Preserve]
		public NOCSWECPQJX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class EUDSTBEZWHC : MQCICDIZMOL
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
			[Cpp2IlInjected.Address(RVA = "0x99A00A0", Offset = "0x999F0A0", VA = "0x1899A00A0")]
			private void AZJIBKKIKUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x99A0400", Offset = "0x999F400", VA = "0x1899A0400", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9999150", Offset = "0x9998150", VA = "0x189999150", Slot = "14")]
		protected override void CYSBHVYHWEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9999350", Offset = "0x9998350", VA = "0x189999350")]
		private JobHandle LYPYGMAMWBM(IntermediateVersionInfo<TerrainGenerationData_v1> a, FinalVersionInfo<TerrainGenerationData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0")]
		[Preserve]
		public EUDSTBEZWHC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class OTGOFULHNPU : MQCICDIZMOL
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
			[Cpp2IlInjected.Address(RVA = "0x999F810", Offset = "0x999E810", VA = "0x18999F810")]
			private void AZJIBKKIKUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x999FAB0", Offset = "0x999EAB0", VA = "0x18999FAB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x999C2F0", Offset = "0x999B2F0", VA = "0x18999C2F0", Slot = "14")]
		protected override void CYSBHVYHWEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x999C4F0", Offset = "0x999B4F0", VA = "0x18999C4F0")]
		private JobHandle IDQHRZJAMJW(IntermediateVersionInfo<ReplicatorData_v1> a, FinalVersionInfo<ReplicatorData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0")]
		[Preserve]
		public OTGOFULHNPU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class RZBANNOEYIZ : MQCICDIZMOL
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
			[Cpp2IlInjected.Address(RVA = "0x9999D20", Offset = "0x9998D20", VA = "0x189999D20")]
			private void AZJIBKKIKUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9999F80", Offset = "0x9998F80", VA = "0x189999F80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x999F420", Offset = "0x999E420", VA = "0x18999F420", Slot = "14")]
		protected override void CYSBHVYHWEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x999F620", Offset = "0x999E620", VA = "0x18999F620")]
		private JobHandle IAHJLXINOTN(IntermediateVersionInfo<InventionInstanceIdData_v1> a, FinalVersionInfo<InventionInstanceIdData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0")]
		[Preserve]
		public RZBANNOEYIZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class PPNAMACFWPD : MQCICDIZMOL
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
			[Cpp2IlInjected.Address(RVA = "0x99A0410", Offset = "0x999F410", VA = "0x1899A0410")]
			private void AZJIBKKIKUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x99A09B0", Offset = "0x999F9B0", VA = "0x1899A09B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x999D820", Offset = "0x999C820", VA = "0x18999D820", Slot = "14")]
		protected override void CYSBHVYHWEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x999D670", Offset = "0x999C670", VA = "0x18999D670")]
		private JobHandle BHALJLXAMMV(IntermediateVersionInfo<TerrainWaterData_v1> a, IntermediateVersionInfo<TerrainWaterData_v2> b, FinalVersionInfo<TerrainWaterData> c, JobHandle d)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0")]
		[Preserve]
		public PPNAMACFWPD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class NUMVBHDYTRP : MQCICDIZMOL
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
			[Cpp2IlInjected.Address(RVA = "0x999BC70", Offset = "0x999AC70", VA = "0x18999BC70")]
			private void AZJIBKKIKUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x999BEF0", Offset = "0x999AEF0", VA = "0x18999BEF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x999ACA0", Offset = "0x9999CA0", VA = "0x18999ACA0", Slot = "14")]
		protected override void CYSBHVYHWEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x999AEA0", Offset = "0x9999EA0", VA = "0x18999AEA0")]
		private JobHandle XIWPHXEGDWP(IntermediateVersionInfo<OMShapeContainerData_v1> a, FinalVersionInfo<OMShapeContainerData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0")]
		[Preserve]
		public NUMVBHDYTRP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PHCWZXHBAIM : MQCICDIZMOL
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
			[Cpp2IlInjected.Address(RVA = "0x999A210", Offset = "0x9999210", VA = "0x18999A210")]
			private void AZJIBKKIKUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x999A4B0", Offset = "0x99994B0", VA = "0x18999A4B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x999D280", Offset = "0x999C280", VA = "0x18999D280", Slot = "14")]
		protected override void CYSBHVYHWEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x999D480", Offset = "0x999C480", VA = "0x18999D480")]
		private JobHandle XQBQDANBZQQ(IntermediateVersionInfo<MagneticAnchorData_v1> a, FinalVersionInfo<MagneticAnchorData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0")]
		[Preserve]
		public PHCWZXHBAIM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class OKWYFXDVRMK : MQCICDIZMOL
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
			[Cpp2IlInjected.Address(RVA = "0x9998B00", Offset = "0x9997B00", VA = "0x189998B00")]
			private void AZJIBKKIKUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9999140", Offset = "0x9998140", VA = "0x189999140", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x999B760", Offset = "0x999A760", VA = "0x18999B760", Slot = "14")]
		protected override void CYSBHVYHWEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x999BA30", Offset = "0x999AA30", VA = "0x18999BA30")]
		private JobHandle GXTFGNDAWFE(IntermediateVersionInfo<AuthoredAIIdData_v1> a, IntermediateVersionInfo<AuthoredAIIdData_v2> b, IntermediateVersionInfo<AuthoredAIIdData_v3> c, FinalVersionInfo<AuthoredAIIdData> d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0")]
		[Preserve]
		public OKWYFXDVRMK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class IXSKTZRKDAM : MQCICDIZMOL
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
			[Cpp2IlInjected.Address(RVA = "0x999DDC0", Offset = "0x999CDC0", VA = "0x18999DDC0")]
			private void AZJIBKKIKUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x999E030", Offset = "0x999D030", VA = "0x18999E030", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9999930", Offset = "0x9998930", VA = "0x189999930", Slot = "14")]
		protected override void CYSBHVYHWEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9999B30", Offset = "0x9998B30", VA = "0x189999B30")]
		private JobHandle MHCDUEBSDQA(IntermediateVersionInfo<ContainerCollisionLayerData_v1> a, FinalVersionInfo<PhysicsModelCollisionLayerData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0")]
		[Preserve]
		public IXSKTZRKDAM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class NRCDTJEVMUG : MQCICDIZMOL
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
			[Cpp2IlInjected.Address(RVA = "0x999E8A0", Offset = "0x999D8A0", VA = "0x18999E8A0")]
			private void AZJIBKKIKUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x999EB10", Offset = "0x999DB10", VA = "0x18999EB10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x999A8B0", Offset = "0x99998B0", VA = "0x18999A8B0", Slot = "14")]
		protected override void CYSBHVYHWEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x999AAB0", Offset = "0x9999AB0", VA = "0x18999AAB0")]
		private JobHandle OGMRVPDHKSW(IntermediateVersionInfo<ContainerGrabbableModeData_v1> a, FinalVersionInfo<PhysicsModelGrabbableModeData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0")]
		[Preserve]
		public NRCDTJEVMUG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public class QWXXXCQOMLE : MQCICDIZMOL
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
			[Cpp2IlInjected.Address(RVA = "0x999E2C0", Offset = "0x999D2C0", VA = "0x18999E2C0")]
			private void AZJIBKKIKUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x999E890", Offset = "0x999D890", VA = "0x18999E890", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x999EF10", Offset = "0x999DF10", VA = "0x18999EF10", Slot = "14")]
		protected override void CYSBHVYHWEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x999F1E0", Offset = "0x999E1E0", VA = "0x18999F1E0")]
		private JobHandle IDLJUKYKFVU(IntermediateVersionInfo<ContainerFlagsData_v1> a, IntermediateVersionInfo<ContainerFlagsData_v2> b, IntermediateVersionInfo<PhysicsModelFlagsData_v3> c, FinalVersionInfo<PhysicsModelFlagsData> d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0")]
		[Preserve]
		public QWXXXCQOMLE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public class QNJSSOSJYQW : MQCICDIZMOL
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
			[Cpp2IlInjected.Address(RVA = "0x999E040", Offset = "0x999D040", VA = "0x18999E040")]
			private void AZJIBKKIKUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x999E2B0", Offset = "0x999D2B0", VA = "0x18999E2B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x999EB20", Offset = "0x999DB20", VA = "0x18999EB20", Slot = "14")]
		protected override void CYSBHVYHWEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x999ED20", Offset = "0x999DD20", VA = "0x18999ED20")]
		private JobHandle LWGDUUJBMJZ(IntermediateVersionInfo<ContainerCollisionModeData_v1> a, FinalVersionInfo<PhysicsModelCollisionModeData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0")]
		[Preserve]
		public QNJSSOSJYQW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	public class OCDRRYOQETM : MQCICDIZMOL
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
			[Cpp2IlInjected.Address(RVA = "0x999C6E0", Offset = "0x999B6E0", VA = "0x18999C6E0")]
			private void AZJIBKKIKUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x999D270", Offset = "0x999C270", VA = "0x18999D270", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x999B090", Offset = "0x999A090", VA = "0x18999B090", Slot = "14")]
		protected override void CYSBHVYHWEX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x999B470", Offset = "0x999A470", VA = "0x18999B470")]
		private JobHandle TVBVQMABVZV(IntermediateVersionInfo<ObjectPolicyData_v1> a, IntermediateVersionInfo<ObjectPolicyData_v2> b, IntermediateVersionInfo<ObjectPolicyData_v3> c, IntermediateVersionInfo<ObjectPolicyData_v4> d, IntermediateVersionInfo<ObjectPolicyData_v5> e, FinalVersionInfo<ObjectPolicyData> f, JobHandle g)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2E525A0", Offset = "0x2E515A0", VA = "0x182E525A0")]
		[Preserve]
		public OCDRRYOQETM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class MEZSOSXJBIT
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3C33CB0", Offset = "0x3C32CB0", VA = "0x183C33CB0")]
		public static void YJAIOKDRGNV<T, U>(T a, [Out] U b) where T : struct where U : struct
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__97249924
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x99A1910", Offset = "0x99A0910", VA = "0x1899A1910")]
	public static void JUZPHBOHHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x99A1900", Offset = "0x99A0900", VA = "0x1899A1900")]
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
