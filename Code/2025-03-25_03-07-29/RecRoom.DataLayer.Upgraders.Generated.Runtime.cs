using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Burst;
using Unity.Entities;
using Unity.Jobs;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BC110", Offset = "0x9BB510", VA = "0x1809BC110")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class BAABBMHOLFP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x77C7240", Offset = "0x77C6640", VA = "0x1877C7240")]
	public static void AOADDCONJPA(ComponentSystemGroup KEPDMOAMLIH, EntityCommandBufferSystem KHCHOPBHPID)
	{
	}
}
namespace RecRoom.DataLayer
{
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
		[Cpp2IlInjected.Address(RVA = "0x77C7240", Offset = "0x77C6640", VA = "0x1877C7240")]
		public static void LAHFBGCKGIB(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x77CD730", Offset = "0x77CCB30", VA = "0x1877CD730")]
		private void AOADDCONJPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x77CDF80", Offset = "0x77CD380", VA = "0x1877CDF80")]
		private void NHEFLOODBHD(FJAOCJNHBPG system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : FJAOCJNHBPG
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public DFCOBCJFDKI<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public DGENBBNMJPI<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x77C9C80", Offset = "0x77C9080", VA = "0x1877C9C80")]
			private void LGJGGKAKAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x77C9C70", Offset = "0x77C9070", VA = "0x1877C9C70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ABDDJEPKCOD log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override ABDDJEPKCOD Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x77C9AF0", Offset = "0x77C8EF0", VA = "0x1877C9AF0", Slot = "14")]
			get
			{
				return default(ABDDJEPKCOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x77C9980", Offset = "0x77C8D80", VA = "0x1877C9980", Slot = "15")]
		protected override void BIOMHKNCIPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x77C9B40", Offset = "0x77C8F40", VA = "0x1877C9B40")]
		private JobHandle FGCNCKFOION(DFCOBCJFDKI<PersistentUserTagData_v1> component_1, DGENBBNMJPI<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287B050", VA = "0x18287BC50")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : FJAOCJNHBPG
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public DFCOBCJFDKI<LocalDeformableScaleData_v1> component_3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public DGENBBNMJPI<LocalDeformableScaleData> component_4;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x77C7C60", Offset = "0x77C7060", VA = "0x1877C7C60")]
			private void LGJGGKAKAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x77C7C50", Offset = "0x77C7050", VA = "0x1877C7C50", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ABDDJEPKCOD log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override ABDDJEPKCOD Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x77C7AD0", Offset = "0x77C6ED0", VA = "0x1877C7AD0", Slot = "14")]
			get
			{
				return default(ABDDJEPKCOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77C7960", Offset = "0x77C6D60", VA = "0x1877C7960", Slot = "15")]
		protected override void BIOMHKNCIPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77C7B20", Offset = "0x77C6F20", VA = "0x1877C7B20")]
		private JobHandle JFODNIMABPP(DFCOBCJFDKI<LocalDeformableScaleData_v1> component_3, DGENBBNMJPI<LocalDeformableScaleData> component_4, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287B050", VA = "0x18287BC50")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : FJAOCJNHBPG
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public DFCOBCJFDKI<SerializedDataLayerVersionData_v1> component_11;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public DGENBBNMJPI<SerializedDataLayerVersionData> component_12;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x77CCC80", Offset = "0x77CC080", VA = "0x1877CCC80")]
			private void LGJGGKAKAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x77CCC70", Offset = "0x77CC070", VA = "0x1877CCC70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ABDDJEPKCOD log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override ABDDJEPKCOD Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x77CCC20", Offset = "0x77CC020", VA = "0x1877CCC20", Slot = "14")]
			get
			{
				return default(ABDDJEPKCOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x77CCAB0", Offset = "0x77CBEB0", VA = "0x1877CCAB0", Slot = "15")]
		protected override void BIOMHKNCIPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x77CCF40", Offset = "0x77CC340", VA = "0x1877CCF40")]
		private JobHandle OHPCNAGEMPI(DFCOBCJFDKI<SerializedDataLayerVersionData_v1> component_11, DGENBBNMJPI<SerializedDataLayerVersionData> component_12, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287B050", VA = "0x18287BC50")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : FJAOCJNHBPG
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public DFCOBCJFDKI<ReplicatorPreallocatedObjectCountData_v1> component_19;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public DGENBBNMJPI<ReplicatorPreallocatedObjectCountData> component_20;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x77CC7A0", Offset = "0x77CBBA0", VA = "0x1877CC7A0")]
			private void LGJGGKAKAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x77CC790", Offset = "0x77CBB90", VA = "0x1877CC790", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly ABDDJEPKCOD log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override ABDDJEPKCOD Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x77CC740", Offset = "0x77CBB40", VA = "0x1877CC740", Slot = "14")]
			get
			{
				return default(ABDDJEPKCOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x77CC5D0", Offset = "0x77CB9D0", VA = "0x1877CC5D0", Slot = "15")]
		protected override void BIOMHKNCIPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x77CC4A0", Offset = "0x77CB8A0", VA = "0x1877CC4A0")]
		private JobHandle AJCDKFEPKAE(DFCOBCJFDKI<ReplicatorPreallocatedObjectCountData_v1> component_19, DGENBBNMJPI<ReplicatorPreallocatedObjectCountData> component_20, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287B050", VA = "0x18287BC50")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : FJAOCJNHBPG
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public DFCOBCJFDKI<ToolCleanupStatusData_v1> component_24;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public DGENBBNMJPI<ToolCleanupStatusData> component_25;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x77CD3C0", Offset = "0x77CC7C0", VA = "0x1877CD3C0")]
			private void LGJGGKAKAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x77CD3B0", Offset = "0x77CC7B0", VA = "0x1877CD3B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly ABDDJEPKCOD log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override ABDDJEPKCOD Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x77CD360", Offset = "0x77CC760", VA = "0x1877CD360", Slot = "14")]
			get
			{
				return default(ABDDJEPKCOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x77CD0C0", Offset = "0x77CC4C0", VA = "0x1877CD0C0", Slot = "15")]
		protected override void BIOMHKNCIPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x77CD230", Offset = "0x77CC630", VA = "0x1877CD230")]
		private JobHandle ECMBKENIDFO(DFCOBCJFDKI<ToolCleanupStatusData_v1> component_24, DGENBBNMJPI<ToolCleanupStatusData> component_25, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287B050", VA = "0x18287BC50")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : FJAOCJNHBPG
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public DFCOBCJFDKI<ReplicatorData_v1> component_31;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public DGENBBNMJPI<ReplicatorData> component_32;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x77CC150", Offset = "0x77CB550", VA = "0x1877CC150")]
			private void LGJGGKAKAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x77CC140", Offset = "0x77CB540", VA = "0x1877CC140", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly ABDDJEPKCOD log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override ABDDJEPKCOD Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x77CBFC0", Offset = "0x77CB3C0", VA = "0x1877CBFC0", Slot = "14")]
			get
			{
				return default(ABDDJEPKCOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x77CBE50", Offset = "0x77CB250", VA = "0x1877CBE50", Slot = "15")]
		protected override void BIOMHKNCIPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x77CC010", Offset = "0x77CB410", VA = "0x1877CC010")]
		private JobHandle IJLNKCEJEJB(DFCOBCJFDKI<ReplicatorData_v1> component_31, DGENBBNMJPI<ReplicatorData> component_32, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287B050", VA = "0x18287BC50")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : FJAOCJNHBPG
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public DFCOBCJFDKI<InventionInstanceIdData_v1> component_34;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public DGENBBNMJPI<InventionInstanceIdData> component_35;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x77C7530", Offset = "0x77C6930", VA = "0x1877C7530")]
			private void LGJGGKAKAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x77C7520", Offset = "0x77C6920", VA = "0x1877C7520", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly ABDDJEPKCOD log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override ABDDJEPKCOD Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x77C74D0", Offset = "0x77C68D0", VA = "0x1877C74D0", Slot = "14")]
			get
			{
				return default(ABDDJEPKCOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x77C7360", Offset = "0x77C6760", VA = "0x1877C7360", Slot = "15")]
		protected override void BIOMHKNCIPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x77C77E0", Offset = "0x77C6BE0", VA = "0x1877C77E0")]
		private JobHandle MHFELFFMJGC(DFCOBCJFDKI<InventionInstanceIdData_v1> component_34, DGENBBNMJPI<InventionInstanceIdData> component_35, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287B050", VA = "0x18287BC50")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : FJAOCJNHBPG
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public DFCOBCJFDKI<OMShapeContainerData_v1> component_37;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public DGENBBNMJPI<OMShapeContainerData> component_38;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x77C8290", Offset = "0x77C7690", VA = "0x1877C8290")]
			private void LGJGGKAKAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x77C8280", Offset = "0x77C7680", VA = "0x1877C8280", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly ABDDJEPKCOD log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override ABDDJEPKCOD Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x77C8100", Offset = "0x77C7500", VA = "0x1877C8100", Slot = "14")]
			get
			{
				return default(ABDDJEPKCOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x77C7F90", Offset = "0x77C7390", VA = "0x1877C7F90", Slot = "15")]
		protected override void BIOMHKNCIPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x77C8150", Offset = "0x77C7550", VA = "0x1877C8150")]
		private JobHandle LIDKIOAHCMI(DFCOBCJFDKI<OMShapeContainerData_v1> component_37, DGENBBNMJPI<OMShapeContainerData> component_38, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287B050", VA = "0x18287BC50")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : FJAOCJNHBPG
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public DFCOBCJFDKI<ContainerCollisionLayerData_v1> component_54;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public DGENBBNMJPI<PhysicsModelCollisionLayerData> component_55;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x77CA310", Offset = "0x77C9710", VA = "0x1877CA310")]
			private void LGJGGKAKAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x77CA300", Offset = "0x77C9700", VA = "0x1877CA300", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly ABDDJEPKCOD log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override ABDDJEPKCOD Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x77CA180", Offset = "0x77C9580", VA = "0x1877CA180", Slot = "14")]
			get
			{
				return default(ABDDJEPKCOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x77CA010", Offset = "0x77C9410", VA = "0x1877CA010", Slot = "15")]
		protected override void BIOMHKNCIPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x77CA1D0", Offset = "0x77C95D0", VA = "0x1877CA1D0")]
		private JobHandle KHCDCHFKBPG(DFCOBCJFDKI<ContainerCollisionLayerData_v1> component_54, DGENBBNMJPI<PhysicsModelCollisionLayerData> component_55, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287B050", VA = "0x18287BC50")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : FJAOCJNHBPG
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public DFCOBCJFDKI<ContainerGrabbableModeData_v1> component_58;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public DGENBBNMJPI<PhysicsModelGrabbableModeData> component_59;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x77CBB10", Offset = "0x77CAF10", VA = "0x1877CBB10")]
			private void LGJGGKAKAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x77CBB00", Offset = "0x77CAF00", VA = "0x1877CBB00", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly ABDDJEPKCOD log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override ABDDJEPKCOD Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x77CBAB0", Offset = "0x77CAEB0", VA = "0x1877CBAB0", Slot = "14")]
			get
			{
				return default(ABDDJEPKCOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x77CB810", Offset = "0x77CAC10", VA = "0x1877CB810", Slot = "15")]
		protected override void BIOMHKNCIPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x77CB980", Offset = "0x77CAD80", VA = "0x1877CB980")]
		private JobHandle EHJBGEPEKKM(DFCOBCJFDKI<ContainerGrabbableModeData_v1> component_58, DGENBBNMJPI<PhysicsModelGrabbableModeData> component_59, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287B050", VA = "0x18287BC50")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : FJAOCJNHBPG
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public DFCOBCJFDKI<ContainerFlagsData_v1> component_65;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public DFCOBCJFDKI<ContainerFlagsData_v2> component_66;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public DFCOBCJFDKI<PhysicsModelFlagsData_v3> component_67;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public DGENBBNMJPI<PhysicsModelFlagsData> component_68;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x77CB0F0", Offset = "0x77CA4F0", VA = "0x1877CB0F0")]
			private void LGJGGKAKAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x77CB0E0", Offset = "0x77CA4E0", VA = "0x1877CB0E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly ABDDJEPKCOD log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override ABDDJEPKCOD Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x77CB090", Offset = "0x77CA490", VA = "0x1877CB090", Slot = "14")]
			get
			{
				return default(ABDDJEPKCOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x77CAE30", Offset = "0x77CA230", VA = "0x1877CAE30", Slot = "15")]
		protected override void BIOMHKNCIPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x77CAC90", Offset = "0x77CA090", VA = "0x1877CAC90")]
		private JobHandle BENAIELPJBP(DFCOBCJFDKI<ContainerFlagsData_v1> component_65, DFCOBCJFDKI<ContainerFlagsData_v2> component_66, DFCOBCJFDKI<PhysicsModelFlagsData_v3> component_67, DGENBBNMJPI<PhysicsModelFlagsData> component_68, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287B050", VA = "0x18287BC50")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : FJAOCJNHBPG
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public DFCOBCJFDKI<ContainerCollisionModeData_v1> component_69;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public DGENBBNMJPI<PhysicsModelCollisionModeData> component_70;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x77CA950", Offset = "0x77C9D50", VA = "0x1877CA950")]
			private void LGJGGKAKAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x77CA940", Offset = "0x77C9D40", VA = "0x1877CA940", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly ABDDJEPKCOD log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override ABDDJEPKCOD Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x77CA8F0", Offset = "0x77C9CF0", VA = "0x1877CA8F0", Slot = "14")]
			get
			{
				return default(ABDDJEPKCOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x77CA650", Offset = "0x77C9A50", VA = "0x1877CA650", Slot = "15")]
		protected override void BIOMHKNCIPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x77CA7C0", Offset = "0x77C9BC0", VA = "0x1877CA7C0")]
		private JobHandle CJDDPAEFMFC(DFCOBCJFDKI<ContainerCollisionModeData_v1> component_69, DGENBBNMJPI<PhysicsModelCollisionModeData> component_70, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287B050", VA = "0x18287BC50")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : FJAOCJNHBPG
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public DFCOBCJFDKI<ObjectPolicyData_v1> component_73;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public DFCOBCJFDKI<ObjectPolicyData_v2> component_74;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public DFCOBCJFDKI<ObjectPolicyData_v3> component_75;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public DFCOBCJFDKI<ObjectPolicyData_v4> component_76;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public DFCOBCJFDKI<ObjectPolicyData_v5> component_77;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public DGENBBNMJPI<ObjectPolicyData> component_78;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x77C8B40", Offset = "0x77C7F40", VA = "0x1877C8B40")]
			private void LGJGGKAKAFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x77C8B30", Offset = "0x77C7F30", VA = "0x1877C8B30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly ABDDJEPKCOD log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override ABDDJEPKCOD Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x77C8AE0", Offset = "0x77C7EE0", VA = "0x1877C8AE0", Slot = "14")]
			get
			{
				return default(ABDDJEPKCOD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x77C85D0", Offset = "0x77C79D0", VA = "0x1877C85D0", Slot = "15")]
		protected override void BIOMHKNCIPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x77C88E0", Offset = "0x77C7CE0", VA = "0x1877C88E0")]
		private JobHandle ECLMKOBEOFC(DFCOBCJFDKI<ObjectPolicyData_v1> component_73, DFCOBCJFDKI<ObjectPolicyData_v2> component_74, DFCOBCJFDKI<ObjectPolicyData_v3> component_75, DFCOBCJFDKI<ObjectPolicyData_v4> component_76, DFCOBCJFDKI<ObjectPolicyData_v5> component_77, DGENBBNMJPI<ObjectPolicyData> component_78, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x287BC50", Offset = "0x287B050", VA = "0x18287BC50")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal static class HIMFBMGIAMD
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x35D9F60", Offset = "0x35D9360", VA = "0x1835D9F60")]
	public static void AGCBBFKBHJD<T, U>(T CHAOCCEIJLD, [Out] U NAPPKJDDPAA) where T : struct where U : struct
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
