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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DCIJAJDGFCC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7D799F0", Offset = "0x7D785F0", VA = "0x187D799F0")]
	public static void HFBBDCJJCAG(ComponentSystemGroup KAEEKMHMHPB, EntityCommandBufferSystem LACOBAHMAHJ)
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
		[Cpp2IlInjected.Address(RVA = "0x7D799F0", Offset = "0x7D785F0", VA = "0x187D799F0")]
		public static void JEDDPKBOMGJ(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D7FF70", Offset = "0x7D7EB70", VA = "0x187D7FF70")]
		private void HFBBDCJJCAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D7FEE0", Offset = "0x7D7EAE0", VA = "0x187D7FEE0")]
		private void DPOKEPAHKIB(AIBAPDFOPFD system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : AIBAPDFOPFD
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public IPJDCNNBHLJ<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public GNFBJJGCHCH<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7D7C430", Offset = "0x7D7B030", VA = "0x187D7C430")]
			private void MKOGAGGJLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7D7C420", Offset = "0x7D7B020", VA = "0x187D7C420", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly JPIBGNDAFKP log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override JPIBGNDAFKP Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7D7C3D0", Offset = "0x7D7AFD0", VA = "0x187D7C3D0", Slot = "14")]
			get
			{
				return default(JPIBGNDAFKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C260", Offset = "0x7D7AE60", VA = "0x187D7C260", Slot = "15")]
		protected override void DFPLLHNGAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C130", Offset = "0x7D7AD30", VA = "0x187D7C130")]
		private JobHandle DFDLENCEICB(IPJDCNNBHLJ<PersistentUserTagData_v1> component_1, GNFBJJGCHCH<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2390", Offset = "0x2BB0F90", VA = "0x182BB2390")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : AIBAPDFOPFD
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public IPJDCNNBHLJ<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public GNFBJJGCHCH<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7D7A410", Offset = "0x7D79010", VA = "0x187D7A410")]
			private void MKOGAGGJLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7D7A400", Offset = "0x7D79000", VA = "0x187D7A400", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly JPIBGNDAFKP log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override JPIBGNDAFKP Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7D7A3B0", Offset = "0x7D78FB0", VA = "0x187D7A3B0", Slot = "14")]
			get
			{
				return default(JPIBGNDAFKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A240", Offset = "0x7D78E40", VA = "0x187D7A240", Slot = "15")]
		protected override void DFPLLHNGAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A110", Offset = "0x7D78D10", VA = "0x187D7A110")]
		private JobHandle ADMGLPMKDFK(IPJDCNNBHLJ<LocalDeformableScaleData_v1> component_4, GNFBJJGCHCH<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2390", Offset = "0x2BB0F90", VA = "0x182BB2390")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : AIBAPDFOPFD
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public IPJDCNNBHLJ<SerializedDataLayerVersionData_v1> component_13;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public GNFBJJGCHCH<SerializedDataLayerVersionData> component_14;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7D7F430", Offset = "0x7D7E030", VA = "0x187D7F430")]
			private void MKOGAGGJLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7D7F420", Offset = "0x7D7E020", VA = "0x187D7F420", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly JPIBGNDAFKP log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override JPIBGNDAFKP Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7D7F3D0", Offset = "0x7D7DFD0", VA = "0x187D7F3D0", Slot = "14")]
			get
			{
				return default(JPIBGNDAFKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7D7F260", Offset = "0x7D7DE60", VA = "0x187D7F260", Slot = "15")]
		protected override void DFPLLHNGAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7D7F6F0", Offset = "0x7D7E2F0", VA = "0x187D7F6F0")]
		private JobHandle NEKKGFPHJBA(IPJDCNNBHLJ<SerializedDataLayerVersionData_v1> component_13, GNFBJJGCHCH<SerializedDataLayerVersionData> component_14, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2390", Offset = "0x2BB0F90", VA = "0x182BB2390")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : AIBAPDFOPFD
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public IPJDCNNBHLJ<ReplicatorPreallocatedObjectCountData_v1> component_21;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public GNFBJJGCHCH<ReplicatorPreallocatedObjectCountData> component_22;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7D7EF50", Offset = "0x7D7DB50", VA = "0x187D7EF50")]
			private void MKOGAGGJLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7D7EF40", Offset = "0x7D7DB40", VA = "0x187D7EF40", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly JPIBGNDAFKP log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override JPIBGNDAFKP Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7D7EEF0", Offset = "0x7D7DAF0", VA = "0x187D7EEF0", Slot = "14")]
			get
			{
				return default(JPIBGNDAFKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7D7ED80", Offset = "0x7D7D980", VA = "0x187D7ED80", Slot = "15")]
		protected override void DFPLLHNGAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7D7EC50", Offset = "0x7D7D850", VA = "0x187D7EC50")]
		private JobHandle CPKFJHHLJPC(IPJDCNNBHLJ<ReplicatorPreallocatedObjectCountData_v1> component_21, GNFBJJGCHCH<ReplicatorPreallocatedObjectCountData> component_22, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2390", Offset = "0x2BB0F90", VA = "0x182BB2390")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : AIBAPDFOPFD
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public IPJDCNNBHLJ<ToolCleanupStatusData_v1> component_26;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public GNFBJJGCHCH<ToolCleanupStatusData> component_27;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7D7FB70", Offset = "0x7D7E770", VA = "0x187D7FB70")]
			private void MKOGAGGJLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7D7FB60", Offset = "0x7D7E760", VA = "0x187D7FB60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly JPIBGNDAFKP log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override JPIBGNDAFKP Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7D7FB10", Offset = "0x7D7E710", VA = "0x187D7FB10", Slot = "14")]
			get
			{
				return default(JPIBGNDAFKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7D7F9A0", Offset = "0x7D7E5A0", VA = "0x187D7F9A0", Slot = "15")]
		protected override void DFPLLHNGAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7D7F870", Offset = "0x7D7E470", VA = "0x187D7F870")]
		private JobHandle CLBPFFNPAPF(IPJDCNNBHLJ<ToolCleanupStatusData_v1> component_26, GNFBJJGCHCH<ToolCleanupStatusData> component_27, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2390", Offset = "0x2BB0F90", VA = "0x182BB2390")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : AIBAPDFOPFD
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public IPJDCNNBHLJ<ReplicatorData_v1> component_34;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public GNFBJJGCHCH<ReplicatorData> component_35;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7D7E900", Offset = "0x7D7D500", VA = "0x187D7E900")]
			private void MKOGAGGJLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7D7E8F0", Offset = "0x7D7D4F0", VA = "0x187D7E8F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly JPIBGNDAFKP log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override JPIBGNDAFKP Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7D7E8A0", Offset = "0x7D7D4A0", VA = "0x187D7E8A0", Slot = "14")]
			get
			{
				return default(JPIBGNDAFKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7D7E600", Offset = "0x7D7D200", VA = "0x187D7E600", Slot = "15")]
		protected override void DFPLLHNGAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7D7E770", Offset = "0x7D7D370", VA = "0x187D7E770")]
		private JobHandle HFCEGMDMMJF(IPJDCNNBHLJ<ReplicatorData_v1> component_34, GNFBJJGCHCH<ReplicatorData> component_35, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2390", Offset = "0x2BB0F90", VA = "0x182BB2390")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : AIBAPDFOPFD
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public IPJDCNNBHLJ<InventionInstanceIdData_v1> component_38;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public GNFBJJGCHCH<InventionInstanceIdData> component_39;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7D79E10", Offset = "0x7D78A10", VA = "0x187D79E10")]
			private void MKOGAGGJLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7D79E00", Offset = "0x7D78A00", VA = "0x187D79E00", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly JPIBGNDAFKP log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override JPIBGNDAFKP Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7D79DB0", Offset = "0x7D789B0", VA = "0x187D79DB0", Slot = "14")]
			get
			{
				return default(JPIBGNDAFKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7D79C40", Offset = "0x7D78840", VA = "0x187D79C40", Slot = "15")]
		protected override void DFPLLHNGAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7D79B10", Offset = "0x7D78710", VA = "0x187D79B10")]
		private JobHandle AMNPMPCLELH(IPJDCNNBHLJ<InventionInstanceIdData_v1> component_38, GNFBJJGCHCH<InventionInstanceIdData> component_39, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2390", Offset = "0x2BB0F90", VA = "0x182BB2390")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : AIBAPDFOPFD
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public IPJDCNNBHLJ<OMShapeContainerData_v1> component_43;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public GNFBJJGCHCH<OMShapeContainerData> component_44;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7D7AA40", Offset = "0x7D79640", VA = "0x187D7AA40")]
			private void MKOGAGGJLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7D7AA30", Offset = "0x7D79630", VA = "0x187D7AA30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly JPIBGNDAFKP log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override JPIBGNDAFKP Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7D7A9E0", Offset = "0x7D795E0", VA = "0x187D7A9E0", Slot = "14")]
			get
			{
				return default(JPIBGNDAFKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A870", Offset = "0x7D79470", VA = "0x187D7A870", Slot = "15")]
		protected override void DFPLLHNGAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A740", Offset = "0x7D79340", VA = "0x187D7A740")]
		private JobHandle APNAIJBOMPG(IPJDCNNBHLJ<OMShapeContainerData_v1> component_43, GNFBJJGCHCH<OMShapeContainerData> component_44, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2390", Offset = "0x2BB0F90", VA = "0x182BB2390")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : AIBAPDFOPFD
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public IPJDCNNBHLJ<AuthoredAIIdData_v1> component_53;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IPJDCNNBHLJ<AuthoredAIIdData_v2> component_54;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public IPJDCNNBHLJ<AuthoredAIIdData_v3> component_55;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public GNFBJJGCHCH<AuthoredAIIdData> component_56;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7D79280", Offset = "0x7D77E80", VA = "0x187D79280")]
			private void MKOGAGGJLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7D79270", Offset = "0x7D77E70", VA = "0x187D79270", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly JPIBGNDAFKP log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override JPIBGNDAFKP Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7D79220", Offset = "0x7D77E20", VA = "0x187D79220", Slot = "14")]
			get
			{
				return default(JPIBGNDAFKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7D78E20", Offset = "0x7D77A20", VA = "0x187D78E20", Slot = "15")]
		protected override void DFPLLHNGAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7D79080", Offset = "0x7D77C80", VA = "0x187D79080")]
		private JobHandle GEPEFHNAHOA(IPJDCNNBHLJ<AuthoredAIIdData_v1> component_53, IPJDCNNBHLJ<AuthoredAIIdData_v2> component_54, IPJDCNNBHLJ<AuthoredAIIdData_v3> component_55, GNFBJJGCHCH<AuthoredAIIdData> component_56, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2390", Offset = "0x2BB0F90", VA = "0x182BB2390")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : AIBAPDFOPFD
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public IPJDCNNBHLJ<ContainerCollisionLayerData_v1> component_65;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public GNFBJJGCHCH<PhysicsModelCollisionLayerData> component_66;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7D7CAC0", Offset = "0x7D7B6C0", VA = "0x187D7CAC0")]
			private void MKOGAGGJLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7D7CAB0", Offset = "0x7D7B6B0", VA = "0x187D7CAB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly JPIBGNDAFKP log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override JPIBGNDAFKP Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7D7CA60", Offset = "0x7D7B660", VA = "0x187D7CA60", Slot = "14")]
			get
			{
				return default(JPIBGNDAFKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C7C0", Offset = "0x7D7B3C0", VA = "0x187D7C7C0", Slot = "15")]
		protected override void DFPLLHNGAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C930", Offset = "0x7D7B530", VA = "0x187D7C930")]
		private JobHandle DJOGIGHBPEB(IPJDCNNBHLJ<ContainerCollisionLayerData_v1> component_65, GNFBJJGCHCH<PhysicsModelCollisionLayerData> component_66, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2390", Offset = "0x2BB0F90", VA = "0x182BB2390")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : AIBAPDFOPFD
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public IPJDCNNBHLJ<ContainerGrabbableModeData_v1> component_69;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public GNFBJJGCHCH<PhysicsModelGrabbableModeData> component_70;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7D7E2C0", Offset = "0x7D7CEC0", VA = "0x187D7E2C0")]
			private void MKOGAGGJLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7D7E2B0", Offset = "0x7D7CEB0", VA = "0x187D7E2B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly JPIBGNDAFKP log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override JPIBGNDAFKP Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7D7E260", Offset = "0x7D7CE60", VA = "0x187D7E260", Slot = "14")]
			get
			{
				return default(JPIBGNDAFKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7D7DFC0", Offset = "0x7D7CBC0", VA = "0x187D7DFC0", Slot = "15")]
		protected override void DFPLLHNGAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7D7E130", Offset = "0x7D7CD30", VA = "0x187D7E130")]
		private JobHandle GHDICFCCNNM(IPJDCNNBHLJ<ContainerGrabbableModeData_v1> component_69, GNFBJJGCHCH<PhysicsModelGrabbableModeData> component_70, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2390", Offset = "0x2BB0F90", VA = "0x182BB2390")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : AIBAPDFOPFD
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public IPJDCNNBHLJ<ContainerFlagsData_v1> component_76;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public IPJDCNNBHLJ<ContainerFlagsData_v2> component_77;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public IPJDCNNBHLJ<PhysicsModelFlagsData_v3> component_78;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public GNFBJJGCHCH<PhysicsModelFlagsData> component_79;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7D7D8A0", Offset = "0x7D7C4A0", VA = "0x187D7D8A0")]
			private void MKOGAGGJLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7D7D890", Offset = "0x7D7C490", VA = "0x187D7D890", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly JPIBGNDAFKP log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override JPIBGNDAFKP Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7D7D840", Offset = "0x7D7C440", VA = "0x187D7D840", Slot = "14")]
			get
			{
				return default(JPIBGNDAFKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7D7D440", Offset = "0x7D7C040", VA = "0x187D7D440", Slot = "15")]
		protected override void DFPLLHNGAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7D7D6A0", Offset = "0x7D7C2A0", VA = "0x187D7D6A0")]
		private JobHandle IHGKOFJKEIF(IPJDCNNBHLJ<ContainerFlagsData_v1> component_76, IPJDCNNBHLJ<ContainerFlagsData_v2> component_77, IPJDCNNBHLJ<PhysicsModelFlagsData_v3> component_78, GNFBJJGCHCH<PhysicsModelFlagsData> component_79, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2390", Offset = "0x2BB0F90", VA = "0x182BB2390")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : AIBAPDFOPFD
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public IPJDCNNBHLJ<ContainerCollisionModeData_v1> component_80;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public GNFBJJGCHCH<PhysicsModelCollisionModeData> component_81;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7D7D100", Offset = "0x7D7BD00", VA = "0x187D7D100")]
			private void MKOGAGGJLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7D7D0F0", Offset = "0x7D7BCF0", VA = "0x187D7D0F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly JPIBGNDAFKP log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override JPIBGNDAFKP Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7D7D0A0", Offset = "0x7D7BCA0", VA = "0x187D7D0A0", Slot = "14")]
			get
			{
				return default(JPIBGNDAFKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7D7CF30", Offset = "0x7D7BB30", VA = "0x187D7CF30", Slot = "15")]
		protected override void DFPLLHNGAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7D7CE00", Offset = "0x7D7BA00", VA = "0x187D7CE00")]
		private JobHandle AGGNDMLBDAA(IPJDCNNBHLJ<ContainerCollisionModeData_v1> component_80, GNFBJJGCHCH<PhysicsModelCollisionModeData> component_81, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2390", Offset = "0x2BB0F90", VA = "0x182BB2390")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : AIBAPDFOPFD
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public IPJDCNNBHLJ<ObjectPolicyData_v1> component_84;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public IPJDCNNBHLJ<ObjectPolicyData_v2> component_85;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public IPJDCNNBHLJ<ObjectPolicyData_v3> component_86;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public IPJDCNNBHLJ<ObjectPolicyData_v4> component_87;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public IPJDCNNBHLJ<ObjectPolicyData_v5> component_88;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public GNFBJJGCHCH<ObjectPolicyData> component_89;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7D7B2F0", Offset = "0x7D79EF0", VA = "0x187D7B2F0")]
			private void MKOGAGGJLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7D7B2E0", Offset = "0x7D79EE0", VA = "0x187D7B2E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly JPIBGNDAFKP log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override JPIBGNDAFKP Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7D7B290", Offset = "0x7D79E90", VA = "0x187D7B290", Slot = "14")]
			get
			{
				return default(JPIBGNDAFKP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7D7AF80", Offset = "0x7D79B80", VA = "0x187D7AF80", Slot = "15")]
		protected override void DFPLLHNGAAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7D7AD80", Offset = "0x7D79980", VA = "0x187D7AD80")]
		private JobHandle AIIOFOMGOKM(IPJDCNNBHLJ<ObjectPolicyData_v1> component_84, IPJDCNNBHLJ<ObjectPolicyData_v2> component_85, IPJDCNNBHLJ<ObjectPolicyData_v3> component_86, IPJDCNNBHLJ<ObjectPolicyData_v4> component_87, IPJDCNNBHLJ<ObjectPolicyData_v5> component_88, GNFBJJGCHCH<ObjectPolicyData> component_89, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2BB2390", Offset = "0x2BB0F90", VA = "0x182BB2390")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class EOCOKOGDFBO
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3915DA0", Offset = "0x39149A0", VA = "0x183915DA0")]
	public static void JAOMNPNJHME<T, U>(T DMHGCKEGLMH, [Out] U HOHHCCFFPGD) where T : struct where U : struct
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
