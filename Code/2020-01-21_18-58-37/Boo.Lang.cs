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
		[Cpp2IlInjected.Address(RVA = "0x24FD720", Offset = "0x24FBD20", VA = "0x1824FD720")]
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
			[Cpp2IlInjected.Address(RVA = "0x166EA20", Offset = "0x166D020", VA = "0x18166EA20", Slot = "30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCE1440", Offset = "0xCDFA40", VA = "0x180CE1440", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public object SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x166E3D0", Offset = "0x166C9D0", VA = "0x18166E3D0", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xCE1440", Offset = "0xCDFA40", VA = "0x180CE1440", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x16D87E0", Offset = "0x16D6DE0", VA = "0x1816D87E0", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x16D8870", Offset = "0x16D6E70", VA = "0x1816D8870", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IList.this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x16D8590", Offset = "0x16D6B90", VA = "0x1816D8590", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x16D85C0", Offset = "0x16D6BC0", VA = "0x1816D85C0", Slot = "19")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool IList.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xCE1440", Offset = "0xCDFA40", VA = "0x180CE1440", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x109CFD0", Offset = "0x109B5D0", VA = "0x18109CFD0")]
		public List()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x16D7F80", Offset = "0x16D6580", VA = "0x1816D7F80", Slot = "11")]
		void ICollection<T>.Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x16D8080", Offset = "0x16D6680", VA = "0x1816D8080", Slot = "17")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x16D79D0", Offset = "0x16D5FD0", VA = "0x1816D79D0", Slot = "16")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1094E20", Offset = "0x1093420", VA = "0x181094E20", Slot = "14")]
		public void CopyTo(T[] target, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x16D7E90", Offset = "0x16D6490", VA = "0x1816D7E90")]
		public List<T> Push(T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x16D7470", Offset = "0x16D5A70", VA = "0x1816D7470", Slot = "34")]
		public virtual List<T> Add(T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x16D86C0", Offset = "0x16D6CC0", VA = "0x1816D86C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x16D7DB0", Offset = "0x16D63B0", VA = "0x1816D7DB0")]
		public string Join(string separator)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x16D7A50", Offset = "0x16D6050", VA = "0x1816D7A50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x16D7930", Offset = "0x16D5F30", VA = "0x1816D7930", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x16D7810", Offset = "0x16D5E10", VA = "0x1816D7810", Slot = "33")]
		public bool Equals(List<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x16D7560", Offset = "0x16D5B60", VA = "0x1816D7560", Slot = "22")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x16D7770", Offset = "0x16D5D70", VA = "0x1816D7770", Slot = "13")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x16D7AD0", Offset = "0x16D60D0", VA = "0x1816D7AD0", Slot = "6")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x16D7C80", Offset = "0x16D6280", VA = "0x1816D7C80")]
		public List<T> Insert(int index, T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x16D7F40", Offset = "0x16D6540", VA = "0x1816D7F40")]
		public List<T> Remove(T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x16D7EC0", Offset = "0x16D64C0", VA = "0x1816D7EC0")]
		public List<T> RemoveAt(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x16D7FE0", Offset = "0x16D65E0", VA = "0x1816D7FE0", Slot = "7")]
		void IList<T>.Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x16D8010", Offset = "0x16D6610", VA = "0x1816D8010", Slot = "8")]
		void IList<T>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x16D7FB0", Offset = "0x16D65B0", VA = "0x1816D7FB0", Slot = "15")]
		bool ICollection<T>.Remove(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x16D77A0", Offset = "0x16D5DA0", VA = "0x1816D77A0")]
		private void EnsureCapacity(int minCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x16D7DC0", Offset = "0x16D63C0", VA = "0x1816D7DC0")]
		private T[] NewArray(int minCapacity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x16D7BA0", Offset = "0x16D61A0", VA = "0x1816D7BA0")]
		private void InnerRemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x16D7C10", Offset = "0x16D6210", VA = "0x1816D7C10")]
		private bool InnerRemove(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x16D74F0", Offset = "0x16D5AF0", VA = "0x1816D74F0")]
		private int CheckIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x16D7E80", Offset = "0x16D6480", VA = "0x1816D7E80")]
		private int NormalizeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x16D80D0", Offset = "0x16D66D0", VA = "0x1816D80D0", Slot = "20")]
		int IList.Add(object value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x16D8370", Offset = "0x16D6970", VA = "0x1816D8370", Slot = "26")]
		void IList.Insert(int index, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x16D75C0", Offset = "0x16D5BC0", VA = "0x1816D75C0")]
		private static T Coerce(object value)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x16D84A0", Offset = "0x16D6AA0", VA = "0x1816D84A0", Slot = "27")]
		void IList.Remove(object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x16D8280", Offset = "0x16D6880", VA = "0x1816D8280", Slot = "25")]
		int IList.IndexOf(object value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x16D8190", Offset = "0x16D6790", VA = "0x1816D8190", Slot = "21")]
		bool IList.Contains(object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x16D8470", Offset = "0x16D6A70", VA = "0x1816D8470", Slot = "28")]
		void IList.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1094E20", Offset = "0x1093420", VA = "0x181094E20", Slot = "29")]
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
			[Cpp2IlInjected.Address(RVA = "0x166E3D0", Offset = "0x166C9D0", VA = "0x18166E3D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x24FE390", Offset = "0x24FC990", VA = "0x1824FE390")]
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
		[Cpp2IlInjected.Address(RVA = "0x2500150", Offset = "0x24FE750", VA = "0x182500150")]
		private static Dispatcher GetDispatcher(object target, string cacheKeyName, Type[] cacheKeyTypes, DispatcherCache.DispatcherFactory factory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x24FE9C0", Offset = "0x24FCFC0", VA = "0x1824FE9C0")]
		public static object Coerce(object value, Type toType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x24FEE20", Offset = "0x24FD420", VA = "0x1824FEE20")]
		private static Dispatcher CreateCoerceDispatcher(object value, Type toType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x24FF240", Offset = "0x24FD840", VA = "0x1824FF240")]
		private static Dispatcher EmitPromotionDispatcher(Type fromType, Type toType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x25003A0", Offset = "0x24FE9A0", VA = "0x1825003A0")]
		private static bool IsPromotableNumeric(Type fromType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x24FF100", Offset = "0x24FD700", VA = "0x1824FF100")]
		private static Dispatcher EmitImplicitConversionDispatcher(MethodInfo method)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x24FEC80", Offset = "0x24FD280", VA = "0x1824FEC80")]
		private static object CoercibleDispatcher(object o, object[] args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x176FBD0", Offset = "0x176E1D0", VA = "0x18176FBD0")]
		private static object IdentityDispatcher(object o, object[] args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x25002F0", Offset = "0x24FE8F0", VA = "0x1825002F0")]
		private static bool IsNumeric(TypeCode code)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x24FF930", Offset = "0x24FDF30", VA = "0x1824FF930")]
		public static bool EqualityOperator(object lhs, object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x24FE870", Offset = "0x24FCE70", VA = "0x1824FE870")]
		private static bool ArrayEqualityImpl(Array lhs, Array rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x2500080", Offset = "0x24FE680", VA = "0x182500080")]
		private static TypeCode GetConvertTypeCode(TypeCode lhsTypeCode, TypeCode rhsTypeCode)
		{
			return default(TypeCode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x24FF4F0", Offset = "0x24FDAF0", VA = "0x1824FF4F0")]
		private static bool EqualityOperator(object lhs, TypeCode lhsTypeCode, object rhs, TypeCode rhsTypeCode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x2500340", Offset = "0x24FE940", VA = "0x182500340")]
		internal static bool IsPromotableNumeric(TypeCode code)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x24FFEF0", Offset = "0x24FE4F0", VA = "0x1824FFEF0")]
		internal static MethodInfo FindImplicitConversionOperator(Type from, Type to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2500280", Offset = "0x24FE880", VA = "0x182500280")]
		private static IEnumerable<MethodInfo> GetExtensionMethods()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x24FFC60", Offset = "0x24FE260", VA = "0x1824FFC60")]
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
		[Cpp2IlInjected.Address(RVA = "0x24FD960", Offset = "0x24FBF60", VA = "0x1824FD960")]
		public Dispatcher Get(DispatcherKey key, DispatcherFactory factory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x31E0E0", Offset = "0x31C6E0", VA = "0x18031E0E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x2500B90", Offset = "0x24FF190", VA = "0x182500B90", Slot = "5")]
			public int GetHashCode(DispatcherKey key)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x2500AB0", Offset = "0x24FF0B0", VA = "0x182500AB0", Slot = "4")]
			public bool Equals(DispatcherKey x, DispatcherKey y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x31E0E0", Offset = "0x31C6E0", VA = "0x18031E0E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x49AD50", Offset = "0x499350", VA = "0x18049AD50")]
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
		[Cpp2IlInjected.Address(RVA = "0x24FE130", Offset = "0x24FC730", VA = "0x1824FE130")]
		public DispatcherEmitter(Type owner, string dynamicMethodName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x24FE070", Offset = "0x24FC670", VA = "0x1824FE070")]
		public Dispatcher Emit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void EmitMethodBody();

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x24FDCC0", Offset = "0x24FC2C0", VA = "0x1824FDCC0")]
		protected Dispatcher CreateMethodDispatcher()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x24FDD70", Offset = "0x24FC370", VA = "0x1824FDD70")]
		protected void EmitCastOrUnbox(Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x24FDC10", Offset = "0x24FC210", VA = "0x1824FDC10")]
		protected void BoxIfNeeded(Type returnType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x24FDEB0", Offset = "0x24FC4B0", VA = "0x1824FDEB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x24FE7F0", Offset = "0x24FCDF0", VA = "0x1824FE7F0")]
		public ImplicitConversionEmitter(MethodInfo conversion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x24FE410", Offset = "0x24FCA10", VA = "0x1824FE410", Slot = "4")]
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
