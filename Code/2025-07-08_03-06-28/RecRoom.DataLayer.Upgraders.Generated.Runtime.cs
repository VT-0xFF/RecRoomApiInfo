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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class BCIDBGDOJNP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x806CA80", Offset = "0x806B880", VA = "0x18806CA80")]
	public static void IFDLNMAOGKP(ComponentSystemGroup HKDEGGMBIMJ, EntityCommandBufferSystem LILMAMMDCBG)
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
		[Cpp2IlInjected.Address(RVA = "0x806CA80", Offset = "0x806B880", VA = "0x18806CA80")]
		public static void ONILGIFGENF(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8072F70", Offset = "0x8071D70", VA = "0x188072F70")]
		private void IFDLNMAOGKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8073860", Offset = "0x8072660", VA = "0x188073860")]
		private void PDDPODECDAN(PBFNKCBPOBE system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : PBFNKCBPOBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public OLDHDIMIKND<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public AEKCBCPKMPK<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x806F4B0", Offset = "0x806E2B0", VA = "0x18806F4B0")]
			private void ELEAHIOBOHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x806F7F0", Offset = "0x806E5F0", VA = "0x18806F7F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly PHLHEDGDBJO log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override PHLHEDGDBJO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x806F1C0", Offset = "0x806DFC0", VA = "0x18806F1C0", Slot = "14")]
			get
			{
				return default(PHLHEDGDBJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x806F340", Offset = "0x806E140", VA = "0x18806F340", Slot = "15")]
		protected override void KPDELFLLAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x806F210", Offset = "0x806E010", VA = "0x18806F210")]
		private JobHandle HGLKEHMDMMA(OLDHDIMIKND<PersistentUserTagData_v1> component_1, AEKCBCPKMPK<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2C5EDF0", Offset = "0x2C5DBF0", VA = "0x182C5EDF0")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : PBFNKCBPOBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public OLDHDIMIKND<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public AEKCBCPKMPK<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x806D490", Offset = "0x806C290", VA = "0x18806D490")]
			private void ELEAHIOBOHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x806D770", Offset = "0x806C570", VA = "0x18806D770", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly PHLHEDGDBJO log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override PHLHEDGDBJO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x806D1A0", Offset = "0x806BFA0", VA = "0x18806D1A0", Slot = "14")]
			get
			{
				return default(PHLHEDGDBJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x806D320", Offset = "0x806C120", VA = "0x18806D320", Slot = "15")]
		protected override void KPDELFLLAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x806D1F0", Offset = "0x806BFF0", VA = "0x18806D1F0")]
		private JobHandle FCIKGLHAKKK(OLDHDIMIKND<LocalDeformableScaleData_v1> component_4, AEKCBCPKMPK<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2C5EDF0", Offset = "0x2C5DBF0", VA = "0x182C5EDF0")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : PBFNKCBPOBE
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public OLDHDIMIKND<SerializedDataLayerVersionData_v1> component_13;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public AEKCBCPKMPK<SerializedDataLayerVersionData> component_14;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x80725E0", Offset = "0x80713E0", VA = "0x1880725E0")]
			private void ELEAHIOBOHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x80728A0", Offset = "0x80716A0", VA = "0x1880728A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly PHLHEDGDBJO log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override PHLHEDGDBJO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x80722F0", Offset = "0x80710F0", VA = "0x1880722F0", Slot = "14")]
			get
			{
				return default(PHLHEDGDBJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8072470", Offset = "0x8071270", VA = "0x188072470", Slot = "15")]
		protected override void KPDELFLLAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8072340", Offset = "0x8071140", VA = "0x188072340")]
		private JobHandle HGCKLKLLHKJ(OLDHDIMIKND<SerializedDataLayerVersionData_v1> component_13, AEKCBCPKMPK<SerializedDataLayerVersionData> component_14, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2C5EDF0", Offset = "0x2C5DBF0", VA = "0x182C5EDF0")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : PBFNKCBPOBE
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public OLDHDIMIKND<ReplicatorPreallocatedObjectCountData_v1> component_21;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public AEKCBCPKMPK<ReplicatorPreallocatedObjectCountData> component_22;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8071FD0", Offset = "0x8070DD0", VA = "0x188071FD0")]
			private void ELEAHIOBOHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8072290", Offset = "0x8071090", VA = "0x188072290", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly PHLHEDGDBJO log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override PHLHEDGDBJO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8071CE0", Offset = "0x8070AE0", VA = "0x188071CE0", Slot = "14")]
			get
			{
				return default(PHLHEDGDBJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8071E60", Offset = "0x8070C60", VA = "0x188071E60", Slot = "15")]
		protected override void KPDELFLLAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8071D30", Offset = "0x8070B30", VA = "0x188071D30")]
		private JobHandle COACLEHDAEI(OLDHDIMIKND<ReplicatorPreallocatedObjectCountData_v1> component_21, AEKCBCPKMPK<ReplicatorPreallocatedObjectCountData> component_22, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2C5EDF0", Offset = "0x2C5DBF0", VA = "0x182C5EDF0")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : PBFNKCBPOBE
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public OLDHDIMIKND<ToolCleanupStatusData_v1> component_26;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public AEKCBCPKMPK<ToolCleanupStatusData> component_27;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8072BF0", Offset = "0x80719F0", VA = "0x188072BF0")]
			private void ELEAHIOBOHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8072F10", Offset = "0x8071D10", VA = "0x188072F10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly PHLHEDGDBJO log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override PHLHEDGDBJO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8072900", Offset = "0x8071700", VA = "0x188072900", Slot = "14")]
			get
			{
				return default(PHLHEDGDBJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8072A80", Offset = "0x8071880", VA = "0x188072A80", Slot = "15")]
		protected override void KPDELFLLAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8072950", Offset = "0x8071750", VA = "0x188072950")]
		private JobHandle EKJPPIPELPD(OLDHDIMIKND<ToolCleanupStatusData_v1> component_26, AEKCBCPKMPK<ToolCleanupStatusData> component_27, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2C5EDF0", Offset = "0x2C5DBF0", VA = "0x182C5EDF0")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : PBFNKCBPOBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public OLDHDIMIKND<ReplicatorData_v1> component_34;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public AEKCBCPKMPK<ReplicatorData> component_35;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8071980", Offset = "0x8070780", VA = "0x188071980")]
			private void ELEAHIOBOHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8071C80", Offset = "0x8070A80", VA = "0x188071C80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly PHLHEDGDBJO log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override PHLHEDGDBJO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8071690", Offset = "0x8070490", VA = "0x188071690", Slot = "14")]
			get
			{
				return default(PHLHEDGDBJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8071810", Offset = "0x8070610", VA = "0x188071810", Slot = "15")]
		protected override void KPDELFLLAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x80716E0", Offset = "0x80704E0", VA = "0x1880716E0")]
		private JobHandle INAFPHHLDHD(OLDHDIMIKND<ReplicatorData_v1> component_34, AEKCBCPKMPK<ReplicatorData> component_35, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2C5EDF0", Offset = "0x2C5DBF0", VA = "0x182C5EDF0")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : PBFNKCBPOBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public OLDHDIMIKND<InventionInstanceIdData_v1> component_38;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public AEKCBCPKMPK<InventionInstanceIdData> component_39;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x806CD60", Offset = "0x806BB60", VA = "0x18806CD60")]
			private void ELEAHIOBOHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x806D010", Offset = "0x806BE10", VA = "0x18806D010", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly PHLHEDGDBJO log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override PHLHEDGDBJO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x806CBA0", Offset = "0x806B9A0", VA = "0x18806CBA0", Slot = "14")]
			get
			{
				return default(PHLHEDGDBJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x806CBF0", Offset = "0x806B9F0", VA = "0x18806CBF0", Slot = "15")]
		protected override void KPDELFLLAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x806D020", Offset = "0x806BE20", VA = "0x18806D020")]
		private JobHandle ODANOHOCFMI(OLDHDIMIKND<InventionInstanceIdData_v1> component_38, AEKCBCPKMPK<InventionInstanceIdData> component_39, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2C5EDF0", Offset = "0x2C5DBF0", VA = "0x182C5EDF0")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : PBFNKCBPOBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public OLDHDIMIKND<OMShapeContainerData_v1> component_43;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public AEKCBCPKMPK<OMShapeContainerData> component_44;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x806DAC0", Offset = "0x806C8C0", VA = "0x18806DAC0")]
			private void ELEAHIOBOHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x806DDB0", Offset = "0x806CBB0", VA = "0x18806DDB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly PHLHEDGDBJO log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override PHLHEDGDBJO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x806D7D0", Offset = "0x806C5D0", VA = "0x18806D7D0", Slot = "14")]
			get
			{
				return default(PHLHEDGDBJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x806D950", Offset = "0x806C750", VA = "0x18806D950", Slot = "15")]
		protected override void KPDELFLLAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x806D820", Offset = "0x806C620", VA = "0x18806D820")]
		private JobHandle ELPOKEDPEFH(OLDHDIMIKND<OMShapeContainerData_v1> component_43, AEKCBCPKMPK<OMShapeContainerData> component_44, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2C5EDF0", Offset = "0x2C5DBF0", VA = "0x182C5EDF0")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : PBFNKCBPOBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public OLDHDIMIKND<AuthoredAIIdData_v1> component_53;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public OLDHDIMIKND<AuthoredAIIdData_v2> component_54;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public OLDHDIMIKND<AuthoredAIIdData_v3> component_55;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public AEKCBCPKMPK<AuthoredAIIdData> component_56;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x806C300", Offset = "0x806B100", VA = "0x18806C300")]
			private void ELEAHIOBOHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x806CA20", Offset = "0x806B820", VA = "0x18806CA20", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly PHLHEDGDBJO log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override PHLHEDGDBJO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x806BEB0", Offset = "0x806ACB0", VA = "0x18806BEB0", Slot = "14")]
			get
			{
				return default(PHLHEDGDBJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x806C0A0", Offset = "0x806AEA0", VA = "0x18806C0A0", Slot = "15")]
		protected override void KPDELFLLAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x806BF00", Offset = "0x806AD00", VA = "0x18806BF00")]
		private JobHandle IOBCDNAGJGF(OLDHDIMIKND<AuthoredAIIdData_v1> component_53, OLDHDIMIKND<AuthoredAIIdData_v2> component_54, OLDHDIMIKND<AuthoredAIIdData_v3> component_55, AEKCBCPKMPK<AuthoredAIIdData> component_56, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2C5EDF0", Offset = "0x2C5DBF0", VA = "0x182C5EDF0")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : PBFNKCBPOBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public OLDHDIMIKND<ContainerCollisionLayerData_v1> component_66;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public AEKCBCPKMPK<PhysicsModelCollisionLayerData> component_67;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x806FB40", Offset = "0x806E940", VA = "0x18806FB40")]
			private void ELEAHIOBOHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x806FE30", Offset = "0x806EC30", VA = "0x18806FE30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly PHLHEDGDBJO log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override PHLHEDGDBJO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x806F850", Offset = "0x806E650", VA = "0x18806F850", Slot = "14")]
			get
			{
				return default(PHLHEDGDBJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x806F9D0", Offset = "0x806E7D0", VA = "0x18806F9D0", Slot = "15")]
		protected override void KPDELFLLAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x806F8A0", Offset = "0x806E6A0", VA = "0x18806F8A0")]
		private JobHandle KLGKKPHHOLN(OLDHDIMIKND<ContainerCollisionLayerData_v1> component_66, AEKCBCPKMPK<PhysicsModelCollisionLayerData> component_67, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2C5EDF0", Offset = "0x2C5DBF0", VA = "0x182C5EDF0")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : PBFNKCBPOBE
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public OLDHDIMIKND<ContainerGrabbableModeData_v1> component_71;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public AEKCBCPKMPK<PhysicsModelGrabbableModeData> component_72;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8071210", Offset = "0x8070010", VA = "0x188071210")]
			private void ELEAHIOBOHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8071500", Offset = "0x8070300", VA = "0x188071500", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly PHLHEDGDBJO log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override PHLHEDGDBJO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8071050", Offset = "0x806FE50", VA = "0x188071050", Slot = "14")]
			get
			{
				return default(PHLHEDGDBJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x80710A0", Offset = "0x806FEA0", VA = "0x1880710A0", Slot = "15")]
		protected override void KPDELFLLAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8071510", Offset = "0x8070310", VA = "0x188071510")]
		private JobHandle OEGGLNAEJLH(OLDHDIMIKND<ContainerGrabbableModeData_v1> component_71, AEKCBCPKMPK<PhysicsModelGrabbableModeData> component_72, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2C5EDF0", Offset = "0x2C5DBF0", VA = "0x182C5EDF0")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : PBFNKCBPOBE
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public OLDHDIMIKND<ContainerFlagsData_v1> component_78;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public OLDHDIMIKND<ContainerFlagsData_v2> component_79;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public OLDHDIMIKND<PhysicsModelFlagsData_v3> component_80;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AEKCBCPKMPK<PhysicsModelFlagsData> component_81;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8070920", Offset = "0x806F720", VA = "0x188070920")]
			private void ELEAHIOBOHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x8070FF0", Offset = "0x806FDF0", VA = "0x188070FF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly PHLHEDGDBJO log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override PHLHEDGDBJO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x80704D0", Offset = "0x806F2D0", VA = "0x1880704D0", Slot = "14")]
			get
			{
				return default(PHLHEDGDBJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x80706C0", Offset = "0x806F4C0", VA = "0x1880706C0", Slot = "15")]
		protected override void KPDELFLLAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8070520", Offset = "0x806F320", VA = "0x188070520")]
		private JobHandle KEEGJOCHEME(OLDHDIMIKND<ContainerFlagsData_v1> component_78, OLDHDIMIKND<ContainerFlagsData_v2> component_79, OLDHDIMIKND<PhysicsModelFlagsData_v3> component_80, AEKCBCPKMPK<PhysicsModelFlagsData> component_81, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2C5EDF0", Offset = "0x2C5DBF0", VA = "0x182C5EDF0")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : PBFNKCBPOBE
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public OLDHDIMIKND<ContainerCollisionModeData_v1> component_82;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AEKCBCPKMPK<PhysicsModelCollisionModeData> component_83;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8070050", Offset = "0x806EE50", VA = "0x188070050")]
			private void ELEAHIOBOHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8070340", Offset = "0x806F140", VA = "0x188070340", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly PHLHEDGDBJO log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override PHLHEDGDBJO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x806FE90", Offset = "0x806EC90", VA = "0x18806FE90", Slot = "14")]
			get
			{
				return default(PHLHEDGDBJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x806FEE0", Offset = "0x806ECE0", VA = "0x18806FEE0", Slot = "15")]
		protected override void KPDELFLLAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8070350", Offset = "0x806F150", VA = "0x188070350")]
		private JobHandle NCLMIJIOHIC(OLDHDIMIKND<ContainerCollisionModeData_v1> component_82, AEKCBCPKMPK<PhysicsModelCollisionModeData> component_83, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2C5EDF0", Offset = "0x2C5DBF0", VA = "0x182C5EDF0")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : PBFNKCBPOBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public OLDHDIMIKND<ObjectPolicyData_v1> component_86;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public OLDHDIMIKND<ObjectPolicyData_v2> component_87;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public OLDHDIMIKND<ObjectPolicyData_v3> component_88;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public OLDHDIMIKND<ObjectPolicyData_v4> component_89;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public OLDHDIMIKND<ObjectPolicyData_v5> component_90;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public AEKCBCPKMPK<ObjectPolicyData> component_91;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x806E370", Offset = "0x806D170", VA = "0x18806E370")]
			private void ELEAHIOBOHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x806F160", Offset = "0x806DF60", VA = "0x18806F160", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly PHLHEDGDBJO log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override PHLHEDGDBJO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x806DE10", Offset = "0x806CC10", VA = "0x18806DE10", Slot = "14")]
			get
			{
				return default(PHLHEDGDBJO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x806E060", Offset = "0x806CE60", VA = "0x18806E060", Slot = "15")]
		protected override void KPDELFLLAEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x806DE60", Offset = "0x806CC60", VA = "0x18806DE60")]
		private JobHandle CELFLMHCIIG(OLDHDIMIKND<ObjectPolicyData_v1> component_86, OLDHDIMIKND<ObjectPolicyData_v2> component_87, OLDHDIMIKND<ObjectPolicyData_v3> component_88, OLDHDIMIKND<ObjectPolicyData_v4> component_89, OLDHDIMIKND<ObjectPolicyData_v5> component_90, AEKCBCPKMPK<ObjectPolicyData> component_91, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2C5EDF0", Offset = "0x2C5DBF0", VA = "0x182C5EDF0")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class BGLLNIPICDK
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3936A40", Offset = "0x3935840", VA = "0x183936A40")]
	public static void AJGAEIBDCEG<T, U>(T IDIAFCODBKO, [Out] U KJEMFGFCMLF) where T : struct where U : struct
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
