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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Utils.PrefParsers
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class ZQDPSDOGFXF : ADFSYRSKXAQ<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8903310", Offset = "0x8901910", VA = "0x188903310", Slot = "9")]
		public override string Serialize(bool input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x89032C0", Offset = "0x89018C0", VA = "0x1889032C0", Slot = "10")]
		protected override bool RQBBEHZZNEF(string a, [Out] bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8903340", Offset = "0x8901940", VA = "0x188903340")]
		public ZQDPSDOGFXF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal class XSFNPUXAKYK : ADFSYRSKXAQ<DateTime>
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8902F90", Offset = "0x8901590", VA = "0x188902F90", Slot = "9")]
		public override string Serialize(DateTime input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8902EF0", Offset = "0x89014F0", VA = "0x188902EF0", Slot = "10")]
		protected override bool RQBBEHZZNEF(string a, [Out] DateTime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8903020", Offset = "0x8901620", VA = "0x188903020")]
		public XSFNPUXAKYK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PXVGNIHVNJA<a> : ADFSYRSKXAQ<a> where a : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Type BIBDPXTYBQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly bool XEXLNHBNCTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly a[] EJHSPXJBXKG;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5C91720", Offset = "0x5C8FD20", VA = "0x185C91720")]
		[Preserve]
		public PXVGNIHVNJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5C91130", Offset = "0x5C8F730", VA = "0x185C91130", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5C90FA0", Offset = "0x5C8F5A0", VA = "0x185C90FA0", Slot = "10")]
		protected override bool RQBBEHZZNEF(string a, [Out] a b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class XYXCLKGKPXL<a> : ADFSYRSKXAQ<a> where a : Enum
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly Type BIBDPXTYBQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly KFHUIOKXTOJ CEPDMPDKZEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly bool XEXLNHBNCTO;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4098380", Offset = "0x4096980", VA = "0x184098380")]
		[Preserve]
		public XYXCLKGKPXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x40982B0", Offset = "0x40968B0", VA = "0x1840982B0", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4097F30", Offset = "0x4096530", VA = "0x184097F30", Slot = "10")]
		protected override bool RQBBEHZZNEF(string a, [Out] a b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class XRSUIKLYGGK
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private static readonly Dictionary<Type, KFHUIOKXTOJ> EWPYZBAABNY;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x89027E0", Offset = "0x8900DE0", VA = "0x1889027E0")]
		public static KFHUIOKXTOJ CCHTMUMFDFI(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class GXPEEBRJCSL<a> : ADFSYRSKXAQ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5076040", Offset = "0x5074640", VA = "0x185076040", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5075F10", Offset = "0x5074510", VA = "0x185075F10", Slot = "10")]
		protected override bool RQBBEHZZNEF(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x41317E0", Offset = "0x412FDE0", VA = "0x1841317E0")]
		public GXPEEBRJCSL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class AWNMKPTUSYX<a, b> : ADFSYRSKXAQ<a> where a : IEnumerable<b>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		protected readonly XEMGIITTIKS<b> VFVFEWIFCIP;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x56B8D50", Offset = "0x56B7350", VA = "0x1856B8D50")]
		protected AWNMKPTUSYX(XEMGIITTIKS<b> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x56B7C60", Offset = "0x56B6260", VA = "0x1856B7C60", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x56B7910", Offset = "0x56B5F10", VA = "0x1856B7910", Slot = "10")]
		protected override bool RQBBEHZZNEF(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract a VBCBQNQNTIA(IEnumerable<b> a);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x56B4CF0", Offset = "0x56B32F0", VA = "0x1856B4CF0", Slot = "12")]
		internal virtual IEnumerable<string> PGXYAHKLNIQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x56B8810", Offset = "0x56B6E10", VA = "0x1856B8810")]
		[CompilerGenerated]
		private string VSABJNJSFCR(b a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AOZIWGALGDP<a> : AWNMKPTUSYX<a[], a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5617D30", Offset = "0x5616330", VA = "0x185617D30")]
		[Preserve]
		public AOZIWGALGDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5617D20", Offset = "0x5616320", VA = "0x185617D20")]
		[Preserve]
		public AOZIWGALGDP(XEMGIITTIKS<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5617B90", Offset = "0x5616190", VA = "0x185617B90", Slot = "11")]
		protected override a[] VBCBQNQNTIA(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class TFVGWBMHADG<a> : AWNMKPTUSYX<List<a>, a>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5617D30", Offset = "0x5616330", VA = "0x185617D30")]
		[Preserve]
		public TFVGWBMHADG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5617D20", Offset = "0x5616320", VA = "0x185617D20")]
		[Preserve]
		public TFVGWBMHADG([Optional] XEMGIITTIKS<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x61291A0", Offset = "0x61277A0", VA = "0x1861291A0", Slot = "11")]
		protected override List<a> VBCBQNQNTIA(IEnumerable<a> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ISJMECGWBAM<a> : ADFSYRSKXAQ<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JsonSerializerSettings? PKXUKEXQMTR;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x51DE450", Offset = "0x51DCA50", VA = "0x1851DE450")]
		public ISJMECGWBAM(JsonSerializerSettings? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x51DE300", Offset = "0x51DC900", VA = "0x1851DE300", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x51DE0D0", Offset = "0x51DC6D0", VA = "0x1851DE0D0", Slot = "10")]
		protected override bool RQBBEHZZNEF([NotNull] string input, [Out] a a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	internal class YQRNADISSMV : ADFSYRSKXAQ<byte>
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8903220", Offset = "0x8901820", VA = "0x188903220", Slot = "9")]
		public override string Serialize(byte input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8903190", Offset = "0x8901790", VA = "0x188903190", Slot = "10")]
		protected override bool RQBBEHZZNEF(string a, [Out] byte b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8903280", Offset = "0x8901880", VA = "0x188903280")]
		public YQRNADISSMV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal class NSZCHHFGYBD : ADFSYRSKXAQ<short>
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8902380", Offset = "0x8900980", VA = "0x188902380", Slot = "9")]
		public override string Serialize(short input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x89022E0", Offset = "0x89008E0", VA = "0x1889022E0", Slot = "10")]
		protected override bool RQBBEHZZNEF(string a, [Out] short b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x89023E0", Offset = "0x89009E0", VA = "0x1889023E0")]
		public NSZCHHFGYBD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class DHLFRBQYRME : ADFSYRSKXAQ<ushort>
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8901C50", Offset = "0x8900250", VA = "0x188901C50", Slot = "9")]
		public override string Serialize(ushort input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8901BB0", Offset = "0x89001B0", VA = "0x188901BB0", Slot = "10")]
		protected override bool RQBBEHZZNEF(string a, [Out] ushort b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8901CB0", Offset = "0x89002B0", VA = "0x188901CB0")]
		public DHLFRBQYRME()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class IWLTXVLQNAS : ADFSYRSKXAQ<int>
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x89021E0", Offset = "0x89007E0", VA = "0x1889021E0", Slot = "9")]
		public override string Serialize(int input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8902150", Offset = "0x8900750", VA = "0x188902150", Slot = "10")]
		protected override bool RQBBEHZZNEF(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8902240", Offset = "0x8900840", VA = "0x188902240")]
		public IWLTXVLQNAS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class XWUJSTGGETB : ADFSYRSKXAQ<uint>
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x89030F0", Offset = "0x89016F0", VA = "0x1889030F0", Slot = "9")]
		public override string Serialize(uint input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8903060", Offset = "0x8901660", VA = "0x188903060", Slot = "10")]
		protected override bool RQBBEHZZNEF(string a, [Out] uint b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8903150", Offset = "0x8901750", VA = "0x188903150")]
		public XWUJSTGGETB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class PRAUCEEKUYR : ADFSYRSKXAQ<long>
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x89024C0", Offset = "0x8900AC0", VA = "0x1889024C0", Slot = "9")]
		public override string Serialize(long input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8902420", Offset = "0x8900A20", VA = "0x188902420", Slot = "10")]
		protected override bool RQBBEHZZNEF(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8902520", Offset = "0x8900B20", VA = "0x188902520")]
		public PRAUCEEKUYR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class URAIWRPWXEK : ADFSYRSKXAQ<ulong>
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8902740", Offset = "0x8900D40", VA = "0x188902740", Slot = "9")]
		public override string Serialize(ulong input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x89026A0", Offset = "0x8900CA0", VA = "0x1889026A0", Slot = "10")]
		protected override bool RQBBEHZZNEF(string a, [Out] ulong b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x89027A0", Offset = "0x8900DA0", VA = "0x1889027A0")]
		public URAIWRPWXEK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class SPWUMXZPCQV : ADFSYRSKXAQ<float>
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x89025F0", Offset = "0x8900BF0", VA = "0x1889025F0", Slot = "9")]
		public override string Serialize(float input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8902560", Offset = "0x8900B60", VA = "0x188902560", Slot = "10")]
		protected override bool RQBBEHZZNEF(string a, [Out] float b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8902660", Offset = "0x8900C60", VA = "0x188902660")]
		public SPWUMXZPCQV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface KFHUIOKXTOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string IOFHZNFKNVF(object a);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool VBJUJBKDLIZ([CanBeNull] string input, [Out] object a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface XEMGIITTIKS<a> : KFHUIOKXTOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool IXSFUJNOUNW([CanBeNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		a SLACCWFOPWP([CanBeNull] string input, [Optional] a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class ADFSYRSKXAQ<a> : XEMGIITTIKS<a>, KFHUIOKXTOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Type RHCFLNNHTHS;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5564A10", Offset = "0x5563010", VA = "0x185564A10")]
		protected ADFSYRSKXAQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x55639D0", Offset = "0x5561FD0", VA = "0x1855639D0")]
		private a IKAGLRPSWOQ(object a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string Serialize(a input);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5564060", Offset = "0x5562660", VA = "0x185564060", Slot = "7")]
		public string IOFHZNFKNVF(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5564600", Offset = "0x5562C00", VA = "0x185564600", Slot = "5")]
		public bool IXSFUJNOUNW(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool RQBBEHZZNEF([NotNull] string input, [Out] a a);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x55633F0", Offset = "0x55619F0", VA = "0x1855633F0", Slot = "8")]
		private bool BNFLNSCKSTR(string a, [Out] object b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5564650", Offset = "0x5562C50", VA = "0x185564650", Slot = "6")]
		public a SLACCWFOPWP(string a, [Optional] a b)
		{
			return (a)null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public static class CBCNQCEGHYB<b>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static XEMGIITTIKS<b> AMLVLGFTEOB
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3FF7E00", Offset = "0x3FF6400", VA = "0x183FF7E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3861790", Offset = "0x385FD90", VA = "0x183861790")]
		public static XEMGIITTIKS<a> DDCLOJXXOUG<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x4003530", Offset = "0x4001B30", VA = "0x184003530")]
		public static KFHUIOKXTOJ DDCLOJXXOUG(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x40065D0", Offset = "0x4004BD0", VA = "0x1840065D0")]
		private static KFHUIOKXTOJ HRKWQWIKMFR(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3FFCA30", Offset = "0x3FFB030", VA = "0x183FFCA30")]
		private static KFHUIOKXTOJ DCOKFONINUC(Type a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class FVJFGZOAFYI<a> : AWNMKPTUSYX<a, string> where a : IEnumerable<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class XUCSXUYYTMN : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private string MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int NVRLJVISCMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			private string RKGRKODVJWE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public string YAPYBGIAZDR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public FVJFGZOAFYI<a> CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private PooledObject<StringBuilder> RHKNARAKVHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private StringBuilder XWVUIVYEHEY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private bool SLNRRRIXZVM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int HBESVHOSIEP;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			private string FOLRAZEUJML
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xB597F0", Offset = "0xB57DF0", VA = "0x180B597F0")]
			[DebuggerHidden]
			public XUCSXUYYTMN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x4090250", Offset = "0x408E850", VA = "0x184090250", Slot = "7")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x4090AC0", Offset = "0x408F0C0", VA = "0x184090AC0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x40904F0", Offset = "0x408EAF0", VA = "0x1840904F0")]
			private void KPIRURCCWVL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x3FF6D20", Offset = "0x3FF5320", VA = "0x183FF6D20", Slot = "10")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x4090430", Offset = "0x408EA30", VA = "0x184090430", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<string> IWXTODGYYKA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x40905B0", Offset = "0x408EBB0", VA = "0x1840905B0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator MZPFIUHPQEF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly bool VMPTTJIURJZ;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4F47C90", Offset = "0x4F46290", VA = "0x184F47C90")]
		protected FVJFGZOAFYI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4F47660", Offset = "0x4F45C60", VA = "0x184F47660", Slot = "9")]
		public override string Serialize(a input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4F47500", Offset = "0x4F45B00", VA = "0x184F47500", Slot = "12")]
		[IteratorStateMachine(typeof(FVJFGZOAFYI<>.XUCSXUYYTMN))]
		internal override IEnumerable<string> PGXYAHKLNIQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4F47BD0", Offset = "0x4F461D0", VA = "0x184F47BD0")]
		[CompilerGenerated]
		internal static string WTOFELUGGHI(StringBuilder a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class HOWUGWJFNQG : FVJFGZOAFYI<List<string>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8902100", Offset = "0x8900700", VA = "0x188902100")]
		[Preserve]
		public HOWUGWJFNQG(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8902070", Offset = "0x8900670", VA = "0x188902070", Slot = "11")]
		protected override List<string> VBCBQNQNTIA(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class GLGXMRRGUSJ : FVJFGZOAFYI<string[]>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8902020", Offset = "0x8900620", VA = "0x188902020")]
		[Preserve]
		public GLGXMRRGUSJ(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8901FC0", Offset = "0x89005C0", VA = "0x188901FC0", Slot = "11")]
		protected override string[] VBCBQNQNTIA(IEnumerable<string> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal class NLXLOFUPDHE : ADFSYRSKXAQ<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB07EC0", Offset = "0xB064C0", VA = "0x180B07EC0", Slot = "9")]
		public override string Serialize(string input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8902280", Offset = "0x8900880", VA = "0x188902280", Slot = "10")]
		protected override bool RQBBEHZZNEF(string a, [Out] string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x89022A0", Offset = "0x89008A0", VA = "0x1889022A0")]
		public NLXLOFUPDHE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DMGGPYKIMPP : ADFSYRSKXAQ<TimeSpan>
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8901E60", Offset = "0x8900460", VA = "0x188901E60", Slot = "9")]
		public override string Serialize(TimeSpan input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8901CF0", Offset = "0x89002F0", VA = "0x188901CF0", Slot = "10")]
		protected override bool RQBBEHZZNEF(string a, [Out] TimeSpan b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8901F80", Offset = "0x8900580", VA = "0x188901F80")]
		public DMGGPYKIMPP()
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
