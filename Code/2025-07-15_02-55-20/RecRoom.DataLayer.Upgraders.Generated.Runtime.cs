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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IFNFALBPPEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x80A9A10", Offset = "0x80A8610", VA = "0x1880A9A10")]
	public static void KLHHNAALEOB(ComponentSystemGroup KAPGMCDEGPH, EntityCommandBufferSystem HOJDMKEGOCA)
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
		[Cpp2IlInjected.Address(RVA = "0x80A9A10", Offset = "0x80A8610", VA = "0x1880A9A10")]
		public static void ABJAAPMNOIE(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x80AFF90", Offset = "0x80AEB90", VA = "0x1880AFF90")]
		private void KLHHNAALEOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x80AFF00", Offset = "0x80AEB00", VA = "0x1880AFF00")]
		private void AIBMPOHPFCJ(CJKPIPFJMAE system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : CJKPIPFJMAE
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public JBGCLPFGPEH<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public LANINFCEMGC<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x80AC2E0", Offset = "0x80AAEE0", VA = "0x1880AC2E0")]
			private void FOBOJFMNNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x80AC2D0", Offset = "0x80AAED0", VA = "0x1880AC2D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly PEOHNMCPNIJ log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override PEOHNMCPNIJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x80AC150", Offset = "0x80AAD50", VA = "0x1880AC150", Slot = "14")]
			get
			{
				return default(PEOHNMCPNIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x80AC620", Offset = "0x80AB220", VA = "0x1880AC620", Slot = "15")]
		protected override void OBEJJCMJBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80AC1A0", Offset = "0x80AADA0", VA = "0x1880AC1A0")]
		private JobHandle IHHOAPBGHNB(JBGCLPFGPEH<PersistentUserTagData_v1> component_1, LANINFCEMGC<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4A60", Offset = "0x2CB3660", VA = "0x182CB4A60")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : CJKPIPFJMAE
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public JBGCLPFGPEH<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public LANINFCEMGC<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x80AA190", Offset = "0x80A8D90", VA = "0x1880AA190")]
			private void FOBOJFMNNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x80AA180", Offset = "0x80A8D80", VA = "0x1880AA180", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly PEOHNMCPNIJ log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override PEOHNMCPNIJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x80AA130", Offset = "0x80A8D30", VA = "0x1880AA130", Slot = "14")]
			get
			{
				return default(PEOHNMCPNIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x80AA5A0", Offset = "0x80A91A0", VA = "0x1880AA5A0", Slot = "15")]
		protected override void OBEJJCMJBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80AA470", Offset = "0x80A9070", VA = "0x1880AA470")]
		private JobHandle MFPLMGJILLB(JBGCLPFGPEH<LocalDeformableScaleData_v1> component_4, LANINFCEMGC<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4A60", Offset = "0x2CB3660", VA = "0x182CB4A60")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : CJKPIPFJMAE
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public JBGCLPFGPEH<SerializedDataLayerVersionData_v1> component_15;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public LANINFCEMGC<SerializedDataLayerVersionData> component_16;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x80AF410", Offset = "0x80AE010", VA = "0x1880AF410")]
			private void FOBOJFMNNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x80AF400", Offset = "0x80AE000", VA = "0x1880AF400", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly PEOHNMCPNIJ log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override PEOHNMCPNIJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x80AF280", Offset = "0x80ADE80", VA = "0x1880AF280", Slot = "14")]
			get
			{
				return default(PEOHNMCPNIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80AF6D0", Offset = "0x80AE2D0", VA = "0x1880AF6D0", Slot = "15")]
		protected override void OBEJJCMJBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x80AF2D0", Offset = "0x80ADED0", VA = "0x1880AF2D0")]
		private JobHandle FDKACEIBFCG(JBGCLPFGPEH<SerializedDataLayerVersionData_v1> component_15, LANINFCEMGC<SerializedDataLayerVersionData> component_16, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4A60", Offset = "0x2CB3660", VA = "0x182CB4A60")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : CJKPIPFJMAE
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public JBGCLPFGPEH<ReplicatorPreallocatedObjectCountData_v1> component_23;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public LANINFCEMGC<ReplicatorPreallocatedObjectCountData> component_24;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x80AECD0", Offset = "0x80AD8D0", VA = "0x1880AECD0")]
			private void FOBOJFMNNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x80AECC0", Offset = "0x80AD8C0", VA = "0x1880AECC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly PEOHNMCPNIJ log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override PEOHNMCPNIJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x80AEC70", Offset = "0x80AD870", VA = "0x1880AEC70", Slot = "14")]
			get
			{
				return default(PEOHNMCPNIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x80AF0C0", Offset = "0x80ADCC0", VA = "0x1880AF0C0", Slot = "15")]
		protected override void OBEJJCMJBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x80AEF90", Offset = "0x80ADB90", VA = "0x1880AEF90")]
		private JobHandle MLFOGMCELLO(JBGCLPFGPEH<ReplicatorPreallocatedObjectCountData_v1> component_23, LANINFCEMGC<ReplicatorPreallocatedObjectCountData> component_24, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4A60", Offset = "0x2CB3660", VA = "0x182CB4A60")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : CJKPIPFJMAE
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public JBGCLPFGPEH<ToolCleanupStatusData_v1> component_28;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public LANINFCEMGC<ToolCleanupStatusData> component_29;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x80AFA20", Offset = "0x80AE620", VA = "0x1880AFA20")]
			private void FOBOJFMNNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x80AFA10", Offset = "0x80AE610", VA = "0x1880AFA10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly PEOHNMCPNIJ log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override PEOHNMCPNIJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x80AF9C0", Offset = "0x80AE5C0", VA = "0x1880AF9C0", Slot = "14")]
			get
			{
				return default(PEOHNMCPNIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x80AFD40", Offset = "0x80AE940", VA = "0x1880AFD40", Slot = "15")]
		protected override void OBEJJCMJBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x80AF890", Offset = "0x80AE490", VA = "0x1880AF890")]
		private JobHandle CFBEBANHABM(JBGCLPFGPEH<ToolCleanupStatusData_v1> component_28, LANINFCEMGC<ToolCleanupStatusData> component_29, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4A60", Offset = "0x2CB3660", VA = "0x182CB4A60")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : CJKPIPFJMAE
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public JBGCLPFGPEH<ReplicatorData_v1> component_38;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public LANINFCEMGC<ReplicatorData> component_39;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x80AE680", Offset = "0x80AD280", VA = "0x1880AE680")]
			private void FOBOJFMNNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x80AE670", Offset = "0x80AD270", VA = "0x1880AE670", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly PEOHNMCPNIJ log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override PEOHNMCPNIJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x80AE620", Offset = "0x80AD220", VA = "0x1880AE620", Slot = "14")]
			get
			{
				return default(PEOHNMCPNIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x80AE980", Offset = "0x80AD580", VA = "0x1880AE980", Slot = "15")]
		protected override void OBEJJCMJBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x80AEAF0", Offset = "0x80AD6F0", VA = "0x1880AEAF0")]
		private JobHandle ODGOFDIJBEO(JBGCLPFGPEH<ReplicatorData_v1> component_38, LANINFCEMGC<ReplicatorData> component_39, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4A60", Offset = "0x2CB3660", VA = "0x182CB4A60")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : CJKPIPFJMAE
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public JBGCLPFGPEH<InventionInstanceIdData_v1> component_42;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public LANINFCEMGC<InventionInstanceIdData> component_43;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x80A9B90", Offset = "0x80A8790", VA = "0x1880A9B90")]
			private void FOBOJFMNNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x80A9B80", Offset = "0x80A8780", VA = "0x1880A9B80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly PEOHNMCPNIJ log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override PEOHNMCPNIJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x80A9B30", Offset = "0x80A8730", VA = "0x1880A9B30", Slot = "14")]
			get
			{
				return default(PEOHNMCPNIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x80A9E40", Offset = "0x80A8A40", VA = "0x1880A9E40", Slot = "15")]
		protected override void OBEJJCMJBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x80A9FB0", Offset = "0x80A8BB0", VA = "0x1880A9FB0")]
		private JobHandle PDPFMJGGGGE(JBGCLPFGPEH<InventionInstanceIdData_v1> component_42, LANINFCEMGC<InventionInstanceIdData> component_43, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4A60", Offset = "0x2CB3660", VA = "0x182CB4A60")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : CJKPIPFJMAE
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public JBGCLPFGPEH<OMShapeContainerData_v1> component_47;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public LANINFCEMGC<OMShapeContainerData> component_48;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x80AA8F0", Offset = "0x80A94F0", VA = "0x1880AA8F0")]
			private void FOBOJFMNNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x80AA8E0", Offset = "0x80A94E0", VA = "0x1880AA8E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly PEOHNMCPNIJ log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override PEOHNMCPNIJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x80AA760", Offset = "0x80A9360", VA = "0x1880AA760", Slot = "14")]
			get
			{
				return default(PEOHNMCPNIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x80AABE0", Offset = "0x80A97E0", VA = "0x1880AABE0", Slot = "15")]
		protected override void OBEJJCMJBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x80AA7B0", Offset = "0x80A93B0", VA = "0x1880AA7B0")]
		private JobHandle EFFKKCOJECM(JBGCLPFGPEH<OMShapeContainerData_v1> component_47, LANINFCEMGC<OMShapeContainerData> component_48, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4A60", Offset = "0x2CB3660", VA = "0x182CB4A60")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : CJKPIPFJMAE
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public JBGCLPFGPEH<AuthoredAIIdData_v1> component_57;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public JBGCLPFGPEH<AuthoredAIIdData_v2> component_58;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public JBGCLPFGPEH<AuthoredAIIdData_v3> component_59;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public LANINFCEMGC<AuthoredAIIdData> component_60;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x80A9040", Offset = "0x80A7C40", VA = "0x1880A9040")]
			private void FOBOJFMNNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x80A9030", Offset = "0x80A7C30", VA = "0x1880A9030", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly PEOHNMCPNIJ log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override PEOHNMCPNIJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x80A8E40", Offset = "0x80A7A40", VA = "0x1880A8E40", Slot = "14")]
			get
			{
				return default(PEOHNMCPNIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x80A9760", Offset = "0x80A8360", VA = "0x1880A9760", Slot = "15")]
		protected override void OBEJJCMJBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x80A8E90", Offset = "0x80A7A90", VA = "0x1880A8E90")]
		private JobHandle IBILBADCEIH(JBGCLPFGPEH<AuthoredAIIdData_v1> component_57, JBGCLPFGPEH<AuthoredAIIdData_v2> component_58, JBGCLPFGPEH<AuthoredAIIdData_v3> component_59, LANINFCEMGC<AuthoredAIIdData> component_60, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4A60", Offset = "0x2CB3660", VA = "0x182CB4A60")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : CJKPIPFJMAE
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public JBGCLPFGPEH<ContainerCollisionLayerData_v1> component_70;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public LANINFCEMGC<PhysicsModelCollisionLayerData> component_71;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x80AC840", Offset = "0x80AB440", VA = "0x1880AC840")]
			private void FOBOJFMNNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x80AC830", Offset = "0x80AB430", VA = "0x1880AC830", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly PEOHNMCPNIJ log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override PEOHNMCPNIJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x80AC7E0", Offset = "0x80AB3E0", VA = "0x1880AC7E0", Slot = "14")]
			get
			{
				return default(PEOHNMCPNIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x80ACB30", Offset = "0x80AB730", VA = "0x1880ACB30", Slot = "15")]
		protected override void OBEJJCMJBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x80ACCA0", Offset = "0x80AB8A0", VA = "0x1880ACCA0")]
		private JobHandle PBCEIHDBOOI(JBGCLPFGPEH<ContainerCollisionLayerData_v1> component_70, LANINFCEMGC<PhysicsModelCollisionLayerData> component_71, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4A60", Offset = "0x2CB3660", VA = "0x182CB4A60")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : CJKPIPFJMAE
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public JBGCLPFGPEH<ContainerGrabbableModeData_v1> component_75;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public LANINFCEMGC<PhysicsModelGrabbableModeData> component_76;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x80AE040", Offset = "0x80ACC40", VA = "0x1880AE040")]
			private void FOBOJFMNNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x80AE030", Offset = "0x80ACC30", VA = "0x1880AE030", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly PEOHNMCPNIJ log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override PEOHNMCPNIJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x80ADFE0", Offset = "0x80ACBE0", VA = "0x1880ADFE0", Slot = "14")]
			get
			{
				return default(PEOHNMCPNIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x80AE330", Offset = "0x80ACF30", VA = "0x1880AE330", Slot = "15")]
		protected override void OBEJJCMJBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x80AE4A0", Offset = "0x80AD0A0", VA = "0x1880AE4A0")]
		private JobHandle PKIKACCAJMC(JBGCLPFGPEH<ContainerGrabbableModeData_v1> component_75, LANINFCEMGC<PhysicsModelGrabbableModeData> component_76, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4A60", Offset = "0x2CB3660", VA = "0x182CB4A60")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : CJKPIPFJMAE
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public JBGCLPFGPEH<ContainerFlagsData_v1> component_82;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public JBGCLPFGPEH<ContainerFlagsData_v2> component_83;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public JBGCLPFGPEH<PhysicsModelFlagsData_v3> component_84;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public LANINFCEMGC<PhysicsModelFlagsData> component_85;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x80AD660", Offset = "0x80AC260", VA = "0x1880AD660")]
			private void FOBOJFMNNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x80AD650", Offset = "0x80AC250", VA = "0x1880AD650", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly PEOHNMCPNIJ log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override PEOHNMCPNIJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x80AD460", Offset = "0x80AC060", VA = "0x1880AD460", Slot = "14")]
			get
			{
				return default(PEOHNMCPNIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x80ADD30", Offset = "0x80AC930", VA = "0x1880ADD30", Slot = "15")]
		protected override void OBEJJCMJBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x80AD4B0", Offset = "0x80AC0B0", VA = "0x1880AD4B0")]
		private JobHandle KAMAIEKNCLJ(JBGCLPFGPEH<ContainerFlagsData_v1> component_82, JBGCLPFGPEH<ContainerFlagsData_v2> component_83, JBGCLPFGPEH<PhysicsModelFlagsData_v3> component_84, LANINFCEMGC<PhysicsModelFlagsData> component_85, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4A60", Offset = "0x2CB3660", VA = "0x182CB4A60")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : CJKPIPFJMAE
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public JBGCLPFGPEH<ContainerCollisionModeData_v1> component_86;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public LANINFCEMGC<PhysicsModelCollisionModeData> component_87;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x80ACFB0", Offset = "0x80ABBB0", VA = "0x1880ACFB0")]
			private void FOBOJFMNNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x80ACFA0", Offset = "0x80ABBA0", VA = "0x1880ACFA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly PEOHNMCPNIJ log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override PEOHNMCPNIJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x80ACE20", Offset = "0x80ABA20", VA = "0x1880ACE20", Slot = "14")]
			get
			{
				return default(PEOHNMCPNIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x80AD2A0", Offset = "0x80ABEA0", VA = "0x1880AD2A0", Slot = "15")]
		protected override void OBEJJCMJBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x80ACE70", Offset = "0x80ABA70", VA = "0x1880ACE70")]
		private JobHandle FFBNANCADIO(JBGCLPFGPEH<ContainerCollisionModeData_v1> component_86, LANINFCEMGC<PhysicsModelCollisionModeData> component_87, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4A60", Offset = "0x2CB3660", VA = "0x182CB4A60")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : CJKPIPFJMAE
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public JBGCLPFGPEH<ObjectPolicyData_v1> component_90;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public JBGCLPFGPEH<ObjectPolicyData_v2> component_91;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public JBGCLPFGPEH<ObjectPolicyData_v3> component_92;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public JBGCLPFGPEH<ObjectPolicyData_v4> component_93;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public JBGCLPFGPEH<ObjectPolicyData_v5> component_94;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public LANINFCEMGC<ObjectPolicyData> component_95;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x80AB000", Offset = "0x80A9C00", VA = "0x1880AB000")]
			private void FOBOJFMNNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x80AAFF0", Offset = "0x80A9BF0", VA = "0x1880AAFF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly PEOHNMCPNIJ log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override PEOHNMCPNIJ Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x80AADA0", Offset = "0x80A99A0", VA = "0x1880AADA0", Slot = "14")]
			get
			{
				return default(PEOHNMCPNIJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x80ABDF0", Offset = "0x80AA9F0", VA = "0x1880ABDF0", Slot = "15")]
		protected override void OBEJJCMJBBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x80AADF0", Offset = "0x80A99F0", VA = "0x1880AADF0")]
		private JobHandle HEDLNJMCCFC(JBGCLPFGPEH<ObjectPolicyData_v1> component_90, JBGCLPFGPEH<ObjectPolicyData_v2> component_91, JBGCLPFGPEH<ObjectPolicyData_v3> component_92, JBGCLPFGPEH<ObjectPolicyData_v4> component_93, JBGCLPFGPEH<ObjectPolicyData_v5> component_94, LANINFCEMGC<ObjectPolicyData> component_95, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2CB4A60", Offset = "0x2CB3660", VA = "0x182CB4A60")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class AOGFOHLPCJP
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3195AF0", Offset = "0x31946F0", VA = "0x183195AF0")]
	public static void JPAOBLCKECA<T, U>(T NFCHCPFDFMN, [Out] U AKENCOPCNON) where T : struct where U : struct
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
