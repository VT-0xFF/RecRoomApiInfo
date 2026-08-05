using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using RecRoom.NoEngine.DataStructures.Runtime.Caching;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF1800", Offset = "0xAF0600", VA = "0x180AF1800")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.PrefParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CDJFAVVSKVV : RJQLTHPVVVO<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x891EBC0", Offset = "0x891D9C0", VA = "0x18891EBC0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x891EBF0", Offset = "0x891D9F0", VA = "0x18891EBF0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x891EC40", Offset = "0x891DA40", VA = "0x18891EC40")]
		public CDJFAVVSKVV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class GDJACPMRMJQ : RJQLTHPVVVO<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x891EDC0", Offset = "0x891DBC0", VA = "0x18891EDC0", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x891EE50", Offset = "0x891DC50", VA = "0x18891EE50", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x891EEF0", Offset = "0x891DCF0", VA = "0x18891EEF0")]
		public GDJACPMRMJQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class NQRJBEGTBNI<a> : RJQLTHPVVVO<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Type HIFOKETNOPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool ACARWAQAGRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly a[] OLXKLYIEXVA;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x59FADA0", Offset = "0x59F9BA0", VA = "0x1859FADA0")]
		[Preserve]
		public NQRJBEGTBNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x59FA5D0", Offset = "0x59F93D0", VA = "0x1859FA5D0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x59FAB30", Offset = "0x59F9930", VA = "0x1859FAB30", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class NHGMONCTSWR<a> : RJQLTHPVVVO<a> where a : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Type HIFOKETNOPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly EMHXHIEZFNL TAVWGBYWXVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly bool ACARWAQAGRK;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x59ECD50", Offset = "0x59EBB50", VA = "0x1859ECD50")]
		[Preserve]
		public NHGMONCTSWR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x59EC4A0", Offset = "0x59EB2A0", VA = "0x1859EC4A0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x59EC6B0", Offset = "0x59EB4B0", VA = "0x1859EC6B0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class SQHAVRUUMBE
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Dictionary<Type, EMHXHIEZFNL> DBIEVRTPRFA;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x891F410", Offset = "0x891E210", VA = "0x18891F410")]
		public static EMHXHIEZFNL KOVDHURSMHY(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class YCRDDAFRVBZ<a> : RJQLTHPVVVO<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3C4A180", Offset = "0x3C48F80", VA = "0x183C4A180", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3EF6940", Offset = "0x3EF5740", VA = "0x183EF6940", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3EF69F0", Offset = "0x3EF57F0", VA = "0x183EF69F0")]
		public YCRDDAFRVBZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class BPWKGXLWAXJ<a, b> : RJQLTHPVVVO<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly XJDIQSDJBRI<b> CKJKCOZGSHR;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x714B3A0", Offset = "0x714A1A0", VA = "0x18714B3A0")]
		protected BPWKGXLWAXJ(XJDIQSDJBRI<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7147B20", Offset = "0x7146920", VA = "0x187147B20", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7149DD0", Offset = "0x7148BD0", VA = "0x187149DD0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a CPBZGODEDMQ(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x714B370", Offset = "0x714A170", VA = "0x18714B370", Slot = "12")]
		internal virtual IEnumerable<string> VTNYVAGZWEE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7147540", Offset = "0x7146340", VA = "0x187147540")]
		[CompilerGenerated]
		private string SYWKAVOQWRH(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class BWLEACDIHBH<a> : BPWKGXLWAXJ<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x714C6C0", Offset = "0x714B4C0", VA = "0x18714C6C0")]
		[Preserve]
		public BWLEACDIHBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x714C590", Offset = "0x714B390", VA = "0x18714C590")]
		[Preserve]
		public BWLEACDIHBH(XJDIQSDJBRI<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x714BFD0", Offset = "0x714ADD0", VA = "0x18714BFD0", Slot = "11")]
		protected override a[] CPBZGODEDMQ(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class HVDITQXQNNW<a> : BPWKGXLWAXJ<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5011130", Offset = "0x500FF30", VA = "0x185011130")]
		[Preserve]
		public HVDITQXQNNW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5011150", Offset = "0x500FF50", VA = "0x185011150")]
		[Preserve]
		public HVDITQXQNNW([Optional] XJDIQSDJBRI<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5010A60", Offset = "0x500F860", VA = "0x185010A60", Slot = "11")]
		protected override List<a> CPBZGODEDMQ(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ZEHVVHPCWEA<a> : RJQLTHPVVVO<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? TDONIKGNGCL;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3FD4B50", Offset = "0x3FD3950", VA = "0x183FD4B50")]
		public ZEHVVHPCWEA(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3FD4770", Offset = "0x3FD3570", VA = "0x183FD4770", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3FD48D0", Offset = "0x3FD36D0", VA = "0x183FD48D0", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class AXBWAKRGKEV : RJQLTHPVVVO<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x891EA90", Offset = "0x891D890", VA = "0x18891EA90", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x891EAF0", Offset = "0x891D8F0", VA = "0x18891EAF0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x891EB80", Offset = "0x891D980", VA = "0x18891EB80")]
		public AXBWAKRGKEV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class WOPEZMCPSWB : RJQLTHPVVVO<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x891FE80", Offset = "0x891EC80", VA = "0x18891FE80", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x891FEE0", Offset = "0x891ECE0", VA = "0x18891FEE0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x891FF80", Offset = "0x891ED80", VA = "0x18891FF80")]
		public WOPEZMCPSWB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class CXEMOYGIHFC : RJQLTHPVVVO<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x891EC80", Offset = "0x891DA80", VA = "0x18891EC80", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x891ECE0", Offset = "0x891DAE0", VA = "0x18891ECE0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x891ED80", Offset = "0x891DB80", VA = "0x18891ED80")]
		public CXEMOYGIHFC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ORRTPJFWVTU : RJQLTHPVVVO<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x891F010", Offset = "0x891DE10", VA = "0x18891F010", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x891F070", Offset = "0x891DE70", VA = "0x18891F070", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x891F100", Offset = "0x891DF00", VA = "0x18891F100")]
		public ORRTPJFWVTU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class PXEJVXLGNYL : RJQLTHPVVVO<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x891F140", Offset = "0x891DF40", VA = "0x18891F140", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x891F1A0", Offset = "0x891DFA0", VA = "0x18891F1A0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x891F230", Offset = "0x891E030", VA = "0x18891F230")]
		public PXEJVXLGNYL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class TNOEJOVHQFX : RJQLTHPVVVO<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x891FB50", Offset = "0x891E950", VA = "0x18891FB50", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x891FBB0", Offset = "0x891E9B0", VA = "0x18891FBB0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x891FC50", Offset = "0x891EA50", VA = "0x18891FC50")]
		public TNOEJOVHQFX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class RXESBYDPEHA : RJQLTHPVVVO<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x891F2D0", Offset = "0x891E0D0", VA = "0x18891F2D0", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x891F330", Offset = "0x891E130", VA = "0x18891F330", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x891F3D0", Offset = "0x891E1D0", VA = "0x18891F3D0")]
		public RXESBYDPEHA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class UIXVZYBPLLT : RJQLTHPVVVO<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x891FC90", Offset = "0x891EA90", VA = "0x18891FC90", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x891FD00", Offset = "0x891EB00", VA = "0x18891FD00", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x891FD90", Offset = "0x891EB90", VA = "0x18891FD90")]
		public UIXVZYBPLLT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface EMHXHIEZFNL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string UBTVVBSQFBN(object a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool GKODQROYSYV([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface XJDIQSDJBRI<a> : EMHXHIEZFNL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool XFEWASNMRQE([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a PBDDNACPTQD([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class RJQLTHPVVVO<a> : XJDIQSDJBRI<a>, EMHXHIEZFNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type DKSEUVDFCWA;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5D75170", Offset = "0x5D73F70", VA = "0x185D75170")]
		protected RJQLTHPVVVO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5D73C10", Offset = "0x5D72A10", VA = "0x185D73C10")]
		private a NCYTCYCFOYE(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5D74D20", Offset = "0x5D73B20", VA = "0x185D74D20", Slot = "7")]
		public string UBTVVBSQFBN(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5D75150", Offset = "0x5D73F50", VA = "0x185D75150", Slot = "5")]
		public bool XFEWASNMRQE(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5D745A0", Offset = "0x5D733A0", VA = "0x185D745A0", Slot = "8")]
		private bool RQCYSHZRULR(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5D73FE0", Offset = "0x5D72DE0", VA = "0x185D73FE0", Slot = "6")]
		public a PBDDNACPTQD(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class ECRTLORWEXX<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static XJDIQSDJBRI<b> CJGYMEELLGF
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4836C20", Offset = "0x4835A20", VA = "0x184836C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x363C5E0", Offset = "0x363B3E0", VA = "0x18363C5E0")]
		public static XJDIQSDJBRI<a> FVEFGLDUZZQ<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x482D7A0", Offset = "0x482C5A0", VA = "0x18482D7A0")]
		public static EMHXHIEZFNL FVEFGLDUZZQ(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4829C20", Offset = "0x4828A20", VA = "0x184829C20")]
		private static EMHXHIEZFNL ETRYKZRZMBR(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4835D40", Offset = "0x4834B40", VA = "0x184835D40")]
		private static EMHXHIEZFNL IMGUXXDMWAG(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class YCFIYNUCECY<a> : BPWKGXLWAXJ<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class GBVPFLMPIQZ : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private string LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int DGBKDPSSRXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private string SZQOPRICWFS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public string UNWRGWCHJMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public YCFIYNUCECY<a> FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private PooledObject<StringBuilder> XZKWGBNZRTS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private StringBuilder GPAOZVSIJFW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool FVBJPOSWKKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int RACKJTTYHTN;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private string NIKLBOMTNZR
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xDE87C0", Offset = "0xDE75C0", VA = "0x180DE87C0")]
			[DebuggerHidden]
			public GBVPFLMPIQZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x4F7A730", Offset = "0x4F79530", VA = "0x184F7A730", Slot = "7")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4F79DE0", Offset = "0x4F78BE0", VA = "0x184F79DE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x4F79AE0", Offset = "0x4F788E0", VA = "0x184F79AE0")]
			private void GWSJMPTZZMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3DD1D80", Offset = "0x3DD0B80", VA = "0x183DD1D80", Slot = "10")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4F79B80", Offset = "0x4F78980", VA = "0x184F79B80", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> GZIMJFDXMSY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4F79D10", Offset = "0x4F78B10", VA = "0x184F79D10", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HTHYFOXNRHD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool SDLNJDAWPNJ;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3EE5130", Offset = "0x3EE3F30", VA = "0x183EE5130")]
		protected YCFIYNUCECY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x3EE4990", Offset = "0x3EE3790", VA = "0x183EE4990", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3EE4ED0", Offset = "0x3EE3CD0", VA = "0x183EE4ED0", Slot = "12")]
		[IteratorStateMachine(typeof(YCFIYNUCECY<>.GBVPFLMPIQZ))]
		internal override IEnumerable<string> VTNYVAGZWEE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3EE5030", Offset = "0x3EE3E30", VA = "0x183EE5030")]
		[CompilerGenerated]
		internal static string WEDPUGMWSZE(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class HCOJWJSJAUC : YCFIYNUCECY<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x891EFC0", Offset = "0x891DDC0", VA = "0x18891EFC0")]
		[Preserve]
		public HCOJWJSJAUC(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x891EF30", Offset = "0x891DD30", VA = "0x18891EF30", Slot = "11")]
		protected override List<string> CPBZGODEDMQ(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class UWPLCUZKNON : YCFIYNUCECY<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x891FE30", Offset = "0x891EC30", VA = "0x18891FE30")]
		[Preserve]
		public UWPLCUZKNON(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x891FDD0", Offset = "0x891EBD0", VA = "0x18891FDD0", Slot = "11")]
		protected override string[] CPBZGODEDMQ(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class RPUXHVUKKNU : RJQLTHPVVVO<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB2C9D0", Offset = "0xB2B7D0", VA = "0x180B2C9D0", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x891F270", Offset = "0x891E070", VA = "0x18891F270", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x891F290", Offset = "0x891E090", VA = "0x18891F290")]
		public RPUXHVUKKNU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class ZKTGGMXEVOV : RJQLTHPVVVO<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x891FFC0", Offset = "0x891EDC0", VA = "0x18891FFC0", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x89200E0", Offset = "0x891EEE0", VA = "0x1889200E0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8920250", Offset = "0x891F050", VA = "0x188920250")]
		public ZKTGGMXEVOV()
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
