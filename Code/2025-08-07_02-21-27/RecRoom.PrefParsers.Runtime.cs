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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.PrefParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ATYEIXJQIQS : UMEZLOBANCV<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E49EB0", Offset = "0x8E48AB0", VA = "0x188E49EB0", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8E49E60", Offset = "0x8E48A60", VA = "0x188E49E60", Slot = "10")]
		protected override bool IPMHCNWMEDG(string a, [Out] bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8E49EE0", Offset = "0x8E48AE0", VA = "0x188E49EE0")]
		public ATYEIXJQIQS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class GAPVUQDJUYP : UMEZLOBANCV<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A650", Offset = "0x8E49250", VA = "0x188E4A650", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A5B0", Offset = "0x8E491B0", VA = "0x188E4A5B0", Slot = "10")]
		protected override bool IPMHCNWMEDG(string a, [Out] DateTime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A6E0", Offset = "0x8E492E0", VA = "0x188E4A6E0")]
		public GAPVUQDJUYP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class OQSFGLYUXML<a> : UMEZLOBANCV<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Type OSIZDXQVGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool LBNVQIIIMYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly a[] BSWDYMIYVZN;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x60A8590", Offset = "0x60A7190", VA = "0x1860A8590")]
		[Preserve]
		public OQSFGLYUXML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x60A8300", Offset = "0x60A6F00", VA = "0x1860A8300", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60A8240", Offset = "0x60A6E40", VA = "0x1860A8240", Slot = "10")]
		protected override bool IPMHCNWMEDG(string a, [Out] a b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class UOZXFKWWKJK<a> : UMEZLOBANCV<a> where a : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Type OSIZDXQVGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly LJARJJVVRCO USGOJUEMOYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly bool LBNVQIIIMYL;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x681B810", Offset = "0x681A410", VA = "0x18681B810")]
		[Preserve]
		public UOZXFKWWKJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x681B600", Offset = "0x681A200", VA = "0x18681B600", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x681B280", Offset = "0x6819E80", VA = "0x18681B280", Slot = "10")]
		protected override bool IPMHCNWMEDG(string a, [Out] a b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class KVHHLMLZBLZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Dictionary<Type, LJARJJVVRCO> UVTOOMDTWQL;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A7D0", Offset = "0x8E493D0", VA = "0x188E4A7D0")]
		public static LJARJJVVRCO TJZIPODOHBB(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class HCHKADDOATK<a> : UMEZLOBANCV<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x546B260", Offset = "0x5469E60", VA = "0x18546B260", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x546B170", Offset = "0x5469D70", VA = "0x18546B170", Slot = "10")]
		protected override bool IPMHCNWMEDG(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x43D73F0", Offset = "0x43D5FF0", VA = "0x1843D73F0")]
		public HCHKADDOATK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class HRCYSVZVHLQ<a, b> : UMEZLOBANCV<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly EDYEQLIPZND<b> RYRZPBYXRLO;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x547C920", Offset = "0x547B520", VA = "0x18547C920")]
		protected HRCYSVZVHLQ(EDYEQLIPZND<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x547C560", Offset = "0x547B160", VA = "0x18547C560", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x547A150", Offset = "0x5478D50", VA = "0x18547A150", Slot = "10")]
		protected override bool IPMHCNWMEDG(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a KWTNTCCIVKR(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x54788D0", Offset = "0x54774D0", VA = "0x1854788D0", Slot = "12")]
		internal virtual IEnumerable<string> BOYZERUSJDP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x547BC10", Offset = "0x547A810", VA = "0x18547BC10")]
		[CompilerGenerated]
		private string KVQIFLWFXDM(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class TILYASPKQNU<a> : HRCYSVZVHLQ<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x43ACCD0", Offset = "0x43AB8D0", VA = "0x1843ACCD0")]
		[Preserve]
		public TILYASPKQNU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x43ACCF0", Offset = "0x43AB8F0", VA = "0x1843ACCF0")]
		[Preserve]
		public TILYASPKQNU(EDYEQLIPZND<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x65EA1C0", Offset = "0x65E8DC0", VA = "0x1865EA1C0", Slot = "11")]
		protected override a[] KWTNTCCIVKR(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class COYGSTHSZGR<a> : HRCYSVZVHLQ<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x43ACCD0", Offset = "0x43AB8D0", VA = "0x1843ACCD0")]
		[Preserve]
		public COYGSTHSZGR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x43ACCF0", Offset = "0x43AB8F0", VA = "0x1843ACCF0")]
		[Preserve]
		public COYGSTHSZGR([Optional] EDYEQLIPZND<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x43AC8D0", Offset = "0x43AB4D0", VA = "0x1843AC8D0", Slot = "11")]
		protected override List<a> KWTNTCCIVKR(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class LJQPFRYEVHD<a> : UMEZLOBANCV<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? WUVOYPKLOUO;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5984FB0", Offset = "0x5983BB0", VA = "0x185984FB0")]
		public LJQPFRYEVHD(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5984F10", Offset = "0x5983B10", VA = "0x185984F10", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5984D70", Offset = "0x5983970", VA = "0x185984D70", Slot = "10")]
		protected override bool IPMHCNWMEDG([NotNull] string input, [Out] a a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class NTEETXWEZSI : UMEZLOBANCV<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B110", Offset = "0x8E49D10", VA = "0x188E4B110", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B080", Offset = "0x8E49C80", VA = "0x188E4B080", Slot = "10")]
		protected override bool IPMHCNWMEDG(string a, [Out] byte b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B170", Offset = "0x8E49D70", VA = "0x188E4B170")]
		public NTEETXWEZSI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class BEYFFTNGGMK : UMEZLOBANCV<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8E49FC0", Offset = "0x8E48BC0", VA = "0x188E49FC0", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8E49F20", Offset = "0x8E48B20", VA = "0x188E49F20", Slot = "10")]
		protected override bool IPMHCNWMEDG(string a, [Out] short b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A020", Offset = "0x8E48C20", VA = "0x188E4A020")]
		public BEYFFTNGGMK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class SLOOZQPGASR : UMEZLOBANCV<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B380", Offset = "0x8E49F80", VA = "0x188E4B380", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B2E0", Offset = "0x8E49EE0", VA = "0x188E4B2E0", Slot = "10")]
		protected override bool IPMHCNWMEDG(string a, [Out] ushort b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B3E0", Offset = "0x8E49FE0", VA = "0x188E4B3E0")]
		public SLOOZQPGASR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class VNVPLABBRPX : UMEZLOBANCV<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B4B0", Offset = "0x8E4A0B0", VA = "0x188E4B4B0", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B420", Offset = "0x8E4A020", VA = "0x188E4B420", Slot = "10")]
		protected override bool IPMHCNWMEDG(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B510", Offset = "0x8E4A110", VA = "0x188E4B510")]
		public VNVPLABBRPX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class PQQHHDBWTFQ : UMEZLOBANCV<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B240", Offset = "0x8E49E40", VA = "0x188E4B240", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B1B0", Offset = "0x8E49DB0", VA = "0x188E4B1B0", Slot = "10")]
		protected override bool IPMHCNWMEDG(string a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B2A0", Offset = "0x8E49EA0", VA = "0x188E4B2A0")]
		public PQQHHDBWTFQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class MVDLUTMLFOU : UMEZLOBANCV<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8E4AF80", Offset = "0x8E49B80", VA = "0x188E4AF80", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8E4AEE0", Offset = "0x8E49AE0", VA = "0x188E4AEE0", Slot = "10")]
		protected override bool IPMHCNWMEDG(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8E4AFE0", Offset = "0x8E49BE0", VA = "0x188E4AFE0")]
		public MVDLUTMLFOU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class BFULRWLALBT : UMEZLOBANCV<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A100", Offset = "0x8E48D00", VA = "0x188E4A100", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A060", Offset = "0x8E48C60", VA = "0x188E4A060", Slot = "10")]
		protected override bool IPMHCNWMEDG(string a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A160", Offset = "0x8E48D60", VA = "0x188E4A160")]
		public BFULRWLALBT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class DYFQNNALJBU : UMEZLOBANCV<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A230", Offset = "0x8E48E30", VA = "0x188E4A230", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A1A0", Offset = "0x8E48DA0", VA = "0x188E4A1A0", Slot = "10")]
		protected override bool IPMHCNWMEDG(string a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A2A0", Offset = "0x8E48EA0", VA = "0x188E4A2A0")]
		public DYFQNNALJBU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface LJARJJVVRCO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string HQFQTIMXTHM(object a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool MNRFSHZLIMW([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface EDYEQLIPZND<a> : LJARJJVVRCO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool OLZFYBCEPRL([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a XUSENQPOPLC([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class UMEZLOBANCV<a> : EDYEQLIPZND<a>, LJARJJVVRCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type HIPVUWNCWDF;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6817FF0", Offset = "0x6816BF0", VA = "0x186817FF0")]
		protected UMEZLOBANCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x68177C0", Offset = "0x68163C0", VA = "0x1868177C0")]
		private a RSMIKUGMJNV(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6816BB0", Offset = "0x68157B0", VA = "0x186816BB0", Slot = "7")]
		public string HQFQTIMXTHM(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6816EF0", Offset = "0x6815AF0", VA = "0x186816EF0", Slot = "5")]
		public bool OLZFYBCEPRL(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool IPMHCNWMEDG([NotNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x68173B0", Offset = "0x6815FB0", VA = "0x1868173B0", Slot = "8")]
		private bool OXANNJEWVZG(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6817C80", Offset = "0x6816880", VA = "0x186817C80", Slot = "6")]
		public a XUSENQPOPLC(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class DWDWSDVZAUM<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static EDYEQLIPZND<b> ERMGBLVPTJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x466FD90", Offset = "0x466E990", VA = "0x18466FD90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3FC4D60", Offset = "0x3FC3960", VA = "0x183FC4D60")]
		public static EDYEQLIPZND<a> PRNAXEKSOFP<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x467CBE0", Offset = "0x467B7E0", VA = "0x18467CBE0")]
		public static LJARJJVVRCO PRNAXEKSOFP(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x4677CA0", Offset = "0x46768A0", VA = "0x184677CA0")]
		private static LJARJJVVRCO PEZHTTAJDCO(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4671480", Offset = "0x4670080", VA = "0x184671480")]
		private static LJARJJVVRCO GMWQFRCCLOR(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class OAMIVUMJPXJ<a> : HRCYSVZVHLQ<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class SCBJJFDPPAE : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private string DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int RPOQDRFWNXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private string HCRJKCBMCID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public string FDPUYSCXIDY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public OAMIVUMJPXJ<a> VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private PooledObject<StringBuilder> BUWFLPFGDJZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private StringBuilder SUQBCUNOMLR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool CGBNZNWUQZV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int MZBSBXKAOMQ;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private string DMWONALYXSM
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
			[DebuggerHidden]
			public SCBJJFDPPAE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x64EE570", Offset = "0x64ED170", VA = "0x1864EE570", Slot = "7")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x64EDE90", Offset = "0x64ECA90", VA = "0x1864EDE90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x64EE2D0", Offset = "0x64ECED0", VA = "0x1864EE2D0")]
			private void QCWGZBRZQOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x4381FB0", Offset = "0x4380BB0", VA = "0x184381FB0", Slot = "10")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x64EE430", Offset = "0x64ED030", VA = "0x1864EE430", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> YDQXJDTSKET()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x64EE610", Offset = "0x64ED210", VA = "0x1864EE610", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator ZFHLTDQPCLO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool ICLNUYJZCAG;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x60928B0", Offset = "0x60914B0", VA = "0x1860928B0")]
		protected OAMIVUMJPXJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x60923A0", Offset = "0x6090FA0", VA = "0x1860923A0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x60921F0", Offset = "0x6090DF0", VA = "0x1860921F0", Slot = "12")]
		[IteratorStateMachine(typeof(OAMIVUMJPXJ<>.SCBJJFDPPAE))]
		internal override IEnumerable<string> BOYZERUSJDP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6092320", Offset = "0x6090F20", VA = "0x186092320")]
		[CompilerGenerated]
		internal static string EOTNAMTXCIZ(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class XYBEMVYMKFR : OAMIVUMJPXJ<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B5E0", Offset = "0x8E4A1E0", VA = "0x188E4B5E0")]
		[Preserve]
		public XYBEMVYMKFR(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B550", Offset = "0x8E4A150", VA = "0x188E4B550", Slot = "11")]
		protected override List<string> KWTNTCCIVKR(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class IZSAKDAKCZU : OAMIVUMJPXJ<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A780", Offset = "0x8E49380", VA = "0x188E4A780")]
		[Preserve]
		public IZSAKDAKCZU(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A720", Offset = "0x8E49320", VA = "0x188E4A720", Slot = "11")]
		protected override string[] KWTNTCCIVKR(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class NSAXTFZWARV : UMEZLOBANCV<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB7C8B0", Offset = "0xB7B4B0", VA = "0x180B7C8B0", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B020", Offset = "0x8E49C20", VA = "0x188E4B020", Slot = "10")]
		protected override bool IPMHCNWMEDG(string a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8E4B040", Offset = "0x8E49C40", VA = "0x188E4B040")]
		public NSAXTFZWARV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class FCGVLTMHRQY : UMEZLOBANCV<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A450", Offset = "0x8E49050", VA = "0x188E4A450", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A2E0", Offset = "0x8E48EE0", VA = "0x188E4A2E0", Slot = "10")]
		protected override bool IPMHCNWMEDG(string a, [Out] TimeSpan b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A570", Offset = "0x8E49170", VA = "0x188E4A570")]
		public FCGVLTMHRQY()
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
