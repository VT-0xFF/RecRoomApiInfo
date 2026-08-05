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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
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
	public class _AssemblyIndex : MLJNMKFIGMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private EENLKAGMGJE bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7A8200", Offset = "0x7A7000", VA = "0x1807A8200", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1279420", Offset = "0x1278220", VA = "0x181279420", Slot = "5")]
		public override void JHOHBHCKFCE(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5FBA480", Offset = "0x5FB9280", VA = "0x185FBA480")]
		private void PHCLPOGNBJN(JIGNBFODIDF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5FBA700", Offset = "0x5FB9500", VA = "0x185FBA700", Slot = "6")]
		public override void PPJLFIMLGNK(JIGNBFODIDF registry, [In] LCAIGHCIJNG filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7AA5C0", Offset = "0x7A93C0", VA = "0x1807AA5C0", Slot = "8")]
		public override void MFEEKKLICMI(NMNCJDKLJOJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5FBA760", Offset = "0x5FB9560", VA = "0x185FBA760")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	public readonly struct OverrideObjectNetworkIdDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly OverrideObjectNetworkIdDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5380", Offset = "0x5FB4180", VA = "0x185FB5380", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal OverrideObjectNetworkIdDataWrapper(Entity entity, OverrideObjectNetworkIdDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Preserve]
	[CompilerGenerated]
	public class OverrideObjectNetworkIdDataProperties : BPAFBLAFLMF<OverrideObjectNetworkIdDataWrapper, OverrideObjectNetworkIdData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly DJEGHLLJLPD<uint> networkIdBits;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x5FAD890", Offset = "0x5FAC690", VA = "0x185FAD890")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly CIMCLNAEFEN<uint> networkIdBits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5230", Offset = "0x5FB4030", VA = "0x185FB5230")]
		public OverrideObjectNetworkIdDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override OverrideObjectNetworkIdDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(OverrideObjectNetworkIdDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public readonly struct PersistentUserTagDataWrapper : EFLJMIKJDOL
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
			[Cpp2IlInjected.Address(RVA = "0x5FB5890", Offset = "0x5FB4690", VA = "0x185FB5890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5FB57F0", Offset = "0x5FB45F0", VA = "0x185FB57F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal PersistentUserTagDataWrapper(Entity entity, PersistentUserTagDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5950", Offset = "0x5FB4750", VA = "0x185FB5950")]
		public bool PKDNHBNEFMC(FixedList32Bytes<int> value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5FB58F0", Offset = "0x5FB46F0", VA = "0x185FB58F0")]
		public bool PJKIJHKLFMC(bool value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[Preserve]
	[CompilerGenerated]
	public class PersistentUserTagDataProperties : BPAFBLAFLMF<PersistentUserTagDataWrapper, PersistentUserTagData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly DJEGHLLJLPD<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly DJEGHLLJLPD<bool> initalizedDefaults;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x5FADA10", Offset = "0x5FAC810", VA = "0x185FADA10")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly CIMCLNAEFEN<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly CIMCLNAEFEN<bool> initalizedDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5610", Offset = "0x5FB4410", VA = "0x185FB5610")]
		public PersistentUserTagDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override PersistentUserTagDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(PersistentUserTagDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	[global::MFKEIHJECBL]
	[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
	public struct PersistentUserTagData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::MNHIBGCDOBM(1)]
		public FixedList32Bytes<int> tags;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public readonly struct LocalDeformableScaleDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LocalDeformableScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5FAD240", Offset = "0x5FAC040", VA = "0x185FAD240", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal LocalDeformableScaleDataWrapper(Entity entity, LocalDeformableScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[Preserve]
	[CompilerGenerated]
	public class LocalDeformableScaleDataProperties : BPAFBLAFLMF<LocalDeformableScaleDataWrapper, LocalDeformableScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly DJEGHLLJLPD<float3> localDeformationScale;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5FAED90", Offset = "0x5FADB90", VA = "0x185FAED90")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly CIMCLNAEFEN<float3> localDeformationScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5FAD0F0", Offset = "0x5FABEF0", VA = "0x185FAD0F0")]
		public LocalDeformableScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override LocalDeformableScaleDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(LocalDeformableScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	public readonly struct SplinePointScaleDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly SplinePointScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5FB89F0", Offset = "0x5FB77F0", VA = "0x185FB89F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal SplinePointScaleDataWrapper(Entity entity, SplinePointScaleDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8A90", Offset = "0x5FB7890", VA = "0x185FB8A90")]
		public float3 FILPDLFPHIB()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8B10", Offset = "0x5FB7910", VA = "0x185FB8B10")]
		public bool PLKBDLNEJEK(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointScaleDataProperties : BPAFBLAFLMF<SplinePointScaleDataWrapper, SplinePointScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public static readonly DJEGHLLJLPD<float3> localScale;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE2C0", Offset = "0x5FAD0C0", VA = "0x185FAE2C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly CIMCLNAEFEN<float3> localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5FB88A0", Offset = "0x5FB76A0", VA = "0x185FB88A0")]
		public SplinePointScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override SplinePointScaleDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(SplinePointScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	public readonly struct LocalUniformScaleDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly LocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5FAD6B0", Offset = "0x5FAC4B0", VA = "0x185FAD6B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal LocalUniformScaleDataWrapper(Entity entity, LocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[Preserve]
	[CompilerGenerated]
	public class LocalUniformScaleDataProperties : BPAFBLAFLMF<LocalUniformScaleDataWrapper, LocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public static readonly DJEGHLLJLPD<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE340", Offset = "0x5FAD140", VA = "0x185FAE340")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public readonly CIMCLNAEFEN<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5FAD560", Offset = "0x5FAC360", VA = "0x185FAD560")]
		public LocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override LocalUniformScaleDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(LocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	public readonly struct InteractionFilterDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly InteractionFilterDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public FixedList32Bytes<int> tags
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5FACF80", Offset = "0x5FABD80", VA = "0x185FACF80")]
			get
			{
				return default(FixedList32Bytes<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5FACDC0", Offset = "0x5FABBC0", VA = "0x185FACDC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal InteractionFilterDataWrapper(Entity entity, InteractionFilterDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5FAD000", Offset = "0x5FABE00", VA = "0x185FAD000")]
		public FixedList32Bytes<int> OGMOBNKFLKJ()
		{
			return default(FixedList32Bytes<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5FAD080", Offset = "0x5FABE80", VA = "0x185FAD080")]
		public bool PKDNHBNEFMC(FixedList32Bytes<int> value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5FACF20", Offset = "0x5FABD20", VA = "0x185FACF20")]
		public bool IAFHLEDPGNA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5FACE60", Offset = "0x5FABC60", VA = "0x185FACE60")]
		public bool GAIMKIDDHOI(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5FACEC0", Offset = "0x5FABCC0", VA = "0x185FACEC0")]
		public OPGILECLNBH GHPBGOKPGIO()
		{
			return default(OPGILECLNBH);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5FACD60", Offset = "0x5FABB60", VA = "0x185FACD60")]
		public bool BMAPPNLNLMK(OPGILECLNBH value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterDataProperties : BPAFBLAFLMF<InteractionFilterDataWrapper, InteractionFilterData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public static readonly DJEGHLLJLPD<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly DJEGHLLJLPD<bool> enabled;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly DJEGHLLJLPD<OPGILECLNBH> filterMode;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x5FADB60", Offset = "0x5FAC960", VA = "0x185FADB60")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public readonly CIMCLNAEFEN<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly CIMCLNAEFEN<bool> enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly CIMCLNAEFEN<OPGILECLNBH> filterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7AD190", Offset = "0x7ABF90", VA = "0x1807AD190", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5FACB00", Offset = "0x5FAB900", VA = "0x185FACB00")]
		public InteractionFilterDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override InteractionFilterDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(InteractionFilterDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[CompilerGenerated]
	public readonly struct ComponentSerializedVersionDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly ComponentSerializedVersionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F850", Offset = "0x5F9E650", VA = "0x185F9F850", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal ComponentSerializedVersionDataWrapper(Entity entity, ComponentSerializedVersionDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[Preserve]
	[CompilerGenerated]
	public class ComponentSerializedVersionDataProperties : BPAFBLAFLMF<ComponentSerializedVersionDataWrapper, ComponentSerializedVersionData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public static readonly DJEGHLLJLPD<FFIKLMMAOJI> version;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5FAD810", Offset = "0x5FAC610", VA = "0x185FAD810")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public readonly CIMCLNAEFEN<FFIKLMMAOJI> version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F700", Offset = "0x5F9E500", VA = "0x185F9F700")]
		public ComponentSerializedVersionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override ComponentSerializedVersionDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(ComponentSerializedVersionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	public readonly struct SplinePointOrderDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly SplinePointOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7FD0", Offset = "0x5FB6DD0", VA = "0x185FB7FD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal SplinePointOrderDataWrapper(Entity entity, SplinePointOrderDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7F70", Offset = "0x5FB6D70", VA = "0x185FB7F70")]
		public bool CPALLMLPACL(CGCPEDGLCON value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointOrderDataProperties : BPAFBLAFLMF<SplinePointOrderDataWrapper, SplinePointOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static readonly DJEGHLLJLPD<CGCPEDGLCON> order;

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5FAEE90", Offset = "0x5FADC90", VA = "0x185FAEE90")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public readonly CIMCLNAEFEN<CGCPEDGLCON> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7E20", Offset = "0x5FB6C20", VA = "0x185FB7E20")]
		public SplinePointOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override SplinePointOrderDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(SplinePointOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	public readonly struct CostumePieceSlotIndexDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly CostumePieceSlotIndexDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5FAC640", Offset = "0x5FAB440", VA = "0x185FAC640", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal CostumePieceSlotIndexDataWrapper(Entity entity, CostumePieceSlotIndexDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[Preserve]
	[CompilerGenerated]
	public class CostumePieceSlotIndexDataProperties : BPAFBLAFLMF<CostumePieceSlotIndexDataWrapper, CostumePieceSlotIndexData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly DJEGHLLJLPD<int> slotIndex;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5FADE70", Offset = "0x5FACC70", VA = "0x185FADE70")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public readonly CIMCLNAEFEN<int> slotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5FAC4F0", Offset = "0x5FAB2F0", VA = "0x185FAC4F0")]
		public CostumePieceSlotIndexDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override CostumePieceSlotIndexDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(CostumePieceSlotIndexDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	public readonly struct SerializedEmbodiedDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly SerializedEmbodiedDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7880", Offset = "0x5FB6680", VA = "0x185FB7880", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal SerializedEmbodiedDataWrapper(Entity entity, SerializedEmbodiedDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[Preserve]
	[CompilerGenerated]
	public class SerializedEmbodiedDataProperties : BPAFBLAFLMF<SerializedEmbodiedDataWrapper, SerializedEmbodiedData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class Names
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x7A8200", Offset = "0x7A7000", VA = "0x1807A8200", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5FB77F0", Offset = "0x5FB65F0", VA = "0x185FB77F0")]
		public SerializedEmbodiedDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override SerializedEmbodiedDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(SerializedEmbodiedDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	public readonly struct LocalPoseDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly LocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5FAD4C0", Offset = "0x5FAC2C0", VA = "0x185FAD4C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal LocalPoseDataWrapper(Entity entity, LocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[Preserve]
	[CompilerGenerated]
	public class LocalPoseDataProperties : BPAFBLAFLMF<LocalPoseDataWrapper, LocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public static readonly DJEGHLLJLPD<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public static readonly DJEGHLLJLPD<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE510", Offset = "0x5FAD310", VA = "0x185FAE510")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly CIMCLNAEFEN<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly CIMCLNAEFEN<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5FAD2E0", Offset = "0x5FAC0E0", VA = "0x185FAD2E0")]
		public LocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override LocalPoseDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(LocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectActiveStatusDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly ReplicatedObjectActiveStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7370", Offset = "0x5FB6170", VA = "0x185FB7370", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal ReplicatedObjectActiveStatusDataWrapper(Entity entity, ReplicatedObjectActiveStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatedObjectActiveStatusDataProperties : BPAFBLAFLMF<ReplicatedObjectActiveStatusDataWrapper, ReplicatedObjectActiveStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public static readonly DJEGHLLJLPD<bool> active;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE730", Offset = "0x5FAD530", VA = "0x185FAE730")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly CIMCLNAEFEN<bool> active;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7220", Offset = "0x5FB6020", VA = "0x185FB7220")]
		public ReplicatedObjectActiveStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override ReplicatedObjectActiveStatusDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(ReplicatedObjectActiveStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	public readonly struct SplinePointRotationDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly SplinePointRotationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8790", Offset = "0x5FB7590", VA = "0x185FB8790", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal SplinePointRotationDataWrapper(Entity entity, SplinePointRotationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8720", Offset = "0x5FB7520", VA = "0x185FB8720")]
		public quaternion EHNDAFKDPKG()
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8830", Offset = "0x5FB7630", VA = "0x185FB8830")]
		public bool PGKPNEEBDNJ(quaternion value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointRotationDataProperties : BPAFBLAFLMF<SplinePointRotationDataWrapper, SplinePointRotationData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public static readonly DJEGHLLJLPD<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x5FADD70", Offset = "0x5FACB70", VA = "0x185FADD70")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly CIMCLNAEFEN<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5FB85D0", Offset = "0x5FB73D0", VA = "0x185FB85D0")]
		public SplinePointRotationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override SplinePointRotationDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(SplinePointRotationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	public readonly struct SplinePointPositionDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly SplinePointPositionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5FB84B0", Offset = "0x5FB72B0", VA = "0x185FB84B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal SplinePointPositionDataWrapper(Entity entity, SplinePointPositionDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8550", Offset = "0x5FB7350", VA = "0x185FB8550")]
		public float3 MEAEFGFJANH()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8440", Offset = "0x5FB7240", VA = "0x185FB8440")]
		public bool CIGDLPADLPF(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointPositionDataProperties : BPAFBLAFLMF<SplinePointPositionDataWrapper, SplinePointPositionData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly DJEGHLLJLPD<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5FAD910", Offset = "0x5FAC710", VA = "0x185FAD910")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly CIMCLNAEFEN<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5FB82F0", Offset = "0x5FB70F0", VA = "0x185FB82F0")]
		public SplinePointPositionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override SplinePointPositionDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(SplinePointPositionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	public readonly struct ShapeTypeDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private readonly ShapeTypeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public HNFAPBIOGOE shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x5FB7DC0", Offset = "0x5FB6BC0", VA = "0x185FB7DC0")]
			get
			{
				return default(HNFAPBIOGOE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7D20", Offset = "0x5FB6B20", VA = "0x185FB7D20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal ShapeTypeDataWrapper(Entity entity, ShapeTypeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	[Preserve]
	public class ShapeTypeDataProperties : BPAFBLAFLMF<ShapeTypeDataWrapper, ShapeTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly DJEGHLLJLPD<HNFAPBIOGOE> shapeType;

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE070", Offset = "0x5FACE70", VA = "0x185FAE070")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public readonly CIMCLNAEFEN<HNFAPBIOGOE> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7BD0", Offset = "0x5FB69D0", VA = "0x185FB7BD0")]
		public ShapeTypeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override ShapeTypeDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(ShapeTypeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	public readonly struct PrimitiveShapeDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private readonly PrimitiveShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public MCEJPAIOHJF shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5FB6050", Offset = "0x5FB4E50", VA = "0x185FB6050")]
			get
			{
				return default(MCEJPAIOHJF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5FB0", Offset = "0x5FB4DB0", VA = "0x185FB5FB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal PrimitiveShapeDataWrapper(Entity entity, PrimitiveShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5F50", Offset = "0x5FB4D50", VA = "0x185FB5F50")]
		public MCEJPAIOHJF CHKKFABFCBE()
		{
			return default(MCEJPAIOHJF);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[Preserve]
	[CompilerGenerated]
	public class PrimitiveShapeDataProperties : BPAFBLAFLMF<PrimitiveShapeDataWrapper, PrimitiveShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly DJEGHLLJLPD<MCEJPAIOHJF> shapeType;

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE240", Offset = "0x5FAD040", VA = "0x185FAE240")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly CIMCLNAEFEN<MCEJPAIOHJF> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5E00", Offset = "0x5FB4C00", VA = "0x185FB5E00")]
		public PrimitiveShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override PrimitiveShapeDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	public readonly struct ReplicatorDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ReplicatorDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7750", Offset = "0x5FB6550", VA = "0x185FB7750", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal ReplicatorDataWrapper(Entity entity, ReplicatorDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatorDataProperties : BPAFBLAFLMF<ReplicatorDataWrapper, ReplicatorData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly DJEGHLLJLPD<Entity> Target;

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x5FAEBC0", Offset = "0x5FAD9C0", VA = "0x185FAEBC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public readonly CIMCLNAEFEN<Entity> Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7600", Offset = "0x5FB6400", VA = "0x185FB7600")]
		public ReplicatorDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override ReplicatorDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(ReplicatorDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	public readonly struct PlayerScopeDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly PlayerScopeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5D60", Offset = "0x5FB4B60", VA = "0x185FB5D60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal PlayerScopeDataWrapper(Entity entity, PlayerScopeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	[Preserve]
	public class PlayerScopeDataProperties : BPAFBLAFLMF<PlayerScopeDataWrapper, PlayerScopeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public static readonly DJEGHLLJLPD<Entity> playerScope;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x5FADCF0", Offset = "0x5FACAF0", VA = "0x185FADCF0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly CIMCLNAEFEN<Entity> playerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5C10", Offset = "0x5FB4A10", VA = "0x185FB5C10")]
		public PlayerScopeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override PlayerScopeDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(PlayerScopeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	public readonly struct EntityBundlePartDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly EntityBundlePartDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5FAC8C0", Offset = "0x5FAB6C0", VA = "0x185FAC8C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal EntityBundlePartDataWrapper(Entity entity, EntityBundlePartDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[Preserve]
	[CompilerGenerated]
	public class EntityBundlePartDataProperties : BPAFBLAFLMF<EntityBundlePartDataWrapper, EntityBundlePartData>
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public static readonly DJEGHLLJLPD<Entity> prefabRoot;

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly DJEGHLLJLPD<uint> entityBundlePartId;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE5E0", Offset = "0x5FAD3E0", VA = "0x185FAE5E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly CIMCLNAEFEN<Entity> prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly CIMCLNAEFEN<uint> entityBundlePartId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5FAC6E0", Offset = "0x5FAB4E0", VA = "0x185FAC6E0")]
		public EntityBundlePartDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override EntityBundlePartDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(EntityBundlePartDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectOwnedByPlayerDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly ReplicatedObjectOwnedByPlayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7560", Offset = "0x5FB6360", VA = "0x185FB7560", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal ReplicatedObjectOwnedByPlayerDataWrapper(Entity entity, ReplicatedObjectOwnedByPlayerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatedObjectOwnedByPlayerDataProperties : BPAFBLAFLMF<ReplicatedObjectOwnedByPlayerDataWrapper, ReplicatedObjectOwnedByPlayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly DJEGHLLJLPD<int> actorId;

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE9F0", Offset = "0x5FAD7F0", VA = "0x185FAE9F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly CIMCLNAEFEN<int> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7410", Offset = "0x5FB6210", VA = "0x185FB7410")]
		public ReplicatedObjectOwnedByPlayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override ReplicatedObjectOwnedByPlayerDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(ReplicatedObjectOwnedByPlayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	public readonly struct OMShapeContainerDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly OMShapeContainerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool canModifyWithCircuits
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x5FB4920", Offset = "0x5FB3720", VA = "0x185FB4920")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x5FB4820", Offset = "0x5FB3620", VA = "0x185FB4820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4880", Offset = "0x5FB3680", VA = "0x185FB4880", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal OMShapeContainerDataWrapper(Entity entity, OMShapeContainerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[Preserve]
	[CompilerGenerated]
	public class OMShapeContainerDataProperties : BPAFBLAFLMF<OMShapeContainerDataWrapper, OMShapeContainerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public static readonly DJEGHLLJLPD<bool> canModifyWithCircuits;

			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public static readonly DJEGHLLJLPD<bool> optimizedCollidersEnabled;

			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x5FAD750", Offset = "0x5FAC550", VA = "0x185FAD750")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly CIMCLNAEFEN<bool> canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public readonly CIMCLNAEFEN<bool> optimizedCollidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4650", Offset = "0x5FB3450", VA = "0x185FB4650")]
		public OMShapeContainerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override OMShapeContainerDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(OMShapeContainerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	[global::MFKEIHJECBL]
	[CompilerGenerated]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[global::MNHIBGCDOBM(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[global::MNHIBGCDOBM(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[global::MNHIBGCDOBM(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	public readonly struct AuthoredParentDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly AuthoredParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F660", Offset = "0x5F9E460", VA = "0x185F9F660", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal AuthoredParentDataWrapper(Entity entity, AuthoredParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredParentDataProperties : BPAFBLAFLMF<AuthoredParentDataWrapper, AuthoredParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly DJEGHLLJLPD<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE830", Offset = "0x5FAD630", VA = "0x185FAE830")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly CIMCLNAEFEN<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F510", Offset = "0x5F9E310", VA = "0x185F9F510")]
		public AuthoredParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override AuthoredParentDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(AuthoredParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	public readonly struct NavMeshGenerationDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly NavMeshGenerationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x5FAF0E0", Offset = "0x5FADEE0", VA = "0x185FAF0E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal NavMeshGenerationDataWrapper(Entity entity, NavMeshGenerationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5FAF1E0", Offset = "0x5FADFE0", VA = "0x185FAF1E0")]
		public MIHOOCPGHPC JEBNAGMMHPI()
		{
			return default(MIHOOCPGHPC);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5FAF180", Offset = "0x5FADF80", VA = "0x185FAF180")]
		public bool HDLBAEILJIG(MIHOOCPGHPC value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	[Preserve]
	public class NavMeshGenerationDataProperties : BPAFBLAFLMF<NavMeshGenerationDataWrapper, NavMeshGenerationData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public static readonly DJEGHLLJLPD<MIHOOCPGHPC> mode;

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE490", Offset = "0x5FAD290", VA = "0x185FAE490")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public readonly CIMCLNAEFEN<MIHOOCPGHPC> mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5FAEF90", Offset = "0x5FADD90", VA = "0x185FAEF90")]
		public NavMeshGenerationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override NavMeshGenerationDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	public readonly struct ContainerNameDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly ContainerNameDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5FAC1D0", Offset = "0x5FAAFD0", VA = "0x185FAC1D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal ContainerNameDataWrapper(Entity entity, ContainerNameDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x5FAC270", Offset = "0x5FAB070", VA = "0x185FAC270")]
		public FixedString64Bytes JKJHNIGCFNL()
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5FAC160", Offset = "0x5FAAF60", VA = "0x185FAC160")]
		public bool AANHBENHAHL(FixedString64Bytes value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerNameDataProperties : BPAFBLAFLMF<ContainerNameDataWrapper, ContainerNameData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public static readonly DJEGHLLJLPD<FixedString64Bytes> name;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE8B0", Offset = "0x5FAD6B0", VA = "0x185FAE8B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public readonly CIMCLNAEFEN<FixedString64Bytes> name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5FAC010", Offset = "0x5FAAE10", VA = "0x185FAC010")]
		public ContainerNameDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override ContainerNameDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(ContainerNameDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	public readonly struct ShapeConfigDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly ShapeConfigDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7AD0", Offset = "0x5FB68D0", VA = "0x185FB7AD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal ShapeConfigDataWrapper(Entity entity, ShapeConfigDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7A70", Offset = "0x5FB6870", VA = "0x185FB7A70")]
		public DLCHMDBBJIK BHAOPLKNPFB()
		{
			return default(DLCHMDBBJIK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7B70", Offset = "0x5FB6970", VA = "0x185FB7B70")]
		public bool PLECHKBODDB(DLCHMDBBJIK value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	[Preserve]
	public class ShapeConfigDataProperties : BPAFBLAFLMF<ShapeConfigDataWrapper, ShapeConfigData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public static readonly DJEGHLLJLPD<DLCHMDBBJIK> flags;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x5FAEF10", Offset = "0x5FADD10", VA = "0x185FAEF10")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public readonly CIMCLNAEFEN<DLCHMDBBJIK> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5FB7920", Offset = "0x5FB6720", VA = "0x185FB7920")]
		public ShapeConfigDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override ShapeConfigDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(ShapeConfigDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	public readonly struct ParentDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly ParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5570", Offset = "0x5FB4370", VA = "0x185FB5570", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal ParentDataWrapper(Entity entity, ParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	[Preserve]
	public class ParentDataProperties : BPAFBLAFLMF<ParentDataWrapper, ParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public static readonly DJEGHLLJLPD<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE7B0", Offset = "0x5FAD5B0", VA = "0x185FAE7B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public readonly CIMCLNAEFEN<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5420", Offset = "0x5FB4220", VA = "0x185FB5420")]
		public ParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override ParentDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(ParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	public readonly struct ContainerMassOverrideDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly ContainerMassOverrideDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x5FABF10", Offset = "0x5FAAD10", VA = "0x185FABF10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal ContainerMassOverrideDataWrapper(Entity entity, ContainerMassOverrideDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5FABFB0", Offset = "0x5FAADB0", VA = "0x185FABFB0")]
		public float OPGFCFHMNGI()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5FABEB0", Offset = "0x5FAACB0", VA = "0x185FABEB0")]
		public bool ABGLKCNCPAC(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerMassOverrideDataProperties : BPAFBLAFLMF<ContainerMassOverrideDataWrapper, ContainerMassOverrideData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly DJEGHLLJLPD<float> mass;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE1C0", Offset = "0x5FACFC0", VA = "0x185FAE1C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly CIMCLNAEFEN<float> mass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5FABD60", Offset = "0x5FAAB60", VA = "0x185FABD60")]
		public ContainerMassOverrideDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override ContainerMassOverrideDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(ContainerMassOverrideDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalPoseDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly AuthoredLocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F270", Offset = "0x5F9E070", VA = "0x185F9F270", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal AuthoredLocalPoseDataWrapper(Entity entity, AuthoredLocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[Preserve]
	[CompilerGenerated]
	public class AuthoredLocalPoseDataProperties : BPAFBLAFLMF<AuthoredLocalPoseDataWrapper, AuthoredLocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public static readonly DJEGHLLJLPD<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly DJEGHLLJLPD<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE0F0", Offset = "0x5FACEF0", VA = "0x185FAE0F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public readonly CIMCLNAEFEN<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public readonly CIMCLNAEFEN<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F090", Offset = "0x5F9DE90", VA = "0x185F9F090")]
		public AuthoredLocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override AuthoredLocalPoseDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(AuthoredLocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	public readonly struct ObjectBoardNodeDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly ObjectBoardNodeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4B50", Offset = "0x5FB3950", VA = "0x185FB4B50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal ObjectBoardNodeDataWrapper(Entity entity, ObjectBoardNodeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectBoardNodeDataProperties : BPAFBLAFLMF<ObjectBoardNodeDataWrapper, ObjectBoardNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public static readonly DJEGHLLJLPD<NetworkGuid> nodeId;

			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public static readonly DJEGHLLJLPD<NetworkGuid> graphId;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE930", Offset = "0x5FAD730", VA = "0x185FAE930")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly CIMCLNAEFEN<NetworkGuid> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly CIMCLNAEFEN<NetworkGuid> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4980", Offset = "0x5FB3780", VA = "0x185FB4980")]
		public ObjectBoardNodeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override ObjectBoardNodeDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(ObjectBoardNodeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalUniformScaleDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly AuthoredLocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F470", Offset = "0x5F9E270", VA = "0x185F9F470", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal AuthoredLocalUniformScaleDataWrapper(Entity entity, AuthoredLocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredLocalUniformScaleDataProperties : BPAFBLAFLMF<AuthoredLocalUniformScaleDataWrapper, AuthoredLocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public static readonly DJEGHLLJLPD<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE6B0", Offset = "0x5FAD4B0", VA = "0x185FAE6B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public readonly CIMCLNAEFEN<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F320", Offset = "0x5F9E120", VA = "0x185F9F320")]
		public AuthoredLocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override AuthoredLocalUniformScaleDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(AuthoredLocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	public readonly struct StandardRenderableVisualDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly StandardRenderableVisualDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public NODCJNFOCGG color
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x5FB9150", Offset = "0x5FB7F50", VA = "0x185FB9150")]
			get
			{
				return default(NODCJNFOCGG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public NHCCMKBOPPD material
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x5FB9580", Offset = "0x5FB8380", VA = "0x185FB9580")]
			get
			{
				return default(NHCCMKBOPPD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float uvScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x5FB9210", Offset = "0x5FB8010", VA = "0x185FB9210")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float3 uvOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x5FB9500", Offset = "0x5FB8300", VA = "0x185FB9500")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5FB9390", Offset = "0x5FB8190", VA = "0x185FB9390", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal StandardRenderableVisualDataWrapper(Entity entity, StandardRenderableVisualDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5FB92D0", Offset = "0x5FB80D0", VA = "0x185FB92D0")]
		public NODCJNFOCGG CKLEJDNOPPO()
		{
			return default(NODCJNFOCGG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5FB9270", Offset = "0x5FB8070", VA = "0x185FB9270")]
		public bool CKFIPEFMHFJ(NODCJNFOCGG value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5FB9330", Offset = "0x5FB8130", VA = "0x185FB9330")]
		public NHCCMKBOPPD DGDBPBNGODC()
		{
			return default(NHCCMKBOPPD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5FB91B0", Offset = "0x5FB7FB0", VA = "0x185FB91B0")]
		public bool BBOEDPONPBO(NHCCMKBOPPD value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5FB95E0", Offset = "0x5FB83E0", VA = "0x185FB95E0")]
		public float ODHNPNLGLEA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5FB94A0", Offset = "0x5FB82A0", VA = "0x185FB94A0")]
		public bool HKKDLLMHGLA(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5FB9640", Offset = "0x5FB8440", VA = "0x185FB9640")]
		public float3 OMOMOAGODMO()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5FB9430", Offset = "0x5FB8230", VA = "0x185FB9430")]
		public bool HBKIGEJMBEH(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	[Preserve]
	public class StandardRenderableVisualDataProperties : BPAFBLAFLMF<StandardRenderableVisualDataWrapper, StandardRenderableVisualData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public static readonly DJEGHLLJLPD<NODCJNFOCGG> color;

			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public static readonly DJEGHLLJLPD<NHCCMKBOPPD> material;

			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public static readonly DJEGHLLJLPD<float> uvScale;

			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public static readonly DJEGHLLJLPD<float3> uvOffset;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x5FAEC40", Offset = "0x5FADA40", VA = "0x185FAEC40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly CIMCLNAEFEN<NODCJNFOCGG> color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly CIMCLNAEFEN<NHCCMKBOPPD> material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public readonly CIMCLNAEFEN<float> uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public readonly CIMCLNAEFEN<float3> uvOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x7AD1F0", Offset = "0x7ABFF0", VA = "0x1807AD1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8E60", Offset = "0x5FB7C60", VA = "0x185FB8E60")]
		public StandardRenderableVisualDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override StandardRenderableVisualDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionLayerDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly ContainerCollisionLayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB3A0", Offset = "0x5FAA1A0", VA = "0x185FAB3A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal ContainerCollisionLayerDataWrapper(Entity entity, ContainerCollisionLayerDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB340", Offset = "0x5FAA140", VA = "0x185FAB340")]
		public HIDCIFMCKAM BHEOOBHPLKI()
		{
			return default(HIDCIFMCKAM);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB440", Offset = "0x5FAA240", VA = "0x185FAB440")]
		public bool HKDNEFKAHPP(HIDCIFMCKAM value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerCollisionLayerDataProperties : BPAFBLAFLMF<ContainerCollisionLayerDataWrapper, ContainerCollisionLayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly DJEGHLLJLPD<HIDCIFMCKAM> collisionLayer;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x5FADEF0", Offset = "0x5FACCF0", VA = "0x185FADEF0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly CIMCLNAEFEN<HIDCIFMCKAM> collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB1F0", Offset = "0x5FA9FF0", VA = "0x185FAB1F0")]
		public ContainerCollisionLayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override ContainerCollisionLayerDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(ContainerCollisionLayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	public readonly struct ContainerGrabbableModeDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly ContainerGrabbableModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5FABC60", Offset = "0x5FAAA60", VA = "0x185FABC60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal ContainerGrabbableModeDataWrapper(Entity entity, ContainerGrabbableModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5FABC00", Offset = "0x5FAAA00", VA = "0x185FABC00")]
		public HLOOMFKOIJH EGKOAFNIEAP()
		{
			return default(HLOOMFKOIJH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5FABD00", Offset = "0x5FAAB00", VA = "0x185FABD00")]
		public bool LNDEDINMKNA(HLOOMFKOIJH value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerGrabbableModeDataProperties : BPAFBLAFLMF<ContainerGrabbableModeDataWrapper, ContainerGrabbableModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public static readonly DJEGHLLJLPD<HLOOMFKOIJH> grabbableMode;

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x5FAEE10", Offset = "0x5FADC10", VA = "0x185FAEE10")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public readonly CIMCLNAEFEN<HLOOMFKOIJH> grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5FABAB0", Offset = "0x5FAA8B0", VA = "0x185FABAB0")]
		public ContainerGrabbableModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override ContainerGrabbableModeDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(ContainerGrabbableModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[CompilerGenerated]
	public readonly struct CostumePieceParentCostumeDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly CostumePieceParentCostumeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5FAC450", Offset = "0x5FAB250", VA = "0x185FAC450", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal CostumePieceParentCostumeDataWrapper(Entity entity, CostumePieceParentCostumeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	[Preserve]
	public class CostumePieceParentCostumeDataProperties : BPAFBLAFLMF<CostumePieceParentCostumeDataWrapper, CostumePieceParentCostumeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public static readonly DJEGHLLJLPD<Entity> parentCostume;

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x5FADAE0", Offset = "0x5FAC8E0", VA = "0x185FADAE0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public readonly CIMCLNAEFEN<Entity> parentCostume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5FAC300", Offset = "0x5FAB100", VA = "0x185FAC300")]
		public CostumePieceParentCostumeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override CostumePieceParentCostumeDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(CostumePieceParentCostumeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	public readonly struct SplineShapeDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly SplineShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8D50", Offset = "0x5FB7B50", VA = "0x185FB8D50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal SplineShapeDataWrapper(Entity entity, SplineShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8CD0", Offset = "0x5FB7AD0", VA = "0x185FB8CD0")]
		public CECJBHNPNAC DIJMEILOMDF()
		{
			return default(CECJBHNPNAC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8DF0", Offset = "0x5FB7BF0", VA = "0x185FB8DF0")]
		public bool PLKFDJLPGIL(CECJBHNPNAC value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[Preserve]
	[CompilerGenerated]
	public class SplineShapeDataProperties : BPAFBLAFLMF<SplineShapeDataWrapper, SplineShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly DJEGHLLJLPD<CECJBHNPNAC> parameters;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x5FADDF0", Offset = "0x5FACBF0", VA = "0x185FADDF0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public readonly CIMCLNAEFEN<CECJBHNPNAC> parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8B80", Offset = "0x5FB7980", VA = "0x185FB8B80")]
		public SplineShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override SplineShapeDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(SplineShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CompilerGenerated]
	public readonly struct TransformFlagsDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly TransformFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5FB98A0", Offset = "0x5FB86A0", VA = "0x185FB98A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal TransformFlagsDataWrapper(Entity entity, TransformFlagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[Preserve]
	[CompilerGenerated]
	public class TransformFlagsDataProperties : BPAFBLAFLMF<TransformFlagsDataWrapper, TransformFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public static readonly DJEGHLLJLPD<LDKNHNPJBMO> transformHint;

			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public static readonly DJEGHLLJLPD<FKPJHEDNGFM> transformPriority;

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x5FAE3C0", Offset = "0x5FAD1C0", VA = "0x185FAE3C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public readonly CIMCLNAEFEN<LDKNHNPJBMO> transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public readonly CIMCLNAEFEN<FKPJHEDNGFM> transformPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x7AD1D0", Offset = "0x7ABFD0", VA = "0x1807AD1D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5FB96C0", Offset = "0x5FB84C0", VA = "0x185FB96C0")]
		public TransformFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override TransformFlagsDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(TransformFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	public readonly struct ContainerFlagsDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly ContainerFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB960", Offset = "0x5FAA760", VA = "0x185FAB960", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal ContainerFlagsDataWrapper(Entity entity, ContainerFlagsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB900", Offset = "0x5FAA700", VA = "0x185FAB900")]
		public NONJHGAANGP BHAOPLKNPFB()
		{
			return default(NONJHGAANGP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x5FABA00", Offset = "0x5FAA800", VA = "0x185FABA00")]
		public void KBOEKJMKIPC(NONJHGAANGP flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerFlagsDataProperties : BPAFBLAFLMF<ContainerFlagsDataWrapper, ContainerFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public static readonly DJEGHLLJLPD<NONJHGAANGP> flags;

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x5FADF70", Offset = "0x5FACD70", VA = "0x185FADF70")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly CIMCLNAEFEN<NONJHGAANGP> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB7B0", Offset = "0x5FAA5B0", VA = "0x185FAB7B0")]
		public ContainerFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override ContainerFlagsDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(ContainerFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[global::MFKEIHJECBL]
	[CompilerGenerated]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[global::MNHIBGCDOBM(1)]
		public NONJHGAANGP flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionModeDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly ContainerCollisionModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public KHCGBLHLHMN collisionMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x5FAB6F0", Offset = "0x5FAA4F0", VA = "0x185FAB6F0")]
			get
			{
				return default(KHCGBLHLHMN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB650", Offset = "0x5FAA450", VA = "0x185FAB650", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal ContainerCollisionModeDataWrapper(Entity entity, ContainerCollisionModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB5F0", Offset = "0x5FAA3F0", VA = "0x185FAB5F0")]
		public KHCGBLHLHMN DINHHMHMLCJ()
		{
			return default(KHCGBLHLHMN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB750", Offset = "0x5FAA550", VA = "0x185FAB750")]
		public bool GOOGGCFMEBK(KHCGBLHLHMN value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerCollisionModeDataProperties : BPAFBLAFLMF<ContainerCollisionModeDataWrapper, ContainerCollisionModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public static readonly DJEGHLLJLPD<KHCGBLHLHMN> collisionMode;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x5FAD990", Offset = "0x5FAC790", VA = "0x185FAD990")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly CIMCLNAEFEN<KHCGBLHLHMN> collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5FAB4A0", Offset = "0x5FAA2A0", VA = "0x185FAB4A0")]
		public ContainerCollisionModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override ContainerCollisionModeDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(ContainerCollisionModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	public readonly struct PhysicsMaterialDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly PhysicsMaterialDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5B70", Offset = "0x5FB4970", VA = "0x185FB5B70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal PhysicsMaterialDataWrapper(Entity entity, PhysicsMaterialDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5B10", Offset = "0x5FB4910", VA = "0x185FB5B10")]
		public bool CGJNDDIGALL(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	[Preserve]
	public class PhysicsMaterialDataProperties : BPAFBLAFLMF<PhysicsMaterialDataWrapper, PhysicsMaterialData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public static readonly DJEGHLLJLPD<float> density;

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x5FADFF0", Offset = "0x5FACDF0", VA = "0x185FADFF0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public readonly CIMCLNAEFEN<float> density;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5FB59C0", Offset = "0x5FB47C0", VA = "0x185FB59C0")]
		public PhysicsMaterialDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override PhysicsMaterialDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	public readonly struct ObjectPolicyDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly ObjectPolicyDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public IBBOMFHEPLG scaleRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x5FB50F0", Offset = "0x5FB3EF0", VA = "0x185FB50F0")]
			get
			{
				return default(IBBOMFHEPLG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4F40", Offset = "0x5FB3D40", VA = "0x185FB4F40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal ObjectPolicyDataWrapper(Entity entity, ObjectPolicyDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4EE0", Offset = "0x5FB3CE0", VA = "0x185FB4EE0")]
		public BJHBALEABPN BHAOPLKNPFB()
		{
			return default(BJHBALEABPN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4FE0", Offset = "0x5FB3DE0", VA = "0x185FB4FE0")]
		public HJHFJNCLMIG GOJPCAFEOKI()
		{
			return default(HJHFJNCLMIG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5040", Offset = "0x5FB3E40", VA = "0x185FB5040")]
		public void IAKDDLDJLAH(HJHFJNCLMIG flag, bool enable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5FB5170", Offset = "0x5FB3F70", VA = "0x185FB5170")]
		public ADOEKHBDHCN PJOOOEONCHL()
		{
			return default(ADOEKHBDHCN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5FB51D0", Offset = "0x5FB3FD0", VA = "0x185FB51D0")]
		public bool POCOEENEMFA(ADOEKHBDHCN value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectPolicyDataProperties : BPAFBLAFLMF<ObjectPolicyDataWrapper, ObjectPolicyData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public static readonly DJEGHLLJLPD<IBBOMFHEPLG> scaleRestriction;

			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly DJEGHLLJLPD<HJHFJNCLMIG> userConfigurableFlags;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly DJEGHLLJLPD<ADOEKHBDHCN> circuitsTransformBehavior;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly DJEGHLLJLPD<BJHBALEABPN> flags;

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x5FAEA70", Offset = "0x5FAD870", VA = "0x185FAEA70")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public readonly CIMCLNAEFEN<IBBOMFHEPLG> scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public readonly CIMCLNAEFEN<HJHFJNCLMIG> userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public readonly CIMCLNAEFEN<ADOEKHBDHCN> circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public readonly CIMCLNAEFEN<BJHBALEABPN> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x7AD1F0", Offset = "0x7ABFF0", VA = "0x1807AD1F0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4BF0", Offset = "0x5FB39F0", VA = "0x185FB4BF0")]
		public ObjectPolicyDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override ObjectPolicyDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(ObjectPolicyDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[global::MFKEIHJECBL]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[global::MNHIBGCDOBM(1)]
		public BJHBALEABPN flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[global::MNHIBGCDOBM(2)]
		public IBBOMFHEPLG scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[global::MNHIBGCDOBM(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[CompilerGenerated]
	[global::MFKEIHJECBL]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		[global::MNHIBGCDOBM(1)]
		public BJHBALEABPN flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		[global::MNHIBGCDOBM(2)]
		public IBBOMFHEPLG scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[global::MNHIBGCDOBM(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	[global::MFKEIHJECBL]
	[CompilerGenerated]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[global::MNHIBGCDOBM(1)]
		public BJHBALEABPN flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[global::MNHIBGCDOBM(2)]
		public IBBOMFHEPLG scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[global::MNHIBGCDOBM(3)]
		public HJHFJNCLMIG userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[TypeManager.TypeVersion(2)]
	[global::MFKEIHJECBL]
	[CompilerGenerated]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		[global::MNHIBGCDOBM(2)]
		public IBBOMFHEPLG scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		[global::MNHIBGCDOBM(3)]
		public HJHFJNCLMIG userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[global::MNHIBGCDOBM(1)]
		public BJHBALEABPN flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	public readonly struct SplinePointParentDataWrapper : EFLJMIKJDOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly SplinePointParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5FB81C0", Offset = "0x5FB6FC0", VA = "0x185FB81C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x1D77130", Offset = "0x1D75F30", VA = "0x181D77130", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F310", Offset = "0x5F9E110", VA = "0x185F9F310")]
		internal SplinePointParentDataWrapper(Entity entity, SplinePointParentDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8260", Offset = "0x5FB7060", VA = "0x185FB8260")]
		public bool HFMAHBNLNMD(LocalId value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointParentDataProperties : BPAFBLAFLMF<SplinePointParentDataWrapper, SplinePointParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public static readonly DJEGHLLJLPD<Entity> spline;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x5FADC70", Offset = "0x5FACA70", VA = "0x185FADC70")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public readonly CIMCLNAEFEN<Entity> spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly DCNLFJJFHMC[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected internal override DCNLFJJFHMC[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x7A8220", Offset = "0x7A7020", VA = "0x1807A8220", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5FB8070", Offset = "0x5FB6E70", VA = "0x185FB8070")]
		public SplinePointParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F070", Offset = "0x5F9DE70", VA = "0x185F9F070", Slot = "16")]
		protected internal override SplinePointParentDataWrapper OBPCNBJJCHL(Entity entity)
		{
			return default(SplinePointParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	public static class ConfigMetadataRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private static readonly Dictionary<Type, int> enumTypeToIndex;

		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private static readonly (long value, string name, string tooltip)[][] enumMetadata;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5F9FA30", Offset = "0x5F9E830", VA = "0x185F9FA30")]
		public static (long, string, string) POFBOHMOGGO(EGPFMLCEFJD value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F8F0", Offset = "0x5F9E6F0", VA = "0x185F9F8F0")]
		public static (long, string, string)[] FCOKOHCJCPI(Type type)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	internal static class NetworkComponentRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x5FAC960", Offset = "0x5FAB760", VA = "0x185FAC960")]
		public static Type[] DEONKFEHFIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5FAF240", Offset = "0x5FAE040", VA = "0x185FAF240")]
		private static void NLHDMBJLIGN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	internal static class NetworkEnumRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private static (Type type, long min, long max)[] enums;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5FACAA0", Offset = "0x5FAB8A0", VA = "0x185FACAA0")]
		public static (Type, long, long)[] DEONKFEHFIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5FB0410", Offset = "0x5FAF210", VA = "0x185FB0410")]
		private static void NLHDMBJLIGN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	[PFENABFDEFA(DCCNCNLIDJL.Application)]
	[HLLKJAAFIAG(typeof(OMONIPPBPAI), new string[] { "Registry" })]
	internal class NetworkPropertyRegistry : OMONIPPBPAI
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private Type[] Type
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x7A8210", Offset = "0x7A7010", VA = "0x1807A8210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private int[] Offset
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x7A81C0", Offset = "0x7A6FC0", VA = "0x1807A81C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private int[] Size
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x7A81D0", Offset = "0x7A6FD0", VA = "0x1807A81D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private Type[] ComponentType
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x7A81E0", Offset = "0x7A6FE0", VA = "0x1807A81E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5FB4630", Offset = "0x5FB3430", VA = "0x185FB4630")]
		public NetworkPropertyRegistry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x5FB1030", Offset = "0x5FAFE30", VA = "0x185FB1030")]
		private void LGLPKGKFPFE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	internal static class PropertyProviderRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static Type[] types;

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x5FAC9E0", Offset = "0x5FAB7E0", VA = "0x185FAC9E0")]
		public static Type[] DEONKFEHFIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x5FB60B0", Offset = "0x5FB4EB0", VA = "0x185FB60B0")]
		private static void NLHDMBJLIGN()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x5FBA470", Offset = "0x5FB9270", VA = "0x185FBA470")]
		public void NLHDMBJLIGN(NMNCJDKLJOJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x5FB9940", Offset = "0x5FB8740", VA = "0x185FB9940")]
		private void KAPDHHCPLAO(NMNCJDKLJOJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x2C6A970", Offset = "0x2C69770", VA = "0x182C6A970")]
		private void KLENLFDIHOE<T>(NMNCJDKLJOJ registry, [In] T value) where T : struct
		{
		}
	}
}
namespace RecRoom.DataLayer.Tombstoned
{
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	[Preserve]
	[TypeManager.ForcedStableTypeHash(15191719635551116065uL)]
	internal struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6372660366488563574uL)]
	[Preserve]
	internal struct ContainerCollidesWithData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int last;
	}
	[StructLayout((LayoutKind)2, Pack = 1, Size = 4)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8377031472968749431uL)]
	[Preserve]
	internal struct GizmoData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int last;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[HLLKJAAFIAG(typeof(CEAEDLNEBFM), new string[] { "Registry" })]
[PFENABFDEFA(DCCNCNLIDJL.Application)]
internal class HFBEGDOHIKM : CEAEDLNEBFM
{
	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Type GLGDECDBOLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x5FACA40", Offset = "0x5FAB840", VA = "0x185FACA40", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Type[] NLCCBNNOOJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x5FAC9E0", Offset = "0x5FAB7E0", VA = "0x185FAC9E0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public Type[] BAIDHKHHEJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x5FAC960", Offset = "0x5FAB760", VA = "0x185FAC960", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public (Type type, long min, long max)[] KBINOLFEMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5FACAA0", Offset = "0x5FAB8A0", VA = "0x185FACAA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5FAC9C0", Offset = "0x5FAB7C0", VA = "0x185FAC9C0", Slot = "8")]
	public void NAMEGHEOJLO(NMNCJDKLJOJ MPEOGFCLGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
	public HFBEGDOHIKM()
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
