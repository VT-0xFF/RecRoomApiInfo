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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
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
	public class _AssemblyIndex : CAKBDCNKOBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private BNPPEDMHMGM bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x13736B0", Offset = "0x13728B0", VA = "0x1813736B0", Slot = "5")]
		public override void FCBNKPLDJOB(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x61AF6C0", Offset = "0x61AE8C0", VA = "0x1861AF6C0")]
		private void ADEFBFFMAIK(PBABFIIKKEP registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x61AF940", Offset = "0x61AEB40", VA = "0x1861AF940", Slot = "6")]
		public override void KOHLKIFPOBH(PBABFIIKKEP registry, [In] OKFMGAJCCBM filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "8")]
		public override void LFGBMGLIJAD(PDIHABEAKLL registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x61AF9A0", Offset = "0x61AEBA0", VA = "0x1861AF9A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	public readonly struct OverrideObjectNetworkIdDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly OverrideObjectNetworkIdDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61A97A0", Offset = "0x61A89A0", VA = "0x1861A97A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal OverrideObjectNetworkIdDataWrapper(Entity entity, OverrideObjectNetworkIdDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Preserve]
	[CompilerGenerated]
	public class OverrideObjectNetworkIdDataProperties : BMPHMGKLEHC<OverrideObjectNetworkIdDataWrapper, OverrideObjectNetworkIdData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly NHBFCLBDPEE<uint> networkIdBits;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x61A1270", Offset = "0x61A0470", VA = "0x1861A1270")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly IPJDEPGKKOL<uint> networkIdBits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61A9650", Offset = "0x61A8850", VA = "0x1861A9650")]
		public OverrideObjectNetworkIdDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override OverrideObjectNetworkIdDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(OverrideObjectNetworkIdDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public readonly struct PersistentUserTagDataWrapper : HDJOPFOEMAB
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
			[Cpp2IlInjected.Address(RVA = "0x61A9D80", Offset = "0x61A8F80", VA = "0x1861A9D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x61A9C10", Offset = "0x61A8E10", VA = "0x1861A9C10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal PersistentUserTagDataWrapper(Entity entity, PersistentUserTagDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x61A9CB0", Offset = "0x61A8EB0", VA = "0x1861A9CB0")]
		public bool IMFCLMCBLNL(FixedList32Bytes<int> value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x61A9D20", Offset = "0x61A8F20", VA = "0x1861A9D20")]
		public bool MEMBAACHMEK(bool value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[Preserve]
	public class PersistentUserTagDataProperties : BMPHMGKLEHC<PersistentUserTagDataWrapper, PersistentUserTagData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly NHBFCLBDPEE<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly NHBFCLBDPEE<bool> initalizedDefaults;

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x61A13F0", Offset = "0x61A05F0", VA = "0x1861A13F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly IPJDEPGKKOL<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly IPJDEPGKKOL<bool> initalizedDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x61A9A30", Offset = "0x61A8C30", VA = "0x1861A9A30")]
		public PersistentUserTagDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override PersistentUserTagDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(PersistentUserTagDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	[global::LLBGMHNKOLO]
	[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
	public struct PersistentUserTagData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::JBILIDMDGLK(1)]
		public FixedList32Bytes<int> tags;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public readonly struct LocalDeformableScaleDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LocalDeformableScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x61A0B70", Offset = "0x619FD70", VA = "0x1861A0B70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal LocalDeformableScaleDataWrapper(Entity entity, LocalDeformableScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[Preserve]
	[CompilerGenerated]
	public class LocalDeformableScaleDataProperties : BMPHMGKLEHC<LocalDeformableScaleDataWrapper, LocalDeformableScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly NHBFCLBDPEE<float3> localDeformationScale;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x61A28D0", Offset = "0x61A1AD0", VA = "0x1861A28D0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly IPJDEPGKKOL<float3> localDeformationScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x61A0A20", Offset = "0x619FC20", VA = "0x1861A0A20")]
		public LocalDeformableScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override LocalDeformableScaleDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(LocalDeformableScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
	[global::LLBGMHNKOLO]
	public struct LocalDeformableScaleData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[global::JBILIDMDGLK(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public readonly struct SplinePointScaleDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly SplinePointScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x61AD3E0", Offset = "0x61AC5E0", VA = "0x1861AD3E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal SplinePointScaleDataWrapper(Entity entity, SplinePointScaleDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x61AD4F0", Offset = "0x61AC6F0", VA = "0x1861AD4F0")]
		public float3 MAKDGKKEEHA()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x61AD480", Offset = "0x61AC680", VA = "0x1861AD480")]
		public bool FBKPAIBIPHE(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointScaleDataProperties : BMPHMGKLEHC<SplinePointScaleDataWrapper, SplinePointScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly NHBFCLBDPEE<float3> localScale;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x61A1E60", Offset = "0x61A1060", VA = "0x1861A1E60")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly IPJDEPGKKOL<float3> localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x61AD290", Offset = "0x61AC490", VA = "0x1861AD290")]
		public SplinePointScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override SplinePointScaleDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(SplinePointScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	public readonly struct LocalUniformScaleDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly LocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x61A0FE0", Offset = "0x61A01E0", VA = "0x1861A0FE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal LocalUniformScaleDataWrapper(Entity entity, LocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	[Preserve]
	public class LocalUniformScaleDataProperties : BMPHMGKLEHC<LocalUniformScaleDataWrapper, LocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly NHBFCLBDPEE<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x61A1EE0", Offset = "0x61A10E0", VA = "0x1861A1EE0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly IPJDEPGKKOL<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x61A0E90", Offset = "0x61A0090", VA = "0x1861A0E90")]
		public LocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override LocalUniformScaleDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(LocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public readonly struct InteractionFilterDataWrapper : HDJOPFOEMAB
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
			[Cpp2IlInjected.Address(RVA = "0x61A08E0", Offset = "0x619FAE0", VA = "0x1861A08E0")]
			get
			{
				return default(FixedList32Bytes<int>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x61A0770", Offset = "0x619F970", VA = "0x1861A0770", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal InteractionFilterDataWrapper(Entity entity, InteractionFilterDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x61A06F0", Offset = "0x619F8F0", VA = "0x1861A06F0")]
		public FixedList32Bytes<int> COMJMIHLBGA()
		{
			return default(FixedList32Bytes<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x61A0870", Offset = "0x619FA70", VA = "0x1861A0870")]
		public bool IMFCLMCBLNL(FixedList32Bytes<int> value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x61A0960", Offset = "0x619FB60", VA = "0x1861A0960")]
		public bool MPOABDFPFNK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x61A09C0", Offset = "0x619FBC0", VA = "0x1861A09C0")]
		public bool PFKODOFBAIG(bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x61A0810", Offset = "0x619FA10", VA = "0x1861A0810")]
		public CBEOBLKLLNC FHLAAHBFKGE()
		{
			return default(CBEOBLKLLNC);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x61A0690", Offset = "0x619F890", VA = "0x1861A0690")]
		public bool CGLOOMPEABO(CBEOBLKLLNC value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterDataProperties : BMPHMGKLEHC<InteractionFilterDataWrapper, InteractionFilterData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public static readonly NHBFCLBDPEE<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public static readonly NHBFCLBDPEE<bool> enabled;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public static readonly NHBFCLBDPEE<CBEOBLKLLNC> filterMode;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x61A1530", Offset = "0x61A0730", VA = "0x1861A1530")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly IPJDEPGKKOL<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public readonly IPJDEPGKKOL<bool> enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public readonly IPJDEPGKKOL<CBEOBLKLLNC> filterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7BE1A0", Offset = "0x7BD3A0", VA = "0x1807BE1A0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x61A0430", Offset = "0x619F630", VA = "0x1861A0430")]
		public InteractionFilterDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override InteractionFilterDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(InteractionFilterDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	public readonly struct ComponentSerializedVersionDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly ComponentSerializedVersionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6193200", Offset = "0x6192400", VA = "0x186193200", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal ComponentSerializedVersionDataWrapper(Entity entity, ComponentSerializedVersionDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	[Preserve]
	public class ComponentSerializedVersionDataProperties : BMPHMGKLEHC<ComponentSerializedVersionDataWrapper, ComponentSerializedVersionData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public static readonly NHBFCLBDPEE<NICHABCIKOD> version;

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x61A11F0", Offset = "0x61A03F0", VA = "0x1861A11F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public readonly IPJDEPGKKOL<NICHABCIKOD> version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x61930B0", Offset = "0x61922B0", VA = "0x1861930B0")]
		public ComponentSerializedVersionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override ComponentSerializedVersionDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(ComponentSerializedVersionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public readonly struct ToolCleanupSettingsDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly ToolCleanupSettingsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x61AE2F0", Offset = "0x61AD4F0", VA = "0x1861AE2F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal ToolCleanupSettingsDataWrapper(Entity entity, ToolCleanupSettingsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x61AE440", Offset = "0x61AD640", VA = "0x1861AE440")]
		public float KJNACKNLFNB()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x61AE290", Offset = "0x61AD490", VA = "0x1861AE290")]
		public bool DIHNMBBAACF(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x61AE4A0", Offset = "0x61AD6A0", VA = "0x1861AE4A0")]
		public KAFDABLICPN PPJIGPEBCEM()
		{
			return default(KAFDABLICPN);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x61AE390", Offset = "0x61AD590", VA = "0x1861AE390")]
		public void IDDNKNPEFIA(KAFDABLICPN flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	[Preserve]
	public class ToolCleanupSettingsDataProperties : BMPHMGKLEHC<ToolCleanupSettingsDataWrapper, ToolCleanupSettingsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public static readonly NHBFCLBDPEE<float> delay;

			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public static readonly NHBFCLBDPEE<KAFDABLICPN> toolCleanupFlags;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x61A1130", Offset = "0x61A0330", VA = "0x1861A1130")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public readonly IPJDEPGKKOL<float> delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly IPJDEPGKKOL<KAFDABLICPN> toolCleanupFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x61AE0B0", Offset = "0x61AD2B0", VA = "0x1861AE0B0")]
		public ToolCleanupSettingsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override ToolCleanupSettingsDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	public readonly struct SplinePointOrderDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly SplinePointOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x61AC960", Offset = "0x61ABB60", VA = "0x1861AC960", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal SplinePointOrderDataWrapper(Entity entity, SplinePointOrderDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x61ACA00", Offset = "0x61ABC00", VA = "0x1861ACA00")]
		public bool PIFEOPBPNBJ(OICAAOIBBBA value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointOrderDataProperties : BMPHMGKLEHC<SplinePointOrderDataWrapper, SplinePointOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public static readonly NHBFCLBDPEE<OICAAOIBBBA> order;

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x61A29D0", Offset = "0x61A1BD0", VA = "0x1861A29D0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly IPJDEPGKKOL<OICAAOIBBBA> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x61AC810", Offset = "0x61ABA10", VA = "0x1861AC810")]
		public SplinePointOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override SplinePointOrderDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(SplinePointOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public readonly struct CostumePieceSlotIndexDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly CostumePieceSlotIndexDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x61A0110", Offset = "0x619F310", VA = "0x1861A0110", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal CostumePieceSlotIndexDataWrapper(Entity entity, CostumePieceSlotIndexDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[Preserve]
	[CompilerGenerated]
	public class CostumePieceSlotIndexDataProperties : BMPHMGKLEHC<CostumePieceSlotIndexDataWrapper, CostumePieceSlotIndexData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public static readonly NHBFCLBDPEE<int> slotIndex;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x61A18B0", Offset = "0x61A0AB0", VA = "0x1861A18B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly IPJDEPGKKOL<int> slotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x619FFC0", Offset = "0x619F1C0", VA = "0x18619FFC0")]
		public CostumePieceSlotIndexDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override CostumePieceSlotIndexDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(CostumePieceSlotIndexDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	public readonly struct SerializedEmbodiedDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private readonly SerializedEmbodiedDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x61AC080", Offset = "0x61AB280", VA = "0x1861AC080", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal SerializedEmbodiedDataWrapper(Entity entity, SerializedEmbodiedDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	[Preserve]
	public class SerializedEmbodiedDataProperties : BMPHMGKLEHC<SerializedEmbodiedDataWrapper, SerializedEmbodiedData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Names
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x61ABFF0", Offset = "0x61AB1F0", VA = "0x1861ABFF0")]
		public SerializedEmbodiedDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override SerializedEmbodiedDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(SerializedEmbodiedDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	public readonly struct LocalPoseDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly LocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x61A0DF0", Offset = "0x619FFF0", VA = "0x1861A0DF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal LocalPoseDataWrapper(Entity entity, LocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[Preserve]
	[CompilerGenerated]
	public class LocalPoseDataProperties : BMPHMGKLEHC<LocalPoseDataWrapper, LocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public static readonly NHBFCLBDPEE<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public static readonly NHBFCLBDPEE<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x61A20A0", Offset = "0x61A12A0", VA = "0x1861A20A0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly IPJDEPGKKOL<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly IPJDEPGKKOL<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x61A0C10", Offset = "0x619FE10", VA = "0x1861A0C10")]
		public LocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override LocalPoseDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(LocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectActiveStatusDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly ReplicatedObjectActiveStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x61AB980", Offset = "0x61AAB80", VA = "0x1861AB980", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal ReplicatedObjectActiveStatusDataWrapper(Entity entity, ReplicatedObjectActiveStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatedObjectActiveStatusDataProperties : BMPHMGKLEHC<ReplicatedObjectActiveStatusDataWrapper, ReplicatedObjectActiveStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public static readonly NHBFCLBDPEE<bool> active;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x61A22A0", Offset = "0x61A14A0", VA = "0x1861A22A0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly IPJDEPGKKOL<bool> active;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x61AB830", Offset = "0x61AAA30", VA = "0x1861AB830")]
		public ReplicatedObjectActiveStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override ReplicatedObjectActiveStatusDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(ReplicatedObjectActiveStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	public readonly struct SplinePointRotationDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly SplinePointRotationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x61AD180", Offset = "0x61AC380", VA = "0x1861AD180", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal SplinePointRotationDataWrapper(Entity entity, SplinePointRotationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x61AD220", Offset = "0x61AC420", VA = "0x1861AD220")]
		public quaternion ODGAHOHDEDL()
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x61AD110", Offset = "0x61AC310", VA = "0x1861AD110")]
		public bool ACFFKPKOHOL(quaternion value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointRotationDataProperties : BMPHMGKLEHC<SplinePointRotationDataWrapper, SplinePointRotationData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly NHBFCLBDPEE<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x61A1730", Offset = "0x61A0930", VA = "0x1861A1730")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly IPJDEPGKKOL<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x61ACFC0", Offset = "0x61AC1C0", VA = "0x1861ACFC0")]
		public SplinePointRotationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override SplinePointRotationDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(SplinePointRotationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	public readonly struct ToolCleanupStatusDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly ToolCleanupStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x61AE760", Offset = "0x61AD960", VA = "0x1861AE760", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal ToolCleanupStatusDataWrapper(Entity entity, ToolCleanupStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Preserve]
	[CompilerGenerated]
	public class ToolCleanupStatusDataProperties : BMPHMGKLEHC<ToolCleanupStatusDataWrapper, ToolCleanupStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly NHBFCLBDPEE<float> cleanupStartTime;

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly NHBFCLBDPEE<bool> forceCleanup;

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly NHBFCLBDPEE<bool> cleanupDone;

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x61A1AB0", Offset = "0x61A0CB0", VA = "0x1861A1AB0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly IPJDEPGKKOL<float> cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly IPJDEPGKKOL<bool> forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public readonly IPJDEPGKKOL<bool> cleanupDone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7BE1A0", Offset = "0x7BD3A0", VA = "0x1807BE1A0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x61AE500", Offset = "0x61AD700", VA = "0x1861AE500")]
		public ToolCleanupStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override ToolCleanupStatusDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(ToolCleanupStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	public readonly struct SplinePointPositionDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly SplinePointPositionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x61ACE30", Offset = "0x61AC030", VA = "0x1861ACE30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal SplinePointPositionDataWrapper(Entity entity, SplinePointPositionDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x61ACED0", Offset = "0x61AC0D0", VA = "0x1861ACED0")]
		public float3 KOOAOKHOGKP()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x61ACF50", Offset = "0x61AC150", VA = "0x1861ACF50")]
		public bool LGPOCLAELFE(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointPositionDataProperties : BMPHMGKLEHC<SplinePointPositionDataWrapper, SplinePointPositionData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly NHBFCLBDPEE<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x61A12F0", Offset = "0x61A04F0", VA = "0x1861A12F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly IPJDEPGKKOL<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x61ACCE0", Offset = "0x61ABEE0", VA = "0x1861ACCE0")]
		public SplinePointPositionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override SplinePointPositionDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(SplinePointPositionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	public readonly struct ShapeTypeDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private readonly ShapeTypeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public EHKIBNJBFBB shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x61AC5C0", Offset = "0x61AB7C0", VA = "0x1861AC5C0")]
			get
			{
				return default(EHKIBNJBFBB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x61AC520", Offset = "0x61AB720", VA = "0x1861AC520", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal ShapeTypeDataWrapper(Entity entity, ShapeTypeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[Preserve]
	[CompilerGenerated]
	public class ShapeTypeDataProperties : BMPHMGKLEHC<ShapeTypeDataWrapper, ShapeTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public static readonly NHBFCLBDPEE<EHKIBNJBFBB> shapeType;

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x61A1C20", Offset = "0x61A0E20", VA = "0x1861A1C20")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public readonly IPJDEPGKKOL<EHKIBNJBFBB> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x61AC3D0", Offset = "0x61AB5D0", VA = "0x1861AC3D0")]
		public ShapeTypeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override ShapeTypeDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(ShapeTypeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	public readonly struct PrimitiveShapeDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly PrimitiveShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public OONAHILDADH shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x61AA470", Offset = "0x61A9670", VA = "0x1861AA470")]
			get
			{
				return default(OONAHILDADH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x61AA3D0", Offset = "0x61A95D0", VA = "0x1861AA3D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal PrimitiveShapeDataWrapper(Entity entity, PrimitiveShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x61AA370", Offset = "0x61A9570", VA = "0x1861AA370")]
		public OONAHILDADH AJNCMJMEHKF()
		{
			return default(OONAHILDADH);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	[Preserve]
	public class PrimitiveShapeDataProperties : BMPHMGKLEHC<PrimitiveShapeDataWrapper, PrimitiveShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly NHBFCLBDPEE<OONAHILDADH> shapeType;

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x61A1DE0", Offset = "0x61A0FE0", VA = "0x1861A1DE0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly IPJDEPGKKOL<OONAHILDADH> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x61AA220", Offset = "0x61A9420", VA = "0x1861AA220")]
		public PrimitiveShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override PrimitiveShapeDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	public readonly struct ReplicatorDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly ReplicatorDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x61ABD60", Offset = "0x61AAF60", VA = "0x1861ABD60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal ReplicatorDataWrapper(Entity entity, ReplicatorDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatorDataProperties : BMPHMGKLEHC<ReplicatorDataWrapper, ReplicatorData>
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly NHBFCLBDPEE<Entity> Target;

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x61A2710", Offset = "0x61A1910", VA = "0x1861A2710")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly IPJDEPGKKOL<Entity> Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x61ABC10", Offset = "0x61AAE10", VA = "0x1861ABC10")]
		public ReplicatorDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override ReplicatorDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(ReplicatorDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	public readonly struct PlayerScopeDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly PlayerScopeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x61AA180", Offset = "0x61A9380", VA = "0x1861AA180", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal PlayerScopeDataWrapper(Entity entity, PlayerScopeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[Preserve]
	[CompilerGenerated]
	public class PlayerScopeDataProperties : BMPHMGKLEHC<PlayerScopeDataWrapper, PlayerScopeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public static readonly NHBFCLBDPEE<Entity> playerScope;

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x61A16B0", Offset = "0x61A08B0", VA = "0x1861A16B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly IPJDEPGKKOL<Entity> playerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x61AA030", Offset = "0x61A9230", VA = "0x1861AA030")]
		public PlayerScopeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override PlayerScopeDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(PlayerScopeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	public readonly struct EntityBundlePartDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly EntityBundlePartDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x61A0390", Offset = "0x619F590", VA = "0x1861A0390", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal EntityBundlePartDataWrapper(Entity entity, EntityBundlePartDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[Preserve]
	[CompilerGenerated]
	public class EntityBundlePartDataProperties : BMPHMGKLEHC<EntityBundlePartDataWrapper, EntityBundlePartData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public static readonly NHBFCLBDPEE<Entity> prefabRoot;

			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public static readonly NHBFCLBDPEE<uint> entityBundlePartId;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x61A2160", Offset = "0x61A1360", VA = "0x1861A2160")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly IPJDEPGKKOL<Entity> prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public readonly IPJDEPGKKOL<uint> entityBundlePartId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x61A01B0", Offset = "0x619F3B0", VA = "0x1861A01B0")]
		public EntityBundlePartDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override EntityBundlePartDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(EntityBundlePartDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectOwnedByPlayerDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private readonly ReplicatedObjectOwnedByPlayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x61ABB70", Offset = "0x61AAD70", VA = "0x1861ABB70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal ReplicatedObjectOwnedByPlayerDataWrapper(Entity entity, ReplicatedObjectOwnedByPlayerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatedObjectOwnedByPlayerDataProperties : BMPHMGKLEHC<ReplicatedObjectOwnedByPlayerDataWrapper, ReplicatedObjectOwnedByPlayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public static readonly NHBFCLBDPEE<int> actorId;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x61A2550", Offset = "0x61A1750", VA = "0x1861A2550")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly IPJDEPGKKOL<int> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x61ABA20", Offset = "0x61AAC20", VA = "0x1861ABA20")]
		public ReplicatedObjectOwnedByPlayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override ReplicatedObjectOwnedByPlayerDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(ReplicatedObjectOwnedByPlayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	public readonly struct OMShapeContainerDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly OMShapeContainerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x61A8CA0", Offset = "0x61A7EA0", VA = "0x1861A8CA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal OMShapeContainerDataWrapper(Entity entity, OMShapeContainerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	[Preserve]
	public class OMShapeContainerDataProperties : BMPHMGKLEHC<OMShapeContainerDataWrapper, OMShapeContainerData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public static readonly NHBFCLBDPEE<bool> canModifyWithCircuits;

			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public static readonly NHBFCLBDPEE<bool> optimizedCollidersEnabled;

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x61A1080", Offset = "0x61A0280", VA = "0x1861A1080")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public readonly IPJDEPGKKOL<bool> canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly IPJDEPGKKOL<bool> optimizedCollidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x61A8AD0", Offset = "0x61A7CD0", VA = "0x1861A8AD0")]
		public OMShapeContainerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override OMShapeContainerDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(OMShapeContainerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	[CompilerGenerated]
	[global::LLBGMHNKOLO]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[global::JBILIDMDGLK(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[global::JBILIDMDGLK(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[global::JBILIDMDGLK(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	public readonly struct AuthoredParentDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly AuthoredParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6193010", Offset = "0x6192210", VA = "0x186193010", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal AuthoredParentDataWrapper(Entity entity, AuthoredParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredParentDataProperties : BMPHMGKLEHC<AuthoredParentDataWrapper, AuthoredParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public static readonly NHBFCLBDPEE<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x61A23A0", Offset = "0x61A15A0", VA = "0x1861A23A0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public readonly IPJDEPGKKOL<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6192EC0", Offset = "0x61920C0", VA = "0x186192EC0")]
		public AuthoredParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override AuthoredParentDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(AuthoredParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	public readonly struct NavMeshGenerationDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly NavMeshGenerationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x61A2C80", Offset = "0x61A1E80", VA = "0x1861A2C80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal NavMeshGenerationDataWrapper(Entity entity, NavMeshGenerationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x61A2C20", Offset = "0x61A1E20", VA = "0x1861A2C20")]
		public OIOGKNHCGED CHEJOINEEGP()
		{
			return default(OIOGKNHCGED);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x61A2D20", Offset = "0x61A1F20", VA = "0x1861A2D20")]
		public bool PCKEKJFLDAJ(OIOGKNHCGED value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[Preserve]
	[CompilerGenerated]
	public class NavMeshGenerationDataProperties : BMPHMGKLEHC<NavMeshGenerationDataWrapper, NavMeshGenerationData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public static readonly NHBFCLBDPEE<OIOGKNHCGED> mode;

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x61A2020", Offset = "0x61A1220", VA = "0x1861A2020")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public readonly IPJDEPGKKOL<OIOGKNHCGED> mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x61A2AD0", Offset = "0x61A1CD0", VA = "0x1861A2AD0")]
		public NavMeshGenerationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override NavMeshGenerationDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	public readonly struct ContainerNameDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly ContainerNameDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x619FCA0", Offset = "0x619EEA0", VA = "0x18619FCA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal ContainerNameDataWrapper(Entity entity, ContainerNameDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x619FD40", Offset = "0x619EF40", VA = "0x18619FD40")]
		public FixedString64Bytes LELLFBMFLMK()
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x619FC30", Offset = "0x619EE30", VA = "0x18619FC30")]
		public bool DAADGDODEJM(FixedString64Bytes value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerNameDataProperties : BMPHMGKLEHC<ContainerNameDataWrapper, ContainerNameData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public static readonly NHBFCLBDPEE<FixedString64Bytes> name;

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x61A2420", Offset = "0x61A1620", VA = "0x1861A2420")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public readonly IPJDEPGKKOL<FixedString64Bytes> name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x619FAE0", Offset = "0x619ECE0", VA = "0x18619FAE0")]
		public ContainerNameDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override ContainerNameDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(ContainerNameDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	public readonly struct ShapeConfigDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly ShapeConfigDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x61AC2D0", Offset = "0x61AB4D0", VA = "0x1861AC2D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal ShapeConfigDataWrapper(Entity entity, ShapeConfigDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x61AC370", Offset = "0x61AB570", VA = "0x1861AC370")]
		public MKMLIFLADIO OIAGBFFKPJI()
		{
			return default(MKMLIFLADIO);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x61AC270", Offset = "0x61AB470", VA = "0x1861AC270")]
		public bool ECOMFAOLAAK(MKMLIFLADIO value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	[Preserve]
	public class ShapeConfigDataProperties : BMPHMGKLEHC<ShapeConfigDataWrapper, ShapeConfigData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly NHBFCLBDPEE<MKMLIFLADIO> flags;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x61A2A50", Offset = "0x61A1C50", VA = "0x1861A2A50")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public readonly IPJDEPGKKOL<MKMLIFLADIO> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x61AC120", Offset = "0x61AB320", VA = "0x1861AC120")]
		public ShapeConfigDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override ShapeConfigDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(ShapeConfigDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	public readonly struct ParentDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly ParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x61A9990", Offset = "0x61A8B90", VA = "0x1861A9990", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal ParentDataWrapper(Entity entity, ParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[Preserve]
	[CompilerGenerated]
	public class ParentDataProperties : BMPHMGKLEHC<ParentDataWrapper, ParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public static readonly NHBFCLBDPEE<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x61A2320", Offset = "0x61A1520", VA = "0x1861A2320")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly IPJDEPGKKOL<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x61A9840", Offset = "0x61A8A40", VA = "0x1861A9840")]
		public ParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override ParentDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(ParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	public readonly struct ReplicatorMaxObjectCountDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private readonly ReplicatorMaxObjectCountDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x61ABF50", Offset = "0x61AB150", VA = "0x1861ABF50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal ReplicatorMaxObjectCountDataWrapper(Entity entity, ReplicatorMaxObjectCountDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatorMaxObjectCountDataProperties : BMPHMGKLEHC<ReplicatorMaxObjectCountDataWrapper, ReplicatorMaxObjectCountData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public static readonly NHBFCLBDPEE<int> MaxCopies;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x61A1BA0", Offset = "0x61A0DA0", VA = "0x1861A1BA0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public readonly IPJDEPGKKOL<int> MaxCopies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x61ABE00", Offset = "0x61AB000", VA = "0x1861ABE00")]
		public ReplicatorMaxObjectCountDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override ReplicatorMaxObjectCountDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(ReplicatorMaxObjectCountDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	public readonly struct ContainerMassOverrideDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly ContainerMassOverrideDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x619F980", Offset = "0x619EB80", VA = "0x18619F980", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal ContainerMassOverrideDataWrapper(Entity entity, ContainerMassOverrideDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x619FA20", Offset = "0x619EC20", VA = "0x18619FA20")]
		public float JJJDKLEKGCP()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x619FA80", Offset = "0x619EC80", VA = "0x18619FA80")]
		public bool ODJAJGFBMDD(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerMassOverrideDataProperties : BMPHMGKLEHC<ContainerMassOverrideDataWrapper, ContainerMassOverrideData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public static readonly NHBFCLBDPEE<float> mass;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x61A1D60", Offset = "0x61A0F60", VA = "0x1861A1D60")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public readonly IPJDEPGKKOL<float> mass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x619F830", Offset = "0x619EA30", VA = "0x18619F830")]
		public ContainerMassOverrideDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override ContainerMassOverrideDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(ContainerMassOverrideDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalPoseDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private readonly AuthoredLocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6192C20", Offset = "0x6191E20", VA = "0x186192C20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal AuthoredLocalPoseDataWrapper(Entity entity, AuthoredLocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[Preserve]
	[CompilerGenerated]
	public class AuthoredLocalPoseDataProperties : BMPHMGKLEHC<AuthoredLocalPoseDataWrapper, AuthoredLocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public static readonly NHBFCLBDPEE<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public static readonly NHBFCLBDPEE<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x61A1CA0", Offset = "0x61A0EA0", VA = "0x1861A1CA0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public readonly IPJDEPGKKOL<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public readonly IPJDEPGKKOL<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6192A40", Offset = "0x6191C40", VA = "0x186192A40")]
		public AuthoredLocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override AuthoredLocalPoseDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(AuthoredLocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	public readonly struct ObjectBoardNodeDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly ObjectBoardNodeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x61A8F10", Offset = "0x61A8110", VA = "0x1861A8F10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal ObjectBoardNodeDataWrapper(Entity entity, ObjectBoardNodeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectBoardNodeDataProperties : BMPHMGKLEHC<ObjectBoardNodeDataWrapper, ObjectBoardNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public static readonly NHBFCLBDPEE<NetworkGuid> nodeId;

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly NHBFCLBDPEE<NetworkGuid> graphId;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x61A24A0", Offset = "0x61A16A0", VA = "0x1861A24A0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly IPJDEPGKKOL<NetworkGuid> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public readonly IPJDEPGKKOL<NetworkGuid> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x61A8D40", Offset = "0x61A7F40", VA = "0x1861A8D40")]
		public ObjectBoardNodeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override ObjectBoardNodeDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(ObjectBoardNodeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalUniformScaleDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private readonly AuthoredLocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6192E20", Offset = "0x6192020", VA = "0x186192E20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal AuthoredLocalUniformScaleDataWrapper(Entity entity, AuthoredLocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[Preserve]
	[CompilerGenerated]
	public class AuthoredLocalUniformScaleDataProperties : BMPHMGKLEHC<AuthoredLocalUniformScaleDataWrapper, AuthoredLocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public static readonly NHBFCLBDPEE<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x61A2220", Offset = "0x61A1420", VA = "0x1861A2220")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public readonly IPJDEPGKKOL<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6192CD0", Offset = "0x6191ED0", VA = "0x186192CD0")]
		public AuthoredLocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override AuthoredLocalUniformScaleDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(AuthoredLocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	public readonly struct StandardRenderableVisualDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private readonly StandardRenderableVisualDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public PGGNMAEFFLG color
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x61ADFF0", Offset = "0x61AD1F0", VA = "0x1861ADFF0")]
			get
			{
				return default(PGGNMAEFFLG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public FKDILDJBONM material
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x61ADBA0", Offset = "0x61ACDA0", VA = "0x1861ADBA0")]
			get
			{
				return default(FKDILDJBONM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public float uvScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x61ADB40", Offset = "0x61ACD40", VA = "0x1861ADB40")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public float3 uvOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x61ADDD0", Offset = "0x61ACFD0", VA = "0x1861ADDD0")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x61ADCC0", Offset = "0x61ACEC0", VA = "0x1861ADCC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal StandardRenderableVisualDataWrapper(Entity entity, StandardRenderableVisualDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x61ADED0", Offset = "0x61AD0D0", VA = "0x1861ADED0")]
		public PGGNMAEFFLG JKKILELLOAH()
		{
			return default(PGGNMAEFFLG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x61AE050", Offset = "0x61AD250", VA = "0x1861AE050")]
		public bool PHDGBCGLLAI(PGGNMAEFFLG value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x61ADF90", Offset = "0x61AD190", VA = "0x1861ADF90")]
		public FKDILDJBONM OLGCJGHEJAC()
		{
			return default(FKDILDJBONM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x61ADF30", Offset = "0x61AD130", VA = "0x1861ADF30")]
		public bool KBJHAAJLNGF(FKDILDJBONM value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x61ADC60", Offset = "0x61ACE60", VA = "0x1861ADC60")]
		public float DFGLJBJAODM()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x61ADC00", Offset = "0x61ACE00", VA = "0x1861ADC00")]
		public bool DDJIFJBLJEJ(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x61ADE50", Offset = "0x61AD050", VA = "0x1861ADE50")]
		public float3 JEJDFGJPHCM()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x61ADD60", Offset = "0x61ACF60", VA = "0x1861ADD60")]
		public bool FHNIIPHKNGK(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[Preserve]
	[CompilerGenerated]
	public class StandardRenderableVisualDataProperties : BMPHMGKLEHC<StandardRenderableVisualDataWrapper, StandardRenderableVisualData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly NHBFCLBDPEE<PGGNMAEFFLG> color;

			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public static readonly NHBFCLBDPEE<FKDILDJBONM> material;

			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public static readonly NHBFCLBDPEE<float> uvScale;

			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public static readonly NHBFCLBDPEE<float3> uvOffset;

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x61A2790", Offset = "0x61A1990", VA = "0x1861A2790")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public readonly IPJDEPGKKOL<PGGNMAEFFLG> color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public readonly IPJDEPGKKOL<FKDILDJBONM> material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly IPJDEPGKKOL<float> uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly IPJDEPGKKOL<float3> uvOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7B6020", Offset = "0x7B5220", VA = "0x1807B6020", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x61AD850", Offset = "0x61ACA50", VA = "0x1861AD850")]
		public StandardRenderableVisualDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override StandardRenderableVisualDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionLayerDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly ContainerCollisionLayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x619EE10", Offset = "0x619E010", VA = "0x18619EE10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal ContainerCollisionLayerDataWrapper(Entity entity, ContainerCollisionLayerDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x619EF10", Offset = "0x619E110", VA = "0x18619EF10")]
		public AMPNCKEABLE OBAFOOMCCIJ()
		{
			return default(AMPNCKEABLE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x619EEB0", Offset = "0x619E0B0", VA = "0x18619EEB0")]
		public bool KEOGBNNLCPI(AMPNCKEABLE value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerCollisionLayerDataProperties : BMPHMGKLEHC<ContainerCollisionLayerDataWrapper, ContainerCollisionLayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public static readonly NHBFCLBDPEE<AMPNCKEABLE> collisionLayer;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x61A1930", Offset = "0x61A0B30", VA = "0x1861A1930")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public readonly IPJDEPGKKOL<AMPNCKEABLE> collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x619ECC0", Offset = "0x619DEC0", VA = "0x18619ECC0")]
		public ContainerCollisionLayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override ContainerCollisionLayerDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(ContainerCollisionLayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	public readonly struct SiblingSortOrderDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly SiblingSortOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x61AC770", Offset = "0x61AB970", VA = "0x1861AC770", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal SiblingSortOrderDataWrapper(Entity entity, SiblingSortOrderDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[Preserve]
	[CompilerGenerated]
	public class SiblingSortOrderDataProperties : BMPHMGKLEHC<SiblingSortOrderDataWrapper, SiblingSortOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public static readonly NHBFCLBDPEE<OICAAOIBBBA> order;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x61A1830", Offset = "0x61A0A30", VA = "0x1861A1830")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public readonly IPJDEPGKKOL<OICAAOIBBBA> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x61AC620", Offset = "0x61AB820", VA = "0x1861AC620")]
		public SiblingSortOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override SiblingSortOrderDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(SiblingSortOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	public readonly struct ContainerGrabbableModeDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly ContainerGrabbableModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x619F6D0", Offset = "0x619E8D0", VA = "0x18619F6D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal ContainerGrabbableModeDataWrapper(Entity entity, ContainerGrabbableModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x619F770", Offset = "0x619E970", VA = "0x18619F770")]
		public HFGDBBHGGDC MFAMOLBLDOO()
		{
			return default(HFGDBBHGGDC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x619F7D0", Offset = "0x619E9D0", VA = "0x18619F7D0")]
		public bool OGKPOEHHFLJ(HFGDBBHGGDC value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerGrabbableModeDataProperties : BMPHMGKLEHC<ContainerGrabbableModeDataWrapper, ContainerGrabbableModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public static readonly NHBFCLBDPEE<HFGDBBHGGDC> grabbableMode;

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x61A2950", Offset = "0x61A1B50", VA = "0x1861A2950")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly IPJDEPGKKOL<HFGDBBHGGDC> grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x619F580", Offset = "0x619E780", VA = "0x18619F580")]
		public ContainerGrabbableModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override ContainerGrabbableModeDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(ContainerGrabbableModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	public readonly struct CostumePieceParentCostumeDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly CostumePieceParentCostumeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x619FF20", Offset = "0x619F120", VA = "0x18619FF20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal CostumePieceParentCostumeDataWrapper(Entity entity, CostumePieceParentCostumeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	[Preserve]
	public class CostumePieceParentCostumeDataProperties : BMPHMGKLEHC<CostumePieceParentCostumeDataWrapper, CostumePieceParentCostumeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public static readonly NHBFCLBDPEE<Entity> parentCostume;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x61A14B0", Offset = "0x61A06B0", VA = "0x1861A14B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public readonly IPJDEPGKKOL<Entity> parentCostume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x619FDD0", Offset = "0x619EFD0", VA = "0x18619FDD0")]
		public CostumePieceParentCostumeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override CostumePieceParentCostumeDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(CostumePieceParentCostumeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	public readonly struct SplineShapeDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly SplineShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x61AD6C0", Offset = "0x61AC8C0", VA = "0x1861AD6C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal SplineShapeDataWrapper(Entity entity, SplineShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x61AD760", Offset = "0x61AC960", VA = "0x1861AD760")]
		public KJGIJINEINK HBIEOHLAFCB()
		{
			return default(KJGIJINEINK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x61AD7E0", Offset = "0x61AC9E0", VA = "0x1861AD7E0")]
		public bool MPFMEMAJADB(KJGIJINEINK value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[Preserve]
	[CompilerGenerated]
	public class SplineShapeDataProperties : BMPHMGKLEHC<SplineShapeDataWrapper, SplineShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public static readonly NHBFCLBDPEE<KJGIJINEINK> parameters;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x61A17B0", Offset = "0x61A09B0", VA = "0x1861A17B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly IPJDEPGKKOL<KJGIJINEINK> parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x61AD570", Offset = "0x61AC770", VA = "0x1861AD570")]
		public SplineShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override SplineShapeDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(SplineShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	public readonly struct TransformFlagsDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly TransformFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x61AE9E0", Offset = "0x61ADBE0", VA = "0x1861AE9E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal TransformFlagsDataWrapper(Entity entity, TransformFlagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	[Preserve]
	public class TransformFlagsDataProperties : BMPHMGKLEHC<TransformFlagsDataWrapper, TransformFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly NHBFCLBDPEE<JGFBELBNDNB> transformHint;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly NHBFCLBDPEE<ONDFFKKBNED> transformPriority;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x61A1F60", Offset = "0x61A1160", VA = "0x1861A1F60")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public readonly IPJDEPGKKOL<JGFBELBNDNB> transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public readonly IPJDEPGKKOL<ONDFFKKBNED> transformPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x61AE800", Offset = "0x61ADA00", VA = "0x1861AE800")]
		public TransformFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override TransformFlagsDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(TransformFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	public readonly struct ContainerFlagsDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly ContainerFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x619F3D0", Offset = "0x619E5D0", VA = "0x18619F3D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal ContainerFlagsDataWrapper(Entity entity, ContainerFlagsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x619F470", Offset = "0x619E670", VA = "0x18619F470")]
		public DMFJIBOHKNI OIAGBFFKPJI()
		{
			return default(DMFJIBOHKNI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x619F4D0", Offset = "0x619E6D0", VA = "0x18619F4D0")]
		public void OJDNGMFJBGB(DMFJIBOHKNI flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerFlagsDataProperties : BMPHMGKLEHC<ContainerFlagsDataWrapper, ContainerFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public static readonly NHBFCLBDPEE<DMFJIBOHKNI> flags;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x61A19B0", Offset = "0x61A0BB0", VA = "0x1861A19B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public readonly IPJDEPGKKOL<DMFJIBOHKNI> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x619F280", Offset = "0x619E480", VA = "0x18619F280")]
		public ContainerFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override ContainerFlagsDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(ContainerFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	[global::LLBGMHNKOLO]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[global::JBILIDMDGLK(1)]
		public DMFJIBOHKNI flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionModeDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private readonly ContainerCollisionModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public IFHCIJGELLJ collisionMode
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x619F1C0", Offset = "0x619E3C0", VA = "0x18619F1C0")]
			get
			{
				return default(IFHCIJGELLJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x619F120", Offset = "0x619E320", VA = "0x18619F120", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal ContainerCollisionModeDataWrapper(Entity entity, ContainerCollisionModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x619F220", Offset = "0x619E420", VA = "0x18619F220")]
		public IFHCIJGELLJ MMPBFPIENPE()
		{
			return default(IFHCIJGELLJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x619F0C0", Offset = "0x619E2C0", VA = "0x18619F0C0")]
		public bool ENCCPPFDAHP(IFHCIJGELLJ value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerCollisionModeDataProperties : BMPHMGKLEHC<ContainerCollisionModeDataWrapper, ContainerCollisionModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public static readonly NHBFCLBDPEE<IFHCIJGELLJ> collisionMode;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x61A1370", Offset = "0x61A0570", VA = "0x1861A1370")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly IPJDEPGKKOL<IFHCIJGELLJ> collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x619EF70", Offset = "0x619E170", VA = "0x18619EF70")]
		public ContainerCollisionModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override ContainerCollisionModeDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(ContainerCollisionModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CompilerGenerated]
	public readonly struct PhysicsMaterialDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private readonly PhysicsMaterialDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x61A9F30", Offset = "0x61A9130", VA = "0x1861A9F30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal PhysicsMaterialDataWrapper(Entity entity, PhysicsMaterialDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x61A9FD0", Offset = "0x61A91D0", VA = "0x1861A9FD0")]
		public bool HMMEOCIEAJO(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[Preserve]
	[CompilerGenerated]
	public class PhysicsMaterialDataProperties : BMPHMGKLEHC<PhysicsMaterialDataWrapper, PhysicsMaterialData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly NHBFCLBDPEE<float> density;

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x61A1A30", Offset = "0x61A0C30", VA = "0x1861A1A30")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public readonly IPJDEPGKKOL<float> density;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x61A9DE0", Offset = "0x61A8FE0", VA = "0x1861A9DE0")]
		public PhysicsMaterialDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override PhysicsMaterialDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	public readonly struct ObjectPolicyDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly ObjectPolicyDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public ACPNJIFFEJM scaleRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x61A9510", Offset = "0x61A8710", VA = "0x1861A9510")]
			get
			{
				return default(ACPNJIFFEJM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x61A9470", Offset = "0x61A8670", VA = "0x1861A9470", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal ObjectPolicyDataWrapper(Entity entity, ObjectPolicyDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x61A95F0", Offset = "0x61A87F0", VA = "0x1861A95F0")]
		public JHPCPPLHOMJ OIAGBFFKPJI()
		{
			return default(JHPCPPLHOMJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x61A9410", Offset = "0x61A8610", VA = "0x1861A9410")]
		public ENENJKLEDNA EPGEAGJFGPA()
		{
			return default(ENENJKLEDNA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x61A9590", Offset = "0x61A8790", VA = "0x1861A9590")]
		public bool INOPGPDOEIJ(ENENJKLEDNA value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x61A9360", Offset = "0x61A8560", VA = "0x1861A9360")]
		public void DPEOHIGHFIK(ENENJKLEDNA flag, bool enable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x61A9300", Offset = "0x61A8500", VA = "0x1861A9300")]
		public NHMPFBPMHDB DIILJGGHMBD()
		{
			return default(NHMPFBPMHDB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x61A92A0", Offset = "0x61A84A0", VA = "0x1861A92A0")]
		public bool BIHPKIPBKMO(NHMPFBPMHDB value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectPolicyDataProperties : BMPHMGKLEHC<ObjectPolicyDataWrapper, ObjectPolicyData>
	{
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public static readonly NHBFCLBDPEE<ACPNJIFFEJM> scaleRestriction;

			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly NHBFCLBDPEE<ENENJKLEDNA> userConfigurableFlags;

			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly NHBFCLBDPEE<NHMPFBPMHDB> circuitsTransformBehavior;

			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly NHBFCLBDPEE<JHPCPPLHOMJ> flags;

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x61A25D0", Offset = "0x61A17D0", VA = "0x1861A25D0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public readonly IPJDEPGKKOL<ACPNJIFFEJM> scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public readonly IPJDEPGKKOL<ENENJKLEDNA> userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public readonly IPJDEPGKKOL<NHMPFBPMHDB> circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public readonly IPJDEPGKKOL<JHPCPPLHOMJ> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x7B6020", Offset = "0x7B5220", VA = "0x1807B6020", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x61A8FB0", Offset = "0x61A81B0", VA = "0x1861A8FB0")]
		public ObjectPolicyDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override ObjectPolicyDataWrapper HKOAFCEMFKN(Entity entity)
		{
			return default(ObjectPolicyDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[global::LLBGMHNKOLO]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[global::JBILIDMDGLK(1)]
		public JHPCPPLHOMJ flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[global::JBILIDMDGLK(2)]
		public ACPNJIFFEJM scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[global::JBILIDMDGLK(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[CompilerGenerated]
	[global::LLBGMHNKOLO]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[global::JBILIDMDGLK(1)]
		public JHPCPPLHOMJ flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[global::JBILIDMDGLK(2)]
		public ACPNJIFFEJM scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[global::JBILIDMDGLK(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	[global::LLBGMHNKOLO]
	[CompilerGenerated]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[global::JBILIDMDGLK(1)]
		public JHPCPPLHOMJ flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[global::JBILIDMDGLK(2)]
		public ACPNJIFFEJM scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[global::JBILIDMDGLK(3)]
		public ENENJKLEDNA userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[global::LLBGMHNKOLO]
	[TypeManager.TypeVersion(2)]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[global::JBILIDMDGLK(2)]
		public ACPNJIFFEJM scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[global::JBILIDMDGLK(3)]
		public ENENJKLEDNA userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[global::JBILIDMDGLK(1)]
		public JHPCPPLHOMJ flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[CompilerGenerated]
	public readonly struct SplinePointParentDataWrapper : HDJOPFOEMAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private readonly SplinePointParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x61ACBB0", Offset = "0x61ABDB0", VA = "0x1861ACBB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x1E66B40", Offset = "0x1E65D40", VA = "0x181E66B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6192CC0", Offset = "0x6191EC0", VA = "0x186192CC0")]
		internal SplinePointParentDataWrapper(Entity entity, SplinePointParentDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x61ACC50", Offset = "0x61ABE50", VA = "0x1861ACC50")]
		public bool OOONIKFPIAC(LocalId value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointParentDataProperties : BMPHMGKLEHC<SplinePointParentDataWrapper, SplinePointParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly NHBFCLBDPEE<Entity> spline;

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x61A1630", Offset = "0x61A0830", VA = "0x1861A1630")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly IPJDEPGKKOL<Entity> spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private readonly CBLKJOJOGPN[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected internal override CBLKJOJOGPN[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x61ACA60", Offset = "0x61ABC60", VA = "0x1861ACA60")]
		public SplinePointParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6192A20", Offset = "0x6191C20", VA = "0x186192A20", Slot = "16")]
		protected internal override SplinePointParentDataWrapper HKOAFCEMFKN(Entity entity)
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
		[Cpp2IlInjected.Address(RVA = "0x61932A0", Offset = "0x61924A0", VA = "0x1861932A0")]
		public static (long, string, string) HFBDKIHMBCM(FHHKGBHDBDG value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6194DC0", Offset = "0x6193FC0", VA = "0x186194DC0")]
		public static (long, string, string)[] MAPGLLFFPGJ(Type type)
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
		[Cpp2IlInjected.Address(RVA = "0x61A4100", Offset = "0x61A3300", VA = "0x1861A4100")]
		public static Type[] PJCMPBGMGFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x61A2D80", Offset = "0x61A1F80", VA = "0x1861A2D80")]
		private static void FPMBLPAHIMD()
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
		[Cpp2IlInjected.Address(RVA = "0x61A4DF0", Offset = "0x61A3FF0", VA = "0x1861A4DF0")]
		public static (Type, long, long)[] PJCMPBGMGFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x61A4150", Offset = "0x61A3350", VA = "0x1861A4150")]
		private static void FPMBLPAHIMD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	[CNJGMKKABCG(FGONPGLMBDD.Application)]
	[HGCGALFKODL(typeof(LAFAMBEBGEJ), new string[] { "Registry" })]
	internal class NetworkPropertyRegistry : LAFAMBEBGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private Type[] Type
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x7B6300", Offset = "0x7B5500", VA = "0x1807B6300")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		private int[] Offset
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x7B6290", Offset = "0x7B5490", VA = "0x1807B6290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private int[] Size
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7B84D0", Offset = "0x7B76D0", VA = "0x1807B84D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		private Type[] ComponentType
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x7BC9A0", Offset = "0x7BBBA0", VA = "0x1807BC9A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x61A8AB0", Offset = "0x61A7CB0", VA = "0x1861A8AB0")]
		public NetworkPropertyRegistry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x61A4E40", Offset = "0x61A4040", VA = "0x1861A4E40")]
		private void EELMEDFLLDP()
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
		[Cpp2IlInjected.Address(RVA = "0x61AB7E0", Offset = "0x61AA9E0", VA = "0x1861AB7E0")]
		public static Type[] PJCMPBGMGFM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x61AA4D0", Offset = "0x61A96D0", VA = "0x1861AA4D0")]
		private static void FPMBLPAHIMD()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x61AEA80", Offset = "0x61ADC80", VA = "0x1861AEA80")]
		public void FPMBLPAHIMD(PDIHABEAKLL registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x61AEA90", Offset = "0x61ADC90", VA = "0x1861AEA90")]
		private void PBJOBINOGOD(PDIHABEAKLL registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x2EC3E10", Offset = "0x2EC3010", VA = "0x182EC3E10")]
		private void HJIGLLKDKDB<T>(PDIHABEAKLL registry, [In] T value) where T : struct
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
[HGCGALFKODL(typeof(BEHBDGADOEH), new string[] { "Registry" })]
[CNJGMKKABCG(FGONPGLMBDD.Application)]
internal class DLNPAFHPIAF : BEHBDGADOEH
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public Type IDNCDDMGGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x61AFB30", Offset = "0x61AED30", VA = "0x1861AFB30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Type[] KOMGBPACLPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x61AFBB0", Offset = "0x61AEDB0", VA = "0x1861AFBB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public Type[] LJFDIPDKNFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x61AFBC0", Offset = "0x61AEDC0", VA = "0x1861AFBC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public (Type type, long min, long max)[] KGJACBGHLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x61AFB20", Offset = "0x61AED20", VA = "0x1861AFB20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x61AFB90", Offset = "0x61AED90", VA = "0x1861AFB90", Slot = "8")]
	public void KKPFKHFMJCF(PDIHABEAKLL OAPLEAAIAID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public DLNPAFHPIAF()
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
