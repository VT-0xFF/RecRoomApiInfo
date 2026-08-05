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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB40", Offset = "0xACDF40", VA = "0x180ACEB40")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.PrefParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class CINKOFNMOSJ : ACNPEQLTMWK<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8681490", Offset = "0x8680890", VA = "0x188681490", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x86814C0", Offset = "0x86808C0", VA = "0x1886814C0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] bool value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8681510", Offset = "0x8680910", VA = "0x188681510")]
		public CINKOFNMOSJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class XOMJUVRAUDG : ACNPEQLTMWK<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x86828D0", Offset = "0x8681CD0", VA = "0x1886828D0", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8682960", Offset = "0x8681D60", VA = "0x188682960", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] DateTime value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8682A00", Offset = "0x8681E00", VA = "0x188682A00")]
		public XOMJUVRAUDG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class CWPITCGKYIA<a> : ACNPEQLTMWK<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Type URHABNHEMVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool WDNGRYDLUTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly a[] KSUHZBWOOIM;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3E34140", Offset = "0x3E33540", VA = "0x183E34140")]
		[Preserve]
		public CWPITCGKYIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3E339C0", Offset = "0x3E32DC0", VA = "0x183E339C0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3E33FB0", Offset = "0x3E333B0", VA = "0x183E33FB0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class HSJAHRRFHHZ<a> : ACNPEQLTMWK<a> where a : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Type URHABNHEMVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly QFEJUCSZSYX FCLXBDKVXVG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly bool WDNGRYDLUTE;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4F4A320", Offset = "0x4F49720", VA = "0x184F4A320")]
		[Preserve]
		public HSJAHRRFHHZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4F49CF0", Offset = "0x4F490F0", VA = "0x184F49CF0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4F4A0D0", Offset = "0x4F494D0", VA = "0x184F4A0D0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class NKBEIJRHHZC
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Dictionary<Type, QFEJUCSZSYX> MMNSRITUPFG;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8681E40", Offset = "0x8681240", VA = "0x188681E40")]
		public static QFEJUCSZSYX XTQLTQYXMEA(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class EESYRAAZJGN<a> : ACNPEQLTMWK<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4758570", Offset = "0x4757970", VA = "0x184758570", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x47586C0", Offset = "0x4757AC0", VA = "0x1847586C0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3F5F830", Offset = "0x3F5EC30", VA = "0x183F5F830")]
		public EESYRAAZJGN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class WEDEDMHCYYZ<a, b> : ACNPEQLTMWK<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly HNULQOWVXXS<b> KQGRVGLBJEV;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x65A8060", Offset = "0x65A7460", VA = "0x1865A8060")]
		protected WEDEDMHCYYZ(HNULQOWVXXS<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x65A49D0", Offset = "0x65A3DD0", VA = "0x1865A49D0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x65A6490", Offset = "0x65A5890", VA = "0x1865A6490", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a BZSZUPARJUW(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x65A45E0", Offset = "0x65A39E0", VA = "0x1865A45E0", Slot = "12")]
		internal virtual IEnumerable<string> JRWBYTFPNPI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x65A4370", Offset = "0x65A3770", VA = "0x1865A4370")]
		[CompilerGenerated]
		private string FDYCJDKRUGL(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class FJGCLPTTCKH<a> : WEDEDMHCYYZ<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A580", Offset = "0x3F09980", VA = "0x183F0A580")]
		[Preserve]
		public FJGCLPTTCKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A570", Offset = "0x3F09970", VA = "0x183F0A570")]
		[Preserve]
		public FJGCLPTTCKH(HNULQOWVXXS<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4D9B360", Offset = "0x4D9A760", VA = "0x184D9B360", Slot = "11")]
		protected override a[] BZSZUPARJUW(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ZJYAAVUAXHQ<a> : WEDEDMHCYYZ<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A580", Offset = "0x3F09980", VA = "0x183F0A580")]
		[Preserve]
		public ZJYAAVUAXHQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A570", Offset = "0x3F09970", VA = "0x183F0A570")]
		[Preserve]
		public ZJYAAVUAXHQ([Optional] HNULQOWVXXS<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A440", Offset = "0x3F09840", VA = "0x183F0A440", Slot = "11")]
		protected override List<a> BZSZUPARJUW(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KNNERFFQLRA<a> : ACNPEQLTMWK<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? JRHCIFWLJQB;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x521FF30", Offset = "0x521F330", VA = "0x18521FF30")]
		public KNNERFFQLRA(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x521FC60", Offset = "0x521F060", VA = "0x18521FC60", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x521FCC0", Offset = "0x521F0C0", VA = "0x18521FCC0", Slot = "10")]
		protected override bool TryParseInternal([NotNull] string input, [Out] a value)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class JHDVLZQOWHV : ACNPEQLTMWK<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8681BD0", Offset = "0x8680FD0", VA = "0x188681BD0", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8681C30", Offset = "0x8681030", VA = "0x188681C30", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] byte value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8681CC0", Offset = "0x86810C0", VA = "0x188681CC0")]
		public JHDVLZQOWHV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class QHXMNFMVGWD : ACNPEQLTMWK<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8682680", Offset = "0x8681A80", VA = "0x188682680", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x86826E0", Offset = "0x8681AE0", VA = "0x1886826E0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] short value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8682780", Offset = "0x8681B80", VA = "0x188682780")]
		public QHXMNFMVGWD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class DZBIZPGSUYW : ACNPEQLTMWK<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8681690", Offset = "0x8680A90", VA = "0x188681690", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x86816F0", Offset = "0x8680AF0", VA = "0x1886816F0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ushort value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8681790", Offset = "0x8680B90", VA = "0x188681790")]
		public DZBIZPGSUYW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HBSRWIENICE : ACNPEQLTMWK<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x86817D0", Offset = "0x8680BD0", VA = "0x1886817D0", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8681830", Offset = "0x8680C30", VA = "0x188681830", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] int value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x86818C0", Offset = "0x8680CC0", VA = "0x1886818C0")]
		public HBSRWIENICE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class PKNGFADEDVH : ACNPEQLTMWK<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8682550", Offset = "0x8681950", VA = "0x188682550", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x86825B0", Offset = "0x86819B0", VA = "0x1886825B0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] uint value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8682640", Offset = "0x8681A40", VA = "0x188682640")]
		public PKNGFADEDVH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class DIIEHTIQVJB : ACNPEQLTMWK<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8681550", Offset = "0x8680950", VA = "0x188681550", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x86815B0", Offset = "0x86809B0", VA = "0x1886815B0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] long value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8681650", Offset = "0x8680A50", VA = "0x188681650")]
		public DIIEHTIQVJB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class BFBXZZZIDNC : ACNPEQLTMWK<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8681350", Offset = "0x8680750", VA = "0x188681350", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86813B0", Offset = "0x86807B0", VA = "0x1886813B0", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] ulong value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8681450", Offset = "0x8680850", VA = "0x188681450")]
		public BFBXZZZIDNC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class KYMSBYYXBAX : ACNPEQLTMWK<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8681D00", Offset = "0x8681100", VA = "0x188681D00", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8681D70", Offset = "0x8681170", VA = "0x188681D70", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] float value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8681E00", Offset = "0x8681200", VA = "0x188681E00")]
		public KYMSBYYXBAX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface QFEJUCSZSYX
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string DUUHQSVRJIV(object a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool WQXNYRGIPZB([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface HNULQOWVXXS<a> : QFEJUCSZSYX
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool WNIWTQLPHSC([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a IWYMAMBRLMF([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class ACNPEQLTMWK<a> : HNULQOWVXXS<a>, QFEJUCSZSYX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type SMJOCMHDUXQ;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5475DD0", Offset = "0x54751D0", VA = "0x185475DD0")]
		protected ACNPEQLTMWK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5475840", Offset = "0x5474C40", VA = "0x185475840")]
		private a OWCPWSGDRKK(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x54747A0", Offset = "0x5473BA0", VA = "0x1854747A0", Slot = "7")]
		public string DUUHQSVRJIV(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5475D40", Offset = "0x5475140", VA = "0x185475D40", Slot = "5")]
		public bool WNIWTQLPHSC(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TryParseInternal([NotNull] string input, [Out] a value);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5475140", Offset = "0x5474540", VA = "0x185475140", Slot = "8")]
		private bool MSQKEVEIDXD(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5474D30", Offset = "0x5474130", VA = "0x185474D30", Slot = "6")]
		public a IWYMAMBRLMF(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class SHETKVMNZRJ<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static HNULQOWVXXS<b> VDDQACCVTOD
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4D34B30", Offset = "0x4D33F30", VA = "0x184D34B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x362BEC0", Offset = "0x362B2C0", VA = "0x18362BEC0")]
		public static HNULQOWVXXS<a> UCPXLGVYTQU<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5DD77C0", Offset = "0x5DD6BC0", VA = "0x185DD77C0")]
		public static QFEJUCSZSYX UCPXLGVYTQU(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5DCDE70", Offset = "0x5DCD270", VA = "0x185DCDE70")]
		private static QFEJUCSZSYX RSUJPAPBTNL(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5DC3080", Offset = "0x5DC2480", VA = "0x185DC3080")]
		private static QFEJUCSZSYX CYCWWOXQMKA(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class BIHSGOSHUVA<a> : WEDEDMHCYYZ<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class VMFOALPSNUD : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int JIPOOQUWCIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private string JOTWNIKQVJT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int PLMFUAHXCWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private string KQVRFETUHTI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public string FFHVKMJVNAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public BIHSGOSHUVA<a> MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private PooledObject<StringBuilder> FNYXVRJQNMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private StringBuilder KOROKOOQIIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool IXTPXZXVTFW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int TUJCSXLFDSF;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private string XRSXERLDEVX
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object MSIUOYXLJXG
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xD06FE0", Offset = "0xD063E0", VA = "0x180D06FE0")]
			[DebuggerHidden]
			public VMFOALPSNUD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6250490", Offset = "0x624F890", VA = "0x186250490", Slot = "7")]
			[DebuggerHidden]
			private void AEBWHPMOWJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x6250770", Offset = "0x624FB70", VA = "0x186250770", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x6251050", Offset = "0x6250450", VA = "0x186251050")]
			private void RYZDNTQONZF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3D27BC0", Offset = "0x3D26FC0", VA = "0x183D27BC0", Slot = "10")]
			[DebuggerHidden]
			private void MJTKPUASZVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x62505F0", Offset = "0x624F9F0", VA = "0x1862505F0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> DNUVTWOVQJE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x6250530", Offset = "0x624F930", VA = "0x186250530", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator CQMSCGRISCD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool ZTFSMUWOBCJ;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6F64FB0", Offset = "0x6F643B0", VA = "0x186F64FB0")]
		protected BIHSGOSHUVA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6F64AC0", Offset = "0x6F63EC0", VA = "0x186F64AC0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6F64A10", Offset = "0x6F63E10", VA = "0x186F64A10", Slot = "12")]
		[IteratorStateMachine(typeof(BIHSGOSHUVA<>.VMFOALPSNUD))]
		internal override IEnumerable<string> JRWBYTFPNPI(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6F648E0", Offset = "0x6F63CE0", VA = "0x186F648E0")]
		[CompilerGenerated]
		internal static string EOXYLIEONMQ(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class YJUAMZCDDYI : BIHSGOSHUVA<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8682AD0", Offset = "0x8681ED0", VA = "0x188682AD0")]
		[Preserve]
		public YJUAMZCDDYI(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8682A40", Offset = "0x8681E40", VA = "0x188682A40", Slot = "11")]
		protected override List<string> BZSZUPARJUW(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class TAPZLIFZMEX : BIHSGOSHUVA<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8682820", Offset = "0x8681C20", VA = "0x188682820")]
		[Preserve]
		public TAPZLIFZMEX(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x86827C0", Offset = "0x8681BC0", VA = "0x1886827C0", Slot = "11")]
		protected override string[] BZSZUPARJUW(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class VRMNPPPHZYE : ACNPEQLTMWK<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB048B0", Offset = "0xB03CB0", VA = "0x180B048B0", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8682870", Offset = "0x8681C70", VA = "0x188682870", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] string value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8682890", Offset = "0x8681C90", VA = "0x188682890")]
		public VRMNPPPHZYE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class HJDFRKJZHDF : ACNPEQLTMWK<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8681900", Offset = "0x8680D00", VA = "0x188681900", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8681A20", Offset = "0x8680E20", VA = "0x188681A20", Slot = "10")]
		protected override bool TryParseInternal(string input, [Out] TimeSpan value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8681B90", Offset = "0x8680F90", VA = "0x188681B90")]
		public HJDFRKJZHDF()
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
