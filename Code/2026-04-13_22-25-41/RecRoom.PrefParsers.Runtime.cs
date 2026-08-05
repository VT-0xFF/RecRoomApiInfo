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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18210", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18250", VA = "0x180D19850")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C592D0", Offset = "0x9C57CD0", VA = "0x189C592D0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9C59300", Offset = "0x9C57D00", VA = "0x189C59300", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9C59350", Offset = "0x9C57D50", VA = "0x189C59350")]
		public KYDIQQYIBOX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class GTGISTDFBVM : NVNXNDGEDVG<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9C59020", Offset = "0x9C57A20", VA = "0x189C59020", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9C590B0", Offset = "0x9C57AB0", VA = "0x189C590B0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9C59150", Offset = "0x9C57B50", VA = "0x189C59150")]
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
		[Cpp2IlInjected.Address(RVA = "0x66906A0", Offset = "0x668F0A0", VA = "0x1866906A0")]
		[Preserve]
		public JYQAUMKTOWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6690280", Offset = "0x668EC80", VA = "0x186690280", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6690440", Offset = "0x668EE40", VA = "0x186690440", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x85D9280", Offset = "0x85D7C80", VA = "0x1885D9280")]
		[Preserve]
		public WTUTWDKTHOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x85D8B20", Offset = "0x85D7520", VA = "0x1885D8B20", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x85D8D20", Offset = "0x85D7720", VA = "0x1885D8D20", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C58910", Offset = "0x9C57310", VA = "0x189C58910")]
		public static DKZYVFGEDYV GGNDLWXWTZA(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class EPLIHTQVSYX<a> : NVNXNDGEDVG<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4094B90", Offset = "0x4093590", VA = "0x184094B90", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5B43ED0", Offset = "0x5B428D0", VA = "0x185B43ED0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5B440C0", Offset = "0x5B42AC0", VA = "0x185B440C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x71D56D0", Offset = "0x71D40D0", VA = "0x1871D56D0")]
		protected AXSPWALCNYD(BILDKLRZYOS<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x71D1950", Offset = "0x71D0350", VA = "0x1871D1950", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x71D27D0", Offset = "0x71D11D0", VA = "0x1871D27D0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a YFLAHNWPOJC(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x71D1620", Offset = "0x71D0020", VA = "0x1871D1620", Slot = "12")]
		internal virtual IEnumerable<string> MXMXOYIMAYU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x71D51F0", Offset = "0x71D3BF0", VA = "0x1871D51F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x65A7D20", Offset = "0x65A6720", VA = "0x1865A7D20")]
		[Preserve]
		public IKKAJPZXBFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x65A7D40", Offset = "0x65A6740", VA = "0x1865A7D40")]
		[Preserve]
		public IKKAJPZXBFX(BILDKLRZYOS<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x65A7BA0", Offset = "0x65A65A0", VA = "0x1865A7BA0", Slot = "11")]
		protected override a[] YFLAHNWPOJC(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class OLGGVEDFRSU<a> : AXSPWALCNYD<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x65A7D20", Offset = "0x65A6720", VA = "0x1865A7D20")]
		[Preserve]
		public OLGGVEDFRSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x65A7D40", Offset = "0x65A6740", VA = "0x1865A7D40")]
		[Preserve]
		public OLGGVEDFRSU([Optional] BILDKLRZYOS<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72AA900", Offset = "0x72A9300", VA = "0x1872AA900", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D2A140", Offset = "0x7D28B40", VA = "0x187D2A140")]
		public UCXKZHXHUUI(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7D29EB0", Offset = "0x7D288B0", VA = "0x187D29EB0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7D2A090", Offset = "0x7D28A90", VA = "0x187D2A090", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class LHWRJEDEGKB : NVNXNDGEDVG<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9C594C0", Offset = "0x9C57EC0", VA = "0x189C594C0", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9C59520", Offset = "0x9C57F20", VA = "0x189C59520", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9C595B0", Offset = "0x9C57FB0", VA = "0x189C595B0")]
		public LHWRJEDEGKB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class ZZQPMOVKPQJ : NVNXNDGEDVG<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9C59E60", Offset = "0x9C58860", VA = "0x189C59E60", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9C59EC0", Offset = "0x9C588C0", VA = "0x189C59EC0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9C59F60", Offset = "0x9C58960", VA = "0x189C59F60")]
		public ZZQPMOVKPQJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class GEZWQQOLROQ : NVNXNDGEDVG<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9C587D0", Offset = "0x9C571D0", VA = "0x189C587D0", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9C58830", Offset = "0x9C57230", VA = "0x189C58830", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C588D0", Offset = "0x9C572D0", VA = "0x189C588D0")]
		public GEZWQQOLROQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class TKMVXWAGADA : NVNXNDGEDVG<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9C59CD0", Offset = "0x9C586D0", VA = "0x189C59CD0", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9C59D30", Offset = "0x9C58730", VA = "0x189C59D30", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9C59DC0", Offset = "0x9C587C0", VA = "0x189C59DC0")]
		public TKMVXWAGADA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class KZVESLWESOT : NVNXNDGEDVG<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9C59390", Offset = "0x9C57D90", VA = "0x189C59390", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9C593F0", Offset = "0x9C57DF0", VA = "0x189C593F0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9C59480", Offset = "0x9C57E80", VA = "0x189C59480")]
		public KZVESLWESOT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class PLEHMEBMGEZ : NVNXNDGEDVG<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9C59730", Offset = "0x9C58130", VA = "0x189C59730", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9C59790", Offset = "0x9C58190", VA = "0x189C59790", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9C59830", Offset = "0x9C58230", VA = "0x189C59830")]
		public PLEHMEBMGEZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class MJRGNQCGRPM : NVNXNDGEDVG<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9C595F0", Offset = "0x9C57FF0", VA = "0x189C595F0", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9C59650", Offset = "0x9C58050", VA = "0x189C59650", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9C596F0", Offset = "0x9C580F0", VA = "0x189C596F0")]
		public MJRGNQCGRPM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class KUJJIVXSLNP : NVNXNDGEDVG<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9C59190", Offset = "0x9C57B90", VA = "0x189C59190", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9C59200", Offset = "0x9C57C00", VA = "0x189C59200", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9C59290", Offset = "0x9C57C90", VA = "0x189C59290")]
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
		[Cpp2IlInjected.Address(RVA = "0x715D490", Offset = "0x715BE90", VA = "0x18715D490")]
		protected NVNXNDGEDVG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x715C770", Offset = "0x715B170", VA = "0x18715C770")]
		private a EFWNJKTHSPG(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x715BCA0", Offset = "0x715A6A0", VA = "0x18715BCA0", Slot = "7")]
		public string DWPTDRDBYSH(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x715D3A0", Offset = "0x715BDA0", VA = "0x18715D3A0", Slot = "5")]
		public bool VPWDAIBPJGY(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x715CDC0", Offset = "0x715B7C0", VA = "0x18715CDC0", Slot = "8")]
		private bool KEQKAMZBMFF(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x715CFF0", Offset = "0x715B9F0", VA = "0x18715CFF0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B5FA60", Offset = "0x5B5E460", VA = "0x185B5FA60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x39EA2F0", Offset = "0x39E8CF0", VA = "0x1839EA2F0")]
		public static BILDKLRZYOS<a> DTLQTPUPUOC<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x713B8E0", Offset = "0x713A2E0", VA = "0x18713B8E0")]
		public static DKZYVFGEDYV DTLQTPUPUOC(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x713C1F0", Offset = "0x713ABF0", VA = "0x18713C1F0")]
		private static DKZYVFGEDYV YSSSEQVOHAP(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x713C960", Offset = "0x713B360", VA = "0x18713C960")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F7F0", VA = "0x181010DF0")]
			[DebuggerHidden]
			public LBYRWFEEOVP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6864520", Offset = "0x6862F20", VA = "0x186864520", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x68640E0", Offset = "0x6862AE0", VA = "0x1868640E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6864690", Offset = "0x6863090", VA = "0x186864690")]
			private void SYBUDUAVPHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4FAC7F0", Offset = "0x4FAB1F0", VA = "0x184FAC7F0", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x6863B10", Offset = "0x6862510", VA = "0x186863B10", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> JXOSTSWOHUY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6863A50", Offset = "0x6862450", VA = "0x186863A50", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x71C4150", Offset = "0x71C2B50", VA = "0x1871C4150")]
		protected AKKJEGDWBUI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x71C3B80", Offset = "0x71C2580", VA = "0x1871C3B80", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x71C3AD0", Offset = "0x71C24D0", VA = "0x1871C3AD0", Slot = "12")]
		[IteratorStateMachine(typeof(AKKJEGDWBUI<>.LBYRWFEEOVP))]
		internal override IEnumerable<string> MXMXOYIMAYU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x71C39A0", Offset = "0x71C23A0", VA = "0x1871C39A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C59900", Offset = "0x9C58300", VA = "0x189C59900")]
		[Preserve]
		public QTMIWDUSKCO(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9C59870", Offset = "0x9C58270", VA = "0x189C59870", Slot = "11")]
		protected override List<string> YFLAHNWPOJC(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class QVFEAJUSPFH : AKKJEGDWBUI<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9C599B0", Offset = "0x9C583B0", VA = "0x189C599B0")]
		[Preserve]
		public QVFEAJUSPFH(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9C59950", Offset = "0x9C58350", VA = "0x189C59950", Slot = "11")]
		protected override string[] YFLAHNWPOJC(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class UHEKYXBGYNE : NVNXNDGEDVG<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD548C0", Offset = "0xD532C0", VA = "0x180D548C0", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9C59E00", Offset = "0x9C58800", VA = "0x189C59E00", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9C59E20", Offset = "0x9C58820", VA = "0x189C59E20")]
		public UHEKYXBGYNE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class SORNXYVTVFP : NVNXNDGEDVG<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9C59A00", Offset = "0x9C58400", VA = "0x189C59A00", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9C59B20", Offset = "0x9C58520", VA = "0x189C59B20", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9C59C90", Offset = "0x9C58690", VA = "0x189C59C90")]
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
