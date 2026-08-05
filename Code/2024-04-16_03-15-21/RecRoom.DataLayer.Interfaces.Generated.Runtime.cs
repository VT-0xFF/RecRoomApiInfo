using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer.Attributes;
using RecRoom.Foundation;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEA50", Offset = "0x7DDC50", VA = "0x1807DEA50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_DataLayer_Interfaces_Generated_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Preserve]
	public class _AssemblyIndex : BHGNIPDAAHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private PLDKANGDDDP bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B4130", Offset = "0x7B3330", VA = "0x1807B4130", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x13511C0", Offset = "0x13503C0", VA = "0x1813511C0", Slot = "5")]
		public override void NFPDFNDEAED(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x60F5150", Offset = "0x60F4350", VA = "0x1860F5150")]
		private void LFIGPBIMHMM(NFPJJEAKHFP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x60F53D0", Offset = "0x60F45D0", VA = "0x1860F53D0", Slot = "6")]
		public override void PLBJNCNNDBL(NFPJJEAKHFP registry, [In] MFEOBGFJEOO filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B3620", Offset = "0x7B2820", VA = "0x1807B3620", Slot = "8")]
		public override void AKMCFODBHPA(AJJICLPDKOG registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x60F5430", Offset = "0x60F4630", VA = "0x1860F5430")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	public readonly struct OverrideObjectNetworkIdDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly OverrideObjectNetworkIdDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x60EF230", Offset = "0x60EE430", VA = "0x1860EF230", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal OverrideObjectNetworkIdDataWrapper(Entity entity, OverrideObjectNetworkIdDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Preserve]
	[CompilerGenerated]
	public class OverrideObjectNetworkIdDataProperties : LBADIJNLAOO<OverrideObjectNetworkIdDataWrapper, OverrideObjectNetworkIdData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly NKDILCMHFJA<uint> networkIdBits;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x60E6D00", Offset = "0x60E5F00", VA = "0x1860E6D00")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly MKKKMENBGOL<uint> networkIdBits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x60EF0E0", Offset = "0x60EE2E0", VA = "0x1860EF0E0")]
		public OverrideObjectNetworkIdDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override OverrideObjectNetworkIdDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(OverrideObjectNetworkIdDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public readonly struct PersistentUserTagDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly PersistentUserTagDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool initalizedDefaults
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x60EF740", Offset = "0x60EE940", VA = "0x1860EF740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60EF6A0", Offset = "0x60EE8A0", VA = "0x1860EF6A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal PersistentUserTagDataWrapper(Entity entity, PersistentUserTagDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x60EF800", Offset = "0x60EEA00", VA = "0x1860EF800")]
		public bool NNAJDAAOEIA(FixedList32Bytes<int> value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x60EF7A0", Offset = "0x60EE9A0", VA = "0x1860EF7A0")]
		public bool LDDPBEKCDBC(bool value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[Preserve]
	public class PersistentUserTagDataProperties : LBADIJNLAOO<PersistentUserTagDataWrapper, PersistentUserTagData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly NKDILCMHFJA<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly NKDILCMHFJA<bool> initalizedDefaults;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x60E6E80", Offset = "0x60E6080", VA = "0x1860E6E80")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly MKKKMENBGOL<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly MKKKMENBGOL<bool> initalizedDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x60EF4C0", Offset = "0x60EE6C0", VA = "0x1860EF4C0")]
		public PersistentUserTagDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override PersistentUserTagDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(PersistentUserTagDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	[global::COJDIMJIKPE]
	[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
	public struct PersistentUserTagData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::JEJFDDMFHFN(1)]
		public FixedList32Bytes<int> tags;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public readonly struct LocalDeformableScaleDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LocalDeformableScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60E6600", Offset = "0x60E5800", VA = "0x1860E6600", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal LocalDeformableScaleDataWrapper(Entity entity, LocalDeformableScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[Preserve]
	[CompilerGenerated]
	public class LocalDeformableScaleDataProperties : LBADIJNLAOO<LocalDeformableScaleDataWrapper, LocalDeformableScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly NKDILCMHFJA<float3> localDeformationScale;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x60E8360", Offset = "0x60E7560", VA = "0x1860E8360")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly MKKKMENBGOL<float3> localDeformationScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x60E64B0", Offset = "0x60E56B0", VA = "0x1860E64B0")]
		public LocalDeformableScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override LocalDeformableScaleDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(LocalDeformableScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
	[global::COJDIMJIKPE]
	public struct LocalDeformableScaleData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[global::JEJFDDMFHFN(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public readonly struct SplinePointScaleDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly SplinePointScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x60F2E70", Offset = "0x60F2070", VA = "0x1860F2E70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal SplinePointScaleDataWrapper(Entity entity, SplinePointScaleDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x60F2F10", Offset = "0x60F2110", VA = "0x1860F2F10")]
		public float3 LKLLOPEMHML()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x60F2F90", Offset = "0x60F2190", VA = "0x1860F2F90")]
		public bool NPAOLFCNDDE(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointScaleDataProperties : LBADIJNLAOO<SplinePointScaleDataWrapper, SplinePointScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly NKDILCMHFJA<float3> localScale;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x60E78F0", Offset = "0x60E6AF0", VA = "0x1860E78F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly MKKKMENBGOL<float3> localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x60F2D20", Offset = "0x60F1F20", VA = "0x1860F2D20")]
		public SplinePointScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override SplinePointScaleDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(SplinePointScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	public readonly struct LocalUniformScaleDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly LocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x60E6A70", Offset = "0x60E5C70", VA = "0x1860E6A70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal LocalUniformScaleDataWrapper(Entity entity, LocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	[Preserve]
	public class LocalUniformScaleDataProperties : LBADIJNLAOO<LocalUniformScaleDataWrapper, LocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly NKDILCMHFJA<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x60E7970", Offset = "0x60E6B70", VA = "0x1860E7970")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly MKKKMENBGOL<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x60E6920", Offset = "0x60E5B20", VA = "0x1860E6920")]
		public LocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override LocalUniformScaleDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(LocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public readonly struct InteractionFilterDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly InteractionFilterDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FixedList32Bytes<int> tags
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x60E6280", Offset = "0x60E5480", VA = "0x1860E6280")]
			get
			{
				return default(FixedList32Bytes<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x60E61E0", Offset = "0x60E53E0", VA = "0x1860E61E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal InteractionFilterDataWrapper(Entity entity, InteractionFilterDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x60E6430", Offset = "0x60E5630", VA = "0x1860E6430")]
		public FixedList32Bytes<int> OIABKDKPNHC()
		{
			return default(FixedList32Bytes<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x60E63C0", Offset = "0x60E55C0", VA = "0x1860E63C0")]
		public bool NNAJDAAOEIA(FixedList32Bytes<int> value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x60E6300", Offset = "0x60E5500", VA = "0x1860E6300")]
		public bool HGJJCOOIOGI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x60E6180", Offset = "0x60E5380", VA = "0x1860E6180")]
		public bool CDDBOENJANG(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x60E6120", Offset = "0x60E5320", VA = "0x1860E6120")]
		public OIGBGKEBEFC BGLPIHLAJLP()
		{
			return default(OIGBGKEBEFC);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x60E6360", Offset = "0x60E5560", VA = "0x1860E6360")]
		public bool LACACLLJELI(OIGBGKEBEFC value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterDataProperties : LBADIJNLAOO<InteractionFilterDataWrapper, InteractionFilterData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly NKDILCMHFJA<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly NKDILCMHFJA<bool> enabled;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly NKDILCMHFJA<OIGBGKEBEFC> filterMode;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x60E6FC0", Offset = "0x60E61C0", VA = "0x1860E6FC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly MKKKMENBGOL<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly MKKKMENBGOL<bool> enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly MKKKMENBGOL<OIGBGKEBEFC> filterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7BF640", Offset = "0x7BE840", VA = "0x1807BF640", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x60E5EC0", Offset = "0x60E50C0", VA = "0x1860E5EC0")]
		public InteractionFilterDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override InteractionFilterDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(InteractionFilterDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	public readonly struct ComponentSerializedVersionDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly ComponentSerializedVersionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x60D8C90", Offset = "0x60D7E90", VA = "0x1860D8C90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal ComponentSerializedVersionDataWrapper(Entity entity, ComponentSerializedVersionDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	[Preserve]
	public class ComponentSerializedVersionDataProperties : LBADIJNLAOO<ComponentSerializedVersionDataWrapper, ComponentSerializedVersionData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly NKDILCMHFJA<JLKOOCLJAGB> version;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x60E6C80", Offset = "0x60E5E80", VA = "0x1860E6C80")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public readonly MKKKMENBGOL<JLKOOCLJAGB> version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x60D8B40", Offset = "0x60D7D40", VA = "0x1860D8B40")]
		public ComponentSerializedVersionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override ComponentSerializedVersionDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(ComponentSerializedVersionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public readonly struct ToolCleanupSettingsDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly ToolCleanupSettingsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x60F3E30", Offset = "0x60F3030", VA = "0x1860F3E30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal ToolCleanupSettingsDataWrapper(Entity entity, ToolCleanupSettingsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x60F3ED0", Offset = "0x60F30D0", VA = "0x1860F3ED0")]
		public float LDNAHADPEFK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x60F3D20", Offset = "0x60F2F20", VA = "0x1860F3D20")]
		public bool AONNEMKDEPN(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x60F3F30", Offset = "0x60F3130", VA = "0x1860F3F30")]
		public MGJBAFEDDNK PAINIPBKKEI()
		{
			return default(MGJBAFEDDNK);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x60F3D80", Offset = "0x60F2F80", VA = "0x1860F3D80")]
		public void BINNEDNKEMB(MGJBAFEDDNK flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	[Preserve]
	public class ToolCleanupSettingsDataProperties : LBADIJNLAOO<ToolCleanupSettingsDataWrapper, ToolCleanupSettingsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly NKDILCMHFJA<float> delay;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly NKDILCMHFJA<MGJBAFEDDNK> toolCleanupFlags;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x60E6BC0", Offset = "0x60E5DC0", VA = "0x1860E6BC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly MKKKMENBGOL<float> delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly MKKKMENBGOL<MGJBAFEDDNK> toolCleanupFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x60F3B40", Offset = "0x60F2D40", VA = "0x1860F3B40")]
		public ToolCleanupSettingsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override ToolCleanupSettingsDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	public readonly struct SplinePointOrderDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly SplinePointOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x60F23F0", Offset = "0x60F15F0", VA = "0x1860F23F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal SplinePointOrderDataWrapper(Entity entity, SplinePointOrderDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x60F2490", Offset = "0x60F1690", VA = "0x1860F2490")]
		public bool JDFELCMMMFC(DHOGHBGBODA value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointOrderDataProperties : LBADIJNLAOO<SplinePointOrderDataWrapper, SplinePointOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly NKDILCMHFJA<DHOGHBGBODA> order;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x60E8460", Offset = "0x60E7660", VA = "0x1860E8460")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly MKKKMENBGOL<DHOGHBGBODA> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x60F22A0", Offset = "0x60F14A0", VA = "0x1860F22A0")]
		public SplinePointOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override SplinePointOrderDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(SplinePointOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public readonly struct CostumePieceSlotIndexDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly CostumePieceSlotIndexDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x60E5BA0", Offset = "0x60E4DA0", VA = "0x1860E5BA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal CostumePieceSlotIndexDataWrapper(Entity entity, CostumePieceSlotIndexDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[Preserve]
	[CompilerGenerated]
	public class CostumePieceSlotIndexDataProperties : LBADIJNLAOO<CostumePieceSlotIndexDataWrapper, CostumePieceSlotIndexData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly NKDILCMHFJA<int> slotIndex;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x60E7340", Offset = "0x60E6540", VA = "0x1860E7340")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly MKKKMENBGOL<int> slotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x60E5A50", Offset = "0x60E4C50", VA = "0x1860E5A50")]
		public CostumePieceSlotIndexDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override CostumePieceSlotIndexDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(CostumePieceSlotIndexDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	public readonly struct SerializedEmbodiedDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly SerializedEmbodiedDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x60F1B10", Offset = "0x60F0D10", VA = "0x1860F1B10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal SerializedEmbodiedDataWrapper(Entity entity, SerializedEmbodiedDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	[Preserve]
	public class SerializedEmbodiedDataProperties : LBADIJNLAOO<SerializedEmbodiedDataWrapper, SerializedEmbodiedData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Names
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7B4130", Offset = "0x7B3330", VA = "0x1807B4130", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x60F1A80", Offset = "0x60F0C80", VA = "0x1860F1A80")]
		public SerializedEmbodiedDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override SerializedEmbodiedDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(SerializedEmbodiedDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	public readonly struct LocalPoseDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly LocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x60E6880", Offset = "0x60E5A80", VA = "0x1860E6880", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal LocalPoseDataWrapper(Entity entity, LocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[Preserve]
	[CompilerGenerated]
	public class LocalPoseDataProperties : LBADIJNLAOO<LocalPoseDataWrapper, LocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public static readonly NKDILCMHFJA<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public static readonly NKDILCMHFJA<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x60E7B30", Offset = "0x60E6D30", VA = "0x1860E7B30")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly MKKKMENBGOL<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly MKKKMENBGOL<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x60E66A0", Offset = "0x60E58A0", VA = "0x1860E66A0")]
		public LocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override LocalPoseDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(LocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectActiveStatusDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly ReplicatedObjectActiveStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x60F1410", Offset = "0x60F0610", VA = "0x1860F1410", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal ReplicatedObjectActiveStatusDataWrapper(Entity entity, ReplicatedObjectActiveStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatedObjectActiveStatusDataProperties : LBADIJNLAOO<ReplicatedObjectActiveStatusDataWrapper, ReplicatedObjectActiveStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public static readonly NKDILCMHFJA<bool> active;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x60E7D30", Offset = "0x60E6F30", VA = "0x1860E7D30")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly MKKKMENBGOL<bool> active;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x60F12C0", Offset = "0x60F04C0", VA = "0x1860F12C0")]
		public ReplicatedObjectActiveStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override ReplicatedObjectActiveStatusDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(ReplicatedObjectActiveStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	public readonly struct SplinePointRotationDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly SplinePointRotationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x60F2C10", Offset = "0x60F1E10", VA = "0x1860F2C10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal SplinePointRotationDataWrapper(Entity entity, SplinePointRotationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x60F2CB0", Offset = "0x60F1EB0", VA = "0x1860F2CB0")]
		public quaternion KIPLBDKCGFG()
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x60F2BA0", Offset = "0x60F1DA0", VA = "0x1860F2BA0")]
		public bool AKLPLPACOFJ(quaternion value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointRotationDataProperties : LBADIJNLAOO<SplinePointRotationDataWrapper, SplinePointRotationData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly NKDILCMHFJA<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x60E71C0", Offset = "0x60E63C0", VA = "0x1860E71C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly MKKKMENBGOL<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x60F2A50", Offset = "0x60F1C50", VA = "0x1860F2A50")]
		public SplinePointRotationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override SplinePointRotationDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(SplinePointRotationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	public readonly struct ToolCleanupStatusDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly ToolCleanupStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x60F41F0", Offset = "0x60F33F0", VA = "0x1860F41F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal ToolCleanupStatusDataWrapper(Entity entity, ToolCleanupStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Preserve]
	[CompilerGenerated]
	public class ToolCleanupStatusDataProperties : LBADIJNLAOO<ToolCleanupStatusDataWrapper, ToolCleanupStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly NKDILCMHFJA<float> cleanupStartTime;

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly NKDILCMHFJA<bool> forceCleanup;

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly NKDILCMHFJA<bool> cleanupDone;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x60E7540", Offset = "0x60E6740", VA = "0x1860E7540")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly MKKKMENBGOL<float> cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly MKKKMENBGOL<bool> forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly MKKKMENBGOL<bool> cleanupDone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7BF640", Offset = "0x7BE840", VA = "0x1807BF640", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x60F3F90", Offset = "0x60F3190", VA = "0x1860F3F90")]
		public ToolCleanupStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override ToolCleanupStatusDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(ToolCleanupStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	public readonly struct SplinePointPositionDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly SplinePointPositionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x60F28C0", Offset = "0x60F1AC0", VA = "0x1860F28C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal SplinePointPositionDataWrapper(Entity entity, SplinePointPositionDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x60F2960", Offset = "0x60F1B60", VA = "0x1860F2960")]
		public float3 IKIIHLDMHBM()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x60F29E0", Offset = "0x60F1BE0", VA = "0x1860F29E0")]
		public bool OJMCEBCCLFG(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointPositionDataProperties : LBADIJNLAOO<SplinePointPositionDataWrapper, SplinePointPositionData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly NKDILCMHFJA<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x60E6D80", Offset = "0x60E5F80", VA = "0x1860E6D80")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly MKKKMENBGOL<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x60F2770", Offset = "0x60F1970", VA = "0x1860F2770")]
		public SplinePointPositionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override SplinePointPositionDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(SplinePointPositionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	public readonly struct ShapeTypeDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly ShapeTypeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public AOPPGPEDKLO shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x60F1FB0", Offset = "0x60F11B0", VA = "0x1860F1FB0")]
			get
			{
				return default(AOPPGPEDKLO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x60F2010", Offset = "0x60F1210", VA = "0x1860F2010", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal ShapeTypeDataWrapper(Entity entity, ShapeTypeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[Preserve]
	[CompilerGenerated]
	public class ShapeTypeDataProperties : LBADIJNLAOO<ShapeTypeDataWrapper, ShapeTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public static readonly NKDILCMHFJA<AOPPGPEDKLO> shapeType;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x60E76B0", Offset = "0x60E68B0", VA = "0x1860E76B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public readonly MKKKMENBGOL<AOPPGPEDKLO> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x60F1E60", Offset = "0x60F1060", VA = "0x1860F1E60")]
		public ShapeTypeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override ShapeTypeDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(ShapeTypeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	public readonly struct PrimitiveShapeDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly PrimitiveShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public DBGCOLPIMDG shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x60EFE00", Offset = "0x60EF000", VA = "0x1860EFE00")]
			get
			{
				return default(DBGCOLPIMDG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x60EFE60", Offset = "0x60EF060", VA = "0x1860EFE60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal PrimitiveShapeDataWrapper(Entity entity, PrimitiveShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x60EFF00", Offset = "0x60EF100", VA = "0x1860EFF00")]
		public DBGCOLPIMDG PNNMBPLJJDK()
		{
			return default(DBGCOLPIMDG);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	[Preserve]
	public class PrimitiveShapeDataProperties : LBADIJNLAOO<PrimitiveShapeDataWrapper, PrimitiveShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly NKDILCMHFJA<DBGCOLPIMDG> shapeType;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x60E7870", Offset = "0x60E6A70", VA = "0x1860E7870")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly MKKKMENBGOL<DBGCOLPIMDG> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x60EFCB0", Offset = "0x60EEEB0", VA = "0x1860EFCB0")]
		public PrimitiveShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override PrimitiveShapeDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	public readonly struct ReplicatorDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly ReplicatorDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x60F17F0", Offset = "0x60F09F0", VA = "0x1860F17F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal ReplicatorDataWrapper(Entity entity, ReplicatorDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatorDataProperties : LBADIJNLAOO<ReplicatorDataWrapper, ReplicatorData>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly NKDILCMHFJA<Entity> Target;

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x60E81A0", Offset = "0x60E73A0", VA = "0x1860E81A0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly MKKKMENBGOL<Entity> Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x60F16A0", Offset = "0x60F08A0", VA = "0x1860F16A0")]
		public ReplicatorDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override ReplicatorDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(ReplicatorDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	public readonly struct PlayerScopeDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly PlayerScopeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x60EFC10", Offset = "0x60EEE10", VA = "0x1860EFC10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal PlayerScopeDataWrapper(Entity entity, PlayerScopeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[Preserve]
	[CompilerGenerated]
	public class PlayerScopeDataProperties : LBADIJNLAOO<PlayerScopeDataWrapper, PlayerScopeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public static readonly NKDILCMHFJA<Entity> playerScope;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x60E7140", Offset = "0x60E6340", VA = "0x1860E7140")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly MKKKMENBGOL<Entity> playerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x60EFAC0", Offset = "0x60EECC0", VA = "0x1860EFAC0")]
		public PlayerScopeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override PlayerScopeDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(PlayerScopeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	public readonly struct EntityBundlePartDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly EntityBundlePartDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x60E5E20", Offset = "0x60E5020", VA = "0x1860E5E20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal EntityBundlePartDataWrapper(Entity entity, EntityBundlePartDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[Preserve]
	[CompilerGenerated]
	public class EntityBundlePartDataProperties : LBADIJNLAOO<EntityBundlePartDataWrapper, EntityBundlePartData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public static readonly NKDILCMHFJA<Entity> prefabRoot;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public static readonly NKDILCMHFJA<uint> entityBundlePartId;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x60E7BF0", Offset = "0x60E6DF0", VA = "0x1860E7BF0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly MKKKMENBGOL<Entity> prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly MKKKMENBGOL<uint> entityBundlePartId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x60E5C40", Offset = "0x60E4E40", VA = "0x1860E5C40")]
		public EntityBundlePartDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override EntityBundlePartDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(EntityBundlePartDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectOwnedByPlayerDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly ReplicatedObjectOwnedByPlayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x60F1600", Offset = "0x60F0800", VA = "0x1860F1600", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal ReplicatedObjectOwnedByPlayerDataWrapper(Entity entity, ReplicatedObjectOwnedByPlayerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatedObjectOwnedByPlayerDataProperties : LBADIJNLAOO<ReplicatedObjectOwnedByPlayerDataWrapper, ReplicatedObjectOwnedByPlayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public static readonly NKDILCMHFJA<int> actorId;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x60E7FE0", Offset = "0x60E71E0", VA = "0x1860E7FE0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly MKKKMENBGOL<int> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x60F14B0", Offset = "0x60F06B0", VA = "0x1860F14B0")]
		public ReplicatedObjectOwnedByPlayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override ReplicatedObjectOwnedByPlayerDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(ReplicatedObjectOwnedByPlayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	public readonly struct OMShapeContainerDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly OMShapeContainerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x60EE730", Offset = "0x60ED930", VA = "0x1860EE730", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal OMShapeContainerDataWrapper(Entity entity, OMShapeContainerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	[Preserve]
	public class OMShapeContainerDataProperties : LBADIJNLAOO<OMShapeContainerDataWrapper, OMShapeContainerData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public static readonly NKDILCMHFJA<bool> canModifyWithCircuits;

			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public static readonly NKDILCMHFJA<bool> optimizedCollidersEnabled;

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x60E6B10", Offset = "0x60E5D10", VA = "0x1860E6B10")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly MKKKMENBGOL<bool> canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly MKKKMENBGOL<bool> optimizedCollidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x60EE560", Offset = "0x60ED760", VA = "0x1860EE560")]
		public OMShapeContainerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override OMShapeContainerDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(OMShapeContainerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	[CompilerGenerated]
	[global::COJDIMJIKPE]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[global::JEJFDDMFHFN(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[global::JEJFDDMFHFN(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[global::JEJFDDMFHFN(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	public readonly struct AuthoredParentDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly AuthoredParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x60D8AA0", Offset = "0x60D7CA0", VA = "0x1860D8AA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal AuthoredParentDataWrapper(Entity entity, AuthoredParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredParentDataProperties : LBADIJNLAOO<AuthoredParentDataWrapper, AuthoredParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public static readonly NKDILCMHFJA<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x60E7E30", Offset = "0x60E7030", VA = "0x1860E7E30")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public readonly MKKKMENBGOL<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x60D8950", Offset = "0x60D7B50", VA = "0x1860D8950")]
		public AuthoredParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override AuthoredParentDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(AuthoredParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	public readonly struct NavMeshGenerationDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly NavMeshGenerationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x60E8710", Offset = "0x60E7910", VA = "0x1860E8710", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal NavMeshGenerationDataWrapper(Entity entity, NavMeshGenerationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x60E86B0", Offset = "0x60E78B0", VA = "0x1860E86B0")]
		public CCEAMCMKGBM APMHFIIMHFA()
		{
			return default(CCEAMCMKGBM);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x60E87B0", Offset = "0x60E79B0", VA = "0x1860E87B0")]
		public bool NHBNIAOJOGD(CCEAMCMKGBM value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[Preserve]
	[CompilerGenerated]
	public class NavMeshGenerationDataProperties : LBADIJNLAOO<NavMeshGenerationDataWrapper, NavMeshGenerationData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public static readonly NKDILCMHFJA<CCEAMCMKGBM> mode;

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x60E7AB0", Offset = "0x60E6CB0", VA = "0x1860E7AB0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly MKKKMENBGOL<CCEAMCMKGBM> mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x60E8560", Offset = "0x60E7760", VA = "0x1860E8560")]
		public NavMeshGenerationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override NavMeshGenerationDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	public readonly struct ContainerNameDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly ContainerNameDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x60E5750", Offset = "0x60E4950", VA = "0x1860E5750", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal ContainerNameDataWrapper(Entity entity, ContainerNameDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x60E56C0", Offset = "0x60E48C0", VA = "0x1860E56C0")]
		public FixedString64Bytes EFGBMFABOJN()
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x60E57F0", Offset = "0x60E49F0", VA = "0x1860E57F0")]
		public bool IJEAENNDAAC(FixedString64Bytes value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerNameDataProperties : LBADIJNLAOO<ContainerNameDataWrapper, ContainerNameData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public static readonly NKDILCMHFJA<FixedString64Bytes> name;

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x60E7EB0", Offset = "0x60E70B0", VA = "0x1860E7EB0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly MKKKMENBGOL<FixedString64Bytes> name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x60E5570", Offset = "0x60E4770", VA = "0x1860E5570")]
		public ContainerNameDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override ContainerNameDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(ContainerNameDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	public readonly struct ShapeConfigDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly ShapeConfigDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x60F1D60", Offset = "0x60F0F60", VA = "0x1860F1D60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal ShapeConfigDataWrapper(Entity entity, ShapeConfigDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x60F1E00", Offset = "0x60F1000", VA = "0x1860F1E00")]
		public GFPBOGIPHND NEGHIFMCEAF()
		{
			return default(GFPBOGIPHND);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x60F1D00", Offset = "0x60F0F00", VA = "0x1860F1D00")]
		public bool BIJICAANIBA(GFPBOGIPHND value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	[Preserve]
	public class ShapeConfigDataProperties : LBADIJNLAOO<ShapeConfigDataWrapper, ShapeConfigData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly NKDILCMHFJA<GFPBOGIPHND> flags;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x60E84E0", Offset = "0x60E76E0", VA = "0x1860E84E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public readonly MKKKMENBGOL<GFPBOGIPHND> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x60F1BB0", Offset = "0x60F0DB0", VA = "0x1860F1BB0")]
		public ShapeConfigDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override ShapeConfigDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(ShapeConfigDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	public readonly struct ParentDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly ParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x60EF420", Offset = "0x60EE620", VA = "0x1860EF420", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal ParentDataWrapper(Entity entity, ParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[Preserve]
	[CompilerGenerated]
	public class ParentDataProperties : LBADIJNLAOO<ParentDataWrapper, ParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public static readonly NKDILCMHFJA<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x60E7DB0", Offset = "0x60E6FB0", VA = "0x1860E7DB0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly MKKKMENBGOL<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x60EF2D0", Offset = "0x60EE4D0", VA = "0x1860EF2D0")]
		public ParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override ParentDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(ParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	public readonly struct ReplicatorMaxObjectCountDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly ReplicatorMaxObjectCountDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x60F19E0", Offset = "0x60F0BE0", VA = "0x1860F19E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal ReplicatorMaxObjectCountDataWrapper(Entity entity, ReplicatorMaxObjectCountDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatorMaxObjectCountDataProperties : LBADIJNLAOO<ReplicatorMaxObjectCountDataWrapper, ReplicatorMaxObjectCountData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public static readonly NKDILCMHFJA<int> MaxCopies;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x60E7630", Offset = "0x60E6830", VA = "0x1860E7630")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public readonly MKKKMENBGOL<int> MaxCopies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x60F1890", Offset = "0x60F0A90", VA = "0x1860F1890")]
		public ReplicatorMaxObjectCountDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override ReplicatorMaxObjectCountDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(ReplicatorMaxObjectCountDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	public readonly struct ContainerMassOverrideDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly ContainerMassOverrideDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x60E5410", Offset = "0x60E4610", VA = "0x1860E5410", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal ContainerMassOverrideDataWrapper(Entity entity, ContainerMassOverrideDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x60E54B0", Offset = "0x60E46B0", VA = "0x1860E54B0")]
		public float FPMIFLLLHLC()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x60E5510", Offset = "0x60E4710", VA = "0x1860E5510")]
		public bool KFIOBLCAOMI(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerMassOverrideDataProperties : LBADIJNLAOO<ContainerMassOverrideDataWrapper, ContainerMassOverrideData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public static readonly NKDILCMHFJA<float> mass;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x60E77F0", Offset = "0x60E69F0", VA = "0x1860E77F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public readonly MKKKMENBGOL<float> mass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x60E52C0", Offset = "0x60E44C0", VA = "0x1860E52C0")]
		public ContainerMassOverrideDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override ContainerMassOverrideDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(ContainerMassOverrideDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalPoseDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly AuthoredLocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x60D86B0", Offset = "0x60D78B0", VA = "0x1860D86B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal AuthoredLocalPoseDataWrapper(Entity entity, AuthoredLocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[Preserve]
	[CompilerGenerated]
	public class AuthoredLocalPoseDataProperties : LBADIJNLAOO<AuthoredLocalPoseDataWrapper, AuthoredLocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public static readonly NKDILCMHFJA<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public static readonly NKDILCMHFJA<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x60E7730", Offset = "0x60E6930", VA = "0x1860E7730")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public readonly MKKKMENBGOL<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public readonly MKKKMENBGOL<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x60D84D0", Offset = "0x60D76D0", VA = "0x1860D84D0")]
		public AuthoredLocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override AuthoredLocalPoseDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(AuthoredLocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	public readonly struct ObjectBoardNodeDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly ObjectBoardNodeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x60EE9A0", Offset = "0x60EDBA0", VA = "0x1860EE9A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal ObjectBoardNodeDataWrapper(Entity entity, ObjectBoardNodeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectBoardNodeDataProperties : LBADIJNLAOO<ObjectBoardNodeDataWrapper, ObjectBoardNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly NKDILCMHFJA<NetworkGuid> nodeId;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly NKDILCMHFJA<NetworkGuid> graphId;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x60E7F30", Offset = "0x60E7130", VA = "0x1860E7F30")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly MKKKMENBGOL<NetworkGuid> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly MKKKMENBGOL<NetworkGuid> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x60EE7D0", Offset = "0x60ED9D0", VA = "0x1860EE7D0")]
		public ObjectBoardNodeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override ObjectBoardNodeDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(ObjectBoardNodeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalUniformScaleDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly AuthoredLocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x60D88B0", Offset = "0x60D7AB0", VA = "0x1860D88B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal AuthoredLocalUniformScaleDataWrapper(Entity entity, AuthoredLocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[Preserve]
	[CompilerGenerated]
	public class AuthoredLocalUniformScaleDataProperties : LBADIJNLAOO<AuthoredLocalUniformScaleDataWrapper, AuthoredLocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly NKDILCMHFJA<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x60E7CB0", Offset = "0x60E6EB0", VA = "0x1860E7CB0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public readonly MKKKMENBGOL<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x60D8760", Offset = "0x60D7960", VA = "0x1860D8760")]
		public AuthoredLocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override AuthoredLocalUniformScaleDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(AuthoredLocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	public readonly struct StandardRenderableVisualDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly StandardRenderableVisualDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public DKFFJGDMCCB color
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x60F3670", Offset = "0x60F2870", VA = "0x1860F3670")]
			get
			{
				return default(DKFFJGDMCCB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public JFLGFGJFHHM material
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x60F38E0", Offset = "0x60F2AE0", VA = "0x1860F38E0")]
			get
			{
				return default(JFLGFGJFHHM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public float uvScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x60F39C0", Offset = "0x60F2BC0", VA = "0x1860F39C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float3 uvOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x60F3940", Offset = "0x60F2B40", VA = "0x1860F3940")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x60F35D0", Offset = "0x60F27D0", VA = "0x1860F35D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal StandardRenderableVisualDataWrapper(Entity entity, StandardRenderableVisualDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x60F3A80", Offset = "0x60F2C80", VA = "0x1860F3A80")]
		public DKFFJGDMCCB PMNGOEBHKLF()
		{
			return default(DKFFJGDMCCB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x60F36D0", Offset = "0x60F28D0", VA = "0x1860F36D0")]
		public bool GCJGHDLPDMN(DKFFJGDMCCB value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x60F37A0", Offset = "0x60F29A0", VA = "0x1860F37A0")]
		public JFLGFGJFHHM LADDJFGGHMH()
		{
			return default(JFLGFGJFHHM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x60F3AE0", Offset = "0x60F2CE0", VA = "0x1860F3AE0")]
		public bool PNPAPKHPGHD(JFLGFGJFHHM value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x60F3A20", Offset = "0x60F2C20", VA = "0x1860F3A20")]
		public float ONINKBAHELO()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x60F3880", Offset = "0x60F2A80", VA = "0x1860F3880")]
		public bool LJABNBIKIIB(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x60F3800", Offset = "0x60F2A00", VA = "0x1860F3800")]
		public float3 LALKMDNHGDH()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x60F3730", Offset = "0x60F2930", VA = "0x1860F3730")]
		public bool IIBJFAFHOAO(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[Preserve]
	[CompilerGenerated]
	public class StandardRenderableVisualDataProperties : LBADIJNLAOO<StandardRenderableVisualDataWrapper, StandardRenderableVisualData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly NKDILCMHFJA<DKFFJGDMCCB> color;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly NKDILCMHFJA<JFLGFGJFHHM> material;

			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public static readonly NKDILCMHFJA<float> uvScale;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public static readonly NKDILCMHFJA<float3> uvOffset;

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x60E8220", Offset = "0x60E7420", VA = "0x1860E8220")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public readonly MKKKMENBGOL<DKFFJGDMCCB> color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public readonly MKKKMENBGOL<JFLGFGJFHHM> material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly MKKKMENBGOL<float> uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly MKKKMENBGOL<float3> uvOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7B7520", Offset = "0x7B6720", VA = "0x1807B7520", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x60F32E0", Offset = "0x60F24E0", VA = "0x1860F32E0")]
		public StandardRenderableVisualDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override StandardRenderableVisualDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionLayerDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly ContainerCollisionLayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x60E48A0", Offset = "0x60E3AA0", VA = "0x1860E48A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal ContainerCollisionLayerDataWrapper(Entity entity, ContainerCollisionLayerDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x60E49A0", Offset = "0x60E3BA0", VA = "0x1860E49A0")]
		public JLICOMJJGPO LIODJNHNLNL()
		{
			return default(JLICOMJJGPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x60E4940", Offset = "0x60E3B40", VA = "0x1860E4940")]
		public bool JPGONBGADKB(JLICOMJJGPO value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerCollisionLayerDataProperties : LBADIJNLAOO<ContainerCollisionLayerDataWrapper, ContainerCollisionLayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public static readonly NKDILCMHFJA<JLICOMJJGPO> collisionLayer;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x60E73C0", Offset = "0x60E65C0", VA = "0x1860E73C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public readonly MKKKMENBGOL<JLICOMJJGPO> collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x60E4750", Offset = "0x60E3950", VA = "0x1860E4750")]
		public ContainerCollisionLayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override ContainerCollisionLayerDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(ContainerCollisionLayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	public readonly struct SiblingSortOrderDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly SiblingSortOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x60F2200", Offset = "0x60F1400", VA = "0x1860F2200", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal SiblingSortOrderDataWrapper(Entity entity, SiblingSortOrderDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[Preserve]
	[CompilerGenerated]
	public class SiblingSortOrderDataProperties : LBADIJNLAOO<SiblingSortOrderDataWrapper, SiblingSortOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public static readonly NKDILCMHFJA<DHOGHBGBODA> order;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x60E72C0", Offset = "0x60E64C0", VA = "0x1860E72C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly MKKKMENBGOL<DHOGHBGBODA> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x60F20B0", Offset = "0x60F12B0", VA = "0x1860F20B0")]
		public SiblingSortOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override SiblingSortOrderDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(SiblingSortOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	public readonly struct ContainerGrabbableModeDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly ContainerGrabbableModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x60E51C0", Offset = "0x60E43C0", VA = "0x1860E51C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal ContainerGrabbableModeDataWrapper(Entity entity, ContainerGrabbableModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x60E5160", Offset = "0x60E4360", VA = "0x1860E5160")]
		public KJOJBBBAKAP CEJNOCOGFPI()
		{
			return default(KJOJBBBAKAP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x60E5260", Offset = "0x60E4460", VA = "0x1860E5260")]
		public bool NCCEIPGILFM(KJOJBBBAKAP value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerGrabbableModeDataProperties : LBADIJNLAOO<ContainerGrabbableModeDataWrapper, ContainerGrabbableModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public static readonly NKDILCMHFJA<KJOJBBBAKAP> grabbableMode;

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x60E83E0", Offset = "0x60E75E0", VA = "0x1860E83E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly MKKKMENBGOL<KJOJBBBAKAP> grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x60E5010", Offset = "0x60E4210", VA = "0x1860E5010")]
		public ContainerGrabbableModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override ContainerGrabbableModeDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(ContainerGrabbableModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	public readonly struct CostumePieceParentCostumeDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly CostumePieceParentCostumeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x60E59B0", Offset = "0x60E4BB0", VA = "0x1860E59B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal CostumePieceParentCostumeDataWrapper(Entity entity, CostumePieceParentCostumeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	[Preserve]
	public class CostumePieceParentCostumeDataProperties : LBADIJNLAOO<CostumePieceParentCostumeDataWrapper, CostumePieceParentCostumeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public static readonly NKDILCMHFJA<Entity> parentCostume;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x60E6F40", Offset = "0x60E6140", VA = "0x1860E6F40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public readonly MKKKMENBGOL<Entity> parentCostume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x60E5860", Offset = "0x60E4A60", VA = "0x1860E5860")]
		public CostumePieceParentCostumeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override CostumePieceParentCostumeDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(CostumePieceParentCostumeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	public readonly struct SplineShapeDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly SplineShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x60F3150", Offset = "0x60F2350", VA = "0x1860F3150", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal SplineShapeDataWrapper(Entity entity, SplineShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x60F31F0", Offset = "0x60F23F0", VA = "0x1860F31F0")]
		public JLLBINFBBDN KMNBOOFBNGB()
		{
			return default(JLLBINFBBDN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x60F3270", Offset = "0x60F2470", VA = "0x1860F3270")]
		public bool OMFNHHAMOIA(JLLBINFBBDN value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[Preserve]
	[CompilerGenerated]
	public class SplineShapeDataProperties : LBADIJNLAOO<SplineShapeDataWrapper, SplineShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public static readonly NKDILCMHFJA<JLLBINFBBDN> parameters;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x60E7240", Offset = "0x60E6440", VA = "0x1860E7240")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly MKKKMENBGOL<JLLBINFBBDN> parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x60F3000", Offset = "0x60F2200", VA = "0x1860F3000")]
		public SplineShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override SplineShapeDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(SplineShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	public readonly struct TransformFlagsDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly TransformFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x60F4470", Offset = "0x60F3670", VA = "0x1860F4470", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal TransformFlagsDataWrapper(Entity entity, TransformFlagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	[Preserve]
	public class TransformFlagsDataProperties : LBADIJNLAOO<TransformFlagsDataWrapper, TransformFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly NKDILCMHFJA<CCMNNACNPHP> transformHint;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly NKDILCMHFJA<OFPPBMBMNOL> transformPriority;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x60E79F0", Offset = "0x60E6BF0", VA = "0x1860E79F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public readonly MKKKMENBGOL<CCMNNACNPHP> transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public readonly MKKKMENBGOL<OFPPBMBMNOL> transformPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x7B7560", Offset = "0x7B6760", VA = "0x1807B7560", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x60F4290", Offset = "0x60F3490", VA = "0x1860F4290")]
		public TransformFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override TransformFlagsDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(TransformFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	public readonly struct ContainerFlagsDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly ContainerFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x60E4F10", Offset = "0x60E4110", VA = "0x1860E4F10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal ContainerFlagsDataWrapper(Entity entity, ContainerFlagsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x60E4FB0", Offset = "0x60E41B0", VA = "0x1860E4FB0")]
		public BPEECEOEIPM NEGHIFMCEAF()
		{
			return default(BPEECEOEIPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x60E4E60", Offset = "0x60E4060", VA = "0x1860E4E60")]
		public void ELGLGNPMILI(BPEECEOEIPM flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerFlagsDataProperties : LBADIJNLAOO<ContainerFlagsDataWrapper, ContainerFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public static readonly NKDILCMHFJA<BPEECEOEIPM> flags;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x60E7440", Offset = "0x60E6640", VA = "0x1860E7440")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public readonly MKKKMENBGOL<BPEECEOEIPM> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x60E4D10", Offset = "0x60E3F10", VA = "0x1860E4D10")]
		public ContainerFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override ContainerFlagsDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(ContainerFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	[global::COJDIMJIKPE]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[global::JEJFDDMFHFN(1)]
		public BPEECEOEIPM flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionModeDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly ContainerCollisionModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public NMFMEBNCGMB collisionMode
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x60E4BB0", Offset = "0x60E3DB0", VA = "0x1860E4BB0")]
			get
			{
				return default(NMFMEBNCGMB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x60E4C10", Offset = "0x60E3E10", VA = "0x1860E4C10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal ContainerCollisionModeDataWrapper(Entity entity, ContainerCollisionModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x60E4CB0", Offset = "0x60E3EB0", VA = "0x1860E4CB0")]
		public NMFMEBNCGMB LHNJGKLAEKK()
		{
			return default(NMFMEBNCGMB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x60E4B50", Offset = "0x60E3D50", VA = "0x1860E4B50")]
		public bool AGBLGMCANFD(NMFMEBNCGMB value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerCollisionModeDataProperties : LBADIJNLAOO<ContainerCollisionModeDataWrapper, ContainerCollisionModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public static readonly NKDILCMHFJA<NMFMEBNCGMB> collisionMode;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x60E6E00", Offset = "0x60E6000", VA = "0x1860E6E00")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly MKKKMENBGOL<NMFMEBNCGMB> collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x60E4A00", Offset = "0x60E3C00", VA = "0x1860E4A00")]
		public ContainerCollisionModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override ContainerCollisionModeDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(ContainerCollisionModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	public readonly struct PhysicsMaterialDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private readonly PhysicsMaterialDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x60EF9C0", Offset = "0x60EEBC0", VA = "0x1860EF9C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal PhysicsMaterialDataWrapper(Entity entity, PhysicsMaterialDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x60EFA60", Offset = "0x60EEC60", VA = "0x1860EFA60")]
		public bool PMAPFGHILDF(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[Preserve]
	[CompilerGenerated]
	public class PhysicsMaterialDataProperties : LBADIJNLAOO<PhysicsMaterialDataWrapper, PhysicsMaterialData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly NKDILCMHFJA<float> density;

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x60E74C0", Offset = "0x60E66C0", VA = "0x1860E74C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly MKKKMENBGOL<float> density;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x60EF870", Offset = "0x60EEA70", VA = "0x1860EF870")]
		public PhysicsMaterialDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override PhysicsMaterialDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	public readonly struct ObjectPolicyDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly ObjectPolicyDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public OPHOACBKMHH scaleRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x60EEFA0", Offset = "0x60EE1A0", VA = "0x1860EEFA0")]
			get
			{
				return default(OPHOACBKMHH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x60EEE50", Offset = "0x60EE050", VA = "0x1860EEE50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal ObjectPolicyDataWrapper(Entity entity, ObjectPolicyDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x60EF020", Offset = "0x60EE220", VA = "0x1860EF020")]
		public INIFBINLFIE NEGHIFMCEAF()
		{
			return default(INIFBINLFIE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x60EEDF0", Offset = "0x60EDFF0", VA = "0x1860EEDF0")]
		public OBPHPMOBDFL EFJEPEKELIP()
		{
			return default(OBPHPMOBDFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x60EED30", Offset = "0x60EDF30", VA = "0x1860EED30")]
		public bool ACDPIKBHAMM(OBPHPMOBDFL value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x60EEEF0", Offset = "0x60EE0F0", VA = "0x1860EEEF0")]
		public void FBGAGDEIDGO(OBPHPMOBDFL flag, bool enable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x60EED90", Offset = "0x60EDF90", VA = "0x1860EED90")]
		public OLHAMEMJPND BCODKLCAJAL()
		{
			return default(OLHAMEMJPND);
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x60EF080", Offset = "0x60EE280", VA = "0x1860EF080")]
		public bool OFHFFABAAOM(OLHAMEMJPND value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectPolicyDataProperties : LBADIJNLAOO<ObjectPolicyDataWrapper, ObjectPolicyData>
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public static readonly NKDILCMHFJA<OPHOACBKMHH> scaleRestriction;

			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly NKDILCMHFJA<OBPHPMOBDFL> userConfigurableFlags;

			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly NKDILCMHFJA<OLHAMEMJPND> circuitsTransformBehavior;

			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly NKDILCMHFJA<INIFBINLFIE> flags;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x60E8060", Offset = "0x60E7260", VA = "0x1860E8060")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public readonly MKKKMENBGOL<OPHOACBKMHH> scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public readonly MKKKMENBGOL<OBPHPMOBDFL> userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public readonly MKKKMENBGOL<OLHAMEMJPND> circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public readonly MKKKMENBGOL<INIFBINLFIE> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x7B7520", Offset = "0x7B6720", VA = "0x1807B7520", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x60EEA40", Offset = "0x60EDC40", VA = "0x1860EEA40")]
		public ObjectPolicyDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override ObjectPolicyDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(ObjectPolicyDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[global::COJDIMJIKPE]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[global::JEJFDDMFHFN(1)]
		public INIFBINLFIE flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[global::JEJFDDMFHFN(2)]
		public OPHOACBKMHH scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[global::JEJFDDMFHFN(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	[global::COJDIMJIKPE]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[global::JEJFDDMFHFN(1)]
		public INIFBINLFIE flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[global::JEJFDDMFHFN(2)]
		public OPHOACBKMHH scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[global::JEJFDDMFHFN(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	[global::COJDIMJIKPE]
	[CompilerGenerated]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[global::JEJFDDMFHFN(1)]
		public INIFBINLFIE flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[global::JEJFDDMFHFN(2)]
		public OPHOACBKMHH scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[global::JEJFDDMFHFN(3)]
		public OBPHPMOBDFL userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[global::COJDIMJIKPE]
	[TypeManager.TypeVersion(2)]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[global::JEJFDDMFHFN(2)]
		public OPHOACBKMHH scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[global::JEJFDDMFHFN(3)]
		public OBPHPMOBDFL userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[global::JEJFDDMFHFN(1)]
		public INIFBINLFIE flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	public readonly struct SplinePointParentDataWrapper : CJAKPFKCCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly SplinePointParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x60F2640", Offset = "0x60F1840", VA = "0x1860F2640", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x1DF9B20", Offset = "0x1DF8D20", VA = "0x181DF9B20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x60D8750", Offset = "0x60D7950", VA = "0x1860D8750")]
		internal SplinePointParentDataWrapper(Entity entity, SplinePointParentDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x60F26E0", Offset = "0x60F18E0", VA = "0x1860F26E0")]
		public bool IKIEPFKLNFB(LocalId value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointParentDataProperties : LBADIJNLAOO<SplinePointParentDataWrapper, SplinePointParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly NKDILCMHFJA<Entity> spline;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x60E70C0", Offset = "0x60E62C0", VA = "0x1860E70C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly MKKKMENBGOL<Entity> spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private readonly POBGGKBBIKM[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected internal override POBGGKBBIKM[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x7B4170", Offset = "0x7B3370", VA = "0x1807B4170", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x60F24F0", Offset = "0x60F16F0", VA = "0x1860F24F0")]
		public SplinePointParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x60D84B0", Offset = "0x60D76B0", VA = "0x1860D84B0", Slot = "16")]
		protected internal override SplinePointParentDataWrapper FICPENOPBCF(Entity entity)
		{
			return default(SplinePointParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[CompilerGenerated]
	public static class ConfigMetadataRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private static readonly Dictionary<Type, int> enumTypeToIndex;

		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static readonly (long value, string name, string tooltip)[][] enumMetadata;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x60D8E70", Offset = "0x60D8070", VA = "0x1860D8E70")]
		public static (long, string, string) CLFLLGJFGAI(AIMLLPOCAAB value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x60D8D30", Offset = "0x60D7F30", VA = "0x1860D8D30")]
		public static (long, string, string)[] ADDGFOHANJB(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	internal static class NetworkComponentRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x60E8810", Offset = "0x60E7A10", VA = "0x1860E8810")]
		public static Type[] FNNGMMHMOEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x60E8860", Offset = "0x60E7A60", VA = "0x1860E8860")]
		private static void OEPCKJDAMHI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	internal static class NetworkEnumRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private static (Type type, long min, long max)[] enums;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x60E9BE0", Offset = "0x60E8DE0", VA = "0x1860E9BE0")]
		public static (Type, long, long)[] FNNGMMHMOEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x60E9C30", Offset = "0x60E8E30", VA = "0x1860E9C30")]
		private static void OEPCKJDAMHI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	[ILGOHFDJPOE(GDOPADDLIHF.Application)]
	[GENMAJFODJG(typeof(MEIFMMFGDDD), new string[] { "Registry" })]
	internal class NetworkPropertyRegistry : MEIFMMFGDDD
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private Type[] Type
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x7B4120", Offset = "0x7B3320", VA = "0x1807B4120")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		private int[] Offset
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x7B40F0", Offset = "0x7B32F0", VA = "0x1807B40F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private int[] Size
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7B4110", Offset = "0x7B3310", VA = "0x1807B4110")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		private Type[] ComponentType
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x7B4150", Offset = "0x7B3350", VA = "0x1807B4150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x60EE540", Offset = "0x60ED740", VA = "0x1860EE540")]
		public NetworkPropertyRegistry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x60EA8D0", Offset = "0x60E9AD0", VA = "0x1860EA8D0")]
		private void BHHPBOOALMI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	internal static class PropertyProviderRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x60EFF60", Offset = "0x60EF160", VA = "0x1860EFF60")]
		public static Type[] FNNGMMHMOEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x60EFFB0", Offset = "0x60EF1B0", VA = "0x1860EFFB0")]
		private static void OEPCKJDAMHI()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x60F5140", Offset = "0x60F4340", VA = "0x1860F5140")]
		public void OEPCKJDAMHI(AJJICLPDKOG registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x60F4510", Offset = "0x60F3710", VA = "0x1860F4510")]
		private void NGLABIAIGLG(AJJICLPDKOG registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2E65A30", Offset = "0x2E64C30", VA = "0x182E65A30")]
		private void OOKKDGNLJGC<T>(AJJICLPDKOG registry, [In] T value) where T : struct
		{
		}
	}
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	[Preserve]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	[Preserve]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	[CompilerGenerated]
	[Preserve]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private int last;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[GENMAJFODJG(typeof(MCJEAKOBBEO), new string[] { "Registry" })]
[ILGOHFDJPOE(GDOPADDLIHF.Application)]
internal class HKOGPNBFDDE : MCJEAKOBBEO
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public Type ECOLALBBEGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x60F5600", Offset = "0x60F4800", VA = "0x1860F5600", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Type[] MCNEEKPFBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x60F55F0", Offset = "0x60F47F0", VA = "0x1860F55F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public Type[] IDCAJNOGMAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x60F55E0", Offset = "0x60F47E0", VA = "0x1860F55E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public (Type type, long min, long max)[] ODOJCOJDFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x60F55B0", Offset = "0x60F47B0", VA = "0x1860F55B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x60F55C0", Offset = "0x60F47C0", VA = "0x1860F55C0", Slot = "8")]
	public void DDKMPGCEPGH(AJJICLPDKOG NDHNADPLILO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
	public HKOGPNBFDDE()
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
