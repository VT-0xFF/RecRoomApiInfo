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
		[Cpp2IlInjected.Address(RVA = "0x259A7F0", Offset = "0x25991F0", VA = "0x18259A7F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x10534D0", Offset = "0x1051ED0", VA = "0x1810534D0", Slot = "30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IsSynchronized
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xD49440", Offset = "0xD47E40", VA = "0x180D49440", Slot = "32")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public object SyncRoot
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x1053570", Offset = "0x1051F70", VA = "0x181053570", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xD49440", Offset = "0xD47E40", VA = "0x180D49440", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public T this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x10534E0", Offset = "0x1051EE0", VA = "0x1810534E0", Slot = "4")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1053580", Offset = "0x1051F80", VA = "0x181053580", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		object IList.this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x10531A0", Offset = "0x1051BA0", VA = "0x1810531A0", Slot = "18")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x10531D0", Offset = "0x1051BD0", VA = "0x1810531D0", Slot = "19")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		bool IList.IsFixedSize
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xD49440", Offset = "0xD47E40", VA = "0x180D49440", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x10533F0", Offset = "0x1051DF0", VA = "0x1810533F0")]
		public List()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x1052B90", Offset = "0x1051590", VA = "0x181052B90", Slot = "11")]
		void ICollection<T>.Add(T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1052C90", Offset = "0x1051690", VA = "0x181052C90", Slot = "17")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x10525E0", Offset = "0x1050FE0", VA = "0x1810525E0", Slot = "16")]
		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1052380", Offset = "0x1050D80", VA = "0x181052380", Slot = "14")]
		public void CopyTo(T[] target, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1052AA0", Offset = "0x10514A0", VA = "0x181052AA0")]
		public List<T> Push(T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1052050", Offset = "0x1050A50", VA = "0x181052050", Slot = "34")]
		public virtual List<T> Add(T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x10532D0", Offset = "0x1051CD0", VA = "0x1810532D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x10529C0", Offset = "0x10513C0", VA = "0x1810529C0")]
		public string Join(string separator)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1052660", Offset = "0x1051060", VA = "0x181052660", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1052540", Offset = "0x1050F40", VA = "0x181052540", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1052420", Offset = "0x1050E20", VA = "0x181052420", Slot = "33")]
		public bool Equals(List<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1052140", Offset = "0x1050B40", VA = "0x181052140", Slot = "22")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1052350", Offset = "0x1050D50", VA = "0x181052350", Slot = "13")]
		public bool Contains(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x10526E0", Offset = "0x10510E0", VA = "0x1810526E0", Slot = "6")]
		public int IndexOf(T item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1052890", Offset = "0x1051290", VA = "0x181052890")]
		public List<T> Insert(int index, T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1052B50", Offset = "0x1051550", VA = "0x181052B50")]
		public List<T> Remove(T item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1052AD0", Offset = "0x10514D0", VA = "0x181052AD0")]
		public List<T> RemoveAt(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1052BF0", Offset = "0x10515F0", VA = "0x181052BF0", Slot = "7")]
		void IList<T>.Insert(int index, T item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1052C20", Offset = "0x1051620", VA = "0x181052C20", Slot = "8")]
		void IList<T>.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1052BC0", Offset = "0x10515C0", VA = "0x181052BC0", Slot = "15")]
		bool ICollection<T>.Remove(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x10523B0", Offset = "0x1050DB0", VA = "0x1810523B0")]
		private void EnsureCapacity(int minCapacity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x10529D0", Offset = "0x10513D0", VA = "0x1810529D0")]
		private T[] NewArray(int minCapacity)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x10527B0", Offset = "0x10511B0", VA = "0x1810527B0")]
		private void InnerRemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1052820", Offset = "0x1051220", VA = "0x181052820")]
		private bool InnerRemove(T item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x10520D0", Offset = "0x1050AD0", VA = "0x1810520D0")]
		private int CheckIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1052A90", Offset = "0x1051490", VA = "0x181052A90")]
		private int NormalizeIndex(int index)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1052CE0", Offset = "0x10516E0", VA = "0x181052CE0", Slot = "20")]
		int IList.Add(object value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1052F80", Offset = "0x1051980", VA = "0x181052F80", Slot = "26")]
		void IList.Insert(int index, object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x10521A0", Offset = "0x1050BA0", VA = "0x1810521A0")]
		private static T Coerce(object value)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x10530B0", Offset = "0x1051AB0", VA = "0x1810530B0", Slot = "27")]
		void IList.Remove(object value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1052E90", Offset = "0x1051890", VA = "0x181052E90", Slot = "25")]
		int IList.IndexOf(object value)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1052DA0", Offset = "0x10517A0", VA = "0x181052DA0", Slot = "21")]
		bool IList.Contains(object value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1053080", Offset = "0x1051A80", VA = "0x181053080", Slot = "28")]
		void IList.RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1052380", Offset = "0x1050D80", VA = "0x181052380", Slot = "29")]
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
			[Cpp2IlInjected.Address(RVA = "0x1053570", Offset = "0x1051F70", VA = "0x181053570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x259B460", Offset = "0x2599E60", VA = "0x18259B460")]
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
		[Cpp2IlInjected.Address(RVA = "0x259D220", Offset = "0x259BC20", VA = "0x18259D220")]
		private static Dispatcher GetDispatcher(object target, string cacheKeyName, Type[] cacheKeyTypes, DispatcherCache.DispatcherFactory factory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x259BA90", Offset = "0x259A490", VA = "0x18259BA90")]
		public static object Coerce(object value, Type toType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x259BEF0", Offset = "0x259A8F0", VA = "0x18259BEF0")]
		private static Dispatcher CreateCoerceDispatcher(object value, Type toType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x259C310", Offset = "0x259AD10", VA = "0x18259C310")]
		private static Dispatcher EmitPromotionDispatcher(Type fromType, Type toType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x259D470", Offset = "0x259BE70", VA = "0x18259D470")]
		private static bool IsPromotableNumeric(Type fromType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x259C1D0", Offset = "0x259ABD0", VA = "0x18259C1D0")]
		private static Dispatcher EmitImplicitConversionDispatcher(MethodInfo method)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x259BD50", Offset = "0x259A750", VA = "0x18259BD50")]
		private static object CoercibleDispatcher(object o, object[] args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x16FF920", Offset = "0x16FE320", VA = "0x1816FF920")]
		private static object IdentityDispatcher(object o, object[] args)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x259D3C0", Offset = "0x259BDC0", VA = "0x18259D3C0")]
		private static bool IsNumeric(TypeCode code)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x259CA00", Offset = "0x259B400", VA = "0x18259CA00")]
		public static bool EqualityOperator(object lhs, object rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x259B940", Offset = "0x259A340", VA = "0x18259B940")]
		private static bool ArrayEqualityImpl(Array lhs, Array rhs)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x259D150", Offset = "0x259BB50", VA = "0x18259D150")]
		private static TypeCode GetConvertTypeCode(TypeCode lhsTypeCode, TypeCode rhsTypeCode)
		{
			return default(TypeCode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x259C5C0", Offset = "0x259AFC0", VA = "0x18259C5C0")]
		private static bool EqualityOperator(object lhs, TypeCode lhsTypeCode, object rhs, TypeCode rhsTypeCode)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x259D410", Offset = "0x259BE10", VA = "0x18259D410")]
		internal static bool IsPromotableNumeric(TypeCode code)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x259CFC0", Offset = "0x259B9C0", VA = "0x18259CFC0")]
		internal static MethodInfo FindImplicitConversionOperator(Type from, Type to)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x259D350", Offset = "0x259BD50", VA = "0x18259D350")]
		private static IEnumerable<MethodInfo> GetExtensionMethods()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x259CD30", Offset = "0x259B730", VA = "0x18259CD30")]
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
		[Cpp2IlInjected.Address(RVA = "0x259AA30", Offset = "0x2599430", VA = "0x18259AA30")]
		public Dispatcher Get(DispatcherKey key, DispatcherFactory factory)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x32A0E0", Offset = "0x328AE0", VA = "0x18032A0E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x259DC60", Offset = "0x259C660", VA = "0x18259DC60", Slot = "5")]
			public int GetHashCode(DispatcherKey key)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x259DB80", Offset = "0x259C580", VA = "0x18259DB80", Slot = "4")]
			public bool Equals(DispatcherKey x, DispatcherKey y)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x32A0E0", Offset = "0x328AE0", VA = "0x18032A0E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x448FC0", Offset = "0x4479C0", VA = "0x180448FC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x259B200", Offset = "0x2599C00", VA = "0x18259B200")]
		public DispatcherEmitter(Type owner, string dynamicMethodName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x259B140", Offset = "0x2599B40", VA = "0x18259B140")]
		public Dispatcher Emit()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		protected abstract void EmitMethodBody();

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x259AD90", Offset = "0x2599790", VA = "0x18259AD90")]
		protected Dispatcher CreateMethodDispatcher()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x259AE40", Offset = "0x2599840", VA = "0x18259AE40")]
		protected void EmitCastOrUnbox(Type type)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x259ACE0", Offset = "0x25996E0", VA = "0x18259ACE0")]
		protected void BoxIfNeeded(Type returnType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x259AF80", Offset = "0x2599980", VA = "0x18259AF80")]
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
		[Cpp2IlInjected.Address(RVA = "0x259B8C0", Offset = "0x259A2C0", VA = "0x18259B8C0")]
		public ImplicitConversionEmitter(MethodInfo conversion)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x259B4E0", Offset = "0x2599EE0", VA = "0x18259B4E0", Slot = "4")]
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
