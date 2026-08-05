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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PMNMHFGOBKL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7ADCC30", Offset = "0x7ADB430", VA = "0x187ADCC30")]
	public static void HBLPFPLPPJN(ComponentSystemGroup DIKHGKFCIGP, EntityCommandBufferSystem NDLHNEBLCBM)
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
		[Cpp2IlInjected.Address(RVA = "0x7ADCC30", Offset = "0x7ADB430", VA = "0x187ADCC30")]
		public static void LDEDCGBFCFA(ComponentSystemGroup group, EntityCommandBufferSystem ecbs)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7AE0B00", Offset = "0x7ADF300", VA = "0x187AE0B00")]
		private void HBLPFPLPPJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7AE13F0", Offset = "0x7ADFBF0", VA = "0x187AE13F0")]
		private void NPGBIAAPIAH(LPANKDMAOHE system)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	public class PersistentUserTagDataUpgradeSystem : LPANKDMAOHE
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PersistentUserTagDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public PJNEHJJPJFE<PersistentUserTagData_v1> component_1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public KLJBJIDFHJE<PersistentUserTagData> component_2;

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7ADD040", Offset = "0x7ADB840", VA = "0x187ADD040")]
			private void EGDFHKOBBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7ADD380", Offset = "0x7ADBB80", VA = "0x187ADD380", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly LLPKKNNAIAE log;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected override LLPKKNNAIAE Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x7ADCFF0", Offset = "0x7ADB7F0", VA = "0x187ADCFF0", Slot = "14")]
			get
			{
				return default(LLPKKNNAIAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7ADCD50", Offset = "0x7ADB550", VA = "0x187ADCD50", Slot = "15")]
		protected override void COLBOKBEFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7ADCEC0", Offset = "0x7ADB6C0", VA = "0x187ADCEC0")]
		private JobHandle GPKOLCAMMDO(PJNEHJJPJFE<PersistentUserTagData_v1> component_1, KLJBJIDFHJE<PersistentUserTagData> component_2, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x299DFD0", Offset = "0x299C7D0", VA = "0x18299DFD0")]
		public PersistentUserTagDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public class LocalDeformableScaleDataUpgradeSystem : LPANKDMAOHE
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct LocalDeformableScaleDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public PJNEHJJPJFE<LocalDeformableScaleData_v1> component_4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public KLJBJIDFHJE<LocalDeformableScaleData> component_5;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7ADADD0", Offset = "0x7AD95D0", VA = "0x187ADADD0")]
			private void EGDFHKOBBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7ADB0B0", Offset = "0x7AD98B0", VA = "0x187ADB0B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly LLPKKNNAIAE log;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected override LLPKKNNAIAE Log
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7ADAD80", Offset = "0x7AD9580", VA = "0x187ADAD80", Slot = "14")]
			get
			{
				return default(LLPKKNNAIAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7ADAC10", Offset = "0x7AD9410", VA = "0x187ADAC10", Slot = "15")]
		protected override void COLBOKBEFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7ADB0C0", Offset = "0x7AD98C0", VA = "0x187ADB0C0")]
		private JobHandle NKLLJNJBGAP(PJNEHJJPJFE<LocalDeformableScaleData_v1> component_4, KLJBJIDFHJE<LocalDeformableScaleData> component_5, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x299DFD0", Offset = "0x299C7D0", VA = "0x18299DFD0")]
		public LocalDeformableScaleDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	public class SerializedDataLayerVersionDataUpgradeSystem : LPANKDMAOHE
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct SerializedDataLayerVersionDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public PJNEHJJPJFE<SerializedDataLayerVersionData_v1> component_12;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public KLJBJIDFHJE<SerializedDataLayerVersionData> component_13;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7AE0040", Offset = "0x7ADE840", VA = "0x187AE0040")]
			private void EGDFHKOBBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7AE0300", Offset = "0x7ADEB00", VA = "0x187AE0300", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly LLPKKNNAIAE log;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected override LLPKKNNAIAE Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x7ADFFF0", Offset = "0x7ADE7F0", VA = "0x187ADFFF0", Slot = "14")]
			get
			{
				return default(LLPKKNNAIAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7ADFE80", Offset = "0x7ADE680", VA = "0x187ADFE80", Slot = "15")]
		protected override void COLBOKBEFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7AE0310", Offset = "0x7ADEB10", VA = "0x187AE0310")]
		private JobHandle NBKACOMEJDM(PJNEHJJPJFE<SerializedDataLayerVersionData_v1> component_12, KLJBJIDFHJE<SerializedDataLayerVersionData> component_13, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x299DFD0", Offset = "0x299C7D0", VA = "0x18299DFD0")]
		public SerializedDataLayerVersionDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataUpgradeSystem : LPANKDMAOHE
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorPreallocatedObjectCountDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public PJNEHJJPJFE<ReplicatorPreallocatedObjectCountData_v1> component_21;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public KLJBJIDFHJE<ReplicatorPreallocatedObjectCountData> component_22;

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7ADFB60", Offset = "0x7ADE360", VA = "0x187ADFB60")]
			private void EGDFHKOBBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7ADFE20", Offset = "0x7ADE620", VA = "0x187ADFE20", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly LLPKKNNAIAE log;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected override LLPKKNNAIAE Log
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7ADFB10", Offset = "0x7ADE310", VA = "0x187ADFB10", Slot = "14")]
			get
			{
				return default(LLPKKNNAIAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7ADF870", Offset = "0x7ADE070", VA = "0x187ADF870", Slot = "15")]
		protected override void COLBOKBEFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7ADF9E0", Offset = "0x7ADE1E0", VA = "0x187ADF9E0")]
		private JobHandle GMIHJKKCKBB(PJNEHJJPJFE<ReplicatorPreallocatedObjectCountData_v1> component_21, KLJBJIDFHJE<ReplicatorPreallocatedObjectCountData> component_22, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x299DFD0", Offset = "0x299C7D0", VA = "0x18299DFD0")]
		public ReplicatorPreallocatedObjectCountDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	public class ToolCleanupStatusDataUpgradeSystem : LPANKDMAOHE
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ToolCleanupStatusDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public PJNEHJJPJFE<ToolCleanupStatusData_v1> component_26;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public KLJBJIDFHJE<ToolCleanupStatusData> component_27;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7AE0650", Offset = "0x7ADEE50", VA = "0x187AE0650")]
			private void EGDFHKOBBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7AE0970", Offset = "0x7ADF170", VA = "0x187AE0970", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly LLPKKNNAIAE log;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected override LLPKKNNAIAE Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7AE0600", Offset = "0x7ADEE00", VA = "0x187AE0600", Slot = "14")]
			get
			{
				return default(LLPKKNNAIAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7AE0490", Offset = "0x7ADEC90", VA = "0x187AE0490", Slot = "15")]
		protected override void COLBOKBEFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7AE0980", Offset = "0x7ADF180", VA = "0x187AE0980")]
		private JobHandle PDODNLCEDBG(PJNEHJJPJFE<ToolCleanupStatusData_v1> component_26, KLJBJIDFHJE<ToolCleanupStatusData> component_27, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x299DFD0", Offset = "0x299C7D0", VA = "0x18299DFD0")]
		public ToolCleanupStatusDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public class ReplicatorDataUpgradeSystem : LPANKDMAOHE
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ReplicatorDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public PJNEHJJPJFE<ReplicatorData_v1> component_34;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public KLJBJIDFHJE<ReplicatorData> component_35;

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7ADF3E0", Offset = "0x7ADDBE0", VA = "0x187ADF3E0")]
			private void EGDFHKOBBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7ADF6E0", Offset = "0x7ADDEE0", VA = "0x187ADF6E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static readonly LLPKKNNAIAE log;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected override LLPKKNNAIAE Log
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7ADF390", Offset = "0x7ADDB90", VA = "0x187ADF390", Slot = "14")]
			get
			{
				return default(LLPKKNNAIAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7ADF220", Offset = "0x7ADDA20", VA = "0x187ADF220", Slot = "15")]
		protected override void COLBOKBEFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7ADF6F0", Offset = "0x7ADDEF0", VA = "0x187ADF6F0")]
		private JobHandle PNMJJJNBFLE(PJNEHJJPJFE<ReplicatorData_v1> component_34, KLJBJIDFHJE<ReplicatorData> component_35, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x299DFD0", Offset = "0x299C7D0", VA = "0x18299DFD0")]
		public ReplicatorDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public class InventionInstanceIdDataUpgradeSystem : LPANKDMAOHE
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct InventionInstanceIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public PJNEHJJPJFE<InventionInstanceIdData_v1> component_38;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public KLJBJIDFHJE<InventionInstanceIdData> component_39;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7ADA900", Offset = "0x7AD9100", VA = "0x187ADA900")]
			private void EGDFHKOBBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7ADABB0", Offset = "0x7AD93B0", VA = "0x187ADABB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly LLPKKNNAIAE log;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected override LLPKKNNAIAE Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7ADA8B0", Offset = "0x7AD90B0", VA = "0x187ADA8B0", Slot = "14")]
			get
			{
				return default(LLPKKNNAIAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7ADA610", Offset = "0x7AD8E10", VA = "0x187ADA610", Slot = "15")]
		protected override void COLBOKBEFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7ADA780", Offset = "0x7AD8F80", VA = "0x187ADA780")]
		private JobHandle DFFJPBOFJBK(PJNEHJJPJFE<InventionInstanceIdData_v1> component_38, KLJBJIDFHJE<InventionInstanceIdData> component_39, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x299DFD0", Offset = "0x299C7D0", VA = "0x18299DFD0")]
		public InventionInstanceIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	public class OMShapeContainerDataUpgradeSystem : LPANKDMAOHE
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct OMShapeContainerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public PJNEHJJPJFE<OMShapeContainerData_v1> component_42;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public KLJBJIDFHJE<OMShapeContainerData> component_43;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7ADB530", Offset = "0x7AD9D30", VA = "0x187ADB530")]
			private void EGDFHKOBBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x7ADB820", Offset = "0x7ADA020", VA = "0x187ADB820", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static readonly LLPKKNNAIAE log;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override LLPKKNNAIAE Log
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7ADB4E0", Offset = "0x7AD9CE0", VA = "0x187ADB4E0", Slot = "14")]
			get
			{
				return default(LLPKKNNAIAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7ADB240", Offset = "0x7AD9A40", VA = "0x187ADB240", Slot = "15")]
		protected override void COLBOKBEFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7ADB3B0", Offset = "0x7AD9BB0", VA = "0x187ADB3B0")]
		private JobHandle DMNNEKKIALP(PJNEHJJPJFE<OMShapeContainerData_v1> component_42, KLJBJIDFHJE<OMShapeContainerData> component_43, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x299DFD0", Offset = "0x299C7D0", VA = "0x18299DFD0")]
		public OMShapeContainerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public class AuthoredAIIdDataUpgradeSystem : LPANKDMAOHE
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct AuthoredAIIdDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public PJNEHJJPJFE<AuthoredAIIdData_v1> component_51;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public PJNEHJJPJFE<AuthoredAIIdData_v2> component_52;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public PJNEHJJPJFE<AuthoredAIIdData_v3> component_53;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public KLJBJIDFHJE<AuthoredAIIdData> component_54;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7AD9E90", Offset = "0x7AD8690", VA = "0x187AD9E90")]
			private void EGDFHKOBBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7ADA5B0", Offset = "0x7AD8DB0", VA = "0x187ADA5B0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private static readonly LLPKKNNAIAE log;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override LLPKKNNAIAE Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7AD9E40", Offset = "0x7AD8640", VA = "0x187AD9E40", Slot = "14")]
			get
			{
				return default(LLPKKNNAIAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7AD9BE0", Offset = "0x7AD83E0", VA = "0x187AD9BE0", Slot = "15")]
		protected override void COLBOKBEFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7AD9A40", Offset = "0x7AD8240", VA = "0x187AD9A40")]
		private JobHandle ANKAKILANCK(PJNEHJJPJFE<AuthoredAIIdData_v1> component_51, PJNEHJJPJFE<AuthoredAIIdData_v2> component_52, PJNEHJJPJFE<AuthoredAIIdData_v3> component_53, KLJBJIDFHJE<AuthoredAIIdData> component_54, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x299DFD0", Offset = "0x299C7D0", VA = "0x18299DFD0")]
		public AuthoredAIIdDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public class PhysicsModelCollisionLayerDataUpgradeSystem : LPANKDMAOHE
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionLayerDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public PJNEHJJPJFE<ContainerCollisionLayerData_v1> component_63;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public KLJBJIDFHJE<PhysicsModelCollisionLayerData> component_64;

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7ADD6D0", Offset = "0x7ADBED0", VA = "0x187ADD6D0")]
			private void EGDFHKOBBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7ADD9C0", Offset = "0x7ADC1C0", VA = "0x187ADD9C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly LLPKKNNAIAE log;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected override LLPKKNNAIAE Log
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7ADD550", Offset = "0x7ADBD50", VA = "0x187ADD550", Slot = "14")]
			get
			{
				return default(LLPKKNNAIAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7ADD3E0", Offset = "0x7ADBBE0", VA = "0x187ADD3E0", Slot = "15")]
		protected override void COLBOKBEFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7ADD5A0", Offset = "0x7ADBDA0", VA = "0x187ADD5A0")]
		private JobHandle LCFBPPPGGNF(PJNEHJJPJFE<ContainerCollisionLayerData_v1> component_63, KLJBJIDFHJE<PhysicsModelCollisionLayerData> component_64, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x299DFD0", Offset = "0x299C7D0", VA = "0x18299DFD0")]
		public PhysicsModelCollisionLayerDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	public class PhysicsModelGrabbableModeDataUpgradeSystem : LPANKDMAOHE
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		[NoAlias]
		private struct PhysicsModelGrabbableModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public PJNEHJJPJFE<ContainerGrabbableModeData_v1> component_67;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public KLJBJIDFHJE<PhysicsModelGrabbableModeData> component_68;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7ADEED0", Offset = "0x7ADD6D0", VA = "0x187ADEED0")]
			private void EGDFHKOBBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7ADF1C0", Offset = "0x7ADD9C0", VA = "0x187ADF1C0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private static readonly LLPKKNNAIAE log;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override LLPKKNNAIAE Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7ADEE80", Offset = "0x7ADD680", VA = "0x187ADEE80", Slot = "14")]
			get
			{
				return default(LLPKKNNAIAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7ADEBE0", Offset = "0x7ADD3E0", VA = "0x187ADEBE0", Slot = "15")]
		protected override void COLBOKBEFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7ADED50", Offset = "0x7ADD550", VA = "0x187ADED50")]
		private JobHandle FGIGBOAJAEA(PJNEHJJPJFE<ContainerGrabbableModeData_v1> component_67, KLJBJIDFHJE<PhysicsModelGrabbableModeData> component_68, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x299DFD0", Offset = "0x299C7D0", VA = "0x18299DFD0")]
		public PhysicsModelGrabbableModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public class PhysicsModelFlagsDataUpgradeSystem : LPANKDMAOHE
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelFlagsDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public PJNEHJJPJFE<ContainerFlagsData_v1> component_75;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public PJNEHJJPJFE<ContainerFlagsData_v2> component_76;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public PJNEHJJPJFE<PhysicsModelFlagsData_v3> component_77;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public KLJBJIDFHJE<PhysicsModelFlagsData> component_78;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7ADE310", Offset = "0x7ADCB10", VA = "0x187ADE310")]
			private void EGDFHKOBBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7ADE9E0", Offset = "0x7ADD1E0", VA = "0x187ADE9E0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly LLPKKNNAIAE log;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override LLPKKNNAIAE Log
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7ADE2C0", Offset = "0x7ADCAC0", VA = "0x187ADE2C0", Slot = "14")]
			get
			{
				return default(LLPKKNNAIAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7ADE060", Offset = "0x7ADC860", VA = "0x187ADE060", Slot = "15")]
		protected override void COLBOKBEFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7ADE9F0", Offset = "0x7ADD1F0", VA = "0x187ADE9F0")]
		private JobHandle NBPICMELEJA(PJNEHJJPJFE<ContainerFlagsData_v1> component_75, PJNEHJJPJFE<ContainerFlagsData_v2> component_76, PJNEHJJPJFE<PhysicsModelFlagsData_v3> component_77, KLJBJIDFHJE<PhysicsModelFlagsData> component_78, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x299DFD0", Offset = "0x299C7D0", VA = "0x18299DFD0")]
		public PhysicsModelFlagsDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public class PhysicsModelCollisionModeDataUpgradeSystem : LPANKDMAOHE
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct PhysicsModelCollisionModeDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public PJNEHJJPJFE<ContainerCollisionModeData_v1> component_79;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public KLJBJIDFHJE<PhysicsModelCollisionModeData> component_80;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x7ADDD10", Offset = "0x7ADC510", VA = "0x187ADDD10")]
			private void EGDFHKOBBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7ADE000", Offset = "0x7ADC800", VA = "0x187ADE000", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly LLPKKNNAIAE log;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override LLPKKNNAIAE Log
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7ADDCC0", Offset = "0x7ADC4C0", VA = "0x187ADDCC0", Slot = "14")]
			get
			{
				return default(LLPKKNNAIAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7ADDA20", Offset = "0x7ADC220", VA = "0x187ADDA20", Slot = "15")]
		protected override void COLBOKBEFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7ADDB90", Offset = "0x7ADC390", VA = "0x187ADDB90")]
		private JobHandle FCFKNOGBNEE(PJNEHJJPJFE<ContainerCollisionModeData_v1> component_79, KLJBJIDFHJE<PhysicsModelCollisionModeData> component_80, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x299DFD0", Offset = "0x299C7D0", VA = "0x18299DFD0")]
		public PhysicsModelCollisionModeDataUpgradeSystem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	public class ObjectPolicyDataUpgradeSystem : LPANKDMAOHE
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[NoAlias]
		[BurstCompile(FloatMode = FloatMode.Default, FloatPrecision = FloatPrecision.Standard, CompileSynchronously = false)]
		private struct ObjectPolicyDataUpgradeSystem_LambdaJob_0_Job : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public PJNEHJJPJFE<ObjectPolicyData_v1> component_83;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public PJNEHJJPJFE<ObjectPolicyData_v2> component_84;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public PJNEHJJPJFE<ObjectPolicyData_v3> component_85;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public PJNEHJJPJFE<ObjectPolicyData_v4> component_86;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public PJNEHJJPJFE<ObjectPolicyData_v5> component_87;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public KLJBJIDFHJE<ObjectPolicyData> component_88;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7ADBDE0", Offset = "0x7ADA5E0", VA = "0x187ADBDE0")]
			private void EGDFHKOBBEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x7ADCBD0", Offset = "0x7ADB3D0", VA = "0x187ADCBD0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly LLPKKNNAIAE log;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override LLPKKNNAIAE Log
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x7ADBD90", Offset = "0x7ADA590", VA = "0x187ADBD90", Slot = "14")]
			get
			{
				return default(LLPKKNNAIAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7ADBA80", Offset = "0x7ADA280", VA = "0x187ADBA80", Slot = "15")]
		protected override void COLBOKBEFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7ADB880", Offset = "0x7ADA080", VA = "0x187ADB880")]
		private JobHandle ACFBIDNOJMF(PJNEHJJPJFE<ObjectPolicyData_v1> component_83, PJNEHJJPJFE<ObjectPolicyData_v2> component_84, PJNEHJJPJFE<ObjectPolicyData_v3> component_85, PJNEHJJPJFE<ObjectPolicyData_v4> component_86, PJNEHJJPJFE<ObjectPolicyData_v5> component_87, KLJBJIDFHJE<ObjectPolicyData> component_88, JobHandle __inputDependency)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790", Slot = "4")]
		protected override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x299DFD0", Offset = "0x299C7D0", VA = "0x18299DFD0")]
		public ObjectPolicyDataUpgradeSystem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal static class EPECKJCJECO
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x360E2F0", Offset = "0x360CAF0", VA = "0x18360E2F0")]
	public static void KAAAPDPAKBN<T, U>(T ACFACIOKNNI, [Out] U DGJLLLECKHO) where T : struct where U : struct
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
