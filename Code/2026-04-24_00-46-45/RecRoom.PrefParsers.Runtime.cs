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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.PrefParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class XRTIUFSICRT : UHZRSONWGEO<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9DCCCB0", Offset = "0x9DCB6B0", VA = "0x189DCCCB0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9DCCCE0", Offset = "0x9DCB6E0", VA = "0x189DCCCE0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9DCCD30", Offset = "0x9DCB730", VA = "0x189DCCD30")]
		public XRTIUFSICRT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class ZBHOCAECAQU : UHZRSONWGEO<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9DCCD70", Offset = "0x9DCB770", VA = "0x189DCCD70", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9DCCE00", Offset = "0x9DCB800", VA = "0x189DCCE00", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9DCCEA0", Offset = "0x9DCB8A0", VA = "0x189DCCEA0")]
		public ZBHOCAECAQU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ZOVEYFAXWAA<a> : UHZRSONWGEO<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Type IQAELUUPAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool NWHEDKOCOYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly a[] PZKESDJVPAA;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x515FE70", Offset = "0x515E870", VA = "0x18515FE70")]
		[Preserve]
		public ZOVEYFAXWAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x515FA20", Offset = "0x515E420", VA = "0x18515FA20", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x515FC00", Offset = "0x515E600", VA = "0x18515FC00", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class ZKBCEPAKKIL<a> : UHZRSONWGEO<a> where a : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Type IQAELUUPAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly CUTTMIWIJML ECBGGCLYSRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly bool NWHEDKOCOYC;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x515C8A0", Offset = "0x515B2A0", VA = "0x18515C8A0")]
		[Preserve]
		public ZKBCEPAKKIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x515C110", Offset = "0x515AB10", VA = "0x18515C110", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x515C1F0", Offset = "0x515ABF0", VA = "0x18515C1F0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class JAXNOFCNHNK
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Dictionary<Type, CUTTMIWIJML> XJOCSXZOSIM;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9DCBAB0", Offset = "0x9DCA4B0", VA = "0x189DCBAB0")]
		public static CUTTMIWIJML IFEFNIZPPUU(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class JTXKINOVLLW : UHZRSONWGEO<Guid>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC1F0", Offset = "0x9DCABF0", VA = "0x189DCC1F0", Slot = "9")]
		public override string Serialize(Guid input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC230", Offset = "0x9DCAC30", VA = "0x189DCC230", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] Guid value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC250", Offset = "0x9DCAC50", VA = "0x189DCC250")]
		public JTXKINOVLLW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ZCMQHYODVNH<a> : UHZRSONWGEO<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x40A51D0", Offset = "0x40A3BD0", VA = "0x1840A51D0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x51539B0", Offset = "0x51523B0", VA = "0x1851539B0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5153BC0", Offset = "0x51525C0", VA = "0x185153BC0")]
		public ZCMQHYODVNH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public abstract class IDELAHXCHUV<a, b> : UHZRSONWGEO<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly ZEAELRSVOME<b> HFMDOVHMJUN;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x65F88F0", Offset = "0x65F72F0", VA = "0x1865F88F0")]
		protected IDELAHXCHUV(ZEAELRSVOME<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x65F4610", Offset = "0x65F3010", VA = "0x1865F4610", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x65F6F90", Offset = "0x65F5990", VA = "0x1865F6F90", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a ABRYRRACPMW(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x65F4100", Offset = "0x65F2B00", VA = "0x1865F4100", Slot = "12")]
		internal virtual IEnumerable<string> AGJBCJPZZLA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x65F5140", Offset = "0x65F3B40", VA = "0x1865F5140")]
		[CompilerGenerated]
		private string TGLNSXWIYDB(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class BVPHKTPAIET<a> : IDELAHXCHUV<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4F41160", Offset = "0x4F3FB60", VA = "0x184F41160")]
		[Preserve]
		public BVPHKTPAIET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4F411A0", Offset = "0x4F3FBA0", VA = "0x184F411A0")]
		[Preserve]
		public BVPHKTPAIET(ZEAELRSVOME<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x4F410F0", Offset = "0x4F3FAF0", VA = "0x184F410F0", Slot = "11")]
		protected override a[] ABRYRRACPMW(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class LKGFHUIQAYC<a> : IDELAHXCHUV<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4F41160", Offset = "0x4F3FB60", VA = "0x184F41160")]
		[Preserve]
		public LKGFHUIQAYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4F411A0", Offset = "0x4F3FBA0", VA = "0x184F411A0")]
		[Preserve]
		public LKGFHUIQAYC([Optional] ZEAELRSVOME<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x68C8110", Offset = "0x68C6B10", VA = "0x1868C8110", Slot = "11")]
		protected override List<a> ABRYRRACPMW(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class JDOPFDMHYPI<a> : UHZRSONWGEO<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? SVVKNQIQCAF;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x66CF010", Offset = "0x66CDA10", VA = "0x1866CF010")]
		public JDOPFDMHYPI(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x66CEC30", Offset = "0x66CD630", VA = "0x1866CEC30", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x66CEF20", Offset = "0x66CD920", VA = "0x1866CEF20", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class XORMKHIJXSL : UHZRSONWGEO<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9DCCB80", Offset = "0x9DCB580", VA = "0x189DCCB80", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9DCCBE0", Offset = "0x9DCB5E0", VA = "0x189DCCBE0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9DCCC70", Offset = "0x9DCB670", VA = "0x189DCCC70")]
		public XORMKHIJXSL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class ONADKRZSQJF : UHZRSONWGEO<short>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC900", Offset = "0x9DCB300", VA = "0x189DCC900", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC960", Offset = "0x9DCB360", VA = "0x189DCC960", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9DCCA00", Offset = "0x9DCB400", VA = "0x189DCCA00")]
		public ONADKRZSQJF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class HDOYDKWKCLA : UHZRSONWGEO<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9DCB830", Offset = "0x9DCA230", VA = "0x189DCB830", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9DCB890", Offset = "0x9DCA290", VA = "0x189DCB890", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9DCB930", Offset = "0x9DCA330", VA = "0x189DCB930")]
		public HDOYDKWKCLA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class KYHZKHVECOM : UHZRSONWGEO<int>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC3C0", Offset = "0x9DCADC0", VA = "0x189DCC3C0", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC420", Offset = "0x9DCAE20", VA = "0x189DCC420", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC4B0", Offset = "0x9DCAEB0", VA = "0x189DCC4B0")]
		public KYHZKHVECOM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class KMOGUQZMVVP : UHZRSONWGEO<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC290", Offset = "0x9DCAC90", VA = "0x189DCC290", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC2F0", Offset = "0x9DCACF0", VA = "0x189DCC2F0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC380", Offset = "0x9DCAD80", VA = "0x189DCC380")]
		public KMOGUQZMVVP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class NLGKZZNHIWL : UHZRSONWGEO<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC4F0", Offset = "0x9DCAEF0", VA = "0x189DCC4F0", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC550", Offset = "0x9DCAF50", VA = "0x189DCC550", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC5F0", Offset = "0x9DCAFF0", VA = "0x189DCC5F0")]
		public NLGKZZNHIWL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class ABNFYJBKCDK : UHZRSONWGEO<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9DCB640", Offset = "0x9DCA040", VA = "0x189DCB640", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9DCB6A0", Offset = "0x9DCA0A0", VA = "0x189DCB6A0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9DCB740", Offset = "0x9DCA140", VA = "0x189DCB740")]
		public ABNFYJBKCDK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	internal class INMEQHVDQUT : UHZRSONWGEO<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9DCB970", Offset = "0x9DCA370", VA = "0x189DCB970", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9DCB9E0", Offset = "0x9DCA3E0", VA = "0x189DCB9E0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9DCBA70", Offset = "0x9DCA470", VA = "0x189DCBA70")]
		public INMEQHVDQUT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface CUTTMIWIJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string CQMCRYPHAXT(object a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool XJDGAKIDRFZ([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface ZEAELRSVOME<a> : CUTTMIWIJML
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool YMUWMWJPKES([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a UDFKUPIDUPD([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class UHZRSONWGEO<a> : ZEAELRSVOME<a>, CUTTMIWIJML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type CWXDMLBFRAS;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D480", Offset = "0x7D1BE80", VA = "0x187D1D480")]
		protected UHZRSONWGEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7D1C920", Offset = "0x7D1B320", VA = "0x187D1C920")]
		private a OFJMYSWXFBU(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7D1BC00", Offset = "0x7D1A600", VA = "0x187D1BC00", Slot = "7")]
		public string CQMCRYPHAXT(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7D1D3F0", Offset = "0x7D1BDF0", VA = "0x187D1D3F0", Slot = "5")]
		public bool YMUWMWJPKES(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7D1C0E0", Offset = "0x7D1AAE0", VA = "0x187D1C0E0", Slot = "8")]
		private bool OCHKWXQSIDX(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7D1CEE0", Offset = "0x7D1B8E0", VA = "0x187D1CEE0", Slot = "6")]
		public a UDFKUPIDUPD(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class RVEAXGSHAAH<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static ZEAELRSVOME<b> FYBGHSPAYRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5BB2AD0", Offset = "0x5BB14D0", VA = "0x185BB2AD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3F09DC0", Offset = "0x3F087C0", VA = "0x183F09DC0")]
		public static ZEAELRSVOME<a> ZQESDJIVCAQ<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7681DC0", Offset = "0x76807C0", VA = "0x187681DC0")]
		public static CUTTMIWIJML ZQESDJIVCAQ(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7678150", Offset = "0x7676B50", VA = "0x187678150")]
		private static CUTTMIWIJML LPHFVSUDAUR(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7671930", Offset = "0x7670330", VA = "0x187671930")]
		private static CUTTMIWIJML DAZGEGZPAQM(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class IORIIDPYJPA<a> : IDELAHXCHUV<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class CPBXXLSFYBN : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private string RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private string KVAUWJBYWNY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public string JEKUWARQJYZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public IORIIDPYJPA<a> TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private PooledObject<StringBuilder> TNOIZKCPLXY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private StringBuilder PTROCWRNQLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool JQKFCLGSDBW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int XDAXJQOVVMZ;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private string XWYKLKVTTLP
			{
				[Cpp2IlInjected.Token(Token = "0x600005E")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x1040930", Offset = "0x103F330", VA = "0x181040930")]
			[DebuggerHidden]
			public CPBXXLSFYBN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x50A3AA0", Offset = "0x50A24A0", VA = "0x1850A3AA0", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x50A3FA0", Offset = "0x50A29A0", VA = "0x1850A3FA0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x50A46D0", Offset = "0x50A30D0", VA = "0x1850A46D0")]
			private void XNJKRYGWMCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x4F33510", Offset = "0x4F31F10", VA = "0x184F33510", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x50A43F0", Offset = "0x50A2DF0", VA = "0x1850A43F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> TWESGBWWWOS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x50A4580", Offset = "0x50A2F80", VA = "0x1850A4580", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool XYSGFDMOEGF;

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6601FF0", Offset = "0x66009F0", VA = "0x186601FF0")]
		protected IORIIDPYJPA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6601A70", Offset = "0x6600470", VA = "0x186601A70", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x66018C0", Offset = "0x66002C0", VA = "0x1866018C0", Slot = "12")]
		[IteratorStateMachine(typeof(IORIIDPYJPA<>.CPBXXLSFYBN))]
		internal override IEnumerable<string> AGJBCJPZZLA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6601970", Offset = "0x6600370", VA = "0x186601970")]
		[CompilerGenerated]
		internal static string BNWVKUJSNUA(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class PEZVSSWXVSM : IORIIDPYJPA<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9DCCAD0", Offset = "0x9DCB4D0", VA = "0x189DCCAD0")]
		[Preserve]
		public PEZVSSWXVSM(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9DCCA40", Offset = "0x9DCB440", VA = "0x189DCCA40", Slot = "11")]
		protected override List<string> ABRYRRACPMW(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class CSWHEOYVKST : IORIIDPYJPA<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9DCB7E0", Offset = "0x9DCA1E0", VA = "0x189DCB7E0")]
		[Preserve]
		public CSWHEOYVKST(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9DCB780", Offset = "0x9DCA180", VA = "0x189DCB780", Slot = "11")]
		protected override string[] ABRYRRACPMW(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class TWHZDJOVNZK : UHZRSONWGEO<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xD76D40", Offset = "0xD75740", VA = "0x180D76D40", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9DCCB20", Offset = "0x9DCB520", VA = "0x189DCCB20", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9DCCB40", Offset = "0x9DCB540", VA = "0x189DCCB40")]
		public TWHZDJOVNZK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class OCXCJOQALUD : UHZRSONWGEO<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC630", Offset = "0x9DCB030", VA = "0x189DCC630", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC750", Offset = "0x9DCB150", VA = "0x189DCC750", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9DCC8C0", Offset = "0x9DCB2C0", VA = "0x189DCC8C0")]
		public OCXCJOQALUD()
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
