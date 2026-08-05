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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
		[Cpp2IlInjected.Address(RVA = "0x7EC840", Offset = "0x7EB240", VA = "0x1807EC840")]
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
	public class _AssemblyIndex : JFIBNGDIICO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private LMAJIBLOEFA bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AA0", Offset = "0x7C44A0", VA = "0x1807C5AA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1393310", Offset = "0x1391D10", VA = "0x181393310", Slot = "5")]
		public override void HPCPHMIICDG(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x62FD810", Offset = "0x62FC210", VA = "0x1862FD810")]
		private void BDLNLNECOOJ(DBBHKBEGOEB registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x62FDA90", Offset = "0x62FC490", VA = "0x1862FDA90", Slot = "6")]
		public override void ILFDKCPJAHD(DBBHKBEGOEB registry, [In] GADFEOAAHAK filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "8")]
		public override void OOPDCFDDFOD(MDGGPHKAOOJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x62FDAF0", Offset = "0x62FC4F0", VA = "0x1862FDAF0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	public readonly struct OverrideObjectNetworkIdDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly OverrideObjectNetworkIdDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x62F78E0", Offset = "0x62F62E0", VA = "0x1862F78E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal OverrideObjectNetworkIdDataWrapper(Entity entity, OverrideObjectNetworkIdDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Preserve]
	[CompilerGenerated]
	public class OverrideObjectNetworkIdDataProperties : IAOJJHMNOHP<OverrideObjectNetworkIdDataWrapper, OverrideObjectNetworkIdData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly ICAFADEJOLA<uint> networkIdBits;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x62EF2E0", Offset = "0x62EDCE0", VA = "0x1862EF2E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly CHMNJBFIOJP<uint> networkIdBits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x62F7790", Offset = "0x62F6190", VA = "0x1862F7790")]
		public OverrideObjectNetworkIdDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override OverrideObjectNetworkIdDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(OverrideObjectNetworkIdDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public readonly struct PersistentUserTagDataWrapper : BMBGJEDJJKC
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
			[Cpp2IlInjected.Address(RVA = "0x62F7EC0", Offset = "0x62F68C0", VA = "0x1862F7EC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x62F7E20", Offset = "0x62F6820", VA = "0x1862F7E20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal PersistentUserTagDataWrapper(Entity entity, PersistentUserTagDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x62F7D50", Offset = "0x62F6750", VA = "0x1862F7D50")]
		public bool BIKFPANLNHJ(FixedList32Bytes<int> value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x62F7DC0", Offset = "0x62F67C0", VA = "0x1862F7DC0")]
		public bool BJFLIOBCIDF(bool value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[Preserve]
	public class PersistentUserTagDataProperties : IAOJJHMNOHP<PersistentUserTagDataWrapper, PersistentUserTagData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly ICAFADEJOLA<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly ICAFADEJOLA<bool> initalizedDefaults;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x62EF460", Offset = "0x62EDE60", VA = "0x1862EF460")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly CHMNJBFIOJP<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly CHMNJBFIOJP<bool> initalizedDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AC0", Offset = "0x7C44C0", VA = "0x1807C5AC0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x62F7B70", Offset = "0x62F6570", VA = "0x1862F7B70")]
		public PersistentUserTagDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override PersistentUserTagDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(PersistentUserTagDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	[global::OCOJMMGMPOH]
	[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
	public struct PersistentUserTagData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::GBDNJDNNBCG(1)]
		public FixedList32Bytes<int> tags;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public readonly struct LocalDeformableScaleDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LocalDeformableScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x62EEBC0", Offset = "0x62ED5C0", VA = "0x1862EEBC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal LocalDeformableScaleDataWrapper(Entity entity, LocalDeformableScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[Preserve]
	[CompilerGenerated]
	public class LocalDeformableScaleDataProperties : IAOJJHMNOHP<LocalDeformableScaleDataWrapper, LocalDeformableScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly ICAFADEJOLA<float3> localDeformationScale;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x62F09E0", Offset = "0x62EF3E0", VA = "0x1862F09E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly CHMNJBFIOJP<float3> localDeformationScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x62EEA70", Offset = "0x62ED470", VA = "0x1862EEA70")]
		public LocalDeformableScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override LocalDeformableScaleDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(LocalDeformableScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
	[global::OCOJMMGMPOH]
	public struct LocalDeformableScaleData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[global::GBDNJDNNBCG(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public readonly struct SplinePointScaleDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly SplinePointScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x62FB5A0", Offset = "0x62F9FA0", VA = "0x1862FB5A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal SplinePointScaleDataWrapper(Entity entity, SplinePointScaleDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x62FB640", Offset = "0x62FA040", VA = "0x1862FB640")]
		public float3 POCINEIPOCN()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x62FB530", Offset = "0x62F9F30", VA = "0x1862FB530")]
		public bool AMGFBBOOFBI(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointScaleDataProperties : IAOJJHMNOHP<SplinePointScaleDataWrapper, SplinePointScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly ICAFADEJOLA<float3> localScale;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x62EFF10", Offset = "0x62EE910", VA = "0x1862EFF10")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly CHMNJBFIOJP<float3> localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x62FB3E0", Offset = "0x62F9DE0", VA = "0x1862FB3E0")]
		public SplinePointScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override SplinePointScaleDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(SplinePointScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	public readonly struct LocalUniformScaleDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly LocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x62EF030", Offset = "0x62EDA30", VA = "0x1862EF030", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal LocalUniformScaleDataWrapper(Entity entity, LocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	[Preserve]
	public class LocalUniformScaleDataProperties : IAOJJHMNOHP<LocalUniformScaleDataWrapper, LocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly ICAFADEJOLA<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x62EFF90", Offset = "0x62EE990", VA = "0x1862EFF90")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly CHMNJBFIOJP<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x62EEEE0", Offset = "0x62ED8E0", VA = "0x1862EEEE0")]
		public LocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override LocalUniformScaleDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(LocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public readonly struct InteractionFilterDataWrapper : BMBGJEDJJKC
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
			[Cpp2IlInjected.Address(RVA = "0x62EE750", Offset = "0x62ED150", VA = "0x1862EE750")]
			get
			{
				return default(FixedList32Bytes<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x62EE890", Offset = "0x62ED290", VA = "0x1862EE890", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal InteractionFilterDataWrapper(Entity entity, InteractionFilterDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x62EE9F0", Offset = "0x62ED3F0", VA = "0x1862EE9F0")]
		public FixedList32Bytes<int> LGDFDPIFBKM()
		{
			return default(FixedList32Bytes<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x62EE6E0", Offset = "0x62ED0E0", VA = "0x1862EE6E0")]
		public bool BIKFPANLNHJ(FixedList32Bytes<int> value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x62EE830", Offset = "0x62ED230", VA = "0x1862EE830")]
		public bool ENPHHNNDNBP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x62EE7D0", Offset = "0x62ED1D0", VA = "0x1862EE7D0")]
		public bool EEKCLGPFNPI(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x62EE990", Offset = "0x62ED390", VA = "0x1862EE990")]
		public DCBCIIIJMJG KDNHHENOCAB()
		{
			return default(DCBCIIIJMJG);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x62EE930", Offset = "0x62ED330", VA = "0x1862EE930")]
		public bool HDKHCIHKAOP(DCBCIIIJMJG value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterDataProperties : IAOJJHMNOHP<InteractionFilterDataWrapper, InteractionFilterData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly ICAFADEJOLA<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly ICAFADEJOLA<bool> enabled;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly ICAFADEJOLA<DCBCIIIJMJG> filterMode;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x62EF5B0", Offset = "0x62EDFB0", VA = "0x1862EF5B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly CHMNJBFIOJP<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly CHMNJBFIOJP<bool> enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly CHMNJBFIOJP<DCBCIIIJMJG> filterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AB0", Offset = "0x7C44B0", VA = "0x1807C5AB0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x62EE480", Offset = "0x62ECE80", VA = "0x1862EE480")]
		public InteractionFilterDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override InteractionFilterDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(InteractionFilterDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	public readonly struct ComponentSerializedVersionDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly ComponentSerializedVersionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x62E1180", Offset = "0x62DFB80", VA = "0x1862E1180", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal ComponentSerializedVersionDataWrapper(Entity entity, ComponentSerializedVersionDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	[Preserve]
	public class ComponentSerializedVersionDataProperties : IAOJJHMNOHP<ComponentSerializedVersionDataWrapper, ComponentSerializedVersionData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly ICAFADEJOLA<ILIKIMFHOAD> version;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x62EF260", Offset = "0x62EDC60", VA = "0x1862EF260")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public readonly CHMNJBFIOJP<ILIKIMFHOAD> version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x62E1030", Offset = "0x62DFA30", VA = "0x1862E1030")]
		public ComponentSerializedVersionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override ComponentSerializedVersionDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(ComponentSerializedVersionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public readonly struct ToolCleanupSettingsDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly ToolCleanupSettingsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x62FC4A0", Offset = "0x62FAEA0", VA = "0x1862FC4A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal ToolCleanupSettingsDataWrapper(Entity entity, ToolCleanupSettingsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x62FC540", Offset = "0x62FAF40", VA = "0x1862FC540")]
		public float HJMKGGEPHGJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x62FC3E0", Offset = "0x62FADE0", VA = "0x1862FC3E0")]
		public bool BJMJMFIKLPP(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x62FC440", Offset = "0x62FAE40", VA = "0x1862FC440")]
		public NDNBPFJDLKH EFHBMGHNOPE()
		{
			return default(NDNBPFJDLKH);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x62FC5A0", Offset = "0x62FAFA0", VA = "0x1862FC5A0")]
		public void OILKMBFOLDE(NDNBPFJDLKH flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	[Preserve]
	public class ToolCleanupSettingsDataProperties : IAOJJHMNOHP<ToolCleanupSettingsDataWrapper, ToolCleanupSettingsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly ICAFADEJOLA<float> delay;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly ICAFADEJOLA<NDNBPFJDLKH> toolCleanupFlags;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x62EF190", Offset = "0x62EDB90", VA = "0x1862EF190")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly CHMNJBFIOJP<float> delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly CHMNJBFIOJP<NDNBPFJDLKH> toolCleanupFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AC0", Offset = "0x7C44C0", VA = "0x1807C5AC0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x62FC200", Offset = "0x62FAC00", VA = "0x1862FC200")]
		public ToolCleanupSettingsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override ToolCleanupSettingsDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	public readonly struct SplinePointOrderDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly SplinePointOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x62FAB10", Offset = "0x62F9510", VA = "0x1862FAB10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal SplinePointOrderDataWrapper(Entity entity, SplinePointOrderDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x62FAAB0", Offset = "0x62F94B0", VA = "0x1862FAAB0")]
		public bool BMGNOBNNNEK(DENIDLPPMLE value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointOrderDataProperties : IAOJJHMNOHP<SplinePointOrderDataWrapper, SplinePointOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly ICAFADEJOLA<DENIDLPPMLE> order;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x62F0AE0", Offset = "0x62EF4E0", VA = "0x1862F0AE0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly CHMNJBFIOJP<DENIDLPPMLE> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x62FA960", Offset = "0x62F9360", VA = "0x1862FA960")]
		public SplinePointOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override SplinePointOrderDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(SplinePointOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public readonly struct CostumePieceSlotIndexDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly CostumePieceSlotIndexDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x62EE160", Offset = "0x62ECB60", VA = "0x1862EE160", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal CostumePieceSlotIndexDataWrapper(Entity entity, CostumePieceSlotIndexDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[Preserve]
	[CompilerGenerated]
	public class CostumePieceSlotIndexDataProperties : IAOJJHMNOHP<CostumePieceSlotIndexDataWrapper, CostumePieceSlotIndexData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly ICAFADEJOLA<int> slotIndex;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x62EF940", Offset = "0x62EE340", VA = "0x1862EF940")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly CHMNJBFIOJP<int> slotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x62EE010", Offset = "0x62ECA10", VA = "0x1862EE010")]
		public CostumePieceSlotIndexDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override CostumePieceSlotIndexDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(CostumePieceSlotIndexDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	public readonly struct SerializedEmbodiedDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly SerializedEmbodiedDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x62FA1D0", Offset = "0x62F8BD0", VA = "0x1862FA1D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal SerializedEmbodiedDataWrapper(Entity entity, SerializedEmbodiedDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	[Preserve]
	public class SerializedEmbodiedDataProperties : IAOJJHMNOHP<SerializedEmbodiedDataWrapper, SerializedEmbodiedData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Names
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AA0", Offset = "0x7C44A0", VA = "0x1807C5AA0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x62FA140", Offset = "0x62F8B40", VA = "0x1862FA140")]
		public SerializedEmbodiedDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override SerializedEmbodiedDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(SerializedEmbodiedDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	public readonly struct LocalPoseDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly LocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x62EEE40", Offset = "0x62ED840", VA = "0x1862EEE40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal LocalPoseDataWrapper(Entity entity, LocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[Preserve]
	[CompilerGenerated]
	public class LocalPoseDataProperties : IAOJJHMNOHP<LocalPoseDataWrapper, LocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public static readonly ICAFADEJOLA<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public static readonly ICAFADEJOLA<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x62F0160", Offset = "0x62EEB60", VA = "0x1862F0160")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CHMNJBFIOJP<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly CHMNJBFIOJP<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AC0", Offset = "0x7C44C0", VA = "0x1807C5AC0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x62EEC60", Offset = "0x62ED660", VA = "0x1862EEC60")]
		public LocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override LocalPoseDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(LocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectActiveStatusDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly ReplicatedObjectActiveStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x62F9AD0", Offset = "0x62F84D0", VA = "0x1862F9AD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal ReplicatedObjectActiveStatusDataWrapper(Entity entity, ReplicatedObjectActiveStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatedObjectActiveStatusDataProperties : IAOJJHMNOHP<ReplicatedObjectActiveStatusDataWrapper, ReplicatedObjectActiveStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public static readonly ICAFADEJOLA<bool> active;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x62F0380", Offset = "0x62EED80", VA = "0x1862F0380")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly CHMNJBFIOJP<bool> active;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x62F9980", Offset = "0x62F8380", VA = "0x1862F9980")]
		public ReplicatedObjectActiveStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override ReplicatedObjectActiveStatusDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(ReplicatedObjectActiveStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	public readonly struct SplinePointRotationDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly SplinePointRotationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x62FB260", Offset = "0x62F9C60", VA = "0x1862FB260", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal SplinePointRotationDataWrapper(Entity entity, SplinePointRotationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x62FB300", Offset = "0x62F9D00", VA = "0x1862FB300")]
		public quaternion KLEPMPAMBOE()
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x62FB370", Offset = "0x62F9D70", VA = "0x1862FB370")]
		public bool NMLNKJFAHDC(quaternion value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointRotationDataProperties : IAOJJHMNOHP<SplinePointRotationDataWrapper, SplinePointRotationData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly ICAFADEJOLA<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x62EF7C0", Offset = "0x62EE1C0", VA = "0x1862EF7C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly CHMNJBFIOJP<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x62FB110", Offset = "0x62F9B10", VA = "0x1862FB110")]
		public SplinePointRotationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override SplinePointRotationDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(SplinePointRotationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	public readonly struct ToolCleanupStatusDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly ToolCleanupStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x62FC8B0", Offset = "0x62FB2B0", VA = "0x1862FC8B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal ToolCleanupStatusDataWrapper(Entity entity, ToolCleanupStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Preserve]
	[CompilerGenerated]
	public class ToolCleanupStatusDataProperties : IAOJJHMNOHP<ToolCleanupStatusDataWrapper, ToolCleanupStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly ICAFADEJOLA<float> cleanupStartTime;

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly ICAFADEJOLA<bool> forceCleanup;

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly ICAFADEJOLA<bool> cleanupDone;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x62EFB40", Offset = "0x62EE540", VA = "0x1862EFB40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly CHMNJBFIOJP<float> cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly CHMNJBFIOJP<bool> forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly CHMNJBFIOJP<bool> cleanupDone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AB0", Offset = "0x7C44B0", VA = "0x1807C5AB0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x62FC650", Offset = "0x62FB050", VA = "0x1862FC650")]
		public ToolCleanupStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override ToolCleanupStatusDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(ToolCleanupStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	public readonly struct SplinePointPositionDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly SplinePointPositionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x62FAF80", Offset = "0x62F9980", VA = "0x1862FAF80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal SplinePointPositionDataWrapper(Entity entity, SplinePointPositionDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x62FB020", Offset = "0x62F9A20", VA = "0x1862FB020")]
		public float3 JCNOAADEIGE()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x62FB0A0", Offset = "0x62F9AA0", VA = "0x1862FB0A0")]
		public bool KBEGKMDLNNO(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointPositionDataProperties : IAOJJHMNOHP<SplinePointPositionDataWrapper, SplinePointPositionData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly ICAFADEJOLA<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x62EF360", Offset = "0x62EDD60", VA = "0x1862EF360")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly CHMNJBFIOJP<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x62FAE30", Offset = "0x62F9830", VA = "0x1862FAE30")]
		public SplinePointPositionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override SplinePointPositionDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(SplinePointPositionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	public readonly struct ShapeTypeDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly ShapeTypeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public JBBPHKINJON shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x62FA710", Offset = "0x62F9110", VA = "0x1862FA710")]
			get
			{
				return default(JBBPHKINJON);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x62FA670", Offset = "0x62F9070", VA = "0x1862FA670", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal ShapeTypeDataWrapper(Entity entity, ShapeTypeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[Preserve]
	[CompilerGenerated]
	public class ShapeTypeDataProperties : IAOJJHMNOHP<ShapeTypeDataWrapper, ShapeTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public static readonly ICAFADEJOLA<JBBPHKINJON> shapeType;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x62EFCC0", Offset = "0x62EE6C0", VA = "0x1862EFCC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public readonly CHMNJBFIOJP<JBBPHKINJON> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x62FA520", Offset = "0x62F8F20", VA = "0x1862FA520")]
		public ShapeTypeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override ShapeTypeDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(ShapeTypeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	public readonly struct PrimitiveShapeDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly PrimitiveShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IMOOPIBCBLJ shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x62F85B0", Offset = "0x62F6FB0", VA = "0x1862F85B0")]
			get
			{
				return default(IMOOPIBCBLJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x62F8510", Offset = "0x62F6F10", VA = "0x1862F8510", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal PrimitiveShapeDataWrapper(Entity entity, PrimitiveShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x62F84B0", Offset = "0x62F6EB0", VA = "0x1862F84B0")]
		public IMOOPIBCBLJ DIKKOAFENAC()
		{
			return default(IMOOPIBCBLJ);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	[Preserve]
	public class PrimitiveShapeDataProperties : IAOJJHMNOHP<PrimitiveShapeDataWrapper, PrimitiveShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly ICAFADEJOLA<IMOOPIBCBLJ> shapeType;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x62EFE90", Offset = "0x62EE890", VA = "0x1862EFE90")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly CHMNJBFIOJP<IMOOPIBCBLJ> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x62F8360", Offset = "0x62F6D60", VA = "0x1862F8360")]
		public PrimitiveShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override PrimitiveShapeDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	public readonly struct ReplicatorDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly ReplicatorDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x62F9EB0", Offset = "0x62F88B0", VA = "0x1862F9EB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal ReplicatorDataWrapper(Entity entity, ReplicatorDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatorDataProperties : IAOJJHMNOHP<ReplicatorDataWrapper, ReplicatorData>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly ICAFADEJOLA<Entity> Target;

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x62F0810", Offset = "0x62EF210", VA = "0x1862F0810")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly CHMNJBFIOJP<Entity> Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x62F9D60", Offset = "0x62F8760", VA = "0x1862F9D60")]
		public ReplicatorDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override ReplicatorDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(ReplicatorDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	public readonly struct PlayerScopeDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly PlayerScopeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x62F82C0", Offset = "0x62F6CC0", VA = "0x1862F82C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal PlayerScopeDataWrapper(Entity entity, PlayerScopeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[Preserve]
	[CompilerGenerated]
	public class PlayerScopeDataProperties : IAOJJHMNOHP<PlayerScopeDataWrapper, PlayerScopeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public static readonly ICAFADEJOLA<Entity> playerScope;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x62EF740", Offset = "0x62EE140", VA = "0x1862EF740")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly CHMNJBFIOJP<Entity> playerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x62F8170", Offset = "0x62F6B70", VA = "0x1862F8170")]
		public PlayerScopeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override PlayerScopeDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(PlayerScopeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	public readonly struct EntityBundlePartDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly EntityBundlePartDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x62EE3E0", Offset = "0x62ECDE0", VA = "0x1862EE3E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal EntityBundlePartDataWrapper(Entity entity, EntityBundlePartDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[Preserve]
	[CompilerGenerated]
	public class EntityBundlePartDataProperties : IAOJJHMNOHP<EntityBundlePartDataWrapper, EntityBundlePartData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public static readonly ICAFADEJOLA<Entity> prefabRoot;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public static readonly ICAFADEJOLA<uint> entityBundlePartId;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x62F0230", Offset = "0x62EEC30", VA = "0x1862F0230")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly CHMNJBFIOJP<Entity> prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly CHMNJBFIOJP<uint> entityBundlePartId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AC0", Offset = "0x7C44C0", VA = "0x1807C5AC0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x62EE200", Offset = "0x62ECC00", VA = "0x1862EE200")]
		public EntityBundlePartDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override EntityBundlePartDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(EntityBundlePartDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectOwnedByPlayerDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly ReplicatedObjectOwnedByPlayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x62F9CC0", Offset = "0x62F86C0", VA = "0x1862F9CC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal ReplicatedObjectOwnedByPlayerDataWrapper(Entity entity, ReplicatedObjectOwnedByPlayerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatedObjectOwnedByPlayerDataProperties : IAOJJHMNOHP<ReplicatedObjectOwnedByPlayerDataWrapper, ReplicatedObjectOwnedByPlayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public static readonly ICAFADEJOLA<int> actorId;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x62F0640", Offset = "0x62EF040", VA = "0x1862F0640")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly CHMNJBFIOJP<int> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x62F9B70", Offset = "0x62F8570", VA = "0x1862F9B70")]
		public ReplicatedObjectOwnedByPlayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override ReplicatedObjectOwnedByPlayerDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(ReplicatedObjectOwnedByPlayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	public readonly struct OMShapeContainerDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly OMShapeContainerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x62F6DE0", Offset = "0x62F57E0", VA = "0x1862F6DE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal OMShapeContainerDataWrapper(Entity entity, OMShapeContainerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	[Preserve]
	public class OMShapeContainerDataProperties : IAOJJHMNOHP<OMShapeContainerDataWrapper, OMShapeContainerData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public static readonly ICAFADEJOLA<bool> canModifyWithCircuits;

			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public static readonly ICAFADEJOLA<bool> optimizedCollidersEnabled;

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x62EF0D0", Offset = "0x62EDAD0", VA = "0x1862EF0D0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly CHMNJBFIOJP<bool> canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly CHMNJBFIOJP<bool> optimizedCollidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AC0", Offset = "0x7C44C0", VA = "0x1807C5AC0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x62F6C10", Offset = "0x62F5610", VA = "0x1862F6C10")]
		public OMShapeContainerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override OMShapeContainerDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(OMShapeContainerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	[CompilerGenerated]
	[global::OCOJMMGMPOH]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[global::GBDNJDNNBCG(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[global::GBDNJDNNBCG(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[global::GBDNJDNNBCG(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	public readonly struct AuthoredParentDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly AuthoredParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x62E0F90", Offset = "0x62DF990", VA = "0x1862E0F90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal AuthoredParentDataWrapper(Entity entity, AuthoredParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredParentDataProperties : IAOJJHMNOHP<AuthoredParentDataWrapper, AuthoredParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public static readonly ICAFADEJOLA<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x62F0480", Offset = "0x62EEE80", VA = "0x1862F0480")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public readonly CHMNJBFIOJP<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x62E0E40", Offset = "0x62DF840", VA = "0x1862E0E40")]
		public AuthoredParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override AuthoredParentDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(AuthoredParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	public readonly struct NavMeshGenerationDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly NavMeshGenerationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x62F0D30", Offset = "0x62EF730", VA = "0x1862F0D30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal NavMeshGenerationDataWrapper(Entity entity, NavMeshGenerationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x62F0E30", Offset = "0x62EF830", VA = "0x1862F0E30")]
		public AFFJPNLCPBK JJLEAHJAMIE()
		{
			return default(AFFJPNLCPBK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x62F0DD0", Offset = "0x62EF7D0", VA = "0x1862F0DD0")]
		public bool HLEGOCKDGNH(AFFJPNLCPBK value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[Preserve]
	[CompilerGenerated]
	public class NavMeshGenerationDataProperties : IAOJJHMNOHP<NavMeshGenerationDataWrapper, NavMeshGenerationData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public static readonly ICAFADEJOLA<AFFJPNLCPBK> mode;

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x62F00E0", Offset = "0x62EEAE0", VA = "0x1862F00E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly CHMNJBFIOJP<AFFJPNLCPBK> mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x62F0BE0", Offset = "0x62EF5E0", VA = "0x1862F0BE0")]
		public NavMeshGenerationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override NavMeshGenerationDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	public readonly struct ContainerNameDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly ContainerNameDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x62EDC80", Offset = "0x62EC680", VA = "0x1862EDC80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal ContainerNameDataWrapper(Entity entity, ContainerNameDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x62EDD90", Offset = "0x62EC790", VA = "0x1862EDD90")]
		public FixedString64Bytes IOFGJEGEGBC()
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x62EDD20", Offset = "0x62EC720", VA = "0x1862EDD20")]
		public bool GHOPOJMPNMM(FixedString64Bytes value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerNameDataProperties : IAOJJHMNOHP<ContainerNameDataWrapper, ContainerNameData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public static readonly ICAFADEJOLA<FixedString64Bytes> name;

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x62F0500", Offset = "0x62EEF00", VA = "0x1862F0500")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly CHMNJBFIOJP<FixedString64Bytes> name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x62EDB30", Offset = "0x62EC530", VA = "0x1862EDB30")]
		public ContainerNameDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override ContainerNameDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(ContainerNameDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	public readonly struct ShapeConfigDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly ShapeConfigDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x62FA420", Offset = "0x62F8E20", VA = "0x1862FA420", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal ShapeConfigDataWrapper(Entity entity, ShapeConfigDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x62FA3C0", Offset = "0x62F8DC0", VA = "0x1862FA3C0")]
		public GALKDOKCBDD CEIJGIKBFDB()
		{
			return default(GALKDOKCBDD);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x62FA4C0", Offset = "0x62F8EC0", VA = "0x1862FA4C0")]
		public bool JAFANHGADIK(GALKDOKCBDD value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	[Preserve]
	public class ShapeConfigDataProperties : IAOJJHMNOHP<ShapeConfigDataWrapper, ShapeConfigData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly ICAFADEJOLA<GALKDOKCBDD> flags;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x62F0B60", Offset = "0x62EF560", VA = "0x1862F0B60")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public readonly CHMNJBFIOJP<GALKDOKCBDD> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x62FA270", Offset = "0x62F8C70", VA = "0x1862FA270")]
		public ShapeConfigDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override ShapeConfigDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(ShapeConfigDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	public readonly struct ParentDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly ParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x62F7AD0", Offset = "0x62F64D0", VA = "0x1862F7AD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal ParentDataWrapper(Entity entity, ParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[Preserve]
	[CompilerGenerated]
	public class ParentDataProperties : IAOJJHMNOHP<ParentDataWrapper, ParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public static readonly ICAFADEJOLA<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x62F0400", Offset = "0x62EEE00", VA = "0x1862F0400")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly CHMNJBFIOJP<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x62F7980", Offset = "0x62F6380", VA = "0x1862F7980")]
		public ParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override ParentDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(ParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	public readonly struct ReplicatorMaxObjectCountDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly ReplicatorMaxObjectCountDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x62FA0A0", Offset = "0x62F8AA0", VA = "0x1862FA0A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal ReplicatorMaxObjectCountDataWrapper(Entity entity, ReplicatorMaxObjectCountDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatorMaxObjectCountDataProperties : IAOJJHMNOHP<ReplicatorMaxObjectCountDataWrapper, ReplicatorMaxObjectCountData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public static readonly ICAFADEJOLA<int> MaxCopies;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x62EFC40", Offset = "0x62EE640", VA = "0x1862EFC40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public readonly CHMNJBFIOJP<int> MaxCopies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x62F9F50", Offset = "0x62F8950", VA = "0x1862F9F50")]
		public ReplicatorMaxObjectCountDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override ReplicatorMaxObjectCountDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(ReplicatorMaxObjectCountDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	public readonly struct ContainerMassOverrideDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly ContainerMassOverrideDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x62ED9D0", Offset = "0x62EC3D0", VA = "0x1862ED9D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal ContainerMassOverrideDataWrapper(Entity entity, ContainerMassOverrideDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x62EDA70", Offset = "0x62EC470", VA = "0x1862EDA70")]
		public float IAMKBLENDCE()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x62EDAD0", Offset = "0x62EC4D0", VA = "0x1862EDAD0")]
		public bool JPIFGPGHIND(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerMassOverrideDataProperties : IAOJJHMNOHP<ContainerMassOverrideDataWrapper, ContainerMassOverrideData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public static readonly ICAFADEJOLA<float> mass;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x62EFE10", Offset = "0x62EE810", VA = "0x1862EFE10")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public readonly CHMNJBFIOJP<float> mass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x62ED880", Offset = "0x62EC280", VA = "0x1862ED880")]
		public ContainerMassOverrideDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override ContainerMassOverrideDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(ContainerMassOverrideDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalPoseDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly AuthoredLocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x62E0BA0", Offset = "0x62DF5A0", VA = "0x1862E0BA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal AuthoredLocalPoseDataWrapper(Entity entity, AuthoredLocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[Preserve]
	[CompilerGenerated]
	public class AuthoredLocalPoseDataProperties : IAOJJHMNOHP<AuthoredLocalPoseDataWrapper, AuthoredLocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public static readonly ICAFADEJOLA<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public static readonly ICAFADEJOLA<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x62EFD40", Offset = "0x62EE740", VA = "0x1862EFD40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public readonly CHMNJBFIOJP<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public readonly CHMNJBFIOJP<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AC0", Offset = "0x7C44C0", VA = "0x1807C5AC0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x62E09C0", Offset = "0x62DF3C0", VA = "0x1862E09C0")]
		public AuthoredLocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override AuthoredLocalPoseDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(AuthoredLocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	public readonly struct ObjectBoardNodeDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly ObjectBoardNodeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x62F7050", Offset = "0x62F5A50", VA = "0x1862F7050", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal ObjectBoardNodeDataWrapper(Entity entity, ObjectBoardNodeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectBoardNodeDataProperties : IAOJJHMNOHP<ObjectBoardNodeDataWrapper, ObjectBoardNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly ICAFADEJOLA<NetworkGuid> nodeId;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly ICAFADEJOLA<NetworkGuid> graphId;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x62F0580", Offset = "0x62EEF80", VA = "0x1862F0580")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly CHMNJBFIOJP<NetworkGuid> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly CHMNJBFIOJP<NetworkGuid> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AC0", Offset = "0x7C44C0", VA = "0x1807C5AC0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x62F6E80", Offset = "0x62F5880", VA = "0x1862F6E80")]
		public ObjectBoardNodeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override ObjectBoardNodeDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(ObjectBoardNodeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalUniformScaleDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly AuthoredLocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x62E0DA0", Offset = "0x62DF7A0", VA = "0x1862E0DA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal AuthoredLocalUniformScaleDataWrapper(Entity entity, AuthoredLocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[Preserve]
	[CompilerGenerated]
	public class AuthoredLocalUniformScaleDataProperties : IAOJJHMNOHP<AuthoredLocalUniformScaleDataWrapper, AuthoredLocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly ICAFADEJOLA<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x62F0300", Offset = "0x62EED00", VA = "0x1862F0300")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public readonly CHMNJBFIOJP<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C50", Offset = "0x62DF650", VA = "0x1862E0C50")]
		public AuthoredLocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override AuthoredLocalUniformScaleDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(AuthoredLocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	public readonly struct StandardRenderableVisualDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly StandardRenderableVisualDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public COODFJCBCFA color
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x62FBC90", Offset = "0x62FA690", VA = "0x1862FBC90")]
			get
			{
				return default(COODFJCBCFA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public MBDIACBDLED material
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x62FBCF0", Offset = "0x62FA6F0", VA = "0x1862FBCF0")]
			get
			{
				return default(MBDIACBDLED);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public float uvScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x62FBFF0", Offset = "0x62FA9F0", VA = "0x1862FBFF0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float3 uvOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x62FC0C0", Offset = "0x62FAAC0", VA = "0x1862FC0C0")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x62FBE90", Offset = "0x62FA890", VA = "0x1862FBE90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal StandardRenderableVisualDataWrapper(Entity entity, StandardRenderableVisualDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x62FBE30", Offset = "0x62FA830", VA = "0x1862FBE30")]
		public COODFJCBCFA CJNIJFIPJFK()
		{
			return default(COODFJCBCFA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x62FC1A0", Offset = "0x62FABA0", VA = "0x1862FC1A0")]
		public bool PGMJGNKEICA(COODFJCBCFA value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x62FC140", Offset = "0x62FAB40", VA = "0x1862FC140")]
		public MBDIACBDLED MFDLMNBHIML()
		{
			return default(MBDIACBDLED);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x62FBF30", Offset = "0x62FA930", VA = "0x1862FBF30")]
		public bool GJFLMFHPJPB(MBDIACBDLED value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x62FBD50", Offset = "0x62FA750", VA = "0x1862FBD50")]
		public float CFFDHHHALFB()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x62FBF90", Offset = "0x62FA990", VA = "0x1862FBF90")]
		public bool JHABBCJFKIK(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x62FBDB0", Offset = "0x62FA7B0", VA = "0x1862FBDB0")]
		public float3 CGHAFPGAPAK()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x62FC050", Offset = "0x62FAA50", VA = "0x1862FC050")]
		public bool KEOBNFCPGGN(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[Preserve]
	[CompilerGenerated]
	public class StandardRenderableVisualDataProperties : IAOJJHMNOHP<StandardRenderableVisualDataWrapper, StandardRenderableVisualData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly ICAFADEJOLA<COODFJCBCFA> color;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly ICAFADEJOLA<MBDIACBDLED> material;

			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public static readonly ICAFADEJOLA<float> uvScale;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public static readonly ICAFADEJOLA<float3> uvOffset;

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x62F0890", Offset = "0x62EF290", VA = "0x1862F0890")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public readonly CHMNJBFIOJP<COODFJCBCFA> color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public readonly CHMNJBFIOJP<MBDIACBDLED> material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly CHMNJBFIOJP<float> uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly CHMNJBFIOJP<float3> uvOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7C9C10", Offset = "0x7C8610", VA = "0x1807C9C10", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x62FB9A0", Offset = "0x62FA3A0", VA = "0x1862FB9A0")]
		public StandardRenderableVisualDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override StandardRenderableVisualDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionLayerDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly ContainerCollisionLayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x62ECE60", Offset = "0x62EB860", VA = "0x1862ECE60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal ContainerCollisionLayerDataWrapper(Entity entity, ContainerCollisionLayerDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x62ECF00", Offset = "0x62EB900", VA = "0x1862ECF00")]
		public DLCDNFGOMIH JFNCKHFLLII()
		{
			return default(DLCDNFGOMIH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x62ECF60", Offset = "0x62EB960", VA = "0x1862ECF60")]
		public bool OMIOIGGKAIN(DLCDNFGOMIH value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerCollisionLayerDataProperties : IAOJJHMNOHP<ContainerCollisionLayerDataWrapper, ContainerCollisionLayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public static readonly ICAFADEJOLA<DLCDNFGOMIH> collisionLayer;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x62EF9C0", Offset = "0x62EE3C0", VA = "0x1862EF9C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public readonly CHMNJBFIOJP<DLCDNFGOMIH> collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x62ECD10", Offset = "0x62EB710", VA = "0x1862ECD10")]
		public ContainerCollisionLayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override ContainerCollisionLayerDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(ContainerCollisionLayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	public readonly struct SiblingSortOrderDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly SiblingSortOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x62FA8C0", Offset = "0x62F92C0", VA = "0x1862FA8C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal SiblingSortOrderDataWrapper(Entity entity, SiblingSortOrderDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[Preserve]
	[CompilerGenerated]
	public class SiblingSortOrderDataProperties : IAOJJHMNOHP<SiblingSortOrderDataWrapper, SiblingSortOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public static readonly ICAFADEJOLA<DENIDLPPMLE> order;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x62EF8C0", Offset = "0x62EE2C0", VA = "0x1862EF8C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly CHMNJBFIOJP<DENIDLPPMLE> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x62FA770", Offset = "0x62F9170", VA = "0x1862FA770")]
		public SiblingSortOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override SiblingSortOrderDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(SiblingSortOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	public readonly struct ContainerGrabbableModeDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly ContainerGrabbableModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x62ED720", Offset = "0x62EC120", VA = "0x1862ED720", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal ContainerGrabbableModeDataWrapper(Entity entity, ContainerGrabbableModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x62ED7C0", Offset = "0x62EC1C0", VA = "0x1862ED7C0")]
		public GDIPAJDEFOF HBEPHIGIMLE()
		{
			return default(GDIPAJDEFOF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x62ED820", Offset = "0x62EC220", VA = "0x1862ED820")]
		public bool HKLHMHNKDBD(GDIPAJDEFOF value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerGrabbableModeDataProperties : IAOJJHMNOHP<ContainerGrabbableModeDataWrapper, ContainerGrabbableModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public static readonly ICAFADEJOLA<GDIPAJDEFOF> grabbableMode;

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x62F0A60", Offset = "0x62EF460", VA = "0x1862F0A60")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly CHMNJBFIOJP<GDIPAJDEFOF> grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x62ED5D0", Offset = "0x62EBFD0", VA = "0x1862ED5D0")]
		public ContainerGrabbableModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override ContainerGrabbableModeDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(ContainerGrabbableModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	public readonly struct CostumePieceParentCostumeDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly CostumePieceParentCostumeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x62EDF70", Offset = "0x62EC970", VA = "0x1862EDF70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal CostumePieceParentCostumeDataWrapper(Entity entity, CostumePieceParentCostumeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	[Preserve]
	public class CostumePieceParentCostumeDataProperties : IAOJJHMNOHP<CostumePieceParentCostumeDataWrapper, CostumePieceParentCostumeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public static readonly ICAFADEJOLA<Entity> parentCostume;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x62EF530", Offset = "0x62EDF30", VA = "0x1862EF530")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public readonly CHMNJBFIOJP<Entity> parentCostume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x62EDE20", Offset = "0x62EC820", VA = "0x1862EDE20")]
		public CostumePieceParentCostumeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override CostumePieceParentCostumeDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(CostumePieceParentCostumeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	public readonly struct SplineShapeDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly SplineShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x62FB900", Offset = "0x62FA300", VA = "0x1862FB900", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal SplineShapeDataWrapper(Entity entity, SplineShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x62FB810", Offset = "0x62FA210", VA = "0x1862FB810")]
		public IADLKIOJNBI DELCLPKPJHB()
		{
			return default(IADLKIOJNBI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x62FB890", Offset = "0x62FA290", VA = "0x1862FB890")]
		public bool DIGEPADHMGM(IADLKIOJNBI value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[Preserve]
	[CompilerGenerated]
	public class SplineShapeDataProperties : IAOJJHMNOHP<SplineShapeDataWrapper, SplineShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public static readonly ICAFADEJOLA<IADLKIOJNBI> parameters;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x62EF840", Offset = "0x62EE240", VA = "0x1862EF840")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly CHMNJBFIOJP<IADLKIOJNBI> parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x62FB6C0", Offset = "0x62FA0C0", VA = "0x1862FB6C0")]
		public SplineShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override SplineShapeDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(SplineShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	public readonly struct TransformFlagsDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly TransformFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x62FCB30", Offset = "0x62FB530", VA = "0x1862FCB30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal TransformFlagsDataWrapper(Entity entity, TransformFlagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	[Preserve]
	public class TransformFlagsDataProperties : IAOJJHMNOHP<TransformFlagsDataWrapper, TransformFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly ICAFADEJOLA<BBBAGLIAPPD> transformHint;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly ICAFADEJOLA<HBNNBMFDMGM> transformPriority;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x62F0010", Offset = "0x62EEA10", VA = "0x1862F0010")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public readonly CHMNJBFIOJP<BBBAGLIAPPD> transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public readonly CHMNJBFIOJP<HBNNBMFDMGM> transformPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AC0", Offset = "0x7C44C0", VA = "0x1807C5AC0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x62FC950", Offset = "0x62FB350", VA = "0x1862FC950")]
		public TransformFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override TransformFlagsDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(TransformFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	public readonly struct ContainerFlagsDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly ContainerFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x62ED480", Offset = "0x62EBE80", VA = "0x1862ED480", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal ContainerFlagsDataWrapper(Entity entity, ContainerFlagsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x62ED420", Offset = "0x62EBE20", VA = "0x1862ED420")]
		public NIDCEBJLBCC CEIJGIKBFDB()
		{
			return default(NIDCEBJLBCC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x62ED520", Offset = "0x62EBF20", VA = "0x1862ED520")]
		public void KEKEKOACKML(NIDCEBJLBCC flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerFlagsDataProperties : IAOJJHMNOHP<ContainerFlagsDataWrapper, ContainerFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public static readonly ICAFADEJOLA<NIDCEBJLBCC> flags;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x62EFA40", Offset = "0x62EE440", VA = "0x1862EFA40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public readonly CHMNJBFIOJP<NIDCEBJLBCC> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x62ED2D0", Offset = "0x62EBCD0", VA = "0x1862ED2D0")]
		public ContainerFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override ContainerFlagsDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(ContainerFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	[global::OCOJMMGMPOH]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[global::GBDNJDNNBCG(1)]
		public NIDCEBJLBCC flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionModeDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly ContainerCollisionModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public KEGOHNGKILF collisionMode
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x62ED1B0", Offset = "0x62EBBB0", VA = "0x1862ED1B0")]
			get
			{
				return default(KEGOHNGKILF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x62ED110", Offset = "0x62EBB10", VA = "0x1862ED110", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal ContainerCollisionModeDataWrapper(Entity entity, ContainerCollisionModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x62ED210", Offset = "0x62EBC10", VA = "0x1862ED210")]
		public KEGOHNGKILF KGGGPNIBLBO()
		{
			return default(KEGOHNGKILF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x62ED270", Offset = "0x62EBC70", VA = "0x1862ED270")]
		public bool NEPJKPNIGLO(KEGOHNGKILF value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerCollisionModeDataProperties : IAOJJHMNOHP<ContainerCollisionModeDataWrapper, ContainerCollisionModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public static readonly ICAFADEJOLA<KEGOHNGKILF> collisionMode;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x62EF3E0", Offset = "0x62EDDE0", VA = "0x1862EF3E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly CHMNJBFIOJP<KEGOHNGKILF> collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x62ECFC0", Offset = "0x62EB9C0", VA = "0x1862ECFC0")]
		public ContainerCollisionModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override ContainerCollisionModeDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(ContainerCollisionModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	public readonly struct PhysicsMaterialDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private readonly PhysicsMaterialDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x62F80D0", Offset = "0x62F6AD0", VA = "0x1862F80D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal PhysicsMaterialDataWrapper(Entity entity, PhysicsMaterialDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x62F8070", Offset = "0x62F6A70", VA = "0x1862F8070")]
		public bool EGMBAGDMOIH(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[Preserve]
	[CompilerGenerated]
	public class PhysicsMaterialDataProperties : IAOJJHMNOHP<PhysicsMaterialDataWrapper, PhysicsMaterialData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly ICAFADEJOLA<float> density;

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x62EFAC0", Offset = "0x62EE4C0", VA = "0x1862EFAC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly CHMNJBFIOJP<float> density;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x62F7F20", Offset = "0x62F6920", VA = "0x1862F7F20")]
		public PhysicsMaterialDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override PhysicsMaterialDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	public readonly struct ObjectPolicyDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly ObjectPolicyDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ECJIHBHEPHH scaleRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x62F73E0", Offset = "0x62F5DE0", VA = "0x1862F73E0")]
			get
			{
				return default(ECJIHBHEPHH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x62F7520", Offset = "0x62F5F20", VA = "0x1862F7520", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal ObjectPolicyDataWrapper(Entity entity, ObjectPolicyDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x62F7460", Offset = "0x62F5E60", VA = "0x1862F7460")]
		public MDGDFEGOBNC CEIJGIKBFDB()
		{
			return default(MDGDFEGOBNC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x62F74C0", Offset = "0x62F5EC0", VA = "0x1862F74C0")]
		public GHGOCJLCCKJ EOJMOPMKGJN()
		{
			return default(GHGOCJLCCKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x62F7620", Offset = "0x62F6020", VA = "0x1862F7620")]
		public bool ICLJOECLHAP(GHGOCJLCCKJ value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x62F7680", Offset = "0x62F6080", VA = "0x1862F7680")]
		public void JOECFHFPAEG(GHGOCJLCCKJ flag, bool enable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x62F75C0", Offset = "0x62F5FC0", VA = "0x1862F75C0")]
		public KDGNGEGHKGK FADMKMIPHMA()
		{
			return default(KDGNGEGHKGK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x62F7730", Offset = "0x62F6130", VA = "0x1862F7730")]
		public bool OPBALPIONIL(KDGNGEGHKGK value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectPolicyDataProperties : IAOJJHMNOHP<ObjectPolicyDataWrapper, ObjectPolicyData>
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public static readonly ICAFADEJOLA<ECJIHBHEPHH> scaleRestriction;

			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly ICAFADEJOLA<GHGOCJLCCKJ> userConfigurableFlags;

			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly ICAFADEJOLA<KDGNGEGHKGK> circuitsTransformBehavior;

			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly ICAFADEJOLA<MDGDFEGOBNC> flags;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x62F06C0", Offset = "0x62EF0C0", VA = "0x1862F06C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public readonly CHMNJBFIOJP<ECJIHBHEPHH> scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public readonly CHMNJBFIOJP<GHGOCJLCCKJ> userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public readonly CHMNJBFIOJP<KDGNGEGHKGK> circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public readonly CHMNJBFIOJP<MDGDFEGOBNC> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x7C9C10", Offset = "0x7C8610", VA = "0x1807C9C10", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x62F70F0", Offset = "0x62F5AF0", VA = "0x1862F70F0")]
		public ObjectPolicyDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override ObjectPolicyDataWrapper FGHEOIFPKCI(Entity entity)
		{
			return default(ObjectPolicyDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[global::OCOJMMGMPOH]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[global::GBDNJDNNBCG(1)]
		public MDGDFEGOBNC flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[global::GBDNJDNNBCG(2)]
		public ECJIHBHEPHH scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[global::GBDNJDNNBCG(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	[global::OCOJMMGMPOH]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[global::GBDNJDNNBCG(1)]
		public MDGDFEGOBNC flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[global::GBDNJDNNBCG(2)]
		public ECJIHBHEPHH scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[global::GBDNJDNNBCG(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	[global::OCOJMMGMPOH]
	[CompilerGenerated]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[global::GBDNJDNNBCG(1)]
		public MDGDFEGOBNC flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[global::GBDNJDNNBCG(2)]
		public ECJIHBHEPHH scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[global::GBDNJDNNBCG(3)]
		public GHGOCJLCCKJ userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[global::OCOJMMGMPOH]
	[TypeManager.TypeVersion(2)]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[global::GBDNJDNNBCG(2)]
		public ECJIHBHEPHH scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[global::GBDNJDNNBCG(3)]
		public GHGOCJLCCKJ userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[global::GBDNJDNNBCG(1)]
		public MDGDFEGOBNC flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	public readonly struct SplinePointParentDataWrapper : BMBGJEDJJKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly SplinePointParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x62FAD90", Offset = "0x62F9790", VA = "0x1862FAD90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x1E99590", Offset = "0x1E97F90", VA = "0x181E99590", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x62E0C40", Offset = "0x62DF640", VA = "0x1862E0C40")]
		internal SplinePointParentDataWrapper(Entity entity, SplinePointParentDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x62FAD00", Offset = "0x62F9700", VA = "0x1862FAD00")]
		public bool AFNOGOFEBJL(LocalId value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointParentDataProperties : IAOJJHMNOHP<SplinePointParentDataWrapper, SplinePointParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly ICAFADEJOLA<Entity> spline;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x62EF6C0", Offset = "0x62EE0C0", VA = "0x1862EF6C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly CHMNJBFIOJP<Entity> spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private readonly LPBPPKKEEHB[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected internal override LPBPPKKEEHB[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x62FABB0", Offset = "0x62F95B0", VA = "0x1862FABB0")]
		public SplinePointParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x62E09A0", Offset = "0x62DF3A0", VA = "0x1862E09A0", Slot = "16")]
		protected internal override SplinePointParentDataWrapper FGHEOIFPKCI(Entity entity)
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
		[Cpp2IlInjected.Address(RVA = "0x62E1220", Offset = "0x62DFC20", VA = "0x1862E1220")]
		public static (long, string, string) GJHNJNNDONJ(GAPHNGPGADD value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x62E2E00", Offset = "0x62E1800", VA = "0x1862E2E00")]
		public static (long, string, string)[] NIELAPOPNFN(Type type)
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
		[Cpp2IlInjected.Address(RVA = "0x62F0E90", Offset = "0x62EF890", VA = "0x1862F0E90")]
		public static Type[] IACMLDJKKHJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x62F0EF0", Offset = "0x62EF8F0", VA = "0x1862F0EF0")]
		private static void JIGIEBIDGIG()
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
		[Cpp2IlInjected.Address(RVA = "0x62F2270", Offset = "0x62F0C70", VA = "0x1862F2270")]
		public static (Type, long, long)[] IACMLDJKKHJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x62F22D0", Offset = "0x62F0CD0", VA = "0x1862F22D0")]
		private static void JIGIEBIDGIG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
	[MBBAAMILDKG(typeof(EMDFIFALDBM), new string[] { "Registry" })]
	internal class NetworkPropertyRegistry : EMDFIFALDBM
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private Type[] Type
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x7C4FA0", Offset = "0x7C39A0", VA = "0x1807C4FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		private int[] Offset
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x7C4AA0", Offset = "0x7C34A0", VA = "0x1807C4AA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private int[] Size
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7C4AB0", Offset = "0x7C34B0", VA = "0x1807C4AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		private Type[] ComponentType
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x7C58F0", Offset = "0x7C42F0", VA = "0x1807C58F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x62F6BF0", Offset = "0x62F55F0", VA = "0x1862F6BF0")]
		public NetworkPropertyRegistry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x62F2F80", Offset = "0x62F1980", VA = "0x1862F2F80")]
		private void LDKHCAKHKAO()
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
		[Cpp2IlInjected.Address(RVA = "0x62F8610", Offset = "0x62F7010", VA = "0x1862F8610")]
		public static Type[] IACMLDJKKHJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x62F8670", Offset = "0x62F7070", VA = "0x1862F8670")]
		private static void JIGIEBIDGIG()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x62FD800", Offset = "0x62FC200", VA = "0x1862FD800")]
		public void JIGIEBIDGIG(MDGGPHKAOOJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x62FCBD0", Offset = "0x62FB5D0", VA = "0x1862FCBD0")]
		private void HHHJPHLMAEP(MDGGPHKAOOJ registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2F2FC30", Offset = "0x2F2E630", VA = "0x182F2FC30")]
		private void KGKMIENLNBD<T>(MDGGPHKAOOJ registry, [In] T value) where T : struct
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
[MBBAAMILDKG(typeof(DCFHOOBLBIK), new string[] { "Registry" })]
[HGMHEGMFAAC(AKLDBHGLJNP.Application)]
internal class LEMBLIOIDHA : DCFHOOBLBIK
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public Type MHMOICKPLBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x62FDC70", Offset = "0x62FC670", VA = "0x1862FDC70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Type[] BPNLDNAHGDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x62FDCD0", Offset = "0x62FC6D0", VA = "0x1862FDCD0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public Type[] IGKGNBHMEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x62FDD00", Offset = "0x62FC700", VA = "0x1862FDD00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public (Type type, long min, long max)[] BFPLJDCJGEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x62FDD10", Offset = "0x62FC710", VA = "0x1862FDD10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x62FDCE0", Offset = "0x62FC6E0", VA = "0x1862FDCE0", Slot = "8")]
	public void KIAGOMNANIC(MDGGPHKAOOJ IJPGNCKKJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public LEMBLIOIDHA()
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
