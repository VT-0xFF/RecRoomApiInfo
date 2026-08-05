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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18410", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18450", VA = "0x180D19850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.PrefParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class KYDIQQYIBOX : NVNXNDGEDVG<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AD80", Offset = "0x9C59980", VA = "0x189C5AD80", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9C5ADB0", Offset = "0x9C599B0", VA = "0x189C5ADB0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AE00", Offset = "0x9C59A00", VA = "0x189C5AE00")]
		public KYDIQQYIBOX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class GTGISTDFBVM : NVNXNDGEDVG<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AAD0", Offset = "0x9C596D0", VA = "0x189C5AAD0", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AB60", Offset = "0x9C59760", VA = "0x189C5AB60", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AC00", Offset = "0x9C59800", VA = "0x189C5AC00")]
		public GTGISTDFBVM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class JYQAUMKTOWC<a> : NVNXNDGEDVG<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Type UPHEAJZIOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool HRJFJIQDKQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly a[] OQIWLEHREZU;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6691E20", Offset = "0x6690A20", VA = "0x186691E20")]
		[Preserve]
		public JYQAUMKTOWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6691A00", Offset = "0x6690600", VA = "0x186691A00", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6691BC0", Offset = "0x66907C0", VA = "0x186691BC0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class WTUTWDKTHOF<a> : NVNXNDGEDVG<a> where a : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Type UPHEAJZIOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly DKZYVFGEDYV CVJNOSPYMZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly bool HRJFJIQDKQE;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85DAA00", Offset = "0x85D9600", VA = "0x1885DAA00")]
		[Preserve]
		public WTUTWDKTHOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x85DA2A0", Offset = "0x85D8EA0", VA = "0x1885DA2A0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x85DA4A0", Offset = "0x85D90A0", VA = "0x1885DA4A0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class GPBSQCKATXE
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Dictionary<Type, DKZYVFGEDYV> SAWSJYVUFHM;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9C5A3C0", Offset = "0x9C58FC0", VA = "0x189C5A3C0")]
		public static DKZYVFGEDYV GGNDLWXWTZA(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class EPLIHTQVSYX<a> : NVNXNDGEDVG<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4096280", Offset = "0x4094E80", VA = "0x184096280", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5B45650", Offset = "0x5B44250", VA = "0x185B45650", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5B45840", Offset = "0x5B44440", VA = "0x185B45840")]
		public EPLIHTQVSYX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class AXSPWALCNYD<a, b> : NVNXNDGEDVG<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly BILDKLRZYOS<b> QZBKOYLVVJR;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x71D6E50", Offset = "0x71D5A50", VA = "0x1871D6E50")]
		protected AXSPWALCNYD(BILDKLRZYOS<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x71D30D0", Offset = "0x71D1CD0", VA = "0x1871D30D0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x71D3F50", Offset = "0x71D2B50", VA = "0x1871D3F50", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a YFLAHNWPOJC(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x71D2DA0", Offset = "0x71D19A0", VA = "0x1871D2DA0", Slot = "12")]
		internal virtual IEnumerable<string> MXMXOYIMAYU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x71D6970", Offset = "0x71D5570", VA = "0x1871D6970")]
		[CompilerGenerated]
		private string XVMPZQJEZHH(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class IKKAJPZXBFX<a> : AXSPWALCNYD<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x65A94A0", Offset = "0x65A80A0", VA = "0x1865A94A0")]
		[Preserve]
		public IKKAJPZXBFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x65A94C0", Offset = "0x65A80C0", VA = "0x1865A94C0")]
		[Preserve]
		public IKKAJPZXBFX(BILDKLRZYOS<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x65A9320", Offset = "0x65A7F20", VA = "0x1865A9320", Slot = "11")]
		protected override a[] YFLAHNWPOJC(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class OLGGVEDFRSU<a> : AXSPWALCNYD<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x65A94A0", Offset = "0x65A80A0", VA = "0x1865A94A0")]
		[Preserve]
		public OLGGVEDFRSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x65A94C0", Offset = "0x65A80C0", VA = "0x1865A94C0")]
		[Preserve]
		public OLGGVEDFRSU([Optional] BILDKLRZYOS<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72AC080", Offset = "0x72AAC80", VA = "0x1872AC080", Slot = "11")]
		protected override List<a> YFLAHNWPOJC(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class UCXKZHXHUUI<a> : NVNXNDGEDVG<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? PQYDABYESBF;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7D2B8C0", Offset = "0x7D2A4C0", VA = "0x187D2B8C0")]
		public UCXKZHXHUUI(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7D2B630", Offset = "0x7D2A230", VA = "0x187D2B630", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7D2B810", Offset = "0x7D2A410", VA = "0x187D2B810", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class LHWRJEDEGKB : NVNXNDGEDVG<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AF70", Offset = "0x9C59B70", VA = "0x189C5AF70", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AFD0", Offset = "0x9C59BD0", VA = "0x189C5AFD0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B060", Offset = "0x9C59C60", VA = "0x189C5B060")]
		public LHWRJEDEGKB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class ZZQPMOVKPQJ : NVNXNDGEDVG<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B910", Offset = "0x9C5A510", VA = "0x189C5B910", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B970", Offset = "0x9C5A570", VA = "0x189C5B970", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9C5BA10", Offset = "0x9C5A610", VA = "0x189C5BA10")]
		public ZZQPMOVKPQJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class GEZWQQOLROQ : NVNXNDGEDVG<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9C5A280", Offset = "0x9C58E80", VA = "0x189C5A280", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9C5A2E0", Offset = "0x9C58EE0", VA = "0x189C5A2E0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C5A380", Offset = "0x9C58F80", VA = "0x189C5A380")]
		public GEZWQQOLROQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class TKMVXWAGADA : NVNXNDGEDVG<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B780", Offset = "0x9C5A380", VA = "0x189C5B780", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B7E0", Offset = "0x9C5A3E0", VA = "0x189C5B7E0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B870", Offset = "0x9C5A470", VA = "0x189C5B870")]
		public TKMVXWAGADA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class KZVESLWESOT : NVNXNDGEDVG<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AE40", Offset = "0x9C59A40", VA = "0x189C5AE40", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AEA0", Offset = "0x9C59AA0", VA = "0x189C5AEA0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AF30", Offset = "0x9C59B30", VA = "0x189C5AF30")]
		public KZVESLWESOT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class PLEHMEBMGEZ : NVNXNDGEDVG<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B1E0", Offset = "0x9C59DE0", VA = "0x189C5B1E0", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B240", Offset = "0x9C59E40", VA = "0x189C5B240", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B2E0", Offset = "0x9C59EE0", VA = "0x189C5B2E0")]
		public PLEHMEBMGEZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class MJRGNQCGRPM : NVNXNDGEDVG<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B0A0", Offset = "0x9C59CA0", VA = "0x189C5B0A0", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B100", Offset = "0x9C59D00", VA = "0x189C5B100", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B1A0", Offset = "0x9C59DA0", VA = "0x189C5B1A0")]
		public MJRGNQCGRPM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class KUJJIVXSLNP : NVNXNDGEDVG<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AC40", Offset = "0x9C59840", VA = "0x189C5AC40", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9C5ACB0", Offset = "0x9C598B0", VA = "0x189C5ACB0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9C5AD40", Offset = "0x9C59940", VA = "0x189C5AD40")]
		public KUJJIVXSLNP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface DKZYVFGEDYV
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string DWPTDRDBYSH(object a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool QMOXVYYFCVT([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface BILDKLRZYOS<a> : DKZYVFGEDYV
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool VPWDAIBPJGY([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a QWUXDBCZCPZ([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class NVNXNDGEDVG<a> : BILDKLRZYOS<a>, DKZYVFGEDYV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type AYTSHLQJUDO;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x715EC10", Offset = "0x715D810", VA = "0x18715EC10")]
		protected NVNXNDGEDVG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x715DEF0", Offset = "0x715CAF0", VA = "0x18715DEF0")]
		private a EFWNJKTHSPG(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x715D420", Offset = "0x715C020", VA = "0x18715D420", Slot = "7")]
		public string DWPTDRDBYSH(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x715EB20", Offset = "0x715D720", VA = "0x18715EB20", Slot = "5")]
		public bool VPWDAIBPJGY(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x715E540", Offset = "0x715D140", VA = "0x18715E540", Slot = "8")]
		private bool KEQKAMZBMFF(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x715E770", Offset = "0x715D370", VA = "0x18715E770", Slot = "6")]
		public a QWUXDBCZCPZ(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class NLREFJOGZNP<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static BILDKLRZYOS<b> FYIBPTBKDJH
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5B611E0", Offset = "0x5B5FDE0", VA = "0x185B611E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x39EB9E0", Offset = "0x39EA5E0", VA = "0x1839EB9E0")]
		public static BILDKLRZYOS<a> DTLQTPUPUOC<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x713D060", Offset = "0x713BC60", VA = "0x18713D060")]
		public static DKZYVFGEDYV DTLQTPUPUOC(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x713D970", Offset = "0x713C570", VA = "0x18713D970")]
		private static DKZYVFGEDYV YSSSEQVOHAP(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x713E0E0", Offset = "0x713CCE0", VA = "0x18713E0E0")]
		private static DKZYVFGEDYV ZNQQKNTVWEO(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class AKKJEGDWBUI<a> : AXSPWALCNYD<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class LBYRWFEEOVP : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private string PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int DQGTEBFWJSV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private string PFZBYCRICWQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public string FOLJFTEIVVF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public AKKJEGDWBUI<a> DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private PooledObject<StringBuilder> HHVGITEOXBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private StringBuilder NTGXWYAHVVW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool INSRBNIZZOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int LPRPAYTAQBV;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private string QJFOWEFJHUT
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F9F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public LBYRWFEEOVP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6865CA0", Offset = "0x68648A0", VA = "0x186865CA0", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6865860", Offset = "0x6864460", VA = "0x186865860", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6865E10", Offset = "0x6864A10", VA = "0x186865E10")]
			private void SYBUDUAVPHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6865290", Offset = "0x6863E90", VA = "0x186865290", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> JXOSTSWOHUY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x68651D0", Offset = "0x6863DD0", VA = "0x1868651D0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator IEVKUCCAWWZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool YYBZLAKZIAX;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x71C58D0", Offset = "0x71C44D0", VA = "0x1871C58D0")]
		protected AKKJEGDWBUI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x71C5300", Offset = "0x71C3F00", VA = "0x1871C5300", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x71C5250", Offset = "0x71C3E50", VA = "0x1871C5250", Slot = "12")]
		[IteratorStateMachine(typeof(AKKJEGDWBUI<>.LBYRWFEEOVP))]
		internal override IEnumerable<string> MXMXOYIMAYU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x71C5120", Offset = "0x71C3D20", VA = "0x1871C5120")]
		[CompilerGenerated]
		internal static string CQQIGWAVVOG(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class QTMIWDUSKCO : AKKJEGDWBUI<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B3B0", Offset = "0x9C59FB0", VA = "0x189C5B3B0")]
		[Preserve]
		public QTMIWDUSKCO(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B320", Offset = "0x9C59F20", VA = "0x189C5B320", Slot = "11")]
		protected override List<string> YFLAHNWPOJC(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class QVFEAJUSPFH : AKKJEGDWBUI<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B460", Offset = "0x9C5A060", VA = "0x189C5B460")]
		[Preserve]
		public QVFEAJUSPFH(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B400", Offset = "0x9C5A000", VA = "0x189C5B400", Slot = "11")]
		protected override string[] YFLAHNWPOJC(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class UHEKYXBGYNE : NVNXNDGEDVG<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD548C0", Offset = "0xD534C0", VA = "0x180D548C0", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B8B0", Offset = "0x9C5A4B0", VA = "0x189C5B8B0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B8D0", Offset = "0x9C5A4D0", VA = "0x189C5B8D0")]
		public UHEKYXBGYNE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class SORNXYVTVFP : NVNXNDGEDVG<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B4B0", Offset = "0x9C5A0B0", VA = "0x189C5B4B0", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B5D0", Offset = "0x9C5A1D0", VA = "0x189C5B5D0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9C5B740", Offset = "0x9C5A340", VA = "0x189C5B740")]
		public SORNXYVTVFP()
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
