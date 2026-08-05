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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x2E5B640", Offset = "0x2E5A040", VA = "0x182E5B640")]
		public PrefabRegistrationClass()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Prefabs
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface MEGJMOUOXIQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MXSPRHBUVWN(RRObjectPrefabData a, EntityDefaults b);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IEnumerable<(Guid, ObjectPrefabType, DynamicComponentTypeList, InitializePrefabHandler)> NJKLUFGATQH(NativeArray<(PrimitiveShapeType primitiveType, ObjectPrefabType prefabType)> primitives);
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
		[Cpp2IlInjected.Address(RVA = "0x6930250", Offset = "0x692EC50", VA = "0x186930250")]
		public EntityDefaults(Entity entity, EntityManager entityManager)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3973E00", Offset = "0x3972800", VA = "0x183973E00")]
		public void Set<T>(T value) where T : struct, IComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3973D60", Offset = "0x3972760", VA = "0x183973D60")]
		public void QRCIVIAMKVP<T>(T a) where T : struct, ISharedComponentData
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99FBD90", Offset = "0x99FA790", VA = "0x1899FBD90")]
		public void LZRSNPGUKAD()
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
