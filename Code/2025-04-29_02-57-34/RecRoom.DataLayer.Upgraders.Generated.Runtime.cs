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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F4500", Offset = "0x9F3900", VA = "0x1809F4500")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EGJNAMEGBAB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7AAF3A0", Offset = "0x7AAE7A0", VA = "0x187AAF3A0")]
	public static void CMPNNDJCNIC(ComponentSystemGroup CICOHMGGHPI, EntityCommandBufferSystem NGFDHLPOPGO)
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
		[Cpp2IlInjected.Address(RVA = "0x7AAF3A0", Offset = "0x7AAE7A0", VA = "0x187AAF3A0")]
		public static void EKHOAFPHIMO(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7AB5890", Offset = "0x7AB4C90", VA = "0x187AB5890")]
		private void CMPNNDJCNIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7AB6180", Offset = "0x7AB5580", VA = "0x187AB6180")]
		private void GOAPAHNHJEK(DMNNDJMNGMN system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : DMNNDJMNGMN
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public HBMJACBOOPF<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public IDOOLCJIJHL<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7AB1C10", Offset = "0x7AB1010", VA = "0x187AB1C10")]
			private void AOLJGBEOMDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7AB1F50", Offset = "0x7AB1350", VA = "0x187AB1F50", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly LMKAPNBAFDO log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override LMKAPNBAFDO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7AB20D0", Offset = "0x7AB14D0", VA = "0x187AB20D0", Slot = "14")]
			get
			{
				return default(LMKAPNBAFDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1F60", Offset = "0x7AB1360", VA = "0x187AB1F60", Slot = "15")]
		protected override void OMIHJNKMDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1AE0", Offset = "0x7AB0EE0", VA = "0x187AB1AE0")]
		private JobHandle CBKEMJCJJMB(HBMJACBOOPF<PersistentUserTagData_v1> component_1, IDOOLCJIJHL<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x29403C0", Offset = "0x293F7C0", VA = "0x1829403C0")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : DMNNDJMNGMN
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public HBMJACBOOPF<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public IDOOLCJIJHL<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7AAFBF0", Offset = "0x7AAEFF0", VA = "0x187AAFBF0")]
			private void AOLJGBEOMDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7AAFED0", Offset = "0x7AAF2D0", VA = "0x187AAFED0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly LMKAPNBAFDO log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override LMKAPNBAFDO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7AB0050", Offset = "0x7AAF450", VA = "0x187AB0050", Slot = "14")]
			get
			{
				return default(LMKAPNBAFDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7AAFEE0", Offset = "0x7AAF2E0", VA = "0x187AAFEE0", Slot = "15")]
		protected override void OMIHJNKMDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7AAFAC0", Offset = "0x7AAEEC0", VA = "0x187AAFAC0")]
		private JobHandle IFCKJLLMEHG(HBMJACBOOPF<LocalDeformableScaleData_v1> component_4, IDOOLCJIJHL<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x29403C0", Offset = "0x293F7C0", VA = "0x1829403C0")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : DMNNDJMNGMN
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public HBMJACBOOPF<SerializedDataLayerVersionData_v1> component_12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public IDOOLCJIJHL<SerializedDataLayerVersionData> component_13;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7AB4D40", Offset = "0x7AB4140", VA = "0x187AB4D40")]
			private void AOLJGBEOMDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7AB5000", Offset = "0x7AB4400", VA = "0x187AB5000", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly LMKAPNBAFDO log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override LMKAPNBAFDO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7AB5180", Offset = "0x7AB4580", VA = "0x187AB5180", Slot = "14")]
			get
			{
				return default(LMKAPNBAFDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7AB5010", Offset = "0x7AB4410", VA = "0x187AB5010", Slot = "15")]
		protected override void OMIHJNKMDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4C10", Offset = "0x7AB4010", VA = "0x187AB4C10")]
		private JobHandle HKIIKJGEBFG(HBMJACBOOPF<SerializedDataLayerVersionData_v1> component_12, IDOOLCJIJHL<SerializedDataLayerVersionData> component_13, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x29403C0", Offset = "0x293F7C0", VA = "0x1829403C0")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : DMNNDJMNGMN
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public HBMJACBOOPF<ReplicatorPreallocatedObjectCountData_v1> component_20;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public IDOOLCJIJHL<ReplicatorPreallocatedObjectCountData> component_21;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7AB4730", Offset = "0x7AB3B30", VA = "0x187AB4730")]
			private void AOLJGBEOMDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7AB49F0", Offset = "0x7AB3DF0", VA = "0x187AB49F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly LMKAPNBAFDO log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override LMKAPNBAFDO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7AB4B70", Offset = "0x7AB3F70", VA = "0x187AB4B70", Slot = "14")]
			get
			{
				return default(LMKAPNBAFDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4A00", Offset = "0x7AB3E00", VA = "0x187AB4A00", Slot = "15")]
		protected override void OMIHJNKMDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7AB4600", Offset = "0x7AB3A00", VA = "0x187AB4600")]
		private JobHandle IMAAMMHAHKI(HBMJACBOOPF<ReplicatorPreallocatedObjectCountData_v1> component_20, IDOOLCJIJHL<ReplicatorPreallocatedObjectCountData> component_21, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x29403C0", Offset = "0x293F7C0", VA = "0x1829403C0")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : DMNNDJMNGMN
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public HBMJACBOOPF<ToolCleanupStatusData_v1> component_25;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public IDOOLCJIJHL<ToolCleanupStatusData> component_26;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7AB5350", Offset = "0x7AB4750", VA = "0x187AB5350")]
			private void AOLJGBEOMDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7AB5670", Offset = "0x7AB4A70", VA = "0x187AB5670", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly LMKAPNBAFDO log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override LMKAPNBAFDO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7AB57F0", Offset = "0x7AB4BF0", VA = "0x187AB57F0", Slot = "14")]
			get
			{
				return default(LMKAPNBAFDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7AB5680", Offset = "0x7AB4A80", VA = "0x187AB5680", Slot = "15")]
		protected override void OMIHJNKMDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7AB5220", Offset = "0x7AB4620", VA = "0x187AB5220")]
		private JobHandle HMENBLJBDOK(HBMJACBOOPF<ToolCleanupStatusData_v1> component_25, IDOOLCJIJHL<ToolCleanupStatusData> component_26, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x29403C0", Offset = "0x293F7C0", VA = "0x1829403C0")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : DMNNDJMNGMN
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public HBMJACBOOPF<ReplicatorData_v1> component_33;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public IDOOLCJIJHL<ReplicatorData> component_34;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7AB40E0", Offset = "0x7AB34E0", VA = "0x187AB40E0")]
			private void AOLJGBEOMDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7AB43E0", Offset = "0x7AB37E0", VA = "0x187AB43E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly LMKAPNBAFDO log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override LMKAPNBAFDO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7AB4560", Offset = "0x7AB3960", VA = "0x187AB4560", Slot = "14")]
			get
			{
				return default(LMKAPNBAFDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7AB43F0", Offset = "0x7AB37F0", VA = "0x187AB43F0", Slot = "15")]
		protected override void OMIHJNKMDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3FB0", Offset = "0x7AB33B0", VA = "0x187AB3FB0")]
		private JobHandle IJIGGOKLLGO(HBMJACBOOPF<ReplicatorData_v1> component_33, IDOOLCJIJHL<ReplicatorData> component_34, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x29403C0", Offset = "0x293F7C0", VA = "0x1829403C0")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : DMNNDJMNGMN
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public HBMJACBOOPF<InventionInstanceIdData_v1> component_36;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public IDOOLCJIJHL<InventionInstanceIdData> component_37;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7AAF5F0", Offset = "0x7AAE9F0", VA = "0x187AAF5F0")]
			private void AOLJGBEOMDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7AAF8A0", Offset = "0x7AAECA0", VA = "0x187AAF8A0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly LMKAPNBAFDO log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override LMKAPNBAFDO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7AAFA20", Offset = "0x7AAEE20", VA = "0x187AAFA20", Slot = "14")]
			get
			{
				return default(LMKAPNBAFDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF8B0", Offset = "0x7AAECB0", VA = "0x187AAF8B0", Slot = "15")]
		protected override void OMIHJNKMDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF4C0", Offset = "0x7AAE8C0", VA = "0x187AAF4C0")]
		private JobHandle LNBGJLKJPKA(HBMJACBOOPF<InventionInstanceIdData_v1> component_36, IDOOLCJIJHL<InventionInstanceIdData> component_37, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x29403C0", Offset = "0x293F7C0", VA = "0x1829403C0")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : DMNNDJMNGMN
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public HBMJACBOOPF<OMShapeContainerData_v1> component_39;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public IDOOLCJIJHL<OMShapeContainerData> component_40;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7AB00F0", Offset = "0x7AAF4F0", VA = "0x187AB00F0")]
			private void AOLJGBEOMDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7AB03E0", Offset = "0x7AAF7E0", VA = "0x187AB03E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly LMKAPNBAFDO log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override LMKAPNBAFDO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7AB0690", Offset = "0x7AAFA90", VA = "0x187AB0690", Slot = "14")]
			get
			{
				return default(LMKAPNBAFDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7AB0520", Offset = "0x7AAF920", VA = "0x187AB0520", Slot = "15")]
		protected override void OMIHJNKMDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7AB03F0", Offset = "0x7AAF7F0", VA = "0x187AB03F0")]
		private JobHandle MEEGGIGMEOH(HBMJACBOOPF<OMShapeContainerData_v1> component_39, IDOOLCJIJHL<OMShapeContainerData> component_40, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x29403C0", Offset = "0x293F7C0", VA = "0x1829403C0")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : DMNNDJMNGMN
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public HBMJACBOOPF<AuthoredAIIdData_v1> component_48;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public IDOOLCJIJHL<AuthoredAIIdData> component_49;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7AAEEC0", Offset = "0x7AAE2C0", VA = "0x187AAEEC0")]
			private void AOLJGBEOMDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7AAF180", Offset = "0x7AAE580", VA = "0x187AAF180", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly LMKAPNBAFDO log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override LMKAPNBAFDO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7AAF300", Offset = "0x7AAE700", VA = "0x187AAF300", Slot = "14")]
			get
			{
				return default(LMKAPNBAFDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7AAF190", Offset = "0x7AAE590", VA = "0x187AAF190", Slot = "15")]
		protected override void OMIHJNKMDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7AAED90", Offset = "0x7AAE190", VA = "0x187AAED90")]
		private JobHandle ALDLDIHEGKL(HBMJACBOOPF<AuthoredAIIdData_v1> component_48, IDOOLCJIJHL<AuthoredAIIdData> component_49, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x29403C0", Offset = "0x293F7C0", VA = "0x1829403C0")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : DMNNDJMNGMN
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public HBMJACBOOPF<ContainerCollisionLayerData_v1> component_58;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public IDOOLCJIJHL<PhysicsModelCollisionLayerData> component_59;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2170", Offset = "0x7AB1570", VA = "0x187AB2170")]
			private void AOLJGBEOMDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2460", Offset = "0x7AB1860", VA = "0x187AB2460", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly LMKAPNBAFDO log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override LMKAPNBAFDO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2710", Offset = "0x7AB1B10", VA = "0x187AB2710", Slot = "14")]
			get
			{
				return default(LMKAPNBAFDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7AB25A0", Offset = "0x7AB19A0", VA = "0x187AB25A0", Slot = "15")]
		protected override void OMIHJNKMDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2470", Offset = "0x7AB1870", VA = "0x187AB2470")]
		private JobHandle OLPADBDHMBE(HBMJACBOOPF<ContainerCollisionLayerData_v1> component_58, IDOOLCJIJHL<PhysicsModelCollisionLayerData> component_59, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x29403C0", Offset = "0x293F7C0", VA = "0x1829403C0")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : DMNNDJMNGMN
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public HBMJACBOOPF<ContainerGrabbableModeData_v1> component_62;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public IDOOLCJIJHL<PhysicsModelGrabbableModeData> component_63;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7AB3AA0", Offset = "0x7AB2EA0", VA = "0x187AB3AA0")]
			private void AOLJGBEOMDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7AB3D90", Offset = "0x7AB3190", VA = "0x187AB3D90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private static readonly LMKAPNBAFDO log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override LMKAPNBAFDO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7AB3F10", Offset = "0x7AB3310", VA = "0x187AB3F10", Slot = "14")]
			get
			{
				return default(LMKAPNBAFDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3DA0", Offset = "0x7AB31A0", VA = "0x187AB3DA0", Slot = "15")]
		protected override void OMIHJNKMDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3970", Offset = "0x7AB2D70", VA = "0x187AB3970")]
		private JobHandle CAKLDFNBOCJ(HBMJACBOOPF<ContainerGrabbableModeData_v1> component_62, IDOOLCJIJHL<PhysicsModelGrabbableModeData> component_63, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x29403C0", Offset = "0x293F7C0", VA = "0x1829403C0")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : DMNNDJMNGMN
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public HBMJACBOOPF<ContainerFlagsData_v1> component_70;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public HBMJACBOOPF<ContainerFlagsData_v2> component_71;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public HBMJACBOOPF<PhysicsModelFlagsData_v3> component_72;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public IDOOLCJIJHL<PhysicsModelFlagsData> component_73;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2DF0", Offset = "0x7AB21F0", VA = "0x187AB2DF0")]
			private void AOLJGBEOMDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7AB34C0", Offset = "0x7AB28C0", VA = "0x187AB34C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly LMKAPNBAFDO log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override LMKAPNBAFDO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7AB38D0", Offset = "0x7AB2CD0", VA = "0x187AB38D0", Slot = "14")]
			get
			{
				return default(LMKAPNBAFDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7AB3670", Offset = "0x7AB2A70", VA = "0x187AB3670", Slot = "15")]
		protected override void OMIHJNKMDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7AB34D0", Offset = "0x7AB28D0", VA = "0x187AB34D0")]
		private JobHandle MOOEOODDFBA(HBMJACBOOPF<ContainerFlagsData_v1> component_70, HBMJACBOOPF<ContainerFlagsData_v2> component_71, HBMJACBOOPF<PhysicsModelFlagsData_v3> component_72, IDOOLCJIJHL<PhysicsModelFlagsData> component_73, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x29403C0", Offset = "0x293F7C0", VA = "0x1829403C0")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : DMNNDJMNGMN
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public HBMJACBOOPF<ContainerCollisionModeData_v1> component_74;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public IDOOLCJIJHL<PhysicsModelCollisionModeData> component_75;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7AB27B0", Offset = "0x7AB1BB0", VA = "0x187AB27B0")]
			private void AOLJGBEOMDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2AA0", Offset = "0x7AB1EA0", VA = "0x187AB2AA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static readonly LMKAPNBAFDO log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override LMKAPNBAFDO Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7AB2C20", Offset = "0x7AB2020", VA = "0x187AB2C20", Slot = "14")]
			get
			{
				return default(LMKAPNBAFDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2AB0", Offset = "0x7AB1EB0", VA = "0x187AB2AB0", Slot = "15")]
		protected override void OMIHJNKMDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2C70", Offset = "0x7AB2070", VA = "0x187AB2C70")]
		private JobHandle PJEDNICFBNN(HBMJACBOOPF<ContainerCollisionModeData_v1> component_74, IDOOLCJIJHL<PhysicsModelCollisionModeData> component_75, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x29403C0", Offset = "0x293F7C0", VA = "0x1829403C0")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : DMNNDJMNGMN
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public HBMJACBOOPF<ObjectPolicyData_v1> component_78;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public HBMJACBOOPF<ObjectPolicyData_v2> component_79;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public HBMJACBOOPF<ObjectPolicyData_v3> component_80;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public HBMJACBOOPF<ObjectPolicyData_v4> component_81;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public HBMJACBOOPF<ObjectPolicyData_v5> component_82;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public IDOOLCJIJHL<ObjectPolicyData> component_83;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7AB0930", Offset = "0x7AAFD30", VA = "0x187AB0930")]
			private void AOLJGBEOMDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7AB1720", Offset = "0x7AB0B20", VA = "0x187AB1720", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly LMKAPNBAFDO log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override LMKAPNBAFDO Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7AB1A40", Offset = "0x7AB0E40", VA = "0x187AB1A40", Slot = "14")]
			get
			{
				return default(LMKAPNBAFDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7AB1730", Offset = "0x7AB0B30", VA = "0x187AB1730", Slot = "15")]
		protected override void OMIHJNKMDHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7AB0730", Offset = "0x7AAFB30", VA = "0x187AB0730")]
		private JobHandle KEOLFEKDLEM(HBMJACBOOPF<ObjectPolicyData_v1> component_78, HBMJACBOOPF<ObjectPolicyData_v2> component_79, HBMJACBOOPF<ObjectPolicyData_v3> component_80, HBMJACBOOPF<ObjectPolicyData_v4> component_81, HBMJACBOOPF<ObjectPolicyData_v5> component_82, IDOOLCJIJHL<ObjectPolicyData> component_83, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x29403C0", Offset = "0x293F7C0", VA = "0x1829403C0")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class GEEEBJAOALD
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x36A4F60", Offset = "0x36A4360", VA = "0x1836A4F60")]
	public static void INHMIGPDKEO<T, U>(T NJJGNHFHOAM, [Out] U JOAJJJIEKKO) where T : struct where U : struct
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
