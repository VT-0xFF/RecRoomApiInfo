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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BIDOJNOKBPF : JKEJPMNNMJN<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x81967E0", Offset = "0x81953E0", VA = "0x1881967E0", Slot = "9")]
	public override string BLPDEIDOFHH(bool OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8196830", Offset = "0x8195430", VA = "0x188196830", Slot = "10")]
	protected override bool INMLGJKCEDG(string OLMHJMNEENP, [Out] bool OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8196890", Offset = "0x8195490", VA = "0x188196890")]
	public BIDOJNOKBPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class BINNLACOJPK : JKEJPMNNMJN<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x81968D0", Offset = "0x81954D0", VA = "0x1881968D0", Slot = "9")]
	public override string BLPDEIDOFHH(DateTime OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x8196960", Offset = "0x8195560", VA = "0x188196960", Slot = "10")]
	protected override bool INMLGJKCEDG(string OLMHJMNEENP, [Out] DateTime OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8196A00", Offset = "0x8195600", VA = "0x188196A00")]
	public BINNLACOJPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CHMBOBBCJEP<TEnum> : JKEJPMNNMJN<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type MJLAGNNHJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool PBKBFBILAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] AIPJHMCGMIB;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6978260", Offset = "0x6976E60", VA = "0x186978260")]
	[Preserve]
	public CHMBOBBCJEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6977EC0", Offset = "0x6976AC0", VA = "0x186977EC0", Slot = "9")]
	public override string BLPDEIDOFHH(TEnum OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69780B0", Offset = "0x6976CB0", VA = "0x1869780B0", Slot = "10")]
	protected override bool INMLGJKCEDG(string OLMHJMNEENP, [Out] TEnum OOHGFGHCOAJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class BIENDBDCGPN<TEnum> : JKEJPMNNMJN<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type MJLAGNNHJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly IBJOCFOOGDB DADAGFGFKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool PBKBFBILAJO;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x64739E0", Offset = "0x64725E0", VA = "0x1864739E0")]
	[Preserve]
	public BIENDBDCGPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x64733E0", Offset = "0x6471FE0", VA = "0x1864733E0", Slot = "9")]
	public override string BLPDEIDOFHH(TEnum OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x64734D0", Offset = "0x64720D0", VA = "0x1864734D0", Slot = "10")]
	protected override bool INMLGJKCEDG(string OLMHJMNEENP, [Out] TEnum OOHGFGHCOAJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class MDJNABJINNI
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, IBJOCFOOGDB> KIBCMPHOEHI;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8196F70", Offset = "0x8195B70", VA = "0x188196F70")]
	public static IBJOCFOOGDB DMCOMMLICHH(Type BJALDCPGMPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class CIPHKAELJED<T> : JKEJPMNNMJN<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3C76C80", Offset = "0x3C75880", VA = "0x183C76C80", Slot = "9")]
	public override string BLPDEIDOFHH(T OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6984F60", Offset = "0x6983B60", VA = "0x186984F60", Slot = "10")]
	protected override bool INMLGJKCEDG(string OLMHJMNEENP, [Out] T OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4703E20", Offset = "0x4702A20", VA = "0x184703E20")]
	public CIPHKAELJED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class HKFBOJFHCOP<TCollection, T> : JKEJPMNNMJN<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly POMHBPLMBPJ<T> MMKFFEKFFGC;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4DB3B00", Offset = "0x4DB2700", VA = "0x184DB3B00")]
	protected HKFBOJFHCOP(POMHBPLMBPJ<T> MMKFFEKFFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4DB07A0", Offset = "0x4DAF3A0", VA = "0x184DB07A0", Slot = "9")]
	public override string BLPDEIDOFHH(TCollection OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4DB2FD0", Offset = "0x4DB1BD0", VA = "0x184DB2FD0", Slot = "10")]
	protected override bool INMLGJKCEDG(string OLMHJMNEENP, [Out] TCollection OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection JHJABDFINON(IEnumerable<T> GFOANALCKOM);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4DB0B20", Offset = "0x4DAF720", VA = "0x184DB0B20", Slot = "12")]
	internal virtual IEnumerable<string> COKHFCMADFF(string OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4DB37D0", Offset = "0x4DB23D0", VA = "0x184DB37D0")]
	[CompilerGenerated]
	private string NJBIDJPKCJA(T GCKEIIMJEBO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class NBHKOAJCFIK<T> : HKFBOJFHCOP<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x42CB870", Offset = "0x42CA470", VA = "0x1842CB870")]
	[Preserve]
	public NBHKOAJCFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4738D90", Offset = "0x4737990", VA = "0x184738D90")]
	[Preserve]
	public NBHKOAJCFIK(POMHBPLMBPJ<T> MMKFFEKFFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5518880", Offset = "0x5517480", VA = "0x185518880", Slot = "11")]
	protected override T[] JHJABDFINON(IEnumerable<T> GFOANALCKOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KCGFPJOGEOH<T> : HKFBOJFHCOP<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x42CB870", Offset = "0x42CA470", VA = "0x1842CB870")]
	[Preserve]
	public KCGFPJOGEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4738D90", Offset = "0x4737990", VA = "0x184738D90")]
	[Preserve]
	public KCGFPJOGEOH([Optional] POMHBPLMBPJ<T> MMKFFEKFFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x51CD8F0", Offset = "0x51CC4F0", VA = "0x1851CD8F0", Slot = "11")]
	protected override List<T> JHJABDFINON(IEnumerable<T> GFOANALCKOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class HLABNGKDFNE<T> : JKEJPMNNMJN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? NLCBHCFICCA;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4DB49E0", Offset = "0x4DB35E0", VA = "0x184DB49E0")]
	public HLABNGKDFNE(JsonSerializerSettings? MABGILGKHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4DB48C0", Offset = "0x4DB34C0", VA = "0x184DB48C0", Slot = "9")]
	public override string BLPDEIDOFHH(T OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4DB4920", Offset = "0x4DB3520", VA = "0x184DB4920", Slot = "10")]
	protected override bool INMLGJKCEDG([NotNull] string OLMHJMNEENP, [Out] T OOHGFGHCOAJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class OGCDFKPFEEH : JKEJPMNNMJN<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x81977E0", Offset = "0x81963E0", VA = "0x1881977E0", Slot = "9")]
	public override string BLPDEIDOFHH(byte OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8197840", Offset = "0x8196440", VA = "0x188197840", Slot = "10")]
	protected override bool INMLGJKCEDG(string OLMHJMNEENP, [Out] byte OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x81978D0", Offset = "0x81964D0", VA = "0x1881978D0")]
	public OGCDFKPFEEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class MEGBKEFFJNH : JKEJPMNNMJN<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x81976A0", Offset = "0x81962A0", VA = "0x1881976A0", Slot = "9")]
	public override string BLPDEIDOFHH(short OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8197700", Offset = "0x8196300", VA = "0x188197700", Slot = "10")]
	protected override bool INMLGJKCEDG(string OLMHJMNEENP, [Out] short OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x81977A0", Offset = "0x81963A0", VA = "0x1881977A0")]
	public MEGBKEFFJNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class AMEBIPMOCGP : JKEJPMNNMJN<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8196370", Offset = "0x8194F70", VA = "0x188196370", Slot = "9")]
	public override string BLPDEIDOFHH(ushort OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x81963D0", Offset = "0x8194FD0", VA = "0x1881963D0", Slot = "10")]
	protected override bool INMLGJKCEDG(string OLMHJMNEENP, [Out] ushort OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8196470", Offset = "0x8195070", VA = "0x188196470")]
	public AMEBIPMOCGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FCDBNMJGAMC : JKEJPMNNMJN<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8196B70", Offset = "0x8195770", VA = "0x188196B70", Slot = "9")]
	public override string BLPDEIDOFHH(int OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x8196BD0", Offset = "0x81957D0", VA = "0x188196BD0", Slot = "10")]
	protected override bool INMLGJKCEDG(string OLMHJMNEENP, [Out] int OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8196C60", Offset = "0x8195860", VA = "0x188196C60")]
	public FCDBNMJGAMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class DIHODFMGLEG : JKEJPMNNMJN<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8196A40", Offset = "0x8195640", VA = "0x188196A40", Slot = "9")]
	public override string BLPDEIDOFHH(uint OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8196AA0", Offset = "0x81956A0", VA = "0x188196AA0", Slot = "10")]
	protected override bool INMLGJKCEDG(string OLMHJMNEENP, [Out] uint OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8196B30", Offset = "0x8195730", VA = "0x188196B30")]
	public DIHODFMGLEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class IGNFOKOLOCG : JKEJPMNNMJN<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x8196D80", Offset = "0x8195980", VA = "0x188196D80", Slot = "9")]
	public override string BLPDEIDOFHH(long OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x8196DE0", Offset = "0x81959E0", VA = "0x188196DE0", Slot = "10")]
	protected override bool INMLGJKCEDG(string OLMHJMNEENP, [Out] long OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8196E80", Offset = "0x8195A80", VA = "0x188196E80")]
	public IGNFOKOLOCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class PKLNGAHANPP : JKEJPMNNMJN<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x8197A50", Offset = "0x8196650", VA = "0x188197A50", Slot = "9")]
	public override string BLPDEIDOFHH(ulong OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x8197AB0", Offset = "0x81966B0", VA = "0x188197AB0", Slot = "10")]
	protected override bool INMLGJKCEDG(string OLMHJMNEENP, [Out] ulong OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x8197B50", Offset = "0x8196750", VA = "0x188197B50")]
	public PKLNGAHANPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class OLDKOCPFAIC : JKEJPMNNMJN<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x8197910", Offset = "0x8196510", VA = "0x188197910", Slot = "9")]
	public override string BLPDEIDOFHH(float OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x8197980", Offset = "0x8196580", VA = "0x188197980", Slot = "10")]
	protected override bool INMLGJKCEDG(string OLMHJMNEENP, [Out] float OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x8197A10", Offset = "0x8196610", VA = "0x188197A10")]
	public OLDKOCPFAIC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface IBJOCFOOGDB
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string JIPNCDPLDGE(object OLMHJMNEENP);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool JEBDMPDAPLI([CanBeNull] string OLMHJMNEENP, [Out] object OOHGFGHCOAJ);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface POMHBPLMBPJ<T> : IBJOCFOOGDB
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string BLPDEIDOFHH(T OLMHJMNEENP);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NEHHPOOOFJA([CanBeNull] string OLMHJMNEENP, [Out] T OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T DKFCODJHKKJ([CanBeNull] string OLMHJMNEENP, [Optional] T IPOLOHBNCGD);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class JKEJPMNNMJN<T> : POMHBPLMBPJ<T>, IBJOCFOOGDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type IGGOPJEBGNC;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x51024D0", Offset = "0x51010D0", VA = "0x1851024D0")]
	protected JKEJPMNNMJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5101380", Offset = "0x50FFF80", VA = "0x185101380")]
	private T FDFBLLMDGFO(object KDKJDFFGNJJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string BLPDEIDOFHH(T OLMHJMNEENP);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x51017D0", Offset = "0x51003D0", VA = "0x1851017D0", Slot = "7")]
	public string JIPNCDPLDGE(object OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5101F80", Offset = "0x5100B80", VA = "0x185101F80", Slot = "5")]
	public bool NEHHPOOOFJA(string OLMHJMNEENP, [Out] T OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool INMLGJKCEDG([NotNull] string OLMHJMNEENP, [Out] T OOHGFGHCOAJ);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5101BA0", Offset = "0x51007A0", VA = "0x185101BA0", Slot = "8")]
	private bool LKEHCMIACCJ(string OLMHJMNEENP, [Out] object OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5100F00", Offset = "0x50FFB00", VA = "0x185100F00", Slot = "6")]
	public T DKFCODJHKKJ(string OLMHJMNEENP, [Optional] T IPOLOHBNCGD)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class DJMMHIFCCHJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static POMHBPLMBPJ<T> DIACPKGMELN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x42A8940", Offset = "0x42A7540", VA = "0x1842A8940")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3C1FEC0", Offset = "0x3C1EAC0", VA = "0x183C1FEC0")]
	public static POMHBPLMBPJ<TSerialized> CIPDOCAEKGI<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x42A9400", Offset = "0x42A8000", VA = "0x1842A9400")]
	public static IBJOCFOOGDB CIPDOCAEKGI(Type GKCOMPNHHOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x42AA6B0", Offset = "0x42A92B0", VA = "0x1842AA6B0")]
	private static IBJOCFOOGDB KKAAEGJDFOF(Type PBLHCAGNECO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x42AB7B0", Offset = "0x42AA3B0", VA = "0x1842AB7B0")]
	private static IBJOCFOOGDB LHKLJEPBFBN(Type PBLHCAGNECO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class EAAJLFIHJOA<TCollection> : HKFBOJFHCOP<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class CIJLMBFFHFM : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
		public EAAJLFIHJOA<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private ECLCBBHPFMF<StringBuilder> <_>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xF21C60", Offset = "0xF20860", VA = "0x180F21C60")]
		[DebuggerHidden]
		public CIJLMBFFHFM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4C9FA30", Offset = "0x4C9E630", VA = "0x184C9FA30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6979F00", Offset = "0x6978B00", VA = "0x186979F00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6979EB0", Offset = "0x6978AB0", VA = "0x186979EB0")]
		private void HOIHHFKDFKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x697A410", Offset = "0x6979010", VA = "0x18697A410", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x697A350", Offset = "0x6978F50", VA = "0x18697A350", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x51AE7B0", Offset = "0x51AD3B0", VA = "0x1851AE7B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool DAOGFMHAOGC;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x47093C0", Offset = "0x4707FC0", VA = "0x1847093C0")]
	protected EAAJLFIHJOA(bool DAOGFMHAOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x47090E0", Offset = "0x4707CE0", VA = "0x1847090E0", Slot = "9")]
	public override string BLPDEIDOFHH(TCollection OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4709310", Offset = "0x4707F10", VA = "0x184709310", Slot = "12")]
	[IteratorStateMachine(typeof(EAAJLFIHJOA<>.CIJLMBFFHFM))]
	internal override IEnumerable<string> COKHFCMADFF(string OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4709060", Offset = "0x4707C60", VA = "0x184709060")]
	[CompilerGenerated]
	internal static string AHIFEPPMCMD(StringBuilder APEIOHLGPKL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FCPNPFMCDBN : EAAJLFIHJOA<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8196D30", Offset = "0x8195930", VA = "0x188196D30")]
	[Preserve]
	public FCPNPFMCDBN(bool DAOGFMHAOGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8196CA0", Offset = "0x81958A0", VA = "0x188196CA0", Slot = "11")]
	protected override List<string> JHJABDFINON(IEnumerable<string> GFOANALCKOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JPOKJBJJHHE : EAAJLFIHJOA<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8196F20", Offset = "0x8195B20", VA = "0x188196F20")]
	[Preserve]
	public JPOKJBJJHHE(bool DAOGFMHAOGC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8196EC0", Offset = "0x8195AC0", VA = "0x188196EC0", Slot = "11")]
	protected override string[] JHJABDFINON(IEnumerable<string> GFOANALCKOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class BFBLJNNPCLB : JKEJPMNNMJN<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA84210", Offset = "0xA82E10", VA = "0x180A84210", Slot = "9")]
	public override string BLPDEIDOFHH(string OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8196780", Offset = "0x8195380", VA = "0x188196780", Slot = "10")]
	protected override bool INMLGJKCEDG(string OLMHJMNEENP, [Out] string OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x81967A0", Offset = "0x81953A0", VA = "0x1881967A0")]
	public BFBLJNNPCLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BBJIJCELJJE : JKEJPMNNMJN<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x81964B0", Offset = "0x81950B0", VA = "0x1881964B0", Slot = "9")]
	public override string BLPDEIDOFHH(TimeSpan OLMHJMNEENP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x81965D0", Offset = "0x81951D0", VA = "0x1881965D0", Slot = "10")]
	protected override bool INMLGJKCEDG(string OLMHJMNEENP, [Out] TimeSpan OOHGFGHCOAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8196740", Offset = "0x8195340", VA = "0x188196740")]
	public BBJIJCELJJE()
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
