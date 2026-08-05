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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34A60", Offset = "0xD33A60", VA = "0x180D34A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xD34AA0", Offset = "0xD33AA0", VA = "0x180D34AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DFBFE0", Offset = "0x9DFAFE0", VA = "0x189DFBFE0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC010", Offset = "0x9DFB010", VA = "0x189DFC010", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC060", Offset = "0x9DFB060", VA = "0x189DFC060")]
		public KYDIQQYIBOX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class GTGISTDFBVM : NVNXNDGEDVG<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9DFBD30", Offset = "0x9DFAD30", VA = "0x189DFBD30", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9DFBDC0", Offset = "0x9DFADC0", VA = "0x189DFBDC0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9DFBE60", Offset = "0x9DFAE60", VA = "0x189DFBE60")]
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
		[Cpp2IlInjected.Address(RVA = "0x676F0E0", Offset = "0x676E0E0", VA = "0x18676F0E0")]
		[Preserve]
		public JYQAUMKTOWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x676EC90", Offset = "0x676DC90", VA = "0x18676EC90", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x676EE70", Offset = "0x676DE70", VA = "0x18676EE70", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x8777340", Offset = "0x8776340", VA = "0x188777340")]
		[Preserve]
		public WTUTWDKTHOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8776BC0", Offset = "0x8775BC0", VA = "0x188776BC0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8776DD0", Offset = "0x8775DD0", VA = "0x188776DD0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DFB5F0", Offset = "0x9DFA5F0", VA = "0x189DFB5F0")]
		public static DKZYVFGEDYV GGNDLWXWTZA(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class EPLIHTQVSYX<a> : NVNXNDGEDVG<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x40B1540", Offset = "0x40B0540", VA = "0x1840B1540", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5BD8610", Offset = "0x5BD7610", VA = "0x185BD8610", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5BD8820", Offset = "0x5BD7820", VA = "0x185BD8820")]
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
		[Cpp2IlInjected.Address(RVA = "0x72FD490", Offset = "0x72FC490", VA = "0x1872FD490")]
		protected AXSPWALCNYD(BILDKLRZYOS<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x72F9560", Offset = "0x72F8560", VA = "0x1872F9560", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x72FA4A0", Offset = "0x72F94A0", VA = "0x1872FA4A0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a YFLAHNWPOJC(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x72F91F0", Offset = "0x72F81F0", VA = "0x1872F91F0", Slot = "12")]
		internal virtual IEnumerable<string> MXMXOYIMAYU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x72FCF90", Offset = "0x72FBF90", VA = "0x1872FCF90")]
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
		[Cpp2IlInjected.Address(RVA = "0x66803B0", Offset = "0x667F3B0", VA = "0x1866803B0")]
		[Preserve]
		public IKKAJPZXBFX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x66803D0", Offset = "0x667F3D0", VA = "0x1866803D0")]
		[Preserve]
		public IKKAJPZXBFX(BILDKLRZYOS<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x66801F0", Offset = "0x667F1F0", VA = "0x1866801F0", Slot = "11")]
		protected override a[] YFLAHNWPOJC(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class OLGGVEDFRSU<a> : AXSPWALCNYD<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x66803B0", Offset = "0x667F3B0", VA = "0x1866803B0")]
		[Preserve]
		public OLGGVEDFRSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x66803D0", Offset = "0x667F3D0", VA = "0x1866803D0")]
		[Preserve]
		public OLGGVEDFRSU([Optional] BILDKLRZYOS<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x73D8930", Offset = "0x73D7930", VA = "0x1873D8930", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E94DB0", Offset = "0x7E93DB0", VA = "0x187E94DB0")]
		public UCXKZHXHUUI(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7E94B10", Offset = "0x7E93B10", VA = "0x187E94B10", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7E94D00", Offset = "0x7E93D00", VA = "0x187E94D00", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class LHWRJEDEGKB : NVNXNDGEDVG<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC1D0", Offset = "0x9DFB1D0", VA = "0x189DFC1D0", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC230", Offset = "0x9DFB230", VA = "0x189DFC230", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC2C0", Offset = "0x9DFB2C0", VA = "0x189DFC2C0")]
		public LHWRJEDEGKB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class ZZQPMOVKPQJ : NVNXNDGEDVG<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9DFCB70", Offset = "0x9DFBB70", VA = "0x189DFCB70", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9DFCBD0", Offset = "0x9DFBBD0", VA = "0x189DFCBD0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9DFCC70", Offset = "0x9DFBC70", VA = "0x189DFCC70")]
		public ZZQPMOVKPQJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class GEZWQQOLROQ : NVNXNDGEDVG<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9DFB4B0", Offset = "0x9DFA4B0", VA = "0x189DFB4B0", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9DFB510", Offset = "0x9DFA510", VA = "0x189DFB510", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9DFB5B0", Offset = "0x9DFA5B0", VA = "0x189DFB5B0")]
		public GEZWQQOLROQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class TKMVXWAGADA : NVNXNDGEDVG<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC9E0", Offset = "0x9DFB9E0", VA = "0x189DFC9E0", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9DFCA40", Offset = "0x9DFBA40", VA = "0x189DFCA40", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9DFCAD0", Offset = "0x9DFBAD0", VA = "0x189DFCAD0")]
		public TKMVXWAGADA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class KZVESLWESOT : NVNXNDGEDVG<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC0A0", Offset = "0x9DFB0A0", VA = "0x189DFC0A0", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC100", Offset = "0x9DFB100", VA = "0x189DFC100", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC190", Offset = "0x9DFB190", VA = "0x189DFC190")]
		public KZVESLWESOT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class PLEHMEBMGEZ : NVNXNDGEDVG<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC440", Offset = "0x9DFB440", VA = "0x189DFC440", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC4A0", Offset = "0x9DFB4A0", VA = "0x189DFC4A0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC540", Offset = "0x9DFB540", VA = "0x189DFC540")]
		public PLEHMEBMGEZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class MJRGNQCGRPM : NVNXNDGEDVG<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC300", Offset = "0x9DFB300", VA = "0x189DFC300", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC360", Offset = "0x9DFB360", VA = "0x189DFC360", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC400", Offset = "0x9DFB400", VA = "0x189DFC400")]
		public MJRGNQCGRPM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class KUJJIVXSLNP : NVNXNDGEDVG<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9DFBEA0", Offset = "0x9DFAEA0", VA = "0x189DFBEA0", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9DFBF10", Offset = "0x9DFAF10", VA = "0x189DFBF10", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9DFBFA0", Offset = "0x9DFAFA0", VA = "0x189DFBFA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7283160", Offset = "0x7282160", VA = "0x187283160")]
		protected NVNXNDGEDVG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x72823D0", Offset = "0x72813D0", VA = "0x1872823D0")]
		private a EFWNJKTHSPG(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7281880", Offset = "0x7280880", VA = "0x187281880", Slot = "7")]
		public string DWPTDRDBYSH(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7283070", Offset = "0x7282070", VA = "0x187283070", Slot = "5")]
		public bool VPWDAIBPJGY(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7282A70", Offset = "0x7281A70", VA = "0x187282A70", Slot = "8")]
		private bool KEQKAMZBMFF(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7282CB0", Offset = "0x7281CB0", VA = "0x187282CB0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x5BF4A50", Offset = "0x5BF3A50", VA = "0x185BF4A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3A02B10", Offset = "0x3A01B10", VA = "0x183A02B10")]
		public static BILDKLRZYOS<a> DTLQTPUPUOC<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x72611C0", Offset = "0x72601C0", VA = "0x1872611C0")]
		public static DKZYVFGEDYV DTLQTPUPUOC(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7262B50", Offset = "0x7261B50", VA = "0x187262B50")]
		private static DKZYVFGEDYV YSSSEQVOHAP(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x72632C0", Offset = "0x72622C0", VA = "0x1872632C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x102C950", Offset = "0x102B950", VA = "0x18102C950")]
			[DebuggerHidden]
			public LBYRWFEEOVP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x694C1E0", Offset = "0x694B1E0", VA = "0x18694C1E0", Slot = "7")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x694BD90", Offset = "0x694AD90", VA = "0x18694BD90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x694C370", Offset = "0x694B370", VA = "0x18694C370")]
			private void SYBUDUAVPHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4FEA8D0", Offset = "0x4FE98D0", VA = "0x184FEA8D0", Slot = "10")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x694B7A0", Offset = "0x694A7A0", VA = "0x18694B7A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> JXOSTSWOHUY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x694B6D0", Offset = "0x694A6D0", VA = "0x18694B6D0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x72EB840", Offset = "0x72EA840", VA = "0x1872EB840")]
		protected AKKJEGDWBUI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x72EB230", Offset = "0x72EA230", VA = "0x1872EB230", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x72EB180", Offset = "0x72EA180", VA = "0x1872EB180", Slot = "12")]
		[IteratorStateMachine(typeof(AKKJEGDWBUI<>.LBYRWFEEOVP))]
		internal override IEnumerable<string> MXMXOYIMAYU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x72EB050", Offset = "0x72EA050", VA = "0x1872EB050")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DFC610", Offset = "0x9DFB610", VA = "0x189DFC610")]
		[Preserve]
		public QTMIWDUSKCO(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC580", Offset = "0x9DFB580", VA = "0x189DFC580", Slot = "11")]
		protected override List<string> YFLAHNWPOJC(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class QVFEAJUSPFH : AKKJEGDWBUI<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC6C0", Offset = "0x9DFB6C0", VA = "0x189DFC6C0")]
		[Preserve]
		public QVFEAJUSPFH(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC660", Offset = "0x9DFB660", VA = "0x189DFC660", Slot = "11")]
		protected override string[] YFLAHNWPOJC(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class UHEKYXBGYNE : NVNXNDGEDVG<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD6FCE0", Offset = "0xD6ECE0", VA = "0x180D6FCE0", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9DFCB10", Offset = "0x9DFBB10", VA = "0x189DFCB10", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9DFCB30", Offset = "0x9DFBB30", VA = "0x189DFCB30")]
		public UHEKYXBGYNE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class SORNXYVTVFP : NVNXNDGEDVG<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC710", Offset = "0x9DFB710", VA = "0x189DFC710", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC830", Offset = "0x9DFB830", VA = "0x189DFC830", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9DFC9A0", Offset = "0x9DFB9A0", VA = "0x189DFC9A0")]
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
