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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AMGNFKILPMF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7F525E0", Offset = "0x7F50DE0", VA = "0x187F525E0")]
	public static void LGOFFLJILKI(ComponentSystemGroup LCPLPGNINPG, EntityCommandBufferSystem OFCCHAMOKBL)
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
		[Cpp2IlInjected.Address(RVA = "0x7F525E0", Offset = "0x7F50DE0", VA = "0x187F525E0")]
		public static void HGOMBIMHAHA(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F596A0", Offset = "0x7F57EA0", VA = "0x187F596A0")]
		private void LGOFFLJILKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7F59F90", Offset = "0x7F58790", VA = "0x187F59F90")]
		private void LKKLEMGDNDO(MGLMPKHAIKK system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : MGLMPKHAIKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public MEBOEOOMDNJ<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public KDHLPHCFPKL<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7F55BF0", Offset = "0x7F543F0", VA = "0x187F55BF0")]
			private void LADMOOBMFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7F55BE0", Offset = "0x7F543E0", VA = "0x187F55BE0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly BMELPJIFPCL log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override BMELPJIFPCL Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7F558F0", Offset = "0x7F540F0", VA = "0x187F558F0", Slot = "14")]
			get
			{
				return default(BMELPJIFPCL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7F55940", Offset = "0x7F54140", VA = "0x187F55940", Slot = "15")]
		protected override void DEILEOEKILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F55AB0", Offset = "0x7F542B0", VA = "0x187F55AB0")]
		private JobHandle KMAKPLJKPLD(MEBOEOOMDNJ<PersistentUserTagData_v1> component_1, KDHLPHCFPKL<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B039F0", VA = "0x182B051F0")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : MGLMPKHAIKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public MEBOEOOMDNJ<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public KDHLPHCFPKL<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7F53BD0", Offset = "0x7F523D0", VA = "0x187F53BD0")]
			private void LADMOOBMFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7F53BC0", Offset = "0x7F523C0", VA = "0x187F53BC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly BMELPJIFPCL log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override BMELPJIFPCL Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7F53A00", Offset = "0x7F52200", VA = "0x187F53A00", Slot = "14")]
			get
			{
				return default(BMELPJIFPCL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7F53A50", Offset = "0x7F52250", VA = "0x187F53A50", Slot = "15")]
		protected override void DEILEOEKILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F538D0", Offset = "0x7F520D0", VA = "0x187F538D0")]
		private JobHandle AFHJEJIAIKD(MEBOEOOMDNJ<LocalDeformableScaleData_v1> component_4, KDHLPHCFPKL<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B039F0", VA = "0x182B051F0")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : MGLMPKHAIKK
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public MEBOEOOMDNJ<SerializedDataLayerVersionData_v1> component_12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public KDHLPHCFPKL<SerializedDataLayerVersionData> component_13;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7F58D20", Offset = "0x7F57520", VA = "0x187F58D20")]
			private void LADMOOBMFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7F58D10", Offset = "0x7F57510", VA = "0x187F58D10", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly BMELPJIFPCL log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override BMELPJIFPCL Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7F58B50", Offset = "0x7F57350", VA = "0x187F58B50", Slot = "14")]
			get
			{
				return default(BMELPJIFPCL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F58BA0", Offset = "0x7F573A0", VA = "0x187F58BA0", Slot = "15")]
		protected override void DEILEOEKILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7F58A20", Offset = "0x7F57220", VA = "0x187F58A20")]
		private JobHandle BNDPBKDAODL(MEBOEOOMDNJ<SerializedDataLayerVersionData_v1> component_12, KDHLPHCFPKL<SerializedDataLayerVersionData> component_13, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B039F0", VA = "0x182B051F0")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : MGLMPKHAIKK
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public MEBOEOOMDNJ<ReplicatorPreallocatedObjectCountData_v1> component_20;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public KDHLPHCFPKL<ReplicatorPreallocatedObjectCountData> component_21;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7F58710", Offset = "0x7F56F10", VA = "0x187F58710")]
			private void LADMOOBMFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7F58700", Offset = "0x7F56F00", VA = "0x187F58700", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly BMELPJIFPCL log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override BMELPJIFPCL Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7F58410", Offset = "0x7F56C10", VA = "0x187F58410", Slot = "14")]
			get
			{
				return default(BMELPJIFPCL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7F58460", Offset = "0x7F56C60", VA = "0x187F58460", Slot = "15")]
		protected override void DEILEOEKILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7F585D0", Offset = "0x7F56DD0", VA = "0x187F585D0")]
		private JobHandle DMHONACAGOP(MEBOEOOMDNJ<ReplicatorPreallocatedObjectCountData_v1> component_20, KDHLPHCFPKL<ReplicatorPreallocatedObjectCountData> component_21, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B039F0", VA = "0x182B051F0")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : MGLMPKHAIKK
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public MEBOEOOMDNJ<ToolCleanupStatusData_v1> component_25;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public KDHLPHCFPKL<ToolCleanupStatusData> component_26;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7F59330", Offset = "0x7F57B30", VA = "0x187F59330")]
			private void LADMOOBMFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7F59320", Offset = "0x7F57B20", VA = "0x187F59320", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly BMELPJIFPCL log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override BMELPJIFPCL Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7F59160", Offset = "0x7F57960", VA = "0x187F59160", Slot = "14")]
			get
			{
				return default(BMELPJIFPCL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7F591B0", Offset = "0x7F579B0", VA = "0x187F591B0", Slot = "15")]
		protected override void DEILEOEKILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7F59030", Offset = "0x7F57830", VA = "0x187F59030")]
		private JobHandle CMCJFOIOEFJ(MEBOEOOMDNJ<ToolCleanupStatusData_v1> component_25, KDHLPHCFPKL<ToolCleanupStatusData> component_26, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B039F0", VA = "0x182B051F0")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : MGLMPKHAIKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public MEBOEOOMDNJ<ReplicatorData_v1> component_33;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public KDHLPHCFPKL<ReplicatorData> component_34;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7F580C0", Offset = "0x7F568C0", VA = "0x187F580C0")]
			private void LADMOOBMFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7F580B0", Offset = "0x7F568B0", VA = "0x187F580B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly BMELPJIFPCL log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override BMELPJIFPCL Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7F57DC0", Offset = "0x7F565C0", VA = "0x187F57DC0", Slot = "14")]
			get
			{
				return default(BMELPJIFPCL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F57E10", Offset = "0x7F56610", VA = "0x187F57E10", Slot = "15")]
		protected override void DEILEOEKILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7F57F80", Offset = "0x7F56780", VA = "0x187F57F80")]
		private JobHandle HLALKEIGKBD(MEBOEOOMDNJ<ReplicatorData_v1> component_33, KDHLPHCFPKL<ReplicatorData> component_34, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B039F0", VA = "0x182B051F0")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : MGLMPKHAIKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public MEBOEOOMDNJ<InventionInstanceIdData_v1> component_37;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public KDHLPHCFPKL<InventionInstanceIdData> component_38;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7F535D0", Offset = "0x7F51DD0", VA = "0x187F535D0")]
			private void LADMOOBMFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7F535C0", Offset = "0x7F51DC0", VA = "0x187F535C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly BMELPJIFPCL log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override BMELPJIFPCL Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7F532D0", Offset = "0x7F51AD0", VA = "0x187F532D0", Slot = "14")]
			get
			{
				return default(BMELPJIFPCL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7F53320", Offset = "0x7F51B20", VA = "0x187F53320", Slot = "15")]
		protected override void DEILEOEKILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7F53490", Offset = "0x7F51C90", VA = "0x187F53490")]
		private JobHandle IGPOJPELKHC(MEBOEOOMDNJ<InventionInstanceIdData_v1> component_37, KDHLPHCFPKL<InventionInstanceIdData> component_38, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B039F0", VA = "0x182B051F0")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : MGLMPKHAIKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public MEBOEOOMDNJ<OMShapeContainerData_v1> component_42;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public KDHLPHCFPKL<OMShapeContainerData> component_43;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7F54200", Offset = "0x7F52A00", VA = "0x187F54200")]
			private void LADMOOBMFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7F541F0", Offset = "0x7F529F0", VA = "0x187F541F0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly BMELPJIFPCL log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override BMELPJIFPCL Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7F53F00", Offset = "0x7F52700", VA = "0x187F53F00", Slot = "14")]
			get
			{
				return default(BMELPJIFPCL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7F53F50", Offset = "0x7F52750", VA = "0x187F53F50", Slot = "15")]
		protected override void DEILEOEKILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7F540C0", Offset = "0x7F528C0", VA = "0x187F540C0")]
		private JobHandle LKCEOMMCDIL(MEBOEOOMDNJ<OMShapeContainerData_v1> component_42, KDHLPHCFPKL<OMShapeContainerData> component_43, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B039F0", VA = "0x182B051F0")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : MGLMPKHAIKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public MEBOEOOMDNJ<AuthoredAIIdData_v1> component_51;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public MEBOEOOMDNJ<AuthoredAIIdData_v2> component_52;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public MEBOEOOMDNJ<AuthoredAIIdData_v3> component_53;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public KDHLPHCFPKL<AuthoredAIIdData> component_54;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7F52B60", Offset = "0x7F51360", VA = "0x187F52B60")]
			private void LADMOOBMFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7F52B50", Offset = "0x7F51350", VA = "0x187F52B50", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly BMELPJIFPCL log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override BMELPJIFPCL Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7F52700", Offset = "0x7F50F00", VA = "0x187F52700", Slot = "14")]
			get
			{
				return default(BMELPJIFPCL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7F52750", Offset = "0x7F50F50", VA = "0x187F52750", Slot = "15")]
		protected override void DEILEOEKILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7F529B0", Offset = "0x7F511B0", VA = "0x187F529B0")]
		private JobHandle EMFKAJNJAMP(MEBOEOOMDNJ<AuthoredAIIdData_v1> component_51, MEBOEOOMDNJ<AuthoredAIIdData_v2> component_52, MEBOEOOMDNJ<AuthoredAIIdData_v3> component_53, KDHLPHCFPKL<AuthoredAIIdData> component_54, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B039F0", VA = "0x182B051F0")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : MGLMPKHAIKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public MEBOEOOMDNJ<ContainerCollisionLayerData_v1> component_63;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public KDHLPHCFPKL<PhysicsModelCollisionLayerData> component_64;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7F56280", Offset = "0x7F54A80", VA = "0x187F56280")]
			private void LADMOOBMFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7F56270", Offset = "0x7F54A70", VA = "0x187F56270", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly BMELPJIFPCL log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override BMELPJIFPCL Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7F55F80", Offset = "0x7F54780", VA = "0x187F55F80", Slot = "14")]
			get
			{
				return default(BMELPJIFPCL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7F55FD0", Offset = "0x7F547D0", VA = "0x187F55FD0", Slot = "15")]
		protected override void DEILEOEKILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7F56140", Offset = "0x7F54940", VA = "0x187F56140")]
		private JobHandle HOAAKPEMOJH(MEBOEOOMDNJ<ContainerCollisionLayerData_v1> component_63, KDHLPHCFPKL<PhysicsModelCollisionLayerData> component_64, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B039F0", VA = "0x182B051F0")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : MGLMPKHAIKK
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public MEBOEOOMDNJ<ContainerGrabbableModeData_v1> component_67;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public KDHLPHCFPKL<PhysicsModelGrabbableModeData> component_68;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7F57A80", Offset = "0x7F56280", VA = "0x187F57A80")]
			private void LADMOOBMFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7F57A70", Offset = "0x7F56270", VA = "0x187F57A70", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly BMELPJIFPCL log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override BMELPJIFPCL Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7F57780", Offset = "0x7F55F80", VA = "0x187F57780", Slot = "14")]
			get
			{
				return default(BMELPJIFPCL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7F577D0", Offset = "0x7F55FD0", VA = "0x187F577D0", Slot = "15")]
		protected override void DEILEOEKILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7F57940", Offset = "0x7F56140", VA = "0x187F57940")]
		private JobHandle IBBEENPNFPA(MEBOEOOMDNJ<ContainerGrabbableModeData_v1> component_67, KDHLPHCFPKL<PhysicsModelGrabbableModeData> component_68, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B039F0", VA = "0x182B051F0")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : MGLMPKHAIKK
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public MEBOEOOMDNJ<ContainerFlagsData_v1> component_74;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public MEBOEOOMDNJ<ContainerFlagsData_v2> component_75;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public MEBOEOOMDNJ<PhysicsModelFlagsData_v3> component_76;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public KDHLPHCFPKL<PhysicsModelFlagsData> component_77;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7F57060", Offset = "0x7F55860", VA = "0x187F57060")]
			private void LADMOOBMFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7F57050", Offset = "0x7F55850", VA = "0x187F57050", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly BMELPJIFPCL log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override BMELPJIFPCL Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7F56C00", Offset = "0x7F55400", VA = "0x187F56C00", Slot = "14")]
			get
			{
				return default(BMELPJIFPCL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7F56C50", Offset = "0x7F55450", VA = "0x187F56C50", Slot = "15")]
		protected override void DEILEOEKILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7F56EB0", Offset = "0x7F556B0", VA = "0x187F56EB0")]
		private JobHandle DNEPOAPAGAC(MEBOEOOMDNJ<ContainerFlagsData_v1> component_74, MEBOEOOMDNJ<ContainerFlagsData_v2> component_75, MEBOEOOMDNJ<PhysicsModelFlagsData_v3> component_76, KDHLPHCFPKL<PhysicsModelFlagsData> component_77, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B039F0", VA = "0x182B051F0")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : MGLMPKHAIKK
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public MEBOEOOMDNJ<ContainerCollisionModeData_v1> component_78;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public KDHLPHCFPKL<PhysicsModelCollisionModeData> component_79;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7F56790", Offset = "0x7F54F90", VA = "0x187F56790")]
			private void LADMOOBMFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7F56780", Offset = "0x7F54F80", VA = "0x187F56780", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly BMELPJIFPCL log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override BMELPJIFPCL Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7F565C0", Offset = "0x7F54DC0", VA = "0x187F565C0", Slot = "14")]
			get
			{
				return default(BMELPJIFPCL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7F56610", Offset = "0x7F54E10", VA = "0x187F56610", Slot = "15")]
		protected override void DEILEOEKILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7F56A80", Offset = "0x7F55280", VA = "0x187F56A80")]
		private JobHandle OPOPBIOMLEC(MEBOEOOMDNJ<ContainerCollisionModeData_v1> component_78, KDHLPHCFPKL<PhysicsModelCollisionModeData> component_79, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B039F0", VA = "0x182B051F0")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : MGLMPKHAIKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public MEBOEOOMDNJ<ObjectPolicyData_v1> component_82;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public MEBOEOOMDNJ<ObjectPolicyData_v2> component_83;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public MEBOEOOMDNJ<ObjectPolicyData_v3> component_84;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public MEBOEOOMDNJ<ObjectPolicyData_v4> component_85;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public MEBOEOOMDNJ<ObjectPolicyData_v5> component_86;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public KDHLPHCFPKL<ObjectPolicyData> component_87;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7F54AB0", Offset = "0x7F532B0", VA = "0x187F54AB0")]
			private void LADMOOBMFLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7F54AA0", Offset = "0x7F532A0", VA = "0x187F54AA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly BMELPJIFPCL log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override BMELPJIFPCL Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7F54540", Offset = "0x7F52D40", VA = "0x187F54540", Slot = "14")]
			get
			{
				return default(BMELPJIFPCL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7F54590", Offset = "0x7F52D90", VA = "0x187F54590", Slot = "15")]
		protected override void DEILEOEKILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7F548A0", Offset = "0x7F530A0", VA = "0x187F548A0")]
		private JobHandle HFNLDEGIGHE(MEBOEOOMDNJ<ObjectPolicyData_v1> component_82, MEBOEOOMDNJ<ObjectPolicyData_v2> component_83, MEBOEOOMDNJ<ObjectPolicyData_v3> component_84, MEBOEOOMDNJ<ObjectPolicyData_v4> component_85, MEBOEOOMDNJ<ObjectPolicyData_v5> component_86, KDHLPHCFPKL<ObjectPolicyData> component_87, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2B051F0", Offset = "0x2B039F0", VA = "0x182B051F0")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class KOMDLAFGMCM
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F0E0", Offset = "0x3A9D8E0", VA = "0x183A9F0E0")]
	public static void NMOJEPMKOHK<T, U>(T HAIBAGMKENG, [Out] U JBDCBANFDGG) where T : struct where U : struct
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
