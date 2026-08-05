using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer;
using Unity.Collections;
using Unity.Entities;
using Unity.Entities.Foundation;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class)]
	public class PrefabRegistrationClass : RegisterType
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2BB5DC0", Offset = "0x2BB45C0", VA = "0x182BB5DC0")]
		public PrefabRegistrationClass()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Prefabs
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface UTJLGQIKNNZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XWDPGVPTXOI(RRObjectPrefabData a, EntityDefaults b);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IEnumerable<(Guid, ObjectPrefabType, DynamicComponentTypeList, InitializePrefabHandler)> GIFTCAZOIIA(NativeArray<(PrimitiveShapeType primitiveType, ObjectPrefabType prefabType)> primitives);
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void InitializePrefabHandler(ObjectPrefabType prefabType, EntityDefaults defaults);
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct EntityDefaults
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private EntityManager entityManager;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x52BFB90", Offset = "0x52BE390", VA = "0x1852BFB90")]
		public EntityDefaults(Entity entity, EntityManager entityManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x35EA720", Offset = "0x35E8F20", VA = "0x1835EA720")]
		public void Set<T>(T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x35EA680", Offset = "0x35E8E80", VA = "0x1835EA680")]
		public void SKEHLGFSLUU<T>(T a) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84AD7E0", Offset = "0x84ABFE0", VA = "0x1884AD7E0")]
		public void YDDDVXKUEOG()
		{
		}
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
