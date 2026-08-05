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
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F30", Offset = "0xAC6D30", VA = "0x180AC7F30")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC7F70", Offset = "0xAC6D70", VA = "0x180AC7F70")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.PrefParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class VWUYSNBEGXW : GWIWWXKWCSX<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x887DCB0", Offset = "0x887CAB0", VA = "0x18887DCB0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x887DC60", Offset = "0x887CA60", VA = "0x18887DC60", Slot = "10")]
		protected override bool DZORAZMGDTM(string a, [Out] bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x887DCE0", Offset = "0x887CAE0", VA = "0x18887DCE0")]
		public VWUYSNBEGXW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class JPQJMEMPIOR : GWIWWXKWCSX<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x887CF50", Offset = "0x887BD50", VA = "0x18887CF50", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x887CEB0", Offset = "0x887BCB0", VA = "0x18887CEB0", Slot = "10")]
		protected override bool DZORAZMGDTM(string a, [Out] DateTime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x887CFE0", Offset = "0x887BDE0", VA = "0x18887CFE0")]
		public JPQJMEMPIOR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class NEYYNRLDJTD<a> : GWIWWXKWCSX<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Type XWIWQFCBWQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool RLRUTUTLOSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly a[] WVFCBODGYPP;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5A1BA40", Offset = "0x5A1A840", VA = "0x185A1BA40")]
		[Preserve]
		public NEYYNRLDJTD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5A1B470", Offset = "0x5A1A270", VA = "0x185A1B470", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5A1B2E0", Offset = "0x5A1A0E0", VA = "0x185A1B2E0", Slot = "10")]
		protected override bool DZORAZMGDTM(string a, [Out] a b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class RBAVFBMMBIS<a> : GWIWWXKWCSX<a> where a : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Type XWIWQFCBWQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly EQJOBTJRTTG RRJNKCTVZHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly bool RLRUTUTLOSB;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5D278C0", Offset = "0x5D266C0", VA = "0x185D278C0")]
		[Preserve]
		public RBAVFBMMBIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5D275A0", Offset = "0x5D263A0", VA = "0x185D275A0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5D27350", Offset = "0x5D26150", VA = "0x185D27350", Slot = "10")]
		protected override bool DZORAZMGDTM(string a, [Out] a b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class QLOIWNEZGYB
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Dictionary<Type, EQJOBTJRTTG> ZMALMEDROIN;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x887D200", Offset = "0x887C000", VA = "0x18887D200")]
		public static EQJOBTJRTTG SSLWZRCVDQJ(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class DFHZAYRIBGK<a> : GWIWWXKWCSX<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4329F60", Offset = "0x4328D60", VA = "0x184329F60", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4329DD0", Offset = "0x4328BD0", VA = "0x184329DD0", Slot = "10")]
		protected override bool DZORAZMGDTM(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x407BF00", Offset = "0x407AD00", VA = "0x18407BF00")]
		public DFHZAYRIBGK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class KLZHDTWVVWQ<a, b> : GWIWWXKWCSX<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly MLGBGFQUWCP<b> GBBINHOMFAS;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x53BAF10", Offset = "0x53B9D10", VA = "0x1853BAF10")]
		protected KLZHDTWVVWQ(MLGBGFQUWCP<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x53BA5C0", Offset = "0x53B93C0", VA = "0x1853BA5C0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x53B7EC0", Offset = "0x53B6CC0", VA = "0x1853B7EC0", Slot = "10")]
		protected override bool DZORAZMGDTM(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a FMXWSCBPCLF(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x53B9E10", Offset = "0x53B8C10", VA = "0x1853B9E10", Slot = "12")]
		internal virtual IEnumerable<string> RQHVMOATFNV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x53BABA0", Offset = "0x53B99A0", VA = "0x1853BABA0")]
		[CompilerGenerated]
		private string YGICXIYYBXG(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class WBBVDDYZNWI<a> : KLZHDTWVVWQ<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x50FDC00", Offset = "0x50FCA00", VA = "0x1850FDC00")]
		[Preserve]
		public WBBVDDYZNWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x50FDC20", Offset = "0x50FCA20", VA = "0x1850FDC20")]
		[Preserve]
		public WBBVDDYZNWI(MLGBGFQUWCP<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x67590D0", Offset = "0x6757ED0", VA = "0x1867590D0", Slot = "11")]
		protected override a[] FMXWSCBPCLF(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class HBCOTUAHKLN<a> : KLZHDTWVVWQ<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x50FDC00", Offset = "0x50FCA00", VA = "0x1850FDC00")]
		[Preserve]
		public HBCOTUAHKLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x50FDC20", Offset = "0x50FCA20", VA = "0x1850FDC20")]
		[Preserve]
		public HBCOTUAHKLN([Optional] MLGBGFQUWCP<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x50FD770", Offset = "0x50FC570", VA = "0x1850FD770", Slot = "11")]
		protected override List<a> FMXWSCBPCLF(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class OQDWXMOZSXJ<a> : GWIWWXKWCSX<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? JEZPLBUTLZK;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5B60000", Offset = "0x5B5EE00", VA = "0x185B60000")]
		public OQDWXMOZSXJ(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5B5FFA0", Offset = "0x5B5EDA0", VA = "0x185B5FFA0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5B5FE00", Offset = "0x5B5EC00", VA = "0x185B5FE00", Slot = "10")]
		protected override bool DZORAZMGDTM([NotNull] string input, [Out] a a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class HBFYJUJZXGS : GWIWWXKWCSX<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x887C8C0", Offset = "0x887B6C0", VA = "0x18887C8C0", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x887C830", Offset = "0x887B630", VA = "0x18887C830", Slot = "10")]
		protected override bool DZORAZMGDTM(string a, [Out] byte b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x887C920", Offset = "0x887B720", VA = "0x18887C920")]
		public HBFYJUJZXGS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class RUNSIHQFVDO : GWIWWXKWCSX<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x887D9A0", Offset = "0x887C7A0", VA = "0x18887D9A0", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x887D900", Offset = "0x887C700", VA = "0x18887D900", Slot = "10")]
		protected override bool DZORAZMGDTM(string a, [Out] short b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x887DA00", Offset = "0x887C800", VA = "0x18887DA00")]
		public RUNSIHQFVDO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class SFRJDXHGVET : GWIWWXKWCSX<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x887DAE0", Offset = "0x887C8E0", VA = "0x18887DAE0", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x887DA40", Offset = "0x887C840", VA = "0x18887DA40", Slot = "10")]
		protected override bool DZORAZMGDTM(string a, [Out] ushort b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x887DB40", Offset = "0x887C940", VA = "0x18887DB40")]
		public SFRJDXHGVET()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ATXRBBLUXET : GWIWWXKWCSX<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x887C730", Offset = "0x887B530", VA = "0x18887C730", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x887C6A0", Offset = "0x887B4A0", VA = "0x18887C6A0", Slot = "10")]
		protected override bool DZORAZMGDTM(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x887C790", Offset = "0x887B590", VA = "0x18887C790")]
		public ATXRBBLUXET()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class LEGCMZQTDHW : GWIWWXKWCSX<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x887D0B0", Offset = "0x887BEB0", VA = "0x18887D0B0", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x887D020", Offset = "0x887BE20", VA = "0x18887D020", Slot = "10")]
		protected override bool DZORAZMGDTM(string a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x887D110", Offset = "0x887BF10", VA = "0x18887D110")]
		public LEGCMZQTDHW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class HEXMMGMLJMS : GWIWWXKWCSX<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x887CB40", Offset = "0x887B940", VA = "0x18887CB40", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x887CAA0", Offset = "0x887B8A0", VA = "0x18887CAA0", Slot = "10")]
		protected override bool DZORAZMGDTM(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x887CBA0", Offset = "0x887B9A0", VA = "0x18887CBA0")]
		public HEXMMGMLJMS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class HEXFYIFCHRZ : GWIWWXKWCSX<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x887CA00", Offset = "0x887B800", VA = "0x18887CA00", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x887C960", Offset = "0x887B760", VA = "0x18887C960", Slot = "10")]
		protected override bool DZORAZMGDTM(string a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x887CA60", Offset = "0x887B860", VA = "0x18887CA60")]
		public HEXFYIFCHRZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class AOQNTBKLWAU : GWIWWXKWCSX<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x887C5F0", Offset = "0x887B3F0", VA = "0x18887C5F0", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x887C560", Offset = "0x887B360", VA = "0x18887C560", Slot = "10")]
		protected override bool DZORAZMGDTM(string a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x887C660", Offset = "0x887B460", VA = "0x18887C660")]
		public AOQNTBKLWAU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface EQJOBTJRTTG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string ZRZGJZSLENW(object a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool ISIGDZRHCFC([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface MLGBGFQUWCP<a> : EQJOBTJRTTG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CUOXAFRLPOP([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a XHDXCEAGLJM([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class GWIWWXKWCSX<a> : MLGBGFQUWCP<a>, EQJOBTJRTTG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type NOCSVXQKCBX;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x50B4630", Offset = "0x50B3430", VA = "0x1850B4630")]
		protected GWIWWXKWCSX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x50B3260", Offset = "0x50B2060", VA = "0x1850B3260")]
		private a DMGYYEEFTHT(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x50B3A60", Offset = "0x50B2860", VA = "0x1850B3A60", Slot = "7")]
		public string ZRZGJZSLENW(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x50B2F10", Offset = "0x50B1D10", VA = "0x1850B2F10", Slot = "5")]
		public bool CUOXAFRLPOP(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool DZORAZMGDTM([NotNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x50B4220", Offset = "0x50B3020", VA = "0x1850B4220", Slot = "8")]
		private bool ZXOMIROWZKG(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x50B3860", Offset = "0x50B2660", VA = "0x1850B3860", Slot = "6")]
		public a XHDXCEAGLJM(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class HMZALCAMTCS<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static MLGBGFQUWCP<b> SNTFEPMFQUI
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4F1E180", Offset = "0x4F1CF80", VA = "0x184F1E180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3A5DF90", Offset = "0x3A5CD90", VA = "0x183A5DF90")]
		public static MLGBGFQUWCP<a> DEDRYUIYJVJ<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5102CB0", Offset = "0x5101AB0", VA = "0x185102CB0")]
		public static EQJOBTJRTTG DEDRYUIYJVJ(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5107CC0", Offset = "0x5106AC0", VA = "0x185107CC0")]
		private static EQJOBTJRTTG SFUBBQYJLUU(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5106570", Offset = "0x5105370", VA = "0x185106570")]
		private static EQJOBTJRTTG LBMJHTWWFHZ(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class ZXGXTKXIBTT<a> : KLZHDTWVVWQ<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class UWMUVSUDNXA : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int DPSIYUGFINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private string KPVEVSUGXYQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int SNADUNBHBXY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private string EHPOPTCAQBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public string VSJQYPHHMJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public ZXGXTKXIBTT<a> SVDPBWSVAHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private PooledObject<StringBuilder> GZMQSTBODHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private StringBuilder AKHYERVXLZL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool DUVOHHKYUSZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int AIJAPAFLRYO;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private string XVIXERCRYDU
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object SQVTSFKREWF
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xB50450", Offset = "0xB4F250", VA = "0x180B50450")]
			[DebuggerHidden]
			public UWMUVSUDNXA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x62EE1E0", Offset = "0x62ECFE0", VA = "0x1862EE1E0", Slot = "7")]
			[DebuggerHidden]
			private void DUPJTQKNSZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x62EE280", Offset = "0x62ED080", VA = "0x1862EE280", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x62EED50", Offset = "0x62EDB50", VA = "0x1862EED50")]
			private void XVTZRJOPNYU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x402B990", Offset = "0x402A790", VA = "0x18402B990", Slot = "10")]
			[DebuggerHidden]
			private void KJSXTMSAUIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x62EEB10", Offset = "0x62ED910", VA = "0x1862EEB10", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> SGKYRZSMZGJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x62EEC90", Offset = "0x62EDA90", VA = "0x1862EEC90", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WAAULASRGHE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool GPZYINPEVEA;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x417FCB0", Offset = "0x417EAB0", VA = "0x18417FCB0")]
		protected ZXGXTKXIBTT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x417F680", Offset = "0x417E480", VA = "0x18417F680", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x417F520", Offset = "0x417E320", VA = "0x18417F520", Slot = "12")]
		[IteratorStateMachine(typeof(ZXGXTKXIBTT<>.UWMUVSUDNXA))]
		internal override IEnumerable<string> RQHVMOATFNV(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x417FB70", Offset = "0x417E970", VA = "0x18417FB70")]
		[CompilerGenerated]
		internal static string WHQAPXBPQNZ(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class VEPHSPXVGXT : ZXGXTKXIBTT<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x887DC10", Offset = "0x887CA10", VA = "0x18887DC10")]
		[Preserve]
		public VEPHSPXVGXT(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x887DB80", Offset = "0x887C980", VA = "0x18887DB80", Slot = "11")]
		protected override List<string> FMXWSCBPCLF(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class PHVUZEUJTLK : ZXGXTKXIBTT<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x887D1B0", Offset = "0x887BFB0", VA = "0x18887D1B0")]
		[Preserve]
		public PHVUZEUJTLK(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x887D150", Offset = "0x887BF50", VA = "0x18887D150", Slot = "11")]
		protected override string[] FMXWSCBPCLF(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class DQYSOICKZDL : GWIWWXKWCSX<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAFDDA0", Offset = "0xAFCBA0", VA = "0x180AFDDA0", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x887C7D0", Offset = "0x887B5D0", VA = "0x18887C7D0", Slot = "10")]
		protected override bool DZORAZMGDTM(string a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x887C7F0", Offset = "0x887B5F0", VA = "0x18887C7F0")]
		public DQYSOICKZDL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class HIUBMNJUFTA : GWIWWXKWCSX<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x887CD50", Offset = "0x887BB50", VA = "0x18887CD50", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x887CBE0", Offset = "0x887B9E0", VA = "0x18887CBE0", Slot = "10")]
		protected override bool DZORAZMGDTM(string a, [Out] TimeSpan b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x887CE70", Offset = "0x887BC70", VA = "0x18887CE70")]
		public HIUBMNJUFTA()
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
