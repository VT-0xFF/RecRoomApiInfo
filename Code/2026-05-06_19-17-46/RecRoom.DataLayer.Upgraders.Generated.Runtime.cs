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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class QKWWYOFAGQD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98079D0", Offset = "0x98063D0", VA = "0x1898079D0")]
		public static void JWUVUEVKHDL(ComponentSystemGroup a, EntityCommandBufferSystem b)
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
		[Cpp2IlInjected.Address(RVA = "0x98079D0", Offset = "0x98063D0", VA = "0x1898079D0")]
		public static void ZJOPADBAPFR(ComponentSystemGroup a, EntityCommandBufferSystem b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9808E40", Offset = "0x9807840", VA = "0x189808E40")]
		private void JWUVUEVKHDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x40BC290", Offset = "0x40BAC90", VA = "0x1840BC290")]
		private void QZPESBSBZZI<a>(a a) where a : TJTWKIEXQDT
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class CFPWUBTAFUR : TJTWKIEXQDT
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
			[Cpp2IlInjected.Address(RVA = "0x98065A0", Offset = "0x9804FA0", VA = "0x1898065A0")]
			private void VOLMEYXXSCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9806590", Offset = "0x9804F90", VA = "0x189806590", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9801C10", Offset = "0x9800610", VA = "0x189801C10", Slot = "14")]
		protected override void AWASSIZYNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9801E10", Offset = "0x9800810", VA = "0x189801E10")]
		private JobHandle REJYPMPGQVA(IntermediateVersionInfo<PersistentUserTagData_v1> a, FinalVersionInfo<PersistentUserTagData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FEA0", Offset = "0x2E2E8A0", VA = "0x182E2FEA0")]
		[Preserve]
		public CFPWUBTAFUR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class KISWECMBYIX : TJTWKIEXQDT
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
			[Cpp2IlInjected.Address(RVA = "0x9804550", Offset = "0x9802F50", VA = "0x189804550")]
			private void VOLMEYXXSCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9804540", Offset = "0x9802F40", VA = "0x189804540", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9804150", Offset = "0x9802B50", VA = "0x189804150", Slot = "14")]
		protected override void AWASSIZYNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9804350", Offset = "0x9802D50", VA = "0x189804350")]
		private JobHandle URMRPYAHHVK(IntermediateVersionInfo<LocalDeformableScaleData_v1> a, FinalVersionInfo<LocalDeformableScaleData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FEA0", Offset = "0x2E2E8A0", VA = "0x182E2FEA0")]
		[Preserve]
		public KISWECMBYIX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class WAHSCNLHEAU : TJTWKIEXQDT
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
			[Cpp2IlInjected.Address(RVA = "0x9808000", Offset = "0x9806A00", VA = "0x189808000")]
			private void VOLMEYXXSCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9807FF0", Offset = "0x98069F0", VA = "0x189807FF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x98092E0", Offset = "0x9807CE0", VA = "0x1898092E0", Slot = "14")]
		protected override void AWASSIZYNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x98094E0", Offset = "0x9807EE0", VA = "0x1898094E0")]
		private JobHandle SGNTUVZFQPL(IntermediateVersionInfo<SerializedDataLayerVersionData_v1> a, FinalVersionInfo<SerializedDataLayerVersionData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FEA0", Offset = "0x2E2E8A0", VA = "0x182E2FEA0")]
		[Preserve]
		public WAHSCNLHEAU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class GILHZXWBNJE : TJTWKIEXQDT
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
			[Cpp2IlInjected.Address(RVA = "0x9807D90", Offset = "0x9806790", VA = "0x189807D90")]
			private void VOLMEYXXSCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9807D80", Offset = "0x9806780", VA = "0x189807D80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9802FC0", Offset = "0x98019C0", VA = "0x189802FC0", Slot = "14")]
		protected override void AWASSIZYNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x98031C0", Offset = "0x9801BC0", VA = "0x1898031C0")]
		private JobHandle VXVHZULWVIO(IntermediateVersionInfo<ReplicatorPreallocatedObjectCountData_v1> a, FinalVersionInfo<ReplicatorPreallocatedObjectCountData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FEA0", Offset = "0x2E2E8A0", VA = "0x182E2FEA0")]
		[Preserve]
		public GILHZXWBNJE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class CLNKQISTMGT : TJTWKIEXQDT
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
			[Cpp2IlInjected.Address(RVA = "0x9808B90", Offset = "0x9807590", VA = "0x189808B90")]
			private void VOLMEYXXSCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9808B80", Offset = "0x9807580", VA = "0x189808B80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9802000", Offset = "0x9800A00", VA = "0x189802000", Slot = "14")]
		protected override void AWASSIZYNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9802200", Offset = "0x9800C00", VA = "0x189802200")]
		private JobHandle FTJBMAFZOPL(IntermediateVersionInfo<ToolCleanupStatusData_v1> a, FinalVersionInfo<ToolCleanupStatusData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FEA0", Offset = "0x2E2E8A0", VA = "0x182E2FEA0")]
		[Preserve]
		public CLNKQISTMGT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class PGWQPTUZINU : TJTWKIEXQDT
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
			[Cpp2IlInjected.Address(RVA = "0x9808270", Offset = "0x9806C70", VA = "0x189808270")]
			private void VOLMEYXXSCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9808260", Offset = "0x9806C60", VA = "0x189808260", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x98061A0", Offset = "0x9804BA0", VA = "0x1898061A0", Slot = "14")]
		protected override void AWASSIZYNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x98063A0", Offset = "0x9804DA0", VA = "0x1898063A0")]
		private JobHandle VBTYIQQTRYM(IntermediateVersionInfo<TerrainGenerationData_v1> a, FinalVersionInfo<TerrainGenerationData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FEA0", Offset = "0x2E2E8A0", VA = "0x182E2FEA0")]
		[Preserve]
		public PGWQPTUZINU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class CLPEEQFUNOQ : TJTWKIEXQDT
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
			[Cpp2IlInjected.Address(RVA = "0x9807AE0", Offset = "0x98064E0", VA = "0x189807AE0")]
			private void VOLMEYXXSCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9807AD0", Offset = "0x98064D0", VA = "0x189807AD0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x98023F0", Offset = "0x9800DF0", VA = "0x1898023F0", Slot = "14")]
		protected override void AWASSIZYNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x98025F0", Offset = "0x9800FF0", VA = "0x1898025F0")]
		private JobHandle RMDBLMAJKLY(IntermediateVersionInfo<ReplicatorData_v1> a, FinalVersionInfo<ReplicatorData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FEA0", Offset = "0x2E2E8A0", VA = "0x182E2FEA0")]
		[Preserve]
		public CLPEEQFUNOQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OGQDROWWVNF : TJTWKIEXQDT
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
			[Cpp2IlInjected.Address(RVA = "0x9803820", Offset = "0x9802220", VA = "0x189803820")]
			private void VOLMEYXXSCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9803810", Offset = "0x9802210", VA = "0x189803810", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9804F80", Offset = "0x9803980", VA = "0x189804F80", Slot = "14")]
		protected override void AWASSIZYNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9805180", Offset = "0x9803B80", VA = "0x189805180")]
		private JobHandle CTIVBXVBDRL(IntermediateVersionInfo<InventionInstanceIdData_v1> a, FinalVersionInfo<InventionInstanceIdData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FEA0", Offset = "0x2E2E8A0", VA = "0x182E2FEA0")]
		[Preserve]
		public OGQDROWWVNF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class IMENTIDIBNR : TJTWKIEXQDT
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
			[Cpp2IlInjected.Address(RVA = "0x98085E0", Offset = "0x9806FE0", VA = "0x1898085E0")]
			private void VOLMEYXXSCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x98085D0", Offset = "0x9806FD0", VA = "0x1898085D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x98033B0", Offset = "0x9801DB0", VA = "0x1898033B0", Slot = "14")]
		protected override void AWASSIZYNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9803610", Offset = "0x9802010", VA = "0x189803610")]
		private JobHandle DBPINVQSRNN(IntermediateVersionInfo<TerrainWaterData_v1> a, IntermediateVersionInfo<TerrainWaterData_v2> b, FinalVersionInfo<TerrainWaterData> c, JobHandle d)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FEA0", Offset = "0x2E2E8A0", VA = "0x182E2FEA0")]
		[Preserve]
		public IMENTIDIBNR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class BQANCEDDFCL : TJTWKIEXQDT
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
			[Cpp2IlInjected.Address(RVA = "0x9805380", Offset = "0x9803D80", VA = "0x189805380")]
			private void VOLMEYXXSCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x9805370", Offset = "0x9803D70", VA = "0x189805370", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9801820", Offset = "0x9800220", VA = "0x189801820", Slot = "14")]
		protected override void AWASSIZYNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9801A20", Offset = "0x9800420", VA = "0x189801A20")]
		private JobHandle LWYMCQVPEKJ(IntermediateVersionInfo<OMShapeContainerData_v1> a, FinalVersionInfo<OMShapeContainerData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FEA0", Offset = "0x2E2E8A0", VA = "0x182E2FEA0")]
		[Preserve]
		public BQANCEDDFCL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class FLEFCUCDRMO : TJTWKIEXQDT
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
			[Cpp2IlInjected.Address(RVA = "0x98047D0", Offset = "0x98031D0", VA = "0x1898047D0")]
			private void VOLMEYXXSCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x98047C0", Offset = "0x98031C0", VA = "0x1898047C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9802BD0", Offset = "0x98015D0", VA = "0x189802BD0", Slot = "14")]
		protected override void AWASSIZYNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9802DD0", Offset = "0x98017D0", VA = "0x189802DD0")]
		private JobHandle PUHKTNOYMDY(IntermediateVersionInfo<MagneticAnchorData_v1> a, FinalVersionInfo<MagneticAnchorData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FEA0", Offset = "0x2E2E8A0", VA = "0x182E2FEA0")]
		[Preserve]
		public FLEFCUCDRMO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class ANQHTYIQLWA : TJTWKIEXQDT
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
			[Cpp2IlInjected.Address(RVA = "0x98011E0", Offset = "0x97FFBE0", VA = "0x1898011E0")]
			private void VOLMEYXXSCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x98011D0", Offset = "0x97FFBD0", VA = "0x1898011D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x98008D0", Offset = "0x97FF2D0", VA = "0x1898008D0", Slot = "14")]
		protected override void AWASSIZYNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9800BA0", Offset = "0x97FF5A0", VA = "0x189800BA0")]
		private JobHandle TOXYTJXYFUY(IntermediateVersionInfo<AuthoredAIIdData_v1> a, IntermediateVersionInfo<AuthoredAIIdData_v2> b, IntermediateVersionInfo<AuthoredAIIdData_v3> c, FinalVersionInfo<AuthoredAIIdData> d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FEA0", Offset = "0x2E2E8A0", VA = "0x182E2FEA0")]
		[Preserve]
		public ANQHTYIQLWA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class DBJOYBAPGTE : TJTWKIEXQDT
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
			[Cpp2IlInjected.Address(RVA = "0x9806890", Offset = "0x9805290", VA = "0x189806890")]
			private void VOLMEYXXSCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x9806880", Offset = "0x9805280", VA = "0x189806880", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x98027E0", Offset = "0x98011E0", VA = "0x1898027E0", Slot = "14")]
		protected override void AWASSIZYNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x98029E0", Offset = "0x98013E0", VA = "0x1898029E0")]
		private JobHandle TPSPJJHALUG(IntermediateVersionInfo<ContainerCollisionLayerData_v1> a, FinalVersionInfo<PhysicsModelCollisionLayerData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FEA0", Offset = "0x2E2E8A0", VA = "0x182E2FEA0")]
		[Preserve]
		public DBJOYBAPGTE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class QDUZMUNKCXO : TJTWKIEXQDT
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
			[Cpp2IlInjected.Address(RVA = "0x9807370", Offset = "0x9805D70", VA = "0x189807370")]
			private void VOLMEYXXSCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9807360", Offset = "0x9805D60", VA = "0x189807360", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x98075E0", Offset = "0x9805FE0", VA = "0x1898075E0", Slot = "14")]
		protected override void AWASSIZYNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x98077E0", Offset = "0x98061E0", VA = "0x1898077E0")]
		private JobHandle ETKNIOCKSOA(IntermediateVersionInfo<ContainerGrabbableModeData_v1> a, FinalVersionInfo<PhysicsModelGrabbableModeData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FEA0", Offset = "0x2E2E8A0", VA = "0x182E2FEA0")]
		[Preserve]
		public QDUZMUNKCXO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public class NUNAINLNUIE : TJTWKIEXQDT
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
			[Cpp2IlInjected.Address(RVA = "0x9806D90", Offset = "0x9805790", VA = "0x189806D90")]
			private void VOLMEYXXSCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9806D80", Offset = "0x9805780", VA = "0x189806D80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9804A70", Offset = "0x9803470", VA = "0x189804A70", Slot = "14")]
		protected override void AWASSIZYNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9804D40", Offset = "0x9803740", VA = "0x189804D40")]
		private JobHandle FMNFKRYNQLW(IntermediateVersionInfo<ContainerFlagsData_v1> a, IntermediateVersionInfo<ContainerFlagsData_v2> b, IntermediateVersionInfo<PhysicsModelFlagsData_v3> c, FinalVersionInfo<PhysicsModelFlagsData> d, JobHandle e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FEA0", Offset = "0x2E2E8A0", VA = "0x182E2FEA0")]
		[Preserve]
		public NUNAINLNUIE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public class AYNIFRYLNUA : TJTWKIEXQDT
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
			[Cpp2IlInjected.Address(RVA = "0x9806B10", Offset = "0x9805510", VA = "0x189806B10")]
			private void VOLMEYXXSCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x9806B00", Offset = "0x9805500", VA = "0x189806B00", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9800DE0", Offset = "0x97FF7E0", VA = "0x189800DE0", Slot = "14")]
		protected override void AWASSIZYNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9800FE0", Offset = "0x97FF9E0", VA = "0x189800FE0")]
		private JobHandle ETWRAAPKYIF(IntermediateVersionInfo<ContainerCollisionModeData_v1> a, FinalVersionInfo<PhysicsModelCollisionModeData> b, JobHandle c)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FEA0", Offset = "0x2E2E8A0", VA = "0x182E2FEA0")]
		[Preserve]
		public AYNIFRYLNUA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	public class JTORYVXHGMU : TJTWKIEXQDT
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
			[Cpp2IlInjected.Address(RVA = "0x9805610", Offset = "0x9804010", VA = "0x189805610")]
			private void VOLMEYXXSCS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9805600", Offset = "0x9804000", VA = "0x189805600", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9803A80", Offset = "0x9802480", VA = "0x189803A80", Slot = "14")]
		protected override void AWASSIZYNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9803E60", Offset = "0x9802860", VA = "0x189803E60")]
		private JobHandle BXTSUVSAKGN(IntermediateVersionInfo<ObjectPolicyData_v1> a, IntermediateVersionInfo<ObjectPolicyData_v2> b, IntermediateVersionInfo<ObjectPolicyData_v3> c, IntermediateVersionInfo<ObjectPolicyData_v4> d, IntermediateVersionInfo<ObjectPolicyData_v5> e, FinalVersionInfo<ObjectPolicyData> f, JobHandle g)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2E2FEA0", Offset = "0x2E2E8A0", VA = "0x182E2FEA0")]
		[Preserve]
		public JTORYVXHGMU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	internal static class VVXFMNNFMUV
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x40B0700", Offset = "0x40AF100", VA = "0x1840B0700")]
		public static void FYAWXUMSSZP<T, U>(T a, [Out] U b) where T : struct where U : struct
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1477231623
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x98096E0", Offset = "0x98080E0", VA = "0x1898096E0")]
	public static void ZGEXVVNGJIY()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x98096D0", Offset = "0x98080D0", VA = "0x1898096D0")]
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
