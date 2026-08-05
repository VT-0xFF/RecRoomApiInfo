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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ICHJGLBBHFC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x811D2D0", Offset = "0x811C2D0", VA = "0x18811D2D0")]
	public static void HOKCIJHHPNL(ComponentSystemGroup HNLEHANEADB, EntityCommandBufferSystem JBGMPAMKJCA)
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
		[Cpp2IlInjected.Address(RVA = "0x811D2D0", Offset = "0x811C2D0", VA = "0x18811D2D0")]
		public static void IDFIANBMNNF(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8123850", Offset = "0x8122850", VA = "0x188123850")]
		private void HOKCIJHHPNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x81237C0", Offset = "0x81227C0", VA = "0x1881237C0")]
		private void CMKMNDPGPGN(MCADHMFACDO system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : MCADHMFACDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public LJPLGBJHLAD<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public MBCGLIGAPCC<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x811FD10", Offset = "0x811ED10", VA = "0x18811FD10")]
			private void IPDILOFAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x811FD00", Offset = "0x811ED00", VA = "0x18811FD00", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ONIHMLNNEEF log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override ONIHMLNNEEF Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x811FCB0", Offset = "0x811ECB0", VA = "0x18811FCB0", Slot = "14")]
			get
			{
				return default(ONIHMLNNEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x811FB40", Offset = "0x811EB40", VA = "0x18811FB40", Slot = "15")]
		protected override void JMDHHKBHBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x811FA10", Offset = "0x811EA10", VA = "0x18811FA10")]
		private JobHandle FGPPCCFGKHH(LJPLGBJHLAD<PersistentUserTagData_v1> component_1, MBCGLIGAPCC<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB670", Offset = "0x2CDA670", VA = "0x182CDB670")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : MCADHMFACDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public LJPLGBJHLAD<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public MBCGLIGAPCC<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x811DBC0", Offset = "0x811CBC0", VA = "0x18811DBC0")]
			private void IPDILOFAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x811DBB0", Offset = "0x811CBB0", VA = "0x18811DBB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly ONIHMLNNEEF log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override ONIHMLNNEEF Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x811DB60", Offset = "0x811CB60", VA = "0x18811DB60", Slot = "14")]
			get
			{
				return default(ONIHMLNNEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x811D9F0", Offset = "0x811C9F0", VA = "0x18811D9F0", Slot = "15")]
		protected override void JMDHHKBHBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x811DEA0", Offset = "0x811CEA0", VA = "0x18811DEA0")]
		private JobHandle PGLCEOHAMOB(LJPLGBJHLAD<LocalDeformableScaleData_v1> component_4, MBCGLIGAPCC<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB670", Offset = "0x2CDA670", VA = "0x182CDB670")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : MCADHMFACDO
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public LJPLGBJHLAD<SerializedDataLayerVersionData_v1> component_15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public MBCGLIGAPCC<SerializedDataLayerVersionData> component_16;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8122E40", Offset = "0x8121E40", VA = "0x188122E40")]
			private void IPDILOFAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8122E30", Offset = "0x8121E30", VA = "0x188122E30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly ONIHMLNNEEF log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override ONIHMLNNEEF Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8122DE0", Offset = "0x8121DE0", VA = "0x188122DE0", Slot = "14")]
			get
			{
				return default(ONIHMLNNEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8122C70", Offset = "0x8121C70", VA = "0x188122C70", Slot = "15")]
		protected override void JMDHHKBHBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8122B40", Offset = "0x8121B40", VA = "0x188122B40")]
		private JobHandle IGCJGKDDPBA(LJPLGBJHLAD<SerializedDataLayerVersionData_v1> component_15, MBCGLIGAPCC<SerializedDataLayerVersionData> component_16, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB670", Offset = "0x2CDA670", VA = "0x182CDB670")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : MCADHMFACDO
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public LJPLGBJHLAD<ReplicatorPreallocatedObjectCountData_v1> component_23;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public MBCGLIGAPCC<ReplicatorPreallocatedObjectCountData> component_24;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8122830", Offset = "0x8121830", VA = "0x188122830")]
			private void IPDILOFAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8122820", Offset = "0x8121820", VA = "0x188122820", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly ONIHMLNNEEF log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override ONIHMLNNEEF Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x81227D0", Offset = "0x81217D0", VA = "0x1881227D0", Slot = "14")]
			get
			{
				return default(ONIHMLNNEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8122660", Offset = "0x8121660", VA = "0x188122660", Slot = "15")]
		protected override void JMDHHKBHBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8122530", Offset = "0x8121530", VA = "0x188122530")]
		private JobHandle IOHHJEIGGHG(LJPLGBJHLAD<ReplicatorPreallocatedObjectCountData_v1> component_23, MBCGLIGAPCC<ReplicatorPreallocatedObjectCountData> component_24, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB670", Offset = "0x2CDA670", VA = "0x182CDB670")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : MCADHMFACDO
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public LJPLGBJHLAD<ToolCleanupStatusData_v1> component_28;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public MBCGLIGAPCC<ToolCleanupStatusData> component_29;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8123450", Offset = "0x8122450", VA = "0x188123450")]
			private void IPDILOFAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8123440", Offset = "0x8122440", VA = "0x188123440", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly ONIHMLNNEEF log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override ONIHMLNNEEF Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x81233F0", Offset = "0x81223F0", VA = "0x1881233F0", Slot = "14")]
			get
			{
				return default(ONIHMLNNEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8123280", Offset = "0x8122280", VA = "0x188123280", Slot = "15")]
		protected override void JMDHHKBHBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8123150", Offset = "0x8122150", VA = "0x188123150")]
		private JobHandle ALLODOPNJJC(LJPLGBJHLAD<ToolCleanupStatusData_v1> component_28, MBCGLIGAPCC<ToolCleanupStatusData> component_29, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB670", Offset = "0x2CDA670", VA = "0x182CDB670")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : MCADHMFACDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public LJPLGBJHLAD<ReplicatorData_v1> component_38;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public MBCGLIGAPCC<ReplicatorData> component_39;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x81221E0", Offset = "0x81211E0", VA = "0x1881221E0")]
			private void IPDILOFAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x81221D0", Offset = "0x81211D0", VA = "0x1881221D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly ONIHMLNNEEF log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override ONIHMLNNEEF Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8122180", Offset = "0x8121180", VA = "0x188122180", Slot = "14")]
			get
			{
				return default(ONIHMLNNEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8122010", Offset = "0x8121010", VA = "0x188122010", Slot = "15")]
		protected override void JMDHHKBHBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8121EE0", Offset = "0x8120EE0", VA = "0x188121EE0")]
		private JobHandle AJKFBFFBLJH(LJPLGBJHLAD<ReplicatorData_v1> component_38, MBCGLIGAPCC<ReplicatorData> component_39, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB670", Offset = "0x2CDA670", VA = "0x182CDB670")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : MCADHMFACDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public LJPLGBJHLAD<InventionInstanceIdData_v1> component_42;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public MBCGLIGAPCC<InventionInstanceIdData> component_43;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x811D6F0", Offset = "0x811C6F0", VA = "0x18811D6F0")]
			private void IPDILOFAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x811D6E0", Offset = "0x811C6E0", VA = "0x18811D6E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly ONIHMLNNEEF log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override ONIHMLNNEEF Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x811D560", Offset = "0x811C560", VA = "0x18811D560", Slot = "14")]
			get
			{
				return default(ONIHMLNNEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x811D3F0", Offset = "0x811C3F0", VA = "0x18811D3F0", Slot = "15")]
		protected override void JMDHHKBHBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x811D5B0", Offset = "0x811C5B0", VA = "0x18811D5B0")]
		private JobHandle LLOENFFBFND(LJPLGBJHLAD<InventionInstanceIdData_v1> component_42, MBCGLIGAPCC<InventionInstanceIdData> component_43, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB670", Offset = "0x2CDA670", VA = "0x182CDB670")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : MCADHMFACDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public LJPLGBJHLAD<OMShapeContainerData_v1> component_47;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public MBCGLIGAPCC<OMShapeContainerData> component_48;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x811E1F0", Offset = "0x811D1F0", VA = "0x18811E1F0")]
			private void IPDILOFAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x811E1E0", Offset = "0x811D1E0", VA = "0x18811E1E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly ONIHMLNNEEF log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override ONIHMLNNEEF Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x811E190", Offset = "0x811D190", VA = "0x18811E190", Slot = "14")]
			get
			{
				return default(ONIHMLNNEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x811E020", Offset = "0x811D020", VA = "0x18811E020", Slot = "15")]
		protected override void JMDHHKBHBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x811E4E0", Offset = "0x811D4E0", VA = "0x18811E4E0")]
		private JobHandle PPHGMLMCNGE(LJPLGBJHLAD<OMShapeContainerData_v1> component_47, MBCGLIGAPCC<OMShapeContainerData> component_48, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB670", Offset = "0x2CDA670", VA = "0x182CDB670")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : MCADHMFACDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public LJPLGBJHLAD<AuthoredAIIdData_v1> component_57;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public LJPLGBJHLAD<AuthoredAIIdData_v2> component_58;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public LJPLGBJHLAD<AuthoredAIIdData_v3> component_59;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public MBCGLIGAPCC<AuthoredAIIdData> component_60;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x811CB60", Offset = "0x811BB60", VA = "0x18811CB60")]
			private void IPDILOFAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x811CB50", Offset = "0x811BB50", VA = "0x18811CB50", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly ONIHMLNNEEF log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override ONIHMLNNEEF Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x811CB00", Offset = "0x811BB00", VA = "0x18811CB00", Slot = "14")]
			get
			{
				return default(ONIHMLNNEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x811C8A0", Offset = "0x811B8A0", VA = "0x18811C8A0", Slot = "15")]
		protected override void JMDHHKBHBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x811C700", Offset = "0x811B700", VA = "0x18811C700")]
		private JobHandle HHGHMONAAJI(LJPLGBJHLAD<AuthoredAIIdData_v1> component_57, LJPLGBJHLAD<AuthoredAIIdData_v2> component_58, LJPLGBJHLAD<AuthoredAIIdData_v3> component_59, MBCGLIGAPCC<AuthoredAIIdData> component_60, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB670", Offset = "0x2CDA670", VA = "0x182CDB670")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : MCADHMFACDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public LJPLGBJHLAD<ContainerCollisionLayerData_v1> component_70;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public MBCGLIGAPCC<PhysicsModelCollisionLayerData> component_71;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x81203A0", Offset = "0x811F3A0", VA = "0x1881203A0")]
			private void IPDILOFAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8120390", Offset = "0x811F390", VA = "0x188120390", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly ONIHMLNNEEF log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override ONIHMLNNEEF Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8120340", Offset = "0x811F340", VA = "0x188120340", Slot = "14")]
			get
			{
				return default(ONIHMLNNEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x81201D0", Offset = "0x811F1D0", VA = "0x1881201D0", Slot = "15")]
		protected override void JMDHHKBHBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x81200A0", Offset = "0x811F0A0", VA = "0x1881200A0")]
		private JobHandle JFHAPPNPDKP(LJPLGBJHLAD<ContainerCollisionLayerData_v1> component_70, MBCGLIGAPCC<PhysicsModelCollisionLayerData> component_71, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB670", Offset = "0x2CDA670", VA = "0x182CDB670")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : MCADHMFACDO
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public LJPLGBJHLAD<ContainerGrabbableModeData_v1> component_75;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public MBCGLIGAPCC<PhysicsModelGrabbableModeData> component_76;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8121A70", Offset = "0x8120A70", VA = "0x188121A70")]
			private void IPDILOFAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8121A60", Offset = "0x8120A60", VA = "0x188121A60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly ONIHMLNNEEF log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override ONIHMLNNEEF Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8121A10", Offset = "0x8120A10", VA = "0x188121A10", Slot = "14")]
			get
			{
				return default(ONIHMLNNEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x81218A0", Offset = "0x81208A0", VA = "0x1881218A0", Slot = "15")]
		protected override void JMDHHKBHBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8121D60", Offset = "0x8120D60", VA = "0x188121D60")]
		private JobHandle NOBGMDANGOM(LJPLGBJHLAD<ContainerGrabbableModeData_v1> component_75, MBCGLIGAPCC<PhysicsModelGrabbableModeData> component_76, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB670", Offset = "0x2CDA670", VA = "0x182CDB670")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : MCADHMFACDO
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public LJPLGBJHLAD<ContainerFlagsData_v1> component_82;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public LJPLGBJHLAD<ContainerFlagsData_v2> component_83;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public LJPLGBJHLAD<PhysicsModelFlagsData_v3> component_84;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public MBCGLIGAPCC<PhysicsModelFlagsData> component_85;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8121180", Offset = "0x8120180", VA = "0x188121180")]
			private void IPDILOFAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8121170", Offset = "0x8120170", VA = "0x188121170", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly ONIHMLNNEEF log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override ONIHMLNNEEF Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8120F80", Offset = "0x811FF80", VA = "0x188120F80", Slot = "14")]
			get
			{
				return default(ONIHMLNNEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8120D20", Offset = "0x811FD20", VA = "0x188120D20", Slot = "15")]
		protected override void JMDHHKBHBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8120FD0", Offset = "0x811FFD0", VA = "0x188120FD0")]
		private JobHandle LMIFBPMONMK(LJPLGBJHLAD<ContainerFlagsData_v1> component_82, LJPLGBJHLAD<ContainerFlagsData_v2> component_83, LJPLGBJHLAD<PhysicsModelFlagsData_v3> component_84, MBCGLIGAPCC<PhysicsModelFlagsData> component_85, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB670", Offset = "0x2CDA670", VA = "0x182CDB670")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : MCADHMFACDO
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public LJPLGBJHLAD<ContainerCollisionModeData_v1> component_86;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public MBCGLIGAPCC<PhysicsModelCollisionModeData> component_87;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x81208B0", Offset = "0x811F8B0", VA = "0x1881208B0")]
			private void IPDILOFAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x81208A0", Offset = "0x811F8A0", VA = "0x1881208A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly ONIHMLNNEEF log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override ONIHMLNNEEF Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8120850", Offset = "0x811F850", VA = "0x188120850", Slot = "14")]
			get
			{
				return default(ONIHMLNNEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x81206E0", Offset = "0x811F6E0", VA = "0x1881206E0", Slot = "15")]
		protected override void JMDHHKBHBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8120BA0", Offset = "0x811FBA0", VA = "0x188120BA0")]
		private JobHandle NBBJKEGJFHN(LJPLGBJHLAD<ContainerCollisionModeData_v1> component_86, MBCGLIGAPCC<PhysicsModelCollisionModeData> component_87, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB670", Offset = "0x2CDA670", VA = "0x182CDB670")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : MCADHMFACDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public LJPLGBJHLAD<ObjectPolicyData_v1> component_90;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public LJPLGBJHLAD<ObjectPolicyData_v2> component_91;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public LJPLGBJHLAD<ObjectPolicyData_v3> component_92;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public LJPLGBJHLAD<ObjectPolicyData_v4> component_93;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public LJPLGBJHLAD<ObjectPolicyData_v5> component_94;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public MBCGLIGAPCC<ObjectPolicyData> component_95;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x811E9D0", Offset = "0x811D9D0", VA = "0x18811E9D0")]
			private void IPDILOFAIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x811E9C0", Offset = "0x811D9C0", VA = "0x18811E9C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly ONIHMLNNEEF log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override ONIHMLNNEEF Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x811E970", Offset = "0x811D970", VA = "0x18811E970", Slot = "14")]
			get
			{
				return default(ONIHMLNNEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x811E660", Offset = "0x811D660", VA = "0x18811E660", Slot = "15")]
		protected override void JMDHHKBHBDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x811F7C0", Offset = "0x811E7C0", VA = "0x18811F7C0")]
		private JobHandle NMNBLBAGOHD(LJPLGBJHLAD<ObjectPolicyData_v1> component_90, LJPLGBJHLAD<ObjectPolicyData_v2> component_91, LJPLGBJHLAD<ObjectPolicyData_v3> component_92, LJPLGBJHLAD<ObjectPolicyData_v4> component_93, LJPLGBJHLAD<ObjectPolicyData_v5> component_94, MBCGLIGAPCC<ObjectPolicyData> component_95, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2CDB670", Offset = "0x2CDA670", VA = "0x182CDB670")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class COPANKPJDOB
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3A435A0", Offset = "0x3A425A0", VA = "0x183A435A0")]
	public static void BFCDNMFFECJ<T, U>(T PGAEDBIFHEJ, [Out] U OMMNLCHPNAM) where T : struct where U : struct
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
