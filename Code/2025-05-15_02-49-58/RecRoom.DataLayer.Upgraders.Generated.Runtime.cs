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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LDJDPHKMPAL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7BE36D0", Offset = "0x7BE1CD0", VA = "0x187BE36D0")]
	public static void FCOCAFDFJAD(ComponentSystemGroup FEHDPLGKCJJ, EntityCommandBufferSystem BMFKKHIJGPI)
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
		[Cpp2IlInjected.Address(RVA = "0x7BE36D0", Offset = "0x7BE1CD0", VA = "0x187BE36D0")]
		public static void HIJOEHLPAGF(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7BE95C0", Offset = "0x7BE7BC0", VA = "0x187BE95C0")]
		private void FCOCAFDFJAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9EB0", Offset = "0x7BE84B0", VA = "0x187BE9EB0")]
		private void OKOJBIOLINK(DIPDKNKLPLB system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : DIPDKNKLPLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public KPJNLPNNOBJ<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public JGFODANKMBD<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7BE5B00", Offset = "0x7BE4100", VA = "0x187BE5B00")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7BE5E40", Offset = "0x7BE4440", VA = "0x187BE5E40", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly JBBHIJHGEPM log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override JBBHIJHGEPM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7BE5980", Offset = "0x7BE3F80", VA = "0x187BE5980", Slot = "14")]
			get
			{
				return default(JBBHIJHGEPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7BE5810", Offset = "0x7BE3E10", VA = "0x187BE5810", Slot = "15")]
		protected override void BCNKFDIFGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7BE59D0", Offset = "0x7BE3FD0", VA = "0x187BE59D0")]
		private JobHandle JKGGMCEMPPK(KPJNLPNNOBJ<PersistentUserTagData_v1> component_1, JGFODANKMBD<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x29CEE50", Offset = "0x29CD450", VA = "0x1829CEE50")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : DIPDKNKLPLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public KPJNLPNNOBJ<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public JGFODANKMBD<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7BE3AE0", Offset = "0x7BE20E0", VA = "0x187BE3AE0")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7BE3DC0", Offset = "0x7BE23C0", VA = "0x187BE3DC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly JBBHIJHGEPM log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override JBBHIJHGEPM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7BE3A90", Offset = "0x7BE2090", VA = "0x187BE3A90", Slot = "14")]
			get
			{
				return default(JBBHIJHGEPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7BE37F0", Offset = "0x7BE1DF0", VA = "0x187BE37F0", Slot = "15")]
		protected override void BCNKFDIFGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7BE3960", Offset = "0x7BE1F60", VA = "0x187BE3960")]
		private JobHandle CFLNDPADJLJ(KPJNLPNNOBJ<LocalDeformableScaleData_v1> component_4, JGFODANKMBD<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x29CEE50", Offset = "0x29CD450", VA = "0x1829CEE50")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : DIPDKNKLPLB
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public KPJNLPNNOBJ<SerializedDataLayerVersionData_v1> component_12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public JGFODANKMBD<SerializedDataLayerVersionData> component_13;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7BE8C30", Offset = "0x7BE7230", VA = "0x187BE8C30")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7BE8EF0", Offset = "0x7BE74F0", VA = "0x187BE8EF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly JBBHIJHGEPM log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override JBBHIJHGEPM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7BE8AB0", Offset = "0x7BE70B0", VA = "0x187BE8AB0", Slot = "14")]
			get
			{
				return default(JBBHIJHGEPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7BE8940", Offset = "0x7BE6F40", VA = "0x187BE8940", Slot = "15")]
		protected override void BCNKFDIFGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7BE8B00", Offset = "0x7BE7100", VA = "0x187BE8B00")]
		private JobHandle IHAOMKJIEBA(KPJNLPNNOBJ<SerializedDataLayerVersionData_v1> component_12, JGFODANKMBD<SerializedDataLayerVersionData> component_13, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x29CEE50", Offset = "0x29CD450", VA = "0x1829CEE50")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : DIPDKNKLPLB
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public KPJNLPNNOBJ<ReplicatorPreallocatedObjectCountData_v1> component_21;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public JGFODANKMBD<ReplicatorPreallocatedObjectCountData> component_22;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7BE8620", Offset = "0x7BE6C20", VA = "0x187BE8620")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7BE88E0", Offset = "0x7BE6EE0", VA = "0x187BE88E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly JBBHIJHGEPM log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override JBBHIJHGEPM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7BE85D0", Offset = "0x7BE6BD0", VA = "0x187BE85D0", Slot = "14")]
			get
			{
				return default(JBBHIJHGEPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7BE8330", Offset = "0x7BE6930", VA = "0x187BE8330", Slot = "15")]
		protected override void BCNKFDIFGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7BE84A0", Offset = "0x7BE6AA0", VA = "0x187BE84A0")]
		private JobHandle DJGNACJGAKJ(KPJNLPNNOBJ<ReplicatorPreallocatedObjectCountData_v1> component_21, JGFODANKMBD<ReplicatorPreallocatedObjectCountData> component_22, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x29CEE50", Offset = "0x29CD450", VA = "0x1829CEE50")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : DIPDKNKLPLB
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public KPJNLPNNOBJ<ToolCleanupStatusData_v1> component_26;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public JGFODANKMBD<ToolCleanupStatusData> component_27;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7BE9240", Offset = "0x7BE7840", VA = "0x187BE9240")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7BE9560", Offset = "0x7BE7B60", VA = "0x187BE9560", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly JBBHIJHGEPM log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override JBBHIJHGEPM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7BE90C0", Offset = "0x7BE76C0", VA = "0x187BE90C0", Slot = "14")]
			get
			{
				return default(JBBHIJHGEPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7BE8F50", Offset = "0x7BE7550", VA = "0x187BE8F50", Slot = "15")]
		protected override void BCNKFDIFGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7BE9110", Offset = "0x7BE7710", VA = "0x187BE9110")]
		private JobHandle LNHDBHMNNHP(KPJNLPNNOBJ<ToolCleanupStatusData_v1> component_26, JGFODANKMBD<ToolCleanupStatusData> component_27, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x29CEE50", Offset = "0x29CD450", VA = "0x1829CEE50")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : DIPDKNKLPLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public KPJNLPNNOBJ<ReplicatorData_v1> component_34;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public JGFODANKMBD<ReplicatorData> component_35;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7BE7FD0", Offset = "0x7BE65D0", VA = "0x187BE7FD0")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7BE82D0", Offset = "0x7BE68D0", VA = "0x187BE82D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly JBBHIJHGEPM log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override JBBHIJHGEPM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7BE7E50", Offset = "0x7BE6450", VA = "0x187BE7E50", Slot = "14")]
			get
			{
				return default(JBBHIJHGEPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7BE7CE0", Offset = "0x7BE62E0", VA = "0x187BE7CE0", Slot = "15")]
		protected override void BCNKFDIFGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7BE7EA0", Offset = "0x7BE64A0", VA = "0x187BE7EA0")]
		private JobHandle JLEJIDLDCMA(KPJNLPNNOBJ<ReplicatorData_v1> component_34, JGFODANKMBD<ReplicatorData> component_35, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x29CEE50", Offset = "0x29CD450", VA = "0x1829CEE50")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : DIPDKNKLPLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public KPJNLPNNOBJ<InventionInstanceIdData_v1> component_38;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public JGFODANKMBD<InventionInstanceIdData> component_39;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7BE33C0", Offset = "0x7BE19C0", VA = "0x187BE33C0")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7BE3670", Offset = "0x7BE1C70", VA = "0x187BE3670", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly JBBHIJHGEPM log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override JBBHIJHGEPM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7BE3370", Offset = "0x7BE1970", VA = "0x187BE3370", Slot = "14")]
			get
			{
				return default(JBBHIJHGEPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7BE30D0", Offset = "0x7BE16D0", VA = "0x187BE30D0", Slot = "15")]
		protected override void BCNKFDIFGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7BE3240", Offset = "0x7BE1840", VA = "0x187BE3240")]
		private JobHandle DKEDNCGGAEJ(KPJNLPNNOBJ<InventionInstanceIdData_v1> component_38, JGFODANKMBD<InventionInstanceIdData> component_39, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x29CEE50", Offset = "0x29CD450", VA = "0x1829CEE50")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : DIPDKNKLPLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public KPJNLPNNOBJ<OMShapeContainerData_v1> component_42;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public JGFODANKMBD<OMShapeContainerData> component_43;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7BE4110", Offset = "0x7BE2710", VA = "0x187BE4110")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7BE4400", Offset = "0x7BE2A00", VA = "0x187BE4400", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly JBBHIJHGEPM log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override JBBHIJHGEPM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7BE40C0", Offset = "0x7BE26C0", VA = "0x187BE40C0", Slot = "14")]
			get
			{
				return default(JBBHIJHGEPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7BE3E20", Offset = "0x7BE2420", VA = "0x187BE3E20", Slot = "15")]
		protected override void BCNKFDIFGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7BE3F90", Offset = "0x7BE2590", VA = "0x187BE3F90")]
		private JobHandle CGHDJCIAAKE(KPJNLPNNOBJ<OMShapeContainerData_v1> component_42, JGFODANKMBD<OMShapeContainerData> component_43, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x29CEE50", Offset = "0x29CD450", VA = "0x1829CEE50")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : DIPDKNKLPLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public KPJNLPNNOBJ<AuthoredAIIdData_v1> component_51;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public KPJNLPNNOBJ<AuthoredAIIdData_v2> component_52;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public KPJNLPNNOBJ<AuthoredAIIdData_v3> component_53;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public JGFODANKMBD<AuthoredAIIdData> component_54;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7BE2950", Offset = "0x7BE0F50", VA = "0x187BE2950")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7BE3070", Offset = "0x7BE1670", VA = "0x187BE3070", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly JBBHIJHGEPM log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override JBBHIJHGEPM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7BE2900", Offset = "0x7BE0F00", VA = "0x187BE2900", Slot = "14")]
			get
			{
				return default(JBBHIJHGEPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2500", Offset = "0x7BE0B00", VA = "0x187BE2500", Slot = "15")]
		protected override void BCNKFDIFGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2760", Offset = "0x7BE0D60", VA = "0x187BE2760")]
		private JobHandle CPLCLLDIGJO(KPJNLPNNOBJ<AuthoredAIIdData_v1> component_51, KPJNLPNNOBJ<AuthoredAIIdData_v2> component_52, KPJNLPNNOBJ<AuthoredAIIdData_v3> component_53, JGFODANKMBD<AuthoredAIIdData> component_54, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x29CEE50", Offset = "0x29CD450", VA = "0x1829CEE50")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : DIPDKNKLPLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public KPJNLPNNOBJ<ContainerCollisionLayerData_v1> component_63;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public JGFODANKMBD<PhysicsModelCollisionLayerData> component_64;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7BE6190", Offset = "0x7BE4790", VA = "0x187BE6190")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7BE6480", Offset = "0x7BE4A80", VA = "0x187BE6480", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly JBBHIJHGEPM log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override JBBHIJHGEPM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7BE6140", Offset = "0x7BE4740", VA = "0x187BE6140", Slot = "14")]
			get
			{
				return default(JBBHIJHGEPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7BE5EA0", Offset = "0x7BE44A0", VA = "0x187BE5EA0", Slot = "15")]
		protected override void BCNKFDIFGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7BE6010", Offset = "0x7BE4610", VA = "0x187BE6010")]
		private JobHandle GKBKDNGHOOF(KPJNLPNNOBJ<ContainerCollisionLayerData_v1> component_63, JGFODANKMBD<PhysicsModelCollisionLayerData> component_64, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x29CEE50", Offset = "0x29CD450", VA = "0x1829CEE50")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : DIPDKNKLPLB
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public KPJNLPNNOBJ<ContainerGrabbableModeData_v1> component_67;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public JGFODANKMBD<PhysicsModelGrabbableModeData> component_68;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7BE7990", Offset = "0x7BE5F90", VA = "0x187BE7990")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7BE7C80", Offset = "0x7BE6280", VA = "0x187BE7C80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly JBBHIJHGEPM log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override JBBHIJHGEPM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7BE7940", Offset = "0x7BE5F40", VA = "0x187BE7940", Slot = "14")]
			get
			{
				return default(JBBHIJHGEPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7BE76A0", Offset = "0x7BE5CA0", VA = "0x187BE76A0", Slot = "15")]
		protected override void BCNKFDIFGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7BE7810", Offset = "0x7BE5E10", VA = "0x187BE7810")]
		private JobHandle HNEJLADLELO(KPJNLPNNOBJ<ContainerGrabbableModeData_v1> component_67, JGFODANKMBD<PhysicsModelGrabbableModeData> component_68, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x29CEE50", Offset = "0x29CD450", VA = "0x1829CEE50")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : DIPDKNKLPLB
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public KPJNLPNNOBJ<ContainerFlagsData_v1> component_75;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public KPJNLPNNOBJ<ContainerFlagsData_v2> component_76;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public KPJNLPNNOBJ<PhysicsModelFlagsData_v3> component_77;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public JGFODANKMBD<PhysicsModelFlagsData> component_78;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7BE6F70", Offset = "0x7BE5570", VA = "0x187BE6F70")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7BE7640", Offset = "0x7BE5C40", VA = "0x187BE7640", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly JBBHIJHGEPM log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override JBBHIJHGEPM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7BE6F20", Offset = "0x7BE5520", VA = "0x187BE6F20", Slot = "14")]
			get
			{
				return default(JBBHIJHGEPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7BE6B20", Offset = "0x7BE5120", VA = "0x187BE6B20", Slot = "15")]
		protected override void BCNKFDIFGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7BE6D80", Offset = "0x7BE5380", VA = "0x187BE6D80")]
		private JobHandle GEAHILDCHJC(KPJNLPNNOBJ<ContainerFlagsData_v1> component_75, KPJNLPNNOBJ<ContainerFlagsData_v2> component_76, KPJNLPNNOBJ<PhysicsModelFlagsData_v3> component_77, JGFODANKMBD<PhysicsModelFlagsData> component_78, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x29CEE50", Offset = "0x29CD450", VA = "0x1829CEE50")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : DIPDKNKLPLB
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public KPJNLPNNOBJ<ContainerCollisionModeData_v1> component_79;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public JGFODANKMBD<PhysicsModelCollisionModeData> component_80;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7BE67D0", Offset = "0x7BE4DD0", VA = "0x187BE67D0")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7BE6AC0", Offset = "0x7BE50C0", VA = "0x187BE6AC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly JBBHIJHGEPM log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override JBBHIJHGEPM Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7BE6650", Offset = "0x7BE4C50", VA = "0x187BE6650", Slot = "14")]
			get
			{
				return default(JBBHIJHGEPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7BE64E0", Offset = "0x7BE4AE0", VA = "0x187BE64E0", Slot = "15")]
		protected override void BCNKFDIFGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7BE66A0", Offset = "0x7BE4CA0", VA = "0x187BE66A0")]
		private JobHandle LLKKMFDAKGJ(KPJNLPNNOBJ<ContainerCollisionModeData_v1> component_79, JGFODANKMBD<PhysicsModelCollisionModeData> component_80, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x29CEE50", Offset = "0x29CD450", VA = "0x1829CEE50")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : DIPDKNKLPLB
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public KPJNLPNNOBJ<ObjectPolicyData_v1> component_83;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public KPJNLPNNOBJ<ObjectPolicyData_v2> component_84;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public KPJNLPNNOBJ<ObjectPolicyData_v3> component_85;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public KPJNLPNNOBJ<ObjectPolicyData_v4> component_86;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public KPJNLPNNOBJ<ObjectPolicyData_v5> component_87;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public JGFODANKMBD<ObjectPolicyData> component_88;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7BE49C0", Offset = "0x7BE2FC0", VA = "0x187BE49C0")]
			private void DJHBHCKJCAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7BE57B0", Offset = "0x7BE3DB0", VA = "0x187BE57B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly JBBHIJHGEPM log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override JBBHIJHGEPM Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7BE4970", Offset = "0x7BE2F70", VA = "0x187BE4970", Slot = "14")]
			get
			{
				return default(JBBHIJHGEPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4460", Offset = "0x7BE2A60", VA = "0x187BE4460", Slot = "15")]
		protected override void BCNKFDIFGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7BE4770", Offset = "0x7BE2D70", VA = "0x187BE4770")]
		private JobHandle BEFDPOPMIKH(KPJNLPNNOBJ<ObjectPolicyData_v1> component_83, KPJNLPNNOBJ<ObjectPolicyData_v2> component_84, KPJNLPNNOBJ<ObjectPolicyData_v3> component_85, KPJNLPNNOBJ<ObjectPolicyData_v4> component_86, KPJNLPNNOBJ<ObjectPolicyData_v5> component_87, JGFODANKMBD<ObjectPolicyData> component_88, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x29CEE50", Offset = "0x29CD450", VA = "0x1829CEE50")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class INNMKCCCKKD
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x38A6FA0", Offset = "0x38A55A0", VA = "0x1838A6FA0")]
	public static void KBAPHKKJIED<T, U>(T IFKAFBEGKEH, [Out] U IACIPAIGMFJ) where T : struct where U : struct
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
