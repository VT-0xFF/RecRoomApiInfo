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
		[Cpp2IlInjected.Address(RVA = "0x24EB840", Offset = "0x24EAC40", VA = "0x1824EB840")]
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
			[Cpp2IlInjected.Address(RVA = "0x1625A70", Offset = "0x1624E70", VA = "0x181625A70", Slot = "30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xD2A910", Offset = "0xD29D10", VA = "0x180D2A910", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public object SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x1625420", Offset = "0x1624820", VA = "0x181625420", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xD2A910", Offset = "0xD29D10", VA = "0x180D2A910", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x1774C00", Offset = "0x1774000", VA = "0x181774C00", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1774C90", Offset = "0x1774090", VA = "0x181774C90", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IList.this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x17748D0", Offset = "0x1773CD0", VA = "0x1817748D0", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1774900", Offset = "0x1773D00", VA = "0x181774900", Slot = "19")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool IList.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xD2A910", Offset = "0xD29D10", VA = "0x180D2A910", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x1774B20", Offset = "0x1773F20", VA = "0x181774B20")]
		public List()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x17742C0", Offset = "0x17736C0", VA = "0x1817742C0", Slot = "11")]
		void ICollection<T>.Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x17743C0", Offset = "0x17737C0", VA = "0x1817743C0", Slot = "17")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1773D10", Offset = "0x1773110", VA = "0x181773D10", Slot = "16")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1773AB0", Offset = "0x1772EB0", VA = "0x181773AB0", Slot = "14")]
		public void CopyTo(T[] target, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x17741D0", Offset = "0x17735D0", VA = "0x1817741D0")]
		public List<T> Push(T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1773780", Offset = "0x1772B80", VA = "0x181773780", Slot = "34")]
		public virtual List<T> Add(T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1774A00", Offset = "0x1773E00", VA = "0x181774A00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x17740F0", Offset = "0x17734F0", VA = "0x1817740F0")]
		public string Join(string separator)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1773D90", Offset = "0x1773190", VA = "0x181773D90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1773C70", Offset = "0x1773070", VA = "0x181773C70", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1773B50", Offset = "0x1772F50", VA = "0x181773B50", Slot = "33")]
		public bool Equals(List<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1773870", Offset = "0x1772C70", VA = "0x181773870", Slot = "22")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1773A80", Offset = "0x1772E80", VA = "0x181773A80", Slot = "13")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1773E10", Offset = "0x1773210", VA = "0x181773E10", Slot = "6")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1773FC0", Offset = "0x17733C0", VA = "0x181773FC0")]
		public List<T> Insert(int index, T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1774280", Offset = "0x1773680", VA = "0x181774280")]
		public List<T> Remove(T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1774200", Offset = "0x1773600", VA = "0x181774200")]
		public List<T> RemoveAt(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1774320", Offset = "0x1773720", VA = "0x181774320", Slot = "7")]
		void IList<T>.Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1774350", Offset = "0x1773750", VA = "0x181774350", Slot = "8")]
		void IList<T>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x17742F0", Offset = "0x17736F0", VA = "0x1817742F0", Slot = "15")]
		bool ICollection<T>.Remove(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1773AE0", Offset = "0x1772EE0", VA = "0x181773AE0")]
		private void EnsureCapacity(int minCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1774100", Offset = "0x1773500", VA = "0x181774100")]
		private T[] NewArray(int minCapacity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1773EE0", Offset = "0x17732E0", VA = "0x181773EE0")]
		private void InnerRemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1773F50", Offset = "0x1773350", VA = "0x181773F50")]
		private bool InnerRemove(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1773800", Offset = "0x1772C00", VA = "0x181773800")]
		private int CheckIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x17741C0", Offset = "0x17735C0", VA = "0x1817741C0")]
		private int NormalizeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1774410", Offset = "0x1773810", VA = "0x181774410", Slot = "20")]
		int IList.Add(object value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x17746B0", Offset = "0x1773AB0", VA = "0x1817746B0", Slot = "26")]
		void IList.Insert(int index, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x17738D0", Offset = "0x1772CD0", VA = "0x1817738D0")]
		private static T Coerce(object value)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x17747E0", Offset = "0x1773BE0", VA = "0x1817747E0", Slot = "27")]
		void IList.Remove(object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x17745C0", Offset = "0x17739C0", VA = "0x1817745C0", Slot = "25")]
		int IList.IndexOf(object value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x17744D0", Offset = "0x17738D0", VA = "0x1817744D0", Slot = "21")]
		bool IList.Contains(object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x17747B0", Offset = "0x1773BB0", VA = "0x1817747B0", Slot = "28")]
		void IList.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1773AB0", Offset = "0x1772EB0", VA = "0x181773AB0", Slot = "29")]
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
			[Cpp2IlInjected.Address(RVA = "0x1625420", Offset = "0x1624820", VA = "0x181625420")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x24EC4B0", Offset = "0x24EB8B0", VA = "0x1824EC4B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x24EE270", Offset = "0x24ED670", VA = "0x1824EE270")]
		private static Dispatcher GetDispatcher(object target, string cacheKeyName, Type[] cacheKeyTypes, DispatcherCache.DispatcherFactory factory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x24ECAE0", Offset = "0x24EBEE0", VA = "0x1824ECAE0")]
		public static object Coerce(object value, Type toType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x24ECF40", Offset = "0x24EC340", VA = "0x1824ECF40")]
		private static Dispatcher CreateCoerceDispatcher(object value, Type toType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x24ED360", Offset = "0x24EC760", VA = "0x1824ED360")]
		private static Dispatcher EmitPromotionDispatcher(Type fromType, Type toType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x24EE4C0", Offset = "0x24ED8C0", VA = "0x1824EE4C0")]
		private static bool IsPromotableNumeric(Type fromType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x24ED220", Offset = "0x24EC620", VA = "0x1824ED220")]
		private static Dispatcher EmitImplicitConversionDispatcher(MethodInfo method)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x24ECDA0", Offset = "0x24EC1A0", VA = "0x1824ECDA0")]
		private static object CoercibleDispatcher(object o, object[] args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x16F2CB0", Offset = "0x16F20B0", VA = "0x1816F2CB0")]
		private static object IdentityDispatcher(object o, object[] args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x24EE410", Offset = "0x24ED810", VA = "0x1824EE410")]
		private static bool IsNumeric(TypeCode code)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x24EDA50", Offset = "0x24ECE50", VA = "0x1824EDA50")]
		public static bool EqualityOperator(object lhs, object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x24EC990", Offset = "0x24EBD90", VA = "0x1824EC990")]
		private static bool ArrayEqualityImpl(Array lhs, Array rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x24EE1A0", Offset = "0x24ED5A0", VA = "0x1824EE1A0")]
		private static TypeCode GetConvertTypeCode(TypeCode lhsTypeCode, TypeCode rhsTypeCode)
		{
			return default(TypeCode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x24ED610", Offset = "0x24ECA10", VA = "0x1824ED610")]
		private static bool EqualityOperator(object lhs, TypeCode lhsTypeCode, object rhs, TypeCode rhsTypeCode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x24EE460", Offset = "0x24ED860", VA = "0x1824EE460")]
		internal static bool IsPromotableNumeric(TypeCode code)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x24EE010", Offset = "0x24ED410", VA = "0x1824EE010")]
		internal static MethodInfo FindImplicitConversionOperator(Type from, Type to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x24EE3A0", Offset = "0x24ED7A0", VA = "0x1824EE3A0")]
		private static IEnumerable<MethodInfo> GetExtensionMethods()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x24EDD80", Offset = "0x24ED180", VA = "0x1824EDD80")]
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
		[Cpp2IlInjected.Address(RVA = "0x24EBA80", Offset = "0x24EAE80", VA = "0x1824EBA80")]
		public Dispatcher Get(DispatcherKey key, DispatcherFactory factory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x31A0E0", Offset = "0x3194E0", VA = "0x18031A0E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x24EECB0", Offset = "0x24EE0B0", VA = "0x1824EECB0", Slot = "5")]
			public int GetHashCode(DispatcherKey key)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x24EEBD0", Offset = "0x24EDFD0", VA = "0x1824EEBD0", Slot = "4")]
			public bool Equals(DispatcherKey x, DispatcherKey y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x31A0E0", Offset = "0x3194E0", VA = "0x18031A0E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x498FF0", Offset = "0x4983F0", VA = "0x180498FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x24EC250", Offset = "0x24EB650", VA = "0x1824EC250")]
		public DispatcherEmitter(Type owner, string dynamicMethodName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x24EC190", Offset = "0x24EB590", VA = "0x1824EC190")]
		public Dispatcher Emit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void EmitMethodBody();

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x24EBDE0", Offset = "0x24EB1E0", VA = "0x1824EBDE0")]
		protected Dispatcher CreateMethodDispatcher()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x24EBE90", Offset = "0x24EB290", VA = "0x1824EBE90")]
		protected void EmitCastOrUnbox(Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x24EBD30", Offset = "0x24EB130", VA = "0x1824EBD30")]
		protected void BoxIfNeeded(Type returnType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x24EBFD0", Offset = "0x24EB3D0", VA = "0x1824EBFD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x24EC910", Offset = "0x24EBD10", VA = "0x1824EC910")]
		public ImplicitConversionEmitter(MethodInfo conversion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x24EC530", Offset = "0x24EB930", VA = "0x1824EC530", Slot = "4")]
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
