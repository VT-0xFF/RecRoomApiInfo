using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using Boo.Lang.Runtime.DynamicDispatching;
using Cpp2IlInjected;

[assembly: AssemblyVersion("2.0.9.5")]
namespace Boo.Lang
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class Builtins
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x74B970", Offset = "0x74AD70", VA = "0x18074B970")]
		public static string join(IEnumerable enumerable, string separator)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class List<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IList, ICollection, IEquatable<List<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly T[] EmptyArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected T[] _items;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected int _count;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5ABFC0", Offset = "0x5AB3C0", VA = "0x1805ABFC0", Slot = "30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5AFC60", Offset = "0x5AF060", VA = "0x1805AFC60", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public object SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x5B9240", Offset = "0x5B8640", VA = "0x1805B9240", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5AFC60", Offset = "0x5AF060", VA = "0x1805AFC60", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x19F5910", Offset = "0x19F4D10", VA = "0x1819F5910", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x19F59A0", Offset = "0x19F4DA0", VA = "0x1819F59A0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IList.this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x19F55E0", Offset = "0x19F49E0", VA = "0x1819F55E0", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x19F5610", Offset = "0x19F4A10", VA = "0x1819F5610", Slot = "19")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool IList.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5AFC60", Offset = "0x5AF060", VA = "0x1805AFC60", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x19F5830", Offset = "0x19F4C30", VA = "0x1819F5830")]
		public List()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x19F4FD0", Offset = "0x19F43D0", VA = "0x1819F4FD0", Slot = "11")]
		void ICollection<T>.Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x19F50D0", Offset = "0x19F44D0", VA = "0x1819F50D0", Slot = "17")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x19F4A20", Offset = "0x19F3E20", VA = "0x1819F4A20", Slot = "16")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x19F47C0", Offset = "0x19F3BC0", VA = "0x1819F47C0", Slot = "14")]
		public void CopyTo(T[] target, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x19F4EE0", Offset = "0x19F42E0", VA = "0x1819F4EE0")]
		public List<T> Push(T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x19F4490", Offset = "0x19F3890", VA = "0x1819F4490", Slot = "34")]
		public virtual List<T> Add(T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x19F5710", Offset = "0x19F4B10", VA = "0x1819F5710", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x19F4E00", Offset = "0x19F4200", VA = "0x1819F4E00")]
		public string Join(string separator)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x19F4AA0", Offset = "0x19F3EA0", VA = "0x1819F4AA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x19F4980", Offset = "0x19F3D80", VA = "0x1819F4980", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x19F4860", Offset = "0x19F3C60", VA = "0x1819F4860", Slot = "33")]
		public bool Equals(List<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x19F4580", Offset = "0x19F3980", VA = "0x1819F4580", Slot = "22")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x19F4790", Offset = "0x19F3B90", VA = "0x1819F4790", Slot = "13")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x19F4B20", Offset = "0x19F3F20", VA = "0x1819F4B20", Slot = "6")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x19F4CD0", Offset = "0x19F40D0", VA = "0x1819F4CD0")]
		public List<T> Insert(int index, T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x19F4F90", Offset = "0x19F4390", VA = "0x1819F4F90")]
		public List<T> Remove(T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x19F4F10", Offset = "0x19F4310", VA = "0x1819F4F10")]
		public List<T> RemoveAt(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x19F5030", Offset = "0x19F4430", VA = "0x1819F5030", Slot = "7")]
		void IList<T>.Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x19F5060", Offset = "0x19F4460", VA = "0x1819F5060", Slot = "8")]
		void IList<T>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x19F5000", Offset = "0x19F4400", VA = "0x1819F5000", Slot = "15")]
		bool ICollection<T>.Remove(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x19F47F0", Offset = "0x19F3BF0", VA = "0x1819F47F0")]
		private void EnsureCapacity(int minCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x19F4E10", Offset = "0x19F4210", VA = "0x1819F4E10")]
		private T[] NewArray(int minCapacity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x19F4BF0", Offset = "0x19F3FF0", VA = "0x1819F4BF0")]
		private void InnerRemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x19F4C60", Offset = "0x19F4060", VA = "0x1819F4C60")]
		private bool InnerRemove(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x19F4510", Offset = "0x19F3910", VA = "0x1819F4510")]
		private int CheckIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x19F4ED0", Offset = "0x19F42D0", VA = "0x1819F4ED0")]
		private int NormalizeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x19F5120", Offset = "0x19F4520", VA = "0x1819F5120", Slot = "20")]
		int IList.Add(object value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x19F53C0", Offset = "0x19F47C0", VA = "0x1819F53C0", Slot = "26")]
		void IList.Insert(int index, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x19F45E0", Offset = "0x19F39E0", VA = "0x1819F45E0")]
		private static T Coerce(object value)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x19F54F0", Offset = "0x19F48F0", VA = "0x1819F54F0", Slot = "27")]
		void IList.Remove(object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x19F52D0", Offset = "0x19F46D0", VA = "0x1819F52D0", Slot = "25")]
		int IList.IndexOf(object value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x19F51E0", Offset = "0x19F45E0", VA = "0x1819F51E0", Slot = "21")]
		bool IList.Contains(object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x19F54C0", Offset = "0x19F48C0", VA = "0x1819F54C0", Slot = "28")]
		void IList.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x19F47C0", Offset = "0x19F3BC0", VA = "0x1819F47C0", Slot = "29")]
		void ICollection.CopyTo(Array array, int index)
		{
		}
	}
}
namespace Boo.Lang.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ExtensionRegistry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private List<MemberInfo> _extensions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private object _classLock;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public IEnumerable<MemberInfo> Extensions
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5B9240", Offset = "0x5B8640", VA = "0x1805B9240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x74C860", Offset = "0x74BC60", VA = "0x18074C860")]
		public ExtensionRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface ICoercible
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object Coerce(Type to);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class RuntimeServices
	{
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly object[] NoArguments;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly Type RuntimeServicesType;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static readonly DispatcherCache _cache;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly ExtensionRegistry _extensions;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly object True;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x74E620", Offset = "0x74DA20", VA = "0x18074E620")]
		private static Dispatcher GetDispatcher(object target, string cacheKeyName, Type[] cacheKeyTypes, DispatcherCache.DispatcherFactory factory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x74CE90", Offset = "0x74C290", VA = "0x18074CE90")]
		public static object Coerce(object value, Type toType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x74D2F0", Offset = "0x74C6F0", VA = "0x18074D2F0")]
		private static Dispatcher CreateCoerceDispatcher(object value, Type toType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x74D710", Offset = "0x74CB10", VA = "0x18074D710")]
		private static Dispatcher EmitPromotionDispatcher(Type fromType, Type toType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x74E880", Offset = "0x74DC80", VA = "0x18074E880")]
		private static bool IsPromotableNumeric(Type fromType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x74D5D0", Offset = "0x74C9D0", VA = "0x18074D5D0")]
		private static Dispatcher EmitImplicitConversionDispatcher(MethodInfo method)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x74D150", Offset = "0x74C550", VA = "0x18074D150")]
		private static object CoercibleDispatcher(object o, object[] args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x74E7C0", Offset = "0x74DBC0", VA = "0x18074E7C0")]
		private static object IdentityDispatcher(object o, object[] args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x74E7D0", Offset = "0x74DBD0", VA = "0x18074E7D0")]
		private static bool IsNumeric(TypeCode code)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x74DE00", Offset = "0x74D200", VA = "0x18074DE00")]
		public static bool EqualityOperator(object lhs, object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x74CD40", Offset = "0x74C140", VA = "0x18074CD40")]
		private static bool ArrayEqualityImpl(Array lhs, Array rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x74E550", Offset = "0x74D950", VA = "0x18074E550")]
		private static TypeCode GetConvertTypeCode(TypeCode lhsTypeCode, TypeCode rhsTypeCode)
		{
			return default(TypeCode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x74D9C0", Offset = "0x74CDC0", VA = "0x18074D9C0")]
		private static bool EqualityOperator(object lhs, TypeCode lhsTypeCode, object rhs, TypeCode rhsTypeCode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x74E820", Offset = "0x74DC20", VA = "0x18074E820")]
		internal static bool IsPromotableNumeric(TypeCode code)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x74E3C0", Offset = "0x74D7C0", VA = "0x18074E3C0")]
		internal static MethodInfo FindImplicitConversionOperator(Type from, Type to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x74E750", Offset = "0x74DB50", VA = "0x18074E750")]
		private static IEnumerable<MethodInfo> GetExtensionMethods()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x74E130", Offset = "0x74D530", VA = "0x18074E130")]
		private static MethodInfo FindImplicitConversionMethod(IEnumerable<MethodInfo> candidates, Type from, Type to)
		{
			return null;
		}
	}
}
namespace Boo.Lang.Runtime.DynamicDispatching
{
	[StructLayout((LayoutKind)3, Size = 8)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate object Dispatcher(object target, object[] args);
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class DispatcherCache
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public delegate Dispatcher DispatcherFactory();

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static Dictionary<DispatcherKey, Dispatcher> _cache;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x74BBB0", Offset = "0x74AFB0", VA = "0x18074BBB0")]
		public Dispatcher Get(DispatcherKey key, DispatcherFactory factory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x320620", Offset = "0x31FA20", VA = "0x180320620")]
		public DispatcherCache()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class DispatcherKey
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		private sealed class _EqualityComparer : IEqualityComparer<DispatcherKey>
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x74F070", Offset = "0x74E470", VA = "0x18074F070", Slot = "5")]
			public int GetHashCode(DispatcherKey key)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x74EF90", Offset = "0x74E390", VA = "0x18074EF90", Slot = "4")]
			public bool Equals(DispatcherKey x, DispatcherKey y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x320620", Offset = "0x31FA20", VA = "0x180320620")]
			public _EqualityComparer()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly IEqualityComparer<DispatcherKey> EqualityComparer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly Type _type;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly string _name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly Type[] _arguments;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4DA460", Offset = "0x4D9860", VA = "0x1804DA460")]
		public DispatcherKey(Type type, string name, Type[] arguments)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class NumericPromotions
	{
	}
}
namespace Boo.Lang.Runtime.DynamicDispatching.Emitters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class DispatcherEmitter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private DynamicMethod _dynamicMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		protected readonly ILGenerator _il;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x74C380", Offset = "0x74B780", VA = "0x18074C380")]
		public DispatcherEmitter(Type owner, string dynamicMethodName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x74C2C0", Offset = "0x74B6C0", VA = "0x18074C2C0")]
		public Dispatcher Emit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void EmitMethodBody();

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x74BF10", Offset = "0x74B310", VA = "0x18074BF10")]
		protected Dispatcher CreateMethodDispatcher()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x74BFC0", Offset = "0x74B3C0", VA = "0x18074BFC0")]
		protected void EmitCastOrUnbox(Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x74BE60", Offset = "0x74B260", VA = "0x18074BE60")]
		protected void BoxIfNeeded(Type returnType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x74C100", Offset = "0x74B500", VA = "0x18074C100")]
		protected void EmitReturn(Type typeOnStack)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class ImplicitConversionEmitter : DispatcherEmitter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private MethodInfo _conversion;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x74CCC0", Offset = "0x74C0C0", VA = "0x18074CCC0")]
		public ImplicitConversionEmitter(MethodInfo conversion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x74C8E0", Offset = "0x74BCE0", VA = "0x18074C8E0", Slot = "4")]
		protected override void EmitMethodBody()
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
