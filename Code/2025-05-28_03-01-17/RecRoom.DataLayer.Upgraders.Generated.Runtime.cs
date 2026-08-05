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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LKMOPJKEFIP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7D4FD50", Offset = "0x7D4EB50", VA = "0x187D4FD50")]
	public static void NJPGGJLCCEE(ComponentSystemGroup NNLLPHNMAFL, EntityCommandBufferSystem IBKADNGKJHI)
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
		[Cpp2IlInjected.Address(RVA = "0x7D4FD50", Offset = "0x7D4EB50", VA = "0x187D4FD50")]
		public static void PGEOOEPFBNL(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7D55C40", Offset = "0x7D54A40", VA = "0x187D55C40")]
		private void NJPGGJLCCEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D56530", Offset = "0x7D55330", VA = "0x187D56530")]
		private void PBCBBMEJCME(PBINLJPKIGC system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : PBINLJPKIGC
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public LOADEGJPHHF<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public IEJADCJMKLN<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7D52010", Offset = "0x7D50E10", VA = "0x187D52010")]
			private void DNAIKHKCNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7D52350", Offset = "0x7D51150", VA = "0x187D52350", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly IEBEPMGFCGH log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override IEBEPMGFCGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7D51FC0", Offset = "0x7D50DC0", VA = "0x187D51FC0", Slot = "14")]
			get
			{
				return default(IEBEPMGFCGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7D52360", Offset = "0x7D51160", VA = "0x187D52360", Slot = "15")]
		protected override void OGBLGNGEAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7D51E90", Offset = "0x7D50C90", VA = "0x187D51E90")]
		private JobHandle GEAGLNJJLOH(LOADEGJPHHF<PersistentUserTagData_v1> component_1, IEJADCJMKLN<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2A78D90", Offset = "0x2A77B90", VA = "0x182A78D90")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : PBINLJPKIGC
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public LOADEGJPHHF<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public IEJADCJMKLN<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7D4FFF0", Offset = "0x7D4EDF0", VA = "0x187D4FFF0")]
			private void DNAIKHKCNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7D502D0", Offset = "0x7D4F0D0", VA = "0x187D502D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly IEBEPMGFCGH log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override IEBEPMGFCGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7D4FE70", Offset = "0x7D4EC70", VA = "0x187D4FE70", Slot = "14")]
			get
			{
				return default(IEBEPMGFCGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D502E0", Offset = "0x7D4F0E0", VA = "0x187D502E0", Slot = "15")]
		protected override void OGBLGNGEAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7D4FEC0", Offset = "0x7D4ECC0", VA = "0x187D4FEC0")]
		private JobHandle IAOALFONAOB(LOADEGJPHHF<LocalDeformableScaleData_v1> component_4, IEJADCJMKLN<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2A78D90", Offset = "0x2A77B90", VA = "0x182A78D90")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : PBINLJPKIGC
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public LOADEGJPHHF<SerializedDataLayerVersionData_v1> component_12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public IEJADCJMKLN<SerializedDataLayerVersionData> component_13;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7D55140", Offset = "0x7D53F40", VA = "0x187D55140")]
			private void DNAIKHKCNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7D55400", Offset = "0x7D54200", VA = "0x187D55400", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly IEBEPMGFCGH log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override IEBEPMGFCGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7D54FC0", Offset = "0x7D53DC0", VA = "0x187D54FC0", Slot = "14")]
			get
			{
				return default(IEBEPMGFCGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7D55410", Offset = "0x7D54210", VA = "0x187D55410", Slot = "15")]
		protected override void OGBLGNGEAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7D55010", Offset = "0x7D53E10", VA = "0x187D55010")]
		private JobHandle HHDCMGCBFFM(LOADEGJPHHF<SerializedDataLayerVersionData_v1> component_12, IEJADCJMKLN<SerializedDataLayerVersionData> component_13, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2A78D90", Offset = "0x2A77B90", VA = "0x182A78D90")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : PBINLJPKIGC
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public LOADEGJPHHF<ReplicatorPreallocatedObjectCountData_v1> component_21;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public IEJADCJMKLN<ReplicatorPreallocatedObjectCountData> component_22;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7D54B30", Offset = "0x7D53930", VA = "0x187D54B30")]
			private void DNAIKHKCNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7D54DF0", Offset = "0x7D53BF0", VA = "0x187D54DF0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly IEBEPMGFCGH log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override IEBEPMGFCGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7D54AE0", Offset = "0x7D538E0", VA = "0x187D54AE0", Slot = "14")]
			get
			{
				return default(IEBEPMGFCGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7D54E00", Offset = "0x7D53C00", VA = "0x187D54E00", Slot = "15")]
		protected override void OGBLGNGEAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7D549B0", Offset = "0x7D537B0", VA = "0x187D549B0")]
		private JobHandle CKFMHGBPBFH(LOADEGJPHHF<ReplicatorPreallocatedObjectCountData_v1> component_21, IEJADCJMKLN<ReplicatorPreallocatedObjectCountData> component_22, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2A78D90", Offset = "0x2A77B90", VA = "0x182A78D90")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : PBINLJPKIGC
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public LOADEGJPHHF<ToolCleanupStatusData_v1> component_26;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public IEJADCJMKLN<ToolCleanupStatusData> component_27;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7D55750", Offset = "0x7D54550", VA = "0x187D55750")]
			private void DNAIKHKCNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7D55A70", Offset = "0x7D54870", VA = "0x187D55A70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly IEBEPMGFCGH log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override IEBEPMGFCGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7D55700", Offset = "0x7D54500", VA = "0x187D55700", Slot = "14")]
			get
			{
				return default(IEBEPMGFCGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7D55A80", Offset = "0x7D54880", VA = "0x187D55A80", Slot = "15")]
		protected override void OGBLGNGEAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7D555D0", Offset = "0x7D543D0", VA = "0x187D555D0")]
		private JobHandle ENGJOIMDDOD(LOADEGJPHHF<ToolCleanupStatusData_v1> component_26, IEJADCJMKLN<ToolCleanupStatusData> component_27, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2A78D90", Offset = "0x2A77B90", VA = "0x182A78D90")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : PBINLJPKIGC
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public LOADEGJPHHF<ReplicatorData_v1> component_34;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public IEJADCJMKLN<ReplicatorData> component_35;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7D544E0", Offset = "0x7D532E0", VA = "0x187D544E0")]
			private void DNAIKHKCNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7D547E0", Offset = "0x7D535E0", VA = "0x187D547E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly IEBEPMGFCGH log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override IEBEPMGFCGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7D54490", Offset = "0x7D53290", VA = "0x187D54490", Slot = "14")]
			get
			{
				return default(IEBEPMGFCGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7D547F0", Offset = "0x7D535F0", VA = "0x187D547F0", Slot = "15")]
		protected override void OGBLGNGEAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7D54360", Offset = "0x7D53160", VA = "0x187D54360")]
		private JobHandle DGDIFJBMBHH(LOADEGJPHHF<ReplicatorData_v1> component_34, IEJADCJMKLN<ReplicatorData> component_35, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2A78D90", Offset = "0x2A77B90", VA = "0x182A78D90")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : PBINLJPKIGC
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public LOADEGJPHHF<InventionInstanceIdData_v1> component_38;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public IEJADCJMKLN<InventionInstanceIdData> component_39;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7D4F8D0", Offset = "0x7D4E6D0", VA = "0x187D4F8D0")]
			private void DNAIKHKCNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7D4FB80", Offset = "0x7D4E980", VA = "0x187D4FB80", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly IEBEPMGFCGH log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override IEBEPMGFCGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7D4F880", Offset = "0x7D4E680", VA = "0x187D4F880", Slot = "14")]
			get
			{
				return default(IEBEPMGFCGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7D4FB90", Offset = "0x7D4E990", VA = "0x187D4FB90", Slot = "15")]
		protected override void OGBLGNGEAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7D4F750", Offset = "0x7D4E550", VA = "0x187D4F750")]
		private JobHandle DLMNFAAPDOA(LOADEGJPHHF<InventionInstanceIdData_v1> component_38, IEJADCJMKLN<InventionInstanceIdData> component_39, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2A78D90", Offset = "0x2A77B90", VA = "0x182A78D90")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : PBINLJPKIGC
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public LOADEGJPHHF<OMShapeContainerData_v1> component_43;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public IEJADCJMKLN<OMShapeContainerData> component_44;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7D50620", Offset = "0x7D4F420", VA = "0x187D50620")]
			private void DNAIKHKCNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7D50910", Offset = "0x7D4F710", VA = "0x187D50910", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly IEBEPMGFCGH log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override IEBEPMGFCGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7D504A0", Offset = "0x7D4F2A0", VA = "0x187D504A0", Slot = "14")]
			get
			{
				return default(IEBEPMGFCGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7D50920", Offset = "0x7D4F720", VA = "0x187D50920", Slot = "15")]
		protected override void OGBLGNGEAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7D504F0", Offset = "0x7D4F2F0", VA = "0x187D504F0")]
		private JobHandle JOJOEEFFPCI(LOADEGJPHHF<OMShapeContainerData_v1> component_43, IEJADCJMKLN<OMShapeContainerData> component_44, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2A78D90", Offset = "0x2A77B90", VA = "0x182A78D90")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : PBINLJPKIGC
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public LOADEGJPHHF<AuthoredAIIdData_v1> component_52;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public LOADEGJPHHF<AuthoredAIIdData_v2> component_53;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public LOADEGJPHHF<AuthoredAIIdData_v3> component_54;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public IEJADCJMKLN<AuthoredAIIdData> component_55;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7D4ED70", Offset = "0x7D4DB70", VA = "0x187D4ED70")]
			private void DNAIKHKCNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7D4F490", Offset = "0x7D4E290", VA = "0x187D4F490", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly IEBEPMGFCGH log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override IEBEPMGFCGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7D4ED20", Offset = "0x7D4DB20", VA = "0x187D4ED20", Slot = "14")]
			get
			{
				return default(IEBEPMGFCGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7D4F4A0", Offset = "0x7D4E2A0", VA = "0x187D4F4A0", Slot = "15")]
		protected override void OGBLGNGEAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7D4EB80", Offset = "0x7D4D980", VA = "0x187D4EB80")]
		private JobHandle DLCNAOHCPAK(LOADEGJPHHF<AuthoredAIIdData_v1> component_52, LOADEGJPHHF<AuthoredAIIdData_v2> component_53, LOADEGJPHHF<AuthoredAIIdData_v3> component_54, IEJADCJMKLN<AuthoredAIIdData> component_55, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2A78D90", Offset = "0x2A77B90", VA = "0x182A78D90")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : PBINLJPKIGC
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public LOADEGJPHHF<ContainerCollisionLayerData_v1> component_64;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public IEJADCJMKLN<PhysicsModelCollisionLayerData> component_65;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7D526A0", Offset = "0x7D514A0", VA = "0x187D526A0")]
			private void DNAIKHKCNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7D52990", Offset = "0x7D51790", VA = "0x187D52990", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly IEBEPMGFCGH log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override IEBEPMGFCGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7D52520", Offset = "0x7D51320", VA = "0x187D52520", Slot = "14")]
			get
			{
				return default(IEBEPMGFCGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7D529A0", Offset = "0x7D517A0", VA = "0x187D529A0", Slot = "15")]
		protected override void OGBLGNGEAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7D52570", Offset = "0x7D51370", VA = "0x187D52570")]
		private JobHandle IINGDPACJEP(LOADEGJPHHF<ContainerCollisionLayerData_v1> component_64, IEJADCJMKLN<PhysicsModelCollisionLayerData> component_65, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2A78D90", Offset = "0x2A77B90", VA = "0x182A78D90")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : PBINLJPKIGC
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public LOADEGJPHHF<ContainerGrabbableModeData_v1> component_68;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public IEJADCJMKLN<PhysicsModelGrabbableModeData> component_69;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7D53EA0", Offset = "0x7D52CA0", VA = "0x187D53EA0")]
			private void DNAIKHKCNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7D54190", Offset = "0x7D52F90", VA = "0x187D54190", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly IEBEPMGFCGH log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override IEBEPMGFCGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7D53E50", Offset = "0x7D52C50", VA = "0x187D53E50", Slot = "14")]
			get
			{
				return default(IEBEPMGFCGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7D541A0", Offset = "0x7D52FA0", VA = "0x187D541A0", Slot = "15")]
		protected override void OGBLGNGEAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7D53D20", Offset = "0x7D52B20", VA = "0x187D53D20")]
		private JobHandle BNIFPECLEFL(LOADEGJPHHF<ContainerGrabbableModeData_v1> component_68, IEJADCJMKLN<PhysicsModelGrabbableModeData> component_69, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2A78D90", Offset = "0x2A77B90", VA = "0x182A78D90")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : PBINLJPKIGC
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public LOADEGJPHHF<ContainerFlagsData_v1> component_76;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public LOADEGJPHHF<ContainerFlagsData_v2> component_77;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public LOADEGJPHHF<PhysicsModelFlagsData_v3> component_78;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public IEJADCJMKLN<PhysicsModelFlagsData> component_79;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7D53390", Offset = "0x7D52190", VA = "0x187D53390")]
			private void DNAIKHKCNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7D53A60", Offset = "0x7D52860", VA = "0x187D53A60", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly IEBEPMGFCGH log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override IEBEPMGFCGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7D531A0", Offset = "0x7D51FA0", VA = "0x187D531A0", Slot = "14")]
			get
			{
				return default(IEBEPMGFCGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7D53A70", Offset = "0x7D52870", VA = "0x187D53A70", Slot = "15")]
		protected override void OGBLGNGEAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7D531F0", Offset = "0x7D51FF0", VA = "0x187D531F0")]
		private JobHandle ILEICJKBEMF(LOADEGJPHHF<ContainerFlagsData_v1> component_76, LOADEGJPHHF<ContainerFlagsData_v2> component_77, LOADEGJPHHF<PhysicsModelFlagsData_v3> component_78, IEJADCJMKLN<PhysicsModelFlagsData> component_79, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2A78D90", Offset = "0x2A77B90", VA = "0x182A78D90")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : PBINLJPKIGC
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public LOADEGJPHHF<ContainerCollisionModeData_v1> component_80;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public IEJADCJMKLN<PhysicsModelCollisionModeData> component_81;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7D52CE0", Offset = "0x7D51AE0", VA = "0x187D52CE0")]
			private void DNAIKHKCNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7D52FD0", Offset = "0x7D51DD0", VA = "0x187D52FD0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly IEBEPMGFCGH log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override IEBEPMGFCGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7D52B60", Offset = "0x7D51960", VA = "0x187D52B60", Slot = "14")]
			get
			{
				return default(IEBEPMGFCGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7D52FE0", Offset = "0x7D51DE0", VA = "0x187D52FE0", Slot = "15")]
		protected override void OGBLGNGEAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7D52BB0", Offset = "0x7D519B0", VA = "0x187D52BB0")]
		private JobHandle LPBDKJIPILO(LOADEGJPHHF<ContainerCollisionModeData_v1> component_80, IEJADCJMKLN<PhysicsModelCollisionModeData> component_81, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2A78D90", Offset = "0x2A77B90", VA = "0x182A78D90")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : PBINLJPKIGC
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public LOADEGJPHHF<ObjectPolicyData_v1> component_84;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public LOADEGJPHHF<ObjectPolicyData_v2> component_85;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public LOADEGJPHHF<ObjectPolicyData_v3> component_86;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public LOADEGJPHHF<ObjectPolicyData_v4> component_87;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public LOADEGJPHHF<ObjectPolicyData_v5> component_88;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public IEJADCJMKLN<ObjectPolicyData> component_89;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7D50D30", Offset = "0x7D4FB30", VA = "0x187D50D30")]
			private void DNAIKHKCNMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7D51B20", Offset = "0x7D50920", VA = "0x187D51B20", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly IEBEPMGFCGH log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override IEBEPMGFCGH Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7D50AE0", Offset = "0x7D4F8E0", VA = "0x187D50AE0", Slot = "14")]
			get
			{
				return default(IEBEPMGFCGH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7D51B30", Offset = "0x7D50930", VA = "0x187D51B30", Slot = "15")]
		protected override void OGBLGNGEAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7D50B30", Offset = "0x7D4F930", VA = "0x187D50B30")]
		private JobHandle JPHGAKCAOKH(LOADEGJPHHF<ObjectPolicyData_v1> component_84, LOADEGJPHHF<ObjectPolicyData_v2> component_85, LOADEGJPHHF<ObjectPolicyData_v3> component_86, LOADEGJPHHF<ObjectPolicyData_v4> component_87, LOADEGJPHHF<ObjectPolicyData_v5> component_88, IEJADCJMKLN<ObjectPolicyData> component_89, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2A78D90", Offset = "0x2A77B90", VA = "0x182A78D90")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class AHBFEOPHNCO
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4047A00", Offset = "0x4046800", VA = "0x184047A00")]
	public static void JNLHNAJJPBE<T, U>(T HIKDLOJNBJD, [Out] U GAGOCOIFLCJ) where T : struct where U : struct
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
