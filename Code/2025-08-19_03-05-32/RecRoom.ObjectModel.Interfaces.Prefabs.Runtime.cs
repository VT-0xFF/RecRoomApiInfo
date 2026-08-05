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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DBDFE0", Offset = "0x2DBCDE0", VA = "0x182DBDFE0")]
		public PrefabRegistrationClass()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Prefabs
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface NDXGILSCTDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CQFNJFMOHNW(RRObjectPrefabData a, EntityDefaults b);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IEnumerable<(Guid, ObjectPrefabType, DynamicComponentTypeList, InitializePrefabHandler)> WLBEBNDIDKE(NativeArray<(PrimitiveShapeType primitiveType, ObjectPrefabType prefabType)> primitives);
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
		[Cpp2IlInjected.Address(RVA = "0x55738C0", Offset = "0x55726C0", VA = "0x1855738C0")]
		public EntityDefaults(Entity entity, EntityManager entityManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3819220", Offset = "0x3818020", VA = "0x183819220")]
		public void Set<T>(T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3819180", Offset = "0x3817F80", VA = "0x183819180")]
		public void ENUIOETTHRO<T>(T a) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x87493C0", Offset = "0x87481C0", VA = "0x1887493C0")]
		public void WEZJCFLSTMK()
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
