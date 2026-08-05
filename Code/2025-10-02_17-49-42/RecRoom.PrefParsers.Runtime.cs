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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KPOIHNNDGDI : KFLMFFFNCPM<bool>
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x88DC330", Offset = "0x88DAD30", VA = "0x1888DC330", Slot = "9")]
	public override string GCGCKFHBJPB(bool GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x88DC380", Offset = "0x88DAD80", VA = "0x1888DC380", Slot = "10")]
	protected override bool LENGHMMDCBN(string GHANLDMHBLD, [Out] bool KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x88DC3E0", Offset = "0x88DADE0", VA = "0x1888DC3E0")]
	public KPOIHNNDGDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
internal class AFANDCHJNMK : KFLMFFFNCPM<DateTime>
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x88DB050", Offset = "0x88D9A50", VA = "0x1888DB050", Slot = "9")]
	public override string GCGCKFHBJPB(DateTime GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x88DB0E0", Offset = "0x88D9AE0", VA = "0x1888DB0E0", Slot = "10")]
	protected override bool LENGHMMDCBN(string GHANLDMHBLD, [Out] DateTime KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x88DB180", Offset = "0x88D9B80", VA = "0x1888DB180")]
	public AFANDCHJNMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MCKFPKNFGCF<TEnum> : KFLMFFFNCPM<TEnum> where TEnum : struct, Enum
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly Type LIPDCJPBGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly bool FOHDHMGLAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly TEnum[] FDOLNIMJMJM;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x592F270", Offset = "0x592DC70", VA = "0x18592F270")]
	[Preserve]
	public MCKFPKNFGCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x592EEA0", Offset = "0x592D8A0", VA = "0x18592EEA0", Slot = "9")]
	public override string GCGCKFHBJPB(TEnum GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x592F0A0", Offset = "0x592DAA0", VA = "0x18592F0A0", Slot = "10")]
	protected override bool LENGHMMDCBN(string GHANLDMHBLD, [Out] TEnum KMAFNKGMDCF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CHMAELCDFDN<TEnum> : KFLMFFFNCPM<TEnum> where TEnum : Enum
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Type LIPDCJPBGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly GJCAHOILHLE AKAMLKCBHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly bool FOHDHMGLAAF;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6CE2540", Offset = "0x6CE0F40", VA = "0x186CE2540")]
	[Preserve]
	public CHMAELCDFDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6CE1E80", Offset = "0x6CE0880", VA = "0x186CE1E80", Slot = "9")]
	public override string GCGCKFHBJPB(TEnum GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6CE22E0", Offset = "0x6CE0CE0", VA = "0x186CE22E0", Slot = "10")]
	protected override bool LENGHMMDCBN(string GHANLDMHBLD, [Out] TEnum KMAFNKGMDCF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal static class ENHNEONHDBC
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly Dictionary<Type, GJCAHOILHLE> DGCFDMGAHEN;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x88DB700", Offset = "0x88DA100", VA = "0x1888DB700")]
	public static GJCAHOILHLE CDPDOLDFPGE(Type PBNJNJENDFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class INCODBLLEJM<T> : KFLMFFFNCPM<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3BCFF50", Offset = "0x3BCE950", VA = "0x183BCFF50", Slot = "9")]
	public override string GCGCKFHBJPB(T GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x52F5A40", Offset = "0x52F4440", VA = "0x1852F5A40", Slot = "10")]
	protected override bool LENGHMMDCBN(string GHANLDMHBLD, [Out] T KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x4AEC4E0", Offset = "0x4AEAEE0", VA = "0x184AEC4E0")]
	public INCODBLLEJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class OAMCILIIFNH<TCollection, T> : KFLMFFFNCPM<TCollection> where TCollection : IEnumerable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly ODMLNBEIIKD<T> BEGPONOMIIO;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5B961F0", Offset = "0x5B94BF0", VA = "0x185B961F0")]
	protected OAMCILIIFNH(ODMLNBEIIKD<T> BEGPONOMIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5B92870", Offset = "0x5B91270", VA = "0x185B92870", Slot = "9")]
	public override string GCGCKFHBJPB(TCollection GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5B93EC0", Offset = "0x5B928C0", VA = "0x185B93EC0", Slot = "10")]
	protected override bool LENGHMMDCBN(string GHANLDMHBLD, [Out] TCollection KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract TCollection ENEFJNFHAIN(IEnumerable<T> EDNHDPIMANI);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5B925A0", Offset = "0x5B90FA0", VA = "0x185B925A0", Slot = "12")]
	internal virtual IEnumerable<string> ELIJLDAOHAF(string GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5B96090", Offset = "0x5B94A90", VA = "0x185B96090")]
	[CompilerGenerated]
	private string PPMCOEOLIKL(T FEBGNHCBECK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class NDJBHIFMIHK<T> : OAMCILIIFNH<T[], T>
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x52FB7B0", Offset = "0x52FA1B0", VA = "0x1852FB7B0")]
	[Preserve]
	public NDJBHIFMIHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4B11270", Offset = "0x4B0FC70", VA = "0x184B11270")]
	[Preserve]
	public NDJBHIFMIHK(ODMLNBEIIKD<T> BEGPONOMIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5A48CF0", Offset = "0x5A476F0", VA = "0x185A48CF0", Slot = "11")]
	protected override T[] ENEFJNFHAIN(IEnumerable<T> EDNHDPIMANI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BOHCJLPKMAC<T> : OAMCILIIFNH<List<T>, T>
{
	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x52FB7B0", Offset = "0x52FA1B0", VA = "0x1852FB7B0")]
	[Preserve]
	public BOHCJLPKMAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4B11270", Offset = "0x4B0FC70", VA = "0x184B11270")]
	[Preserve]
	public BOHCJLPKMAC([Optional] ODMLNBEIIKD<T> BEGPONOMIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6785160", Offset = "0x6783B60", VA = "0x186785160", Slot = "11")]
	protected override List<T> ENEFJNFHAIN(IEnumerable<T> EDNHDPIMANI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class LJNJAFAEDNM<T> : KFLMFFFNCPM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JsonSerializerSettings? APEKMPBFHOI;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x573A970", Offset = "0x5739370", VA = "0x18573A970")]
	public LJNJAFAEDNM(JsonSerializerSettings? MEPOIADFLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x573A850", Offset = "0x5739250", VA = "0x18573A850", Slot = "9")]
	public override string GCGCKFHBJPB(T GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x573A8B0", Offset = "0x57392B0", VA = "0x18573A8B0", Slot = "10")]
	protected override bool LENGHMMDCBN([NotNull] string GHANLDMHBLD, [Out] T KMAFNKGMDCF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class IGNMEFKMBFI : KFLMFFFNCPM<byte>
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x88DC060", Offset = "0x88DAA60", VA = "0x1888DC060", Slot = "9")]
	public override string GCGCKFHBJPB(byte GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x88DC0C0", Offset = "0x88DAAC0", VA = "0x1888DC0C0", Slot = "10")]
	protected override bool LENGHMMDCBN(string GHANLDMHBLD, [Out] byte KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x88DC150", Offset = "0x88DAB50", VA = "0x1888DC150")]
	public IGNMEFKMBFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class LEOMEEKODAA : KFLMFFFNCPM<short>
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x88DC500", Offset = "0x88DAF00", VA = "0x1888DC500", Slot = "9")]
	public override string GCGCKFHBJPB(short GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x88DC560", Offset = "0x88DAF60", VA = "0x1888DC560", Slot = "10")]
	protected override bool LENGHMMDCBN(string GHANLDMHBLD, [Out] short KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x88DC600", Offset = "0x88DB000", VA = "0x1888DC600")]
	public LEOMEEKODAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class ILMFPIFCOCK : KFLMFFFNCPM<ushort>
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x88DC190", Offset = "0x88DAB90", VA = "0x1888DC190", Slot = "9")]
	public override string GCGCKFHBJPB(ushort GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x88DC1F0", Offset = "0x88DABF0", VA = "0x1888DC1F0", Slot = "10")]
	protected override bool LENGHMMDCBN(string GHANLDMHBLD, [Out] ushort KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x88DC290", Offset = "0x88DAC90", VA = "0x1888DC290")]
	public ILMFPIFCOCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DDNMNJAKDDG : KFLMFFFNCPM<int>
{
	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x88DB1C0", Offset = "0x88D9BC0", VA = "0x1888DB1C0", Slot = "9")]
	public override string GCGCKFHBJPB(int GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x88DB220", Offset = "0x88D9C20", VA = "0x1888DB220", Slot = "10")]
	protected override bool LENGHMMDCBN(string GHANLDMHBLD, [Out] int KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x88DB2B0", Offset = "0x88D9CB0", VA = "0x1888DB2B0")]
	public DDNMNJAKDDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class MBGLBLMNLPB : KFLMFFFNCPM<uint>
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x88DC640", Offset = "0x88DB040", VA = "0x1888DC640", Slot = "9")]
	public override string GCGCKFHBJPB(uint GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x88DC6A0", Offset = "0x88DB0A0", VA = "0x1888DC6A0", Slot = "10")]
	protected override bool LENGHMMDCBN(string GHANLDMHBLD, [Out] uint KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x88DC730", Offset = "0x88DB130", VA = "0x1888DC730")]
	public MBGLBLMNLPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal class DOIEHPLIDGB : KFLMFFFNCPM<long>
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x88DB2F0", Offset = "0x88D9CF0", VA = "0x1888DB2F0", Slot = "9")]
	public override string GCGCKFHBJPB(long GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x88DB350", Offset = "0x88D9D50", VA = "0x1888DB350", Slot = "10")]
	protected override bool LENGHMMDCBN(string GHANLDMHBLD, [Out] long KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x88DB3F0", Offset = "0x88D9DF0", VA = "0x1888DB3F0")]
	public DOIEHPLIDGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class GIOCIHAMGFJ : KFLMFFFNCPM<ulong>
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x88DBF20", Offset = "0x88DA920", VA = "0x1888DBF20", Slot = "9")]
	public override string GCGCKFHBJPB(ulong GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x88DBF80", Offset = "0x88DA980", VA = "0x1888DBF80", Slot = "10")]
	protected override bool LENGHMMDCBN(string GHANLDMHBLD, [Out] ulong KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x88DC020", Offset = "0x88DAA20", VA = "0x1888DC020")]
	public GIOCIHAMGFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
internal class OLFEJHFBBBA : KFLMFFFNCPM<float>
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x88DC770", Offset = "0x88DB170", VA = "0x1888DC770", Slot = "9")]
	public override string GCGCKFHBJPB(float GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x88DC7E0", Offset = "0x88DB1E0", VA = "0x1888DC7E0", Slot = "10")]
	protected override bool LENGHMMDCBN(string GHANLDMHBLD, [Out] float KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x88DC870", Offset = "0x88DB270", VA = "0x1888DC870")]
	public OLFEJHFBBBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface GJCAHOILHLE
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string MLHPLBPLAJB(object GHANLDMHBLD);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DPPNAJKLFIJ([CanBeNull] string GHANLDMHBLD, [Out] object KMAFNKGMDCF);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface ODMLNBEIIKD<T> : GJCAHOILHLE
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	string GCGCKFHBJPB(T GHANLDMHBLD);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AJEKELLDDGL([CanBeNull] string GHANLDMHBLD, [Out] T KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T LCHHGNNLBDM([CanBeNull] string GHANLDMHBLD, [Optional] T KJMOBDOKFBF);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public abstract class KFLMFFFNCPM<T> : ODMLNBEIIKD<T>, GJCAHOILHLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Type PJFOAKDKEPK;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5657650", Offset = "0x5656050", VA = "0x185657650")]
	protected KFLMFFFNCPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5656A90", Offset = "0x5655490", VA = "0x185656A90")]
	private T HKJEDBEPELK(object PMNHIPACJLN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract string GCGCKFHBJPB(T GHANLDMHBLD);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5656F50", Offset = "0x5655950", VA = "0x185656F50", Slot = "7")]
	public string MLHPLBPLAJB(object GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5655F80", Offset = "0x5654980", VA = "0x185655F80", Slot = "5")]
	public bool AJEKELLDDGL(string GHANLDMHBLD, [Out] T KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool LENGHMMDCBN([NotNull] string GHANLDMHBLD, [Out] T KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5656190", Offset = "0x5654B90", VA = "0x185656190", Slot = "8")]
	private bool CGOKJMPFCHD(string GHANLDMHBLD, [Out] object KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5656C20", Offset = "0x5655620", VA = "0x185656C20", Slot = "6")]
	public T LCHHGNNLBDM(string GHANLDMHBLD, [Optional] T KJMOBDOKFBF)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class GMFFDNMLCNJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static ODMLNBEIIKD<T> IIDHIFPMCOA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4FA6300", Offset = "0x4FA4D00", VA = "0x184FA6300")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4312780", Offset = "0x4311180", VA = "0x184312780")]
	public static ODMLNBEIIKD<TSerialized> FHEKICOJOKK<TSerialized>()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5139940", Offset = "0x5138340", VA = "0x185139940")]
	public static GJCAHOILHLE FHEKICOJOKK(Type KPLAKHFNHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x514EDC0", Offset = "0x514D7C0", VA = "0x18514EDC0")]
	private static GJCAHOILHLE MENLPKCBKAG(Type BMPBOCMBNAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5142A40", Offset = "0x5141440", VA = "0x185142A40")]
	private static GJCAHOILHLE JCFLOJGGAAM(Type BMPBOCMBNAG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public abstract class EEIEONBHBAN<TCollection> : OAMCILIIFNH<TCollection, string> where TCollection : IEnumerable<string>
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class PFBIMMKDFPH : IEnumerable<string>, IEnumerable, IEnumerator<string>, IEnumerator, IDisposable
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
		public EEIEONBHBAN<TCollection> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private LEIGBNDACDH<StringBuilder> <_>5__2;

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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xBE39C0", Offset = "0xBE23C0", VA = "0x180BE39C0")]
		[DebuggerHidden]
		public PFBIMMKDFPH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5083ED0", Offset = "0x50828D0", VA = "0x185083ED0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5CA2EE0", Offset = "0x5CA18E0", VA = "0x185CA2EE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5CA2E90", Offset = "0x5CA1890", VA = "0x185CA2E90")]
		private void LLDKJPCFHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5CA3410", Offset = "0x5CA1E10", VA = "0x185CA3410", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5CA3340", Offset = "0x5CA1D40", VA = "0x185CA3340", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<string> IEnumerable<string>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5550120", Offset = "0x554EB20", VA = "0x185550120", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly bool GADFFEOODOJ;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4B06DE0", Offset = "0x4B057E0", VA = "0x184B06DE0")]
	protected EEIEONBHBAN(bool GADFFEOODOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4B06B80", Offset = "0x4B05580", VA = "0x184B06B80", Slot = "9")]
	public override string GCGCKFHBJPB(TCollection GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4B06AD0", Offset = "0x4B054D0", VA = "0x184B06AD0", Slot = "12")]
	[IteratorStateMachine(typeof(EEIEONBHBAN<>.PFBIMMKDFPH))]
	internal override IEnumerable<string> ELIJLDAOHAF(string GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4B06A50", Offset = "0x4B05450", VA = "0x184B06A50")]
	[CompilerGenerated]
	internal static string AAFKMPJPCAP(StringBuilder IHAGKOOJJKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class LDKBCDFLAAA : EEIEONBHBAN<List<string>>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x88DC4B0", Offset = "0x88DAEB0", VA = "0x1888DC4B0")]
	[Preserve]
	public LDKBCDFLAAA(bool GADFFEOODOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x88DC420", Offset = "0x88DAE20", VA = "0x1888DC420", Slot = "11")]
	protected override List<string> ENEFJNFHAIN(IEnumerable<string> EDNHDPIMANI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FJBHBJLCPIH : EEIEONBHBAN<string[]>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x88DBED0", Offset = "0x88DA8D0", VA = "0x1888DBED0")]
	[Preserve]
	public FJBHBJLCPIH(bool GADFFEOODOJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x88DBE70", Offset = "0x88DA870", VA = "0x1888DBE70", Slot = "11")]
	protected override string[] ENEFJNFHAIN(IEnumerable<string> EDNHDPIMANI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
internal class KANGHFKLOLH : KFLMFFFNCPM<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xB117A0", Offset = "0xB101A0", VA = "0x180B117A0", Slot = "9")]
	public override string GCGCKFHBJPB(string GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x88DC2D0", Offset = "0x88DACD0", VA = "0x1888DC2D0", Slot = "10")]
	protected override bool LENGHMMDCBN(string GHANLDMHBLD, [Out] string KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x88DC2F0", Offset = "0x88DACF0", VA = "0x1888DC2F0")]
	public KANGHFKLOLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class ECHEOJLFPGN : KFLMFFFNCPM<TimeSpan>
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x88DB430", Offset = "0x88D9E30", VA = "0x1888DB430", Slot = "9")]
	public override string GCGCKFHBJPB(TimeSpan GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x88DB550", Offset = "0x88D9F50", VA = "0x1888DB550", Slot = "10")]
	protected override bool LENGHMMDCBN(string GHANLDMHBLD, [Out] TimeSpan KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x88DB6C0", Offset = "0x88DA0C0", VA = "0x1888DB6C0")]
	public ECHEOJLFPGN()
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
