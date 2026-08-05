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
		[Cpp2IlInjected.Address(RVA = "0x220FA40", Offset = "0x220EE40", VA = "0x18220FA40")]
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
			[Cpp2IlInjected.Address(RVA = "0x1322F10", Offset = "0x1322310", VA = "0x181322F10", Slot = "30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAA5AA0", Offset = "0xAA4EA0", VA = "0x180AA5AA0", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public object SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x13228C0", Offset = "0x1321CC0", VA = "0x1813228C0", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5AA0", Offset = "0xAA4EA0", VA = "0x180AA5AA0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x14CB350", Offset = "0x14CA750", VA = "0x1814CB350", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x14CB3E0", Offset = "0x14CA7E0", VA = "0x1814CB3E0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IList.this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x14CB020", Offset = "0x14CA420", VA = "0x1814CB020", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x14CB050", Offset = "0x14CA450", VA = "0x1814CB050", Slot = "19")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool IList.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xAA5AA0", Offset = "0xAA4EA0", VA = "0x180AA5AA0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x14CB270", Offset = "0x14CA670", VA = "0x1814CB270")]
		public List()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x14CAA10", Offset = "0x14C9E10", VA = "0x1814CAA10", Slot = "11")]
		void ICollection<T>.Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x14CAB10", Offset = "0x14C9F10", VA = "0x1814CAB10", Slot = "17")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x14CA460", Offset = "0x14C9860", VA = "0x1814CA460", Slot = "16")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x14CA200", Offset = "0x14C9600", VA = "0x1814CA200", Slot = "14")]
		public void CopyTo(T[] target, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x14CA920", Offset = "0x14C9D20", VA = "0x1814CA920")]
		public List<T> Push(T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x14C9ED0", Offset = "0x14C92D0", VA = "0x1814C9ED0", Slot = "34")]
		public virtual List<T> Add(T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x14CB150", Offset = "0x14CA550", VA = "0x1814CB150", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x14CA840", Offset = "0x14C9C40", VA = "0x1814CA840")]
		public string Join(string separator)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x14CA4E0", Offset = "0x14C98E0", VA = "0x1814CA4E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x14CA3C0", Offset = "0x14C97C0", VA = "0x1814CA3C0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x14CA2A0", Offset = "0x14C96A0", VA = "0x1814CA2A0", Slot = "33")]
		public bool Equals(List<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x14C9FC0", Offset = "0x14C93C0", VA = "0x1814C9FC0", Slot = "22")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x14CA1D0", Offset = "0x14C95D0", VA = "0x1814CA1D0", Slot = "13")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560", Slot = "6")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x14CA710", Offset = "0x14C9B10", VA = "0x1814CA710")]
		public List<T> Insert(int index, T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x14CA9D0", Offset = "0x14C9DD0", VA = "0x1814CA9D0")]
		public List<T> Remove(T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x14CA950", Offset = "0x14C9D50", VA = "0x1814CA950")]
		public List<T> RemoveAt(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x14CAA70", Offset = "0x14C9E70", VA = "0x1814CAA70", Slot = "7")]
		void IList<T>.Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x14CAAA0", Offset = "0x14C9EA0", VA = "0x1814CAAA0", Slot = "8")]
		void IList<T>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x14CAA40", Offset = "0x14C9E40", VA = "0x1814CAA40", Slot = "15")]
		bool ICollection<T>.Remove(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x14CA230", Offset = "0x14C9630", VA = "0x1814CA230")]
		private void EnsureCapacity(int minCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x14CA850", Offset = "0x14C9C50", VA = "0x1814CA850")]
		private T[] NewArray(int minCapacity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x14CA630", Offset = "0x14C9A30", VA = "0x1814CA630")]
		private void InnerRemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x14CA6A0", Offset = "0x14C9AA0", VA = "0x1814CA6A0")]
		private bool InnerRemove(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x14C9F50", Offset = "0x14C9350", VA = "0x1814C9F50")]
		private int CheckIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x14CA910", Offset = "0x14C9D10", VA = "0x1814CA910")]
		private int NormalizeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x14CAB60", Offset = "0x14C9F60", VA = "0x1814CAB60", Slot = "20")]
		int IList.Add(object value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x14CAE00", Offset = "0x14CA200", VA = "0x1814CAE00", Slot = "26")]
		void IList.Insert(int index, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x14CA020", Offset = "0x14C9420", VA = "0x1814CA020")]
		private static T Coerce(object value)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x14CAF30", Offset = "0x14CA330", VA = "0x1814CAF30", Slot = "27")]
		void IList.Remove(object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x14CAD10", Offset = "0x14CA110", VA = "0x1814CAD10", Slot = "25")]
		int IList.IndexOf(object value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x14CAC20", Offset = "0x14CA020", VA = "0x1814CAC20", Slot = "21")]
		bool IList.Contains(object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x14CAF00", Offset = "0x14CA300", VA = "0x1814CAF00", Slot = "28")]
		void IList.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x14CA200", Offset = "0x14C9600", VA = "0x1814CA200", Slot = "29")]
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
			[Cpp2IlInjected.Address(RVA = "0x13228C0", Offset = "0x1321CC0", VA = "0x1813228C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x22106B0", Offset = "0x220FAB0", VA = "0x1822106B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2212470", Offset = "0x2211870", VA = "0x182212470")]
		private static Dispatcher GetDispatcher(object target, string cacheKeyName, Type[] cacheKeyTypes, DispatcherCache.DispatcherFactory factory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2210CE0", Offset = "0x22100E0", VA = "0x182210CE0")]
		public static object Coerce(object value, Type toType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x2211140", Offset = "0x2210540", VA = "0x182211140")]
		private static Dispatcher CreateCoerceDispatcher(object value, Type toType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2211560", Offset = "0x2210960", VA = "0x182211560")]
		private static Dispatcher EmitPromotionDispatcher(Type fromType, Type toType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x22126C0", Offset = "0x2211AC0", VA = "0x1822126C0")]
		private static bool IsPromotableNumeric(Type fromType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2211420", Offset = "0x2210820", VA = "0x182211420")]
		private static Dispatcher EmitImplicitConversionDispatcher(MethodInfo method)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2210FA0", Offset = "0x22103A0", VA = "0x182210FA0")]
		private static object CoercibleDispatcher(object o, object[] args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1414C80", Offset = "0x1414080", VA = "0x181414C80")]
		private static object IdentityDispatcher(object o, object[] args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2212610", Offset = "0x2211A10", VA = "0x182212610")]
		private static bool IsNumeric(TypeCode code)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x2211C50", Offset = "0x2211050", VA = "0x182211C50")]
		public static bool EqualityOperator(object lhs, object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x2210B90", Offset = "0x220FF90", VA = "0x182210B90")]
		private static bool ArrayEqualityImpl(Array lhs, Array rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x22123A0", Offset = "0x22117A0", VA = "0x1822123A0")]
		private static TypeCode GetConvertTypeCode(TypeCode lhsTypeCode, TypeCode rhsTypeCode)
		{
			return default(TypeCode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x2211810", Offset = "0x2210C10", VA = "0x182211810")]
		private static bool EqualityOperator(object lhs, TypeCode lhsTypeCode, object rhs, TypeCode rhsTypeCode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2212660", Offset = "0x2211A60", VA = "0x182212660")]
		internal static bool IsPromotableNumeric(TypeCode code)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x2212210", Offset = "0x2211610", VA = "0x182212210")]
		internal static MethodInfo FindImplicitConversionOperator(Type from, Type to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x22125A0", Offset = "0x22119A0", VA = "0x1822125A0")]
		private static IEnumerable<MethodInfo> GetExtensionMethods()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2211F80", Offset = "0x2211380", VA = "0x182211F80")]
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
		[Cpp2IlInjected.Address(RVA = "0x220FC80", Offset = "0x220F080", VA = "0x18220FC80")]
		public Dispatcher Get(DispatcherKey key, DispatcherFactory factory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x319810", Offset = "0x318C10", VA = "0x180319810")]
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
			[Cpp2IlInjected.Address(RVA = "0x2212EB0", Offset = "0x22122B0", VA = "0x182212EB0", Slot = "5")]
			public int GetHashCode(DispatcherKey key)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2212DD0", Offset = "0x22121D0", VA = "0x182212DD0", Slot = "4")]
			public bool Equals(DispatcherKey x, DispatcherKey y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x319810", Offset = "0x318C10", VA = "0x180319810")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A4170", Offset = "0x3A3570", VA = "0x1803A4170")]
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
		[Cpp2IlInjected.Address(RVA = "0x2210450", Offset = "0x220F850", VA = "0x182210450")]
		public DispatcherEmitter(Type owner, string dynamicMethodName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2210390", Offset = "0x220F790", VA = "0x182210390")]
		public Dispatcher Emit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void EmitMethodBody();

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x220FFE0", Offset = "0x220F3E0", VA = "0x18220FFE0")]
		protected Dispatcher CreateMethodDispatcher()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x2210090", Offset = "0x220F490", VA = "0x182210090")]
		protected void EmitCastOrUnbox(Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x220FF30", Offset = "0x220F330", VA = "0x18220FF30")]
		protected void BoxIfNeeded(Type returnType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x22101D0", Offset = "0x220F5D0", VA = "0x1822101D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2210B10", Offset = "0x220FF10", VA = "0x182210B10")]
		public ImplicitConversionEmitter(MethodInfo conversion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2210730", Offset = "0x220FB30", VA = "0x182210730", Slot = "4")]
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
