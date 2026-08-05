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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87C6C0", Offset = "0x87AEC0", VA = "0x18087C6C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_DataLayer_Interfaces_Generated_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : ACEDPDPNKDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private HGLIPANAEFD bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855140", VA = "0x180856940", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x14ED5A0", Offset = "0x14EBDA0", VA = "0x1814ED5A0", Slot = "5")]
		public override void GGDGBHPPNIB(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6893BC0", Offset = "0x68923C0", VA = "0x186893BC0")]
		private void AOCOLDKKJHF(FCHLICHCLOD registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6893E40", Offset = "0x6892640", VA = "0x186893E40", Slot = "6")]
		public override void KNAPKCNJDIM(FCHLICHCLOD registry, [In] NGGDAGDIDAI filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852A90", VA = "0x180854290", Slot = "8")]
		public override void KCOPNMGFKOP(GOMCEOHIOKI registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6893EA0", Offset = "0x68926A0", VA = "0x186893EA0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	public readonly struct OverrideObjectNetworkIdDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly OverrideObjectNetworkIdDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x688F2E0", Offset = "0x688DAE0", VA = "0x18688F2E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal OverrideObjectNetworkIdDataWrapper(Entity entity, OverrideObjectNetworkIdDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Preserve]
	[CompilerGenerated]
	public class OverrideObjectNetworkIdDataProperties : KKBNKINFGCJ<OverrideObjectNetworkIdDataWrapper, OverrideObjectNetworkIdData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly MNECACGPLAM<uint> networkIdBits;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6885170", Offset = "0x6883970", VA = "0x186885170")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly FOLGLCGBGCK<uint> networkIdBits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x688F190", Offset = "0x688D990", VA = "0x18688F190")]
		public OverrideObjectNetworkIdDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override OverrideObjectNetworkIdDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(OverrideObjectNetworkIdDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public readonly struct PersistentUserTagDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly PersistentUserTagDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x688F750", Offset = "0x688DF50", VA = "0x18688F750", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal PersistentUserTagDataWrapper(Entity entity, PersistentUserTagDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[Preserve]
	public class PersistentUserTagDataProperties : KKBNKINFGCJ<PersistentUserTagDataWrapper, PersistentUserTagData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly MNECACGPLAM<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly MNECACGPLAM<bool> initalizedDefaults;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x68852F0", Offset = "0x6883AF0", VA = "0x1868852F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly FOLGLCGBGCK<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly FOLGLCGBGCK<bool> initalizedDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855160", VA = "0x180856960", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x688F570", Offset = "0x688DD70", VA = "0x18688F570")]
		public PersistentUserTagDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override PersistentUserTagDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(PersistentUserTagDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[global::OKAAICJOLKO]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
	public struct PersistentUserTagData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::COKOBOEFFNH(1)]
		public FixedList32Bytes<int> tags;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public readonly struct LocalDeformableScaleDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LocalDeformableScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6884800", Offset = "0x6883000", VA = "0x186884800", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal LocalDeformableScaleDataWrapper(Entity entity, LocalDeformableScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[Preserve]
	public class LocalDeformableScaleDataProperties : KKBNKINFGCJ<LocalDeformableScaleDataWrapper, LocalDeformableScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly MNECACGPLAM<float3> localDeformationScale;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6886E90", Offset = "0x6885690", VA = "0x186886E90")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly FOLGLCGBGCK<float3> localDeformationScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x68846B0", Offset = "0x6882EB0", VA = "0x1868846B0")]
		public LocalDeformableScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override LocalDeformableScaleDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(LocalDeformableScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
	[global::OKAAICJOLKO]
	public struct LocalDeformableScaleData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[global::COKOBOEFFNH(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public readonly struct SplinePointScaleDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly SplinePointScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x68921B0", Offset = "0x68909B0", VA = "0x1868921B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal SplinePointScaleDataWrapper(Entity entity, SplinePointScaleDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x68922C0", Offset = "0x6890AC0", VA = "0x1868922C0")]
		public float3 LFNHJPOBDDC()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6892250", Offset = "0x6890A50", VA = "0x186892250")]
		public bool HGJJBAJEELB(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointScaleDataProperties : KKBNKINFGCJ<SplinePointScaleDataWrapper, SplinePointScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly MNECACGPLAM<float3> localScale;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6886170", Offset = "0x6884970", VA = "0x186886170")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly FOLGLCGBGCK<float3> localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6892060", Offset = "0x6890860", VA = "0x186892060")]
		public SplinePointScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override SplinePointScaleDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(SplinePointScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	public readonly struct LocalUniformScaleDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly LocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6884C70", Offset = "0x6883470", VA = "0x186884C70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal LocalUniformScaleDataWrapper(Entity entity, LocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[Preserve]
	[CompilerGenerated]
	public class LocalUniformScaleDataProperties : KKBNKINFGCJ<LocalUniformScaleDataWrapper, LocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly MNECACGPLAM<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6886270", Offset = "0x6884A70", VA = "0x186886270")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly FOLGLCGBGCK<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6884B20", Offset = "0x6883320", VA = "0x186884B20")]
		public LocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override LocalUniformScaleDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(LocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public readonly struct InteractionFilterEnabledDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly InteractionFilterEnabledDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6884230", Offset = "0x6882A30", VA = "0x186884230", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal InteractionFilterEnabledDataWrapper(Entity entity, InteractionFilterEnabledDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	[Preserve]
	public class InteractionFilterEnabledDataProperties : KKBNKINFGCJ<InteractionFilterEnabledDataWrapper, InteractionFilterEnabledData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly MNECACGPLAM<NFFPFNKGIEF> filterMode;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x68858D0", Offset = "0x68840D0", VA = "0x1868858D0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly FOLGLCGBGCK<NFFPFNKGIEF> filterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68840E0", Offset = "0x68828E0", VA = "0x1868840E0")]
		public InteractionFilterEnabledDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override InteractionFilterEnabledDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(InteractionFilterEnabledDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	public readonly struct ReferenceGroupReferenceBufferWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly ReferenceGroupReferenceBufferProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6890410", Offset = "0x688EC10", VA = "0x186890410", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ReferenceGroupReferenceBufferWrapper(Entity entity, ReferenceGroupReferenceBufferProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	[Preserve]
	public class ReferenceGroupReferenceBufferProperties : KCBEHOGCCIK<ReferenceGroupReferenceBufferWrapper, ReferenceGroupReferenceBuffer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly MNECACGPLAM<Entity> reference;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6886590", Offset = "0x6884D90", VA = "0x186886590")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly FLIOGKDFLPI<ReferenceGroupReferenceBuffer, Entity> reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x68902C0", Offset = "0x688EAC0", VA = "0x1868902C0")]
		public ReferenceGroupReferenceBufferProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ReferenceGroupReferenceBufferWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ReferenceGroupReferenceBufferWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public readonly struct UserTagReferenceBufferWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly UserTagReferenceBufferProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6893B20", Offset = "0x6892320", VA = "0x186893B20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal UserTagReferenceBufferWrapper(Entity entity, UserTagReferenceBufferProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[Preserve]
	[CompilerGenerated]
	public class UserTagReferenceBufferProperties : KCBEHOGCCIK<UserTagReferenceBufferWrapper, UserTagReferenceBuffer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly MNECACGPLAM<Entity> Child;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6885950", Offset = "0x6884150", VA = "0x186885950")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly FLIOGKDFLPI<UserTagReferenceBuffer, Entity> Child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x68939D0", Offset = "0x68921D0", VA = "0x1868939D0")]
		public UserTagReferenceBufferProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override UserTagReferenceBufferWrapper CIOKHABNMPN(Entity entity)
		{
			return default(UserTagReferenceBufferWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	public readonly struct InteractionFilterDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly InteractionFilterDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6884040", Offset = "0x6882840", VA = "0x186884040", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal InteractionFilterDataWrapper(Entity entity, InteractionFilterDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterDataProperties : KKBNKINFGCJ<InteractionFilterDataWrapper, InteractionFilterData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly MNECACGPLAM<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly MNECACGPLAM<bool> enabled;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly MNECACGPLAM<NFFPFNKGIEF> filterMode;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6885440", Offset = "0x6883C40", VA = "0x186885440")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly FOLGLCGBGCK<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly FOLGLCGBGCK<bool> enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly FOLGLCGBGCK<NFFPFNKGIEF> filterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x856AB0", Offset = "0x8552B0", VA = "0x180856AB0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6883DD0", Offset = "0x68825D0", VA = "0x186883DD0")]
		public InteractionFilterDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override InteractionFilterDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(InteractionFilterDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public readonly struct ComponentSerializedVersionDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly ComponentSerializedVersionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6875F00", Offset = "0x6874700", VA = "0x186875F00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ComponentSerializedVersionDataWrapper(Entity entity, ComponentSerializedVersionDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	[Preserve]
	public class ComponentSerializedVersionDataProperties : KKBNKINFGCJ<ComponentSerializedVersionDataWrapper, ComponentSerializedVersionData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly MNECACGPLAM<CGBINMFDCDD> version;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x68850F0", Offset = "0x68838F0", VA = "0x1868850F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly FOLGLCGBGCK<CGBINMFDCDD> version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6875DB0", Offset = "0x68745B0", VA = "0x186875DB0")]
		public ComponentSerializedVersionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ComponentSerializedVersionDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ComponentSerializedVersionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	public readonly struct ReferenceGroupOwnerDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly ReferenceGroupOwnerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6890220", Offset = "0x688EA20", VA = "0x186890220", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ReferenceGroupOwnerDataWrapper(Entity entity, ReferenceGroupOwnerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Preserve]
	[CompilerGenerated]
	public class ReferenceGroupOwnerDataProperties : KKBNKINFGCJ<ReferenceGroupOwnerDataWrapper, ReferenceGroupOwnerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly MNECACGPLAM<Entity> owner;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6885AD0", Offset = "0x68842D0", VA = "0x186885AD0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly FOLGLCGBGCK<Entity> owner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x68900D0", Offset = "0x688E8D0", VA = "0x1868900D0")]
		public ReferenceGroupOwnerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ReferenceGroupOwnerDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ReferenceGroupOwnerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	public readonly struct MakerPenHeldDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly MakerPenHeldDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6884E60", Offset = "0x6883660", VA = "0x186884E60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal MakerPenHeldDataWrapper(Entity entity, MakerPenHeldDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6884F00", Offset = "0x6883700", VA = "0x186884F00")]
		public bool IACFEKFNAIB(bool value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[Preserve]
	[CompilerGenerated]
	public class MakerPenHeldDataProperties : KKBNKINFGCJ<MakerPenHeldDataWrapper, MakerPenHeldData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly MNECACGPLAM<bool> makerPenHeld;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6885850", Offset = "0x6884050", VA = "0x186885850")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly FOLGLCGBGCK<bool> makerPenHeld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6884D10", Offset = "0x6883510", VA = "0x186884D10")]
		public MakerPenHeldDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override MakerPenHeldDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(MakerPenHeldDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public readonly struct ToolCleanupSettingsDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly ToolCleanupSettingsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x68931E0", Offset = "0x68919E0", VA = "0x1868931E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ToolCleanupSettingsDataWrapper(Entity entity, ToolCleanupSettingsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6893280", Offset = "0x6891A80", VA = "0x186893280")]
		public float FPGGHMFOAIE()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6893180", Offset = "0x6891980", VA = "0x186893180")]
		public bool DIGJOCABMIC(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6893070", Offset = "0x6891870", VA = "0x186893070")]
		public FCJMLJLKKEE BCOPHAJBBFA()
		{
			return default(FCJMLJLKKEE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x68930D0", Offset = "0x68918D0", VA = "0x1868930D0")]
		public void DGNMFCHCACG(FCJMLJLKKEE flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	[CompilerGenerated]
	public class ToolCleanupSettingsDataProperties : KKBNKINFGCJ<ToolCleanupSettingsDataWrapper, ToolCleanupSettingsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public static readonly MNECACGPLAM<float> delay;

			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public static readonly MNECACGPLAM<FCJMLJLKKEE> toolCleanupFlags;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x6885020", Offset = "0x6883820", VA = "0x186885020")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly FOLGLCGBGCK<float> delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly FOLGLCGBGCK<FCJMLJLKKEE> toolCleanupFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855160", VA = "0x180856960", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6892E90", Offset = "0x6891690", VA = "0x186892E90")]
		public ToolCleanupSettingsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ToolCleanupSettingsDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	public readonly struct SplinePointOrderDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly SplinePointOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6891730", Offset = "0x688FF30", VA = "0x186891730", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal SplinePointOrderDataWrapper(Entity entity, SplinePointOrderDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x68917D0", Offset = "0x688FFD0", VA = "0x1868917D0")]
		public bool HPCDOEFNLFN(NJKOAFMLNJE value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointOrderDataProperties : KKBNKINFGCJ<SplinePointOrderDataWrapper, SplinePointOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly MNECACGPLAM<NJKOAFMLNJE> order;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x6886F90", Offset = "0x6885790", VA = "0x186886F90")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly FOLGLCGBGCK<NJKOAFMLNJE> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x68915E0", Offset = "0x688FDE0", VA = "0x1868915E0")]
		public SplinePointOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override SplinePointOrderDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(SplinePointOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	public readonly struct CostumePieceSlotIndexDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly CostumePieceSlotIndexDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x68836D0", Offset = "0x6881ED0", VA = "0x1868836D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal CostumePieceSlotIndexDataWrapper(Entity entity, CostumePieceSlotIndexDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Preserve]
	[CompilerGenerated]
	public class CostumePieceSlotIndexDataProperties : KKBNKINFGCJ<CostumePieceSlotIndexDataWrapper, CostumePieceSlotIndexData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly MNECACGPLAM<int> slotIndex;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x6885A50", Offset = "0x6884250", VA = "0x186885A50")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly FOLGLCGBGCK<int> slotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6883580", Offset = "0x6881D80", VA = "0x186883580")]
		public CostumePieceSlotIndexDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override CostumePieceSlotIndexDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(CostumePieceSlotIndexDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	public readonly struct LocalPoseDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly LocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6884A80", Offset = "0x6883280", VA = "0x186884A80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal LocalPoseDataWrapper(Entity entity, LocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Preserve]
	[CompilerGenerated]
	public class LocalPoseDataProperties : KKBNKINFGCJ<LocalPoseDataWrapper, LocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly MNECACGPLAM<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly MNECACGPLAM<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x68864C0", Offset = "0x6884CC0", VA = "0x1868864C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly FOLGLCGBGCK<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly FOLGLCGBGCK<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855160", VA = "0x180856960", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x68848A0", Offset = "0x68830A0", VA = "0x1868848A0")]
		public LocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override LocalPoseDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(LocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectActiveStatusDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly ReplicatedObjectActiveStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6890600", Offset = "0x688EE00", VA = "0x186890600", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ReplicatedObjectActiveStatusDataWrapper(Entity entity, ReplicatedObjectActiveStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatedObjectActiveStatusDataProperties : KKBNKINFGCJ<ReplicatedObjectActiveStatusDataWrapper, ReplicatedObjectActiveStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public static readonly MNECACGPLAM<bool> active;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x68867E0", Offset = "0x6884FE0", VA = "0x1868867E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly FOLGLCGBGCK<bool> active;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x68904B0", Offset = "0x688ECB0", VA = "0x1868904B0")]
		public ReplicatedObjectActiveStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ReplicatedObjectActiveStatusDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ReplicatedObjectActiveStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	public readonly struct ReplicatorPreallocatedObjectCountDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly ReplicatorPreallocatedObjectCountDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6890E50", Offset = "0x688F650", VA = "0x186890E50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ReplicatorPreallocatedObjectCountDataWrapper(Entity entity, ReplicatorPreallocatedObjectCountDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataProperties : KKBNKINFGCJ<ReplicatorPreallocatedObjectCountDataWrapper, ReplicatorPreallocatedObjectCountData>
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly MNECACGPLAM<int> preallocatedCopies;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x68861F0", Offset = "0x68849F0", VA = "0x1868861F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly FOLGLCGBGCK<int> preallocatedCopies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6890D00", Offset = "0x688F500", VA = "0x186890D00")]
		public ReplicatorPreallocatedObjectCountDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ReplicatorPreallocatedObjectCountDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ReplicatorPreallocatedObjectCountDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16379038427767722229uL)]
	[global::OKAAICJOLKO]
	public struct ReplicatorPreallocatedObjectCountData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[global::COKOBOEFFNH(1)]
		public int PreallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	public readonly struct SplinePointRotationDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly SplinePointRotationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6891EE0", Offset = "0x68906E0", VA = "0x186891EE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal SplinePointRotationDataWrapper(Entity entity, SplinePointRotationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6891F80", Offset = "0x6890780", VA = "0x186891F80")]
		public quaternion NEOACCMAIKF()
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6891FF0", Offset = "0x68907F0", VA = "0x186891FF0")]
		public bool PPDALCLHNIK(quaternion value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointRotationDataProperties : KKBNKINFGCJ<SplinePointRotationDataWrapper, SplinePointRotationData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly MNECACGPLAM<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6885650", Offset = "0x6883E50", VA = "0x186885650")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly FOLGLCGBGCK<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6891D90", Offset = "0x6890590", VA = "0x186891D90")]
		public SplinePointRotationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override SplinePointRotationDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(SplinePointRotationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	public readonly struct InteractionFilterAllTagsDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly InteractionFilterAllTagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6883B40", Offset = "0x6882340", VA = "0x186883B40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal InteractionFilterAllTagsDataWrapper(Entity entity, InteractionFilterAllTagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterAllTagsDataProperties : KKBNKINFGCJ<InteractionFilterAllTagsDataWrapper, InteractionFilterAllTagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly MNECACGPLAM<Entity> allTags;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x68857D0", Offset = "0x6883FD0", VA = "0x1868857D0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public readonly FOLGLCGBGCK<Entity> allTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x68839F0", Offset = "0x68821F0", VA = "0x1868839F0")]
		public InteractionFilterAllTagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override InteractionFilterAllTagsDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(InteractionFilterAllTagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	public readonly struct ToolCleanupStatusDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly ToolCleanupStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x68934C0", Offset = "0x6891CC0", VA = "0x1868934C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ToolCleanupStatusDataWrapper(Entity entity, ToolCleanupStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[Preserve]
	[CompilerGenerated]
	public class ToolCleanupStatusDataProperties : KKBNKINFGCJ<ToolCleanupStatusDataWrapper, ToolCleanupStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly MNECACGPLAM<float> cleanupStartTime;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public static readonly MNECACGPLAM<DLNKJBKMANM> statusFlags;

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x6885D50", Offset = "0x6884550", VA = "0x186885D50")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly FOLGLCGBGCK<float> cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly FOLGLCGBGCK<DLNKJBKMANM> statusFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855160", VA = "0x180856960", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x68932E0", Offset = "0x6891AE0", VA = "0x1868932E0")]
		public ToolCleanupStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ToolCleanupStatusDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ToolCleanupStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
	[CompilerGenerated]
	[global::OKAAICJOLKO]
	public struct ToolCleanupStatusData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[global::COKOBOEFFNH(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[global::COKOBOEFFNH(2)]
		public bool forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[global::COKOBOEFFNH(3)]
		public bool cleanupDone;
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	public readonly struct InteractionFilterAnyTagsDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly InteractionFilterAnyTagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6883D30", Offset = "0x6882530", VA = "0x186883D30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal InteractionFilterAnyTagsDataWrapper(Entity entity, InteractionFilterAnyTagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	[Preserve]
	public class InteractionFilterAnyTagsDataProperties : KKBNKINFGCJ<InteractionFilterAnyTagsDataWrapper, InteractionFilterAnyTagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public static readonly MNECACGPLAM<Entity> anyTags;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x68856D0", Offset = "0x6883ED0", VA = "0x1868856D0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly FOLGLCGBGCK<Entity> anyTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6883BE0", Offset = "0x68823E0", VA = "0x186883BE0")]
		public InteractionFilterAnyTagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override InteractionFilterAnyTagsDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(InteractionFilterAnyTagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	public readonly struct SplinePointPositionDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly SplinePointPositionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6891C80", Offset = "0x6890480", VA = "0x186891C80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal SplinePointPositionDataWrapper(Entity entity, SplinePointPositionDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6891C00", Offset = "0x6890400", VA = "0x186891C00")]
		public float3 CEGEMHDGALH()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6891D20", Offset = "0x6890520", VA = "0x186891D20")]
		public bool PFPEKJMJACK(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointPositionDataProperties : KKBNKINFGCJ<SplinePointPositionDataWrapper, SplinePointPositionData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public static readonly MNECACGPLAM<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x68851F0", Offset = "0x68839F0", VA = "0x1868851F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly FOLGLCGBGCK<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6891AB0", Offset = "0x68902B0", VA = "0x186891AB0")]
		public SplinePointPositionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override SplinePointPositionDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(SplinePointPositionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	public readonly struct ShapeTypeDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly ShapeTypeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public JHCJGJGADEK shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6891390", Offset = "0x688FB90", VA = "0x186891390")]
			get
			{
				return default(JHCJGJGADEK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x68912F0", Offset = "0x688FAF0", VA = "0x1868912F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ShapeTypeDataWrapper(Entity entity, ShapeTypeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[Preserve]
	[CompilerGenerated]
	public class ShapeTypeDataProperties : KKBNKINFGCJ<ShapeTypeDataWrapper, ShapeTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public static readonly MNECACGPLAM<JHCJGJGADEK> shapeType;

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6885F20", Offset = "0x6884720", VA = "0x186885F20")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public readonly FOLGLCGBGCK<JHCJGJGADEK> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x68911A0", Offset = "0x688F9A0", VA = "0x1868911A0")]
		public ShapeTypeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ShapeTypeDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ShapeTypeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	public readonly struct PrimitiveShapeDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly PrimitiveShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ABNGHCBPDJL shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x688FE20", Offset = "0x688E620", VA = "0x18688FE20")]
			get
			{
				return default(ABNGHCBPDJL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x688FD80", Offset = "0x688E580", VA = "0x18688FD80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal PrimitiveShapeDataWrapper(Entity entity, PrimitiveShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x688FE80", Offset = "0x688E680", VA = "0x18688FE80")]
		public ABNGHCBPDJL PCMAHBIFHJF()
		{
			return default(ABNGHCBPDJL);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[Preserve]
	[CompilerGenerated]
	public class PrimitiveShapeDataProperties : KKBNKINFGCJ<PrimitiveShapeDataWrapper, PrimitiveShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly MNECACGPLAM<ABNGHCBPDJL> shapeType;

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x68860F0", Offset = "0x68848F0", VA = "0x1868860F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public readonly FOLGLCGBGCK<ABNGHCBPDJL> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x688FC30", Offset = "0x688E430", VA = "0x18688FC30")]
		public PrimitiveShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override PrimitiveShapeDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	public readonly struct ReplicatorDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly ReplicatorDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6890A70", Offset = "0x688F270", VA = "0x186890A70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ReplicatorDataWrapper(Entity entity, ReplicatorDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatorDataProperties : KKBNKINFGCJ<ReplicatorDataWrapper, ReplicatorData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly MNECACGPLAM<Entity> Target;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public static readonly MNECACGPLAM<bool> NeedsCircuitUpdate;

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x6886C70", Offset = "0x6885470", VA = "0x186886C70")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public readonly FOLGLCGBGCK<Entity> Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly FOLGLCGBGCK<bool> NeedsCircuitUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855160", VA = "0x180856960", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6890890", Offset = "0x688F090", VA = "0x186890890")]
		public ReplicatorDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ReplicatorDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ReplicatorDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[global::OKAAICJOLKO]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	public struct ReplicatorData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[global::COKOBOEFFNH(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	public readonly struct PlayerScopeDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly PlayerScopeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x688FB90", Offset = "0x688E390", VA = "0x18688FB90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal PlayerScopeDataWrapper(Entity entity, PlayerScopeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[Preserve]
	[CompilerGenerated]
	public class PlayerScopeDataProperties : KKBNKINFGCJ<PlayerScopeDataWrapper, PlayerScopeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly MNECACGPLAM<Entity> playerScope;

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x68855D0", Offset = "0x6883DD0", VA = "0x1868855D0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public readonly FOLGLCGBGCK<Entity> playerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x688FA40", Offset = "0x688E240", VA = "0x18688FA40")]
		public PlayerScopeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override PlayerScopeDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(PlayerScopeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	public readonly struct EntityBundlePartDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly EntityBundlePartDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6883950", Offset = "0x6882150", VA = "0x186883950", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal EntityBundlePartDataWrapper(Entity entity, EntityBundlePartDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[Preserve]
	[CompilerGenerated]
	public class EntityBundlePartDataProperties : KKBNKINFGCJ<EntityBundlePartDataWrapper, EntityBundlePartData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public static readonly MNECACGPLAM<Entity> prefabRoot;

			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public static readonly MNECACGPLAM<uint> entityBundlePartId;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x6886610", Offset = "0x6884E10", VA = "0x186886610")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly FOLGLCGBGCK<Entity> prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly FOLGLCGBGCK<uint> entityBundlePartId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855160", VA = "0x180856960", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6883770", Offset = "0x6881F70", VA = "0x186883770")]
		public EntityBundlePartDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override EntityBundlePartDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(EntityBundlePartDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectOwnedByPlayerDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly ReplicatedObjectOwnedByPlayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x68907F0", Offset = "0x688EFF0", VA = "0x1868907F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ReplicatedObjectOwnedByPlayerDataWrapper(Entity entity, ReplicatedObjectOwnedByPlayerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatedObjectOwnedByPlayerDataProperties : KKBNKINFGCJ<ReplicatedObjectOwnedByPlayerDataWrapper, ReplicatedObjectOwnedByPlayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public static readonly MNECACGPLAM<int> actorId;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6886AA0", Offset = "0x68852A0", VA = "0x186886AA0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public readonly FOLGLCGBGCK<int> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x68906A0", Offset = "0x688EEA0", VA = "0x1868906A0")]
		public ReplicatedObjectOwnedByPlayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ReplicatedObjectOwnedByPlayerDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ReplicatedObjectOwnedByPlayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	public readonly struct OMShapeContainerDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly OMShapeContainerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x688E7D0", Offset = "0x688CFD0", VA = "0x18688E7D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal OMShapeContainerDataWrapper(Entity entity, OMShapeContainerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[Preserve]
	[CompilerGenerated]
	public class OMShapeContainerDataProperties : KKBNKINFGCJ<OMShapeContainerDataWrapper, OMShapeContainerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public static readonly MNECACGPLAM<bool> canModifyWithCircuits;

			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public static readonly MNECACGPLAM<bool> optimizedCollidersEnabled;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6884F60", Offset = "0x6883760", VA = "0x186884F60")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly FOLGLCGBGCK<bool> canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly FOLGLCGBGCK<bool> optimizedCollidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855160", VA = "0x180856960", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x688E600", Offset = "0x688CE00", VA = "0x18688E600")]
		public OMShapeContainerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override OMShapeContainerDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(OMShapeContainerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	[global::OKAAICJOLKO]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[global::COKOBOEFFNH(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[global::COKOBOEFFNH(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[global::COKOBOEFFNH(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	public readonly struct AuthoredParentDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly AuthoredParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6875B20", Offset = "0x6874320", VA = "0x186875B20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal AuthoredParentDataWrapper(Entity entity, AuthoredParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredParentDataProperties : KKBNKINFGCJ<AuthoredParentDataWrapper, AuthoredParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public static readonly MNECACGPLAM<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x68868E0", Offset = "0x68850E0", VA = "0x1868868E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly FOLGLCGBGCK<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x68759D0", Offset = "0x68741D0", VA = "0x1868759D0")]
		public AuthoredParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override AuthoredParentDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(AuthoredParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	public readonly struct UserTagNameDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly UserTagNameDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6893930", Offset = "0x6892130", VA = "0x186893930", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal UserTagNameDataWrapper(Entity entity, UserTagNameDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	[Preserve]
	public class UserTagNameDataProperties : KKBNKINFGCJ<UserTagNameDataWrapper, UserTagNameData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly MNECACGPLAM<FixedString32Bytes> Value;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x6886760", Offset = "0x6884F60", VA = "0x186886760")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly FOLGLCGBGCK<FixedString32Bytes> Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x68937E0", Offset = "0x6891FE0", VA = "0x1868937E0")]
		public UserTagNameDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override UserTagNameDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(UserTagNameDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	public readonly struct NavMeshGenerationDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly NavMeshGenerationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6887260", Offset = "0x6885A60", VA = "0x186887260", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal NavMeshGenerationDataWrapper(Entity entity, NavMeshGenerationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6887300", Offset = "0x6885B00", VA = "0x186887300")]
		public KJOGCKDANFN HLKKHPDEPJL()
		{
			return default(KJOGCKDANFN);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6887360", Offset = "0x6885B60", VA = "0x186887360")]
		public bool MFKOFHBJBBP(KJOGCKDANFN value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	[Preserve]
	public class NavMeshGenerationDataProperties : KKBNKINFGCJ<NavMeshGenerationDataWrapper, NavMeshGenerationData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly MNECACGPLAM<KJOGCKDANFN> mode;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x6886440", Offset = "0x6884C40", VA = "0x186886440")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public readonly FOLGLCGBGCK<KJOGCKDANFN> mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6887110", Offset = "0x6885910", VA = "0x186887110")]
		public NavMeshGenerationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override NavMeshGenerationDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	public readonly struct ContainerNameDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly ContainerNameDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6883280", Offset = "0x6881A80", VA = "0x186883280", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ContainerNameDataWrapper(Entity entity, ContainerNameDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x68831F0", Offset = "0x68819F0", VA = "0x1868831F0")]
		public FixedString64Bytes CABCMCGDEBE()
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6883320", Offset = "0x6881B20", VA = "0x186883320")]
		public bool PMLGPJAGNJE(FixedString64Bytes value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerNameDataProperties : KKBNKINFGCJ<ContainerNameDataWrapper, ContainerNameData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly MNECACGPLAM<FixedString64Bytes> name;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6886960", Offset = "0x6885160", VA = "0x186886960")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly FOLGLCGBGCK<FixedString64Bytes> name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x68830A0", Offset = "0x68818A0", VA = "0x1868830A0")]
		public ContainerNameDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ContainerNameDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ContainerNameDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	public readonly struct ShapeConfigDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly ShapeConfigDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x68910A0", Offset = "0x688F8A0", VA = "0x1868910A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ShapeConfigDataWrapper(Entity entity, ShapeConfigDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6891040", Offset = "0x688F840", VA = "0x186891040")]
		public DEIDGEMLJNI BLJFEINPOPD()
		{
			return default(DEIDGEMLJNI);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6891140", Offset = "0x688F940", VA = "0x186891140")]
		public bool GOGKPELDIAE(DEIDGEMLJNI value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	[Preserve]
	public class ShapeConfigDataProperties : KKBNKINFGCJ<ShapeConfigDataWrapper, ShapeConfigData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public static readonly MNECACGPLAM<DEIDGEMLJNI> flags;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x6887010", Offset = "0x6885810", VA = "0x186887010")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public readonly FOLGLCGBGCK<DEIDGEMLJNI> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6890EF0", Offset = "0x688F6F0", VA = "0x186890EF0")]
		public ShapeConfigDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ShapeConfigDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ShapeConfigDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	public readonly struct ParentDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private readonly ParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x688F4D0", Offset = "0x688DCD0", VA = "0x18688F4D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ParentDataWrapper(Entity entity, ParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	[Preserve]
	public class ParentDataProperties : KKBNKINFGCJ<ParentDataWrapper, ParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public static readonly MNECACGPLAM<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x6886860", Offset = "0x6885060", VA = "0x186886860")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public readonly FOLGLCGBGCK<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x688F380", Offset = "0x688DB80", VA = "0x18688F380")]
		public ParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ParentDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	public readonly struct ReplicatorMaxObjectCountDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly ReplicatorMaxObjectCountDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6890C60", Offset = "0x688F460", VA = "0x186890C60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ReplicatorMaxObjectCountDataWrapper(Entity entity, ReplicatorMaxObjectCountDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatorMaxObjectCountDataProperties : KKBNKINFGCJ<ReplicatorMaxObjectCountDataWrapper, ReplicatorMaxObjectCountData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public static readonly MNECACGPLAM<int> MaxCopies;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x6885EA0", Offset = "0x68846A0", VA = "0x186885EA0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly FOLGLCGBGCK<int> MaxCopies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6890B10", Offset = "0x688F310", VA = "0x186890B10")]
		public ReplicatorMaxObjectCountDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ReplicatorMaxObjectCountDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ReplicatorMaxObjectCountDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	public readonly struct ContainerMassOverrideDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly ContainerMassOverrideDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x6882FA0", Offset = "0x68817A0", VA = "0x186882FA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ContainerMassOverrideDataWrapper(Entity entity, ContainerMassOverrideDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6882F40", Offset = "0x6881740", VA = "0x186882F40")]
		public float BLNPMCCHHCD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6883040", Offset = "0x6881840", VA = "0x186883040")]
		public bool KLJCBMHBLJO(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerMassOverrideDataProperties : KKBNKINFGCJ<ContainerMassOverrideDataWrapper, ContainerMassOverrideData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public static readonly MNECACGPLAM<float> mass;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x6886070", Offset = "0x6884870", VA = "0x186886070")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public readonly FOLGLCGBGCK<float> mass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6882DF0", Offset = "0x68815F0", VA = "0x186882DF0")]
		public ContainerMassOverrideDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ContainerMassOverrideDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ContainerMassOverrideDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalPoseDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly AuthoredLocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6875730", Offset = "0x6873F30", VA = "0x186875730", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal AuthoredLocalPoseDataWrapper(Entity entity, AuthoredLocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredLocalPoseDataProperties : KKBNKINFGCJ<AuthoredLocalPoseDataWrapper, AuthoredLocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public static readonly MNECACGPLAM<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public static readonly MNECACGPLAM<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x6885FA0", Offset = "0x68847A0", VA = "0x186885FA0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly FOLGLCGBGCK<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly FOLGLCGBGCK<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855160", VA = "0x180856960", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6875550", Offset = "0x6873D50", VA = "0x186875550")]
		public AuthoredLocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override AuthoredLocalPoseDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(AuthoredLocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	public readonly struct ObjectBoardNodeDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly ObjectBoardNodeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x688EA40", Offset = "0x688D240", VA = "0x18688EA40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ObjectBoardNodeDataWrapper(Entity entity, ObjectBoardNodeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectBoardNodeDataProperties : KKBNKINFGCJ<ObjectBoardNodeDataWrapper, ObjectBoardNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly MNECACGPLAM<NetworkGuid> nodeId;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly MNECACGPLAM<NetworkGuid> graphId;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x68869E0", Offset = "0x68851E0", VA = "0x1868869E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public readonly FOLGLCGBGCK<NetworkGuid> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public readonly FOLGLCGBGCK<NetworkGuid> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855160", VA = "0x180856960", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x688E870", Offset = "0x688D070", VA = "0x18688E870")]
		public ObjectBoardNodeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ObjectBoardNodeDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ObjectBoardNodeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalUniformScaleDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly AuthoredLocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6875930", Offset = "0x6874130", VA = "0x186875930", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal AuthoredLocalUniformScaleDataWrapper(Entity entity, AuthoredLocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredLocalUniformScaleDataProperties : KKBNKINFGCJ<AuthoredLocalUniformScaleDataWrapper, AuthoredLocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public static readonly MNECACGPLAM<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x68866E0", Offset = "0x6884EE0", VA = "0x1868866E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public readonly FOLGLCGBGCK<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x68757E0", Offset = "0x6873FE0", VA = "0x1868757E0")]
		public AuthoredLocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override AuthoredLocalUniformScaleDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(AuthoredLocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	public readonly struct StandardRenderableVisualDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly StandardRenderableVisualDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public KMNCGMLJPGG color
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x6892C20", Offset = "0x6891420", VA = "0x186892C20")]
			get
			{
				return default(KMNCGMLJPGG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public MKMLGNFLONO material
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x6892C80", Offset = "0x6891480", VA = "0x186892C80")]
			get
			{
				return default(MKMLGNFLONO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float uvScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x6892BC0", Offset = "0x68913C0", VA = "0x186892BC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float3 uvOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x6892920", Offset = "0x6891120", VA = "0x186892920")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6892AC0", Offset = "0x68912C0", VA = "0x186892AC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal StandardRenderableVisualDataWrapper(Entity entity, StandardRenderableVisualDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x68929A0", Offset = "0x68911A0", VA = "0x1868929A0")]
		public KMNCGMLJPGG BCIHOMKPDAC()
		{
			return default(KMNCGMLJPGG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6892A60", Offset = "0x6891260", VA = "0x186892A60")]
		public bool EMALGMKGMMH(KMNCGMLJPGG value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x6892A00", Offset = "0x6891200", VA = "0x186892A00")]
		public MKMLGNFLONO DKAEFCMAMOC()
		{
			return default(MKMLGNFLONO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6892DC0", Offset = "0x68915C0", VA = "0x186892DC0")]
		public bool NGNHOKCDNFF(MKMLGNFLONO value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6892D60", Offset = "0x6891560", VA = "0x186892D60")]
		public float MEJPLCADJOP()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6892B60", Offset = "0x6891360", VA = "0x186892B60")]
		public bool FOJIKFLIPNP(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6892CE0", Offset = "0x68914E0", VA = "0x186892CE0")]
		public float3 MCBJOPGKAAL()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6892E20", Offset = "0x6891620", VA = "0x186892E20")]
		public bool PAHMGNIMOIC(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[Preserve]
	[CompilerGenerated]
	public class StandardRenderableVisualDataProperties : KKBNKINFGCJ<StandardRenderableVisualDataWrapper, StandardRenderableVisualData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public static readonly MNECACGPLAM<KMNCGMLJPGG> color;

			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly MNECACGPLAM<MKMLGNFLONO> material;

			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public static readonly MNECACGPLAM<float> uvScale;

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly MNECACGPLAM<float3> uvOffset;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x6886D40", Offset = "0x6885540", VA = "0x186886D40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public readonly FOLGLCGBGCK<KMNCGMLJPGG> color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public readonly FOLGLCGBGCK<MKMLGNFLONO> material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly FOLGLCGBGCK<float> uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly FOLGLCGBGCK<float3> uvOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x8569D0", Offset = "0x8551D0", VA = "0x1808569D0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6892620", Offset = "0x6890E20", VA = "0x186892620")]
		public StandardRenderableVisualDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override StandardRenderableVisualDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionLayerDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly ContainerCollisionLayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x68823D0", Offset = "0x6880BD0", VA = "0x1868823D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ContainerCollisionLayerDataWrapper(Entity entity, ContainerCollisionLayerDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6882470", Offset = "0x6880C70", VA = "0x186882470")]
		public CNLPIGOIGNM KOKEDFHLKKG()
		{
			return default(CNLPIGOIGNM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x68824D0", Offset = "0x6880CD0", VA = "0x1868824D0")]
		public bool OJINPPDGBPI(CNLPIGOIGNM value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerCollisionLayerDataProperties : KKBNKINFGCJ<ContainerCollisionLayerDataWrapper, ContainerCollisionLayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public static readonly MNECACGPLAM<CNLPIGOIGNM> collisionLayer;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x6885B50", Offset = "0x6884350", VA = "0x186885B50")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public readonly FOLGLCGBGCK<CNLPIGOIGNM> collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x6882280", Offset = "0x6880A80", VA = "0x186882280")]
		public ContainerCollisionLayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ContainerCollisionLayerDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ContainerCollisionLayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	public readonly struct InteractionFilterNoneTagsDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly InteractionFilterNoneTagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6884610", Offset = "0x6882E10", VA = "0x186884610", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal InteractionFilterNoneTagsDataWrapper(Entity entity, InteractionFilterNoneTagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterNoneTagsDataProperties : KKBNKINFGCJ<InteractionFilterNoneTagsDataWrapper, InteractionFilterNoneTagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly MNECACGPLAM<Entity> noneTags;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x6885E20", Offset = "0x6884620", VA = "0x186885E20")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public readonly FOLGLCGBGCK<Entity> noneTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x68844C0", Offset = "0x6882CC0", VA = "0x1868844C0")]
		public InteractionFilterNoneTagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override InteractionFilterNoneTagsDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(InteractionFilterNoneTagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	public readonly struct SiblingSortOrderDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly SiblingSortOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6891540", Offset = "0x688FD40", VA = "0x186891540", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal SiblingSortOrderDataWrapper(Entity entity, SiblingSortOrderDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[Preserve]
	[CompilerGenerated]
	public class SiblingSortOrderDataProperties : KKBNKINFGCJ<SiblingSortOrderDataWrapper, SiblingSortOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public static readonly MNECACGPLAM<NJKOAFMLNJE> order;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x68859D0", Offset = "0x68841D0", VA = "0x1868859D0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public readonly FOLGLCGBGCK<NJKOAFMLNJE> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x68913F0", Offset = "0x688FBF0", VA = "0x1868913F0")]
		public SiblingSortOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override SiblingSortOrderDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(SiblingSortOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	public readonly struct ContainerGrabbableModeDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly ContainerGrabbableModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6882CF0", Offset = "0x68814F0", VA = "0x186882CF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ContainerGrabbableModeDataWrapper(Entity entity, ContainerGrabbableModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6882D90", Offset = "0x6881590", VA = "0x186882D90")]
		public GFMGJFJNBFH PONGDLDPBPP()
		{
			return default(GFMGJFJNBFH);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6882C90", Offset = "0x6881490", VA = "0x186882C90")]
		public bool DMDMPGHGPGB(GFMGJFJNBFH value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerGrabbableModeDataProperties : KKBNKINFGCJ<ContainerGrabbableModeDataWrapper, ContainerGrabbableModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public static readonly MNECACGPLAM<GFMGJFJNBFH> grabbableMode;

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x6886F10", Offset = "0x6885710", VA = "0x186886F10")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public readonly FOLGLCGBGCK<GFMGJFJNBFH> grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6882B40", Offset = "0x6881340", VA = "0x186882B40")]
		public ContainerGrabbableModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ContainerGrabbableModeDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ContainerGrabbableModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	public readonly struct CostumePieceParentCostumeDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private readonly CostumePieceParentCostumeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x68834E0", Offset = "0x6881CE0", VA = "0x1868834E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal CostumePieceParentCostumeDataWrapper(Entity entity, CostumePieceParentCostumeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	[Preserve]
	public class CostumePieceParentCostumeDataProperties : KKBNKINFGCJ<CostumePieceParentCostumeDataWrapper, CostumePieceParentCostumeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public static readonly MNECACGPLAM<Entity> parentCostume;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x68853C0", Offset = "0x6883BC0", VA = "0x1868853C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly FOLGLCGBGCK<Entity> parentCostume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6883390", Offset = "0x6881B90", VA = "0x186883390")]
		public CostumePieceParentCostumeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override CostumePieceParentCostumeDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(CostumePieceParentCostumeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	public readonly struct AuthoredUserTagReferenceBufferWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly AuthoredUserTagReferenceBufferProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6875D10", Offset = "0x6874510", VA = "0x186875D10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal AuthoredUserTagReferenceBufferWrapper(Entity entity, AuthoredUserTagReferenceBufferProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredUserTagReferenceBufferProperties : KCBEHOGCCIK<AuthoredUserTagReferenceBufferWrapper, AuthoredUserTagReferenceBuffer>
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly MNECACGPLAM<Entity> Child;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x68862F0", Offset = "0x6884AF0", VA = "0x1868862F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly FLIOGKDFLPI<AuthoredUserTagReferenceBuffer, Entity> Child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6875BC0", Offset = "0x68743C0", VA = "0x186875BC0")]
		public AuthoredUserTagReferenceBufferProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override AuthoredUserTagReferenceBufferWrapper CIOKHABNMPN(Entity entity)
		{
			return default(AuthoredUserTagReferenceBufferWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	public readonly struct SplineShapeDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly SplineShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6892500", Offset = "0x6890D00", VA = "0x186892500", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal SplineShapeDataWrapper(Entity entity, SplineShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x68925A0", Offset = "0x6890DA0", VA = "0x1868925A0")]
		public KCOEAKMOKIN IELNAKGDNNB()
		{
			return default(KCOEAKMOKIN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6892490", Offset = "0x6890C90", VA = "0x186892490")]
		public bool EFNCHHCDGNO(KCOEAKMOKIN value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[Preserve]
	[CompilerGenerated]
	public class SplineShapeDataProperties : KKBNKINFGCJ<SplineShapeDataWrapper, SplineShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly MNECACGPLAM<KCOEAKMOKIN> parameters;

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x6885750", Offset = "0x6883F50", VA = "0x186885750")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public readonly FOLGLCGBGCK<KCOEAKMOKIN> parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6892340", Offset = "0x6890B40", VA = "0x186892340")]
		public SplineShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override SplineShapeDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(SplineShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	public readonly struct TransformFlagsDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly TransformFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6893740", Offset = "0x6891F40", VA = "0x186893740", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal TransformFlagsDataWrapper(Entity entity, TransformFlagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	[Preserve]
	public class TransformFlagsDataProperties : KKBNKINFGCJ<TransformFlagsDataWrapper, TransformFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly MNECACGPLAM<EJHMPKPCBNB> transformHint;

			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly MNECACGPLAM<LHNKGKJOFLH> transformPriority;

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x6886370", Offset = "0x6884B70", VA = "0x186886370")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public readonly FOLGLCGBGCK<EJHMPKPCBNB> transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public readonly FOLGLCGBGCK<LHNKGKJOFLH> transformPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855160", VA = "0x180856960", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6893560", Offset = "0x6891D60", VA = "0x186893560")]
		public TransformFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override TransformFlagsDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(TransformFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	public readonly struct ContainerFlagsDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly ContainerFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x68829F0", Offset = "0x68811F0", VA = "0x1868829F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ContainerFlagsDataWrapper(Entity entity, ContainerFlagsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6882990", Offset = "0x6881190", VA = "0x186882990")]
		public HMOHHGDNCHA BLJFEINPOPD()
		{
			return default(HMOHHGDNCHA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6882A90", Offset = "0x6881290", VA = "0x186882A90")]
		public void KOPFOMKEHHG(HMOHHGDNCHA flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerFlagsDataProperties : KKBNKINFGCJ<ContainerFlagsDataWrapper, ContainerFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly MNECACGPLAM<HMOHHGDNCHA> flags;

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x6885C50", Offset = "0x6884450", VA = "0x186885C50")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public readonly FOLGLCGBGCK<HMOHHGDNCHA> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6882840", Offset = "0x6881040", VA = "0x186882840")]
		public ContainerFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ContainerFlagsDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ContainerFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[CompilerGenerated]
	[global::OKAAICJOLKO]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[global::COKOBOEFFNH(1)]
		public HMOHHGDNCHA flags;
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionModeDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private readonly ContainerCollisionModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public FPPNPIKLAFA collisionMode
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x68827E0", Offset = "0x6880FE0", VA = "0x1868827E0")]
			get
			{
				return default(FPPNPIKLAFA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x68826E0", Offset = "0x6880EE0", VA = "0x1868826E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ContainerCollisionModeDataWrapper(Entity entity, ContainerCollisionModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6882780", Offset = "0x6880F80", VA = "0x186882780")]
		public FPPNPIKLAFA JEEKBPELAPC()
		{
			return default(FPPNPIKLAFA);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6882680", Offset = "0x6880E80", VA = "0x186882680")]
		public bool CGOJHIKLPIF(FPPNPIKLAFA value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerCollisionModeDataProperties : KKBNKINFGCJ<ContainerCollisionModeDataWrapper, ContainerCollisionModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly MNECACGPLAM<FPPNPIKLAFA> collisionMode;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x6885270", Offset = "0x6883A70", VA = "0x186885270")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public readonly FOLGLCGBGCK<FPPNPIKLAFA> collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6882530", Offset = "0x6880D30", VA = "0x186882530")]
		public ContainerCollisionModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ContainerCollisionModeDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ContainerCollisionModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	public readonly struct InteractionFilterEntityRefDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly InteractionFilterEntityRefDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x6884420", Offset = "0x6882C20", VA = "0x186884420", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal InteractionFilterEntityRefDataWrapper(Entity entity, InteractionFilterEntityRefDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	[Preserve]
	public class InteractionFilterEntityRefDataProperties : KKBNKINFGCJ<InteractionFilterEntityRefDataWrapper, InteractionFilterEntityRefData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public static readonly MNECACGPLAM<Entity> filterEntity;

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x6885BD0", Offset = "0x68843D0", VA = "0x186885BD0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly FOLGLCGBGCK<Entity> filterEntity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x68842D0", Offset = "0x6882AD0", VA = "0x1868842D0")]
		public InteractionFilterEntityRefDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override InteractionFilterEntityRefDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(InteractionFilterEntityRefDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	public readonly struct PhysicsMaterialDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly PhysicsMaterialDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x688F9A0", Offset = "0x688E1A0", VA = "0x18688F9A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal PhysicsMaterialDataWrapper(Entity entity, PhysicsMaterialDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x688F940", Offset = "0x688E140", VA = "0x18688F940")]
		public bool EGJKPCLBNMG(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	[Preserve]
	public class PhysicsMaterialDataProperties : KKBNKINFGCJ<PhysicsMaterialDataWrapper, PhysicsMaterialData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly MNECACGPLAM<float> density;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x6885CD0", Offset = "0x68844D0", VA = "0x186885CD0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public readonly FOLGLCGBGCK<float> density;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x688F7F0", Offset = "0x688DFF0", VA = "0x18688F7F0")]
		public PhysicsMaterialDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override PhysicsMaterialDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	public readonly struct ObjectPolicyDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private readonly ObjectPolicyDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public MOIHEGBPPIH scaleRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x688EEE0", Offset = "0x688D6E0", VA = "0x18688EEE0")]
			get
			{
				return default(MOIHEGBPPIH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x688EE40", Offset = "0x688D640", VA = "0x18688EE40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ObjectPolicyDataWrapper(Entity entity, ObjectPolicyDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x688EDE0", Offset = "0x688D5E0", VA = "0x18688EDE0")]
		public ADNNGPCIEAF BLJFEINPOPD()
		{
			return default(ADNNGPCIEAF);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x688F130", Offset = "0x688D930", VA = "0x18688F130")]
		public PIHMGPGBMPI NKMHCNMDDGE()
		{
			return default(PIHMGPGBMPI);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x688F010", Offset = "0x688D810", VA = "0x18688F010")]
		public bool LEAFDFOAADD(PIHMGPGBMPI value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x688EF60", Offset = "0x688D760", VA = "0x18688EF60")]
		public void KHCDNCBEIEG(PIHMGPGBMPI flag, bool enable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x688F0D0", Offset = "0x688D8D0", VA = "0x18688F0D0")]
		public CIOMMKHJBAJ NCELNJEGJGM()
		{
			return default(CIOMMKHJBAJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x688F070", Offset = "0x688D870", VA = "0x18688F070")]
		public bool NAOIKDEJCGL(CIOMMKHJBAJ value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectPolicyDataProperties : KKBNKINFGCJ<ObjectPolicyDataWrapper, ObjectPolicyData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly MNECACGPLAM<MOIHEGBPPIH> scaleRestriction;

			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly MNECACGPLAM<PIHMGPGBMPI> userConfigurableFlags;

			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly MNECACGPLAM<CIOMMKHJBAJ> circuitsTransformBehavior;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public static readonly MNECACGPLAM<ADNNGPCIEAF> flags;

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x6886B20", Offset = "0x6885320", VA = "0x186886B20")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public readonly FOLGLCGBGCK<MOIHEGBPPIH> scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public readonly FOLGLCGBGCK<PIHMGPGBMPI> userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public readonly FOLGLCGBGCK<CIOMMKHJBAJ> circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public readonly FOLGLCGBGCK<ADNNGPCIEAF> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x8569D0", Offset = "0x8551D0", VA = "0x1808569D0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x688EAE0", Offset = "0x688D2E0", VA = "0x18688EAE0")]
		public ObjectPolicyDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ObjectPolicyDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ObjectPolicyDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[global::OKAAICJOLKO]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[global::COKOBOEFFNH(1)]
		public ADNNGPCIEAF flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[global::COKOBOEFFNH(2)]
		public MOIHEGBPPIH scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[global::COKOBOEFFNH(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	[global::OKAAICJOLKO]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[global::COKOBOEFFNH(1)]
		public ADNNGPCIEAF flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[global::COKOBOEFFNH(2)]
		public MOIHEGBPPIH scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[global::COKOBOEFFNH(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[global::OKAAICJOLKO]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[global::COKOBOEFFNH(1)]
		public ADNNGPCIEAF flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[global::COKOBOEFFNH(2)]
		public MOIHEGBPPIH scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[global::COKOBOEFFNH(3)]
		public PIHMGPGBMPI userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[TypeManager.TypeVersion(2)]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[global::OKAAICJOLKO]
	[CompilerGenerated]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[global::COKOBOEFFNH(2)]
		public MOIHEGBPPIH scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[global::COKOBOEFFNH(3)]
		public PIHMGPGBMPI userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[global::COKOBOEFFNH(1)]
		public ADNNGPCIEAF flags;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	public readonly struct SplinePointParentDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private readonly SplinePointParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6891A10", Offset = "0x6890210", VA = "0x186891A10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal SplinePointParentDataWrapper(Entity entity, SplinePointParentDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6891980", Offset = "0x6890180", VA = "0x186891980")]
		public bool BLDJLDLHBHI(LocalId value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointParentDataProperties : KKBNKINFGCJ<SplinePointParentDataWrapper, SplinePointParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B7")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public static readonly MNECACGPLAM<Entity> spline;

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x6885550", Offset = "0x6883D50", VA = "0x186885550")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public readonly FOLGLCGBGCK<Entity> spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6891830", Offset = "0x6890030", VA = "0x186891830")]
		public SplinePointParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override SplinePointParentDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(SplinePointParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	public readonly struct ReferenceGroupKindDataWrapper : COGEFBNNGIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly ReferenceGroupKindDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6890030", Offset = "0x688E830", VA = "0x186890030", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x1FEE330", Offset = "0x1FECB30", VA = "0x181FEE330", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x68757D0", Offset = "0x6873FD0", VA = "0x1868757D0")]
		internal ReferenceGroupKindDataWrapper(Entity entity, ReferenceGroupKindDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[Preserve]
	[CompilerGenerated]
	public class ReferenceGroupKindDataProperties : KKBNKINFGCJ<ReferenceGroupKindDataWrapper, ReferenceGroupKindData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public static readonly MNECACGPLAM<FAHIIHHFPKH> kind;

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x6887090", Offset = "0x6885890", VA = "0x186887090")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public readonly FOLGLCGBGCK<FAHIIHHFPKH> kind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly FFENPHHDHJB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected internal override FFENPHHDHJB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x8553C0", VA = "0x180856BC0", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x688FEE0", Offset = "0x688E6E0", VA = "0x18688FEE0")]
		public ReferenceGroupKindDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6875530", Offset = "0x6873D30", VA = "0x186875530", Slot = "18")]
		protected internal override ReferenceGroupKindDataWrapper CIOKHABNMPN(Entity entity)
		{
			return default(ReferenceGroupKindDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[CompilerGenerated]
	public static class ConfigMetadataRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly Dictionary<Type, int> enumTypeToIndex;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly (long value, string name, string tooltip)[][] enumMetadata;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x6875FA0", Offset = "0x68747A0", VA = "0x186875FA0")]
		public static (long, string, string) IHHNAPPNCBP(DOELAEOOEOB value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x6877CE0", Offset = "0x68764E0", VA = "0x186877CE0")]
		public static (long, string, string)[] MPICCLLFLCC(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	internal static class NetworkComponentRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x68873C0", Offset = "0x6885BC0", VA = "0x1868873C0")]
		public static Type[] ELJGKKAOIAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x6887420", Offset = "0x6885C20", VA = "0x186887420")]
		private static void JGBCFAKMKJN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[CompilerGenerated]
	internal static class NetworkEnumRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static (Type type, long min, long max)[] enums;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6888D40", Offset = "0x6887540", VA = "0x186888D40")]
		public static (Type, long, long)[] ELJGKKAOIAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x6888DA0", Offset = "0x68875A0", VA = "0x186888DA0")]
		private static void JGBCFAKMKJN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[MIFNEPPJGEL(MEHPOACPKMP.Application)]
	[CompilerGenerated]
	[OMGHGEFADHA(typeof(EKGDDGLGMGN), new string[] { "Registry" })]
	internal class NetworkPropertyRegistry : EKGDDGLGMGN
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private Type[] Type
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x8518F0", VA = "0x1808530F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		private int[] Offset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851090", VA = "0x180852890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private int[] Size
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851070", VA = "0x180852870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private Type[] ComponentType
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x858FC0", Offset = "0x8577C0", VA = "0x180858FC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x688E5E0", Offset = "0x688CDE0", VA = "0x18688E5E0")]
		public NetworkPropertyRegistry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x6889B60", Offset = "0x6888360", VA = "0x186889B60")]
		private void DONHJKFNBHD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[CompilerGenerated]
	internal static class PropertyProviderRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x68940C0", Offset = "0x68928C0", VA = "0x1868940C0")]
		public static Type[] ELJGKKAOIAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6894120", Offset = "0x6892920", VA = "0x186894120")]
		private static void JGBCFAKMKJN()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x68959E0", Offset = "0x68941E0", VA = "0x1868959E0")]
		public void JGBCFAKMKJN(GOMCEOHIOKI registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x68959F0", Offset = "0x68941F0", VA = "0x1868959F0")]
		private void MIKKPADLDCF(GOMCEOHIOKI registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x318B020", Offset = "0x3189820", VA = "0x18318B020")]
		private void EEGNHKAJMNJ<T>(GOMCEOHIOKI registry, [In] T value) where T : struct
		{
		}
	}
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	[Preserve]
	[CompilerGenerated]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	[Preserve]
	[CompilerGenerated]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	[Preserve]
	[CompilerGenerated]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[TypeManager.ForcedStableTypeHash(14429493078606832166uL)]
	[CompilerGenerated]
	[Preserve]
	internal struct SerializedEmbodiedData : IComponentData
	{
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 34)]
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[Preserve]
	[CompilerGenerated]
	internal struct InteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private short last;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[MIFNEPPJGEL(MEHPOACPKMP.Application)]
[OMGHGEFADHA(typeof(AOKJBAIKJNB), new string[] { "Registry" })]
internal class HDAGIFOAGKI : AOKJBAIKJNB
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public Type LFLLADIDPGL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x6894020", Offset = "0x6892820", VA = "0x186894020", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Type[] KKHILGMCGEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x68940C0", Offset = "0x68928C0", VA = "0x1868940C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public Type[] HNJFNPNOGMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x6894080", Offset = "0x6892880", VA = "0x186894080", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public (Type type, long min, long max)[] OEHACBIEAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6894090", Offset = "0x6892890", VA = "0x186894090", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x68940A0", Offset = "0x68928A0", VA = "0x1868940A0", Slot = "8")]
	public void OFBJMJOIOKH(GOMCEOHIOKI KFIBIJKCNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
	public HDAGIFOAGKI()
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
