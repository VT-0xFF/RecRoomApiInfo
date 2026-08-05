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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
	public class _AssemblyIndex : OIHPLJCCMGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] localIndices0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private HELGCKGNJCP bitset0;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x15D3CC0", Offset = "0x15D30C0", VA = "0x1815D3CC0", Slot = "5")]
		public override void LGJJIPPJFHB(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68B33C0", Offset = "0x68B27C0", VA = "0x1868B33C0")]
		private void HKLAFMGGDHJ(NLGBDMBMDHC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x68B3640", Offset = "0x68B2A40", VA = "0x1868B3640", Slot = "6")]
		public override void HOLCLMBHKNK(NLGBDMBMDHC registry, [In] FACCPJLOOCE filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "8")]
		public override void DLOFGCDOMEH(FELKOHNNBJK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x68B36A0", Offset = "0x68B2AA0", VA = "0x1868B36A0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	public readonly struct OverrideObjectNetworkIdDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly OverrideObjectNetworkIdDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x68AEAF0", Offset = "0x68ADEF0", VA = "0x1868AEAF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal OverrideObjectNetworkIdDataWrapper(Entity entity, OverrideObjectNetworkIdDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Preserve]
	[CompilerGenerated]
	public class OverrideObjectNetworkIdDataProperties : CODDMBMPNME<OverrideObjectNetworkIdDataWrapper, OverrideObjectNetworkIdData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly EFELFPBBEIB<uint> networkIdBits;

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x68A4C10", Offset = "0x68A4010", VA = "0x1868A4C10")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly OMGPLJDNBKA<uint> networkIdBits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x68AE9A0", Offset = "0x68ADDA0", VA = "0x1868AE9A0")]
		public OverrideObjectNetworkIdDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override OverrideObjectNetworkIdDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(OverrideObjectNetworkIdDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	public readonly struct PersistentUserTagDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly PersistentUserTagDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68AEF60", Offset = "0x68AE360", VA = "0x1868AEF60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal PersistentUserTagDataWrapper(Entity entity, PersistentUserTagDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	[Preserve]
	public class PersistentUserTagDataProperties : CODDMBMPNME<PersistentUserTagDataWrapper, PersistentUserTagData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly EFELFPBBEIB<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly EFELFPBBEIB<bool> initalizedDefaults;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x68A4D90", Offset = "0x68A4190", VA = "0x1868A4D90")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly OMGPLJDNBKA<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly OMGPLJDNBKA<bool> initalizedDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x68AED80", Offset = "0x68AE180", VA = "0x1868AED80")]
		public PersistentUserTagDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override PersistentUserTagDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(PersistentUserTagDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[global::BPMCLJHLDME]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5651606820436095739uL)]
	public struct PersistentUserTagData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[global::AKOGMCGBMOC(1)]
		public FixedList32Bytes<int> tags;
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	public readonly struct LocalDeformableScaleDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LocalDeformableScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x68A42A0", Offset = "0x68A36A0", VA = "0x1868A42A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal LocalDeformableScaleDataWrapper(Entity entity, LocalDeformableScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	[Preserve]
	public class LocalDeformableScaleDataProperties : CODDMBMPNME<LocalDeformableScaleDataWrapper, LocalDeformableScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly EFELFPBBEIB<float3> localDeformationScale;

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x68A6930", Offset = "0x68A5D30", VA = "0x1868A6930")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly OMGPLJDNBKA<float3> localDeformationScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x68A4150", Offset = "0x68A3550", VA = "0x1868A4150")]
		public LocalDeformableScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override LocalDeformableScaleDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(LocalDeformableScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2711391707957742092uL)]
	[global::BPMCLJHLDME]
	public struct LocalDeformableScaleData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[global::AKOGMCGBMOC(1)]
		public float3 localDeformationScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	public readonly struct SplinePointScaleDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly SplinePointScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x68B19C0", Offset = "0x68B0DC0", VA = "0x1868B19C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal SplinePointScaleDataWrapper(Entity entity, SplinePointScaleDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x68B1A60", Offset = "0x68B0E60", VA = "0x1868B1A60")]
		public float3 FJLGNAMHFJH()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x68B1AE0", Offset = "0x68B0EE0", VA = "0x1868B1AE0")]
		public bool OAFDLHODGKG(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointScaleDataProperties : CODDMBMPNME<SplinePointScaleDataWrapper, SplinePointScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static readonly EFELFPBBEIB<float3> localScale;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x68A5C10", Offset = "0x68A5010", VA = "0x1868A5C10")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly OMGPLJDNBKA<float3> localScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x68B1870", Offset = "0x68B0C70", VA = "0x1868B1870")]
		public SplinePointScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override SplinePointScaleDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(SplinePointScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	public readonly struct LocalUniformScaleDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly LocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x68A4710", Offset = "0x68A3B10", VA = "0x1868A4710", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal LocalUniformScaleDataWrapper(Entity entity, LocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[Preserve]
	[CompilerGenerated]
	public class LocalUniformScaleDataProperties : CODDMBMPNME<LocalUniformScaleDataWrapper, LocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public static readonly EFELFPBBEIB<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x68A5D10", Offset = "0x68A5110", VA = "0x1868A5D10")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public readonly OMGPLJDNBKA<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x68A45C0", Offset = "0x68A39C0", VA = "0x1868A45C0")]
		public LocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override LocalUniformScaleDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(LocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	public readonly struct InteractionFilterEnabledDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly InteractionFilterEnabledDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x68A3CD0", Offset = "0x68A30D0", VA = "0x1868A3CD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal InteractionFilterEnabledDataWrapper(Entity entity, InteractionFilterEnabledDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	[Preserve]
	public class InteractionFilterEnabledDataProperties : CODDMBMPNME<InteractionFilterEnabledDataWrapper, InteractionFilterEnabledData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public static readonly EFELFPBBEIB<EGMMDFJLLMC> filterMode;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x68A5370", Offset = "0x68A4770", VA = "0x1868A5370")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public readonly OMGPLJDNBKA<EGMMDFJLLMC> filterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x68A3B80", Offset = "0x68A2F80", VA = "0x1868A3B80")]
		public InteractionFilterEnabledDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override InteractionFilterEnabledDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(InteractionFilterEnabledDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	public readonly struct ReferenceGroupReferenceBufferWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly ReferenceGroupReferenceBufferProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x68AFC20", Offset = "0x68AF020", VA = "0x1868AFC20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ReferenceGroupReferenceBufferWrapper(Entity entity, ReferenceGroupReferenceBufferProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	[Preserve]
	public class ReferenceGroupReferenceBufferProperties : AAPAFNCKCCE<ReferenceGroupReferenceBufferWrapper, ReferenceGroupReferenceBuffer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public static readonly EFELFPBBEIB<Entity> reference;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x68A6030", Offset = "0x68A5430", VA = "0x1868A6030")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly ACKJDPHDCJD<ReferenceGroupReferenceBuffer, Entity> reference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x68AFAD0", Offset = "0x68AEED0", VA = "0x1868AFAD0")]
		public ReferenceGroupReferenceBufferProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ReferenceGroupReferenceBufferWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ReferenceGroupReferenceBufferWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	public readonly struct UserTagReferenceBufferWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly UserTagReferenceBufferProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x68B3320", Offset = "0x68B2720", VA = "0x1868B3320", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal UserTagReferenceBufferWrapper(Entity entity, UserTagReferenceBufferProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[Preserve]
	[CompilerGenerated]
	public class UserTagReferenceBufferProperties : AAPAFNCKCCE<UserTagReferenceBufferWrapper, UserTagReferenceBuffer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public static readonly EFELFPBBEIB<Entity> Child;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x68A53F0", Offset = "0x68A47F0", VA = "0x1868A53F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly ACKJDPHDCJD<UserTagReferenceBuffer, Entity> Child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x68B31D0", Offset = "0x68B25D0", VA = "0x1868B31D0")]
		public UserTagReferenceBufferProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override UserTagReferenceBufferWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(UserTagReferenceBufferWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	public readonly struct InteractionFilterDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly InteractionFilterDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x68A3AE0", Offset = "0x68A2EE0", VA = "0x1868A3AE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal InteractionFilterDataWrapper(Entity entity, InteractionFilterDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterDataProperties : CODDMBMPNME<InteractionFilterDataWrapper, InteractionFilterData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public static readonly EFELFPBBEIB<FixedList32Bytes<int>> tags;

			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public static readonly EFELFPBBEIB<bool> enabled;

			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public static readonly EFELFPBBEIB<EGMMDFJLLMC> filterMode;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x68A4EE0", Offset = "0x68A42E0", VA = "0x1868A4EE0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public readonly OMGPLJDNBKA<FixedList32Bytes<int>> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly OMGPLJDNBKA<bool> enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly OMGPLJDNBKA<EGMMDFJLLMC> filterMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x857620", Offset = "0x856A20", VA = "0x180857620", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68A3880", Offset = "0x68A2C80", VA = "0x1868A3880")]
		public InteractionFilterDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override InteractionFilterDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(InteractionFilterDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	public readonly struct ComponentSerializedVersionDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly ComponentSerializedVersionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6895A00", Offset = "0x6894E00", VA = "0x186895A00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ComponentSerializedVersionDataWrapper(Entity entity, ComponentSerializedVersionDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	[Preserve]
	public class ComponentSerializedVersionDataProperties : CODDMBMPNME<ComponentSerializedVersionDataWrapper, ComponentSerializedVersionData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public static readonly EFELFPBBEIB<IFCJCLMMPFC> version;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x68A4B90", Offset = "0x68A3F90", VA = "0x1868A4B90")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly OMGPLJDNBKA<IFCJCLMMPFC> version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x68958B0", Offset = "0x6894CB0", VA = "0x1868958B0")]
		public ComponentSerializedVersionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ComponentSerializedVersionDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ComponentSerializedVersionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	public readonly struct ReferenceGroupOwnerDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly ReferenceGroupOwnerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x68AFA30", Offset = "0x68AEE30", VA = "0x1868AFA30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ReferenceGroupOwnerDataWrapper(Entity entity, ReferenceGroupOwnerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Preserve]
	[CompilerGenerated]
	public class ReferenceGroupOwnerDataProperties : CODDMBMPNME<ReferenceGroupOwnerDataWrapper, ReferenceGroupOwnerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public static readonly EFELFPBBEIB<Entity> owner;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x68A5570", Offset = "0x68A4970", VA = "0x1868A5570")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public readonly OMGPLJDNBKA<Entity> owner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x68AF8E0", Offset = "0x68AECE0", VA = "0x1868AF8E0")]
		public ReferenceGroupOwnerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ReferenceGroupOwnerDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ReferenceGroupOwnerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	public readonly struct MakerPenHeldDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private readonly MakerPenHeldDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x68A4900", Offset = "0x68A3D00", VA = "0x1868A4900", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal MakerPenHeldDataWrapper(Entity entity, MakerPenHeldDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x68A49A0", Offset = "0x68A3DA0", VA = "0x1868A49A0")]
		public bool LCJCOMGJOHB(bool value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[Preserve]
	[CompilerGenerated]
	public class MakerPenHeldDataProperties : CODDMBMPNME<MakerPenHeldDataWrapper, MakerPenHeldData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public static readonly EFELFPBBEIB<bool> makerPenHeld;

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x68A52F0", Offset = "0x68A46F0", VA = "0x1868A52F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly OMGPLJDNBKA<bool> makerPenHeld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x68A47B0", Offset = "0x68A3BB0", VA = "0x1868A47B0")]
		public MakerPenHeldDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override MakerPenHeldDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(MakerPenHeldDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	public readonly struct ToolCleanupSettingsDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private readonly ToolCleanupSettingsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x68B2990", Offset = "0x68B1D90", VA = "0x1868B2990", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ToolCleanupSettingsDataWrapper(Entity entity, ToolCleanupSettingsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x68B2870", Offset = "0x68B1C70", VA = "0x1868B2870")]
		public float AEMKMJLONCJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x68B2930", Offset = "0x68B1D30", VA = "0x1868B2930")]
		public bool CLPJHOAJJJD(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x68B28D0", Offset = "0x68B1CD0", VA = "0x1868B28D0")]
		public LDNKOMNINCP BHKONMMFOFO()
		{
			return default(LDNKOMNINCP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x68B2A30", Offset = "0x68B1E30", VA = "0x1868B2A30")]
		public void LBMEBDEEJFD(LDNKOMNINCP flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Preserve]
	[CompilerGenerated]
	public class ToolCleanupSettingsDataProperties : CODDMBMPNME<ToolCleanupSettingsDataWrapper, ToolCleanupSettingsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public static readonly EFELFPBBEIB<float> delay;

			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public static readonly EFELFPBBEIB<LDNKOMNINCP> toolCleanupFlags;

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x68A4AC0", Offset = "0x68A3EC0", VA = "0x1868A4AC0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly OMGPLJDNBKA<float> delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly OMGPLJDNBKA<LDNKOMNINCP> toolCleanupFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x68B2690", Offset = "0x68B1A90", VA = "0x1868B2690")]
		public ToolCleanupSettingsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ToolCleanupSettingsDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ToolCleanupSettingsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	public readonly struct SplinePointOrderDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly SplinePointOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x68B0FA0", Offset = "0x68B03A0", VA = "0x1868B0FA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal SplinePointOrderDataWrapper(Entity entity, SplinePointOrderDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x68B0F40", Offset = "0x68B0340", VA = "0x1868B0F40")]
		public bool DGMCJALECJM(PGMGELDGJBM value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointOrderDataProperties : CODDMBMPNME<SplinePointOrderDataWrapper, SplinePointOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly EFELFPBBEIB<PGMGELDGJBM> order;

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x68A6A30", Offset = "0x68A5E30", VA = "0x1868A6A30")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly OMGPLJDNBKA<PGMGELDGJBM> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x68B0DF0", Offset = "0x68B01F0", VA = "0x1868B0DF0")]
		public SplinePointOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override SplinePointOrderDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(SplinePointOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	public readonly struct CostumePieceSlotIndexDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private readonly CostumePieceSlotIndexDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x68A3180", Offset = "0x68A2580", VA = "0x1868A3180", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal CostumePieceSlotIndexDataWrapper(Entity entity, CostumePieceSlotIndexDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Preserve]
	[CompilerGenerated]
	public class CostumePieceSlotIndexDataProperties : CODDMBMPNME<CostumePieceSlotIndexDataWrapper, CostumePieceSlotIndexData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly EFELFPBBEIB<int> slotIndex;

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x68A54F0", Offset = "0x68A48F0", VA = "0x1868A54F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly OMGPLJDNBKA<int> slotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x68A3030", Offset = "0x68A2430", VA = "0x1868A3030")]
		public CostumePieceSlotIndexDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override CostumePieceSlotIndexDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(CostumePieceSlotIndexDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	public readonly struct LocalPoseDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly LocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x68A4520", Offset = "0x68A3920", VA = "0x1868A4520", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal LocalPoseDataWrapper(Entity entity, LocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Preserve]
	[CompilerGenerated]
	public class LocalPoseDataProperties : CODDMBMPNME<LocalPoseDataWrapper, LocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly EFELFPBBEIB<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly EFELFPBBEIB<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x68A5F60", Offset = "0x68A5360", VA = "0x1868A5F60")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public readonly OMGPLJDNBKA<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly OMGPLJDNBKA<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x68A4340", Offset = "0x68A3740", VA = "0x1868A4340")]
		public LocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override LocalPoseDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(LocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectActiveStatusDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly ReplicatedObjectActiveStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x68AFE10", Offset = "0x68AF210", VA = "0x1868AFE10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ReplicatedObjectActiveStatusDataWrapper(Entity entity, ReplicatedObjectActiveStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatedObjectActiveStatusDataProperties : CODDMBMPNME<ReplicatedObjectActiveStatusDataWrapper, ReplicatedObjectActiveStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public static readonly EFELFPBBEIB<bool> active;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x68A6280", Offset = "0x68A5680", VA = "0x1868A6280")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public readonly OMGPLJDNBKA<bool> active;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x68AFCC0", Offset = "0x68AF0C0", VA = "0x1868AFCC0")]
		public ReplicatedObjectActiveStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ReplicatedObjectActiveStatusDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ReplicatedObjectActiveStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	public readonly struct ReplicatorPreallocatedObjectCountDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly ReplicatorPreallocatedObjectCountDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x68B0660", Offset = "0x68AFA60", VA = "0x1868B0660", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ReplicatorPreallocatedObjectCountDataWrapper(Entity entity, ReplicatorPreallocatedObjectCountDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatorPreallocatedObjectCountDataProperties : CODDMBMPNME<ReplicatorPreallocatedObjectCountDataWrapper, ReplicatorPreallocatedObjectCountData>
	{
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly EFELFPBBEIB<int> preallocatedCopies;

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x68A5C90", Offset = "0x68A5090", VA = "0x1868A5C90")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly OMGPLJDNBKA<int> preallocatedCopies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x68B0510", Offset = "0x68AF910", VA = "0x1868B0510")]
		public ReplicatorPreallocatedObjectCountDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ReplicatorPreallocatedObjectCountDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ReplicatorPreallocatedObjectCountDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16379038427767722229uL)]
	[global::BPMCLJHLDME]
	public struct ReplicatorPreallocatedObjectCountData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[global::AKOGMCGBMOC(1)]
		public int PreallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	public readonly struct SplinePointRotationDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly SplinePointRotationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x68B1760", Offset = "0x68B0B60", VA = "0x1868B1760", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal SplinePointRotationDataWrapper(Entity entity, SplinePointRotationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x68B16F0", Offset = "0x68B0AF0", VA = "0x1868B16F0")]
		public quaternion DKODOAPNMJE()
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x68B1800", Offset = "0x68B0C00", VA = "0x1868B1800")]
		public bool GFCOBDJPAGK(quaternion value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointRotationDataProperties : CODDMBMPNME<SplinePointRotationDataWrapper, SplinePointRotationData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly EFELFPBBEIB<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x68A50F0", Offset = "0x68A44F0", VA = "0x1868A50F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly OMGPLJDNBKA<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x68B15A0", Offset = "0x68B09A0", VA = "0x1868B15A0")]
		public SplinePointRotationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override SplinePointRotationDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(SplinePointRotationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	public readonly struct InteractionFilterAllTagsDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly InteractionFilterAllTagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x68A35F0", Offset = "0x68A29F0", VA = "0x1868A35F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal InteractionFilterAllTagsDataWrapper(Entity entity, InteractionFilterAllTagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterAllTagsDataProperties : CODDMBMPNME<InteractionFilterAllTagsDataWrapper, InteractionFilterAllTagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly EFELFPBBEIB<Entity> allTags;

			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x68A5270", Offset = "0x68A4670", VA = "0x1868A5270")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public readonly OMGPLJDNBKA<Entity> allTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x68A34A0", Offset = "0x68A28A0", VA = "0x1868A34A0")]
		public InteractionFilterAllTagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override InteractionFilterAllTagsDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(InteractionFilterAllTagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	public readonly struct ToolCleanupStatusDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly ToolCleanupStatusDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x68B2CC0", Offset = "0x68B20C0", VA = "0x1868B2CC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ToolCleanupStatusDataWrapper(Entity entity, ToolCleanupStatusDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[Preserve]
	[CompilerGenerated]
	public class ToolCleanupStatusDataProperties : CODDMBMPNME<ToolCleanupStatusDataWrapper, ToolCleanupStatusData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public static readonly EFELFPBBEIB<float> cleanupStartTime;

			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public static readonly EFELFPBBEIB<IDDELHIKEKM> statusFlags;

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x68A57F0", Offset = "0x68A4BF0", VA = "0x1868A57F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly OMGPLJDNBKA<float> cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly OMGPLJDNBKA<IDDELHIKEKM> statusFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x68B2AE0", Offset = "0x68B1EE0", VA = "0x1868B2AE0")]
		public ToolCleanupStatusDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ToolCleanupStatusDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ToolCleanupStatusDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[TypeManager.ForcedStableTypeHash(13767281615497948129uL)]
	[CompilerGenerated]
	[global::BPMCLJHLDME]
	public struct ToolCleanupStatusData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[global::AKOGMCGBMOC(1)]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[global::AKOGMCGBMOC(2)]
		public bool forceCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[global::AKOGMCGBMOC(3)]
		public bool cleanupDone;
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	public readonly struct InteractionFilterAnyTagsDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private readonly InteractionFilterAnyTagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x68A37E0", Offset = "0x68A2BE0", VA = "0x1868A37E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal InteractionFilterAnyTagsDataWrapper(Entity entity, InteractionFilterAnyTagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	[Preserve]
	public class InteractionFilterAnyTagsDataProperties : CODDMBMPNME<InteractionFilterAnyTagsDataWrapper, InteractionFilterAnyTagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public static readonly EFELFPBBEIB<Entity> anyTags;

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x68A5170", Offset = "0x68A4570", VA = "0x1868A5170")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly OMGPLJDNBKA<Entity> anyTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x68A3690", Offset = "0x68A2A90", VA = "0x1868A3690")]
		public InteractionFilterAnyTagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override InteractionFilterAnyTagsDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(InteractionFilterAnyTagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	public readonly struct SplinePointPositionDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly SplinePointPositionDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x68B1410", Offset = "0x68B0810", VA = "0x1868B1410", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal SplinePointPositionDataWrapper(Entity entity, SplinePointPositionDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x68B14B0", Offset = "0x68B08B0", VA = "0x1868B14B0")]
		public float3 KCJKFAJODMB()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x68B1530", Offset = "0x68B0930", VA = "0x1868B1530")]
		public bool NKPNONEPEAH(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[Preserve]
	[CompilerGenerated]
	public class SplinePointPositionDataProperties : CODDMBMPNME<SplinePointPositionDataWrapper, SplinePointPositionData>
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public static readonly EFELFPBBEIB<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x68A4C90", Offset = "0x68A4090", VA = "0x1868A4C90")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public readonly OMGPLJDNBKA<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x68B12C0", Offset = "0x68B06C0", VA = "0x1868B12C0")]
		public SplinePointPositionDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override SplinePointPositionDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(SplinePointPositionDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	public readonly struct ShapeTypeDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private readonly ShapeTypeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public GGMABPBLDNH shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x68B0B00", Offset = "0x68AFF00", VA = "0x1868B0B00")]
			get
			{
				return default(GGMABPBLDNH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x68B0B60", Offset = "0x68AFF60", VA = "0x1868B0B60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ShapeTypeDataWrapper(Entity entity, ShapeTypeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[Preserve]
	[CompilerGenerated]
	public class ShapeTypeDataProperties : CODDMBMPNME<ShapeTypeDataWrapper, ShapeTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public static readonly EFELFPBBEIB<GGMABPBLDNH> shapeType;

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x68A59C0", Offset = "0x68A4DC0", VA = "0x1868A59C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public readonly OMGPLJDNBKA<GGMABPBLDNH> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x68B09B0", Offset = "0x68AFDB0", VA = "0x1868B09B0")]
		public ShapeTypeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ShapeTypeDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ShapeTypeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	public readonly struct PrimitiveShapeDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private readonly PrimitiveShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ODHNMDGHJAA shapeType
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x68AF590", Offset = "0x68AE990", VA = "0x1868AF590")]
			get
			{
				return default(ODHNMDGHJAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x68AF650", Offset = "0x68AEA50", VA = "0x1868AF650", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal PrimitiveShapeDataWrapper(Entity entity, PrimitiveShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x68AF5F0", Offset = "0x68AE9F0", VA = "0x1868AF5F0")]
		public ODHNMDGHJAA DCAOCDLEFJL()
		{
			return default(ODHNMDGHJAA);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[Preserve]
	[CompilerGenerated]
	public class PrimitiveShapeDataProperties : CODDMBMPNME<PrimitiveShapeDataWrapper, PrimitiveShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public static readonly EFELFPBBEIB<ODHNMDGHJAA> shapeType;

			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x68A5B90", Offset = "0x68A4F90", VA = "0x1868A5B90")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public readonly OMGPLJDNBKA<ODHNMDGHJAA> shapeType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x68AF440", Offset = "0x68AE840", VA = "0x1868AF440")]
		public PrimitiveShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override PrimitiveShapeDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(PrimitiveShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	public readonly struct ReplicatorDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly ReplicatorDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x68B0280", Offset = "0x68AF680", VA = "0x1868B0280", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ReplicatorDataWrapper(Entity entity, ReplicatorDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[Preserve]
	[CompilerGenerated]
	public class ReplicatorDataProperties : CODDMBMPNME<ReplicatorDataWrapper, ReplicatorData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public static readonly EFELFPBBEIB<Entity> Target;

			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public static readonly EFELFPBBEIB<bool> NeedsCircuitUpdate;

			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x68A6710", Offset = "0x68A5B10", VA = "0x1868A6710")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public readonly OMGPLJDNBKA<Entity> Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly OMGPLJDNBKA<bool> NeedsCircuitUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x68B00A0", Offset = "0x68AF4A0", VA = "0x1868B00A0")]
		public ReplicatorDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ReplicatorDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ReplicatorDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[global::BPMCLJHLDME]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11853296779717712500uL)]
	public struct ReplicatorData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[global::AKOGMCGBMOC(1)]
		public Entity Target;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	public readonly struct PlayerScopeDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly PlayerScopeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x68AF3A0", Offset = "0x68AE7A0", VA = "0x1868AF3A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal PlayerScopeDataWrapper(Entity entity, PlayerScopeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[Preserve]
	[CompilerGenerated]
	public class PlayerScopeDataProperties : CODDMBMPNME<PlayerScopeDataWrapper, PlayerScopeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly EFELFPBBEIB<Entity> playerScope;

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x68A5070", Offset = "0x68A4470", VA = "0x1868A5070")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public readonly OMGPLJDNBKA<Entity> playerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x68AF250", Offset = "0x68AE650", VA = "0x1868AF250")]
		public PlayerScopeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override PlayerScopeDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(PlayerScopeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	public readonly struct EntityBundlePartDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly EntityBundlePartDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x68A3400", Offset = "0x68A2800", VA = "0x1868A3400", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal EntityBundlePartDataWrapper(Entity entity, EntityBundlePartDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[Preserve]
	[CompilerGenerated]
	public class EntityBundlePartDataProperties : CODDMBMPNME<EntityBundlePartDataWrapper, EntityBundlePartData>
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public static readonly EFELFPBBEIB<Entity> prefabRoot;

			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public static readonly EFELFPBBEIB<uint> entityBundlePartId;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x68A60B0", Offset = "0x68A54B0", VA = "0x1868A60B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public readonly OMGPLJDNBKA<Entity> prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public readonly OMGPLJDNBKA<uint> entityBundlePartId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x68A3220", Offset = "0x68A2620", VA = "0x1868A3220")]
		public EntityBundlePartDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override EntityBundlePartDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(EntityBundlePartDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	public readonly struct ReplicatedObjectOwnedByPlayerDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly ReplicatedObjectOwnedByPlayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x68B0000", Offset = "0x68AF400", VA = "0x1868B0000", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ReplicatedObjectOwnedByPlayerDataWrapper(Entity entity, ReplicatedObjectOwnedByPlayerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatedObjectOwnedByPlayerDataProperties : CODDMBMPNME<ReplicatedObjectOwnedByPlayerDataWrapper, ReplicatedObjectOwnedByPlayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public static readonly EFELFPBBEIB<int> actorId;

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x68A6540", Offset = "0x68A5940", VA = "0x1868A6540")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public readonly OMGPLJDNBKA<int> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x68AFEB0", Offset = "0x68AF2B0", VA = "0x1868AFEB0")]
		public ReplicatedObjectOwnedByPlayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ReplicatedObjectOwnedByPlayerDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ReplicatedObjectOwnedByPlayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	public readonly struct OMShapeContainerDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly OMShapeContainerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x68ADFF0", Offset = "0x68AD3F0", VA = "0x1868ADFF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal OMShapeContainerDataWrapper(Entity entity, OMShapeContainerDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[Preserve]
	[CompilerGenerated]
	public class OMShapeContainerDataProperties : CODDMBMPNME<OMShapeContainerDataWrapper, OMShapeContainerData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public static readonly EFELFPBBEIB<bool> canModifyWithCircuits;

			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public static readonly EFELFPBBEIB<bool> optimizedCollidersEnabled;

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x68A4A00", Offset = "0x68A3E00", VA = "0x1868A4A00")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public readonly OMGPLJDNBKA<bool> canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public readonly OMGPLJDNBKA<bool> optimizedCollidersEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x68ADE20", Offset = "0x68AD220", VA = "0x1868ADE20")]
		public OMShapeContainerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override OMShapeContainerDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(OMShapeContainerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	[global::BPMCLJHLDME]
	[TypeManager.ForcedStableTypeHash(6047901070934821887uL)]
	public struct OMShapeContainerData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[global::AKOGMCGBMOC(1)]
		public int physicsMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[global::AKOGMCGBMOC(2)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[global::AKOGMCGBMOC(3)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CompilerGenerated]
	public readonly struct AuthoredParentDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private readonly AuthoredParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6895620", Offset = "0x6894A20", VA = "0x186895620", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal AuthoredParentDataWrapper(Entity entity, AuthoredParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredParentDataProperties : CODDMBMPNME<AuthoredParentDataWrapper, AuthoredParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public static readonly EFELFPBBEIB<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x68A6380", Offset = "0x68A5780", VA = "0x1868A6380")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public readonly OMGPLJDNBKA<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x68954D0", Offset = "0x68948D0", VA = "0x1868954D0")]
		public AuthoredParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override AuthoredParentDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(AuthoredParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	public readonly struct UserTagNameDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private readonly UserTagNameDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x68B3130", Offset = "0x68B2530", VA = "0x1868B3130", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal UserTagNameDataWrapper(Entity entity, UserTagNameDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[CompilerGenerated]
	[Preserve]
	public class UserTagNameDataProperties : CODDMBMPNME<UserTagNameDataWrapper, UserTagNameData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public static readonly EFELFPBBEIB<FixedString32Bytes> Value;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x68A6200", Offset = "0x68A5600", VA = "0x1868A6200")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public readonly OMGPLJDNBKA<FixedString32Bytes> Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x68B2FE0", Offset = "0x68B23E0", VA = "0x1868B2FE0")]
		public UserTagNameDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override UserTagNameDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(UserTagNameDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	public readonly struct NavMeshGenerationDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private readonly NavMeshGenerationDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x68A6DC0", Offset = "0x68A61C0", VA = "0x1868A6DC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal NavMeshGenerationDataWrapper(Entity entity, NavMeshGenerationDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x68A6D00", Offset = "0x68A6100", VA = "0x1868A6D00")]
		public JOPBHOLNLCN BBDELBOMFBM()
		{
			return default(JOPBHOLNLCN);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x68A6D60", Offset = "0x68A6160", VA = "0x1868A6D60")]
		public bool EKHAPJHPIDD(JOPBHOLNLCN value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CompilerGenerated]
	[Preserve]
	public class NavMeshGenerationDataProperties : CODDMBMPNME<NavMeshGenerationDataWrapper, NavMeshGenerationData>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public static readonly EFELFPBBEIB<JOPBHOLNLCN> mode;

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x68A5EE0", Offset = "0x68A52E0", VA = "0x1868A5EE0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public readonly OMGPLJDNBKA<JOPBHOLNLCN> mode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x68A6BB0", Offset = "0x68A5FB0", VA = "0x1868A6BB0")]
		public NavMeshGenerationDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override NavMeshGenerationDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(NavMeshGenerationDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CompilerGenerated]
	public readonly struct ContainerNameDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly ContainerNameDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x68A2CA0", Offset = "0x68A20A0", VA = "0x1868A2CA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ContainerNameDataWrapper(Entity entity, ContainerNameDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x68A2D40", Offset = "0x68A2140", VA = "0x1868A2D40")]
		public FixedString64Bytes FCDEMIMAHJM()
		{
			return default(FixedString64Bytes);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x68A2DD0", Offset = "0x68A21D0", VA = "0x1868A2DD0")]
		public bool IDEGPHBDLNF(FixedString64Bytes value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerNameDataProperties : CODDMBMPNME<ContainerNameDataWrapper, ContainerNameData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public static readonly EFELFPBBEIB<FixedString64Bytes> name;

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x68A6400", Offset = "0x68A5800", VA = "0x1868A6400")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public readonly OMGPLJDNBKA<FixedString64Bytes> name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x68A2B50", Offset = "0x68A1F50", VA = "0x1868A2B50")]
		public ContainerNameDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ContainerNameDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ContainerNameDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	public readonly struct ShapeConfigDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly ShapeConfigDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x68B0850", Offset = "0x68AFC50", VA = "0x1868B0850", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ShapeConfigDataWrapper(Entity entity, ShapeConfigDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x68B0950", Offset = "0x68AFD50", VA = "0x1868B0950")]
		public NCEKBJACAFC ILEIPMOPAKK()
		{
			return default(NCEKBJACAFC);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x68B08F0", Offset = "0x68AFCF0", VA = "0x1868B08F0")]
		public bool FBDKJKOEIDH(NCEKBJACAFC value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CompilerGenerated]
	[Preserve]
	public class ShapeConfigDataProperties : CODDMBMPNME<ShapeConfigDataWrapper, ShapeConfigData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public static readonly EFELFPBBEIB<NCEKBJACAFC> flags;

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x68A6AB0", Offset = "0x68A5EB0", VA = "0x1868A6AB0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public readonly OMGPLJDNBKA<NCEKBJACAFC> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x68B0700", Offset = "0x68AFB00", VA = "0x1868B0700")]
		public ShapeConfigDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ShapeConfigDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ShapeConfigDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	public readonly struct ParentDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private readonly ParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x68AECE0", Offset = "0x68AE0E0", VA = "0x1868AECE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ParentDataWrapper(Entity entity, ParentDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	[Preserve]
	public class ParentDataProperties : CODDMBMPNME<ParentDataWrapper, ParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public static readonly EFELFPBBEIB<Entity> parent;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x68A6300", Offset = "0x68A5700", VA = "0x1868A6300")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public readonly OMGPLJDNBKA<Entity> parent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x68AEB90", Offset = "0x68ADF90", VA = "0x1868AEB90")]
		public ParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ParentDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[CompilerGenerated]
	public readonly struct ReplicatorMaxObjectCountDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private readonly ReplicatorMaxObjectCountDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x68B0470", Offset = "0x68AF870", VA = "0x1868B0470", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ReplicatorMaxObjectCountDataWrapper(Entity entity, ReplicatorMaxObjectCountDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	[Preserve]
	public class ReplicatorMaxObjectCountDataProperties : CODDMBMPNME<ReplicatorMaxObjectCountDataWrapper, ReplicatorMaxObjectCountData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public static readonly EFELFPBBEIB<int> MaxCopies;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x68A5940", Offset = "0x68A4D40", VA = "0x1868A5940")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly OMGPLJDNBKA<int> MaxCopies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x68B0320", Offset = "0x68AF720", VA = "0x1868B0320")]
		public ReplicatorMaxObjectCountDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ReplicatorMaxObjectCountDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ReplicatorMaxObjectCountDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	public readonly struct ContainerMassOverrideDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly ContainerMassOverrideDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x68A2A50", Offset = "0x68A1E50", VA = "0x1868A2A50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ContainerMassOverrideDataWrapper(Entity entity, ContainerMassOverrideDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x68A2AF0", Offset = "0x68A1EF0", VA = "0x1868A2AF0")]
		public float HOPCDEBOMPF()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x68A29F0", Offset = "0x68A1DF0", VA = "0x1868A29F0")]
		public bool DCOOLAMAFIE(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerMassOverrideDataProperties : CODDMBMPNME<ContainerMassOverrideDataWrapper, ContainerMassOverrideData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public static readonly EFELFPBBEIB<float> mass;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x68A5B10", Offset = "0x68A4F10", VA = "0x1868A5B10")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public readonly OMGPLJDNBKA<float> mass;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x68A28A0", Offset = "0x68A1CA0", VA = "0x1868A28A0")]
		public ContainerMassOverrideDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ContainerMassOverrideDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ContainerMassOverrideDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalPoseDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly AuthoredLocalPoseDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6895230", Offset = "0x6894630", VA = "0x186895230", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal AuthoredLocalPoseDataWrapper(Entity entity, AuthoredLocalPoseDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredLocalPoseDataProperties : CODDMBMPNME<AuthoredLocalPoseDataWrapper, AuthoredLocalPoseData>
	{
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public static readonly EFELFPBBEIB<quaternion> localRotation;

			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public static readonly EFELFPBBEIB<float3> localPosition;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x68A5A40", Offset = "0x68A4E40", VA = "0x1868A5A40")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly OMGPLJDNBKA<quaternion> localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public readonly OMGPLJDNBKA<float3> localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6895050", Offset = "0x6894450", VA = "0x186895050")]
		public AuthoredLocalPoseDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override AuthoredLocalPoseDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(AuthoredLocalPoseDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[CompilerGenerated]
	public readonly struct ObjectBoardNodeDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private readonly ObjectBoardNodeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x68AE260", Offset = "0x68AD660", VA = "0x1868AE260", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ObjectBoardNodeDataWrapper(Entity entity, ObjectBoardNodeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectBoardNodeDataProperties : CODDMBMPNME<ObjectBoardNodeDataWrapper, ObjectBoardNodeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly EFELFPBBEIB<NetworkGuid> nodeId;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly EFELFPBBEIB<NetworkGuid> graphId;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x68A6480", Offset = "0x68A5880", VA = "0x1868A6480")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public readonly OMGPLJDNBKA<NetworkGuid> nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public readonly OMGPLJDNBKA<NetworkGuid> graphId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x68AE090", Offset = "0x68AD490", VA = "0x1868AE090")]
		public ObjectBoardNodeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ObjectBoardNodeDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ObjectBoardNodeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CompilerGenerated]
	public readonly struct AuthoredLocalUniformScaleDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private readonly AuthoredLocalUniformScaleDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6895430", Offset = "0x6894830", VA = "0x186895430", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal AuthoredLocalUniformScaleDataWrapper(Entity entity, AuthoredLocalUniformScaleDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredLocalUniformScaleDataProperties : CODDMBMPNME<AuthoredLocalUniformScaleDataWrapper, AuthoredLocalUniformScaleData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public static readonly EFELFPBBEIB<float> localUniformScale;

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x68A6180", Offset = "0x68A5580", VA = "0x1868A6180")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public readonly OMGPLJDNBKA<float> localUniformScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x68952E0", Offset = "0x68946E0", VA = "0x1868952E0")]
		public AuthoredLocalUniformScaleDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override AuthoredLocalUniformScaleDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(AuthoredLocalUniformScaleDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[CompilerGenerated]
	public readonly struct StandardRenderableVisualDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private readonly StandardRenderableVisualDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public BCIFPAJHDBK color
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x68B24B0", Offset = "0x68B18B0", VA = "0x1868B24B0")]
			get
			{
				return default(BCIFPAJHDBK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public IEFIEIOEMOK material
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x68B2510", Offset = "0x68B1910", VA = "0x1868B2510")]
			get
			{
				return default(IEFIEIOEMOK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float uvScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x68B2570", Offset = "0x68B1970", VA = "0x1868B2570")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public float3 uvOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x68B2350", Offset = "0x68B1750", VA = "0x1868B2350")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x68B22B0", Offset = "0x68B16B0", VA = "0x1868B22B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal StandardRenderableVisualDataWrapper(Entity entity, StandardRenderableVisualDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x68B2630", Offset = "0x68B1A30", VA = "0x1868B2630")]
		public BCIFPAJHDBK NNDHMAIIFLA()
		{
			return default(BCIFPAJHDBK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x68B2450", Offset = "0x68B1850", VA = "0x1868B2450")]
		public bool JDMOONJGEKB(BCIFPAJHDBK value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x68B25D0", Offset = "0x68B19D0", VA = "0x1868B25D0")]
		public IEFIEIOEMOK NLKLHIFCMNP()
		{
			return default(IEFIEIOEMOK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x68B21F0", Offset = "0x68B15F0", VA = "0x1868B21F0")]
		public bool DGEECKPAPNA(IEFIEIOEMOK value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x68B2250", Offset = "0x68B1650", VA = "0x1868B2250")]
		public float EKLJCDODLJD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x68B2190", Offset = "0x68B1590", VA = "0x1868B2190")]
		public bool BPGAPAGAEMG(float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x68B23D0", Offset = "0x68B17D0", VA = "0x1868B23D0")]
		public float3 ICJMCEIBPDO()
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x68B2120", Offset = "0x68B1520", VA = "0x1868B2120")]
		public bool BOBMHCHJCIE(float3 value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[Preserve]
	[CompilerGenerated]
	public class StandardRenderableVisualDataProperties : CODDMBMPNME<StandardRenderableVisualDataWrapper, StandardRenderableVisualData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public static readonly EFELFPBBEIB<BCIFPAJHDBK> color;

			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly EFELFPBBEIB<IEFIEIOEMOK> material;

			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public static readonly EFELFPBBEIB<float> uvScale;

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly EFELFPBBEIB<float3> uvOffset;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x68A67E0", Offset = "0x68A5BE0", VA = "0x1868A67E0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public readonly OMGPLJDNBKA<BCIFPAJHDBK> color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public readonly OMGPLJDNBKA<IEFIEIOEMOK> material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly OMGPLJDNBKA<float> uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly OMGPLJDNBKA<float3> uvOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x854190", Offset = "0x853590", VA = "0x180854190", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x68B1E30", Offset = "0x68B1230", VA = "0x1868B1E30")]
		public StandardRenderableVisualDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override StandardRenderableVisualDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(StandardRenderableVisualDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionLayerDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private readonly ContainerCollisionLayerDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x68A1EE0", Offset = "0x68A12E0", VA = "0x1868A1EE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ContainerCollisionLayerDataWrapper(Entity entity, ContainerCollisionLayerDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x68A1F80", Offset = "0x68A1380", VA = "0x1868A1F80")]
		public CGABIILCBOJ OOMCHFDJNMJ()
		{
			return default(CGABIILCBOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x68A1E80", Offset = "0x68A1280", VA = "0x1868A1E80")]
		public bool DMHOOKOLFKO(CGABIILCBOJ value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerCollisionLayerDataProperties : CODDMBMPNME<ContainerCollisionLayerDataWrapper, ContainerCollisionLayerData>
	{
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public static readonly EFELFPBBEIB<CGABIILCBOJ> collisionLayer;

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x68A55F0", Offset = "0x68A49F0", VA = "0x1868A55F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public readonly OMGPLJDNBKA<CGABIILCBOJ> collisionLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x68A1D30", Offset = "0x68A1130", VA = "0x1868A1D30")]
		public ContainerCollisionLayerDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ContainerCollisionLayerDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ContainerCollisionLayerDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	public readonly struct InteractionFilterNoneTagsDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly InteractionFilterNoneTagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x68A40B0", Offset = "0x68A34B0", VA = "0x1868A40B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal InteractionFilterNoneTagsDataWrapper(Entity entity, InteractionFilterNoneTagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[Preserve]
	[CompilerGenerated]
	public class InteractionFilterNoneTagsDataProperties : CODDMBMPNME<InteractionFilterNoneTagsDataWrapper, InteractionFilterNoneTagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly EFELFPBBEIB<Entity> noneTags;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x68A58C0", Offset = "0x68A4CC0", VA = "0x1868A58C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public readonly OMGPLJDNBKA<Entity> noneTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x68A3F60", Offset = "0x68A3360", VA = "0x1868A3F60")]
		public InteractionFilterNoneTagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override InteractionFilterNoneTagsDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(InteractionFilterNoneTagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[CompilerGenerated]
	public readonly struct SiblingSortOrderDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private readonly SiblingSortOrderDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x68B0D50", Offset = "0x68B0150", VA = "0x1868B0D50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal SiblingSortOrderDataWrapper(Entity entity, SiblingSortOrderDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[Preserve]
	[CompilerGenerated]
	public class SiblingSortOrderDataProperties : CODDMBMPNME<SiblingSortOrderDataWrapper, SiblingSortOrderData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public static readonly EFELFPBBEIB<PGMGELDGJBM> order;

			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x68A5470", Offset = "0x68A4870", VA = "0x1868A5470")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public readonly OMGPLJDNBKA<PGMGELDGJBM> order;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x68B0C00", Offset = "0x68B0000", VA = "0x1868B0C00")]
		public SiblingSortOrderDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override SiblingSortOrderDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(SiblingSortOrderDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[CompilerGenerated]
	public readonly struct ContainerGrabbableModeDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly ContainerGrabbableModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x68A27A0", Offset = "0x68A1BA0", VA = "0x1868A27A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ContainerGrabbableModeDataWrapper(Entity entity, ContainerGrabbableModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x68A2840", Offset = "0x68A1C40", VA = "0x1868A2840")]
		public JHABCFCICMM OKBLKJLDGLL()
		{
			return default(JHABCFCICMM);
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x68A2740", Offset = "0x68A1B40", VA = "0x1868A2740")]
		public bool CMOJEIFKGME(JHABCFCICMM value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerGrabbableModeDataProperties : CODDMBMPNME<ContainerGrabbableModeDataWrapper, ContainerGrabbableModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public static readonly EFELFPBBEIB<JHABCFCICMM> grabbableMode;

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x68A69B0", Offset = "0x68A5DB0", VA = "0x1868A69B0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public readonly OMGPLJDNBKA<JHABCFCICMM> grabbableMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x68A25F0", Offset = "0x68A19F0", VA = "0x1868A25F0")]
		public ContainerGrabbableModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ContainerGrabbableModeDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ContainerGrabbableModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[CompilerGenerated]
	public readonly struct CostumePieceParentCostumeDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private readonly CostumePieceParentCostumeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x68A2F90", Offset = "0x68A2390", VA = "0x1868A2F90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal CostumePieceParentCostumeDataWrapper(Entity entity, CostumePieceParentCostumeDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[CompilerGenerated]
	[Preserve]
	public class CostumePieceParentCostumeDataProperties : CODDMBMPNME<CostumePieceParentCostumeDataWrapper, CostumePieceParentCostumeData>
	{
		[Cpp2IlInjected.Token(Token = "0x2000097")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public static readonly EFELFPBBEIB<Entity> parentCostume;

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x68A4E60", Offset = "0x68A4260", VA = "0x1868A4E60")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public readonly OMGPLJDNBKA<Entity> parentCostume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x68A2E40", Offset = "0x68A2240", VA = "0x1868A2E40")]
		public CostumePieceParentCostumeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override CostumePieceParentCostumeDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(CostumePieceParentCostumeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	public readonly struct AuthoredUserTagReferenceBufferWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly AuthoredUserTagReferenceBufferProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6895810", Offset = "0x6894C10", VA = "0x186895810", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal AuthoredUserTagReferenceBufferWrapper(Entity entity, AuthoredUserTagReferenceBufferProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	[Preserve]
	public class AuthoredUserTagReferenceBufferProperties : AAPAFNCKCCE<AuthoredUserTagReferenceBufferWrapper, AuthoredUserTagReferenceBuffer>
	{
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly EFELFPBBEIB<Entity> Child;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x68A5D90", Offset = "0x68A5190", VA = "0x1868A5D90")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly ACKJDPHDCJD<AuthoredUserTagReferenceBuffer, Entity> Child;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x68956C0", Offset = "0x6894AC0", VA = "0x1868956C0")]
		public AuthoredUserTagReferenceBufferProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override AuthoredUserTagReferenceBufferWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(AuthoredUserTagReferenceBufferWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[CompilerGenerated]
	public readonly struct SplineShapeDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly SplineShapeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x68B1CA0", Offset = "0x68B10A0", VA = "0x1868B1CA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal SplineShapeDataWrapper(Entity entity, SplineShapeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x68B1DB0", Offset = "0x68B11B0", VA = "0x1868B1DB0")]
		public CFHMDFBLJPE MMNEOCEJKPD()
		{
			return default(CFHMDFBLJPE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x68B1D40", Offset = "0x68B1140", VA = "0x1868B1D40")]
		public bool GECJIEBOMKG(CFHMDFBLJPE value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[Preserve]
	[CompilerGenerated]
	public class SplineShapeDataProperties : CODDMBMPNME<SplineShapeDataWrapper, SplineShapeData>
	{
		[Cpp2IlInjected.Token(Token = "0x200009D")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly EFELFPBBEIB<CFHMDFBLJPE> parameters;

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x68A51F0", Offset = "0x68A45F0", VA = "0x1868A51F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public readonly OMGPLJDNBKA<CFHMDFBLJPE> parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x68B1B50", Offset = "0x68B0F50", VA = "0x1868B1B50")]
		public SplineShapeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override SplineShapeDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(SplineShapeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[CompilerGenerated]
	public readonly struct TransformFlagsDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private readonly TransformFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x68B2F40", Offset = "0x68B2340", VA = "0x1868B2F40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal TransformFlagsDataWrapper(Entity entity, TransformFlagsDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[CompilerGenerated]
	[Preserve]
	public class TransformFlagsDataProperties : CODDMBMPNME<TransformFlagsDataWrapper, TransformFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A0")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly EFELFPBBEIB<IKGDMPNIILI> transformHint;

			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly EFELFPBBEIB<DHLGKMANIDB> transformPriority;

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x68A5E10", Offset = "0x68A5210", VA = "0x1868A5E10")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public readonly OMGPLJDNBKA<IKGDMPNIILI> transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public readonly OMGPLJDNBKA<DHLGKMANIDB> transformPriority;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x8541C0", Offset = "0x8535C0", VA = "0x1808541C0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x68B2D60", Offset = "0x68B2160", VA = "0x1868B2D60")]
		public TransformFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override TransformFlagsDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(TransformFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[CompilerGenerated]
	public readonly struct ContainerFlagsDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly ContainerFlagsDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x68A24F0", Offset = "0x68A18F0", VA = "0x1868A24F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ContainerFlagsDataWrapper(Entity entity, ContainerFlagsDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x68A2590", Offset = "0x68A1990", VA = "0x1868A2590")]
		public DAMGCJMCCIG ILEIPMOPAKK()
		{
			return default(DAMGCJMCCIG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x68A2440", Offset = "0x68A1840", VA = "0x1868A2440")]
		public void BHLMDFBCANI(DAMGCJMCCIG flag, bool enable)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[Preserve]
	[CompilerGenerated]
	public class ContainerFlagsDataProperties : CODDMBMPNME<ContainerFlagsDataWrapper, ContainerFlagsData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A3")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public static readonly EFELFPBBEIB<DAMGCJMCCIG> flags;

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x68A56F0", Offset = "0x68A4AF0", VA = "0x1868A56F0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public readonly OMGPLJDNBKA<DAMGCJMCCIG> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x68A22F0", Offset = "0x68A16F0", VA = "0x1868A22F0")]
		public ContainerFlagsDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ContainerFlagsDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ContainerFlagsDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[TypeManager.ForcedStableTypeHash(5697233450128812374uL)]
	[CompilerGenerated]
	[global::BPMCLJHLDME]
	public struct ContainerFlagsData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[global::AKOGMCGBMOC(1)]
		public DAMGCJMCCIG flags;
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[CompilerGenerated]
	public readonly struct ContainerCollisionModeDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private readonly ContainerCollisionModeDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public MPLDKJGCKEE collisionMode
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x68A2130", Offset = "0x68A1530", VA = "0x1868A2130")]
			get
			{
				return default(MPLDKJGCKEE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x68A2190", Offset = "0x68A1590", VA = "0x1868A2190", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ContainerCollisionModeDataWrapper(Entity entity, ContainerCollisionModeDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x68A2290", Offset = "0x68A1690", VA = "0x1868A2290")]
		public MPLDKJGCKEE NILNFKEEMHM()
		{
			return default(MPLDKJGCKEE);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x68A2230", Offset = "0x68A1630", VA = "0x1868A2230")]
		public bool GOKCNPCBFJC(MPLDKJGCKEE value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[CompilerGenerated]
	[Preserve]
	public class ContainerCollisionModeDataProperties : CODDMBMPNME<ContainerCollisionModeDataWrapper, ContainerCollisionModeData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			public static readonly EFELFPBBEIB<MPLDKJGCKEE> collisionMode;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x68A4D10", Offset = "0x68A4110", VA = "0x1868A4D10")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public readonly OMGPLJDNBKA<MPLDKJGCKEE> collisionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x68A1FE0", Offset = "0x68A13E0", VA = "0x1868A1FE0")]
		public ContainerCollisionModeDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ContainerCollisionModeDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ContainerCollisionModeDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	public readonly struct InteractionFilterEntityRefDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private readonly InteractionFilterEntityRefDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x68A3EC0", Offset = "0x68A32C0", VA = "0x1868A3EC0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal InteractionFilterEntityRefDataWrapper(Entity entity, InteractionFilterEntityRefDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	[Preserve]
	public class InteractionFilterEntityRefDataProperties : CODDMBMPNME<InteractionFilterEntityRefDataWrapper, InteractionFilterEntityRefData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public static readonly EFELFPBBEIB<Entity> filterEntity;

			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x68A5670", Offset = "0x68A4A70", VA = "0x1868A5670")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public readonly OMGPLJDNBKA<Entity> filterEntity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x68A3D70", Offset = "0x68A3170", VA = "0x1868A3D70")]
		public InteractionFilterEntityRefDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override InteractionFilterEntityRefDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(InteractionFilterEntityRefDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	public readonly struct PhysicsMaterialDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private readonly PhysicsMaterialDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x68AF150", Offset = "0x68AE550", VA = "0x1868AF150", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal PhysicsMaterialDataWrapper(Entity entity, PhysicsMaterialDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x68AF1F0", Offset = "0x68AE5F0", VA = "0x1868AF1F0")]
		public bool GGHODCONMML(float value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	[Preserve]
	public class PhysicsMaterialDataProperties : CODDMBMPNME<PhysicsMaterialDataWrapper, PhysicsMaterialData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400013A")]
			public static readonly EFELFPBBEIB<float> density;

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x68A5770", Offset = "0x68A4B70", VA = "0x1868A5770")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public readonly OMGPLJDNBKA<float> density;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x68AF000", Offset = "0x68AE400", VA = "0x1868AF000")]
		public PhysicsMaterialDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override PhysicsMaterialDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(PhysicsMaterialDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[CompilerGenerated]
	public readonly struct ObjectPolicyDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private readonly ObjectPolicyDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public HEBJPGKPDLA scaleRestriction
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x68AE870", Offset = "0x68ADC70", VA = "0x1868AE870")]
			get
			{
				return default(HEBJPGKPDLA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x68AE5F0", Offset = "0x68AD9F0", VA = "0x1868AE5F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ObjectPolicyDataWrapper(Entity entity, ObjectPolicyDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x68AE7B0", Offset = "0x68ADBB0", VA = "0x1868AE7B0")]
		public ODOPAAAPLKE ILEIPMOPAKK()
		{
			return default(ODOPAAAPLKE);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x68AE6F0", Offset = "0x68ADAF0", VA = "0x1868AE6F0")]
		public NBGHNPHLDEF GIGPIPCEIOG()
		{
			return default(NBGHNPHLDEF);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x68AE810", Offset = "0x68ADC10", VA = "0x1868AE810")]
		public bool IPIFFGLAHNH(NBGHNPHLDEF value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x68AE8F0", Offset = "0x68ADCF0", VA = "0x1868AE8F0")]
		public void LLLNPGICAGK(NBGHNPHLDEF flag, bool enable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x68AE690", Offset = "0x68ADA90", VA = "0x1868AE690")]
		public AHPHGHKBDEP GHEJAGJDNKP()
		{
			return default(AHPHGHKBDEP);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x68AE750", Offset = "0x68ADB50", VA = "0x1868AE750")]
		public bool IGFJEAPHEFN(AHPHGHKBDEP value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[Preserve]
	[CompilerGenerated]
	public class ObjectPolicyDataProperties : CODDMBMPNME<ObjectPolicyDataWrapper, ObjectPolicyData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			public static readonly EFELFPBBEIB<HEBJPGKPDLA> scaleRestriction;

			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public static readonly EFELFPBBEIB<NBGHNPHLDEF> userConfigurableFlags;

			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public static readonly EFELFPBBEIB<AHPHGHKBDEP> circuitsTransformBehavior;

			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public static readonly EFELFPBBEIB<ODOPAAAPLKE> flags;

			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x68A65C0", Offset = "0x68A59C0", VA = "0x1868A65C0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public readonly OMGPLJDNBKA<HEBJPGKPDLA> scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public readonly OMGPLJDNBKA<NBGHNPHLDEF> userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public readonly OMGPLJDNBKA<AHPHGHKBDEP> circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public readonly OMGPLJDNBKA<ODOPAAAPLKE> flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x854190", Offset = "0x853590", VA = "0x180854190", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x68AE300", Offset = "0x68AD700", VA = "0x1868AE300")]
		public ObjectPolicyDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ObjectPolicyDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(ObjectPolicyDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[global::BPMCLJHLDME]
	[TypeManager.ForcedStableTypeHash(2023375009558162791uL)]
	[CompilerGenerated]
	public struct ObjectPolicyData_v1 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[global::AKOGMCGBMOC(1)]
		public ODOPAAAPLKE flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[global::AKOGMCGBMOC(2)]
		public HEBJPGKPDLA scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[global::AKOGMCGBMOC(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15168486114979071194uL)]
	[global::BPMCLJHLDME]
	public struct ObjectPolicyData_v2 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[global::AKOGMCGBMOC(1)]
		public ODOPAAAPLKE flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[global::AKOGMCGBMOC(2)]
		public HEBJPGKPDLA scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[global::AKOGMCGBMOC(3)]
		public bool isFrozen;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[global::BPMCLJHLDME]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5922380073816386711uL)]
	public struct ObjectPolicyData_v3 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[global::AKOGMCGBMOC(1)]
		public ODOPAAAPLKE flags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		[global::AKOGMCGBMOC(2)]
		public HEBJPGKPDLA scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		[global::AKOGMCGBMOC(3)]
		public NBGHNPHLDEF userConfigurableFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[TypeManager.TypeVersion(2)]
	[TypeManager.ForcedStableTypeHash(15970362445488810630uL)]
	[global::BPMCLJHLDME]
	[CompilerGenerated]
	public struct ObjectPolicyData_v4 : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[global::AKOGMCGBMOC(2)]
		public HEBJPGKPDLA scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[global::AKOGMCGBMOC(3)]
		public NBGHNPHLDEF userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[global::AKOGMCGBMOC(1)]
		public ODOPAAAPLKE flags;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[CompilerGenerated]
	public readonly struct SplinePointParentDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private readonly SplinePointParentDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x68B1190", Offset = "0x68B0590", VA = "0x1868B1190", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal SplinePointParentDataWrapper(Entity entity, SplinePointParentDataProperties properties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x68B1230", Offset = "0x68B0630", VA = "0x1868B1230")]
		public bool GAONDIGKGFL(LocalId value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[CompilerGenerated]
	[Preserve]
	public class SplinePointParentDataProperties : CODDMBMPNME<SplinePointParentDataWrapper, SplinePointParentData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000B7")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public static readonly EFELFPBBEIB<Entity> spline;

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x68A4FF0", Offset = "0x68A43F0", VA = "0x1868A4FF0")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public readonly OMGPLJDNBKA<Entity> spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x68B1040", Offset = "0x68B0440", VA = "0x1868B1040")]
		public SplinePointParentDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override SplinePointParentDataWrapper KKPNFGDJDFE(Entity entity)
		{
			return default(SplinePointParentDataWrapper);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	public readonly struct ReferenceGroupKindDataWrapper : IAKNNBOEECN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private readonly ReferenceGroupKindDataProperties properties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private readonly Entity entity;

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x68AF840", Offset = "0x68AEC40", VA = "0x1868AF840", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x68952D0", Offset = "0x68946D0", VA = "0x1868952D0")]
		internal ReferenceGroupKindDataWrapper(Entity entity, ReferenceGroupKindDataProperties properties)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[Preserve]
	[CompilerGenerated]
	public class ReferenceGroupKindDataProperties : CODDMBMPNME<ReferenceGroupKindDataWrapper, ReferenceGroupKindData>
	{
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		public static class Names
		{
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			public static readonly EFELFPBBEIB<LLNMKDOAMIE> kind;

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x68A6B30", Offset = "0x68A5F30", VA = "0x1868A6B30")]
			static Names()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public readonly OMGPLJDNBKA<LLNMKDOAMIE> kind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private readonly DJBGIFILDLE[] properties;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected internal override DJBGIFILDLE[] Properties
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x8517E0", Offset = "0x850BE0", VA = "0x1808517E0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x68AF6F0", Offset = "0x68AEAF0", VA = "0x1868AF6F0")]
		public ReferenceGroupKindDataProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6895030", Offset = "0x6894430", VA = "0x186895030", Slot = "17")]
		protected internal override ReferenceGroupKindDataWrapper KKPNFGDJDFE(Entity entity)
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
		[Cpp2IlInjected.Address(RVA = "0x6895AA0", Offset = "0x6894EA0", VA = "0x186895AA0")]
		public static (long, string, string) AAJMAIBELJO(POJFLIOAKPM value)
		{
			return default((long, string, string));
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x68977E0", Offset = "0x6896BE0", VA = "0x1868977E0")]
		public static (long, string, string)[] NOAGENNMNED(Type type)
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
		[Cpp2IlInjected.Address(RVA = "0x68A6E60", Offset = "0x68A6260", VA = "0x1868A6E60")]
		public static Type[] DHJMBGCANBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x68A6EC0", Offset = "0x68A62C0", VA = "0x1868A6EC0")]
		private static void NLGJOIAOEAN()
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
		[Cpp2IlInjected.Address(RVA = "0x68A8730", Offset = "0x68A7B30", VA = "0x1868A8730")]
		public static (Type, long, long)[] DHJMBGCANBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x68A8790", Offset = "0x68A7B90", VA = "0x1868A8790")]
		private static void NLGJOIAOEAN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[HNPBPAPMCJD(HLMJHHDGPFE.Application)]
	[CompilerGenerated]
	[EFCEPDIPLEI(typeof(DNKPCEECCLM), new string[] { "Registry" })]
	internal class NetworkPropertyRegistry : DNKPCEECCLM
	{
		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private Type[] Type
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x850BC0", VA = "0x1808517C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		private int[] Offset
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x84D8F0", Offset = "0x84CCF0", VA = "0x18084D8F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private int[] Size
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x84D8D0", Offset = "0x84CCD0", VA = "0x18084D8D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private Type[] ComponentType
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x852800", Offset = "0x851C00", VA = "0x180852800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x68ADE00", Offset = "0x68AD200", VA = "0x1868ADE00")]
		public NetworkPropertyRegistry()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x68A9550", Offset = "0x68A8950", VA = "0x1868A9550")]
		private void FPJFGCCHEOI()
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
		[Cpp2IlInjected.Address(RVA = "0x68B3880", Offset = "0x68B2C80", VA = "0x1868B3880")]
		public static Type[] DHJMBGCANBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x68B3920", Offset = "0x68B2D20", VA = "0x1868B3920")]
		private static void NLGJOIAOEAN()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[CompilerGenerated]
	public struct VersionedTypeDefaultRegistration
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x68B5FF0", Offset = "0x68B53F0", VA = "0x1868B5FF0")]
		public void NLGJOIAOEAN(FELKOHNNBJK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x68B5130", Offset = "0x68B4530", VA = "0x1868B5130")]
		private void EMPBALFEMEM(FELKOHNNBJK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x31D7540", Offset = "0x31D6940", VA = "0x1831D7540")]
		private void JCIJONMFNHL<T>(FELKOHNNBJK registry, [In] T value) where T : struct
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
[HNPBPAPMCJD(HLMJHHDGPFE.Application)]
[EFCEPDIPLEI(typeof(GIPAJDGDNMH), new string[] { "Registry" })]
internal class KAOPFKAKGBN : GIPAJDGDNMH
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public Type GJDCHKEIOBE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x68B3820", Offset = "0x68B2C20", VA = "0x1868B3820", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public Type[] BDJJMLNEPCE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x68B3880", Offset = "0x68B2C80", VA = "0x1868B3880", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public Type[] ONCNFHKAOLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x68B38F0", Offset = "0x68B2CF0", VA = "0x1868B38F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public (Type type, long min, long max)[] GHCLLMDKLNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x68B38E0", Offset = "0x68B2CE0", VA = "0x1868B38E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x68B3900", Offset = "0x68B2D00", VA = "0x1868B3900", Slot = "8")]
	public void KMMADFFCIGE(FELKOHNNBJK GACLDMOMONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
	public KAOPFKAKGBN()
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
