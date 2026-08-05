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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class PVOBEZWIUBZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9959D80", Offset = "0x9958D80", VA = "0x189959D80")]
		public static void ZCRDGFMZCKJ(ComponentSystemGroup a, EntityCommandBufferSystem b)
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
		[Cpp2IlInjected.Address(RVA = "0x9959D80", Offset = "0x9958D80", VA = "0x189959D80")]
		public static void EQDRBBXDMMX(ComponentSystemGroup a, EntityCommandBufferSystem b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x995C630", Offset = "0x995B630", VA = "0x18995C630")]
		private void ZCRDGFMZCKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x40927C0", Offset = "0x40917C0", VA = "0x1840927C0")]
		private void UHAWQRYZSAW<a>(a a) where a : ETVVCDLRMKV
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class GOWTZZXQQQF : ETVVCDLRMKV
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
			[Cpp2IlInjected.Address(RVA = "0x9959E80", Offset = "0x9958E80", VA = "0x189959E80")]
			private void DFPEMZXLKLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x995A160", Offset = "0x9959160", VA = "0x18995A160", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9957020", Offset = "0x9956020", VA = "0x189957020", Slot = "14")]
		protected override void RIVEITHGYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9956E80", Offset = "0x9955E80", VA = "0x189956E80")]
		private JobHandle GZQBHCEUEMS(IntermediateVersionInfo<PersistentUserTagData_v1> a, FinalVersionInfo<PersistentUserTagData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E310", Offset = "0x2E3D310", VA = "0x182E3E310")]
		[Preserve]
		public GOWTZZXQQQF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class WNEUGWVFLLF : ETVVCDLRMKV
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
			[Cpp2IlInjected.Address(RVA = "0x9958510", Offset = "0x9957510", VA = "0x189958510")]
			private void DFPEMZXLKLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9958780", Offset = "0x9957780", VA = "0x189958780", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x995CAD0", Offset = "0x995BAD0", VA = "0x18995CAD0", Slot = "14")]
		protected override void RIVEITHGYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x995CCD0", Offset = "0x995BCD0", VA = "0x18995CCD0")]
		private JobHandle UWHBTQABTOI(IntermediateVersionInfo<LocalDeformableScaleData_v1> a, FinalVersionInfo<LocalDeformableScaleData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E310", Offset = "0x2E3D310", VA = "0x182E3E310")]
		[Preserve]
		public WNEUGWVFLLF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class HHGRNZINELO : ETVVCDLRMKV
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
			[Cpp2IlInjected.Address(RVA = "0x995B7E0", Offset = "0x995A7E0", VA = "0x18995B7E0")]
			private void DFPEMZXLKLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x995BA40", Offset = "0x995AA40", VA = "0x18995BA40", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9957410", Offset = "0x9956410", VA = "0x189957410", Slot = "14")]
		protected override void RIVEITHGYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9957270", Offset = "0x9956270", VA = "0x189957270")]
		private JobHandle BXZMVIKIDQF(IntermediateVersionInfo<SerializedDataLayerVersionData_v1> a, FinalVersionInfo<SerializedDataLayerVersionData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E310", Offset = "0x2E3D310", VA = "0x182E3E310")]
		[Preserve]
		public HHGRNZINELO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class QRBCXBKWWKW : ETVVCDLRMKV
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
			[Cpp2IlInjected.Address(RVA = "0x995B570", Offset = "0x995A570", VA = "0x18995B570")]
			private void DFPEMZXLKLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x995B7D0", Offset = "0x995A7D0", VA = "0x18995B7D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x995B070", Offset = "0x995A070", VA = "0x18995B070", Slot = "14")]
		protected override void RIVEITHGYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x995AED0", Offset = "0x9959ED0", VA = "0x18995AED0")]
		private JobHandle QEPGNCUAWUK(IntermediateVersionInfo<ReplicatorPreallocatedObjectCountData_v1> a, FinalVersionInfo<ReplicatorPreallocatedObjectCountData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E310", Offset = "0x2E3D310", VA = "0x182E3E310")]
		[Preserve]
		public QRBCXBKWWKW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class XZTJIOWRAZN : ETVVCDLRMKV
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
			[Cpp2IlInjected.Address(RVA = "0x995C370", Offset = "0x995B370", VA = "0x18995C370")]
			private void DFPEMZXLKLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x995C620", Offset = "0x995B620", VA = "0x18995C620", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x995DF10", Offset = "0x995CF10", VA = "0x18995DF10", Slot = "14")]
		protected override void RIVEITHGYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x995DD70", Offset = "0x995CD70", VA = "0x18995DD70")]
		private JobHandle MIIFBIGUPRD(IntermediateVersionInfo<ToolCleanupStatusData_v1> a, FinalVersionInfo<ToolCleanupStatusData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E310", Offset = "0x2E3D310", VA = "0x182E3E310")]
		[Preserve]
		public XZTJIOWRAZN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class IPXSHHDEXDM : ETVVCDLRMKV
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
			[Cpp2IlInjected.Address(RVA = "0x995BA50", Offset = "0x995AA50", VA = "0x18995BA50")]
			private void DFPEMZXLKLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x995BDB0", Offset = "0x995ADB0", VA = "0x18995BDB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9957800", Offset = "0x9956800", VA = "0x189957800", Slot = "14")]
		protected override void RIVEITHGYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9957660", Offset = "0x9956660", VA = "0x189957660")]
		private JobHandle FZSMAYNDIYY(IntermediateVersionInfo<TerrainGenerationData_v1> a, FinalVersionInfo<TerrainGenerationData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E310", Offset = "0x2E3D310", VA = "0x182E3E310")]
		[Preserve]
		public IPXSHHDEXDM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class BAZICDDGVHO : ETVVCDLRMKV
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
			[Cpp2IlInjected.Address(RVA = "0x995B2C0", Offset = "0x995A2C0", VA = "0x18995B2C0")]
			private void DFPEMZXLKLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x995B560", Offset = "0x995A560", VA = "0x18995B560", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9956060", Offset = "0x9955060", VA = "0x189956060", Slot = "14")]
		protected override void RIVEITHGYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9955EC0", Offset = "0x9954EC0", VA = "0x189955EC0")]
		private JobHandle NLDCNNRZOSK(IntermediateVersionInfo<ReplicatorData_v1> a, FinalVersionInfo<ReplicatorData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E310", Offset = "0x2E3D310", VA = "0x182E3E310")]
		[Preserve]
		public BAZICDDGVHO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class FKOSLGRUFEH : ETVVCDLRMKV
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
			[Cpp2IlInjected.Address(RVA = "0x9957E40", Offset = "0x9956E40", VA = "0x189957E40")]
			private void DFPEMZXLKLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x99580A0", Offset = "0x99570A0", VA = "0x1899580A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9956840", Offset = "0x9955840", VA = "0x189956840", Slot = "14")]
		protected override void RIVEITHGYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x99566A0", Offset = "0x99556A0", VA = "0x1899566A0")]
		private JobHandle PBXQTRZSBCZ(IntermediateVersionInfo<InventionInstanceIdData_v1> a, FinalVersionInfo<InventionInstanceIdData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E310", Offset = "0x2E3D310", VA = "0x182E3E310")]
		[Preserve]
		public FKOSLGRUFEH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class KPRGEAOMFLN : ETVVCDLRMKV
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
			[Cpp2IlInjected.Address(RVA = "0x995BDC0", Offset = "0x995ADC0", VA = "0x18995BDC0")]
			private void DFPEMZXLKLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x995C360", Offset = "0x995B360", VA = "0x18995C360", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9958260", Offset = "0x9957260", VA = "0x189958260", Slot = "14")]
		protected override void RIVEITHGYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x99580B0", Offset = "0x99570B0", VA = "0x1899580B0")]
		private JobHandle JUTYBIHGKVB(IntermediateVersionInfo<TerrainWaterData_v1> a, IntermediateVersionInfo<TerrainWaterData_v2> b, FinalVersionInfo<TerrainWaterData> c, JobHandle d)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E310", Offset = "0x2E3D310", VA = "0x182E3E310")]
		[Preserve]
		public KPRGEAOMFLN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class IRPODVBODRN : ETVVCDLRMKV
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
			[Cpp2IlInjected.Address(RVA = "0x9958A40", Offset = "0x9957A40", VA = "0x189958A40")]
			private void DFPEMZXLKLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x9958CC0", Offset = "0x9957CC0", VA = "0x189958CC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9957A50", Offset = "0x9956A50", VA = "0x189957A50", Slot = "14")]
		protected override void RIVEITHGYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9957C50", Offset = "0x9956C50", VA = "0x189957C50")]
		private JobHandle TGSOCLHUOCR(IntermediateVersionInfo<OMShapeContainerData_v1> a, FinalVersionInfo<OMShapeContainerData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E310", Offset = "0x2E3D310", VA = "0x182E3E310")]
		[Preserve]
		public IRPODVBODRN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class WVCLAGLPRBE : ETVVCDLRMKV
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
			[Cpp2IlInjected.Address(RVA = "0x9958790", Offset = "0x9957790", VA = "0x189958790")]
			private void DFPEMZXLKLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9958A30", Offset = "0x9957A30", VA = "0x189958A30", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x995CEC0", Offset = "0x995BEC0", VA = "0x18995CEC0", Slot = "14")]
		protected override void RIVEITHGYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x995D0C0", Offset = "0x995C0C0", VA = "0x18995D0C0")]
		private JobHandle SKMIKAYMRFI(IntermediateVersionInfo<MagneticAnchorData_v1> a, FinalVersionInfo<MagneticAnchorData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E310", Offset = "0x2E3D310", VA = "0x182E3E310")]
		[Preserve]
		public WVCLAGLPRBE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PAPBCKLKFDO : ETVVCDLRMKV
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
			[Cpp2IlInjected.Address(RVA = "0x9955870", Offset = "0x9954870", VA = "0x189955870")]
			private void DFPEMZXLKLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9955EB0", Offset = "0x9954EB0", VA = "0x189955EB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9959A60", Offset = "0x9958A60", VA = "0x189959A60", Slot = "14")]
		protected override void RIVEITHGYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9959870", Offset = "0x9958870", VA = "0x189959870")]
		private JobHandle JVOZXAMOYRS(IntermediateVersionInfo<AuthoredAIIdData_v1> a, IntermediateVersionInfo<AuthoredAIIdData_v2> b, IntermediateVersionInfo<AuthoredAIIdData_v3> c, FinalVersionInfo<AuthoredAIIdData> d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E310", Offset = "0x2E3D310", VA = "0x182E3E310")]
		[Preserve]
		public PAPBCKLKFDO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class BMBDMGWOMSG : ETVVCDLRMKV
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
			[Cpp2IlInjected.Address(RVA = "0x995A170", Offset = "0x9959170", VA = "0x18995A170")]
			private void DFPEMZXLKLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x995A3E0", Offset = "0x99593E0", VA = "0x18995A3E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x99562B0", Offset = "0x99552B0", VA = "0x1899562B0", Slot = "14")]
		protected override void RIVEITHGYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x99564B0", Offset = "0x99554B0", VA = "0x1899564B0")]
		private JobHandle UMCDYJVWCYK(IntermediateVersionInfo<ContainerCollisionLayerData_v1> a, FinalVersionInfo<PhysicsModelCollisionLayerData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E310", Offset = "0x2E3D310", VA = "0x182E3E310")]
		[Preserve]
		public BMBDMGWOMSG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class FSBTSVLHUHG : ETVVCDLRMKV
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
			[Cpp2IlInjected.Address(RVA = "0x995AC50", Offset = "0x9959C50", VA = "0x18995AC50")]
			private void DFPEMZXLKLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x995AEC0", Offset = "0x9959EC0", VA = "0x18995AEC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9956C30", Offset = "0x9955C30", VA = "0x189956C30", Slot = "14")]
		protected override void RIVEITHGYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9956A90", Offset = "0x9955A90", VA = "0x189956A90")]
		private JobHandle GYFDVOKBJMY(IntermediateVersionInfo<ContainerGrabbableModeData_v1> a, FinalVersionInfo<PhysicsModelGrabbableModeData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E310", Offset = "0x2E3D310", VA = "0x182E3E310")]
		[Preserve]
		public FSBTSVLHUHG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public class YTWDNUDYRDC : ETVVCDLRMKV
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
			[Cpp2IlInjected.Address(RVA = "0x995A670", Offset = "0x9959670", VA = "0x18995A670")]
			private void DFPEMZXLKLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x995AC40", Offset = "0x9959C40", VA = "0x18995AC40", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x995E350", Offset = "0x995D350", VA = "0x18995E350", Slot = "14")]
		protected override void RIVEITHGYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x995E160", Offset = "0x995D160", VA = "0x18995E160")]
		private JobHandle BXLAVEGCCOA(IntermediateVersionInfo<ContainerFlagsData_v1> a, IntermediateVersionInfo<ContainerFlagsData_v2> b, IntermediateVersionInfo<PhysicsModelFlagsData_v3> c, FinalVersionInfo<PhysicsModelFlagsData> d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E310", Offset = "0x2E3D310", VA = "0x182E3E310")]
		[Preserve]
		public YTWDNUDYRDC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public class XYALOCDQGZK : ETVVCDLRMKV
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
			[Cpp2IlInjected.Address(RVA = "0x995A3F0", Offset = "0x99593F0", VA = "0x18995A3F0")]
			private void DFPEMZXLKLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x995A660", Offset = "0x9959660", VA = "0x18995A660", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x995DB20", Offset = "0x995CB20", VA = "0x18995DB20", Slot = "14")]
		protected override void RIVEITHGYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x995D980", Offset = "0x995C980", VA = "0x18995D980")]
		private JobHandle KZJKBQGUOSR(IntermediateVersionInfo<ContainerCollisionModeData_v1> a, FinalVersionInfo<PhysicsModelCollisionModeData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E310", Offset = "0x2E3D310", VA = "0x182E3E310")]
		[Preserve]
		public XYALOCDQGZK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	public class XXJFPCVSTMQ : ETVVCDLRMKV
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
			[Cpp2IlInjected.Address(RVA = "0x9958CD0", Offset = "0x9957CD0", VA = "0x189958CD0")]
			private void DFPEMZXLKLQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9959860", Offset = "0x9958860", VA = "0x189959860", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x995D550", Offset = "0x995C550", VA = "0x18995D550", Slot = "14")]
		protected override void RIVEITHGYMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x995D2B0", Offset = "0x995C2B0", VA = "0x18995D2B0")]
		private JobHandle QTJXMDSIEUB(IntermediateVersionInfo<ObjectPolicyData_v1> a, IntermediateVersionInfo<ObjectPolicyData_v2> b, IntermediateVersionInfo<ObjectPolicyData_v3> c, IntermediateVersionInfo<ObjectPolicyData_v4> d, IntermediateVersionInfo<ObjectPolicyData_v5> e, FinalVersionInfo<ObjectPolicyData> f, JobHandle g)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2E3E310", Offset = "0x2E3D310", VA = "0x182E3E310")]
		[Preserve]
		public XXJFPCVSTMQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class GDZTHLFRCPX
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3AE1910", Offset = "0x3AE0910", VA = "0x183AE1910")]
		public static void FLOUSZCKDZT<T, U>(T a, [Out] U b) where T : struct where U : struct
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3291839549
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x995E680", Offset = "0x995D680", VA = "0x18995E680")]
	public static void PQMGTAMPKVS()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x995E670", Offset = "0x995D670", VA = "0x18995E670")]
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
