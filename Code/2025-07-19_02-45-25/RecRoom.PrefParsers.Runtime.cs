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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LFIAIEBLONB : LHFIDOIGCLG<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x85544A0", Offset = "0x85534A0", VA = "0x1885544A0", Slot = "9")]
	public override string FBGBLPHHDGN(bool JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x85544F0", Offset = "0x85534F0", VA = "0x1885544F0", Slot = "10")]
	protected override bool LLGKNPJOACF(string JMJJABEKOFI, [Out] bool IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8554550", Offset = "0x8553550", VA = "0x188554550")]
	public LFIAIEBLONB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class JNGBBEGCIHB : LHFIDOIGCLG<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8554280", Offset = "0x8553280", VA = "0x188554280", Slot = "9")]
	public override string FBGBLPHHDGN(DateTime JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8554310", Offset = "0x8553310", VA = "0x188554310", Slot = "10")]
	protected override bool LLGKNPJOACF(string JMJJABEKOFI, [Out] DateTime IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x85543B0", Offset = "0x85533B0", VA = "0x1885543B0")]
	public JNGBBEGCIHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class FJFNMNPFOPA<TEnum> : LHFIDOIGCLG<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type NJDEACBHLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool DDMBKHIPJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] NCIPNLHDHEI;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4D985F0", Offset = "0x4D975F0", VA = "0x184D985F0")]
	[Preserve]
	public FJFNMNPFOPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4D98240", Offset = "0x4D97240", VA = "0x184D98240", Slot = "9")]
	public override string FBGBLPHHDGN(TEnum JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4D98430", Offset = "0x4D97430", VA = "0x184D98430", Slot = "10")]
	protected override bool LLGKNPJOACF(string JMJJABEKOFI, [Out] TEnum IOALKPFEKEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class MEMIMNLKFJL<TEnum> : LHFIDOIGCLG<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type NJDEACBHLAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly MOPKJJDBCNA ABOGNCLMIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool DDMBKHIPJJG;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x56AD5F0", Offset = "0x56AC5F0", VA = "0x1856AD5F0")]
	[Preserve]
	public MEMIMNLKFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x56ACDF0", Offset = "0x56ABDF0", VA = "0x1856ACDF0", Slot = "9")]
	public override string FBGBLPHHDGN(TEnum JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x56AD240", Offset = "0x56AC240", VA = "0x1856AD240", Slot = "10")]
	protected override bool LLGKNPJOACF(string JMJJABEKOFI, [Out] TEnum IOALKPFEKEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class FOKIHHHCONA
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, MOPKJJDBCNA> GGPCBOKOHDF;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x85539F0", Offset = "0x85529F0", VA = "0x1885539F0")]
	public static MOPKJJDBCNA MIJBBOHBGHJ(Type GGLPCHMBPCM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class JPJLFDNLEDA<T> : LHFIDOIGCLG<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3C5EDC0", Offset = "0x3C5DDC0", VA = "0x183C5EDC0", Slot = "9")]
	public override string FBGBLPHHDGN(T JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x52E6670", Offset = "0x52E5670", VA = "0x1852E6670", Slot = "10")]
	protected override bool LLGKNPJOACF(string JMJJABEKOFI, [Out] T IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x48DEA80", Offset = "0x48DDA80", VA = "0x1848DEA80")]
	public JPJLFDNLEDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class HEBIJPKJFEO<TCollection, T> : LHFIDOIGCLG<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly NENHAJLFEBJ<T> DJJDLFEMEKE;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4F39A80", Offset = "0x4F38A80", VA = "0x184F39A80")]
	protected HEBIJPKJFEO(NENHAJLFEBJ<T> DJJDLFEMEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4F36020", Offset = "0x4F35020", VA = "0x184F36020", Slot = "9")]
	public override string FBGBLPHHDGN(TCollection JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4F38C00", Offset = "0x4F37C00", VA = "0x184F38C00", Slot = "10")]
	protected override bool LLGKNPJOACF(string JMJJABEKOFI, [Out] TCollection IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection JIJOGLPJFGI(IEnumerable<T> LLJAAOFGKGM);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4F36AA0", Offset = "0x4F35AA0", VA = "0x184F36AA0", Slot = "12")]
	internal virtual IEnumerable<string> LHABHOBONIM(string JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4F39860", Offset = "0x4F38860", VA = "0x184F39860")]
	[CompilerGenerated]
	private string LOGCJGFNLAC(T LJALOPCLDCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class CBLOCHIMECM<T> : HEBIJPKJFEO<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4902F30", Offset = "0x4901F30", VA = "0x184902F30")]
	[Preserve]
	public CBLOCHIMECM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4901E10", Offset = "0x4900E10", VA = "0x184901E10")]
	[Preserve]
	public CBLOCHIMECM(NENHAJLFEBJ<T> DJJDLFEMEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68AA1D0", Offset = "0x68A91D0", VA = "0x1868AA1D0", Slot = "11")]
	protected override T[] JIJOGLPJFGI(IEnumerable<T> LLJAAOFGKGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class EHNPCGKPDPG<T> : HEBIJPKJFEO<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4902F30", Offset = "0x4901F30", VA = "0x184902F30")]
	[Preserve]
	public EHNPCGKPDPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4901E10", Offset = "0x4900E10", VA = "0x184901E10")]
	[Preserve]
	public EHNPCGKPDPG([Optional] NENHAJLFEBJ<T> DJJDLFEMEKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4902E90", Offset = "0x4901E90", VA = "0x184902E90", Slot = "11")]
	protected override List<T> JIJOGLPJFGI(IEnumerable<T> LLJAAOFGKGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class IDOKLJKCAIO<T> : LHFIDOIGCLG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? OFKCJNONLMM;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x500F540", Offset = "0x500E540", VA = "0x18500F540")]
	public IDOKLJKCAIO(JsonSerializerSettings? PDPMKFKBFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x500F420", Offset = "0x500E420", VA = "0x18500F420", Slot = "9")]
	public override string FBGBLPHHDGN(T JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x500F480", Offset = "0x500E480", VA = "0x18500F480", Slot = "10")]
	protected override bool LLGKNPJOACF([NotNull] string JMJJABEKOFI, [Out] T IOALKPFEKEK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class BHAIFBHDFBE : LHFIDOIGCLG<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8553650", Offset = "0x8552650", VA = "0x188553650", Slot = "9")]
	public override string FBGBLPHHDGN(byte JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x85536B0", Offset = "0x85526B0", VA = "0x1885536B0", Slot = "10")]
	protected override bool LLGKNPJOACF(string JMJJABEKOFI, [Out] byte IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8553740", Offset = "0x8552740", VA = "0x188553740")]
	public BHAIFBHDFBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class BPMPFBBOOLM : LHFIDOIGCLG<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x85538B0", Offset = "0x85528B0", VA = "0x1885538B0", Slot = "9")]
	public override string FBGBLPHHDGN(short JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8553910", Offset = "0x8552910", VA = "0x188553910", Slot = "10")]
	protected override bool LLGKNPJOACF(string JMJJABEKOFI, [Out] short IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x85539B0", Offset = "0x85529B0", VA = "0x1885539B0")]
	public BPMPFBBOOLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class MNLKGGGEIGD : LHFIDOIGCLG<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8554590", Offset = "0x8553590", VA = "0x188554590", Slot = "9")]
	public override string FBGBLPHHDGN(ushort JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x85545F0", Offset = "0x85535F0", VA = "0x1885545F0", Slot = "10")]
	protected override bool LLGKNPJOACF(string JMJJABEKOFI, [Out] ushort IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8554690", Offset = "0x8553690", VA = "0x188554690")]
	public MNLKGGGEIGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class OOPKJNAKGEK : LHFIDOIGCLG<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8554D60", Offset = "0x8553D60", VA = "0x188554D60", Slot = "9")]
	public override string FBGBLPHHDGN(int JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8554DC0", Offset = "0x8553DC0", VA = "0x188554DC0", Slot = "10")]
	protected override bool LLGKNPJOACF(string JMJJABEKOFI, [Out] int IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8554E50", Offset = "0x8553E50", VA = "0x188554E50")]
	public OOPKJNAKGEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class BOKPAAFENCA : LHFIDOIGCLG<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8553780", Offset = "0x8552780", VA = "0x188553780", Slot = "9")]
	public override string FBGBLPHHDGN(uint JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x85537E0", Offset = "0x85527E0", VA = "0x1885537E0", Slot = "10")]
	protected override bool LLGKNPJOACF(string JMJJABEKOFI, [Out] uint IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8553870", Offset = "0x8552870", VA = "0x188553870")]
	public BOKPAAFENCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class GLNFCHPLNCH : LHFIDOIGCLG<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8554140", Offset = "0x8553140", VA = "0x188554140", Slot = "9")]
	public override string FBGBLPHHDGN(long JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x85541A0", Offset = "0x85531A0", VA = "0x1885541A0", Slot = "10")]
	protected override bool LLGKNPJOACF(string JMJJABEKOFI, [Out] long IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8554240", Offset = "0x8553240", VA = "0x188554240")]
	public GLNFCHPLNCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class NMOPPHDFKDG : LHFIDOIGCLG<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8554730", Offset = "0x8553730", VA = "0x188554730", Slot = "9")]
	public override string FBGBLPHHDGN(ulong JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8554790", Offset = "0x8553790", VA = "0x188554790", Slot = "10")]
	protected override bool LLGKNPJOACF(string JMJJABEKOFI, [Out] ulong IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8554830", Offset = "0x8553830", VA = "0x188554830")]
	public NMOPPHDFKDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class OBNHJNIMBPA : LHFIDOIGCLG<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8554870", Offset = "0x8553870", VA = "0x188554870", Slot = "9")]
	public override string FBGBLPHHDGN(float JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x85548E0", Offset = "0x85538E0", VA = "0x1885548E0", Slot = "10")]
	protected override bool LLGKNPJOACF(string JMJJABEKOFI, [Out] float IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8554970", Offset = "0x8553970", VA = "0x188554970")]
	public OBNHJNIMBPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MOPKJJDBCNA
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string APGMJNHGCEK(object JMJJABEKOFI);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MBNGPBEJBMI([CanBeNull] string JMJJABEKOFI, [Out] object IOALKPFEKEK);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface NENHAJLFEBJ<T> : MOPKJJDBCNA
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string FBGBLPHHDGN(T JMJJABEKOFI);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AGIMFBCEFJB([CanBeNull] string JMJJABEKOFI, [Out] T IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T CEPGLGHFBEG([CanBeNull] string JMJJABEKOFI, [Optional] T CAILINJCNIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class LHFIDOIGCLG<T> : NENHAJLFEBJ<T>, MOPKJJDBCNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type KDFPGCKKNGF;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5478440", Offset = "0x5477440", VA = "0x185478440")]
	protected LHFIDOIGCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x54776D0", Offset = "0x54766D0", VA = "0x1854776D0")]
	private T CBFHOHLCOGN(object PGIOEBKALDP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string FBGBLPHHDGN(T JMJJABEKOFI);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5477480", Offset = "0x5476480", VA = "0x185477480", Slot = "7")]
	public string APGMJNHGCEK(object JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x54772A0", Offset = "0x54762A0", VA = "0x1854772A0", Slot = "5")]
	public bool AGIMFBCEFJB(string JMJJABEKOFI, [Out] T IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool LLGKNPJOACF([NotNull] string JMJJABEKOFI, [Out] T IOALKPFEKEK);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5478290", Offset = "0x5477290", VA = "0x185478290", Slot = "8")]
	private bool LGIPOOKEINC(string JMJJABEKOFI, [Out] object IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5477B90", Offset = "0x5476B90", VA = "0x185477B90", Slot = "6")]
	public T CEPGLGHFBEG(string JMJJABEKOFI, [Optional] T CAILINJCNIJ)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class LDGPBGCEDCC<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static NENHAJLFEBJ<T> HPFHFAKCNGM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4D70210", Offset = "0x4D6F210", VA = "0x184D70210")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x42BE9E0", Offset = "0x42BD9E0", VA = "0x1842BE9E0")]
	public static NENHAJLFEBJ<TSerialized> BDNABHCKIMA<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5457BF0", Offset = "0x5456BF0", VA = "0x185457BF0")]
	public static MOPKJJDBCNA BDNABHCKIMA(Type HLAEFHJOFPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x546C210", Offset = "0x546B210", VA = "0x18546C210")]
	private static MOPKJJDBCNA NDMMELKBHOA(Type JNHLMOEAJGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x545FD20", Offset = "0x545ED20", VA = "0x18545FD20")]
	private static MOPKJJDBCNA IKDDBOBPOJC(Type JNHLMOEAJGN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class KKFDANDPAPN<TCollection> : HEBIJPKJFEO<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class NOCKNAHCAPP : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private string <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private string input;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public string <>3__input;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public KKFDANDPAPN<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private AJGBDJDFKOB<StringBuilder> <_>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private StringBuilder <partBuilder>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private bool <insideQuotes>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private int <i>5__5;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		string IEnumerator<string>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA5F390", Offset = "0xA5E390", VA = "0x180A5F390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xF97DB0", Offset = "0xF96DB0", VA = "0x180F97DB0")]
		[DebuggerHidden]
		public NOCKNAHCAPP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4E1A8B0", Offset = "0x4E198B0", VA = "0x184E1A8B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x579D4C0", Offset = "0x579C4C0", VA = "0x18579D4C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x579D470", Offset = "0x579C470", VA = "0x18579D470")]
		private void FEADENMJGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x579D9D0", Offset = "0x579C9D0", VA = "0x18579D9D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x579D910", Offset = "0x579C910", VA = "0x18579D910", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5278C00", Offset = "0x5277C00", VA = "0x185278C00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool OPKPPKNLHOJ;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x53CAB10", Offset = "0x53C9B10", VA = "0x1853CAB10")]
	protected KKFDANDPAPN(bool OPKPPKNLHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x53CA820", Offset = "0x53C9820", VA = "0x1853CA820", Slot = "9")]
	public override string FBGBLPHHDGN(TCollection JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x53CAA60", Offset = "0x53C9A60", VA = "0x1853CAA60", Slot = "12")]
	[IteratorStateMachine(typeof(KKFDANDPAPN<>.NOCKNAHCAPP))]
	internal override IEnumerable<string> LHABHOBONIM(string JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x53CA7A0", Offset = "0x53C97A0", VA = "0x1853CA7A0")]
	[CompilerGenerated]
	internal static string DLPBPOEEPHM(StringBuilder CEEJOHHKIKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OFDBFCAKGIH : KKFDANDPAPN<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8554A40", Offset = "0x8553A40", VA = "0x188554A40")]
	[Preserve]
	public OFDBFCAKGIH(bool OPKPPKNLHOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x85549B0", Offset = "0x85539B0", VA = "0x1885549B0", Slot = "11")]
	protected override List<string> JIJOGLPJFGI(IEnumerable<string> LLJAAOFGKGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class KGJFOEPPJBC : KKFDANDPAPN<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8554450", Offset = "0x8553450", VA = "0x188554450")]
	[Preserve]
	public KGJFOEPPJBC(bool OPKPPKNLHOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x85543F0", Offset = "0x85533F0", VA = "0x1885543F0", Slot = "11")]
	protected override string[] JIJOGLPJFGI(IEnumerable<string> LLJAAOFGKGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class NLMAKNEMPFD : LHFIDOIGCLG<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xAC9D70", Offset = "0xAC8D70", VA = "0x180AC9D70", Slot = "9")]
	public override string FBGBLPHHDGN(string JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x85546D0", Offset = "0x85536D0", VA = "0x1885546D0", Slot = "10")]
	protected override bool LLGKNPJOACF(string JMJJABEKOFI, [Out] string IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x85546F0", Offset = "0x85536F0", VA = "0x1885546F0")]
	public NLMAKNEMPFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OOLOHMDALLK : LHFIDOIGCLG<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x8554A90", Offset = "0x8553A90", VA = "0x188554A90", Slot = "9")]
	public override string FBGBLPHHDGN(TimeSpan JMJJABEKOFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8554BB0", Offset = "0x8553BB0", VA = "0x188554BB0", Slot = "10")]
	protected override bool LLGKNPJOACF(string JMJJABEKOFI, [Out] TimeSpan IOALKPFEKEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8554D20", Offset = "0x8553D20", VA = "0x188554D20")]
	public OOLOHMDALLK()
	{
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
