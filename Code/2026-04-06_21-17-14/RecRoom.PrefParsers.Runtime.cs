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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.PrefParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class YDLTBAAIHQZ : JAIVNHEPHYK<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8B60", Offset = "0x9DB7B60", VA = "0x189DB8B60", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8B90", Offset = "0x9DB7B90", VA = "0x189DB8B90", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8BE0", Offset = "0x9DB7BE0", VA = "0x189DB8BE0")]
		public YDLTBAAIHQZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class PDAIFQNXRZO : JAIVNHEPHYK<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8430", Offset = "0x9DB7430", VA = "0x189DB8430", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9DB84C0", Offset = "0x9DB74C0", VA = "0x189DB84C0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8560", Offset = "0x9DB7560", VA = "0x189DB8560")]
		public PDAIFQNXRZO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class WJCMYBNHGRW<a> : JAIVNHEPHYK<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Type PYURSKXIORF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool QNYAPNZABGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly a[] RJVHYOLOEWI;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8725010", Offset = "0x8724010", VA = "0x188725010")]
		[Preserve]
		public WJCMYBNHGRW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8724BC0", Offset = "0x8723BC0", VA = "0x188724BC0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8724E70", Offset = "0x8723E70", VA = "0x188724E70", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class NFXKBKATHNN<a> : JAIVNHEPHYK<a> where a : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Type PYURSKXIORF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly TCQWDZGEQIX VKXJTWNQLOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly bool QNYAPNZABGK;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72918C0", Offset = "0x72908C0", VA = "0x1872918C0")]
		[Preserve]
		public NFXKBKATHNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7291140", Offset = "0x7290140", VA = "0x187291140", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7291670", Offset = "0x7290670", VA = "0x187291670", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class YZSJDCQIMPK
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Dictionary<Type, TCQWDZGEQIX> VVHUUSEDMCI;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8C20", Offset = "0x9DB7C20", VA = "0x189DB8C20")]
		public static TCQWDZGEQIX QSWYQEZEDSQ(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class FAWHWUZRWCB<a> : JAIVNHEPHYK<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x40691C0", Offset = "0x40681C0", VA = "0x1840691C0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x62C1CC0", Offset = "0x62C0CC0", VA = "0x1862C1CC0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x62C1E10", Offset = "0x62C0E10", VA = "0x1862C1E10")]
		public FAWHWUZRWCB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class EPHWQDDJBCJ<a, b> : JAIVNHEPHYK<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly RHGAWVQGRXS<b> GPDMMINKTPX;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5B4D600", Offset = "0x5B4C600", VA = "0x185B4D600")]
		protected EPHWQDDJBCJ(RHGAWVQGRXS<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5B4A1C0", Offset = "0x5B491C0", VA = "0x185B4A1C0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5B4C3C0", Offset = "0x5B4B3C0", VA = "0x185B4C3C0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a RWAJQQRUZYW(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5B493C0", Offset = "0x5B483C0", VA = "0x185B493C0", Slot = "12")]
		internal virtual IEnumerable<string> CMMTOFXVYOW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5B49670", Offset = "0x5B48670", VA = "0x185B49670")]
		[CompilerGenerated]
		private string IIPAPMNDTBB(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class RSRSEDAEQHV<a> : EPHWQDDJBCJ<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6526E70", Offset = "0x6525E70", VA = "0x186526E70")]
		[Preserve]
		public RSRSEDAEQHV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6526E90", Offset = "0x6525E90", VA = "0x186526E90")]
		[Preserve]
		public RSRSEDAEQHV(RHGAWVQGRXS<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7843700", Offset = "0x7842700", VA = "0x187843700", Slot = "11")]
		protected override a[] RWAJQQRUZYW(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class HUJIYNJBWXM<a> : EPHWQDDJBCJ<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6526E70", Offset = "0x6525E70", VA = "0x186526E70")]
		[Preserve]
		public HUJIYNJBWXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6526E90", Offset = "0x6525E90", VA = "0x186526E90")]
		[Preserve]
		public HUJIYNJBWXM([Optional] RHGAWVQGRXS<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6526DC0", Offset = "0x6525DC0", VA = "0x186526DC0", Slot = "11")]
		protected override List<a> RWAJQQRUZYW(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class OREMBOMPDOW<a> : JAIVNHEPHYK<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? RBASLJFECAV;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x73F81B0", Offset = "0x73F71B0", VA = "0x1873F81B0")]
		public OREMBOMPDOW(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x73F7F10", Offset = "0x73F6F10", VA = "0x1873F7F10", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x73F8100", Offset = "0x73F7100", VA = "0x1873F8100", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class PBEUTWBMIJJ : JAIVNHEPHYK<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8300", Offset = "0x9DB7300", VA = "0x189DB8300", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8360", Offset = "0x9DB7360", VA = "0x189DB8360", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9DB83F0", Offset = "0x9DB73F0", VA = "0x189DB83F0")]
		public PBEUTWBMIJJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class ZOIKBDSYMZV : JAIVNHEPHYK<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9360", Offset = "0x9DB8360", VA = "0x189DB9360", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9DB93C0", Offset = "0x9DB83C0", VA = "0x189DB93C0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9DB9460", Offset = "0x9DB8460", VA = "0x189DB9460")]
		public ZOIKBDSYMZV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class WZVFLIICFYC : JAIVNHEPHYK<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8A20", Offset = "0x9DB7A20", VA = "0x189DB8A20", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8A80", Offset = "0x9DB7A80", VA = "0x189DB8A80", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8B20", Offset = "0x9DB7B20", VA = "0x189DB8B20")]
		public WZVFLIICFYC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class SMSPMILIKXC : JAIVNHEPHYK<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8810", Offset = "0x9DB7810", VA = "0x189DB8810", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8870", Offset = "0x9DB7870", VA = "0x189DB8870", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8900", Offset = "0x9DB7900", VA = "0x189DB8900")]
		public SMSPMILIKXC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class PQQOBIKQDVH : JAIVNHEPHYK<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9DB85A0", Offset = "0x9DB75A0", VA = "0x189DB85A0", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8600", Offset = "0x9DB7600", VA = "0x189DB8600", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8690", Offset = "0x9DB7690", VA = "0x189DB8690")]
		public PQQOBIKQDVH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class PYQDNMKZRLF : JAIVNHEPHYK<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9DB86D0", Offset = "0x9DB76D0", VA = "0x189DB86D0", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8730", Offset = "0x9DB7730", VA = "0x189DB8730", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9DB87D0", Offset = "0x9DB77D0", VA = "0x189DB87D0")]
		public PYQDNMKZRLF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class JQHPMGNQYRW : JAIVNHEPHYK<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7DB0", Offset = "0x9DB6DB0", VA = "0x189DB7DB0", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7E10", Offset = "0x9DB6E10", VA = "0x189DB7E10", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7EB0", Offset = "0x9DB6EB0", VA = "0x189DB7EB0")]
		public JQHPMGNQYRW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class OGGWHGSOCZB : JAIVNHEPHYK<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9DB81C0", Offset = "0x9DB71C0", VA = "0x189DB81C0", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8230", Offset = "0x9DB7230", VA = "0x189DB8230", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9DB82C0", Offset = "0x9DB72C0", VA = "0x189DB82C0")]
		public OGGWHGSOCZB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface TCQWDZGEQIX
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string JEUKHFTVMRP(object a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool LWBBCSXEIGL([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface RHGAWVQGRXS<a> : TCQWDZGEQIX
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool YDPNNFVXYAC([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a QEFKLZXAOHT([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class JAIVNHEPHYK<a> : RHGAWVQGRXS<a>, TCQWDZGEQIX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type UCQRSCBHLKW;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x66F0070", Offset = "0x66EF070", VA = "0x1866F0070")]
		protected JAIVNHEPHYK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x66EE790", Offset = "0x66ED790", VA = "0x1866EE790")]
		private a ATVLKCYNKAK(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x66EF910", Offset = "0x66EE910", VA = "0x1866EF910", Slot = "7")]
		public string JEUKHFTVMRP(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x66EFF40", Offset = "0x66EEF40", VA = "0x1866EFF40", Slot = "5")]
		public bool YDPNNFVXYAC(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x66EEF40", Offset = "0x66EDF40", VA = "0x1866EEF40", Slot = "8")]
		private bool HMDDXULOSEF(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x66EFEF0", Offset = "0x66EEEF0", VA = "0x1866EFEF0", Slot = "6")]
		public a QEFKLZXAOHT(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class IJSLZXSDZBJ<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static RHGAWVQGRXS<b> HPUTZVWRNHB
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5B6A330", Offset = "0x5B69330", VA = "0x185B6A330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x38BD7F0", Offset = "0x38BC7F0", VA = "0x1838BD7F0")]
		public static RHGAWVQGRXS<a> CIMXVCHUOAY<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6606A00", Offset = "0x6605A00", VA = "0x186606A00")]
		public static TCQWDZGEQIX CIMXVCHUOAY(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x660BAE0", Offset = "0x660AAE0", VA = "0x18660BAE0")]
		private static TCQWDZGEQIX FIMVPDEHUSV(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x660E010", Offset = "0x660D010", VA = "0x18660E010")]
		private static TCQWDZGEQIX JXESCKRROMM(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class JCUUPUDUKCO<a> : EPHWQDDJBCJ<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class GQJSDWGYFIL : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private string NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int LNNEGLEATET;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private string ZWYBSELOJXY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public string XORTNTBTMGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public JCUUPUDUKCO<a> NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private PooledObject<StringBuilder> IYMGLLXJMQK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private StringBuilder IUMAFCZROOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool OJMBUJEWKDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int AXCWASTQEMV;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private string IICGLFNMBZD
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public GQJSDWGYFIL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x645E570", Offset = "0x645D570", VA = "0x18645E570", Slot = "7")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x645DC20", Offset = "0x645CC20", VA = "0x18645DC20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x645DBD0", Offset = "0x645CBD0", VA = "0x18645DBD0")]
			private void LZWZIAQZAET()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4F220B0", Offset = "0x4F210B0", VA = "0x184F220B0", Slot = "10")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x645D9F0", Offset = "0x645C9F0", VA = "0x18645D9F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> EWVYKGATJSW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x645E610", Offset = "0x645D610", VA = "0x18645E610", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator YIRXJWVWWXR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool DMGIMYWBIQZ;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x66F43F0", Offset = "0x66F33F0", VA = "0x1866F43F0")]
		protected JCUUPUDUKCO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x66F41B0", Offset = "0x66F31B0", VA = "0x1866F41B0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x66F3D00", Offset = "0x66F2D00", VA = "0x1866F3D00", Slot = "12")]
		[IteratorStateMachine(typeof(JCUUPUDUKCO<>.GQJSDWGYFIL))]
		internal override IEnumerable<string> CMMTOFXVYOW(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x66F3E30", Offset = "0x66F2E30", VA = "0x1866F3E30")]
		[CompilerGenerated]
		internal static string DIMYMSMWZVG(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class WUUEZHOGXTS : JCUUPUDUKCO<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9DB89D0", Offset = "0x9DB79D0", VA = "0x189DB89D0")]
		[Preserve]
		public WUUEZHOGXTS(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8940", Offset = "0x9DB7940", VA = "0x189DB8940", Slot = "11")]
		protected override List<string> RWAJQQRUZYW(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class EMSVLBFLVFZ : JCUUPUDUKCO<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7D60", Offset = "0x9DB6D60", VA = "0x189DB7D60")]
		[Preserve]
		public EMSVLBFLVFZ(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7D00", Offset = "0x9DB6D00", VA = "0x189DB7D00", Slot = "11")]
		protected override string[] RWAJQQRUZYW(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class CAPAANFHVKQ : JAIVNHEPHYK<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD5A530", Offset = "0xD59530", VA = "0x180D5A530", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7CA0", Offset = "0x9DB6CA0", VA = "0x189DB7CA0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7CC0", Offset = "0x9DB6CC0", VA = "0x189DB7CC0")]
		public CAPAANFHVKQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class MRZEDDERMEX : JAIVNHEPHYK<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7EF0", Offset = "0x9DB6EF0", VA = "0x189DB7EF0", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8010", Offset = "0x9DB7010", VA = "0x189DB8010", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9DB8180", Offset = "0x9DB7180", VA = "0x189DB8180")]
		public MRZEDDERMEX()
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
