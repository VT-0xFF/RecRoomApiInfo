using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class CJHCPIKAEMF : NNIBNKKKMAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string ALOECAPICDF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x742FF20", Offset = "0x742F120", VA = "0x18742FF20")]
	public CJHCPIKAEMF(string KIBMINNLBKK, string ALOECAPICDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[AttributeUsage(AttributeTargets.Field, Inherited = true)]
public class KNKKBCKKHIJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly string PHNCJGJHIHE;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x74301D0", Offset = "0x742F3D0", VA = "0x1874301D0")]
	public KNKKBCKKHIJ(string PHNCJGJHIHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum ADOEJJMOABO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Self,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Parent,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	Children,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	SelfAndParent,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	SelfAndChildren,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	NestedParent
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KPPBIEPJJJL : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7430040", Offset = "0x742F240", VA = "0x187430040")]
	public KPPBIEPJJJL(ADOEJJMOABO NNILCBOLNDI = ADOEJJMOABO.Self, bool ACDEINPDBAN = false, bool JNFEDOPONMJ = false, bool MLPCJFMLFJH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PLLFEACGGPF : KPPBIEPJJJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly Type GOGDPOCBMFH;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x74303A0", Offset = "0x742F5A0", VA = "0x1874303A0")]
	public PLLFEACGGPF(Type CLBLFKMHGNC, ADOEJJMOABO NNILCBOLNDI = ADOEJJMOABO.Self, bool ACDEINPDBAN = false, bool JNFEDOPONMJ = false, bool MLPCJFMLFJH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class CLMHABBIPJG : KPPBIEPJJJL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7430040", Offset = "0x742F240", VA = "0x187430040")]
	public CLMHABBIPJG(ADOEJJMOABO NNILCBOLNDI = ADOEJJMOABO.Self, bool ACDEINPDBAN = false, bool JNFEDOPONMJ = false, bool MLPCJFMLFJH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
public class ONIBCPPAPEF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum FMADGPLMOJG
	{
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		Info,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		Error
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly string ELEFLNJJFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly FMADGPLMOJG NNILCBOLNDI;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7430360", Offset = "0x742F560", VA = "0x187430360")]
	public ONIBCPPAPEF(string ELEFLNJJFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68E72C0", Offset = "0x68E64C0", VA = "0x1868E72C0")]
	public ONIBCPPAPEF(string ELEFLNJJFJC, FMADGPLMOJG NNILCBOLNDI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class NNIBNKKKMAE : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly string KIBMINNLBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly bool KHKEPGADKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public readonly object[] ONDBNNLPOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public bool ONDJBIMHONA;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7430260", Offset = "0x742F460", VA = "0x187430260")]
	public NNIBNKKKMAE(string KIBMINNLBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x74300F0", Offset = "0x742F2F0", VA = "0x1874300F0")]
	public NNIBNKKKMAE(string KIBMINNLBKK, object LFPGBMDFDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7430090", Offset = "0x742F290", VA = "0x187430090")]
	public NNIBNKKKMAE(string KIBMINNLBKK, params object[] ONDBNNLPOBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class JPJPIMAEHLM : NNIBNKKKMAE
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x74300F0", Offset = "0x742F2F0", VA = "0x1874300F0")]
	public JPJPIMAEHLM(string KIBMINNLBKK, object LFPGBMDFDAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7430090", Offset = "0x742F290", VA = "0x187430090")]
	public JPJPIMAEHLM(string KIBMINNLBKK, params object[] ONDBNNLPOBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class MKOMPJEGDLM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public readonly bool INJMCNNDCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public readonly string KLBPCECMPBA;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7430210", Offset = "0x742F410", VA = "0x187430210")]
	public MKOMPJEGDLM(string GHFJCMNBFBH, bool CMDIJLDEAPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BPKILGKOFLO : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1E79E60", Offset = "0x1E79060", VA = "0x181E79E60")]
	public BPKILGKOFLO()
	{
	}
}
namespace RecRoom.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ReadOnlyFieldAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1E79E60", Offset = "0x1E79060", VA = "0x181E79E60")]
		public ReadOnlyFieldAttribute()
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
